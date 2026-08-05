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
	public class LogRegistrationIndex : MKCMLEJGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69E12E0", Offset = "0x69DFAE0", VA = "0x1869E12E0", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GKGBDIGBIEC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69DD410", Offset = "0x69DBC10", VA = "0x1869DD410")]
	public static void ENHAHBCLGLP(this Rigidbody JNPMEKFEALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69DD2E0", Offset = "0x69DBAE0", VA = "0x1869DD2E0")]
	public static void ENHAHBCLGLP(this Rigidbody JNPMEKFEALJ, Vector3 CIOHKGBHELC, Quaternion PBLCAIBKDLE, Vector3 DJKGFLPPFDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct GKELIELGPBO : IReadOnlyList<GABGGJOAGAC>, IEnumerable<GABGGJOAGAC>, IEnumerable, IReadOnlyCollection<GABGGJOAGAC>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct GOHIMMAHJOD : IEnumerator<GABGGJOAGAC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly JNPMLJAJCFH OOCDOIDHCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator OBCBMANCKCF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GABGGJOAGAC EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x69DD6E0", Offset = "0x69DBEE0", VA = "0x1869DD6E0", Slot = "4")]
			get
			{
				return default(GABGGJOAGAC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x69DD660", Offset = "0x69DBE60", VA = "0x1869DD660", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4221350", Offset = "0x421FB50", VA = "0x184221350")]
		public GOHIMMAHJOD(JNPMLJAJCFH OOCDOIDHCLB, NativeArray<LocalId>.Enumerator OBCBMANCKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69DD5A0", Offset = "0x69DBDA0", VA = "0x1869DD5A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69DD5E0", Offset = "0x69DBDE0", VA = "0x1869DD5E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69DD620", Offset = "0x69DBE20", VA = "0x1869DD620", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly JNPMLJAJCFH OOCDOIDHCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> CHNFMEBDLMI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GABGGJOAGAC NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69DD2A0", Offset = "0x69DBAA0", VA = "0x1869DD2A0", Slot = "4")]
		get
		{
			return default(GABGGJOAGAC);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69DCD30", Offset = "0x69DB530", VA = "0x1869DCD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int GFELLJPDKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8509A0", VA = "0x1808521A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8509A0", VA = "0x1808521A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ICKOEOOAKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69DCD80", Offset = "0x69DB580", VA = "0x1869DCD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> HDCLAICKCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x25617C0", Offset = "0x255FFC0", VA = "0x1825617C0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> IOHENKNJGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69DCCD0", Offset = "0x69DB4D0", VA = "0x1869DCCD0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69DD0C0", Offset = "0x69DB8C0", VA = "0x1869DD0C0")]
	public GKELIELGPBO(int HHGNDILCLEE, JNPMLJAJCFH OOCDOIDHCLB, Allocator CHDJMCMMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x42211C0", Offset = "0x421F9C0", VA = "0x1842211C0")]
	public GKELIELGPBO(JNPMLJAJCFH OOCDOIDHCLB, NativeArray<LocalId> CHNFMEBDLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69DD050", Offset = "0x69DB850", VA = "0x1869DD050")]
	internal GKELIELGPBO(JNPMLJAJCFH OOCDOIDHCLB, NativeArray<Entity> JPHDFJFJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69DD150", Offset = "0x69DB950", VA = "0x1869DD150")]
	public GKELIELGPBO(JNPMLJAJCFH OOCDOIDHCLB, int OMJPDIKPOLO, Allocator CHDJMCMMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69DD1F0", Offset = "0x69DB9F0", VA = "0x1869DD1F0")]
	public GKELIELGPBO(GKELIELGPBO EKPNKHBKOKN, Allocator CHDJMCMMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69DCDC0", Offset = "0x69DB5C0", VA = "0x1869DCDC0")]
	public GKELIELGPBO JGFBHDIGANM(Allocator CHDJMCMMMLJ = Allocator.Temp)
	{
		return default(GKELIELGPBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69DCC90", Offset = "0x69DB490", VA = "0x1869DCC90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69DCC00", Offset = "0x69DB400", VA = "0x1869DCC00")]
	public GOHIMMAHJOD DCPEOMEKOMK()
	{
		return default(GOHIMMAHJOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69DCE70", Offset = "0x69DB670", VA = "0x1869DCE70", Slot = "6")]
	private IEnumerator<GABGGJOAGAC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69DCF60", Offset = "0x69DB760", VA = "0x1869DCF60", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct HOCFFLIANIC : IList<GABGGJOAGAC>, ICollection<GABGGJOAGAC>, IEnumerable<GABGGJOAGAC>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AIJGLPMJDLH : IEnumerator<GABGGJOAGAC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly JNPMLJAJCFH OOCDOIDHCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator OBCBMANCKCF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GABGGJOAGAC EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x69D4510", Offset = "0x69D2D10", VA = "0x1869D4510", Slot = "4")]
			get
			{
				return default(GABGGJOAGAC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69D4490", Offset = "0x69D2C90", VA = "0x1869D4490", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4221350", Offset = "0x421FB50", VA = "0x184221350")]
		public AIJGLPMJDLH(JNPMLJAJCFH OOCDOIDHCLB, NativeArray<LocalId>.Enumerator OBCBMANCKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69D43D0", Offset = "0x69D2BD0", VA = "0x1869D43D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69D4410", Offset = "0x69D2C10", VA = "0x1869D4410", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69D4450", Offset = "0x69D2C50", VA = "0x1869D4450", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JNPMLJAJCFH OOCDOIDHCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> CHNFMEBDLMI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GABGGJOAGAC NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69DF690", Offset = "0x69DDE90", VA = "0x1869DF690", Slot = "4")]
		get
		{
			return default(GABGGJOAGAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69DF710", Offset = "0x69DDF10", VA = "0x1869DF710", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69DF130", Offset = "0x69DD930", VA = "0x1869DF130", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69DF130", Offset = "0x69DD930", VA = "0x1869DF130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69DF570", Offset = "0x69DDD70", VA = "0x1869DF570")]
	public HOCFFLIANIC(int HHGNDILCLEE, JNPMLJAJCFH OOCDOIDHCLB, Allocator CHDJMCMMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69DF4F0", Offset = "0x69DDCF0", VA = "0x1869DF4F0")]
	public HOCFFLIANIC(JNPMLJAJCFH OOCDOIDHCLB, Allocator CHDJMCMMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69DF600", Offset = "0x69DDE00", VA = "0x1869DF600")]
	public HOCFFLIANIC(JNPMLJAJCFH OOCDOIDHCLB, int OMJPDIKPOLO, Allocator CHDJMCMMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69DF170", Offset = "0x69DD970", VA = "0x1869DF170")]
	public GKELIELGPBO PHCBFJOGADO()
	{
		return default(GKELIELGPBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69DED00", Offset = "0x69DD500", VA = "0x1869DED00", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69DED40", Offset = "0x69DD540", VA = "0x1869DED40", Slot = "13")]
	public bool Contains(GABGGJOAGAC JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69DEDD0", Offset = "0x69DD5D0", VA = "0x1869DEDD0", Slot = "14")]
	public void CopyTo(GABGGJOAGAC[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69DEC80", Offset = "0x69DD480", VA = "0x1869DEC80", Slot = "11")]
	public void Add(GABGGJOAGAC JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69DF080", Offset = "0x69DD880", VA = "0x1869DF080", Slot = "7")]
	public void Insert(int DHNLEFJCEAH, GABGGJOAGAC JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69DF240", Offset = "0x69DDA40", VA = "0x1869DF240", Slot = "15")]
	public bool Remove(GABGGJOAGAC JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69DEFF0", Offset = "0x69DD7F0", VA = "0x1869DEFF0", Slot = "6")]
	public int IndexOf(GABGGJOAGAC JNHGHHKKNBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69DF1F0", Offset = "0x69DD9F0", VA = "0x1869DF1F0", Slot = "8")]
	public void RemoveAt(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69DEFB0", Offset = "0x69DD7B0", VA = "0x1869DEFB0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69DEF20", Offset = "0x69DD720", VA = "0x1869DEF20")]
	public AIJGLPMJDLH DCPEOMEKOMK()
	{
		return default(AIJGLPMJDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69DF310", Offset = "0x69DDB10", VA = "0x1869DF310", Slot = "16")]
	private IEnumerator<GABGGJOAGAC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69DF400", Offset = "0x69DDC00", VA = "0x1869DF400", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JJCDLIMMMGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int CPOGECPOILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> NFOJAAJINHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GABGGJOAGAC NHKMEMDEKAN(GABGGJOAGAC CHNFMEBDLMI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BFAEDPNBBAF : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface DIKOLGBPMBC : EEHAOFHDLLJ, AMHKPPIPMFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OJBMAONCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OIHGCBMPJIK OOKHALIPCPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DIEKLFPNCND FHLDEIAENCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	AEBOEOPEMGA OGFIPIIMJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface AMHKPPIPMFB
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool INMPDDDBHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface GDHDMIMJKNB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIOFGOJFDIK(bool JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[MIFNEPPJGEL(MEHPOACPKMP.PhotonRoom)]
public interface MPCIABBOJDH
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool ONLEHMBACCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBOPJINFEFP(bool CKPMODOEIJG);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGAIAFHAHDE();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JINHMPLHGAN(ByteString OEECENNMMAJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMHCPPFHFMG();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDNAIOFGFGE();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBLDDMKPKJH();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONIMGDEMHHK();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JAMNGCEMLJJ();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface AOFDGEECKBG
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	GANFHFOELEK OOKHALIPCPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	DIEKLFPNCND FHLDEIAENCE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MICAOJNNFIH COAFHJDLOOM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	NHBENDOGJAH HFOGFNNFPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	DIKOLGBPMBC CCEAIKPBENO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	MPCIABBOJDH KGLBBAHODAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	POBIDGNADJJ HLKMCIAHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DPGMADCKOBA NLMICFPENFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IBBPDEFLGDF HHJMBKAACGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IBDNEEIKJMF EDELPCANPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	DLONBJHNDJH DMKKPIJIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	POINGCHJLAH PKOFPBDPLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	OFEKIPCHALB MMPLFOCBAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	DBJGJGMBFAK GGGMPCGMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	IJNFJLIGAJO DKENCIKCDGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	JGMHBGJEPKB CLLEEGICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HCJHILDMOKD PPOJOFFDOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IJBPABNCBJO CKHMAGIHKBH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	PHECFDNIMBH NIHGNIMCPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	JJMNFIGHGIC IAKGCONALDF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OFEPENDBMGL IIKACCPHIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	EMMAIEDAFKE MNLEAPKAFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	EKAKMJMKEBD POAFFDPIMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	ABGGAFKHAHA ALMJPPIFKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	LAOEJNLDMGI EKMBCJLANIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	LEFLJIPBKBD LEDLCIHHGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JEKIHDFEEAJ AMCLNMJBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IKFFFOFMOAK COLDBCCAJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(ANBNLAGENCL))]
public readonly struct GABGGJOAGAC : IComparable<GABGGJOAGAC>, IEquatable<GABGGJOAGAC>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly GABGGJOAGAC ADOHMNBGCKE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int OCFMAPAMFAL = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int HBAMGPINBBM = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int EFKJKNEJDBF = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int AIGGAFHDLBC = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId DIHIHJFDGDD;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DIKOLGBPMBC CCEAIKPBENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69DBF70", Offset = "0x69DA770", VA = "0x1869DBF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LocalId FHGJCLGKEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69DBD90", Offset = "0x69DA590", VA = "0x1869DBD90")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal AEBOEOPEMGA OGFIPIIMJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69DC110", Offset = "0x69DA910", VA = "0x1869DC110")]
		get
		{
			return default(AEBOEOPEMGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool LNFEOGNEOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69DBFD0", Offset = "0x69DA7D0", VA = "0x1869DBFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool KODNPDKJOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69DBAC0", Offset = "0x69DA2C0", VA = "0x1869DBAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69DC250", Offset = "0x69DAA50", VA = "0x1869DC250")]
	public GABGGJOAGAC(JNPMLJAJCFH JOBEIIBKBJK, LocalId DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
	public CFLIGJNFJEC KMIPMAGDPJJ()
	{
		return default(CFLIGJNFJEC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69DBDD0", Offset = "0x69DA5D0", VA = "0x1869DBDD0")]
	public static LocalId GCLAHEGAFFN(GABGGJOAGAC IMGDBDKAGGK)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69DBE10", Offset = "0x69DA610", VA = "0x1869DBE10")]
	public static Entity GCLAHEGAFFN(GABGGJOAGAC IMGDBDKAGGK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69DBE50", Offset = "0x69DA650", VA = "0x1869DBE50")]
	public static bool KBKLEFBHIDJ(GABGGJOAGAC MLFGLJKBOIG, GABGGJOAGAC GANEOONFJPD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69D6990", Offset = "0x69D5190", VA = "0x1869D6990")]
	public static bool HFGDCBGDPAJ(GABGGJOAGAC MLFGLJKBOIG, GABGGJOAGAC GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69DC120", Offset = "0x69DA920", VA = "0x1869DC120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69DBBF0", Offset = "0x69DA3F0", VA = "0x1869DBBF0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69DBB10", Offset = "0x69DA310", VA = "0x1869DBB10", Slot = "4")]
	public int CompareTo(GABGGJOAGAC OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "5")]
	public bool Equals(GABGGJOAGAC OKGBBGMIACH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NNFFCOLKILH
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69E3D60", Offset = "0x69E2560", VA = "0x1869E3D60")]
	public static EPOHMNPJENA GNENDEMPCNN(this GABGGJOAGAC MEAFIMADMKA)
	{
		return default(EPOHMNPJENA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69E3CB0", Offset = "0x69E24B0", VA = "0x1869E3CB0")]
	public static CFLIGJNFJEC AEKINDMADHN(this GABGGJOAGAC MEAFIMADMKA)
	{
		return default(CFLIGJNFJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2C94E30", Offset = "0x2C93630", VA = "0x182C94E30")]
	public static T GKCALIEKENI<T>(this GABGGJOAGAC MEAFIMADMKA) where T : struct, COGEFBNNGIJ
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class ANBNLAGENCL
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AEBOEOPEMGA : IEquatable<AEBOEOPEMGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte IIMJMBJHGDI;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] GHJAKKOFDML;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static JNPMLJAJCFH EEMMKJLHHIL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static DIKOLGBPMBC MFJOMMMGOBM;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static JNPMLJAJCFH[] DMPBFJMNIHG;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static DIKOLGBPMBC[] OKHILADKFLP;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> CPEOKPCMKBI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DIKOLGBPMBC CCEAIKPBENO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E20", Offset = "0x69D2620", VA = "0x1869D3E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public JNPMLJAJCFH KDAGDBHJHOP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69D39C0", Offset = "0x69D21C0", VA = "0x1869D39C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69D43C0", Offset = "0x69D2BC0", VA = "0x1869D43C0")]
	static AEBOEOPEMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x216D990", Offset = "0x216C190", VA = "0x18216D990")]
	internal AEBOEOPEMGA(byte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B0A0", Offset = "0x5B398A0", VA = "0x185B3B0A0", Slot = "4")]
	public bool Equals(AEBOEOPEMGA OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69D3570", Offset = "0x69D1D70", VA = "0x1869D3570", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D74020", Offset = "0x1D72820", VA = "0x181D74020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69D4300", Offset = "0x69D2B00", VA = "0x1869D4300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69D34C0", Offset = "0x69D1CC0", VA = "0x1869D34C0")]
	private static JNPMLJAJCFH CBFHLJGOIGC(byte IIMJMBJHGDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69D3D70", Offset = "0x69D2570", VA = "0x1869D3D70")]
	private static DIKOLGBPMBC LCEDECKICLI(byte IIMJMBJHGDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x69D3F80", Offset = "0x69D2780", VA = "0x1869D3F80")]
	private static object NPFFBEKIPFM(byte IIMJMBJHGDI, object[] MNHECFLLMJH, object LIAHLPBCKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x69D39B0", Offset = "0x69D21B0", VA = "0x1869D39B0")]
	private static int GPKBJEJNHHG(byte IIMJMBJHGDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x69D3AA0", Offset = "0x69D22A0", VA = "0x1869D3AA0")]
	private static int ICKPOHFJOGL(byte IIMJMBJHGDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x69D3F00", Offset = "0x69D2700", VA = "0x1869D3F00")]
	private static (int, int) NBDMGEHAIIF(byte IIMJMBJHGDI)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69D3610", Offset = "0x69D1E10", VA = "0x1869D3610")]
	private static byte FIOPKCBMPBJ(int DMDAEILPBHA, int DHNLEFJCEAH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x69D3AB0", Offset = "0x69D22B0", VA = "0x1869D3AB0")]
	internal static AEBOEOPEMGA JGBCFAKMKJN(DIKOLGBPMBC FJMAFAKODJA, JNPMLJAJCFH DNFBBDCFPKG)
	{
		return default(AEBOEOPEMGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69D40F0", Offset = "0x69D28F0", VA = "0x1869D40F0")]
	internal static void ODKKLEIBHOA(AEBOEOPEMGA IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x69D3620", Offset = "0x69D1E20", VA = "0x1869D3620")]
	private static void FJIFLAMOAMH(int HHGNDILCLEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface PIOIELIBBJK
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNLBGGNEFGG();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPHOMJHHHEB(bool EEPLEMKIBLI);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGOIKMMCJFL(GameObject NBDLDMDNCAL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface GPHGMGDMJBH
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Guid OCBDIJEAPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HEEEFOFGIGF(Guid AHGHNIKKDCB, Guid DJMPLCHOJFC, Guid EAJKBIMCNLG);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Guid LPMCGOMNLLB(Guid KDKOCALOMKG);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PIAMBFKKLFF(GABGGJOAGAC PBDAHGLIECA);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JNGCBEMDFFD(HONENIKELML EKEHHJEGPDH, Guid GEGFKBFLKIO);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HINEFLEAOBD(Guid KDKOCALOMKG, bool CKPMODOEIJG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface PLEABHBHJMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEMDBKPGMMH(GKELIELGPBO CHNFMEBDLMI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface ADAMINBFJJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIMCIINJMLA(GameObject NNKDEPLNLDD, GameObject NLBNEHEEPNO, int BBAPIEOEPFB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface DIEKLFPNCND
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	PIOIELIBBJK JDPJMOELGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OLNHBGMBEDI OOIBDHLMAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	AELGLMOICGH GNOCAJKDFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	OMLIJILBDIH NJIKKJPDJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	DKIJMHLCFON NKEPNOGIJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LGJNKHKNGID JGKCJDDNMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	KAHNHPGMDNN PABJJCKHKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	MOIFOHOIPFH JFJKJAABGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	IOHDBMPCENP NPBJBDEPKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	LLFFDJJIAPK LILNNLGPEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface OLNHBGMBEDI
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string DKJOBEDJFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface KOGBAGMIPCB
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APKHHFCIPAJ(Action ENGMCBPHJGL, bool MCPJDAHANGI);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JDBNHMCPBOI(string BHFPKCCDEEC);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IHBFIGKDFOL(string BHFPKCCDEEC, int LIAHLPBCKNO);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JOACFEKJKOL([Out] bool JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IJLICCJPHBP([Out] bool JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GDGMKLBDPLC([Out] int JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface AELGLMOICGH
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string JAKOHLAMGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] NFAGGBCOMNF(IEnumerable<OPJAFGJLOGE> AEJHJMIIJFA, bool BOKNMFBAFEL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IECGOPFCMNM(GameObject NBDLDMDNCAL, [Out] EPOHMNPJENA[] BMNAGJGIMFF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OGGFGDDNGNL(GameObject NBDLDMDNCAL, [Out] int AIFFADKBHCI, [Out] DOELAEOOEOB LNPLCOCFIOP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HONENIKELML NDBFJBMPBKE(OPJAFGJLOGE GPCNCGBOPJG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HONENIKELML NDBFJBMPBKE(string MIMBCLCGJGF, EPOHMNPJENA[] JHDNEHLEBCI, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, Vector3 CDPPGBMBKAI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HONENIKELML ANEMFECJJLE(string MIMBCLCGJGF, EPOHMNPJENA[] JHDNEHLEBCI, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, Vector3 CDPPGBMBKAI);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject KBNHIKEKAHB(string MIMBCLCGJGF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MJBKDLJMAKK(GameObject LNPMJHCPJGC, bool ECOAPNDMJEJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void APBMHMIBHNL(GameObject NBDLDMDNCAL, bool GOGMFKIBMBJ, bool JGEHBANNOJC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class OMMLLFIFOCI
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x69E4EA0", Offset = "0x69E36A0", VA = "0x1869E4EA0")]
	public static HONENIKELML NDBFJBMPBKE(this AELGLMOICGH EKMGPIDNBAL, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, Vector3 CDPPGBMBKAI, params EPOHMNPJENA[] BMNAGJGIMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x69E4D40", Offset = "0x69E3540", VA = "0x1869E4D40")]
	public static HONENIKELML ANEMFECJJLE(this AELGLMOICGH EKMGPIDNBAL, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, Vector3 CDPPGBMBKAI, params EPOHMNPJENA[] BMNAGJGIMFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface OMLIJILBDIH
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOCACEDFGPH(bool CKPMODOEIJG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface DKIJMHLCFON
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BDLFDHJJMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool KFNLGFNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool GNEHDOJFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int MPKCLPEKKHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool DOBEMDDGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGGOJHCENCO(object MIJPDJDOIDB);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGJGGHHOGMH(object MIJPDJDOIDB);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BDMJGOLBIEE(object CGKANMHMCOJ);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HOOGHHLBDFM(object CGKANMHMCOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId NKEPDEFMPCE(GameObject JDNAMEBBFMB);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KNDODEIGDDB(NativeArray<ViewId> MCOJIEDAKKC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DHOPBMPPPOM(NativeArray<ViewId> AIALOIMCLJP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AILADFANLDC();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JCDJICIOGCL(uint DMHDBNDAJAC, ReadOnlySpan<byte> IPGGACMIEIP, bool EDPBKAOAPFE = false);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JCDJICIOGCL(uint DMHDBNDAJAC, ReadOnlySpan<byte> IPGGACMIEIP, ReadOnlySpan<byte> PKCJLICAODA, bool EDPBKAOAPFE = false);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KJLOMODHCMB(Func<int, bool, int> DCIJFGIEKHE, bool EOABINOAFCN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CIFNKOGFEKI(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FKGNKOBMNCB(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint GJMNIFOJOPH(uint NNJFFKDDDDA);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HFMEDFMHOGF
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x69DE790", Offset = "0x69DCF90", VA = "0x1869DE790")]
	public static ILGGJGLDGFF EDLLMGEICFE(this DKIJMHLCFON CFIPBNBFKLE, object EOCJCEFCOOA)
	{
		return default(ILGGJGLDGFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct ILGGJGLDGFF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private DKIJMHLCFON CFIPBNBFKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object EOCJCEFCOOA;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x69DFB10", Offset = "0x69DE310", VA = "0x1869DFB10")]
	public ILGGJGLDGFF(DKIJMHLCFON CFIPBNBFKLE, object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x69DFAC0", Offset = "0x69DE2C0", VA = "0x1869DFAC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface LGJNKHKNGID
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCHGKNPEPDP(GameObject NBDLDMDNCAL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface KAHNHPGMDNN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct NOHDPKAAAHN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private KAHNHPGMDNN MPINENFABFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Task LEDCCMOCHJB;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Task BFILLPLPPPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2900", VA = "0x1808C4100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x69E4800", Offset = "0x69E3000", VA = "0x1869E4800")]
		public NOHDPKAAAHN(KAHNHPGMDNN MPINENFABFJ, CancellationToken MPLGBOFHPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69E47B0", Offset = "0x69E2FB0", VA = "0x1869E47B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOMGLLKMOJJ(string JNNDBFGKHHD, float HIEBMCLPBGB = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PMHAKAPADKG(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBBBDHNCKIE();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LJEGDLOJMGC
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69E12C0", Offset = "0x69DFAC0", VA = "0x1869E12C0")]
	public static KAHNHPGMDNN.NOHDPKAAAHN NLJCHAJJBLA(this KAHNHPGMDNN CFIPBNBFKLE, CancellationToken MPLGBOFHPLM)
	{
		return default(KAHNHPGMDNN.NOHDPKAAAHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface EBFLBIDNOAN
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MECCOEDAIHK(GameObject NBDLDMDNCAL);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAIEIJAGIGK(GameObject NBDLDMDNCAL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EPIDPGHNINE(int JGJFKDCDFCE);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object GHCKFGLMJPH(GABGGJOAGAC DIHIHJFDGDD, GameObject NBDLDMDNCAL, Action<GABGGJOAGAC, int> HBBMMHKOEKK);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEHHMICIDFL(GameObject NBDLDMDNCAL, object GGHHEEAAJBE);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface MOIBOAKBLHI
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool FIECHMOMELE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate OHIDGNGAKNJ(DEOFFGKPJLI.FNJMFDANNOO PPLHNOMMHME, Action<DEOFFGKPJLI.FNJMFDANNOO> HBBMMHKOEKK);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IANAMBLNECO(DEOFFGKPJLI.FNJMFDANNOO PPLHNOMMHME, Delegate HBBMMHKOEKK);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate PLJKLNPEHMM(DEOFFGKPJLI.FNJMFDANNOO PPLHNOMMHME, Action<DEOFFGKPJLI.FNJMFDANNOO> CFKLJDNEPGJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJHKJKDDODP(DEOFFGKPJLI.FNJMFDANNOO PPLHNOMMHME, Delegate HBBMMHKOEKK);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GGCJPCDEOFO(DEOFFGKPJLI.FNJMFDANNOO PPLHNOMMHME);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DEOFFGKPJLI.FNJMFDANNOO DFOCFGALPKJ(GameObject NBDLDMDNCAL);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface MOIFOHOIPFH
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int ADAGLKBDPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	int CCHDFFGJAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LMPBDGLFPBD(GameObject NBDLDMDNCAL);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ICHKIKLCCEC([Out] Vector3 HGDCPNGLIKJ);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BKJMIAKOHID();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GABGGJOAGAC OKKBHMHNMIJ(int JGJFKDCDFCE);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface IOHDBMPCENP
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool ONLEHMBACCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface HLGFOADGMCC
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	BLBNGBCAMCL AFPHGFHDAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	OICKCGJIHKL BFBLINEGECI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABKGNFHPPOB(Transform FMAJPAMCPCL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJLPCPHCFAD(Transform FMAJPAMCPCL, DLNBBOCFFAG IJOMIOBDNPE);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHDIGKMALIF(Transform FMAJPAMCPCL, BCGPGMMDBCL AHGKEHOFKKH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface NJFODFPLNBM
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface LLFFDJJIAPK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GIBLHIJAIOG;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDHHPKHCOFI(GKELIELGPBO KGFDDFIGONO, bool MJEAMAFIMKN);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface FMHGMOHDKFN
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGCHPNLAJDA();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface JMKOGAGJMMG
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DOELAEOOEOB MGAAHIBJINM(GameObject JDNAMEBBFMB);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBDLEMBKGJB(GameObject NBDLDMDNCAL, PIHMGPGBMPI PMECLAHANGN, CIOMMKHJBAJ ACLHDNGIGCL);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NELLBNNBIKM(GABGGJOAGAC DIHIHJFDGDD, bool JNCAOJDDHDA, float3 FANHNPBGBJF, quaternion NPOODEJMHFG);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHAKMBCGAOI(CFLIGJNFJEC IDOOJPJNKLC, CFLIGJNFJEC CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBPFGLJFOMK(CFLIGJNFJEC IDOOJPJNKLC, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHILINCMNIN(GKELIELGPBO DMMKJGFJIMJ);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GEPGCNHFKJK(GKELIELGPBO OOCDOIDHCLB, NativeArray<LocalPoseData> EJKJDJNFILD, NativeArray<float3> NDAKFNEGMDF);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CLKNIJOMGNN(GKELIELGPBO OOCDOIDHCLB, GKELIELGPBO FCCKAHKIBKF);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BBCBCKAKEGN(GKELIELGPBO OOCDOIDHCLB, bool DCCHHKEMOHL);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HCEOBCGDIMO(GKELIELGPBO OOCDOIDHCLB, bool EDJHDJLKIMC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct FDDEKFOIKIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly CJOOEAMLHPI GBALKPFEDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly CJOOEAMLHPI DAOCGKJPECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly uint HGJCLGCOANP;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x69DB850", Offset = "0x69DA050", VA = "0x1869DB850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct CKILDPLIAFJ
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly FDDEKFOIKIO ENGMCBPHJGL;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69D6EA0", Offset = "0x69D56A0", VA = "0x1869D6EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct PKENMLDDAPP
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly FDDEKFOIKIO ENGMCBPHJGL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x69D6EA0", Offset = "0x69D56A0", VA = "0x1869D6EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct EKKFGEDMFNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly uint HGJCLGCOANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly bool IPGLKILAFJO;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x69DAAD0", Offset = "0x69D92D0", VA = "0x1869DAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CJOOEAMLHPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal int PENDBLHFGOI;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69D6E40", Offset = "0x69D5640", VA = "0x1869D6E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface NPBENHOCBJH
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	FINLOGNCBJL HBKHNMFHGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum FCGMOIACLCG
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
public interface HONENIKELML : KGGELMDIEKM
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	FCGMOIACLCG JHJJHMPJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool OLPKHIHIEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject NBDLDMDNCAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HONENIKELML> AGCIBBBIDHJ;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(MICAOJNNFIH FIFOANMDKIF, GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool COLIFCOLMGM);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BLEKKLBOJID
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69D6200", Offset = "0x69D4A00", VA = "0x1869D6200")]
	public static bool JOFAIAGLCGO(this HONENIKELML JEGEPAEEFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x69D61B0", Offset = "0x69D49B0", VA = "0x1869D61B0")]
	public static bool GHLFOLKMPNL(this HONENIKELML JEGEPAEEFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x69D62E0", Offset = "0x69D4AE0", VA = "0x1869D62E0")]
	public static bool OOKOAJHGGPF(this HONENIKELML JEGEPAEEFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x69D6250", Offset = "0x69D4A50", VA = "0x1869D6250")]
	public static bool OJBMAONCMFP(this HONENIKELML JEGEPAEEFCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KGGELMDIEKM
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool HPJBMFGHLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
internal interface FAJONHDODAE
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<EEFBLACHIAF> LHCJBOAKLCG;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface NJKBAENMPEF
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EAFENKCNDKA(Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, Vector3 CDPPGBMBKAI);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMADMDAOMMK(GABGGJOAGAC BMBBFJPOJEB);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGHHEPPGHAF(bool PKMIPPJCBKH);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICKFFKNOPHB(bool EDJHDJLKIMC);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface AJGKJECLEJP
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface ELAJNNPKBND
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(HJKEDKBDPPP FKLCKGCKOFN);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface HJKEDKBDPPP
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	GameObject NBDLDMDNCAL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Transform FMAJPAMCPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	LJEEPNBNNHB AHOOMFBOCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool FNFOMIAJIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EGIALLICKOG(LJEEPNBNNHB CIGKBEKHOLC);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LJEEPNBNNHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	HJKEDKBDPPP AKJLGFMEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	GameObject BGONLCODLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	LJEEPNBNNHB DHCIAOJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	int DGFFNAGFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool GGCJPCDEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool OMMEKKCNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	GCCHGDAONKB GLMHBPJHKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	LIJOKMDFOFH MCJHNAIMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	float OBLJBMFPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 PCBLAEINONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 NNHDGLHBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 DOJOOKOADMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool FGNIPGKHKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool DKNNPMBIPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool BOOAKEKDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 CHBOEELJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 EHOGFCCMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 MPKDNNPCOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 MLGKNLKHOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float CNPKCGDBOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float FKLAKHONCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Vector3 GLAIIHKCPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion IFMMPIPGKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float LGIGFNNJAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float JJGEJCPKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool FLNDLEBMONH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	EEPBOLJHLNK MCAKOHHFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool PBLHJBGBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform NFGKEMNGCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 EPEMKAANOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float DLMMKBPCBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float JDLKEDGCFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion KHCNENJLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 PCKAHHMDECP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion ACLOFDCFLFB
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints OFGMKLMDGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool FKLLLKFDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode AIBPEFBJHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool HJFGMLFHNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CEJKOKAHCJG GOMCPIIALCH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CEJKOKAHCJG KNBPNKNELBJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event CEJKOKAHCJG HFEDDJKAHPB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CEJKOKAHCJG HCDKLCFJLOG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CEJKOKAHCJG IDADILKKDPK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CEJKOKAHCJG LALHICAPNBA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CEJKOKAHCJG PDPOOKEFDLO;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event KFNJEADEOOD OLAGEKEIEFG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "26")]
	LJEEPNBNNHB BPLEDEIPGKB(int DHNLEFJCEAH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void BJNIMHBPEJI((Quaternion rot, Vector3 moments) CKEJAFLIMPB);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void PJMDLPKCJOP();

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void NFLKBJHAPNP();

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void IKNKANAKDJI();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void NMFKFBHACCD();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void MMADMDAOMMK(LJEEPNBNNHB JMDCGOKJIDA, bool DCIOAOCCLNO = false);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void GMBDJPNPBNI(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void CICBOHHFGOI(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 CMIOFOLPDBD(Vector3 FIMFMOJFCFJ);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 EHACCJENFAB(Vector3 NOGFFKGBCOL);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void FOFMMMJGGFN();

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void CELBLPAFCIH();

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void PMEPFJEJIDK();

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void FLNMHLJEABK(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void CHAAMCPOLKD(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void ADFDPALOCLC(Vector3 HGGENDDBBJC);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void OEHCHBFDEKM(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void LDGDMKCOGAH(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void JLBJDDHJOHM(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 IGGKIKFINPM(Vector3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 AGLJKLOFAKO(Vector3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void JOFNHGFIFKE();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void MCGHHLGPCDO(LJEEPNBNNHB KNDIPAMGJEH, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void ABPOJCBHDFP(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void KJDIAFCJJIF();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void MPNLKLPFHHL();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void JONIHJFPCDA();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool DBEPKAHMKBC();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void DENFDBJHBLN();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void DCIFLICONLL(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void KGHICEPBNMM(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void PAIMJFADCAB(object EOCJCEFCOOA, bool MCDOCGGGECM);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void DKOHPMAPHGG(Vector3 BELOINIPDIB, Quaternion HJPFNIDEMNG);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void MLABCGDNEEH(Vector3 LEDGGONKHOH, Quaternion GNOJHHCJPOC);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool PGOKKFJFMGD(float BONLJCBABLI);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void BKONGIFNHPB(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void DNKOPNCBMHI(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void CDBCEDMLJNK(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void OLCAAIPHEIP(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void KAPGLCIGOAI(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void APEKDDPMJIA(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void LPEOIJLIBJD(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void HDLFPCCLPMC(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool DLPAKOEIMOE(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void LFEIJDEHHMF();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface LIJOKMDFOFH
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INIKNEMPJGJ(Vector3 OILBCMOBKJC);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDHGDFGJFJA(Vector3 FJCOMDPBLBJ);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPIBCGHKKLG(Vector3 OILBCMOBKJC);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEEMOFJLECH(Vector3 FJCOMDPBLBJ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface GCCHGDAONKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 DIFJFDGIODF();

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BGIAFHGNAFC();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void CEJKOKAHCJG(HJKEDKBDPPP ONNCMMHMEDJ);
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum EDHCOAFNNDH
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
public enum CJOGEGMLKDO
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
public delegate void KFNJEADEOOD(HJKEDKBDPPP ONNCMMHMEDJ, bool DCIOAOCCLNO = false);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum JCBCIKFMAML
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct KPFNKPJMKHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Rigidbody AMBNMKKFJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public object HDDPEKIEOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector3 BAMHKCIJGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 MMOGMLHFAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ONPHIJJLPGG EEBPBEAOODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool JBOBICGFJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool LELALLGOGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool KOBHMAJIABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool DEBJJNADDHE;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KMJGOIDHDFF : GEAMBFFHPPA<EPOHMNPJENA>, MCDMJOHLAHJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface AFDJHBNEHLA<T> : IGFJFIIBDOJ<EPOHMNPJENA, T>, GEAMBFFHPPA<EPOHMNPJENA>, MCDMJOHLAHJ, IDisposable, KMJGOIDHDFF where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class PCMKKLEKBGE
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5120", Offset = "0x2CC3920", VA = "0x182CC5120")]
	public static bool FFKNBABIJFJ<T>(this GEAMBFFHPPA<EPOHMNPJENA> FMACLHMOMLJ, EPOHMNPJENA JHDNEHLEBCI, [Out] T JMDCGOKJIDA) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B68E70", Offset = "0x2B67670", VA = "0x182B68E70")]
	public static bool OLOHHMDPKEO<T>(this GEAMBFFHPPA<EPOHMNPJENA> FMACLHMOMLJ, EPOHMNPJENA JHDNEHLEBCI, [In] T BOKHJAMHCIH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface HJNODMPKEND : GEAMBFFHPPA<GABGGJOAGAC>, MCDMJOHLAHJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface LPLHIELOOOK<T> : IGFJFIIBDOJ<GABGGJOAGAC, T>, GEAMBFFHPPA<GABGGJOAGAC>, MCDMJOHLAHJ, IDisposable, HJNODMPKEND where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class HHOJNEKJFFH
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2995DE0", Offset = "0x29945E0", VA = "0x182995DE0")]
	public static T JMJOGDIBBHK<T>(this GEAMBFFHPPA<GABGGJOAGAC> FMACLHMOMLJ, GABGGJOAGAC DIHIHJFDGDD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B68E70", Offset = "0x2B67670", VA = "0x182B68E70")]
	public static bool OLOHHMDPKEO<T>(this GEAMBFFHPPA<GABGGJOAGAC> FMACLHMOMLJ, GABGGJOAGAC DIHIHJFDGDD, [In] T BOKHJAMHCIH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct MCGJEOBLIHK : IComparable<MCGJEOBLIHK>, IEquatable<MCGJEOBLIHK>
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly MCGJEOBLIHK ADOHMNBGCKE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly MCGJEOBLIHK EPOPADGJMEL;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MCGJEOBLIHK GBJBHGDBPJK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly MCGJEOBLIHK ONEFGNGDIKP;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly MCGJEOBLIHK LDCKGHAGABJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly MCGJEOBLIHK NGHIDBPOFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int LINJEMEJAMF;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool DCPCFNKMMBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x69E13B0", Offset = "0x69DFBB0", VA = "0x1869E13B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int CMCCCNOGIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x69E14B0", Offset = "0x69DFCB0", VA = "0x1869E14B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A710", VA = "0x180A7BF10")]
	public MCGJEOBLIHK(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x69E1450", Offset = "0x69DFC50", VA = "0x1869E1450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x69E13C0", Offset = "0x69DFBC0", VA = "0x1869E13C0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x9E8AC0", Offset = "0x9E72C0", VA = "0x1809E8AC0", Slot = "5")]
	public bool Equals(MCGJEOBLIHK OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1A89AF0", Offset = "0x1A882F0", VA = "0x181A89AF0", Slot = "4")]
	public int CompareTo(MCGJEOBLIHK OKGBBGMIACH)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0xE11F10", Offset = "0xE10710", VA = "0x180E11F10")]
	public static MCGJEOBLIHK GCLAHEGAFFN(int DHNLEFJCEAH)
	{
		return default(MCGJEOBLIHK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xE11F10", Offset = "0xE10710", VA = "0x180E11F10")]
	public static int GCLAHEGAFFN(MCGJEOBLIHK AOOLGPHJJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x69E14C0", Offset = "0x69DFCC0", VA = "0x1869E14C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct CFLIGJNFJEC : IEquatable<CFLIGJNFJEC>, KGGELMDIEKM
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CFLIGJNFJEC AIMBFAGEECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110", Slot = "6")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public EGEJPGJMOIP IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(EGEJPGJMOIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public NOGPFPJEJGG HLKMCIAHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(NOGPFPJEJGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public GameObject NBDLDMDNCAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x69D6BB0", Offset = "0x69D53B0", VA = "0x1869D6BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public EPOHMNPJENA AICPICJFEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x69D6890", Offset = "0x69D5090", VA = "0x1869D6890")]
		get
		{
			return default(EPOHMNPJENA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public LBAIEFEIHDD AJENEPDFBDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x69D6490", Offset = "0x69D4C90", VA = "0x1869D6490")]
		get
		{
			return default(LBAIEFEIHDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public DOELAEOOEOB AGNHIECKNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x69D6610", Offset = "0x69D4E10", VA = "0x1869D6610")]
		get
		{
			return default(DOELAEOOEOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool PLGMJLMCMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x69D6D40", Offset = "0x69D5540", VA = "0x1869D6D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool LOCPHBHBLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x69D6970", Offset = "0x69D5170", VA = "0x1869D6970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool IGMLHNBCBPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x69D6AF0", Offset = "0x69D52F0", VA = "0x1869D6AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool MDOGBJMGDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x69D6A90", Offset = "0x69D5290", VA = "0x1869D6A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool IMNPNBLCGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x69D6B90", Offset = "0x69D5390", VA = "0x1869D6B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool CMKPLPPDKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x69D69F0", Offset = "0x69D51F0", VA = "0x1869D69F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool OENALKPEKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x69D65D0", Offset = "0x69D4DD0", VA = "0x1869D65D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool IJBGMOLGOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x69D6930", Offset = "0x69D5130", VA = "0x1869D6930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool JDFJNFECINB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x69D66B0", Offset = "0x69D4EB0", VA = "0x1869D66B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public MIBIBCDEAJN FDIEMJLOGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(MIBIBCDEAJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public NPIIAIPJNCI KFPJPMMHONP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(NPIIAIPJNCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public EPNLPEIFFCF GGGMPCGMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(EPNLPEIFFCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public MMICEJDLNCE JMNMEANEEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(MMICEJDLNCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public JLMJDAKDPIC MMPLFOCBAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(JLMJDAKDPIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public EFCKDDNHLBP OOBHPKKFHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(EFCKDDNHLBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public GPOKGFHBMIA NHMLGHMGFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GPOKGFHBMIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public NJAIOMBKDEO DPANLNOJALM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(NJAIOMBKDEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public DMLFPIHOEBI ALFLAAONMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(DMLFPIHOEBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public BENEDMAEHDL CNMLFILADJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(BENEDMAEHDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public EPOJDNKNEHC EALMNKCOIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(EPOJDNKNEHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public ICBJNNPKKEF CMEOIKFHKON
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(ICBJNNPKKEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool JOFAIAGLCGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x69D67A0", Offset = "0x69D4FA0", VA = "0x1869D67A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BBIEECIHKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x69D69B0", Offset = "0x69D51B0", VA = "0x1869D69B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool PCPHCFONKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x69D66D0", Offset = "0x69D4ED0", VA = "0x1869D66D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private bool GICAONPBCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public CFLIGJNFJEC(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x69D4BB0", Offset = "0x69D33B0", VA = "0x1869D4BB0")]
	public static bool GCLAHEGAFFN(CFLIGJNFJEC JMDCGOKJIDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460")]
	public static GABGGJOAGAC GCLAHEGAFFN(CFLIGJNFJEC JMDCGOKJIDA)
	{
		return default(GABGGJOAGAC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x69D6AE0", Offset = "0x69D52E0", VA = "0x1869D6AE0")]
	public static bool KBKLEFBHIDJ(CFLIGJNFJEC MLFGLJKBOIG, CFLIGJNFJEC GANEOONFJPD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x69D6990", Offset = "0x69D5190", VA = "0x1869D6990")]
	public static bool HFGDCBGDPAJ(CFLIGJNFJEC MLFGLJKBOIG, CFLIGJNFJEC GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x69D6710", Offset = "0x69D4F10", VA = "0x1869D6710", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(CFLIGJNFJEC OKGBBGMIACH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460")]
	public static CFLIGJNFJEC GCLAHEGAFFN(GABGGJOAGAC JBFHMEKGHKH)
	{
		return default(CFLIGJNFJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x69D6B10", Offset = "0x69D5310", VA = "0x1869D6B10")]
	public PJHDNBOLCMK KLKPGKBCFPG()
	{
		return default(PJHDNBOLCMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x69D6A10", Offset = "0x69D5210", VA = "0x1869D6A10")]
	public GJIHGMHMEPO IHKPDFDKJMM()
	{
		return default(GJIHGMHMEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x69D6A40", Offset = "0x69D5240", VA = "0x1869D6A40")]
	public BDFHMMMNOBM IIOIIIDLIBH()
	{
		return default(BDFHMMMNOBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x69D6AB0", Offset = "0x69D52B0", VA = "0x1869D6AB0")]
	public BNDPEEOKMBM JDPIMJLJAAD()
	{
		return default(BNDPEEOKMBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x69D6530", Offset = "0x69D4D30", VA = "0x1869D6530")]
	public void AEKINDMADHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x69D6D60", Offset = "0x69D5560", VA = "0x1869D6D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct GPOKGFHBMIA : IEquatable<GPOKGFHBMIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x69DDF00", Offset = "0x69DC700", VA = "0x1869DDF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private HCJHILDMOKD KKJAJHMELHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x69DDA00", Offset = "0x69DC200", VA = "0x1869DDA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool CGAHKGKBLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x69DDCB0", Offset = "0x69DC4B0", VA = "0x1869DDCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Guid DFGGOILBGMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x69DD7C0", Offset = "0x69DBFC0", VA = "0x1869DD7C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool JLFABMGEBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x69DD730", Offset = "0x69DBF30", VA = "0x1869DD730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Guid JEJKNPCADOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x69DDD40", Offset = "0x69DC540", VA = "0x1869DDD40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public GPOKGFHBMIA(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x69DDB00", Offset = "0x69DC300", VA = "0x1869DDB00", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(GPOKGFHBMIA OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x69DDE60", Offset = "0x69DC660", VA = "0x1869DDE60")]
	public bool JKODJCOJAFA([Out] Guid KDKOCALOMKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x69DD8E0", Offset = "0x69DC0E0", VA = "0x1869DD8E0")]
	public void COENHJFFKJD(Guid GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x69DDA60", Offset = "0x69DC260", VA = "0x1869DDA60")]
	public bool EEFDKCMBGLC([Out] Guid DJMPLCHOJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x69DDB90", Offset = "0x69DC390", VA = "0x1869DDB90")]
	public void GEBGCEPMDOM(Guid GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x69DDF90", Offset = "0x69DC790", VA = "0x1869DDF90")]
	public void LPGAPIDOBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct BDFHMMMNOBM : IEquatable<BDFHMMMNOBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x69D4E40", Offset = "0x69D3640", VA = "0x1869D4E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private IJBPABNCBJO JLJFMENOLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x69D4BD0", Offset = "0x69D33D0", VA = "0x1869D4BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 OGADNIAFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x69D49C0", Offset = "0x69D31C0", VA = "0x1869D49C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Quaternion PBOHJDEKLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x69D4ED0", Offset = "0x69D36D0", VA = "0x1869D4ED0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public CFLIGJNFJEC APMHLGECENG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x69D4C60", Offset = "0x69D3460", VA = "0x1869D4C60")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public BDFHMMMNOBM(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x69D4BB0", Offset = "0x69D33B0", VA = "0x1869D4BB0")]
	public static bool GCLAHEGAFFN(BDFHMMMNOBM JMDCGOKJIDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460")]
	public static GABGGJOAGAC GCLAHEGAFFN(BDFHMMMNOBM JMDCGOKJIDA)
	{
		return default(GABGGJOAGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B20", Offset = "0x69D3320", VA = "0x1869D4B20", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(BDFHMMMNOBM OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x69D4CF0", Offset = "0x69D34F0", VA = "0x1869D4CF0")]
	public void HIJLBBEDGGA(Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x69D48B0", Offset = "0x69D30B0", VA = "0x1869D48B0")]
	public void BPFBNCBCEHM(float CDPPGBMBKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x69D5070", Offset = "0x69D3870", VA = "0x1869D5070")]
	public void PJIBMFKMHIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct PJHDNBOLCMK : IEquatable<PJHDNBOLCMK>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly PJHDNBOLCMK AIMBFAGEECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public EGEJPGJMOIP IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(EGEJPGJMOIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public NOGPFPJEJGG HLKMCIAHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(NOGPFPJEJGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x69E67B0", Offset = "0x69E4FB0", VA = "0x1869E67B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private POBIDGNADJJ HFLDLGNKIGA
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x69E5810", Offset = "0x69E4010", VA = "0x1869E5810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public GKELIELGPBO DKINBLELPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x69E5EE0", Offset = "0x69E46E0", VA = "0x1869E5EE0")]
		get
		{
			return default(GKELIELGPBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public IEnumerable<CFLIGJNFJEC> PEPBBOEMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x69E5A60", Offset = "0x69E4260", VA = "0x1869E5A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IEnumerable<CFLIGJNFJEC> AMDNFLGLJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x69E6070", Offset = "0x69E4870", VA = "0x1869E6070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int DGFFNAGFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x69E6E00", Offset = "0x69E5600", VA = "0x1869E6E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int HDHGJMPKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x69E5E20", Offset = "0x69E4620", VA = "0x1869E5E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x69E5540", Offset = "0x69E3D40", VA = "0x1869E5540")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x69E6C80", Offset = "0x69E5480", VA = "0x1869E6C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public CNLPIGOIGNM CLIOGOHIECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x69E61A0", Offset = "0x69E49A0", VA = "0x1869E61A0")]
		get
		{
			return default(CNLPIGOIGNM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x69E5DB0", Offset = "0x69E45B0", VA = "0x1869E5DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public FPPNPIKLAFA CMPDCICICJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x69E6010", Offset = "0x69E4810", VA = "0x1869E6010")]
		get
		{
			return default(FPPNPIKLAFA);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x69E6D90", Offset = "0x69E5590", VA = "0x1869E6D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public GFMGJFJNBFH DJELOHANKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x69E59A0", Offset = "0x69E41A0", VA = "0x1869E59A0")]
		get
		{
			return default(GFMGJFJNBFH);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x69E5D40", Offset = "0x69E4540", VA = "0x1869E5D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public float KCKEILMNONH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x69E6F70", Offset = "0x69E5770", VA = "0x1869E6F70")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x69E5FA0", Offset = "0x69E47A0", VA = "0x1869E5FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool AOEOAANNGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x69E5870", Offset = "0x69E4070", VA = "0x1869E5870")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x69E57A0", Offset = "0x69E3FA0", VA = "0x1869E57A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool IMCCDNJHPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x69E6E90", Offset = "0x69E5690", VA = "0x1869E6E90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x69E5930", Offset = "0x69E4130", VA = "0x1869E5930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool BHDGIPNCMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x69E5A00", Offset = "0x69E4200", VA = "0x1869E5A00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x69E5CD0", Offset = "0x69E44D0", VA = "0x1869E5CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool LCOLNCLPKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x69E6D30", Offset = "0x69E5530", VA = "0x1869E6D30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x69E5C60", Offset = "0x69E4460", VA = "0x1869E5C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool JECJOGBELJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x69E58D0", Offset = "0x69E40D0", VA = "0x1869E58D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x69E6FD0", Offset = "0x69E57D0", VA = "0x1869E6FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool NBMAAKJGHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x69E6840", Offset = "0x69E5040", VA = "0x1869E6840")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x69E5E70", Offset = "0x69E4670", VA = "0x1869E5E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public PJHDNBOLCMK(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x69D4BB0", Offset = "0x69D33B0", VA = "0x1869D4BB0")]
	public static bool GCLAHEGAFFN(PJHDNBOLCMK JMDCGOKJIDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x69D6AE0", Offset = "0x69D52E0", VA = "0x1869D6AE0")]
	public static bool KBKLEFBHIDJ(PJHDNBOLCMK MLFGLJKBOIG, PJHDNBOLCMK GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x69E5BD0", Offset = "0x69E43D0", VA = "0x1869E5BD0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(PJHDNBOLCMK OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460")]
	public static CFLIGJNFJEC GCLAHEGAFFN(PJHDNBOLCMK HIKEOGPAJAF)
	{
		return default(CFLIGJNFJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x69E5520", Offset = "0x69E3D20", VA = "0x1869E5520")]
	public bool ADIFNNLKGOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x69E68A0", Offset = "0x69E50A0", VA = "0x1869E68A0")]
	public bool LGMNIKPEBEH(HMOHHGDNCHA HFDPDKFLGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x69E6EF0", Offset = "0x69E56F0", VA = "0x1869E6EF0")]
	public void OKEJHFBHLHI(HMOHHGDNCHA HFDPDKFLGGH, bool JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x69E55F0", Offset = "0x69E3DF0", VA = "0x1869E55F0")]
	public GKELIELGPBO AKJEHONINKJ(Allocator CHDJMCMMMLJ)
	{
		return default(GKELIELGPBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x69E6910", Offset = "0x69E5110", VA = "0x1869E6910")]
	public void LHFAELGMIBG(PJHDNBOLCMK OKGBBGMIACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x69E6200", Offset = "0x69E4A00", VA = "0x1869E6200")]
	public void KIKNMJBOIAA(List<CFLIGJNFJEC> GENNLFGNPCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct OACPJCECGCN : IEquatable<OACPJCECGCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x69E4B60", Offset = "0x69E3360", VA = "0x1869E4B60", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(OACPJCECGCN OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct NPIIAIPJNCI : IEquatable<NPIIAIPJNCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public NPIIAIPJNCI(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x69E4990", Offset = "0x69E3190", VA = "0x1869E4990", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(NPIIAIPJNCI OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x69E48F0", Offset = "0x69E30F0", VA = "0x1869E48F0")]
	public void CKOHIKCJKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x69E4A20", Offset = "0x69E3220", VA = "0x1869E4A20")]
	public void HCDDNJBALDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x69E4AC0", Offset = "0x69E32C0", VA = "0x1869E4AC0")]
	public bool KLOOLILGJHN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct NOGPFPJEJGG : IEquatable<NOGPFPJEJGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x69E4430", Offset = "0x69E2C30", VA = "0x1869E4430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private POBIDGNADJJ HFLDLGNKIGA
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x69E3E10", Offset = "0x69E2610", VA = "0x1869E3E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public GABGGJOAGAC CFFLEAAPPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x69E3E70", Offset = "0x69E2670", VA = "0x1869E3E70")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public CFLIGJNFJEC EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x69E4110", Offset = "0x69E2910", VA = "0x1869E4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public CFLIGJNFJEC DHCIAOJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x69E4080", Offset = "0x69E2880", VA = "0x1869E4080")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public NOGPFPJEJGG(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x69E3F00", Offset = "0x69E2700", VA = "0x1869E3F00", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(NOGPFPJEJGG OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x69E44C0", Offset = "0x69E2CC0", VA = "0x1869E44C0")]
	public bool MMADMDAOMMK(CFLIGJNFJEC BMBBFJPOJEB, bool DDPGDHLFHEM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x69E45F0", Offset = "0x69E2DF0", VA = "0x1869E45F0")]
	public bool OHDCFBGPEKN(CFLIGJNFJEC MODLHPADBNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x69E41A0", Offset = "0x69E29A0", VA = "0x1869E41A0")]
	private void KHPHKKMNNBG(CFLIGJNFJEC OODKJGOCKHH, List<CFLIGJNFJEC> NJGONKGFOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x69E3FF0", Offset = "0x69E27F0", VA = "0x1869E3FF0")]
	public PJHDNBOLCMK IDNIEFDLBCA()
	{
		return default(PJHDNBOLCMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x69E3F90", Offset = "0x69E2790", VA = "0x1869E3F90")]
	public void FHEGGOBGHBC(List<CFLIGJNFJEC> GEHKPOCBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x69E4690", Offset = "0x69E2E90", VA = "0x1869E4690")]
	public NativeArray<GABGGJOAGAC> PCEPFNAGJAP()
	{
		return default(NativeArray<GABGGJOAGAC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct MIBIBCDEAJN : IEquatable<MIBIBCDEAJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string BKMLLKACEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x69E1C00", Offset = "0x69E0400", VA = "0x1869E1C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string GNMEKMMNKDA
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x69E1870", Offset = "0x69E0070", VA = "0x1869E1870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private bool AMEICCPFFJB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x69E19D0", Offset = "0x69E01D0", VA = "0x1869E19D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string DMNKPFEJBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x69E1ED0", Offset = "0x69E06D0", VA = "0x1869E1ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string IJFNABFAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x69E1C80", Offset = "0x69E0480", VA = "0x1869E1C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string PIBIMBLOMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x69E1B10", Offset = "0x69E0310", VA = "0x1869E1B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public MIBIBCDEAJN(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x69E1940", Offset = "0x69E0140", VA = "0x1869E1940", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(MIBIBCDEAJN OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct EPOJDNKNEHC : IEquatable<EPOJDNKNEHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x69DB390", Offset = "0x69D9B90", VA = "0x1869DB390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private IKFFFOFMOAK COLDBCCAJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x69DB100", Offset = "0x69D9900", VA = "0x1869DB100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public NFFPFNKGIEF IKEACMJDEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x69DB290", Offset = "0x69D9A90", VA = "0x1869DB290")]
		get
		{
			return default(NFFPFNKGIEF);
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x69DB4B0", Offset = "0x69D9CB0", VA = "0x1869DB4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool MJEPJCNPHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x69DB160", Offset = "0x69D9960", VA = "0x1869DB160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x69DB6F0", Offset = "0x69D9EF0", VA = "0x1869DB6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public string[] NJHCNPLHGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x69DB420", Offset = "0x69D9C20", VA = "0x1869DB420")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x69DAF30", Offset = "0x69D9730", VA = "0x1869DAF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] EOFLGPJBLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x69DB5C0", Offset = "0x69D9DC0", VA = "0x1869DB5C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x69DAD70", Offset = "0x69D9570", VA = "0x1869DAD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string[] KAIOOHGIAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x69DAE10", Offset = "0x69D9610", VA = "0x1869DAE10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x69DB060", Offset = "0x69D9860", VA = "0x1869DB060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string[] IEMGOGMKJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x69DAEA0", Offset = "0x69D96A0", VA = "0x1869DAEA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x69DB1F0", Offset = "0x69D99F0", VA = "0x1869DB1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public EPOJDNKNEHC(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460")]
	public static GABGGJOAGAC GCLAHEGAFFN(EPOJDNKNEHC JMDCGOKJIDA)
	{
		return default(GABGGJOAGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x69DAFD0", Offset = "0x69D97D0", VA = "0x1869DAFD0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(EPOJDNKNEHC OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x69DB650", Offset = "0x69D9E50", VA = "0x1869DB650")]
	public bool OMMLMHGJOKB(GABGGJOAGAC DAFEONGKMPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct MOGMFGCAGJF : IEquatable<MOGMFGCAGJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x69E2FE0", Offset = "0x69E17E0", VA = "0x1869E2FE0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(MOGMFGCAGJF OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct EPNLPEIFFCF : IEquatable<EPNLPEIFFCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public EPNLPEIFFCF(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x69DACE0", Offset = "0x69D94E0", VA = "0x1869DACE0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(EPNLPEIFFCF OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x69DAB70", Offset = "0x69D9370", VA = "0x1869DAB70")]
	public bool EKNEDMLKGIC([Out] Collider LKIKJGEBEHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct BNDPEEOKMBM : IEquatable<BNDPEEOKMBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private MakerPenHeldDataWrapper MGHIBKMINGH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x69D6430", Offset = "0x69D4C30", VA = "0x1869D6430")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool LPGIBMDFBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x69D6330", Offset = "0x69D4B30", VA = "0x1869D6330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public BNDPEEOKMBM(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x69D63A0", Offset = "0x69D4BA0", VA = "0x1869D63A0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(BNDPEEOKMBM OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct DMLFPIHOEBI : IEquatable<DMLFPIHOEBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x69D7240", Offset = "0x69D5A40", VA = "0x1869D7240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private LAOEJNLDMGI EKMBCJLANIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x69D7370", Offset = "0x69D5B70", VA = "0x1869D7370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public DMLFPIHOEBI(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x69D71B0", Offset = "0x69D59B0", VA = "0x1869D71B0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(DMLFPIHOEBI OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x69D72D0", Offset = "0x69D5AD0", VA = "0x1869D72D0")]
	public void MEKKGNEHIMM(bool LHEABDMGNNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct MMICEJDLNCE : IEquatable<MMICEJDLNCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x69E2D90", Offset = "0x69E1590", VA = "0x1869E2D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private ObjectPolicyDataWrapper NIBGDLMADHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x69E2530", Offset = "0x69E0D30", VA = "0x1869E2530")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private NavMeshGenerationDataWrapper LDMCLOIJPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x69E1FC0", Offset = "0x69E07C0", VA = "0x1869E1FC0")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool BNJBLMANPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x69E27D0", Offset = "0x69E0FD0", VA = "0x1869E27D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool EHOBIGFDJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x69E2A40", Offset = "0x69E1240", VA = "0x1869E2A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool PEDEHLCLCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x69E2BE0", Offset = "0x69E13E0", VA = "0x1869E2BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool FMNMCOEJDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x69E20F0", Offset = "0x69E08F0", VA = "0x1869E20F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool PEPJOAOPMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x69E2CC0", Offset = "0x69E14C0", VA = "0x1869E2CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool MFPJAOOHGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x69E2230", Offset = "0x69E0A30", VA = "0x1869E2230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool HJKEKKCGNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x69E2F70", Offset = "0x69E1770", VA = "0x1869E2F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool CBKNEMMFBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x69E2020", Offset = "0x69E0820", VA = "0x1869E2020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool MDNGIHPCEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x69E2160", Offset = "0x69E0960", VA = "0x1869E2160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool PFFGKHNNEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x69E2C50", Offset = "0x69E1450", VA = "0x1869E2C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool NNONLFBBFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x69E2AB0", Offset = "0x69E12B0", VA = "0x1869E2AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool DNNCNOOIPFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x69E29D0", Offset = "0x69E11D0", VA = "0x1869E29D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool FAOFGFPAJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x69E2440", Offset = "0x69E0C40", VA = "0x1869E2440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool COEAHMBAKNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x69E2090", Offset = "0x69E0890", VA = "0x1869E2090")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x69E2760", Offset = "0x69E0F60", VA = "0x1869E2760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public KJOGCKDANFN FOBEHDLOECM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x69E21D0", Offset = "0x69E09D0", VA = "0x1869E21D0")]
		get
		{
			return default(KJOGCKDANFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x69E2E20", Offset = "0x69E1620", VA = "0x1869E2E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool FNILKBGHICL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x69E2590", Offset = "0x69E0D90", VA = "0x1869E2590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public CIOMMKHJBAJ NEKPNHILJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x69E2D30", Offset = "0x69E1530", VA = "0x1869E2D30")]
		get
		{
			return default(CIOMMKHJBAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool JLMCEDMALNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x69E2970", Offset = "0x69E1170", VA = "0x1869E2970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 DBLEJOGONCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x69E2B20", Offset = "0x69E1320", VA = "0x1869E2B20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 CGFDBGLKILE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x69E2390", Offset = "0x69E0B90", VA = "0x1869E2390")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool DHHFBIJHMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x69E2870", Offset = "0x69E1070", VA = "0x1869E2870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public MMICEJDLNCE(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x69E24A0", Offset = "0x69E0CA0", VA = "0x1869E24A0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(MMICEJDLNCE OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x69E2E90", Offset = "0x69E1690", VA = "0x1869E2E90")]
	public bool MLBFPELHCBC(HOBAMJKGBHE HFDPDKFLGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x69E2F00", Offset = "0x69E1700", VA = "0x1869E2F00")]
	public bool OANFHOHKIBD(PIHMGPGBMPI HFDPDKFLGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x69E2310", Offset = "0x69E0B10", VA = "0x1869E2310")]
	public void EKGDFKMMEJO(PIHMGPGBMPI HFDPDKFLGGH, bool ALCIEIPEFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x69E2810", Offset = "0x69E1010", VA = "0x1869E2810")]
	public PIHMGPGBMPI GHNBCEOKHEM()
	{
		return default(PIHMGPGBMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x69E22A0", Offset = "0x69E0AA0", VA = "0x1869E22A0")]
	public bool EBDALKFIKBD(PIHMGPGBMPI JMDCGOKJIDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct BENEDMAEHDL : IEquatable<BENEDMAEHDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x69D5CC0", Offset = "0x69D44C0", VA = "0x1869D5CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private JEKIHDFEEAJ AMCLNMJBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x69D5910", Offset = "0x69D4110", VA = "0x1869D5910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public BENEDMAEHDL(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x69D5610", Offset = "0x69D3E10", VA = "0x1869D5610", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(BENEDMAEHDL OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x69D53D0", Offset = "0x69D3BD0", VA = "0x1869D53D0")]
	public bool EFAGOHNKEKP(FAHIIHHFPKH OIOHIJOOPGO, List<CFLIGJNFJEC> GENNLFGNPCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x69D56A0", Offset = "0x69D3EA0", VA = "0x1869D56A0")]
	public int FPMIOOPPFAG(FAHIIHHFPKH OIOHIJOOPGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x69D5970", Offset = "0x69D4170", VA = "0x1869D5970")]
	public void IHACNKDELGN(List<CFLIGJNFJEC> GENNLFGNPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x69D5A80", Offset = "0x69D4280", VA = "0x1869D5A80")]
	public int IMLBDBIFEKB(CFLIGJNFJEC CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x69D5E80", Offset = "0x69D4680", VA = "0x1869D5E80")]
	public CFLIGJNFJEC MJFMIHPBHPP(int DHNLEFJCEAH, FAHIIHHFPKH OIOHIJOOPGO)
	{
		return default(CFLIGJNFJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x69D5D50", Offset = "0x69D4550", VA = "0x1869D5D50")]
	public void LFFGHNCLIIJ(CFLIGJNFJEC CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x69D5860", Offset = "0x69D4060", VA = "0x1869D5860")]
	public bool HKONLDJOEML(CFLIGJNFJEC CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x69D5BB0", Offset = "0x69D43B0", VA = "0x1869D5BB0")]
	public void JMFAEOMEKBH(FAHIIHHFPKH OIOHIJOOPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x69D57B0", Offset = "0x69D3FB0", VA = "0x1869D57B0")]
	public bool GACKDDDLDGH(CFLIGJNFJEC CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x69D5500", Offset = "0x69D3D00", VA = "0x1869D5500")]
	public bool EIFEDMJMEFM(FAHIIHHFPKH OIOHIJOOPGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct EFCKDDNHLBP : IEquatable<EFCKDDNHLBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x69D84E0", Offset = "0x69D6CE0", VA = "0x1869D84E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public EFCKDDNHLBP(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x69D83C0", Offset = "0x69D6BC0", VA = "0x1869D83C0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(EFCKDDNHLBP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x69D8450", Offset = "0x69D6C50", VA = "0x1869D8450")]
	public void HIIGPDBBLAK(bool JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x69D8570", Offset = "0x69D6D70", VA = "0x1869D8570")]
	public void OGJFIOGBHPP(bool JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x29A9410", Offset = "0x29A7C10", VA = "0x1829A9410")]
	public T LINNCJJKLGB<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct ICBJNNPKKEF : IEquatable<ICBJNNPKKEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x69DF9A0", Offset = "0x69DE1A0", VA = "0x1869DF9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private EMMAIEDAFKE FDECFACLENI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x69DF820", Offset = "0x69DE020", VA = "0x1869DF820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool BOBKBCIIGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x69DFA30", Offset = "0x69DE230", VA = "0x1869DFA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool PJNKIKLBGDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x69DF910", Offset = "0x69DE110", VA = "0x1869DF910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public ICBJNNPKKEF(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x69DF880", Offset = "0x69DE080", VA = "0x1869DF880", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(ICBJNNPKKEF OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct JJDIBCKDEBN : IEquatable<JJDIBCKDEBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x69DFC70", Offset = "0x69DE470", VA = "0x1869DFC70", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(JJDIBCKDEBN OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct JLMJDAKDPIC : IEquatable<JLMJDAKDPIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x69E0830", Offset = "0x69DF030", VA = "0x1869E0830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private OFEKIPCHALB NIDDHPLBEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x69E0960", Offset = "0x69DF160", VA = "0x1869E0960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private OFEPENDBMGL IIKACCPHIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x69E0700", Offset = "0x69DEF00", VA = "0x1869E0700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool BBIGDAGIJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x69DFDA0", Offset = "0x69DE5A0", VA = "0x1869DFDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool NDPADOOMKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x69DFFE0", Offset = "0x69DE7E0", VA = "0x1869DFFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool NDFDMDCPLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x69E0390", Offset = "0x69DEB90", VA = "0x1869E0390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool FIODFBLMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x69E0760", Offset = "0x69DEF60", VA = "0x1869E0760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool DNPDFHJLHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x69DFEA0", Offset = "0x69DE6A0", VA = "0x1869DFEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool NLFELCIOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x69E03C0", Offset = "0x69DEBC0", VA = "0x1869E03C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool ONEHHNGPCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x69E04F0", Offset = "0x69DECF0", VA = "0x1869E04F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool BJLAOABKHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x69E0110", Offset = "0x69DE910", VA = "0x1869E0110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public JLMJDAKDPIC(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x69D4BB0", Offset = "0x69D33B0", VA = "0x1869D4BB0")]
	public static bool GCLAHEGAFFN(JLMJDAKDPIC JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x69E0080", Offset = "0x69DE880", VA = "0x1869E0080", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(JLMJDAKDPIC OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x69DFE30", Offset = "0x69DE630", VA = "0x1869DFE30")]
	public bool CCKNKGLGGCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x69E08C0", Offset = "0x69DF0C0", VA = "0x1869E08C0")]
	public CFLIGJNFJEC LEMBCOJGHPM(CFLIGJNFJEC CGKANMHMCOJ)
	{
		return default(CFLIGJNFJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x69DFED0", Offset = "0x69DE6D0", VA = "0x1869DFED0")]
	public GABGGJOAGAC EBGACKEMAJJ()
	{
		return default(GABGGJOAGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x69DFD00", Offset = "0x69DE500", VA = "0x1869DFD00")]
	public bool ABILMJEFGKD(GABGGJOAGAC PKJGCNLLCMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x69E0450", Offset = "0x69DEC50", VA = "0x1869E0450")]
	public bool IHHIAMBLMLI(GABGGJOAGAC EEEJNACAOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x69E0280", Offset = "0x69DEA80", VA = "0x1869E0280")]
	public bool FNMAJLOBJAH(GABGGJOAGAC CGKANMHMCOJ, [Out] GABGGJOAGAC PKJGCNLLCMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct GJIHGMHMEPO : IEquatable<GJIHGMHMEPO>
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly GJIHGMHMEPO AIMBFAGEECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public EGEJPGJMOIP IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(EGEJPGJMOIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public NOGPFPJEJGG HLKMCIAHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(NOGPFPJEJGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private ShapeTypeDataWrapper MHLNEOLOHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x69DC810", Offset = "0x69DB010", VA = "0x1869DC810")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public StandardRenderableVisualDataWrapper HBHEBHNEGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x69DC750", Offset = "0x69DAF50", VA = "0x1869DC750")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public PhysicsMaterialDataWrapper GACJDMILCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x69DCBA0", Offset = "0x69DB3A0", VA = "0x1869DCBA0")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public ShapeConfigDataWrapper MJGENJLEAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x69DC870", Offset = "0x69DB070", VA = "0x1869DC870")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public JHCJGJGADEK JNOLHEFFLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x69DC5F0", Offset = "0x69DADF0", VA = "0x1869DC5F0")]
		get
		{
			return default(JHCJGJGADEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public KMNCGMLJPGG GMOFENMBBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x69DC7B0", Offset = "0x69DAFB0", VA = "0x1869DC7B0")]
		get
		{
			return default(KMNCGMLJPGG);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x69DC410", Offset = "0x69DAC10", VA = "0x1869DC410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public MKMLGNFLONO KHHANACNIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x69DCA50", Offset = "0x69DB250", VA = "0x1869DCA50")]
		get
		{
			return default(MKMLGNFLONO);
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x69DCAB0", Offset = "0x69DB2B0", VA = "0x1869DCAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public float BKLLPGEJEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x69DC6F0", Offset = "0x69DAEF0", VA = "0x1869DC6F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x69DC580", Offset = "0x69DAD80", VA = "0x1869DC580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 KPCBKADLDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x69DC4E0", Offset = "0x69DACE0", VA = "0x1869DC4E0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x69DC940", Offset = "0x69DB140", VA = "0x1869DC940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public float EICCDMKKELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x69DC8D0", Offset = "0x69DB0D0", VA = "0x1869DC8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public DEIDGEMLJNI LAIAKDHPJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x69DC480", Offset = "0x69DAC80", VA = "0x1869DC480")]
		get
		{
			return default(DEIDGEMLJNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x69DC9E0", Offset = "0x69DB1E0", VA = "0x1869DC9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public GJIHGMHMEPO(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x69D4BB0", Offset = "0x69D33B0", VA = "0x1869D4BB0")]
	public static bool GCLAHEGAFFN(GJIHGMHMEPO JMDCGOKJIDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x69D6990", Offset = "0x69D5190", VA = "0x1869D6990")]
	public static bool HFGDCBGDPAJ(GJIHGMHMEPO MLFGLJKBOIG, GJIHGMHMEPO GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x69DC660", Offset = "0x69DAE60", VA = "0x1869DC660", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(GJIHGMHMEPO OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x69DC390", Offset = "0x69DAB90", VA = "0x1869DC390")]
	public JPDNHHNOHOH BBPHFPFCKMM()
	{
		return default(JPDNHHNOHOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x69DCB20", Offset = "0x69DB320", VA = "0x1869DCB20")]
	public EAIJFICLBKC KHMCBHOPPFM()
	{
		return default(EAIJFICLBKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct JPDNHHNOHOH : IEquatable<JPDNHHNOHOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public GJIHGMHMEPO HHCLOJKNPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GJIHGMHMEPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private PrimitiveShapeDataWrapper OHIGJMDAKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x69E0AB0", Offset = "0x69DF2B0", VA = "0x1869E0AB0")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public ABNGHCBPDJL JGAFFEKCAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x69E0A50", Offset = "0x69DF250", VA = "0x1869E0A50")]
		get
		{
			return default(ABNGHCBPDJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public JPDNHHNOHOH(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x69D4BB0", Offset = "0x69D33B0", VA = "0x1869D4BB0")]
	public static bool GCLAHEGAFFN(JPDNHHNOHOH JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x69E09C0", Offset = "0x69DF1C0", VA = "0x1869E09C0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(JPDNHHNOHOH OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public readonly struct EAIJFICLBKC : IEquatable<EAIJFICLBKC>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly EAIJFICLBKC AIMBFAGEECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public EGEJPGJMOIP IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(EGEJPGJMOIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x69D7A10", Offset = "0x69D6210", VA = "0x1869D7A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private DLONBJHNDJH DMKKPIJIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x69D7CC0", Offset = "0x69D64C0", VA = "0x1869D7CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public GJIHGMHMEPO HHCLOJKNPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GJIHGMHMEPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public KCOEAKMOKIN NHIHELLKNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x69D7470", Offset = "0x69D5C70", VA = "0x1869D7470")]
		get
		{
			return default(KCOEAKMOKIN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x69D7630", Offset = "0x69D5E30", VA = "0x1869D7630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public IEnumerable<KENIPLOJLJH> FDPJJLDNEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D20", Offset = "0x69D6520", VA = "0x1869D7D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public KENIPLOJLJH NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x69D7FC0", Offset = "0x69D67C0", VA = "0x1869D7FC0")]
		get
		{
			return default(KENIPLOJLJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x69D7F30", Offset = "0x69D6730", VA = "0x1869D7F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public EAIJFICLBKC(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x69D4BB0", Offset = "0x69D33B0", VA = "0x1869D4BB0")]
	public static bool GCLAHEGAFFN(EAIJFICLBKC JMDCGOKJIDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x69D6AE0", Offset = "0x69D52E0", VA = "0x1869D6AE0")]
	public static bool KBKLEFBHIDJ(EAIJFICLBKC MLFGLJKBOIG, EAIJFICLBKC GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x69D75A0", Offset = "0x69D5DA0", VA = "0x1869D75A0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(EAIJFICLBKC OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x69D7AA0", Offset = "0x69D62A0", VA = "0x1869D7AA0")]
	public KENIPLOJLJH LBJDLPDBEDK(float3? HGDCPNGLIKJ, [Optional] quaternion? LCDJINCAHMD, [Optional] Vector3? CDPPGBMBKAI)
	{
		return default(KENIPLOJLJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x69D7750", Offset = "0x69D5F50", VA = "0x1869D7750")]
	public KENIPLOJLJH HDMLFENMIIH(int DHNLEFJCEAH, float3? HGDCPNGLIKJ, [Optional] quaternion? LCDJINCAHMD, [Optional] Vector3? CDPPGBMBKAI)
	{
		return default(KENIPLOJLJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x69D73D0", Offset = "0x69D5BD0", VA = "0x1869D73D0")]
	public void ACAJIKLBJOM(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x69D7980", Offset = "0x69D6180", VA = "0x1869D7980")]
	public void IMJJLGNDCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct KENIPLOJLJH : IEquatable<KENIPLOJLJH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public EAIJFICLBKC KADKIMNADLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x69E0B70", Offset = "0x69DF370", VA = "0x1869E0B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public float3 PCKAHHMDECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x69E0D70", Offset = "0x69DF570", VA = "0x1869E0D70")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x69E1030", Offset = "0x69DF830", VA = "0x1869E1030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public quaternion ACLOFDCFLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x69E0C00", Offset = "0x69DF400", VA = "0x1869E0C00")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x69E0F60", Offset = "0x69DF760", VA = "0x1869E0F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public float3 PPEBOBJIFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x69E0EE0", Offset = "0x69DF6E0", VA = "0x1869E0EE0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x69E0DF0", Offset = "0x69DF5F0", VA = "0x1869E0DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public NJKOAFMLNJE NKDHILFOIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x69E0E70", Offset = "0x69DF670", VA = "0x1869E0E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private SplinePointParentDataWrapper NPNBIDFBMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x69E1110", Offset = "0x69DF910", VA = "0x1869E1110")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private SplinePointPositionDataWrapper NFBBGJMDCPP
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x69E0B10", Offset = "0x69DF310", VA = "0x1869E0B10")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private SplinePointRotationDataWrapper IOAGCEOLKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x69E0FD0", Offset = "0x69DF7D0", VA = "0x1869E0FD0")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private SplinePointScaleDataWrapper FDMGCFEPHNH
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x69E0D10", Offset = "0x69DF510", VA = "0x1869E0D10")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private SplinePointOrderDataWrapper NLPABBMJJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x69E10B0", Offset = "0x69DF8B0", VA = "0x1869E10B0")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public KENIPLOJLJH(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x69E0C80", Offset = "0x69DF480", VA = "0x1869E0C80", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(KENIPLOJLJH OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x69E0B70", Offset = "0x69DF370", VA = "0x1869E0B70")]
	public void BLDJLDLHBHI(EAIJFICLBKC JMDCGOKJIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct NJAIOMBKDEO : IEquatable<NJAIOMBKDEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x69E38A0", Offset = "0x69E20A0", VA = "0x1869E38A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private ABGGAFKHAHA CCPFJECNGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x69E32F0", Offset = "0x69E1AF0", VA = "0x1869E32F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private ToolCleanupSettingsDataWrapper JDMLECMMLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x69E3350", Offset = "0x69E1B50", VA = "0x1869E3350")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public bool AODFBOKMJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x69E3930", Offset = "0x69E2130", VA = "0x1869E3930")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x69E35F0", Offset = "0x69E1DF0", VA = "0x1869E35F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool LJBBFGNMJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x69E3590", Offset = "0x69E1D90", VA = "0x1869E3590")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x69E3280", Offset = "0x69E1A80", VA = "0x1869E3280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public float MGGPBNNDKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x69E3220", Offset = "0x69E1A20", VA = "0x1869E3220")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x69E3660", Offset = "0x69E1E60", VA = "0x1869E3660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool DCHGIJAAECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x69E36D0", Offset = "0x69E1ED0", VA = "0x1869E36D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public NJAIOMBKDEO(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x69E33B0", Offset = "0x69E1BB0", VA = "0x1869E33B0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(NJAIOMBKDEO OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x69E3180", Offset = "0x69E1980", VA = "0x1869E3180")]
	public void COIDJNPCHNJ(int IDOOJPJNKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x69E3070", Offset = "0x69E1870", VA = "0x1869E3070")]
	public bool AGCIAOHMBMK([Out] int IDOOJPJNKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x69E3990", Offset = "0x69E2190", VA = "0x1869E3990")]
	public void NFIIEKEDFNF(bool FJLABAPBACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x69E3A30", Offset = "0x69E2230", VA = "0x1869E3A30")]
	public void NLNNIJGEKAL(float INKBMGHKJBH, float DIAJGCFAFJA, float AAOPOGDBJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x69E3440", Offset = "0x69E1C40", VA = "0x1869E3440")]
	public void HHLODHLOMEE(float3 GMKNIMNHFMM, quaternion BBFPPCPIKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x69E3770", Offset = "0x69E1F70", VA = "0x1869E3770")]
	public bool KCJEKCGMCOF([Out] float3 GMKNIMNHFMM, [Out] quaternion BBFPPCPIKED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x69E3B80", Offset = "0x69E2380", VA = "0x1869E3B80")]
	public bool PLHPLHBEHGK([Out] float ILJHJIGPMPP, [Out] float AGEKNIMIBHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct EGEJPGJMOIP : IEquatable<EGEJPGJMOIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly GABGGJOAGAC JBFHMEKGHKH;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public CFLIGJNFJEC NLHCDOOPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(CFLIGJNFJEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public NOGPFPJEJGG HLKMCIAHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
		get
		{
			return default(NOGPFPJEJGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private JNPMLJAJCFH GMAECELJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x69D5010", Offset = "0x69D3810", VA = "0x1869D5010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private DPGMADCKOBA IBCGGDPBJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x69D9850", Offset = "0x69D8050", VA = "0x1869D9850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public bool GHDIEHBMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x69D8A40", Offset = "0x69D7240", VA = "0x1869D8A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Vector3 PCKAHHMDECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x69D90F0", Offset = "0x69D78F0", VA = "0x1869D90F0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x69DA400", Offset = "0x69D8C00", VA = "0x1869DA400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Quaternion ACLOFDCFLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x69D8D60", Offset = "0x69D7560", VA = "0x1869D8D60")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x69DA0A0", Offset = "0x69D88A0", VA = "0x1869DA0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Vector3 EPEMKAANOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x69D8950", Offset = "0x69D7150", VA = "0x1869D8950")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x69D99C0", Offset = "0x69D81C0", VA = "0x1869D99C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Quaternion KHCNENJLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x69D9710", Offset = "0x69D7F10", VA = "0x1869D9710")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x69D8C90", Offset = "0x69D7490", VA = "0x1869D8C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public float DLMMKBPCBCI
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x69D87C0", Offset = "0x69D6FC0", VA = "0x1869D87C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x69DA170", Offset = "0x69D8970", VA = "0x1869DA170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public float JDLKEDGCFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x69DA220", Offset = "0x69D8A20", VA = "0x1869DA220")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public Vector3 PPEBOBJIFDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x69D9C10", Offset = "0x69D8410", VA = "0x1869D9C10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x69D92B0", Offset = "0x69D7AB0", VA = "0x1869D92B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Vector3 IGDKJAGFOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x69D9FB0", Offset = "0x69D87B0", VA = "0x1869D9FB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Matrix4x4 NNJFGKGKEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x69D9380", Offset = "0x69D7B80", VA = "0x1869D9380")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0xE43340", Offset = "0xE41B40", VA = "0x180E43340")]
	public EGEJPGJMOIP(GABGGJOAGAC DIHIHJFDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C30", Offset = "0x69D3430", VA = "0x1869D4C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x69D8EA0", Offset = "0x69D76A0", VA = "0x1869D8EA0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B10", Offset = "0x69D3310", VA = "0x1869D4B10", Slot = "4")]
	public bool Equals(EGEJPGJMOIP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x69D5230", Offset = "0x69D3A30", VA = "0x1869D5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x69D8B70", Offset = "0x69D7370", VA = "0x1869D8B70")]
	public HLEMAOPCIDE CLIHDDPDANB()
	{
		return default(HLEMAOPCIDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x69D86A0", Offset = "0x69D6EA0", VA = "0x1869D86A0")]
	public void AGCDJMLFJPJ([Out] Matrix4x4 KKCFNCIJCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x69DA670", Offset = "0x69D8E70", VA = "0x1869DA670")]
	public void OEEKDAFMBLF([Out] Vector3 JLLEJLEAIND, [Out] Quaternion PBAALPDHPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x69DA5C0", Offset = "0x69D8DC0", VA = "0x1869DA5C0")]
	public void OEEKDAFMBLF([Out] RigidTransform PICNKNJCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x69D9630", Offset = "0x69D7E30", VA = "0x1869D9630")]
	public void HOJAIAAPPLH([Out] Vector3 JLLEJLEAIND, [Out] Quaternion PBAALPDHPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x69D9580", Offset = "0x69D7D80", VA = "0x1869D9580")]
	public void HOJAIAAPPLH([Out] RigidTransform PICNKNJCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x69DA4D0", Offset = "0x69D8CD0", VA = "0x1869DA4D0")]
	public UniformTRS OABKDGJIAEG()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x69DA500", Offset = "0x69D8D00", VA = "0x1869DA500")]
	public void OABKDGJIAEG([Out] UniformTRS OBNNMAGIJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x69D8FF0", Offset = "0x69D77F0", VA = "0x1869D8FF0")]
	public UniformTRS FMKLJGMDOCH()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x69D8F30", Offset = "0x69D7730", VA = "0x1869D8F30")]
	public void FMKLJGMDOCH([Out] UniformTRS PICNKNJCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x69D8A80", Offset = "0x69D7280", VA = "0x1869D8A80")]
	public Vector3 CEGEMHDGALH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x69DA930", Offset = "0x69D9130", VA = "0x1869DA930")]
	public void PFPEKJMJACK([In] Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x69DA750", Offset = "0x69D8F50", VA = "0x1869DA750")]
	public Vector3 PDJNPAOEBPG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x69D91E0", Offset = "0x69D79E0", VA = "0x1869D91E0")]
	public void GOBMMMCCMOD([In] Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x69DA2C0", Offset = "0x69D8AC0", VA = "0x1869DA2C0")]
	public Quaternion NEOACCMAIKF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x69DAA00", Offset = "0x69D9200", VA = "0x1869DAA00")]
	public void PPDALCLHNIK([In] Quaternion JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x69D9E70", Offset = "0x69D8670", VA = "0x1869D9E70")]
	public Quaternion KLPBKEKOHBE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x69D9D00", Offset = "0x69D8500", VA = "0x1869D9D00")]
	public void KGELDGNHDHN([In] Quaternion JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x69D8600", Offset = "0x69D6E00", VA = "0x1869D8600")]
	public float AFALOFIDPKH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x69D9A90", Offset = "0x69D8290", VA = "0x1869D9A90")]
	public void JEFGELGEHBE(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x69D9DD0", Offset = "0x69D85D0", VA = "0x1869D9DD0")]
	public float KHNFMMDFILB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x69D9910", Offset = "0x69D8110", VA = "0x1869D9910")]
	public void IKBPGCGMLJD(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x69D93C0", Offset = "0x69D7BC0", VA = "0x1869D93C0")]
	public void HGJJBAJEELB([In] Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x69DA840", Offset = "0x69D9040", VA = "0x1869DA840")]
	public Vector3 PEHCFPCPOJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x69D8BC0", Offset = "0x69D73C0", VA = "0x1869D8BC0")]
	public void CLLJDAMABEE([In] Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x69D9490", Offset = "0x69D7C90", VA = "0x1869D9490")]
	public Vector3 HKPIBPCKBFF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x69D9B40", Offset = "0x69D8340", VA = "0x1869D9B40")]
	public void JJHANEPODLG([In] Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x69D8860", Offset = "0x69D7060", VA = "0x1869D8860")]
	public Vector3 BEIKAHCELFP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x69D9020", Offset = "0x69D7820", VA = "0x1869D9020")]
	public void FPJCOFHJGJA([In] Vector3 JMDCGOKJIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class KMNILGAAICC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct FIGBCHKOFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid BMIGIGGJPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public INAOECHDMEF BJMCIMDOLDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private struct INAOECHDMEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int JMDCGOKJIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int OGFDFIJFELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int DMHDBNDAJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int CJJBHLIPIIL;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x69DFBA0", Offset = "0x69DE3A0", VA = "0x1869DFBA0")]
		public bool KCONGGLEKLC([Out] EPOHMNPJENA JHDNEHLEBCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x69DFC30", Offset = "0x69DE430", VA = "0x1869DFC30")]
		public INAOECHDMEF(EPOHMNPJENA JHDNEHLEBCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x69E1190", Offset = "0x69DF990", VA = "0x1869E1190")]
	public static Guid JOJOMLMGGIB(this EPOHMNPJENA JHDNEHLEBCI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x69E1170", Offset = "0x69DF970", VA = "0x1869E1170")]
	public static bool ABBKACHPENJ(this Guid BMIGIGGJPJD, [Out] EPOHMNPJENA JHDNEHLEBCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal static class MCLIKLFNCKE
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x69E17E0", Offset = "0x69DFFE0", VA = "0x1869E17E0")]
	public static AOFDGEECKBG MLIHGIAAIPG(this GABGGJOAGAC DKFNFHGODON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x69E1610", Offset = "0x69DFE10", VA = "0x1869E1610")]
	public static MICAOJNNFIH COAFHJDLOOM(this GABGGJOAGAC DKFNFHGODON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x69E16E0", Offset = "0x69DFEE0", VA = "0x1869E16E0")]
	public static EntityManager KLCONNELEGA(this GABGGJOAGAC DKFNFHGODON)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D900", Offset = "0x2C1C100", VA = "0x182C1D900")]
	public static T GJPKPNDNNIC<T>(this GABGGJOAGAC DKFNFHGODON) where T : struct, COGEFBNNGIJ
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D640", Offset = "0x2C1BE40", VA = "0x182C1D640")]
	public static bool DOOIFCMECHH<T>(this GABGGJOAGAC DKFNFHGODON) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C1EBC0", Offset = "0x2C1D3C0", VA = "0x182C1EBC0")]
	public static bool JPDDJONEBDN<T>(this GABGGJOAGAC DKFNFHGODON) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface HCJHILDMOKD
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLFABMGEBKG(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGAHKGKBLOP(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JKODJCOJAFA(GABGGJOAGAC DIHIHJFDGDD, [Out] Guid KDKOCALOMKG);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid KIEIDMNLAIK(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void COENHJFFKJD(GABGGJOAGAC DIHIHJFDGDD, Guid KDKOCALOMKG);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EEFDKCMBGLC(GABGGJOAGAC DIHIHJFDGDD, [Out] Guid DJMPLCHOJFC);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid ODGLFJFHDPO(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GEBGCEPMDOM(GABGGJOAGAC DIHIHJFDGDD, Guid DJMPLCHOJFC);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LPGAPIDOBBK(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task GOGMCAPKLGP(GABGGJOAGAC JPEFLCPGHGB, GABGGJOAGAC BMBBFJPOJEB);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface DLEFGKANLCA
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	Guid OCBDIJEAPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGBDDDDNEEL(NativeList<Guid> EGECPDDOGHG, NativeList<Guid> CNFJDLKBJBO, NativeList<FixedString64Bytes> LACAJAKGBDE);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface EMMAIEDAFKE
{
	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGMNPOICAAN(List<GABGGJOAGAC> EFMFMJICJGL);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHIJDNJKLNB(List<GABGGJOAGAC> BMPCHLAFCPD);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HLDPAJDCCKE(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BOBKBCIIGOO(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PJNKIKLBGDF(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KAJHFNPLJII(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OHGEMHPAECE(GABGGJOAGAC IKLBGDHLNOF, int IEJKLFLAGBB);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GABGGJOAGAC MGPIPCOODJG(GABGGJOAGAC CJHMIEPFDJN);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int JNNHPEGFPMA(GABGGJOAGAC CJHMIEPFDJN);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HKMCBACDOBB(GABGGJOAGAC CJHMIEPFDJN, int JKBBGFGJKPF);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int CLPDJMKMDKD(GABGGJOAGAC CJHMIEPFDJN);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HKAMAOCKCPN(GABGGJOAGAC CJHMIEPFDJN, int HLJGIEMEGJH);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ACPPPBPNNGJ(GABGGJOAGAC JBFHMEKGHKH);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IMADKKCEMNL(GABGGJOAGAC DIHIHJFDGDD, bool HJLCOKLEGJP);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NCICMEAFNMF(GABGGJOAGAC[] CHNFMEBDLMI, bool HJLCOKLEGJP);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface JJMNFIGHGIC
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	IReadOnlyCollection<KLGOKKFJPKL> OLEHCIIPMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MLMNBADPANF(int ILLCBJEFNGA, [Out] KLGOKKFJPKL JLMFPFPCHKD);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KLGOKKFJPKL CNIIIFKJKEO(Type NCMHJNKFAGH);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class NBFILCCOHFK
{
	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BF50", Offset = "0x2C8A750", VA = "0x182C8BF50")]
	public static T CIOKHABNMPN<T>(this JJMNFIGHGIC MLIEGINPPCG, Entity IBKNLGIDEBH) where T : struct, COGEFBNNGIJ
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C8C000", Offset = "0x2C8A800", VA = "0x182C8C000")]
	public static KLGOKKFJPKL CNIIIFKJKEO<T>(this JJMNFIGHGIC MLIEGINPPCG) where T : struct, COGEFBNNGIJ
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface EMMMFIIHJEF
{
	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPOHMNPJENA[] CCHAHPAPLHI(string BHFPKCCDEEC, CFLIGJNFJEC MMEKCENCLHK, bool MFEEGBLMHJP = false);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LABNHNCDPPI(string MIMBCLCGJGF, EPOHMNPJENA[] BMNAGJGIMFF);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface IJBPABNCBJO
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<GABGGJOAGAC, GABGGJOAGAC> KBNGECCDFAD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<GABGGJOAGAC, GABGGJOAGAC> CAHBLBCDJPI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<GABGGJOAGAC, GABGGJOAGAC, GABGGJOAGAC> EDMDCBDGJNC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<GABGGJOAGAC> CIAIOIDCLAB;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HPFGALHPEDP(GABGGJOAGAC DIHIHJFDGDD, GABGGJOAGAC OLNOAGDOHBL);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GABGGJOAGAC HJJBGHJBAMN(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<GABGGJOAGAC> AMLMEDFAFGF(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GABGGJOAGAC ANMBLCIOEDG(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HIJLBBEDGGA(GABGGJOAGAC DIHIHJFDGDD, Vector3 ICFCGNJFKLO, Quaternion BJFNBMBABML);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BPFBNCBCEHM(GABGGJOAGAC DIHIHJFDGDD, float AHDCCDIOAPK);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool HOKDFLGCCLC(GABGGJOAGAC DIHIHJFDGDD, [Out] GABGGJOAGAC BMBBFJPOJEB);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CMHHPEINCBB(GABGGJOAGAC DIHIHJFDGDD, [Out] RigidTransform CIAAHPDPNLL);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool EPMGHAAPCEN(GABGGJOAGAC DIHIHJFDGDD, [Out] float FOPEOAELMOC);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 DNKPANOBCOJ(BDFHMMMNOBM IKDLNJNGHLN);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion GMJNCNAEGHK(BDFHMMMNOBM IKDLNJNGHLN);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class DDPCMADKBLN
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface CABKPIGDNCD
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	object PDELFICNBPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEMDBKPGMMH(GKELIELGPBO CHNFMEBDLMI);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct AEECLDGAGLI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly string BHFPKCCDEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly T LIAHLPBCKNO;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x3C548A0", Offset = "0x3C530A0", VA = "0x183C548A0")]
	public AEECLDGAGLI(T LIAHLPBCKNO, [Optional][CallerMemberName] string BHFPKCCDEEC)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly AEECLDGAGLI<int> EEEGKPKBDLN;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum EIJKCLPEHIK
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class DBNALPGHOML
{
	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0xD6DA50", Offset = "0xD6C250", VA = "0x180D6DA50")]
	public static bool HLBAFPGEOOG(this EIJKCLPEHIK DMDDBNBIFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0xD6DA60", Offset = "0xD6C260", VA = "0x180D6DA60")]
	public static bool FOOAACBCBMC(this EIJKCLPEHIK DMDDBNBIFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2543860", Offset = "0x2542060", VA = "0x182543860")]
	public static bool CKKIEDFDJNE(this EIJKCLPEHIK DMDDBNBIFMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface LIHEKOEONMI
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	bool GKAFGGFEEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface PHECFDNIMBH
{
	[Cpp2IlInjected.Token(Token = "0x17000180")]
	EIJKCLPEHIK AKBLIOCMDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	EIJKCLPEHIK IJDMAMHKEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	EIJKCLPEHIK JGFBHDIGANM
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	EIJKCLPEHIK CPOKAOPLHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	EIJKCLPEHIK ADDKCLOAEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	EIJKCLPEHIK GGGMPCGMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	EIJKCLPEHIK JKDGFNOAHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	EIJKCLPEHIK BKHKGIHGBAD
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	EIJKCLPEHIK BLLLBGJCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	EIJKCLPEHIK ENONMCNDIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	EIJKCLPEHIK KNKPDCFDOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	EIJKCLPEHIK HDPFCAFJOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	EIJKCLPEHIK GLNNJIOCJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	EIJKCLPEHIK MMGDILDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	EIJKCLPEHIK MAFKFFDGPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JMJOGDIBBHK(AEECLDGAGLI<int> AACIHKHGIHG);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface POBIDGNADJJ
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<EEFBLACHIAF> LHCJBOAKLCG;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GABGGJOAGAC ELHIHCNAKGP(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KGAFCGLAFDH(List<GABGGJOAGAC> BMPCHLAFCPD);

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NJKOAFMLNJE FBPDCHMHNCC(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GNBIFJJIMNM(IEnumerable<GABGGJOAGAC> HFGNEPINDEJ);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NJKOAFMLNJE GIGOCGMOPFG(GABGGJOAGAC BMBBFJPOJEB, GABGGJOAGAC HKKDPGGNNBK, bool FIBIDMDODPF, GABGGJOAGAC CGKANMHMCOJ);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GABGGJOAGAC EJGCADKFNOA(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MMADMDAOMMK(GABGGJOAGAC DIHIHJFDGDD, GABGGJOAGAC BMBBFJPOJEB, bool DDPGDHLFHEM);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GNGCIEAOMMM(GABGGJOAGAC DIHIHJFDGDD, GABGGJOAGAC BMBBFJPOJEB);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FOKAKEAACGE(GABGGJOAGAC OLBMFNPMLNJ, GABGGJOAGAC FEKKAKGIHFB);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int EHKOKKKOMEN(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GKELIELGPBO OIKLNFABNFB(GABGGJOAGAC JBFHMEKGHKH);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<GABGGJOAGAC> PCEPFNAGJAP(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool ABDAEJHFCNO(GABGGJOAGAC DIHIHJFDGDD, GABGGJOAGAC NDFKCENHCIO);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<GABGGJOAGAC> HPPOCJAIBIF(GABGGJOAGAC DIHIHJFDGDD, bool BMMDCECFEGB = false);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool OHDCFBGPEKN(GABGGJOAGAC DIHIHJFDGDD, GABGGJOAGAC MODLHPADBNH);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "17")]
	GABGGJOAGAC PMMCFKHJGGB(GABGGJOAGAC CGKANMHMCOJ, GABGGJOAGAC LAMGMHLAEFA);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IPNOILGCMII(GABGGJOAGAC CGKANMHMCOJ, GABGGJOAGAC LAMGMHLAEFA, [Out] GABGGJOAGAC CNBFBOIBPGG);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class BDHCJCEMLDA
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x69D5250", Offset = "0x69D3A50", VA = "0x1869D5250")]
	public static List<GABGGJOAGAC> KGAFCGLAFDH(this POBIDGNADJJ DBOIGEKAFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x69D5360", Offset = "0x69D3B60", VA = "0x1869D5360")]
	public static bool KIMLMAODMNF(this POBIDGNADJJ DBOIGEKAFFJ, GABGGJOAGAC DIHIHJFDGDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface IKFFFOFMOAK
{
	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFFPFNKGIEF AAJEDLDJOCF(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEKHMIJIJNF(GABGGJOAGAC IKLBGDHLNOF, NFFPFNKGIEF EFNHFIAJDJA);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KPJIKBMGLFK(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNFOMJOFJOC(GABGGJOAGAC IKLBGDHLNOF, bool JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] IHFBGAIPCAD(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPFOPKBDCKF(GABGGJOAGAC IKLBGDHLNOF, IEnumerable<string> DJEEKAMJJDN);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] HKAACLNDKDN(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OFKNAICIJLF(GABGGJOAGAC IKLBGDHLNOF, IEnumerable<string> DJEEKAMJJDN);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] KGCPLJHLEFD(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HHIEMEFCJNF(GABGGJOAGAC IKLBGDHLNOF, IEnumerable<string> DJEEKAMJJDN);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] PNPFICLKMKC(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MAKFPGLDJFB(GABGGJOAGAC IKLBGDHLNOF, IEnumerable<string> DJEEKAMJJDN);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OMMLMHGJOKB(GABGGJOAGAC IKLBGDHLNOF, GABGGJOAGAC DAFEONGKMPP);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface MHNLDEBKEOH
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	bool OBPEFMECDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	bool JJEPJAKOGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface DNOPOMNADGK : GENIJDAJABO
{
	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PEICOLHLABC(Entity IBKNLGIDEBH, [Out] PDHLLGDFEPN IIMJMBJHGDI);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGAKJAKNHDJ(NativeArray<PDHLLGDFEPN> GHJAKKOFDML, NativeArray<IBPLEJHIFCJ> LIPHIKJKPFE);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLFKOGODFJP(PDHLLGDFEPN IIMJMBJHGDI);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HLLALHFANEC(PDHLLGDFEPN IIMJMBJHGDI, [Out] Collider LKIKJGEBEHP);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface GENIJDAJABO
{
	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPKNIAFFNLP([In] float3 MNCFLKFGCKD, [In] float3 FCBGHELDCII, float BKKDIDJOENO, Allocator CHDJMCMMMLJ, [Out] NativeArray<Entity> JPHDFJFJAJL);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface POINGCHJLAH
{
	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPKNIAFFNLP([In] float3 MNCFLKFGCKD, [In] float3 FCBGHELDCII, float BKKDIDJOENO, [Out] MLHMFMLPGFA MHAPFDBLKOP, [Out] GABGGJOAGAC IFMLHGKDGCB);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface JOIOGPIHIMB
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPKNIAFFNLP([In] NativeArray<Entity> JPHDFJFJAJL, [In] float3 MNCFLKFGCKD, [In] float3 FCBGHELDCII, [In] NativeArray<MLHMFMLPGFA> CEJLOADFCPC);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct PDHLLGDFEPN : DIAIPOOLIIL, IEquatable<PDHLLGDFEPN>
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A710", VA = "0x180A7BF10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public int GIOOEBIGKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A290", VA = "0x18255BA90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9A30", Offset = "0x5CA8230", VA = "0x185CA9A30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x69E5480", Offset = "0x69E3C80", VA = "0x1869E5480", Slot = "8")]
	public bool Equals(PDHLLGDFEPN OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x69E54D0", Offset = "0x69E3CD0", VA = "0x1869E54D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct MLHMFMLPGFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float IBNOPPILEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float3 NFFLDAHKGKD;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface JOAHALCDFKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface JNPMLJAJCFH
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	AOFDGEECKBG MLIHGIAAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	AEBOEOPEMGA OGFIPIIMJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<GKELIELGPBO, NativeArray<DOELAEOOEOB>> CLLKMNADLEK;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<GKELIELGPBO> GEJILDJCHJN;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LBAIEFEIHDD NBJOMGOPOLC(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DOELAEOOEOB GKLFLIECIDA(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JGBCFAKMKJN(EPOHMNPJENA JHDNEHLEBCI, HONENIKELML JEGEPAEEFCO);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ILIEKJGJFGC(EPOHMNPJENA[] BMNAGJGIMFF, GameObject NBDLDMDNCAL);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CFLIGJNFJEC AEKINDMADHN(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OMACENIOHBM(GABGGJOAGAC DIHIHJFDGDD, [Out] Transform FMAJPAMCPCL);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JOFAIAGLCGO(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EMNJMJPLOIN(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GABGGJOAGAC CICEBPABBCJ(EPOHMNPJENA JHDNEHLEBCI);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MGCCHHKAIHC(EPOHMNPJENA JHDNEHLEBCI, [Out] GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "16")]
	EPOHMNPJENA GNENDEMPCNN(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "17")]
	GKELIELGPBO CICEBPABBCJ(NativeArray<EPOHMNPJENA> JHDNEHLEBCI, Allocator CHDJMCMMMLJ);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	GKELIELGPBO KIGJKMPHGGD(DOELAEOOEOB LNPLCOCFIOP, int IHGHLPOONHD, Allocator CHDJMCMMMLJ);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	GKELIELGPBO ENBBNHPECNO(NativeArray<EPOHMNPJENA> JHDNEHLEBCI, NativeArray<ALEKPGEIKGH> OPKIEGEPJGC, Allocator CHDJMCMMMLJ);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	EPOHMNPJENA[] CCHAHPAPLHI(string MIMBCLCGJGF, CFLIGJNFJEC MMEKCENCLHK, bool MFEEGBLMHJP);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LABNHNCDPPI(string MIMBCLCGJGF, EPOHMNPJENA[] BMNAGJGIMFF);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	CFLIGJNFJEC EPOPADGJMEL(DOELAEOOEOB LNPLCOCFIOP, bool BEDNPDEHJHB);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CFLIGJNFJEC EPOPADGJMEL(DOELAEOOEOB LNPLCOCFIOP);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "24")]
	CFLIGJNFJEC PMKMHHBCCKD(DOELAEOOEOB LNPLCOCFIOP);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CFLIGJNFJEC LEBDKHBDEHN(DOELAEOOEOB LNPLCOCFIOP);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CFLIGJNFJEC KLDBEOKPMPM(EPOHMNPJENA JHDNEHLEBCI, DOELAEOOEOB LNPLCOCFIOP);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "27")]
	PJHDNBOLCMK EAHKIMMMHCG();

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "28")]
	EAIJFICLBKC AENMIPNEMND();

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "29")]
	JPDNHHNOHOH GHIMCBHIEHL(ABNGHCBPDJL NKJEFANENCO);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void HCDDNJBALDM(GKELIELGPBO CHNFMEBDLMI);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void CKOHIKCJKJA(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void JMMFEDOOCON(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void HCDDNJBALDM(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CJHLDFMMCCG(GABGGJOAGAC CHNFMEBDLMI);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool KLOOLILGJHN(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "36")]
	GKELIELGPBO OABEGGOFBHB(GKELIELGPBO LJKINDIIKMB, Allocator CHDJMCMMMLJ);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool LNFEOGNEOOI(GABGGJOAGAC DIHIHJFDGDD);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class HCMNIMCGIIB
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x69DE0E0", Offset = "0x69DC8E0", VA = "0x1869DE0E0")]
	public static void EMNJMJPLOIN(this JNPMLJAJCFH OOCDOIDHCLB, HONENIKELML JEGEPAEEFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x69DE0B0", Offset = "0x69DC8B0", VA = "0x1869DE0B0")]
	public static CFLIGJNFJEC JBCLIPFLIMC(this JNPMLJAJCFH OOCDOIDHCLB, LocalId DIHIHJFDGDD)
	{
		return default(CFLIGJNFJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x69DE5D0", Offset = "0x69DCDD0", VA = "0x1869DE5D0")]
	public static CFLIGJNFJEC JBCLIPFLIMC(this JNPMLJAJCFH OOCDOIDHCLB, EPOHMNPJENA JHDNEHLEBCI)
	{
		return default(CFLIGJNFJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x69DE0B0", Offset = "0x69DC8B0", VA = "0x1869DE0B0")]
	public static GABGGJOAGAC CICEBPABBCJ(this JNPMLJAJCFH OOCDOIDHCLB, LocalId DIHIHJFDGDD)
	{
		return default(GABGGJOAGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x69DE450", Offset = "0x69DCC50", VA = "0x1869DE450")]
	public static EPOHMNPJENA GNENDEMPCNN(this JNPMLJAJCFH OOCDOIDHCLB, LocalId DIHIHJFDGDD)
	{
		return default(EPOHMNPJENA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x69DE720", Offset = "0x69DCF20", VA = "0x1869DE720")]
	public static bool LNFEOGNEOOI(this JNPMLJAJCFH OOCDOIDHCLB, EPOHMNPJENA JHDNEHLEBCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x2B549D0", Offset = "0x2B531D0", VA = "0x182B549D0")]
	public static T GKCALIEKENI<T>(this JNPMLJAJCFH OOCDOIDHCLB, LocalId DIHIHJFDGDD) where T : struct, COGEFBNNGIJ
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x69DE630", Offset = "0x69DCE30", VA = "0x1869DE630")]
	public static PJHDNBOLCMK LEKIKOPNBBA(this JNPMLJAJCFH OOCDOIDHCLB, RigidTransform OBNNMAGIJBG)
	{
		return default(PJHDNBOLCMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x69DE4D0", Offset = "0x69DCCD0", VA = "0x1869DE4D0")]
	public static JPDNHHNOHOH HENMDCLKCHD(this JNPMLJAJCFH OOCDOIDHCLB, ABNGHCBPDJL IBCCPKEAHLL, RigidTransform OBNNMAGIJBG)
	{
		return default(JPDNHHNOHOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x69DE160", Offset = "0x69DC960", VA = "0x1869DE160")]
	public static EAIJFICLBKC FKNHBCPLNGP(this JNPMLJAJCFH OOCDOIDHCLB, RigidTransform OBNNMAGIJBG)
	{
		return default(EAIJFICLBKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x69DE250", Offset = "0x69DCA50", VA = "0x1869DE250")]
	private static void GNDFDBKDBON(CFLIGJNFJEC DAHGPPHPHMD, RigidTransform OBNNMAGIJBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface OFEKIPCHALB
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	bool DKIAEBHGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	GABGGJOAGAC IPDOGEAMOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	CFLIGJNFJEC FEPALECHADG
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PPEGDCCPDMO KHCAMCHJFHJ;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GABGGJOAGAC PMMCFKHJGGB(GABGGJOAGAC CGKANMHMCOJ, GABGGJOAGAC LAMGMHLAEFA);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IPNOILGCMII(GABGGJOAGAC CGKANMHMCOJ, GABGGJOAGAC LAMGMHLAEFA, [Out] GABGGJOAGAC CNBFBOIBPGG);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AIJDAOKMIHK();

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LKMILLNCJCJ();

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BBIGDAGIJDL(GABGGJOAGAC CGKANMHMCOJ);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NLFELCIOCAM(GABGGJOAGAC CGKANMHMCOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public delegate void PPEGDCCPDMO(CFLIGJNFJEC HELOOOAGHDG, CFLIGJNFJEC BOGDPIJFMIE);
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class BBIBGIKALOK
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x69D4860", Offset = "0x69D3060", VA = "0x1869D4860")]
	public static bool NLGBBFJKAOG(this OFEKIPCHALB LHNEONJJJHG, CFLIGJNFJEC CGKANMHMCOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x69D4700", Offset = "0x69D2F00", VA = "0x1869D4700")]
	public static bool BEICJIAKBHI(this OFEKIPCHALB LHNEONJJJHG, GABGGJOAGAC CGKANMHMCOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x69D47E0", Offset = "0x69D2FE0", VA = "0x1869D47E0")]
	public static bool FIODFBLMGKI(this OFEKIPCHALB LHNEONJJJHG, GABGGJOAGAC CGKANMHMCOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface JEKIHDFEEAJ
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFAGOHNKEKP(CFLIGJNFJEC DAHGPPHPHMD, FAHIIHHFPKH OIOHIJOOPGO, List<CFLIGJNFJEC> GENNLFGNPCA);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FPMIOOPPFAG(CFLIGJNFJEC DAHGPPHPHMD, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHACNKDELGN(CFLIGJNFJEC DAHGPPHPHMD, List<CFLIGJNFJEC> GENNLFGNPCA);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IMLBDBIFEKB(CFLIGJNFJEC IDOOJPJNKLC, CFLIGJNFJEC CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CFLIGJNFJEC MJFMIHPBHPP(CFLIGJNFJEC IDOOJPJNKLC, int DHNLEFJCEAH, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFFGHNCLIIJ(CFLIGJNFJEC IDOOJPJNKLC, CFLIGJNFJEC CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HKONLDJOEML(CFLIGJNFJEC IDOOJPJNKLC, CFLIGJNFJEC CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JMFAEOMEKBH(CFLIGJNFJEC IDOOJPJNKLC, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GACKDDDLDGH(CFLIGJNFJEC IDOOJPJNKLC, CFLIGJNFJEC CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJABHLCEMHJ(Entity IDOOJPJNKLC, Entity CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IOJBKGEMKLE(Entity IDOOJPJNKLC, FAHIIHHFPKH OIOHIJOOPGO);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EIFEDMJMEFM(CFLIGJNFJEC CGKANMHMCOJ, FAHIIHHFPKH OIOHIJOOPGO);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface NODBBKLLHFG
{
	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDGGNJGGGPJ(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LMEMCANGILJ(GABGGJOAGAC DIHIHJFDGDD, Transform FMAJPAMCPCL);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface OFEPENDBMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ABILMJEFGKD(GABGGJOAGAC CGKANMHMCOJ, GABGGJOAGAC PKJGCNLLCMJ);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHHIAMBLMLI(GABGGJOAGAC CGKANMHMCOJ, GABGGJOAGAC EEEJNACAOMP);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FNMAJLOBJAH(GABGGJOAGAC CGKANMHMCOJ, [Out] GABGGJOAGAC HBMNFGFHBBJ);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface JGMHBGJEPKB
{
	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIIGPDBBLAK(GABGGJOAGAC JBFHMEKGHKH, bool JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGJFIOGBHPP(GABGGJOAGAC JBFHMEKGHKH, bool JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEAIOAIDLOA(GABGGJOAGAC JBFHMEKGHKH, int JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface DLONBJHNDJH
{
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<GABGGJOAGAC> HCOLLBPDPIB(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GABGGJOAGAC IOABKPOKDBB(GABGGJOAGAC DIHIHJFDGDD, int DHNLEFJCEAH);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int ENIJJNMIHEP(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KCOEAKMOKIN IELNAKGDNNB(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EFNCHHCDGNO(GABGGJOAGAC DIHIHJFDGDD, KCOEAKMOKIN LDMPLMIKDPA);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GABGGJOAGAC KCDIIHNGFJH(GABGGJOAGAC DIHIHJFDGDD, [Optional] float3? HGDCPNGLIKJ, [Optional] quaternion? LCDJINCAHMD, [Optional] float3? CDPPGBMBKAI);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GABGGJOAGAC JGIDCJEJEAF(GABGGJOAGAC DIHIHJFDGDD, int DHNLEFJCEAH, [Optional] float3? HGDCPNGLIKJ, [Optional] quaternion? LCDJINCAHMD, [Optional] float3? CDPPGBMBKAI);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GJFJHCFEBGJ(GABGGJOAGAC DIHIHJFDGDD, int DHNLEFJCEAH);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MCILAGJHGKK(GABGGJOAGAC DIHIHJFDGDD);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface NHBENDOGJAH
{
	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMMGNFCGHCB();

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKJPLDOCIOA();

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJPEGFOBPGA();

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDPFPKPHINP();

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGKFBEDADHD();

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFIJECODFLB();

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MDENKEGDKCE();

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HBCPABBHMML();

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GANIENOHPNI();

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ENHKAGCEBFH();

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BMDNJKFKKJD();

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MJHFJGAFGFD();

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DAHGOGNBPHK();
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface ABGGAFKHAHA
{
	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGCIAOHMBMK(GABGGJOAGAC CGKANMHMCOJ, [Out] int IDOOJPJNKLC);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COIDJNPCHNJ(GABGGJOAGAC CGKANMHMCOJ, int IDOOJPJNKLC);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIIFEHMIIDD(GABGGJOAGAC CGKANMHMCOJ, bool ALCIEIPEFBF);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFIIEKEDFNF(GABGGJOAGAC CGKANMHMCOJ, bool FJLABAPBACC);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLNNIJGEKAL(GABGGJOAGAC CGKANMHMCOJ, float INKBMGHKJBH, float DIAJGCFAFJA, float AAOPOGDBJKO);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PLHPLHBEHGK(GABGGJOAGAC DIHIHJFDGDD, [Out] float DIAJGCFAFJA, [Out] float AAOPOGDBJKO);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHLODHLOMEE(GABGGJOAGAC CGKANMHMCOJ, float3 HGDCPNGLIKJ, quaternion LCDJINCAHMD);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KCJEKCGMCOF(GABGGJOAGAC CGKANMHMCOJ, [Out] float3 HGDCPNGLIKJ, [Out] quaternion LCDJINCAHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface DPGMADCKOBA
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKDCPIBKPLD(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFPEKJMJACK(Entity IBKNLGIDEBH, [In] float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 CEGEMHDGALH(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PPDALCLHNIK(Entity IBKNLGIDEBH, [In] quaternion JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion NEOACCMAIKF(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAILHBIHAMN(Entity IBKNLGIDEBH, [In] float3 HGDCPNGLIKJ, [In] quaternion LCDJINCAHMD);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OEEKDAFMBLF(Entity IBKNLGIDEBH, [Out] float3 HGDCPNGLIKJ, [Out] quaternion LCDJINCAHMD);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OEEKDAFMBLF(Entity IBKNLGIDEBH, [Out] RigidTransform HJJJLBLOIEM);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HOJAIAAPPLH(Entity IBKNLGIDEBH, [Out] float3 HGDCPNGLIKJ, [Out] quaternion LCDJINCAHMD);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HOJAIAAPPLH(Entity IBKNLGIDEBH, [Out] RigidTransform HJJJLBLOIEM);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 LFNHJPOBDDC(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HGJJBAJEELB(Entity IBKNLGIDEBH, [In] float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JEFGELGEHBE(Entity IBKNLGIDEBH, float JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float AFALOFIDPKH(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JJHANEPODLG(Entity IBKNLGIDEBH, [In] float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 HKPIBPCKBFF(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GOBMMMCCMOD(Entity IBKNLGIDEBH, [In] float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 PDJNPAOEBPG(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KGELDGNHDHN(Entity IBKNLGIDEBH, [In] quaternion JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion KLPBKEKOHBE(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 PEHCFPCPOJA(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CLLJDAMABEE(Entity IBKNLGIDEBH, [In] float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IKBPGCGMLJD(Entity IBKNLGIDEBH, float JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float KHNFMMDFILB(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FPJCOFHJGJA(Entity IBKNLGIDEBH, [In] float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 BEIKAHCELFP(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OPCOKDEGPEL(Entity IBKNLGIDEBH, [Out] float4x4 KKCFNCIJCJM);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EMNLACHCEDI(Entity IBKNLGIDEBH, [In] float4x4 KKCFNCIJCJM);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MODHPEBAIDF(Entity IBKNLGIDEBH, [Out] float4x4 KKCFNCIJCJM);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool OMACENIOHBM(Entity IBKNLGIDEBH, [Out] Transform FMAJPAMCPCL);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void HANKEMAJJLN(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IIAGIIOMGBB(Entity IBKNLGIDEBH, Entity KFDMOGBAOBH, Entity KGHLFFBGAIM);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class KBODDGDBDKL
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface LEFLJIPBKBD
{
	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFJPDAKAILL(bool ILLAIMLPMFK);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface NKGLDAHENDP
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDMGMFAFJEA(GABGGJOAGAC IKLBGDHLNOF, IEnumerable<string> DJEEKAMJJDN);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JALGICJIEFA(GABGGJOAGAC IKLBGDHLNOF, IEnumerable<string> DJEEKAMJJDN);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHGIHHDBDAI(GABGGJOAGAC IKLBGDHLNOF, params string[] DJEEKAMJJDN);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALGOOAILCKJ(GABGGJOAGAC IKLBGDHLNOF, params string[] DJEEKAMJJDN);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFPODLJJDNG(GABGGJOAGAC IKLBGDHLNOF, params string[] DJEEKAMJJDN);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IIGHEIACCBG(GABGGJOAGAC IKLBGDHLNOF, params string[] DJEEKAMJJDN);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DLAENGAPGAJ(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int OPLMLDMLMED(GABGGJOAGAC IKLBGDHLNOF);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PCHOHEFADJL(GABGGJOAGAC IKLBGDHLNOF, ICollection<string> HOFHLKMCOBC);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LOPDGFONLHG(GABGGJOAGAC IKLBGDHLNOF, ICollection<string> HOFHLKMCOBC);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ELKDDIKDNEK(GABGGJOAGAC IKLBGDHLNOF, string LCFMJNPOPEB);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MFNNGCGNHCO(string LCFMJNPOPEB, HOCFFLIANIC LFKPCNOMHJI);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PIMIFEFKLGI(string LCFMJNPOPEB, HOCFFLIANIC LFKPCNOMHJI);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool FJODGEOKCEO();

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GLHBOCBIJNP(IEnumerable<string> DJEEKAMJJDN);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface NNOELHJJOKF
{
	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World KGDDJOKHNKC(string GGPLMHMGNFN = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World AIJDLOPIGCP(string GGPLMHMGNFN = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World POMDBJDPLCN(string GGPLMHMGNFN = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World BMKEOAEAKBK(string GGPLMHMGNFN = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface MICAOJNNFIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	World OKEKMCBEHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	World DOCAABILFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	EntityManager KLCONNELEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	bool OJBMAONCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase KJADMBAIOKD(Type NCMHJNKFAGH);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class LHIIKBJCPJA
{
	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x69E1230", Offset = "0x69DFA30", VA = "0x1869E1230")]
	public static ComponentSystemBase DANCHJFDMCD(this World FIFOANMDKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C08030", Offset = "0x2C06830", VA = "0x182C08030")]
	public static T KJADMBAIOKD<T>(this MICAOJNNFIH DHNIENCJEPG) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface JDENABBOJOL
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEKPNMHOCJD(NativeListAsync<Entity> AABDDEENPFB);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONBGBCLNEOI(DIIODEOBKFK BPMLBMKHNCH);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OAFKCOAMPPO(NativeListAsync<Entity> JCEIEDBBAIN, bool LBJGPACIEKD);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIDAAIKKBGE();
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface EKAKMJMKEBD
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JFIBPAMJLKA(Collider LKIKJGEBEHP, [Out] HCEDINLGGGF AHKFBMGFFGO);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface DBJGJGMBFAK
{
	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKCGEIKCJCG(GABGGJOAGAC DIHIHJFDGDD, [Out] Collider LKIKJGEBEHP);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject HNHNFMIAGIN(GABGGJOAGAC FBFKLNHIBNJ, GameObject OGCFILPLNFJ, Vector3 NJGBBMKGAPK, Quaternion IJKPBDDGPGD);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEMBONCBAIK(GameObject LKIKJGEBEHP);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider AIIKMKFFHAC<TCollider>(GameObject BMAMLPLANHJ) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABNEECKHIHI(Collider LKIKJGEBEHP);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BNHKJDBOJMH<TCollider>(string BHFPKCCDEEC) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public enum PCGBILCIBFI
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
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface JPMGNDBAAFH
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public struct KCLJHOKDHHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int FHILIIEAFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GameObject OGCFILPLNFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEEPAHPEFPJ(GABGGJOAGAC DIHIHJFDGDD, CNLPIGOIGNM FLDGCADNOJA, bool BKOJDGMJEML, HMOHHGDNCHA GFIJFGNCFIA);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPJFKIEOGBF(GABGGJOAGAC DIHIHJFDGDD, CNLPIGOIGNM FLDGCADNOJA, bool BKOJDGMJEML, bool DLOJIAPPCJB, bool KGPNLHMEFKH);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AANFAKNPOIP JEKAMCAMIDL(GABGGJOAGAC GFFCILHEGII, List<GABGGJOAGAC> KBNLBHNOMFH);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIGCKJPNOHP(GameObject DCBAJHNHPEK, GameObject GLOAKDOAPJH);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POGGGFAENDM(GameObject DCBAJHNHPEK, [In] FCCFNDGAOHI<GameObject> NLNMIEICMDO);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABGMNEDKDDK(GameObject GLOAKDOAPJH);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T AIIKMKFFHAC<T>(GameObject BMAMLPLANHJ) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ABNEECKHIHI(Collider LKIKJGEBEHP);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DMMJMNMNPIM(GKELIELGPBO DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KANJOOAEDHL(GKELIELGPBO DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject CIEBNELJEKD<T>(string BHFPKCCDEEC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OKJFLDDDMKP(Collider LKIKJGEBEHP, [Out] GABGGJOAGAC IDOOJPJNKLC);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JEKEOEJNNGC(GABGGJOAGAC DIHIHJFDGDD, [Out] HCEDINLGGGF AHKFBMGFFGO);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<PCGBILCIBFI> OGHOFDJGGIJ(Allocator CHDJMCMMMLJ = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] FIFJLPEANKJ();

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int JFKDLGENIFG(CNLPIGOIGNM FLDGCADNOJA);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string GOHGJJAMDNP(CNLPIGOIGNM FLDGCADNOJA);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface PCLMCHCPMKM
{
	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGJHIGDGICA(GABGGJOAGAC DIHIHJFDGDD, GABGGJOAGAC JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMFKCEMIMAH(GABGGJOAGAC DIHIHJFDGDD, GABGGJOAGAC JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int EHKOKKKOMEN(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GABGGJOAGAC BPLEDEIPGKB(GABGGJOAGAC DIHIHJFDGDD, int DHNLEFJCEAH);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GKELIELGPBO BOFEHEIHJNM(GABGGJOAGAC DIHIHJFDGDD, Allocator CHDJMCMMMLJ = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void COBNPPOPHOD(GABGGJOAGAC DIHIHJFDGDD, object EOCJCEFCOOA, GABGGJOAGAC JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BCKJLEOCMIP(GABGGJOAGAC DIHIHJFDGDD, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PJPOJFJDFPH(GABGGJOAGAC DIHIHJFDGDD, [Out] GABGGJOAGAC JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KMGGFOEKFKA(GABGGJOAGAC DIHIHJFDGDD, float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IDMMMCJDALA(GABGGJOAGAC DIHIHJFDGDD, [Out] float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DKHOBHFFCDN(GABGGJOAGAC DIHIHJFDGDD, float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NJANCFANIKC(GABGGJOAGAC DIHIHJFDGDD, [Out] float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CLLAABDMFPI(GABGGJOAGAC DIHIHJFDGDD, (Quaternion rot, Vector3 moments) CKEJAFLIMPB);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NAMNNCALABP(GABGGJOAGAC DIHIHJFDGDD, [Out] quaternion OBKMAHDAHKH, [Out] float3 LMPPIHJCCPP);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CEGPONPGBAN(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 CEBLNNEJGGM(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 KNJNNAKPDIK(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void INPBNNCFDAP(GABGGJOAGAC DIHIHJFDGDD, float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BOIGIGLMOEB(GABGGJOAGAC DIHIHJFDGDD, float3 JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float BLNPMCCHHCD(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float ODIDDMMFBPB(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FELHKLHIBFA(GABGGJOAGAC DIHIHJFDGDD, float JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PKPOPDEFFHF(GABGGJOAGAC DIHIHJFDGDD, float JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode JJMFHJONDOD(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EOOGJEMCBPC(GABGGJOAGAC DIHIHJFDGDD, CollisionDetectionMode JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EEPBOLJHLNK GEJCPEEOPKG(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AEBKJAAHEOD(GABGGJOAGAC DIHIHJFDGDD, EEPBOLJHLNK JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KNCIJKFMCOP(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GIADJLFNKCA(GABGGJOAGAC DIHIHJFDGDD, bool JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "29")]
	GABGGJOAGAC ELHIHCNAKGP(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IHGHEGFMBLF(GABGGJOAGAC DIHIHJFDGDD, GABGGJOAGAC JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "31")]
	GABGGJOAGAC EJGCADKFNOA(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void MMADMDAOMMK(GABGGJOAGAC DIHIHJFDGDD, GABGGJOAGAC JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "33")]
	ONPHIJJLPGG IHGCDFIEJCC(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void ALHPJDIDDPN(GABGGJOAGAC DIHIHJFDGDD, ONPHIJJLPGG EEBPBEAOODP);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool JEMANMGEPIP(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void AIALGNDAJDO(GABGGJOAGAC DIHIHJFDGDD, bool JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool NGDIJPIBAOA(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void BPIOECBLCPK(GABGGJOAGAC DIHIHJFDGDD, bool JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints AMKNKEJNCED(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void OOBHINEDOAA(GABGGJOAGAC DIHIHJFDGDD, RigidbodyConstraints JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float PJMKHCILKNN(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void JFNKDHKEHPD(GABGGJOAGAC DIHIHJFDGDD, float JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float KJJFBHAALAJ(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void ENIPKKOJHKH(GABGGJOAGAC DIHIHJFDGDD, float JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool INCOLHJACCK(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void NPBGIMDFJNN(GABGGJOAGAC DIHIHJFDGDD, bool JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool IEPADKJONEA(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void CANEDKLAHHB(GABGGJOAGAC DIHIHJFDGDD, bool JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void MGBBPOEJHAB(GABGGJOAGAC DIHIHJFDGDD, int JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "50")]
	GCCHGDAONKB LLLHGGGIFPP(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void HHBGCNCDLEL(GABGGJOAGAC DIHIHJFDGDD, GCCHGDAONKB JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "52")]
	LIJOKMDFOFH LILHMDNGGJO(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void LJOLENFLBMH(GABGGJOAGAC DIHIHJFDGDD, LIJOKMDFOFH JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float KLPPDJBJICK(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void AIOGMGGHDKM(GABGGJOAGAC DIHIHJFDGDD, float JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void IIADGIPOFFG(GABGGJOAGAC DIHIHJFDGDD, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void BAFMLOJCCOB(GABGGJOAGAC DIHIHJFDGDD, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool BAKDLPBNONB(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void LGHBAKFOMMG(GABGGJOAGAC DIHIHJFDGDD, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void ABANKGMGJCG(GABGGJOAGAC DIHIHJFDGDD, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool HIGEGMGDIGD(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool CAFFFNOJEGH(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody LJEEEHNKKOM(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void JMLLEDECKDL(GABGGJOAGAC DIHIHJFDGDD, Rigidbody KLDLKACCMKB);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void CDBCEDMLJNK(GABGGJOAGAC DIHIHJFDGDD, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void OLCAAIPHEIP(GABGGJOAGAC DIHIHJFDGDD, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool KALEGKHPEKI(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void JIHLKEIOHLK(GABGGJOAGAC DIHIHJFDGDD, float3 GPJLHMNPICC);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void MEHHKGJOADH(GABGGJOAGAC DIHIHJFDGDD, float3 FJCOMDPBLBJ);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool GOABEHFMMLF(GABGGJOAGAC DIHIHJFDGDD, [Out] float3 GPJLHMNPICC);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool ADBCLLHCFIG(GABGGJOAGAC DIHIHJFDGDD, [Out] float3 FJCOMDPBLBJ);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool PBLHJBGBIIE(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void PEGHPKPOHON(GABGGJOAGAC DIHIHJFDGDD, object EOCJCEFCOOA, bool MCDOCGGGECM);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void LDHDFFJGKOO(GABGGJOAGAC DIHIHJFDGDD, bool MFJIFHHNLHM);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void EGMILBKADJE(GABGGJOAGAC DIHIHJFDGDD);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool KOCBCHGIEOK(GABGGJOAGAC DIHIHJFDGDD);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface KKCIAEMAGGG
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEEKLNOAGCG(Entity DLILBLJHJOP);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCBIHHLPHLG(Entity DLILBLJHJOP);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface LAOEJNLDMGI
{
	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJPKCLMIPLM(GABGGJOAGAC CGKANMHMCOJ, bool LHEABDMGNNG);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBACIOCKNDK(GABGGJOAGAC CGKANMHMCOJ, int JGJFKDCDFCE);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public delegate void MEFENOMJPKM(FCPJAHEJJIB HJNMDLMCABK);
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct FCPJAHEJJIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly GKELIELGPBO DMMKJGFJIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NativeArray<byte> FFBMBHFNJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NativeArray<byte> NBHEMIIJOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MCGJEOBLIHK AOOLGPHJJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly int PHNOKPFAIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Type KGDKDOJABNK;

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public GKELIELGPBO NENKENGKJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1D0", Offset = "0xA689D0", VA = "0x180A6A1D0")]
		get
		{
			return default(GKELIELGPBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x69DB7E0", Offset = "0x69D9FE0", VA = "0x1869DB7E0")]
	public FCPJAHEJJIB(GKELIELGPBO DMMKJGFJIMJ, NativeArray<byte> FFBMBHFNJKJ, NativeArray<byte> NBHEMIIJOKA, MCGJEOBLIHK AOOLGPHJJIF, int PHNOKPFAIKG, Type KGDKDOJABNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D430", Offset = "0x2B0BC30", VA = "0x182B0D430")]
	public NativeArray<T> MEEEPMJABJC<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D470", Offset = "0x2B0BC70", VA = "0x182B0D470")]
	public NativeArray<T> NHLFIIPNFDA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D340", Offset = "0x2B0BB40", VA = "0x182B0D340")]
	public (GKELIELGPBO, NativeArray<T>, NativeArray<T>) JMJOGDIBBHK<T>() where T : struct
	{
		return default((GKELIELGPBO, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x69DB790", Offset = "0x69D9F90", VA = "0x1869DB790")]
	public EEFBLACHIAF MFNKAKOHCGG()
	{
		return default(EEFBLACHIAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface OEEGIKFJOAL
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	string NJEOHJMOBFF
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	OEEGIKFJOAL DNFBLLOCELF
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	IEnumerable<OEEGIKFJOAL> ALGKPMGHDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface CPNJCDJOJIK
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	OEEGIKFJOAL OOHGPAJIAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	List<HJNODMPKEND> GCOPNIGKGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FCLNDMCCENI(HJNODMPKEND FMACLHMOMLJ, [Out] OEEGIKFJOAL MFNJKEIOLKE);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGBCFAKMKJN(HJNODMPKEND FMACLHMOMLJ, MEFENOMJPKM NBCHKJPMADK);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODKKLEIBHOA(HJNODMPKEND FMACLHMOMLJ, MEFENOMJPKM NBCHKJPMADK);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public readonly struct EEFBLACHIAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FCPJAHEJJIB LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public GKELIELGPBO NENKENGKJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1D0", Offset = "0xA689D0", VA = "0x180A6A1D0")]
		get
		{
			return default(GKELIELGPBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x69D8390", Offset = "0x69D6B90", VA = "0x1869D8390")]
	public EEFBLACHIAF(FCPJAHEJJIB LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x69D81F0", Offset = "0x69D69F0", VA = "0x1869D81F0")]
	public GKELIELGPBO MEEEPMJABJC()
	{
		return default(GKELIELGPBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x69D82C0", Offset = "0x69D6AC0", VA = "0x1869D82C0")]
	public GKELIELGPBO NHLFIIPNFDA()
	{
		return default(GKELIELGPBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x69D80D0", Offset = "0x69D68D0", VA = "0x1869D80D0")]
	public (GKELIELGPBO, GKELIELGPBO, GKELIELGPBO) JMJOGDIBBHK()
	{
		return default((GKELIELGPBO, GKELIELGPBO, GKELIELGPBO));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
[DefaultMember("Item")]
public interface FOJFFCPEOPL : IEnumerable<FFENPHHDHJB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	NativeBitArray BMDLOAFIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	NativeBitArray DBEKOOBDICL
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	NativeArray<int> CHFKONLBLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	FFENPHHDHJB NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	FFENPHHDHJB NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FFENPHHDHJB GNMMNIBLHCP(IFOINEFCHDG LMFCCDBJMHJ);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MCGJEOBLIHK IOPNNBILCAC(IFOINEFCHDG LMFCCDBJMHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class CMJNLJMFNJL
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[DefaultMember("Item")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface CCJGGAOFMJC : IEnumerable<KMJGOIDHDFF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	KMJGOIDHDFF NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KMJGOIDHDFF GNMMNIBLHCP(IFOINEFCHDG LMFCCDBJMHJ);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCGJEOBLIHK IOPNNBILCAC(IFOINEFCHDG LMFCCDBJMHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class GGNPMMKNKOK
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2B27C90", Offset = "0x2B26490", VA = "0x182B27C90")]
	public static MCGJEOBLIHK IOPNNBILCAC<T>(this CCJGGAOFMJC JJHPFCNOMJP, MNECACGPLAM<T> BHFPKCCDEEC) where T : struct
	{
		return default(MCGJEOBLIHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[DefaultMember("Item")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface EOLACPHJBBM : IEnumerable<HJNODMPKEND>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	HJNODMPKEND NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HJNODMPKEND GNMMNIBLHCP(IFOINEFCHDG LMFCCDBJMHJ);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCGJEOBLIHK IOPNNBILCAC(IFOINEFCHDG LMFCCDBJMHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class PKOHHGONAOF
{
	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2CCBA30", Offset = "0x2CCA230", VA = "0x182CCBA30")]
	public static LPLHIELOOOK<T> GNMMNIBLHCP<T>(this EOLACPHJBBM JJHPFCNOMJP, IFOINEFCHDG BHFPKCCDEEC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2CCBB70", Offset = "0x2CCA370", VA = "0x182CCBB70")]
	public static MCGJEOBLIHK IOPNNBILCAC<T>(this EOLACPHJBBM JJHPFCNOMJP, MNECACGPLAM<T> BHFPKCCDEEC) where T : struct
	{
		return default(MCGJEOBLIHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface IBDNEEIKJMF
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGBCFAKMKJN(IFOINEFCHDG FMACLHMOMLJ, MEFENOMJPKM NBCHKJPMADK);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODKKLEIBHOA(IFOINEFCHDG FMACLHMOMLJ, MEFENOMJPKM NBCHKJPMADK);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class DGDJHFAOMGJ
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2978A40", Offset = "0x2977240", VA = "0x182978A40")]
	public static void JGBCFAKMKJN<T>(this IBDNEEIKJMF KMKOIGPAONL, MNECACGPLAM<T> FMACLHMOMLJ, MEFENOMJPKM NBCHKJPMADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2978DA0", Offset = "0x29775A0", VA = "0x182978DA0")]
	public static void ODKKLEIBHOA<T>(this IBDNEEIKJMF KMKOIGPAONL, MNECACGPLAM<T> FMACLHMOMLJ, MEFENOMJPKM NBCHKJPMADK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface JDIOGODBMBP
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	OCPJAEIFIEI JLCGAHKEKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKCEHGKMHPB(EPOHMNPJENA JHDNEHLEBCI, MCGJEOBLIHK FMACLHMOMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEEHGPKIHOD(EPOHMNPJENA JHDNEHLEBCI, Span<MCGJEOBLIHK> JJHPFCNOMJP, bool KGLLAMFFGDI);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CODGPGIFBDE(NativeArray<EPOHMNPJENA> BMNAGJGIMFF);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class DCHPJADPEEL
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x69D6F40", Offset = "0x69D5740", VA = "0x1869D6F40")]
	public static void LEEHGPKIHOD(this JDIOGODBMBP FELOOELBICC, EPOHMNPJENA JHDNEHLEBCI, MCGJEOBLIHK FMACLHMOMLJ, bool KGLLAMFFGDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public readonly struct OCPJAEIFIEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NativeBitArray JNOIABHFGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NativeParallelHashMap<EPOHMNPJENA, int> EFMBCIJCKJI;

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public bool INMPDDDBHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x69E4D20", Offset = "0x69E3520", VA = "0x1869E4D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x421A550", Offset = "0x4218D50", VA = "0x18421A550")]
	public OCPJAEIFIEI(NativeBitArray JNOIABHFGAN, NativeParallelHashMap<EPOHMNPJENA, int> EFMBCIJCKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x69E4BF0", Offset = "0x69E33F0", VA = "0x1869E4BF0")]
	public bool PKCEHGKMHPB(EPOHMNPJENA JHDNEHLEBCI, MCGJEOBLIHK FMACLHMOMLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface MOEKJPCAGLG
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EMCJHMJMEIG(GABGGJOAGAC DIHIHJFDGDD, JBCMKOAFGAE JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface PGFMHMDMBNJ
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	BCGPGMMDBCL LLPOIAIMAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface OGIGDDHJOLN
{
	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCJPAOMILGF(World FIFOANMDKIF);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIOLLPPKLLF(World FIFOANMDKIF);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase KEELFBEFLPM(World FIFOANMDKIF);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHBFELFFAOI(World FIFOANMDKIF);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDLLHNBLDIE(World FIFOANMDKIF);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DEIMLHIOOIC(World FIFOANMDKIF);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[MIFNEPPJGEL(MEHPOACPKMP.LoadInstance)]
public interface IJNFJLIGAJO
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIEHPAEIGMN(GABGGJOAGAC JBFHMEKGHKH, bool JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public readonly struct HNAICOPDEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IEnumerable<OPJAFGJLOGE> AEJHJMIIJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IReadOnlyList<GameObject> IBLABOGDCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IReadOnlyList<int> AONBNBNMLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IReadOnlyList<(EPOHMNPJENA, EPOHMNPJENA)> FPOJLALGACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly int JANNHFEAAJA;

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public bool OONANGMADII
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x69DE820", Offset = "0x69DD020", VA = "0x1869DE820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public int LDCPCGMIFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC330", VA = "0x1808CDB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public IEnumerable<GameObject> OOGBBGCHCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2900", VA = "0x1808C4100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public IEnumerable<(EPOHMNPJENA src, EPOHMNPJENA dst)> EEICOMDHONO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x69DEC10", Offset = "0x69DD410", VA = "0x1869DEC10")]
	public HNAICOPDEIO(IEnumerable<OPJAFGJLOGE> AEJHJMIIJFA, IReadOnlyList<GameObject> IBLABOGDCFC, IReadOnlyList<int> AONBNBNMLNA, IReadOnlyList<(EPOHMNPJENA src, EPOHMNPJENA dst)> FPOJLALGACB, int JANNHFEAAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x69DE880", Offset = "0x69DD080", VA = "0x1869DE880")]
	public (GameObject, int)[] BAKAKIAEOLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface IBBPDEFLGDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	bool OICEBBBNEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	bool OBDHKNLLHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	CHPNEJCIFNO BPBJMFBFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DINGILGPAEE EELLNOPHBCE();

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DINGILGPAEE OIIJBBFIDOH(IEnumerable<GABGGJOAGAC> CHNFMEBDLMI, [In] UniformTRS HHJIAENGEJE);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GACFLEBDEHB HPDFNDKCFLP(ByteString BGFENNGHPIM);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GGJKCEGNELM BJGJOIJCMCG(ByteString OEECENNMMAJ, GABGGJOAGAC BMBBFJPOJEB, [In] UniformTRS BABFPGECEKP, NIEFPGKNCPM ONHAIMNMPMD, bool NFMPHBFDKEA = true);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BDFFHHMCFOC();

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HNAICOPDEIO DMAJLLEIJPF(IEnumerable<OPJAFGJLOGE> AEJHJMIIJFA);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class EOOGDCCKLAO
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface PANLNDAOMBJ
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action HBLDDMKPKJH;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action OCJHKCIGCBA;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct ALEKPGEIKGH : NJJHNIHKEAO, IEquatable<ALEKPGEIKGH>
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static readonly int BEJLNLFBGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public DOELAEOOEOB LNPLCOCFIOP;

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x69D4560", Offset = "0x69D2D60", VA = "0x1869D4560", Slot = "5")]
	public void DGBBAPGEGII(DHBLCOCBCPJ ELOKBGPKALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x69D4630", Offset = "0x69D2E30", VA = "0x1869D4630", Slot = "4")]
	public void OPCGAJMHMBL(FJNPMJOLODL JLIOPEDCMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x69D4660", Offset = "0x69D2E60", VA = "0x1869D4660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x9E8AC0", Offset = "0x9E72C0", VA = "0x1809E8AC0", Slot = "6")]
	public bool Equals(ALEKPGEIKGH OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x69D4590", Offset = "0x69D2D90", VA = "0x1869D4590", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct OPJAFGJLOGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Guid BMIGIGGJPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public string MIMBCLCGJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Vector3 HGDCPNGLIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Quaternion LCDJINCAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Vector3 CDPPGBMBKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int DFNHGBINICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Dictionary<string, object> LDMPLMIKDPA;

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x69E5190", Offset = "0x69E3990", VA = "0x1869E5190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x69E5000", Offset = "0x69E3800", VA = "0x1869E5000")]
	private static string DMDCNPKCHFN(Dictionary<string, object> DNDCPHACLKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum JNNLMFCNDMJ
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
public static class BCBLPGEHJOK
{
	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4E10", Offset = "0x5DE3610", VA = "0x185DE4E10")]
	public static bool KPOAEMHMJAC(this JNNLMFCNDMJ NCMHJNKFAGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[Flags]
public enum NANPPDLGKPD
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
public interface GGJKCEGNELM : CHPNEJCIFNO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	NIEFPGKNCPM AJBONJDHKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGALHLJOLPH();

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOOINIMDIBF();
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface CHPNEJCIFNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	IEnumerable<OPJAFGJLOGE> KLJOMNOGILM
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	HNAICOPDEIO NPHKDNNOBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	JNNLMFCNDMJ EPCABOEGHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	LocalId PFKBIABJPHH
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	JJCDLIMMMGO FGAICKBDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MHMACPKANBJ(NANPPDLGKPD PFPJJNGLMCG);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface NIEFPGKNCPM
{
	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIIPCJPNIKJ(Guid HKKDPGGNNBK, [Out] Guid BCCFKHCCLFG);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface GACFLEBDEHB : CHPNEJCIFNO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[Flags]
public enum JFBHFAEJJMF
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
public interface DINGILGPAEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	JJCDLIMMMGO OLHCLJGOMMO
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString HIJDLMHCCGL();
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum KNNIMIJNBLC
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public delegate bool LGADBBKGJHG(DFAAKNOOHAL CHALDDPHCCA, [In] JHKEOJJDFBK JMDCGOKJIDA);
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public delegate bool OAGKJJIIFFH<T>(DFAAKNOOHAL CHALDDPHCCA, [In] T JMDCGOKJIDA);
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface CLJECOKMCPO
{
	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGBCFAKMKJN(MCGJEOBLIHK AOOLGPHJJIF, Type FPPJJFGLDKN, LGADBBKGJHG JBPEPLDBPCC);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDGPKNEHPPM(MCGJEOBLIHK AOOLGPHJJIF, [Out] LGADBBKGJHG JBPEPLDBPCC);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class DIFHLNCJENH
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class MGEMPEPHCON<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public OAGKJJIIFFH<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public MGEMPEPHCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x44912A0", Offset = "0x448FAA0", VA = "0x1844912A0")]
		internal bool ABEGDKBCEPF(DFAAKNOOHAL pendingList, [In] JHKEOJJDFBK value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x297B040", Offset = "0x2979840", VA = "0x18297B040")]
	public static void JGBCFAKMKJN<T>(this CLJECOKMCPO KMKOIGPAONL, MCGJEOBLIHK AOOLGPHJJIF, OAGKJJIIFFH<T> JBPEPLDBPCC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x69D70A0", Offset = "0x69D58A0", VA = "0x1869D70A0")]
	public static bool BMPIBCOEJFN(this CLJECOKMCPO KMKOIGPAONL, DFAAKNOOHAL CHALDDPHCCA, MCGJEOBLIHK AOOLGPHJJIF, [In] JHKEOJJDFBK JMDCGOKJIDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface HELDBOPPHEL
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	uint EMCMEFMBJGB
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface DFAAKNOOHAL
{
	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGIHDPGICNG(EPOHMNPJENA NJJAGEHACBF, MCGJEOBLIHK AOOLGPHJJIF, ReadOnlySpan<byte> GFANKNBGBFO, ReadOnlySpan<byte> EJMFFAEMBML);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLHCHDIJLNM(EPOHMNPJENA NJJAGEHACBF, MCGJEOBLIHK AOOLGPHJJIF, ReadOnlySpan<byte> GFANKNBGBFO, ReadOnlySpan<byte> EJMFFAEMBML);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EMPGJOAEFPC(EPOHMNPJENA NJJAGEHACBF, MCGJEOBLIHK AOOLGPHJJIF);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EKNAKALEOKN(EPOHMNPJENA NJJAGEHACBF, MCGJEOBLIHK AOOLGPHJJIF, ReadOnlySpan<byte> EJMFFAEMBML);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PMKGNOMBKLG(EPOHMNPJENA NJJAGEHACBF, MCGJEOBLIHK AOOLGPHJJIF, Span<byte> GFANKNBGBFO, Span<byte> EJMFFAEMBML);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class NFIPOILECBB
{
	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E1F0", Offset = "0x2C8C9F0", VA = "0x182C8E1F0")]
	public static bool PMKGNOMBKLG<T>(this DFAAKNOOHAL KLDKONKIIOI, EPOHMNPJENA NJJAGEHACBF, MCGJEOBLIHK AOOLGPHJJIF, [Out] T GFANKNBGBFO, [Out] T EJMFFAEMBML) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E0B0", Offset = "0x2C8C8B0", VA = "0x182C8E0B0")]
	public static bool EKNAKALEOKN<T>(this DFAAKNOOHAL KLDKONKIIOI, EPOHMNPJENA NJJAGEHACBF, MCGJEOBLIHK AOOLGPHJJIF, T EJMFFAEMBML) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum JGCMDCIKCJP
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
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface MALNAFGHNKF
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJMCEDFHBGN(BFEPFIEMBAL LDPKCIGIIMG, ReadOnlySpan<byte> MIJPDJDOIDB);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGLLGAKBGNE(uint DMHDBNDAJAC, ReadOnlySpan<byte> MIJPDJDOIDB);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAELNJDJNHG(int IPFPGPGFKPL);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface BEEJECLJHNE
{
	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFEPFIEMBAL FGGJGLGBPKC(ReadOnlySpan<byte> MIJPDJDOIDB);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface GMJKLKNOIED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGGOJHCENCO(BFEPFIEMBAL NDDCLPHCEEO, ReadOnlySpan<byte> MIJPDJDOIDB);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMIACGDBIHJ(ReadOnlySpan<BFEPFIEMBAL> MGHIBJLGAJJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct IODFLJOLEDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public BFEPFIEMBAL LDPKCIGIIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public ReadOnlyMemory<byte> MIJPDJDOIDB;
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct BFEPFIEMBAL
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static BFEPFIEMBAL LHFJOOCJFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public uint AKMNNFAFMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public int ABBCANHPMAJ;

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0xC3F080", Offset = "0xC3D880", VA = "0x180C3F080")]
	public BFEPFIEMBAL(uint AKMNNFAFMJG, int ABBCANHPMAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x69D60A0", Offset = "0x69D48A0", VA = "0x1869D60A0")]
	public static bool KBKLEFBHIDJ([In] BFEPFIEMBAL DIAAOCPNHKC, [In] BFEPFIEMBAL LLLBDLGIMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x69D5FC0", Offset = "0x69D47C0", VA = "0x1869D5FC0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x69D6070", Offset = "0x69D4870", VA = "0x1869D6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x69D60C0", Offset = "0x69D48C0", VA = "0x1869D60C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x69D5FB0", Offset = "0x69D47B0", VA = "0x1869D5FB0")]
	public void ACGMCNJANLE([Out] uint AKMNNFAFMJG, [Out] int ABBCANHPMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[MIFNEPPJGEL(MEHPOACPKMP.OMRoom)]
public interface BPAMOKFDKJO : HJOHCIOEKJJ<BPAMOKFDKJO>
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFKNBABIJFJ(MCGJEOBLIHK DKFNFHGODON, [Out] KPGGFCEOFHM JLMFPFPCHKD);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class LBCOLKKJDOD
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public interface KPGGFCEOFHM
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	Type JJMEHNEIMAI
	{
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGBBAPGEGII(DHBLCOCBCPJ ELOKBGPKALP, Span<byte> CGKANMHMCOJ);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPCGAJMHMBL(FJNPMJOLODL JLIOPEDCMBE, ReadOnlySpan<byte> LDPKCIGIIMG);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class LOIEDFILHIF
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct IBPLEJHIFCJ : ISystemStateComponentData, IComponentData, IEquatable<IBPLEJHIFCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 GOPLNKKAHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3 MNOBBCADDPL;

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x69DF7A0", Offset = "0x69DDFA0", VA = "0x1869DF7A0", Slot = "4")]
	public bool Equals(IBPLEJHIFCJ OKGBBGMIACH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class FFCOGINOOIO
{
	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public FFCOGINOOIO()
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
