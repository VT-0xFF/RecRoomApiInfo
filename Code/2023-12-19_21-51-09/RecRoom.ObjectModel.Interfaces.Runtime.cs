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
public struct HBBOGBDBNJL : IReadOnlyList<HIMFIAMFCKI>, IEnumerable<HIMFIAMFCKI>, IEnumerable, IReadOnlyCollection<HIMFIAMFCKI>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct HFKIAPPJDEO : IEnumerator<HIMFIAMFCKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly FLPNJHKLIHG FPHMPFNGAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator MCDMPGFPEBB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public HIMFIAMFCKI FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5EF3AA0", Offset = "0x5EF26A0", VA = "0x185EF3AA0", Slot = "4")]
			get
			{
				return default(HIMFIAMFCKI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5EF3A20", Offset = "0x5EF2620", VA = "0x185EF3A20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3A23810", Offset = "0x3A22410", VA = "0x183A23810")]
		public HFKIAPPJDEO(FLPNJHKLIHG FPHMPFNGAPO, NativeArray<LocalId>.Enumerator MCDMPGFPEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3960", Offset = "0x5EF2560", VA = "0x185EF3960", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5EF39A0", Offset = "0x5EF25A0", VA = "0x185EF39A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5EF39E0", Offset = "0x5EF25E0", VA = "0x185EF39E0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly FLPNJHKLIHG FPHMPFNGAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> BPDDIMEAMCL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HIMFIAMFCKI NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3320", Offset = "0x5EF1F20", VA = "0x185EF3320", Slot = "4")]
		get
		{
			return default(HIMFIAMFCKI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2DB0", Offset = "0x5EF19B0", VA = "0x185EF2DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int DOBKIOMOBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76ED80", VA = "0x180770180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HOBMJDIAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76ED80", VA = "0x180770180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EJCLNBICOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2EB0", Offset = "0x5EF1AB0", VA = "0x185EF2EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> IIGJFBJLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A1BCA0", Offset = "0x3A1A8A0", VA = "0x183A1BCA0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3290", Offset = "0x5EF1E90", VA = "0x185EF3290")]
	public HBBOGBDBNJL(int AAAINGBCLDC, FLPNJHKLIHG FPHMPFNGAPO, Allocator NOFANFDHPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A23190", Offset = "0x3A21D90", VA = "0x183A23190")]
	public HBBOGBDBNJL(FLPNJHKLIHG FPHMPFNGAPO, NativeArray<LocalId> BPDDIMEAMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EF30D0", Offset = "0x5EF1CD0", VA = "0x185EF30D0")]
	internal HBBOGBDBNJL(FLPNJHKLIHG FPHMPFNGAPO, NativeArray<Entity> ELHAAFMGCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3140", Offset = "0x5EF1D40", VA = "0x185EF3140")]
	public HBBOGBDBNJL(FLPNJHKLIHG FPHMPFNGAPO, int NBJKCBMEDIG, Allocator NOFANFDHPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EF31E0", Offset = "0x5EF1DE0", VA = "0x185EF31E0")]
	public HBBOGBDBNJL(HBBOGBDBNJL MPBOHIHPPDI, Allocator NOFANFDHPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2E00", Offset = "0x5EF1A00", VA = "0x185EF2E00")]
	public HBBOGBDBNJL KOCALHGOPKG(Allocator NOFANFDHPGP = Allocator.Temp)
	{
		return default(HBBOGBDBNJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2CE0", Offset = "0x5EF18E0", VA = "0x185EF2CE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2D20", Offset = "0x5EF1920", VA = "0x185EF2D20")]
	public HFKIAPPJDEO IFFPMJIPELE()
	{
		return default(HFKIAPPJDEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2EF0", Offset = "0x5EF1AF0", VA = "0x185EF2EF0", Slot = "6")]
	private IEnumerator<HIMFIAMFCKI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2FE0", Offset = "0x5EF1BE0", VA = "0x185EF2FE0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct JIJICJKIOMC : IList<HIMFIAMFCKI>, ICollection<HIMFIAMFCKI>, IEnumerable<HIMFIAMFCKI>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct LDJOGNFDJCM : IEnumerator<HIMFIAMFCKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly FLPNJHKLIHG FPHMPFNGAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator MCDMPGFPEBB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HIMFIAMFCKI FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5EF9F30", Offset = "0x5EF8B30", VA = "0x185EF9F30", Slot = "4")]
			get
			{
				return default(HIMFIAMFCKI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5EF9EB0", Offset = "0x5EF8AB0", VA = "0x185EF9EB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3A23810", Offset = "0x3A22410", VA = "0x183A23810")]
		public LDJOGNFDJCM(FLPNJHKLIHG FPHMPFNGAPO, NativeArray<LocalId>.Enumerator MCDMPGFPEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9DF0", Offset = "0x5EF89F0", VA = "0x185EF9DF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9E30", Offset = "0x5EF8A30", VA = "0x185EF9E30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9E70", Offset = "0x5EF8A70", VA = "0x185EF9E70", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FLPNJHKLIHG FPHMPFNGAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> BPDDIMEAMCL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HIMFIAMFCKI NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8D20", Offset = "0x5EF7920", VA = "0x185EF8D20", Slot = "4")]
		get
		{
			return default(HIMFIAMFCKI);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8DA0", Offset = "0x5EF79A0", VA = "0x185EF8DA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8780", Offset = "0x5EF7380", VA = "0x185EF8780", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HOBMJDIAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8780", Offset = "0x5EF7380", VA = "0x185EF8780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool GNNIBHGIIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8C90", Offset = "0x5EF7890", VA = "0x185EF8C90")]
	public JIJICJKIOMC(FLPNJHKLIHG FPHMPFNGAPO, int NBJKCBMEDIG, Allocator NOFANFDHPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8700", Offset = "0x5EF7300", VA = "0x185EF8700")]
	public HBBOGBDBNJL FOBIKNMBFFD()
	{
		return default(HBBOGBDBNJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF84A0", Offset = "0x5EF70A0", VA = "0x185EF84A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EF84E0", Offset = "0x5EF70E0", VA = "0x185EF84E0", Slot = "13")]
	public bool Contains(HIMFIAMFCKI KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8570", Offset = "0x5EF7170", VA = "0x185EF8570", Slot = "14")]
	public void CopyTo(HIMFIAMFCKI[] DAJPKFPFPMI, int DOCPNNGFPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8420", Offset = "0x5EF7020", VA = "0x185EF8420", Slot = "11")]
	public void Add(HIMFIAMFCKI KADOGPFLCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EF88E0", Offset = "0x5EF74E0", VA = "0x185EF88E0", Slot = "7")]
	public void Insert(int DCGGFHOCGGH, HIMFIAMFCKI KADOGPFLCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EF89E0", Offset = "0x5EF75E0", VA = "0x185EF89E0", Slot = "15")]
	public bool Remove(HIMFIAMFCKI KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8850", Offset = "0x5EF7450", VA = "0x185EF8850", Slot = "6")]
	public int IndexOf(HIMFIAMFCKI KADOGPFLCFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8990", Offset = "0x5EF7590", VA = "0x185EF8990", Slot = "8")]
	public void RemoveAt(int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EF86C0", Offset = "0x5EF72C0", VA = "0x185EF86C0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EF87C0", Offset = "0x5EF73C0", VA = "0x185EF87C0")]
	public LDJOGNFDJCM IFFPMJIPELE()
	{
		return default(LDJOGNFDJCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8AB0", Offset = "0x5EF76B0", VA = "0x185EF8AB0", Slot = "16")]
	private IEnumerator<HIMFIAMFCKI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8BA0", Offset = "0x5EF77A0", VA = "0x185EF8BA0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DBOMNFNAJJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int OCEFKKGJJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> EBLMMHODBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HIMFIAMFCKI GFLHGOCEBCM(HIMFIAMFCKI BPDDIMEAMCL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BKOFEJLKCNK : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface KGMIGCOACBF : NJKAEMDAMDL, PDKMOJIAHEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool CBOMGKLCBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ALMCOIGPHEO HNGBAEBKBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NBLIGDJLPBL ANAFNAOBKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GMDOEGFMHEJ JMMFFGPKJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	IIBKOJFCNJK INDLGFDHLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NKLPGGMEOPK HEHLOHJELIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface PDKMOJIAHEM
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool CGCCNAIGNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface ACBNOMHIIJF
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNLILDGKJDM(bool GCPEEAODAIB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface IIBKOJFCNJK
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HLPBCPPLNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AOBOFIEFCEH;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNAEGCJCPCG(bool CDMIKOHKIDI);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MLDJEOOKJBN(ByteString KCGANELMDLB);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PGJKHKMOAFG();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DJMLPGIOEDO();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MPLPKFGNMDO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface GMDOEGFMHEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	AKLOJBGPAJC HNGBAEBKBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	NBLIGDJLPBL ANAFNAOBKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	GKKDCNJAMAE AMOLHHIMHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	KGMIGCOACBF JJMEOJDNMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EDOFJLFNBEH AHHFEGHKCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MNPEJCNPPGJ JEPKHGEJBKH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	EFDIIDLHGCF KNLGKFAPMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BKOKKOKNKBC GPOLPIKHPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	HIIJOGNCNMH HAEANBLPGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GBEAKGJBPDH APIPJCJMCOL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	FMDJJFNGDFG LNKJCMJLNLH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	FJHMEDBHAAJ EIMFKNIAKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	LDEMCEPKGGP GDCIDLHLGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	BPBODEILMOP AIAIOIPKAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	KAPJLJPJBNO OOJPFHFGEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	EIPJMFAKKNI JOHMNJBEFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DMOPNDHELBN JALOCOABFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CDHIDEMMGGM MHGADNHMMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	LMOCGNGFDKJ AAMDIKBALHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BOMPPIOAEFC PFCHMFJEAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(FDODHDCNOCF))]
public readonly struct HIMFIAMFCKI : IComparable<HIMFIAMFCKI>, IEquatable<HIMFIAMFCKI>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly HIMFIAMFCKI PHKLJCNEMGA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int JIILANGODGC = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int AFOCCCKGPEG = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int OGOCLCBDBAH = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int HJGABAEDJKA = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId JMADFINDJPP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KGMIGCOACBF JJMEOJDNMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3F80", Offset = "0x5EF2B80", VA = "0x185EF3F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LocalId HDADMDFIPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF40F0", Offset = "0x5EF2CF0", VA = "0x185EF40F0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	internal NKLPGGMEOPK HEHLOHJELIM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF40C0", Offset = "0x5EF2CC0", VA = "0x185EF40C0")]
		get
		{
			return default(NKLPGGMEOPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool ENKHGCDGNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3FE0", Offset = "0x5EF2BE0", VA = "0x185EF3FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool AIGGAFIHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3F30", Offset = "0x5EF2B30", VA = "0x185EF3F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool KACAKNGLONP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF42D0", Offset = "0x5EF2ED0", VA = "0x185EF42D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4450", Offset = "0x5EF3050", VA = "0x185EF4450")]
	public HIMFIAMFCKI(FLPNJHKLIHG MCCNONNLPGO, LocalId JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
	public JMFPDKOILML ENMAOBKGJCA()
	{
		return default(JMFPDKOILML);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4130", Offset = "0x5EF2D30", VA = "0x185EF4130")]
	public static LocalId JLFJLFEACJM(HIMFIAMFCKI JLDEAKFCMFK)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4170", Offset = "0x5EF2D70", VA = "0x185EF4170")]
	public static Entity JLFJLFEACJM(HIMFIAMFCKI JLDEAKFCMFK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5EF41B0", Offset = "0x5EF2DB0", VA = "0x185EF41B0")]
	public static bool JONBIHPGCCI(HIMFIAMFCKI FLGIINLNNEM, HIMFIAMFCKI KNDAEONALIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EF40D0", Offset = "0x5EF2CD0", VA = "0x185EF40D0")]
	public static bool JBDELPGDOBO(HIMFIAMFCKI FLGIINLNNEM, HIMFIAMFCKI KNDAEONALIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4320", Offset = "0x5EF2F20", VA = "0x185EF4320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3DA0", Offset = "0x5EF29A0", VA = "0x185EF3DA0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3CC0", Offset = "0x5EF28C0", VA = "0x185EF3CC0", Slot = "4")]
	public int CompareTo(HIMFIAMFCKI LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "5")]
	public bool Equals(HIMFIAMFCKI LLMHBOEDHFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GPKIHLOOMLG
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2BF0", Offset = "0x5EF17F0", VA = "0x185EF2BF0")]
	public static LCHFDJFHJHJ ELKKMHPJMJL(this HIMFIAMFCKI IIFJCGIHMIN)
	{
		return default(LCHFDJFHJHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x24FD4A0", Offset = "0x24FC0A0", VA = "0x1824FD4A0")]
	public static T GNAOHJJFFJK<T>(this HIMFIAMFCKI IIFJCGIHMIN) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class FDODHDCNOCF
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct NKLPGGMEOPK : IEquatable<NKLPGGMEOPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte IFMBFHNFCLO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] HKIHFJKFFOA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static FLPNJHKLIHG KPNBIJBEFPF;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static KGMIGCOACBF IKMPGMGJNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static FLPNJHKLIHG[] ELPFHBGALAL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static KGMIGCOACBF[] KMGGNADPBGC;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> OBNNPEHLOHE;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KGMIGCOACBF JJMEOJDNMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5EFBB30", Offset = "0x5EFA730", VA = "0x185EFBB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FLPNJHKLIHG KHBMMPGBPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5EFBD90", Offset = "0x5EFA990", VA = "0x185EFBD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC060", Offset = "0x5EFAC60", VA = "0x185EFC060")]
	static NKLPGGMEOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xBBFA70", Offset = "0xBBE670", VA = "0x180BBFA70")]
	internal NKLPGGMEOPK(byte GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x51B3480", Offset = "0x51B2080", VA = "0x1851B3480", Slot = "4")]
	public bool Equals(NKLPGGMEOPK LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5EFBA80", Offset = "0x5EFA680", VA = "0x185EFBA80", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x19E3670", Offset = "0x19E2270", VA = "0x1819E3670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EFBFA0", Offset = "0x5EFABA0", VA = "0x185EFBFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5EFB160", Offset = "0x5EF9D60", VA = "0x185EFB160")]
	private static FLPNJHKLIHG APMJNKEDJOO(byte IFMBFHNFCLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5EFBE70", Offset = "0x5EFAA70", VA = "0x185EFBE70")]
	private static KGMIGCOACBF NPEGCJGGBAP(byte IFMBFHNFCLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EFBC20", Offset = "0x5EFA820", VA = "0x185EFBC20")]
	private static object KCMABFHACNG(byte IFMBFHNFCLO, object[] HJEFNDCLEGO, object MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EFBC10", Offset = "0x5EFA810", VA = "0x185EFBC10")]
	private static int IIBEPBGJJBG(byte IFMBFHNFCLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EFBB20", Offset = "0x5EFA720", VA = "0x185EFBB20")]
	private static int GNDKBOBHNAJ(byte IFMBFHNFCLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EFBF20", Offset = "0x5EFAB20", VA = "0x185EFBF20")]
	private static (int, int) OLFIIHABKJH(byte IFMBFHNFCLO)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EFB6E0", Offset = "0x5EFA2E0", VA = "0x185EFB6E0")]
	private static byte DMGBKIKEJAB(int DLBBNPMBKBG, int DCGGFHOCGGH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5EFB420", Offset = "0x5EFA020", VA = "0x185EFB420")]
	internal static NKLPGGMEOPK CFNGGCOIEBP(KGMIGCOACBF IBDHMFKPEHF, FLPNJHKLIHG GKAKDCNCCBM)
	{
		return default(NKLPGGMEOPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EFB210", Offset = "0x5EF9E10", VA = "0x185EFB210")]
	internal static void BAIJPEIFOMP(NKLPGGMEOPK IFMBFHNFCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EFB6F0", Offset = "0x5EFA2F0", VA = "0x185EFB6F0")]
	private static void DMNBEJPDHFJ(int AAAINGBCLDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface BGBNOECFPFI
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDKLIBKACNO();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAHCACAKMHE(bool BIDFJFCKHBE);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFIECJEMLOE(GameObject LCHNDEILNAI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface AADPCCDEKEE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Guid NKAEEDGNEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OIPNLNIADPO(Guid OKJCCHICPFF, Guid ALHPABGCANM);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JBJIKDEAGPH(HIMFIAMFCKI GEKMICMLOGI);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DHFDILENCML(HIMFIAMFCKI HOGAMINFHLD, HIMFIAMFCKI HHNAEDAPOHF, [Out] Vector3 PFPKEOGBCMG, [Out] Quaternion NPBGCICJLPM);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNJGKHGCMAP(DLBPDJGOHPH AKBFGJNMFEF, Vector3 PFPKEOGBCMG, Quaternion NPBGCICJLPM);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNMLPMCDFHH(HIMFIAMFCKI NLMPPGAGAOE, [Out] Vector3 IIPGIMLIGOD, [Out] Quaternion HKALFNFPGJL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface IBPFOPIOHFP
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHJGLKNAILP(HBBOGBDBNJL BPDDIMEAMCL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface NBLIGDJLPBL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BGBNOECFPFI DKJJIEFJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KGIFHMCBIOC EIJEKIKMKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PCMKMDGGOKA ADNKGJGMIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AHLJNGAFEPJ GEBCHEEEHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	HGGBGNPFHFM KDBKOCOKOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BBHOOEAIMPJ JEGHCHJBIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CGLNNJHNJJC MPCJGIDJJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	IIAEJKCIPMH NLBGAAJIEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface LJLCOKFMKIN
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFLJGPBBJOO(Action GAFABDCELFL, bool IOODOEKKPOL);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JMCMNDPMMDI(string JEICAPDKHKI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface KGIFHMCBIOC
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string GDJFAFOCDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] DJDDAOMFEFH(IEnumerable<HEFIFDFEEHD> ENONDHKJMPC);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool POGJCHOIBHD(GameObject LCHNDEILNAI, [Out] LCHFDJFHJHJ[] KMDPPOBDBCF);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHOEOHHKIPD(GameObject LCHNDEILNAI, [Out] int FGFPCPKGODI, [Out] LGFPBEODEOP LMBLGMDMJHB);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FBHHAPBFFJI OJFCMMIGMMH(HEFIFDFEEHD NFAAJOAMBMN);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FBHHAPBFFJI OJFCMMIGMMH(string CDJCGCBIKKC, LCHFDJFHJHJ[] EJBFBHCOFGB, Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE, Vector3 JIFOIDNONIC);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject HCJCHHFNKEP(string CDJCGCBIKKC);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IBKIJMGNJEK(GameObject HKLCKFIBFHK, bool BNMAAIDFKDO);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCAOFEMIBML(GameObject LCHNDEILNAI, bool LEDLEENKCLL, bool PAJKEFJJBOK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GFPHDDMLPNB
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1980", Offset = "0x5EF0580", VA = "0x185EF1980")]
	public static FBHHAPBFFJI OJFCMMIGMMH(this KGIFHMCBIOC IENMGICDHEH, Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE, Vector3 JIFOIDNONIC, params LCHFDJFHJHJ[] KMDPPOBDBCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface PCMKMDGGOKA
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNMPFGOHLGD(bool CDMIKOHKIDI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface AHLJNGAFEPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool CDOGNDOJMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool BDGMFONPAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IIOGJBHDELP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int COFNFOGCBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool LKOHAALMJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LAODCBCCJHF(object AGEBEEELPDJ);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void APOMCMDHLIO(object AGEBEEELPDJ);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FIDEAEHBPID(object JIGKIEPHJOJ);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IKGIBBMIFML(object JIGKIEPHJOJ);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int PCKBCEIDHLM(GameObject JNAEGEFDFLO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AIAJMDKBLPM(NativeArray<int> JNMNKDGLNJK);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EHLMMALFMGG(NativeArray<int> JOKBCHKAIFE);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CALALJOJCGK();

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GGOLPLLIPJK(uint NOPJOFJIKBB, ReadOnlySpan<byte> FGGBCKMIHJM, bool PHJACFLDEDA = false);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GGOLPLLIPJK(uint NOPJOFJIKBB, ReadOnlySpan<byte> FGGBCKMIHJM, ReadOnlySpan<byte> LDODDBFOEFP, bool PHJACFLDEDA = false);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface HGGBGNPFHFM
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHMPHHPHDCO(GameObject LCHNDEILNAI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface COMAGPJADJN
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANFPJBNFINB(string EOOPGFAEMIH);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface EODJEPLDECA
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FPEGAJGGOHI(GameObject LCHNDEILNAI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INAPAKJFAPK(GameObject LCHNDEILNAI);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object HBMOKGMJPJD(HIMFIAMFCKI JMADFINDJPP, GameObject LCHNDEILNAI, Action<HIMFIAMFCKI, int> FCFEFDOJHCD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BIAGNEMJNPG(GameObject LCHNDEILNAI, object KGPNEKJAHBE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface BBHOOEAIMPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int BIJCACBDMAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LGENICEHHPC(GameObject LCHNDEILNAI);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DOPHKIDLKAJ([Out] Vector3 CFCLFCDKKPD);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MFDHBLDPHGL();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface CGLNNJHNJJC
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HLPBCPPLNNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CINIFOIPAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface CHMODAFFLMP
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	GPEDHLKMOBP FHNFEFHPNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IOMOOCHMMIM EIIIKOPKIDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GAFDKEIPOFG(Transform CAHHGMHAMLP);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOANNFOPJKH(Transform CAHHGMHAMLP, PDJNBPLLHHE EIINNHMILIA);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDOKLDBBPBM(Transform CAHHGMHAMLP, KFHCMIPAIKD HDALIMNEKHP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface IIAEJKCIPMH
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCDANCDAOMH();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface ODBKGHAJCDB
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBMFMOFAKIM();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface PECBDMEMJED
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGFPBEODEOP FAIMBKBCIEF(GameObject JNAEGEFDFLO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EADGGINBIOP(GameObject LCHNDEILNAI, BOCEJMGJIJI DLPAFKELAKD, HAEEMLMCOBG POIAFGGHCAA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string FCCPECHBPAC(int HLINMGJJNHD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LDFGCBPGLEA(string DONFKHJMCEA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLIFCBGAHNJ(HIMFIAMFCKI JMADFINDJPP, int[] NIIGEFKBMIC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GANDALGCJDK(GameObject LJAABCGBANE, GameObject LIPMBENEIEM, int MBHEOBIOBGA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct CEPGMBHBKPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly BJLGIEANENG DIOBLODNDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly BJLGIEANENG AEFDKINALJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint EFOIKKALNBD;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EED510", Offset = "0x5EEC110", VA = "0x185EED510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct PHCCKCPPMGM
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly CEPGMBHBKPP GAFABDCELFL;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC1B0", Offset = "0x5EFADB0", VA = "0x185EFC1B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct PGAHJGCPJEE
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly CEPGMBHBKPP GAFABDCELFL;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC1B0", Offset = "0x5EFADB0", VA = "0x185EFC1B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct GJALCAHOCNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint EFOIKKALNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool IACCCIAJGOF;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1B60", Offset = "0x5EF0760", VA = "0x185EF1B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BJLGIEANENG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int IAKOFEGDGBF;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5EED1C0", Offset = "0x5EEBDC0", VA = "0x185EED1C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface LEEENCJHJHO
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	OMFPLGPJNHC LLJLNJAKNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum DJOJCHCBLGD
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
public interface FBHHAPBFFJI : ICGPHIAEBJC
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	DJOJCHCBLGD BDHPLEGMGNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool DDBCKCBOLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	GameObject LCHNDEILNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<FBHHAPBFFJI> NBNKCDGLNIJ;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(GKKDCNJAMAE GFHDGPOBABB, HIMFIAMFCKI JINDKOEKCIC);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool LLHOMMCNFFG);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class MMBKJFJMGCN
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA890", Offset = "0x5EF9490", VA = "0x185EFA890")]
	public static bool KCLJBIMOOBA(this FBHHAPBFFJI BKEHCHKFFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA8E0", Offset = "0x5EF94E0", VA = "0x185EFA8E0")]
	public static bool OOLHIPLCMCH(this FBHHAPBFFJI BKEHCHKFFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA7B0", Offset = "0x5EF93B0", VA = "0x185EFA7B0")]
	public static bool BMJMAPKANBO(this FBHHAPBFFJI BKEHCHKFFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA800", Offset = "0x5EF9400", VA = "0x185EFA800")]
	public static bool CBOMGKLCBDN(this FBHHAPBFFJI BKEHCHKFFLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface ICGPHIAEBJC
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool BKIHKFDKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
internal interface JFKMOPNENBD
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<CFDOHIKNPFG> MBMDKJBCHAI;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface GNMPENBCDCF : FLGMIPMLEND<LCHFDJFHJHJ>, HCMJODNHOFK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface NHEAKDNHEGD<T> : LOICEEOFGMA<LCHFDJFHJHJ, T>, FLGMIPMLEND<LCHFDJFHJHJ>, HCMJODNHOFK, IDisposable, GNMPENBCDCF where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PNIDNEKHHKH
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x26662A0", Offset = "0x2664EA0", VA = "0x1826662A0")]
	public static bool ELLDKPBLMHI<T>(this FLGMIPMLEND<LCHFDJFHJHJ> IEIEKFIPLEG, LCHFDJFHJHJ EJBFBHCOFGB, [Out] T GCPEEAODAIB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2353340", Offset = "0x2351F40", VA = "0x182353340")]
	public static bool INLCAGHFLDH<T>(this FLGMIPMLEND<LCHFDJFHJHJ> IEIEKFIPLEG, LCHFDJFHJHJ EJBFBHCOFGB, [In] T CGEKFJOFDCO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EBIPFMJOBLI : FLGMIPMLEND<HIMFIAMFCKI>, HCMJODNHOFK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface ONHFPDLBKAI<T> : LOICEEOFGMA<HIMFIAMFCKI, T>, FLGMIPMLEND<HIMFIAMFCKI>, HCMJODNHOFK, IDisposable, EBIPFMJOBLI where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FKBFJGCMBLI
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x22D3060", Offset = "0x22D1C60", VA = "0x1822D3060")]
	public static T IOOJPMIEEDI<T>(this FLGMIPMLEND<HIMFIAMFCKI> IEIEKFIPLEG, HIMFIAMFCKI JMADFINDJPP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2353300", Offset = "0x2351F00", VA = "0x182353300")]
	public static bool INLCAGHFLDH<T>(this FLGMIPMLEND<HIMFIAMFCKI> IEIEKFIPLEG, HIMFIAMFCKI JMADFINDJPP, [In] T CGEKFJOFDCO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DKCNINGMOLC : IComparable<DKCNINGMOLC>, IEquatable<DKCNINGMOLC>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly DKCNINGMOLC PHKLJCNEMGA;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly DKCNINGMOLC LMAHKIMMOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly DKCNINGMOLC DHAGDKNACPB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly DKCNINGMOLC LGCHELEKFCC;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly DKCNINGMOLC NKCNHBEGNCO;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly DKCNINGMOLC EOEJPNNJCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int EJAAMOHLDLD;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool ACFDOCFIEII
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEA10", Offset = "0x5EED610", VA = "0x185EEEA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int CFLFMMKNHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEA00", Offset = "0x5EED600", VA = "0x185EEEA00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x85B580", Offset = "0x85A180", VA = "0x18085B580")]
	public DKCNINGMOLC(int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE9A0", Offset = "0x5EED5A0", VA = "0x185EEE9A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE920", Offset = "0x5EED520", VA = "0x185EEE920", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EC780", Offset = "0x7EB380", VA = "0x1807EC780", Slot = "5")]
	public bool Equals(DKCNINGMOLC LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1719350", Offset = "0x1717F50", VA = "0x181719350", Slot = "4")]
	public int CompareTo(DKCNINGMOLC LLMHBOEDHFP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xD68740", Offset = "0xD67340", VA = "0x180D68740")]
	public static DKCNINGMOLC JLFJLFEACJM(int DCGGFHOCGGH)
	{
		return default(DKCNINGMOLC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xD68740", Offset = "0xD67340", VA = "0x180D68740")]
	public static int JLFJLFEACJM(DKCNINGMOLC MGCLAKBCFBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEA20", Offset = "0x5EED620", VA = "0x185EEEA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct JMFPDKOILML : IEquatable<JMFPDKOILML>, ICGPHIAEBJC
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly JMFPDKOILML MGNOCMJIIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910", Slot = "6")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public JGDAFJAGLHK AEEFBILMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JGDAFJAGLHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public PJOHPMICMAD AHHFEGHKCLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(PJOHPMICMAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public GameObject LCHNDEILNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9740", Offset = "0x5EF8340", VA = "0x185EF9740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public LCHFDJFHJHJ AENPBAGOOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8FC0", Offset = "0x5EF7BC0", VA = "0x185EF8FC0")]
		get
		{
			return default(LCHFDJFHJHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public LHIDJJOMBAL IGMANOGNFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5EF90F0", Offset = "0x5EF7CF0", VA = "0x185EF90F0")]
		get
		{
			return default(LHIDJJOMBAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public LGFPBEODEOP BKCGLAGDABP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9570", Offset = "0x5EF8170", VA = "0x185EF9570")]
		get
		{
			return default(LGFPBEODEOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool KEBMALIDLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9610", Offset = "0x5EF8210", VA = "0x185EF9610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool AJGDODNLELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8E70", Offset = "0x5EF7A70", VA = "0x185EF8E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool HLEBOJBMONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9630", Offset = "0x5EF8230", VA = "0x185EF9630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool FHOPEHLCDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5EF96F0", Offset = "0x5EF82F0", VA = "0x185EF96F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool PMHBPLOJOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9650", Offset = "0x5EF8250", VA = "0x185EF9650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool EHIBMJECPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5EF91E0", Offset = "0x5EF7DE0", VA = "0x185EF91E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool DHEMNKFCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8E30", Offset = "0x5EF7A30", VA = "0x185EF8E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool CLMFAJFACHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9310", Offset = "0x5EF7F10", VA = "0x185EF9310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public DHOMBJIMPIA NFFNGDABHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(DHOMBJIMPIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public HHJGJGEAJJO DNBOAAJDPDO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HHJGJGEAJJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public MABLMBMOGGB EIMFKNIAKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(MABLMBMOGGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public GJEMPNDEDEK BEBAKCLDADN
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(GJEMPNDEDEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public JAFALNHPJAC LNKJCMJLNLH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JAFALNHPJAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public KMFLDJDAKMA PMDHBCFJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(KMFLDJDAKMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public DLBPDJGOHPH NLMOEIMEKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(DLBPDJGOHPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public IPFOGFCCCBO IPODNNGIEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(IPFOGFCCCBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool KCLJBIMOOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9220", Offset = "0x5EF7E20", VA = "0x185EF9220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool FFNNMCHAALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9530", Offset = "0x5EF8130", VA = "0x185EF9530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool MNIDJDEHAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8E90", Offset = "0x5EF7A90", VA = "0x185EF8E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	private bool EFJDJCEIJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public JMFPDKOILML(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC20", Offset = "0x5EEB820", VA = "0x185EECC20")]
	public static bool JLFJLFEACJM(JMFPDKOILML GCPEEAODAIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static HIMFIAMFCKI JLFJLFEACJM(JMFPDKOILML GCPEEAODAIB)
	{
		return default(HIMFIAMFCKI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EECE70", Offset = "0x5EEBA70", VA = "0x185EECE70")]
	public static bool JONBIHPGCCI(JMFPDKOILML FLGIINLNNEM, JMFPDKOILML KNDAEONALIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EF40D0", Offset = "0x5EF2CD0", VA = "0x185EF40D0")]
	public static bool JBDELPGDOBO(JMFPDKOILML FLGIINLNNEM, JMFPDKOILML KNDAEONALIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9060", Offset = "0x5EF7C60", VA = "0x185EF9060", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(JMFPDKOILML LLMHBOEDHFP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static JMFPDKOILML JLFJLFEACJM(HIMFIAMFCKI OEBOJHNMNBH)
	{
		return default(JMFPDKOILML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9670", Offset = "0x5EF8270", VA = "0x185EF9670")]
	public EIPLECJDKAJ MPHGAIDFFEP()
	{
		return default(EIPLECJDKAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9710", Offset = "0x5EF8310", VA = "0x185EF9710")]
	public NJHPGEHCKDM PBFKEKFANEM()
	{
		return default(NJHPGEHCKDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9190", Offset = "0x5EF7D90", VA = "0x185EF9190")]
	public GBICMDCOHJC HGIHOMGDHFO()
	{
		return default(GBICMDCOHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9420", Offset = "0x5EF8020", VA = "0x185EF9420")]
	public void KFBCNDBPIBH([Optional] object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9330", Offset = "0x5EF7F30", VA = "0x185EF9330")]
	public bool JNFFLAGAGKM(object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8ED0", Offset = "0x5EF7AD0", VA = "0x185EF8ED0")]
	public bool CMHLGENMDIF(object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EF98D0", Offset = "0x5EF84D0", VA = "0x185EF98D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct DLBPDJGOHPH : IEquatable<DLBPDJGOHPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private GMDOEGFMHEJ JMMFFGPKJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF0F0", Offset = "0x5EEDCF0", VA = "0x185EEF0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private KAPJLJPJBNO CLHBIHJFOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF090", Offset = "0x5EEDC90", VA = "0x185EEF090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool BJMNLBMEHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEE50", Offset = "0x5EEDA50", VA = "0x185EEEE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Guid GBAFOPKDNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEF70", Offset = "0x5EEDB70", VA = "0x185EEEF70")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public bool ODGEFLGDBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF340", Offset = "0x5EEDF40", VA = "0x185EEF340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Guid HIFHNPJELDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEB70", Offset = "0x5EED770", VA = "0x185EEEB70")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public DLBPDJGOHPH(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC20", Offset = "0x5EEB820", VA = "0x185EECC20")]
	public static bool JLFJLFEACJM(DLBPDJGOHPH GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEEE0", Offset = "0x5EEDAE0", VA = "0x185EEEEE0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(DLBPDJGOHPH LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEC90", Offset = "0x5EED890", VA = "0x185EEEC90")]
	public bool CHCLPJFFMND([Out] Guid EJECECMPMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEED30", Offset = "0x5EED930", VA = "0x185EEED30")]
	public void DNPPNJHAAMI(Guid FEGNLFKFNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF180", Offset = "0x5EEDD80", VA = "0x185EEF180")]
	public bool FMHAFKFFIEB([Out] Guid GKCGMEKGHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF220", Offset = "0x5EEDE20", VA = "0x185EEF220")]
	public void IAPOBPBOLPN(Guid FEGNLFKFNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF3D0", Offset = "0x5EEDFD0", VA = "0x185EEF3D0")]
	public void MIHDFJLLHCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct GBICMDCOHJC : IEquatable<GBICMDCOHJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private GMDOEGFMHEJ JMMFFGPKJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1740", Offset = "0x5EF0340", VA = "0x185EF1740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private EIPJMFAKKNI HCJHCMLLJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1520", Offset = "0x5EF0120", VA = "0x185EF1520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public float3 EJNCJNBMGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1610", Offset = "0x5EF0210", VA = "0x185EF1610")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public quaternion HOEMAALGABK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1860", Offset = "0x5EF0460", VA = "0x185EF1860")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public JMFPDKOILML GHLGOKCFFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF17D0", Offset = "0x5EF03D0", VA = "0x185EF17D0")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public GBICMDCOHJC(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static HIMFIAMFCKI JLFJLFEACJM(GBICMDCOHJC GCPEEAODAIB)
	{
		return default(HIMFIAMFCKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1580", Offset = "0x5EF0180", VA = "0x185EF1580", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(GBICMDCOHJC LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct EIPLECJDKAJ : IEquatable<EIPLECJDKAJ>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class IOMNBKOLONB : IEnumerable<JMFPDKOILML>, IEnumerable, IEnumerator<JMFPDKOILML>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private JMFPDKOILML <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public EIPLECJDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public EIPLECJDKAJ <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<JMFPDKOILML> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IEnumerator<HIMFIAMFCKI> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private JMFPDKOILML System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.RRObject>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x31E2B60", Offset = "0x31E1760", VA = "0x1831E2B60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JMFPDKOILML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x5EF4F90", Offset = "0x5EF3B90", VA = "0x185EF4F90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x330B500", Offset = "0x330A100", VA = "0x18330B500")]
		[DebuggerHidden]
		public IOMNBKOLONB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4FE0", Offset = "0x5EF3BE0", VA = "0x185EF4FE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4980", Offset = "0x5EF3580", VA = "0x185EF4980", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4930", Offset = "0x5EF3530", VA = "0x185EF4930")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5EF48E0", Offset = "0x5EF34E0", VA = "0x185EF48E0")]
		private void HAIPFOFCHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4890", Offset = "0x5EF3490", VA = "0x185EF4890")]
		private void BLEACDMIDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4F40", Offset = "0x5EF3B40", VA = "0x185EF4F40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4EA0", Offset = "0x5EF3AA0", VA = "0x185EF4EA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JMFPDKOILML> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.RRObject>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4EA0", Offset = "0x5EF3AA0", VA = "0x185EF4EA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly EIPLECJDKAJ MGNOCMJIIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public JGDAFJAGLHK AEEFBILMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JGDAFJAGLHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public PJOHPMICMAD AHHFEGHKCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(PJOHPMICMAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private GMDOEGFMHEJ JMMFFGPKJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFD80", Offset = "0x5EEE980", VA = "0x185EEFD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private EDOFJLFNBEH MEHPCHAEECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFFB0", Offset = "0x5EEEBB0", VA = "0x185EEFFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public HBBOGBDBNJL KACBKNEPMDC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFA90", Offset = "0x5EEE690", VA = "0x185EEFA90")]
		get
		{
			return default(HBBOGBDBNJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IEnumerable<JMFPDKOILML> JDAJBCIPDMM
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF860", Offset = "0x5EEE460", VA = "0x185EEF860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IEnumerable<JMFPDKOILML> KFJLJBJDGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF660", Offset = "0x5EEE260", VA = "0x185EEF660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int FGEMHGALJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFBB0", Offset = "0x5EEE7B0", VA = "0x185EEFBB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int CJMAPCEKACF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF09C0", Offset = "0x5EEF5C0", VA = "0x185EF09C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public string ODBDFCEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFCD0", Offset = "0x5EEE8D0", VA = "0x185EEFCD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFE80", Offset = "0x5EEEA80", VA = "0x185EEFE80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GFHGKAJKFGM EIJJJEKCFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5EF08F0", Offset = "0x5EEF4F0", VA = "0x185EF08F0")]
		get
		{
			return default(GFHGKAJKFGM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0810", Offset = "0x5EEF410", VA = "0x185EF0810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ABALNHFPMDH CFCKBLONBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF9D0", Offset = "0x5EEE5D0", VA = "0x185EEF9D0")]
		get
		{
			return default(ABALNHFPMDH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF790", Offset = "0x5EEE390", VA = "0x185EEF790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CPFOCDODPOM BIKOGIECLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFA30", Offset = "0x5EEE630", VA = "0x185EEFA30")]
		get
		{
			return default(CPFOCDODPOM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0010", Offset = "0x5EEEC10", VA = "0x185EF0010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public float JDPPAJKIKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF800", Offset = "0x5EEE400", VA = "0x185EEF800")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0410", Offset = "0x5EEF010", VA = "0x185EF0410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool EBEHMFCEJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF00F0", Offset = "0x5EEECF0", VA = "0x185EF00F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool IPPLDDKNBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0950", Offset = "0x5EEF550", VA = "0x185EF0950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool LLFIPLHLMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0080", Offset = "0x5EEEC80", VA = "0x185EF0080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool CFGFGPCCGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0880", Offset = "0x5EEF480", VA = "0x185EF0880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool OJLGOINCPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFF50", Offset = "0x5EEEB50", VA = "0x185EEFF50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFE10", Offset = "0x5EEEA10", VA = "0x185EEFE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool ACGBHFBOFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFB50", Offset = "0x5EEE750", VA = "0x185EEFB50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5EF07A0", Offset = "0x5EEF3A0", VA = "0x185EF07A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public EIPLECJDKAJ(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC20", Offset = "0x5EEB820", VA = "0x185EECC20")]
	public static bool JLFJLFEACJM(EIPLECJDKAJ GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFC40", Offset = "0x5EEE840", VA = "0x185EEFC40", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(EIPLECJDKAJ LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static JMFPDKOILML JLFJLFEACJM(EIPLECJDKAJ PCOJMOHPOND)
	{
		return default(JMFPDKOILML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFF30", Offset = "0x5EEEB30", VA = "0x185EEFF30")]
	public bool HFKHJMFCHFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0730", Offset = "0x5EEF330", VA = "0x185EF0730")]
	public bool NHNLNIAJCHM(JPEPEFFLGDM PELFNJFDMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5EF01E0", Offset = "0x5EEEDE0", VA = "0x185EF01E0")]
	public void MFFCFINEPGJ(JPEPEFFLGDM PELFNJFDMPH, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0260", Offset = "0x5EEEE60", VA = "0x185EF0260")]
	public HBBOGBDBNJL MKAJBNECPFB(Allocator NOFANFDHPGP)
	{
		return default(HBBOGBDBNJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0480", Offset = "0x5EEF080", VA = "0x185EF0480")]
	public void NGNOGLAHAAD(EIPLECJDKAJ LLMHBOEDHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0160", Offset = "0x5EEED60", VA = "0x185EF0160")]
	[IteratorStateMachine(typeof(IOMNBKOLONB))]
	public IEnumerable<JMFPDKOILML> LPJGLGGLOHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct PANNCAAGLPH : IEquatable<PANNCAAGLPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC120", Offset = "0x5EFAD20", VA = "0x185EFC120", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(PANNCAAGLPH LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct HHJGJGEAJJO : IEquatable<HHJGJGEAJJO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public HHJGJGEAJJO(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3AF0", Offset = "0x5EF26F0", VA = "0x185EF3AF0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(HHJGJGEAJJO LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3B80", Offset = "0x5EF2780", VA = "0x185EF3B80")]
	public void HBPPMPIFHCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3C20", Offset = "0x5EF2820", VA = "0x185EF3C20")]
	public void JKNBMCINGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct JFAJPAIKMFF : IEquatable<JFAJPAIKMFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5FB0", Offset = "0x5EF4BB0", VA = "0x185EF5FB0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(JFAJPAIKMFF LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct BJGBKNGFFJG : IEquatable<BJGBKNGFFJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5EED130", Offset = "0x5EEBD30", VA = "0x185EED130", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(BJGBKNGFFJG LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct DJPMANMJJDO : IEquatable<DJPMANMJJDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE890", Offset = "0x5EED490", VA = "0x185EEE890", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(DJPMANMJJDO LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct CDPFAAGBCKP : IEquatable<CDPFAAGBCKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5EED220", Offset = "0x5EEBE20", VA = "0x185EED220", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(CDPFAAGBCKP LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct PJOHPMICMAD : IEquatable<PJOHPMICMAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private GMDOEGFMHEJ JMMFFGPKJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EFC7C0", Offset = "0x5EFB3C0", VA = "0x185EFC7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private EDOFJLFNBEH MEHPCHAEECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EFC980", Offset = "0x5EFB580", VA = "0x185EFC980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public HIMFIAMFCKI IMBNAELJKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5EFCAD0", Offset = "0x5EFB6D0", VA = "0x185EFCAD0")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JMFPDKOILML OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EFC9E0", Offset = "0x5EFB5E0", VA = "0x185EFC9E0")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public JMFPDKOILML EGCFCBLCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5EFC370", Offset = "0x5EFAF70", VA = "0x185EFC370")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public PJOHPMICMAD(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC730", Offset = "0x5EFB330", VA = "0x185EFC730", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(PJOHPMICMAD LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC850", Offset = "0x5EFB450", VA = "0x185EFC850")]
	public bool GMIJDPBCEJN(JMFPDKOILML HHNAEDAPOHF, bool GMJNMOGBNNG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC400", Offset = "0x5EFB000", VA = "0x185EFC400")]
	public bool CFIAKNIABOF(JMFPDKOILML HLMGOHOFLBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC4A0", Offset = "0x5EFB0A0", VA = "0x185EFC4A0")]
	private void EDEDMLKDDIC(JMFPDKOILML OPONEOBEGCP, List<JMFPDKOILML> EAOLHGLJOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EFCA70", Offset = "0x5EFB670", VA = "0x185EFCA70")]
	public void MBDHKIJOHJD(List<JMFPDKOILML> IKEFNPMNAMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct DHOMBJIMPIA : IEquatable<DHOMBJIMPIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string GABNJEJFCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE530", Offset = "0x5EED130", VA = "0x185EEE530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public string BMJCCLGEHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE460", Offset = "0x5EED060", VA = "0x185EEE460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private bool CHMHGGLDNFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE750", Offset = "0x5EED350", VA = "0x185EEE750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string EDKAIAHPEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE660", Offset = "0x5EED260", VA = "0x185EEE660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string FEMFEHECCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE210", Offset = "0x5EECE10", VA = "0x185EEE210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string FALPMHCJNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE5B0", Offset = "0x5EED1B0", VA = "0x185EEE5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public DHOMBJIMPIA(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE180", Offset = "0x5EECD80", VA = "0x185EEE180", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(DHOMBJIMPIA LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDBB0", Offset = "0x5EEC7B0", VA = "0x185EEDBB0")]
	private static string CMAHAANFOOD(LGFPBEODEOP GOEKDPAGMAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct PHLPNECCGCI : IEquatable<PHLPNECCGCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC2E0", Offset = "0x5EFAEE0", VA = "0x185EFC2E0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(PHLPNECCGCI LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct MABLMBMOGGB : IEquatable<MABLMBMOGGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public MABLMBMOGGB(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA0D0", Offset = "0x5EF8CD0", VA = "0x185EFA0D0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(MABLMBMOGGB LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA160", Offset = "0x5EF8D60", VA = "0x185EFA160")]
	public bool NNMFMDIEECK([Out] Collider JANMHBBPKAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct GJEMPNDEDEK : IEquatable<GJEMPNDEDEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private GMDOEGFMHEJ JMMFFGPKJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5EF22B0", Offset = "0x5EF0EB0", VA = "0x185EF22B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private OEMGBJPOCJK NAMIJCFIHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2010", Offset = "0x5EF0C10", VA = "0x185EF2010")]
		get
		{
			return default(OEMGBJPOCJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private MEDOOKCPEOJ OKMDAAKDCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EF28F0", Offset = "0x5EF14F0", VA = "0x185EF28F0")]
		get
		{
			return default(MEDOOKCPEOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool FDGANKJKLNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1C00", Offset = "0x5EF0800", VA = "0x185EF1C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool CGLHLGDCJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1E00", Offset = "0x5EF0A00", VA = "0x185EF1E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool DKCEECGPDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2430", Offset = "0x5EF1030", VA = "0x185EF2430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool MPAMEOJBJNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2510", Offset = "0x5EF1110", VA = "0x185EF2510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool DPLIEFGAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2070", Offset = "0x5EF0C70", VA = "0x185EF2070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool HMJICJGOPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1D90", Offset = "0x5EF0990", VA = "0x185EF1D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool IOFLFHDJHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2580", Offset = "0x5EF1180", VA = "0x185EF2580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool FNDOLOJJMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5EF25F0", Offset = "0x5EF11F0", VA = "0x185EF25F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool FPGCMODKOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2880", Offset = "0x5EF1480", VA = "0x185EF2880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool LALOKMOKOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5EF24A0", Offset = "0x5EF10A0", VA = "0x185EF24A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool KOEBPJBKACF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1CB0", Offset = "0x5EF08B0", VA = "0x185EF1CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool MMABKOAADLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5EF21E0", Offset = "0x5EF0DE0", VA = "0x185EF21E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool HJKHINOBEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1E70", Offset = "0x5EF0A70", VA = "0x185EF1E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool HKGGJHOEPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1C40", Offset = "0x5EF0840", VA = "0x185EF1C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool HKLDAHKLAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2660", Offset = "0x5EF1260", VA = "0x185EF2660")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EF20E0", Offset = "0x5EF0CE0", VA = "0x185EF20E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public FANFPFCHADK KDEAEMGJEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1FB0", Offset = "0x5EF0BB0", VA = "0x185EF1FB0")]
		get
		{
			return default(FANFPFCHADK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2950", Offset = "0x5EF1550", VA = "0x185EF2950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool CCIJPIHBKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5EF29C0", Offset = "0x5EF15C0", VA = "0x185EF29C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public HAEEMLMCOBG NOMCBOPNHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2B90", Offset = "0x5EF1790", VA = "0x185EF2B90")]
		get
		{
			return default(HAEEMLMCOBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool NKJFEEEJGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2250", Offset = "0x5EF0E50", VA = "0x185EF2250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 KGHELBCDOOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1EE0", Offset = "0x5EF0AE0", VA = "0x185EF1EE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 IHNJBCOPNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EF26D0", Offset = "0x5EF12D0", VA = "0x185EF26D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool DLILMJAPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2780", Offset = "0x5EF1380", VA = "0x185EF2780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public GJEMPNDEDEK(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2150", Offset = "0x5EF0D50", VA = "0x185EF2150", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(GJEMPNDEDEK LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1D20", Offset = "0x5EF0920", VA = "0x185EF1D20")]
	public bool BJAICABGPED(DIKHKFBIDHP PELFNJFDMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5EF23C0", Offset = "0x5EF0FC0", VA = "0x185EF23C0")]
	public bool HIKINIKJLJO(BOCEJMGJIJI PELFNJFDMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2340", Offset = "0x5EF0F40", VA = "0x185EF2340")]
	public void GLENKJPAAAP(BOCEJMGJIJI PELFNJFDMPH, bool LPOCOBOKBAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct KMFLDJDAKMA : IEquatable<KMFLDJDAKMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private GMDOEGFMHEJ JMMFFGPKJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9A40", Offset = "0x5EF8640", VA = "0x185EF9A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public KMFLDJDAKMA(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5EF99B0", Offset = "0x5EF85B0", VA = "0x185EF99B0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(KMFLDJDAKMA LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9B60", Offset = "0x5EF8760", VA = "0x185EF9B60")]
	public void LHLPJIFIFHD(bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9AD0", Offset = "0x5EF86D0", VA = "0x185EF9AD0")]
	public void HPODBCELHAA(bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x256EE50", Offset = "0x256DA50", VA = "0x18256EE50")]
	public T PPMDFNINANF<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct JAFALNHPJAC : IEquatable<JAFALNHPJAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private GMDOEGFMHEJ JMMFFGPKJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5EF59D0", Offset = "0x5EF45D0", VA = "0x185EF59D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private FMDJJFNGDFG FJCCEBLPJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5A60", Offset = "0x5EF4660", VA = "0x185EF5A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private BOMPPIOAEFC PFCHMFJEAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5B50", Offset = "0x5EF4750", VA = "0x185EF5B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool NGKCIKCKPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5AC0", Offset = "0x5EF46C0", VA = "0x185EF5AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool EGEOFHAFPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5490", Offset = "0x5EF4090", VA = "0x185EF5490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool PCNMCENGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5F80", Offset = "0x5EF4B80", VA = "0x185EF5F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool ACPKGKIAOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5900", Offset = "0x5EF4500", VA = "0x185EF5900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool LGELHCGKPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5DE0", Offset = "0x5EF49E0", VA = "0x185EF5DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool MEIJEIKMMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5870", Offset = "0x5EF4470", VA = "0x185EF5870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool AFEPMAFAOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5530", Offset = "0x5EF4130", VA = "0x185EF5530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool IJLNNPCHNNO
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5E10", Offset = "0x5EF4A10", VA = "0x185EF5E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public JAFALNHPJAC(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC20", Offset = "0x5EEB820", VA = "0x185EECC20")]
	public static bool JLFJLFEACJM(JAFALNHPJAC GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5EF57E0", Offset = "0x5EF43E0", VA = "0x185EF57E0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(JAFALNHPJAC LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5BB0", Offset = "0x5EF47B0", VA = "0x185EF5BB0")]
	public bool MLLAOFHKLCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5740", Offset = "0x5EF4340", VA = "0x185EF5740")]
	public JMFPDKOILML EONGMPCBEGC(JMFPDKOILML JIGKIEPHJOJ)
	{
		return default(JMFPDKOILML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5CD0", Offset = "0x5EF48D0", VA = "0x185EF5CD0")]
	public HIMFIAMFCKI NCBNMDBBJOG()
	{
		return default(HIMFIAMFCKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5360", Offset = "0x5EF3F60", VA = "0x185EF5360")]
	public void ABIIBIADMDN(HIMFIAMFCKI JIGKIEPHJOJ, HIMFIAMFCKI LIJPJPLCIHM, HIMFIAMFCKI FPFIDHIDANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct NJHPGEHCKDM : IEquatable<NJHPGEHCKDM>
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly NJHPGEHCKDM MGNOCMJIIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public JGDAFJAGLHK AEEFBILMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JGDAFJAGLHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private MDGDNGIBEML JJLCPCAFOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5EFB100", Offset = "0x5EF9D00", VA = "0x185EFB100")]
		get
		{
			return default(MDGDNGIBEML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public BHFNDEOFJBF NJNPOPIKCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAEA0", Offset = "0x5EF9AA0", VA = "0x185EFAEA0")]
		get
		{
			return default(BHFNDEOFJBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public HMEODMMHLLB GBONNOJMONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAA00", Offset = "0x5EF9600", VA = "0x185EFAA00")]
		get
		{
			return default(HMEODMMHLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public BKHGLLEGFLA CJPEGEDIHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAF00", Offset = "0x5EF9B00", VA = "0x185EFAF00")]
		get
		{
			return default(BKHGLLEGFLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public KLIBJIMJNHI PJMGCGGGHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5EFABC0", Offset = "0x5EF97C0", VA = "0x185EFABC0")]
		get
		{
			return default(KLIBJIMJNHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public HPOFGPIKEKI CNEODCOCNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5EFB0A0", Offset = "0x5EF9CA0", VA = "0x185EFB0A0")]
		get
		{
			return default(HPOFGPIKEKI);
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5EFA930", Offset = "0x5EF9530", VA = "0x185EFA930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public AEEGCPHNDCI EHABNMABMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAA60", Offset = "0x5EF9660", VA = "0x185EFAA60")]
		get
		{
			return default(AEEGCPHNDCI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAF60", Offset = "0x5EF9B60", VA = "0x185EFAF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public float MIONMLMOHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5EFB040", Offset = "0x5EF9C40", VA = "0x185EFB040")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5EFACB0", Offset = "0x5EF98B0", VA = "0x185EFACB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 BMLMHFLLGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAB40", Offset = "0x5EF9740", VA = "0x185EFAB40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAD90", Offset = "0x5EF9990", VA = "0x185EFAD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public float MCLKKDKCCHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAD20", Offset = "0x5EF9920", VA = "0x185EFAD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public MIDHFOFIIGO.POGNHNHFAGB GNPDGMKFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5EFA9A0", Offset = "0x5EF95A0", VA = "0x185EFA9A0")]
		get
		{
			return default(MIDHFOFIIGO.POGNHNHFAGB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAFD0", Offset = "0x5EF9BD0", VA = "0x185EFAFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public NJHPGEHCKDM(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC20", Offset = "0x5EEB820", VA = "0x185EECC20")]
	public static bool JLFJLFEACJM(NJHPGEHCKDM GCPEEAODAIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5EF40D0", Offset = "0x5EF2CD0", VA = "0x185EF40D0")]
	public static bool JBDELPGDOBO(NJHPGEHCKDM FLGIINLNNEM, NJHPGEHCKDM KNDAEONALIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5EFAE10", Offset = "0x5EF9A10", VA = "0x185EFAE10", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(NJHPGEHCKDM LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5EFAC30", Offset = "0x5EF9830", VA = "0x185EFAC30")]
	public LMLDMPADLCM DBLGDMJFPIE()
	{
		return default(LMLDMPADLCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5EFAAC0", Offset = "0x5EF96C0", VA = "0x185EFAAC0")]
	public BIFBFBIDBEG CDFOCEEFEDB()
	{
		return default(BIFBFBIDBEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct LMLDMPADLCM : IEquatable<LMLDMPADLCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public NJHPGEHCKDM FHMHCDHFCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(NJHPGEHCKDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private JPBMHOKJOFM FDPLLAENAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9F80", Offset = "0x5EF8B80", VA = "0x185EF9F80")]
		get
		{
			return default(JPBMHOKJOFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public DGEEPCMBCIA DFGFONIONDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5EFA070", Offset = "0x5EF8C70", VA = "0x185EFA070")]
		get
		{
			return default(DGEEPCMBCIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public LMLDMPADLCM(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC20", Offset = "0x5EEB820", VA = "0x185EECC20")]
	public static bool JLFJLFEACJM(LMLDMPADLCM GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9FE0", Offset = "0x5EF8BE0", VA = "0x185EF9FE0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(LMLDMPADLCM LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public readonly struct BIFBFBIDBEG : IEquatable<BIFBFBIDBEG>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly BIFBFBIDBEG MGNOCMJIIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public JGDAFJAGLHK AEEFBILMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JGDAFJAGLHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private GMDOEGFMHEJ JMMFFGPKJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC8E0", Offset = "0x5EEB4E0", VA = "0x185EEC8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private HIIJOGNCNMH HAEANBLPGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC880", Offset = "0x5EEB480", VA = "0x185EEC880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public NJHPGEHCKDM FHMHCDHFCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(NJHPGEHCKDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public EDNJPEBBPFN FIDDNANIGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5EECAF0", Offset = "0x5EEB6F0", VA = "0x185EECAF0")]
		get
		{
			return default(EDNJPEBBPFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5EED010", Offset = "0x5EEBC10", VA = "0x185EED010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public IEnumerable<AHFMMIHGOFK> FMNLGDJBHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5EECE80", Offset = "0x5EEBA80", VA = "0x185EECE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public AHFMMIHGOFK NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC3B0", Offset = "0x5EEAFB0", VA = "0x185EEC3B0")]
		get
		{
			return default(AHFMMIHGOFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC970", Offset = "0x5EEB570", VA = "0x185EEC970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public BIFBFBIDBEG(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC20", Offset = "0x5EEB820", VA = "0x185EECC20")]
	public static bool JLFJLFEACJM(BIFBFBIDBEG GCPEEAODAIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5EECE70", Offset = "0x5EEBA70", VA = "0x185EECE70")]
	public static bool JONBIHPGCCI(BIFBFBIDBEG FLGIINLNNEM, BIFBFBIDBEG KNDAEONALIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC7F0", Offset = "0x5EEB3F0", VA = "0x185EEC7F0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(BIFBFBIDBEG LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC5D0", Offset = "0x5EEB1D0", VA = "0x185EEC5D0")]
	public AHFMMIHGOFK ECPKJCOHHNL(float3? CFCLFCDKKPD, [Optional] quaternion? HFKFMHAMLPE, [Optional] Vector3? JIFOIDNONIC)
	{
		return default(AHFMMIHGOFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC40", Offset = "0x5EEB840", VA = "0x185EECC40")]
	public AHFMMIHGOFK JNBPJJIDHKJ(int DCGGFHOCGGH, float3? CFCLFCDKKPD, [Optional] quaternion? HFKFMHAMLPE, [Optional] Vector3? JIFOIDNONIC)
	{
		return default(AHFMMIHGOFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC4C0", Offset = "0x5EEB0C0", VA = "0x185EEC4C0")]
	public void DPAIMFGPBJL(int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5EECA00", Offset = "0x5EEB600", VA = "0x185EECA00")]
	public void GMINFKPEKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct AHFMMIHGOFK : IEquatable<AHFMMIHGOFK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public BIFBFBIDBEG MDGEFHKNCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5EEBC30", Offset = "0x5EEA830", VA = "0x185EEBC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public float3 DFDHGFBBAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5EEBEF0", Offset = "0x5EEAAF0", VA = "0x185EEBEF0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC180", Offset = "0x5EEAD80", VA = "0x185EEC180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public quaternion GGBPFGKEGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC100", Offset = "0x5EEAD00", VA = "0x185EEC100")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5EEBF70", Offset = "0x5EEAB70", VA = "0x185EEBF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float3 PKMIIFNMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEBD40", Offset = "0x5EEA940", VA = "0x185EEBD40")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEBCC0", Offset = "0x5EEA8C0", VA = "0x185EEBCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public ACJOHOEJBGA ACOCAAIPDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC200", Offset = "0x5EEAE00", VA = "0x185EEC200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private PCFEJFEAPKG HCLIDLGELBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEBDC0", Offset = "0x5EEA9C0", VA = "0x185EEBDC0")]
		get
		{
			return default(PCFEJFEAPKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private AFODFBFCMGB LCAPMINOMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC040", Offset = "0x5EEAC40", VA = "0x185EEC040")]
		get
		{
			return default(AFODFBFCMGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private HHCKNBIKKHM NCOENOPAMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC0A0", Offset = "0x5EEACA0", VA = "0x185EEC0A0")]
		get
		{
			return default(HHCKNBIKKHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private JOKEDCENMAA ECONPACLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5EEBFE0", Offset = "0x5EEABE0", VA = "0x185EEBFE0")]
		get
		{
			return default(JOKEDCENMAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private HANLABPNDNI NELNKLNFEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC270", Offset = "0x5EEAE70", VA = "0x185EEC270")]
		get
		{
			return default(HANLABPNDNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public AHFMMIHGOFK(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE30", Offset = "0x5EEAA30", VA = "0x185EEBE30", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(AHFMMIHGOFK LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBC30", Offset = "0x5EEA830", VA = "0x185EEBC30")]
	public void BAIGCGKEECD(BIFBFBIDBEG GCPEEAODAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct JGDAFJAGLHK : IEquatable<JGDAFJAGLHK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public PJOHPMICMAD AHHFEGHKCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(PJOHPMICMAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private FLPNJHKLIHG JICFADNLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5EECA90", Offset = "0x5EEB690", VA = "0x185EECA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private MNPEJCNPPGJ KBJJPJCBAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7A50", Offset = "0x5EF6650", VA = "0x185EF7A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool IHNOMNOPLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6360", Offset = "0x5EF4F60", VA = "0x185EF6360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 DFDHGFBBAKG
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF71D0", Offset = "0x5EF5DD0", VA = "0x185EF71D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7EF0", Offset = "0x5EF6AF0", VA = "0x185EF7EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Quaternion GGBPFGKEGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7CB0", Offset = "0x5EF68B0", VA = "0x185EF7CB0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7790", Offset = "0x5EF6390", VA = "0x185EF7790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 BDHADAPDDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6270", Offset = "0x5EF4E70", VA = "0x185EF6270")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5EF72C0", Offset = "0x5EF5EC0", VA = "0x185EF72C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Quaternion EEHOPJHJAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5EF63A0", Offset = "0x5EF4FA0", VA = "0x185EF63A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7030", Offset = "0x5EF5C30", VA = "0x185EF7030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public float IOPDOGALHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7480", Offset = "0x5EF6080", VA = "0x185EF7480")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7520", Offset = "0x5EF6120", VA = "0x185EF7520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float BLIGPHJJDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6E40", Offset = "0x5EF5A40", VA = "0x185EF6E40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public Vector3 PKMIIFNMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6920", Offset = "0x5EF5520", VA = "0x185EF6920")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF64F0", Offset = "0x5EF50F0", VA = "0x185EF64F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 KLGKPNOHJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6690", Offset = "0x5EF5290", VA = "0x185EF6690")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Matrix4x4 CKGOGBNIDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6230", Offset = "0x5EF4E30", VA = "0x185EF6230")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public JGDAFJAGLHK(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6C40", Offset = "0x5EF5840", VA = "0x185EF6C40", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(JGDAFJAGLHK LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF81F0", Offset = "0x5EF6DF0", VA = "0x185EF81F0")]
	public GFBGHCLLDBK PGIBLHHDOGA()
	{
		return default(GFBGHCLLDBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6110", Offset = "0x5EF4D10", VA = "0x185EF6110")]
	public void AMMOAEFHIGO([Out] Matrix4x4 NBIONLPNBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6A10", Offset = "0x5EF5610", VA = "0x185EF6A10")]
	public void ECKLDPBHIGA([Out] Vector3 ACHKEKNKANF, [Out] Quaternion IOJIIGDLCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7FC0", Offset = "0x5EF6BC0", VA = "0x185EF7FC0")]
	public void MIKAGMLFOIO([Out] RigidTransform KKFBDEKDEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6B50", Offset = "0x5EF5750", VA = "0x185EF6B50")]
	public MHCAHIBICII EJBHIOBEBFC()
	{
		return default(MHCAHIBICII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6B80", Offset = "0x5EF5780", VA = "0x185EF6B80")]
	public void EJBHIOBEBFC([Out] MHCAHIBICII HBDIHLKKHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8300", Offset = "0x5EF6F00", VA = "0x185EF8300")]
	public MHCAHIBICII PLGLKAMGJAH()
	{
		return default(MHCAHIBICII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8240", Offset = "0x5EF6E40", VA = "0x185EF8240")]
	public void PLGLKAMGJAH([Out] MHCAHIBICII KKFBDEKDEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7E00", Offset = "0x5EF6A00", VA = "0x185EF7E00")]
	public Vector3 MGEIMJJKAEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8120", Offset = "0x5EF6D20", VA = "0x185EF8120")]
	public void OMLNLHMNDAC([In] Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8330", Offset = "0x5EF6F30", VA = "0x185EF8330")]
	public Vector3 PLNBIOKKPMD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6040", Offset = "0x5EF4C40", VA = "0x185EF6040")]
	public void AKADPBHHLMP([In] Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7860", Offset = "0x5EF6460", VA = "0x185EF7860")]
	public Quaternion JCKNKDNIOMK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x5EF75D0", Offset = "0x5EF61D0", VA = "0x185EF75D0")]
	public void IDMEAMEAHDJ([In] Quaternion GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6EE0", Offset = "0x5EF5AE0", VA = "0x185EF6EE0")]
	public Quaternion FPPHKGIMJOD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7B10", Offset = "0x5EF6710", VA = "0x185EF7B10")]
	public void LIPHCAOMFPC([In] Quaternion GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF79B0", Offset = "0x5EF65B0", VA = "0x185EF79B0")]
	public float KFBMEFPAMHM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6780", Offset = "0x5EF5380", VA = "0x185EF6780")]
	public void CMINFFPNOAI(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6CD0", Offset = "0x5EF58D0", VA = "0x185EF6CD0")]
	public float FBAGKNGOEHH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8070", Offset = "0x5EF6C70", VA = "0x185EF8070")]
	public void MKMFCMCGBEF(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7100", Offset = "0x5EF5D00", VA = "0x185EF7100")]
	public void HCGFGDIBNBJ([In] Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5EF76A0", Offset = "0x5EF62A0", VA = "0x185EF76A0")]
	public Vector3 IGNEFPOHNJF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7BE0", Offset = "0x5EF67E0", VA = "0x185EF7BE0")]
	public void LLDCBLJEABD([In] Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7390", Offset = "0x5EF5F90", VA = "0x185EF7390")]
	public Vector3 HOGJAIMPCDL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6D70", Offset = "0x5EF5970", VA = "0x185EF6D70")]
	public void FOFOOGBOCGE([In] Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6830", Offset = "0x5EF5430", VA = "0x185EF6830")]
	public Vector3 DBCBKDLLEFD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5EF65C0", Offset = "0x5EF51C0", VA = "0x185EF65C0")]
	public void CFHMHLOIKMB([In] Vector3 GCPEEAODAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct IPFOGFCCCBO : IEquatable<IPFOGFCCCBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public JMFPDKOILML IHJIEFCHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
		get
		{
			return default(JMFPDKOILML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public int[] FAIMFECAFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5270", Offset = "0x5EF3E70", VA = "0x185EF5270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
	public IPFOGFCCCBO(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBEC0", Offset = "0x5EEAAC0", VA = "0x185EEBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF51E0", Offset = "0x5EF3DE0", VA = "0x185EF51E0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE20", Offset = "0x5EEAA20", VA = "0x185EEBE20", Slot = "4")]
	public bool Equals(IPFOGFCCCBO LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2D0", Offset = "0x5EEAED0", VA = "0x185EEC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class OLDJODFFJCM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct IAELEFJGGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Guid OGCEPACDHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ELAALPFIHOB NLCCGHLLGDO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct ELAALPFIHOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int GCPEEAODAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int PLJJHGKLMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int NOPJOFJIKBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int DGLLOJOIGBG;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0A10", Offset = "0x5EEF610", VA = "0x185EF0A10")]
		public bool FNLDGMLJFPE([Out] LCHFDJFHJHJ EJBFBHCOFGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0A90", Offset = "0x5EEF690", VA = "0x185EF0A90")]
		public ELAALPFIHOB(LCHFDJFHJHJ EJBFBHCOFGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC070", Offset = "0x5EFAC70", VA = "0x185EFC070")]
	public static Guid JLIOFEDJHBI(this LCHFDJFHJHJ EJBFBHCOFGB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC100", Offset = "0x5EFAD00", VA = "0x185EFC100")]
	public static bool JNCGCFPAFFP(this Guid OGCEPACDHOE, [Out] LCHFDJFHJHJ EJBFBHCOFGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class CEOKHIGKOCH
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5EED380", Offset = "0x5EEBF80", VA = "0x185EED380")]
	public static GMDOEGFMHEJ JMMFFGPKJLN(this HIMFIAMFCKI HLINMGJJNHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5EED2B0", Offset = "0x5EEBEB0", VA = "0x185EED2B0")]
	public static GKKDCNJAMAE AMOLHHIMHLJ(this HIMFIAMFCKI HLINMGJJNHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5EED410", Offset = "0x5EEC010", VA = "0x185EED410")]
	public static EntityManager MOAHEHFBAFG(this HIMFIAMFCKI HLINMGJJNHD)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x234F460", Offset = "0x234E060", VA = "0x18234F460")]
	public static T KCDNMPBJMLH<T>(this HIMFIAMFCKI HLINMGJJNHD) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x23503D0", Offset = "0x234EFD0", VA = "0x1823503D0")]
	public static bool NFDHLPEDEEF<T>(this HIMFIAMFCKI HLINMGJJNHD) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2350690", Offset = "0x234F290", VA = "0x182350690")]
	public static bool ODGECGDAECD<T>(this HIMFIAMFCKI HLINMGJJNHD) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface KAPJLJPJBNO
{
	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODGEFLGDBPM(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJMNLBMEHCO(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CHCLPJFFMND(HIMFIAMFCKI JMADFINDJPP, [Out] Guid EJECECMPMDH);

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid HJLFOIEJOCF(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNPPNJHAAMI(HIMFIAMFCKI JMADFINDJPP, Guid EJECECMPMDH);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FMHAFKFFIEB(HIMFIAMFCKI JMADFINDJPP, [Out] Guid GKCGMEKGHIE);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid POPLBPIIFHK(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IAPOBPBOLPN(HIMFIAMFCKI JMADFINDJPP, Guid GKCGMEKGHIE);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MIHDFJLLHCJ(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PLNJEKALIOB(HIMFIAMFCKI HOGAMINFHLD, HIMFIAMFCKI HHNAEDAPOHF);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface LALHJOKNEJI
{
	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	Guid NKAEEDGNEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPHOJKIJKID(Guid EJECECMPMDH, Guid GKCGMEKGHIE, string JEICAPDKHKI);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface LMOCGNGFDKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	IReadOnlyCollection<DKLNNALIHAG> BOLLIHLIGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJFPKKOHDIM(int ADJEGAJMFIJ, [Out] DKLNNALIHAG EAPMJNGJPKE);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DKLNNALIHAG ACLECIGEBMM(Type OMKEAAPIABA);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class DOHLAIALNJI
{
	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2388E20", Offset = "0x2387A20", VA = "0x182388E20")]
	public static T CIKNKCBCJDH<T>(this LMOCGNGFDKJ FHPDEMPIEDE, Entity BMHPCOMOJJA) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2388250", Offset = "0x2386E50", VA = "0x182388250")]
	public static DKLNNALIHAG ACLECIGEBMM<T>(this LMOCGNGFDKJ FHPDEMPIEDE) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface FKINNEMNJEA
{
	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LCHFDJFHJHJ[] EFIMMJENIDO(string JEICAPDKHKI, JMFPDKOILML FMHELLDDDCN, bool DFJGMFFIMGN = false);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFOCPGLCFPL(string CDJCGCBIKKC, LCHFDJFHJHJ[] KMDPPOBDBCF);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface EIPJMFAKKNI
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<HIMFIAMFCKI, HIMFIAMFCKI> LIEFPMFJJFD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<HIMFIAMFCKI, HIMFIAMFCKI> KAKCBGHBANG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<HIMFIAMFCKI, HIMFIAMFCKI, HIMFIAMFCKI> ILNGKMOIOEC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<HIMFIAMFCKI> EMNMNKIDLKC;

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JLLJLBCPGKK(HIMFIAMFCKI JMADFINDJPP, HIMFIAMFCKI PJLCNIOGHMM);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HIMFIAMFCKI DOOFMCCDCMK(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<HIMFIAMFCKI> LFOALBFPPAG(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HIMFIAMFCKI LIIJAKKANII(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IEPFIKKLHPF(HIMFIAMFCKI JMADFINDJPP, Vector3 OKGJNNKGDBO, Quaternion LEDHDBGKFMJ);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DNKONCCHEMJ(HIMFIAMFCKI JMADFINDJPP, float IGICPJJPDGI);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CPELBLHJMEC(HIMFIAMFCKI JMADFINDJPP, [Out] RigidTransform LIDFBGPJFMJ);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FMMBPJAHCDK(HIMFIAMFCKI JMADFINDJPP, [Out] float LMEKKHFAKDE);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 NFFGHEINKIA(GBICMDCOHJC KNLKBEOKFON);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion NPOKMJIKAAD(GBICMDCOHJC KNLKBEOKFON);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class PPKDGNJEMIO
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface PPGFMPMBJCB
{
	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	object ANFFKEGMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHJGLKNAILP(HBBOGBDBNJL BPDDIMEAMCL);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum HCMNOKJIONN
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DJBKOJJGBLJ
{
	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xB39240", Offset = "0xB37E40", VA = "0x180B39240")]
	public static bool JFCFMLFAPMF(this HCMNOKJIONN FPIEOLNLDGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xB39250", Offset = "0xB37E50", VA = "0x180B39250")]
	public static bool EGCLALABCMF(this HCMNOKJIONN FPIEOLNLDGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2086870", Offset = "0x2085470", VA = "0x182086870")]
	public static bool MAPBOOKMIME(this HCMNOKJIONN FPIEOLNLDGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum JNMDOPMDPGJ
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
public static class ELIIEOPLCAF
{
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xD68740", Offset = "0xD67340", VA = "0x180D68740")]
	public static int NHBPBMPOCOL(this JNMDOPMDPGJ GCPEEAODAIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface GDCCDHHKNFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface CDHIDEMMGGM
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	HCMNOKJIONN MOKJLKJONIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	HCMNOKJIONN JIDJPANLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	HCMNOKJIONN KNGEGBABBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	HCMNOKJIONN KOCALHGOPKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	HCMNOKJIONN CBEKGJKPKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	HCMNOKJIONN KCHIFHDCNOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	HCMNOKJIONN EIMFKNIAKFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	HCMNOKJIONN CKBJBDIECLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	HCMNOKJIONN OIJKNLNFFJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	HCMNOKJIONN GKLMDFGJEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	HCMNOKJIONN BHAEAJAEAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	HCMNOKJIONN MKAGGEDKOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	HCMNOKJIONN MFCNFLGGOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface EDOFJLFNBEH
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<CFDOHIKNPFG> MBMDKJBCHAI;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HIMFIAMFCKI JKGNKAPCCDK(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHKJBDEKIPG(List<HIMFIAMFCKI> DMKHMLIHBGI);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HIMFIAMFCKI EPLJAFPLIPM(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GMIJDPBCEJN(HIMFIAMFCKI JMADFINDJPP, HIMFIAMFCKI HHNAEDAPOHF, bool GMJNMOGBNNG);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FNCDPMKOCIC(HIMFIAMFCKI JMADFINDJPP, HIMFIAMFCKI HHNAEDAPOHF);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int HNNCCPICFHN(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HBBOGBDBNJL KCFDNFEBFMJ(HIMFIAMFCKI OEBOJHNMNBH);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<HIMFIAMFCKI> DDPOBAFLMKG(HIMFIAMFCKI OEBOJHNMNBH);

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NHKHBKPLAFA(HIMFIAMFCKI JMADFINDJPP, HIMFIAMFCKI HGMKEGMDHFC);

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CFIAKNIABOF(HIMFIAMFCKI JMADFINDJPP, HIMFIAMFCKI HLMGOHOFLBK);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HIMFIAMFCKI FKDBDCCAKMD(HIMFIAMFCKI JIGKIEPHJOJ, HIMFIAMFCKI PCILEMDHNNJ);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KAPLKBGNEBK(HIMFIAMFCKI JIGKIEPHJOJ, HIMFIAMFCKI PCILEMDHNNJ, [Out] HIMFIAMFCKI ECKBHIPMNGD);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class HCGIHDKDIAG
{
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EF33D0", Offset = "0x5EF1FD0", VA = "0x185EF33D0")]
	public static List<HIMFIAMFCKI> JHKJBDEKIPG(this EDOFJLFNBEH EEAGHNDNJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3360", Offset = "0x5EF1F60", VA = "0x185EF3360")]
	public static bool CJJMNNPCEPC(this EDOFJLFNBEH EEAGHNDNJNG, HIMFIAMFCKI JMADFINDJPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface BOAOCHDJCPE
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	bool JHJNEENOMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	bool AJKPOEMKLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface MBLNHOLMAOG : LJMCBEABLBG
{
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGPOBBDAJEP(Entity BMHPCOMOJJA, [Out] DNFKFBLNDIA IFMBFHNFCLO);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMGHMENHHHL(NativeArray<DNFKFBLNDIA> HKIHFJKFFOA, NativeArray<MAOIMBDBCPL> AOHNHLGHNLD);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELMEJHEIKNL(DNFKFBLNDIA IFMBFHNFCLO);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CBECNLAJMCI(DNFKFBLNDIA IFMBFHNFCLO, [Out] Collider JANMHBBPKAL);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface LJMCBEABLBG
{
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AMBIKIFEPAM([In] float3 KJENPMGNNIG, [In] float3 DIFJPIHEJAN, float KIMLGCJBKME, Allocator NOFANFDHPGP, [Out] NativeArray<Entity> ELHAAFMGCOP);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface GBEAKGJBPDH
{
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AMBIKIFEPAM([In] float3 KJENPMGNNIG, [In] float3 DIFJPIHEJAN, float KIMLGCJBKME, [Out] ABLPGIIDMPN NGHLEBNHMNM, [Out] HIMFIAMFCKI OGLIKAGGMMP);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface BBNAEPLFFJC
{
	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMBIKIFEPAM([In] NativeArray<Entity> ELHAAFMGCOP, [In] float3 KJENPMGNNIG, [In] float3 DIFJPIHEJAN, [In] NativeArray<ABLPGIIDMPN> GGEJEFAOLCL);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct DNFKFBLNDIA : PKOAKKMJOIJ, IEquatable<DNFKFBLNDIA>
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public int EJAAMOHLDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x85B650", Offset = "0x85A250", VA = "0x18085B650", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x85B580", Offset = "0x85A180", VA = "0x18085B580", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public int AMLCOLPAGKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x20A6110", Offset = "0x20A4D10", VA = "0x1820A6110", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5304700", Offset = "0x5303300", VA = "0x185304700", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF460", Offset = "0x5EEE060", VA = "0x185EEF460", Slot = "8")]
	public bool Equals(DNFKFBLNDIA LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF4B0", Offset = "0x5EEE0B0", VA = "0x185EEF4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct ABLPGIIDMPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float MFDFFBFAEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 FNDECJGLHAI;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface GIKMHDDKIJE
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface FLPNJHKLIHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	GMDOEGFMHEJ JMMFFGPKJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	NKLPGGMEOPK HEHLOHJELIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<HBBOGBDBNJL, NativeArray<LGFPBEODEOP>> KJAMOCKEOJG;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<HBBOGBDBNJL> JNNEHDDONNL;

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LHIDJJOMBAL GFIJEKLIJIJ(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LGFPBEODEOP CMFNJJOKHKJ(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CFNGGCOIEBP(LCHFDJFHJHJ EJBFBHCOFGB, FBHHAPBFFJI BKEHCHKFFLP);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FJODOEBHCBD(LCHFDJFHJHJ[] KMDPPOBDBCF, GameObject LCHNDEILNAI);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JMFPDKOILML KFBCNDBPIBH(HIMFIAMFCKI JMADFINDJPP, [Optional] object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DPMMKMFMILO(HIMFIAMFCKI JMADFINDJPP, [Out] FBHHAPBFFJI BKEHCHKFFLP);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NGDKFDBNKPD(HIMFIAMFCKI JMADFINDJPP, [Out] Transform CAHHGMHAMLP);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KCLJBIMOOBA(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MFCGELOGEBH(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JNFFLAGAGKM(LocalId JMADFINDJPP, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool CMHLGENMDIF(LocalId JMADFINDJPP, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "17")]
	HIMFIAMFCKI HHOJGGBIAJF(LCHFDJFHJHJ EJBFBHCOFGB);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EJLKMDKPGJN(LCHFDJFHJHJ EJBFBHCOFGB, [Out] HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "19")]
	LCHFDJFHJHJ ELKKMHPJMJL(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "20")]
	HBBOGBDBNJL HHOJGGBIAJF(NativeArray<LCHFDJFHJHJ> EJBFBHCOFGB, Allocator NOFANFDHPGP);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HBBOGBDBNJL GIEFALIACLG(NativeArray<LCHFDJFHJHJ> EJBFBHCOFGB, NativeArray<FOLJDNOENAI> OOMNLNINHGO, Allocator NOFANFDHPGP);

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "22")]
	LCHFDJFHJHJ[] EFIMMJENIDO(string CDJCGCBIKKC, JMFPDKOILML FMHELLDDDCN, bool DFJGMFFIMGN);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GFOCPGLCFPL(string CDJCGCBIKKC, LCHFDJFHJHJ[] KMDPPOBDBCF);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "24")]
	JMFPDKOILML LMAHKIMMOKJ(LGFPBEODEOP LMBLGMDMJHB, bool NCJHKFLGMCG);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JMFPDKOILML LMAHKIMMOKJ(LGFPBEODEOP LMBLGMDMJHB);

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	JMFPDKOILML MFGHFGFLHAO(LGFPBEODEOP LMBLGMDMJHB);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	JMFPDKOILML FFCANCHIKOD(LGFPBEODEOP LMBLGMDMJHB);

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	JMFPDKOILML GIEFALIACLG(LCHFDJFHJHJ EJBFBHCOFGB, LGFPBEODEOP LMBLGMDMJHB);

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	EIPLECJDKAJ LMAKPKLLHID();

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	BIFBFBIDBEG HNFILMLOANO();

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	LMLDMPADLCM JHHLPMEKNGN(DGEEPCMBCIA KDHBABNEMLL);

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void JKNBMCINGNC(HBBOGBDBNJL BPDDIMEAMCL);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void HBPPMPIFHCM(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void AMHBCEKBAOC(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void JKNBMCINGNC(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "36")]
	HBBOGBDBNJL LJCOCMPLHFB(HBBOGBDBNJL IPNKEDNLMKL, Allocator NOFANFDHPGP);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool ENKHGCDGNNP(HIMFIAMFCKI JMADFINDJPP);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class FJAHHJGHOFB
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1160", Offset = "0x5EEFD60", VA = "0x185EF1160")]
	public static void MFCGELOGEBH(this FLPNJHKLIHG FPHMPFNGAPO, FBHHAPBFFJI BKEHCHKFFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0CD0", Offset = "0x5EEF8D0", VA = "0x185EF0CD0")]
	public static JMFPDKOILML CBINOKJFPGC(this FLPNJHKLIHG FPHMPFNGAPO, LocalId JMADFINDJPP)
	{
		return default(JMFPDKOILML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0CD0", Offset = "0x5EEF8D0", VA = "0x185EF0CD0")]
	public static HIMFIAMFCKI HHOJGGBIAJF(this FLPNJHKLIHG FPHMPFNGAPO, LocalId JMADFINDJPP)
	{
		return default(HIMFIAMFCKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0D00", Offset = "0x5EEF900", VA = "0x185EF0D00")]
	public static LCHFDJFHJHJ ELKKMHPJMJL(this FLPNJHKLIHG FPHMPFNGAPO, LocalId JMADFINDJPP)
	{
		return default(LCHFDJFHJHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0D80", Offset = "0x5EEF980", VA = "0x185EF0D80")]
	public static bool ENKHGCDGNNP(this FLPNJHKLIHG FPHMPFNGAPO, LCHFDJFHJHJ EJBFBHCOFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x24DF0E0", Offset = "0x24DDCE0", VA = "0x1824DF0E0")]
	public static T GNAOHJJFFJK<T>(this FLPNJHKLIHG FPHMPFNGAPO, LocalId JMADFINDJPP) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0F60", Offset = "0x5EEFB60", VA = "0x185EF0F60")]
	public static EIPLECJDKAJ HKKEGIPFBMP(this FLPNJHKLIHG FPHMPFNGAPO, RigidTransform HBDIHLKKHGI, [Optional] object KJCAGLABEME)
	{
		return default(EIPLECJDKAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0E50", Offset = "0x5EEFA50", VA = "0x185EF0E50")]
	public static LMLDMPADLCM GDFHJICHLMH(this FLPNJHKLIHG FPHMPFNGAPO, DGEEPCMBCIA CGEDBOJGGDG, RigidTransform HBDIHLKKHGI, [Optional] object KJCAGLABEME)
	{
		return default(LMLDMPADLCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1060", Offset = "0x5EEFC60", VA = "0x185EF1060")]
	public static BIFBFBIDBEG JMMIHNHNOEM(this FLPNJHKLIHG FPHMPFNGAPO, RigidTransform HBDIHLKKHGI, [Optional] object KJCAGLABEME)
	{
		return default(BIFBFBIDBEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0AB0", Offset = "0x5EEF6B0", VA = "0x185EF0AB0")]
	private static void BMDLIJLBOMH(JMFPDKOILML BBHIPMGPGMO, RigidTransform HBDIHLKKHGI, [Optional] object KJCAGLABEME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface FMDJJFNGDFG
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	bool JMHDHOGEJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	HIMFIAMFCKI GACACKMJMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	JMFPDKOILML KLFIHIKKNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JCPIPIEDHBE GIOAJCLBLFL;

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HIMFIAMFCKI FKDBDCCAKMD(HIMFIAMFCKI JIGKIEPHJOJ, HIMFIAMFCKI PCILEMDHNNJ);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KAPLKBGNEBK(HIMFIAMFCKI JIGKIEPHJOJ, HIMFIAMFCKI PCILEMDHNNJ, [Out] HIMFIAMFCKI ECKBHIPMNGD);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DFMOMGEOMAO();

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CGJGCHCDBAP();

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NGKCIKCKPEO(HIMFIAMFCKI JIGKIEPHJOJ);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MEIJEIKMMPL(HIMFIAMFCKI JIGKIEPHJOJ);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public delegate void JCPIPIEDHBE(JMFPDKOILML PBDCJEGOIPP, JMFPDKOILML FKFEPAMFFNC);
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class EGJDHIGNJFM
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF580", Offset = "0x5EEE180", VA = "0x185EEF580")]
	public static bool NIDMKEGEHHB(this FMDJJFNGDFG KGALEKKAAPG, HIMFIAMFCKI JIGKIEPHJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF500", Offset = "0x5EEE100", VA = "0x185EEF500")]
	public static bool ACPKGKIAOHC(this FMDJJFNGDFG KGALEKKAAPG, HIMFIAMFCKI JIGKIEPHJOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface LDCLFDMFIGD
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOJGBFCOJNN(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FDELKLHPFIO(HIMFIAMFCKI JMADFINDJPP, Transform CAHHGMHAMLP);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface BOMPPIOAEFC
{
	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABIIBIADMDN(HIMFIAMFCKI JIGKIEPHJOJ, HIMFIAMFCKI LIJPJPLCIHM, HIMFIAMFCKI FPFIDHIDANH);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HIMFIAMFCKI FCHEKAHEKLH(HIMFIAMFCKI JIGKIEPHJOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface BPBODEILMOP
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHLPJIFIFHD(HIMFIAMFCKI OEBOJHNMNBH, bool GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPODBCELHAA(HIMFIAMFCKI OEBOJHNMNBH, bool GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBNKNDNCAPL(HIMFIAMFCKI OEBOJHNMNBH, int GCPEEAODAIB);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface HIIJOGNCNMH
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<HIMFIAMFCKI> AGNMMNDFBAF(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HIMFIAMFCKI NCKIPJOJHHE(HIMFIAMFCKI JMADFINDJPP, int DCGGFHOCGGH);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FKEDFCEPMIH(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EDNJPEBBPFN AHBNGLJLAFG(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EBJIJEJDEBN(HIMFIAMFCKI JMADFINDJPP, EDNJPEBBPFN OCFPIAIMFIA);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HIMFIAMFCKI PBGIDPAMEAF(HIMFIAMFCKI JMADFINDJPP, [Optional] float3? CFCLFCDKKPD, [Optional] quaternion? HFKFMHAMLPE, [Optional] float3? JIFOIDNONIC);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HIMFIAMFCKI DOAOLDPFOCF(HIMFIAMFCKI JMADFINDJPP, int DCGGFHOCGGH, [Optional] float3? CFCLFCDKKPD, [Optional] quaternion? HFKFMHAMLPE, [Optional] float3? JIFOIDNONIC);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGELOMAPHJO(HIMFIAMFCKI JMADFINDJPP, int DCGGFHOCGGH);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PJAOIHMNFCL(HIMFIAMFCKI JMADFINDJPP);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface EPEJCAFPBFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDKDKHMBBNI();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EALDGCNOGEC();

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPCDBIBDLJI();

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKLLJGDJHMF();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PANEIIIOFBB();

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJEKGEDMHIF();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHPFFAIOJCM();

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void COJFMKGNNFF();

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KLGDOOJFICL();

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BNKOCINMIGD();

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HNKAIPOGOEL();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface MNPEJCNPPGJ
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMBMJNHFJDB(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMLNLHMNDAC(Entity BMHPCOMOJJA, [In] float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 MGEIMJJKAEP(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDMEAMEAHDJ(Entity BMHPCOMOJJA, [In] quaternion GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion JCKNKDNIOMK(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ECKLDPBHIGA(Entity BMHPCOMOJJA, [Out] float3 CFCLFCDKKPD, [Out] quaternion HFKFMHAMLPE);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ECKLDPBHIGA(Entity BMHPCOMOJJA, [Out] RigidTransform JICLEEIHEKF);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MIKAGMLFOIO(Entity BMHPCOMOJJA, [Out] RigidTransform JICLEEIHEKF);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 EHFLDGBINIC(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HCGFGDIBNBJ(Entity BMHPCOMOJJA, [In] float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CMINFFPNOAI(Entity BMHPCOMOJJA, float GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float KFBMEFPAMHM(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FOFOOGBOCGE(Entity BMHPCOMOJJA, [In] float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 HOGJAIMPCDL(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AKADPBHHLMP(Entity BMHPCOMOJJA, [In] float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 PLNBIOKKPMD(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LIPHCAOMFPC(Entity BMHPCOMOJJA, [In] quaternion GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion FPPHKGIMJOD(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 IGNEFPOHNJF(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LLDCBLJEABD(Entity BMHPCOMOJJA, [In] float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MKMFCMCGBEF(Entity BMHPCOMOJJA, float GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float FBAGKNGOEHH(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CFHMHLOIKMB(Entity BMHPCOMOJJA, [In] float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 DBCBKDLLEFD(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DJEADDKHFBC(Entity BMHPCOMOJJA, [Out] float4x4 NBIONLPNBED);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void GDBIFLHHLBL(Entity BMHPCOMOJJA, [In] float4x4 NBIONLPNBED);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GGAONHALFFJ(Entity BMHPCOMOJJA, [Out] float4x4 NBIONLPNBED);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool NGDKFDBNKPD(Entity BMHPCOMOJJA, [Out] Transform CAHHGMHAMLP);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KKABMPPPLGK(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FGMJBGHAHKP(Entity BMHPCOMOJJA, Entity HHFMPIFMFLK, Entity OGNJAKACDHE);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class NFOAOLCHOJN
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface CEPKOAKBAND
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World EPGMLOIENFA(string LBBFGBDFOPM = "Main");

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World IHKMNDEONJJ(string LBBFGBDFOPM = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World LIIJLMIONEC(string LBBFGBDFOPM = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World BHFDJPDJJGB(string LBBFGBDFOPM = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface GKKDCNJAMAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	World KPMHHNNBHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	World ADDDAHPAEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	EntityManager MOAHEHFBAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	bool CBOMGKLCBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase JLOPLABDABB(Type OMKEAAPIABA);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class IGFNGFPBPHA
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4800", Offset = "0x5EF3400", VA = "0x185EF4800")]
	public static ComponentSystemBase HMDPEILDLBB(this World GFHDGPOBABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x252E1F0", Offset = "0x252CDF0", VA = "0x18252E1F0")]
	public static T JLOPLABDABB<T>(this GKKDCNJAMAE ALMHEHLDAMB) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface BIDAIFALHFE
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNKLGHEOILA(NativeListAsync<Entity> PLBFAOEPNKA);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIBFDENMINJ(LBPFALJNOND MPGNGGKGLFD);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOMHECJDICD(NativeListAsync<Entity> CHMHNMJLFDB, bool KDBHAIELADO);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLCJMNPAENF();
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface FJHMEDBHAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLEAIAOJKGB(HIMFIAMFCKI JMADFINDJPP, [Out] Collider JANMHBBPKAL);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject GKNCGPMNLBB(HIMFIAMFCKI FBCKGLAGGMI, GameObject NMGALPBKFJN, Vector3 MNANBFFJBMF, Quaternion HFJOJGBHICN);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EICBLHDJPFA(GameObject JANMHBBPKAL);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider KNLNBJADDKM<TCollider>(GameObject DCOELBBIHIP) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPDPCBLFLPM(Collider JANMHBBPKAL);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject HPNEAJLKKDE<TCollider>(string JEICAPDKHKI) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface KPGKIENGMKL
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJCKDEHNDIP(HIMFIAMFCKI JMADFINDJPP, GFHGKAJKFGM IEAFBJIJOBL, bool DFFPADHABEE, JPEPEFFLGDM CKPCNCHPFNP);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BINLJGPHALA(HIMFIAMFCKI JMADFINDJPP, GFHGKAJKFGM IEAFBJIJOBL, bool DFFPADHABEE, bool OKBHBCKEAAE, bool OOOPLKJIDOI);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IMGODINOIFN LBONMHJKPKE(HIMFIAMFCKI NMHGPHBIAIB, List<HIMFIAMFCKI> IMHCGLBIDHJ);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHHFGJBPLNC(GameObject IMIAMKNMODI, GameObject JPENJANGFJM);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBCGDFDNMLA(GameObject JPENJANGFJM);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T KNLNBJADDKM<T>(GameObject DCOELBBIHIP) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CPDPCBLFLPM(Collider JANMHBBPKAL);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject HEFLCIBNONL<T>(string JEICAPDKHKI) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface DMOPNDHELBN
{
	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGHJIDDLBLG(HIMFIAMFCKI JMADFINDJPP, JNJNNIGHFML GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JNJNNIGHFML OBIAMJFFIDM(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDBFHNLJBCE(HIMFIAMFCKI JMADFINDJPP, HIMFIAMFCKI GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCPPHKCNPIG(HIMFIAMFCKI JMADFINDJPP, HIMFIAMFCKI GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HNNCCPICFHN(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HIMFIAMFCKI FPNHPAPLDGN(HIMFIAMFCKI JMADFINDJPP, int DCGGFHOCGGH);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLPLMCNBCIL(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LJHPPENGECH(HIMFIAMFCKI JMADFINDJPP, object KJCAGLABEME, HIMFIAMFCKI GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DFCMBPGPAPM(HIMFIAMFCKI JMADFINDJPP, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FHNPDLCOHOH(HIMFIAMFCKI JMADFINDJPP, [Out] HIMFIAMFCKI GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HCFHPKOBABE(HIMFIAMFCKI JMADFINDJPP, float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HPGDNNOKIBK(HIMFIAMFCKI JMADFINDJPP, [Out] float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ELOCDFECBDM(HIMFIAMFCKI JMADFINDJPP, float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CLNPAMLBKOE(HIMFIAMFCKI JMADFINDJPP, [Out] float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FJPNJAAFGAF(HIMFIAMFCKI JMADFINDJPP, (Quaternion rot, Vector3 moments) KMLFOKBPHDE);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JGPJLFKFCKE(HIMFIAMFCKI JMADFINDJPP, [Out] quaternion NPBGCICJLPM, [Out] float3 NLNMOLPNJHO);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KBAJKPIDOJF(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void POCPPMDAHPF(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 PPNKPGHJAKK(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 HGAHAGKAGCK(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KIEBBGKDHKM(HIMFIAMFCKI JMADFINDJPP, float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ONMFAFACGDN(HIMFIAMFCKI JMADFINDJPP, float3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float MIFKBHIOHLH(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float IEALCCBGKMI(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PJLBHDMMAEJ(HIMFIAMFCKI JMADFINDJPP, float GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FFNLDGJFOLJ(HIMFIAMFCKI JMADFINDJPP, float GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode BNILPPEEBJJ(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JCCGHNBKNAN(HIMFIAMFCKI JMADFINDJPP, CollisionDetectionMode GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "28")]
	AKKMOBBIBLF LKHPIEEPJLM(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void AKMJFFAFPMC(HIMFIAMFCKI JMADFINDJPP, AKKMOBBIBLF GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool JHOJMJOAHOG(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void EAKOCCOHNCM(HIMFIAMFCKI JMADFINDJPP, bool GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "32")]
	HIMFIAMFCKI JKGNKAPCCDK(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void FLMOENJIEAN(HIMFIAMFCKI JMADFINDJPP, HIMFIAMFCKI GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "34")]
	HIMFIAMFCKI EPLJAFPLIPM(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void GMIJDPBCEJN(HIMFIAMFCKI JMADFINDJPP, HIMFIAMFCKI GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "36")]
	NLLCDEONLOL FNDMCOJGFKA(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void ANJAHKEMIIK(HIMFIAMFCKI JMADFINDJPP, NLLCDEONLOL NJHFANHKNGN);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool PKGLMDCHDHM(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void GCLAOIIDAAP(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool HFILJJHBPHD(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void PNIPGINILIM(HIMFIAMFCKI JMADFINDJPP, bool GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool FLABMECDOOG(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void KANCOALNFEI(HIMFIAMFCKI JMADFINDJPP, bool GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints CFAPKMFIBLD(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void BDCIDEPMPIM(HIMFIAMFCKI JMADFINDJPP, RigidbodyConstraints GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float ACHCADELKKA(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void JCEOPKIHOFA(HIMFIAMFCKI JMADFINDJPP, float GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float DAIKIJFLEFG(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void JIDNPDFCDGJ(HIMFIAMFCKI JMADFINDJPP, float GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool EBAMOCAFBEG(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void MDLPLHIANHH(HIMFIAMFCKI JMADFINDJPP, bool GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool PDDKIIKIEGL(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void JGOHBBCEOND(HIMFIAMFCKI JMADFINDJPP, bool GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void LACOBHEGKEC(HIMFIAMFCKI JMADFINDJPP, int GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object JOLMLALLCEM(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PNELGINDHAK(HIMFIAMFCKI JMADFINDJPP, object GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object KMGNPHAJMFL(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void KAGNGDJNHON(HIMFIAMFCKI JMADFINDJPP, object GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float FDEKDNEEBJM(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void CMBPFKHCHEE(HIMFIAMFCKI JMADFINDJPP, float GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void LAJIKMNHFOD(HIMFIAMFCKI JMADFINDJPP, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void IMCHJOLGBMI(HIMFIAMFCKI JMADFINDJPP, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool FJOMOLHOGIB(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void INKJCAKKOCO(HIMFIAMFCKI JMADFINDJPP, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void IFOKHHBHFPG(HIMFIAMFCKI JMADFINDJPP, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool GJGFCGLMFGH(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool KMIFNEFMHFG(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody DFKIGHBGINK(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void PNHJGEAIOMD(HIMFIAMFCKI JMADFINDJPP, Rigidbody IDJLKFJMEJJ);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void OEOPAAJBNBI(HIMFIAMFCKI JMADFINDJPP, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void JGIPCLHFIPE(HIMFIAMFCKI JMADFINDJPP, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool EPHJFLBBLED(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KBJPMKPDHIK(HIMFIAMFCKI JMADFINDJPP, float3 OAAOAKNCDMA);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void NDAJAPOKJPB(HIMFIAMFCKI JMADFINDJPP, float3 NHOJBJMMDJB);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool ILAMBAEEABF(HIMFIAMFCKI JMADFINDJPP, [Out] float3 OAAOAKNCDMA);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool KHHLGPKMAMG(HIMFIAMFCKI JMADFINDJPP, [Out] float3 NHOJBJMMDJB);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool DPNBAINOCLI(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void MHCLBHOFNIN(HIMFIAMFCKI JMADFINDJPP, object KJCAGLABEME, bool IEPCDJKIMLH);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void EBJJPIHAJHP(HIMFIAMFCKI JMADFINDJPP, bool LNALAPMGCAI);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void ADOKEFBKGAN(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool LIJLBOJCCPG(HIMFIAMFCKI JMADFINDJPP);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface IMADJJBFFKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000138")]
	bool CBOMGKLCBDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LADLLHGCBIO(HIMFIAMFCKI JMADFINDJPP);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKPKDAOPFPI(HIMFIAMFCKI JMADFINDJPP, bool DFFPADHABEE, bool OKBHBCKEAAE, bool POBFAOIOMNB);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJDGMNNJMJN(HIMFIAMFCKI JMADFINDJPP, float3 PMHHDDKKDHI);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEGFIOJHAGH(HIMFIAMFCKI JMADFINDJPP, float3 PMHHDDKKDHI);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface MAFDFEKKMAG
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIDCBBFDHOK(Entity GDMIFFINOLK);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGKGLHCEBAN(Entity GDMIFFINOLK);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public delegate void CMIJFDPJJKM(BCEBHDDDHAO KMAEDHKNBLP);
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct BCEBHDDDHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly HBBOGBDBNJL NDEMPIFGPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NativeArray<byte> MLMDDEIDFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> CHGDNKMNMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly DKCNINGMOLC MGCLAKBCFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly int DPFJNADKPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Type LJLCBMBCFBL;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public HBBOGBDBNJL JNCKLCKMMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x3A1BC10", Offset = "0x3A1A810", VA = "0x183A1BC10")]
		get
		{
			return default(HBBOGBDBNJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC340", Offset = "0x5EEAF40", VA = "0x185EEC340")]
	public BCEBHDDDHAO(HBBOGBDBNJL NDEMPIFGPEN, NativeArray<byte> MLMDDEIDFHL, NativeArray<byte> CHGDNKMNMEG, DKCNINGMOLC MGCLAKBCFBH, int DPFJNADKPHF, Type LJLCBMBCFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x22B6470", Offset = "0x22B5070", VA = "0x1822B6470")]
	public NativeArray<T> KEJFHEBBMAO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x22B6340", Offset = "0x22B4F40", VA = "0x1822B6340")]
	public NativeArray<T> AMPDJBKCHCD<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x22B6380", Offset = "0x22B4F80", VA = "0x1822B6380")]
	public (HBBOGBDBNJL, NativeArray<T>, NativeArray<T>) IOOJPMIEEDI<T>() where T : struct
	{
		return default((HBBOGBDBNJL, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2F0", Offset = "0x5EEAEF0", VA = "0x185EEC2F0")]
	public CFDOHIKNPFG CLEIBBELGHF()
	{
		return default(CFDOHIKNPFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface AMOEMKCOGEF
{
	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	string PMLOGKCBJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	AMOEMKCOGEF IMPAHHMEJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	IEnumerable<AMOEMKCOGEF> LIANPMPIEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface FBLCOGAEFEM
{
	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	AMOEMKCOGEF PDPNGKIGABB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	List<EBIPFMJOBLI> KBMBFDBHPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool COIEFGMMGDC(EBIPFMJOBLI IEIEKFIPLEG, [Out] AMOEMKCOGEF FPGPODOPHHB);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CFNGGCOIEBP(EBIPFMJOBLI IEIEKFIPLEG, CMIJFDPJJKM GOPNEECDBMK);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BAIJPEIFOMP(EBIPFMJOBLI IEIEKFIPLEG, CMIJFDPJJKM GOPNEECDBMK);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct CFDOHIKNPFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly BCEBHDDDHAO IGJLGPELHOJ;

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public HBBOGBDBNJL JNCKLCKMMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x3A1BC10", Offset = "0x3A1A810", VA = "0x183A1BC10")]
		get
		{
			return default(HBBOGBDBNJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDA30", Offset = "0x5EEC630", VA = "0x185EEDA30")]
	public CFDOHIKNPFG(BCEBHDDDHAO IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5EED960", Offset = "0x5EEC560", VA = "0x185EED960")]
	public HBBOGBDBNJL KEJFHEBBMAO()
	{
		return default(HBBOGBDBNJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5EED770", Offset = "0x5EEC370", VA = "0x185EED770")]
	public HBBOGBDBNJL AMPDJBKCHCD()
	{
		return default(HBBOGBDBNJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5EED840", Offset = "0x5EEC440", VA = "0x185EED840")]
	public (HBBOGBDBNJL, HBBOGBDBNJL, HBBOGBDBNJL) IOOJPMIEEDI()
	{
		return default((HBBOGBDBNJL, HBBOGBDBNJL, HBBOGBDBNJL));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DefaultMember("Item")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface BNBOIJPKHCN : IEnumerable<JPCOIOCHKOG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000140")]
	NativeBitArray NHHFDCDAGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	NativeArray<int> MNELKMFDLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	JPCOIOCHKOG NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	JPCOIOCHKOG NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JPCOIOCHKOG NAOHPPLHDKK(HCAAHEDIGHK DKLHENCIMJI);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DKCNINGMOLC BONDPGPBLGG(HCAAHEDIGHK DKLHENCIMJI);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class FFLIBBCPJEN
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
[DefaultMember("Item")]
public interface BNJAINBJMAE : IEnumerable<GNMPENBCDCF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000145")]
	int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	GNMPENBCDCF NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GNMPENBCDCF NAOHPPLHDKK(HCAAHEDIGHK DKLHENCIMJI);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DKCNINGMOLC BONDPGPBLGG(HCAAHEDIGHK DKLHENCIMJI);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class NILEILCHOMF
{
	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2623C60", Offset = "0x2622860", VA = "0x182623C60")]
	public static DKCNINGMOLC BONDPGPBLGG<T>(this BNJAINBJMAE ACGMLGMLLPB, IGEKDKKOPBK<T> JEICAPDKHKI) where T : struct
	{
		return default(DKCNINGMOLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface NCBIDFDLKLG : IEnumerable<EBIPFMJOBLI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000147")]
	int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	EBIPFMJOBLI NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EBIPFMJOBLI NAOHPPLHDKK(HCAAHEDIGHK DKLHENCIMJI);

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DKCNINGMOLC BONDPGPBLGG(HCAAHEDIGHK DKLHENCIMJI);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class EAAIMJMGKOD
{
	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x23C6470", Offset = "0x23C5070", VA = "0x1823C6470")]
	public static ONHFPDLBKAI<T> NAOHPPLHDKK<T>(this NCBIDFDLKLG ACGMLGMLLPB, HCAAHEDIGHK JEICAPDKHKI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x23C6370", Offset = "0x23C4F70", VA = "0x1823C6370")]
	public static DKCNINGMOLC BONDPGPBLGG<T>(this NCBIDFDLKLG ACGMLGMLLPB, IGEKDKKOPBK<T> JEICAPDKHKI) where T : struct
	{
		return default(DKCNINGMOLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface BKOKKOKNKBC
{
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFNGGCOIEBP(HCAAHEDIGHK IEIEKFIPLEG, CMIJFDPJJKM GOPNEECDBMK);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAIJPEIFOMP(HCAAHEDIGHK IEIEKFIPLEG, CMIJFDPJJKM GOPNEECDBMK);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class HDDKLFPKBAL
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface GAIFEIAMBII
{
	[Cpp2IlInjected.Token(Token = "0x17000149")]
	DCEOMDIFABF HMOAMMPEHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLHPCLPOJNJ(LCHFDJFHJHJ EJBFBHCOFGB, DKCNINGMOLC IEIEKFIPLEG);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEJLEPDOAPF(LCHFDJFHJHJ EJBFBHCOFGB, Span<DKCNINGMOLC> ACGMLGMLLPB, bool LAFHDBIKKBH);

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEOLPJHGJLI(NativeArray<LCHFDJFHJHJ> KMDPPOBDBCF);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class HLKGOMFNAND
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF46A0", Offset = "0x5EF32A0", VA = "0x185EF46A0")]
	public static void FEJLEPDOAPF(this GAIFEIAMBII JHDNLGJDCNM, LCHFDJFHJHJ EJBFBHCOFGB, DKCNINGMOLC IEIEKFIPLEG, bool LAFHDBIKKBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct DCEOMDIFABF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly NativeBitArray BHMIKEINNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeParallelHashMap<LCHFDJFHJHJ, int> LLJCKGBAAGC;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool CGCCNAIGNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDA60", Offset = "0x5EEC660", VA = "0x185EEDA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xB2A4A0", Offset = "0xB290A0", VA = "0x180B2A4A0")]
	public DCEOMDIFABF(NativeBitArray BHMIKEINNLG, NativeParallelHashMap<LCHFDJFHJHJ, int> LLJCKGBAAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDA80", Offset = "0x5EEC680", VA = "0x185EEDA80")]
	public bool OLHPCLPOJNJ(LCHFDJFHJHJ EJBFBHCOFGB, DKCNINGMOLC IEIEKFIPLEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface DOPJEIKDMGG
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPLHPOABHJO(HIMFIAMFCKI JMADFINDJPP, BLKCDCILOGI GCPEEAODAIB);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface AOJEHJIKEOM
{
	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	KFHCMIPAIKD MBFLMCOHNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface DHNMCKBPHJP
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	Type DIFOMFIAIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[NNHGGBDLEBL(POFEBJKDGBG.LoadInstance)]
public interface LDEMCEPKGGP
{
	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGIDKKHIICP(HIMFIAMFCKI OEBOJHNMNBH, bool GCPEEAODAIB);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public readonly struct MJCBAJAOEPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IEnumerable<HEFIFDFEEHD> ENONDHKJMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IReadOnlyList<GameObject> PHKGEJFMNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<int> OKONPEAFIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<(LCHFDJFHJHJ, LCHFDJFHJHJ)> MOKKMBLNLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int NIAMFGHEGKA;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public bool LNBKOGHJAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x5EFA6E0", Offset = "0x5EF92E0", VA = "0x185EFA6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public int OBHIFJEDJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x896A30", Offset = "0x895630", VA = "0x180896A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<GameObject> GEHOPGOOGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x834770", Offset = "0x833370", VA = "0x180834770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public IEnumerable<(LCHFDJFHJHJ src, LCHFDJFHJHJ dst)> DLNIHLOFMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA740", Offset = "0x5EF9340", VA = "0x185EFA740")]
	public MJCBAJAOEPC(IEnumerable<HEFIFDFEEHD> ENONDHKJMPC, IReadOnlyList<GameObject> PHKGEJFMNAJ, IReadOnlyList<int> OKONPEAFIMI, IReadOnlyList<(LCHFDJFHJHJ src, LCHFDJFHJHJ dst)> MOKKMBLNLMF, int NIAMFGHEGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA350", Offset = "0x5EF8F50", VA = "0x185EFA350")]
	public (GameObject, int)[] DCCHIMJKBMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface EFDIIDLHGCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000151")]
	bool KOLEAEEJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	bool HJMLFPIOMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	AHBGGFEPKGG CAMECKHHNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BENHKBHBLMM NDNOLHIPMDL();

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BENHKBHBLMM NHOPHJBNPJI(IEnumerable<HIMFIAMFCKI> BPDDIMEAMCL, [In] MHCAHIBICII PNDIDBKLAHH);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PJKMGBINHLI IHLECLGENCC(ByteString AGJMKOBIGFE);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JGBHPGLAAFH LFAPKFOPNLM(ByteString KCGANELMDLB, HIMFIAMFCKI HHNAEDAPOHF, [In] MHCAHIBICII POIHPEDDMEH, JGNAIMMIOGA MGALAPBIHIL, bool MBGOLHIEBHE = true);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PGOPGCMLEIJ();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MJCBAJAOEPC OLKBAGHNIBP(IEnumerable<HEFIFDFEEHD> ENONDHKJMPC);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class MJFOOBNAHNN
{
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface HGAFEHIEPMK
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action DJMLPGIOEDO;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action LKNEDFOJAAN;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct FOLJDNOENAI : MNPAKPLALJI, IEquatable<FOLJDNOENAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public LGFPBEODEOP LMBLGMDMJHB;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1460", Offset = "0x5EF0060", VA = "0x185EF1460", Slot = "5")]
	public void JFKFFNFOIMD(KHBFNJIKOPG BIBCAMINPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1490", Offset = "0x5EF0090", VA = "0x185EF1490", Slot = "4")]
	public void OIIEHDKDHEB(MBDOKFPFEPO BNGNOICJJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF14C0", Offset = "0x5EF00C0", VA = "0x185EF14C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC780", Offset = "0x7EB380", VA = "0x1807EC780", Slot = "6")]
	public bool Equals(FOLJDNOENAI LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF13E0", Offset = "0x5EEFFE0", VA = "0x185EF13E0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x85B650", Offset = "0x85A250", VA = "0x18085B650", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct LCHFDJFHJHJ : IComparable<LCHFDJFHJHJ>, IEquatable<LCHFDJFHJHJ>, MNPAKPLALJI
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public const uint FBLBCHLDEIB = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint EPNHMPIGALI = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly LCHFDJFHJHJ PHKLJCNEMGA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int JHDGJOLNJGP = 24;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const uint EHNNAOLPGPF = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int JADPLIAHKKM = 8;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const uint HMNJFDAFNPO = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly uint FEGEJBFJFNG;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public uint DFCIDPMFIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x7CC560", Offset = "0x7CB160", VA = "0x1807CC560")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public uint GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9C80", Offset = "0x5EF8880", VA = "0x185EF9C80")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public uint NKMGLEGFLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x85B650", Offset = "0x85A250", VA = "0x18085B650")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool LNBKOGHJAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FD40", Offset = "0x5E4E940", VA = "0x185E4FD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xD68740", Offset = "0xD67340", VA = "0x180D68740")]
	public static LCHFDJFHJHJ EGFBKHHJGPL(uint FEGEJBFJFNG)
	{
		return default(LCHFDJFHJHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9DE0", Offset = "0x5EF89E0", VA = "0x185EF9DE0")]
	public LCHFDJFHJHJ(int CKFFDHGOJPM, int KEJGCDPDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9DE0", Offset = "0x5EF89E0", VA = "0x185EF9DE0")]
	public LCHFDJFHJHJ(uint CKFFDHGOJPM, int KEJGCDPDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9DE0", Offset = "0x5EF89E0", VA = "0x185EF9DE0")]
	public LCHFDJFHJHJ(uint CKFFDHGOJPM, uint KEJGCDPDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x85B580", Offset = "0x85A180", VA = "0x18085B580")]
	private LCHFDJFHJHJ(uint FEGEJBFJFNG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1709750", Offset = "0x1708350", VA = "0x181709750")]
	public static bool JONBIHPGCCI(LCHFDJFHJHJ FLGIINLNNEM, LCHFDJFHJHJ KNDAEONALIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC780", Offset = "0x7EB380", VA = "0x1807EC780", Slot = "5")]
	public bool Equals(LCHFDJFHJHJ HLINMGJJNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9C00", Offset = "0x5EF8800", VA = "0x185EF9C00", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2086780", Offset = "0x2085380", VA = "0x182086780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9D50", Offset = "0x5EF8950", VA = "0x185EF9D50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9CF0", Offset = "0x5EF88F0", VA = "0x185EF9CF0", Slot = "6")]
	public void OIIEHDKDHEB(MBDOKFPFEPO BNGNOICJJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9C90", Offset = "0x5EF8890", VA = "0x185EF9C90", Slot = "7")]
	public void JFKFFNFOIMD(KHBFNJIKOPG BIBCAMINPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9BF0", Offset = "0x5EF87F0", VA = "0x185EF9BF0", Slot = "4")]
	public int CompareTo(LCHFDJFHJHJ LLMHBOEDHFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct HEFIFDFEEHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Guid OGCEPACDHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public string CDJCGCBIKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Vector3 CFCLFCDKKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Quaternion HFKFMHAMLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Vector3 JIFOIDNONIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int FKDJGFKECKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Dictionary<string, object> OCFPIAIMFIA;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3670", Offset = "0x5EF2270", VA = "0x185EF3670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5EF34E0", Offset = "0x5EF20E0", VA = "0x185EF34E0")]
	private static string CGAGCHFABBF(Dictionary<string, object> HAENNPALKDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public enum AJMINDLDMFC
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class CLGEEPEPCKA
{
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5432680", Offset = "0x5431280", VA = "0x185432680")]
	public static bool MAJBGPGGHAK(this AJMINDLDMFC OMKEAAPIABA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Flags]
public enum NPBBBKBIONN
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
public interface JGBHPGLAAFH : AHBGGFEPKGG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000158")]
	JGNAIMMIOGA GFDLAPGPJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PELAEOHIFHJ();

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMFFKGJCHFJ();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface AHBGGFEPKGG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000159")]
	IEnumerable<HEFIFDFEEHD> IGOPGDBJIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	MJCBAJAOEPC PLBDCLNPJED
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	LocalId GIIOCENJFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	DBOMNFNAJJH CEBJFBPGDAF
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	Task MOAJCIFBLCA
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DHAKHJIICCG(NPBBBKBIONN AGINHOIIDNE);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface JGNAIMMIOGA
{
	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNHNAHIFBPE(Guid PFJBHGAEIJN, [Out] Guid JKLLIKBBCBF);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface PJKMGBINHLI : AHBGGFEPKGG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[Flags]
public enum HPNJAPPCBKM
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
public interface BENHKBHBLMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	DBOMNFNAJJH BCKHIAOGAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString NDCHKBGFEII();
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public enum MOJJJBDEBCB
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public delegate bool LAGPOOONHNI(NKPAIHEHDND IHGLCHNEBBA, [In] BNDALHLCLDJ GCPEEAODAIB);
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public delegate bool OCHFLDBBDJF<T>(NKPAIHEHDND IHGLCHNEBBA, [In] T GCPEEAODAIB);
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface MDGBJGNGMLD
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFNGGCOIEBP(DKCNINGMOLC MGCLAKBCFBH, Type EKEBGGMFKCN, LAGPOOONHNI POOLKLFGCBF);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GJLNGPCHHEJ(DKCNINGMOLC MGCLAKBCFBH, [Out] LAGPOOONHNI POOLKLFGCBF);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class HKGGFNAMOPD
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class DHOJBOFLICO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public OCHFLDBBDJF<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DHOJBOFLICO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x4E44740", Offset = "0x4E43340", VA = "0x184E44740")]
		internal bool PAILFGFOEHC(NKPAIHEHDND pendingList, [In] BNDALHLCLDJ value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x251B840", Offset = "0x251A440", VA = "0x18251B840")]
	public static void CFNGGCOIEBP<T>(this MDGBJGNGMLD KBPCHNGOIDL, DKCNINGMOLC MGCLAKBCFBH, OCHFLDBBDJF<T> POOLKLFGCBF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4590", Offset = "0x5EF3190", VA = "0x185EF4590")]
	public static bool DOKCJAKIPIH(this MDGBJGNGMLD KBPCHNGOIDL, NKPAIHEHDND IHGLCHNEBBA, DKCNINGMOLC MGCLAKBCFBH, [In] BNDALHLCLDJ GCPEEAODAIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface OPKJBLBMNAE
{
	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	uint JKOLLFKIFPP
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface NKPAIHEHDND
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJHJJCBPGKG(LCHFDJFHJHJ HKMBGMOEPFA, DKCNINGMOLC MGCLAKBCFBH, ReadOnlySpan<byte> NFHPMAHAOKE, ReadOnlySpan<byte> OBJHIGGPNNE);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BAMPBHPDFIP(LCHFDJFHJHJ HKMBGMOEPFA, DKCNINGMOLC MGCLAKBCFBH);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NLOHENLLAPI(LCHFDJFHJHJ HKMBGMOEPFA, DKCNINGMOLC MGCLAKBCFBH, ReadOnlySpan<byte> OBJHIGGPNNE);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EHFLKNFENKA(LCHFDJFHJHJ HKMBGMOEPFA, DKCNINGMOLC MGCLAKBCFBH, Span<byte> NFHPMAHAOKE, Span<byte> OBJHIGGPNNE);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class BOABGOFCAHP
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x22DD940", Offset = "0x22DC540", VA = "0x1822DD940")]
	public static bool EHFLKNFENKA<T>(this NKPAIHEHDND JPIHKPFMJDA, LCHFDJFHJHJ HKMBGMOEPFA, DKCNINGMOLC MGCLAKBCFBH, [Out] T NFHPMAHAOKE, [Out] T OBJHIGGPNNE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x22DDAF0", Offset = "0x22DC6F0", VA = "0x1822DDAF0")]
	public static bool NLOHENLLAPI<T>(this NKPAIHEHDND JPIHKPFMJDA, LCHFDJFHJHJ HKMBGMOEPFA, DKCNINGMOLC MGCLAKBCFBH, T OBJHIGGPNNE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public enum EHBIIAIMCPM
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
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface JCKMDPMAJBD
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFOHAOJAPFD(FMNBCHJKCNF NOOIIGLDGHB, ReadOnlySpan<byte> AGEBEEELPDJ);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBPKMKGEPNI(uint NOPJOFJIKBB, ReadOnlySpan<byte> AGEBEEELPDJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface PLGBKLKPINC
{
	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FMNBCHJKCNF MCNKMHPOLDK(ReadOnlySpan<byte> AGEBEEELPDJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface HLLFIKDLBFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAODCBCCJHF(FMNBCHJKCNF PPNDANAOAMK, ReadOnlySpan<byte> AGEBEEELPDJ);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDPOKGEEGJO(ReadOnlySpan<FMNBCHJKCNF> BKPFHOLIGGB);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct EEMJLGLOGPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public FMNBCHJKCNF NOOIIGLDGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public ReadOnlyMemory<byte> AGEBEEELPDJ;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct FMNBCHJKCNF
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static FMNBCHJKCNF JHIDPKHGFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public uint CKFFDHGOJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int DJBLGPGBDCI;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0xA0F810", Offset = "0xA0E410", VA = "0x180A0F810")]
	public FMNBCHJKCNF(uint CKFFDHGOJPM, int DJBLGPGBDCI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF12C0", Offset = "0x5EEFEC0", VA = "0x185EF12C0")]
	public static bool JONBIHPGCCI([In] FMNBCHJKCNF AGIBINPMDEG, [In] FMNBCHJKCNF BBPKFALMKGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF11E0", Offset = "0x5EEFDE0", VA = "0x185EF11E0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1290", Offset = "0x5EEFE90", VA = "0x185EF1290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF12F0", Offset = "0x5EEFEF0", VA = "0x185EF12F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF12E0", Offset = "0x5EEFEE0", VA = "0x185EF12E0")]
	public void OJCJGJJAKEJ([Out] uint CKFFDHGOJPM, [Out] int DJBLGPGBDCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[NNHGGBDLEBL(POFEBJKDGBG.OMRoom)]
public interface AICGEKBCAAF : LGCHGKKNJNN<AICGEKBCAAF>
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELLDKPBLMHI(DKCNINGMOLC HLINMGJJNHD, [Out] DOBGJHDHOGK EAPMJNGJPKE);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class DMJCCCPIKNN
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface DOBGJHDHOGK
{
	[Cpp2IlInjected.Token(Token = "0x17000160")]
	Type LDLCHHGJINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFKFFNFOIMD(KHBFNJIKOPG BIBCAMINPDH, Span<byte> JIGKIEPHJOJ);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIIEHDKDHEB(MBDOKFPFEPO BNGNOICJJGA, ReadOnlySpan<byte> NOOIIGLDGHB);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class PLINKJFEIDD
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct MAOIMBDBCPL : ISystemStateComponentData, IComponentData, IEquatable<MAOIMBDBCPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float3 MJPHPLJKJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 JMHKIELLAKF;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA2D0", Offset = "0x5EF8ED0", VA = "0x185EFA2D0", Slot = "4")]
	public bool Equals(MAOIMBDBCPL LLMHBOEDHFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface KKDJGIIGJFH
{
	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BELHNPEKEED JLJMNBEBDMP(int ADJEGAJMFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int NCBBGFHIOOL(BELHNPEKEED CIOOJHJEJPN);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface NDJLEEEMOKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000161")]
	IEnumerable<IAEFBOEMLDL> DEKAEOCENFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ONBBGGIMHHB(int ADJEGAJMFIJ, [Out] IAEFBOEMLDL EAPMJNGJPKE);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface LIECDOPEFBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IIBEPBGJJBG(int ADJEGAJMFIJ);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface FFICOAJJLJG
{
	[Cpp2IlInjected.Token(Token = "0x17000162")]
	List<(BELHNPEKEED nameHash, DBEDBICAADA stableTypeHash, Type type)> HKALDLJPICP
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class CNCAHEHIFIE
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CNCAHEHIFIE()
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
