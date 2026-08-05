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
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HOJCIPGJMNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> AKDCPDIONFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OLACMNNNFCK KJCFLDKONAB(OLACMNNNFCK HGLJHPGPPDC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Entity KJCFLDKONAB(Entity HGLJHPGPPDC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EGCFDCFHPMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DEGAMIMEMLN FIEBOMHOKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IKIEIANKFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFBLDOLKNNC(ByteString OAGMKJFIKKL, MGJJCLGNAJN AJKANCOMGHN = MGJJCLGNAJN.All);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJHKKFBAEIM();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFGBGLEFMAG();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LINKHNDCNGA();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JCNDCNBGKIM();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JPIJHPOKJLL();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NNAJJKACHNE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GLIHGKJNDBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public float3 JACLPJHPOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public quaternion AHDCMPCBKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float3 LIDNCELIAFO;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JDDPPIAFHCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ODAOEDJMBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IIGIKJCGFBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int ECFNCIDCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OKONJNLIEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CCDCDCKBHOC CFNKFALAEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	ONOLPANMIPA IOKBPGLBPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EEFAGBNPNLD(bool BGCPHEKMBDJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DLLPDOAGIEN(EGCFDCFHPMF FJANDPPHOJP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BILMDDAMLDC(GameObject MHECAANKLIB, out GEGPJNFMCPG PJIBLINGJGM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OFCDBBPPLKA(GameObject MHECAANKLIB, out bool GPGPNBIENLM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EFBCJPDNPOM(NativeArray<GEGPJNFMCPG> PJIBLINGJGM, NativeArray<GLIHGKJNDBF> NGCBDOCNCGO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DCFEMLAEOED HIALPPCNLEK(in GEGPJNFMCPG PJIBLINGJGM, in Vector3 JACLPJHPOFC, in Quaternion AHDCMPCBKHJ, in Vector3 LIDNCELIAFO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JGBADGNGGDE(GameObject MHECAANKLIB, bool IJGGEAEJOJO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PLINLCOKPOC(GameObject MHECAANKLIB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task BELMAPHBGHC();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JGNGHOFIOPM(object FNPGAOOPMNE);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BJLLBJLOPDJ(object FNPGAOOPMNE);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PKJDFFMGCFK(object LEPAGINGHFK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FLIHPGEHGLA(object GCALAGNGEDP, [Optional] object PHKKNFNFDNP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DGKEMJDMHAI(Transform BHPNFBEEMHL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BOHNAOGCFLD(Transform BHPNFBEEMHL, DMOIBLHBGCL CNNGOEELCJL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BNJFPPHMLIH(Transform BHPNFBEEMHL, GIKNMFHPAIG MGBMKLHMEEH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HBMPFCCPLAL(GameObject MHECAANKLIB, OBBNEPBOPBE KIBJHIDFPCO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3 NHJKHKDNJJK(GameObject MHECAANKLIB, int HJHIEBMCHJB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BDNIJAOEAEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DEGAMIMEMLN FIEBOMHOKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JDDPPIAFHCO OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	BHBECLCNBCK BONNMJFMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EGCFDCFHPMF NJEANANPJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	FDNCDAIFHHA EDAFGIAPEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DLIOKHGJHNN NEOMBDCOKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LBMBOABFHDF EALDJLPFMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FOJAKKAEGJD BAFEKHBBHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MDONMFNCNJF ABFCKKIPNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	ODHGFDMHCDN ALNEDOGAKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DILLBIDCLLI KJLHAFJFHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	EEMFEBEOLOO IIMEPKAIKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JFDNCMBCKCA JLLLBFHKFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	BNDFEICOCDN NPJIANAICGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	CGDNGNAEAEB DFOPPEKOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ENJBBMGPMHG GNPBDCHBHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct IDEMJCEPDIC<TKey> : IDisposable where TKey : struct, IEquatable<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct GKFHDEGEAJI
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeHashMap<TKey, GKFHDEGEAJI> BBDNOECODFL;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public struct GFHDAMOBKPG : IReadOnlyList<OLACMNNNFCK>, IEnumerable<OLACMNNNFCK>, IEnumerable, IReadOnlyCollection<OLACMNNNFCK>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct FICKICMCLOD : IEnumerator<OLACMNNNFCK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly PNPPGDJCNCL LCAGHKIOCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<Entity>.Enumerator EMOMAAKECJI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public OLACMNNNFCK IJPBKONCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5650810", Offset = "0x564F410", VA = "0x185650810", Slot = "4")]
			get
			{
				return default(OLACMNNNFCK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5650740", Offset = "0x564F340", VA = "0x185650740", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2A96DB0", Offset = "0x2A959B0", VA = "0x182A96DB0")]
		public FICKICMCLOD(PNPPGDJCNCL LCAGHKIOCIC, NativeArray<Entity>.Enumerator EMOMAAKECJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5650680", Offset = "0x564F280", VA = "0x185650680", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x56506C0", Offset = "0x564F2C0", VA = "0x1856506C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5650700", Offset = "0x564F300", VA = "0x185650700", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PNPPGDJCNCL LCAGHKIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeArray<Entity> MJFGMCFCBDM;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OLACMNNNFCK GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5650FD0", Offset = "0x564FBD0", VA = "0x185650FD0", Slot = "4")]
		get
		{
			return default(OLACMNNNFCK);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5650B90", Offset = "0x564F790", VA = "0x185650B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private int CDGJHJHGADK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECED0", Offset = "0x5EBAD0", VA = "0x1805ECED0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BBJDPOLPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECED0", Offset = "0x5EBAD0", VA = "0x1805ECED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GAJOLDEOPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5650BE0", Offset = "0x564F7E0", VA = "0x185650BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public NativeArray<Entity> JOGBCBNIAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2693970", Offset = "0x2692570", VA = "0x182693970")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5650F30", Offset = "0x564FB30", VA = "0x185650F30")]
	public GFHDAMOBKPG(int LAODCMGHKOP, PNPPGDJCNCL LCAGHKIOCIC, Allocator HGKGLCNFHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x24C94F0", Offset = "0x24C80F0", VA = "0x1824C94F0")]
	public GFHDAMOBKPG(PNPPGDJCNCL LCAGHKIOCIC, NativeArray<Entity> MJFGMCFCBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5650E80", Offset = "0x564FA80", VA = "0x185650E80")]
	public GFHDAMOBKPG(GFHDAMOBKPG FIDKDEIKIAJ, Allocator HGKGLCNFHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5650BA0", Offset = "0x564F7A0", VA = "0x185650BA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5650C20", Offset = "0x564F820", VA = "0x185650C20")]
	public FICKICMCLOD OKMFHIDEJFI()
	{
		return default(FICKICMCLOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5650CC0", Offset = "0x564F8C0", VA = "0x185650CC0", Slot = "6")]
	private IEnumerator<OLACMNNNFCK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5650DA0", Offset = "0x564F9A0", VA = "0x185650DA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DebuggerTypeProxy(typeof(JENHACFFGDA))]
public struct OLACMNNNFCK : IComparable<OLACMNNNFCK>, IEquatable<OLACMNNNFCK>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly OLACMNNNFCK EIEGJHHNOAD;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72D470", Offset = "0x72C070", VA = "0x18072D470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Entity LHHBOIJJOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x925B10", Offset = "0x924710", VA = "0x180925B10")]
		[CompilerGenerated]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2D62B50", Offset = "0x2D61750", VA = "0x182D62B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x56557E0", Offset = "0x56543E0", VA = "0x1856557E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool GENCDOFCIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x56557B0", Offset = "0x56543B0", VA = "0x1856557B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool CAACINLFJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5655580", Offset = "0x5654180", VA = "0x185655580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x56558A0", Offset = "0x56544A0", VA = "0x1856558A0")]
	public OLACMNNNFCK(PNPPGDJCNCL HIBAIJPNPAB, Entity OCMABEPCGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
	public NIJAIOMNHOO PNDBAIMDBOA()
	{
		return default(NIJAIOMNHOO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x925B10", Offset = "0x924710", VA = "0x180925B10")]
	public static Entity GOPIOOMOEDD(OLACMNNNFCK BGFDCIMIIMG)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5655830", Offset = "0x5654430", VA = "0x185655830")]
	public static bool NHPMPBNMAAP(OLACMNNNFCK FNKIIBFNLFB, OLACMNNNFCK EDLPJGEPJPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5655660", Offset = "0x5654260", VA = "0x185655660")]
	public static bool CLDCOCNHPOO(OLACMNNNFCK FNKIIBFNLFB, OLACMNNNFCK EDLPJGEPJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5655880", Offset = "0x5654480", VA = "0x185655880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5655710", Offset = "0x5654310", VA = "0x185655710", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA0B0", VA = "0x1808AB4B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x56556B0", Offset = "0x56542B0", VA = "0x1856556B0", Slot = "4")]
	public int CompareTo(OLACMNNNFCK NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "5")]
	public bool Equals(OLACMNNNFCK NPKIIGGBCCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LDHEPEEIGDA
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5653B40", Offset = "0x5652740", VA = "0x185653B40")]
	public static GEGPJNFMCPG OJFOEHBFNEO(this OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(GEGPJNFMCPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x56539F0", Offset = "0x56525F0", VA = "0x1856539F0")]
	public static NIJAIOMNHOO GJJJIKECOBM(this OLACMNNNFCK EBMPLNBFAKM, [Optional] object KJKNLGILOFJ)
	{
		return default(NIJAIOMNHOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class JENHACFFGDA
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct INDLONCDGDD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const uint MNNCAIMAPEG = 2147483648u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly OCODFBLNHLK HGAEFGJCCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal readonly OCODFBLNHLK OFINKJCDEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly uint CMMGEPMFJDB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5652350", Offset = "0x5650F50", VA = "0x185652350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public uint MIENPJNJMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A640", Offset = "0x3E59240", VA = "0x183E5A640")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5652620", Offset = "0x5651220", VA = "0x185652620")]
	public INDLONCDGDD(OCODFBLNHLK HGAEFGJCCPH, OCODFBLNHLK OFINKJCDEMA, uint CMMGEPMFJDB, bool HJKPHGIPGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5652360", Offset = "0x5650F60", VA = "0x185652360")]
	public bool KNNJEMMLBIL(INDLONCDGDD NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x56523B0", Offset = "0x5650FB0", VA = "0x1856523B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.History)]
	public readonly struct UndoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal readonly INDLONCDGDD KINCGCMCJLI;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool PDABALEFEIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5652350", Offset = "0x5650F50", VA = "0x185652350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE3FF40", Offset = "0xE3EB40", VA = "0x180E3FF40")]
		internal UndoAction(INDLONCDGDD KINCGCMCJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5656D60", Offset = "0x5655960", VA = "0x185656D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.History)]
	public readonly struct RedoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly INDLONCDGDD KINCGCMCJLI;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool PDABALEFEIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5652350", Offset = "0x5650F50", VA = "0x185652350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xE3FF40", Offset = "0xE3EB40", VA = "0x180E3FF40")]
		internal RedoAction(INDLONCDGDD KINCGCMCJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5656D60", Offset = "0x5655960", VA = "0x185656D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct HOFFGBEPKBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	internal readonly uint CMMGEPMFJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal readonly bool AFNOHOMMBJH;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x56516D0", Offset = "0x56502D0", VA = "0x1856516D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OCODFBLNHLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal int FPKCCNCOJGI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0")]
	public OCODFBLNHLK(int FPKCCNCOJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5655470", Offset = "0x5654070", VA = "0x185655470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum EDGMFANNLAF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DCFEMLAEOED : AMLIMGALOLN
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	EDGMFANNLAF KFCHNBEOHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool FBDMEKJCKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GameObject MHECAANKLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnEmbody(BHBECLCNBCK JFAHNIMFMGP, OLACMNNNFCK DLHOMKCKDFA);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnDisembody(bool IIMCHILOLIK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PHLCFGMBAED
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x56562D0", Offset = "0x5654ED0", VA = "0x1856562D0")]
	public static bool IHHKOCLPKGP(this DCFEMLAEOED MPHBIKLMOEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x56561F0", Offset = "0x5654DF0", VA = "0x1856561F0")]
	public static bool BEFGGBECCFA(this DCFEMLAEOED MPHBIKLMOEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5656320", Offset = "0x5654F20", VA = "0x185656320")]
	public static bool MFBLCAGIMBG(this DCFEMLAEOED MPHBIKLMOEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5656240", Offset = "0x5654E40", VA = "0x185656240")]
	public static bool GAILNDCGGNK(this DCFEMLAEOED MPHBIKLMOEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AMLIMGALOLN
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	OLACMNNNFCK IBMOHDDKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BIIMOMDCJGN : global::GNBEEICGICM<GEGPJNFMCPG>, AAIBJIBIIGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GFEEPGJPLML(in CJHLIFJIIDK KGJOJGIPNPH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MFOLKMBMNHP<T> : global::GJOMGFAOOGO<GEGPJNFMCPG, T>, global::GNBEEICGICM<GEGPJNFMCPG>, AAIBJIBIIGL, IDisposable, BIIMOMDCJGN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class MIOJIMDDGPH
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1AA8CB0", Offset = "0x1AA78B0", VA = "0x181AA8CB0")]
	public static T JHLAPKAGPFG<T>(this global::GNBEEICGICM<GEGPJNFMCPG> MDENPOJAPFE, GEGPJNFMCPG PJIBLINGJGM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x27E3810", Offset = "0x27E2410", VA = "0x1827E3810")]
	public static bool GELHLBKPBFF<T>(this global::GNBEEICGICM<GEGPJNFMCPG> MDENPOJAPFE, GEGPJNFMCPG PJIBLINGJGM, in T FMKHLEANADK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CNAIOOCFPBI : global::GNBEEICGICM<OLACMNNNFCK>, AAIBJIBIIGL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface MGBAHOPOBPI<T> : global::GJOMGFAOOGO<OLACMNNNFCK, T>, global::GNBEEICGICM<OLACMNNNFCK>, AAIBJIBIIGL, IDisposable, CNAIOOCFPBI where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GHLGFNOPHIE
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2019A30", Offset = "0x2018630", VA = "0x182019A30")]
	public static T JHLAPKAGPFG<T>(this global::GNBEEICGICM<OLACMNNNFCK> MDENPOJAPFE, OLACMNNNFCK AIJKIAIKFDH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27E1D20", Offset = "0x27E0920", VA = "0x1827E1D20")]
	public static bool GELHLBKPBFF<T>(this global::GNBEEICGICM<OLACMNNNFCK> MDENPOJAPFE, OLACMNNNFCK AIJKIAIKFDH, in T FMKHLEANADK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LOGKGBLPOOD : IComparable<LOGKGBLPOOD>, IEquatable<LOGKGBLPOOD>
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly LOGKGBLPOOD EIEGJHHNOAD;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly LOGKGBLPOOD MAKPCLMEKLM;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly LOGKGBLPOOD MEFONJBJIPL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly LOGKGBLPOOD GMLOPMBELMH;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly LOGKGBLPOOD INJMALCLDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public int PAOIHHHPKNO;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0")]
	public LOGKGBLPOOD(int HIANDEDCLIF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x229D400", Offset = "0x229C000", VA = "0x18229D400")]
	public static bool NHPMPBNMAAP(LOGKGBLPOOD FNKIIBFNLFB, LOGKGBLPOOD EDLPJGEPJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5653D70", Offset = "0x5652970", VA = "0x185653D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5653CF0", Offset = "0x56528F0", VA = "0x185653CF0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xD8F730", Offset = "0xD8E330", VA = "0x180D8F730", Slot = "5")]
	public bool Equals(LOGKGBLPOOD NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x22A29B0", Offset = "0x22A15B0", VA = "0x1822A29B0", Slot = "4")]
	public int CompareTo(LOGKGBLPOOD NPKIIGGBCCI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x790150", Offset = "0x78ED50", VA = "0x180790150")]
	public static LOGKGBLPOOD GOPIOOMOEDD(int HIANDEDCLIF)
	{
		return default(LOGKGBLPOOD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x790150", Offset = "0x78ED50", VA = "0x180790150")]
	public static int GOPIOOMOEDD(LOGKGBLPOOD IPGOEGFNLNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5653DD0", Offset = "0x56529D0", VA = "0x185653DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct NIJAIOMNHOO : IEquatable<NIJAIOMNHOO>, AMLIMGALOLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public OLACMNNNFCK IBMOHDDKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810", Slot = "5")]
		get
		{
			return default(OLACMNNNFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public COBDFJDIJOG LNBAHGNJKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(COBDFJDIJOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public KBOALBNCNPM EDAFGIAPEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(KBOALBNCNPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GameObject MHECAANKLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5654970", Offset = "0x5653570", VA = "0x185654970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GEGPJNFMCPG KPIGGIAPFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5654D20", Offset = "0x5653920", VA = "0x185654D20")]
		get
		{
			return default(GEGPJNFMCPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IFCMLGGILLI NDCBEMENAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x56552A0", Offset = "0x5653EA0", VA = "0x1856552A0")]
		get
		{
			return default(IFCMLGGILLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public CMECOJAJFAB HPFMIMKFAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5654A80", Offset = "0x5653680", VA = "0x185654A80")]
		get
		{
			return default(CMECOJAJFAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GOIKCKNDCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5654EA0", Offset = "0x5653AA0", VA = "0x185654EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool KHKNFFEKKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5655380", Offset = "0x5653F80", VA = "0x185655380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IIEPIDENEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5654D00", Offset = "0x5653900", VA = "0x185654D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool ILFCCBAMIKD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5654EC0", Offset = "0x5653AC0", VA = "0x185654EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JFHBGJNECPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5654EE0", Offset = "0x5653AE0", VA = "0x185654EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool JJAADDFOJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5655000", Offset = "0x5653C00", VA = "0x185655000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool LDLACPGCDBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5654FE0", Offset = "0x5653BE0", VA = "0x185654FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NDOCPGCHBBJ JPPIDBOFMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NDOCPGCHBBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BBEKADJHELJ NKLNMDNGAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(BBEKADJHELJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EPPBEIDHNLF DFOPPEKOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(EPPBEIDHNLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public PCDCLIGAAMG EDGLCHDILNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(PCDCLIGAAMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public JDJMJODGPAB JLLLBFHKFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(JDJMJODGPAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public PAJHNJALCMN LPGPFGJLLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(PAJHNJALCMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool IHHKOCLPKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5654BC0", Offset = "0x56537C0", VA = "0x185654BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public NIJAIOMNHOO(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x564C3B0", Offset = "0x564AFB0", VA = "0x18564C3B0")]
	public static bool GOPIOOMOEDD(NIJAIOMNHOO KGJOJGIPNPH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810")]
	public static OLACMNNNFCK GOPIOOMOEDD(NIJAIOMNHOO KGJOJGIPNPH)
	{
		return default(OLACMNNNFCK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080")]
	public static bool NHPMPBNMAAP(NIJAIOMNHOO FNKIIBFNLFB, NIJAIOMNHOO EDLPJGEPJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5654DF0", Offset = "0x56539F0", VA = "0x185654DF0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(NIJAIOMNHOO NPKIIGGBCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
	public static NIJAIOMNHOO GOPIOOMOEDD(OLACMNNNFCK DJJOBHOILOH)
	{
		return default(NIJAIOMNHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5655020", Offset = "0x5653C20", VA = "0x185655020")]
	public ANMPIPGPBIJ KAAOINDPDFI()
	{
		return default(ANMPIPGPBIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5655240", Offset = "0x5653E40", VA = "0x185655240")]
	public POENGKIIBEM NFLGPMJPMMJ()
	{
		return default(POENGKIIBEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5654B60", Offset = "0x5653760", VA = "0x185654B60")]
	public EMNJFMALKFJ BJGPDBPEMMB()
	{
		return default(EMNJFMALKFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5654CA0", Offset = "0x56538A0", VA = "0x185654CA0")]
	public FFANDBIFHPN DLOILMIELJJ()
	{
		return default(FFANDBIFHPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5654F00", Offset = "0x5653B00", VA = "0x185654F00")]
	public void GJJJIKECOBM([Optional] object KJKNLGILOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5655080", Offset = "0x5653C80", VA = "0x185655080")]
	public void LEDODGGAFMD(object KJKNLGILOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5655150", Offset = "0x5653D50", VA = "0x185655150")]
	public bool MKGAPOGLBHP(object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x56553A0", Offset = "0x5653FA0", VA = "0x1856553A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct ANMPIPGPBIJ : IEquatable<ANMPIPGPBIJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly ANMPIPGPBIJ KHMKPPMMAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public OLACMNNNFCK IBMOHDDKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810")]
		get
		{
			return default(OLACMNNNFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public COBDFJDIJOG LNBAHGNJKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(COBDFJDIJOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public KBOALBNCNPM EDAFGIAPEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(KBOALBNCNPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x564C800", Offset = "0x564B400", VA = "0x18564C800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private FDNCDAIFHHA IHODABLDNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x564CBA0", Offset = "0x564B7A0", VA = "0x18564CBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public IEnumerable<OLACMNNNFCK> PFLAJMCOMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x564CA90", Offset = "0x564B690", VA = "0x18564CA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public IEnumerable<NIJAIOMNHOO> KKHMGMKNEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x564C8A0", Offset = "0x564B4A0", VA = "0x18564C8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public IEnumerable<NIJAIOMNHOO> MJOLNOCKHHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x564C3F0", Offset = "0x564AFF0", VA = "0x18564C3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int JJCDLIDHGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x564C9B0", Offset = "0x564B5B0", VA = "0x18564C9B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int AOGABIOFAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x564C850", Offset = "0x564B450", VA = "0x18564C850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public string DNLLPFFBEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x564C720", Offset = "0x564B320", VA = "0x18564C720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public ANMPIPGPBIJ(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x564C3B0", Offset = "0x564AFB0", VA = "0x18564C3B0")]
	public static bool GOPIOOMOEDD(ANMPIPGPBIJ KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x564C300", Offset = "0x564AF00", VA = "0x18564C300", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(ANMPIPGPBIJ NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
	public static NIJAIOMNHOO GOPIOOMOEDD(ANMPIPGPBIJ NBELCHPBKDK)
	{
		return default(NIJAIOMNHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x564C2E0", Offset = "0x564AEE0", VA = "0x18564C2E0")]
	public bool CFFCIHOHNPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x564C500", Offset = "0x564B100", VA = "0x18564C500")]
	public GFHDAMOBKPG IKHNCKEDMPB(Allocator HGKGLCNFHPJ)
	{
		return default(GFHDAMOBKPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct DICPPLCINMP : IEquatable<DICPPLCINMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x564F7D0", Offset = "0x564E3D0", VA = "0x18564F7D0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(DICPPLCINMP NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BBEKADJHELJ : IEquatable<BBEKADJHELJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public BBEKADJHELJ(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x564CC20", Offset = "0x564B820", VA = "0x18564CC20", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(BBEKADJHELJ NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x564CDA0", Offset = "0x564B9A0", VA = "0x18564CDA0")]
	public void MOANCCAMPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x564CCD0", Offset = "0x564B8D0", VA = "0x18564CCD0")]
	public void GENHPMKNFBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct EMNJFMALKFJ : IEquatable<EMNJFMALKFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public EMNJFMALKFJ(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x56500B0", Offset = "0x564ECB0", VA = "0x1856500B0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(EMNJFMALKFJ NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct EFDGHBNHKAG : IEquatable<EFDGHBNHKAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x564FED0", Offset = "0x564EAD0", VA = "0x18564FED0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(EFDGHBNHKAG NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IJEPKHAAEMP : IEquatable<IJEPKHAAEMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x56522A0", Offset = "0x5650EA0", VA = "0x1856522A0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(IJEPKHAAEMP NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OGFNKEEPFCM : IEquatable<OGFNKEEPFCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x56554D0", Offset = "0x56540D0", VA = "0x1856554D0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(OGFNKEEPFCM NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct KBOALBNCNPM : IEquatable<KBOALBNCNPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public OLACMNNNFCK IBMOHDDKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810")]
		get
		{
			return default(OLACMNNNFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x56532D0", Offset = "0x5651ED0", VA = "0x1856532D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private FDNCDAIFHHA IHODABLDNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5653520", Offset = "0x5652120", VA = "0x185653520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public OLACMNNNFCK PDFPFNFAOEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5653430", Offset = "0x5652030", VA = "0x185653430")]
		get
		{
			return default(OLACMNNNFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public NIJAIOMNHOO CFPOOABENIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x56531D0", Offset = "0x5651DD0", VA = "0x1856531D0")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public KBOALBNCNPM(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5653120", Offset = "0x5651D20", VA = "0x185653120", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(KBOALBNCNPM NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5653320", Offset = "0x5651F20", VA = "0x185653320")]
	public bool KMBIIDLEBDG(NIJAIOMNHOO MKOLBPGKLJP, bool CFGNJOFBFIH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5653030", Offset = "0x5651C30", VA = "0x185653030")]
	public bool EAHMDJKDIOJ(NIJAIOMNHOO MCHPJLFOAJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct NDOCPGCHBBJ : IEquatable<NDOCPGCHBBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string OIOLMCDGAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5654880", Offset = "0x5653480", VA = "0x185654880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public NDOCPGCHBBJ(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x56548C0", Offset = "0x56534C0", VA = "0x1856548C0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(NDOCPGCHBBJ NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct JCDINBNFPJG : IEquatable<JCDINBNFPJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5652640", Offset = "0x5651240", VA = "0x185652640", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(JCDINBNFPJG NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct EPPBEIDHNLF : IEquatable<EPPBEIDHNLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public OLACMNNNFCK IBMOHDDKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810")]
		get
		{
			return default(OLACMNNNFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float ADDHLLEHDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5650330", Offset = "0x564EF30", VA = "0x185650330")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 CPAGCCDBIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5650160", Offset = "0x564ED60", VA = "0x185650160")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public EPPBEIDHNLF(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x56503A0", Offset = "0x564EFA0", VA = "0x1856503A0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(EPPBEIDHNLF NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5650210", Offset = "0x564EE10", VA = "0x185650210")]
	public bool BKDLPKLOEPP(out Collider PCJIIECCPGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct PCDCLIGAAMG : IEquatable<PCDCLIGAAMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private AHPFMEFHLKN PFKAHPBEALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5656040", Offset = "0x5654C40", VA = "0x185656040")]
		get
		{
			return default(AHPFMEFHLKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool LHFGHEFCGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5656170", Offset = "0x5654D70", VA = "0x185656170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool DBEHGBEANLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5655FC0", Offset = "0x5654BC0", VA = "0x185655FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool LJOPFLEAPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5655D60", Offset = "0x5654960", VA = "0x185655D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DMFLMCKDJKK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5655C70", Offset = "0x5654870", VA = "0x185655C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool CJFOCHHPCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5655C60", Offset = "0x5654860", VA = "0x185655C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool JDGLLACJPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5655C90", Offset = "0x5654890", VA = "0x185655C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool ENKPPJPMPKK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5655ED0", Offset = "0x5654AD0", VA = "0x185655ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool EPBGOFCMCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x56561E0", Offset = "0x5654DE0", VA = "0x1856561E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool NDCCIPNFBND
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5656160", Offset = "0x5654D60", VA = "0x185656160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool EICPDPIFGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5655CA0", Offset = "0x56548A0", VA = "0x185655CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool OLNDBLAFMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5655EE0", Offset = "0x5654AE0", VA = "0x185655EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool LMIANKFKLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5655C80", Offset = "0x5654880", VA = "0x185655C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public bool IPINOJHAMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5655FD0", Offset = "0x5654BD0", VA = "0x185655FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 ILCHIFAJPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5655EF0", Offset = "0x5654AF0", VA = "0x185655EF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Vector3 PHBLECNKKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x56560A0", Offset = "0x5654CA0", VA = "0x1856560A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public PCDCLIGAAMG(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5655CB0", Offset = "0x56548B0", VA = "0x185655CB0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(PCDCLIGAAMG NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5655E50", Offset = "0x5654A50", VA = "0x185655E50")]
	public bool JEIGELMLMNC(JJHDDLJFOCE JANGOMFIKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5655D70", Offset = "0x5654970", VA = "0x185655D70")]
	public void FEMFIOGMEDB(JJHDDLJFOCE JANGOMFIKHC, bool INBOJIDPLPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct FFANDBIFHPN : IEquatable<FFANDBIFHPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private MJFDGALIJIE MLDDCCIOMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5650450", Offset = "0x564F050", VA = "0x185650450")]
		get
		{
			return default(MJFDGALIJIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public KOMBGIFPLPP JHBAKPJCCNP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5650560", Offset = "0x564F160", VA = "0x185650560")]
		get
		{
			return default(KOMBGIFPLPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public FFANDBIFHPN(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x56504B0", Offset = "0x564F0B0", VA = "0x1856504B0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(FFANDBIFHPN NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x56505D0", Offset = "0x564F1D0", VA = "0x1856505D0")]
	public ANLJHOADIOE PGPJMKFFBHN()
	{
		return default(ANLJHOADIOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct ANLJHOADIOE : IEquatable<ANLJHOADIOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private KGPKOABFDHE NJMKNKBOKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x564C220", Offset = "0x564AE20", VA = "0x18564C220")]
		get
		{
			return default(KGPKOABFDHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GPILGPICAJM DDMCFEIMIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x564C1A0", Offset = "0x564ADA0", VA = "0x18564C1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public ANLJHOADIOE(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x564C0D0", Offset = "0x564ACD0", VA = "0x18564C0D0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(ANLJHOADIOE NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct PAJHNJALCMN : IEquatable<PAJHNJALCMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5655AD0", Offset = "0x56546D0", VA = "0x185655AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public PAJHNJALCMN(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x56558F0", Offset = "0x56544F0", VA = "0x1856558F0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(PAJHNJALCMN NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x56559A0", Offset = "0x56545A0", VA = "0x1856559A0")]
	public void JNAPFEBNPGA(bool KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5655B20", Offset = "0x5654720", VA = "0x185655B20")]
	public void MHHCKCBOHOJ(bool KGJOJGIPNPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct JDJMJODGPAB : IEquatable<JDJMJODGPAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public OLACMNNNFCK IBMOHDDKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810")]
		get
		{
			return default(OLACMNNNFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5652E00", Offset = "0x5651A00", VA = "0x185652E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private JFDNCMBCKCA IELCNDFMBKC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5652E50", Offset = "0x5651A50", VA = "0x185652E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool ONFGCPOGHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5652A90", Offset = "0x5651690", VA = "0x185652A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool MBGJBEOBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5652ED0", Offset = "0x5651AD0", VA = "0x185652ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool BPGDCGBOHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5652FD0", Offset = "0x5651BD0", VA = "0x185652FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool LHCCCOJPEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5653000", Offset = "0x5651C00", VA = "0x185653000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool NLPJLKEMJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5652990", Offset = "0x5651590", VA = "0x185652990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool OGIIJJJINDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5652CA0", Offset = "0x56518A0", VA = "0x185652CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public JDJMJODGPAB(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x564C3B0", Offset = "0x564AFB0", VA = "0x18564C3B0")]
	public static bool GOPIOOMOEDD(JDJMJODGPAB KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x56528E0", Offset = "0x56514E0", VA = "0x1856528E0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(JDJMJODGPAB NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x56526F0", Offset = "0x56512F0", VA = "0x1856526F0")]
	public void AOIBJDJCMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5652B70", Offset = "0x5651770", VA = "0x185652B70")]
	public NIJAIOMNHOO FLKPKPIMPED(NIJAIOMNHOO FNPGAOOPMNE)
	{
		return default(NIJAIOMNHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5652720", Offset = "0x5651320", VA = "0x185652720")]
	public OLACMNNNFCK BBEFMAJNLOO()
	{
		return default(OLACMNNNFCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct POENGKIIBEM : IEquatable<POENGKIIBEM>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly POENGKIIBEM KHMKPPMMAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public OLACMNNNFCK IBMOHDDKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810")]
		get
		{
			return default(OLACMNNNFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public COBDFJDIJOG LNBAHGNJKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(COBDFJDIJOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private LJBPAFPBABC DCGMLPGFMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5656C80", Offset = "0x5655880", VA = "0x185656C80")]
		get
		{
			return default(LJBPAFPBABC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public CMHHGIKCJKC OKABAPMPHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x56564F0", Offset = "0x56550F0", VA = "0x1856564F0")]
		get
		{
			return default(CMHHGIKCJKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public IBPHBGPKMHN KJJCNBICPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5656550", Offset = "0x5655150", VA = "0x185656550")]
		get
		{
			return default(IBPHBGPKMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public ANLGOHBGHDE FPLPLEDLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5656620", Offset = "0x5655220", VA = "0x185656620")]
		get
		{
			return default(ANLGOHBGHDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public NLLNHNNMAMI DNPNMCJJMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x56567E0", Offset = "0x56553E0", VA = "0x1856567E0")]
		get
		{
			return default(NLLNHNNMAMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public HEIDOPLIFDP OHHBFPNDCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5656C10", Offset = "0x5655810", VA = "0x185656C10")]
		get
		{
			return default(HEIDOPLIFDP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5656680", Offset = "0x5655280", VA = "0x185656680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public GGBPBHPAHHF JCHGKMGMAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x56565B0", Offset = "0x56551B0", VA = "0x1856565B0")]
		get
		{
			return default(GGBPBHPAHHF);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5656760", Offset = "0x5655360", VA = "0x185656760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public float INJLNDFEGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5656BA0", Offset = "0x56557A0", VA = "0x185656BA0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5656B20", Offset = "0x5655720", VA = "0x185656B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 NJHFGIPFKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5656A90", Offset = "0x5655690", VA = "0x185656A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public float ECIBEGJLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x56569B0", Offset = "0x56555B0", VA = "0x1856569B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public ShapeConfigData.Flags EPOGJGFNJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5656940", Offset = "0x5655540", VA = "0x185656940")]
		get
		{
			return default(ShapeConfigData.Flags);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5656CE0", Offset = "0x56558E0", VA = "0x185656CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public POENGKIIBEM(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x564C3B0", Offset = "0x564AFB0", VA = "0x18564C3B0")]
	public static bool GOPIOOMOEDD(POENGKIIBEM KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5656890", Offset = "0x5655490", VA = "0x185656890", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(POENGKIIBEM NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5656A30", Offset = "0x5655630", VA = "0x185656A30")]
	public PMDGNJFCLOI HGDDDCAOIML()
	{
		return default(PMDGNJFCLOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5656700", Offset = "0x5655300", VA = "0x185656700")]
	public ICMKMEOPNCP DIFMLHMPNCN()
	{
		return default(ICMKMEOPNCP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PMDGNJFCLOI : IEquatable<PMDGNJFCLOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public OLACMNNNFCK IBMOHDDKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810")]
		get
		{
			return default(OLACMNNNFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public COBDFJDIJOG LNBAHGNJKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(COBDFJDIJOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public POENGKIIBEM KFANBPBJLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(POENGKIIBEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private OLMGIAKBJJK KIFJIDJGKKF
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5656490", Offset = "0x5655090", VA = "0x185656490")]
		get
		{
			return default(OLMGIAKBJJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public HNGFAHNAKGA JJLNJEGKBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5656420", Offset = "0x5655020", VA = "0x185656420")]
		get
		{
			return default(HNGFAHNAKGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public PMDGNJFCLOI(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x564C3B0", Offset = "0x564AFB0", VA = "0x18564C3B0")]
	public static bool GOPIOOMOEDD(PMDGNJFCLOI KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5656370", Offset = "0x5654F70", VA = "0x185656370", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(PMDGNJFCLOI NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public struct ICMKMEOPNCP : IEquatable<ICMKMEOPNCP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public OLACMNNNFCK IBMOHDDKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810")]
		get
		{
			return default(OLACMNNNFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public COBDFJDIJOG LNBAHGNJKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(COBDFJDIJOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5652040", Offset = "0x5650C40", VA = "0x185652040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private DILLBIDCLLI KJLHAFJFHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5651FC0", Offset = "0x5650BC0", VA = "0x185651FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public POENGKIIBEM KFANBPBJLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(POENGKIIBEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private AFJDDNJABHB FJKFJPKGFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5652090", Offset = "0x5650C90", VA = "0x185652090")]
		get
		{
			return default(AFJDDNJABHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public DFJBBJNIPDN KIKHFEICOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5651750", Offset = "0x5650350", VA = "0x185651750")]
		get
		{
			return default(DFJBBJNIPDN);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5652210", Offset = "0x5650E10", VA = "0x185652210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public IEnumerable<NHHMKJOCNML> PPFPBMLJFNL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x56517E0", Offset = "0x56503E0", VA = "0x1856517E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public NHHMKJOCNML GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5651900", Offset = "0x5650500", VA = "0x185651900")]
		get
		{
			return default(NHHMKJOCNML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x56520F0", Offset = "0x5650CF0", VA = "0x1856520F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public ICMKMEOPNCP(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x564C3B0", Offset = "0x564AFB0", VA = "0x18564C3B0")]
	public static bool GOPIOOMOEDD(ICMKMEOPNCP KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5651A50", Offset = "0x5650650", VA = "0x185651A50", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(ICMKMEOPNCP NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5651B00", Offset = "0x5650700", VA = "0x185651B00")]
	public NHHMKJOCNML FBKLJAFKEKI(Vector3? JACLPJHPOFC, Quaternion? AHDCMPCBKHJ, Vector3? LIDNCELIAFO)
	{
		return default(NHHMKJOCNML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5651D00", Offset = "0x5650900", VA = "0x185651D00")]
	public NHHMKJOCNML FBKLJAFKEKI()
	{
		return default(NHHMKJOCNML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5651EA0", Offset = "0x5650AA0", VA = "0x185651EA0")]
	public void FNJJGGMAHAD(int HIANDEDCLIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct COBDFJDIJOG : IEquatable<COBDFJDIJOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly OLACMNNNFCK DJJOBHOILOH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public NIJAIOMNHOO BDNPBKKLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x564C280", Offset = "0x564AE80", VA = "0x18564C280")]
		get
		{
			return default(NIJAIOMNHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	private PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private DLIOKHGJHNN KECCCPMFMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x564D910", Offset = "0x564C510", VA = "0x18564D910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MJHPGGELNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x564D780", Offset = "0x564C380", VA = "0x18564D780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Vector3 FFKIIOAIPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x564EF90", Offset = "0x564DB90", VA = "0x18564EF90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x564F690", Offset = "0x564E290", VA = "0x18564F690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Quaternion GODOLMCLPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x564F210", Offset = "0x564DE10", VA = "0x18564F210")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x564DFA0", Offset = "0x564CBA0", VA = "0x18564DFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public Vector3 MILFLEKJCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x564D3C0", Offset = "0x564BFC0", VA = "0x18564D3C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x564DBE0", Offset = "0x564C7E0", VA = "0x18564DBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Quaternion KCDIEMDHIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x564E9E0", Offset = "0x564D5E0", VA = "0x18564E9E0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x564EDA0", Offset = "0x564D9A0", VA = "0x18564EDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public float IDCLEDAGPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x564E560", Offset = "0x564D160", VA = "0x18564E560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 MPNNOMDOFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x564E0E0", Offset = "0x564CCE0", VA = "0x18564E0E0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x564E8A0", Offset = "0x564D4A0", VA = "0x18564E8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Vector3 OJHNGKFANAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x564F350", Offset = "0x564DF50", VA = "0x18564F350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Vector3 MJMKLOAPPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x564DE60", Offset = "0x564CA60", VA = "0x18564DE60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Matrix4x4 GACCJNPEMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x564D230", Offset = "0x564BE30", VA = "0x18564D230")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x28C06E0", Offset = "0x28BF2E0", VA = "0x1828C06E0")]
	public COBDFJDIJOG(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AD80", VA = "0x18564C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x564D980", Offset = "0x564C580", VA = "0x18564D980", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "4")]
	public bool Equals(COBDFJDIJOG NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x564C2A0", Offset = "0x564AEA0", VA = "0x18564C2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x564DB70", Offset = "0x564C770", VA = "0x18564DB70")]
	public CLEFBGOBOPM GHBJCOJECBF()
	{
		return default(CLEFBGOBOPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x564F550", Offset = "0x564E150", VA = "0x18564F550")]
	public void PBOKMGLMJHA(out Vector3 BDAEFIHNJEN, out Quaternion IBJBIKHAMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x564DA30", Offset = "0x564C630", VA = "0x18564DA30")]
	public Vector3 FOHKPGILPBN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x564D7D0", Offset = "0x564C3D0", VA = "0x18564D7D0")]
	public void EBKHBHECNEG(Vector3 KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x564E620", Offset = "0x564D220", VA = "0x18564E620")]
	public Vector3 JFHLDABLNCH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x564E220", Offset = "0x564CE20", VA = "0x18564E220")]
	public void IFFONKIKELC(Vector3 KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x564EB20", Offset = "0x564D720", VA = "0x18564EB20")]
	public Quaternion MCMKHAJPEGE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x564D640", Offset = "0x564C240", VA = "0x18564D640")]
	public void DFCLFDLGLEE(Quaternion KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x564D0F0", Offset = "0x564BCF0", VA = "0x18564D0F0")]
	public Quaternion BHOEHHALFHP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x564E760", Offset = "0x564D360", VA = "0x18564E760")]
	public void JHMECBBMFPD(Quaternion KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x564EEE0", Offset = "0x564DAE0", VA = "0x18564EEE0")]
	public float NFHPLAECMJG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x564E4A0", Offset = "0x564D0A0", VA = "0x18564E4A0")]
	public void IKDOMCGDEII(float KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x564D040", Offset = "0x564BC40", VA = "0x18564D040")]
	public float AEBEINLINHE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x564F490", Offset = "0x564E090", VA = "0x18564F490")]
	public void OPACKLALHKD(float KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x564DD20", Offset = "0x564C920", VA = "0x18564DD20")]
	public void GNOEIMLDADP(Vector3 KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x564EC60", Offset = "0x564D860", VA = "0x18564EC60")]
	public Vector3 MNIAODDEKBE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x564E360", Offset = "0x564CF60", VA = "0x18564E360")]
	public void IJFIPOEPFDF(Vector3 KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x564D500", Offset = "0x564C100", VA = "0x18564D500")]
	public Vector3 CBEKIGIHCBF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x564F0D0", Offset = "0x564DCD0", VA = "0x18564F0D0")]
	public void NJPKAAFHIAP(Vector3 KGJOJGIPNPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class AILMGEEJMFJ
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x564BEF0", Offset = "0x564AAF0", VA = "0x18564BEF0")]
	public static BHBECLCNBCK BONNMJFMGOJ(this OLACMNNNFCK DJHPMDEHJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x564BF60", Offset = "0x564AB60", VA = "0x18564BF60")]
	public static EntityManager JGHLJDFOODE(this OLACMNNNFCK DJHPMDEHJMK)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FC70", Offset = "0x1E9E870", VA = "0x181E9FC70")]
	public static T IFNCEBCKAKI<T>(this OLACMNNNFCK DJHPMDEHJMK) where T : struct, LJIGCIINKIP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x31210B0", Offset = "0x311FCB0", VA = "0x1831210B0")]
	public static bool EIMAKGFNJGL<T>(this OLACMNNNFCK DJHPMDEHJMK) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KEMNBMLDFFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Entity DBLIBNIHBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Entity LDPOODHODEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELADJOKOCNA(float3 AJAFCGMELAL);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFKHNBFFJJH(float3 AJAFCGMELAL);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void COAECKNINEC(out float3 HGAEFGJCCPH, out float3 OFINKJCDEMA);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHHFFOEHHGI(float3 HGAEFGJCCPH, float3 OFINKJCDEMA);

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AMILHLJEOLJ(Color HGAEFGJCCPH, Color OFINKJCDEMA);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KEMNBMLDFFK Instantiate(Transform BHPNFBEEMHL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface OIIGJDEIEKC
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEDKCOBOAHP(Transform BHPNFBEEMHL, KEMNBMLDFFK FMOOCMNPNEI);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KEMNBMLDFFK MNIIEBPOOEM();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DDKELKICOBG
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Func<KEMNBMLDFFK> MNIIEBPOOEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OLACMNNNFCK, OLACMNNNFCK> LDBKMKINJAL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<OLACMNNNFCK, OLACMNNNFCK> PKKAFMNIEKA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<OLACMNNNFCK, OLACMNNNFCK, OLACMNNNFCK> AOBHNMEAKIH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<OLACMNNNFCK> AEKMLOCMLEO;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OLACMNNNFCK PMIBDGIMMJC(OLACMNNNFCK AIJKIAIKFDH, int IJDEIMGEPFP);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Color GFNCNKCBLKG(OLACMNNNFCK AIJKIAIKFDH, int IJDEIMGEPFP);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 NHJKHKDNJJK(OLACMNNNFCK AIJKIAIKFDH, int IJDEIMGEPFP);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KMBIIDLEBDG(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK AJCFEJDFIMM);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OLACMNNNFCK DPNLFEGJALJ(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<OLACMNNNFCK> OCEHEBEFEOF(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OLACMNNNFCK ILAJCIAIJDO(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FOINGKPDIGF(OLACMNNNFCK AIJKIAIKFDH, Vector3 EOBGKFKPJNE, Quaternion GPJEIMOFPOC);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	(Vector3, Quaternion, bool) CIADLLBLDMN(OLACMNNNFCK AIJKIAIKFDH);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class OICMHPPONDA
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface FDNCDAIFHHA
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OLACMNNNFCK DPNLFEGJALJ(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KMBIIDLEBDG(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK MKOLBPGKLJP, bool CFGNJOFBFIH);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CFCLBILFFDO(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK MKOLBPGKLJP);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GFBHOGJBGOC(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GFHDAMOBKPG AKIOAFJOKLM(OLACMNNNFCK DJJOBHOILOH);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AGDDOPKFFCH(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK JEGDMKPCECO);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EAHMDJKDIOJ(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK MCHPJLFOAJC);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OLACMNNNFCK HPFCHDMGGGI(OLACMNNNFCK JEGDMKPCECO, OLACMNNNFCK CNDMHGAOPGD);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EKBLKLILKFF(OLACMNNNFCK JEGDMKPCECO, OLACMNNNFCK CNDMHGAOPGD, out OLACMNNNFCK JPILMHHADCF);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JMNGHFBMDNE
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface BNDFEICOCDN
{
	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	UndoAction MBKPDOCFBCM();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	RedoAction DPBLACKALKN(UndoAction FNPGAOOPMNE);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	UndoAction HKEEANOECEL(RedoAction FNPGAOOPMNE);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDisposable LLJGHBJGLIF();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PNPPGDJCNCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	int APIEBBKHJFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	int LOFNLMCKNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<OLACMNNNFCK, CMECOJAJFAB> EMLABCEDMOE;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<OLACMNNNFCK> CKLIGLIHAAL;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GFHDAMOBKPG JBHFHGBJOHN();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IFCMLGGILLI MDFJJHGEBIB(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CMECOJAJFAB DAHCABLJMIA(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KIEPKILKNCN(GEGPJNFMCPG PJIBLINGJGM, DCFEMLAEOED MPHBIKLMOEK);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NIJAIOMNHOO GJJJIKECOBM(OLACMNNNFCK AIJKIAIKFDH, [Optional] object KJKNLGILOFJ);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JIJGEKFIGAG(OLACMNNNFCK AIJKIAIKFDH, out DCFEMLAEOED MPHBIKLMOEK);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JKILOOENFCD(DCFEMLAEOED MPHBIKLMOEK);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool HLICONCCCHB(OLACMNNNFCK AIJKIAIKFDH, out Transform BHPNFBEEMHL);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IHHKOCLPKGP(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LEDODGGAFMD(Entity OCMABEPCGDM, object KJKNLGILOFJ);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool MKGAPOGLBHP(Entity OCMABEPCGDM, object KJKNLGILOFJ);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	OLACMNNNFCK NBOBFLKDCHO(GEGPJNFMCPG PJIBLINGJGM);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	GEGPJNFMCPG OJFOEHBFNEO(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "20")]
	NIJAIOMNHOO MAKPCLMEKLM(CMECOJAJFAB LBEKIEDKPCN);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "21")]
	NIJAIOMNHOO LINIIDLAFGB(CMECOJAJFAB LBEKIEDKPCN);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "22")]
	NIJAIOMNHOO CIIKAHOEEGC(GEGPJNFMCPG PJIBLINGJGM, CMECOJAJFAB LBEKIEDKPCN);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "23")]
	ANMPIPGPBIJ INJJBKJOIPH();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "24")]
	ICMKMEOPNCP FLFOCNDOJDB();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "25")]
	PMDGNJFCLOI FDLHEELIDBF(HNGFAHNAKGA ICDDGBCNJAK);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MOANCCAMPPP(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LEPAFNJMDJH(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GENHPMKNFBO(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "29")]
	NativeArray<(OLACMNNNFCK, OLACMNNNFCK)> BMFKHGCIIMB(NativeArray<OLACMNNNFCK> BCDDKJBGLOL, Allocator HGKGLCNFHPJ);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool CAACINLFJOH(OLACMNNNFCK AIJKIAIKFDH);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LONCNHKPMCG();

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void MGGAELLGHFA();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MDIODMBBEIG
{
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5654450", Offset = "0x5653050", VA = "0x185654450")]
	public static bool HLICONCCCHB(this PNPPGDJCNCL LCAGHKIOCIC, Entity OCMABEPCGDM, out Transform BHPNFBEEMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5654690", Offset = "0x5653290", VA = "0x185654690")]
	public static OLACMNNNFCK NBOBFLKDCHO(this PNPPGDJCNCL LCAGHKIOCIC, Entity OCMABEPCGDM)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x56546F0", Offset = "0x56532F0", VA = "0x1856546F0")]
	public static GEGPJNFMCPG OJFOEHBFNEO(this PNPPGDJCNCL LCAGHKIOCIC, Entity OCMABEPCGDM)
	{
		return default(GEGPJNFMCPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5654340", Offset = "0x5652F40", VA = "0x185654340")]
	public static NIJAIOMNHOO EIGDHLNGPII(this PNPPGDJCNCL LCAGHKIOCIC, CMECOJAJFAB LBEKIEDKPCN, [Optional] object KJKNLGILOFJ)
	{
		return default(NIJAIOMNHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5654140", Offset = "0x5652D40", VA = "0x185654140")]
	public static ANMPIPGPBIJ BAEDBLFOBJI(this PNPPGDJCNCL LCAGHKIOCIC, [Optional] object KJKNLGILOFJ)
	{
		return default(ANMPIPGPBIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5654240", Offset = "0x5652E40", VA = "0x185654240")]
	public static ICMKMEOPNCP CAOMENJNOIG(this PNPPGDJCNCL LCAGHKIOCIC, [Optional] object KJKNLGILOFJ)
	{
		return default(ICMKMEOPNCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5654570", Offset = "0x5653170", VA = "0x185654570")]
	public static PMDGNJFCLOI LHEJFMKFIMP(this PNPPGDJCNCL LCAGHKIOCIC, HNGFAHNAKGA DKBLOMGKFIK, [Optional] object KJKNLGILOFJ)
	{
		return default(PMDGNJFCLOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5653F20", Offset = "0x5652B20", VA = "0x185653F20")]
	public static ANLJHOADIOE APEONHGNNAP(this PNPPGDJCNCL LCAGHKIOCIC, GPILGPICAJM GKCALOIKJEC, [Optional] object KJKNLGILOFJ)
	{
		return default(ANLJHOADIOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CGDNGNAEAEB
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<OLACMNNNFCK, EFIPFMNBNEP> LDJMFHIIANF;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFMEOAJHJLM(OLACMNNNFCK AIJKIAIKFDH, Vector3 PPELONMPOIC);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DPBFMIFIKKP(OLACMNNNFCK AIJKIAIKFDH, out Collider PCJIIECCPGC);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DABDDLKBAAA(OLACMNNNFCK AIJKIAIKFDH);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface MDONMFNCNJF
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	bool IKIEIANKFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface JFDNCMBCKCA
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	OLACMNNNFCK LGPNCHLNMOF
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	NIJAIOMNHOO BHDOEEJPAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CNOEFOMINIM AGCPOOKOOHG;

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OLACMNNNFCK HPFCHDMGGGI(OLACMNNNFCK JEGDMKPCECO, OLACMNNNFCK CNDMHGAOPGD);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EKBLKLILKFF(OLACMNNNFCK JEGDMKPCECO, OLACMNNNFCK CNDMHGAOPGD, out OLACMNNNFCK JPILMHHADCF);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LGEBCIHGBMC();

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CEAHIJKMAOO();

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ONFGCPOGHOJ(OLACMNNNFCK FNPGAOOPMNE);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public delegate void CNOEFOMINIM(NIJAIOMNHOO CHHDLGFEJJF, NIJAIOMNHOO PFLAHAEPHGJ);
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KICLEGPHEIE
{
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x56537A0", Offset = "0x56523A0", VA = "0x1856537A0")]
	public static void IBHJCCMNCLL(this JFDNCMBCKCA LOPBOOCOLJF, NIJAIOMNHOO FNPGAOOPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x56535A0", Offset = "0x56521A0", VA = "0x1856535A0")]
	public static void IBHJCCMNCLL(this JFDNCMBCKCA LOPBOOCOLJF, OLACMNNNFCK FNPGAOOPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5653810", Offset = "0x5652410", VA = "0x185653810")]
	public static bool MMADDBDJOOB(this JFDNCMBCKCA LOPBOOCOLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5653910", Offset = "0x5652510", VA = "0x185653910")]
	public static bool NLPJLKEMJKO(this JFDNCMBCKCA LOPBOOCOLJF, OLACMNNNFCK FNPGAOOPMNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface ENJBBMGPMHG
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNAPFEBNPGA(OLACMNNNFCK DJJOBHOILOH, bool KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHHCKCBOHOJ(OLACMNNNFCK DJJOBHOILOH, bool KGJOJGIPNPH);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface LBMBOABFHDF
{
	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action JCNDCNBGKIM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action IKBBCBPEHLC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action LOJEELHIPMK;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KEHAMHELBOC(bool BGCPHEKMBDJ);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ByteString CGMPPIJDMHM();

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ByteString CGMPPIJDMHM(out IDisposable GMDDEAIKHMK);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HFGBGLEFMAG();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EOJDKEMAKKH();

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EFBLDOLKNNC(ByteString BBHKBAHFEIG, MGJJCLGNAJN AJKANCOMGHN = MGJJCLGNAJN.All);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LJHKKFBAEIM();

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JPIJHPOKJLL();

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NNAJJKACHNE();
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DILLBIDCLLI
{
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHHMKJOCNML POIPGOBFHBE(AFJDDNJABHB DPJJKLGNPDI, [Optional] Vector3? JACLPJHPOFC, [Optional] Quaternion? AHDCMPCBKHJ, [Optional] Vector3? LIDNCELIAFO);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NHHMKJOCNML JLJKLBPFINK(AFJDDNJABHB DPJJKLGNPDI, int HIANDEDCLIF);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICFMPGABKFK(AFJDDNJABHB DPJJKLGNPDI, int HIANDEDCLIF);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PFPLCBOEKMP(AFJDDNJABHB DPJJKLGNPDI);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<NHHMKJOCNML> NFEGDOBDNCG(AFJDDNJABHB DPJJKLGNPDI);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface FJKDEOKBEGE
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLDFELOJGNN();

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEFAELNIEBK();

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HAMMAJILEAF();

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHLNDLBCPAN();

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIFIHABAJFF();

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDMNBIEPINN();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DLIOKHGJHNN
{
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDINJPLNBON(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBKHBHECNEG(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Vector3 FOHKPGILPBN(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFCLFDLGLEE(Entity OCMABEPCGDM, Quaternion KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Quaternion MCMKHAJPEGE(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMDHPODFHEG(Entity OCMABEPCGDM, Vector3 JACLPJHPOFC, Quaternion AHDCMPCBKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PBOKMGLMJHA(Entity OCMABEPCGDM, out Vector3 JACLPJHPOFC, out Quaternion AHDCMPCBKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JKBHFCBPJEJ(Entity OCMABEPCGDM, out Vector3 JACLPJHPOFC, out Quaternion AHDCMPCBKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 JHCGCIKLPLM(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GNOEIMLDADP(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IKDOMCGDEII(Entity OCMABEPCGDM, float KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float NFHPLAECMJG(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IJFIPOEPFDF(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Vector3 MNIAODDEKBE(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IFFONKIKELC(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Vector3 JFHLDABLNCH(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JHMECBBMFPD(Entity OCMABEPCGDM, Quaternion KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Quaternion BHOEHHALFHP(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 DGNPNDHINKL(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KAPPMFCFPLF(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OPACKLALHKD(Entity OCMABEPCGDM, float KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float AEBEINLINHE(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NJPKAAFHIAP(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3 CBEKIGIHCBF(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IPJHDGNOFIL(Entity OCMABEPCGDM, out Matrix4x4 DKADKIELFLM);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LLAHIPLMCJH(Entity OCMABEPCGDM, in Matrix4x4 DKADKIELFLM);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HGEMLEJPCMD(Entity OCMABEPCGDM, out Matrix4x4 DKADKIELFLM);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool HLICONCCCHB(Entity OCMABEPCGDM, out Transform BHPNFBEEMHL);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OGJICNIOAJI(Entity OCMABEPCGDM);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class FHINADKLKLP
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface BINMKOFKKMO
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNHMPOMKLDK(OLACMNNNFCK DJJOBHOILOH, bool KGJOJGIPNPH);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface BHBECLCNBCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	IEEMDNAPKGD BONNMJFMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	BOCEAGHBLMC CCJAAPJEOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	EntityManager JGHLJDFOODE
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action JMOCFLKFDFF;

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ComponentSystemBase PGOKLMDKLEE(Type LIJLAEFJGCI);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PDFHIIDCDPH();

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ILKEDGCDBCJ();

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GLAJABEPNFN();

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FGAJFFMKEGG();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KCKMCNLOINN();

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EBDPBIBNAMH();

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IFPEOLCCOAM();

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OJLJIIHCNNG();

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GJJDAIEKOHK();
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class LFJDNAJCEPA
{
	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5653C40", Offset = "0x5652840", VA = "0x185653C40")]
	public static World KFPPGPMBDKM(this BHBECLCNBCK NJMNPDHNNLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2025B80", Offset = "0x2024780", VA = "0x182025B80")]
	public static T PGOKLMDKLEE<T>(this BHBECLCNBCK NJMNPDHNNLL) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Flags]
public enum MGJJCLGNAJN
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	DestroyObjects = 1,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	InitializeWorld = 2,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Settings = 4,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	PreInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	PostInstantiate = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	All = 0x1F
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface HMECPPGNBDI
{
	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ECOKJLMGFIF(in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, float EIJHLGKIBNG, Allocator HGKGLCNFHPJ, out NativeArray<Entity> MJFGMCFCBDM);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface EEMFEBEOLOO
{
	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ECOKJLMGFIF(in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, float EIJHLGKIBNG, out DIBJLGOBLGJ KPKONOMMOKC, out Entity HMEJLHDILOI);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface JJAOJIEGHON
{
	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECOKJLMGFIF(in NativeArray<Entity> MJFGMCFCBDM, in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, in NativeArray<DIBJLGOBLGJ> NDAIKGDIIFE);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct CMIGFMBEJGM : global::POBAFBEGBJN<CMIGFMBEJGM>, FBMJPDGBHLO, IEquatable<CMIGFMBEJGM>
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int PAOIHHHPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int EKKPBKBJINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4E0", Offset = "0x8AA0E0", VA = "0x1808AB4E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2D0", Offset = "0x8FDED0", VA = "0x1808FF2D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x564CF00", Offset = "0x564BB00", VA = "0x18564CF00", Slot = "8")]
	public bool Equals(CMIGFMBEJGM NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x564CF50", Offset = "0x564BB50", VA = "0x18564CF50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct DIBJLGOBLGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float GJLJKEEJFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float3 DOGBEAKOJOM;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface OPGBJHDIFOD
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string HGFKPNBBHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	OPGBJHDIFOD OCEDBDOODNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	IEnumerable<OPGBJHDIFOD> LCDHICJAIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface JMOLPEEPLPD
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	OPGBJHDIFOD ECJELJADPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	List<CNAIOOCFPBI> LCMOOCKGDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLIBNAGMIDF(CNAIOOCFPBI MDENPOJAPFE, out OPGBJHDIFOD MFEOBENMMAK);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public interface DMOLBBGANCB : IEnumerable<FCAJCLOJKEA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	FCAJCLOJKEA GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	FCAJCLOJKEA GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FCAJCLOJKEA EIPNDAPIEGF(BDHIOHAFMEG OHDKCBCOIKL);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LOGKGBLPOOD DDLLOIBHPCA(BDHIOHAFMEG OHDKCBCOIKL);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class DLDBGAHMBHG
{
	[Cpp2IlInjected.Token(Token = "0x600028F")]
	public static global::OMFCIKBGKOE<T> EIPNDAPIEGF<T>(this DMOLBBGANCB GCALAGNGEDP, BDHIOHAFMEG FHNLBBBEDLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x312E680", Offset = "0x312D280", VA = "0x18312E680")]
	public static global::OMFCIKBGKOE<T> EIPNDAPIEGF<T>(this DMOLBBGANCB GCALAGNGEDP, global::AABHEEDMDPC<T> FHNLBBBEDLN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DefaultMember("Item")]
public interface JDGCMEDKNHD : IEnumerable<BIIMOMDCJGN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	BIIMOMDCJGN GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BIIMOMDCJGN EIPNDAPIEGF(BDHIOHAFMEG OHDKCBCOIKL);

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LOGKGBLPOOD DDLLOIBHPCA(BDHIOHAFMEG OHDKCBCOIKL);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IKMLLAAEODA
{
	[Cpp2IlInjected.Token(Token = "0x6000295")]
	public static global::MFOLKMBMNHP<T> EIPNDAPIEGF<T>(this JDGCMEDKNHD GCALAGNGEDP, BDHIOHAFMEG FHNLBBBEDLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x20D1810", Offset = "0x20D0410", VA = "0x1820D1810")]
	public static LOGKGBLPOOD DDLLOIBHPCA<T>(this JDGCMEDKNHD GCALAGNGEDP, global::AABHEEDMDPC<T> FHNLBBBEDLN) where T : struct
	{
		return default(LOGKGBLPOOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public interface ODHGFDMHCDN : IEnumerable<CNAIOOCFPBI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	CNAIOOCFPBI GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CNAIOOCFPBI EIPNDAPIEGF(BDHIOHAFMEG OHDKCBCOIKL);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class KLJANPHCPEB
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x20D2D10", Offset = "0x20D1910", VA = "0x1820D2D10")]
	public static global::MGBAHOPOBPI<T> EIPNDAPIEGF<T>(this ODHGFDMHCDN GCALAGNGEDP, BDHIOHAFMEG FHNLBBBEDLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x20D2BC0", Offset = "0x20D17C0", VA = "0x1820D2BC0")]
	public static global::MGBAHOPOBPI<T> EIPNDAPIEGF<T>(this ODHGFDMHCDN GCALAGNGEDP, global::AABHEEDMDPC<T> FHNLBBBEDLN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MBOEOCBCOCB
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHAIICDGCFD(GEGPJNFMCPG PJIBLINGJGM, LOGKGBLPOOD MDENPOJAPFE);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGBNLILMOAH(GEGPJNFMCPG PJIBLINGJGM, Span<LOGKGBLPOOD> GCALAGNGEDP, bool NIEIIACNEGA);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct NACGOIKMGBD : MHGHNPKFAFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public CMECOJAJFAB LBEKIEDKPCN;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5654840", Offset = "0x5653440", VA = "0x185654840", Slot = "5")]
	public void EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5654800", Offset = "0x5653400", VA = "0x185654800", Slot = "4")]
	public void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct GEGPJNFMCPG : IComparable<GEGPJNFMCPG>, IEquatable<GEGPJNFMCPG>, MHGHNPKFAFL
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GEGPJNFMCPG EIEGJHHNOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private uint EGJHEPHPDOG;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public uint BMAFMDEJBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1332AC0", Offset = "0x13316C0", VA = "0x181332AC0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public uint ONGHMHAEIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x229DB50", Offset = "0x229C750", VA = "0x18229DB50")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public uint FPBFJAGGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x12274F0", Offset = "0x12260F0", VA = "0x1812274F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool EIOHEFOJJII
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5650A70", Offset = "0x564F670", VA = "0x185650A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5650B80", Offset = "0x564F780", VA = "0x185650B80")]
	public GEGPJNFMCPG(int FNMOGANINIA, int HLCMEOLMOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5650B80", Offset = "0x564F780", VA = "0x185650B80")]
	public GEGPJNFMCPG(uint FNMOGANINIA, uint HLCMEOLMOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0")]
	private GEGPJNFMCPG(uint EGJHEPHPDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x790150", Offset = "0x78ED50", VA = "0x180790150")]
	public static GEGPJNFMCPG HDAOGHODHPH(uint EGJHEPHPDOG)
	{
		return default(GEGPJNFMCPG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x229D400", Offset = "0x229C000", VA = "0x18229D400")]
	public static bool NHPMPBNMAAP(GEGPJNFMCPG FNKIIBFNLFB, GEGPJNFMCPG EDLPJGEPJPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x229D410", Offset = "0x229C010", VA = "0x18229D410")]
	public static bool CLDCOCNHPOO(GEGPJNFMCPG FNKIIBFNLFB, GEGPJNFMCPG EDLPJGEPJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xD8F730", Offset = "0xD8E330", VA = "0x180D8F730", Slot = "5")]
	public bool Equals(GEGPJNFMCPG DJHPMDEHJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x56509F0", Offset = "0x564F5F0", VA = "0x1856509F0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x93E0D0", Offset = "0x93CCD0", VA = "0x18093E0D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5650AF0", Offset = "0x564F6F0", VA = "0x185650AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5650A80", Offset = "0x564F680", VA = "0x185650A80")]
	public static void LAFMIEAABBE(IKIDEMPJGGM AOMLNNKAJKE, GEGPJNFMCPG KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5650920", Offset = "0x564F520", VA = "0x185650920")]
	public static GEGPJNFMCPG ECDFNFCHPBE(IKIDEMPJGGM AOMLNNKAJKE)
	{
		return default(GEGPJNFMCPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x56508A0", Offset = "0x564F4A0", VA = "0x1856508A0", Slot = "6")]
	public void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5650980", Offset = "0x564F580", VA = "0x185650980", Slot = "7")]
	public void EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x337B430", Offset = "0x337A030", VA = "0x18337B430", Slot = "4")]
	public int CompareTo(GEGPJNFMCPG NPKIIGGBCCI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum JBAPEBDOBIL
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Mark = 1,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	GroupBegin = 2,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	GroupEnd = 3,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	EntCreate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	EntDestroy = 5,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	EntSetParent = 6,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	EntCreateInstance = 7,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	XfmSetLocalPosition = 8,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	XfmSetLocalRotation = 9,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	XfmSetLocalScale = 10,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	COUNT = 11,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	MAX = 10
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface EGFEKIAKANC
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public delegate bool BPCOBFEGIJF(OOJKCBLFFGH IAADOHDBECD, in CJHLIFJIIDK KGJOJGIPNPH);
[Cpp2IlInjected.Token(Token = "0x2000060")]
public delegate bool NPDJKLPLIJM<T>(OOJKCBLFFGH IAADOHDBECD, in T KGJOJGIPNPH);
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface HHHGPLGMGKP
{
	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIEPKILKNCN(LOGKGBLPOOD IPGOEGFNLNJ, Type ADFIFPIDFMD, BPCOBFEGIJF KAEIIPHPFDJ);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFEFFANPIAB(LOGKGBLPOOD IPGOEGFNLNJ, out BPCOBFEGIJF KAEIIPHPFDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class HABFGCMFAKK
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class NJBEJFFJMHO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public global::NPDJKLPLIJM<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public NJBEJFFJMHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x38B7F70", Offset = "0x38B6B70", VA = "0x1838B7F70")]
	public static void KIEPKILKNCN<T>(this HHHGPLGMGKP DNIGLLFHMCE, LOGKGBLPOOD IPGOEGFNLNJ, global::NPDJKLPLIJM<T> KAEIIPHPFDJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x56515D0", Offset = "0x56501D0", VA = "0x1856515D0")]
	public static bool HEEOHKACLMA(this HHHGPLGMGKP DNIGLLFHMCE, OOJKCBLFFGH IAADOHDBECD, LOGKGBLPOOD IPGOEGFNLNJ, in CJHLIFJIIDK KGJOJGIPNPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface KEGDDKGELOF
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCPEKAPGMIA(int OEBMILJLIAL);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNGOPHIKMAP(in ReadOnlyMemory<byte> GLJCPDEKKCL, out ReadOnlyMemory<byte> JMIGDAADKLB);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJDMMNAHPEB(in ReadOnlyMemory<byte> GLJCPDEKKCL, out ReadOnlyMemory<byte> JMIGDAADKLB);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface IEDPEFPOIIM : FDJPAMIJCJH
{
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface FDJPAMIJCJH
{
	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODNCHEFFPAF(ELJKNPMHDCF KKDEFIFHPNN, ReadOnlyMemory<byte> LEPAGINGHFK);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface FBHEMLCDGNH : FDJPAMIJCJH
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	int NJLLLHHICGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELJKNPMHDCF KFDDDNPCEAH();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface CMAEPCNCIGE
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	int IOPKOJNMCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public delegate void GMBKPCMFDGB(ELJKNPMHDCF KKDEFIFHPNN, ReadOnlyMemory<byte> LEPAGINGHFK);
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct ELJKNPMHDCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public uint FNMOGANINIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int LDKJBAFFHJK;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x775D30", Offset = "0x774930", VA = "0x180775D30")]
	public ELJKNPMHDCF(uint FNMOGANINIA, int LDKJBAFFHJK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5650010", Offset = "0x564EC10", VA = "0x185650010")]
	public static bool NHPMPBNMAAP(in ELJKNPMHDCF EHGLDEHJCJA, in ELJKNPMHDCF POGMGOCOOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x564FF80", Offset = "0x564EB80", VA = "0x18564FF80", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1222F00", Offset = "0x1221B00", VA = "0x181222F00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5650030", Offset = "0x564EC30", VA = "0x185650030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct OLOJKIJGDEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public ELJKNPMHDCF KKDEFIFHPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public ReadOnlyMemory<byte> LEPAGINGHFK;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A96930", Offset = "0x2A95530", VA = "0x182A96930")]
	public OLOJKIJGDEC(ELJKNPMHDCF KKDEFIFHPNN, ReadOnlyMemory<byte> LEPAGINGHFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface LPLKABLBOGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKJDFFMGCFK(ELJKNPMHDCF KKDEFIFHPNN, ReadOnlyMemory<byte> LEPAGINGHFK);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface CMLFDHFFPKM
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	IKIDEMPJGGM GDCGEPJEDON
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFJEGHOLLJG();

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAMBKMFJHJH();
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface KGMODLGLHAD
{
	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGDKJINICCC(ELJKNPMHDCF KKDEFIFHPNN, ReadOnlyMemory<byte> JMFDNAKFNAC);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface BIJOBGIJDDE
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCLBOEBDFEC(GEGPJNFMCPG NFBGOIJEFME, in NACGOIKMGBD OAGMKJFIKKL);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBDNGAPKFIE(GEGPJNFMCPG NFBGOIJEFME);

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJLDOGFCGLL(GEGPJNFMCPG NFBGOIJEFME, LOGKGBLPOOD IPGOEGFNLNJ, in CJHLIFJIIDK KGJOJGIPNPH);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class CGBJLHNGLID
{
	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x232E260", Offset = "0x232CE60", VA = "0x18232E260")]
	public static void IJLDOGFCGLL<T>(this BIJOBGIJDDE FGCLHPLIFAM, GEGPJNFMCPG NFBGOIJEFME, LOGKGBLPOOD IPGOEGFNLNJ, T KGJOJGIPNPH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface LJMFJHAJICB
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	uint MGECHCHICJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface FOJAKKAEGJD
{
	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKBKHBPNIIM();

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCGDDCAALFC(GEGPJNFMCPG PJIBLINGJGM, bool KOEKJIEOIIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface BBOELHANIGP
{
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INEJNLDNAMB(GEGPJNFMCPG DJJOBHOILOH, in NACGOIKMGBD OAGMKJFIKKL, bool OADAJKPLPPJ);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCDLMPJBHMO(GEGPJNFMCPG DJJOBHOILOH, bool OADAJKPLPPJ);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONBILHLALLJ(GEGPJNFMCPG DJJOBHOILOH, LOGKGBLPOOD MDENPOJAPFE, in CJHLIFJIIDK KGJOJGIPNPH, bool OADAJKPLPPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class CNNNHLBAOLL
{
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2330AC0", Offset = "0x232F6C0", VA = "0x182330AC0")]
	public static void ONBILHLALLJ<T>(this BBOELHANIGP FJAGFNGNGHD, GEGPJNFMCPG DJJOBHOILOH, LOGKGBLPOOD MDENPOJAPFE, T KGJOJGIPNPH, bool OADAJKPLPPJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface CJAOPNMFBHF
{
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPKPJNNMKPC(GEGPJNFMCPG NFBGOIJEFME, in NACGOIKMGBD OAGMKJFIKKL);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHCLHJDOAKE(GEGPJNFMCPG NFBGOIJEFME);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGNJDHGCAHP(GEGPJNFMCPG NFBGOIJEFME, LOGKGBLPOOD MDENPOJAPFE, in CJHLIFJIIDK HOMEBBNJHJM, in CJHLIFJIIDK FMKHLEANADK);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class PPILCGEANOA
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D54030", Offset = "0x2D52C30", VA = "0x182D54030")]
	public static void BGNJDHGCAHP<T>(this CJAOPNMFBHF FJAGFNGNGHD, GEGPJNFMCPG NFBGOIJEFME, LOGKGBLPOOD MDENPOJAPFE, T NBOLFCPAICP, T FMKHLEANADK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface OOJKCBLFFGH
{
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCADLLHJDEM(GEGPJNFMCPG NFBGOIJEFME, LOGKGBLPOOD IPGOEGFNLNJ, in CJHLIFJIIDK HOMEBBNJHJM, in CJHLIFJIIDK OPGMGLEPAPF);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IOKOAHNEIJD(GEGPJNFMCPG NFBGOIJEFME, LOGKGBLPOOD IPGOEGFNLNJ, in EJMAFNBMMGI HOMEBBNJHJM, in EJMAFNBMMGI OPGMGLEPAPF);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OFAAFICEPON(GEGPJNFMCPG NFBGOIJEFME, LOGKGBLPOOD IPGOEGFNLNJ);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LBNIPMCJPEN(GEGPJNFMCPG NFBGOIJEFME, LOGKGBLPOOD IPGOEGFNLNJ, in CJHLIFJIIDK OPGMGLEPAPF);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class NOKOFLJHMDI
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x27ECE10", Offset = "0x27EBA10", VA = "0x1827ECE10")]
	public static bool IOKOAHNEIJD<T>(this OOJKCBLFFGH FMGJGBNLJOK, GEGPJNFMCPG NFBGOIJEFME, LOGKGBLPOOD IPGOEGFNLNJ, out T HOMEBBNJHJM, out T OPGMGLEPAPF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x27ECF70", Offset = "0x27EBB70", VA = "0x1827ECF70")]
	public static bool LBNIPMCJPEN<T>(this OOJKCBLFFGH FMGJGBNLJOK, GEGPJNFMCPG NFBGOIJEFME, LOGKGBLPOOD IPGOEGFNLNJ, T OPGMGLEPAPF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface DGMHFGJILHI
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIBBILHHCOI(GEGPJNFMCPG PJIBLINGJGM, LOGKGBLPOOD MDENPOJAPFE, in EJMAFNBMMGI KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIEGBJJEGLJ(GEGPJNFMCPG PJIBLINGJGM, IAIJJIAPNDG HKGCALJNCCI, [Optional] object NAEOEJMOBMH);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHAIICDGCFD(GEGPJNFMCPG PJIBLINGJGM, LOGKGBLPOOD MDENPOJAPFE);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGBNLILMOAH(GEGPJNFMCPG PJIBLINGJGM, Span<LOGKGBLPOOD> MDENPOJAPFE, bool NIEIIACNEGA);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NIJAIOMNHOO MAKPCLMEKLM(GEGPJNFMCPG PJIBLINGJGM, in NACGOIKMGBD OAGMKJFIKKL);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEFONJBJIPL(GEGPJNFMCPG PJIBLINGJGM);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ICIGNHPMEOJ(GEGPJNFMCPG PJIBLINGJGM, LOGKGBLPOOD MDENPOJAPFE, in CJHLIFJIIDK KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HEEOHKACLMA(OOJKCBLFFGH IAADOHDBECD, LOGKGBLPOOD MDENPOJAPFE, in CJHLIFJIIDK KGJOJGIPNPH);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class CADHKPPJGPC
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF510", Offset = "0x3BFE110", VA = "0x183BFF510")]
	public static T GIBBILHHCOI<T>(this DGMHFGJILHI DPCBGLAGGGP, GEGPJNFMCPG PJIBLINGJGM, LOGKGBLPOOD MDENPOJAPFE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x312BB70", Offset = "0x312A770", VA = "0x18312BB70")]
	public static bool ICIGNHPMEOJ<T>(this DGMHFGJILHI DPCBGLAGGGP, GEGPJNFMCPG PJIBLINGJGM, LOGKGBLPOOD MDENPOJAPFE, T KGJOJGIPNPH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public enum EPALEFLJHEP
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public delegate void DNBPNCPEACE(BBOELHANIGP FJAGFNGNGHD, IKIDEMPJGGM AOMLNNKAJKE, GEGPJNFMCPG DJJOBHOILOH, LOGKGBLPOOD IPGOEGFNLNJ, bool OADAJKPLPPJ);
[Cpp2IlInjected.Token(Token = "0x200007D")]
public delegate void ILHNNKLLKGP<T>(IKIDEMPJGGM AOMLNNKAJKE, T KGJOJGIPNPH) where T : struct;
[Cpp2IlInjected.Token(Token = "0x200007E")]
public delegate T KCFABAMIMAB<T>(IKIDEMPJGGM AOMLNNKAJKE) where T : struct;
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface INLHJOGNGJK : global::AHLBPBPFKGM<INLHJOGNGJK>
{
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LOGKGBLPOOD DDLLOIBHPCA(BDHIOHAFMEG FHNLBBBEDLN);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIEPKILKNCN(LOGKGBLPOOD DJHPMDEHJMK, AENIEIDJNIK ODCFKLLJCFB);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool POIHJJLHJCC(LOGKGBLPOOD DJHPMDEHJMK, out AENIEIDJNIK ODCFKLLJCFB);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class EFBHPLJCMBM
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x20C67A0", Offset = "0x20C53A0", VA = "0x1820C67A0")]
	public static LOGKGBLPOOD DDLLOIBHPCA<T>(this INLHJOGNGJK GCALAGNGEDP, global::AABHEEDMDPC<T> FHNLBBBEDLN)
	{
		return default(LOGKGBLPOOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x20C6980", Offset = "0x20C5580", VA = "0x1820C6980")]
	public static LOGKGBLPOOD KIEPKILKNCN<T>(this INLHJOGNGJK GCALAGNGEDP, global::AABHEEDMDPC<T> FHNLBBBEDLN, AENIEIDJNIK ODCFKLLJCFB) where T : struct
	{
		return default(LOGKGBLPOOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface EJNLIIMNDDH
{
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOFDHHCJLDL<T>(in T KGJOJGIPNPH, [Optional] object NAEOEJMOBMH) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface AENIEIDJNIK
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	Type JFMKFLEJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE, in CJHLIFJIIDK FNNHACEFOCO);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEFHONAIJPO(IKIDEMPJGGM AOMLNNKAJKE, EJNLIIMNDDH HKGCALJNCCI, [Optional] object NAEOEJMOBMH);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class APFONAEGBAA
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface MBGJLLHBFFO
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool CGOCCJLHIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EOOKMIMPJHP([Optional] CancellationToken DHCIMDILIGO);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface NBCNMBCIDMO : BBOELHANIGP
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface HDKBFEAHLEJ
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PHPEAKMAHKJ(ReadOnlySpan<byte> KGJOJGIPNPH, CancellationToken DHCIMDILIGO);
}
namespace RecRoom.ObjectModel.Interfaces.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Preserve]
	internal class _RRAssemblyIndex : DGENKNGBBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5656EB0", Offset = "0x5655AB0", VA = "0x185656EB0", Slot = "4")]
		public sealed override void JHENDOAEKLB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
