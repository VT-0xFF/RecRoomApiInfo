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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x848DBC0", Offset = "0x848CFC0", VA = "0x18848DBC0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CPCOGBKDOFA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84801D0", Offset = "0x847F5D0", VA = "0x1884801D0")]
	public static void FCAGALNFKGP(this Rigidbody PLMDAJNBAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8480360", Offset = "0x847F760", VA = "0x188480360")]
	public static void FCAGALNFKGP(this Rigidbody PLMDAJNBAGC, Vector3 EAIBEEBNNMN, Quaternion EDAMCMCIKGC, Vector3 GNLEFDEINIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct HOKGPHAPNOB : IReadOnlyList<NAIIODHHNBF>, IEnumerable<NAIIODHHNBF>, IEnumerable, IReadOnlyCollection<NAIIODHHNBF>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct HMFMKBPMCNJ : IEnumerator<NAIIODHHNBF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MHFAEJPNHJP GFKIDJOBMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator DKMELEEAPAI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NAIIODHHNBF FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8486A50", Offset = "0x8485E50", VA = "0x188486A50", Slot = "4")]
			get
			{
				return default(NAIIODHHNBF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8486A00", Offset = "0x8485E00", VA = "0x188486A00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x54E1B80", Offset = "0x54E0F80", VA = "0x1854E1B80")]
		public HMFMKBPMCNJ(MHFAEJPNHJP GFKIDJOBMJK, NativeArray<LocalId>.Enumerator DKMELEEAPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8486940", Offset = "0x8485D40", VA = "0x188486940", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8486980", Offset = "0x8485D80", VA = "0x188486980", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84869C0", Offset = "0x8485DC0", VA = "0x1884869C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HLAFCICCABI FELIADFOOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> PHJLCHBDPGC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NAIIODHHNBF FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8487FF0", Offset = "0x84873F0", VA = "0x188487FF0", Slot = "4")]
		get
		{
			return default(NAIIODHHNBF);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8487650", Offset = "0x8486A50", VA = "0x188487650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int LGBCDNNAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MHFAEJPNHJP EPCFGMJMGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8487B30", Offset = "0x8486F30", VA = "0x188487B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool AJBBOECICAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8487AF0", Offset = "0x8486EF0", VA = "0x188487AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> JBCPALGIPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2C96350", Offset = "0x2C95750", VA = "0x182C96350")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> IFCHAFICJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8487830", Offset = "0x8486C30", VA = "0x188487830")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8487CF0", Offset = "0x84870F0", VA = "0x188487CF0")]
	public HOKGPHAPNOB(int HLNAOJHAMJG, MHFAEJPNHJP GFKIDJOBMJK, Allocator KCEIEKBPKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8487E50", Offset = "0x8487250", VA = "0x188487E50")]
	public HOKGPHAPNOB(HLAFCICCABI FELIADFOOJH, NativeArray<LocalId> PHJLCHBDPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8487F10", Offset = "0x8487310", VA = "0x188487F10")]
	public HOKGPHAPNOB(HLAFCICCABI FELIADFOOJH, NativeArray<Entity> PHJLCHBDPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8487C60", Offset = "0x8487060", VA = "0x188487C60")]
	internal HOKGPHAPNOB(MHFAEJPNHJP GFKIDJOBMJK, NativeArray<Entity> FGABDCIOGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8487F80", Offset = "0x8487380", VA = "0x188487F80")]
	internal HOKGPHAPNOB(MHFAEJPNHJP GFKIDJOBMJK, NativeArray<LocalId> PHJLCHBDPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8487DA0", Offset = "0x84871A0", VA = "0x188487DA0")]
	public HOKGPHAPNOB(MHFAEJPNHJP GFKIDJOBMJK, int COONBEDHJNN, Allocator KCEIEKBPKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8487E60", Offset = "0x8487260", VA = "0x188487E60")]
	public HOKGPHAPNOB(HOKGPHAPNOB MDANALLNMFI, Allocator KCEIEKBPKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84873E0", Offset = "0x84867E0", VA = "0x1884873E0")]
	public void AHINEHNEJJM(List<NAIIODHHNBF> KIGLENMLJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84879E0", Offset = "0x8486DE0", VA = "0x1884879E0")]
	public void NMCLBCEJALB(int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8487790", Offset = "0x8486B90", VA = "0x188487790")]
	public HOKGPHAPNOB JCIOENFMGMF(Allocator KCEIEKBPKNP)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8487890", Offset = "0x8486C90", VA = "0x188487890")]
	public Span<NAIIODHHNBF> LJHFGFAAJAK()
	{
		return default(Span<NAIIODHHNBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84876F0", Offset = "0x8486AF0", VA = "0x1884876F0")]
	public HOKGPHAPNOB FAKCNLFLCFE(int FEMDGHMCLCC, int COONBEDHJNN)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84876B0", Offset = "0x8486AB0", VA = "0x1884876B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8487A30", Offset = "0x8486E30", VA = "0x188487A30")]
	public HMFMKBPMCNJ OJAPBOKMMBI()
	{
		return default(HMFMKBPMCNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8487B80", Offset = "0x8486F80", VA = "0x188487B80", Slot = "6")]
	private IEnumerator<NAIIODHHNBF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8487BF0", Offset = "0x8486FF0", VA = "0x188487BF0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BOGHHEAPGDM
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A47B70", Offset = "0x3A46F70", VA = "0x183A47B70")]
	public static LGOFOLFOCNA<T> JHJNJJCJCBO<T>(this HOKGPHAPNOB BEOBAPANJHO) where T : Component
	{
		return default(LGOFOLFOCNA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct OGKGFAOMCHI : IList<NAIIODHHNBF>, ICollection<NAIIODHHNBF>, IEnumerable<NAIIODHHNBF>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PKOBDLKCIAO : IEnumerator<NAIIODHHNBF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MHFAEJPNHJP GFKIDJOBMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator DKMELEEAPAI;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NAIIODHHNBF FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x84960D0", Offset = "0x84954D0", VA = "0x1884960D0", Slot = "4")]
			get
			{
				return default(NAIIODHHNBF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8496080", Offset = "0x8495480", VA = "0x188496080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x54E1B80", Offset = "0x54E0F80", VA = "0x1854E1B80")]
		public PKOBDLKCIAO(MHFAEJPNHJP GFKIDJOBMJK, NativeArray<LocalId>.Enumerator DKMELEEAPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8495FC0", Offset = "0x84953C0", VA = "0x188495FC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8496000", Offset = "0x8495400", VA = "0x188496000", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8496040", Offset = "0x8495440", VA = "0x188496040", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MHFAEJPNHJP GFKIDJOBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> PHJLCHBDPGC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NAIIODHHNBF FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84929F0", Offset = "0x8491DF0", VA = "0x1884929F0", Slot = "4")]
		get
		{
			return default(NAIIODHHNBF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8492AE0", Offset = "0x8491EE0", VA = "0x188492AE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8492000", Offset = "0x8491400", VA = "0x188492000", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8492000", Offset = "0x8491400", VA = "0x188492000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> JBCPALGIPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2C96350", Offset = "0x2C95750", VA = "0x182C96350")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool NBPHDBEEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84928E0", Offset = "0x8491CE0", VA = "0x1884928E0")]
	public OGKGFAOMCHI(MHFAEJPNHJP GFKIDJOBMJK, Allocator KCEIEKBPKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8492960", Offset = "0x8491D60", VA = "0x188492960")]
	public OGKGFAOMCHI(MHFAEJPNHJP GFKIDJOBMJK, int COONBEDHJNN, Allocator KCEIEKBPKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84922E0", Offset = "0x84916E0", VA = "0x1884922E0")]
	public HOKGPHAPNOB DGLNPEFNDGE()
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8492040", Offset = "0x8491440", VA = "0x188492040", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8492080", Offset = "0x8491480", VA = "0x188492080", Slot = "13")]
	public bool Contains(NAIIODHHNBF GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8492110", Offset = "0x8491510", VA = "0x188492110", Slot = "14")]
	public void CopyTo(NAIIODHHNBF[] LMLCJEFLFMP, int KJLHONACGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8491F80", Offset = "0x8491380", VA = "0x188491F80", Slot = "11")]
	public void Add(NAIIODHHNBF GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84924C0", Offset = "0x84918C0", VA = "0x1884924C0", Slot = "7")]
	public void Insert(int NOEININIMIL, NAIIODHHNBF GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8492650", Offset = "0x8491A50", VA = "0x188492650", Slot = "15")]
	public bool Remove(NAIIODHHNBF GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8492430", Offset = "0x8491830", VA = "0x188492430", Slot = "6")]
	public int IndexOf(NAIIODHHNBF GBDPBDHPLOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8492600", Offset = "0x8491A00", VA = "0x188492600", Slot = "8")]
	public void RemoveAt(int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84923F0", Offset = "0x84917F0", VA = "0x1884923F0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8492570", Offset = "0x8491970", VA = "0x188492570")]
	public PKOBDLKCIAO OJAPBOKMMBI()
	{
		return default(PKOBDLKCIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8492720", Offset = "0x8491B20", VA = "0x188492720", Slot = "16")]
	private IEnumerator<NAIIODHHNBF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8492800", Offset = "0x8491C00", VA = "0x188492800", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PCLHDDLNJAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAIIODHHNBF FCPHGDHFOCH(NAIIODHHNBF PHJLCHBDPGC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DNHHHAGCCHH : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface BPHMKJHOLKM : DAGLJPIGILE, BEPNILIBKJG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PDJHIFICKBM NAKJDPNPLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HLAFCICCABI DJILMGJMNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface BEPNILIBKJG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool HDAANLJCHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface LCFCABNCJNL
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFFCLHGBIHN(bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBLMHKLDBPD();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface BGNCAHMCOAA
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HJOLGGCJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool EAMAIOJEANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool IDGDNKMJENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool ELCFGPIFFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OEGLFJJJGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BJJGBDAMAEJ(bool DGKJCLCLLMA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DKFMMMPJAKG(ByteString ILPJPPHONOB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PHLEJAHPAKC();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BLALNHLAHNF();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FMBNCEMPDJJ();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface FGPBDDGCBGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	BBKOKELKFDM NAKJDPNPLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FOKGOKMAKMH PFABPHDMEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MALMJFKJJNA MNJAOIEIPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	BPHMKJHOLKM GJBFFAPJPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PFJMMCIIHOA NOEPMNJMKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	BGNCAHMCOAA LBOCECPGJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	CFLPOFDACJP NFFOGDCDMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OONLBECKDHI DHIEPEKAMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DHLLNOFKNAA PGJAKNONCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DDFFIBBBDCI OFBDFJKOLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	OAOIPGBKCLP CPKJJJENDGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	COJCAOGKNCI MIAAIGDKDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	MHFAEJPNHJP EPCFGMJMGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	OKMMFMDNONO GLJEAJOJMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	AMOMFNJCBAN DAKGPOOCGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	ANFIJLBKKNE EAODHBCMJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ENOLMAJCHPI PPPCOGIABPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AEFLIHBPMEJ IKLACGPMGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EKFPDKJPIAM JGDODNEEIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HDPIGLLNLBC CFKNCPBALGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NFOCNCEHBMF HDLOCIKKCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	OCLOPOPALDC AGDPNPJFKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BNABIFGDLDE AEAFFJOOEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CPMDLPHOEAL MKPHAFHODEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	ELOONHGKGHE BKIKFMMHMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CFFGMIPDMOB NMHJBOEEGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BNFPGIFBFBJ MGOGMBKOHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FOOPJJDIOEH LDGBAJEDOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KDDMNMBCONC KGKPDLJONDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	ODHDBENJMPP PAKDNMFGAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MJJBEPODCPM MMNAEILNPMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DJEGDOLDLFH LJBGKPDCCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HAGHILCFJMD INLFNCPBEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	MHFHPGBIGKN FIBPCEPJPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	FOMGJMJGJGC HNEPFPPKELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	PFIJCFDKACA JPFCLNLFBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NNGIBDKCHKM LENCDJIJHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	CAJCBBNDOID OOGDJFNPEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	GCGGHIEIMDF LEOOJDMJGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	FJILNINBNME KBCNEBDMNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(CBGMJKHOGCF))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct NAIIODHHNBF : IComparable<NAIIODHHNBF>, IEquatable<NAIIODHHNBF>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly NAIIODHHNBF FEIBEMCCPGP;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int LFELJLHFBKM = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int NBBOHBNAFHP = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int FNEIHOEOCBF = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int GJDFAGBNEOD = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId HNIIKCBNMGN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MHFAEJPNHJP EPCFGMJMGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84891B0", Offset = "0x84885B0", VA = "0x1884891B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public BPHMKJHOLKM GJBFFAPJPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8490020", Offset = "0x848F420", VA = "0x188490020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LocalId KADHGKILELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x848FEF0", Offset = "0x848F2F0", VA = "0x18848FEF0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal HLAFCICCABI DJILMGJMNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8490410", Offset = "0x848F810", VA = "0x188490410")]
		get
		{
			return default(HLAFCICCABI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool KNLAECGHIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8490420", Offset = "0x848F820", VA = "0x188490420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private bool HBLHLCFFPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8490220", Offset = "0x848F620", VA = "0x188490220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8490700", Offset = "0x848FB00", VA = "0x188490700")]
	public NAIIODHHNBF(MHFAEJPNHJP CKHNGMCFKNF, LocalId HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8490670", Offset = "0x848FA70", VA = "0x188490670")]
	public NAIIODHHNBF(HLAFCICCABI FELIADFOOJH, LocalId HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
	public OAMEECEEOCH BGCBBJFMLJO()
	{
		return default(OAMEECEEOCH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8490270", Offset = "0x848F670", VA = "0x188490270")]
	public static LocalId GKKMDDPCKIG(NAIIODHHNBF JKGEIBCCKPD)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x84902B0", Offset = "0x848F6B0", VA = "0x1884902B0")]
	public static Entity GKKMDDPCKIG(NAIIODHHNBF JKGEIBCCKPD)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84902F0", Offset = "0x848F6F0", VA = "0x1884902F0")]
	public static bool ILMCFLMCOJH(NAIIODHHNBF HCFCOMCPJPA, NAIIODHHNBF JOCIBENNGKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8481600", Offset = "0x8480A00", VA = "0x188481600")]
	public static bool AMDBHCBNEEF(NAIIODHHNBF HCFCOMCPJPA, NAIIODHHNBF JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8490540", Offset = "0x848F940", VA = "0x188490540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8490080", Offset = "0x848F480", VA = "0x188490080", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x848FF30", Offset = "0x848F330", VA = "0x18848FF30", Slot = "4")]
	public int CompareTo(NAIIODHHNBF LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "5")]
	public bool Equals(NAIIODHHNBF LHDOHAKINKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ECNOGDKLECD
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8481F90", Offset = "0x8481390", VA = "0x188481F90")]
	public static DNOIABBOEPJ OLDJJILJEKK(this NAIIODHHNBF DEJGDIIDCDN)
	{
		return default(DNOIABBOEPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class CBGMJKHOGCF
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct HLAFCICCABI : IEquatable<HLAFCICCABI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte FELIADFOOJH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] DHJLFOIFJKG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static MHFAEJPNHJP MDDGOPFGIEA;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static BPHMKJHOLKM APGADAPMLIO;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static MHFAEJPNHJP[] LCOLEDDBCJK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static BPHMKJHOLKM[] FCMAICCIMKA;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> OGAEHKJOEGO;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public BPHMKJHOLKM GJBFFAPJPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8486080", Offset = "0x8485480", VA = "0x188486080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public MHFAEJPNHJP CFBKEKAHLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8486560", Offset = "0x8485960", VA = "0x188486560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8486930", Offset = "0x8485D30", VA = "0x188486930")]
	static HLAFCICCABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA490", Offset = "0x2CE9890", VA = "0x182CEA490")]
	internal HLAFCICCABI(byte CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x72AFFE0", Offset = "0x72AF3E0", VA = "0x1872AFFE0", Slot = "4")]
	public bool Equals(HLAFCICCABI LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8486160", Offset = "0x8485560", VA = "0x188486160", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x105C9D0", Offset = "0x105BDD0", VA = "0x18105C9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8486870", Offset = "0x8485C70", VA = "0x188486870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x84864A0", Offset = "0x84858A0", VA = "0x1884864A0")]
	private static MHFAEJPNHJP IBPMIOOLEAG(byte FELIADFOOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8486640", Offset = "0x8485A40", VA = "0x188486640")]
	private static BPHMKJHOLKM KFHNPCANEKK(byte FELIADFOOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x84866F0", Offset = "0x8485AF0", VA = "0x1884866F0")]
	private static object MOKENFFPHLG(byte FELIADFOOJH, object[] EJCCOPPBIIG, object ABINAMGBLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8486550", Offset = "0x8485950", VA = "0x188486550")]
	private static int JEBOBNPNDAB(byte FELIADFOOJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8486860", Offset = "0x8485C60", VA = "0x188486860")]
	private static int PCCPKEHPMJF(byte FELIADFOOJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8486420", Offset = "0x8485820", VA = "0x188486420")]
	private static (int, int) IAOLNIPEJFP(byte FELIADFOOJH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8486410", Offset = "0x8485810", VA = "0x188486410")]
	private static byte HKECMELGAOF(int CDBBOGJDAGP, int NOEININIMIL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8485A30", Offset = "0x8484E30", VA = "0x188485A30")]
	internal static HLAFCICCABI AAGBOPIEMBE(BPHMKJHOLKM INGBCONOOGH, MHFAEJPNHJP CNKCCCNPKFD)
	{
		return default(HLAFCICCABI);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8486200", Offset = "0x8485600", VA = "0x188486200")]
	internal static void FDMOJFMGAAL(HLAFCICCABI FELIADFOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8485CF0", Offset = "0x84850F0", VA = "0x188485CF0")]
	private static void ADDOFGCNACB(int HLNAOJHAMJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum JBONMLMLPEF
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
public interface NJNAIFONKOA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool FMMKOJMHINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DGILJGPJMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool JPFFJEKGMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool JFGKMHHCPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool NJALDODEGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DOLPOPGOPHL
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DLPIBPPJHKH(JFEFIMDBPDG MNCIANLLPKI, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GENIEOAEEJK(JFEFIMDBPDG PFBCECGNMCA, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GOJDCBILCPP(JHOKCELOIPE MLOJEBHGPDG, int NOEININIMIL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DGBOOFMICCJ : JFEFIMDBPDG, NJNAIFONKOA
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int KAMCAELFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADGMGEAPMPL(OLFJLJLPMHJ PDPKIFONADM, int NOEININIMIL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JFEFIMDBPDG : NJNAIFONKOA
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum DMJLGEEBCBO
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
	bool BICJIHBKNBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool BANFCIKEAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool BFFHOANLILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OLFJLJLPMHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool LMOFJEMIAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	BFBNMLCCBFM FDBBDIDBLNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	GEOGCBPGONN CENAHJPBCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 BKPAIEKHLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	quaternion GGEGPGBJIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float3 HNGFPHJMIIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	HPLJMLNNILP NOKPIKBDEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	GEGMIDKLLFN LEHEPOAPIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float MEODOKMAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 NJLDOKPPBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float FHGBEGDHLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	HNPEOKBOCPL HHPKHHAHCHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface JPGIHALMGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float3 CGGNGHCCNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float3 BKEPJIGJHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion DNIJMCPEGEM(float3 HAECFLIPIHK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface GEOGCBPGONN
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool GFMCGDGBAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool HNCCECMKHON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool AFJMPBCMPHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float JLFFJAAFCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int JOLDDADFICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int CKLHKBGOHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CGGCMADFNHN(JPGIHALMGMK PDPKIFONADM, int NOEININIMIL);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.OMRoom)]
public class ICJBCAOJDPK
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ICJBCAOJDPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface FKFLBFFCAHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Guid GJCEEGEPJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ILBNHMHOCBF(Guid LIKDDKMGILA, Guid BBEBJBEHHMM, Guid EFGKDOGJIFK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JIOEEABHKAN(Guid LIKDDKMGILA, Guid[] EIFCLCCCDLP, Guid EFGKDOGJIFK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid MIDFCBCJKFC(Guid LAGHGCFFPCD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NKFAADEFGPG(NAIIODHHNBF DIGICOCJANK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IJFEDHNFPEB(Guid LAGHGCFFPCD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DAOCGFGBNDA(DJKDJAMGBFG GHGICOIENDP, Guid AAHKGBJCCPN);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BNCBOFHJCJI(Guid LAGHGCFFPCD, bool DGKJCLCLLMA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GICPJGIHKEO(Guid LAGHGCFFPCD, DNOIABBOEPJ BINDKDHEIJE);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LCIIHNIMDGC(DNOIABBOEPJ BINDKDHEIJE);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LGKBOLMCEPA(NAIIODHHNBF HNIIKCBNMGN);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface HNFJKCNJOKJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface DCDDDGAKECO
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "0")]
	void JKCCPNICIIJ(bool MOELHOCKLNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface FOKGOKMAKMH
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	DCDDDGAKECO FPLEKHOEGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	DPGAKGCCDMH BNHDHBGCKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	OKMEFBNAIBF FOLHKCJJDBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	KLEHIJJEPON CPCGPHPDDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	ODHKBNJBHLC BNOABGDLCMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	OBPFGCGOKMH DCJPCOEHCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	OMNPEBMHJAI BMPKOCCOGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	BEBAENHOIFH GICIDEKNNIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface DPGAKGCCDMH
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	string EALCLFIJMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface KPANNKKEMDD
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJIIFMDCPCA(Action ENDEKEOKCCM, bool BIECLPLLHBD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NNKEPADHFII(string HDNPPEBJPAE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LNCPBNNHJLB(string HDNPPEBJPAE, int ABINAMGBLJP);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MAILFGBCAPL([Out] bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BBEANACGPIA([Out] bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PEOMOLPJMKE([Out] int CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KFBBFAJKMJD([Out] bool CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface OKMEFBNAIBF
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "0")]
	void INCEBMNDKLH(bool DGKJCLCLLMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface KLEHIJJEPON
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid NCJMGLPJGNM;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid FBOGIPANAOP;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid HLOHBGKOOLN;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid GGDJJNNOGCA;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool JCDIDCABFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool LHHHEGIDBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool JIKHFCGCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool BHFLEPMCBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x848D3B0", Offset = "0x848C7B0", VA = "0x18848D3B0", Slot = "4")]
	string[] FPPAJIGPELF(DAKCGOEDMGE KCBLPMENKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFGMPGBHBOE();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x848D440", Offset = "0x848C840", VA = "0x18848D440", Slot = "6")]
	Guid NDOHEHKBDGF(Guid PNKJNPAINAL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int FBLONFLIHMN(DAKCGOEDMGE KCBLPMENKNL);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KGCIALJMPDA(DAKCGOEDMGE KCBLPMENKNL, NativeArray<LHJNPELMGLI> JLGFHLBOOED, NativeList<UniformTRS> NHOHCIEFKBN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int HOGMKAFNDPK(Guid OOOANFDGEED);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KJDCCAHIIAF(string BHECMNLMABG, [Out] Guid OOOANFDGEED);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string BJAELIAAFAC(Guid OOOANFDGEED);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CHIGGAEOBKE(RRObjectPrefabData DHKKEJGICCH, [Out] LocalId MEOOAHKPJCE);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LGOFOLFOCNA<byte[]> BBDGJLDMKAJ(NativeArray<LHJNPELMGLI> LJJPLAENNHO);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GBBDOLLGOIL(byte[] CPILNPHCFJN);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GameObject IPNDDIFOLMK(string BHECMNLMABG);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NKGPKKPODNM(Transform GANAIKEBLIG, RRObjectPrefabData IFKHGFHFPFH, JHFFNIJDHNE HFJHENFIDEF);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LDACBKBAJEP(DAKCGOEDMGE KCBLPMENKNL, NativeParallelHashMap<Guid, LocalId> BLNECLCDHNP, [Out] Exception GGJDDHMDBJI);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DJEIINPHCNH(DAKCGOEDMGE KCBLPMENKNL, NativeParallelHashMap<Guid, LocalId> BLNECLCDHNP, [Out] NativeArray<LocalId> FGABDCIOGLK, [Out] NativeArray<LocalId> BNMOMPBEPGM, [Out] NativeArray<AuthoredLocalPoseData> PABALJLHEBA, Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "19")]
	void NDGCIEJHMNC(DAKCGOEDMGE PHIIDLOGBDN, NativeArray<int> PCCEEKOEHBF, PNBCFLDECIA<GameObject> BIAMEJOODGJ, LGOFOLFOCNA<GameObject> CFJKFOLNDDF, JBONMLMLPEF BBCBCJEJODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AEMNEODAAAK();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "21")]
	void OFEKEJNACMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "22")]
	void KBDJLJJEMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "23")]
	bool JDMOBCJMCPL(DAKCGOEDMGE KCBLPMENKNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "24")]
	DOLPOPGOPHL MFEFAIGIGFP(DAKCGOEDMGE KCBLPMENKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "25")]
	void MJPNBJHNMPO(Guid LEPFIPKMFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "26")]
	bool IAAJPFAKFGL(Guid LEPFIPKMFPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x848D470", Offset = "0x848C870", VA = "0x18848D470")]
	static KLEHIJJEPON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface IJECHFPJLDD
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	long IGCFJMCPEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long MGGMBAINOIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface ODHKBNJBHLC
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool FICPEIIDOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int MGJGFEBPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int OMGCBNLPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool FDLAOAHPOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	int OPGPENFMDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
	void CJLJIMJKBHG(JEOBLPECIJA EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "6")]
	void HHCHKKGOAHK(bool PCGLGJPLFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "7")]
	bool GOFEIMLMKBD(NNAECDFEPDN BDBJAOEOBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
	void IBNFBGCHIMH(object JPPAFNCCIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "9")]
	void OJBOKBBOFEN(object JPPAFNCCIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GMDENNOCGLF(Action<object> PDBKPPOHBCI);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KEJIJEBPLEI(Action<object> PDBKPPOHBCI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "12")]
	void PKHIMFJDAKM(NativeArray<ViewId> NKGFOLNGAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "13")]
	void BNHCLLAEJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "14")]
	void AALBNPHKLBM(NKPPOELGPAG IIHAKBEOLJD, ReadOnlySpan<byte> NGIAGNLBILI, NNAECDFEPDN IDDLNDPPHII, bool NBOLBMEBBJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "15")]
	void AALBNPHKLBM(NKPPOELGPAG IIHAKBEOLJD, ReadOnlySpan<byte> BFMHKKENLNI, bool NBOLBMEBBJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "16")]
	void AALBNPHKLBM(NKPPOELGPAG IIHAKBEOLJD, ReadOnlySpan<byte> BFMHKKENLNI, ReadOnlySpan<byte> ABADDOIAKHN, bool NBOLBMEBBJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "17")]
	void GHJDDKFFJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "18")]
	void LIAHBHJGKJJ(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "19")]
	void JJJHFANDKND(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "20")]
	void DJNIPNMKHDD(Dictionary<object, object> AFOBPHFGGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "21")]
	void PGHLDBCHBDB(NativeList<DNOIABBOEPJ> LGPLPGOKCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "23")]
	void KJNHDHHODHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "24")]
	void GIJJGOBBIJH(List<object> LIBOFBBNJID, int FDIBAFEDFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "25")]
	void KAFEMJGJOLN(int OFBCKMCDDOO, object FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "26")]
	void EFDCGCLMBCN(NNAECDFEPDN BDBJAOEOBNM, object FJPPKFAJKIF, bool FLPAGODNJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "27")]
	void BNEJFADOIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "28")]
	void IDIAEOACJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class NBEAMKDHCMB
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x84907C0", Offset = "0x848FBC0", VA = "0x1884907C0")]
	public static EMCFEPIFMDJ LCLLMAAMCMJ(this ODHKBNJBHLC ANBICBPBIDK, object MONGIMOHLAO)
	{
		return default(EMCFEPIFMDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct EMCFEPIFMDJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private ODHKBNJBHLC ANBICBPBIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object MONGIMOHLAO;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x84824B0", Offset = "0x84818B0", VA = "0x1884824B0")]
	public EMCFEPIFMDJ(ODHKBNJBHLC ANBICBPBIDK, object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8482460", Offset = "0x8481860", VA = "0x188482460", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CFFCGEADBGP
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void PMDHHBLABCA(ViewId MIMIGBMDBGE, LPDMMEHBJGN DBDCHOIHLLL, int KEJCMKLNFBJ);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "0")]
	void GEPJKPKHGPB(PMDHHBLABCA BCMEKIBMJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "1")]
	void OMGGOOJKNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "2")]
	void HHJIGHLODPD(KMOGAEBEGPF EGMDPKHDKLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface NOMFPPCGLPD
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.Application)]
public interface OBPFGCGOKMH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct GOPLNICJJBL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private OBPFGCGOKMH MJBCDGOLCIF;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x84842F0", Offset = "0x84836F0", VA = "0x1884842F0")]
		public GOPLNICJJBL(OBPFGCGOKMH MJBCDGOLCIF, string LNOGNANOHAB, string HNGHJDFFNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8484230", Offset = "0x8483630", VA = "0x188484230", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct OMLHIOMFLAL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private OBPFGCGOKMH MJBCDGOLCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task KDHFABGBLNO;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x84930C0", Offset = "0x84924C0", VA = "0x1884930C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "0")]
	void NEPJKFCOCBI(string AFDNIPHJHMO, float DLCLIHPGOLF = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "1")]
	void OEDNAOHKABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGEOANGBFOA(bool MLIAKBCNAFP, string LNOGNANOHAB, string HNGHJDFFNCI);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "3")]
	void PNGGPKEBKFH(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EHJNMOJHJOJ
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8482240", Offset = "0x8481640", VA = "0x188482240")]
	public static OBPFGCGOKMH.GOPLNICJJBL BMGNMJNACLJ(this OBPFGCGOKMH ANBICBPBIDK, string LNOGNANOHAB, string HNGHJDFFNCI)
	{
		return default(OBPFGCGOKMH.GOPLNICJJBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface HNIHIAMHFED
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PMEMACPOBBA(GameObject JBJNKCGNJKP);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKPGLOLNBGO(GameObject JBJNKCGNJKP);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ILBBIOFMIPI(int BDBJAOEOBNM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object EOLDLLLINIH(NAIIODHHNBF HNIIKCBNMGN, GameObject JBJNKCGNJKP, Action<NAIIODHHNBF, int> BFDLNHAHOHH);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPCOLFIALKP(GameObject JBJNKCGNJKP, object EJJBMNMLMDF);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NFJFCKCKMKG
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLMGNGFJADE(JMAJLEBDBPE CIJDBPBBPNJ, JBGEMEIIOHE ALNLOCPIMLG);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface OFJCBAPOBJG
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COFPFOKABJF(object DEJGDIIDCDN, NativeList<byte> NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object DGFNGGGAAON(NativeArray<byte> NGIAGNLBILI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface KJGLCENFHFH
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool MIKCPHBKHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate LLPCMBJOFBH(CEBAJGBFBNL HOFGMCIGLMP, Action<CEBAJGBFBNL> BFDLNHAHOHH);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOFGBNNKNDN(CEBAJGBFBNL HOFGMCIGLMP, Delegate BFDLNHAHOHH);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate AFEGECANDPJ(CEBAJGBFBNL HOFGMCIGLMP, Action<CEBAJGBFBNL> KPPKFBGIKHN);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODIHNDLDKDP(CEBAJGBFBNL HOFGMCIGLMP, Delegate BFDLNHAHOHH);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LFPFNEMDNPA(CEBAJGBFBNL HOFGMCIGLMP);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CEBAJGBFBNL CKNEHJLPCCM(GameObject JBJNKCGNJKP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface KJDELFGFKKL
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int NLDPMDIHKOM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int CANHHHHGILA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool DACFNJHPGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool GELCBHBHAJN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NAIIODHHNBF ILHNEFJJMDD(int BDBJAOEOBNM);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PEIFNJNIMHA(GameObject KIJHAHNNEDE, JobHandle KECEFELGOKH);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface CBPFPBIOLFG
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLMGNGFJADE(int CJKINMFPLED, JBGEMEIIOHE BJDGKGEHBAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface OMNPEBMHJAI
{
	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool HJOLGGCJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface HHCMFEOCFNN
{
	[Cpp2IlInjected.Token(Token = "0x17000084")]
	KGMOHGCFKDB AIKCJPBGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	IEKGCOIIEHP NJHODAGHHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool EADFMHEKLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GNADHBDGILG(Transform GANAIKEBLIG);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECCNKLHEPMF(Transform GANAIKEBLIG, HGDKDFHGHAK DFKMHNAMFBL);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBKENCMOBOE(Transform GANAIKEBLIG, MPJPIJDIFLM ODCHPDHAEIG);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface BEBAENHOIFH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action CNOMJIKPPJJ;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface EPFHNAMCCMN
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOLLCFINECF();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ServiceLifetime(Lifetime.Application)]
public interface LJLKEHPJNAB
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JAODJOEHPNO(GameObject JBJNKCGNJKP, OEFDIDBPHAO OENPBAIOFJP, OBOGCMLDHKJ NBGOKPBDBIL);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBFNJNDGOEE(NAIIODHHNBF HNIIKCBNMGN, bool BLGBOCLBGBE, float3 BLALMLIEMEC, quaternion LKHKECEEDHL);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CKHEEELNOJA(HOKGPHAPNOB OHMIJAMJFHA);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADOHKKDCBEF(OAMEECEEOCH CCGANJILKHA, OAMEECEEOCH NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHIIPIJKCLD(OAMEECEEOCH CCGANJILKHA, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFPOIKDABLD(HOKGPHAPNOB DDMEFKOKONA);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AKKAJICKPMD(DAKCGOEDMGE EEJGFEMDNJK, ReadOnlySpan<Guid> AOHECEDBPAA, ReadOnlySpan<int> MGBFPMKCDHM, LGOFOLFOCNA<GameObject> JECJAIDNGIA);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HFFAIIPDLAL(BCFFHAFDNGI JDBDJBFOEIE);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BACBBBLDMFK(DNEHDELGLIN GBNIFHHKGFK, DNEHDELGLIN JJNENCGIGIK);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CNJECHDODJA(DNEHDELGLIN GBNIFHHKGFK, DNEHDELGLIN JJNENCGIGIK);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BKMKHGKLHPA(NAIIODHHNBF LIDICEDHKNP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct DNDDLOBKIBG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> NGIAGNLBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle FELIADFOOJH;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8481550", Offset = "0x8480950", VA = "0x188481550")]
	public DNDDLOBKIBG(ReadOnlyMemory<byte> EKMAOLGBFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8481510", Offset = "0x8480910", VA = "0x188481510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum FKHMHBGLPKA
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
public struct DAKCGOEDMGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString ELNNPAKOCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object PKDNHODHIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object JGBHCIGLLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> CIPCJHKEPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool MNDKPBCCNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public FJEGFHFPJNA.HHBNHEHKJPL? JJIDBOMKKNI;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8480490", Offset = "0x847F890", VA = "0x188480490")]
	public DAKCGOEDMGE(ByteString ELNNPAKOCNP, [Optional] object PKDNHODHIFE, [Optional] object JGBHCIGLLNN, [Optional] IEnumerable<string> CIPCJHKEPPI, bool MNDKPBCCNKO = true, [Optional] FJEGFHFPJNA.HHBNHEHKJPL? JJIDBOMKKNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct ACDBCALEHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object PGJMPOIJALC;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct LHJNPELMGLI
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Flags]
	public enum PJBAFJGGHCA
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
	public RRObjectPrefabData ADIIJMJHCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid KBCJANMKKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid EFDJLGAFNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid LMENFEIANED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid LNINEPECEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public PJBAFJGGHCA DPALHGCDOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 FJECCHNNLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int DENMIBAHAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public CPBFPLMGPJD ENFELPCKMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int KHHKDLOJCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int MJBCEEPFPNB;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Guid GHBKCDOHLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x54DBEA0", Offset = "0x54DB2A0", VA = "0x1854DBEA0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool ODEPDGMDIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x848DB80", Offset = "0x848CF80", VA = "0x18848DB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool DMBJAHMJOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x848DBB0", Offset = "0x848CFB0", VA = "0x18848DBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool LGCCLMIGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x848DBA0", Offset = "0x848CFA0", VA = "0x18848DBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool JOIJJLOEMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x848DB90", Offset = "0x848CF90", VA = "0x18848DB90")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct LBAHEIAMMPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly EIEFAIGBPHF FEMDGHMCLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly EIEFAIGBPHF BBCNKKJCHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint OIAAADFNNNH;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x848D590", Offset = "0x848C990", VA = "0x18848D590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct OLJPIGFMKBM
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly LBAHEIAMMPK ENDEKEOKCCM;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8482AD0", Offset = "0x8481ED0", VA = "0x188482AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct EPCLFHCFPFO
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly LBAHEIAMMPK ENDEKEOKCCM;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8482AD0", Offset = "0x8481ED0", VA = "0x188482AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct LEPOAEOBHIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint OIAAADFNNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool JJFPDHDFOPH;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x848D800", Offset = "0x848CC00", VA = "0x18848D800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct EIEFAIGBPHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int FDIDNNCIDHK;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x84822D0", Offset = "0x84816D0", VA = "0x1884822D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[ServiceLifetime(Lifetime.Application)]
public interface BKKOBHDBLPD
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	AILGAELBOHC MOCEKADIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface DJKDJAMGBFG
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface OIFBGDPDEIB
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class EEGIPLJALIC
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3B2DEA0", Offset = "0x3B2D2A0", VA = "0x183B2DEA0")]
	public static OAMEECEEOCH BGCBBJFMLJO<T>(this T HNIIKCBNMGN) where T : DJKDJAMGBFG
	{
		return default(OAMEECEEOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8482100", Offset = "0x8481500", VA = "0x188482100")]
	public static MonoBehaviour JIDGKEOHLEE(this DJKDJAMGBFG HNIIKCBNMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8482180", Offset = "0x8481580", VA = "0x188482180")]
	public static GameObject KBGJEENOIEL(this DJKDJAMGBFG HNIIKCBNMGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface GDAMEGFOJLE : DJKDJAMGBFG
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(NAIIODHHNBF FBNJAHIFLKC);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface PHPIAOCFGIL : DJKDJAMGBFG
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IHFOEPCDBAC
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void LNKLHFMANNN(ECJJJEIONOJ EFAHPLLMNKD);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LNKLHFMANNN GNAOPGOGLGD;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface IENPEAHCJIM
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface PKDPNMJBNHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface GJJDPKCKHPO
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(NAIIODHHNBF LKGAIIJPKLH);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool KLELFJHGIBI);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBBHKMMNPAM(NAIIODHHNBF ANKACPFCKKH);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface LGIHOGJKCKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(HHMPDIJPAEB FEGKKMPCBHG);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface HHMPDIJPAEB
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	GameObject JBJNKCGNJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Transform GANAIKEBLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	ANFFNMLLNBD MNJBJHJKOND
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool AOHOACHBAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLAIHHNKDOB(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KPDFEHPKBMM GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class BHMIKDAOJMB
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x847EAD0", Offset = "0x847DED0", VA = "0x18847EAD0")]
	public static void PCIAELJEHIC(this HHMPDIJPAEB PAIBDGNODBA, JHFFNIJDHNE HFJHENFIDEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface ANFFNMLLNBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000092")]
	NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Rigidbody GKLCHHJFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	HHMPDIJPAEB LAHHNIHOPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	GameObject KBGJEENOIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Transform MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	ANFFNMLLNBD BIMLAPPNEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	ANFFNMLLNBD NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	int KMJPCKADHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	bool NHNICGNNADL
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool LFPFNEMDNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool OLDGACHJNBG
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	LLFNGCOOPGE MLBJGFMIACD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	BNNLLMJJDPO JIANNGPCJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	float ICCECLDBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Vector3 DCFGNKAPHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Vector3 BKDGJEFAIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 PMMAEKMJMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 HCLKOEFECIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	bool FPCMCBBMDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool MCFLDOOEFGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool ELIKEPNCGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool GFOJNPBFEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Vector3 OAGNCLJEPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Vector3 IEGOLHEPHID
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Vector3 HDFKHPAMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 AOACKPCHPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	float IJKIJHPMLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	float CIKHNEOEHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Vector3 KIDPHBFLJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Quaternion MFJGOBAIBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	float KACFOJIAIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float OMBMPLDENDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	bool IJMGAJGOEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	LDGMPMKAKEN FBMLKEHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool HKJHCJNDBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Transform GFKDPMFHONJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	Vector3 MFPBOIJJBPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	float KDBDCMOKGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	float MJGMGCOGIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	Quaternion DOALJHOHDAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	Vector3 CGGNGHCCNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Quaternion BNPIKAOEGBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	RigidbodyConstraints KKEJJCCKHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	bool LKGHGHPGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	CollisionDetectionMode FDGANLMDOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	bool BEHIPMAANFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CIOBHEEBBCO KMKICDNANGK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CIOBHEEBBCO DLLONEOIIFN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CIOBHEEBBCO NACADNJMMHN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event CIOBHEEBBCO FHJBMOPMOKC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CIOBHEEBBCO HAMHFGOADKA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CIOBHEEBBCO EIMNEJBGAEP;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CIOBHEEBBCO FCAKFDDLEJN;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MBOJNAFHAKB MPECPIOGIDN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<IEEJIDPBMPL, IEEJIDPBMPL> MDCACKDOAIF;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "26")]
	ANFFNMLLNBD ABHJEFONKKD(int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void LNIJCCJEKMJ((Quaternion rot, Vector3 moments) AMFBBMEJKPC);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void PFPNBAHGKKL();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void DHKJLAFONKM();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void IBPAEEDCKLH();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void AKLLODDLMDD();

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void AELDHAAAHGC();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void PPKDCGAIMAJ(ANFFNMLLNBD CBMEHPPMEEA, bool FLJJABAPNLC = false);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void PAOBJJAJAEB(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void KLEODOBJDCF(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 KCCLBLKIBBD(Vector3 DDEFJFOMGFG);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 KAPGKHJAMCO(Vector3 MIAAPPECFHB);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void DGOJJNBLAOE();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void FCDBAFEMNKF();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void KKABJONKKLB();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void PAPIHDOEIPB(Vector3 PABEIKNKFPG, Vector3 FBIPAGEENGH);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void HKFEKAPGFDA(Vector3 PLHEOKHEDMJ, Vector3 IGINODMGIBP);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void CJMGIGGKHMA(Vector3 NHCNIILPJKC);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void CBCJLHNCKAK(DLGHIGIHDGD JJEMFOJGMKG, Vector3 PEJHAMCEMGO, float LBCMHCOCBKI, float EIHOHPGGLMO = 8f, float CCOOALGJJEJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void JLDELFHKIIM(EPFKLCJJAED ABMEPGCCPLP, Vector3 OGPLLELJPBM, float CDDONLBHEGI = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void KPJFGOHALMI(EPFKLCJJAED ABMEPGCCPLP, Vector3 EMLGDFFEJED, float MCLHJJMOIDC = 7f, float NCKPOIOOOGF = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 CCDKCMOKFPN(Vector3 CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 IOPOEGOFCMI(Vector3 CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void MBEICEELOON();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void JAFBLENMJGF(ANFFNMLLNBD HAMLJAHLKDM, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void OOLJOCJMIDC(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void ENHLDHHICDM();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void CHBHLGLNPJK();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void MIOIMAEDDIO();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool COOIHAEOEHK();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void NPIAHGMDHCB();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void BLMFBLLAHBD(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void EMMIHPCFILD(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void AFBJHDBFHKA(object MONGIMOHLAO, bool GHMABHCPHDE);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void PNHKMKPKMHB(Vector3 LKOMPDMLLGJ, Quaternion MONBLLPGNBP);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void FFMIKBMNCFN(Vector3 NLDEGBJACOA, Quaternion OAEOLICGPGP);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool PJJEEKPMEKJ(float ECDGIBOACGM);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void HCIPJGNLINC(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void ICBGEBNIKAO(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void PLDBGMIIOCJ(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void HEBJHCHCMEF(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void ALKPCGBNCBJ(Vector3 KBIBIFOFAKG, ForceMode MIGBGLJJIBM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void MBFECIAIEKD(Vector3 KBIBIFOFAKG, Vector3 LBCFHLNAPLC, ForceMode MIGBGLJJIBM);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void GOPABEPLFHG(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void MLNBEBIEEOK(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool ELNPMFAIDPO(Vector3 NLDMHMFAEEN, [Out] RaycastHit EACMJKDJDDD, float ICEDCEOLBDI);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void BGNDJKEFEMN();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface BNNLLMJJDPO
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class GAPOMPKELEF : BNNLLMJJDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GAPOMPKELEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "0")]
	void ONDAKCCHMDC(Vector3 HNNNCHDCJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "1")]
	void AGMBEBEGNNO(Vector3 NBPDCMBDPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "2")]
	void HGBLBFPENIC(Vector3 HNNNCHDCJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "3")]
	void GAONDFHIJCC(Vector3 NBPDCMBDPJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LLFNGCOOPGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 GFEBPILLHGG();

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 EOEFKHCGNPP();

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPFDPFFEEAK(float DKICOKAOCCL, float AEGKBKICDDK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate void CIOBHEEBBCO(HHMPDIJPAEB GFIEMJGAEEK);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum BNBKLNKNBGJ
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
public enum DLGHIGIHDGD
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
public delegate void MBOJNAFHAKB(HHMPDIJPAEB GFIEMJGAEEK, bool FLJJABAPNLC = false);
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum EPFKLCJJAED
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct KPDFEHPKBMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody DGOBDNAOFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object PKMDJAGDKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 FDILJFDIMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 DMDGKBPCGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public IAOENOOJLJP MMGBJKAOGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool MKBIDKFOFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool BKLOHMPABHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool KMMJFBKKCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool PKNNGKDDDGI;
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct OAMEECEEOCH : IEquatable<OAMEECEEOCH>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly OAMEECEEOCH FJMDDOMHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public GameObject JBJNKCGNJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8491670", Offset = "0x8490A70", VA = "0x188491670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public DNOIABBOEPJ ADBOMMHDMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8491800", Offset = "0x8490C00", VA = "0x188491800")]
		get
		{
			return default(DNOIABBOEPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public PBMOMKKFMLL KPHMDALIOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x84915D0", Offset = "0x84909D0", VA = "0x1884915D0")]
		get
		{
			return default(PBMOMKKFMLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public RRObjectPrefabData OLIIACOFOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8491340", Offset = "0x8490740", VA = "0x188491340")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool DJLBNPCDJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x84912D0", Offset = "0x84906D0", VA = "0x1884912D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool COMNHOCIIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8491CC0", Offset = "0x84910C0", VA = "0x188491CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool LMOFJEMIAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x84914A0", Offset = "0x84908A0", VA = "0x1884914A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool LNJILCHOIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8491A60", Offset = "0x8490E60", VA = "0x188491A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool NDAGBBLFMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8491A80", Offset = "0x8490E80", VA = "0x188491A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool HMBEAEMHIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x84919E0", Offset = "0x8490DE0", VA = "0x1884919E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool MPJNHNNJJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x84910C0", Offset = "0x84904C0", VA = "0x1884910C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool DCFEAOEFKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8491180", Offset = "0x8490580", VA = "0x188491180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool KOOLADLOOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8491510", Offset = "0x8490910", VA = "0x188491510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool HHPKAMEALNM
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8491A10", Offset = "0x8490E10", VA = "0x188491A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool ONLAAINJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8490F60", Offset = "0x8490360", VA = "0x188490F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool DOFENDJGFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8491C30", Offset = "0x8491030", VA = "0x188491C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool OKAKJDDGBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8490FA0", Offset = "0x84903A0", VA = "0x188490FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool AOLLBKDABHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x84918E0", Offset = "0x8490CE0", VA = "0x1884918E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool JCIJHMEPNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x84918A0", Offset = "0x8490CA0", VA = "0x1884918A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool CLLBFIEKKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8491920", Offset = "0x8490D20", VA = "0x188491920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public OPODEHDLJBG IAIFLECIPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OPODEHDLJBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DLOPPHMOJOH BMHKKOMHHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(DLOPPHMOJOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public OPADJMIPFIB GLJEAJOJMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OPADJMIPFIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public MCJNIHMNFMK JFIDDBCNOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(MCJNIHMNFMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public MNNHGIPNIJI AECEHIGJCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(MNNHGIPNIJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public KJJLIHNLFPL MEAPFAMGMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(KJJLIHNLFPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public CCIIDFNJCNM KGOJMONMPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(CCIIDFNJCNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public ILJFKMDMPJP KEBENCGPEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(ILJFKMDMPJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public EPMLKGMJNOH IOJMACCMCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(EPMLKGMJNOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public PHFBHFNNAKO DAKGPOOCGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(PHFBHFNNAKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public HDDFJHOAKIA MGKJOCIBKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(HDDFJHOAKIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public OHDIJAJMPAO KEEEEPHPPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OHDIJAJMPAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FNKANPIGJGG PHMAGIIOHFD
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(FNKANPIGJGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public OAAMLAKENCA AOOKLANMAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAAMLAKENCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public PLCBKCFPCPC GDCBEHHHIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(PLCBKCFPCPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool LPOCFLBEGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8491B40", Offset = "0x8490F40", VA = "0x188491B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool IMIGHGMJFKP
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8491140", Offset = "0x8490540", VA = "0x188491140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool JJFIFLJPABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8490E20", Offset = "0x8490220", VA = "0x188490E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool KNLAECGHIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8491A50", Offset = "0x8490E50", VA = "0x188491A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool OMMFOAKCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8491460", Offset = "0x8490860", VA = "0x188491460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool FBHADDLPGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8491100", Offset = "0x8490500", VA = "0x188491100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool CPPPAFICDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8491080", Offset = "0x8490480", VA = "0x188491080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IKBPCFPMPFP MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(IKBPCFPMPFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public JLIKDJCPJDF OFBDFJKOLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(JLIKDJCPJDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private MHFAEJPNHJP EPCFGMJMGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x84891B0", Offset = "0x84885B0", VA = "0x1884891B0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static OAMEECEEOCH GKKMDDPCKIG(NAIIODHHNBF FBNJAHIFLKC)
	{
		return default(OAMEECEEOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x84911C0", Offset = "0x84905C0", VA = "0x1884911C0")]
	public AAECFLCMDEN ENPFNGJANLA()
	{
		return default(AAECFLCMDEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x84915A0", Offset = "0x84909A0", VA = "0x1884915A0")]
	public HIGOMPAEDIJ IKHHJPJFALE()
	{
		return default(HIGOMPAEDIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8491960", Offset = "0x8490D60", VA = "0x188491960")]
	public DDJGBJOODNH KLHGJDENKHP()
	{
		return default(DDJGBJOODNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x84919B0", Offset = "0x8490DB0", VA = "0x1884919B0")]
	public PIMPMKANLEA LLEEGHNELMA()
	{
		return default(PIMPMKANLEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8491CE0", Offset = "0x84910E0", VA = "0x188491CE0")]
	public AIIHBDEHPFE PPGMHMEPNLK()
	{
		return default(AIIHBDEHPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x84912F0", Offset = "0x84906F0", VA = "0x1884912F0")]
	public MMALBCNCFLE GANONENCMHD()
	{
		return default(MMALBCNCFLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8491550", Offset = "0x8490950", VA = "0x188491550")]
	public DNEHDELGLIN IHDGLCFPKAG()
	{
		return default(DNEHDELGLIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8491C70", Offset = "0x8491070", VA = "0x188491C70")]
	public FGPKHIEJAJN PKDMDJLFHEF()
	{
		return default(FGPKHIEJAJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x84914C0", Offset = "0x84908C0", VA = "0x1884914C0")]
	public BKNLJFGPIFB GPJBGHKMINK()
	{
		return default(BKNLJFGPIFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8490E60", Offset = "0x8490260", VA = "0x188490E60")]
	public void ACKDDGPJDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x8491AA0", Offset = "0x8490EA0", VA = "0x188491AA0")]
	public void ONLDIMNIKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x8490FE0", Offset = "0x84903E0", VA = "0x188490FE0")]
	public bool CELEBOFALBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x8491D30", Offset = "0x8491130", VA = "0x188491D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public OAMEECEEOCH(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x847D0F0", Offset = "0x847C4F0", VA = "0x18847D0F0")]
	public static bool GKKMDDPCKIG(OAMEECEEOCH CBMEHPPMEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static NAIIODHHNBF GKKMDDPCKIG(OAMEECEEOCH CBMEHPPMEEA)
	{
		return default(NAIIODHHNBF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x84817F0", Offset = "0x8480BF0", VA = "0x1884817F0")]
	public static bool ILMCFLMCOJH(OAMEECEEOCH HCFCOMCPJPA, OAMEECEEOCH JOCIBENNGKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x8481600", Offset = "0x8480A00", VA = "0x188481600")]
	public static bool AMDBHCBNEEF(OAMEECEEOCH HCFCOMCPJPA, OAMEECEEOCH JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8491240", Offset = "0x8490640", VA = "0x188491240", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(OAMEECEEOCH LHDOHAKINKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct FNKANPIGJGG : IEquatable<FNKANPIGJGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private MHFHPGBIGKN GLOEAFPBOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8483950", Offset = "0x8482D50", VA = "0x188483950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8483F60", Offset = "0x8483360", VA = "0x188483F60")]
	public void OBLEIEOJBEB(uint CLNGGGMIBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8483BD0", Offset = "0x8482FD0", VA = "0x188483BD0")]
	public bool HJNFACCJLEH([Out] uint CLNGGGMIBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8484060", Offset = "0x8483460", VA = "0x188484060")]
	public bool OPHNEAHJGLD([Out] uint CLNGGGMIBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x84839B0", Offset = "0x8482DB0", VA = "0x1884839B0")]
	public void DOPBNLOPGBG(string CLNGGGMIBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8483CD0", Offset = "0x84830D0", VA = "0x188483CD0")]
	[CanBeNull]
	public string JGIJACJDODI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8483DE0", Offset = "0x84831E0", VA = "0x188483DE0")]
	public bool MNOGLCPBFDB([Out] string LOIIBOHGNMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8483B30", Offset = "0x8482F30", VA = "0x188483B30")]
	public void FJOOJADNIEG(string LOIIBOHGNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public FNKANPIGJGG(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8483AA0", Offset = "0x8482EA0", VA = "0x188483AA0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(FNKANPIGJGG LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct OPODEHDLJBG : IEquatable<OPODEHDLJBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private CFLPOFDACJP EHFDOIPKCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8494920", Offset = "0x8493D20", VA = "0x188494920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private MHFHPGBIGKN FIBPCEPJPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8494BC0", Offset = "0x8493FC0", VA = "0x188494BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool DFHGLHHGLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8494CB0", Offset = "0x84940B0", VA = "0x188494CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool ADGFGHKBKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8494FA0", Offset = "0x84943A0", VA = "0x188494FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool AFKGOMFGCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8494EE0", Offset = "0x84942E0", VA = "0x188494EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Guid HGNEMFEIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8494A20", Offset = "0x8493E20", VA = "0x188494A20")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Guid NOIICONGMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8494E60", Offset = "0x8494260", VA = "0x188494E60")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Guid LNNMIPHBMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8494FE0", Offset = "0x84943E0", VA = "0x188494FE0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public JLIKDJCPJDF OFBDFJKOLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(JLIKDJCPJDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x84951F0", Offset = "0x84945F0", VA = "0x1884951F0")]
	public bool NJJPLNODCLE([Out] Guid LAGHGCFFPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8494980", Offset = "0x8493D80", VA = "0x188494980")]
	public bool AGNCLBBAJNH([Out] Guid BBEBJBEHHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8494AA0", Offset = "0x8493EA0", VA = "0x188494AA0")]
	public void AJHIGCOHAJH(Guid DIMKOEFIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8495290", Offset = "0x8494690", VA = "0x188495290")]
	public void PIMGCNPJKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8494D40", Offset = "0x8494140", VA = "0x188494D40")]
	public Guid HLLENDAFELM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public OPODEHDLJBG(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8494C20", Offset = "0x8494020", VA = "0x188494C20", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(OPODEHDLJBG LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct DDJGBJOODNH : IEquatable<DDJGBJOODNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private DHLLNOFKNAA CCKGONINDKL
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x84806D0", Offset = "0x847FAD0", VA = "0x1884806D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public Vector3 FNABMNHHDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8480B90", Offset = "0x847FF90", VA = "0x188480B90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Quaternion NPLIDGGBLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8480730", Offset = "0x847FB30", VA = "0x188480730")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public OAMEECEEOCH NDHCJGGCCND
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8480CE0", Offset = "0x84800E0", VA = "0x188480CE0")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x8480A50", Offset = "0x847FE50", VA = "0x188480A50")]
	public HOKGPHAPNOB GLFJAKADOBH(Allocator KCEIEKBPKNP)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x8480E80", Offset = "0x8480280", VA = "0x188480E80")]
	public bool PGNGOMMMAIO(OAMEECEEOCH JIECBJMGMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x8480870", Offset = "0x847FC70", VA = "0x188480870")]
	public void DIBEBAHDEBE(Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x8480D70", Offset = "0x8480170", VA = "0x188480D70")]
	public void OINPGPKFNNH(float MJHAIBCGLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x8480510", Offset = "0x847F910", VA = "0x188480510")]
	public void AICALIGKLIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public DDJGBJOODNH(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x847D0F0", Offset = "0x847C4F0", VA = "0x18847D0F0")]
	public static bool GKKMDDPCKIG(DDJGBJOODNH CBMEHPPMEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static NAIIODHHNBF GKKMDDPCKIG(DDJGBJOODNH CBMEHPPMEEA)
	{
		return default(NAIIODHHNBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x84809C0", Offset = "0x847FDC0", VA = "0x1884809C0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(DDJGBJOODNH LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct AAECFLCMDEN : IEquatable<AAECFLCMDEN>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly AAECFLCMDEN FJMDDOMHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private DDFFIBBBDCI IPMJDAMHJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x847CF70", Offset = "0x847C370", VA = "0x18847CF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<OAMEECEEOCH> IBDCABEELNF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x847D5E0", Offset = "0x847C9E0", VA = "0x18847D5E0")]
		get
		{
			return default(Span<OAMEECEEOCH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x847D6E0", Offset = "0x847CAE0", VA = "0x18847D6E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x847CFD0", Offset = "0x847C3D0", VA = "0x18847CFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public IKBPCFPMPFP MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(IKBPCFPMPFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public JLIKDJCPJDF OFBDFJKOLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(JLIKDJCPJDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x847D140", Offset = "0x847C540", VA = "0x18847D140")]
	public void INDPPADHIJO(AAECFLCMDEN LHDOHAKINKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public AAECFLCMDEN(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x847D0F0", Offset = "0x847C4F0", VA = "0x18847D0F0")]
	public static bool GKKMDDPCKIG(AAECFLCMDEN CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x847D060", Offset = "0x847C460", VA = "0x18847D060", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(AAECFLCMDEN LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static OAMEECEEOCH GKKMDDPCKIG(AAECFLCMDEN DMFKPMONDPO)
	{
		return default(OAMEECEEOCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DefaultMember("Item")]
public struct CKKBHIEFKJN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> FKMIOCNPCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private KFNNMIHFMBA HECCBIHPCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool FJELOMHKCGN;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		[CompilerGenerated]
		readonly get
		{
			return default(OAMEECEEOCH);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public JLPPDAJAOIB FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x847FE40", Offset = "0x847F240", VA = "0x18847FE40")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x84800A0", Offset = "0x847F4A0", VA = "0x1884800A0")]
	internal CKKBHIEFKJN(OAMEECEEOCH DEJGDIIDCDN, bool FJELOMHKCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x847FF00", Offset = "0x847F300", VA = "0x18847FF00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC750", Offset = "0x3AABB50", VA = "0x183AAC750")]
	public void CDJMBKGCJMN<T>(JLPPDAJAOIB PEENICAIFOP, T CBMEHPPMEEA, [Optional] T ABINAMGBLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x847FD90", Offset = "0x847F190", VA = "0x18847FD90")]
	public void CBDHBFLGDII(JLPPDAJAOIB PEENICAIFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xAF6930", Offset = "0xAF5D30", VA = "0x180AF6930")]
	public Dictionary<int, object> IMODHHIDFFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x8480030", Offset = "0x847F430", VA = "0x188480030")]
	private readonly void OMONGHMBMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class EDDGFKLKHFE
{
	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8482040", Offset = "0x8481440", VA = "0x188482040")]
	public static CKKBHIEFKJN KMHFDNPEENN(this OAMEECEEOCH DEJGDIIDCDN)
	{
		return default(CKKBHIEFKJN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct OAAMLAKENCA : IEquatable<OAAMLAKENCA>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly OAAMLAKENCA FJMDDOMHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private bool ONLAAINJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x84909E0", Offset = "0x848FDE0", VA = "0x1884909E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 ABBAMDOHGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8490930", Offset = "0x848FD30", VA = "0x188490930")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8490C60", Offset = "0x8490060", VA = "0x188490C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x8490CC0", Offset = "0x84900C0", VA = "0x188490CC0")]
	public Vector3 KPPNBKCPDHL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x8490AD0", Offset = "0x848FED0", VA = "0x188490AD0")]
	public void COLHFBGMAGG([In] Vector3 CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x8490B50", Offset = "0x848FF50", VA = "0x188490B50")]
	public void EEBDDLKHPFH([In] Vector3 CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x8490A20", Offset = "0x848FE20", VA = "0x188490A20")]
	public bool BOHEPJFOMGN([In] Vector3 CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public OAAMLAKENCA(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8490BD0", Offset = "0x848FFD0", VA = "0x188490BD0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(OAAMLAKENCA LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8490D40", Offset = "0x8490140", VA = "0x188490D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct AHFBBPDPIID : IEquatable<AHFBBPDPIID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x847D910", Offset = "0x847CD10", VA = "0x18847D910", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(AHFBBPDPIID LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct FGPKHIEJAJN : IEquatable<FGPKHIEJAJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private NNGIBDKCHKM LENCDJIJHCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x84835F0", Offset = "0x84829F0", VA = "0x1884835F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool LKHFLHBCPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8483650", Offset = "0x8482A50", VA = "0x188483650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool CHDLCKNEPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8483820", Offset = "0x8482C20", VA = "0x188483820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public DEENLBKCLDB GAFOLKFANIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x84834C0", Offset = "0x84828C0", VA = "0x1884834C0")]
		get
		{
			return default(DEENLBKCLDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool FADLOADCMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8483240", Offset = "0x8482640", VA = "0x188483240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool LEGEANFOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8483280", Offset = "0x8482680", VA = "0x188483280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool LDKFOGFAINL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8483310", Offset = "0x8482710", VA = "0x188483310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8483070", Offset = "0x8482470", VA = "0x188483070")]
	public bool DDGABFLEEMA(FGPKHIEJAJN OEBCJHKIJIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8483780", Offset = "0x8482B80", VA = "0x188483780")]
	public bool NLKHNAFMKDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8483110", Offset = "0x8482510", VA = "0x188483110")]
	public bool DENNLKMNDJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x84833A0", Offset = "0x84827A0", VA = "0x1884833A0")]
	public ReadOnlySpan<NAIIODHHNBF> INJOOJAFNLA()
	{
		return default(ReadOnlySpan<NAIIODHHNBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public FGPKHIEJAJN(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x84817F0", Offset = "0x8480BF0", VA = "0x1884817F0")]
	public static bool ILMCFLMCOJH(FGPKHIEJAJN HCFCOMCPJPA, FGPKHIEJAJN JOCIBENNGKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8481600", Offset = "0x8480A00", VA = "0x188481600")]
	public static bool AMDBHCBNEEF(FGPKHIEJAJN HCFCOMCPJPA, FGPKHIEJAJN JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x84831B0", Offset = "0x84825B0", VA = "0x1884831B0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(FGPKHIEJAJN LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct DNEHDELGLIN : IEquatable<DNEHDELGLIN>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly DNEHDELGLIN FJMDDOMHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private NNGIBDKCHKM COCDEIBFEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8481950", Offset = "0x8480D50", VA = "0x188481950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public bool GEBMEPLEGAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x84819B0", Offset = "0x8480DB0", VA = "0x1884819B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public IKBPCFPMPFP MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(IKBPCFPMPFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8481620", Offset = "0x8480A20", VA = "0x188481620")]
	public bool DDGABFLEEMA(DNEHDELGLIN LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8481750", Offset = "0x8480B50", VA = "0x188481750")]
	public bool GHEEAAFGFJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8481870", Offset = "0x8480C70", VA = "0x188481870")]
	public bool LFKHIDEOKEL([Out] DNEHDELGLIN MPPMCPDILEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8481800", Offset = "0x8480C00", VA = "0x188481800")]
	public void KNPECEADHDI(CAKFJLPKMGI HMHEELDKLNE, bool BFGCMJHAFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public DNEHDELGLIN(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x84817F0", Offset = "0x8480BF0", VA = "0x1884817F0")]
	public static bool ILMCFLMCOJH(DNEHDELGLIN HCFCOMCPJPA, DNEHDELGLIN JOCIBENNGKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8481600", Offset = "0x8480A00", VA = "0x188481600")]
	public static bool AMDBHCBNEEF(DNEHDELGLIN HCFCOMCPJPA, DNEHDELGLIN JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x84816C0", Offset = "0x8480AC0", VA = "0x1884816C0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(DNEHDELGLIN LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct JLIKDJCPJDF : IEquatable<JLIKDJCPJDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private DDFFIBBBDCI IPMJDAMHJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x848BF50", Offset = "0x848B350", VA = "0x18848BF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public NAIIODHHNBF LBADECOKFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x848C360", Offset = "0x848B760", VA = "0x18848C360")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public OAMEECEEOCH BIMLAPPNEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x848C3F0", Offset = "0x848B7F0", VA = "0x18848C3F0")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public OAMEECEEOCH NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x848C2D0", Offset = "0x848B6D0", VA = "0x18848C2D0")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x848C480", Offset = "0x848B880", VA = "0x18848C480")]
	public Span<OAMEECEEOCH> NFIEADPKKJM()
	{
		return default(Span<OAMEECEEOCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x848C140", Offset = "0x848B540", VA = "0x18848C140")]
	public Span<OAMEECEEOCH> FFJIIIOKPGD()
	{
		return default(Span<OAMEECEEOCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x848C040", Offset = "0x848B440", VA = "0x18848C040")]
	public Span<OAMEECEEOCH> FDBNHPLAAPL()
	{
		return default(Span<OAMEECEEOCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x848BDB0", Offset = "0x848B1B0", VA = "0x18848BDB0")]
	public Span<OAMEECEEOCH> BDOPHNJJPHO()
	{
		return default(Span<OAMEECEEOCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x848C690", Offset = "0x848BA90", VA = "0x18848C690")]
	public bool PPKDCGAIMAJ(OAMEECEEOCH JIECBJMGMAC, bool LKGIHIAMELF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x848BEB0", Offset = "0x848B2B0", VA = "0x18848BEB0")]
	public bool CBALNCMOEAE(OAMEECEEOCH FBKFBKODJAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x848C580", Offset = "0x848B980", VA = "0x18848C580")]
	public OAMEECEEOCH NJABLKMLHIE(uint CBNOKFHGGEG)
	{
		return default(OAMEECEEOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x848C240", Offset = "0x848B640", VA = "0x18848C240")]
	public AAECFLCMDEN FHIIAJMGDMB()
	{
		return default(AAECFLCMDEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public JLIKDJCPJDF(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x847D0F0", Offset = "0x847C4F0", VA = "0x18847D0F0")]
	public static bool GKKMDDPCKIG(JLIKDJCPJDF CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x848BFB0", Offset = "0x848B3B0", VA = "0x18848BFB0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(JLIKDJCPJDF LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct DLOPPHMOJOH : IEquatable<DLOPPHMOJOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public string OPFNAEKCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8480FB0", Offset = "0x84803B0", VA = "0x188480FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public string MGAAJDCAMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8481390", Offset = "0x8480790", VA = "0x188481390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string ECPIGJPKMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8481040", Offset = "0x8480440", VA = "0x188481040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string JOEMPOBGJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x84810F0", Offset = "0x84804F0", VA = "0x1884810F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x8481400", Offset = "0x8480800", VA = "0x188481400")]
	public bool MNOGLCPBFDB([Out] string LOIIBOHGNMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public DLOPPHMOJOH(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8480F20", Offset = "0x8480320", VA = "0x188480F20", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(DLOPPHMOJOH LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct CCNCGBBIAIO : IEquatable<CCNCGBBIAIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x847FC00", Offset = "0x847F000", VA = "0x18847FC00", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(CCNCGBBIAIO LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct IAFELGIKOAL : IEquatable<IAFELGIKOAL>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[Flags]
	public enum AJPBNCPKBOK
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
	private static AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly IAFELGIKOAL FJMDDOMHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private MHFAEJPNHJP EPCFGMJMGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x84891B0", Offset = "0x84885B0", VA = "0x1884891B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8488BD0", Offset = "0x8487FD0", VA = "0x188488BD0")]
	public static AJPBNCPKBOK IGMKGGPMNPF(IAFELGIKOAL HCFCOMCPJPA, IAFELGIKOAL JOCIBENNGKI)
	{
		return default(AJPBNCPKBOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8488400", Offset = "0x8487800", VA = "0x188488400")]
	public bool BINALDPOPCP([Out] GameObject JIECBJMGMAC, [Out] GameObject JBJNKCGNJKP, [Out] OAMEECEEOCH HDAMCCOINNK, [Out] OAMEECEEOCH NEJKHIBABPL, [Out] Vector3 LBCFHLNAPLC, [Out] Vector3 HLPOABOJLKF, [Out] Vector3 MKEGMDDJOAI, [Out] OAMEECEEOCH GHNFGOMIMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8488930", Offset = "0x8487D30", VA = "0x188488930")]
	public bool BPPFKFAOLDG([Out] GameObject JIECBJMGMAC, [Out] GameObject JBJNKCGNJKP, [Out] OAMEECEEOCH HDAMCCOINNK, [Out] OAMEECEEOCH NEJKHIBABPL, [Out] Vector3 LBCFHLNAPLC, [Out] Vector3 HLPOABOJLKF, [Out] Vector3 MKEGMDDJOAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8488DF0", Offset = "0x84881F0", VA = "0x188488DF0")]
	private void OBLHBJHIANL(Entity MEOOAHKPJCE, EntityManager ENALKMFFCLM, MagneticAnchorData NJKNHLMOPKN, [Out] GameObject JIECBJMGMAC, [Out] GameObject JBJNKCGNJKP, [Out] OAMEECEEOCH HDAMCCOINNK, [Out] OAMEECEEOCH NEJKHIBABPL, [Out] Vector3 LBCFHLNAPLC, [Out] Vector3 HLPOABOJLKF, [Out] Vector3 MKEGMDDJOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public IAFELGIKOAL(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8488B40", Offset = "0x8487F40", VA = "0x188488B40", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(IAFELGIKOAL LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8489210", Offset = "0x8488610", VA = "0x188489210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct IEBNFPJOAPF : IEquatable<IEBNFPJOAPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8489310", Offset = "0x8488710", VA = "0x188489310", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(IEBNFPJOAPF LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct PLCBKCFPCPC : IEquatable<PLCBKCFPCPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private CAJCBBNDOID COCDEIBFEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x84966F0", Offset = "0x8495AF0", VA = "0x1884966F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public JHJGBLLNBFI JCKDHHDDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8496750", Offset = "0x8495B50", VA = "0x188496750")]
		get
		{
			return default(JHJGBLLNBFI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x84963E0", Offset = "0x84957E0", VA = "0x1884963E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public LGOFOLFOCNA<string> IPFBIMMBBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x84965E0", Offset = "0x84959E0", VA = "0x1884965E0")]
		get
		{
			return default(LGOFOLFOCNA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x84961A0", Offset = "0x84955A0", VA = "0x1884961A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public LGOFOLFOCNA<string> ICGBPMJAMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x84964C0", Offset = "0x84958C0", VA = "0x1884964C0")]
		get
		{
			return default(LGOFOLFOCNA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x84962C0", Offset = "0x84956C0", VA = "0x1884962C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public PLCBKCFPCPC(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x8496430", Offset = "0x8495830", VA = "0x188496430", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(PLCBKCFPCPC LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct OPADJMIPFIB : IEquatable<OPADJMIPFIB>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ComponentTypes MPMKAGKFAGE;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly OPADJMIPFIB FJMDDOMHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Collider IEAHOCJFNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x84934F0", Offset = "0x84928F0", VA = "0x1884934F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public CGPPANCJEFA PPNMLCDHPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x84939C0", Offset = "0x8492DC0", VA = "0x1884939C0")]
		get
		{
			return default(CGPPANCJEFA);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8493220", Offset = "0x8492620", VA = "0x188493220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public OPHMAHEJLBB MDOAOJDKIJM
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8493FC0", Offset = "0x84933C0", VA = "0x188493FC0")]
		get
		{
			return default(OPHMAHEJLBB);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8493770", Offset = "0x8492B70", VA = "0x188493770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public EBPMCOGAHLH LHMCFGNPHLF
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8493E10", Offset = "0x8493210", VA = "0x188493E10")]
		get
		{
			return default(EBPMCOGAHLH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8493A00", Offset = "0x8492E00", VA = "0x188493A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float LHEPMEJBOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8493F20", Offset = "0x8493320", VA = "0x188493F20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8493E50", Offset = "0x8493250", VA = "0x188493E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public bool BICJIHBKNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8493110", Offset = "0x8492510", VA = "0x188493110")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8493180", Offset = "0x8492580", VA = "0x188493180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool CLFPLBCMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8493470", Offset = "0x8492870", VA = "0x188493470")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8493920", Offset = "0x8492D20", VA = "0x188493920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool OMIHCDDHIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8493EA0", Offset = "0x84932A0", VA = "0x188493EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8493270", Offset = "0x8492670", VA = "0x188493270")]
	public static bool EBFNNAHDKHH(OAMEECEEOCH CANOPIHDPAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x8493A50", Offset = "0x8492E50", VA = "0x188493A50")]
	public static bool KGHIMGHIPAA(OAMEECEEOCH CANOPIHDPAM, [Out] OPADJMIPFIB MDOGENPNDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x84937C0", Offset = "0x8492BC0", VA = "0x1884937C0")]
	public bool ILGBLGIGPJG([Out] GJJDPKCKHPO NLMGKPGMOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8493CA0", Offset = "0x84930A0", VA = "0x188493CA0")]
	public bool KJOFPOBCICN([Out] NAIIODHHNBF LDEPDDDHLLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8493F60", Offset = "0x8493360", VA = "0x188493F60")]
	public bool PBMCAFMIKMH(BNADNEMKMMC HMHEELDKLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8493D90", Offset = "0x8493190", VA = "0x188493D90")]
	public void KLGCADPHFIB(BNADNEMKMMC HMHEELDKLNE, bool MOELHOCKLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8493640", Offset = "0x8492A40", VA = "0x188493640")]
	public void EFAMEFANHHE(BNADNEMKMMC HMHEELDKLNE, bool MOELHOCKLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public OPADJMIPFIB(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x84936E0", Offset = "0x8492AE0", VA = "0x1884936E0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(OPADJMIPFIB LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8494000", Offset = "0x8493400", VA = "0x188494000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct PIMPMKANLEA : IEquatable<PIMPMKANLEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool AOCNIGELPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8495F70", Offset = "0x8495370", VA = "0x188495F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public PIMPMKANLEA(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x8495EE0", Offset = "0x84952E0", VA = "0x188495EE0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(PIMPMKANLEA LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct MCJNIHMNFMK : IEquatable<MCJNIHMNFMK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private ANFIJLBKKNE EAODHBCMJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x848EDD0", Offset = "0x848E1D0", VA = "0x18848EDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x848EE30", Offset = "0x848E230", VA = "0x18848EE30")]
	public void KLOFGDJKOKJ(bool ILNJHNCJPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public MCJNIHMNFMK(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x848ED40", Offset = "0x848E140", VA = "0x18848ED40", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(MCJNIHMNFMK LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct AIIHBDEHPFE : IEquatable<AIIHBDEHPFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private OAOIPGBKCLP CPKJJJENDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x847DE20", Offset = "0x847D220", VA = "0x18847DE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public JHJGBLLNBFI NBMFFFKGAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x847E150", Offset = "0x847D550", VA = "0x18847E150")]
		get
		{
			return default(JHJGBLLNBFI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x847E400", Offset = "0x847D800", VA = "0x18847E400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool FDNDENJEONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x847E250", Offset = "0x847D650", VA = "0x18847E250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x847E6D0", Offset = "0x847DAD0", VA = "0x18847E6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public LGOFOLFOCNA<string> MMLEFNJHKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x847E030", Offset = "0x847D430", VA = "0x18847E030")]
		get
		{
			return default(LGOFOLFOCNA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x847DAC0", Offset = "0x847CEC0", VA = "0x18847DAC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public LGOFOLFOCNA<string> OLMLJHIAIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x847D9A0", Offset = "0x847CDA0", VA = "0x18847D9A0")]
		get
		{
			return default(LGOFOLFOCNA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x847DD00", Offset = "0x847D100", VA = "0x18847DD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public LGOFOLFOCNA<string> BHGOBGDNPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x847DF10", Offset = "0x847D310", VA = "0x18847DF10")]
		get
		{
			return default(LGOFOLFOCNA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x847DBE0", Offset = "0x847CFE0", VA = "0x18847DBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public LGOFOLFOCNA<string> DINEBKFNNON
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x847E5B0", Offset = "0x847D9B0", VA = "0x18847E5B0")]
		get
		{
			return default(LGOFOLFOCNA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x847E2E0", Offset = "0x847D6E0", VA = "0x18847E2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x847E510", Offset = "0x847D910", VA = "0x18847E510")]
	public bool NNIJBICHMLG(NAIIODHHNBF NICGPJDLKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public AIIHBDEHPFE(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static NAIIODHHNBF GKKMDDPCKIG(AIIHBDEHPFE CBMEHPPMEEA)
	{
		return default(NAIIODHHNBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x847DE80", Offset = "0x847D280", VA = "0x18847DE80", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(AIIHBDEHPFE LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct MNNHGIPNIJI : IEquatable<MNNHGIPNIJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool GODCLEGDKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x848F920", Offset = "0x848ED20", VA = "0x18848F920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool BANNEKMLNEE
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x848F710", Offset = "0x848EB10", VA = "0x18848F710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool CLDLCNBLCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x848FC00", Offset = "0x848F000", VA = "0x18848FC00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x848FBE0", Offset = "0x848EFE0", VA = "0x18848FBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool LGNAHMFBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x848F1E0", Offset = "0x848E5E0", VA = "0x18848F1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool BFFMNJFCBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x848F190", Offset = "0x848E590", VA = "0x18848F190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool DJIBKKCIBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x848FAD0", Offset = "0x848EED0", VA = "0x18848FAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool DFOEKHJPKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x848F140", Offset = "0x848E540", VA = "0x18848F140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool IEDMMMJAIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x848F3B0", Offset = "0x848E7B0", VA = "0x18848F3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool NCPCDMIFLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x848F960", Offset = "0x848ED60", VA = "0x18848F960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool FFOCOILBBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x848F880", Offset = "0x848EC80", VA = "0x18848F880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool HPJKMMHKOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x848F480", Offset = "0x848E880", VA = "0x18848F480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool JBJNEDGHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x848F280", Offset = "0x848E680", VA = "0x18848F280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool DGILJGPJMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x848F230", Offset = "0x848E630", VA = "0x18848F230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool JPFFJEKGMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x848F100", Offset = "0x848E500", VA = "0x18848F100")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x848F0A0", Offset = "0x848E4A0", VA = "0x18848F0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool IMNJKIHOLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x848F2D0", Offset = "0x848E6D0", VA = "0x18848F2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public AGIDIJAMCNH BNACIOCGHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x848FC50", Offset = "0x848F050", VA = "0x18848FC50")]
		get
		{
			return default(AGIDIJAMCNH);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x848F530", Offset = "0x848E930", VA = "0x18848F530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool CILPIEJFNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x848F760", Offset = "0x848EB60", VA = "0x18848F760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public OBOGCMLDHKJ CBGDFMPDMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x848F670", Offset = "0x848EA70", VA = "0x18848F670")]
		get
		{
			return default(OBOGCMLDHKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x848F8D0", Offset = "0x848ECD0", VA = "0x18848F8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool CEHLNOGPJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x848FB20", Offset = "0x848EF20", VA = "0x18848FB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 NGDPBDLPPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x848F020", Offset = "0x848E420", VA = "0x18848F020")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public Vector3 NOCALFMHFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x848F400", Offset = "0x848E800", VA = "0x18848F400")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool PKDEJILNOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x848FC90", Offset = "0x848F090", VA = "0x18848FC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public bool OBJMJDJCFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x848F580", Offset = "0x848E980", VA = "0x18848F580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private EntityManager LLDMANKJGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x848F6B0", Offset = "0x848EAB0", VA = "0x18848F6B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x848F4D0", Offset = "0x848E8D0", VA = "0x18848F4D0")]
	public bool GOCEIHCKAKN(CEKELHJFPPO HMHEELDKLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x848F9B0", Offset = "0x848EDB0", VA = "0x18848F9B0")]
	public void LBDJEGKCNNJ(CEKELHJFPPO HMHEELDKLNE, bool MOELHOCKLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x848FA40", Offset = "0x848EE40", VA = "0x18848FA40")]
	public bool LGAKGCPCLEH(OEFDIDBPHAO HMHEELDKLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x848FB60", Offset = "0x848EF60", VA = "0x18848FB60")]
	public void NKBCCHKIHCP(OEFDIDBPHAO HMHEELDKLNE, bool MOELHOCKLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x848FA90", Offset = "0x848EE90", VA = "0x18848FA90")]
	public OEFDIDBPHAO MJGIDIAMIOB()
	{
		return default(OEFDIDBPHAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x848F6C0", Offset = "0x848EAC0", VA = "0x18848F6C0")]
	public bool JKLEBKOEJDC(OEFDIDBPHAO CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public MNNHGIPNIJI(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x848F320", Offset = "0x848E720", VA = "0x18848F320", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(MNNHGIPNIJI LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct KJJLIHNLFPL : IEquatable<KJJLIHNLFPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	private EKFPDKJPIAM JGDODNEEIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x848CA80", Offset = "0x848BE80", VA = "0x18848CA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x848CAE0", Offset = "0x848BEE0", VA = "0x18848CAE0")]
	public bool EBCGKNKECGN(GDCPGHBNPPK OBGGAHJDHFG, List<OAMEECEEOCH> LJLNHEOADNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x848C860", Offset = "0x848BC60", VA = "0x18848C860")]
	public int ACOOMJFCHJJ(GDCPGHBNPPK OBGGAHJDHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x848C970", Offset = "0x848BD70", VA = "0x18848C970")]
	public void CIIAMBFODBH(List<OAMEECEEOCH> LJLNHEOADNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x848D280", Offset = "0x848C680", VA = "0x18848D280")]
	public int PENPPLDLEPP(OAMEECEEOCH NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x848CC10", Offset = "0x848C010", VA = "0x18848CC10")]
	public OAMEECEEOCH EDKDIMPKNBI(int NOEININIMIL, GDCPGHBNPPK OBGGAHJDHFG)
	{
		return default(OAMEECEEOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x848D0A0", Offset = "0x848C4A0", VA = "0x18848D0A0")]
	public void NNBMGPFHLOF(OAMEECEEOCH NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x848CEE0", Offset = "0x848C2E0", VA = "0x18848CEE0")]
	public bool KLFNMCLCIDJ(OAMEECEEOCH NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x848CF90", Offset = "0x848C390", VA = "0x18848CF90")]
	public void LBKCDGNOMGB(GDCPGHBNPPK OBGGAHJDHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x848D1D0", Offset = "0x848C5D0", VA = "0x18848D1D0")]
	public bool OHHPFOMKGJD(OAMEECEEOCH NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x848CDD0", Offset = "0x848C1D0", VA = "0x18848CDD0")]
	public bool GKIOLCOBODL(GDCPGHBNPPK OBGGAHJDHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public KJJLIHNLFPL(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x848CD40", Offset = "0x848C140", VA = "0x18848CD40", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(KJJLIHNLFPL LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct CCIIDFNJCNM : IEquatable<CCIIDFNJCNM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x847FAE0", Offset = "0x847EEE0", VA = "0x18847FAE0")]
	public void JGEHKOJBALA(bool CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x847FB70", Offset = "0x847EF70", VA = "0x18847FB70")]
	public void MPEMIDCKCAD(bool CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3AA02A0", Offset = "0x3A9F6A0", VA = "0x183AA02A0")]
	public T ICJFMAHCJDO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public CCIIDFNJCNM(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x847FA50", Offset = "0x847EE50", VA = "0x18847FA50", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(CCIIDFNJCNM LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct ILJFKMDMPJP : IEquatable<ILJFKMDMPJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public bool LCELEOJHIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x848B5B0", Offset = "0x848A9B0", VA = "0x18848B5B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x848B630", Offset = "0x848AA30", VA = "0x18848B630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool BHAOIOEBNAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x848B4A0", Offset = "0x848A8A0", VA = "0x18848B4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int ACCLMIGCKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x848B5F0", Offset = "0x848A9F0", VA = "0x18848B5F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x848B410", Offset = "0x848A810", VA = "0x18848B410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public ILJFKMDMPJP(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x848B520", Offset = "0x848A920", VA = "0x18848B520", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(ILJFKMDMPJP LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct EPMLKGMJNOH : IEquatable<EPMLKGMJNOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public int IGNOCPLFFPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8482D70", Offset = "0x8482170", VA = "0x188482D70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8482C80", Offset = "0x8482080", VA = "0x188482C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int CCIGKLMEKAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8482C40", Offset = "0x8482040", VA = "0x188482C40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8482CD0", Offset = "0x84820D0", VA = "0x188482CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public uint DFAIPGEDCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8482B70", Offset = "0x8481F70", VA = "0x188482B70")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8482D20", Offset = "0x8482120", VA = "0x188482D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public EPMLKGMJNOH(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x8482BB0", Offset = "0x8481FB0", VA = "0x188482BB0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(EPMLKGMJNOH LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct PHFBHFNNAKO : IEquatable<PHFBHFNNAKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	private AMOMFNJCBAN JGNAKIKKIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8495E80", Offset = "0x8495280", VA = "0x188495E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	private OCLOPOPALDC AGDPNPJFKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8495640", Offset = "0x8494A40", VA = "0x188495640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public bool HBHOHHGBNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x8495730", Offset = "0x8494B30", VA = "0x188495730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public bool OLJBFAKOEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8495530", Offset = "0x8494930", VA = "0x188495530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool ALLILDBHBJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8495BE0", Offset = "0x8494FE0", VA = "0x188495BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool EDPJPCNAMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x84957C0", Offset = "0x8494BC0", VA = "0x1884957C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public bool DHKMJHMIJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8495C10", Offset = "0x8495010", VA = "0x188495C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool NLNKLJHGJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8495390", Offset = "0x8494790", VA = "0x188495390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool DNDBABFAKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8495CE0", Offset = "0x84950E0", VA = "0x188495CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool DDGFIOMKICD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8495940", Offset = "0x8494D40", VA = "0x188495940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool MAPFJBNCHCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8495AB0", Offset = "0x8494EB0", VA = "0x188495AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x84955D0", Offset = "0x84949D0", VA = "0x1884955D0")]
	public bool CPJMCFOLLLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8495C40", Offset = "0x8495040", VA = "0x188495C40")]
	public OAMEECEEOCH NDHGAPAHGGD(OAMEECEEOCH NJJNDJLGDNH)
	{
		return default(OAMEECEEOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x8495420", Offset = "0x8494820", VA = "0x188495420")]
	public NAIIODHHNBF BEKFOFLILOK()
	{
		return default(NAIIODHHNBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x8495890", Offset = "0x8494C90", VA = "0x188495890")]
	public bool INFPBNIBJIE(NAIIODHHNBF NJJNDJLGDNH, [Out] NAIIODHHNBF FIIDOGIBNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public PHFBHFNNAKO(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x847D0F0", Offset = "0x847C4F0", VA = "0x18847D0F0")]
	public static bool GKKMDDPCKIG(PHFBHFNNAKO CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x84956A0", Offset = "0x8494AA0", VA = "0x1884956A0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(PHFBHFNNAKO LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct HIGOMPAEDIJ : IEquatable<HIGOMPAEDIJ>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly HIGOMPAEDIJ FJMDDOMHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public ALLEDPCNAAI FDBBDIDBLNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x84859A0", Offset = "0x8484DA0", VA = "0x1884859A0")]
		get
		{
			return default(ALLEDPCNAAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public GEGMIDKLLFN LEHEPOAPIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x8485960", Offset = "0x8484D60", VA = "0x188485960")]
		get
		{
			return default(GEGMIDKLLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x84859E0", Offset = "0x8484DE0", VA = "0x1884859E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public HPLJMLNNILP NOKPIKBDEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x8485850", Offset = "0x8484C50", VA = "0x188485850")]
		get
		{
			return default(HPLJMLNNILP);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x8485450", Offset = "0x8484850", VA = "0x188485450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public float PDHIPEIOLNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x8485560", Offset = "0x8484960", VA = "0x188485560")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x84855A0", Offset = "0x84849A0", VA = "0x1884855A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public Vector3 NDDAMILNMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x84854A0", Offset = "0x84848A0", VA = "0x1884854A0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x84856D0", Offset = "0x8484AD0", VA = "0x1884856D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public float FHGBEGDHLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x8485800", Offset = "0x8484C00", VA = "0x188485800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public HNPEOKBOCPL HHPKHHAHCHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8485410", Offset = "0x8484810", VA = "0x188485410")]
		get
		{
			return default(HNPEOKBOCPL);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x8485680", Offset = "0x8484A80", VA = "0x188485680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public bool JMCJHIKCPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x8485520", Offset = "0x8484920", VA = "0x188485520")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x84857A0", Offset = "0x8484BA0", VA = "0x1884857A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public IKBPCFPMPFP MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(IKBPCFPMPFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public JLIKDJCPJDF OFBDFJKOLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(JLIKDJCPJDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8485750", Offset = "0x8484B50", VA = "0x188485750")]
	public ABBFGPENHBK GJHMFFKGGCC()
	{
		return default(ABBFGPENHBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x8485910", Offset = "0x8484D10", VA = "0x188485910")]
	public MCGPACNOOPH NFNDOGMOLJJ()
	{
		return default(MCGPACNOOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x84853C0", Offset = "0x84847C0", VA = "0x1884853C0")]
	private bool AABLIGMEBIJ(HNPEOKBOCPL HMHEELDKLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8485890", Offset = "0x8484C90", VA = "0x188485890")]
	public void MAEPHLBINHO(HNPEOKBOCPL HMHEELDKLNE, bool MOELHOCKLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public HIGOMPAEDIJ(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x847D0F0", Offset = "0x847C4F0", VA = "0x18847D0F0")]
	public static bool GKKMDDPCKIG(HIGOMPAEDIJ CBMEHPPMEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x8481600", Offset = "0x8480A00", VA = "0x188481600")]
	public static bool AMDBHCBNEEF(HIGOMPAEDIJ HCFCOMCPJPA, HIGOMPAEDIJ JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x84855F0", Offset = "0x84849F0", VA = "0x1884855F0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(HIGOMPAEDIJ LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct ABBFGPENHBK : IEquatable<ABBFGPENHBK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public HIGOMPAEDIJ JEJKJBLPDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(HIGOMPAEDIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public BFBNMLCCBFM OAEMCKKJKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x847D810", Offset = "0x847CC10", VA = "0x18847D810")]
		get
		{
			return default(BFBNMLCCBFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public ABBFGPENHBK(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x847D0F0", Offset = "0x847C4F0", VA = "0x18847D0F0")]
	public static bool GKKMDDPCKIG(ABBFGPENHBK CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x847D780", Offset = "0x847CB80", VA = "0x18847D780", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(ABBFGPENHBK LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DefaultMember("Item")]
public readonly struct MCGPACNOOPH : IEquatable<MCGPACNOOPH>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly MCGPACNOOPH FJMDDOMHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	private ELOONHGKGHE BKIKFMMHMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x848E100", Offset = "0x848D500", VA = "0x18848E100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public HIGOMPAEDIJ JEJKJBLPDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(HIGOMPAEDIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public BFGADLCEFPF GKJJHAEPIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x848EB80", Offset = "0x848DF80", VA = "0x18848EB80")]
		get
		{
			return default(BFGADLCEFPF);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x848E530", Offset = "0x848D930", VA = "0x18848E530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public IEnumerable<HPMIBJEAGOE> OFANAFFFFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x848E990", Offset = "0x848DD90", VA = "0x18848E990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public HPMIBJEAGOE FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x848E420", Offset = "0x848D820", VA = "0x18848E420")]
		get
		{
			return default(HPMIBJEAGOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x848E390", Offset = "0x848D790", VA = "0x18848E390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public IKBPCFPMPFP MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(IKBPCFPMPFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x848E6E0", Offset = "0x848DAE0", VA = "0x18848E6E0")]
	public HPMIBJEAGOE GHNFBMEEMFD(float3? LBCFHLNAPLC, [Optional] quaternion? EMLGDFFEJED, [Optional] Vector3? MJHAIBCGLLD)
	{
		return default(HPMIBJEAGOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x848E160", Offset = "0x848D560", VA = "0x18848E160")]
	public HPMIBJEAGOE CJCNKGGGBMJ(int NOEININIMIL, float3? LBCFHLNAPLC, [Optional] quaternion? EMLGDFFEJED, [Optional] Vector3? MJHAIBCGLLD)
	{
		return default(HPMIBJEAGOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x848ECA0", Offset = "0x848E0A0", VA = "0x18848ECA0")]
	public void PNJMDCCOGEG(int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x848E900", Offset = "0x848DD00", VA = "0x18848E900")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public MCGPACNOOPH(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x847D0F0", Offset = "0x847C4F0", VA = "0x18847D0F0")]
	public static bool GKKMDDPCKIG(MCGPACNOOPH CBMEHPPMEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x84817F0", Offset = "0x8480BF0", VA = "0x1884817F0")]
	public static bool ILMCFLMCOJH(MCGPACNOOPH HCFCOMCPJPA, MCGPACNOOPH JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x848E650", Offset = "0x848DA50", VA = "0x18848E650", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(MCGPACNOOPH LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct HPMIBJEAGOE : IEquatable<HPMIBJEAGOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public MCGPACNOOPH CENAHJPBCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x8488160", Offset = "0x8487560", VA = "0x188488160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public float3 CGGNGHCCNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x84881E0", Offset = "0x84875E0", VA = "0x1884881E0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x84882F0", Offset = "0x84876F0", VA = "0x1884882F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public quaternion BNPIKAOEGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x84882A0", Offset = "0x84876A0", VA = "0x1884882A0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x8488360", Offset = "0x8487760", VA = "0x188488360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public float3 BKEPJIGJHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x8488240", Offset = "0x8487640", VA = "0x188488240")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x8488070", Offset = "0x8487470", VA = "0x188488070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public OJNFHONPFAP PFAOFEIDEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x84883B0", Offset = "0x84877B0", VA = "0x1884883B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8488350", Offset = "0x8487750", VA = "0x188488350")]
	public void LOOALAHAEGI(MCGPACNOOPH CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public HPMIBJEAGOE(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x84880D0", Offset = "0x84874D0", VA = "0x1884880D0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(HPMIBJEAGOE LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct MMALBCNCFLE : IEquatable<MMALBCNCFLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public bool KLAEBCFNIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x848EF20", Offset = "0x848E320", VA = "0x18848EF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public MMALBCNCFLE(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x848EF90", Offset = "0x848E390", VA = "0x18848EF90", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(MMALBCNCFLE LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct BKNLJFGPIFB : IEquatable<BKNLJFGPIFB>
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public static readonly BKNLJFGPIFB FJMDDOMHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	private FJILNINBNME KBCNEBDMNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x847F040", Offset = "0x847E440", VA = "0x18847F040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public uint MHAJCEBCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x847F610", Offset = "0x847EA10", VA = "0x18847F610")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x847F230", Offset = "0x847E630", VA = "0x18847F230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public GLJNFGKKOAM POIBOKIFPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x847EE50", Offset = "0x847E250", VA = "0x18847EE50")]
		get
		{
			return default(GLJNFGKKOAM);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x847F710", Offset = "0x847EB10", VA = "0x18847F710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public float JMABEFEINHG
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x847F7F0", Offset = "0x847EBF0", VA = "0x18847F7F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x847F880", Offset = "0x847EC80", VA = "0x18847F880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public float KFLOHFMCOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x847F0A0", Offset = "0x847E4A0", VA = "0x18847F0A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x847F460", Offset = "0x847E860", VA = "0x18847F460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public PBFAHNBOMEH LAMENOIJLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x847F760", Offset = "0x847EB60", VA = "0x18847F760")]
		get
		{
			return default(PBFAHNBOMEH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x847F7A0", Offset = "0x847EBA0", VA = "0x18847F7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public float MEMGGEHDMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x847F420", Offset = "0x847E820", VA = "0x18847F420")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x847EE90", Offset = "0x847E290", VA = "0x18847EE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public float JKLDMBADCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x847F280", Offset = "0x847E680", VA = "0x18847F280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public float MPIIMCOONNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x847F1F0", Offset = "0x847E5F0", VA = "0x18847F1F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public float NOJILPHKLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x847F3E0", Offset = "0x847E7E0", VA = "0x18847F3E0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x847F830", Offset = "0x847EC30", VA = "0x18847F830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public GEGMIDKLLFN CLPAJNCBLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x847F8D0", Offset = "0x847ECD0", VA = "0x18847F8D0")]
		get
		{
			return default(GEGMIDKLLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x847F5C0", Offset = "0x847E9C0", VA = "0x18847F5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public GEGMIDKLLFN PLFEELHOCFL
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x847F120", Offset = "0x847E520", VA = "0x18847F120")]
		get
		{
			return default(GEGMIDKLLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x847EFF0", Offset = "0x847E3F0", VA = "0x18847EFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public float LIGLBHODFML
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x847F0E0", Offset = "0x847E4E0", VA = "0x18847F0E0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x847F570", Offset = "0x847E970", VA = "0x18847F570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public ReadOnlySpan<TerrainGenerationLayer> PAELEAODOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x847F650", Offset = "0x847EA50", VA = "0x18847F650")]
		get
		{
			return default(ReadOnlySpan<TerrainGenerationLayer>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x847F2D0", Offset = "0x847E6D0", VA = "0x18847F2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public ReadOnlySpan<GCFFMGKDNLP> IKAPEPLFGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x847F4B0", Offset = "0x847E8B0", VA = "0x18847F4B0")]
		get
		{
			return default(ReadOnlySpan<GCFFMGKDNLP>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x847EEE0", Offset = "0x847E2E0", VA = "0x18847EEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public BKNLJFGPIFB(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static NAIIODHHNBF GKKMDDPCKIG(BKNLJFGPIFB CBMEHPPMEEA)
	{
		return default(NAIIODHHNBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x847F160", Offset = "0x847E560", VA = "0x18847F160", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(BKNLJFGPIFB LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct HDDFJHOAKIA : IEquatable<HDDFJHOAKIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	private BNFPGIFBFBJ NMFFLIHIGPA
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x8484D80", Offset = "0x8484180", VA = "0x188484D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public bool AHJGHJGNHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x8484E30", Offset = "0x8484230", VA = "0x188484E30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x84848D0", Offset = "0x8483CD0", VA = "0x1884848D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public bool DOGOPCABONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x84846D0", Offset = "0x8483AD0", VA = "0x1884846D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x8484AD0", Offset = "0x8483ED0", VA = "0x188484AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public float GHKLFBLFJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x84844D0", Offset = "0x84838D0", VA = "0x1884844D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8484E80", Offset = "0x8484280", VA = "0x188484E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public bool KAKDHGHJCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x8484930", Offset = "0x8483D30", VA = "0x188484930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x8484ED0", Offset = "0x84842D0", VA = "0x188484ED0")]
	public void PJDDKCFFOFL(int CCGANJILKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x8484C70", Offset = "0x8484070", VA = "0x188484C70")]
	public bool LAJAJEHOIGA([Out] int CCGANJILKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x8484830", Offset = "0x8483C30", VA = "0x188484830")]
	public void FMIOJPJKPCA(bool MAAOGPMHLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x8484DE0", Offset = "0x84841E0", VA = "0x188484DE0")]
	public bool MJDKDLOAFOJ(KGMJKHNNELD HMHEELDKLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x84847B0", Offset = "0x8483BB0", VA = "0x1884847B0")]
	public void FCEGJCDINOO(KGMJKHNNELD HMHEELDKLNE, bool MOELHOCKLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x8484B30", Offset = "0x8483F30", VA = "0x188484B30")]
	public void KFPNDCLCJEC(float LIGFFDKKGGM, float BMGHBNBILDL, float AJHDIJFJJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x8484980", Offset = "0x8483D80", VA = "0x188484980")]
	public void JGENOFGHNNB(float3 LGHCOAHOHGA, quaternion PAMAFOMEPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x8484510", Offset = "0x8483910", VA = "0x188484510")]
	public bool BDFMDCLEBGO([Out] float3 LGHCOAHOHGA, [Out] quaternion PAMAFOMEPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x8484F70", Offset = "0x8484370", VA = "0x188484F70")]
	public bool PPBLNFIEPOD([Out] float DCCBPHFJABK, [Out] float OJNLDJAHOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x8484640", Offset = "0x8483A40", VA = "0x188484640")]
	public void CCBIPEABPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public HDDFJHOAKIA(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x8484720", Offset = "0x8483B20", VA = "0x188484720", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(HDDFJHOAKIA LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct IKBPCFPMPFP : IEquatable<IKBPCFPMPFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	private FOOPJJDIOEH NEODFGNMJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x848AE50", Offset = "0x848A250", VA = "0x18848AE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public Vector3 CGGNGHCCNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x848A390", Offset = "0x8489790", VA = "0x18848A390")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x848A9A0", Offset = "0x8489DA0", VA = "0x18848A9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public Quaternion BNPIKAOEGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x848A860", Offset = "0x8489C60", VA = "0x18848A860")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x848B050", Offset = "0x848A450", VA = "0x18848B050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public Vector3 MFPBOIJJBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x848B120", Offset = "0x848A520", VA = "0x18848B120")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x84895D0", Offset = "0x84889D0", VA = "0x1884895D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public Quaternion DOALJHOHDAI
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x848AF10", Offset = "0x848A310", VA = "0x18848AF10")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x848A1F0", Offset = "0x84895F0", VA = "0x18848A1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public float KDBDCMOKGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x848ACA0", Offset = "0x848A0A0", VA = "0x18848ACA0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8489DD0", Offset = "0x84891D0", VA = "0x188489DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public float MJGMGCOGIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x848AA70", Offset = "0x8489E70", VA = "0x18848AA70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public Matrix4x4 LKMGHHPAHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x8489D90", Offset = "0x8489190", VA = "0x188489D90")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public JLIKDJCPJDF OFBDFJKOLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(JLIKDJCPJDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	private MHFAEJPNHJP EPCFGMJMGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x84891B0", Offset = "0x84885B0", VA = "0x1884891B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x84898C0", Offset = "0x8488CC0", VA = "0x1884898C0")]
	public GIJLHKFOFFB CJJADDDKDGN()
	{
		return default(GIJLHKFOFFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x848AD40", Offset = "0x848A140", VA = "0x18848AD40")]
	public void NDPKJAIOFGM([Out] Matrix4x4 LCHGFDBANLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x848A6A0", Offset = "0x8489AA0", VA = "0x18848A6A0")]
	public void KGPCCECPNEA([In] Vector3 IPGNGMJBFOL, [In] Quaternion JJPOMEGMBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x848A7A0", Offset = "0x8489BA0", VA = "0x18848A7A0")]
	public void KGPCCECPNEA([In] RigidTransform IKABGDNAJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x848B270", Offset = "0x848A670", VA = "0x18848B270")]
	public void OOGPPPOAFEM([Out] RigidTransform IKABGDNAJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x848A5A0", Offset = "0x84899A0", VA = "0x18848A5A0")]
	public void KGCIOPAMKAO([In] Vector3 BKFIHNMIHDL, [In] Quaternion ELADGEJIENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x848A4E0", Offset = "0x84898E0", VA = "0x18848A4E0")]
	public void KGCIOPAMKAO([In] RigidTransform MMPBDMLMPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x848AB10", Offset = "0x8489F10", VA = "0x18848AB10")]
	public void LLILNEPDONP([Out] Vector3 BKFIHNMIHDL, [Out] Quaternion ELADGEJIENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x848ABF0", Offset = "0x8489FF0", VA = "0x18848ABF0")]
	public void LLILNEPDONP([Out] RigidTransform IKABGDNAJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x84894E0", Offset = "0x84888E0", VA = "0x1884894E0")]
	public UniformTRS ANEALJFAOBK()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8489510", Offset = "0x8488910", VA = "0x188489510")]
	public void ANEALJFAOBK([Out] UniformTRS MMPBDMLMPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x848B320", Offset = "0x848A720", VA = "0x18848B320")]
	public UniformTRS PBNAIMGMDHO()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x848B350", Offset = "0x848A750", VA = "0x18848B350")]
	public void PBNAIMGMDHO([Out] UniformTRS IKABGDNAJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x8489FD0", Offset = "0x84893D0", VA = "0x188489FD0")]
	public Vector3 HCJNMHPBOPM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x84896A0", Offset = "0x8488AA0", VA = "0x1884896A0")]
	public void BCKPHCAIHDJ([In] Vector3 CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x8489E80", Offset = "0x8489280", VA = "0x188489E80")]
	public Vector3 GPKJDLAFGNF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x848A120", Offset = "0x8489520", VA = "0x18848A120")]
	public void IGMOOFGALBB([In] Vector3 CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8489910", Offset = "0x8488D10", VA = "0x188489910")]
	public Quaternion DNIJMCPEGEM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8489B00", Offset = "0x8488F00", VA = "0x188489B00")]
	public void EDAOHLDJJGB([In] Quaternion CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x84893A0", Offset = "0x84887A0", VA = "0x1884893A0")]
	public Quaternion AJAOGPFGFHN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x848A2C0", Offset = "0x84896C0", VA = "0x18848A2C0")]
	public void JKCOFHJCJHP([In] Quaternion CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8489820", Offset = "0x8488C20", VA = "0x188489820")]
	public float BOHCGEOIEOG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x8489770", Offset = "0x8488B70", VA = "0x188489770")]
	public void BLIAEKKLODE(float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x8489BD0", Offset = "0x8488FD0", VA = "0x188489BD0")]
	public float EOBIDEGNMCG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x8489A50", Offset = "0x8488E50", VA = "0x188489A50")]
	public void DNPJIACOFPG(float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8489C70", Offset = "0x8489070", VA = "0x188489C70")]
	public Vector3 EOIFGFACNPA([In] Vector3 NLDMHMFAEEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public IKBPCFPMPFP(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x8489D00", Offset = "0x8489100", VA = "0x188489D00", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(IKBPCFPMPFP LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct OHDIJAJMPAO : IEquatable<OHDIJAJMPAO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	private ODHDBENJMPP PAKDNMFGAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x8492B70", Offset = "0x8491F70", VA = "0x188492B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	private FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x847CF60", Offset = "0x847C360", VA = "0x18847CF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x8492BD0", Offset = "0x8491FD0", VA = "0x188492BD0")]
	public void ELDJMGIKFAF(string HHKLKJCBFCE, OGKGFAOMCHI GFKIDJOBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public OHDIJAJMPAO(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x8492D10", Offset = "0x8492110", VA = "0x188492D10", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(OHDIJAJMPAO LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x847D760", Offset = "0x847CB60", VA = "0x18847D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct FAGPBEJFEMP : IEquatable<FAGPBEJFEMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public JMAJLEBDBPE PMCDGBFNMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x8482DB0", Offset = "0x84821B0", VA = "0x188482DB0")]
		get
		{
			return default(JMAJLEBDBPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public FAGPBEJFEMP(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x8482EA0", Offset = "0x84822A0", VA = "0x188482EA0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(FAGPBEJFEMP LHDOHAKINKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct HNALKCIEFPN : IEquatable<HNALKCIEFPN>
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public struct EMANCLDJEPK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private NAIIODHHNBF HNIIKCBNMGN;

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x84823C0", Offset = "0x84817C0", VA = "0x1884823C0")]
		public EMANCLDJEPK(NAIIODHHNBF HNIIKCBNMGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x8482330", Offset = "0x8481730", VA = "0x188482330", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x8486EB0", Offset = "0x84862B0", VA = "0x188486EB0")]
	public EMANCLDJEPK EAFILCGDFAK()
	{
		return default(EMANCLDJEPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x8487230", Offset = "0x8486630", VA = "0x188487230")]
	public CHFCCBBNCCJ MIIANCCJJEI(Allocator KCEIEKBPKNP = Allocator.Temp)
	{
		return default(CHFCCBBNCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x8486D80", Offset = "0x8486180", VA = "0x188486D80")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> DKFAKEGHDCC(Allocator KCEIEKBPKNP = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x8486C50", Offset = "0x8486050", VA = "0x188486C50")]
	public NativeArray<DNOIABBOEPJ> BKMGDKGGEDJ(Allocator KCEIEKBPKNP = Allocator.Temp)
	{
		return default(NativeArray<DNOIABBOEPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x8486B20", Offset = "0x8485F20", VA = "0x188486B20")]
	public NativeArray<DNOIABBOEPJ> ABGJENJMPHI(Allocator KCEIEKBPKNP = Allocator.Temp)
	{
		return default(NativeArray<DNOIABBOEPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x84872B0", Offset = "0x84866B0", VA = "0x1884872B0")]
	public HOKGPHAPNOB PBBPDFFCPDD(Allocator KCEIEKBPKNP = Allocator.Temp)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x8487100", Offset = "0x8486500", VA = "0x188487100")]
	public HOKGPHAPNOB JCHDCPGIFBI(Allocator KCEIEKBPKNP = Allocator.Temp)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x8486FD0", Offset = "0x84863D0", VA = "0x188486FD0")]
	public HOKGPHAPNOB FOGKKOMPMOK(Allocator KCEIEKBPKNP = Allocator.Temp)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public HNALKCIEFPN(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x8486F40", Offset = "0x8486340", VA = "0x188486F40", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(HNALKCIEFPN LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x847FA30", Offset = "0x847EE30", VA = "0x18847FA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct IKDNMJDEOLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int AICLNKJNCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int COGHKOHIMGI;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct HEKBAMHGADC : IEquatable<HEKBAMHGADC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public HNALKCIEFPN JFJJOOEIBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(HNALKCIEFPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public BOFJADKNGEG OMMOIDMJEKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(BOFJADKNGEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public FAGPBEJFEMP CGLMKFHHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(FAGPBEJFEMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x8485120", Offset = "0x8484520", VA = "0x188485120")]
	public bool BBCDHCFBJLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x84851C0", Offset = "0x84845C0", VA = "0x1884851C0")]
	public bool BILDCBCPHNO([Out] Exception CGMANOFIFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public HEKBAMHGADC(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static NAIIODHHNBF GKKMDDPCKIG(HEKBAMHGADC CBMEHPPMEEA)
	{
		return default(NAIIODHHNBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x8485330", Offset = "0x8484730", VA = "0x188485330", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(HEKBAMHGADC LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x847FA30", Offset = "0x847EE30", VA = "0x18847FA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public readonly struct LHEIOAMAFNG : IDisposable, IEquatable<LHEIOAMAFNG>
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static readonly LHEIOAMAFNG FJMDDOMHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public HEKBAMHGADC LHGELCIPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(HEKBAMHGADC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public HNALKCIEFPN JFJJOOEIBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(HNALKCIEFPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x848DA00", Offset = "0x848CE00", VA = "0x18848DA00")]
	public void MGJFCGIENEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x848D8A0", Offset = "0x848CCA0", VA = "0x18848D8A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public LHEIOAMAFNG(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x848D970", Offset = "0x848CD70", VA = "0x18848D970", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "5")]
	public bool Equals(LHEIOAMAFNG LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x848DA80", Offset = "0x848CE80", VA = "0x18848DA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public readonly struct BOFJADKNGEG : IEquatable<BOFJADKNGEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public bool KBNFFJOCCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x847F9A0", Offset = "0x847EDA0", VA = "0x18847F9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	public BOFJADKNGEG(NAIIODHHNBF HNIIKCBNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847C510", VA = "0x18847D110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x847F910", Offset = "0x847ED10", VA = "0x18847F910", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x847D050", Offset = "0x847C450", VA = "0x18847D050", Slot = "4")]
	public bool Equals(BOFJADKNGEG LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x847FA30", Offset = "0x847EE30", VA = "0x18847FA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class AHDCOBLOMJM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct JIIBKKHKDHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Guid OOOANFDGEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public NKJPNMODHKI KADBPDJFPAD;
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private struct NKJPNMODHKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int CBMEHPPMEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int DOCPCJOAHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int IJCMEOHJFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int EJBHPHPFPNJ;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x8490850", Offset = "0x848FC50", VA = "0x188490850")]
		public bool NIKCLDEIAKK([Out] DNOIABBOEPJ LGKFNBNJHLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x84908F0", Offset = "0x848FCF0", VA = "0x1884908F0")]
		public NKJPNMODHKI(DNOIABBOEPJ LGKFNBNJHLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x847D850", Offset = "0x847CC50", VA = "0x18847D850")]
	public static Guid KBDIDMAGAFN(this DNOIABBOEPJ LGKFNBNJHLJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x847D8F0", Offset = "0x847CCF0", VA = "0x18847D8F0")]
	public static bool LJHNEPKLBKE(this Guid OOOANFDGEED, [Out] DNOIABBOEPJ LGKFNBNJHLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class OHNBMJJCMHH
{
	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x8492FA0", Offset = "0x84923A0", VA = "0x188492FA0")]
	public static FGPBDDGCBGJ MCFHOGBMFDA(this NAIIODHHNBF CLNGGGMIBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x8492EB0", Offset = "0x84922B0", VA = "0x188492EB0")]
	public static DJEGDOLDLFH LJBGKPDCCGH(this NAIIODHHNBF CLNGGGMIBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x8492F10", Offset = "0x8492310", VA = "0x188492F10")]
	public static EntityManager LLDMANKJGOL(this NAIIODHHNBF CLNGGGMIBPI)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3660", Offset = "0x3EB2A60", VA = "0x183EB3660")]
	internal static bool CNPLCPGHDAJ<T>(this NAIIODHHNBF CLNGGGMIBPI, bool MOELHOCKLNG) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x8492DA0", Offset = "0x84921A0", VA = "0x188492DA0")]
	public static bool IELHJKNCADO(this NAIIODHHNBF CLNGGGMIBPI, OJEHFCOLBPA NBOAFDFPIEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2BC0", Offset = "0x3EB1FC0", VA = "0x183EB2BC0")]
	public static bool CLHNCAJMCHF<T>(this NAIIODHHNBF CLNGGGMIBPI) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x3EB39C0", Offset = "0x3EB2DC0", VA = "0x183EB39C0")]
	public static bool KMJMFGFCLPI<T>(this NAIIODHHNBF CLNGGGMIBPI) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x3EB38D0", Offset = "0x3EB2CD0", VA = "0x183EB38D0")]
	[LGFOELNJLID]
	internal static NativeArray<T> HMEMHKMDKPH<T>(this NAIIODHHNBF CLNGGGMIBPI, Allocator KCEIEKBPKNP) where T : struct, IBufferElementData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x3EB0F00", Offset = "0x3EB0300", VA = "0x183EB0F00")]
	[LGFOELNJLID]
	public static T BNIPPOLLMCO<T>(this NAIIODHHNBF CLNGGGMIBPI) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3B20", Offset = "0x3EB2F20", VA = "0x183EB3B20")]
	[LGFOELNJLID]
	public static T NIODBJLMNLA<T>(this NAIIODHHNBF CLNGGGMIBPI) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2AA0", Offset = "0x3EB1EA0", VA = "0x183EB2AA0")]
	public static bool CBBBALKKHGP<T>(this NAIIODHHNBF CLNGGGMIBPI, [Out] T CBMEHPPMEEA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3820", Offset = "0x3EB2C20", VA = "0x183EB3820")]
	public static T GGBKPMKMKHN<T>(this NAIIODHHNBF CLNGGGMIBPI) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x3EB0E80", Offset = "0x3EB0280", VA = "0x183EB0E80")]
	public static T BFDBCDPFJND<T>(this NAIIODHHNBF CLNGGGMIBPI) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class GNEADLDCHBF
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public struct CHFCCBBNCCJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private HOKGPHAPNOB BEOBAPANJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> AKJIHJKEGKO;

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x60BD860", Offset = "0x60BCC60", VA = "0x1860BD860")]
	public CHFCCBBNCCJ(HOKGPHAPNOB BEOBAPANJHO, NativeArray<EntityRemapUtility.EntityRemapInfo> AKJIHJKEGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x847FD50", Offset = "0x847F150", VA = "0x18847FD50")]
	public LocalId FCPHGDHFOCH(LocalId DEJGDIIDCDN)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x847FD00", Offset = "0x847F100", VA = "0x18847FD00")]
	public LocalId FCPHGDHFOCH(int NOEININIMIL)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x847FC90", Offset = "0x847F090", VA = "0x18847FC90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHFHPGBIGKN
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPHNEAHJGLD(NAIIODHHNBF ANKACPFCKKH, [Out] uint CLNGGGMIBPI);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HJNFACCJLEH(NAIIODHHNBF ANKACPFCKKH, [Out] uint CLNGGGMIBPI);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBLEIEOJBEB(NAIIODHHNBF ANKACPFCKKH, uint CLNGGGMIBPI);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HPPKHJFDAMH(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string JGIJACJDODI(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DOPBNLOPGBG(NAIIODHHNBF ANKACPFCKKH, string CLNGGGMIBPI);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MNOGLCPBFDB(NAIIODHHNBF ANKACPFCKKH, [Out] string LOIIBOHGNMD);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FJOOJADNIEG(NAIIODHHNBF ANKACPFCKKH, string LOIIBOHGNMD);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CFLPOFDACJP
{
	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	Guid GJCEEGEPJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	Guid IHMNNOMFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DFHGLHHGLLN(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task NLHGLEFALHI(OAMEECEEOCH DEJGDIIDCDN);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid HLLENDAFELM(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AJHIGCOHAJH(NAIIODHHNBF HNIIKCBNMGN, Guid BBEBJBEHHMM);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PIMGCNPJKCA(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task FPIONMNDAHN(NAIIODHHNBF HCOPOFCDINJ, NAIIODHHNBF JIECBJMGMAC);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FMIMCCEOEEC(NAIIODHHNBF HNIIKCBNMGN, DNOIABBOEPJ BINDKDHEIJE);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BAIFCGHBKGA
{
	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	Guid GJCEEGEPJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBAOANCKHMF(NativeList<Guid> DKCHJOOMHBK, NativeList<Guid> EIFCLCCCDLP, NativeList<FixedString64Bytes> GDGIHNAFJDE);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HDPIGLLNLBC
{
	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOKGPHAPNOB MLBLBDNBODK(Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOKGPHAPNOB DJAKOKNCIEN(Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFHDKKOACID(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BHAOIOEBNAO(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PCELEDBBIMH(NAIIODHHNBF ANKACPFCKKH, [Out] NAIIODHHNBF FHHNHFHEKFL);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LCELEOJHIEF(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EPEPBKNODKD(NAIIODHHNBF ANKACPFCKKH, int CJKINMFPLED);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NAIIODHHNBF FHDPIMKNKIC(NAIIODHHNBF FHHNHFHEKFL);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HEAOOHMLMOM(HOKGPHAPNOB PHJLCHBDPGC, bool EKJLBIPLAGD);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GONAPBENJCE(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OMMGMIGKOFP(NAIIODHHNBF ANKACPFCKKH, bool BCLOPCOLNBA);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int FAGBKHOILMN();

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HOFJBPAAIPB(NAIIODHHNBF HNIIKCBNMGN);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DHLLNOFKNAA
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<NAIIODHHNBF, NAIIODHHNBF> LPPEIPAEADM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<NAIIODHHNBF, NAIIODHHNBF> HKJOODKGIAI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<NAIIODHHNBF, NAIIODHHNBF, NAIIODHHNBF> HGMIMALDJAM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<NAIIODHHNBF> NBLAFODFAGB;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PGNGOMMMAIO(NAIIODHHNBF HNIIKCBNMGN, NAIIODHHNBF JDPPGKDIJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NAIIODHHNBF CGNGHKNLKML(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HOKGPHAPNOB GLFJAKADOBH(NAIIODHHNBF HNIIKCBNMGN, Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NAIIODHHNBF PNFNBBINHFG(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DIBEBAHDEBE(NAIIODHHNBF HNIIKCBNMGN, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OINPGPKFNNH(NAIIODHHNBF HNIIKCBNMGN, float PDCCLEJABHI);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool LIGACKHLGPA(NAIIODHHNBF HNIIKCBNMGN, [Out] NAIIODHHNBF JIECBJMGMAC);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LCBIPBHJKGO(NAIIODHHNBF HNIIKCBNMGN, [Out] RigidTransform KDPCMLHNPLH);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 MGDNJPGCOHN(DDJGBJOODNH DGNBDNLBGEN);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion LKEJOFFMCBF(DDJGBJOODNH DGNBDNLBGEN);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class LGOHFDINDDD
{
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MLGGKDADLKN
{
	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	object KKHEBOMDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OONLBECKDHI
{
	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FJJPLEBBEDI(NAIIODHHNBF DEJGDIIDCDN, BCFFHAFDNGI JDBDJBFOEIE);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCKKBIECLMG(BCFFHAFDNGI JDBDJBFOEIE);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LHJMHIKMFMN(NAIIODHHNBF HNIIKCBNMGN, [Out] BCFFHAFDNGI ANGJJIAMHKO);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GCGGHIEIMDF
{
	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHEKPNGOJAJ(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeArray<NAIIODHHNBF> KEHMHGGFGPN();
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Flags]
public enum DIBANGFNCDL
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
public interface NNGIBDKCHKM
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public ref struct KPFGDGBIHCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ReadOnlySpan<NAIIODHHNBF> JGHACLJOOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ReadOnlySpan<NAIIODHHNBF> OLIKBBMININ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public NAIIODHHNBF DGGCGIIIAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public NAIIODHHNBF DCBJMNKMKBK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIHLANCLFCO(NAIIODHHNBF MBNMLCEDLGO, NAIIODHHNBF AAOFJLPHDKC);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FFAIGKFLFLB(NAIIODHHNBF DKAJEJBIPCD, bool KBIBIFOFAKG);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GMEGDJEEGFD(NAIIODHHNBF ANFOAENCAFO, NAIIODHHNBF EPCEFJPHDHD);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KEOIJIAGIOE(NAIIODHHNBF JKJOEJKLENN, bool KBIBIFOFAKG);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LDKFOGFAINL(NAIIODHHNBF JKJOEJKLENN);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LEGEANFOJDH(NAIIODHHNBF JKJOEJKLENN);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NAIIODHHNBF ALNPMGNPOEK(NAIIODHHNBF DKAJEJBIPCD);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ReadOnlySpan<NAIIODHHNBF> HGLBFACIJEC(NAIIODHHNBF JKJOEJKLENN);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ReadOnlySpan<NAIIODHHNBF> EOEJAIKEAPF(NAIIODHHNBF JKJOEJKLENN);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KPFGDGBIHCO BOADGDCPDJK(NAIIODHHNBF JKJOEJKLENN, float FMHBEDJGNAH, float IHNHABGCAME);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LCCNPFPLAKC(NAIIODHHNBF JKJOEJKLENN, [Out] DEENLBKCLDB CHLOFLMLPBP);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CNKGMLKGLGA(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GEJIIDBJHAC(NAIIODHHNBF HNIIKCBNMGN);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public readonly struct DGKHPOFDFJP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly string HDNPPEBJPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly T ABINAMGBLJP;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x454FE70", Offset = "0x454F270", VA = "0x18454FE70")]
	public DGKHPOFDFJP(T ABINAMGBLJP, [Optional][CallerMemberName] string HDNPPEBJPAE)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly DGKHPOFDFJP<int> LCKGBBJFIOL;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly DGKHPOFDFJP<int> LCBDAGMHMNH;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly DGKHPOFDFJP<int> ANJDDLCDPJN;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public enum KDDHGIEMKHB
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class CHJECBJGLNI
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x1498A90", Offset = "0x1497E90", VA = "0x181498A90")]
	public static bool EGDELCANAIM(this KDDHGIEMKHB JPDKKKJJNLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x18D96F0", Offset = "0x18D8AF0", VA = "0x1818D96F0")]
	public static bool ACBHAPLILGI(this KDDHGIEMKHB JPDKKKJJNLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x3187D50", Offset = "0x3187150", VA = "0x183187D50")]
	public static bool DIKKCHAGOII(this KDDHGIEMKHB JPDKKKJJNLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x1498AA0", Offset = "0x1497EA0", VA = "0x181498AA0")]
	public static bool BELHPHLPJAP(this KDDHGIEMKHB JPDKKKJJNLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FJEGFHFPJNA
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum FGMHDEHIGDF
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
	public enum HHBNHEHKJPL
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	FGMHDEHIGDF JMHCDMMLABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	bool PLBKGGOPHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	bool OCLKMFNONKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	HHBNHEHKJPL JPBOLAMAABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.Application)]
public interface MALMJFKJJNA
{
	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	KDDHGIEMKHB GCGILIDCNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	KDDHGIEMKHB JCIOENFMGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	KDDHGIEMKHB MKHDMJCLLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	KDDHGIEMKHB PKJKLOPGALM
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	KDDHGIEMKHB FAJAAKPLJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	KDDHGIEMKHB DAHMLKKGNDC
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	KDDHGIEMKHB AEOBBJPIIKD
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	KDDHGIEMKHB GDEDBMLGOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	KDDHGIEMKHB KEIOBHBKINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	KDDHGIEMKHB GLJEAJOJMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	KDDHGIEMKHB MIIMHEGADGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	KDDHGIEMKHB JFGMDLDKHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	KDDHGIEMKHB PBJAFPEHIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	KDDHGIEMKHB LJLFJGIFADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	KDDHGIEMKHB KNAPNCHKHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	KDDHGIEMKHB NLKDBDNLBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	KDDHGIEMKHB GAKIPGBBIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	KDDHGIEMKHB HGAKCGBBEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	KDDHGIEMKHB EBHJMLOILJK
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DIJAEKOIPED(DGKHPOFDFJP<int> HFDKCBHNBMB);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DDFFIBBBDCI
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event IHFOEPCDBAC.LNKLHFMANNN GNAOPGOGLGD;

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NAIIODHHNBF MFNCPHJIBHO(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOKGPHAPNOB DFKFOKNJMEA(Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OJNFHONPFAP DIPBEPFLIBI(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CDNKCAJAMNB(IEnumerable<NAIIODHHNBF> OIOILNIMGCC);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OJNFHONPFAP HJJBENCDMLP(NAIIODHHNBF JIECBJMGMAC, NAIIODHHNBF BEOBAPANJHO, bool BJCKLOFFKNG, NAIIODHHNBF NJJNDJLGDNH);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NAIIODHHNBF IPKGCGIDGPI(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PPKDCGAIMAJ(NAIIODHHNBF HNIIKCBNMGN, NAIIODHHNBF JIECBJMGMAC, bool LKGIHIAMELF = false);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LPLJBPHONCB(NAIIODHHNBF HNIIKCBNMGN, NAIIODHHNBF JIECBJMGMAC);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AJPAPKGLAIN(NAIIODHHNBF PNMAHAEBHIE, NAIIODHHNBF BJHHNGFCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	HOKGPHAPNOB KGGPHBIDNLH(NAIIODHHNBF FBNJAHIFLKC);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PMHNGAMCEBM(NAIIODHHNBF HNIIKCBNMGN, NAIIODHHNBF AOMGFLFEAIG);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HOKGPHAPNOB KBGMOKEBDFE(HOKGPHAPNOB OAINENKGJOI, DIBANGFNCDL DPALHGCDOLB, Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CBALNCMOEAE(NAIIODHHNBF HNIIKCBNMGN, NAIIODHHNBF FBKFBKODJAE);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NAIIODHHNBF IGBLNADNFBA(NAIIODHHNBF NJJNDJLGDNH, NAIIODHHNBF IMHFGHHEPNP);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool EEFCBNODAJB(NAIIODHHNBF NJJNDJLGDNH, NAIIODHHNBF IMHFGHHEPNP, [Out] NAIIODHHNBF FKHJIJNKIPE);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NAIIODHHNBF OHOAFKCHOCN(NAIIODHHNBF[] PHJLCHBDPGC);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	NAIIODHHNBF NJABLKMLHIE(NAIIODHHNBF HNIIKCBNMGN, uint CBNOKFHGGEG);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class ENPKHBJIGHP
{
	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x8482A60", Offset = "0x8481E60", VA = "0x188482A60")]
	public static bool NHNICGNNADL(this DDFFIBBBDCI KBKKNFFIIFI, NAIIODHHNBF HNIIKCBNMGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x8482790", Offset = "0x8481B90", VA = "0x188482790")]
	public static HOKGPHAPNOB KBGMOKEBDFE(this DDFFIBBBDCI KNNNGIFKPIN, NAIIODHHNBF HNIIKCBNMGN, DIBANGFNCDL DPALHGCDOLB, Allocator KCEIEKBPKNP)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x84825C0", Offset = "0x84819C0", VA = "0x1884825C0")]
	public static HOKGPHAPNOB FFJIIIOKPGD(this DDFFIBBBDCI KNNNGIFKPIN, NAIIODHHNBF HNIIKCBNMGN, Allocator KCEIEKBPKNP)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x8482540", Offset = "0x8481940", VA = "0x188482540")]
	public static HOKGPHAPNOB BDOPHNJJPHO(this DDFFIBBBDCI KNNNGIFKPIN, NAIIODHHNBF HNIIKCBNMGN, Allocator KCEIEKBPKNP)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x8482600", Offset = "0x8481A00", VA = "0x188482600")]
	public static HOKGPHAPNOB FKGEMCPEAMB(this DDFFIBBBDCI KNNNGIFKPIN, NAIIODHHNBF HNIIKCBNMGN, Allocator KCEIEKBPKNP)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x8482580", Offset = "0x8481980", VA = "0x188482580")]
	public static HOKGPHAPNOB FDBNHPLAAPL(this DDFFIBBBDCI KNNNGIFKPIN, NAIIODHHNBF HNIIKCBNMGN, Allocator KCEIEKBPKNP)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x8482A20", Offset = "0x8481E20", VA = "0x188482A20")]
	public static HOKGPHAPNOB NFIEADPKKJM(this DDFFIBBBDCI KNNNGIFKPIN, NAIIODHHNBF HNIIKCBNMGN, Allocator KCEIEKBPKNP)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x8482750", Offset = "0x8481B50", VA = "0x188482750")]
	public static HOKGPHAPNOB KBAIPMPBEGH(this DDFFIBBBDCI KNNNGIFKPIN, NAIIODHHNBF HNIIKCBNMGN, Allocator KCEIEKBPKNP)
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x8482640", Offset = "0x8481A40", VA = "0x188482640")]
	public static HOKGPHAPNOB KBAIPMPBEGH(this DDFFIBBBDCI KNNNGIFKPIN, HOKGPHAPNOB HNIIKCBNMGN, Allocator KCEIEKBPKNP)
	{
		return default(HOKGPHAPNOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CMCGANNOGKF
{
	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x8480170", Offset = "0x847F570", VA = "0x188480170", Slot = "0")]
	Task<HEKBAMHGADC> DGKMCPHGNFJ(DAKCGOEDMGE EEJGFEMDNJK, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "1")]
	void NCHNMCKCECH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FOMGJMJGJGC
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event IHFOEPCDBAC.LNKLHFMANNN GNAOPGOGLGD;

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NAIIODHHNBF IPKGCGIDGPI(NAIIODHHNBF HCOPOFCDINJ);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<NAIIODHHNBF> CJLHFCJOABN();

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<NAIIODHHNBF> NEEAKCEAOLH(NAIIODHHNBF JIECBJMGMAC);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OFBKLDDOPEI(NAIIODHHNBF MBHLFFGBCMP, NAIIODHHNBF HMPLKAOEJNB, [Out] OJNFHONPFAP MBFPOPKHFNN);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PILEFBPBDGM(NAIIODHHNBF MBHLFFGBCMP, NAIIODHHNBF NBDFDDNIGGL, [Out] OJNFHONPFAP MBFPOPKHFNN);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CODMCMPJKMO(NAIIODHHNBF MBHLFFGBCMP);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LPLJBPHONCB(NAIIODHHNBF AIPPNGPOIPD, NAIIODHHNBF LPICKFBBMGL);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OJNFHONPFAP JABMJCEPIGL(NAIIODHHNBF HNIIKCBNMGN);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DHEEPFGFJHD
{
	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	bool EEBICJHKHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	bool NEDOCHPJJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	bool FGKHCCPAOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MJEBFNEIGCJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NFJHAAHIJIN
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNLOCLIAMDN(NAIIODHHNBF HNIIKCBNMGN, OJEHFCOLBPA NBOAFDFPIEI);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFCMPLFFENI(NAIIODHHNBF HNIIKCBNMGN, OJEHFCOLBPA NBOAFDFPIEI);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CAJCBBNDOID
{
	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGOFOLFOCNA<string> BLBNBJIPEKA(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LGOFOLFOCNA<string> JDDGBHLNFGM(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLCKBKNLDHE(NAIIODHHNBF HNIIKCBNMGN, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FFHGCAOOKHI(NAIIODHHNBF HNIIKCBNMGN, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MAELHOLHIPG(NAIIODHHNBF NGEBAKGPMMF, NAIIODHHNBF KGCJECADCMF);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OAOIPGBKCLP
{
	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JHJGBLLNBFI BHEKBBFDLDC(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNEIILDOHFP(NAIIODHHNBF ANKACPFCKKH, JHJGBLLNBFI MEDKNMLOIBI);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JJHOELHDBCI(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPIHAKLAJMH(NAIIODHHNBF ANKACPFCKKH, bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LGOFOLFOCNA<string> HODDPDONMFL(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFBFKNKFNHI(NAIIODHHNBF ANKACPFCKKH, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LGOFOLFOCNA<string> NFPGEMNCHNB(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMHHGOEOFDA(NAIIODHHNBF ANKACPFCKKH, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LGOFOLFOCNA<string> CCKOJCNBECK(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JOFHIJFNNGI(NAIIODHHNBF ANKACPFCKKH, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LGOFOLFOCNA<string> IGCBLLMBENM(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DOPOBHMBPMH(NAIIODHHNBF ANKACPFCKKH, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NNIJBICHMLG(NAIIODHHNBF ANKACPFCKKH, NAIIODHHNBF NICGPJDLKCM);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CPMDLPHOEAL
{
	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBPOMHNEBBD([In] float3 GOFLCKHIPLK, [In] float3 NLDMHMFAEEN, float ICEDCEOLBDI, [Out] APMIGNJHAOG CNLILMEGIND, [Out] NAIIODHHNBF JIJBIEHNKAL);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int CJHECDKIJNG([In] float3 GOFLCKHIPLK, float FLMDAOGEKMO, List<NAIIODHHNBF> PHJLCHBDPGC);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KPGNHNDPLKO(Plane[] GHIPHNHLPBC, float3 GOFLCKHIPLK, float3 BJHLILGAGGB, quaternion EMLGDFFEJED, List<NAIIODHHNBF> PHJLCHBDPGC);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HOGNKJNJFHN
{
	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBPOMHNEBBD([In] NativeArray<Entity> FGABDCIOGLK, [In] float3 GOFLCKHIPLK, [In] float3 NLDMHMFAEEN, [In] NativeArray<APMIGNJHAOG> OIOILLLPHBE);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> CJHECDKIJNG([In] NativeArray<Entity> FGABDCIOGLK, [In] float3 GOFLCKHIPLK, float FLMDAOGEKMO);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> KPGNHNDPLKO([In] NativeArray<Entity> FGABDCIOGLK, [In] NativeArray<float4> HJDLGHGJFAM);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct KGJEKIFJIEG : GFPDGFGKLAD, IEquatable<KGJEKIFJIEG>
{
	[Cpp2IlInjected.Token(Token = "0x17000200")]
	public int JHGBNCFKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	public int CAAKCKNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBB0", Offset = "0x2FBAFB0", VA = "0x182FBBBB0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBA0", Offset = "0x2FBAFA0", VA = "0x182FBBBA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x848C7C0", Offset = "0x848BBC0", VA = "0x18848C7C0", Slot = "8")]
	public bool Equals(KGJEKIFJIEG LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x848C810", Offset = "0x848BC10", VA = "0x18848C810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct APMIGNJHAOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float CCIMPAJPNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public float3 KIAHAFCJEPK;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JIEBAOHHPFJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHFAEJPNHJP
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	HLAFCICCABI DJILMGJMNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<HOKGPHAPNOB, NativeArray<RRObjectPrefabData>> HALMALCFILN;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<HOKGPHAPNOB> OOBPCNCGEOB;

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HOKGPHAPNOB MPBEKAIGOPA();

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PBMOMKKFMLL IFAGFFPKPPJ(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData DIIKKIHAJII(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DHJMDOJGHEA(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OAMEECEEOCH ACKDDGPJDOB(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LPOCFLBEGIO(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LHMMGFBFNKK(NAIIODHHNBF HNIIKCBNMGN, [Out] Transform GANAIKEBLIG);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NAIIODHHNBF KHIABFNKMEA(DNOIABBOEPJ LGKFNBNJHLJ);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool PKKIOJCMMPF(DNOIABBOEPJ LGKFNBNJHLJ, [Out] NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DNOIABBOEPJ OLDJJILJEKK(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HOKGPHAPNOB KHIABFNKMEA(NativeArray<DNOIABBOEPJ> LGKFNBNJHLJ, Allocator KCEIEKBPKNP, bool LJELGEBJGCO = true);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool PKPHHBCKHJF(NativeArray<PEOEKKEOCIM> GGLEEPJKLJG, NativeArray<DNOIABBOEPJ> IFEOACCLJNL, NativeArray<Entity> KIBFBDBKOLC, LGOFOLFOCNA<KFNNMIHFMBA> BKDHGBDOBPA);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	OAMEECEEOCH LJIDAAAMJMN();

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	OAMEECEEOCH EBKBELDCCHC(RRObjectPrefabData HCOCMBHFGFG, [Optional] NALOKHDCBNN MIJOFKBHCAK);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	AAECFLCMDEN EGILFJDDLOK();

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	MCGPACNOOPH FPECKOINAEB();

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	ABBFGPENHBK NMMBDAOOGMC(BFBNMLCCBFM DKDLPDPNMMC);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LMPIIKNIADF(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool CELEBOFALBG(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HOKGPHAPNOB CGBOKJAFJKG(HOKGPHAPNOB CPPDKJALBNJ, Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool KNLAECGHIJO(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FLNNLMLNOOA(NAIIODHHNBF HNIIKCBNMGN, ComponentTypes IIGOAHJGBIE);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "28")]
	NAIIODHHNBF HPLEEBMAKEL(Transform GANAIKEBLIG);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class OPBKLAKDFMP
{
	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x84944A0", Offset = "0x84938A0", VA = "0x1884944A0")]
	internal static NAIIODHHNBF OKIEFGCDFPD(this Entity MEOOAHKPJCE, MHFAEJPNHJP GFKIDJOBMJK)
	{
		return default(NAIIODHHNBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x8494760", Offset = "0x8493B60", VA = "0x188494760")]
	public static OAMEECEEOCH OPPFCIJIGCO(this MHFAEJPNHJP GFKIDJOBMJK, LocalId HNIIKCBNMGN)
	{
		return default(OAMEECEEOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x84943F0", Offset = "0x84937F0", VA = "0x1884943F0")]
	public static NAIIODHHNBF KHIABFNKMEA(this MHFAEJPNHJP GFKIDJOBMJK, LocalId HNIIKCBNMGN)
	{
		return default(NAIIODHHNBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x8494550", Offset = "0x8493950", VA = "0x188494550")]
	public static DNOIABBOEPJ OLDJJILJEKK(this MHFAEJPNHJP GFKIDJOBMJK, LocalId HNIIKCBNMGN)
	{
		return default(DNOIABBOEPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x84945C0", Offset = "0x84939C0", VA = "0x1884945C0")]
	public static AAECFLCMDEN OONFMDIKFPH(this MHFAEJPNHJP GFKIDJOBMJK, RigidTransform MMPBDMLMPGJ)
	{
		return default(AAECFLCMDEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x8494770", Offset = "0x8493B70", VA = "0x188494770")]
	public static ABBFGPENHBK PJODILKDPIN(this MHFAEJPNHJP GFKIDJOBMJK, BFBNMLCCBFM LKBHLCAIMIP, RigidTransform MMPBDMLMPGJ)
	{
		return default(ABBFGPENHBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x8494250", Offset = "0x8493650", VA = "0x188494250")]
	public static MCGPACNOOPH EGHMLMNBMKN(this MHFAEJPNHJP GFKIDJOBMJK, RigidTransform MMPBDMLMPGJ)
	{
		return default(MCGPACNOOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x8494220", Offset = "0x8493620", VA = "0x188494220")]
	private static void AJBJIAHPPAP(OAMEECEEOCH CANOPIHDPAM, RigidTransform MMPBDMLMPGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal interface OJHDEJCAFJF
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AMOMFNJCBAN
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	bool PBFKDKJOAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	NAIIODHHNBF AJPIKNNNBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	OAMEECEEOCH NKNIJHLABHB
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event GGAJHDHAJJH CMHGNADECJK;

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NAIIODHHNBF IGBLNADNFBA(NAIIODHHNBF NJJNDJLGDNH, NAIIODHHNBF IMHFGHHEPNP);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EEFCBNODAJB(NAIIODHHNBF NJJNDJLGDNH, NAIIODHHNBF IMHFGHHEPNP, [Out] NAIIODHHNBF FKHJIJNKIPE);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GKKCBKAHCND();

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NGOJNFPDNKF();

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HBHOHHGBNDG(NAIIODHHNBF NJJNDJLGDNH);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NLNKLJHGJEG(NAIIODHHNBF NJJNDJLGDNH);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public delegate void GGAJHDHAJJH(OAMEECEEOCH OGMOHLKLICE, OAMEECEEOCH CDGHLHBEOFK);
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class INFKJJFJLKI
{
	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x848B680", Offset = "0x848AA80", VA = "0x18848B680")]
	public static bool DALFPMDEIGP(this AMOMFNJCBAN FBJJAKHOMAK, OAMEECEEOCH NJJNDJLGDNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x848B750", Offset = "0x848AB50", VA = "0x18848B750")]
	public static bool IGIFKKEDKOH(this AMOMFNJCBAN FBJJAKHOMAK, NAIIODHHNBF NJJNDJLGDNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x848B6D0", Offset = "0x848AAD0", VA = "0x18848B6D0")]
	public static bool EDPJPCNAMCP(this AMOMFNJCBAN FBJJAKHOMAK, NAIIODHHNBF NJJNDJLGDNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HAGHILCFJMD
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFPJADNDHAK(NativeList<RRObjectPrefabData> IDGEOHJNLPI);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EKFPDKJPIAM
{
	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBCGKNKECGN(OAMEECEEOCH CANOPIHDPAM, GDCPGHBNPPK OBGGAHJDHFG, List<OAMEECEEOCH> LJLNHEOADNE);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ACOOMJFCHJJ(OAMEECEEOCH CANOPIHDPAM, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIIAMBFODBH(OAMEECEEOCH CANOPIHDPAM, List<OAMEECEEOCH> LJLNHEOADNE);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PENPPLDLEPP(OAMEECEEOCH CCGANJILKHA, OAMEECEEOCH NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OAMEECEEOCH EDKDIMPKNBI(OAMEECEEOCH CCGANJILKHA, int NOEININIMIL, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNBMGPFHLOF(OAMEECEEOCH CCGANJILKHA, OAMEECEEOCH NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KLFNMCLCIDJ(OAMEECEEOCH CCGANJILKHA, OAMEECEEOCH NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LBKCDGNOMGB(OAMEECEEOCH CCGANJILKHA, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OHHPFOMKGJD(OAMEECEEOCH CCGANJILKHA, OAMEECEEOCH NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GAGFMCKECEN(Entity CCGANJILKHA, Entity NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BHMCBLIFMDB(Entity CCGANJILKHA, GDCPGHBNPPK OBGGAHJDHFG);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GKIOLCOBODL(OAMEECEEOCH NJJNDJLGDNH, GDCPGHBNPPK OBGGAHJDHFG);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NFOCNCEHBMF
{
	[Cpp2IlInjected.Token(Token = "0x17000207")]
	FAGPBEJFEMP CLIKOOPNCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JMAJLEBDBPE PCNKNGCJOBN(FAGPBEJFEMP CHBELKDGKBD);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FAGPBEJFEMP CHPPBFDBCCB();

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FAGPBEJFEMP KEGKMJABAEB();
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OCLOPOPALDC
{
	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INFPBNIBJIE(NAIIODHHNBF NJJNDJLGDNH, [Out] NAIIODHHNBF FDNKEICCOIM);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BNABIFGDLDE
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<NAIIODHHNBF> LHKDAPPJNAM;

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGEHKOJBALA(NAIIODHHNBF FBNJAHIFLKC, bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPEMIDCKCAD(NAIIODHHNBF FBNJAHIFLKC, bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NECJEJJLMBG(NAIIODHHNBF FBNJAHIFLKC, int CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ELOONHGKGHE
{
	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<NAIIODHHNBF> FLGBKJHKEAJ(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NAIIODHHNBF AIJPKBKJHFO(NAIIODHHNBF HNIIKCBNMGN, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GOBJIKLFGKE(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BFGADLCEFPF BKJHKPKGDAN(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIGEIHDDKED(NAIIODHHNBF HNIIKCBNMGN, BFGADLCEFPF FGEMBJJOPFK);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NAIIODHHNBF IBBBDNNPDJP(NAIIODHHNBF HNIIKCBNMGN, [Optional] float3? LBCFHLNAPLC, [Optional] quaternion? EMLGDFFEJED, [Optional] float3? MJHAIBCGLLD);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NAIIODHHNBF HOENGDLHIEJ(NAIIODHHNBF HNIIKCBNMGN, int NOEININIMIL, [Optional] float3? LBCFHLNAPLC, [Optional] quaternion? EMLGDFFEJED, [Optional] float3? MJHAIBCGLLD);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KKEEFIHIFLA(NAIIODHHNBF HNIIKCBNMGN, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NKPEJMDIBHJ(NAIIODHHNBF HNIIKCBNMGN);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NIODNFKJHAF
{
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FJILNINBNME
{
	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHDODMNNDJD(NAIIODHHNBF HNIIKCBNMGN, ReadOnlySpan<TerrainGenerationLayer> MLNIOMCPGOA);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOECDDLAPLL(NAIIODHHNBF HNIIKCBNMGN, ReadOnlySpan<GCFFMGKDNLP> MLNIOMCPGOA);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CFFGMIPDMOB
{
	[Cpp2IlInjected.Token(Token = "0x17000208")]
	bool JGNKFHGOFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBPCHCINDLF();

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPBLJPFNHNB();

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADEAEBFEGCJ();

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PMJHNPJACPP();

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JEKFNCAMJBF();

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AOOKOFFBDNB();

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KFEFEKPCPLC();

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CKMKLBPNFOJ();

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ADJCNNCNHCA();

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AHDMBHOILGI();

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CAAPJBDMGNM();

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AMLODDFAHMH();
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BNFPGIFBFBJ
{
	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LAJAJEHOIGA(NAIIODHHNBF NJJNDJLGDNH, [Out] int CCGANJILKHA);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJDDKCFFOFL(NAIIODHHNBF NJJNDJLGDNH, int CCGANJILKHA);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMIOJPJKPCA(NAIIODHHNBF NJJNDJLGDNH, bool MAAOGPMHLJB);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFPNDCLCJEC(NAIIODHHNBF NJJNDJLGDNH, float LIGFFDKKGGM, float BMGHBNBILDL, float AJHDIJFJJEM);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PPBLNFIEPOD(NAIIODHHNBF HNIIKCBNMGN, [Out] float BMGHBNBILDL, [Out] float AJHDIJFJJEM);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGENOFGHNNB(NAIIODHHNBF NJJNDJLGDNH, float3 LBCFHLNAPLC, quaternion EMLGDFFEJED);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BDFMDCLEBGO(NAIIODHHNBF NJJNDJLGDNH, [Out] float3 LBCFHLNAPLC, [Out] quaternion EMLGDFFEJED);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CCBIPEABPII(NAIIODHHNBF NJJNDJLGDNH);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FOOPJJDIOEH
{
	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCKPHCAIHDJ(Entity MEOOAHKPJCE, [In] float3 CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 HCJNMHPBOPM(Entity MEOOAHKPJCE);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDAOHLDJJGB(Entity MEOOAHKPJCE, [In] quaternion CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion DNIJMCPEGEM(Entity MEOOAHKPJCE);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGPCCECPNEA(Entity MEOOAHKPJCE, [In] float3 LBCFHLNAPLC, [In] quaternion EMLGDFFEJED);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OOGPPPOAFEM(Entity MEOOAHKPJCE, [Out] RigidTransform KJOOFEFGGOF);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KGCIOPAMKAO(Entity MEOOAHKPJCE, [In] float3 LBCFHLNAPLC, [In] quaternion EMLGDFFEJED);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LLILNEPDONP(Entity MEOOAHKPJCE, [Out] float3 LBCFHLNAPLC, [Out] quaternion EMLGDFFEJED);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LLILNEPDONP(Entity MEOOAHKPJCE, [Out] RigidTransform KJOOFEFGGOF);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BLIAEKKLODE(Entity MEOOAHKPJCE, float CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float BOHCGEOIEOG(Entity MEOOAHKPJCE);

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IGMOOFGALBB(Entity MEOOAHKPJCE, [In] float3 CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 GPKJDLAFGNF(Entity MEOOAHKPJCE);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JKCOFHJCJHP(Entity MEOOAHKPJCE, [In] quaternion CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion AJAOGPFGFHN(Entity MEOOAHKPJCE);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DNPJIACOFPG(Entity MEOOAHKPJCE, float CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float EOBIDEGNMCG(Entity MEOOAHKPJCE);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HCELIFHMFBL(Entity MEOOAHKPJCE, [Out] float4x4 LCHGFDBANLN);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FCEBCAIDOGE(Entity MEOOAHKPJCE, [In] float4x4 LCHGFDBANLN);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void AGNGCHMDPKC(Entity MEOOAHKPJCE);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GLMHKMAEDAP(Entity MEOOAHKPJCE, Entity DNNKPCKHKEP, Entity LPICKFBBMGL);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class HFMMOIMBBJO
{
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KDDMNMBCONC
{
	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNCHIJLOFCO(bool NKIKDGHHLIL);
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ODHDBENJMPP
{
	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GADKPLAKDLN(NAIIODHHNBF ANKACPFCKKH, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICAGPNCMELG(NAIIODHHNBF ANKACPFCKKH, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIABFOBJKMA(NAIIODHHNBF ANKACPFCKKH, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPJFNCDAICM(NAIIODHHNBF ANKACPFCKKH, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEFAGPEIAGA(NAIIODHHNBF ANKACPFCKKH, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JADKONJDHIK(NAIIODHHNBF ANKACPFCKKH, LGOFOLFOCNA<string> AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JOHHJIMMBOK(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int PEGHFBIOMPM(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int CCONMGHOOHB(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PNBCFLDECIA<string> IIFBGJHBMBB(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BLCICJFIJLG(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PNBCFLDECIA<string> GBPEMPFPJNL(NAIIODHHNBF ANKACPFCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ECKAHGCPIJF(NAIIODHHNBF ANKACPFCKKH, string HHKLKJCBFCE);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DHNAGCKKFLE(string HHKLKJCBFCE, OGKGFAOMCHI JKIIFOAFECJ);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NAIIODHHNBF ENIBHBMDEDC(string HHKLKJCBFCE);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MLPIMDOOMHD(string HHKLKJCBFCE, OGKGFAOMCHI JKIIFOAFECJ);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ELDJMGIKFAF(NAIIODHHNBF ONELAAHDIDB, string HHKLKJCBFCE, OGKGFAOMCHI JKIIFOAFECJ);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PNBCFLDECIA<string> OPJLCIAHEFH();
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class OPBKHEEHNBF
{
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LFFOFOPKOAD
{
	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World FFMPECGJMJM(string BDKELNPDHHJ = "Main");

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World BGLCIBPMDKH(string BDKELNPDHHJ = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World INOLCADPPAC(string BDKELNPDHHJ = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World HFIPNKPJGEI(string BDKELNPDHHJ = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DJEGDOLDLFH
{
	[Cpp2IlInjected.Token(Token = "0x17000209")]
	World MCIICBEKAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	World PLDKBAGHKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	EntityManager LLDMANKJGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	bool OEKNIBMILKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase FOONGBHFLJC(Type IIHAKBEOLJD);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class MPGFFHKLGBP
{
	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x848FE60", Offset = "0x848F260", VA = "0x18848FE60")]
	public static ComponentSystemBase JACKLIKNNNM(this World BADONBAKCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8FB0", Offset = "0x3DF83B0", VA = "0x183DF8FB0")]
	public static T FOONGBHFLJC<T>(this DJEGDOLDLFH DDMLMBHCJAH) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IBOAKDNMMLM
{
	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJEDENPNDHN(NativeListAsync<Entity> LGCPKOEAGPN);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEMHDJODBLP(CBOFCKGDHCL CEHMAMFMGEM);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBDFELMMHML(NativeListAsync<Entity> IHMLBNCNMPH, bool PFDJNAHLPGL);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFCMJCPFJAA();

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOJBMDEDOBL(Entity LDEPDDDHLLO);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface COJCAOGKNCI
{
	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBHFMDNIEPG(Collider NLMGKPGMOBC, [Out] GAGBOOCEKHA BLGDPDCLICL);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OKMMFMDNONO
{
	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider NCDLOJOABDH(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject BDGONNMLOFH(NAIIODHHNBF MCKPEDILKIF, GameObject MKFMLBCIMEB, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBJINIILBNG(GameObject NLMGKPGMOBC);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider DKMMDIEHDOE<TCollider>(GameObject LJNEOEBDKLH) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPEGHMMCKDD(Collider NLMGKPGMOBC);

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject CNPIPFPPNHC<TCollider>(string HDNPPEBJPAE) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GJJDPKCKHPO MHGGPOABMKP(NAIIODHHNBF PMENIDMKNOD, NAIIODHHNBF DJPPFOALKBF, BFBNMLCCBFM POEBAPPKKJL, float3 LJIKCKIMIDE, quaternion BJFIHCHNALK, float3 GAPOEDFJKKB);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ILGBLGIGPJG(NAIIODHHNBF HNIIKCBNMGN, [Out] GJJDPKCKHPO NLMGKPGMOBC);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BKDIAJNLHEI(NAIIODHHNBF HNIIKCBNMGN, [Out] NAIIODHHNBF LDEPDDDHLLO);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public enum CNCCGFFLNII
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
public interface PLNPFJLOHIL
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public struct FHPAIIPFFOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int POEBAPPKKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GameObject MKFMLBCIMEB;
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILIPAIILBPM(NAIIODHHNBF HNIIKCBNMGN, CGPPANCJEFA FNJHHLMPHBG, bool BELGJPNAKIH, BNADNEMKMMC BNMPEKCPHEA);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILEMIAKOBNE(NAIIODHHNBF HNIIKCBNMGN, CGPPANCJEFA FNJHHLMPHBG, bool BELGJPNAKIH, bool MFALIMEOOAM, bool EOLALHEPHJJ);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IBAIAMHIOAO EOFFIJHLNMK(NAIIODHHNBF LDEPDDDHLLO, List<NAIIODHHNBF> DHBMKJAKPJK);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GJJDPKCKHPO LHOGAPBFOPN(GameObject KODKHOAKCFH, GameObject CCJLGMICHEJ);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBFEAFLMMFM(GameObject KODKHOAKCFH, List<GameObject> NBPGNMHDCAJ);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OHDDIFICIHG(GameObject CCJLGMICHEJ);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T DKMMDIEHDOE<T>(GameObject LJNEOEBDKLH) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FPEGHMMCKDD(Collider NLMGKPGMOBC);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject BILOAMCLAJH<T>(string HDNPPEBJPAE) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KGLPLGEGNNJ(Collider NLMGKPGMOBC, [Out] NAIIODHHNBF CCGANJILKHA);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GJNDLMKANAE(NAIIODHHNBF HNIIKCBNMGN, [Out] GAGBOOCEKHA BLGDPDCLICL);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<CNCCGFFLNII> BEKJPBDEEJE(Allocator KCEIEKBPKNP = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] KPJOHMCLMCN();
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AEFLIHBPMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKFHPNBABH(NAIIODHHNBF HNIIKCBNMGN, NAIIODHHNBF CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAOMNBKJBHP(NAIIODHHNBF HNIIKCBNMGN, NAIIODHHNBF CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GIEFCMOAGDF(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NAIIODHHNBF ABHJEFONKKD(NAIIODHHNBF HNIIKCBNMGN, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HOKGPHAPNOB PHGCONGLKAB(NAIIODHHNBF HNIIKCBNMGN, Allocator KCEIEKBPKNP = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNIJNPNJAME(NAIIODHHNBF HNIIKCBNMGN, object MONGIMOHLAO, NAIIODHHNBF CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MLBMCOJLJKF(NAIIODHHNBF HNIIKCBNMGN, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MBHPLCIMCPM(NAIIODHHNBF HNIIKCBNMGN, [Out] NAIIODHHNBF CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCMCDPOBNCM(NAIIODHHNBF HNIIKCBNMGN, float3 CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BNJNFNBCBBJ(NAIIODHHNBF HNIIKCBNMGN, [Out] float3 CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AFCMCJAHNNB(NAIIODHHNBF HNIIKCBNMGN, float3 CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FPNDNBKABMA(NAIIODHHNBF HNIIKCBNMGN, [Out] float3 CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CPGLBAILIED(NAIIODHHNBF HNIIKCBNMGN, (Quaternion rot, Vector3 moments) AMFBBMEJKPC);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool IFEOGMCEHHF(NAIIODHHNBF HNIIKCBNMGN, [Out] quaternion AOLCBAKAICF, [Out] float3 EMGGNPJCDAA);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LCKCMMBBOJM(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 OMGNLKOCFMI(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 FABDHHEDDBC(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HIAHBPFOPJN(NAIIODHHNBF HNIIKCBNMGN, float3 CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JMAPFIELCDL(NAIIODHHNBF HNIIKCBNMGN, float3 CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float MCBMAAGPBKM(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float LBIJPICBENH(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GIOJONADIOJ(NAIIODHHNBF HNIIKCBNMGN, float CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IFFOGLJCNAK(NAIIODHHNBF HNIIKCBNMGN, float CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode HJBPMCNMABN(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CLLODLLGKDI(NAIIODHHNBF HNIIKCBNMGN, CollisionDetectionMode CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LDGMPMKAKEN DMGKJEJNCJC(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NKCHABDKJFH(NAIIODHHNBF HNIIKCBNMGN, LDGMPMKAKEN CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EMIIPFENLEI(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BHLMIMGNEMM(NAIIODHHNBF HNIIKCBNMGN, bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "29")]
	NAIIODHHNBF MFNCPHJIBHO(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void ADMDKEAPAFC(NAIIODHHNBF HNIIKCBNMGN, NAIIODHHNBF CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "31")]
	NAIIODHHNBF IPKGCGIDGPI(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PPKDCGAIMAJ(NAIIODHHNBF HNIIKCBNMGN, NAIIODHHNBF CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "33")]
	IAOENOOJLJP GMGJLDKEPML(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void NDKNCMDKDBN(NAIIODHHNBF HNIIKCBNMGN, IAOENOOJLJP MMGBJKAOGPE);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool OINAEENAILN(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void ADCJDNLGOFP(NAIIODHHNBF HNIIKCBNMGN, bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool AJNDFMHEDOO(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void KMBPJGNJMNL(NAIIODHHNBF HNIIKCBNMGN, bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints KFOLPHCLPKP(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BKKJFBFNLOA(NAIIODHHNBF HNIIKCBNMGN, RigidbodyConstraints CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float OPJEGNHAGGM(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void IKNOGPOEIKH(NAIIODHHNBF HNIIKCBNMGN, float CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float MLFAFAKPCLK(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void MCHJEPHMDCN(NAIIODHHNBF HNIIKCBNMGN, float CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool OPCHBPFIJBD(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void GOKNNIIPBBN(NAIIODHHNBF HNIIKCBNMGN, bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool PBBECLDPHAO(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void HNBEDNJLDPN(NAIIODHHNBF HNIIKCBNMGN, bool CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CIDHAFDGLMB(NAIIODHHNBF HNIIKCBNMGN, int CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "50")]
	LLFNGCOOPGE PNMEJOJPCKP(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void HOCIHBNHEMM(NAIIODHHNBF HNIIKCBNMGN, LLFNGCOOPGE CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "52")]
	BNNLLMJJDPO IFEGGGOCNNJ(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void KBHGCCCHAKH(NAIIODHHNBF HNIIKCBNMGN, BNNLLMJJDPO CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float FONKPEDECFC(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void KCIOHECHGFN(NAIIODHHNBF HNIIKCBNMGN, float CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void KIHBHILNGMI(NAIIODHHNBF HNIIKCBNMGN, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void NKHJJBHBLKG(NAIIODHHNBF HNIIKCBNMGN, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool KMEPAAJOMGE(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void IECLFKPHKBH(NAIIODHHNBF HNIIKCBNMGN, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void EPDALBCNIBD(NAIIODHHNBF HNIIKCBNMGN, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool FBOIDEGJONA(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool OCEMIPHNDPF(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody CGMAFIGEMMN(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void IBCPBEBADDE(NAIIODHHNBF HNIIKCBNMGN, Rigidbody JAFLLGIEKOM);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void PLDBGMIIOCJ(NAIIODHHNBF HNIIKCBNMGN, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void HEBJHCHCMEF(NAIIODHHNBF HNIIKCBNMGN, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool GCLCMOGAKEL(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void FDKCDHIDMHH(NAIIODHHNBF HNIIKCBNMGN, float3 PODFFOEBFLC);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void AEOLAGPLFKE(NAIIODHHNBF HNIIKCBNMGN, float3 NBPDCMBDPJL);

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool MEAIBPGEHOE(NAIIODHHNBF HNIIKCBNMGN, [Out] float3 PODFFOEBFLC);

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool ELLCDNKPHMN(NAIIODHHNBF HNIIKCBNMGN, [Out] float3 NBPDCMBDPJL);

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool HKJHCJNDBLK(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void HGJKJJMJIAC(NAIIODHHNBF HNIIKCBNMGN, object MONGIMOHLAO, bool GHMABHCPHDE);

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void LOOFNEGCBPJ(NAIIODHHNBF HNIIKCBNMGN, bool BMPHJGCHBFM);

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void CPOAIFCBKDD(NAIIODHHNBF HNIIKCBNMGN);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool FIMCHAOGKHN(NAIIODHHNBF HNIIKCBNMGN);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IKNMOJOENBC
{
	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFMDLKDFOAN(Entity AGLGFOHCFPO);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPCEOBHEKBJ(Entity AGLGFOHCFPO);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOAPMEONGHJ(Entity AGLGFOHCFPO);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ANFIJLBKKNE
{
	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLBLLHANJIH(NAIIODHHNBF NJJNDJLGDNH, bool ILNJHNCJPFK);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public delegate void MGAOCFHIIGI(GIACOGODKJL GMLFDPBNGHE);
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly ref struct GIACOGODKJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly HOKGPHAPNOB DDMEFKOKONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly NativeArray<byte> AANJFBMPELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly NativeArray<byte> NFNOLGJEOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly OJEHFCOLBPA NBOAFDFPIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly int PGIIEJGEHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Type BFNAOJPNIIL;

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	public HOKGPHAPNOB OMHFPLACGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x510B460", Offset = "0x510A860", VA = "0x18510B460")]
		get
		{
			return default(HOKGPHAPNOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	public int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x8484160", Offset = "0x8483560", VA = "0x188484160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	public OJEHFCOLBPA DECDJGINCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
		get
		{
			return default(OJEHFCOLBPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x84841B0", Offset = "0x84835B0", VA = "0x1884841B0")]
	public GIACOGODKJL(HOKGPHAPNOB DDMEFKOKONA, NativeArray<byte> AANJFBMPELD, NativeArray<byte> NFNOLGJEOIA, OJEHFCOLBPA NBOAFDFPIEI, int PGIIEJGEHKG, Type BFNAOJPNIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4820", Offset = "0x3CB3C20", VA = "0x183CB4820")]
	public NativeArray<T> DAGLCHPKJEP<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4950", Offset = "0x3CB3D50", VA = "0x183CB4950")]
	public NativeArray<T> PODNPKIEMCH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4860", Offset = "0x3CB3C60", VA = "0x183CB4860")]
	public (HOKGPHAPNOB, NativeArray<T>, NativeArray<T>) DIJAEKOIPED<T>() where T : struct
	{
		return default((HOKGPHAPNOB, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x8484180", Offset = "0x8483580", VA = "0x188484180")]
	public ECJJJEIONOJ MPFIELOONDF()
	{
		return default(ECJJJEIONOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface JLPHNCPJEJN
{
	[Cpp2IlInjected.Token(Token = "0x17000210")]
	string GNJEBHGPEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	JLPHNCPJEJN KPAHHLNOOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	IEnumerable<JLPHNCPJEJN> DBFFAOPIEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OBDHDMPBCDO
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	JLPHNCPJEJN HCLNLPBGJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	NativeArray<OJEHFCOLBPA> JPGMPKBMFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OFBOJLFIIOA(OJEHFCOLBPA NBOAFDFPIEI, [Out] JLPHNCPJEJN JFINDLBKLHM);

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAGBOPIEMBE(OJEHFCOLBPA NBOAFDFPIEI, MGAOCFHIIGI KBMDNBDNGFD);

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDMOJFMGAAL(OJEHFCOLBPA NBOAFDFPIEI, MGAOCFHIIGI KBMDNBDNGFD);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ENOLMAJCHPI
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAGBOPIEMBE(OJEHFCOLBPA NBOAFDFPIEI, MGAOCFHIIGI KBMDNBDNGFD);

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDMOJFMGAAL(OJEHFCOLBPA NBOAFDFPIEI, MGAOCFHIIGI KBMDNBDNGFD);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class MODCLEJOOPE
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CLFCFOAFCHG
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	bool GCEEJFEFBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000216")]
	BCDEKBEPIJH EMDPHHMLCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INGNAIBEEKH(JMAJLEBDBPE LGKFNBNJHLJ, bool LIDKDNNNBOH);

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IPFBGKIBBOF(DNOIABBOEPJ LGKFNBNJHLJ, OJEHFCOLBPA NBOAFDFPIEI);

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDNMBFFLMAF(NativeArray<DNOIABBOEPJ> IOHHNJJAHPA);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class BPHPKPJBDKF
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public readonly ref struct ECJJJEIONOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly GIACOGODKJL NGIAGNLBILI;

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public HOKGPHAPNOB OMHFPLACGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x510B460", Offset = "0x510A860", VA = "0x18510B460")]
		get
		{
			return default(HOKGPHAPNOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x8481F60", Offset = "0x8481360", VA = "0x188481F60")]
	public ECJJJEIONOJ(GIACOGODKJL NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x8481A10", Offset = "0x8480E10", VA = "0x188481A10")]
	public HOKGPHAPNOB DAGLCHPKJEP()
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x8481E30", Offset = "0x8481230", VA = "0x188481E30")]
	public HOKGPHAPNOB PODNPKIEMCH()
	{
		return default(HOKGPHAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x8481B40", Offset = "0x8480F40", VA = "0x188481B40")]
	public (HOKGPHAPNOB, HOKGPHAPNOB, HOKGPHAPNOB) DIJAEKOIPED()
	{
		return default((HOKGPHAPNOB, HOKGPHAPNOB, HOKGPHAPNOB));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class MKGCCKOGMOE
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public readonly struct BCDEKBEPIJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly NativeBitArray DDHCGLOMAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly NativeParallelHashMap<DNOIABBOEPJ, int> ELFPJDNBICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly NativeParallelHashSet<JMAJLEBDBPE> EKEHOKOLPCC;

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public bool JJFNOPKOLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x847E890", Offset = "0x847DC90", VA = "0x18847E890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public bool GCEEJFEFBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x847EAA0", Offset = "0x847DEA0", VA = "0x18847EAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x6111A40", Offset = "0x6110E40", VA = "0x186111A40")]
	public BCDEKBEPIJH(NativeBitArray DDHCGLOMAFI, NativeParallelHashMap<DNOIABBOEPJ, int> ELFPJDNBICA, NativeParallelHashSet<JMAJLEBDBPE> EKEHOKOLPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x847E8B0", Offset = "0x847DCB0", VA = "0x18847E8B0")]
	public bool IPFBGKIBBOF(DNOIABBOEPJ LGKFNBNJHLJ, OJEHFCOLBPA NBOAFDFPIEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MOHAGAINBII
{
	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	MPJPIJDIFLM DFIBAKGGCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface MFGDNLAANGB
{
	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMEDOFNMFBC(NAIIODHHNBF HNIIKCBNMGN, GHFLJPPKMHJ CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGNHPGHDKAF LHPNLNJLKBO();
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FCBFAGKFLPB
{
	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGNJFODHPHN(World BADONBAKCJC);

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFPBDLLJCIE(World BADONBAKCJC);

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase NALKADBENGJ(World BADONBAKCJC);

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNMFOFLELOF(World BADONBAKCJC);

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPHKOMLMPAM(World BADONBAKCJC);

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CEFJCOMOJHJ(World BADONBAKCJC);

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJMIALCKMGP(World BADONBAKCJC);

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> MMBMHDIIMLE();
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MJJBEPODCPM
{
	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJPPLEMAHEI(NAIIODHHNBF FBNJAHIFLKC, bool CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public readonly struct OBHJAFMNPEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IEnumerable<AJGEFLJHLOD> EILMPOKFKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IReadOnlyList<GameObject> EKEJGOOICLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly IReadOnlyList<int> NFGIBFOLFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IReadOnlyList<(DNOIABBOEPJ, DNOIABBOEPJ)> JKCDMLKKMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly int ILBOLKDBAOB;
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public struct DLPHBEGCDOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public InventionIdData CLNGGGMIBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public InventionInstanceIdData OIPFBFJKLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool PEKJAIKEKOI;

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x84814C0", Offset = "0x84808C0", VA = "0x1884814C0")]
	public DLPHBEGCDOA(long CLNGGGMIBPI, Guid OIPFBFJKLHK, bool PEKJAIKEKOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[ServiceLifetime(Lifetime.Application)]
public interface PFJMMCIIHOA
{
	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HEKBAMHGADC LDHJPDOLDDI(DAKCGOEDMGE KCBLPMENKNL, int HBEJOBODBKL = 0, bool HPPPMIAJJHE = false);

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LHEIOAMAFNG APBBHGHPHEP(DAKCGOEDMGE KCBLPMENKNL, NAIIODHHNBF JIECBJMGMAC, [In] UniformTRS EFHKMNLJGGH, KGPKHFIDLJM MJDEEFLELFO, [Optional] DLPHBEGCDOA KKBHKAMFCGK, bool DPGHOPNCOJG = true, bool EMNPALKBLDJ = false, bool HPPPMIAJJHE = false, bool FHINCGFPEDP = false);

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DAGKPJAGHBL IKJOOMFICKD();

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DAGKPJAGHBL HEBDAPGLCPE(HOKGPHAPNOB PHJLCHBDPGC, [In] UniformTRS OFIOEDPAMKJ, [Optional] KGPKHFIDLJM ONMCPBJMMBG);

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BBCDHCFBJLA(NAIIODHHNBF PEFKJCKBBOL);

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BILDCBCPHNO(NAIIODHHNBF PEFKJCKBBOL, [Out] Exception GGJDDHMDBJI);

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<DNOIABBOEPJ> BKMGDKGGEDJ(NAIIODHHNBF PEFKJCKBBOL, Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<DNOIABBOEPJ> ABGJENJMPHI(NAIIODHHNBF PEFKJCKBBOL, Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HOKGPHAPNOB PBBPDFFCPDD(NAIIODHHNBF PEFKJCKBBOL, Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HOKGPHAPNOB JCHDCPGIFBI(NAIIODHHNBF PEFKJCKBBOL, Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HOKGPHAPNOB HPHJKNAOPAF(NAIIODHHNBF PEFKJCKBBOL, Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> DKFAKEGHDCC(NAIIODHHNBF PEFKJCKBBOL, Allocator KCEIEKBPKNP);

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FMDENIPDBGP(NAIIODHHNBF PEFKJCKBBOL);

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int JLCALCEIIPP(NAIIODHHNBF PEFKJCKBBOL, int PPNAGMANAKJ);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.Application)]
public interface EMEFAIEEHNG
{
	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0xF28990", Offset = "0xF27D90", VA = "0x180F28990", Slot = "0")]
	bool MDNPGNBFALF(object FCGKHKJBFED, KMOGAEBEGPF DBCHIOJILOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public static class ODOAEICHHMJ
{
	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x8491EA0", Offset = "0x84912A0", VA = "0x188491EA0")]
	public static bool MDNPGNBFALF(this EMEFAIEEHNG KNNNGIFKPIN, object FCGKHKJBFED, [Out] KMOGAEBEGPF DBCHIOJILOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public enum KINJHIAFJJF : byte
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
public interface KMOGAEBEGPF
{
	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	FMGMOFJMBLC GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	NNAECDFEPDN CBOFALAFBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	bool OLBMKKBEIAE
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	bool KCBODLPMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object APLLMCNAMLK();

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x10927A0", Offset = "0x1091BA0", VA = "0x1810927A0", Slot = "5")]
	(NNAECDFEPDN, object) KBGGNAGJLJJ()
	{
		return default((NNAECDFEPDN, object));
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "6")]
	(DNOIABBOEPJ, NNAECDFEPDN) BJBHOAEDAPL()
	{
		return default((DNOIABBOEPJ, NNAECDFEPDN));
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "7")]
	OFDAKGDMHMK<(DNOIABBOEPJ, NNAECDFEPDN)> IGBEDCFKPAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x10927A0", Offset = "0x1091BA0", VA = "0x1810927A0", Slot = "8")]
	(NKPPOELGPAG, byte[]) EFNICCGCOGM()
	{
		return default((NKPPOELGPAG, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x10927A0", Offset = "0x1091BA0", VA = "0x1810927A0", Slot = "9")]
	(MBEDCBJABND, byte[]) IPANELHAHCN()
	{
		return default((MBEDCBJABND, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x10927A0", Offset = "0x1091BA0", VA = "0x1810927A0", Slot = "10")]
	T OOMPOFEJKHM<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class FAKCNNBHINK
{
	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x8482F30", Offset = "0x8482330", VA = "0x188482F30")]
	public static bool DJKBDCDAKBN(this KMOGAEBEGPF EGMDPKHDKLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface JKPELIFOGDK : OFDAKGDMHMK<LPDMMEHBJGN>
{
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[DefaultMember("Item")]
public interface OFDAKGDMHMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	T FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000220")]
	int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public enum FMGMOFJMBLC : byte
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
public enum NKPPOELGPAG : uint
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
public static class JAHBGFIHPNM
{
	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x848B830", Offset = "0x848AC30", VA = "0x18848B830")]
	public static DNOIABBOEPJ CEAEHBINGMP(this LIIDMBJHHHO NGIAGNLBILI)
	{
		return default(DNOIABBOEPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x848BB00", Offset = "0x848AF00", VA = "0x18848BB00")]
	public static DNOIABBOEPJ LECJKAFMALI([In] this LIIDMBJHHHO NGIAGNLBILI)
	{
		return default(DNOIABBOEPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x8406580", Offset = "0x8405980", VA = "0x188406580")]
	public static DNOIABBOEPJ BLHECDDOICP(this LIIDMBJHHHO NGIAGNLBILI)
	{
		return default(DNOIABBOEPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x8406580", Offset = "0x8405980", VA = "0x188406580")]
	public static ViewId OEFLIIAJGIK(this LIIDMBJHHHO NGIAGNLBILI)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x848BB50", Offset = "0x848AF50", VA = "0x18848BB50")]
	public static FixedString64Bytes PPEEPOHGAGE(this JMAJLEBDBPE CLNGGGMIBPI)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x848B870", Offset = "0x848AC70", VA = "0x18848B870")]
	public static FixedString64Bytes JNDHKPKHJKP(this DNOIABBOEPJ CLNGGGMIBPI)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x848BD20", Offset = "0x848B120", VA = "0x18848BD20")]
	public static FixedString32Bytes PPEEPOHGAGE(this Entity MEOOAHKPJCE)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FBHCJAJBLIO : JEOBLPECIJA
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public enum HDEPLADCLPD
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
public interface GFJCHHGAMMA
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> JMICPMODECP;

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "2")]
	void BAPMOKDJNDJ(object FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "3")]
	void IKMEGOCJBIH(MBEDCBJABND NHDOFIDIKGL, ReadOnlySpan<byte> JPPAFNCCIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	void AGMBHDGNJKL(NKPPOELGPAG IIHAKBEOLJD, ReadOnlySpan<byte> JPPAFNCCIMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KCKBOGEOFFL
{
	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBEDCBJABND MOJIPPOGKCO(ReadOnlySpan<byte> JPPAFNCCIMK);
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BEIIGJGHNLL
{
	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBNFBGCHIMH(MBEDCBJABND PEENICAIFOP, ReadOnlySpan<byte> JPPAFNCCIMK);

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCHJGDOHFCN(ReadOnlySpan<MBEDCBJABND> MMJNHKPCMFI);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct NAGHENKPMGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public MBEDCBJABND NHDOFIDIKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public ReadOnlyMemory<byte> JPPAFNCCIMK;
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct MBEDCBJABND
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static MBEDCBJABND GBOMBIEKOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public JMAJLEBDBPE CIJDBPBBPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public int LFIFPEBEICE;

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public static JMAJLEBDBPE JLFOLNHGLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x848DF70", Offset = "0x848D370", VA = "0x18848DF70")]
		get
		{
			return default(JMAJLEBDBPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x54E1D50", Offset = "0x54E1150", VA = "0x1854E1D50")]
	public MBEDCBJABND(JMAJLEBDBPE CIJDBPBBPNJ, int LFIFPEBEICE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x848DEE0", Offset = "0x848D2E0", VA = "0x18848DEE0")]
	public static bool ILMCFLMCOJH([In] MBEDCBJABND KEHFCBFJCMA, [In] MBEDCBJABND KGECIONKOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x848DD70", Offset = "0x848D170", VA = "0x18848DD70", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x848DE80", Offset = "0x848D280", VA = "0x18848DE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x848DFC0", Offset = "0x848D3C0", VA = "0x18848DFC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x848DD60", Offset = "0x848D160", VA = "0x18848DD60")]
	public void BBBPACNHLNO([Out] JMAJLEBDBPE ICAMGPAGGAL, [Out] int LFIFPEBEICE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public static class ECDKPAAMCFG
{
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public struct AJGEFLJHLOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Guid OOOANFDGEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public string BHECMNLMABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Vector3 LBCFHLNAPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public Quaternion EMLGDFFEJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Vector3 MJHAIBCGLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public int AHDJCFAACAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NALOKHDCBNN FGEMBJJOPFK;

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x847E770", Offset = "0x847DB70", VA = "0x18847E770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public enum JPKJEAJCOGL
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
public static class GIEEANEAMLA
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x8484200", Offset = "0x8483600", VA = "0x188484200")]
	public static bool IILBHLIICIP(this JPKJEAJCOGL IIHAKBEOLJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x84841F0", Offset = "0x84835F0", VA = "0x1884841F0")]
	public static bool GGPIIGMFLJM(this JPKJEAJCOGL IIHAKBEOLJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x8484220", Offset = "0x8483620", VA = "0x188484220")]
	public static bool PHPJJDDEJAJ(this JPKJEAJCOGL IIHAKBEOLJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[Flags]
public enum JFCJFFPDJCG
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
public interface KGPKHFIDLJM
{
	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALMEBOPAJEC([In] Guid BEOBAPANJHO, [Out] Guid MBAOOPBKPLE);
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[Flags]
public enum AKOFIFKPCEM
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
public interface DAGKPJAGHBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000222")]
	PCLHDDLNJAM OEAFAICKPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString KODCJFPEPHC();
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public enum DFHKKNPAKAE
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct HDFIDNKMPHN : ISystemStateComponentData, IComponentData, IEquatable<HDFIDNKMPHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public float3 GHMCFDBPIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public float3 IBNJBOPJIEC;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x84850A0", Offset = "0x84844A0", VA = "0x1884850A0", Slot = "4")]
	public bool Equals(HDFIDNKMPHN LHDOHAKINKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PFIJCFDKACA
{
	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<NAIIODHHNBF> EABKPCLCFPH(NAIIODHHNBF JKJOEJKLENN);

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JAOBDLKEEBL(NAIIODHHNBF JGECEAPGNKP, [Out] NAIIODHHNBF PHKAEAJIMEC);
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NAOMJCBMJHA
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBCOCCJEJIL(long FKKIDEOCEFM);

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IODAHFHPEGA(NativeParallelHashSet<long> KBJLJBAANOF);

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OINPCCDBCIA(World BADONBAKCJC, NativeParallelHashMap<Guid, long> IEOJJHOFHLO);

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PBDIBGNGMFJ(DNOIABBOEPJ LGKFNBNJHLJ);

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LFIMLBKCMAK(DNOIABBOEPJ LGKFNBNJHLJ, [Out] Guid BGIDPHNONHF, [Out] long FKKIDEOCEFM);

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGOCCJKKFGF(DNOIABBOEPJ LGKFNBNJHLJ, Guid BGIDPHNONHF, long FKKIDEOCEFM);

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FNKPNPCOELH(Guid BGIDPHNONHF);

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HJLONFMLJPH(Guid BGIDPHNONHF, [Out] int FEKEODGHCBL, [Out] int NIIJIBFAPMH);

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HIFELPPNDBG(Guid BGIDPHNONHF, int FEKEODGHCBL, int NIIJIBFAPMH);

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PBHMEKEAHFB(Guid BGIDPHNONHF);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000105")]
public class FCNBKKGCIKA
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FCNBKKGCIKA()
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
