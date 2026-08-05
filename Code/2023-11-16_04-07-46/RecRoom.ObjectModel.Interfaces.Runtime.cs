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
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
public struct LBFACEKPFEC : IReadOnlyList<DALFLBHIMAN>, IEnumerable<DALFLBHIMAN>, IEnumerable, IReadOnlyCollection<DALFLBHIMAN>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct ELOIAPGJCNB : IEnumerator<DALFLBHIMAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly BPGCKJHOOFK GBIHCEMBHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator EKKLLDJDCCL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DALFLBHIMAN PADEIDMLAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5ED0910", Offset = "0x5ECF910", VA = "0x185ED0910", Slot = "4")]
			get
			{
				return default(DALFLBHIMAN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5ED0890", Offset = "0x5ECF890", VA = "0x185ED0890", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3A50770", Offset = "0x3A4F770", VA = "0x183A50770")]
		public ELOIAPGJCNB(BPGCKJHOOFK GBIHCEMBHAM, NativeArray<LocalId>.Enumerator EKKLLDJDCCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5ED07D0", Offset = "0x5ECF7D0", VA = "0x185ED07D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0810", Offset = "0x5ECF810", VA = "0x185ED0810", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0850", Offset = "0x5ECF850", VA = "0x185ED0850", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly BPGCKJHOOFK GBIHCEMBHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> OPKAINPLLMM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DALFLBHIMAN KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6AE0", Offset = "0x5ED5AE0", VA = "0x185ED6AE0", Slot = "4")]
		get
		{
			return default(DALFLBHIMAN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5ED65D0", Offset = "0x5ED55D0", VA = "0x185ED65D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int JADBBNNINMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76F180", Offset = "0x76E180", VA = "0x18076F180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EPGHPPHAJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76F180", Offset = "0x76E180", VA = "0x18076F180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IBKEJLGGENP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED64A0", Offset = "0x5ED54A0", VA = "0x185ED64A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> DAOCNKMOCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A8F0", Offset = "0x3A498F0", VA = "0x183A4A8F0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6890", Offset = "0x5ED5890", VA = "0x185ED6890")]
	public LBFACEKPFEC(int IKHECAIEEHO, BPGCKJHOOFK GBIHCEMBHAM, Allocator OIPBEAGANJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A50510", Offset = "0x3A4F510", VA = "0x183A50510")]
	public LBFACEKPFEC(BPGCKJHOOFK GBIHCEMBHAM, NativeArray<LocalId> OPKAINPLLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5ED69D0", Offset = "0x5ED59D0", VA = "0x185ED69D0")]
	internal LBFACEKPFEC(BPGCKJHOOFK GBIHCEMBHAM, NativeArray<Entity> DJHDIEIFFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6A40", Offset = "0x5ED5A40", VA = "0x185ED6A40")]
	public LBFACEKPFEC(BPGCKJHOOFK GBIHCEMBHAM, int EHBIPHOJPOK, Allocator OIPBEAGANJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6920", Offset = "0x5ED5920", VA = "0x185ED6920")]
	public LBFACEKPFEC(LBFACEKPFEC HMPHIAMPDCL, Allocator OIPBEAGANJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED64E0", Offset = "0x5ED54E0", VA = "0x185ED64E0")]
	public LBFACEKPFEC BDJPDEJCMDM(Allocator OIPBEAGANJF = Allocator.Temp)
	{
		return default(LBFACEKPFEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6590", Offset = "0x5ED5590", VA = "0x185ED6590", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6620", Offset = "0x5ED5620", VA = "0x185ED6620")]
	public ELOIAPGJCNB PKEKCLMIDEH()
	{
		return default(ELOIAPGJCNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5ED66B0", Offset = "0x5ED56B0", VA = "0x185ED66B0", Slot = "6")]
	private IEnumerator<DALFLBHIMAN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5ED67A0", Offset = "0x5ED57A0", VA = "0x185ED67A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct CNOMJJMPING : IList<DALFLBHIMAN>, ICollection<DALFLBHIMAN>, IEnumerable<DALFLBHIMAN>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct MHHDKLMHJGH : IEnumerator<DALFLBHIMAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly BPGCKJHOOFK GBIHCEMBHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator EKKLLDJDCCL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DALFLBHIMAN PADEIDMLAKM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5ED8790", Offset = "0x5ED7790", VA = "0x185ED8790", Slot = "4")]
			get
			{
				return default(DALFLBHIMAN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5ED8710", Offset = "0x5ED7710", VA = "0x185ED8710", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3A50770", Offset = "0x3A4F770", VA = "0x183A50770")]
		public MHHDKLMHJGH(BPGCKJHOOFK GBIHCEMBHAM, NativeArray<LocalId>.Enumerator EKKLLDJDCCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8650", Offset = "0x5ED7650", VA = "0x185ED8650", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8690", Offset = "0x5ED7690", VA = "0x185ED8690", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5ED86D0", Offset = "0x5ED76D0", VA = "0x185ED86D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BPGCKJHOOFK GBIHCEMBHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> OPKAINPLLMM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DALFLBHIMAN KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF6E0", Offset = "0x5ECE6E0", VA = "0x185ECF6E0", Slot = "4")]
		get
		{
			return default(DALFLBHIMAN);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF760", Offset = "0x5ECE760", VA = "0x185ECF760", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF080", Offset = "0x5ECE080", VA = "0x185ECF080", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EPGHPPHAJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF080", Offset = "0x5ECE080", VA = "0x185ECF080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool HFHPEHMAAKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF650", Offset = "0x5ECE650", VA = "0x185ECF650")]
	public CNOMJJMPING(BPGCKJHOOFK GBIHCEMBHAM, int EHBIPHOJPOK, Allocator OIPBEAGANJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF240", Offset = "0x5ECE240", VA = "0x185ECF240")]
	public LBFACEKPFEC OGPDBPBCNDK()
	{
		return default(LBFACEKPFEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEE60", Offset = "0x5ECDE60", VA = "0x185ECEE60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEEA0", Offset = "0x5ECDEA0", VA = "0x185ECEEA0", Slot = "13")]
	public bool Contains(DALFLBHIMAN NIFCHCHHAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEF30", Offset = "0x5ECDF30", VA = "0x185ECEF30", Slot = "14")]
	public void CopyTo(DALFLBHIMAN[] FHOLKIOOKFG, int FKKKLBOABKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDE0", Offset = "0x5ECDDE0", VA = "0x185ECEDE0", Slot = "11")]
	public void Add(DALFLBHIMAN NIFCHCHHAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF190", Offset = "0x5ECE190", VA = "0x185ECF190", Slot = "7")]
	public void Insert(int NFJIPMHILEL, DALFLBHIMAN NIFCHCHHAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF3A0", Offset = "0x5ECE3A0", VA = "0x185ECF3A0", Slot = "15")]
	public bool Remove(DALFLBHIMAN NIFCHCHHAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF100", Offset = "0x5ECE100", VA = "0x185ECF100", Slot = "6")]
	public int IndexOf(DALFLBHIMAN NIFCHCHHAAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF350", Offset = "0x5ECE350", VA = "0x185ECF350", Slot = "8")]
	public void RemoveAt(int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF0C0", Offset = "0x5ECE0C0", VA = "0x185ECF0C0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF2C0", Offset = "0x5ECE2C0", VA = "0x185ECF2C0")]
	public MHHDKLMHJGH PKEKCLMIDEH()
	{
		return default(MHHDKLMHJGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF470", Offset = "0x5ECE470", VA = "0x185ECF470", Slot = "16")]
	private IEnumerator<DALFLBHIMAN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF560", Offset = "0x5ECE560", VA = "0x185ECF560", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IADFFJHHONH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int BIALAPGNPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> JBGPKAHDPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DALFLBHIMAN KEJCBFHPDNL(DALFLBHIMAN OPKAINPLLMM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EJHLBPLFOPI : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface MIBIOLFBFKM : GILCNCGMOPD, GKPBFOGMNNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OAFFKLKKCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	OBBNDMMBMKJ BIMJJCDLAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NLFDLMOMPNF OJMEGNOGBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MGHGDLAOALD AMPFKEEHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	EDJGGOINACF MMFICPOPEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	AJBOHKHIKOG NDJGMNGILDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface GKPBFOGMNNB
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LODDGFKFEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface PAGHEBBKJBA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCIONOHHBCA(bool APPJEOKOGAK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface EDJGGOINACF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KOOAKBBNMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NAMHLNMGBNI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGHBMEBPKIJ(bool NHIMOAGIDEG);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NGCGMJJEHKO(ByteString LNCOLHOCFJN);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAOPCNMLEHP();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHPNBCGMCKK();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FDLHMCJGAOC();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface MGHGDLAOALD
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	MKDBPFPJIJD BIMJJCDLAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	NLFDLMOMPNF OJMEGNOGBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DKJNHDKDPGA JIFOOAOLCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MIBIOLFBFKM KEKLKOMGPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	CILBLAAABKJ PENHCFMGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	LAEPPDGPOAO DNCNCFMHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	EMGJCNGGJCH IAHNOEPLDNG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IJICANBCKBJ EDOAJLFHPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	BNFIACHEJEO IMEMPFBLEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	CACPIIKCPKA KOKENIAHBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	OLPJOBBIDMO GCOENKEPEOE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	FLAMNPOBAGI GBEMKFEPMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	BKBAPIPPMME BMPNIJFLOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	DIPBIEJNFLO DOEMBJJKLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	OCNDOMNDGLK LADNMFLNBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	AEIECBAICDE IAALHPMPGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DLCIOIDPKIF NNKCBCGALNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DHDAPBIGPCJ ANAOAOOBFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	JJFMBENHELA MCKKBBHELNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	CGJEMIMBMMC AKMJILKBGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(EFPBNCJNHGK))]
public readonly struct DALFLBHIMAN : IComparable<DALFLBHIMAN>, IEquatable<DALFLBHIMAN>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DALFLBHIMAN GHGNOAMLPEA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int PACKNEDAGFN = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int ENJFIHEMCDI = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int HBABHODHBCB = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int AIDMOMDNFDN = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId BOEFBOGINDB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MIBIOLFBFKM KEKLKOMGPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFE10", Offset = "0x5ECEE10", VA = "0x185ECFE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LocalId MNFIMGGDFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFB60", Offset = "0x5ECEB60", VA = "0x185ECFB60")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	internal AJBOHKHIKOG NDJGMNGILDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFA20", Offset = "0x5ECEA20", VA = "0x185ECFA20")]
		get
		{
			return default(AJBOHKHIKOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool AKEJHEAMADO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFD30", Offset = "0x5ECED30", VA = "0x185ECFD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LBGKNECOIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFA30", Offset = "0x5ECEA30", VA = "0x185ECFA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool JJCOCKALLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFE90", Offset = "0x5ECEE90", VA = "0x185ECFE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5ED01B0", Offset = "0x5ECF1B0", VA = "0x185ED01B0")]
	public DALFLBHIMAN(BPGCKJHOOFK NGOBMKIBMGL, LocalId BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
	public GKHNCFMKNMN CGJOJBHNNFO()
	{
		return default(GKHNCFMKNMN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0040", Offset = "0x5ECF040", VA = "0x185ED0040")]
	public static LocalId OKGBDLIDGHC(DALFLBHIMAN DLCCFCHBMFL)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0000", Offset = "0x5ECF000", VA = "0x185ED0000")]
	public static Entity OKGBDLIDGHC(DALFLBHIMAN DLCCFCHBMFL)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFEE0", Offset = "0x5ECEEE0", VA = "0x185ECFEE0")]
	public static bool LICIMLDMCMN(DALFLBHIMAN HMDDIJJDAIK, DALFLBHIMAN NDOJJCKFJID)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFE70", Offset = "0x5ECEE70", VA = "0x185ECFE70")]
	public static bool JNBEKHIMJBJ(DALFLBHIMAN HMDDIJJDAIK, DALFLBHIMAN NDOJJCKFJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0080", Offset = "0x5ECF080", VA = "0x185ED0080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFBA0", Offset = "0x5ECEBA0", VA = "0x185ECFBA0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFA80", Offset = "0x5ECEA80", VA = "0x185ECFA80", Slot = "4")]
	public int CompareTo(DALFLBHIMAN EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "5")]
	public bool Equals(DALFLBHIMAN EJEDDDCGMMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BNGEIMMBCNI
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDE50", Offset = "0x5ECCE50", VA = "0x185ECDE50")]
	public static AOLAPKAKPFI CHOMMFONAKB(this DALFLBHIMAN GPCHHCACPPJ)
	{
		return default(AOLAPKAKPFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22C51F0", Offset = "0x22C41F0", VA = "0x1822C51F0")]
	public static T PJHCCAMELNM<T>(this DALFLBHIMAN GPCHHCACPPJ) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class EFPBNCJNHGK
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct AJBOHKHIKOG : IEquatable<AJBOHKHIKOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte LJOOGDNJBGF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] EOKJKCIIGFO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static BPGCKJHOOFK FBBNINIAKKC;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static MIBIOLFBFKM BHJCEOLAMPH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static BPGCKJHOOFK[] KDOKJGPBIKI;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static MIBIOLFBFKM[] GPKDBFJHOFA;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> EACOFMJAIHM;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MIBIOLFBFKM KEKLKOMGPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD050", Offset = "0x5ECC050", VA = "0x185ECD050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BPGCKJHOOFK KNGFAJELCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD3C0", Offset = "0x5ECC3C0", VA = "0x185ECD3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDBC0", Offset = "0x5ECCBC0", VA = "0x185ECDBC0")]
	static AJBOHKHIKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xBAF9F0", Offset = "0xBAE9F0", VA = "0x180BAF9F0")]
	internal AJBOHKHIKOG(byte APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x519AA00", Offset = "0x5199A00", VA = "0x18519AA00", Slot = "4")]
	public bool Equals(AJBOHKHIKOG EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCE40", Offset = "0x5ECBE40", VA = "0x185ECCE40", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x19A32E0", Offset = "0x19A22E0", VA = "0x1819A32E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDB00", Offset = "0x5ECCB00", VA = "0x185ECDB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCD70", Offset = "0x5ECBD70", VA = "0x185ECCD70")]
	private static BPGCKJHOOFK CGGKJJKFLOH(byte LJOOGDNJBGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCCC0", Offset = "0x5ECBCC0", VA = "0x185ECCCC0")]
	private static MIBIOLFBFKM CEPJDBEDPLC(byte LJOOGDNJBGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCEE0", Offset = "0x5ECBEE0", VA = "0x185ECCEE0")]
	private static object FJDMHJGJNFO(byte LJOOGDNJBGF, object[] ALBJDCCCHNI, object ELMPJJEOKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCE30", Offset = "0x5ECBE30", VA = "0x185ECCE30")]
	private static int ENDKFKGIOMM(byte LJOOGDNJBGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD4A0", Offset = "0x5ECC4A0", VA = "0x185ECD4A0")]
	private static int KOJELGHJPNP(byte LJOOGDNJBGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD340", Offset = "0x5ECC340", VA = "0x185ECD340")]
	private static (int, int) JPLKAGBDEJE(byte LJOOGDNJBGF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCE20", Offset = "0x5ECBE20", VA = "0x185ECCE20")]
	private static byte CJOIOGCDNEC(int CEJKGGNMCNG, int NFJIPMHILEL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD4B0", Offset = "0x5ECC4B0", VA = "0x185ECD4B0")]
	internal static AJBOHKHIKOG NOIKFHNFAKL(MIBIOLFBFKM AJHKCKHDFBG, BPGCKJHOOFK GNEDKPIHLOJ)
	{
		return default(AJBOHKHIKOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD130", Offset = "0x5ECC130", VA = "0x185ECD130")]
	internal static void JDHNBLDODIP(AJBOHKHIKOG LJOOGDNJBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD770", Offset = "0x5ECC770", VA = "0x185ECD770")]
	private static void PCNOBKGDEHJ(int IKHECAIEEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface ONABHGNIOOD
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDGCKEAKABL();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JAFDHAOIMAD(bool OINDGNKCPNE);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIKGHGLOPKL(GameObject GFBHJHHLEFD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface CKCMDDHHKNA
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Guid FNNJLALKGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OMCGOGNMODA(Guid JNPOKHDPFCI, Guid HEIPLFOFEDA);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JCBBLFLFJAL(DALFLBHIMAN GNMIJNAHBFH);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGBEMBKMEDF(DALFLBHIMAN DNNMPMAOGBP, DALFLBHIMAN IGPIMCJILMM, [Out] Vector3 BOJGOGFFKJG, [Out] Quaternion OPKOAAPHEFK);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KDDIBCHIDBB(MCHBGMAMFCI ELDGPGBAEKB, Vector3 BOJGOGFFKJG, Quaternion OPKOAAPHEFK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface PBLFBANHDIG
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCANAOONOMF(LBFACEKPFEC OPKAINPLLMM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface NLFDLMOMPNF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ONABHGNIOOD IDEPEODHHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MDHEMMMPDPG PBKANAKEEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	KAIPIIJPJED DHMLPICNKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OMMOFEDCNEC BMLIOFJMIIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	LLLFGJGKBMD EBADFLOMLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	NBCNJAJOOOH ADLJJNCENDP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NPNOOPDKCFF BGNOIPLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EADMNCCKHGP OGCNDDDFDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface EAKBIKFGLNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONMMFBCNNDD(Action NFDFJOBAEPD, bool HGEHPLHGGKL);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IJKEHPGHCNM(string JNMEJDHMADI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface MDHEMMMPDPG
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string EHIEECLLCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] EFINANCDDCL(IEnumerable<KMPFBKNOPEL> EBOJCBEJPBL);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JCBIKGHNMPH(GameObject GFBHJHHLEFD, [Out] AOLAPKAKPFI[] EMOFBCKAOOI);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LHKEBFLMBGK(GameObject GFBHJHHLEFD, [Out] int LNMJDHLFHFA, [Out] LBHIBFADKLF MMIOCMIOHFJ);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LPICGNDOFJL NIBABKBAAAL(KMPFBKNOPEL ICLPGCHCHFB);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LPICGNDOFJL NIBABKBAAAL(string AELAONILKMK, AOLAPKAKPFI[] LBCBENNEFOP, Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM, Vector3 EKPAHLHAMGH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject ALLFIGLOJLD(string AELAONILKMK);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MBDOBHGNKLK(GameObject NLHDLMPEGDN, bool GFHFKCIIDHH);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IGGCNBGDCNA(GameObject GFBHJHHLEFD, bool NLEHMBHPKCI, bool NNIMPMEKOFO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class LGAILJGNJEF
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7A50", Offset = "0x5ED6A50", VA = "0x185ED7A50")]
	public static LPICGNDOFJL NIBABKBAAAL(this MDHEMMMPDPG ICCKKADELMP, Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM, Vector3 EKPAHLHAMGH, params AOLAPKAKPFI[] EMOFBCKAOOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface KAIPIIJPJED
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNJNAGIAAOB(bool NHIMOAGIDEG);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface OMMOFEDCNEC
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool IDLFHLEBNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool GJEJAOKPENL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool BJLJHNIAGEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool PJDEDJJFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLNADDMJAPP(object HPEDGLBMGED);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BICMCBEHAJO(object HPEDGLBMGED);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OMMPAHDFLHG(object MNNJBJHGADP);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AGDJAEHKHKA(object MNNJBJHGADP);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int EPMOMGFACFE(GameObject OKFEGDLOMNK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void COFIEMDCHFJ(NativeArray<int> GNGGKALLNEL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OIFOBDFCBGD(NativeArray<int> BBJOACPLOCG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DHKNCPKGGFH([Out] byte[] AFJNDIFPGDG, [Out] byte[] IAOOPBGOJAH);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LFNDNBHHFIL(ReadOnlySpan<byte> HPEDGLBMGED, ReadOnlySpan<byte> IAOOPBGOJAH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GABDKIPDLIE();

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NNLINEIAOFH(uint DHCBFMEALJE, ReadOnlySpan<byte> FCLEEDACIMH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface LLLFGJGKBMD
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMFBJKFMHBE(GameObject GFBHJHHLEFD);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface HDNLHFMJNDB
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEIPIHDAFDK(string NCBOINMNCHO);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface NCLEAFMAODB
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HEGKBEGIAFN(GameObject GFBHJHHLEFD);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKKFHHHGPEO(GameObject GFBHJHHLEFD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object KOLDKDJKHBD(DALFLBHIMAN BOEFBOGINDB, GameObject GFBHJHHLEFD, Action<DALFLBHIMAN, int> CAEGDBPOJIB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIGNNBGPBAO(GameObject GFBHJHHLEFD, object LJMGHLBPACL);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface NBCNJAJOOOH
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	int OPHCDEJANIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DEONIMKEFOM(GameObject GFBHJHHLEFD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFNBIPHHEEI([Out] Vector3 LPGLCEHEHMC);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEPAAGGGAFL();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface NPNOOPDKCFF
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool KOOAKBBNMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool CDIPOFHONMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface PGLOBJEKMFL
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	JFAHHOFNEID BEEAILHLOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	DHMELNEEOBH JIKKDLLJGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCOKHNJOEOP(Transform PIMEBPKGKBD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KCOAJEMCDDI(Transform PIMEBPKGKBD, GLFEDOAPKAG GLKBOBIOOEO);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGMAFEGFIDC(Transform PIMEBPKGKBD, CLOECILAMCC AADFGDGLCCB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface EADMNCCKHGP
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDIHAHADJIE();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface AHBEBMFLNNH
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCHECLDHDOH();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface NMCBBEBFDBF
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LBHIBFADKLF NCDJPFOAGDP(GameObject OKFEGDLOMNK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKFGIBGNEHM(GameObject GFBHJHHLEFD, BKFLMAPINJG PCHGLABFBCI, FGNLHALLCCB BLDMJBHDAEK);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string MBDNCFGBLMI(int LPCEACMGEAL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LJBCGGNAFNK(string HAPGJANIBPK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDEECEHLMCE(DALFLBHIMAN BOEFBOGINDB, int[] CLBLJOJNOIC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GIOIJKHBALD(GameObject DGKGJHCILMA, GameObject HGOFNMFGDAH, int PMOGKDHCCLI);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct HHJDKFFAEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly LEJCCLJEECI CEJJMMEOKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly LEJCCLJEECI HGIJPKEDKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint EOLLLHJKHPL;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3050", Offset = "0x5ED2050", VA = "0x185ED3050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct JKEBHHKNJOD
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly HHJDKFFAEPD NFDFJOBAEPD;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5110", Offset = "0x5ED4110", VA = "0x185ED5110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct MBFMLIFHLCC
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly HHJDKFFAEPD NFDFJOBAEPD;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5110", Offset = "0x5ED4110", VA = "0x185ED5110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct LJLGJOGMONL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint EOLLLHJKHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool MIKDMNEELCO;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7C30", Offset = "0x5ED6C30", VA = "0x185ED7C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct LEJCCLJEECI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int ODJLNMBFCPC;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5ED79F0", Offset = "0x5ED69F0", VA = "0x185ED79F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface LDJNOCCDFKG
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	DJHLIIOGPOF DBGAEMKMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum DDOHMKBIPNM
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
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LPICGNDOFJL : HMPHFBGABPG
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	DDOHMKBIPNM EEMHEOGOAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool LPMIGEGNFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	GameObject GFBHJHHLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<LPICGNDOFJL> KFOFAAMLPPH;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(DKJNHDKDPGA MNIDJIIDCNA, DALFLBHIMAN IGJMINFNCLC);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool LPJPLJEHAAM);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class GIAEDABFCJA
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1970", Offset = "0x5ED0970", VA = "0x185ED1970")]
	public static bool JDOMPEFEOKI(this LPICGNDOFJL KCFEKGFNDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5ED18D0", Offset = "0x5ED08D0", VA = "0x185ED18D0")]
	public static bool FKINPILOIMB(this LPICGNDOFJL KCFEKGFNDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1920", Offset = "0x5ED0920", VA = "0x185ED1920")]
	public static bool HBCFBMNOIGM(this LPICGNDOFJL KCFEKGFNDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED19C0", Offset = "0x5ED09C0", VA = "0x185ED19C0")]
	public static bool OAFFKLKKCNG(this LPICGNDOFJL KCFEKGFNDGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HMPHFBGABPG
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool NPPHNPBCGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
internal interface KMABGJGBEGJ
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<HIKGODCBGKM> OOCABFJNOPN;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface OOKAFPGCJJD : LMNIFMEEKIM<AOLAPKAKPFI>, KEJOHPHCOML, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface OCCNGOALDON<T> : CNFHKCEABBP<AOLAPKAKPFI, T>, LMNIFMEEKIM<AOLAPKAKPFI>, KEJOHPHCOML, IDisposable, OOKAFPGCJJD where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class CDIECPIGOJM
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x231E9C0", Offset = "0x231D9C0", VA = "0x18231E9C0")]
	public static bool FKFDJGDIAKO<T>(this LMNIFMEEKIM<AOLAPKAKPFI> BHNFFMEOAFJ, AOLAPKAKPFI LBCBENNEFOP, [Out] T APPJEOKOGAK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x231E9E0", Offset = "0x231D9E0", VA = "0x18231E9E0")]
	public static bool GBPMDEJOJHE<T>(this LMNIFMEEKIM<AOLAPKAKPFI> BHNFFMEOAFJ, AOLAPKAKPFI LBCBENNEFOP, [In] T KMHOGAFNGBN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NPJJOGPBNJA : LMNIFMEEKIM<DALFLBHIMAN>, KEJOHPHCOML, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface DCMKCANIHKA<T> : CNFHKCEABBP<DALFLBHIMAN, T>, LMNIFMEEKIM<DALFLBHIMAN>, KEJOHPHCOML, IDisposable, NPJJOGPBNJA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HHKLCLCFNFA
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x23BF910", Offset = "0x23BE910", VA = "0x1823BF910")]
	public static T GJNMDDLIIAA<T>(this LMNIFMEEKIM<DALFLBHIMAN> BHNFFMEOAFJ, DALFLBHIMAN BOEFBOGINDB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x24FBD80", Offset = "0x24FAD80", VA = "0x1824FBD80")]
	public static bool GBPMDEJOJHE<T>(this LMNIFMEEKIM<DALFLBHIMAN> BHNFFMEOAFJ, DALFLBHIMAN BOEFBOGINDB, [In] T KMHOGAFNGBN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct EDCPELGMLAD : IComparable<EDCPELGMLAD>, IEquatable<EDCPELGMLAD>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly EDCPELGMLAD GHGNOAMLPEA;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly EDCPELGMLAD JLDPFBGCNMF;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly EDCPELGMLAD EJIDEHOMGOH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly EDCPELGMLAD FKMPDPGHHHP;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly EDCPELGMLAD LELDGOJJHEE;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly EDCPELGMLAD GKONHDBFMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int KLNGLNIFDLJ;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool CMJDOKOBAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5ED04E0", Offset = "0x5ECF4E0", VA = "0x185ED04E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int MPPGDECNLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5ED05D0", Offset = "0x5ECF5D0", VA = "0x185ED05D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x82BE50", Offset = "0x82AE50", VA = "0x18082BE50")]
	public EDCPELGMLAD(int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0570", Offset = "0x5ECF570", VA = "0x185ED0570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED04F0", Offset = "0x5ECF4F0", VA = "0x185ED04F0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x16C9AD0", Offset = "0x16C8AD0", VA = "0x1816C9AD0", Slot = "5")]
	public bool Equals(EDCPELGMLAD EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x16D99D0", Offset = "0x16D89D0", VA = "0x1816D99D0", Slot = "4")]
	public int CompareTo(EDCPELGMLAD EJEDDDCGMMB)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0xD512D0", Offset = "0xD502D0", VA = "0x180D512D0")]
	public static EDCPELGMLAD OKGBDLIDGHC(int NFJIPMHILEL)
	{
		return default(EDCPELGMLAD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xD512D0", Offset = "0xD502D0", VA = "0x180D512D0")]
	public static int OKGBDLIDGHC(EDCPELGMLAD PKPKCGCHKKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5ED05E0", Offset = "0x5ECF5E0", VA = "0x185ED05E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct GKHNCFMKNMN : IEquatable<GKHNCFMKNMN>, HMPHFBGABPG
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly GKHNCFMKNMN KGLICEBIEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900", Slot = "6")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public ODNJIFHCJFP FHHLKDMADLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(ODNJIFHCJFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public GKAOKMAEDNE PENHCFMGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKAOKMAEDNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public GameObject GFBHJHHLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2B60", Offset = "0x5ED1B60", VA = "0x185ED2B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public AOLAPKAKPFI KDMAOPOLJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2750", Offset = "0x5ED1750", VA = "0x185ED2750")]
		get
		{
			return default(AOLAPKAKPFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public LCIFOIEHOAC FMMDKALLNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5ED27F0", Offset = "0x5ED17F0", VA = "0x185ED27F0")]
		get
		{
			return default(LCIFOIEHOAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public LBHIBFADKLF BCOKOBJOLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2890", Offset = "0x5ED1890", VA = "0x185ED2890")]
		get
		{
			return default(LBHIBFADKLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool HFFFPOKACED
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5ED23A0", Offset = "0x5ED13A0", VA = "0x185ED23A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool FPBOFCHCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2B20", Offset = "0x5ED1B20", VA = "0x185ED2B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool JGDPBINELPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2400", Offset = "0x5ED1400", VA = "0x185ED2400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool FFDJLKOILHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2B40", Offset = "0x5ED1B40", VA = "0x185ED2B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool ELDFLHKMEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2640", Offset = "0x5ED1640", VA = "0x185ED2640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool DGLMKCJCMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2960", Offset = "0x5ED1960", VA = "0x185ED2960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool MHKOMCBAIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2AA0", Offset = "0x5ED1AA0", VA = "0x185ED2AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool BACGCBFKFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2420", Offset = "0x5ED1420", VA = "0x185ED2420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public CNOGJMEOMLD HDHHJBCMKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(CNOGJMEOMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public DAIKBMGPCMN JFGNBMFECPC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DAIKBMGPCMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public FBONGIKAILP GBEMKFEPMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(FBONGIKAILP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public JGEIGIJLKIN JOAFALNHBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(JGEIGIJLKIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public NPMDGJBPIAK GCOENKEPEOE
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(NPMDGJBPIAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public PEGPDMEAMOJ MCINENJJCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(PEGPDMEAMOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public MCHBGMAMFCI DGPLNMDCDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(MCHBGMAMFCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public KIILMPCEIAA HMGHGNMJDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(KIILMPCEIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool JDOMPEFEOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5ED29A0", Offset = "0x5ED19A0", VA = "0x185ED29A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool AMLODAGOGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2AE0", Offset = "0x5ED1AE0", VA = "0x185ED2AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool NPEKPMGDOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5ED23C0", Offset = "0x5ED13C0", VA = "0x185ED23C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private bool KIBOICLGNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public GKHNCFMKNMN(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2CF0", Offset = "0x5ED1CF0", VA = "0x185ED2CF0")]
	public static bool OKGBDLIDGHC(GKHNCFMKNMN APPJEOKOGAK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static DALFLBHIMAN OKGBDLIDGHC(GKHNCFMKNMN APPJEOKOGAK)
	{
		return default(DALFLBHIMAN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2A90", Offset = "0x5ED1A90", VA = "0x185ED2A90")]
	public static bool LICIMLDMCMN(GKHNCFMKNMN HMDDIJJDAIK, GKHNCFMKNMN NDOJJCKFJID)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFE70", Offset = "0x5ECEE70", VA = "0x185ECFE70")]
	public static bool JNBEKHIMJBJ(GKHNCFMKNMN HMDDIJJDAIK, GKHNCFMKNMN NDOJJCKFJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2530", Offset = "0x5ED1530", VA = "0x185ED2530", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(GKHNCFMKNMN EJEDDDCGMMB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static GKHNCFMKNMN OKGBDLIDGHC(DALFLBHIMAN KFGJIMGDDPH)
	{
		return default(GKHNCFMKNMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5ED25C0", Offset = "0x5ED15C0", VA = "0x185ED25C0")]
	public PLBADGLLBHO FFHDGFAODLE()
	{
		return default(PLBADGLLBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2930", Offset = "0x5ED1930", VA = "0x185ED2930")]
	public NEINGNPOCME KFBPMEGFEDB()
	{
		return default(NEINGNPOCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2350", Offset = "0x5ED1350", VA = "0x185ED2350")]
	public JEHKMHJKKCD APCECMDLOOK()
	{
		return default(JEHKMHJKKCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2D10", Offset = "0x5ED1D10", VA = "0x185ED2D10")]
	public void PEDOHFFOMDM([Optional] object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2440", Offset = "0x5ED1440", VA = "0x185ED2440")]
	public bool EKFFNPPMCOI(object PDIBILKHEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2660", Offset = "0x5ED1660", VA = "0x185ED2660")]
	public bool GPKADIHLFMF(object PDIBILKHEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2E20", Offset = "0x5ED1E20", VA = "0x185ED2E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct MCHBGMAMFCI : IEquatable<MCHBGMAMFCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private MGHGDLAOALD AMPFKEEHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5ED84A0", Offset = "0x5ED74A0", VA = "0x185ED84A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private OCNDOMNDGLK DLDHGOIADMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8440", Offset = "0x5ED7440", VA = "0x185ED8440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool EMHBFADNHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5ED83B0", Offset = "0x5ED73B0", VA = "0x185ED83B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Guid OIJBJOHOMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7DF0", Offset = "0x5ED6DF0", VA = "0x185ED7DF0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool LBEJAPKEJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7D60", Offset = "0x5ED6D60", VA = "0x185ED7D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Guid JHBCJADGHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8160", Offset = "0x5ED7160", VA = "0x185ED8160")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public MCHBGMAMFCI(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2CF0", Offset = "0x5ED1CF0", VA = "0x185ED2CF0")]
	public static bool OKGBDLIDGHC(MCHBGMAMFCI APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED80D0", Offset = "0x5ED70D0", VA = "0x185ED80D0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(MCHBGMAMFCI EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8280", Offset = "0x5ED7280", VA = "0x185ED8280")]
	public bool HMGMLBBGOBL([Out] Guid OCKKPJOGMKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7FB0", Offset = "0x5ED6FB0", VA = "0x185ED7FB0")]
	public void EJCDBBFDMLN(Guid DKCKOABFNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7F10", Offset = "0x5ED6F10", VA = "0x185ED7F10")]
	public bool EBNCBHIMIJO([Out] Guid BCDEFAJKINM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8530", Offset = "0x5ED7530", VA = "0x185ED8530")]
	public void NKAGHFGCGHH(Guid DKCKOABFNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8320", Offset = "0x5ED7320", VA = "0x185ED8320")]
	public void JJMFJPMJKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct JEHKMHJKKCD : IEquatable<JEHKMHJKKCD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private MGHGDLAOALD AMPFKEEHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4130", Offset = "0x5ED3130", VA = "0x185ED4130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private AEIECBAICDE FHKJPNAEFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3DF0", Offset = "0x5ED2DF0", VA = "0x185ED3DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public float3 PGCEDENPLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3E50", Offset = "0x5ED2E50", VA = "0x185ED3E50")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public quaternion APINJNEFFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4010", Offset = "0x5ED3010", VA = "0x185ED4010")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GKHNCFMKNMN DELDFEDMAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED41C0", Offset = "0x5ED31C0", VA = "0x185ED41C0")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public JEHKMHJKKCD(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static DALFLBHIMAN OKGBDLIDGHC(JEHKMHJKKCD APPJEOKOGAK)
	{
		return default(DALFLBHIMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3F80", Offset = "0x5ED2F80", VA = "0x185ED3F80", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(JEHKMHJKKCD EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct PLBADGLLBHO : IEquatable<PLBADGLLBHO>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class LDBMFFIHIEN : IEnumerable<GKHNCFMKNMN>, IEnumerable, IEnumerator<GKHNCFMKNMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private GKHNCFMKNMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PLBADGLLBHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PLBADGLLBHO <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<GKHNCFMKNMN> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IEnumerator<DALFLBHIMAN> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private GKHNCFMKNMN System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.RRObject>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x3171C20", Offset = "0x3170C20", VA = "0x183171C20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GKHNCFMKNMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x5ED72B0", Offset = "0x5ED62B0", VA = "0x185ED72B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x33C2C30", Offset = "0x33C1C30", VA = "0x1833C2C30")]
		[DebuggerHidden]
		public LDBMFFIHIEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7300", Offset = "0x5ED6300", VA = "0x185ED7300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6C50", Offset = "0x5ED5C50", VA = "0x185ED6C50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6C00", Offset = "0x5ED5C00", VA = "0x185ED6C00")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6BB0", Offset = "0x5ED5BB0", VA = "0x185ED6BB0")]
		private void CPPLOHGLGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7170", Offset = "0x5ED6170", VA = "0x185ED7170")]
		private void POJIANEGOPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7260", Offset = "0x5ED6260", VA = "0x185ED7260", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5ED71C0", Offset = "0x5ED61C0", VA = "0x185ED71C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GKHNCFMKNMN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.RRObject>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x5ED71C0", Offset = "0x5ED61C0", VA = "0x185ED71C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly PLBADGLLBHO KGLICEBIEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public ODNJIFHCJFP FHHLKDMADLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(ODNJIFHCJFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public GKAOKMAEDNE PENHCFMGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKAOKMAEDNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private MGHGDLAOALD AMPFKEEHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD360", Offset = "0x5EDC360", VA = "0x185EDD360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private CILBLAAABKJ PDPEMCDAIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD900", Offset = "0x5EDC900", VA = "0x185EDD900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public LBFACEKPFEC CAODIMFPJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD230", Offset = "0x5EDC230", VA = "0x185EDD230")]
		get
		{
			return default(LBFACEKPFEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public IEnumerable<GKHNCFMKNMN> FACLIONGBII
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD500", Offset = "0x5EDC500", VA = "0x185EDD500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IEnumerable<GKHNCFMKNMN> DABOKCNLNML
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCF20", Offset = "0x5EDBF20", VA = "0x185EDCF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int GFNGACMMBOA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD470", Offset = "0x5EDC470", VA = "0x185EDD470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int GDCKKLPOPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC610", Offset = "0x5EDB610", VA = "0x185EDC610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string GMOLFEBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC6D0", Offset = "0x5EDB6D0", VA = "0x185EDC6D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD050", Offset = "0x5EDC050", VA = "0x185EDD050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public NBMGBMCGCBP GNJJDCEFPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD7B0", Offset = "0x5EDC7B0", VA = "0x185EDD7B0")]
		get
		{
			return default(NBMGBMCGCBP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC780", Offset = "0x5EDB780", VA = "0x185EDC780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public NDADHHOBCHG EIOJAFKEKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC5B0", Offset = "0x5EDB5B0", VA = "0x185EDC5B0")]
		get
		{
			return default(NDADHHOBCHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCB10", Offset = "0x5EDBB10", VA = "0x185EDCB10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JPAKAGKPODE LMAMFCKLICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD170", Offset = "0x5EDC170", VA = "0x185EDD170")]
		get
		{
			return default(JPAKAGKPODE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD6E0", Offset = "0x5EDC6E0", VA = "0x185EDD6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float JCCCLDHFOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCD10", Offset = "0x5EDBD10", VA = "0x185EDCD10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC660", Offset = "0x5EDB660", VA = "0x185EDC660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool FKFBLNBEJML
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD100", Offset = "0x5EDC100", VA = "0x185EDD100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool LJEKMAAALLN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCC10", Offset = "0x5EDBC10", VA = "0x185EDCC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool FJHGLFKIAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD670", Offset = "0x5EDC670", VA = "0x185EDD670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool DHEFAOLAIBK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD2F0", Offset = "0x5EDC2F0", VA = "0x185EDD2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool GEHDDFCPOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD1D0", Offset = "0x5EDC1D0", VA = "0x185EDD1D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC7F0", Offset = "0x5EDB7F0", VA = "0x185EDC7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool JEEAKJPDHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD750", Offset = "0x5EDC750", VA = "0x185EDD750")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD810", Offset = "0x5EDC810", VA = "0x185EDD810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public PLBADGLLBHO(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2CF0", Offset = "0x5ED1CF0", VA = "0x185ED2CF0")]
	public static bool OKGBDLIDGHC(PLBADGLLBHO APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5EDCB80", Offset = "0x5EDBB80", VA = "0x185EDCB80", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(PLBADGLLBHO EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static GKHNCFMKNMN OKGBDLIDGHC(PLBADGLLBHO KMOLABGHAKI)
	{
		return default(GKHNCFMKNMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDCCF0", Offset = "0x5EDBCF0", VA = "0x185EDCCF0")]
	public bool GNEPDMBFIND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5EDCC80", Offset = "0x5EDBC80", VA = "0x185EDCC80")]
	public bool GFFKAOMOPGJ(HLMPGCIBJOF GHCLMJNFNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD3F0", Offset = "0x5EDC3F0", VA = "0x185EDD3F0")]
	public void LEAIKJLLNGK(HLMPGCIBJOF GHCLMJNFNLO, bool APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5EDCD70", Offset = "0x5EDBD70", VA = "0x185EDCD70")]
	public LBFACEKPFEC HPBHCNKMHDM(Allocator OIPBEAGANJF)
	{
		return default(LBFACEKPFEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC860", Offset = "0x5EDB860", VA = "0x185EDC860")]
	public void DPBBEPHDLPE(PLBADGLLBHO EJEDDDCGMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD880", Offset = "0x5EDC880", VA = "0x185EDD880")]
	[IteratorStateMachine(typeof(LDBMFFIHIEN))]
	public IEnumerable<GKHNCFMKNMN> PAIPHNNGNFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct HOCGBENBGFF : IEquatable<HOCGBENBGFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3660", Offset = "0x5ED2660", VA = "0x185ED3660", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(HOCGBENBGFF EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct DAIKBMGPCMN : IEquatable<DAIKBMGPCMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public DAIKBMGPCMN(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF930", Offset = "0x5ECE930", VA = "0x185ECF930", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(DAIKBMGPCMN EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF890", Offset = "0x5ECE890", VA = "0x185ECF890")]
	public void EPEJEEPODAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF7F0", Offset = "0x5ECE7F0", VA = "0x185ECF7F0")]
	public void BDPDGOAABHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct GFEBEPJKIMP : IEquatable<GFEBEPJKIMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1840", Offset = "0x5ED0840", VA = "0x185ED1840", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(GFEBEPJKIMP EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct NHIKGAPAOLF : IEquatable<NHIKGAPAOLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9190", Offset = "0x5ED8190", VA = "0x185ED9190", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(NHIKGAPAOLF EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct LBFPJBAFJNC : IEquatable<LBFPJBAFJNC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6B20", Offset = "0x5ED5B20", VA = "0x185ED6B20", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(LBFPJBAFJNC EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct PHGOEPCOMJG : IEquatable<PHGOEPCOMJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC520", Offset = "0x5EDB520", VA = "0x185EDC520", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(PHGOEPCOMJG EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct GKAOKMAEDNE : IEquatable<GKAOKMAEDNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private MGHGDLAOALD AMPFKEEHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2140", Offset = "0x5ED1140", VA = "0x185ED2140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private CILBLAAABKJ PDPEMCDAIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED22F0", Offset = "0x5ED12F0", VA = "0x185ED22F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public DALFLBHIMAN CNJHAHEEAPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1D80", Offset = "0x5ED0D80", VA = "0x185ED1D80")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public GKHNCFMKNMN CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5ED21D0", Offset = "0x5ED11D0", VA = "0x185ED21D0")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public GKHNCFMKNMN FMAEDMDFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2260", Offset = "0x5ED1260", VA = "0x185ED2260")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public GKAOKMAEDNE(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1BC0", Offset = "0x5ED0BC0", VA = "0x185ED1BC0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(GKAOKMAEDNE EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1C50", Offset = "0x5ED0C50", VA = "0x185ED1C50")]
	public bool GLKDGJFHDGI(GKHNCFMKNMN IGPIMCJILMM, bool BGNCACIKMGK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1E10", Offset = "0x5ED0E10", VA = "0x185ED1E10")]
	public bool KFAPELDDGMK(GKHNCFMKNMN HPIAGANECMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1EB0", Offset = "0x5ED0EB0", VA = "0x185ED1EB0")]
	private void KIPBHJOPHML(GKHNCFMKNMN JIHOGJJOOCN, List<GKHNCFMKNMN> JMPFHAHHLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1B60", Offset = "0x5ED0B60", VA = "0x185ED1B60")]
	public void DFIDHHFLHMO(List<GKHNCFMKNMN> PBNOAEOAOBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct CNOGJMEOMLD : IEquatable<CNOGJMEOMLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public string GHBCCHGNIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE940", Offset = "0x5ECD940", VA = "0x185ECE940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string KNIKGHMJEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEC40", Offset = "0x5ECDC40", VA = "0x185ECEC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private bool JOPJKLDGEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE760", Offset = "0x5ECD760", VA = "0x185ECE760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public string IMMOJPGDLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE0A0", Offset = "0x5ECD0A0", VA = "0x185ECE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string KEBKIPEMKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE9F0", Offset = "0x5ECD9F0", VA = "0x185ECE9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string NAEFGFHCMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5ECED10", Offset = "0x5ECDD10", VA = "0x185ECED10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public CNOGJMEOMLD(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8B0", Offset = "0x5ECD8B0", VA = "0x185ECE8B0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(CNOGJMEOMLD EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE190", Offset = "0x5ECD190", VA = "0x185ECE190")]
	private static string BNCNIJPAHKC(LBHIBFADKLF CGMPOGNKLNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct NOPIAFJDABO : IEquatable<NOPIAFJDABO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9220", Offset = "0x5ED8220", VA = "0x185ED9220", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(NOPIAFJDABO EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct FBONGIKAILP : IEquatable<FBONGIKAILP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public FBONGIKAILP(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0960", Offset = "0x5ECF960", VA = "0x185ED0960", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(FBONGIKAILP EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5ED09F0", Offset = "0x5ECF9F0", VA = "0x185ED09F0")]
	public bool IKKGDHCNIDM([Out] Collider ADLAAIPCPLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct JGEIGIJLKIN : IEquatable<JGEIGIJLKIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private MGHGDLAOALD AMPFKEEHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4910", Offset = "0x5ED3910", VA = "0x185ED4910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private IIGMIILMDIL EIEJCHHFMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5ED44F0", Offset = "0x5ED34F0", VA = "0x185ED44F0")]
		get
		{
			return default(IIGMIILMDIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool FADFBIMBPHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED47F0", Offset = "0x5ED37F0", VA = "0x185ED47F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool PHKILJEHKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5030", Offset = "0x5ED4030", VA = "0x185ED5030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool FHBLHGHDLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4320", Offset = "0x5ED3320", VA = "0x185ED4320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool KDPNKBFMOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4F50", Offset = "0x5ED3F50", VA = "0x185ED4F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool KINOKNIOFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4FC0", Offset = "0x5ED3FC0", VA = "0x185ED4FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool BPOCEIPPJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED46A0", Offset = "0x5ED36A0", VA = "0x185ED46A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool KFKOHGFAKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4710", Offset = "0x5ED3710", VA = "0x185ED4710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool EDNEKOGKNLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4830", Offset = "0x5ED3830", VA = "0x185ED4830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool KGKHDPDMEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5ED48A0", Offset = "0x5ED38A0", VA = "0x185ED48A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool PABFNCBBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5ED42B0", Offset = "0x5ED32B0", VA = "0x185ED42B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool JKCGAGBMDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4780", Offset = "0x5ED3780", VA = "0x185ED4780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool BLGPFHCPFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5ED45C0", Offset = "0x5ED35C0", VA = "0x185ED45C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool NBLGCGELGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4D40", Offset = "0x5ED3D40", VA = "0x185ED4D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool GNGOIDKDINP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4E60", Offset = "0x5ED3E60", VA = "0x185ED4E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool NNDCGILEGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4630", Offset = "0x5ED3630", VA = "0x185ED4630")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4550", Offset = "0x5ED3550", VA = "0x185ED4550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool PLGCOIFEGBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED49A0", Offset = "0x5ED39A0", VA = "0x185ED49A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public FGNLHALLCCB NHGJNDPBMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4250", Offset = "0x5ED3250", VA = "0x185ED4250")]
		get
		{
			return default(FGNLHALLCCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool CPEGDGIFLON
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4400", Offset = "0x5ED3400", VA = "0x185ED4400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public Vector3 GCCOLOHFNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4B70", Offset = "0x5ED3B70", VA = "0x185ED4B70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public Vector3 JGNMNHFGBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4DB0", Offset = "0x5ED3DB0", VA = "0x185ED4DB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool MDEELJOJBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4C40", Offset = "0x5ED3C40", VA = "0x185ED4C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public JGEIGIJLKIN(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4460", Offset = "0x5ED3460", VA = "0x185ED4460", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(JGEIGIJLKIN EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4390", Offset = "0x5ED3390", VA = "0x185ED4390")]
	public bool DFHAKIMIOIH(EEDFGECFCFK GHCLMJNFNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED50A0", Offset = "0x5ED40A0", VA = "0x185ED50A0")]
	public bool PNBDMGBPCHL(BKFLMAPINJG GHCLMJNFNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4ED0", Offset = "0x5ED3ED0", VA = "0x185ED4ED0")]
	public void NJHAMKMOKBN(BKFLMAPINJG GHCLMJNFNLO, bool DNJKBADFLBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct PEGPDMEAMOJ : IEquatable<PEGPDMEAMOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private MGHGDLAOALD AMPFKEEHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC400", Offset = "0x5EDB400", VA = "0x185EDC400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public PEGPDMEAMOJ(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC2E0", Offset = "0x5EDB2E0", VA = "0x185EDC2E0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(PEGPDMEAMOJ EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC370", Offset = "0x5EDB370", VA = "0x185EDC370")]
	public void KKPELIGNGJH(bool APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC490", Offset = "0x5EDB490", VA = "0x185EDC490")]
	public void NKLEEFHEIBN(bool APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x263AD60", Offset = "0x2639D60", VA = "0x18263AD60")]
	public T HIPHOGIONPL<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct NPMDGJBPIAK : IEquatable<NPMDGJBPIAK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private MGHGDLAOALD AMPFKEEHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9B00", Offset = "0x5ED8B00", VA = "0x185ED9B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private OLPJOBBIDMO OFCOHKHJBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9460", Offset = "0x5ED8460", VA = "0x185ED9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private CGJEMIMBMMC AKMJILKBGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9AA0", Offset = "0x5ED8AA0", VA = "0x185ED9AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool GGHALHOIANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5ED93D0", Offset = "0x5ED83D0", VA = "0x185ED93D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool PILNKFLPMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9590", Offset = "0x5ED8590", VA = "0x185ED9590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool OOJGLDAHFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9EA0", Offset = "0x5ED8EA0", VA = "0x185ED9EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool FNLPGPAIOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5ED94C0", Offset = "0x5ED84C0", VA = "0x185ED94C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool LCHANIHIJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9ED0", Offset = "0x5ED8ED0", VA = "0x185ED9ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool AKAMIMHNGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9E10", Offset = "0x5ED8E10", VA = "0x185ED9E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool LEMAIGOFILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9890", Offset = "0x5ED8890", VA = "0x185ED9890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool JEPAOHODKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9CA0", Offset = "0x5ED8CA0", VA = "0x185ED9CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public NPMDGJBPIAK(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2CF0", Offset = "0x5ED1CF0", VA = "0x185ED2CF0")]
	public static bool OKGBDLIDGHC(NPMDGJBPIAK APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9760", Offset = "0x5ED8760", VA = "0x185ED9760", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(NPMDGJBPIAK EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5ED92B0", Offset = "0x5ED82B0", VA = "0x185ED92B0")]
	public bool AJDKJDEBGAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5ED97F0", Offset = "0x5ED87F0", VA = "0x185ED97F0")]
	public GKHNCFMKNMN IDKLMOPEGEG(GKHNCFMKNMN MNNJBJHGADP)
	{
		return default(GKHNCFMKNMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9B90", Offset = "0x5ED8B90", VA = "0x185ED9B90")]
	public DALFLBHIMAN LHCANHLFNOM()
	{
		return default(DALFLBHIMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9630", Offset = "0x5ED8630", VA = "0x185ED9630")]
	public void DGELNGHHJGH(DALFLBHIMAN MNNJBJHGADP, DALFLBHIMAN PJLAABMEEKC, DALFLBHIMAN LMOLMJDMNDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct NEINGNPOCME : IEquatable<NEINGNPOCME>
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly NEINGNPOCME KGLICEBIEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public ODNJIFHCJFP FHHLKDMADLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(ODNJIFHCJFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private CDCKIDDEOHI EFDJJJCLGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9000", Offset = "0x5ED8000", VA = "0x185ED9000")]
		get
		{
			return default(CDCKIDDEOHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public MCKFNBMPJML LLDDEJBIBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5ED89D0", Offset = "0x5ED79D0", VA = "0x185ED89D0")]
		get
		{
			return default(MCKFNBMPJML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public BMEPAOBHMEM CMGNLCKBMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8E50", Offset = "0x5ED7E50", VA = "0x185ED8E50")]
		get
		{
			return default(BMEPAOBHMEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public EOLHCNIABNH KJEMMPHGLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8A30", Offset = "0x5ED7A30", VA = "0x185ED8A30")]
		get
		{
			return default(EOLHCNIABNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public HMDJIJGHMMA BCCBGFEDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8A90", Offset = "0x5ED7A90", VA = "0x185ED8A90")]
		get
		{
			return default(HMDJIJGHMMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public DOPMHANFEKL IHLMLKJIBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8D70", Offset = "0x5ED7D70", VA = "0x185ED8D70")]
		get
		{
			return default(DOPMHANFEKL);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8960", Offset = "0x5ED7960", VA = "0x185ED8960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public JIGLJABBNHO KKDJAMMHCNK
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED90C0", Offset = "0x5ED80C0", VA = "0x185ED90C0")]
		get
		{
			return default(JIGLJABBNHO);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8EB0", Offset = "0x5ED7EB0", VA = "0x185ED8EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public float GDDAHOBPOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9060", Offset = "0x5ED8060", VA = "0x185ED9060")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8D00", Offset = "0x5ED7D00", VA = "0x185ED8D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Vector3 GDMEGIEAMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8B90", Offset = "0x5ED7B90", VA = "0x185ED8B90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8C10", Offset = "0x5ED7C10", VA = "0x185ED8C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public float LOJHGDJFNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9120", Offset = "0x5ED8120", VA = "0x185ED9120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public PDMMKCABCOI.BKGNDOBDKMG EHNAKCPEEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8FA0", Offset = "0x5ED7FA0", VA = "0x185ED8FA0")]
		get
		{
			return default(PDMMKCABCOI.BKGNDOBDKMG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8C90", Offset = "0x5ED7C90", VA = "0x185ED8C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public NEINGNPOCME(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2CF0", Offset = "0x5ED1CF0", VA = "0x185ED2CF0")]
	public static bool OKGBDLIDGHC(NEINGNPOCME APPJEOKOGAK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFE70", Offset = "0x5ECEE70", VA = "0x185ECFE70")]
	public static bool JNBEKHIMJBJ(NEINGNPOCME HMDDIJJDAIK, NEINGNPOCME NDOJJCKFJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8B00", Offset = "0x5ED7B00", VA = "0x185ED8B00", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(NEINGNPOCME EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8DD0", Offset = "0x5ED7DD0", VA = "0x185ED8DD0")]
	public HABMGPNOJNJ KLCCEGFFLDK()
	{
		return default(HABMGPNOJNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8F20", Offset = "0x5ED7F20", VA = "0x185ED8F20")]
	public KCKLFLLAEJC OCBNHLGAOKN()
	{
		return default(KCKLFLLAEJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct HABMGPNOJNJ : IEquatable<HABMGPNOJNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public NEINGNPOCME IPLJNIDFCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(NEINGNPOCME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private FFKCOFOEJPC BFJAIILAPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2FF0", Offset = "0x5ED1FF0", VA = "0x185ED2FF0")]
		get
		{
			return default(FFKCOFOEJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public EPBBLHAHLDD JCCIKEJEENI
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2F00", Offset = "0x5ED1F00", VA = "0x185ED2F00")]
		get
		{
			return default(EPBBLHAHLDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public HABMGPNOJNJ(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2CF0", Offset = "0x5ED1CF0", VA = "0x185ED2CF0")]
	public static bool OKGBDLIDGHC(HABMGPNOJNJ APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2F60", Offset = "0x5ED1F60", VA = "0x185ED2F60", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(HABMGPNOJNJ EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public readonly struct KCKLFLLAEJC : IEquatable<KCKLFLLAEJC>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly KCKLFLLAEJC KGLICEBIEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public ODNJIFHCJFP FHHLKDMADLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(ODNJIFHCJFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private MGHGDLAOALD AMPFKEEHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED59B0", Offset = "0x5ED49B0", VA = "0x185ED59B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private BNFIACHEJEO IMEMPFBLEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED52C0", Offset = "0x5ED42C0", VA = "0x185ED52C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public NEINGNPOCME IPLJNIDFCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(NEINGNPOCME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public FIGCDCPGKHC OPJECKNABEH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5540", Offset = "0x5ED4540", VA = "0x185ED5540")]
		get
		{
			return default(FIGCDCPGKHC);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5C60", Offset = "0x5ED4C60", VA = "0x185ED5C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public IEnumerable<JBGHKOBLHJC> GLMACKANOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5ED53B0", Offset = "0x5ED43B0", VA = "0x185ED53B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public JBGHKOBLHJC KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5ED58A0", Offset = "0x5ED48A0", VA = "0x185ED58A0")]
		get
		{
			return default(JBGHKOBLHJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5D80", Offset = "0x5ED4D80", VA = "0x185ED5D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public KCKLFLLAEJC(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2CF0", Offset = "0x5ED1CF0", VA = "0x185ED2CF0")]
	public static bool OKGBDLIDGHC(KCKLFLLAEJC APPJEOKOGAK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2A90", Offset = "0x5ED1A90", VA = "0x185ED2A90")]
	public static bool LICIMLDMCMN(KCKLFLLAEJC HMDDIJJDAIK, KCKLFLLAEJC NDOJJCKFJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5320", Offset = "0x5ED4320", VA = "0x185ED5320", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(KCKLFLLAEJC EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5A40", Offset = "0x5ED4A40", VA = "0x185ED5A40")]
	public JBGHKOBLHJC NMIAHBPIICO(float3? LPGLCEHEHMC, [Optional] quaternion? LGOFCBEILGM, [Optional] Vector3? EKPAHLHAMGH)
	{
		return default(JBGHKOBLHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5670", Offset = "0x5ED4670", VA = "0x185ED5670")]
	public JBGHKOBLHJC HIINCELAFFK(int NFJIPMHILEL, float3? LPGLCEHEHMC, [Optional] quaternion? LGOFCBEILGM, [Optional] Vector3? EKPAHLHAMGH)
	{
		return default(JBGHKOBLHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5ED51B0", Offset = "0x5ED41B0", VA = "0x185ED51B0")]
	public void DAFIJKEBGEI(int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5E10", Offset = "0x5ED4E10", VA = "0x185ED5E10")]
	public void PMEKKAMOFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct JBGHKOBLHJC : IEquatable<JBGHKOBLHJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public KCKLFLLAEJC FKCCENPJIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3D60", Offset = "0x5ED2D60", VA = "0x185ED3D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public float3 LGOPKPGLOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3BB0", Offset = "0x5ED2BB0", VA = "0x185ED3BB0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5ED39F0", Offset = "0x5ED29F0", VA = "0x185ED39F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public quaternion JGPPPKPPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3A70", Offset = "0x5ED2A70", VA = "0x185ED3A70")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3C90", Offset = "0x5ED2C90", VA = "0x185ED3C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public float3 KDGLOPAJFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3800", Offset = "0x5ED2800", VA = "0x185ED3800")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3880", Offset = "0x5ED2880", VA = "0x185ED3880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public AJONKJGGLAE DMDFIFFFEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3790", Offset = "0x5ED2790", VA = "0x185ED3790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private ALGHGEPINNM NHDPBDMDPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3C30", Offset = "0x5ED2C30", VA = "0x185ED3C30")]
		get
		{
			return default(ALGHGEPINNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private DOMCPIADPJN KBJMGIHPALE
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3B50", Offset = "0x5ED2B50", VA = "0x185ED3B50")]
		get
		{
			return default(DOMCPIADPJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private CLBHODCINBC HAICOGKGHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3AF0", Offset = "0x5ED2AF0", VA = "0x185ED3AF0")]
		get
		{
			return default(CLBHODCINBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private CEJPLPHOOJL MOHGBBAJOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3D00", Offset = "0x5ED2D00", VA = "0x185ED3D00")]
		get
		{
			return default(CEJPLPHOOJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private JKLAAGGJGPM KHDGLJDNJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3990", Offset = "0x5ED2990", VA = "0x185ED3990")]
		get
		{
			return default(JKLAAGGJGPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public JBGHKOBLHJC(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3900", Offset = "0x5ED2900", VA = "0x185ED3900", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(JBGHKOBLHJC EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3D60", Offset = "0x5ED2D60", VA = "0x185ED3D60")]
	public void OCFNGJOIGJF(KCKLFLLAEJC APPJEOKOGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct ODNJIFHCJFP : IEquatable<ODNJIFHCJFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public GKAOKMAEDNE PENHCFMGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKAOKMAEDNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private BPGCKJHOOFK OLOJIFKOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF9C0", Offset = "0x5ECE9C0", VA = "0x185ECF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private LAEPPDGPOAO OKMDABBPNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAC90", Offset = "0x5ED9C90", VA = "0x185EDAC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool NCKNFAIEKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBE90", Offset = "0x5EDAE90", VA = "0x185EDBE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 LGOPKPGLOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB700", Offset = "0x5EDA700", VA = "0x185EDB700")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAD50", Offset = "0x5ED9D50", VA = "0x185EDAD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Quaternion JGPPPKPPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAF70", Offset = "0x5ED9F70", VA = "0x185EDAF70")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBBC0", Offset = "0x5EDABC0", VA = "0x185EDBBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 LAFFMBPMCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBED0", Offset = "0x5EDAED0", VA = "0x185EDBED0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB350", Offset = "0x5EDA350", VA = "0x185EDB350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Quaternion NBMJCMLBMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAE20", Offset = "0x5ED9E20", VA = "0x185EDAE20")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9FD0", Offset = "0x5ED8FD0", VA = "0x185ED9FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float ABAAKHNHDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC240", Offset = "0x5EDB240", VA = "0x185EDC240")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB900", Offset = "0x5EDA900", VA = "0x185EDB900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float JFAHGDFBNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB660", Offset = "0x5EDA660", VA = "0x185EDB660")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 KDGLOPAJFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA530", Offset = "0x5ED9530", VA = "0x185EDA530")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA620", Offset = "0x5ED9620", VA = "0x185EDA620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Vector3 INLNEMCEGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB0C0", Offset = "0x5EDA0C0", VA = "0x185EDB0C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public Matrix4x4 DNJBIKJBHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB8C0", Offset = "0x5EDA8C0", VA = "0x185EDB8C0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public ODNJIFHCJFP(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA960", Offset = "0x5ED9960", VA = "0x185EDA960", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(ODNJIFHCJFP EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBFC0", Offset = "0x5EDAFC0", VA = "0x185EDBFC0")]
	public OHLMKILJLIL PAHBOIEOFCD()
	{
		return default(OHLMKILJLIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBAA0", Offset = "0x5EDAAA0", VA = "0x185EDBAA0")]
	public void MOMMPLAFJOJ([Out] Matrix4x4 GCNLNEAOLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC010", Offset = "0x5EDB010", VA = "0x185EDC010")]
	public void PEEBHGOOILK([Out] Vector3 JMACKMIJHBA, [Out] Quaternion BCBIJEANJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDABE0", Offset = "0x5ED9BE0", VA = "0x185EDABE0")]
	public void FILALLNBLKH([Out] RigidTransform IFBMBPJKJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA190", Offset = "0x5ED9190", VA = "0x185EDA190")]
	public DJCDPGPAJPK BKGGHBOOKBO()
	{
		return default(DJCDPGPAJPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA1C0", Offset = "0x5ED91C0", VA = "0x185EDA1C0")]
	public void BKGGHBOOKBO([Out] DJCDPGPAJPK FCFOGDBDAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA160", Offset = "0x5ED9160", VA = "0x185EDA160")]
	public DJCDPGPAJPK APHODGBOIAE()
	{
		return default(DJCDPGPAJPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA0A0", Offset = "0x5ED90A0", VA = "0x185EDA0A0")]
	public void APHODGBOIAE([Out] DJCDPGPAJPK IFBMBPJKJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA440", Offset = "0x5ED9440", VA = "0x185EDA440")]
	public Vector3 CDIKPBHPDDI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB1B0", Offset = "0x5EDA1B0", VA = "0x185EDB1B0")]
	public void HGCHOIKAKHC([In] Vector3 APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA280", Offset = "0x5ED9280", VA = "0x185EDA280")]
	public Vector3 BNEDOOBJPAJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9F00", Offset = "0x5ED8F00", VA = "0x185ED9F00")]
	public void ADMBDPAKLPD([In] Vector3 APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBD40", Offset = "0x5EDAD40", VA = "0x185EDBD40")]
	public Quaternion NJINLPNEJMH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA370", Offset = "0x5ED9370", VA = "0x185EDA370")]
	public void BOHEAGBOJAB([In] Quaternion APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA9F0", Offset = "0x5ED99F0", VA = "0x185EDA9F0")]
	public Quaternion FCJDLMKHACI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB590", Offset = "0x5EDA590", VA = "0x185EDB590")]
	public void LAALIHLOFJP([In] Quaternion APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAB40", Offset = "0x5ED9B40", VA = "0x185EDAB40")]
	public float FGEDINIPHEH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA6F0", Offset = "0x5ED96F0", VA = "0x185EDA6F0")]
	public void DBHDHEEFKKO(float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB4F0", Offset = "0x5EDA4F0", VA = "0x185EDB4F0")]
	public float KJEHDIKEPEP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBC90", Offset = "0x5EDAC90", VA = "0x185EDBC90")]
	public void NINPDKMBKHO(float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB7F0", Offset = "0x5EDA7F0", VA = "0x185EDB7F0")]
	public void MEAIMJKMIIC([In] Vector3 APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA7A0", Offset = "0x5ED97A0", VA = "0x185EDA7A0")]
	public Vector3 DMNIFJALMNA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA890", Offset = "0x5ED9890", VA = "0x185EDA890")]
	public void DNLLEIPDCJB([In] Vector3 APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC150", Offset = "0x5EDB150", VA = "0x185EDC150")]
	public Vector3 PFPCBPJMMPH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB420", Offset = "0x5EDA420", VA = "0x185EDB420")]
	public void JGLONDFGCIB([In] Vector3 APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB9B0", Offset = "0x5EDA9B0", VA = "0x185EDB9B0")]
	public Vector3 MMGNFFDGBHB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB280", Offset = "0x5EDA280", VA = "0x185EDB280")]
	public void IKMMJKALMCF([In] Vector3 APPJEOKOGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct KIILMPCEIAA : IEquatable<KIILMPCEIAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public GKHNCFMKNMN BLDHKNMDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		get
		{
			return default(GKHNCFMKNMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int[] CPIELFDINKC
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5F30", Offset = "0x5ED4F30", VA = "0x185ED5F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
	public KIILMPCEIAA(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE9C0", Offset = "0x5ECD9C0", VA = "0x185ECE9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5EA0", Offset = "0x5ED4EA0", VA = "0x185ED5EA0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8A0", Offset = "0x5ECD8A0", VA = "0x185ECE8A0", Slot = "4")]
	public bool Equals(KIILMPCEIAA EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDC0", Offset = "0x5ECDDC0", VA = "0x185ECEDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DPJHCHGKJBL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct GCIDNLHLKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Guid BCPPFHNPEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public HOHJGAEIKAG JHMKEDHCODF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct HOHJGAEIKAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int APPJEOKOGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int NPKIKDJFBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int DHCBFMEALJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int FKLHNLFIOBP;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED36F0", Offset = "0x5ED26F0", VA = "0x185ED36F0")]
		public bool GHEGOEEJGKF([Out] AOLAPKAKPFI LBCBENNEFOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3770", Offset = "0x5ED2770", VA = "0x185ED3770")]
		public HOHJGAEIKAG(AOLAPKAKPFI LBCBENNEFOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0450", Offset = "0x5ECF450", VA = "0x185ED0450")]
	public static Guid FJNOKMJAPMN(this AOLAPKAKPFI LBCBENNEFOP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0430", Offset = "0x5ECF430", VA = "0x185ED0430")]
	public static bool FDCEIFLKJGC(this Guid BCPPFHNPEMA, [Out] AOLAPKAKPFI LBCBENNEFOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class FDAAADANBBJ
{
	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0B60", Offset = "0x5ECFB60", VA = "0x185ED0B60")]
	public static MGHGDLAOALD AMPFKEEHKOG(this DALFLBHIMAN LPCEACMGEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0BF0", Offset = "0x5ECFBF0", VA = "0x185ED0BF0")]
	public static DKJNHDKDPGA JIFOOAOLCDE(this DALFLBHIMAN LPCEACMGEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0CC0", Offset = "0x5ECFCC0", VA = "0x185ED0CC0")]
	public static EntityManager PBDLFNMMACM(this DALFLBHIMAN LPCEACMGEAL)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x24D4060", Offset = "0x24D3060", VA = "0x1824D4060")]
	public static T LLCHHBLPGKI<T>(this DALFLBHIMAN LPCEACMGEAL) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x24D3CF0", Offset = "0x24D2CF0", VA = "0x1824D3CF0")]
	public static bool HIHOGDDCOLJ<T>(this DALFLBHIMAN LPCEACMGEAL) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x24D3FB0", Offset = "0x24D2FB0", VA = "0x1824D3FB0")]
	public static bool JHLKDLJPEBH<T>(this DALFLBHIMAN LPCEACMGEAL) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface OCNDOMNDGLK
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LBEJAPKEJNA(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EMHBFADNHPH(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMGMLBBGOBL(DALFLBHIMAN BOEFBOGINDB, [Out] Guid OCKKPJOGMKO);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid APKMFNMAAJF(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJCDBBFDMLN(DALFLBHIMAN BOEFBOGINDB, Guid OCKKPJOGMKO);

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EBNCBHIMIJO(DALFLBHIMAN BOEFBOGINDB, [Out] Guid BCDEFAJKINM);

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid MEPLJEPDJNL(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NKAGHFGCGHH(DALFLBHIMAN BOEFBOGINDB, Guid BCDEFAJKINM);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JJMFJPMJKFD(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AHFCEDBKLLK(DALFLBHIMAN DNNMPMAOGBP, DALFLBHIMAN IGPIMCJILMM);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface HCBKDGKHOPH
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	Guid FNNJLALKGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNMFOJLLMEA(Guid OCKKPJOGMKO, Guid BCDEFAJKINM, string JNMEJDHMADI);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface JJFMBENHELA
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	IReadOnlyCollection<HOELMJJHJAA> CBOKFHKIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OKECJGAIGFA(int MEGKEAHLAIG, [Out] HOELMJJHJAA OBNBKNAOIDE);

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HOELMJJHJAA ENOJDPLFIAO(Type CFGJPNBLNDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class DDPCEHBJMOO
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2357010", Offset = "0x2356010", VA = "0x182357010")]
	public static T JIKMAEMLOON<T>(this JJFMBENHELA HMBIAOCCAMH, Entity CFNJODNKJAM) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x23564D0", Offset = "0x23554D0", VA = "0x1823564D0")]
	public static HOELMJJHJAA ENOJDPLFIAO<T>(this JJFMBENHELA HMBIAOCCAMH) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface LLBOLCDJGHA
{
	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AOLAPKAKPFI[] HPIMHAFGOLO(string JNMEJDHMADI, GKHNCFMKNMN KOMDKDGCILL, bool FNJAEMEHJDC = false);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGNFEEBPAHA(string AELAONILKMK, AOLAPKAKPFI[] EMOFBCKAOOI);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface AEIECBAICDE
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<DALFLBHIMAN, DALFLBHIMAN> CPFOCMKHLED;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<DALFLBHIMAN, DALFLBHIMAN> JDCILNCJKLF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<DALFLBHIMAN, DALFLBHIMAN, DALFLBHIMAN> POIDMEBIEOE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<DALFLBHIMAN> LKMIPEIJLEF;

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GKCHHEHMFJH(DALFLBHIMAN BOEFBOGINDB, DALFLBHIMAN LOKAPMDNCFL);

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DALFLBHIMAN FOMDDMAOKLK(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<DALFLBHIMAN> DEEKJKIFKAG(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DALFLBHIMAN BHMPOLPNOHJ(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KHJMALCIMFI(DALFLBHIMAN BOEFBOGINDB, Vector3 JLIPLKMFDHF, Quaternion JCPLJDGGPGK);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MHBIGIFDHCA(DALFLBHIMAN BOEFBOGINDB, float LCAFNBOHFDC);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool PJKCIBCHHOJ(DALFLBHIMAN BOEFBOGINDB, [Out] RigidTransform HFCDBMJEFBC);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool HJIGOHOAKNJ(DALFLBHIMAN BOEFBOGINDB, [Out] float IAHJFODBEAM);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 FKHMHKDJEPC(JEHKMHJKKCD KHEEDKJGJOO);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion LJBDGNNBIEN(JEHKMHJKKCD KHEEDKJGJOO);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class OEDANCIMEBM
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface IAOHEEBCKIE
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	object AOMFMEGCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCANAOONOMF(LBFACEKPFEC OPKAINPLLMM);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum OIDGPHGODHP
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FHAKJDCGOCC
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xAF52A0", Offset = "0xAF42A0", VA = "0x180AF52A0")]
	public static bool AALKKAGNMKE(this OIDGPHGODHP LDGNDDODOCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAF52B0", Offset = "0xAF42B0", VA = "0x180AF52B0")]
	public static bool OPCBGGFPLDH(this OIDGPHGODHP LDGNDDODOCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x20746F0", Offset = "0x20736F0", VA = "0x1820746F0")]
	public static bool MENEEIFMOAC(this OIDGPHGODHP LDGNDDODOCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum MPALLCMIGKM
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Neck,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Shoulders,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Stomach,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Hips,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	UpperArmR,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	LowerArmR,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	HandR,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	UpperArmL,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	LowerArmL,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	HandL,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	UpperLegR,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	LowerLegR,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	FootR,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	UpperLegL,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	LowerLegL,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	FootL,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class MMINJJMJLCB
{
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xD512D0", Offset = "0xD502D0", VA = "0x180D512D0")]
	public static int ADGAPIOJBLG(this MPALLCMIGKM APPJEOKOGAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface GEBBJKMMHMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface DHDAPBIGPCJ
{
	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	OIDGPHGODHP AHNGIEPKFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	OIDGPHGODHP ALMADGDMHHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	OIDGPHGODHP FFPOMLNLONK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	OIDGPHGODHP BDJPDEJCMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	OIDGPHGODHP BLFFEDFPIPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	OIDGPHGODHP OJHMNIEPPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	OIDGPHGODHP GBEMKFEPMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	OIDGPHGODHP JCPPENPAJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	OIDGPHGODHP MJNGNHIFEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	OIDGPHGODHP LPPNNIPJMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	OIDGPHGODHP LEKLMMNBMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	OIDGPHGODHP OLOJHEFEIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	OIDGPHGODHP BAPAILIOFOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface CILBLAAABKJ
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<HIKGODCBGKM> OOCABFJNOPN;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DALFLBHIMAN JPHMCDJABFE(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGDFLKBJGCN(List<DALFLBHIMAN> LFPPNDFJDNB);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DALFLBHIMAN LHNOALLBDNH(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GLKDGJFHDGI(DALFLBHIMAN BOEFBOGINDB, DALFLBHIMAN IGPIMCJILMM, bool BGNCACIKMGK);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ILJPKCGLKLE(DALFLBHIMAN BOEFBOGINDB, DALFLBHIMAN IGPIMCJILMM);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int GNLHIFFEHLD(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LBFACEKPFEC OHEIINALIJJ(DALFLBHIMAN KFGJIMGDDPH);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<DALFLBHIMAN> AIMBKPIKEOD(DALFLBHIMAN KFGJIMGDDPH);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OIDIBAODBDA(DALFLBHIMAN BOEFBOGINDB, DALFLBHIMAN JJFOJHELEHH);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KFAPELDDGMK(DALFLBHIMAN BOEFBOGINDB, DALFLBHIMAN HPIAGANECMG);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DALFLBHIMAN GBFLAMKDKCI(DALFLBHIMAN MNNJBJHGADP, DALFLBHIMAN BDNGKPINFKJ);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BONDKOMNNIA(DALFLBHIMAN MNNJBJHGADP, DALFLBHIMAN BDNGKPINFKJ, [Out] DALFLBHIMAN PGMILKPLOMB);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class NAJBFMOOFHF
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5ED87E0", Offset = "0x5ED77E0", VA = "0x185ED87E0")]
	public static List<DALFLBHIMAN> AGDFLKBJGCN(this CILBLAAABKJ KDBKOEIHBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5ED88F0", Offset = "0x5ED78F0", VA = "0x185ED88F0")]
	public static bool LAHBJHCBLCC(this CILBLAAABKJ KDBKOEIHBJM, DALFLBHIMAN BOEFBOGINDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface PLFEKMFHELK
{
	[Cpp2IlInjected.Token(Token = "0x17000128")]
	bool AILELBKINFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	bool CHBAGFIEEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface ELGOBIHKBCK : ENECEEPEFGP
{
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AIELBEKICOJ(Entity CFNJODNKJAM, [Out] ELINFAFBFAO LJOOGDNJBGF);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJOMMKCOCAJ(NativeArray<ELINFAFBFAO> EOKJKCIIGFO, NativeArray<BAAOIOIMBIG> DMOFALMOLIM);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KEEKBCCBIIA(ELINFAFBFAO LJOOGDNJBGF);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EGIOOKAIGAH(ELINFAFBFAO LJOOGDNJBGF, [Out] Collider ADLAAIPCPLH);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface ENECEEPEFGP
{
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPKMIHCADGL([In] float3 MJEJBDJGGLA, [In] float3 AKNDOLIKNGM, float IBOJBDBEJBJ, Allocator OIPBEAGANJF, [Out] NativeArray<Entity> DJHDIEIFFIA);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface CACPIIKCPKA
{
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPKMIHCADGL([In] float3 MJEJBDJGGLA, [In] float3 AKNDOLIKNGM, float IBOJBDBEJBJ, [Out] JIBMINJKOEH FOGGEDEHPPL, [Out] DALFLBHIMAN GEGLHHMOFEK);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface HKEELJJPPCN
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPKMIHCADGL([In] NativeArray<Entity> DJHDIEIFFIA, [In] float3 MJEJBDJGGLA, [In] float3 AKNDOLIKNGM, [In] NativeArray<JIBMINJKOEH> MJPKJPEGDIC);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct ELINFAFBFAO : PMNNCLPDDJB, IEquatable<ELINFAFBFAO>
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public int KLNGLNIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x82BE50", Offset = "0x82AE50", VA = "0x18082BE50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public int JIGAGOBMBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x208F330", Offset = "0x208E330", VA = "0x18208F330", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x52EBC80", Offset = "0x52EAC80", VA = "0x1852EBC80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0730", Offset = "0x5ECF730", VA = "0x185ED0730", Slot = "8")]
	public bool Equals(ELINFAFBFAO EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0780", Offset = "0x5ECF780", VA = "0x185ED0780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct JIBMINJKOEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float IPICKPOAKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 IPOPAPIAACP;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface NPJINIMGOOL
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface BPGCKJHOOFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	MGHGDLAOALD AMPFKEEHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	AJBOHKHIKOG NDJGMNGILDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<LBFACEKPFEC, NativeArray<LBHIBFADKLF>> JBHAGNDLCJJ;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<LBFACEKPFEC> PFDGKANCLMP;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LCIFOIEHOAC KOBLIHACACI(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LBHIBFADKLF PNDMCKIIGOC(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NOIKFHNFAKL(AOLAPKAKPFI LBCBENNEFOP, LPICGNDOFJL KCFEKGFNDGG);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GPCLFOFJBMB(AOLAPKAKPFI[] EMOFBCKAOOI, GameObject GFBHJHHLEFD);

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GKHNCFMKNMN PEDOHFFOMDM(DALFLBHIMAN BOEFBOGINDB, [Optional] object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DONFMMCNEIB(DALFLBHIMAN BOEFBOGINDB, [Out] LPICGNDOFJL KCFEKGFNDGG);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PKHDDKNPMIO(DALFLBHIMAN BOEFBOGINDB, [Out] Transform PIMEBPKGKBD);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JDOMPEFEOKI(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FCBCJHEDNPB(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool EKFFNPPMCOI(LocalId BOEFBOGINDB, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool GPKADIHLFMF(LocalId BOEFBOGINDB, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DALFLBHIMAN EDGNDEBIDIL(AOLAPKAKPFI LBCBENNEFOP);

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OJANBHFJNGO(AOLAPKAKPFI LBCBENNEFOP, [Out] DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	AOLAPKAKPFI CHOMMFONAKB(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "20")]
	LBFACEKPFEC EDGNDEBIDIL(NativeArray<AOLAPKAKPFI> LBCBENNEFOP, Allocator OIPBEAGANJF);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "21")]
	LBFACEKPFEC PKCJIIGPFFK(NativeArray<AOLAPKAKPFI> LBCBENNEFOP, NativeArray<DMDFOFEOCBM> NLCJPGOBDIF, Allocator OIPBEAGANJF);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "22")]
	AOLAPKAKPFI[] HPIMHAFGOLO(string AELAONILKMK, GKHNCFMKNMN KOMDKDGCILL, bool FNJAEMEHJDC);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DGNFEEBPAHA(string AELAONILKMK, AOLAPKAKPFI[] EMOFBCKAOOI);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "24")]
	GKHNCFMKNMN JLDPFBGCNMF(LBHIBFADKLF MMIOCMIOHFJ, bool NLELBGAOAIH);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GKHNCFMKNMN JLDPFBGCNMF(LBHIBFADKLF MMIOCMIOHFJ);

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GKHNCFMKNMN ECNNOFENCHE(LBHIBFADKLF MMIOCMIOHFJ);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "27")]
	GKHNCFMKNMN GFHFEBFCFFK(LBHIBFADKLF MMIOCMIOHFJ);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "28")]
	GKHNCFMKNMN PKCJIIGPFFK(AOLAPKAKPFI LBCBENNEFOP, LBHIBFADKLF MMIOCMIOHFJ);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "29")]
	PLBADGLLBHO GIKKGNCCENI();

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	KCKLFLLAEJC KLMCNJAPIGA();

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	HABMGPNOJNJ ALEBAIEFHPA(EPBBLHAHLDD HBACFKOJHIB);

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void BDPDGOAABHD(LBFACEKPFEC OPKAINPLLMM);

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void EPEJEEPODAB(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KIKCEHMBEPH(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BDPDGOAABHD(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "36")]
	LBFACEKPFEC FMLJIPIGMBH(LBFACEKPFEC ICHIEKBGENJ, Allocator OIPBEAGANJF);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool AKEJHEAMADO(DALFLBHIMAN BOEFBOGINDB);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class FNAGJBCAHLC
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x5ED13A0", Offset = "0x5ED03A0", VA = "0x185ED13A0")]
	public static void FCBCJHEDNPB(this BPGCKJHOOFK GBIHCEMBHAM, LPICGNDOFJL KCFEKGFNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1270", Offset = "0x5ED0270", VA = "0x185ED1270")]
	public static GKHNCFMKNMN HDCJNHBOMDA(this BPGCKJHOOFK GBIHCEMBHAM, LocalId BOEFBOGINDB)
	{
		return default(GKHNCFMKNMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1270", Offset = "0x5ED0270", VA = "0x185ED1270")]
	public static DALFLBHIMAN EDGNDEBIDIL(this BPGCKJHOOFK GBIHCEMBHAM, LocalId BOEFBOGINDB)
	{
		return default(DALFLBHIMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5ED11F0", Offset = "0x5ED01F0", VA = "0x185ED11F0")]
	public static AOLAPKAKPFI CHOMMFONAKB(this BPGCKJHOOFK GBIHCEMBHAM, LocalId BOEFBOGINDB)
	{
		return default(AOLAPKAKPFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0F10", Offset = "0x5ECFF10", VA = "0x185ED0F10")]
	public static bool AKEJHEAMADO(this BPGCKJHOOFK GBIHCEMBHAM, AOLAPKAKPFI LBCBENNEFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x24DCC20", Offset = "0x24DBC20", VA = "0x1824DCC20")]
	public static T PJHCCAMELNM<T>(this BPGCKJHOOFK GBIHCEMBHAM, LocalId BOEFBOGINDB) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0FE0", Offset = "0x5ECFFE0", VA = "0x185ED0FE0")]
	public static PLBADGLLBHO APGMMMDJOMD(this BPGCKJHOOFK GBIHCEMBHAM, RigidTransform FCFOGDBDAJF, [Optional] object PDIBILKHEBM)
	{
		return default(PLBADGLLBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5ED10E0", Offset = "0x5ED00E0", VA = "0x185ED10E0")]
	public static HABMGPNOJNJ BPFNJDEECPI(this BPGCKJHOOFK GBIHCEMBHAM, EPBBLHAHLDD FLOCFJAFEHG, RigidTransform FCFOGDBDAJF, [Optional] object PDIBILKHEBM)
	{
		return default(HABMGPNOJNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED12A0", Offset = "0x5ED02A0", VA = "0x185ED12A0")]
	public static KCKLFLLAEJC EKICDNIINHD(this BPGCKJHOOFK GBIHCEMBHAM, RigidTransform FCFOGDBDAJF, [Optional] object PDIBILKHEBM)
	{
		return default(KCKLFLLAEJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1420", Offset = "0x5ED0420", VA = "0x185ED1420")]
	private static void MGOOJIGMIHP(GKHNCFMKNMN KBLIDEKJJIC, RigidTransform FCFOGDBDAJF, [Optional] object PDIBILKHEBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface OLPJOBBIDMO
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	bool FHKLLFGHJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	DALFLBHIMAN EJOIJGACJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	GKHNCFMKNMN MIPHIPLMLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event NPHHOIEGFCO JICAGECJIMM;

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DALFLBHIMAN GBFLAMKDKCI(DALFLBHIMAN MNNJBJHGADP, DALFLBHIMAN BDNGKPINFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BONDKOMNNIA(DALFLBHIMAN MNNJBJHGADP, DALFLBHIMAN BDNGKPINFKJ, [Out] DALFLBHIMAN PGMILKPLOMB);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JPMIHDBHAFH();

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KOCDDBMOOKG();

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GGHALHOIANM(DALFLBHIMAN MNNJBJHGADP);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AKAMIMHNGMA(DALFLBHIMAN MNNJBJHGADP);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public delegate void NPHHOIEGFCO(GKHNCFMKNMN JKCAPDIHANK, GKHNCFMKNMN JGKKHMKNIOE);
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class ACBLCKFHJEH
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCBE0", Offset = "0x5ECBBE0", VA = "0x185ECCBE0")]
	public static bool JHIBJJLFHPF(this OLPJOBBIDMO PPEHAEGKDCF, DALFLBHIMAN MNNJBJHGADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCB60", Offset = "0x5ECBB60", VA = "0x185ECCB60")]
	public static bool FNLPGPAIOKF(this OLPJOBBIDMO PPEHAEGKDCF, DALFLBHIMAN MNNJBJHGADP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface IPBKFFLIOHE
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOBCAADAAJJ(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AHLFJCGHEFO(DALFLBHIMAN BOEFBOGINDB, Transform PIMEBPKGKBD);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface CGJEMIMBMMC
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGELNGHHJGH(DALFLBHIMAN MNNJBJHGADP, DALFLBHIMAN PJLAABMEEKC, DALFLBHIMAN LMOLMJDMNDA);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DALFLBHIMAN NMPGIFMDCNB(DALFLBHIMAN MNNJBJHGADP);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface DIPBIEJNFLO
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKPELIGNGJH(DALFLBHIMAN KFGJIMGDDPH, bool APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKLEEFHEIBN(DALFLBHIMAN KFGJIMGDDPH, bool APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFAOJHANBPD(DALFLBHIMAN KFGJIMGDDPH, int APPJEOKOGAK);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface BNFIACHEJEO
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<DALFLBHIMAN> PNBLAMNJIKF(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DALFLBHIMAN IDAECDPKNKB(DALFLBHIMAN BOEFBOGINDB, int NFJIPMHILEL);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LFKGNDGNNJG(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FIGCDCPGKHC HFNAAJDGNDA(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDPAAHHAFCO(DALFLBHIMAN BOEFBOGINDB, FIGCDCPGKHC DFHMEJDFNAL);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DALFLBHIMAN OANCEEMOIFG(DALFLBHIMAN BOEFBOGINDB, [Optional] float3? LPGLCEHEHMC, [Optional] quaternion? LGOFCBEILGM, [Optional] float3? EKPAHLHAMGH);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DALFLBHIMAN AOPOAILHNAL(DALFLBHIMAN BOEFBOGINDB, int NFJIPMHILEL, [Optional] float3? LPGLCEHEHMC, [Optional] quaternion? LGOFCBEILGM, [Optional] float3? EKPAHLHAMGH);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GMPMLJPMDKB(DALFLBHIMAN BOEFBOGINDB, int NFJIPMHILEL);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CJFJACOLPMB(DALFLBHIMAN BOEFBOGINDB);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface MDBKNAHGHCB
{
	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIGNKLADJIC();

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIMAJOLHEGJ();

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAEDOENFIDA();

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKLMEMGGOFN();

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOILNDEAOPE();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DBNAICIKNEK();

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGCANFGGCJB();

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CKGOPGJBKCD();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AGGELOCMAJF();

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JNBNEMJLOOA();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ICHBFAELMCB();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface LAEPPDGPOAO
{
	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLNHHJAFNAJ(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGCHOIKAKHC(Entity CFNJODNKJAM, [In] float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 CDIKPBHPDDI(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOHEAGBOJAB(Entity CFNJODNKJAM, [In] quaternion APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion NJINLPNEJMH(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PEEBHGOOILK(Entity CFNJODNKJAM, [Out] float3 LPGLCEHEHMC, [Out] quaternion LGOFCBEILGM);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PEEBHGOOILK(Entity CFNJODNKJAM, [Out] RigidTransform GHMOODLBINE);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FILALLNBLKH(Entity CFNJODNKJAM, [Out] RigidTransform GHMOODLBINE);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 NIJDNDGCAJJ(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MEAIMJKMIIC(Entity CFNJODNKJAM, [In] float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DBHDHEEFKKO(Entity CFNJODNKJAM, float APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float FGEDINIPHEH(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JGLONDFGCIB(Entity CFNJODNKJAM, [In] float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 PFPCBPJMMPH(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ADMBDPAKLPD(Entity CFNJODNKJAM, [In] float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 BNEDOOBJPAJ(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LAALIHLOFJP(Entity CFNJODNKJAM, [In] quaternion APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion FCJDLMKHACI(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 DMNIFJALMNA(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DNLLEIPDCJB(Entity CFNJODNKJAM, [In] float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NINPDKMBKHO(Entity CFNJODNKJAM, float APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float KJEHDIKEPEP(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IKMMJKALMCF(Entity CFNJODNKJAM, [In] float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 MMGNFFDGBHB(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LJDJILCMBHP(Entity CFNJODNKJAM, [Out] float4x4 GCNLNEAOLDL);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BCACOHIABDD(Entity CFNJODNKJAM, [In] float4x4 GCNLNEAOLDL);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OLCNKOBEJBF(Entity CFNJODNKJAM, [Out] float4x4 GCNLNEAOLDL);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PKHDDKNPMIO(Entity CFNJODNKJAM, [Out] Transform PIMEBPKGKBD);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MKAKPAJPHMN(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KKOPPGCMFNN(Entity CFNJODNKJAM, Entity MOIJFAHEGOI, Entity GLMIFAAAHGN);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class ALKACIBJCLM
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface HAIGJBHDDFO
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World NGDCLGMADOH(string IAJDAFMEGBM = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World PELFLHLBLON(string IAJDAFMEGBM = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World JIELCAHEEGK(string IAJDAFMEGBM = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World MKLFCLNFAEE(string IAJDAFMEGBM = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface DKJNHDKDPGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	World JNDBLFAJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	World KLPJEPNKLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	EntityManager PBDLFNMMACM
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	bool OAFFKLKKCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase CEBCJCEGGOH(Type CFGJPNBLNDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class LEDFKDKNDMA
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7500", Offset = "0x5ED6500", VA = "0x185ED7500")]
	public static ComponentSystemBase NLHDLKBLIFC(this World MNIDJIIDCNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x255C360", Offset = "0x255B360", VA = "0x18255C360")]
	public static T CEBCJCEGGOH<T>(this DKJNHDKDPGA LDKIJCNHOCJ) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface NNEPJDKEOPN
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCBDJPMNCEI(NativeListAsync<Entity> IGHHMEHPNME);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJFMBDNDIIJ(MHJBOMDJNNH GAADBPAGHPJ);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOBDOOLFNIG(NativeListAsync<Entity> EILMHNJOJPM, bool MOPIPHDCNAI);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KAMLOIGMLKF();
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface FLAMNPOBAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FILFALBLCJL(DALFLBHIMAN BOEFBOGINDB, [Out] Collider ADLAAIPCPLH);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NHHJNFBFOKP(DALFLBHIMAN JIHNPPBNPMF, GameObject NEMHBMOBONB, Vector3 LGJKNOILLNC, Quaternion ODJCGHEELMK);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJHABOHLOIN(GameObject ADLAAIPCPLH);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider PBAIMBPGMGI<TCollider>(GameObject BABLOAPPCJK) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLNBJFHCDAK(Collider ADLAAIPCPLH);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject EGMNFJDKJOM<TCollider>(string JNMEJDHMADI) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface BJKCPKPNMOK
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COMEILFBCLD(DALFLBHIMAN BOEFBOGINDB, NBMGBMCGCBP JELDFPEBLJM, bool EEMJKKFDLGP, HLMPGCIBJOF ANKGBONNKAF);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCELFAKGGAH(DALFLBHIMAN BOEFBOGINDB, NBMGBMCGCBP JELDFPEBLJM, bool EEMJKKFDLGP, bool PLDDLPICFNN, bool KIPNLPEOEIM);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GIMBIKGLCLO HECCEPPFBLG(DALFLBHIMAN GLACNLFCFNI, List<DALFLBHIMAN> OAJKJPPFNCC);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHLFGFCDJDE(GameObject AJEJNMELCCJ, GameObject EFGLPEPHICL);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JEHDBGELHKE(GameObject EFGLPEPHICL);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T PBAIMBPGMGI<T>(GameObject BABLOAPPCJK) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JLNBJFHCDAK(Collider ADLAAIPCPLH);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject LDAPACBFFOH<T>(string JNMEJDHMADI) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface DLCIOIDPKIF
{
	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLNBCHLANIJ(DALFLBHIMAN BOEFBOGINDB, CBBNHNONOOK APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CBBNHNONOOK DHNMPFIFDGF(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFEGLLIBHOI(DALFLBHIMAN BOEFBOGINDB, DALFLBHIMAN APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HACPIENJING(DALFLBHIMAN BOEFBOGINDB, DALFLBHIMAN APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GNLHIFFEHLD(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DALFLBHIMAN EKLAKAJGPLA(DALFLBHIMAN BOEFBOGINDB, int NFJIPMHILEL);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHFKGDCKBDJ(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BCJEJIPPEEK(DALFLBHIMAN BOEFBOGINDB, object PDIBILKHEBM, DALFLBHIMAN APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AJBBGHDBKOO(DALFLBHIMAN BOEFBOGINDB, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool INLLGNLECBH(DALFLBHIMAN BOEFBOGINDB, [Out] DALFLBHIMAN APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KOCGJJKEFKA(DALFLBHIMAN BOEFBOGINDB, float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PCFKJFNIOGF(DALFLBHIMAN BOEFBOGINDB, [Out] float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FNGDHBOMDHP(DALFLBHIMAN BOEFBOGINDB, float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool EDBIJNNHLID(DALFLBHIMAN BOEFBOGINDB, [Out] float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IPJPJENFJLJ(DALFLBHIMAN BOEFBOGINDB, (Quaternion rot, Vector3 moments) IJPGGILEIIN);

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool HHHFIJDJDEJ(DALFLBHIMAN BOEFBOGINDB, [Out] quaternion OPKOAAPHEFK, [Out] float3 LHLODHFOGNM);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EPGIOJOMFFM(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HMHEDMKMOMK(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 CEFKIOAEKLI(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 AAAKOKDMALB(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DAHOEINPDHO(DALFLBHIMAN BOEFBOGINDB, float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ADNEIOHMOPI(DALFLBHIMAN BOEFBOGINDB, float3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float CBJBDNIPNIO(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float BFBEFJGNHMA(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LLPECCFKBEI(DALFLBHIMAN BOEFBOGINDB, float APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void JNLADDOECCA(DALFLBHIMAN BOEFBOGINDB, float APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode AADFCMBMMFF(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ANDGONDPCMO(DALFLBHIMAN BOEFBOGINDB, CollisionDetectionMode APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	BAGHKPJGLEA KEMCFDFELGE(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void IMDBBIIPBEN(DALFLBHIMAN BOEFBOGINDB, BAGHKPJGLEA APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool JBKDHNADAPC(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BAFBFDPEHNG(DALFLBHIMAN BOEFBOGINDB, bool APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	DALFLBHIMAN JPHMCDJABFE(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void JLBNKAPNJFA(DALFLBHIMAN BOEFBOGINDB, DALFLBHIMAN APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	DALFLBHIMAN LHNOALLBDNH(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void GLKDGJFHDGI(DALFLBHIMAN BOEFBOGINDB, DALFLBHIMAN APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	HJJEIONKHEK PKCDHFDDLIF(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void OGINMBAMNOE(DALFLBHIMAN BOEFBOGINDB, HJJEIONKHEK MEJOPMNLIME);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool NPICALGPJPA(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void FKKEFJCMMFO(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool JMOGKGMEDHC(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void EJAPKDBKDLP(DALFLBHIMAN BOEFBOGINDB, bool APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool FGBLOBLBADM(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void FKJHEEAKBKP(DALFLBHIMAN BOEFBOGINDB, bool APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints FHNBJOFOENO(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void IHBGEMPOFKP(DALFLBHIMAN BOEFBOGINDB, RigidbodyConstraints APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float BGFEBNELACG(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void EODOHPIDOMP(DALFLBHIMAN BOEFBOGINDB, float APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float HEMPOBCEMDE(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void LHGMIHLACFE(DALFLBHIMAN BOEFBOGINDB, float APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool BIEAHIGHJKA(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void DMGGFILLLOF(DALFLBHIMAN BOEFBOGINDB, bool APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool PAHICBHCAIM(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void NOPNHJMPOKH(DALFLBHIMAN BOEFBOGINDB, bool APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void DDHELFMDEIE(DALFLBHIMAN BOEFBOGINDB, int APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object IMAAHHCLLFA(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void DOMFFOLNDLN(DALFLBHIMAN BOEFBOGINDB, object APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object GAPBIHJPIPN(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void JMEFAMAIEKG(DALFLBHIMAN BOEFBOGINDB, object APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float KFBECDMNMEP(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void ONLOEHKHDFL(DALFLBHIMAN BOEFBOGINDB, float APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void FFPNHEPFLJP(DALFLBHIMAN BOEFBOGINDB, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void CJCOGMEOGBB(DALFLBHIMAN BOEFBOGINDB, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool CBDJPDFFKCM(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void KPELMGMABCH(DALFLBHIMAN BOEFBOGINDB, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void CLGNFOEIGIJ(DALFLBHIMAN BOEFBOGINDB, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool CEGHGJPPNNO(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool GBAFFDCMBJM(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody GHNGMHJFDIF(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void FHICNJMPDEM(DALFLBHIMAN BOEFBOGINDB, Rigidbody JFBLILNAOMM);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void JEJJNCIBMKD(DALFLBHIMAN BOEFBOGINDB, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void MPNABKADOLD(DALFLBHIMAN BOEFBOGINDB, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool DBMBFKMMNEM(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void FHOIACCFJLJ(DALFLBHIMAN BOEFBOGINDB, float3 OBNDDJFFKOO);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void JCPKDEBJLAH(DALFLBHIMAN BOEFBOGINDB, float3 DHDAKHKKKMH);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool EEIGPDIPGMG(DALFLBHIMAN BOEFBOGINDB, [Out] float3 OBNDDJFFKOO);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool MIHJHOHLFLN(DALFLBHIMAN BOEFBOGINDB, [Out] float3 DHDAKHKKKMH);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool KFMBBJLEAJK(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void HKCNNAOAKMG(DALFLBHIMAN BOEFBOGINDB, object PDIBILKHEBM, bool GKHMPKCJGHP);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void JBEPOHFELMI(DALFLBHIMAN BOEFBOGINDB, bool AKDKDHNFGJM);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void OJALHMBOKJE(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool JNEHLEEPNNK(DALFLBHIMAN BOEFBOGINDB);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface JMOMKGEHEMD
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	bool OAFFKLKKCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEIPMCEFFPA(DALFLBHIMAN BOEFBOGINDB);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFDOPBMCIEK(DALFLBHIMAN BOEFBOGINDB, bool EEMJKKFDLGP, bool PLDDLPICFNN, bool IFDMKLECEJA);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMOPADFKBAI(DALFLBHIMAN BOEFBOGINDB, float3 GMLDNFHDNJP);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBJEDFMIINF(DALFLBHIMAN BOEFBOGINDB, float3 GMLDNFHDNJP);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface DICAGLHGOJD
{
	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMKOKOKDAHG(Entity DIFBKBOHHEC);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHLALHJMCCC(Entity DIFBKBOHHEC);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public delegate void KMDECHCGCDF(HIDNPNBHELA GCOOMHFHLKA);
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct HIDNPNBHELA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LBFACEKPFEC JGHPPBEKGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NativeArray<byte> MJGALODGAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> NMFMKGLEEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly EDCPELGMLAD PKPKCGCHKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly int LDEBOGOKFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Type INCFKNJMOOO;

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public LBFACEKPFEC BDHHCEADADA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A840", Offset = "0x3A49840", VA = "0x183A4A840")]
		get
		{
			return default(LBFACEKPFEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3300", Offset = "0x5ED2300", VA = "0x185ED3300")]
	public HIDNPNBHELA(LBFACEKPFEC JGHPPBEKGHI, NativeArray<byte> MJGALODGAME, NativeArray<byte> NMFMKGLEEKB, EDCPELGMLAD PKPKCGCHKKM, int LDEBOGOKFKK, Type INCFKNJMOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x24FBED0", Offset = "0x24FAED0", VA = "0x1824FBED0")]
	public NativeArray<T> LBEJNPLNEDA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x24FBDA0", Offset = "0x24FADA0", VA = "0x1824FBDA0")]
	public NativeArray<T> EDALKKGHCCN<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x24FBDE0", Offset = "0x24FADE0", VA = "0x1824FBDE0")]
	public (LBFACEKPFEC, NativeArray<T>, NativeArray<T>) GJNMDDLIIAA<T>() where T : struct
	{
		return default((LBFACEKPFEC, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED32B0", Offset = "0x5ED22B0", VA = "0x185ED32B0")]
	public HIKGODCBGKM JIHFCPPNJKK()
	{
		return default(HIKGODCBGKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface FGNOPLOIPGM
{
	[Cpp2IlInjected.Token(Token = "0x17000137")]
	string NFLEHGFJEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	FGNOPLOIPGM OCLIKPPCMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	IEnumerable<FGNOPLOIPGM> OBFHEALPPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface HHBMLCKOENB
{
	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	FGNOPLOIPGM OIJFICCBPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	List<NPJJOGPBNJA> BNALKODDHOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LCPJKMEIJDI(NPJJOGPBNJA BHNFFMEOAFJ, [Out] FGNOPLOIPGM GPCJDEMBHEM);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOIKFHNFAKL(NPJJOGPBNJA BHNFFMEOAFJ, KMDECHCGCDF FNBBAHMLKEL);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDHNBLDODIP(NPJJOGPBNJA BHNFFMEOAFJ, KMDECHCGCDF FNBBAHMLKEL);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct HIKGODCBGKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly HIDNPNBHELA FCLEEDACIMH;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public LBFACEKPFEC BDHHCEADADA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A840", Offset = "0x3A49840", VA = "0x183A4A840")]
		get
		{
			return default(LBFACEKPFEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3630", Offset = "0x5ED2630", VA = "0x185ED3630")]
	public HIKGODCBGKM(HIDNPNBHELA FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3560", Offset = "0x5ED2560", VA = "0x185ED3560")]
	public LBFACEKPFEC LBEJNPLNEDA()
	{
		return default(LBFACEKPFEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3370", Offset = "0x5ED2370", VA = "0x185ED3370")]
	public LBFACEKPFEC EDALKKGHCCN()
	{
		return default(LBFACEKPFEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3440", Offset = "0x5ED2440", VA = "0x185ED3440")]
	public (LBFACEKPFEC, LBFACEKPFEC, LBFACEKPFEC) GJNMDDLIIAA()
	{
		return default((LBFACEKPFEC, LBFACEKPFEC, LBFACEKPFEC));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DefaultMember("Item")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface MNCHDHICDGP : IEnumerable<JNEBOFIEDGJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	NativeBitArray JPBFCMHOHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	NativeArray<int> MLLGKMJOMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	JNEBOFIEDGJ KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	JNEBOFIEDGJ KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JNEBOFIEDGJ MBFLMPEBKFP(HPMLKNNDOJG PNEABPKDNJE);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EDCPELGMLAD DLHGGEANEAJ(HPMLKNNDOJG PNEABPKDNJE);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class KHLJCAKJOAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
[DefaultMember("Item")]
public interface AEOFKOGJNCI : IEnumerable<OOKAFPGCJJD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000142")]
	int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	OOKAFPGCJJD KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OOKAFPGCJJD MBFLMPEBKFP(HPMLKNNDOJG PNEABPKDNJE);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EDCPELGMLAD DLHGGEANEAJ(HPMLKNNDOJG PNEABPKDNJE);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class NEFLNJMIJPN
{
	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x25FBB50", Offset = "0x25FAB50", VA = "0x1825FBB50")]
	public static EDCPELGMLAD DLHGGEANEAJ<T>(this AEOFKOGJNCI CDJFMFMBDBN, ENCNPEPPFND<T> JNMEJDHMADI) where T : struct
	{
		return default(EDCPELGMLAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface LPCMNKKEKLN : IEnumerable<NPJJOGPBNJA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000144")]
	int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	NPJJOGPBNJA KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NPJJOGPBNJA MBFLMPEBKFP(HPMLKNNDOJG PNEABPKDNJE);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EDCPELGMLAD DLHGGEANEAJ(HPMLKNNDOJG PNEABPKDNJE);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class DEHPCOBMGIC
{
	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x2363210", Offset = "0x2362210", VA = "0x182363210")]
	public static DCMKCANIHKA<T> MBFLMPEBKFP<T>(this LPCMNKKEKLN CDJFMFMBDBN, HPMLKNNDOJG JNMEJDHMADI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2363110", Offset = "0x2362110", VA = "0x182363110")]
	public static EDCPELGMLAD DLHGGEANEAJ<T>(this LPCMNKKEKLN CDJFMFMBDBN, ENCNPEPPFND<T> JNMEJDHMADI) where T : struct
	{
		return default(EDCPELGMLAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface IJICANBCKBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOIKFHNFAKL(HPMLKNNDOJG BHNFFMEOAFJ, KMDECHCGCDF FNBBAHMLKEL);

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDHNBLDODIP(HPMLKNNDOJG BHNFFMEOAFJ, KMDECHCGCDF FNBBAHMLKEL);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class FPJIHFFDMFF
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface IBLBJOEONFE
{
	[Cpp2IlInjected.Token(Token = "0x17000146")]
	FGMDFNHGMEL AAPKPKKKBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IICIJEEANFD(AOLAPKAKPFI LBCBENNEFOP, EDCPELGMLAD BHNFFMEOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKFBBENGPPH(AOLAPKAKPFI LBCBENNEFOP, Span<EDCPELGMLAD> CDJFMFMBDBN, bool ABHPNPFCADK);

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFFHFDMHFOH(NativeArray<AOLAPKAKPFI> EMOFBCKAOOI);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class CKKPNGOMINC
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDF40", Offset = "0x5ECCF40", VA = "0x185ECDF40")]
	public static void DKFBBENGPPH(this IBLBJOEONFE MOFCBCEPDMD, AOLAPKAKPFI LBCBENNEFOP, EDCPELGMLAD BHNFFMEOAFJ, bool ABHPNPFCADK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct FGMDFNHGMEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly NativeBitArray AHHNBBHGIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeParallelHashMap<AOLAPKAKPFI, int> CEOCFFEOHCD;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool LODDGFKFEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0EF0", Offset = "0x5ECFEF0", VA = "0x185ED0EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xAF06B0", Offset = "0xAEF6B0", VA = "0x180AF06B0")]
	public FGMDFNHGMEL(NativeBitArray AHHNBBHGIBA, NativeParallelHashMap<AOLAPKAKPFI, int> CEOCFFEOHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0DC0", Offset = "0x5ECFDC0", VA = "0x185ED0DC0")]
	public bool IICIJEEANFD(AOLAPKAKPFI LBCBENNEFOP, EDCPELGMLAD BHNFFMEOAFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface PFILPHHCEOC
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKKAFNDIHMG(DALFLBHIMAN BOEFBOGINDB, FAFCOCAPCOJ APPJEOKOGAK);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface JPHCGKGONAN
{
	[Cpp2IlInjected.Token(Token = "0x17000148")]
	CLOECILAMCC IDDHPICDKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface DOCAAEBHHBE
{
	[Cpp2IlInjected.Token(Token = "0x17000149")]
	Type GPCLMKEKGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[APMFBPCIIGG(NDFLJIICBJB.LoadInstance)]
public interface BKBAPIPPMME
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNBHAIFOEKL(DALFLBHIMAN KFGJIMGDDPH, bool APPJEOKOGAK);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public readonly struct LEHKMJPNMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IEnumerable<KMPFBKNOPEL> EBOJCBEJPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IReadOnlyList<GameObject> JACEIIKMKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<int> LIJNFLGPMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<(AOLAPKAKPFI, AOLAPKAKPFI)> EEIEOLOGLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int DAOIDBGOKGN;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool EMFJBOKKGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7920", Offset = "0x5ED6920", VA = "0x185ED7920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public int GCILNDKMNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8620A0", Offset = "0x8610A0", VA = "0x1808620A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public IEnumerable<GameObject> HFIPDDGCNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDA0", Offset = "0x7FEDA0", VA = "0x1807FFDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public IEnumerable<(AOLAPKAKPFI src, AOLAPKAKPFI dst)> LBLFGCAKMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7980", Offset = "0x5ED6980", VA = "0x185ED7980")]
	public LEHKMJPNMCE(IEnumerable<KMPFBKNOPEL> EBOJCBEJPBL, IReadOnlyList<GameObject> JACEIIKMKOP, IReadOnlyList<int> LIJNFLGPMEB, IReadOnlyList<(AOLAPKAKPFI src, AOLAPKAKPFI dst)> EEIEOLOGLKO, int DAOIDBGOKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7590", Offset = "0x5ED6590", VA = "0x185ED7590")]
	public (GameObject, int)[] AFNOKDCHFMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface EMGJCNGGJCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	bool HJKOHIFOIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	bool ANFFNKANKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	HJMDPJJEICG JPGPJAMBMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JLKOIFPCMLJ GBNINOCMJNL();

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JLKOIFPCMLJ PELEAAFHKEJ(IEnumerable<DALFLBHIMAN> OPKAINPLLMM, [In] DJCDPGPAJPK ANKMKGAJEEL);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DABAPCNPLEL HEIMOBGGLHJ(ByteString LGNEPEIIJLG);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HIGIJCLJLGJ ICHPLGDKLHA(ByteString LNCOLHOCFJN, DALFLBHIMAN IGPIMCJILMM, [In] DJCDPGPAJPK JEHCIBEIOBL, LHJIEFKJLLI NPNOFGMFOMA, bool EJLKKGDIJJH = true);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JCJAMNGCFEC();

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LEHKMJPNMCE HIPEECLJGJD(IEnumerable<KMPFBKNOPEL> EBOJCBEJPBL);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class IIBHIANPNKE
{
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface DLKHBFJLBPK
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action HHPNBCGMCKK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action DJHICEPFNPC;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct DMDFOFEOCBM : BBIMOGAIALL, IEquatable<DMDFOFEOCBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public LBHIBFADKLF MMIOCMIOHFJ;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5ED02F0", Offset = "0x5ECF2F0", VA = "0x185ED02F0", Slot = "5")]
	public void AJBPOCIDFHA(ADPHFBNFONE JPPGFPLOJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5ED03A0", Offset = "0x5ECF3A0", VA = "0x185ED03A0", Slot = "4")]
	public void KJONJHMMAMK(HNBKBBLFGFP BBENPAOCMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5ED03D0", Offset = "0x5ECF3D0", VA = "0x185ED03D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x16C9AD0", Offset = "0x16C8AD0", VA = "0x1816C9AD0", Slot = "6")]
	public bool Equals(DMDFOFEOCBM EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0320", Offset = "0x5ECF320", VA = "0x185ED0320", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct AOLAPKAKPFI : IComparable<AOLAPKAKPFI>, IEquatable<AOLAPKAKPFI>, BBIMOGAIALL
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public const uint GJMIIAOFCMG = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint OHPLINADFKM = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly AOLAPKAKPFI GHGNOAMLPEA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int LPFGCOPNCBB = 24;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const uint GEHOIFGAOON = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int DOGKFPJIAJD = 8;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const uint KKNMHAJGBHB = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly uint BKCOILCKNDC;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public uint LJJJGNKINGB
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x7CAEE0", Offset = "0x7C9EE0", VA = "0x1807CAEE0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public uint INAJMIAKCCF
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDCC0", Offset = "0x5ECCCC0", VA = "0x185ECDCC0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public uint JPMPDNEFEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool EMFJBOKKGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x5E31870", Offset = "0x5E30870", VA = "0x185E31870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xD512D0", Offset = "0xD502D0", VA = "0x180D512D0")]
	public static AOLAPKAKPFI GMCCFMPHMJM(uint BKCOILCKNDC)
	{
		return default(AOLAPKAKPFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDDC0", Offset = "0x5ECCDC0", VA = "0x185ECDDC0")]
	public AOLAPKAKPFI(int NLOANPFIFKC, int LJJCJBBEFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDDC0", Offset = "0x5ECCDC0", VA = "0x185ECDDC0")]
	public AOLAPKAKPFI(uint NLOANPFIFKC, int LJJCJBBEFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDDC0", Offset = "0x5ECCDC0", VA = "0x185ECDDC0")]
	public AOLAPKAKPFI(uint NLOANPFIFKC, uint LJJCJBBEFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x82BE50", Offset = "0x82AE50", VA = "0x18082BE50")]
	private AOLAPKAKPFI(uint BKCOILCKNDC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x16C9AF0", Offset = "0x16C8AF0", VA = "0x1816C9AF0")]
	public static bool LICIMLDMCMN(AOLAPKAKPFI HMDDIJJDAIK, AOLAPKAKPFI NDOJJCKFJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x16C9AD0", Offset = "0x16C8AD0", VA = "0x1816C9AD0", Slot = "5")]
	public bool Equals(AOLAPKAKPFI LPCEACMGEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC40", Offset = "0x5ECCC40", VA = "0x185ECDC40", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2074600", Offset = "0x2073600", VA = "0x182074600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDD30", Offset = "0x5ECCD30", VA = "0x185ECDD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDCD0", Offset = "0x5ECCCD0", VA = "0x185ECDCD0", Slot = "6")]
	public void KJONJHMMAMK(HNBKBBLFGFP BBENPAOCMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDBD0", Offset = "0x5ECCBD0", VA = "0x185ECDBD0", Slot = "7")]
	public void AJBPOCIDFHA(ADPHFBNFONE JPPGFPLOJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC30", Offset = "0x5ECCC30", VA = "0x185ECDC30", Slot = "4")]
	public int CompareTo(AOLAPKAKPFI EJEDDDCGMMB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct KMPFBKNOPEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Guid BCPPFHNPEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public string AELAONILKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Vector3 LPGLCEHEHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Quaternion LGOFCBEILGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Vector3 EKPAHLHAMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int IMHOLMEJHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Dictionary<string, object> DFHMEJDFNAL;

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED61B0", Offset = "0x5ED51B0", VA = "0x185ED61B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6020", Offset = "0x5ED5020", VA = "0x185ED6020")]
	private static string KFILHOJPKNA(Dictionary<string, object> GLBBOMGLNKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public enum OLONKKMLBEN
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class ACCAJLJMFPC
{
	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x541AA20", Offset = "0x5419A20", VA = "0x18541AA20")]
	public static bool MDKKBNCLAMB(this OLONKKMLBEN CFGJPNBLNDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Flags]
public enum IMFLKEEDHFG
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface HIGIJCLJLGJ : HJMDPJJEICG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000155")]
	LHJIEFKJLLI GEMNJFNMIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LODICMNCPHB();

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCJBJHHAAFE();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface HJMDPJJEICG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000156")]
	IEnumerable<KMPFBKNOPEL> PNKLDPNNLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	LEHKMJPNMCE EKAAEFIFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	LocalId EDEALOBBJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	IADFFJHHONH GJNABHOLKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	Task NJBNLLEKCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PCIFAKAHGKL(IMFLKEEDHFG GEIOEGAMNIG);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface LHJIEFKJLLI
{
	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHKNBNJJPOJ(Guid AEMKIPDFHEB, [Out] Guid HPCDKOJJCBN);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface DABAPCNPLEL : HJMDPJJEICG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[Flags]
public enum ALIHNEIJLFM
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface JLKOIFPCMLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	IADFFJHHONH EECKMKBPKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString KOBOCMAMHIF();
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public enum ONGEIHNIMHD
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public delegate bool LPNGKBGPJAC(ACOBJAIKFDL GIDGEKFJHMD, [In] BDBCEBCNMAI APPJEOKOGAK);
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public delegate bool MIJEBNLFDDE<T>(ACOBJAIKFDL GIDGEKFJHMD, [In] T APPJEOKOGAK);
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface GNGOKECPJNI
{
	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOIKFHNFAKL(EDCPELGMLAD PKPKCGCHKKM, Type JLKCOALGCDN, LPNGKBGPJAC JLFHCBPLFJO);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMOKFMGLFCH(EDCPELGMLAD PKPKCGCHKKM, [Out] LPNGKBGPJAC JLFHCBPLFJO);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class GJBFDHBKNCE
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class OCPMMBFAKBO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public MIJEBNLFDDE<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public OCPMMBFAKBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5CB0", Offset = "0x3DF4CB0", VA = "0x183DF5CB0")]
		internal bool MLMNAFMAPGD(ACOBJAIKFDL pendingList, [In] BDBCEBCNMAI value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x24EF150", Offset = "0x24EE150", VA = "0x1824EF150")]
	public static void NOIKFHNFAKL<T>(this GNGOKECPJNI PJFMIMNFEDC, EDCPELGMLAD PKPKCGCHKKM, MIJEBNLFDDE<T> JLFHCBPLFJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1A50", Offset = "0x5ED0A50", VA = "0x185ED1A50")]
	public static bool JJKPEDGAHCB(this GNGOKECPJNI PJFMIMNFEDC, ACOBJAIKFDL GIDGEKFJHMD, EDCPELGMLAD PKPKCGCHKKM, [In] BDBCEBCNMAI APPJEOKOGAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface KJFOKAKIIMC
{
	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	uint LMLNLJKEHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface ACOBJAIKFDL
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAPCPMJLNKC(AOLAPKAKPFI IBMDJDGKMAK, EDCPELGMLAD PKPKCGCHKKM, ReadOnlySpan<byte> HBKINMFLAHD, ReadOnlySpan<byte> EMHNDEAJNLL);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OEMCEHOFAPB(AOLAPKAKPFI IBMDJDGKMAK, EDCPELGMLAD PKPKCGCHKKM);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EHLJBGLIPLD(AOLAPKAKPFI IBMDJDGKMAK, EDCPELGMLAD PKPKCGCHKKM, ReadOnlySpan<byte> EMHNDEAJNLL);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EMAFFMILNBD(AOLAPKAKPFI IBMDJDGKMAK, EDCPELGMLAD PKPKCGCHKKM, Span<byte> HBKINMFLAHD, Span<byte> EMHNDEAJNLL);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class GLABGJMOAMD
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x24F4E20", Offset = "0x24F3E20", VA = "0x1824F4E20")]
	public static bool EMAFFMILNBD<T>(this ACOBJAIKFDL DFDGHLKLAGB, AOLAPKAKPFI IBMDJDGKMAK, EDCPELGMLAD PKPKCGCHKKM, [Out] T HBKINMFLAHD, [Out] T EMHNDEAJNLL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x24F4CF0", Offset = "0x24F3CF0", VA = "0x1824F4CF0")]
	public static bool EHLJBGLIPLD<T>(this ACOBJAIKFDL DFDGHLKLAGB, AOLAPKAKPFI IBMDJDGKMAK, EDCPELGMLAD PKPKCGCHKKM, T EMHNDEAJNLL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public enum KDFCDHJGMBG
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface KNIACBABJKI
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FECNMKGPDEO(GCEJLAILKLA ONDDMEPBDDI, ReadOnlySpan<byte> HPEDGLBMGED);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPBBMMFJBPP(uint DHCBFMEALJE, ReadOnlySpan<byte> HPEDGLBMGED);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface GEGLLCDBHJC
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCEJLAILKLA DIIJKIJHEEI(ReadOnlySpan<byte> HPEDGLBMGED);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface NJPNMCNNKAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLNADDMJAPP(GCEJLAILKLA BGNGIHJEFLM, ReadOnlySpan<byte> HPEDGLBMGED);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGCOIMANLPL(ReadOnlySpan<GCEJLAILKLA> LDMEGNNFBBH);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct POFOIFEFGON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public GCEJLAILKLA ONDDMEPBDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public ReadOnlyMemory<byte> HPEDGLBMGED;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct GCEJLAILKLA
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static GCEJLAILKLA GDGBPNDIMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public uint NLOANPFIFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int BKAEMBGACKC;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x9CE1C0", Offset = "0x9CD1C0", VA = "0x1809CE1C0")]
	public GCEJLAILKLA(uint NLOANPFIFKC, int BKAEMBGACKC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1730", Offset = "0x5ED0730", VA = "0x185ED1730")]
	public static bool LICIMLDMCMN([In] GCEJLAILKLA LJNLOLDLJAJ, [In] GCEJLAILKLA AHGDCNHHAHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1640", Offset = "0x5ED0640", VA = "0x185ED1640", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1700", Offset = "0x5ED0700", VA = "0x185ED1700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1750", Offset = "0x5ED0750", VA = "0x185ED1750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED16F0", Offset = "0x5ED06F0", VA = "0x185ED16F0")]
	public void FPCBDFAHIFB([Out] uint NLOANPFIFKC, [Out] int BKAEMBGACKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[APMFBPCIIGG(NDFLJIICBJB.OMRoom)]
public interface BJFFHHANCHO : OOEMNIFAEGL<BJFFHHANCHO>
{
	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FKFDJGDIAKO(EDCPELGMLAD LPCEACMGEAL, [Out] LPIBMNKKMBC OBNBKNAOIDE);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class FIPONINJDCC
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface LPIBMNKKMBC
{
	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	Type NDIGNGEDELA
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJBPOCIDFHA(ADPHFBNFONE JPPGFPLOJCL, Span<byte> MNNJBJHGADP);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJONJHMMAMK(HNBKBBLFGFP BBENPAOCMIF, ReadOnlySpan<byte> ONDDMEPBDDI);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class DPBEDKJONHE
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct BAAOIOIMBIG : ISystemStateComponentData, IComponentData, IEquatable<BAAOIOIMBIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float3 BFANNAKPDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 OGNCDOLKCIE;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDDD0", Offset = "0x5ECCDD0", VA = "0x185ECDDD0", Slot = "4")]
	public bool Equals(BAAOIOIMBIG EJEDDDCGMMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface OHNAOMBDDJP
{
	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIAHDGAFLGO NNNIJPKENFK(int MEGKEAHLAIG);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DELOFDOECKG(AIAHDGAFLGO MHNMDBDJBON);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface MLHFIOBABHD
{
	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	IEnumerable<BKPNNJPKIHN> OOGKPDKDMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LDBLPOCDHHL(int MEGKEAHLAIG, [Out] BKPNNJPKIHN OBNBKNAOIDE);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface OLEFAGBFHBC
{
	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ENDKFKGIOMM(int MEGKEAHLAIG);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface OEBKGEOFHJE
{
	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	List<(AIAHDGAFLGO nameHash, NENHIINAELP stableTypeHash, Type type)> DGACGJPNJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class OHHMJHHAJKD
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OHHMJHHAJKD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
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
