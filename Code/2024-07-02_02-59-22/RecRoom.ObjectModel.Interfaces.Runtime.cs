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
	public class LogRegistrationIndex : DAMGOKPKJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6A79290", Offset = "0x6A78290", VA = "0x186A79290", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MCIPAOHKLNA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A79600", Offset = "0x6A78600", VA = "0x186A79600")]
	public static void MHGFAICAODL(this Rigidbody EDIKCMCJLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A79790", Offset = "0x6A78790", VA = "0x186A79790")]
	public static void MHGFAICAODL(this Rigidbody EDIKCMCJLAO, Vector3 KHPNNFOEIIF, Quaternion MALDBKLIIFF, Vector3 AOMEEGDOBGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct ANDJNBHCECG : IReadOnlyList<AAEGPHPJNLD>, IEnumerable<AAEGPHPJNLD>, IEnumerable, IReadOnlyCollection<AAEGPHPJNLD>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct BJEFNDFHHBA : IEnumerator<AAEGPHPJNLD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly KLHDIAOOCPK NHPJHMKDNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator JPEENEJPGDF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AAEGPHPJNLD NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6A6DFF0", Offset = "0x6A6CFF0", VA = "0x186A6DFF0", Slot = "4")]
			get
			{
				return default(AAEGPHPJNLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6A6DF70", Offset = "0x6A6CF70", VA = "0x186A6DF70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x42BA130", Offset = "0x42B9130", VA = "0x1842BA130")]
		public BJEFNDFHHBA(KLHDIAOOCPK NHPJHMKDNHF, NativeArray<LocalId>.Enumerator JPEENEJPGDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DEB0", Offset = "0x6A6CEB0", VA = "0x186A6DEB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DEF0", Offset = "0x6A6CEF0", VA = "0x186A6DEF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DF30", Offset = "0x6A6CF30", VA = "0x186A6DF30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly KLHDIAOOCPK NHPJHMKDNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> HDPAMFPMPBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AAEGPHPJNLD PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D930", Offset = "0x6A6C930", VA = "0x186A6D930", Slot = "4")]
		get
		{
			return default(AAEGPHPJNLD);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D3C0", Offset = "0x6A6C3C0", VA = "0x186A6D3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int PANGCDDKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x8641A0", VA = "0x1808651A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x8641A0", VA = "0x1808651A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NEIPGPKBIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D4C0", Offset = "0x6A6C4C0", VA = "0x186A6D4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> LPHECEMCDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2562D00", Offset = "0x2561D00", VA = "0x182562D00")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> CBIJBOPANID
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D360", Offset = "0x6A6C360", VA = "0x186A6D360")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D6E0", Offset = "0x6A6C6E0", VA = "0x186A6D6E0")]
	public ANDJNBHCECG(int NAFKLJDAKHD, KLHDIAOOCPK NHPJHMKDNHF, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x42B9B20", Offset = "0x42B8B20", VA = "0x1842B9B20")]
	public ANDJNBHCECG(KLHDIAOOCPK NHPJHMKDNHF, NativeArray<LocalId> HDPAMFPMPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D8C0", Offset = "0x6A6C8C0", VA = "0x186A6D8C0")]
	internal ANDJNBHCECG(KLHDIAOOCPK NHPJHMKDNHF, NativeArray<Entity> GOBIGKPCBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D820", Offset = "0x6A6C820", VA = "0x186A6D820")]
	public ANDJNBHCECG(KLHDIAOOCPK NHPJHMKDNHF, int DOIKAIEGGLD, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D770", Offset = "0x6A6C770", VA = "0x186A6D770")]
	public ANDJNBHCECG(ANDJNBHCECG BIHAHJMDCFN, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D410", Offset = "0x6A6C410", VA = "0x186A6D410")]
	public ANDJNBHCECG IELCMBBNHEG(Allocator IDMGOAKOEDG = Allocator.Temp)
	{
		return default(ANDJNBHCECG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D320", Offset = "0x6A6C320", VA = "0x186A6D320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D290", Offset = "0x6A6C290", VA = "0x186A6D290")]
	public BJEFNDFHHBA AKHPNFMFJMK()
	{
		return default(BJEFNDFHHBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D500", Offset = "0x6A6C500", VA = "0x186A6D500", Slot = "6")]
	private IEnumerator<AAEGPHPJNLD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D5F0", Offset = "0x6A6C5F0", VA = "0x186A6D5F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct LNKEOBMBAPA : IList<AAEGPHPJNLD>, ICollection<AAEGPHPJNLD>, IEnumerable<AAEGPHPJNLD>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct KONOGEKOFJE : IEnumerator<AAEGPHPJNLD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly KLHDIAOOCPK NHPJHMKDNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator JPEENEJPGDF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AAEGPHPJNLD NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6A783A0", Offset = "0x6A773A0", VA = "0x186A783A0", Slot = "4")]
			get
			{
				return default(AAEGPHPJNLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6A78320", Offset = "0x6A77320", VA = "0x186A78320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42BA130", Offset = "0x42B9130", VA = "0x1842BA130")]
		public KONOGEKOFJE(KLHDIAOOCPK NHPJHMKDNHF, NativeArray<LocalId>.Enumerator JPEENEJPGDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A78260", Offset = "0x6A77260", VA = "0x186A78260", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A782A0", Offset = "0x6A772A0", VA = "0x186A782A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A782E0", Offset = "0x6A772E0", VA = "0x186A782E0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KLHDIAOOCPK NHPJHMKDNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> HDPAMFPMPBB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AAEGPHPJNLD PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A79000", Offset = "0x6A78000", VA = "0x186A79000", Slot = "4")]
		get
		{
			return default(AAEGPHPJNLD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A79080", Offset = "0x6A78080", VA = "0x186A79080", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A78B20", Offset = "0x6A77B20", VA = "0x186A78B20", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A78B20", Offset = "0x6A77B20", VA = "0x186A78B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FAOLOMOFDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A78E60", Offset = "0x6A77E60", VA = "0x186A78E60")]
	public LNKEOBMBAPA(int NAFKLJDAKHD, KLHDIAOOCPK NHPJHMKDNHF, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A78EF0", Offset = "0x6A77EF0", VA = "0x186A78EF0")]
	public LNKEOBMBAPA(KLHDIAOOCPK NHPJHMKDNHF, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A78F70", Offset = "0x6A77F70", VA = "0x186A78F70")]
	public LNKEOBMBAPA(KLHDIAOOCPK NHPJHMKDNHF, int DOIKAIEGGLD, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A785F0", Offset = "0x6A775F0", VA = "0x186A785F0")]
	public ANDJNBHCECG ABDNPIMAFKH()
	{
		return default(ANDJNBHCECG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A78780", Offset = "0x6A77780", VA = "0x186A78780", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A787C0", Offset = "0x6A777C0", VA = "0x186A787C0", Slot = "13")]
	public bool Contains(AAEGPHPJNLD OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A78850", Offset = "0x6A77850", VA = "0x186A78850", Slot = "14")]
	public void CopyTo(AAEGPHPJNLD[] GGEMIJICFPG, int MCEFCKDGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A78700", Offset = "0x6A77700", VA = "0x186A78700", Slot = "11")]
	public void Add(AAEGPHPJNLD OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A78A70", Offset = "0x6A77A70", VA = "0x186A78A70", Slot = "7")]
	public void Insert(int LLPJHIPCNFD, AAEGPHPJNLD OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A78BB0", Offset = "0x6A77BB0", VA = "0x186A78BB0", Slot = "15")]
	public bool Remove(AAEGPHPJNLD OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A789E0", Offset = "0x6A779E0", VA = "0x186A789E0", Slot = "6")]
	public int IndexOf(AAEGPHPJNLD OPNLGJFHDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A78B60", Offset = "0x6A77B60", VA = "0x186A78B60", Slot = "8")]
	public void RemoveAt(int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A789A0", Offset = "0x6A779A0", VA = "0x186A789A0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A78670", Offset = "0x6A77670", VA = "0x186A78670")]
	public KONOGEKOFJE AKHPNFMFJMK()
	{
		return default(KONOGEKOFJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A78C80", Offset = "0x6A77C80", VA = "0x186A78C80", Slot = "16")]
	private IEnumerator<AAEGPHPJNLD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A78D70", Offset = "0x6A77D70", VA = "0x186A78D70", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HDPIOIPNLMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int HKFENNOAGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> LPCOPCMIHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AAEGPHPJNLD AOFIKKPONML(AAEGPHPJNLD HDPAMFPMPBB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KFLDEODJFBN : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface HMLHEKIHJMB : JCHLCKDBCPN, KAKGBKJOLAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool MENDGOLEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	PDBNDHLFMCD GBBPJJHDCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EFBGMCLIPGK JJAMBPCFEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OGPELCDHHDO INJKEFCBJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface KAKGBKJOLAH
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool AJKIJLIKGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface HOHLDEDNBDM
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBOHFLJPMMC(bool CBAEIEAPLIH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[PBELGAHGGLA(AFHNLDKMONP.PhotonRoom)]
public interface OGDNAJFNMGN
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OBAKHCHLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGJAOIJAKPJ(bool GFLBKNDOAOE);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLHDIIMEOAH();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBLMHOEGDJF(ByteString BCFBKOPNCPH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PMGFDDLDMIK();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GCIOMOKBBLN();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KHDCJFDPKGO();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HGCPKMGIOJH();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EANBAALIONJ();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface DJDFLLKIHKD
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	HODPOPFOFDD GBBPJJHDCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	EFBGMCLIPGK JJAMBPCFEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ENNOLIDPGMP PKEICGCHPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	FINLOJKOHOO AFIHEBCDJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	HMLHEKIHJMB EFCNOPJDPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	OGDNAJFNMGN FDCFMNCGDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	NCJHBDLHOGE DCNBNJDGLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IPBFDMGMDCC JHHEOOOKLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	EHDPLJJOOFN MBNIEFPLBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PLMCDLOIJJB LODFFOAGLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	CGEDEDAHAPI BPGKKGBMEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	MKJAJFENNFP CPJNIIJNDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	GCCONOAGHML MFCGKHNOIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	MHFIPACLEJI MHMIDBMFKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GLEGENNEIHO OCKIIBBLJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HEKIBGLDOPE KNNKHELNPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ALBECIIMDNG HPJMKIIJMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ILBAJNELFOI HOCBIKBHAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	JGOPMKGAFGM GKEBNMONMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	EDCIOAKAPBB ABNKIABCKIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	KEJOCCHIHBH EDGNNEBFBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HBPIKMNCFEO MFGEDNNDLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	CEOBJBHONGG LMKDCLOABFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OBMMMOPPPNO CLIJEEPFJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	JLNFKMFDMHE MNAMDLLLJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	KLDKDIJGLOO LFPLKADEMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	PIOKFHMHEAI ECLOJLILAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	NFLPALCAONH HDDPLODHEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(HPNOHCDIFLJ))]
public readonly struct AAEGPHPJNLD : IComparable<AAEGPHPJNLD>, IEquatable<AAEGPHPJNLD>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly AAEGPHPJNLD GCMJGJIPGKE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int CHKNNFFKMHD = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int DBFFMMGCFGC = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int LBDDIOBKHNK = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int IDLKJAHOCEE = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId OJMEEMCEEJO;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HMLHEKIHJMB EFCNOPJDPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B490", Offset = "0x6A6A490", VA = "0x186A6B490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LocalId DINPKMLDLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B450", Offset = "0x6A6A450", VA = "0x186A6B450")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal OGPELCDHHDO INJKEFCBJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6AFA0", Offset = "0x6A69FA0", VA = "0x186A6AFA0")]
		get
		{
			return default(OGPELCDHHDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool EKGDBOHPAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6AFB0", Offset = "0x6A69FB0", VA = "0x186A6AFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool HGBNOAHKIND
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B2E0", Offset = "0x6A6A2E0", VA = "0x186A6B2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B620", Offset = "0x6A6A620", VA = "0x186A6B620")]
	public AAEGPHPJNLD(KLHDIAOOCPK FHHMEHBDKGF, LocalId OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
	public AAMKNBMNABE LPBHDLOAFLP()
	{
		return default(AAMKNBMNABE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AE80", Offset = "0x6A69E80", VA = "0x186A6AE80")]
	public static LocalId CPPJIHNILOM(AAEGPHPJNLD HHJBMDMCJPO)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AE40", Offset = "0x6A69E40", VA = "0x186A6AE40")]
	public static Entity CPPJIHNILOM(AAEGPHPJNLD HHJBMDMCJPO)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B330", Offset = "0x6A6A330", VA = "0x186A6B330")]
	public static bool JEKPEIKHIPM(AAEGPHPJNLD FAGKOOGCGBH, AAEGPHPJNLD HEOHCJKCOLM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B290", Offset = "0x6A6A290", VA = "0x186A6B290")]
	public static bool GJBEBFKCOKB(AAEGPHPJNLD FAGKOOGCGBH, AAEGPHPJNLD HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B4F0", Offset = "0x6A6A4F0", VA = "0x186A6B4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B100", Offset = "0x6A6A100", VA = "0x186A6B100", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AEC0", Offset = "0x6A69EC0", VA = "0x186A6AEC0", Slot = "4")]
	public int CompareTo(AAEGPHPJNLD LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "5")]
	public bool Equals(AAEGPHPJNLD LJAAPFIIPOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JMBNHKDGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A77EE0", Offset = "0x6A76EE0", VA = "0x186A77EE0")]
	public static IHGNLFDACDF IOHANIMMPCC(this AAEGPHPJNLD HBFCGFKGCAF)
	{
		return default(IHGNLFDACDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6A77F90", Offset = "0x6A76F90", VA = "0x186A77F90")]
	public static AAMKNBMNABE OCBEPNPKNBP(this AAEGPHPJNLD HBFCGFKGCAF)
	{
		return default(AAMKNBMNABE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2BAFB20", Offset = "0x2BAEB20", VA = "0x182BAFB20")]
	public static T DLIGPOADBHI<T>(this AAEGPHPJNLD HBFCGFKGCAF) where T : struct, GNMNCODNJFG
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HPNOHCDIFLJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct OGPELCDHHDO : IEquatable<OGPELCDHHDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte JNKGLDBBIBB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] PJJDBOLIJLO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static KLHDIAOOCPK LOHAECMOHAK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static HMLHEKIHJMB KIMPFCAAFOI;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static KLHDIAOOCPK[] GOECIPHPHFL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static HMLHEKIHJMB[] MNOHMLDLDHG;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> FFCLIBLDHHO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public HMLHEKIHJMB EFCNOPJDPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7C6A0", Offset = "0x6A7B6A0", VA = "0x186A7C6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KLHDIAOOCPK HEEPNCIHIIP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7BD80", Offset = "0x6A7AD80", VA = "0x186A7BD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CB00", Offset = "0x6A7BB00", VA = "0x186A7CB00")]
	static OGPELCDHHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x217F560", Offset = "0x217E560", VA = "0x18217F560")]
	internal OGPELCDHHDO(byte CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6320", Offset = "0x5BE5320", VA = "0x185BE6320", Slot = "4")]
	public bool Equals(OGPELCDHHDO LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BE60", Offset = "0x6A7AE60", VA = "0x186A7BE60", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D708A0", Offset = "0x1D6F8A0", VA = "0x181D708A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CA40", Offset = "0x6A7BA40", VA = "0x186A7CA40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C290", Offset = "0x6A7B290", VA = "0x186A7C290")]
	private static KLHDIAOOCPK GFCCLENCNBI(byte JNKGLDBBIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C3C0", Offset = "0x6A7B3C0", VA = "0x186A7C3C0")]
	private static HMLHEKIHJMB IINHJEFGAJP(byte JNKGLDBBIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BC00", Offset = "0x6A7AC00", VA = "0x186A7BC00")]
	private static object ALFPMHFOPLF(byte JNKGLDBBIBB, object[] CNNODMDOLAC, object AJMLHGDNPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C690", Offset = "0x6A7B690", VA = "0x186A7C690")]
	private static int KJMPJHMNHMC(byte JNKGLDBBIBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C470", Offset = "0x6A7B470", VA = "0x186A7C470")]
	private static int INDADLDEPLA(byte JNKGLDBBIBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C340", Offset = "0x6A7B340", VA = "0x186A7C340")]
	private static (int, int) IHOKGKLGFBI(byte JNKGLDBBIBB)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BD70", Offset = "0x6A7AD70", VA = "0x186A7BD70")]
	private static byte CFJFHHNAFLL(int HNNOPDLCPBM, int LLPJHIPCNFD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C780", Offset = "0x6A7B780", VA = "0x186A7C780")]
	internal static OGPELCDHHDO PIKNDMFIIPK(HMLHEKIHJMB DJHMCIECKEI, KLHDIAOOCPK IBCHGCDKKPG)
	{
		return default(OGPELCDHHDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C480", Offset = "0x6A7B480", VA = "0x186A7C480")]
	internal static void KAAMLDMKLFD(OGPELCDHHDO JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BF00", Offset = "0x6A7AF00", VA = "0x186A7BF00")]
	private static void FGNBMMPFDHD(int NAFKLJDAKHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface JBOJBOCHOGI
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKKNMNADCOP();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOBMIGGNOED(bool ADDACJDBPCI);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNLAMGDHLOP(GameObject INALOLPJOHI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface COAHHFJPHEB
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Guid ACCIFBDEFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AOCKKELLPHO(Guid MJCMBENGNAC, Guid MHMEMGOEJHD, Guid LNKJCCJIEAK);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Guid OKMBHHDFLHL(Guid KJEGAEAMNPF);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LJFKCPENPOP(AAEGPHPJNLD PHCKACBIGAE);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OFELCFEIALB(AAEGPHPJNLD FLFKBMMIINC, AAEGPHPJNLD HHMPHBNGMGF, [Out] Vector3 OGNOLJCMDMP, [Out] Quaternion NACDGIDELJO);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGIIKEEGONN(IBMNLBPHCNP BIIODMCLGIN, Vector3 OGNOLJCMDMP, Quaternion NACDGIDELJO);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IOPCKEHHJJH(AAEGPHPJNLD NPLACKMMPII, [Out] Vector3 FIMNADNDKOE, [Out] Quaternion KBJPNACNDLP);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EBPODBJNJFN(OKHLLIPPIGH BAPCFBDNIJC, Guid CILMEOCHKOL);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FEMLMKGAENL(Guid KJEGAEAMNPF, bool GFLBKNDOAOE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface KABIIEPADHK
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHHCEDNBMNL(ANDJNBHCECG HDPAMFPMPBB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface NCPJGINKONK
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FKHFKMDEEKA(GameObject MDOLJIGNONO, GameObject KLLOJFPPADH, int FMECGGGAFDL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface EFBGMCLIPGK
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JBOJBOCHOGI KLLAEMNOCPH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FELEIGNDMJJ HADLGNJNAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	JLFDPFMCCAO HIKCBJCONOI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	CDJBLBGIKPL ELKOBPOKPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	FAJIEOMNGAP NHOCLKFDGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	IOONHEGNBID EOFNALBPJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	OFNMLBPOMHK BJIGAFPMPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	GLPNHAHODFG LLLHJEDJHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	COIPHOIHBOF GNCBNCDOPDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AGOCOFAOMMO PFKCMFEABKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface FELEIGNDMJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string NBPHODHCMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface LDFENBDBECJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKGLKLEPGLO(Action OGLJLDNLGIJ, bool CCCLNGBMDFD);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PEKGOPHFPHF(string LCLKDNPLMED);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PNKBNFKILAG(string LCLKDNPLMED, int AJMLHGDNPEK);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JCHDDOEOFHD([Out] bool CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IGEFNMMIGBC([Out] bool CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PLOLFCMMBCC([Out] int CBAEIEAPLIH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface JLFDPFMCCAO
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string KHOHIAKDNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] FCNMGHHHGEA(IEnumerable<CCIEDDKOBBB> DGOFCABMPCN, bool DPADNBLBKLI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AMPLLKNEGGD(GameObject INALOLPJOHI, [Out] IHGNLFDACDF[] GJGNBOMHEMN);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AJAOJADDKIJ(GameObject INALOLPJOHI, [Out] int FLNMMPAKOBG, [Out] HMNDHIDLGHN HKILDBKKLEG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OKHLLIPPIGH FILIJFLKCFD(CCIEDDKOBBB BDMHFDNBPPE);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OKHLLIPPIGH FILIJFLKCFD(string MHPCMEBOPCE, IHGNLFDACDF[] KJKEGAFLFDE, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, Vector3 GNMLLHFGICG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OKHLLIPPIGH GADNFNGNFJD(string MHPCMEBOPCE, IHGNLFDACDF[] KJKEGAFLFDE, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, Vector3 GNMLLHFGICG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject DBAEPFAOPPO(string MHPCMEBOPCE);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GIEPBKLJDLH(GameObject GNJAFPJMLJM, bool GMNLPDCHGDJ);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HJLKCFCJAEH(GameObject INALOLPJOHI, bool FDHDNPDGJML, bool LCFCJIMLOGD);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PGBEGGNNHON
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E3A0", Offset = "0x6A7D3A0", VA = "0x186A7E3A0")]
	public static OKHLLIPPIGH FILIJFLKCFD(this JLFDPFMCCAO AHBNABCBLNH, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, Vector3 GNMLLHFGICG, params IHGNLFDACDF[] GJGNBOMHEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E510", Offset = "0x6A7D510", VA = "0x186A7E510")]
	public static OKHLLIPPIGH GADNFNGNFJD(this JLFDPFMCCAO AHBNABCBLNH, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, Vector3 GNMLLHFGICG, params IHGNLFDACDF[] GJGNBOMHEMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface CDJBLBGIKPL
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMDEAKOCKNB(bool GFLBKNDOAOE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface FAJIEOMNGAP
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool JLOJHJHLEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool OGPLEDGKMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KFFFOBNAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int FCIIAEANJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool JDMDPOGGIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNDPAAAMDCJ(object HJCJCIIFPJE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LKMMLDOOLCE(object HJCJCIIFPJE);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void APKNLAEFCMM(object PKMPGPJICGL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HFLLPPCKKPL(object PKMPGPJICGL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId AMGCHGBJAIH(GameObject EFDDHMOHOKH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HAKPIMNPPPO(NativeArray<ViewId> LBKLBAJPGLF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OMEBOKAJLJH(NativeArray<ViewId> HKHBJFJHNAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JNEEGEMILIO();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NKCMHGMLALE(uint LDJGNLKFNHF, ReadOnlySpan<byte> KMAJNLCEOLF, bool NLMBPDPMBNP = false);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NKCMHGMLALE(uint LDJGNLKFNHF, ReadOnlySpan<byte> KMAJNLCEOLF, ReadOnlySpan<byte> EDPDOEHIJLM, bool NLMBPDPMBNP = false);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NJLIANHOHEF(Func<int, bool, int> MMPKEJEBANJ, bool EGGJMJEGHFE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FEAMAPKFIBI(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BMNEHBNCEFJ(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint ILAFKKNBBEO(uint JNNHDMKPDLF);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class DDGPMKKHIKL
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F720", Offset = "0x6A6E720", VA = "0x186A6F720")]
	public static BEGJCEKJJAB IPMGOKNFJIP(this FAJIEOMNGAP ECFOBHKDIGL, object OEDJKICDDGA)
	{
		return default(BEGJCEKJJAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BEGJCEKJJAB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private FAJIEOMNGAP ECFOBHKDIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object OEDJKICDDGA;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DD80", Offset = "0x6A6CD80", VA = "0x186A6DD80")]
	public BEGJCEKJJAB(FAJIEOMNGAP ECFOBHKDIGL, object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DD30", Offset = "0x6A6CD30", VA = "0x186A6DD30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface IOONHEGNBID
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKIHGGOJJLL(GameObject INALOLPJOHI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface OFNMLBPOMHK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct JMJOEAOFBIK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private OFNMLBPOMHK LFGCLILLFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Task PEBIPFJADEI;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Task OPLHKNPCHBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EC0", Offset = "0x8D3EC0", VA = "0x1808D4EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6A78090", Offset = "0x6A77090", VA = "0x186A78090")]
		public JMJOEAOFBIK(OFNMLBPOMHK LFGCLILLFMM, CancellationToken DADBOHKBJNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A78040", Offset = "0x6A77040", VA = "0x186A78040", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJIANANFGFB(string NFOHONOFFAP, float DACHNPNJPDB = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NLJNGKKDENL(CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJGCIGGBBAF();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KFIGGIHFGNC
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A78240", Offset = "0x6A77240", VA = "0x186A78240")]
	public static OFNMLBPOMHK.JMJOEAOFBIK NPPAHJDEAFM(this OFNMLBPOMHK ECFOBHKDIGL, CancellationToken DADBOHKBJNO)
	{
		return default(OFNMLBPOMHK.JMJOEAOFBIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface BDIPEFNEEAH
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NAGGAFLIDOP(GameObject INALOLPJOHI);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAFIFKMCGNI(GameObject INALOLPJOHI);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ICMGNHOKELH(int AOKMKNGFNPG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object HLLDHJNLFJM(AAEGPHPJNLD OJMEEMCEEJO, GameObject INALOLPJOHI, Action<AAEGPHPJNLD, int> AHJILKLLLDE);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAAMLGPJHAK(GameObject INALOLPJOHI, object JHECGIMGHAN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface AHGDMKAFPHO
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool NJDNOICGBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate IMKMCIGGIMG(BAPODPKADOG.PFGFABFNBIC AFFFKEFAABJ, Action<BAPODPKADOG.PFGFABFNBIC> AHJILKLLLDE);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KDMPAFFBMBC(BAPODPKADOG.PFGFABFNBIC AFFFKEFAABJ, Delegate AHJILKLLLDE);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate MACJDAHOILP(BAPODPKADOG.PFGFABFNBIC AFFFKEFAABJ, Action<BAPODPKADOG.PFGFABFNBIC> KJDEDFNEJLJ);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDLJDAMGKAB(BAPODPKADOG.PFGFABFNBIC AFFFKEFAABJ, Delegate AHJILKLLLDE);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LNOIEOBPGOA(BAPODPKADOG.PFGFABFNBIC AFFFKEFAABJ);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BAPODPKADOG.PFGFABFNBIC KNJHPOEAGCB(GameObject INALOLPJOHI);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface GLPNHAHODFG
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int LDEMEFLPEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	int PIKLPAPCNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JNCNBLOGPJB(GameObject INALOLPJOHI);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMKAFJAPLNO([Out] Vector3 MOIICCIPACK);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GOPKIALEKIM();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AAEGPHPJNLD GGKPFACNAHJ(int AOKMKNGFNPG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface COIPHOIHBOF
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool OBAKHCHLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface NFBKPJCICDE
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	LBJKKAKJIAH OADJNMENDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	JACMAOMLFJJ ANGBCJNCHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMMGHAKHNGJ(Transform DNPKMJFBJBC);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MFPPBLDPBBD(Transform DNPKMJFBJBC, JJCNGLHDEFE DAOMCGDEKLF);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MMMCDNFMJMK(Transform DNPKMJFBJBC, JEPJJIBBHEG DHLLILNPCMI);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface LAEKMPOOMLH
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface AGOCOFAOMMO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PBECDIONPIN;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPOBHHIJBDB(ANDJNBHCECG JMBEAFKMNBG, bool ICMGHBPICHA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface HBKIICDMLPI
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KELOBFDLJCF();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface BFJNDJPNGFE
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HMNDHIDLGHN ALMOCIMFPHP(GameObject EFDDHMOHOKH);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJHAHOKOPGI(GameObject INALOLPJOHI, IPLIKNBCAMB IILEEHGPGCA, GLJNKOKMBJJ GGFPKNNKIJM);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IPJDLEECHOE(AAEGPHPJNLD OJMEEMCEEJO, bool AFDMDDNGOJF, float3 NEEKGIFPEKI, quaternion LPOJNFIPFDG);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GDNGPLPPNJI(AAMKNBMNABE BMDINFODMJG, AAMKNBMNABE PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGAGFAIOICC(AAMKNBMNABE BMDINFODMJG, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HEDAOLPIDCJ(ANDJNBHCECG ILBONJPLGFN);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DNCNNMNCCNA(ANDJNBHCECG NHPJHMKDNHF, NativeArray<LocalPoseData> BPBOKIKEKDE, NativeArray<float3> CAHJIMNEKEM);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DDLDKBODIBH(ANDJNBHCECG NHPJHMKDNHF, ANDJNBHCECG HBDCIONLEPP);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LFDNKNHFEPI(ANDJNBHCECG NHPJHMKDNHF, bool HMBMDIJBPJC);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DAJDJMINKPD(ANDJNBHCECG NHPJHMKDNHF, bool DFGHIAGFEAH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct BDCCNOEFKOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly IIMMIALAJOB ODFMKGCLIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly IIMMIALAJOB EACEIFBMGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly uint DKFJGHKFNOB;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DAD0", Offset = "0x6A6CAD0", VA = "0x186A6DAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GKJGIIFBGFJ
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly BDCCNOEFKOP OGLJLDNLGIJ;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A732D0", Offset = "0x6A722D0", VA = "0x186A732D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct MFNKEJFAFJK
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly BDCCNOEFKOP OGLJLDNLGIJ;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A732D0", Offset = "0x6A722D0", VA = "0x186A732D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct BHODIGJFJGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly uint DKFJGHKFNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly bool HEHFEKKIGLK;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DE10", Offset = "0x6A6CE10", VA = "0x186A6DE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct IIMMIALAJOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal int ANNLKNNLIGI;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A771C0", Offset = "0x6A761C0", VA = "0x186A771C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface OBHFACLDFFH
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	PJCLOIBBJNB KFJGENPDIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum EPOOEHKEGMD
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface OKHLLIPPIGH : PDIFCLNPGMD
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	EPOOEHKEGMD AKEHAMNKGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool NLMEMGJENJL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject INALOLPJOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<OKHLLIPPIGH> GDDBHADNKOK;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(ENNOLIDPGMP NONINMLLOEG, AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool AJEEPBFDEJJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class LPLCIMAAHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6A79160", Offset = "0x6A78160", VA = "0x186A79160")]
	public static bool GEKANGKIIGP(this OKHLLIPPIGH DOLIGBGJCLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A79110", Offset = "0x6A78110", VA = "0x186A79110")]
	public static bool CDLNBAPNEMB(this OKHLLIPPIGH DOLIGBGJCLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6A791B0", Offset = "0x6A781B0", VA = "0x186A791B0")]
	public static bool GLGKNCKGJPM(this OKHLLIPPIGH DOLIGBGJCLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6A79200", Offset = "0x6A78200", VA = "0x186A79200")]
	public static bool MENDGOLEHOE(this OKHLLIPPIGH DOLIGBGJCLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface PDIFCLNPGMD
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
internal interface ADMNDHNNHKG
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<HFPOAEHABJK> PKLDGIEPBGF;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface KPNMPHOPONC
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMNFMIFCJNI(Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, Vector3 GNMLLHFGICG);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBIJAJOHEMP(AAEGPHPJNLD HHMPHBNGMGF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJGOBBHNFGL(bool FOOCPKEHHHI);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMIMMAMGJFP(bool DFGHIAGFEAH);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LEKDOPKEOJI
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface CKDCKKBGDLD
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(GMBPJONDGEK NLEFLODAGNO);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface GMBPJONDGEK
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	GameObject INALOLPJOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Transform DNPKMJFBJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	APLBGFGJNCA KNOBAKIIOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool HNHKKNPDDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HABJGBIMLFP(APLBGFGJNCA LIGKCFOOPNO);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface APLBGFGJNCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Rigidbody IIPBAHLFLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	GMBPJONDGEK LPFBGACKLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	GameObject CHNINBIEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	APLBGFGJNCA EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	APLBGFGJNCA JJGALJKCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	int OBEGLHIDBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool LNOIEOBPGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool HLOCEFHJFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	NBGFPCGNHAJ MDIDEKBEBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	GDLMMBKDOFD PDHMDHCJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	float KHBCBMICPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 LPLJJCMDAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 GGAIONLLBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 PFPOLMCKFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 MGBDEJCEECD
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool AFEJNPNMCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool DFJDMNDBIML
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool HMPBHMHCEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 EDCABHFAAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 IKDJAIOOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 LLCHMCEGACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 DMKBNHANJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float BOLEMMHMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float JCPNADANAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Vector3 OGIAMCOBEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion ILIHBKBCLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float JGIJMIECAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float OINHMCCHBFI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool MAIOGPMEPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	AHOPCOINALC MOCDPHINOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool EJAIKGPDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform HPKOOIKHDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 OFCPGHABHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float ENGNAMJBAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float HDCDFFDAKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion HEDBLFNKKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 ABAOOCCJCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion JHHONLHGLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints MNFAOBCAHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool NJHCAMDGLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode AIEMLBIPKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool AFHIINLOJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HJNBIKAPNHI MEJFDLJMBHA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HJNBIKAPNHI CCIOFDBKGEJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event HJNBIKAPNHI LLGAAAIHHIP;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event HJNBIKAPNHI EFMEMIAAGBB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event HJNBIKAPNHI OLEHIOMBLOL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event HJNBIKAPNHI CGOADBPPEDL;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event HJNBIKAPNHI GFKOIMCPIOF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JHDGOPNJJCO HEJFAKOONNE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HPJFBALBIOJ, HPJFBALBIOJ> FPKHALMDLDG;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	APLBGFGJNCA NNPIKIFMACD(int LLPJHIPCNFD);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void KDALBOFGHHC((Quaternion rot, Vector3 moments) GIALOAJHHIE);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void NJNJFFLKLJH();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void ANKEHACNMHP();

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void LOHBDBMDNNP();

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void KPCLKJCNCKL();

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void JBIJAJOHEMP(APLBGFGJNCA CBAEIEAPLIH, bool FFPHPJEJBKL = false);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void OELMKIPJBIG(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void ALDPGBMDKBE(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 FHOLLECDNPL(Vector3 GAIBCOAKDKC);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 GIBOAKBIOBF(Vector3 JPHCCCIGOIO);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void DNCLFMGGGJH();

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void DANBDBPOFDB();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void HOBKCMKFCLE();

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void DEBGMMCHMJM(Vector3 JLAGCBDIOCE, Vector3 EDDEDOBFGPD);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void OFGCKBHIDPB(Vector3 OBEPKPEDLHP, Vector3 ABBPNJFJIFG);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void PBEKBHIAIFL(Vector3 IJLKCHGFNBD);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void OHMJEBOOCPL(IFHGOPCKPNL JGPGGDILHJP, Vector3 FOFCEMPLBMF, float PMHFDGEEHMA, float CKOJHMCFDFN = 8f, float DAPEKAPEIGC = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void IAAPNEJDAPI(NDHCMAFIHCP DMCPDILGENE, Vector3 CCIKDGBKHJI, float PFIFJDPLMHF = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void JNLCOADNGGC(NDHCMAFIHCP DMCPDILGENE, Vector3 ADNGPFKNGFI, float NBNJNGGMAEO = 7f, float JPGDHDCNCHB = 1f);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 AEKAOILCHOO(Vector3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 CHGJLBAAOOC(Vector3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void BFJGNAHHNLH();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void FHGLNMDOHBB(APLBGFGJNCA MMELNEJHCGH, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void AAMDKFFGMMO(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void JFEFDBPFKAI();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void BGIAMMFHOEJ();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void MFCGGLFKNLK();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool AGBCHGFAEEO();

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void OGFNCOIHMFP();

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void CNBBAJCBBGF(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void NLNABJAHOLE(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void MEPPPGODBIL(object OEDJKICDDGA, bool OKDLNAIMGHJ);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void CJEDGLMMBDC(Vector3 JLPKCGDHNKG, Quaternion GDJCCIDIKIN);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void DLMGOANOKML(Vector3 KFJLMDEKNOI, Quaternion NPNKNILIGCI);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool JDDFJCGKFMK(float BELNDHOBICH);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void ICCHKCLABFP(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void BNCCABKMMOJ(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void EBGLEEGCKPH(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void JKEKIFFHNOK(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void JMNAKONBCGM(Vector3 BAKDLGCFEEB, ForceMode CGHFFMJLLOB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void BIAEKBICOOJ(Vector3 BAKDLGCFEEB, Vector3 MOIICCIPACK, ForceMode CGHFFMJLLOB);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void KMGFCLKLIKC(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void AADNPNFECGO(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool CCOPMDDFIGI(Vector3 KDJEBHMIDDA, [Out] RaycastHit AFHFMMLDFGN, float PNEKGHHAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void KAAHHJDKNAH();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GDLMMBKDOFD
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOBKNOKDOMG(Vector3 LCCCALJDNCL);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMINCOBPNIE(Vector3 BEELOOCNBOF);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKCMIMHLOAN(Vector3 LCCCALJDNCL);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DHMFANCKIAA(Vector3 BEELOOCNBOF);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface NBGFPCGNHAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NFABBLEHBOJ();

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 HOCEDEBJEEI();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void HJNBIKAPNHI(GMBPJONDGEK EAMDDOGFAKN);
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum LBHEIFLDMLG
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum IFHGOPCKPNL
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public delegate void JHDGOPNJJCO(GMBPJONDGEK EAMDDOGFAKN, bool FFPHPJEJBKL = false);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum NDHCMAFIHCP
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct MIAGEIJEICK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Rigidbody IBPJGMDGDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public object MLBJOODCFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector3 DKANNPGKCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 PHFKLNEEBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public JAFDOBAHKIN KMDGACFHLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool OBLNCDPMKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool BHPDBIHNEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool CABBBKIMJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool PJDOBEKMCBO;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DPCAJHGLMKH : AKEPMCFDLOM<IHGNLFDACDF>, KIBDNPLNELB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface NDDGLMNFNMJ<T> : JHCLKHPPOFH<IHGNLFDACDF, T>, AKEPMCFDLOM<IHGNLFDACDF>, KIBDNPLNELB, IDisposable, DPCAJHGLMKH where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class OEKKJFJDFKN
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C834B0", Offset = "0x2C824B0", VA = "0x182C834B0")]
	public static bool KCOKGBINLEI<T>(this AKEPMCFDLOM<IHGNLFDACDF> PDOOMGNBLHC, IHGNLFDACDF KJKEGAFLFDE, [Out] T CBAEIEAPLIH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2BF28B0", Offset = "0x2BF18B0", VA = "0x182BF28B0")]
	public static bool LHLEJLJODIO<T>(this AKEPMCFDLOM<IHGNLFDACDF> PDOOMGNBLHC, IHGNLFDACDF KJKEGAFLFDE, [In] T KPJPGFGPJMK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LJJELBHLHEG : AKEPMCFDLOM<AAEGPHPJNLD>, KIBDNPLNELB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface AEOIPICGJFO<T> : JHCLKHPPOFH<AAEGPHPJNLD, T>, AKEPMCFDLOM<AAEGPHPJNLD>, KIBDNPLNELB, IDisposable, LJJELBHLHEG where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class KIJEIKHHBKD
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x28C3B20", Offset = "0x28C2B20", VA = "0x1828C3B20")]
	public static T BDJJCDMMBKL<T>(this AKEPMCFDLOM<AAEGPHPJNLD> PDOOMGNBLHC, AAEGPHPJNLD OJMEEMCEEJO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2BF28B0", Offset = "0x2BF18B0", VA = "0x182BF28B0")]
	public static bool LHLEJLJODIO<T>(this AKEPMCFDLOM<AAEGPHPJNLD> PDOOMGNBLHC, AAEGPHPJNLD OJMEEMCEEJO, [In] T KPJPGFGPJMK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct MCMBKLFDKDM : IComparable<MCMBKLFDKDM>, IEquatable<MCMBKLFDKDM>
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly MCMBKLFDKDM GCMJGJIPGKE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly MCMBKLFDKDM MOEKKOBLIAP;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MCMBKLFDKDM ALKCHGDHDAI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly MCMBKLFDKDM DGEGMJFFJGD;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly MCMBKLFDKDM MMAFKKODPJC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly MCMBKLFDKDM PPHLCHHNMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int FPNFNABMIOF;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool PFDKFEHFAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A799B0", Offset = "0x6A789B0", VA = "0x186A799B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int LCHCCPIPGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6A799A0", Offset = "0x6A789A0", VA = "0x186A799A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0xA8D540", Offset = "0xA8C540", VA = "0x180A8D540")]
	public MCMBKLFDKDM(int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A79940", Offset = "0x6A78940", VA = "0x186A79940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A798C0", Offset = "0x6A788C0", VA = "0x186A798C0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x9FE480", Offset = "0x9FD480", VA = "0x1809FE480", Slot = "5")]
	public bool Equals(MCMBKLFDKDM LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1A8A980", Offset = "0x1A89980", VA = "0x181A8A980", Slot = "4")]
	public int CompareTo(MCMBKLFDKDM LJAAPFIIPOF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0xE1FD00", Offset = "0xE1ED00", VA = "0x180E1FD00")]
	public static MCMBKLFDKDM CPPJIHNILOM(int LLPJHIPCNFD)
	{
		return default(MCMBKLFDKDM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0xE1FD00", Offset = "0xE1ED00", VA = "0x180E1FD00")]
	public static int CPPJIHNILOM(MCMBKLFDKDM JEKFLJBJJDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A799C0", Offset = "0x6A789C0", VA = "0x186A799C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct AAMKNBMNABE : IEquatable<AAMKNBMNABE>, PDIFCLNPGMD
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly AAMKNBMNABE CFCGLLLPKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "6")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IFFJCGMBAFC ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(IFFJCGMBAFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public NOCINHNHONK DCNBNJDGLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(NOCINHNHONK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public GameObject INALOLPJOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B960", Offset = "0x6A6A960", VA = "0x186A6B960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public IHGNLFDACDF OKOCGOIMCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BF20", Offset = "0x6A6AF20", VA = "0x186A6BF20")]
		get
		{
			return default(IHGNLFDACDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public HHCMMLEJPPF BENAJBGABBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BAF0", Offset = "0x6A6AAF0", VA = "0x186A6BAF0")]
		get
		{
			return default(HHCMMLEJPPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public HMNDHIDLGHN BFGOMIMOGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BCD0", Offset = "0x6A6ACD0", VA = "0x186A6BCD0")]
		get
		{
			return default(HMNDHIDLGHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MFKEEIPFOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BC70", Offset = "0x6A6AC70", VA = "0x186A6BC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool OFBDMNBLMCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B890", Offset = "0x6A6A890", VA = "0x186A6B890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool MIKECACMECI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B7B0", Offset = "0x6A6A7B0", VA = "0x186A6B7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool PFDKCKJIAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BD70", Offset = "0x6A6AD70", VA = "0x186A6BD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool FIMAJMNOKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BC90", Offset = "0x6A6AC90", VA = "0x186A6BC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool ANJINAFFGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BCB0", Offset = "0x6A6ACB0", VA = "0x186A6BCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool OOFMLMGKKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BC20", Offset = "0x6A6AC20", VA = "0x186A6BC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool OMAACLFMHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B7D0", Offset = "0x6A6A7D0", VA = "0x186A6B7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool IKOPHBLDICI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B8B0", Offset = "0x6A6A8B0", VA = "0x186A6B8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public AIPNAAFMFIM IJPMPMHCPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AIPNAAFMFIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public HMIANLLFKFF FKLJDKDJBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(HMIANLLFKFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public LEKCGHDCAHI MHMIDBMFKBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(LEKCGHDCAHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public CPFJLBDBJPN EFAEDPHLLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(CPFJLBDBJPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public JLGHBBMNHND MFCGKHNOIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(JLGHBBMNHND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public DCIILHPPMKJ NJCBBIPPGHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(DCIILHPPMKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IBMNLBPHCNP LGLLBIIIKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(IBMNLBPHCNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public PFLOLIGKHEJ CDPJNIMCDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(PFLOLIGKHEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IEOMDPJHDGB HKMNGIINKAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(IEOMDPJHDGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NKJHEPEMIMO DGDJPBHBPGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(NKJHEPEMIMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public DJCLBEOLHJC PDFMJELDIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(DJCLBEOLHJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public MADEAIIDDFC FKCIJJIHJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(MADEAIIDDFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool GEKANGKIIGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BD90", Offset = "0x6A6AD90", VA = "0x186A6BD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BCJIJCKPGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BFC0", Offset = "0x6A6AFC0", VA = "0x186A6BFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool FHBIIKPGHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B8D0", Offset = "0x6A6A8D0", VA = "0x186A6B8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private bool NOKJCAJGLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public AAMKNBMNABE(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B910", Offset = "0x6A6A910", VA = "0x186A6B910")]
	public static bool CPPJIHNILOM(AAMKNBMNABE CBAEIEAPLIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	public static AAEGPHPJNLD CPPJIHNILOM(AAMKNBMNABE CBAEIEAPLIH)
	{
		return default(AAEGPHPJNLD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BC60", Offset = "0x6A6AC60", VA = "0x186A6BC60")]
	public static bool JEKPEIKHIPM(AAMKNBMNABE FAGKOOGCGBH, AAMKNBMNABE HEOHCJKCOLM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B290", Offset = "0x6A6A290", VA = "0x186A6B290")]
	public static bool GJBEBFKCOKB(AAMKNBMNABE FAGKOOGCGBH, AAMKNBMNABE HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BB90", Offset = "0x6A6AB90", VA = "0x186A6BB90", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(AAMKNBMNABE LJAAPFIIPOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	public static AAMKNBMNABE CPPJIHNILOM(AAEGPHPJNLD BMKMOMMIDOK)
	{
		return default(AAMKNBMNABE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B810", Offset = "0x6A6A810", VA = "0x186A6B810")]
	public GENHDEKBAFK CJJBBOOKGDK()
	{
		return default(GENHDEKBAFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B930", Offset = "0x6A6A930", VA = "0x186A6B930")]
	public ALNJLBBNPND DBCMNNBOHGK()
	{
		return default(ALNJLBBNPND);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B760", Offset = "0x6A6A760", VA = "0x186A6B760")]
	public PBGLEBELCBD AKHHMNJAABC()
	{
		return default(PBGLEBELCBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C000", Offset = "0x6A6B000", VA = "0x186A6C000")]
	public FIDBPODIABB PNMMFKBBODL()
	{
		return default(FIDBPODIABB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BE80", Offset = "0x6A6AE80", VA = "0x186A6BE80")]
	public void OCBEPNPKNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C030", Offset = "0x6A6B030", VA = "0x186A6C030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct IBMNLBPHCNP : IEquatable<IBMNLBPHCNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A742C0", Offset = "0x6A732C0", VA = "0x186A742C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private ALBECIIMDNG EEIMPCMDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A743F0", Offset = "0x6A733F0", VA = "0x186A743F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool JKPOCFMJMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A74580", Offset = "0x6A73580", VA = "0x186A74580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Guid JPIPEBHBNNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A74970", Offset = "0x6A73970", VA = "0x186A74970")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool ONHIEPGEGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A74730", Offset = "0x6A73730", VA = "0x186A74730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Guid BBEIENMKAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A74610", Offset = "0x6A73610", VA = "0x186A74610")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public IBMNLBPHCNP(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B910", Offset = "0x6A6A910", VA = "0x186A6B910")]
	public static bool CPPJIHNILOM(IBMNLBPHCNP CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A74450", Offset = "0x6A73450", VA = "0x186A74450", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(IBMNLBPHCNP LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A74350", Offset = "0x6A73350", VA = "0x186A74350")]
	public bool DIDAMLOCINO([Out] Guid KJEGAEAMNPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A741A0", Offset = "0x6A731A0", VA = "0x186A741A0")]
	public void BMIMICADNAJ(Guid LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A744E0", Offset = "0x6A734E0", VA = "0x186A744E0")]
	public bool FHMNKENLNOP([Out] Guid MHMEMGOEJHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6A747C0", Offset = "0x6A737C0", VA = "0x186A747C0")]
	public void HCFLNLDPKIL(Guid LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6A748E0", Offset = "0x6A738E0", VA = "0x186A748E0")]
	public void NOIMALIKGCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct PBGLEBELCBD : IEquatable<PBGLEBELCBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CEF0", Offset = "0x6A7BEF0", VA = "0x186A7CEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private ILBAJNELFOI AMFLNDKJBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CE90", Offset = "0x6A7BE90", VA = "0x186A7CE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 HBJOGBOIOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D4C0", Offset = "0x6A7C4C0", VA = "0x186A7D4C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Quaternion KHGGLNBCNDL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D610", Offset = "0x6A7C610", VA = "0x186A7D610")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public AAMKNBMNABE EMGBCALOGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D320", Offset = "0x6A7C320", VA = "0x186A7D320")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public PBGLEBELCBD(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B910", Offset = "0x6A6A910", VA = "0x186A6B910")]
	public static bool CPPJIHNILOM(PBGLEBELCBD CBAEIEAPLIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	public static AAEGPHPJNLD CPPJIHNILOM(PBGLEBELCBD CBAEIEAPLIH)
	{
		return default(AAEGPHPJNLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D0D0", Offset = "0x6A7C0D0", VA = "0x186A7D0D0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(PBGLEBELCBD LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CF80", Offset = "0x6A7BF80", VA = "0x186A7CF80")]
	public void DLCDBJBEOML(Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D3B0", Offset = "0x6A7C3B0", VA = "0x186A7D3B0")]
	public void LBPJGALOEJO(float GNMLLHFGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D160", Offset = "0x6A7C160", VA = "0x186A7D160")]
	public void GDMJPIMIFKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct GENHDEKBAFK : IEquatable<GENHDEKBAFK>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly GENHDEKBAFK CFCGLLLPKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IFFJCGMBAFC ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(IFFJCGMBAFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public NOCINHNHONK DCNBNJDGLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(NOCINHNHONK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6A70C40", Offset = "0x6A6FC40", VA = "0x186A70C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private NCJHBDLHOGE EIBCLBMLKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6A70D40", Offset = "0x6A6FD40", VA = "0x186A70D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public ANDJNBHCECG MNHECMLFAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6A70DA0", Offset = "0x6A6FDA0", VA = "0x186A70DA0")]
		get
		{
			return default(ANDJNBHCECG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public IEnumerable<AAMKNBMNABE> ACNCGBCHAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6A70F60", Offset = "0x6A6FF60", VA = "0x186A70F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IEnumerable<AAMKNBMNABE> JHPGEBPKACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6A71B10", Offset = "0x6A70B10", VA = "0x186A71B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int OBEGLHIDBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6A70E60", Offset = "0x6A6FE60", VA = "0x186A70E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int DPFIJFIPKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6A71270", Offset = "0x6A70270", VA = "0x186A71270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6A711C0", Offset = "0x6A701C0", VA = "0x186A711C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6A715A0", Offset = "0x6A705A0", VA = "0x186A715A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public FJNGAELGDAF ALPIHDGLPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6A70AA0", Offset = "0x6A6FAA0", VA = "0x186A70AA0")]
		get
		{
			return default(FJNGAELGDAF);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6A72560", Offset = "0x6A71560", VA = "0x186A72560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IMJLPBLFBEE OJCJFCFGHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6A71EE0", Offset = "0x6A70EE0", VA = "0x186A71EE0")]
		get
		{
			return default(IMJLPBLFBEE);
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6A71CB0", Offset = "0x6A70CB0", VA = "0x186A71CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public PFCOOAMNOEL GKCJPBOJJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6A71540", Offset = "0x6A70540", VA = "0x186A71540")]
		get
		{
			return default(PFCOOAMNOEL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6A70B70", Offset = "0x6A6FB70", VA = "0x186A70B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public float JOLBFCBNLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6A70BE0", Offset = "0x6A6FBE0", VA = "0x186A70BE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6A70EF0", Offset = "0x6A6FEF0", VA = "0x186A70EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool MEMPLPCPEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6A71650", Offset = "0x6A70650", VA = "0x186A71650")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6A714D0", Offset = "0x6A704D0", VA = "0x186A714D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool BHFCBDJBIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6A71160", Offset = "0x6A70160", VA = "0x186A71160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6A70B00", Offset = "0x6A6FB00", VA = "0x186A70B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool APJDEKPFHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6A71F40", Offset = "0x6A70F40", VA = "0x186A71F40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6A71E10", Offset = "0x6A70E10", VA = "0x186A71E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool NPHDEKGAIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6A71DB0", Offset = "0x6A70DB0", VA = "0x186A71DB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6A70CD0", Offset = "0x6A6FCD0", VA = "0x186A70CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool PHMONFOKGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6A712C0", Offset = "0x6A702C0", VA = "0x186A712C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6A71D40", Offset = "0x6A70D40", VA = "0x186A71D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool BIDBCELEBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6A71E80", Offset = "0x6A70E80", VA = "0x186A71E80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6A71C40", Offset = "0x6A70C40", VA = "0x186A71C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public GENHDEKBAFK(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B910", Offset = "0x6A6A910", VA = "0x186A6B910")]
	public static bool CPPJIHNILOM(GENHDEKBAFK CBAEIEAPLIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BC60", Offset = "0x6A6AC60", VA = "0x186A6BC60")]
	public static bool JEKPEIKHIPM(GENHDEKBAFK FAGKOOGCGBH, GENHDEKBAFK HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6A710D0", Offset = "0x6A700D0", VA = "0x186A710D0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(GENHDEKBAFK LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	public static AAMKNBMNABE CPPJIHNILOM(GENHDEKBAFK OLDDCPCBGIL)
	{
		return default(AAMKNBMNABE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6A71D20", Offset = "0x6A70D20", VA = "0x186A71D20")]
	public bool KLCCEGKHBJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6A71730", Offset = "0x6A70730", VA = "0x186A71730")]
	public bool IKKHGKBAODO(MJBOEELPMEM FDGNAIAIJOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6A716B0", Offset = "0x6A706B0", VA = "0x186A716B0")]
	public void HMIMKCDPCOE(MJBOEELPMEM FDGNAIAIJOC, bool CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6A71320", Offset = "0x6A70320", VA = "0x186A71320")]
	public ANDJNBHCECG GBPLDNGJFNK(Allocator IDMGOAKOEDG)
	{
		return default(ANDJNBHCECG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6A717A0", Offset = "0x6A707A0", VA = "0x186A717A0")]
	public void IPHGGDCKKNL(GENHDEKBAFK LJAAPFIIPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6A71FA0", Offset = "0x6A70FA0", VA = "0x186A71FA0")]
	public void PIIGIOPFCDF(List<AAMKNBMNABE> LGBJFINGEMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct DKNKMNJNPEC : IEquatable<DKNKMNJNPEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6A70320", Offset = "0x6A6F320", VA = "0x186A70320", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(DKNKMNJNPEC LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct HMIANLLFKFF : IEquatable<HMIANLLFKFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public HMIANLLFKFF(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A73FD0", Offset = "0x6A72FD0", VA = "0x186A73FD0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(HMIANLLFKFF LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6A73F30", Offset = "0x6A72F30", VA = "0x186A73F30")]
	public void BKCGKDNFFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6A74100", Offset = "0x6A73100", VA = "0x186A74100")]
	public void IABAHPKOLFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6A74060", Offset = "0x6A73060", VA = "0x186A74060")]
	public bool FJOIPHBNPBE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct NOCINHNHONK : IEquatable<NOCINHNHONK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B0F0", Offset = "0x6A7A0F0", VA = "0x186A7B0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private NCJHBDLHOGE EIBCLBMLKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B500", Offset = "0x6A7A500", VA = "0x186A7B500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public AAEGPHPJNLD PBJHCKFBNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B710", Offset = "0x6A7A710", VA = "0x186A7B710")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public AAMKNBMNABE EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B5F0", Offset = "0x6A7A5F0", VA = "0x186A7B5F0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public AAMKNBMNABE JJGALJKCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B680", Offset = "0x6A7A680", VA = "0x186A7B680")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public NOCINHNHONK(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B560", Offset = "0x6A7A560", VA = "0x186A7B560", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(NOCINHNHONK LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B7A0", Offset = "0x6A7A7A0", VA = "0x186A7B7A0")]
	public bool JBIJAJOHEMP(AAMKNBMNABE HHMPHBNGMGF, bool FBKFBBAIMLJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B8D0", Offset = "0x6A7A8D0", VA = "0x186A7B8D0")]
	public bool OCFNJFJOCMF(AAMKNBMNABE OIEOMIHHCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B180", Offset = "0x6A7A180", VA = "0x186A7B180")]
	private void DBMMCMALAMP(AAMKNBMNABE BHHPCDPHOFD, List<AAMKNBMNABE> LGCNGMHLAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B410", Offset = "0x6A7A410", VA = "0x186A7B410")]
	public GENHDEKBAFK DCACIBEMOCI()
	{
		return default(GENHDEKBAFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B4A0", Offset = "0x6A7A4A0", VA = "0x186A7B4A0")]
	public void DFGNJEHAMFE(List<AAMKNBMNABE> PCKPLNJEIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AFD0", Offset = "0x6A79FD0", VA = "0x186A7AFD0")]
	public NativeArray<AAEGPHPJNLD> BGLFJEFNODB()
	{
		return default(NativeArray<AAEGPHPJNLD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct AIPNAAFMFIM : IEquatable<AIPNAAFMFIM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string BHHKKMMCCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C660", Offset = "0x6A6B660", VA = "0x186A6C660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string GIBPMFJAGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C6E0", Offset = "0x6A6B6E0", VA = "0x186A6C6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private bool MEHJLEJDECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C340", Offset = "0x6A6B340", VA = "0x186A6C340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string KAIIIIGABOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C480", Offset = "0x6A6B480", VA = "0x186A6C480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string HICKMCCGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C7B0", Offset = "0x6A6B7B0", VA = "0x186A6C7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string EEHCDHHAKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C570", Offset = "0x6A6B570", VA = "0x186A6C570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public AIPNAAFMFIM(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C2B0", Offset = "0x6A6B2B0", VA = "0x186A6C2B0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(AIPNAAFMFIM LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct DJCLBEOLHJC : IEquatable<DJCLBEOLHJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FB60", Offset = "0x6A6EB60", VA = "0x186A6FB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private NFLPALCAONH HDDPLODHEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FE50", Offset = "0x6A6EE50", VA = "0x186A6FE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public GMOIEKOHKKI GIPJGPCKHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FEB0", Offset = "0x6A6EEB0", VA = "0x186A6FEB0")]
		get
		{
			return default(GMOIEKOHKKI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6A70180", Offset = "0x6A6F180", VA = "0x186A70180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool JDBHBGLKIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FAD0", Offset = "0x6A6EAD0", VA = "0x186A6FAD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FC80", Offset = "0x6A6EC80", VA = "0x186A6FC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public string[] APBEPPNHAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6A70290", Offset = "0x6A6F290", VA = "0x186A70290")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FA30", Offset = "0x6A6EA30", VA = "0x186A6FA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] PNNFDCOGECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F900", Offset = "0x6A6E900", VA = "0x186A6F900")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FDB0", Offset = "0x6A6EDB0", VA = "0x186A6FDB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string[] EJJLGOPFNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FD20", Offset = "0x6A6ED20", VA = "0x186A6FD20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F990", Offset = "0x6A6E990", VA = "0x186A6F990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string[] LKLAKAHGPBH
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FFB0", Offset = "0x6A6EFB0", VA = "0x186A6FFB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6A70040", Offset = "0x6A6F040", VA = "0x186A70040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public DJCLBEOLHJC(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	public static AAEGPHPJNLD CPPJIHNILOM(DJCLBEOLHJC CBAEIEAPLIH)
	{
		return default(AAEGPHPJNLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FBF0", Offset = "0x6A6EBF0", VA = "0x186A6FBF0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(DJCLBEOLHJC LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6A700E0", Offset = "0x6A6F0E0", VA = "0x186A700E0")]
	public bool OHOGJECHFFL(AAEGPHPJNLD GOBKHJJOFMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct ODLADMCBBJI : IEquatable<ODLADMCBBJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BB70", Offset = "0x6A7AB70", VA = "0x186A7BB70", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(ODLADMCBBJI LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct LEKCGHDCAHI : IEquatable<LEKCGHDCAHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public LEKCGHDCAHI(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6A78560", Offset = "0x6A77560", VA = "0x186A78560", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(LEKCGHDCAHI LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6A783F0", Offset = "0x6A773F0", VA = "0x186A783F0")]
	public bool COMLKKDGEHN([Out] Collider MKHCKFPAKLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct FIDBPODIABB : IEquatable<FIDBPODIABB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private MakerPenHeldDataWrapper MMBHEDIJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A70A40", Offset = "0x6A6FA40", VA = "0x186A70A40")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool EKHOEOICGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A70940", Offset = "0x6A6F940", VA = "0x186A70940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public FIDBPODIABB(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6A709B0", Offset = "0x6A6F9B0", VA = "0x186A709B0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(FIDBPODIABB LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct IEOMDPJHDGB : IEquatable<IEOMDPJHDGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A74AF0", Offset = "0x6A73AF0", VA = "0x186A74AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private JLNFKMFDMHE MNAMDLLLJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A74A90", Offset = "0x6A73A90", VA = "0x186A74A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public IEOMDPJHDGB(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A74B80", Offset = "0x6A73B80", VA = "0x186A74B80", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(IEOMDPJHDGB LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A74C10", Offset = "0x6A73C10", VA = "0x186A74C10")]
	public void LCPMMCKICPN(bool FPCNEOGOBHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct CPFJLBDBJPN : IEquatable<CPFJLBDBJPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E730", Offset = "0x6A6D730", VA = "0x186A6E730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private ObjectPolicyDataWrapper JHLDHOBANDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F340", Offset = "0x6A6E340", VA = "0x186A6F340")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private NavMeshGenerationDataWrapper KAMMNECKFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EC30", Offset = "0x6A6DC30", VA = "0x186A6EC30")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool GABPKDNNLBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F240", Offset = "0x6A6E240", VA = "0x186A6F240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool HJJNGIPIKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EF20", Offset = "0x6A6DF20", VA = "0x186A6EF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool IOEILCKKALL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EF90", Offset = "0x6A6DF90", VA = "0x186A6EF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool EDIAAACBFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EC90", Offset = "0x6A6DC90", VA = "0x186A6EC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool ICOLNGENIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E7C0", Offset = "0x6A6D7C0", VA = "0x186A6E7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool NAMIEBLOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F170", Offset = "0x6A6E170", VA = "0x186A6F170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool FDDIHMHFJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EEB0", Offset = "0x6A6DEB0", VA = "0x186A6EEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool ECGCKICIMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F400", Offset = "0x6A6E400", VA = "0x186A6F400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool KLMJJKAHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F470", Offset = "0x6A6E470", VA = "0x186A6F470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool FJFFCEINJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E6C0", Offset = "0x6A6D6C0", VA = "0x186A6E6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool JKLCJIDAIIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ED00", Offset = "0x6A6DD00", VA = "0x186A6ED00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool GDDANALAAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F000", Offset = "0x6A6E000", VA = "0x186A6F000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool KLEBEGDOJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F1E0", Offset = "0x6A6E1E0", VA = "0x186A6F1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool BHEKOEONKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F3A0", Offset = "0x6A6E3A0", VA = "0x186A6F3A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E650", Offset = "0x6A6D650", VA = "0x186A6E650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public LCJBGHMMALL KLDOMPCANAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E890", Offset = "0x6A6D890", VA = "0x186A6E890")]
		get
		{
			return default(LCJBGHMMALL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EE40", Offset = "0x6A6DE40", VA = "0x186A6EE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool EEEAEGIHFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EA60", Offset = "0x6A6DA60", VA = "0x186A6EA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public GLJNKOKMBJJ LFLNPFBGGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E830", Offset = "0x6A6D830", VA = "0x186A6E830")]
		get
		{
			return default(GLJNKOKMBJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool KKDALHKOCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EDE0", Offset = "0x6A6DDE0", VA = "0x186A6EDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 EPAJOHHAIIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F280", Offset = "0x6A6E280", VA = "0x186A6F280")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 HPAHEFDOHNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E530", Offset = "0x6A6D530", VA = "0x186A6E530")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool BPAKOLCOBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F070", Offset = "0x6A6E070", VA = "0x186A6F070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public CPFJLBDBJPN(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E8F0", Offset = "0x6A6D8F0", VA = "0x186A6E8F0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(CPFJLBDBJPN LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A6ED70", Offset = "0x6A6DD70", VA = "0x186A6ED70")]
	public bool IJFHHCAMGNO(PMOPAAEKJON FDGNAIAIJOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E5E0", Offset = "0x6A6D5E0", VA = "0x186A6E5E0")]
	public bool BNGMEOCPMDF(IPLIKNBCAMB FDGNAIAIJOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E980", Offset = "0x6A6D980", VA = "0x186A6E980")]
	public void FCPHFGIAKLA(IPLIKNBCAMB FDGNAIAIJOC, bool OHFAELGDCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EA00", Offset = "0x6A6DA00", VA = "0x186A6EA00")]
	public IPLIKNBCAMB FENHMJNHABN()
	{
		return default(IPLIKNBCAMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E4C0", Offset = "0x6A6D4C0", VA = "0x186A6E4C0")]
	public bool AMICMCLKHLL(IPLIKNBCAMB CBAEIEAPLIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct NKJHEPEMIMO : IEquatable<NKJHEPEMIMO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6A79D00", Offset = "0x6A78D00", VA = "0x186A79D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private PIOKFHMHEAI ECLOJLILAOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6A79D90", Offset = "0x6A78D90", VA = "0x186A79D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public NKJHEPEMIMO(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A79F00", Offset = "0x6A78F00", VA = "0x186A79F00", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(NKJHEPEMIMO LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A2E0", Offset = "0x6A792E0", VA = "0x186A7A2E0")]
	public bool LFGDGABMFEF(LKPJMGKMABK JGHIAOJOLJP, List<AAMKNBMNABE> LGBJFINGEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A79DF0", Offset = "0x6A78DF0", VA = "0x186A79DF0")]
	public int EFLMIBGFJKD(LKPJMGKMABK JGHIAOJOLJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A670", Offset = "0x6A79670", VA = "0x186A7A670")]
	public void OCIPNCBJPHB(List<AAMKNBMNABE> LGBJFINGEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A1B0", Offset = "0x6A791B0", VA = "0x186A7A1B0")]
	public int KNGEDAAOIAE(AAMKNBMNABE PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A410", Offset = "0x6A79410", VA = "0x186A7A410")]
	public AAMKNBMNABE LMMNKMDJAKF(int LLPJHIPCNFD, LKPJMGKMABK JGHIAOJOLJP)
	{
		return default(AAMKNBMNABE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A540", Offset = "0x6A79540", VA = "0x186A7A540")]
	public void MDOEIFJFMAG(AAMKNBMNABE PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A79BA0", Offset = "0x6A78BA0", VA = "0x186A79BA0")]
	public bool BBKCJGCHCNG(AAMKNBMNABE PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A0A0", Offset = "0x6A790A0", VA = "0x186A7A0A0")]
	public void KCABCIABBNN(LKPJMGKMABK JGHIAOJOLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A79C50", Offset = "0x6A78C50", VA = "0x186A79C50")]
	public bool CGPNMLGHDLB(AAMKNBMNABE PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A79F90", Offset = "0x6A78F90", VA = "0x186A79F90")]
	public bool HFELFIAFMHH(LKPJMGKMABK JGHIAOJOLJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct DCIILHPPMKJ : IEquatable<DCIILHPPMKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F4E0", Offset = "0x6A6E4E0", VA = "0x186A6F4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public DCIILHPPMKJ(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F600", Offset = "0x6A6E600", VA = "0x186A6F600", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(DCIILHPPMKJ LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F690", Offset = "0x6A6E690", VA = "0x186A6F690")]
	public void KIGIFEGFFJI(bool CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F570", Offset = "0x6A6E570", VA = "0x186A6F570")]
	public void EMGNOEEPPMA(bool CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x297C7C0", Offset = "0x297B7C0", VA = "0x18297C7C0")]
	public T OJNOGDKHBLE<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct MADEAIIDDFC : IEquatable<MADEAIIDDFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A793F0", Offset = "0x6A783F0", VA = "0x186A793F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private HBPIKMNCFEO COEMLEDMJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A79510", Offset = "0x6A78510", VA = "0x186A79510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool EJMPMCILOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A79480", Offset = "0x6A78480", VA = "0x186A79480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool ABLEBPLPAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A79360", Offset = "0x6A78360", VA = "0x186A79360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public MADEAIIDDFC(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A79570", Offset = "0x6A78570", VA = "0x186A79570", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(MADEAIIDDFC LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct OKFLDGIHOFA : IEquatable<OKFLDGIHOFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CD80", Offset = "0x6A7BD80", VA = "0x186A7CD80", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(OKFLDGIHOFA LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct JLGHBBMNHND : IEquatable<JLGHBBMNHND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6A77290", Offset = "0x6A76290", VA = "0x186A77290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private GCCONOAGHML KNIGNJMIEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6A77A20", Offset = "0x6A76A20", VA = "0x186A77A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private KEJOCCHIHBH EDGNNEBFBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x6A77A80", Offset = "0x6A76A80", VA = "0x186A77A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool MNKMKAKLPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6A77C50", Offset = "0x6A76C50", VA = "0x186A77C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool NIPHOPJFAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6A778F0", Offset = "0x6A768F0", VA = "0x186A778F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool MHHDNJBFFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6A77B80", Offset = "0x6A76B80", VA = "0x186A77B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool EFGAGKNFFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6A77CE0", Offset = "0x6A76CE0", VA = "0x186A77CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool LOBMNPBBILG
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6A778C0", Offset = "0x6A768C0", VA = "0x186A778C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool NHBPCJOFMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6A77DB0", Offset = "0x6A76DB0", VA = "0x186A77DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool ODFMPOKKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6A77320", Offset = "0x6A76320", VA = "0x186A77320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool DJFDNOOJMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x6A77530", Offset = "0x6A76530", VA = "0x186A77530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public JLGHBBMNHND(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B910", Offset = "0x6A6A910", VA = "0x186A6B910")]
	public static bool CPPJIHNILOM(JLGHBBMNHND CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6A77990", Offset = "0x6A76990", VA = "0x186A77990", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(JLGHBBMNHND LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6A77220", Offset = "0x6A76220", VA = "0x186A77220")]
	public bool BAKANPJOHBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6A77E40", Offset = "0x6A76E40", VA = "0x186A77E40")]
	public AAMKNBMNABE OBEFKMONPNC(AAMKNBMNABE PKMPGPJICGL)
	{
		return default(AAMKNBMNABE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6A776A0", Offset = "0x6A766A0", VA = "0x186A776A0")]
	public AAEGPHPJNLD DMCLHFDPGHE()
	{
		return default(AAEGPHPJNLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6A77AE0", Offset = "0x6A76AE0", VA = "0x186A77AE0")]
	public bool HELJBNDLHCH(AAEGPHPJNLD FCNFGEGOLKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6A77BB0", Offset = "0x6A76BB0", VA = "0x186A77BB0")]
	public bool MAIDIEMDCAJ(AAEGPHPJNLD PIGDFKAPDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6A777B0", Offset = "0x6A767B0", VA = "0x186A777B0")]
	public bool EBALJLGGCFF(AAEGPHPJNLD PKMPGPJICGL, [Out] AAEGPHPJNLD FCNFGEGOLKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct ALNJLBBNPND : IEquatable<ALNJLBBNPND>
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly ALNJLBBNPND CFCGLLLPKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public IFFJCGMBAFC ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(IFFJCGMBAFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public NOCINHNHONK DCNBNJDGLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(NOCINHNHONK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private ShapeTypeDataWrapper KCFOMNLDBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D0F0", Offset = "0x6A6C0F0", VA = "0x186A6D0F0")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public StandardRenderableVisualDataWrapper HBDGJKOOIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CA80", Offset = "0x6A6BA80", VA = "0x186A6CA80")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public PhysicsMaterialDataWrapper MAHGIKBKHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D150", Offset = "0x6A6C150", VA = "0x186A6D150")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public ShapeConfigDataWrapper EOPMMAEPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CA20", Offset = "0x6A6BA20", VA = "0x186A6CA20")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public FJICDOGEBPO BILCEJNOIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CE80", Offset = "0x6A6BE80", VA = "0x186A6CE80")]
		get
		{
			return default(FJICDOGEBPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public HBBKHIOKEBO POKBFINKFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CBC0", Offset = "0x6A6BBC0", VA = "0x186A6CBC0")]
		get
		{
			return default(HBBKHIOKEBO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CC80", Offset = "0x6A6BC80", VA = "0x186A6CC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public APFJPODAPMD BOCAFGJDKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CC20", Offset = "0x6A6BC20", VA = "0x186A6CC20")]
		get
		{
			return default(APFJPODAPMD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D1B0", Offset = "0x6A6C1B0", VA = "0x186A6D1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public float JOIIOHKCOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CAE0", Offset = "0x6A6BAE0", VA = "0x186A6CAE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CF60", Offset = "0x6A6BF60", VA = "0x186A6CF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 FHDBJOCOBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CD80", Offset = "0x6A6BD80", VA = "0x186A6CD80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D050", Offset = "0x6A6C050", VA = "0x186A6D050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public float FPEEKKFCDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CEF0", Offset = "0x6A6BEF0", VA = "0x186A6CEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public AKMLFMCCAKA OKEFCHCIOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CE20", Offset = "0x6A6BE20", VA = "0x186A6CE20")]
		get
		{
			return default(AKMLFMCCAKA);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D220", Offset = "0x6A6C220", VA = "0x186A6D220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public ALNJLBBNPND(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B910", Offset = "0x6A6A910", VA = "0x186A6B910")]
	public static bool CPPJIHNILOM(ALNJLBBNPND CBAEIEAPLIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B290", Offset = "0x6A6A290", VA = "0x186A6B290")]
	public static bool GJBEBFKCOKB(ALNJLBBNPND FAGKOOGCGBH, ALNJLBBNPND HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CCF0", Offset = "0x6A6BCF0", VA = "0x186A6CCF0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(ALNJLBBNPND LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CFD0", Offset = "0x6A6BFD0", VA = "0x186A6CFD0")]
	public NLEOLGHIJGK KEJFJMGJKMB()
	{
		return default(NLEOLGHIJGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CB40", Offset = "0x6A6BB40", VA = "0x186A6CB40")]
	public GKIGGANFGEP BCINGGFEGNL()
	{
		return default(GKIGGANFGEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct NLEOLGHIJGK : IEquatable<NLEOLGHIJGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public ALNJLBBNPND FNDGDDEMKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(ALNJLBBNPND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private PrimitiveShapeDataWrapper BCEMICOOBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A870", Offset = "0x6A79870", VA = "0x186A7A870")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public BBDBMCJMGFO NHNJLFEEHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A810", Offset = "0x6A79810", VA = "0x186A7A810")]
		get
		{
			return default(BBDBMCJMGFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public NLEOLGHIJGK(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B910", Offset = "0x6A6A910", VA = "0x186A6B910")]
	public static bool CPPJIHNILOM(NLEOLGHIJGK CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A780", Offset = "0x6A79780", VA = "0x186A7A780", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(NLEOLGHIJGK LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public readonly struct GKIGGANFGEP : IEquatable<GKIGGANFGEP>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly GKIGGANFGEP CFCGLLLPKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IFFJCGMBAFC ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(IFFJCGMBAFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x6A725D0", Offset = "0x6A715D0", VA = "0x186A725D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private CGEDEDAHAPI BPGKKGBMEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6A72790", Offset = "0x6A71790", VA = "0x186A72790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public ALNJLBBNPND FNDGDDEMKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(ALNJLBBNPND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public DCJCNMJEOPB MAJNMBOPCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6A72660", Offset = "0x6A71660", VA = "0x186A72660")]
		get
		{
			return default(DCJCNMJEOPB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6A72880", Offset = "0x6A71880", VA = "0x186A72880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public IEnumerable<HFHAJEHBGMN> GFKOBLNKPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6A72AB0", Offset = "0x6A71AB0", VA = "0x186A72AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public HFHAJEHBGMN PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x6A729A0", Offset = "0x6A719A0", VA = "0x186A729A0")]
		get
		{
			return default(HFHAJEHBGMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6A73240", Offset = "0x6A72240", VA = "0x186A73240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public GKIGGANFGEP(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B910", Offset = "0x6A6A910", VA = "0x186A6B910")]
	public static bool CPPJIHNILOM(GKIGGANFGEP CBAEIEAPLIH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BC60", Offset = "0x6A6AC60", VA = "0x186A6BC60")]
	public static bool JEKPEIKHIPM(GKIGGANFGEP FAGKOOGCGBH, GKIGGANFGEP HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6A727F0", Offset = "0x6A717F0", VA = "0x186A727F0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(GKIGGANFGEP LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6A72CC0", Offset = "0x6A71CC0", VA = "0x186A72CC0")]
	public HFHAJEHBGMN LFJDNNPAPPK(float3? MOIICCIPACK, [Optional] quaternion? ADNGPFKNGFI, [Optional] Vector3? GNMLLHFGICG)
	{
		return default(HFHAJEHBGMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6A73010", Offset = "0x6A72010", VA = "0x186A73010")]
	public HFHAJEHBGMN PHEGOHBAODL(int LLPJHIPCNFD, float3? MOIICCIPACK, [Optional] quaternion? ADNGPFKNGFI, [Optional] Vector3? GNMLLHFGICG)
	{
		return default(HFHAJEHBGMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6A72EE0", Offset = "0x6A71EE0", VA = "0x186A72EE0")]
	public void LICPGDGLNME(int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6A72F80", Offset = "0x6A71F80", VA = "0x186A72F80")]
	public void OAIAOCAHOEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct HFHAJEHBGMN : IEquatable<HFHAJEHBGMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public GKIGGANFGEP BGDPGHNHDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6A734D0", Offset = "0x6A724D0", VA = "0x186A734D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public float3 ABAOOCCJCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6A73820", Offset = "0x6A72820", VA = "0x186A73820")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6A73960", Offset = "0x6A72960", VA = "0x186A73960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public quaternion JHHONLHGLCH
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6A73740", Offset = "0x6A72740", VA = "0x186A73740")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6A73AC0", Offset = "0x6A72AC0", VA = "0x186A73AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public float3 AJJMNLFEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6A739E0", Offset = "0x6A729E0", VA = "0x186A739E0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6A73560", Offset = "0x6A72560", VA = "0x186A73560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public PIDPFJAHIJC BIFNKHKNIHE
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6A736D0", Offset = "0x6A726D0", VA = "0x186A736D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private SplinePointParentDataWrapper IKKDKHFBPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6A73900", Offset = "0x6A72900", VA = "0x186A73900")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private SplinePointPositionDataWrapper LAIELCJDFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6A735E0", Offset = "0x6A725E0", VA = "0x186A735E0")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private SplinePointRotationDataWrapper OIJPPLNEHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6A737C0", Offset = "0x6A727C0", VA = "0x186A737C0")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private SplinePointScaleDataWrapper EMEHCKCKNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6A738A0", Offset = "0x6A728A0", VA = "0x186A738A0")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private SplinePointOrderDataWrapper LIPHCBJKMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6A73A60", Offset = "0x6A72A60", VA = "0x186A73A60")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public HFHAJEHBGMN(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6A73640", Offset = "0x6A72640", VA = "0x186A73640", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(HFHAJEHBGMN LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6A734D0", Offset = "0x6A724D0", VA = "0x186A734D0")]
	public void AIEIMNOCCGC(GKIGGANFGEP CBAEIEAPLIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct PFLOLIGKHEJ : IEquatable<PFLOLIGKHEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D760", Offset = "0x6A7C760", VA = "0x186A7D760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private OBMMMOPPPNO JKNKHBOJICB
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DA30", Offset = "0x6A7CA30", VA = "0x186A7DA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private ToolCleanupSettingsDataWrapper ENIGFNPHLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DBA0", Offset = "0x6A7CBA0", VA = "0x186A7DBA0")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public bool CFPKMEKPKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E340", Offset = "0x6A7D340", VA = "0x186A7E340")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DA90", Offset = "0x6A7CA90", VA = "0x186A7DA90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool HHCJCIAEJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E270", Offset = "0x6A7D270", VA = "0x186A7E270")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E2D0", Offset = "0x6A7D2D0", VA = "0x186A7E2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public float ADJOAGFFBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DC00", Offset = "0x6A7CC00", VA = "0x186A7DC00")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DEE0", Offset = "0x6A7CEE0", VA = "0x186A7DEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool DODDHGNFPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E080", Offset = "0x6A7D080", VA = "0x186A7E080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public PFLOLIGKHEJ(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D9A0", Offset = "0x6A7C9A0", VA = "0x186A7D9A0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(PFLOLIGKHEJ LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DB00", Offset = "0x6A7CB00", VA = "0x186A7DB00")]
	public void HKKDNOBJFNL(int BMDINFODMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D7F0", Offset = "0x6A7C7F0", VA = "0x186A7D7F0")]
	public bool DNMCDEJFEFC([Out] int BMDINFODMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D900", Offset = "0x6A7C900", VA = "0x186A7D900")]
	public void EAABJKHDLNE(bool PHBLPHFNJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DD90", Offset = "0x6A7CD90", VA = "0x186A7DD90")]
	public void JOLJFKHNMFK(float CBLBJEPLPJP, float JOADOGMBPCI, float CJPEMLCHMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E120", Offset = "0x6A7D120", VA = "0x186A7E120")]
	public void MCAPGFOLNJF(float3 GPKGGEDJKNL, quaternion MOEPFBLHNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DC60", Offset = "0x6A7CC60", VA = "0x186A7DC60")]
	public bool IPJIMHPKKCH([Out] float3 GPKGGEDJKNL, [Out] quaternion MOEPFBLHNLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DF50", Offset = "0x6A7CF50", VA = "0x186A7DF50")]
	public bool KLAOFDLKJOJ([Out] float DAOJIKCFKIK, [Out] float MANCBFECBDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct IFFJCGMBAFC : IEquatable<IFFJCGMBAFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly AAEGPHPJNLD BMKMOMMIDOK;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public AAMKNBMNABE EJOMCAPLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(AAMKNBMNABE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public NOCINHNHONK DCNBNJDGLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
		get
		{
			return default(NOCINHNHONK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private KLHDIAOOCPK LJAJPFKMEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ADE0", Offset = "0x6A69DE0", VA = "0x186A6ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private IPBFDMGMDCC KOEJNCHKLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x6A751A0", Offset = "0x6A741A0", VA = "0x186A751A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public bool LDOFGHLODKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6A76EB0", Offset = "0x6A75EB0", VA = "0x186A76EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Vector3 ABAOOCCJCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x6A759F0", Offset = "0x6A749F0", VA = "0x186A759F0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6A75E40", Offset = "0x6A74E40", VA = "0x186A75E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Quaternion JHHONLHGLCH
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6A75800", Offset = "0x6A74800", VA = "0x186A75800")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x6A76960", Offset = "0x6A75960", VA = "0x186A76960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Vector3 OFCPGHABHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6A75710", Offset = "0x6A74710", VA = "0x186A75710")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6A75F10", Offset = "0x6A74F10", VA = "0x186A75F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Quaternion HEDBLFNKKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x6A76B80", Offset = "0x6A75B80", VA = "0x186A76B80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A764C0", Offset = "0x6A754C0", VA = "0x186A764C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public float ENGNAMJBAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A75100", Offset = "0x6A74100", VA = "0x186A75100")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A77040", Offset = "0x6A76040", VA = "0x186A77040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public float HDCDFFDAKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A76240", Offset = "0x6A75240", VA = "0x186A76240")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public Vector3 AJJMNLFEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A763D0", Offset = "0x6A753D0", VA = "0x186A763D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A75030", Offset = "0x6A74030", VA = "0x186A75030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Vector3 MLAFBKEBELG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A767C0", Offset = "0x6A757C0", VA = "0x186A767C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Matrix4x4 ELABMHFAIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A75260", Offset = "0x6A74260", VA = "0x186A75260")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
	public IFFJCGMBAFC(AAEGPHPJNLD OJMEEMCEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B2B0", Offset = "0x6A6A2B0", VA = "0x186A6B2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6A75440", Offset = "0x6A74440", VA = "0x186A75440", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0F0", Offset = "0x6A6A0F0", VA = "0x186A6B0F0", Slot = "4")]
	public bool Equals(IFFJCGMBAFC LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CA00", Offset = "0x6A6BA00", VA = "0x186A6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6A755F0", Offset = "0x6A745F0", VA = "0x186A755F0")]
	public FOJCBDPOEBL FGOJECDFGLP()
	{
		return default(FOJCBDPOEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A754D0", Offset = "0x6A744D0", VA = "0x186A754D0")]
	public void FAHBOLNNKHK([Out] Matrix4x4 NBMFEBPFDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A76640", Offset = "0x6A75640", VA = "0x186A76640")]
	public void LNFIAIGFGMI([Out] Vector3 FLJFNDMPNFK, [Out] Quaternion DGOOEJOBFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A76590", Offset = "0x6A75590", VA = "0x186A76590")]
	public void LNFIAIGFGMI([Out] RigidTransform PHKKAJEOEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A76090", Offset = "0x6A75090", VA = "0x186A76090")]
	public void KACJJHOJIKE([Out] Vector3 FLJFNDMPNFK, [Out] Quaternion DGOOEJOBFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A75FE0", Offset = "0x6A74FE0", VA = "0x186A75FE0")]
	public void KACJJHOJIKE([Out] RigidTransform PHKKAJEOEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A74E60", Offset = "0x6A73E60", VA = "0x186A74E60")]
	public UniformTRS AKNGCOFNNPF()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A74DA0", Offset = "0x6A73DA0", VA = "0x186A74DA0")]
	public void AKNGCOFNNPF([Out] UniformTRS HEHKKIOOIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A76D90", Offset = "0x6A75D90", VA = "0x186A76D90")]
	public UniformTRS OEIJECDAKKH()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A76CD0", Offset = "0x6A75CD0", VA = "0x186A76CD0")]
	public void OEIJECDAKKH([Out] UniformTRS PHKKAJEOEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A74CB0", Offset = "0x6A73CB0", VA = "0x186A74CB0")]
	public Vector3 ACGKMLEMBBP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A75B90", Offset = "0x6A74B90", VA = "0x186A75B90")]
	public void INCGLEKKCJO([In] Vector3 CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A762E0", Offset = "0x6A752E0", VA = "0x186A762E0")]
	public Vector3 KPKLDBJHEDE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A752A0", Offset = "0x6A742A0", VA = "0x186A752A0")]
	public void DJPELLGIKPJ([In] Vector3 CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A76A30", Offset = "0x6A75A30", VA = "0x186A76A30")]
	public Quaternion NNCKJMDELBJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A74F60", Offset = "0x6A73F60", VA = "0x186A74F60")]
	public void CDDPLBACIAG([In] Quaternion CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A76EF0", Offset = "0x6A75EF0", VA = "0x186A76EF0")]
	public Quaternion ONPEFILNMKE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A75640", Offset = "0x6A74640", VA = "0x186A75640")]
	public void FHMLHBOILIO([In] Quaternion CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A76720", Offset = "0x6A75720", VA = "0x186A76720")]
	public float LPEONIMPBFL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A768B0", Offset = "0x6A758B0", VA = "0x186A768B0")]
	public void NCNHKHDDPJA(float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A75950", Offset = "0x6A74950", VA = "0x186A75950")]
	public float GEJAGHIJNCG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A75AE0", Offset = "0x6A74AE0", VA = "0x186A75AE0")]
	public void IENOFNCDNKP(float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A76170", Offset = "0x6A75170", VA = "0x186A76170")]
	public void KBEBCEINGGN([In] Vector3 CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A75D50", Offset = "0x6A74D50", VA = "0x186A75D50")]
	public Vector3 JJMDIBDPMMI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A770F0", Offset = "0x6A760F0", VA = "0x186A770F0")]
	public void PDBOKFAMEAI([In] Vector3 CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A75C60", Offset = "0x6A74C60", VA = "0x186A75C60")]
	public Vector3 JHKHMDIINAK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A75370", Offset = "0x6A74370", VA = "0x186A75370")]
	public void EFKCKINBPHB([In] Vector3 CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A76DC0", Offset = "0x6A75DC0", VA = "0x186A76DC0")]
	public Vector3 OFGGLDKJAJG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A74E90", Offset = "0x6A73E90", VA = "0x186A74E90")]
	public void BLOJAKCINGN([In] Vector3 CBAEIEAPLIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class JPPABKLNLDH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct AHEAAPMBHOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid NNFEKLKANBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public GOIEJLCCPPO NFNODMHKOLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private struct GOIEJLCCPPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int CBAEIEAPLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int AEPILAELHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int LDJGNLKFNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int IDCJEGJNHKA;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A73370", Offset = "0x6A72370", VA = "0x186A73370")]
		public bool JHCGIBADIPL([Out] IHGNLFDACDF KJKEGAFLFDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A73400", Offset = "0x6A72400", VA = "0x186A73400")]
		public GOIEJLCCPPO(IHGNLFDACDF KJKEGAFLFDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A78180", Offset = "0x6A77180", VA = "0x186A78180")]
	public static Guid JLDKCMDMBKN(this IHGNLFDACDF KJKEGAFLFDE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A78220", Offset = "0x6A77220", VA = "0x186A78220")]
	public static bool MKMJDPLEIOO(this Guid NNFEKLKANBO, [Out] IHGNLFDACDF KJKEGAFLFDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal static class PNIEIMJDEFN
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E780", Offset = "0x6A7D780", VA = "0x186A7E780")]
	public static DJDFLLKIHKD MMPKBKCJMCO(this AAEGPHPJNLD BLCJLIJFBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E810", Offset = "0x6A7D810", VA = "0x186A7E810")]
	public static ENNOLIDPGMP PKEICGCHPNC(this AAEGPHPJNLD BLCJLIJFBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E680", Offset = "0x6A7D680", VA = "0x186A7E680")]
	public static EntityManager GBKAKLNHENB(this AAEGPHPJNLD BLCJLIJFBDL)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9340", Offset = "0x2CD8340", VA = "0x182CD9340")]
	public static T LDHPDKNBLHM<T>(this AAEGPHPJNLD BLCJLIJFBDL) where T : struct, GNMNCODNJFG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9080", Offset = "0x2CD8080", VA = "0x182CD9080")]
	public static bool DMPCBAPNIMN<T>(this AAEGPHPJNLD BLCJLIJFBDL) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8FD0", Offset = "0x2CD7FD0", VA = "0x182CD8FD0")]
	public static bool AONIAAKCCBF<T>(this AAEGPHPJNLD BLCJLIJFBDL) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface ALBECIIMDNG
{
	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ONHIEPGEGGI(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JKPOCFMJMPA(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DIDAMLOCINO(AAEGPHPJNLD OJMEEMCEEJO, [Out] Guid KJEGAEAMNPF);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid FNEHCAOGBIG(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMIMICADNAJ(AAEGPHPJNLD OJMEEMCEEJO, Guid KJEGAEAMNPF);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FHMNKENLNOP(AAEGPHPJNLD OJMEEMCEEJO, [Out] Guid MHMEMGOEJHD);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid FEGEAOBIKON(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HCFLNLDPKIL(AAEGPHPJNLD OJMEEMCEEJO, Guid MHMEMGOEJHD);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NOIMALIKGCA(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task HHMGPADCCEL(AAEGPHPJNLD FLFKBMMIINC, AAEGPHPJNLD HHMPHBNGMGF);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface CHKKELJBALO
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	Guid ACCIFBDEFID
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIDDDNHPEJP(NativeList<Guid> LGIBPODGGCO, NativeList<Guid> GKJNDKDCEAM, NativeList<FixedString64Bytes> CKFPELNBHJI);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface HBPIKMNCFEO
{
	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOKCOILPMPF(List<AAEGPHPJNLD> DCDLHFFJNCD);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMMJBCLJGFJ(List<AAEGPHPJNLD> DCBEJFIDLIP);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPIADNNEHKK(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EJMPMCILOPF(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ABLEBPLPAPD(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int JCFKFMDMDIG(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NPNKMPFHGJL(AAEGPHPJNLD MMGHCLBGFLK, int IGGMMJMDDDD);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AAEGPHPJNLD PHLMNLAGGPE(AAEGPHPJNLD JLPGKIIFIIK);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int MKJPNKHKNIL(AAEGPHPJNLD JLPGKIIFIIK);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JGJMLIKPHFC(AAEGPHPJNLD JLPGKIIFIIK, int OAJIDNKHBIE);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int NLBNONNLJNA(AAEGPHPJNLD JLPGKIIFIIK);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EPGPPJLMHBG(AAEGPHPJNLD JLPGKIIFIIK, int LDELPOBKBGO);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PGHCHDADGPC(AAEGPHPJNLD BMKMOMMIDOK);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ILFCPHCPOJO(AAEGPHPJNLD OJMEEMCEEJO, bool BEDMOFKIOGO);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IBMBADHONHD(AAEGPHPJNLD[] HDPAMFPMPBB, bool BEDMOFKIOGO);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface EDCIOAKAPBB
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	IReadOnlyCollection<EAOBFODEGDK> EINIMGGADFL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLGHGLDCHEK(int OPLDNLPEEPG, [Out] EAOBFODEGDK AABBBPHCHCD);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EAOBFODEGDK AHMHEBNECFD(Type PBLNJHEPKAE);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class ECHBGJKOLLF
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x29A0660", Offset = "0x299F660", VA = "0x1829A0660")]
	public static T ANKDFNDOMJF<T>(this EDCIOAKAPBB LFAHNKJIJNE, Entity JOAHHHNEJGM) where T : struct, GNMNCODNJFG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x299FA90", Offset = "0x299EA90", VA = "0x18299FA90")]
	public static EAOBFODEGDK AHMHEBNECFD<T>(this EDCIOAKAPBB LFAHNKJIJNE) where T : struct, GNMNCODNJFG
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface HJMLGFABCFO
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IHGNLFDACDF[] NOBGHPBBJMC(string LCLKDNPLMED, AAMKNBMNABE ODFBMJICGIH, bool DKGKBIFOAOG = false);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OABBNLANBCA(string MHPCMEBOPCE, IHGNLFDACDF[] GJGNBOMHEMN);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface ILBAJNELFOI
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<AAEGPHPJNLD, AAEGPHPJNLD> NGCIBNKHBJJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<AAEGPHPJNLD, AAEGPHPJNLD> KAPCLDHFBIJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AAEGPHPJNLD, AAEGPHPJNLD, AAEGPHPJNLD> PJCNLLIBMCA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AAEGPHPJNLD> EHFIBHLCEOH;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HALHKHHENJB(AAEGPHPJNLD OJMEEMCEEJO, AAEGPHPJNLD JDNABOPHHBE);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AAEGPHPJNLD OOCHNNOGKGO(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<AAEGPHPJNLD> BKICJIMDIAG(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AAEGPHPJNLD PHIPIFINNOJ(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DLCDBJBEOML(AAEGPHPJNLD OJMEEMCEEJO, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LBPJGALOEJO(AAEGPHPJNLD OJMEEMCEEJO, float MMHPMHNOCBE);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool PLNFPJAHAGN(AAEGPHPJNLD OJMEEMCEEJO, [Out] AAEGPHPJNLD HHMPHBNGMGF);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AANFIMHMBPA(AAEGPHPJNLD OJMEEMCEEJO, [Out] RigidTransform FKFEDKJJNNJ);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool BFMPNBFFAGB(AAEGPHPJNLD OJMEEMCEEJO, [Out] float FPMNMNMPHDL);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 MPFDIMIGEDJ(PBGLEBELCBD HPEDOOPINDA);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion BGMKDMCHOLB(PBGLEBELCBD HPEDOOPINDA);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class BMFJPFIMLBO
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface MDFELAEONHL
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	object EPMAPFKMHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHHCEDNBMNL(ANDJNBHCECG HDPAMFPMPBB);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct NMONENKGINO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly string LCLKDNPLMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly T AJMLHGDNPEK;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x45AA110", Offset = "0x45A9110", VA = "0x1845AA110")]
	public NMONENKGINO(T AJMLHGDNPEK, [Optional][CallerMemberName] string LCLKDNPLMED)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly NMONENKGINO<int> NIMLKINJMHA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum CHBDOMCBHNP
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class MJMHFMMFKGD
{
	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xD74A40", Offset = "0xD73A40", VA = "0x180D74A40")]
	public static bool NGADDIMJOBC(this CHBDOMCBHNP NGHALOPECFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xD74C70", Offset = "0xD73C70", VA = "0x180D74C70")]
	public static bool PCOOADHPPEB(this CHBDOMCBHNP NGHALOPECFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x25436C0", Offset = "0x25426C0", VA = "0x1825436C0")]
	public static bool NKAJHMKMBMO(this CHBDOMCBHNP NGHALOPECFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface BKOODIPIFON
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	bool MCJHJMLNMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface JGOPMKGAFGM
{
	[Cpp2IlInjected.Token(Token = "0x17000180")]
	CHBDOMCBHNP BBKLFJOKDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	CHBDOMCBHNP FCBOIHHPCCD
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	CHBDOMCBHNP IELCMBBNHEG
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	CHBDOMCBHNP DPBMIHMBBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	CHBDOMCBHNP LHMIBLNIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	CHBDOMCBHNP MHMIDBMFKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	CHBDOMCBHNP OPJCIMBCDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	CHBDOMCBHNP JEDNHJJMHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	CHBDOMCBHNP MLNPEHAELAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	CHBDOMCBHNP OFHCCLDBLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	CHBDOMCBHNP FKHHNDIJGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	CHBDOMCBHNP NJBMEGAFLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	CHBDOMCBHNP FDDNBHOJKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	CHBDOMCBHNP CPOCNLFKHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	CHBDOMCBHNP NKPKOFMNDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BDJJCDMMBKL(NMONENKGINO<int> FFADDNJMIIP);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface NCJHBDLHOGE
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<HFPOAEHABJK> PKLDGIEPBGF;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AAEGPHPJNLD JFJMBBCPEND(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOLFIBGGLKI(List<AAEGPHPJNLD> DCBEJFIDLIP);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PIDPFJAHIJC OFJMFGLBLOF(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PIDPFJAHIJC NMPGGEFMNBL(AAEGPHPJNLD HHMPHBNGMGF, AAEGPHPJNLD LPPNOBMEEDD, bool MCFBMNGPFML, AAEGPHPJNLD PKMPGPJICGL);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AAEGPHPJNLD NEBBPAGEGKE(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JBIJAJOHEMP(AAEGPHPJNLD OJMEEMCEEJO, AAEGPHPJNLD HHMPHBNGMGF, bool FBKFBBAIMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DFLLFOGBHKE(AAEGPHPJNLD OJMEEMCEEJO, AAEGPHPJNLD HHMPHBNGMGF);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PHCEMLCCEOK(AAEGPHPJNLD IDJAFLGEMEC, AAEGPHPJNLD PFLEEGNNFIB);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int HLJPDOIJOGD(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ANDJNBHCECG MMJEIDLNNDH(AAEGPHPJNLD BMKMOMMIDOK);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NativeArray<AAEGPHPJNLD> BGLFJEFNODB(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GKNKOOPBOIH(AAEGPHPJNLD OJMEEMCEEJO, AAEGPHPJNLD JIBHAPNJBEB);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<AAEGPHPJNLD> HMPEOMOHDHE(AAEGPHPJNLD OJMEEMCEEJO, bool OJLAKEOKPNL = false);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OCFNJFJOCMF(AAEGPHPJNLD OJMEEMCEEJO, AAEGPHPJNLD OIEOMIHHCCH);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	AAEGPHPJNLD FCDHBIGAAGL(AAEGPHPJNLD PKMPGPJICGL, AAEGPHPJNLD JOKNDHNLFPJ);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool NPKCMLCDPAL(AAEGPHPJNLD PKMPGPJICGL, AAEGPHPJNLD JOKNDHNLFPJ, [Out] AAEGPHPJNLD MIIOEIIIGML);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class AABKFCIHCGL
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AC60", Offset = "0x6A69C60", VA = "0x186A6AC60")]
	public static List<AAEGPHPJNLD> FOLFIBGGLKI(this NCJHBDLHOGE FNKICHMEFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AD70", Offset = "0x6A69D70", VA = "0x186A6AD70")]
	public static bool OGKMLGMAMJM(this NCJHBDLHOGE FNKICHMEFHK, AAEGPHPJNLD OJMEEMCEEJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface NFLPALCAONH
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GMOIEKOHKKI LMNOFDOKPGA(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMONIJICNON(AAEGPHPJNLD MMGHCLBGFLK, GMOIEKOHKKI BOEJLOIMLFM);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DBEDGGBHIBC(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EAKFOIKIIEO(AAEGPHPJNLD MMGHCLBGFLK, bool CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] LGJHFCBIHHF(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLDFJMEMIHD(AAEGPHPJNLD MMGHCLBGFLK, IEnumerable<string> LNFPBHCJGHO);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] HMEBLPBCCAN(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBAMELDPINM(AAEGPHPJNLD MMGHCLBGFLK, IEnumerable<string> LNFPBHCJGHO);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] CEIHPGBFCPG(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GKMIBBDMBHO(AAEGPHPJNLD MMGHCLBGFLK, IEnumerable<string> LNFPBHCJGHO);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] OLPELKINKNH(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FLJDDPCEGIC(AAEGPHPJNLD MMGHCLBGFLK, IEnumerable<string> LNFPBHCJGHO);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OHOGJECHFFL(AAEGPHPJNLD MMGHCLBGFLK, AAEGPHPJNLD GOBKHJJOFMO);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface DICNFFGNGPF
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	bool LOABHCCGNLO
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	bool PLKLPIKFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface AFJJPGANCBB : FGEPIECGPNC
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AENLPMEPCIA(Entity JOAHHHNEJGM, [Out] DMJNMFJAPHK JNKGLDBBIBB);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPGEAOKACCG(NativeArray<DMJNMFJAPHK> PJJDBOLIJLO, NativeArray<ONEPIGBHIBO> APMCAOMPJCO);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPILEMNKOFA(DMJNMFJAPHK JNKGLDBBIBB);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HMABKAIBNPD(DMJNMFJAPHK JNKGLDBBIBB, [Out] Collider MKHCKFPAKLI);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface FGEPIECGPNC
{
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BKAJGAOGMHK([In] float3 AKJEKBLKOGB, [In] float3 KDJEBHMIDDA, float PNEKGHHAGPJ, Allocator IDMGOAKOEDG, [Out] NativeArray<Entity> GOBIGKPCBPO);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface MKJAJFENNFP
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BKAJGAOGMHK([In] float3 AKJEKBLKOGB, [In] float3 KDJEBHMIDDA, float PNEKGHHAGPJ, [Out] PAJJGHBALCF LDNNAGOGIAN, [Out] AAEGPHPJNLD PHPAEBAONCF);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface NPIIBLOLAPK
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKAJGAOGMHK([In] NativeArray<Entity> GOBIGKPCBPO, [In] float3 AKJEKBLKOGB, [In] float3 KDJEBHMIDDA, [In] NativeArray<PAJJGHBALCF> BEGHAFAKDFL);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct DMJNMFJAPHK : BNGFLHDNNIJ, IEquatable<DMJNMFJAPHK>
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public int FPNFNABMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xA8D560", Offset = "0xA8C560", VA = "0x180A8D560", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xA8D540", Offset = "0xA8C540", VA = "0x180A8D540", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public int HJHABCPEMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2550DE0", Offset = "0x254FDE0", VA = "0x182550DE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x5D54330", Offset = "0x5D53330", VA = "0x185D54330", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6A703B0", Offset = "0x6A6F3B0", VA = "0x186A703B0", Slot = "8")]
	public bool Equals(DMJNMFJAPHK LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x6A70400", Offset = "0x6A6F400", VA = "0x186A70400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct PAJJGHBALCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float DLALHMLKGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float3 FFJHDFACBIE;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface LEFIJFECENH
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface KLHDIAOOCPK
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	DJDFLLKIHKD MMPKBKCJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	OGPELCDHHDO INJKEFCBJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<ANDJNBHCECG, NativeArray<HMNDHIDLGHN>> CDELFFBGHCF;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<ANDJNBHCECG> PPKCADHFHEO;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HHCMMLEJPPF NCNCAHCLHEH(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HMNDHIDLGHN JEOOFLFAMLO(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PIKNDMFIIPK(IHGNLFDACDF KJKEGAFLFDE, OKHLLIPPIGH DOLIGBGJCLG);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AAABGMNMCMN(IHGNLFDACDF[] GJGNBOMHEMN, GameObject INALOLPJOHI);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AAMKNBMNABE OCBEPNPKNBP(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BOBCABNPAMO(AAEGPHPJNLD OJMEEMCEEJO, [Out] Transform DNPKMJFBJBC);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GEKANGKIIGP(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ADANPCDCCFM(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AAEGPHPJNLD BFBCFIIKHPL(IHGNLFDACDF KJKEGAFLFDE);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KOPCACPOOCD(IHGNLFDACDF KJKEGAFLFDE, [Out] AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IHGNLFDACDF IOHANIMMPCC(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	ANDJNBHCECG BFBCFIIKHPL(NativeArray<IHGNLFDACDF> KJKEGAFLFDE, Allocator IDMGOAKOEDG);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	ANDJNBHCECG OMFMLGMOGLF(HMNDHIDLGHN HKILDBKKLEG, int JPBPNOCHNLG, Allocator IDMGOAKOEDG);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	ANDJNBHCECG LBKEFIDOKHC(NativeArray<IHGNLFDACDF> KJKEGAFLFDE, NativeArray<AGHNCEKJDPP> PLAPJIEHCME, Allocator IDMGOAKOEDG);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IHGNLFDACDF[] NOBGHPBBJMC(string MHPCMEBOPCE, AAMKNBMNABE ODFBMJICGIH, bool DKGKBIFOAOG);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OABBNLANBCA(string MHPCMEBOPCE, IHGNLFDACDF[] GJGNBOMHEMN);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "22")]
	AAMKNBMNABE MOEKKOBLIAP(HMNDHIDLGHN HKILDBKKLEG, bool BBDBABDAFPN);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "23")]
	AAMKNBMNABE MOEKKOBLIAP(HMNDHIDLGHN HKILDBKKLEG);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "24")]
	AAMKNBMNABE CEABOLMPNCC(HMNDHIDLGHN HKILDBKKLEG);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "25")]
	AAMKNBMNABE NAGNNHHFCCH(HMNDHIDLGHN HKILDBKKLEG);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AAMKNBMNABE KJCOIAKJODA(IHGNLFDACDF KJKEGAFLFDE, HMNDHIDLGHN HKILDBKKLEG);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "27")]
	GENHDEKBAFK JHKCKAIEKBM();

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "28")]
	GKIGGANFGEP HFGNFFIAOBB();

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "29")]
	NLEOLGHIJGK ALEKDLHBLKF(BBDBMCJMGFO MCOBDCNAAHF);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IABAHPKOLFD(ANDJNBHCECG HDPAMFPMPBB);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BKCGKDNFFIN(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void JMHFFAKJICO(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void IABAHPKOLFD(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void AHKJKHBANKJ(AAEGPHPJNLD HDPAMFPMPBB);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool FJOIPHBNPBE(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	ANDJNBHCECG BDJEGINGLNB(ANDJNBHCECG EBPGBDEOLNG, Allocator IDMGOAKOEDG);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool EKGDBOHPAIM(AAEGPHPJNLD OJMEEMCEEJO);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class NLHPLMHPDHA
{
	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A8D0", Offset = "0x6A798D0", VA = "0x186A7A8D0")]
	public static void ADANPCDCCFM(this KLHDIAOOCPK NHPJHMKDNHF, OKHLLIPPIGH DOLIGBGJCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A950", Offset = "0x6A79950", VA = "0x186A7A950")]
	public static AAMKNBMNABE HIPNCOILPNP(this KLHDIAOOCPK NHPJHMKDNHF, LocalId OJMEEMCEEJO)
	{
		return default(AAMKNBMNABE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6A7ABF0", Offset = "0x6A79BF0", VA = "0x186A7ABF0")]
	public static AAMKNBMNABE HIPNCOILPNP(this KLHDIAOOCPK NHPJHMKDNHF, IHGNLFDACDF KJKEGAFLFDE)
	{
		return default(AAMKNBMNABE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A950", Offset = "0x6A79950", VA = "0x186A7A950")]
	public static AAEGPHPJNLD BFBCFIIKHPL(this KLHDIAOOCPK NHPJHMKDNHF, LocalId OJMEEMCEEJO)
	{
		return default(AAEGPHPJNLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AD50", Offset = "0x6A79D50", VA = "0x186A7AD50")]
	public static IHGNLFDACDF IOHANIMMPCC(this KLHDIAOOCPK NHPJHMKDNHF, LocalId OJMEEMCEEJO)
	{
		return default(IHGNLFDACDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A980", Offset = "0x6A79980", VA = "0x186A7A980")]
	public static bool EKGDBOHPAIM(this KLHDIAOOCPK NHPJHMKDNHF, IHGNLFDACDF KJKEGAFLFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F080", Offset = "0x2C8E080", VA = "0x182C8F080")]
	public static T DLIGPOADBHI<T>(this KLHDIAOOCPK NHPJHMKDNHF, LocalId OJMEEMCEEJO) where T : struct, GNMNCODNJFG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AED0", Offset = "0x6A79ED0", VA = "0x186A7AED0")]
	public static GENHDEKBAFK NPHCFPDOACD(this KLHDIAOOCPK NHPJHMKDNHF, RigidTransform HEHKKIOOIIG)
	{
		return default(GENHDEKBAFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AC50", Offset = "0x6A79C50", VA = "0x186A7AC50")]
	public static NLEOLGHIJGK IAOEIDKCNOF(this KLHDIAOOCPK NHPJHMKDNHF, BBDBMCJMGFO CBBDICIDDKC, RigidTransform HEHKKIOOIIG)
	{
		return default(NLEOLGHIJGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7ADD0", Offset = "0x6A79DD0", VA = "0x186A7ADD0")]
	public static GKIGGANFGEP NKCKHGEOLJJ(this KLHDIAOOCPK NHPJHMKDNHF, RigidTransform HEHKKIOOIIG)
	{
		return default(GKIGGANFGEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A9F0", Offset = "0x6A799F0", VA = "0x186A7A9F0")]
	private static void FKPNMIPNCBE(AAMKNBMNABE BJFBHBIDKBJ, RigidTransform HEHKKIOOIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface GCCONOAGHML
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	bool HLEGKCMDGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	AAEGPHPJNLD NBOKLNADMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	AAMKNBMNABE JHHLPFBDBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event LGNHKANIBGJ KLGNPOMHPGN;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AAEGPHPJNLD FCDHBIGAAGL(AAEGPHPJNLD PKMPGPJICGL, AAEGPHPJNLD JOKNDHNLFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NPKCMLCDPAL(AAEGPHPJNLD PKMPGPJICGL, AAEGPHPJNLD JOKNDHNLFPJ, [Out] AAEGPHPJNLD MIIOEIIIGML);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NFLBJGEOMEF();

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JLLLEBEAHFM();

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MNKMKAKLPHL(AAEGPHPJNLD PKMPGPJICGL);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NHBPCJOFMIE(AAEGPHPJNLD PKMPGPJICGL);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public delegate void LGNHKANIBGJ(AAMKNBMNABE KCLEAILJGAO, AAMKNBMNABE DBBHNDCOOEK);
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class OHGAKIOFNGH
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CB10", Offset = "0x6A7BB10", VA = "0x186A7CB10")]
	public static bool CCHINNDOLID(this GCCONOAGHML CJFPAPMDPKF, AAMKNBMNABE PKMPGPJICGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CBE0", Offset = "0x6A7BBE0", VA = "0x186A7CBE0")]
	public static bool LFMIIDFLBNO(this GCCONOAGHML CJFPAPMDPKF, AAEGPHPJNLD PKMPGPJICGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CB60", Offset = "0x6A7BB60", VA = "0x186A7CB60")]
	public static bool EFGAGKNFFOA(this GCCONOAGHML CJFPAPMDPKF, AAEGPHPJNLD PKMPGPJICGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface PIOKFHMHEAI
{
	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFGDGABMFEF(AAMKNBMNABE BJFBHBIDKBJ, LKPJMGKMABK JGHIAOJOLJP, List<AAMKNBMNABE> LGBJFINGEMK);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int EFLMIBGFJKD(AAMKNBMNABE BJFBHBIDKBJ, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCIPNCBJPHB(AAMKNBMNABE BJFBHBIDKBJ, List<AAMKNBMNABE> LGBJFINGEMK);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KNGEDAAOIAE(AAMKNBMNABE BMDINFODMJG, AAMKNBMNABE PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AAMKNBMNABE LMMNKMDJAKF(AAMKNBMNABE BMDINFODMJG, int LLPJHIPCNFD, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MDOEIFJFMAG(AAMKNBMNABE BMDINFODMJG, AAMKNBMNABE PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BBKCJGCHCNG(AAMKNBMNABE BMDINFODMJG, AAMKNBMNABE PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KCABCIABBNN(AAMKNBMNABE BMDINFODMJG, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CGPNMLGHDLB(AAMKNBMNABE BMDINFODMJG, AAMKNBMNABE PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void COEHHLDIGIN(Entity BMDINFODMJG, Entity PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CCEAKEODCAG(Entity BMDINFODMJG, LKPJMGKMABK JGHIAOJOLJP);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HFELFIAFMHH(AAMKNBMNABE PKMPGPJICGL, LKPJMGKMABK JGHIAOJOLJP);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface OPKMLGOKHBG
{
	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFEFEGKLHDB(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LLFHLOMHEPP(AAEGPHPJNLD OJMEEMCEEJO, Transform DNPKMJFBJBC);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface KEJOCCHIHBH
{
	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HELJBNDLHCH(AAEGPHPJNLD PKMPGPJICGL, AAEGPHPJNLD FCNFGEGOLKA);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MAIDIEMDCAJ(AAEGPHPJNLD PKMPGPJICGL, AAEGPHPJNLD PIGDFKAPDLJ);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EBALJLGGCFF(AAEGPHPJNLD PKMPGPJICGL, [Out] AAEGPHPJNLD CPJPFGKPFKJ);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface HEKIBGLDOPE
{
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIGIFEGFFJI(AAEGPHPJNLD BMKMOMMIDOK, bool CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMGNOEEPPMA(AAEGPHPJNLD BMKMOMMIDOK, bool CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMOLONBEGOM(AAEGPHPJNLD BMKMOMMIDOK, int CBAEIEAPLIH);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface CGEDEDAHAPI
{
	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<AAEGPHPJNLD> NOJHIBFFLGH(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AAEGPHPJNLD JDIGFPNOMCD(AAEGPHPJNLD OJMEEMCEEJO, int LLPJHIPCNFD);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int DJNMHEJOFOK(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DCJCNMJEOPB LPFLPPFINBN(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJJMKNJFGIB(AAEGPHPJNLD OJMEEMCEEJO, DCJCNMJEOPB LIIDINHCICD);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AAEGPHPJNLD PMMKFMPLGCJ(AAEGPHPJNLD OJMEEMCEEJO, [Optional] float3? MOIICCIPACK, [Optional] quaternion? ADNGPFKNGFI, [Optional] float3? GNMLLHFGICG);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AAEGPHPJNLD ADOAOFOFKMH(AAEGPHPJNLD OJMEEMCEEJO, int LLPJHIPCNFD, [Optional] float3? MOIICCIPACK, [Optional] quaternion? ADNGPFKNGFI, [Optional] float3? GNMLLHFGICG);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBPAENMAFKD(AAEGPHPJNLD OJMEEMCEEJO, int LLPJHIPCNFD);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KBNNNKDIKIP(AAEGPHPJNLD OJMEEMCEEJO);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface FINLOJKOHOO
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKJPJINEOKG();

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJBEJBOGMID();

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOJBONCKOIA();

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIBAOILFCLH();

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDIHFBDCLEH();

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IAIALHAEMAO();

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DGKJDEKGOBN();

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODDBKDAGMEN();

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BLHINMNMDEB();

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FIBEJCOKOFD();

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DPHBECMJDHD();

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LKHBEHLMILF();

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HPMAFAFMPIF();
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface OBMMMOPPPNO
{
	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNMCDEJFEFC(AAEGPHPJNLD PKMPGPJICGL, [Out] int BMDINFODMJG);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKKDNOBJFNL(AAEGPHPJNLD PKMPGPJICGL, int BMDINFODMJG);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AAEBJCBJFJC(AAEGPHPJNLD PKMPGPJICGL, bool OHFAELGDCKO);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EAABJKHDLNE(AAEGPHPJNLD PKMPGPJICGL, bool PHBLPHFNJCC);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOLJFKHNMFK(AAEGPHPJNLD PKMPGPJICGL, float CBLBJEPLPJP, float JOADOGMBPCI, float CJPEMLCHMGJ);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KLAOFDLKJOJ(AAEGPHPJNLD OJMEEMCEEJO, [Out] float JOADOGMBPCI, [Out] float CJPEMLCHMGJ);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MCAPGFOLNJF(AAEGPHPJNLD PKMPGPJICGL, float3 MOIICCIPACK, quaternion ADNGPFKNGFI);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IPJIMHPKKCH(AAEGPHPJNLD PKMPGPJICGL, [Out] float3 MOIICCIPACK, [Out] quaternion ADNGPFKNGFI);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface IPBFDMGMDCC
{
	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFHFMJIMGEN(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INCGLEKKCJO(Entity JOAHHHNEJGM, [In] float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 ACGKMLEMBBP(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CDDPLBACIAG(Entity JOAHHHNEJGM, [In] quaternion CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion NNCKJMDELBJ(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FOOGBAFHAHJ(Entity JOAHHHNEJGM, [In] float3 MOIICCIPACK, [In] quaternion ADNGPFKNGFI);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LNFIAIGFGMI(Entity JOAHHHNEJGM, [Out] float3 MOIICCIPACK, [Out] quaternion ADNGPFKNGFI);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LNFIAIGFGMI(Entity JOAHHHNEJGM, [Out] RigidTransform ECADMNINBDK);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KACJJHOJIKE(Entity JOAHHHNEJGM, [Out] float3 MOIICCIPACK, [Out] quaternion ADNGPFKNGFI);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KACJJHOJIKE(Entity JOAHHHNEJGM, [Out] RigidTransform ECADMNINBDK);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 OHCCCCIJFMD(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KBEBCEINGGN(Entity JOAHHHNEJGM, [In] float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NCNHKHDDPJA(Entity JOAHHHNEJGM, float CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float LPEONIMPBFL(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EFKCKINBPHB(Entity JOAHHHNEJGM, [In] float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 JHKHMDIINAK(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DJPELLGIKPJ(Entity JOAHHHNEJGM, [In] float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 KPKLDBJHEDE(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FHMLHBOILIO(Entity JOAHHHNEJGM, [In] quaternion CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion ONPEFILNMKE(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 JJMDIBDPMMI(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PDBOKFAMEAI(Entity JOAHHHNEJGM, [In] float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IENOFNCDNKP(Entity JOAHHHNEJGM, float CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float GEJAGHIJNCG(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BLOJAKCINGN(Entity JOAHHHNEJGM, [In] float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 OFGGLDKJAJG(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NKFMKPBLIBJ(Entity JOAHHHNEJGM, [Out] float4x4 NBMFEBPFDJH);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void AJMPNLPBDLM(Entity JOAHHHNEJGM, [In] float4x4 NBMFEBPFDJH);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DEMABNHBNOI(Entity JOAHHHNEJGM, [Out] float4x4 NBMFEBPFDJH);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool BOBCABNPAMO(Entity JOAHHHNEJGM, [Out] Transform DNPKMJFBJBC);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DKBIPJFHBHH(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JEGLNDANFHH(Entity JOAHHHNEJGM, Entity JFLPKAEFKDG, Entity NAEADMGDGFI);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class FFEGJLDLOBD
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface KLDKDIJGLOO
{
	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCCPCLAEFPL(bool CCMANGKMKPF);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface LJGJGFKKGGL
{
	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHBGJIFJEEM(AAEGPHPJNLD MMGHCLBGFLK, IEnumerable<string> LNFPBHCJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGNGOKJBCIJ(AAEGPHPJNLD MMGHCLBGFLK, IEnumerable<string> LNFPBHCJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNPOMIDLLAF(AAEGPHPJNLD MMGHCLBGFLK, params string[] LNFPBHCJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DEPKPKCDOBH(AAEGPHPJNLD MMGHCLBGFLK, params string[] LNFPBHCJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDEEBGNMANO(AAEGPHPJNLD MMGHCLBGFLK, params string[] LNFPBHCJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMNHPOFCEOF(AAEGPHPJNLD MMGHCLBGFLK, params string[] LNFPBHCJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FGPKNJNMNAC(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int GPBFADIICED(AAEGPHPJNLD MMGHCLBGFLK);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MLNAKPMFJAG(AAEGPHPJNLD MMGHCLBGFLK, ICollection<string> KEOHGLALHHC);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NJLGMGCGEAA(AAEGPHPJNLD MMGHCLBGFLK, ICollection<string> KEOHGLALHHC);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LCANGLHCLIP(AAEGPHPJNLD MMGHCLBGFLK, string EGOPOEBLEJP);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void POIOJPCHDMJ(string EGOPOEBLEJP, LNKEOBMBAPA JPGHELNFNMI);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EJJOBBEEJKJ(string EGOPOEBLEJP, LNKEOBMBAPA JPGHELNFNMI);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JFPGNMGGPOC();

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BMKDBEPOECB(IEnumerable<string> LNFPBHCJGHO);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface OIOHLIADDEK
{
	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World OAENKFPDHHH(string JEOJAKDIGAA = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World LJPGFBOEJFK(string JEOJAKDIGAA = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World EAEFPKLPMCK(string JEOJAKDIGAA = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World JDDPNBNJBIH(string JEOJAKDIGAA = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface ENNOLIDPGMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	World LEBMEJDJJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	World NNMLDHKFLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	EntityManager GBKAKLNHENB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	bool MENDGOLEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase JBFAHCJFPAL(Type PBLNJHEPKAE);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class EDMOPCPDANI
{
	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6A70450", Offset = "0x6A6F450", VA = "0x186A70450")]
	public static ComponentSystemBase KFFKIIBAAEE(this World NONINMLLOEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x29A1860", Offset = "0x29A0860", VA = "0x1829A1860")]
	public static T JBFAHCJFPAL<T>(this ENNOLIDPGMP EJKNHBODGGI) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface BONIOLKPOCF
{
	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOPOKPHBCDE(NativeListAsync<Entity> OFDGDPCDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FACCGMBGACM(PNCECJNMIPP IMBLLNJEEED);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGMFMKEEDCD(NativeListAsync<Entity> NHJJPJCPDNL, bool AKADOJIAGBD);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOKMBNNLMFM();
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface CEOBJBHONGG
{
	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDABFDPKLJC(Collider MKHCKFPAKLI, [Out] CFLEICKAICO IBFJMGENIBP);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface MHFIPACLEJI
{
	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JHPKAKIGBPL(AAEGPHPJNLD OJMEEMCEEJO, [Out] Collider MKHCKFPAKLI);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PBMMCAOKMKD(AAEGPHPJNLD KCAJBAJAGDM, GameObject FIFJHOIIJHB, Vector3 DCBNBHMBGKP, Quaternion JAFBJNOBENG);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNJONKJLKNB(GameObject MKHCKFPAKLI);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider FKJIFLDPPOC<TCollider>(GameObject BMPFNHAMJIP) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LIGCAMDOPCG(Collider MKHCKFPAKLI);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BIMABDIFJMJ<TCollider>(string LCLKDNPLMED) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public enum FLJMMCGDAIO
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface KDOPGOIHGMJ
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public struct KKKEAMOEFCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int CAPDOHDKJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GameObject FIFJHOIIJHB;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKBKEBEPCOC(AAEGPHPJNLD OJMEEMCEEJO, FJNGAELGDAF MCHNPLMNKPH, bool NIPOEALJIGP, MJBOEELPMEM KDEOBFBBCBH);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OINNPMJJPLJ(AAEGPHPJNLD OJMEEMCEEJO, FJNGAELGDAF MCHNPLMNKPH, bool NIPOEALJIGP, bool IOKOECPBIFL, bool CDAPCDJCPGB);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IBKBAGKMNPE NHMOKFODDEB(AAEGPHPJNLD FMGEJNFFGHE, List<AAEGPHPJNLD> COALFLHFHJP);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIFFLNGKKNO(GameObject IFIJCBIHBHO, GameObject EMIDFMNGNDC);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JACMJFBNGLO(GameObject IFIJCBIHBHO, [In] GOOAPFACFOD<GameObject> PPAIHBHHIFC);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFIEAEBJBGD(GameObject EMIDFMNGNDC);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T FKJIFLDPPOC<T>(GameObject BMPFNHAMJIP) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LIGCAMDOPCG(Collider MKHCKFPAKLI);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NJKONNKBLDE(ANDJNBHCECG OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MFFNGBHJNKP(ANDJNBHCECG OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject HBHCANGPNPF<T>(string LCLKDNPLMED) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EGEGMGBMJFD(Collider MKHCKFPAKLI, [Out] AAEGPHPJNLD BMDINFODMJG);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MNNBDOPFHBK(AAEGPHPJNLD OJMEEMCEEJO, [Out] CFLEICKAICO IBFJMGENIBP);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<FLJMMCGDAIO> FFPNLEOPAEG(Allocator IDMGOAKOEDG = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] GNNMBICJJOO();

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int JFECDJPMHIL(FJNGAELGDAF MCHNPLMNKPH);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string BDNHKFJCKNJ(FJNGAELGDAF MCHNPLMNKPH);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface BHLBLIBLPND
{
	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAMMKDIBDLH(AAEGPHPJNLD OJMEEMCEEJO, AAEGPHPJNLD CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJAEINCGPLB(AAEGPHPJNLD OJMEEMCEEJO, AAEGPHPJNLD CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HLJPDOIJOGD(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AAEGPHPJNLD NNPIKIFMACD(AAEGPHPJNLD OJMEEMCEEJO, int LLPJHIPCNFD);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ANDJNBHCECG FMNCLEDJEAA(AAEGPHPJNLD OJMEEMCEEJO, Allocator IDMGOAKOEDG = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFFJHIOKBJB(AAEGPHPJNLD OJMEEMCEEJO, object OEDJKICDDGA, AAEGPHPJNLD CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KALJHJFNAAA(AAEGPHPJNLD OJMEEMCEEJO, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DKNJAJBKNKH(AAEGPHPJNLD OJMEEMCEEJO, [Out] AAEGPHPJNLD CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DNNKKELPAEC(AAEGPHPJNLD OJMEEMCEEJO, float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ALDLFOFEJGG(AAEGPHPJNLD OJMEEMCEEJO, [Out] float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MDHPDPKBGOB(AAEGPHPJNLD OJMEEMCEEJO, float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ICPLIGBILCK(AAEGPHPJNLD OJMEEMCEEJO, [Out] float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LNHMOMCHCNF(AAEGPHPJNLD OJMEEMCEEJO, (Quaternion rot, Vector3 moments) GIALOAJHHIE);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LDAGPHHKPPF(AAEGPHPJNLD OJMEEMCEEJO, [Out] quaternion NACDGIDELJO, [Out] float3 BKPPGLEKIBF);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HCFELKFODEO(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 OAKOJAINMCO(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 AAHEPEEOCCA(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MEAJEHHGLIK(AAEGPHPJNLD OJMEEMCEEJO, float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CNOKIHJBCFG(AAEGPHPJNLD OJMEEMCEEJO, float3 CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float APIBBAIAFDM(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float OOKLPNIBHGI(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ACAICLFONDI(AAEGPHPJNLD OJMEEMCEEJO, float CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GIBNLPLCNKD(AAEGPHPJNLD OJMEEMCEEJO, float CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode POPNBIJOMFA(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EJPAGOIBAKE(AAEGPHPJNLD OJMEEMCEEJO, CollisionDetectionMode CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "25")]
	AHOPCOINALC ODPAPDEGOPL(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LFFDGKEBLJE(AAEGPHPJNLD OJMEEMCEEJO, AHOPCOINALC CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LIANBHMJGAI(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PCLCMEPBGGK(AAEGPHPJNLD OJMEEMCEEJO, bool CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "29")]
	AAEGPHPJNLD JFJMBBCPEND(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void ALIKKNONPMB(AAEGPHPJNLD OJMEEMCEEJO, AAEGPHPJNLD CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "31")]
	AAEGPHPJNLD NEBBPAGEGKE(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void JBIJAJOHEMP(AAEGPHPJNLD OJMEEMCEEJO, AAEGPHPJNLD CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "33")]
	JAFDOBAHKIN FODILJAJPAI(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KPLBLJIFOLL(AAEGPHPJNLD OJMEEMCEEJO, JAFDOBAHKIN KMDGACFHLDK);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EHGLJBDAKCP(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EHJCNFHCMLO(AAEGPHPJNLD OJMEEMCEEJO, bool CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool ONOHMNEFDCC(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FANLJOKEHCF(AAEGPHPJNLD OJMEEMCEEJO, bool CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints PFOIKACCAHE(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void GGFFBDCBEKL(AAEGPHPJNLD OJMEEMCEEJO, RigidbodyConstraints CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float DCMGMMBEKMJ(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void AOFCLOMHANC(AAEGPHPJNLD OJMEEMCEEJO, float CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float NLNFAGGLENN(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void FBABFMHBGGI(AAEGPHPJNLD OJMEEMCEEJO, float CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool AIBCJNMIIIE(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void NANCDAHHPNP(AAEGPHPJNLD OJMEEMCEEJO, bool CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool COANEEJBFEM(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void NHHHHMJKIPI(AAEGPHPJNLD OJMEEMCEEJO, bool CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void BACFALHBHLG(AAEGPHPJNLD OJMEEMCEEJO, int CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "50")]
	NBGFPCGNHAJ PGNFGENKGEJ(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void OHFEAAEKJLP(AAEGPHPJNLD OJMEEMCEEJO, NBGFPCGNHAJ CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "52")]
	GDLMMBKDOFD MCIJIOCACGF(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void GFANCIKJLNC(AAEGPHPJNLD OJMEEMCEEJO, GDLMMBKDOFD CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float FFJANBAPKLJ(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void PDAIEKECKEF(AAEGPHPJNLD OJMEEMCEEJO, float CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void IBPJIBBDLJK(AAEGPHPJNLD OJMEEMCEEJO, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void PAPBEGDKGIO(AAEGPHPJNLD OJMEEMCEEJO, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool OGDPLAJJCPC(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void PLNNOLEHGFG(AAEGPHPJNLD OJMEEMCEEJO, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void CDCKEIIALMI(AAEGPHPJNLD OJMEEMCEEJO, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool DCBCLEINPPP(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool CCCNLAOGLCE(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody IHBOFGONELP(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void GMJFLIJKNCO(AAEGPHPJNLD OJMEEMCEEJO, Rigidbody NEPLMIMPLJL);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void EBGLEEGCKPH(AAEGPHPJNLD OJMEEMCEEJO, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void JKEKIFFHNOK(AAEGPHPJNLD OJMEEMCEEJO, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool PKGHADOLFKI(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void FHLKFGBECCD(AAEGPHPJNLD OJMEEMCEEJO, float3 EFBILKIFBJD);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void IMPNGPDMEGM(AAEGPHPJNLD OJMEEMCEEJO, float3 BEELOOCNBOF);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool NMEFACPPJHD(AAEGPHPJNLD OJMEEMCEEJO, [Out] float3 EFBILKIFBJD);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool HBINDKJNABE(AAEGPHPJNLD OJMEEMCEEJO, [Out] float3 BEELOOCNBOF);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool EJAIKGPDIBJ(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KFKLHENBLGI(AAEGPHPJNLD OJMEEMCEEJO, object OEDJKICDDGA, bool OKDLNAIMGHJ);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void MBDEDCPAPKK(AAEGPHPJNLD OJMEEMCEEJO, bool LGOBJBNBLBJ);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void FGEMGKALDFA(AAEGPHPJNLD OJMEEMCEEJO);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool PIIANDIHNPC(AAEGPHPJNLD OJMEEMCEEJO);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface LFEHPHAGCOF
{
	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIFKOHGIFIO(Entity NCDOEJEOPDP);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGIJKCDJDHI(Entity NCDOEJEOPDP);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface JLNFKMFDMHE
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFMEDIGHLLM(AAEGPHPJNLD PKMPGPJICGL, bool FPCNEOGOBHL);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIBHNHCHFKL(AAEGPHPJNLD PKMPGPJICGL, int AOKMKNGFNPG);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public delegate void KHCEFMINEHA(OHLFKAGPAPE FKHFCOEEGHL);
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct OHLFKAGPAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly ANDJNBHCECG ILBONJPLGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NativeArray<byte> MMEJBFFJJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NativeArray<byte> HKHEDCNNGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MCMBKLFDKDM JEKFLJBJJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly int KKKGMGOMPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Type JDHDMFHKEJG;

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public ANDJNBHCECG DOGBELKBCKK
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xA7B030", Offset = "0xA7A030", VA = "0x180A7B030")]
		get
		{
			return default(ANDJNBHCECG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CD10", Offset = "0x6A7BD10", VA = "0x186A7CD10")]
	public OHLFKAGPAPE(ANDJNBHCECG ILBONJPLGFN, NativeArray<byte> MMEJBFFJJCL, NativeArray<byte> HKHEDCNNGBN, MCMBKLFDKDM JEKFLJBJJDA, int KKKGMGOMPBL, Type JDHDMFHKEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1800", Offset = "0x2CB0800", VA = "0x182CB1800")]
	public NativeArray<T> KNNBCJLIFNA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2CB17C0", Offset = "0x2CB07C0", VA = "0x182CB17C0")]
	public NativeArray<T> COCABBDONFD<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x2CB16D0", Offset = "0x2CB06D0", VA = "0x182CB16D0")]
	public (ANDJNBHCECG, NativeArray<T>, NativeArray<T>) BDJJCDMMBKL<T>() where T : struct
	{
		return default((ANDJNBHCECG, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CCC0", Offset = "0x6A7BCC0", VA = "0x186A7CCC0")]
	public HFPOAEHABJK JFBBHCEPLBD()
	{
		return default(HFPOAEHABJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface FEOJNDPBIFL
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	string DGJGGLMCLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	FEOJNDPBIFL JGMOLIJLNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	IEnumerable<FEOJNDPBIFL> NBALKEONKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface NHHNLCFPIAK
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	FEOJNDPBIFL GMEMBCKKJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	List<LJJELBHLHEG> PBGFDDMEOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HGEEAGANKKD(LJJELBHLHEG PDOOMGNBLHC, [Out] FEOJNDPBIFL DMIBAMIPIDM);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PIKNDMFIIPK(LJJELBHLHEG PDOOMGNBLHC, KHCEFMINEHA JKFOHJCKAGN);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KAAMLDMKLFD(LJJELBHLHEG PDOOMGNBLHC, KHCEFMINEHA JKFOHJCKAGN);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public readonly struct HFPOAEHABJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly OHLFKAGPAPE FHNKDHIILBL;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public ANDJNBHCECG DOGBELKBCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA7B030", Offset = "0xA7A030", VA = "0x180A7B030")]
		get
		{
			return default(ANDJNBHCECG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x6A73DF0", Offset = "0x6A72DF0", VA = "0x186A73DF0")]
	public HFPOAEHABJK(OHLFKAGPAPE FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x6A73D20", Offset = "0x6A72D20", VA = "0x186A73D20")]
	public ANDJNBHCECG KNNBCJLIFNA()
	{
		return default(ANDJNBHCECG);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x6A73C50", Offset = "0x6A72C50", VA = "0x186A73C50")]
	public ANDJNBHCECG COCABBDONFD()
	{
		return default(ANDJNBHCECG);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6A73B30", Offset = "0x6A72B30", VA = "0x186A73B30")]
	public (ANDJNBHCECG, ANDJNBHCECG, ANDJNBHCECG) BDJJCDMMBKL()
	{
		return default((ANDJNBHCECG, ANDJNBHCECG, ANDJNBHCECG));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DefaultMember("Item")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface KDMMBCKJOIH : IEnumerable<AFPNNMHOJOP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	NativeBitArray ACJADAKILJA
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	NativeBitArray FNMPHDBEJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	NativeArray<int> IDAKKILOHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	AFPNNMHOJOP PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	AFPNNMHOJOP PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AFPNNMHOJOP JKGGEOICDDH(BCNGOELDNOO IJNPKFDDGPP);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MCMBKLFDKDM IGGEHFOAFMH(BCNGOELDNOO IJNPKFDDGPP);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class PEAHGMELMEG
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[DefaultMember("Item")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface CEHNHABAGIN : IEnumerable<DPCAJHGLMKH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	DPCAJHGLMKH PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPCAJHGLMKH JKGGEOICDDH(BCNGOELDNOO IJNPKFDDGPP);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCMBKLFDKDM IGGEHFOAFMH(BCNGOELDNOO IJNPKFDDGPP);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class JDKKFHDHNMI
{
	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2B85FF0", Offset = "0x2B84FF0", VA = "0x182B85FF0")]
	public static MCMBKLFDKDM IGGEHFOAFMH<T>(this CEHNHABAGIN CLIGLABJMIA, FLJCJPKCPFE<T> LCLKDNPLMED) where T : struct
	{
		return default(MCMBKLFDKDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
[DefaultMember("Item")]
public interface JOPHJJDICGA : IEnumerable<LJJELBHLHEG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	LJJELBHLHEG PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LJJELBHLHEG JKGGEOICDDH(BCNGOELDNOO IJNPKFDDGPP);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCMBKLFDKDM IGGEHFOAFMH(BCNGOELDNOO IJNPKFDDGPP);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class HLBNHFOODFC
{
	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x2B27CD0", Offset = "0x2B26CD0", VA = "0x182B27CD0")]
	public static AEOIPICGJFO<T> JKGGEOICDDH<T>(this JOPHJJDICGA CLIGLABJMIA, BCNGOELDNOO LCLKDNPLMED) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2B27730", Offset = "0x2B26730", VA = "0x182B27730")]
	public static MCMBKLFDKDM IGGEHFOAFMH<T>(this JOPHJJDICGA CLIGLABJMIA, FLJCJPKCPFE<T> LCLKDNPLMED) where T : struct
	{
		return default(MCMBKLFDKDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface PLMCDLOIJJB
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIKNDMFIIPK(BCNGOELDNOO PDOOMGNBLHC, KHCEFMINEHA JKFOHJCKAGN);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAAMLDMKLFD(BCNGOELDNOO PDOOMGNBLHC, KHCEFMINEHA JKFOHJCKAGN);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class ONIFDKFLMOC
{
	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCBE0", Offset = "0x2CBBBE0", VA = "0x182CBCBE0")]
	public static void PIKNDMFIIPK<T>(this PLMCDLOIJJB FCILLGGMCPH, FLJCJPKCPFE<T> PDOOMGNBLHC, KHCEFMINEHA JKFOHJCKAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC850", Offset = "0x2CBB850", VA = "0x182CBC850")]
	public static void KAAMLDMKLFD<T>(this PLMCDLOIJJB FCILLGGMCPH, FLJCJPKCPFE<T> PDOOMGNBLHC, KHCEFMINEHA JKFOHJCKAGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface PPGBFCAEJCE
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	DHHDMIAEJAJ INJLKGENJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KLBNKJOIHGO(IHGNLFDACDF KJKEGAFLFDE, MCMBKLFDKDM PDOOMGNBLHC);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNBFIEDPPDF(IHGNLFDACDF KJKEGAFLFDE, Span<MCMBKLFDKDM> CLIGLABJMIA, bool CHDBJECLGJN);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLGALGLLPDA(NativeArray<IHGNLFDACDF> GJGNBOMHEMN);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class AOMFCNFOHON
{
	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D970", Offset = "0x6A6C970", VA = "0x186A6D970")]
	public static void GNBFIEDPPDF(this PPGBFCAEJCE JPEJLAFDCGN, IHGNLFDACDF KJKEGAFLFDE, MCMBKLFDKDM PDOOMGNBLHC, bool CHDBJECLGJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public readonly struct DHHDMIAEJAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NativeBitArray IEAPOIJLAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NativeParallelHashMap<IHGNLFDACDF, int> PBIACKFOJDI;

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public bool AJKIJLIKGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F8E0", Offset = "0x6A6E8E0", VA = "0x186A6F8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x42B39A0", Offset = "0x42B29A0", VA = "0x1842B39A0")]
	public DHHDMIAEJAJ(NativeBitArray IEAPOIJLAMO, NativeParallelHashMap<IHGNLFDACDF, int> PBIACKFOJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F7B0", Offset = "0x6A6E7B0", VA = "0x186A6F7B0")]
	public bool KLBNKJOIHGO(IHGNLFDACDF KJKEGAFLFDE, MCMBKLFDKDM PDOOMGNBLHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface BFMAKEEHCDC
{
	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKDGBACNGHM(AAEGPHPJNLD OJMEEMCEEJO, COADBPFMFML CBAEIEAPLIH);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface DNCIJFCHMPD
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	JEPJJIBBHEG OOGJDKLBLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface AHDEJAGODBM
{
	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFFAEECJCJJ(World NONINMLLOEG);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIMLKFLAIFD(World NONINMLLOEG);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase EACAGCBODIN(World NONINMLLOEG);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IKIBILOCKLF(World NONINMLLOEG);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FENANGHPKCJ(World NONINMLLOEG);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LKHFDIDGKPI(World NONINMLLOEG);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[PBELGAHGGLA(AFHNLDKMONP.LoadInstance)]
public interface GLEGENNEIHO
{
	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMLNNKFKLIA(AAEGPHPJNLD BMKMOMMIDOK, bool CBAEIEAPLIH);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public readonly struct FEFLKCCKIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IEnumerable<CCIEDDKOBBB> DGOFCABMPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IReadOnlyList<GameObject> BBPJJMMNAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IReadOnlyList<int> LAPDJHDAKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IReadOnlyList<(IHGNLFDACDF, IHGNLFDACDF)> KGKDKKBAMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly int CELJJGNMMLO;

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public bool DJDJJCHPPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A704E0", Offset = "0x6A6F4E0", VA = "0x186A704E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public int AJGOPKEGLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8DB860", Offset = "0x8DA860", VA = "0x1808DB860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public IEnumerable<GameObject> GCNINIFBHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EC0", Offset = "0x8D3EC0", VA = "0x1808D4EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public IEnumerable<(IHGNLFDACDF src, IHGNLFDACDF dst)> FNLCBKPIGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A708D0", Offset = "0x6A6F8D0", VA = "0x186A708D0")]
	public FEFLKCCKIIP(IEnumerable<CCIEDDKOBBB> DGOFCABMPCN, IReadOnlyList<GameObject> BBPJJMMNAJL, IReadOnlyList<int> LAPDJHDAKJL, IReadOnlyList<(IHGNLFDACDF src, IHGNLFDACDF dst)> KGKDKKBAMNM, int CELJJGNMMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A70540", Offset = "0x6A6F540", VA = "0x186A70540")]
	public (GameObject, int)[] IOMNPPIHFFG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface EHDPLJJOOFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	bool BPLOKNBELLC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	bool GOAPHAHILBN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	LHFEONGPPNE NJOFPNPKHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IKAAGBJIMOL PJPACFGIBAA();

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IKAAGBJIMOL CAMCIMIPMIG(IEnumerable<AAEGPHPJNLD> HDPAMFPMPBB, [In] UniformTRS BKAPGIBJAKH);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EOIAHLNHHGC PPPLMOIJOEE(ByteString AGBKLGLHMIF);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NNPGOIOIDCP CDCACIHJDLA(ByteString BCFBKOPNCPH, AAEGPHPJNLD HHMPHBNGMGF, [In] UniformTRS DJBNFFAKFBG, KMJJDNNNMFC OEGHNALGHJP, bool OPCKIKOAGAG = true);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DONOGNEFMLD();

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FEFLKCCKIIP NIGLOLJPMAP(IEnumerable<CCIEDDKOBBB> DGOFCABMPCN);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class FDKLKJELCCH
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface GNCBDFHJCHP
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action KHDCJFDPKGO;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action LADANEFAPLC;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct AGHNCEKJDPP : NNMDLAGCFGL, IEquatable<AGHNCEKJDPP>
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static readonly int JDJNKBAAKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public HMNDHIDLGHN HKILDBKKLEG;

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C1B0", Offset = "0x6A6B1B0", VA = "0x186A6C1B0", Slot = "5")]
	public void JGNOLJBBCJA(BLKOOHNENMA DHKLMNOOPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C1E0", Offset = "0x6A6B1E0", VA = "0x186A6C1E0", Slot = "4")]
	public void KLDBPIDHOEH(MLEEDCPGPGM OGONFGJBIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C210", Offset = "0x6A6B210", VA = "0x186A6C210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x9FE480", Offset = "0x9FD480", VA = "0x1809FE480", Slot = "6")]
	public bool Equals(AGHNCEKJDPP LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C110", Offset = "0x6A6B110", VA = "0x186A6C110", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0xA8D560", Offset = "0xA8C560", VA = "0x180A8D560", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct CCIEDDKOBBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Guid NNFEKLKANBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public string MHPCMEBOPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Vector3 MOIICCIPACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Quaternion ADNGPFKNGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Vector3 GNMLLHFGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int EHEKGLJLIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Dictionary<string, object> LIIDINHCICD;

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E1D0", Offset = "0x6A6D1D0", VA = "0x186A6E1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E040", Offset = "0x6A6D040", VA = "0x186A6E040")]
	private static string AHLIAMMJLAI(Dictionary<string, object> MNOLCMCDDNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum JJMGNGBNPJM
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	SubGraphReplace,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	RestoreCreationData
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class NHJGJEKEEDE
{
	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D8C0", Offset = "0x5E8C8C0", VA = "0x185E8D8C0")]
	public static bool CJNJDBPGCJD(this JJMGNGBNPJM PBLNJHEPKAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[Flags]
public enum JKAMMPOINJJ
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	AdditivePhases = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface NNPGOIOIDCP : LHFEONGPPNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	KMJJDNNNMFC OBPLLOKKLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGBGEMHOKIJ();

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIDJLLHOAAL();
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface LHFEONGPPNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	IEnumerable<CCIEDDKOBBB> KHLFMFEFAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	FEFLKCCKIIP BAIKNGOPEGO
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	JJMGNGBNPJM MDBCEFGBENA
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	LocalId HFJGIPIADLH
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	HDPIOIPNLMC BIGOKDKPBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KBOIAJIAKAK(JKAMMPOINJJ KJHJBBIKMPP);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface KMJJDNNNMFC
{
	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJDOCPICEKL(Guid LPPNOBMEEDD, [Out] Guid FIEEIAHPDIF);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface EOIAHLNHHGC : LHFEONGPPNE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[Flags]
public enum EAPCFHHLMMD
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface IKAAGBJIMOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	HDPIOIPNLMC MEDMFLBPNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString MILBMNPEDDO();
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum NHPOBDPLAKA
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public delegate bool EHNOFHCJJFB(MNICGLDKPAL AHFOPEDIGCH, [In] BBEAFPNMONC CBAEIEAPLIH);
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public delegate bool MNHFNHKOCME<T>(MNICGLDKPAL AHFOPEDIGCH, [In] T CBAEIEAPLIH);
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface FMMCEECLHGL
{
	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIKNDMFIIPK(MCMBKLFDKDM JEKFLJBJJDA, Type OIPFCDCFKKJ, EHNOFHCJJFB LONMANCOKGC);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCDLMGEAJFD(MCMBKLFDKDM JEKFLJBJJDA, [Out] EHNOFHCJJFB LONMANCOKGC);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class HMFILMNCKIG
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class OABEFNPKJHK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public MNHFNHKOCME<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public OABEFNPKJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x4675780", Offset = "0x4674780", VA = "0x184675780")]
		internal bool BIMPIPIMEPM(MNICGLDKPAL pendingList, [In] BBEAFPNMONC value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x2B28CB0", Offset = "0x2B27CB0", VA = "0x182B28CB0")]
	public static void PIKNDMFIIPK<T>(this FMMCEECLHGL FCILLGGMCPH, MCMBKLFDKDM JEKFLJBJJDA, MNHFNHKOCME<T> LONMANCOKGC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A73E20", Offset = "0x6A72E20", VA = "0x186A73E20")]
	public static bool GBJEMFDIPDI(this FMMCEECLHGL FCILLGGMCPH, MNICGLDKPAL AHFOPEDIGCH, MCMBKLFDKDM JEKFLJBJJDA, [In] BBEAFPNMONC CBAEIEAPLIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface DGLMMGLEEGC
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	uint OHENDCAIDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface MNICGLDKPAL
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBOCAPHHOKG(IHGNLFDACDF ALDLBBLDPLI, MCMBKLFDKDM JEKFLJBJJDA, ReadOnlySpan<byte> PCBDKMNOAFG, ReadOnlySpan<byte> IHFKNGIALPP);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPHBAKLNIFO(IHGNLFDACDF ALDLBBLDPLI, MCMBKLFDKDM JEKFLJBJJDA, ReadOnlySpan<byte> PCBDKMNOAFG, ReadOnlySpan<byte> IHFKNGIALPP);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OIDHNLMKNJG(IHGNLFDACDF ALDLBBLDPLI, MCMBKLFDKDM JEKFLJBJJDA);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EAMGAIPPEDP(IHGNLFDACDF ALDLBBLDPLI, MCMBKLFDKDM JEKFLJBJJDA, ReadOnlySpan<byte> IHFKNGIALPP);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HOCBGGMDJCB(IHGNLFDACDF ALDLBBLDPLI, MCMBKLFDKDM JEKFLJBJJDA, Span<byte> PCBDKMNOAFG, Span<byte> IHFKNGIALPP);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class NJFHJAFIKDP
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E790", Offset = "0x2C8D790", VA = "0x182C8E790")]
	public static bool HOCBGGMDJCB<T>(this MNICGLDKPAL HOGBBBKKLHN, IHGNLFDACDF ALDLBBLDPLI, MCMBKLFDKDM JEKFLJBJJDA, [Out] T PCBDKMNOAFG, [Out] T IHFKNGIALPP) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E650", Offset = "0x2C8D650", VA = "0x182C8E650")]
	public static bool EAMGAIPPEDP<T>(this MNICGLDKPAL HOGBBBKKLHN, IHGNLFDACDF ALDLBBLDPLI, MCMBKLFDKDM JEKFLJBJJDA, T IHFKNGIALPP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum AOBOGIDLHCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface FCGDFFDKMEI
{
	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBDDJJGOGBM(NPMFKGEOOMP CHNGFEKJHON, ReadOnlySpan<byte> HJCJCIIFPJE);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCEMGEGKHHI(uint LDJGNLKFNHF, ReadOnlySpan<byte> HJCJCIIFPJE);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENJPLFCPODC(int PKIAGNLGIPF);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface NPDHIMJFBIE
{
	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPMFKGEOOMP DNBIDOJOPDI(ReadOnlySpan<byte> HJCJCIIFPJE);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface MBPGNPDEGDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNDPAAAMDCJ(NPMFKGEOOMP BHEIPBKEDLG, ReadOnlySpan<byte> HJCJCIIFPJE);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONBHLMPGAFO(ReadOnlySpan<NPMFKGEOOMP> NMNPPJKNCHC);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct NKNPNFBCMDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public NPMFKGEOOMP CHNGFEKJHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public ReadOnlyMemory<byte> HJCJCIIFPJE;
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct NPMFKGEOOMP
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static NPMFKGEOOMP BHPIJKLNEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public uint DEOBIPHBNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public int ILDHJNIKEBC;

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0xC57490", Offset = "0xC56490", VA = "0x180C57490")]
	public NPMFKGEOOMP(uint DEOBIPHBNIF, int ILDHJNIKEBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BA60", Offset = "0x6A7AA60", VA = "0x186A7BA60")]
	public static bool JEKPEIKHIPM([In] NPMFKGEOOMP ILBMPADICAD, [In] NPMFKGEOOMP BEOPIALHGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B980", Offset = "0x6A7A980", VA = "0x186A7B980", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BA30", Offset = "0x6A7AA30", VA = "0x186A7BA30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BA80", Offset = "0x6A7AA80", VA = "0x186A7BA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B970", Offset = "0x6A7A970", VA = "0x186A7B970")]
	public void CLDPEJLCOKN([Out] uint DEOBIPHBNIF, [Out] int ILDHJNIKEBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface HPCKHDFBPFD : DGPFBNNIPCJ<HPCKHDFBPFD>
{
	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCOKGBINLEI(MCMBKLFDKDM BLCJLIJFBDL, [Out] CBPOPECAINB AABBBPHCHCD);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class LEJFHIBJPHG
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public interface CBPOPECAINB
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	Type IDMEPKALPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGNOLJBBCJA(BLKOOHNENMA DHKLMNOOPAJ, Span<byte> PKMPGPJICGL);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLDBPIDHOEH(MLEEDCPGPGM OGONFGJBIBI, ReadOnlySpan<byte> CHNGFEKJHON);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class DNPIIDEOMJC
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct ONEPIGBHIBO : ISystemStateComponentData, IComponentData, IEquatable<ONEPIGBHIBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 FDFNHNMGEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3 NDMFGICLLJA;

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CE10", Offset = "0x6A7BE10", VA = "0x186A7CE10", Slot = "4")]
	public bool Equals(ONEPIGBHIBO LJAAPFIIPOF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class ECFAFCMGIDH
{
	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public ECFAFCMGIDH()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
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
