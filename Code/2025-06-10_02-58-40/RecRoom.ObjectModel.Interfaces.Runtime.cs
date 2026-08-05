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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E28B30", Offset = "0x7E27D30", VA = "0x187E28B30", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ABLLNEGKLEP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E17480", Offset = "0x7E16680", VA = "0x187E17480")]
	public static void FEEAEPBLKJG(this Rigidbody EPELOGPFGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7E17350", Offset = "0x7E16550", VA = "0x187E17350")]
	public static void FEEAEPBLKJG(this Rigidbody EPELOGPFGMN, Vector3 DIALNBPHAIH, Quaternion IHLDOPLBHHM, Vector3 DCBLCBDHPAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct JCMFEJFBHJF : IReadOnlyList<EBBGNAFIMFG>, IEnumerable<EBBGNAFIMFG>, IEnumerable, IReadOnlyCollection<EBBGNAFIMFG>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct DJAANNCJHAK : IEnumerator<EBBGNAFIMFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MIPBFCPKCOJ BHGHJPNDBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator CMBGOOFPBLB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public EBBGNAFIMFG FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7E1A4F0", Offset = "0x7E196F0", VA = "0x187E1A4F0", Slot = "4")]
			get
			{
				return default(EBBGNAFIMFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7E1A4A0", Offset = "0x7E196A0", VA = "0x187E1A4A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x51D4A70", Offset = "0x51D3C70", VA = "0x1851D4A70")]
		public DJAANNCJHAK(MIPBFCPKCOJ BHGHJPNDBMK, NativeArray<LocalId>.Enumerator CMBGOOFPBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A3E0", Offset = "0x7E195E0", VA = "0x187E1A3E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A420", Offset = "0x7E19620", VA = "0x187E1A420", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A460", Offset = "0x7E19660", VA = "0x187E1A460", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly JKLELGJCNHE BIFBBDMNGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> IOIHFCOPCJO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EBBGNAFIMFG HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E244F0", Offset = "0x7E236F0", VA = "0x187E244F0", Slot = "4")]
		get
		{
			return default(EBBGNAFIMFG);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E23D80", Offset = "0x7E22F80", VA = "0x187E23D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int PNBKPDBDHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MIPBFCPKCOJ ILKAAAENLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E24030", Offset = "0x7E23230", VA = "0x187E24030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PAKAGCJKALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E23A80", Offset = "0x7E22C80", VA = "0x187E23A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> JGBEMBFKFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2A93520", Offset = "0x2A92720", VA = "0x182A93520")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> EFGAILBJNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E23DE0", Offset = "0x7E22FE0", VA = "0x187E23DE0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E24440", Offset = "0x7E23640", VA = "0x187E24440")]
	public JCMFEJFBHJF(int POKPPHJAIGN, MIPBFCPKCOJ BHGHJPNDBMK, Allocator DPAKHKILCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E243C0", Offset = "0x7E235C0", VA = "0x187E243C0")]
	public JCMFEJFBHJF(JKLELGJCNHE BIFBBDMNGPL, NativeArray<LocalId> IOIHFCOPCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E243D0", Offset = "0x7E235D0", VA = "0x187E243D0")]
	public JCMFEJFBHJF(JKLELGJCNHE BIFBBDMNGPL, NativeArray<Entity> IOIHFCOPCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E24210", Offset = "0x7E23410", VA = "0x187E24210")]
	internal JCMFEJFBHJF(MIPBFCPKCOJ BHGHJPNDBMK, NativeArray<Entity> HBEMCIPCOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E24350", Offset = "0x7E23550", VA = "0x187E24350")]
	internal JCMFEJFBHJF(MIPBFCPKCOJ BHGHJPNDBMK, NativeArray<LocalId> IOIHFCOPCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E242A0", Offset = "0x7E234A0", VA = "0x187E242A0")]
	public JCMFEJFBHJF(MIPBFCPKCOJ BHGHJPNDBMK, int CLBDAFJFHFB, Allocator DPAKHKILCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E24160", Offset = "0x7E23360", VA = "0x187E24160")]
	public JCMFEJFBHJF(JCMFEJFBHJF MFOICJLPPLN, Allocator DPAKHKILCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E23AC0", Offset = "0x7E22CC0", VA = "0x187E23AC0")]
	public void GGNEAAKPFPJ(List<EBBGNAFIMFG> CFFEIIKPOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E23D30", Offset = "0x7E22F30", VA = "0x187E23D30")]
	public void IICGPJOFHBF(int CMDFFDAPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E239E0", Offset = "0x7E22BE0", VA = "0x187E239E0")]
	public JCMFEJFBHJF EDIKNCAPOAM(Allocator DPAKHKILCMF)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E23E40", Offset = "0x7E23040", VA = "0x187E23E40")]
	public Span<EBBGNAFIMFG> KOCDNNJPAGD()
	{
		return default(Span<EBBGNAFIMFG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E23F90", Offset = "0x7E23190", VA = "0x187E23F90")]
	public JCMFEJFBHJF PFAPOCMFIDL(int EIGANLKFLHL, int CLBDAFJFHFB)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E239A0", Offset = "0x7E22BA0", VA = "0x187E239A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E238E0", Offset = "0x7E22AE0", VA = "0x187E238E0")]
	public DJAANNCJHAK BFKODFEKGDL()
	{
		return default(DJAANNCJHAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E24080", Offset = "0x7E23280", VA = "0x187E24080", Slot = "6")]
	private IEnumerator<EBBGNAFIMFG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E240F0", Offset = "0x7E232F0", VA = "0x187E240F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MBEMLPMKGEO
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7C80", Offset = "0x3AE6E80", VA = "0x183AE7C80")]
	public static EFNLAMGBNCO<T> KEBELLHODON<T>(this JCMFEJFBHJF LMDCFNDMKMH) where T : Component
	{
		return default(EFNLAMGBNCO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct MGGMGKJEFNC : IList<EBBGNAFIMFG>, ICollection<EBBGNAFIMFG>, IEnumerable<EBBGNAFIMFG>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct AFOPMONKOLG : IEnumerator<EBBGNAFIMFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MIPBFCPKCOJ BHGHJPNDBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator CMBGOOFPBLB;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EBBGNAFIMFG FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7E17710", Offset = "0x7E16910", VA = "0x187E17710", Slot = "4")]
			get
			{
				return default(EBBGNAFIMFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7E176C0", Offset = "0x7E168C0", VA = "0x187E176C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x51D4A70", Offset = "0x51D3C70", VA = "0x1851D4A70")]
		public AFOPMONKOLG(MIPBFCPKCOJ BHGHJPNDBMK, NativeArray<LocalId>.Enumerator CMBGOOFPBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E17600", Offset = "0x7E16800", VA = "0x187E17600", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E17640", Offset = "0x7E16840", VA = "0x187E17640", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E17680", Offset = "0x7E16880", VA = "0x187E17680", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MIPBFCPKCOJ BHGHJPNDBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> IOIHFCOPCJO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EBBGNAFIMFG HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E29D10", Offset = "0x7E28F10", VA = "0x187E29D10", Slot = "4")]
		get
		{
			return default(EBBGNAFIMFG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E29E00", Offset = "0x7E29000", VA = "0x187E29E00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E297D0", Offset = "0x7E289D0", VA = "0x187E297D0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7E297D0", Offset = "0x7E289D0", VA = "0x187E297D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> JGBEMBFKFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2A93520", Offset = "0x2A92720", VA = "0x182A93520")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JNOIOHADNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E29C90", Offset = "0x7E28E90", VA = "0x187E29C90")]
	public MGGMGKJEFNC(MIPBFCPKCOJ BHGHJPNDBMK, Allocator DPAKHKILCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7E29C00", Offset = "0x7E28E00", VA = "0x187E29C00")]
	public MGGMGKJEFNC(MIPBFCPKCOJ BHGHJPNDBMK, int CLBDAFJFHFB, Allocator DPAKHKILCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E29810", Offset = "0x7E28A10", VA = "0x187E29810")]
	public JCMFEJFBHJF NICCFCMAPNO()
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E293B0", Offset = "0x7E285B0", VA = "0x187E293B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E293F0", Offset = "0x7E285F0", VA = "0x187E293F0", Slot = "13")]
	public bool Contains(EBBGNAFIMFG LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E29480", Offset = "0x7E28680", VA = "0x187E29480", Slot = "14")]
	public void CopyTo(EBBGNAFIMFG[] KBILCKNPAKO, int NEAIGFOMGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E292A0", Offset = "0x7E284A0", VA = "0x187E292A0", Slot = "11")]
	public void Add(EBBGNAFIMFG LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E29720", Offset = "0x7E28920", VA = "0x187E29720", Slot = "7")]
	public void Insert(int CMDFFDAPDIB, EBBGNAFIMFG LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E29970", Offset = "0x7E28B70", VA = "0x187E29970", Slot = "15")]
	public bool Remove(EBBGNAFIMFG LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E29690", Offset = "0x7E28890", VA = "0x187E29690", Slot = "6")]
	public int IndexOf(EBBGNAFIMFG LHNFJLFIPMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E29920", Offset = "0x7E28B20", VA = "0x187E29920", Slot = "8")]
	public void RemoveAt(int CMDFFDAPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E29650", Offset = "0x7E28850", VA = "0x187E29650", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E29320", Offset = "0x7E28520", VA = "0x187E29320")]
	public AFOPMONKOLG BFKODFEKGDL()
	{
		return default(AFOPMONKOLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E29A40", Offset = "0x7E28C40", VA = "0x187E29A40", Slot = "16")]
	private IEnumerator<EBBGNAFIMFG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E29B20", Offset = "0x7E28D20", VA = "0x187E29B20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IIMJJNKBLNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EBBGNAFIMFG EKOJPGEHMIG(EBBGNAFIMFG IOIHFCOPCJO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ADHKKLKAHDJ : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface HGAAHNNLPNO : GOEDMCEDDPO, IGOOJKBPJMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HHAEJFPLINH OCOFKOBFEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JKLELGJCNHE KFHDJFHINGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface IGOOJKBPJMB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LKJEHOPDGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface GEJDPAGOLCE
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLIIMNIPJMJ(bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLKFAGPLGGN();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface HGHHOHHCKAO
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DCHBAHHINEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ICIKPCJFJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DOFEAKKCBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OPMJAGPJBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NFHDOOMIEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KMOIIAGGODH(bool NPFLOGOKNBN);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CHCGCPOOACP(ByteString JHAEHEEHONK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LGOMNKDLJLN();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BHJLEAKLBHI();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ADPEJFOGKOP();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface EIMDFMFNNAG
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	EENCHNOCEIL OCOFKOBFEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FEIEPBNONLF OJOPANDOCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	GPGFGCPFLGA FNLDFJPOMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	HGAAHNNLPNO AKPBGDKPMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DNBBFJFDFKD PBIFJBBCGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	HGHHOHHCKAO ODIHACMKKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	NKLJLHFCPEK CNMPLMKDBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PNJGIMPDKGK JEPKJPHAFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	PGPOBAMFDJM OOCJDJHNIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JPIALIKNHCC IGGAGMHAOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	MELILGNLOEG JIGPCNMBODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	POCMMAPPNJI EBKBGBPANDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	MIPBFCPKCOJ ILKAAAENLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	OLMPGIEFJML KMEGOBEGKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	JKDAMCDCHNH KCKGIALIJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	KDFJNMOPGNM DKNMLAKDGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KLPOLOEEFJF AFMIEMEDFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DANOBJJICOF ECENPBBPHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	DBGJLBCGJDC JMIDOAAEMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BMPNPIAAGBO POJLNAHPOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	ONPKACLCBEN IMOBGKAGNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JBHNJIEJDJB KMGLACFOGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	GBJODFAGAMG CLEFECICJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	LBKMAPNBIDM APPMCMIBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OMAOJKPBNDN GINNEFKMLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DOMBNNPEFED LKFOOLPPAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FIJOAGNCNMH ALOLGIGJLJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MLACKGMOCIO CGELCHDENFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	DMFEOJCAOCE ABJFOLGIOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OMBGIHJLFOF FFGLPIMJBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MMPJOBLMANL FHIEMEELKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LANOECBBLFB OAOPEPGHMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EIILPJKCALH HINKEPGPDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PDPEIEABDNI LJGPBFMMICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NOCNHAAKIII EKECBPCEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(GHOAIJENGNC))]
public readonly struct EBBGNAFIMFG : IComparable<EBBGNAFIMFG>, IEquatable<EBBGNAFIMFG>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly EBBGNAFIMFG OHOFKAHGOBL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int CAANHBAHDDF = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int ONNEODCIKHB = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int IBEHJJELLMF = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int LDKHJPAGFFF = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId MNPNHJICMND;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public MIPBFCPKCOJ ILKAAAENLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BD70", Offset = "0x7E1AF70", VA = "0x187E1BD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public HGAAHNNLPNO AKPBGDKPMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B930", Offset = "0x7E1AB30", VA = "0x187E1B930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LocalId HMMACBBIIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BB30", Offset = "0x7E1AD30", VA = "0x187E1BB30")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal JKLELGJCNHE KFHDJFHINGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BCE0", Offset = "0x7E1AEE0", VA = "0x187E1BCE0")]
		get
		{
			return default(JKLELGJCNHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IBDFDDCHHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BB70", Offset = "0x7E1AD70", VA = "0x187E1BB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private bool OCJLJCJKKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BC90", Offset = "0x7E1AE90", VA = "0x187E1BC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1BF00", Offset = "0x7E1B100", VA = "0x187E1BF00")]
	public EBBGNAFIMFG(MIPBFCPKCOJ JHDFJIDHPOG, LocalId MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1BFC0", Offset = "0x7E1B1C0", VA = "0x187E1BFC0")]
	public EBBGNAFIMFG(JKLELGJCNHE BIFBBDMNGPL, LocalId MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
	public OGCPECJLBAM KBGOLNKGACJ()
	{
		return default(OGCPECJLBAM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1BD30", Offset = "0x7E1AF30", VA = "0x187E1BD30")]
	public static LocalId PDHAGBEBCNG(EBBGNAFIMFG KAEBCFFDMDA)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1BCF0", Offset = "0x7E1AEF0", VA = "0x187E1BCF0")]
	public static Entity PDHAGBEBCNG(EBBGNAFIMFG KAEBCFFDMDA)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B810", Offset = "0x7E1AA10", VA = "0x187E1B810")]
	public static bool EEDHALGLIEL(EBBGNAFIMFG BGPKBCGBDMP, EBBGNAFIMFG NIJBGCGEGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E17D20", Offset = "0x7E16F20", VA = "0x187E17D20")]
	public static bool JGFOFPDALHN(EBBGNAFIMFG BGPKBCGBDMP, EBBGNAFIMFG NIJBGCGEGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7E1BDD0", Offset = "0x7E1AFD0", VA = "0x187E1BDD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B990", Offset = "0x7E1AB90", VA = "0x187E1B990", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B720", Offset = "0x7E1A920", VA = "0x187E1B720", Slot = "4")]
	public int CompareTo(EBBGNAFIMFG CMOCFNBHPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "5")]
	public bool Equals(EBBGNAFIMFG CMOCFNBHPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MFNBICEMLBO
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7E291F0", Offset = "0x7E283F0", VA = "0x187E291F0")]
	public static DLILJGCOAIF NOAAPKNFAED(this EBBGNAFIMFG KFMNDOMPAMC)
	{
		return default(DLILJGCOAIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class GHOAIJENGNC
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct JKLELGJCNHE : IEquatable<JKLELGJCNHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte BIFBBDMNGPL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] ILJPGEOGGKI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static MIPBFCPKCOJ HAFLNAENDAK;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static HGAAHNNLPNO HFHFNPDNFPF;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static MIPBFCPKCOJ[] IDGJAHCKKGC;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static HGAAHNNLPNO[] MFKKHNNEDKN;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> PDLPJBFHIMG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public HGAAHNNLPNO AKPBGDKPMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E24770", Offset = "0x7E23970", VA = "0x187E24770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public MIPBFCPKCOJ OPHDDDDINHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7E24CF0", Offset = "0x7E23EF0", VA = "0x187E24CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E255C0", Offset = "0x7E247C0", VA = "0x187E255C0")]
	static JKLELGJCNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF3E0", Offset = "0x2ACE5E0", VA = "0x182ACF3E0")]
	internal JKLELGJCNHE(byte KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6CCFC60", Offset = "0x6CCEE60", VA = "0x186CCFC60", Slot = "4")]
	public bool Equals(JKLELGJCNHE CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7E24AF0", Offset = "0x7E23CF0", VA = "0x187E24AF0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xF5F910", Offset = "0xF5EB10", VA = "0x180F5F910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E25500", Offset = "0x7E24700", VA = "0x187E25500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7E25130", Offset = "0x7E24330", VA = "0x187E25130")]
	private static MIPBFCPKCOJ IDLMEOIJELC(byte BIFBBDMNGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7E25460", Offset = "0x7E24660", VA = "0x187E25460")]
	private static HGAAHNNLPNO NGLGNILBFNA(byte BIFBBDMNGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7E24B90", Offset = "0x7E23D90", VA = "0x187E24B90")]
	private static object FEOOMDNGPHN(byte BIFBBDMNGPL, object[] LMKJLPPFOFC, object FEOJADDJKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7E24760", Offset = "0x7E23960", VA = "0x187E24760")]
	private static int CLOFMPPEPJG(byte BIFBBDMNGPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7E25450", Offset = "0x7E24650", VA = "0x187E25450")]
	private static int NCPKFPABHIA(byte BIFBBDMNGPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7E253D0", Offset = "0x7E245D0", VA = "0x187E253D0")]
	private static (int, int) KIGKEEJMHOH(byte BIFBBDMNGPL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7E251D0", Offset = "0x7E243D0", VA = "0x187E251D0")]
	private static byte JKCEEPPJMMM(int EPCDIDIGEAG, int CMDFFDAPDIB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7E24850", Offset = "0x7E23A50", VA = "0x187E24850")]
	internal static JKLELGJCNHE ELDCOJNOKAJ(HGAAHNNLPNO LKPOMCFEMEC, MIPBFCPKCOJ LBLOMJNHNGB)
	{
		return default(JKLELGJCNHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7E251E0", Offset = "0x7E243E0", VA = "0x187E251E0")]
	internal static void JNBGJFEBNND(JKLELGJCNHE BIFBBDMNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7E24DD0", Offset = "0x7E23FD0", VA = "0x187E24DD0")]
	private static void FKOFFJHHOPL(int POKPPHJAIGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum ELAOOIIGKIP
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
public interface CCPNOMPGNKK
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool BHHIEIOJPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool ODCBMDJEFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool IEJKAIGKMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool MDKKCFEOPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool OKAPODHNOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OIAKKKDNEBP
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKKOHNLLAPH(LLCKIJCGBOI MBLPEFIMNGA, int CMDFFDAPDIB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GPPHJBFEJME(LLCKIJCGBOI PNOHMOBIKJN, int CMDFFDAPDIB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MIFLEPLOHDE : LLCKIJCGBOI, CCPNOMPGNKK
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int AKEPIBPCAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPHPPCJJNOI(BHJEAEGAHCL GEPHAPCMEAA, int CMDFFDAPDIB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LLCKIJCGBOI : CCPNOMPGNKK
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum ONMJCBNCKOO
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

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool PCAJBPMDNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FLGHHNLEHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool JLMFCNLLCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BHJEAEGAHCL
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool PPFCILIGFND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	AJCKMHEMCBO AFKFLEFOHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	MDFMKPLCCGE MJKEBOHBDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float3 MILMNOPOIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	quaternion DDKKAJIGLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float3 NONFLPGEECD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	FCIAGNOBJCE MLKDHMPMIKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	OFLMEILHLBB IDDHCGFKLED
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float ICLFNBIPKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float3 JGNNJPINBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float KHMLNJCKOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	FEDMKIFLINL OEEKOEDDKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface EJLPNHCJNMN
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 DPCDBEOOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float3 GEDMGNBEJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion OADKICMINED(float3 CCIDJKMOLDG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface MDFMKPLCCGE
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool ADDNJIJFNEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool IAFBBNJPGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool FGNNFPEONOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float FHGBEKFLKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int DHGLNINDJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int NNLEOODBEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INABDMKBGNI(EJLPNHCJNMN GEPHAPCMEAA, int CMDFFDAPDIB);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface ELJIECAFGLH
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Guid JAPDOMLPHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HBLKGIPDMAI(Guid KBFABLKMDPO, Guid KHABIKOGJPF, Guid MDCKFBJDEJF);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task OEJHAMJBDOM(Guid KBFABLKMDPO, Guid[] GMLKNAPAIIB, Guid MDCKFBJDEJF);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid DHNJEPMAAMC(Guid PHMPPPDJDDA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task DILOJGDIEGG(EBBGNAFIMFG GCGKGBDMPDP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OADBMJGBIKC(Guid PHMPPPDJDDA);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PNOPLMILKHO(FENOBMDIAGD HFKCALDCJGI, Guid JPCBLPOKJDJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MKGGCFFEILF(Guid PHMPPPDJDDA, bool NPFLOGOKNBN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LIEIPCIEHKA(Guid PHMPPPDJDDA, DLILJGCOAIF LKLCMOKFFEL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LGCPKCOBAPF(DLILJGCOAIF LKLCMOKFFEL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ICKIPDPMPIP(EBBGNAFIMFG MNPNHJICMND);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface DICMDELNMBC
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface HDCPEOIGACC
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "0")]
	void KLBEPAPPPPN(bool PGEJJMOHEOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface FEIEPBNONLF
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	HDCPEOIGACC LNOLHBDGECB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	KENBADPNBAN AGJAHAKIIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	DGPJNPNLMHP AMPAHCOHIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	IEAALAHDCLE LEIIJIKDIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	DEAGIDCNAJM PIFBLDGPHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	NEPJNNHJFMK CIEBNNGMJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	HFHJPIFCLIO DGNKCCIKMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	GJJCIBENJEA FFJGJHAHDNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface KENBADPNBAN
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	string HJEHINNFAPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface MDIJLPBCLMC
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMPFDNGHJCI(Action CJLPDLONOLK, bool KMALGBNFCMI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OKAANNBMMEE(string GBOCGPJOEEK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AKGHOIPMPDH(string GBOCGPJOEEK, int FEOJADDJKIL);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MAADHLEOMBM([Out] bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JECIJKLHJGG([Out] bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FDKMKFCNGIN([Out] int KJIOHKMJAPE);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface DGPJNPNLMHP
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "0")]
	void NNHBONHPHLN(bool NPFLOGOKNBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface IEAALAHDCLE
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid AHIANLJKIKL;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid JINJCMOGDMC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid NCNHGHOLPNG;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid FBIBCJBNNJN;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool ECOKACBNPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool BPGNPFBGAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool NPIHLJBMCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E22500", Offset = "0x7E21700", VA = "0x187E22500", Slot = "3")]
	string[] MGDEOHDOJOD(KPOKEHFKHFL EKAOAIAIJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPLHIEGNKGA();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E224D0", Offset = "0x7E216D0", VA = "0x187E224D0", Slot = "5")]
	Guid KJFLJPHKOCH(Guid IPAGDNFMPFC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FKPHAIEDKMP(KPOKEHFKHFL EKAOAIAIJGD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AEIAAGJPEFO(KPOKEHFKHFL EKAOAIAIJGD, NativeArray<LIGIFGLAAJB> CEAHBBOLKLL, NativeList<UniformTRS> MIOPKOMAHPH);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int NIMLNICODBD(Guid DJOIAEMCFDK);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NFBOFEKLFJC(string FNBPEJBPIPG, [Out] Guid DJOIAEMCFDK);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string DAHOIIDNDFO(Guid DJOIAEMCFDK);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NEINLCLGOGB(RRObjectPrefabData NMILJLDFLOC, [Out] LocalId GONFONDIOED);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EFNLAMGBNCO<byte[]> MBCGNPLFACB(NativeArray<LIGIFGLAAJB> JOJPPGNBMBG);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AKEBNELLLHF(byte[] IDAJHNFKBKG);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GameObject CKHBCJEOJMI(string FNBPEJBPIPG);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EJOMPKBKPPB(Transform JGOMLHGOKKB, RRObjectPrefabData AAMHOIELBBH, FDMFIFPHKJP BKDMJHGCDEA);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool PKEDMLJOGPG(KPOKEHFKHFL EKAOAIAIJGD, NativeParallelHashMap<Guid, LocalId> FEJKFCANIPA, [Out] Exception JLAMGOGLIAG);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EJMKOOBLGBO(KPOKEHFKHFL EKAOAIAIJGD, NativeParallelHashMap<Guid, LocalId> FEJKFCANIPA, [Out] NativeArray<LocalId> HBEMCIPCOAI, [Out] NativeArray<LocalId> BODMFCLHIMI, [Out] NativeArray<AuthoredLocalPoseData> NFGKBDNAMCB, Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "18")]
	void MGBPEPLMOIP(KPOKEHFKHFL JCFOMPGDMKN, NativeArray<int> BOCKDNCNDFL, NKNHMBEFOJB<GameObject> BDKACHJEELH, EFNLAMGBNCO<GameObject> IJKEOOEFPNN, ELAOOIIGKIP JCMKMMFFJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ANNKHCPBJEG();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "20")]
	void HFEIPMJMDLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "21")]
	void MLHAPENNONF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "22")]
	bool EADBOMMFGBI(KPOKEHFKHFL EKAOAIAIJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "23")]
	OIAKKKDNEBP NDDKCABEPJP(KPOKEHFKHFL EKAOAIAIJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "24")]
	void ENPHPEKJOLF(Guid CLIJDFLEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "25")]
	bool KGMJKHICBME(Guid CLIJDFLEOMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7E22590", Offset = "0x7E21790", VA = "0x187E22590")]
	static IEAALAHDCLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface HOKODHABEMK
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	long ONECGFHDAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	long MALMFBGFJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface DEAGIDCNAJM
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool LNOIDHHPFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool GHLCEIMPKHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int EHJMMMPNJJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	int IKHGDNGBACI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	int OAENOIOJFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool ADBPHBEKGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int CPIHOJIBIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "6")]
	void GODKEJABHAJ(CGHCLGPOONK NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
	void OIAHJGGPLPB(bool PNAFNFGMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "8")]
	bool FBFNCFDDHCA(NPGIOFFINPJ LPGODJOFLMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "9")]
	void IMEHBFDLFEG(object EKFBEBELGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "10")]
	void GNNBDKCIPPA(object EKFBEBELGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JPKKEGKAHIG(Action<object> OLILEGOKDKH);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PMIMJAGCNGH(Action<object> OLILEGOKDKH);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "13")]
	void CAEPNFGNFNH(NativeArray<ViewId> GCKHJHLADCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "14")]
	void JLMKOPNHDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "15")]
	void AHHENBDNAIE(GGJDLMJHNMI GDHKDBJPDLG, ReadOnlySpan<byte> CAIGHLKIDBF, NPGIOFFINPJ JHMOIHCLCDG, bool KENCAGAIOIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "16")]
	void AHHENBDNAIE(GGJDLMJHNMI GDHKDBJPDLG, ReadOnlySpan<byte> EGOEPDHNCPF, bool KENCAGAIOIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "17")]
	void AHHENBDNAIE(GGJDLMJHNMI GDHKDBJPDLG, ReadOnlySpan<byte> EGOEPDHNCPF, ReadOnlySpan<byte> GLFKCGFBKIG, bool KENCAGAIOIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "18")]
	void JPOMJMHFFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "19")]
	void NMIMFFLNJLO(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "20")]
	void ELLOLBMFGAC(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "21")]
	void OGECKNICFMP(Dictionary<object, object> PLIBAFNNDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "22")]
	void OINLCGCIJLO(NativeList<DLILJGCOAIF> IIHBFDHIJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "24")]
	void MHNLENGHAPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "25")]
	void HKNNMBJHLHG(List<object> FANIAMKJHGP, int KOKMPCAPCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "26")]
	void FDBMOAKKLOH(int BLKBKPJFHAB, object ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "27")]
	void PLBLADIGEKO(NPGIOFFINPJ LPGODJOFLMG, Dictionary<object, object> GFKOIMIAEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "28")]
	void IOGJEEFFPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "29")]
	void AKFLCIIMGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class OBACPIGIBLN
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A790", Offset = "0x7E29990", VA = "0x187E2A790")]
	public static BNALIPLALBE OACBGGHJILL(this DEAGIDCNAJM KOHBDHDNGIJ, object CCLFNPCGNED)
	{
		return default(BNALIPLALBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct BNALIPLALBE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private DEAGIDCNAJM KOHBDHDNGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object CCLFNPCGNED;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7E18D00", Offset = "0x7E17F00", VA = "0x187E18D00")]
	public BNALIPLALBE(DEAGIDCNAJM KOHBDHDNGIJ, object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7E18CB0", Offset = "0x7E17EB0", VA = "0x187E18CB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ANIIEAAHGMD
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate void MCAFGJLKKHC(ViewId LIOACKIDDBK, DPGDOGEFGCI AHMENDMONGH, int GCPKMNCMKPP);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "0")]
	void IENMIHHEGBA(MCAFGJLKKHC MOPMPCHOJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "1")]
	void ADPBHLDNDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "2")]
	void JGACCKNGGNC(NDKAIJEIFHC HEAHMHOMOPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface MGHDCMPMFCP
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface NEPJNNHJFMK
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct BEKMKLGEODE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private NEPJNNHJFMK BOGOPOOCJPC;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7E18C20", Offset = "0x7E17E20", VA = "0x187E18C20")]
		public BEKMKLGEODE(NEPJNNHJFMK BOGOPOOCJPC, string PHCDDDIIGAJ, string PJFGEEPNGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7E18BC0", Offset = "0x7E17DC0", VA = "0x187E18BC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct ECBDICFGOBC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private NEPJNNHJFMK BOGOPOOCJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task MKOPIIJMBLM;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C660", Offset = "0x7E1B860", VA = "0x187E1C660", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "0")]
	void AFEBDLMCDMC(string NPEJLHCJPAI, float PFMGKMLLMHD = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "1")]
	void LLHNEGKBBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPDPMHABIMF(bool DMHGIJPNHHE, string PHCDDDIIGAJ, string PJFGEEPNGFB);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "3")]
	void KEGLLNJFKJN(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class DEGLHOGGHNN
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A210", Offset = "0x7E19410", VA = "0x187E1A210")]
	public static NEPJNNHJFMK.BEKMKLGEODE EEFFBPCEFHG(this NEPJNNHJFMK KOHBDHDNGIJ, string PHCDDDIIGAJ, string PJFGEEPNGFB)
	{
		return default(NEPJNNHJFMK.BEKMKLGEODE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ServiceLifetime(Lifetime.Application)]
public interface IFOLIGICCDE
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CCFMCGCJLPG(GameObject LBBGHAOMHLO);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFKAGAJMKKO(GameObject LBBGHAOMHLO);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LLNMGCDCIBD(int LPGODJOFLMG);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object JHCNLEFNKLF(EBBGNAFIMFG MNPNHJICMND, GameObject LBBGHAOMHLO, Action<EBBGNAFIMFG, int> MHPGHAHOBNK);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDBJNGFHLCM(GameObject LBBGHAOMHLO, object FGJMJNODNIC);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFMPFGKDOND
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IDCNDFEAJGG(CEAHLANEAPC HAPPMEIKPMA, JFGPGKPOGDI GPJEKBKINIF);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface JDILGIINKHB
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELKKKBEIKKA(object KFMNDOMPAMC, NativeList<byte> CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object BHIBMPPAILM(NativeArray<byte> CAIGHLKIDBF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface ABNDFEHPNNH
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool IMDMODMMLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate CJLACDBIMCF(AMDJOLLNHGD ALNDCEAMIED, Action<AMDJOLLNHGD> MHPGHAHOBNK);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGDOFJKMGME(AMDJOLLNHGD ALNDCEAMIED, Delegate MHPGHAHOBNK);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate IBIENDMNIIM(AMDJOLLNHGD ALNDCEAMIED, Action<AMDJOLLNHGD> LKBCLJNDINA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CHEOHNPOAJM(AMDJOLLNHGD ALNDCEAMIED, Delegate MHPGHAHOBNK);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PABGIEGOABI(AMDJOLLNHGD ALNDCEAMIED);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AMDJOLLNHGD PDPMBJHNJPL(GameObject LBBGHAOMHLO);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface ALIPOAPJDNI
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int IKEGBAJIFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int IHELFJLPKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool LNOIDHHPFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool IBMALCELGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool IOHDJBBHNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EBBGNAFIMFG ACLFJPLBKBI(int LPGODJOFLMG);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LMOHNEBHJFN(GameObject IEJPIFIGHBO, JobHandle OBFBOHPGOOP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface AIDMPGNGJBN
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IDCNDFEAJGG(int MKCPMOJFGDP, JFGPGKPOGDI FAFKOEJABAO);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface HFHJPIFCLIO
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool DCHBAHHINEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface HDCONKFMOMB
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	NBLECBFEIMG LNBDOGNFPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	BJOOKMNONND HBPKJPOMDDL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool MAEGONJCKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLFLAGEFANI(Transform JGOMLHGOKKB);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGMNDHEEPAO(Transform JGOMLHGOKKB, MFEDJIKCLFM LIMIFAMLBAK);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAHPCFDBDJH(Transform JGOMLHGOKKB, CHMGPECIKJJ LANBPNACLHP);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface GJJCIBENJEA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MJEJHIKLBBL;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface CCCLPIBNNCO
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIICPHEEGGG();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface HOCLBHAJENO
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFIFJMBCLKG(GameObject LBBGHAOMHLO, EGKABEIDDMN HDBGEMBBFBC, NFJOAPCLPMN EDGLAHPMNAL);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLBGPCCDDGJ(EBBGNAFIMFG MNPNHJICMND, bool HHKDFCHLLAB, float3 KKCCBJAIGLH, quaternion CLFEHDBHLJG);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NADNPEDBELM(JCMFEJFBHJF MGKKPIOONPM);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLFEFKIAJIL(OGCPECJLBAM IMMAKBDNFNI, OGCPECJLBAM LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNDELAICIIF(OGCPECJLBAM IMMAKBDNFNI, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NIKFKIIBKMN(JCMFEJFBHJF JNFHOBPPFBA);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IELLGPCIFNH(KPOKEHFKHFL JFJLCELEMGO, ReadOnlySpan<Guid> FOBPHEHFIKC, ReadOnlySpan<int> AEDJBMCKLJE, EFNLAMGBNCO<GameObject> PGAKPHKPMDE);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MMMNLOMOCBD(NLCJIIIDMMO MHIOLFBBMPO);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct DMEGJOHMEIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> CAIGHLKIDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle BIFBBDMNGPL;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B210", Offset = "0x7E1A410", VA = "0x187E1B210")]
	public DMEGJOHMEIO(ReadOnlyMemory<byte> JHMBOBHDCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B1D0", Offset = "0x7E1A3D0", VA = "0x187E1B1D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum PPDNPEHAACN
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
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct KPOKEHFKHFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString PKEGADGLJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object MHBGKLDDLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object NOOEDMLEAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> GJOLEMHHCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool MJLDGEJGKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public KMAKGLICNNJ.OHHBAFDBFJD? HBKNPJFMHLB;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7E27990", Offset = "0x7E26B90", VA = "0x187E27990")]
	public KPOKEHFKHFL(ByteString PKEGADGLJLM, [Optional] object MHBGKLDDLLF, [Optional] object NOOEDMLEAFA, [Optional] IEnumerable<string> GJOLEMHHCLC, bool MJLDGEJGKMC = true, [Optional] KMAKGLICNNJ.OHHBAFDBFJD? HBKNPJFMHLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct MGNBPNNFFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object HCODAOPDMHE;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct LIGIFGLAAJB
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Flags]
	public enum FBBMGHNILLE
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
	public RRObjectPrefabData AAIGIAMCPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid BGFODCFIGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid KNGGHOGOEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid FCNGEOCJGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid EIILPIPOFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public FBBMGHNILLE FFMDBMBLMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 BPCBBJEABPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int MKFCFEFNJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public NHEBFPMCJFK JLAGJIFNDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int NGINNHILEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int LPPPOEMCKCF;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid CFPMPHEGMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x51CF400", Offset = "0x51CE600", VA = "0x1851CF400")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool GNGLKLJEEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7E28380", Offset = "0x7E27580", VA = "0x187E28380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool KNIDGBOBNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7E28360", Offset = "0x7E27560", VA = "0x187E28360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool OABIMHOKBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7E28370", Offset = "0x7E27570", VA = "0x187E28370")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct LNFAFMOCHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly EEAHKNLGLMF EIGANLKFLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly EEAHKNLGLMF GCHDNICOBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly uint IFCOLFMDMPC;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7E28770", Offset = "0x7E27970", VA = "0x187E28770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct EHPLCHJDNJK
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal readonly LNFAFMOCHFC CJLPDLONOLK;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C9E0", Offset = "0x7E1BBE0", VA = "0x187E1C9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct NLOKCIMPCNP
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal readonly LNFAFMOCHFC CJLPDLONOLK;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C9E0", Offset = "0x7E1BBE0", VA = "0x187E1C9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct FKDIIBIIOOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly uint IFCOLFMDMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly bool NNNDLBJMEFE;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DA00", Offset = "0x7E1CC00", VA = "0x187E1DA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct EEAHKNLGLMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal int GJBFKFHLHKP;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C6B0", Offset = "0x7E1B8B0", VA = "0x187E1C6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[ServiceLifetime(Lifetime.Application)]
public interface IMIIAFAEMGG
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	KDGNCBGOLKH PCEDNKEFGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface FENOBMDIAGD
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface CKKIJJAJCAL
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class DGMGBFEOBBH
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x385C990", Offset = "0x385BB90", VA = "0x18385C990")]
	public static OGCPECJLBAM KBGOLNKGACJ<T>(this T MNPNHJICMND) where T : FENOBMDIAGD
	{
		return default(OGCPECJLBAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A360", Offset = "0x7E19560", VA = "0x187E1A360")]
	public static MonoBehaviour MJLPOKEFHAN(this FENOBMDIAGD MNPNHJICMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A2A0", Offset = "0x7E194A0", VA = "0x187E1A2A0")]
	public static GameObject DEOJDBDDHBG(this FENOBMDIAGD MNPNHJICMND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface GHNKHAMILGN : FENOBMDIAGD
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(EBBGNAFIMFG PMOPIAOAEIC);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface KANAPMPPMCB : FENOBMDIAGD
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LCPKIBCGPAC
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate void KNAJCDOHBDH(GDOHBJIIFEE GOMMDPPAJHC);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KNAJCDOHBDH PBBFENKMCPJ;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface KJMIHFAKPGF
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface AMPNAGGHBCI
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface AOCFFLDGBKH
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(EBBGNAFIMFG MDHPDLNBODB);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool GNMCKMLMLIF);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAGBCNFGOOD(EBBGNAFIMFG DBENCIIAGPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface JBEFCKILMBD
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(NIJLAPDBAHE LECNMHGCDPE);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface NIJLAPDBAHE
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	GameObject LBBGHAOMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Transform JGOMLHGOKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	PHNCFOGEOOF HAKDCNGCIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool OBCEPIDFABP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BICPJKPLJDD(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JJJNBIJGPDG GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class LGNOIIDCBJA
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7E27AD0", Offset = "0x7E26CD0", VA = "0x187E27AD0")]
	public static void ODEHFABACFH(this NIJLAPDBAHE MCFDCNGFCOI, FDMFIFPHKJP BKDMJHGCDEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface PHNCFOGEOOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Rigidbody MKLKACPEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	NIJLAPDBAHE LKKIJBANEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GameObject DEOJDBDDHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Transform DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	PHNCFOGEOOF MBPBJNDLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	PHNCFOGEOOF LHGFIGHCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	int NPDGKKLDGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool EEFKKNIEIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool PABGIEGOABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool FNNFICHJMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	AMBDNINENEN LMPICKEHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	ICKNPKALBAM ONDPGDGBCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	float MAJPAAENDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 BIFDABBKNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Vector3 FLINLHJIBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Vector3 LDKHAFPEALE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	Vector3 EJNNDMKJHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool ONJCPCNOAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool EBBNLNKCIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool FOGFOLBEPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	bool LICAOAJPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 OFPEANCCINF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 PGCDCJNGEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 PJPAOHGANHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 HEJFILFCLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	float MKFGMFLBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	float PHAKCFCOGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Vector3 BALPJDKAFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Quaternion JCNFCLBJBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	float MPIGHGHEPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	float ONCIEDPNPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool OIDDBDAGPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	CMFBMPLFPMI IIKKDFEMLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool JNAFLDCOEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Transform GLBJHHBHCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Vector3 GABCDCKCPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float DMLBOIHBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float NELECBAJGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Quaternion ENFOLGOEPKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Vector3 DPCDBEOOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Quaternion BDNOGOADCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	RigidbodyConstraints FIIBEJBGGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool BEGLONAEOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode FLLNAGFOKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	bool CIEBCPPNCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LGEMEOCGCEJ KONBLHNACOM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LGEMEOCGCEJ GKGJNCINCAH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LGEMEOCGCEJ DPJEAPGBMHC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LGEMEOCGCEJ NNBCBJDJPCE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event LGEMEOCGCEJ BNOICKDILLH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event LGEMEOCGCEJ DHHEGKEOJJP;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event LGEMEOCGCEJ INCNFIELLHI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EEPFMKEJJPJ NAFACMHLIAH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<DLGGNNMFNFI, DLGGNNMFNFI> CBKINBMILBF;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	PHNCFOGEOOF HAGMMKGFPCK(int CMDFFDAPDIB);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void AKLNNGGKMIH((Quaternion rot, Vector3 moments) PLBDLBHPJFE);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void DDADFJBFCMK();

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void IEHFFCCKIOI();

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void GCBJAJLNEAD();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void BJDNDFNPIDA();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void LMBAJAMHHAB();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void KMHANLPIIHA(PHNCFOGEOOF KJIOHKMJAPE, bool PEMCPPNLJOK = false);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void NIFOGPHDDLL(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void IMNMMHIGOGN(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 NIJFNJGENME(Vector3 IFPOFGCJIOC);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 KJFKNNAOPPF(Vector3 HEBMKEEGADP);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void NLGMCMODFPP();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void LDFHNJAJBEG();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void ELOFIACINEH();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void FCAMJGNDKLE(Vector3 OLNMJECJIHN, Vector3 KONENOOPMNL);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void AHALKHHCKGK(Vector3 IOEEHPMHLON, Vector3 MDOMAAAPHIC);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void DKICKCIFEFD(Vector3 FDMJBKNIFKE);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void FEGKFKJFNOI(FOFJEBJADLK CKGKMBNIHEB, Vector3 FLKIJPNGFFJ, float HGBMIGEGDNO, float CJLCLIAJNED = 8f, float MLLIAHIMCBD = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void OCDBEAPHLLH(IKMHDDEODBJ PLGEODGNDIP, Vector3 EGAKJMHBNCA, float PNDDEFAPACE = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void EFMBABIFDMP(IKMHDDEODBJ PLGEODGNDIP, Vector3 NDOBKEDDJAJ, float FGPLLNDELCJ = 7f, float ALNDLCNCPII = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 ADDCGGECPML(Vector3 KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 NECICHEEPNF(Vector3 KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void KPIKCEGFCFP();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void BIIEGOMNBEO(PHNCFOGEOOF PIKCGJKMBFP, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void CJGDCAAPMNN(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void NLJPLAPNPNH();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void GEMMKEPNPNH();

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void DLMHNBAPCLO();

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool PEKINICHOKM();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void BDCLNOEFNCL();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void BOJJPDINDLK(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void FHPLJAPEBNK(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void NIELPKBDIGM(object CCLFNPCGNED, bool JEHOOBEDLAD);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void LJADLBMGHJF(Vector3 JEFKJIMPADK, Quaternion JLMCFEOBFHG);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void DKBNHJKJAAD(Vector3 ALIFNAHGJDF, Quaternion DCBHDPNLHFC);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool LLJJMFGBMNL(float CHCCCCJIGOE);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void GGPJBGPKFKG(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void DBHHLGKHBEE(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void JNGNFEOJBBF(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void JADKGBEPFDN(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void PCCKIOHFPJB(Vector3 IKLDNLEDLAC, ForceMode BIMCLGPPPMH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void OHPNIOLBLCN(Vector3 IKLDNLEDLAC, Vector3 FICCENLPJEL, ForceMode BIMCLGPPPMH);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void GLHBKCIMMGL(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void GBCDHOGAELK(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool PDKMELOHKJD(Vector3 JBACNGDELHL, [Out] RaycastHit LAPIKELMKEJ, float ADBCFFBIBMG);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void PJLJKNEDMJP();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface ICKNPKALBAM
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAPFPGJKANK(Vector3 DIMODDHFLMG);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CILEMAKAHGO(Vector3 MKIIBLHCBDM);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOLNLLKCDEE(Vector3 DIMODDHFLMG);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCGJGDOFLIA(Vector3 MKIIBLHCBDM);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface AMBDNINENEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FEKDDENKDJG();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 LHNKIIGFDFF();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HAFDAELGLDK(float MBEIIICALJN, float NPFICCAIELL);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate void LGEMEOCGCEJ(NIJLAPDBAHE CKFMOEOPCGD);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum FBKMMPIGEIC
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
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum FOFJEBJADLK
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
[Cpp2IlInjected.Token(Token = "0x200005B")]
public delegate void EEPFMKEJJPJ(NIJLAPDBAHE CKFMOEOPCGD, bool PEMCPPNLJOK = false);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum IKMHDDEODBJ
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct JJJNBIJGPDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Rigidbody MFFGACBHHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public object FKBPAPGLMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3 AFEMOKLBAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 BGJHDLDOPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public JOHOKOFPFMP OJDGNKGODEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool ADBGOJEMOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool EACPODPLJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool KKOIOEBHGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool PALELBGHFMG;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct OGCPECJLBAM : IEquatable<OGCPECJLBAM>
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly OGCPECJLBAM KIJCOFLKIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GameObject LBBGHAOMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B320", Offset = "0x7E2A520", VA = "0x187E2B320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public DLILJGCOAIF NEJDDDGOOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B140", Offset = "0x7E2A340", VA = "0x187E2B140")]
		get
		{
			return default(DLILJGCOAIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IHPINLDMLGD KDHPMMFOLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B970", Offset = "0x7E2AB70", VA = "0x187E2B970")]
		get
		{
			return default(IHPINLDMLGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public RRObjectPrefabData HKGKMEHNDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B010", Offset = "0x7E2A210", VA = "0x187E2B010")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool DLHGGINIPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B690", Offset = "0x7E2A890", VA = "0x187E2B690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool FILNMOIMMHI
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B730", Offset = "0x7E2A930", VA = "0x187E2B730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool PPFCILIGFND
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B2B0", Offset = "0x7E2A4B0", VA = "0x187E2B2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool LBOPMMHNMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BA50", Offset = "0x7E2AC50", VA = "0x187E2BA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool NCBOKKECFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B540", Offset = "0x7E2A740", VA = "0x187E2B540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool EGHAEHMJDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B510", Offset = "0x7E2A710", VA = "0x187E2B510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool BBGFJAOFAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BA10", Offset = "0x7E2AC10", VA = "0x187E2BA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool IHGFOOCHBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7E2AE00", Offset = "0x7E2A000", VA = "0x187E2AE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool GIKPBBJMPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B830", Offset = "0x7E2AA30", VA = "0x187E2B830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool BCBENCLKLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B650", Offset = "0x7E2A850", VA = "0x187E2B650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool AECLPLAIKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BA70", Offset = "0x7E2AC70", VA = "0x187E2BA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool KDIHMACPCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BAB0", Offset = "0x7E2ACB0", VA = "0x187E2BAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public PKICMIFFLJJ PKGOGMJAIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(PKICMIFFLJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public CLKGPKEJGOG HJIINLKOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(CLKGPKEJGOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public OIALCOIBKLP KMEGOBEGKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OIALCOIBKLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public BNMNMMFAFJD JNAOOOHFOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(BNMNMMFAFJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public AKJKFLBLANG BBKBDIKDPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(AKJKFLBLANG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public DLMMHNDIIPN MMBHHDBCEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(DLMMHNDIIPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public BOKDBOEECON JDNGCPEMGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(BOKDBOEECON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public HKPLNKPANAL OONDPDHPDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(HKPLNKPANAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public NEOKMIIFIMG MGAHKEBHIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(NEOKMIIFIMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public HHNHGILHKIP KCKGIALIJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(HHNHGILHKIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public FBNEFAOLDGD GCGCBJOFADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(FBNEFAOLDGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public LJCLFNAGNIL MDPLKBAKGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(LJCLFNAGNIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public IHMOPLNGHHO DLDNCEGLNBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(IHMOPLNGHHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public LHOBGJOKKKN JDPKHEIGOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(LHOBGJOKKKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool GCIBMHLJOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B560", Offset = "0x7E2A760", VA = "0x187E2B560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool EMDGDANHLEK
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B1E0", Offset = "0x7E2A3E0", VA = "0x187E2B1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool LMNBKKEFILB
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B750", Offset = "0x7E2A950", VA = "0x187E2B750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool IBDFDDCHHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B500", Offset = "0x7E2A700", VA = "0x187E2B500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool IIIHCFLJJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7E2AE80", Offset = "0x7E2A080", VA = "0x187E2AE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool EBFOBFNDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7E2AE40", Offset = "0x7E2A040", VA = "0x187E2AE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool CHANPNKKCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7E2ADC0", Offset = "0x7E29FC0", VA = "0x187E2ADC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FOKDNEJDOHA DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(FOKDNEJDOHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IMBIBOMDBCE IGGAGMHAOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(IMBIBOMDBCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private MIPBFCPKCOJ ILKAAAENLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BD70", Offset = "0x7E1AF70", VA = "0x187E1BD70")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static OGCPECJLBAM PDHAGBEBCNG(EBBGNAFIMFG PMOPIAOAEIC)
	{
		return default(OGCPECJLBAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B6B0", Offset = "0x7E2A8B0", VA = "0x187E2B6B0")]
	public DBPCCINGKLD JPAGEHBOPIL()
	{
		return default(DBPCCINGKLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AF60", Offset = "0x7E2A160", VA = "0x187E2AF60")]
	public AGCGOJCMGCB BOICOLDFNKB()
	{
		return default(AGCGOJCMGCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B2D0", Offset = "0x7E2A4D0", VA = "0x187E2B2D0")]
	public KNHJEANNDGG FKEHAJJMONL()
	{
		return default(KNHJEANNDGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AF90", Offset = "0x7E2A190", VA = "0x187E2AF90")]
	public CKPFMAPPLCG CDAHABGJCKH()
	{
		return default(CKPFMAPPLCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B4B0", Offset = "0x7E2A6B0", VA = "0x187E2B4B0")]
	public KMHGIKJJHCN GABFFAPNPGA()
	{
		return default(KMHGIKJJHCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AFC0", Offset = "0x7E2A1C0", VA = "0x187E2AFC0")]
	public FJNGCINNGDJ CEGGLGKAPEI()
	{
		return default(FJNGCINNGDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B870", Offset = "0x7E2AA70", VA = "0x187E2B870")]
	public void MJGCCNHJDCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AEC0", Offset = "0x7E2A0C0", VA = "0x187E2AEC0")]
	public void BEPHGAAGPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B790", Offset = "0x7E2A990", VA = "0x187E2B790")]
	public bool KLOBKCMPIBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7E2BAF0", Offset = "0x7E2ACF0", VA = "0x187E2BAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public OGCPECJLBAM(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7E17EB0", Offset = "0x7E170B0", VA = "0x187E17EB0")]
	public static bool PDHAGBEBCNG(OGCPECJLBAM KJIOHKMJAPE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static EBBGNAFIMFG PDHAGBEBCNG(OGCPECJLBAM KJIOHKMJAPE)
	{
		return default(EBBGNAFIMFG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FF80", Offset = "0x7E1F180", VA = "0x187E1FF80")]
	public static bool EEDHALGLIEL(OGCPECJLBAM BGPKBCGBDMP, OGCPECJLBAM NIJBGCGEGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7E17D20", Offset = "0x7E16F20", VA = "0x187E17D20")]
	public static bool JGFOFPDALHN(OGCPECJLBAM BGPKBCGBDMP, OGCPECJLBAM NIJBGCGEGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7E2B220", Offset = "0x7E2A420", VA = "0x187E2B220", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(OGCPECJLBAM CMOCFNBHPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct IHMOPLNGHHO : IEquatable<IHMOPLNGHHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private PDPEIEABDNI MOEIOKIAFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7E227A0", Offset = "0x7E219A0", VA = "0x187E227A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7E22930", Offset = "0x7E21B30", VA = "0x187E22930")]
	public void HMOAAHOFEMM(uint APBCLGNDGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7E22A40", Offset = "0x7E21C40", VA = "0x187E22A40")]
	public bool KDMEKDPFJOD([Out] uint APBCLGNDGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7E22B40", Offset = "0x7E21D40", VA = "0x187E22B40")]
	public bool LPOLJBBGBEK([Out] uint APBCLGNDGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7E226B0", Offset = "0x7E218B0", VA = "0x187E226B0")]
	public void ADFBHCIIEGF(string APBCLGNDGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7E22C40", Offset = "0x7E21E40", VA = "0x187E22C40")]
	[CanBeNull]
	public string NDHONEHMHJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7E22D50", Offset = "0x7E21F50", VA = "0x187E22D50")]
	public bool OJNGAEMIOGN([Out] string MBCALNAAFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7E22800", Offset = "0x7E21A00", VA = "0x187E22800")]
	public void DIFAHCKLKBG(string MBCALNAAFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public IHMOPLNGHHO(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7E228A0", Offset = "0x7E21AA0", VA = "0x187E228A0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(IHMOPLNGHHO CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct PKICMIFFLJJ : IEquatable<PKICMIFFLJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private NKLJLHFCPEK AKDDEJLBMEC
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7E2CFB0", Offset = "0x7E2C1B0", VA = "0x187E2CFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private PDPEIEABDNI LJGPBFMMICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D430", Offset = "0x7E2C630", VA = "0x187E2D430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool PPJNAACOELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D570", Offset = "0x7E2C770", VA = "0x187E2D570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool AJBJBMNCOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D530", Offset = "0x7E2C730", VA = "0x187E2D530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool OLGAGHPAFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D720", Offset = "0x7E2C920", VA = "0x187E2D720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Guid IJEBCFGDHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D600", Offset = "0x7E2C800", VA = "0x187E2D600")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Guid HKLCJIPLIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D010", Offset = "0x7E2C210", VA = "0x187E2D010")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Guid CHCENHLOBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D220", Offset = "0x7E2C420", VA = "0x187E2D220")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public IMBIBOMDBCE IGGAGMHAOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(IMBIBOMDBCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D490", Offset = "0x7E2C690", VA = "0x187E2D490")]
	public bool IGOAFOAJIKC([Out] Guid PHMPPPDJDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D680", Offset = "0x7E2C880", VA = "0x187E2D680")]
	public bool KLAIHHIGGCA([Out] Guid KHABIKOGJPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7E2CD70", Offset = "0x7E2BF70", VA = "0x187E2CD70")]
	public void AONHOLBGAHD(Guid DIPIKNPCGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D090", Offset = "0x7E2C290", VA = "0x187E2D090")]
	public void DKDEJEIBHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7E2CE90", Offset = "0x7E2C090", VA = "0x187E2CE90")]
	public Guid CIIJJFMMODP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public PKICMIFFLJJ(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D190", Offset = "0x7E2C390", VA = "0x187E2D190", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(PKICMIFFLJJ CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct KNHJEANNDGG : IEquatable<KNHJEANNDGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private PGPOBAMFDJM HCNCGBDPNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7E272E0", Offset = "0x7E264E0", VA = "0x187E272E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 KPDCMIHGCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7E27080", Offset = "0x7E26280", VA = "0x187E27080")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Quaternion FNOKLLHNMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7E275B0", Offset = "0x7E267B0", VA = "0x187E275B0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public OGCPECJLBAM JOBEJOIIAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7E27340", Offset = "0x7E26540", VA = "0x187E27340")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x7E278C0", Offset = "0x7E26AC0", VA = "0x187E278C0")]
	public JCMFEJFBHJF ODDBMPKPDKC(Allocator DPAKHKILCMF)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7E26FE0", Offset = "0x7E261E0", VA = "0x187E26FE0")]
	public bool ADEPHLJKHHD(OGCPECJLBAM FLKKOCNDECC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7E27460", Offset = "0x7E26660", VA = "0x187E27460")]
	public void FCPAFFFIPNN(Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7E271D0", Offset = "0x7E263D0", VA = "0x187E271D0")]
	public void BPCNOLBOGNI(float GPOEDAABNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7E27700", Offset = "0x7E26900", VA = "0x187E27700")]
	public void KCIKJLFNJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public KNHJEANNDGG(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7E17EB0", Offset = "0x7E170B0", VA = "0x187E17EB0")]
	public static bool PDHAGBEBCNG(KNHJEANNDGG KJIOHKMJAPE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static EBBGNAFIMFG PDHAGBEBCNG(KNHJEANNDGG KJIOHKMJAPE)
	{
		return default(EBBGNAFIMFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7E273D0", Offset = "0x7E265D0", VA = "0x187E273D0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(KNHJEANNDGG CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct DBPCCINGKLD : IEquatable<DBPCCINGKLD>
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly DBPCCINGKLD KIJCOFLKIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private JPIALIKNHCC BECENHLFONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7E19F20", Offset = "0x7E19120", VA = "0x187E19F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<OGCPECJLBAM> LCLFLBDOHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A090", Offset = "0x7E19290", VA = "0x187E1A090")]
		get
		{
			return default(Span<OGCPECJLBAM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A190", Offset = "0x7E19390", VA = "0x187E1A190")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A010", Offset = "0x7E19210", VA = "0x187E1A010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public FOKDNEJDOHA DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(FOKDNEJDOHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IMBIBOMDBCE IGGAGMHAOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(IMBIBOMDBCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7E19A80", Offset = "0x7E18C80", VA = "0x187E19A80")]
	public void BAJENCFPACN(DBPCCINGKLD CMOCFNBHPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public DBPCCINGKLD(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x7E17EB0", Offset = "0x7E170B0", VA = "0x187E17EB0")]
	public static bool PDHAGBEBCNG(DBPCCINGKLD KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x7E19F80", Offset = "0x7E19180", VA = "0x187E19F80", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(DBPCCINGKLD CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static OGCPECJLBAM PDHAGBEBCNG(DBPCCINGKLD IPOCHJJJBCM)
	{
		return default(OGCPECJLBAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public struct DNJGHDDEDMD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Dictionary<int, object> ABMKJAEMGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private DNNLAHBGMBD OEGLJMHPIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool BODGJLLPAHO;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(OGCPECJLBAM);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GFJCGALDBGO HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B460", Offset = "0x7E1A660", VA = "0x187E1B460")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B5D0", Offset = "0x7E1A7D0", VA = "0x187E1B5D0")]
	internal DNJGHDDEDMD(OGCPECJLBAM KFMNDOMPAMC, bool BODGJLLPAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B330", Offset = "0x7E1A530", VA = "0x187E1B330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x3867610", Offset = "0x3866810", VA = "0x183867610")]
	public void EOCKEAJHEJK<T>(GFJCGALDBGO MHDODBCCAJB, T KJIOHKMJAPE, [Optional] T FEOJADDJKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B520", Offset = "0x7E1A720", VA = "0x187E1B520")]
	public void PKCJOLGDFLO(GFJCGALDBGO MHDODBCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0xDFAF60", Offset = "0xDFA160", VA = "0x180DFAF60")]
	public Dictionary<int, object> IDBIPJGAHLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B2C0", Offset = "0x7E1A4C0", VA = "0x187E1B2C0")]
	private readonly void AFFJENKFOCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class DKCGOLMPJLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A5C0", Offset = "0x7E197C0", VA = "0x187E1A5C0")]
	public static DNJGHDDEDMD KHDAOCKJNHA(this OGCPECJLBAM KFMNDOMPAMC)
	{
		return default(DNJGHDDEDMD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct LHOBGJOKKKN : IEquatable<LHOBGJOKKKN>
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly LHOBGJOKKKN KIJCOFLKIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private bool AECLPLAIKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7E281C0", Offset = "0x7E273C0", VA = "0x187E281C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Vector3 NLEMOMEABLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7E27F60", Offset = "0x7E27160", VA = "0x187E27F60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7E27E70", Offset = "0x7E27070", VA = "0x187E27E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7E28010", Offset = "0x7E27210", VA = "0x187E28010")]
	public Vector3 FOMBBBFDHCB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7E28140", Offset = "0x7E27340", VA = "0x187E28140")]
	public void MGJLNKEMDDN([In] Vector3 KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7E28200", Offset = "0x7E27400", VA = "0x187E28200")]
	public void OOANDHEELNM([In] Vector3 KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7E28090", Offset = "0x7E27290", VA = "0x187E28090")]
	public bool IEAAHBKAIGK([In] Vector3 KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public LHOBGJOKKKN(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7E27ED0", Offset = "0x7E270D0", VA = "0x187E27ED0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(LHOBGJOKKKN CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7E28280", Offset = "0x7E27480", VA = "0x187E28280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct HKBFLKPBALK : IEquatable<HKBFLKPBALK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7E21AF0", Offset = "0x7E20CF0", VA = "0x187E21AF0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(HKBFLKPBALK CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct IMBIBOMDBCE : IEquatable<IMBIBOMDBCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private JPIALIKNHCC BECENHLFONE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E23000", Offset = "0x7E22200", VA = "0x187E23000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public EBBGNAFIMFG BMIMCLCJEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E233B0", Offset = "0x7E225B0", VA = "0x187E233B0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public OGCPECJLBAM MBPBJNDLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7E23850", Offset = "0x7E22A50", VA = "0x187E23850")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public OGCPECJLBAM LHGFIGHCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7E230F0", Offset = "0x7E222F0", VA = "0x187E230F0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E23440", Offset = "0x7E22640", VA = "0x187E23440")]
	public Span<OGCPECJLBAM> LNHMOGBJBKM()
	{
		return default(Span<OGCPECJLBAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E23540", Offset = "0x7E22740", VA = "0x187E23540")]
	public Span<OGCPECJLBAM> NFFPBBBOHHL()
	{
		return default(Span<OGCPECJLBAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E23640", Offset = "0x7E22840", VA = "0x187E23640")]
	public Span<OGCPECJLBAM> OCIOJLMFHHE()
	{
		return default(Span<OGCPECJLBAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E23180", Offset = "0x7E22380", VA = "0x187E23180")]
	public Span<OGCPECJLBAM> JNMLDLAIEDK()
	{
		return default(Span<OGCPECJLBAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E23280", Offset = "0x7E22480", VA = "0x187E23280")]
	public bool KMHANLPIIHA(OGCPECJLBAM FLKKOCNDECC, bool MKIGDJCKCJK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E22F60", Offset = "0x7E22160", VA = "0x187E22F60")]
	public bool BGKKJAAPBBH(OGCPECJLBAM GDOJBHEJNHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E23740", Offset = "0x7E22940", VA = "0x187E23740")]
	public OGCPECJLBAM OMHNJGIAKAO(uint OLOCDOKDAOA)
	{
		return default(OGCPECJLBAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E22ED0", Offset = "0x7E220D0", VA = "0x187E22ED0")]
	public DBPCCINGKLD AOIMELEJKAI()
	{
		return default(DBPCCINGKLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public IMBIBOMDBCE(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E17EB0", Offset = "0x7E170B0", VA = "0x187E17EB0")]
	public static bool PDHAGBEBCNG(IMBIBOMDBCE KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E23060", Offset = "0x7E22260", VA = "0x187E23060", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(IMBIBOMDBCE CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct CLKGPKEJGOG : IEquatable<CLKGPKEJGOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public string MCPIOFNNGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E194E0", Offset = "0x7E186E0", VA = "0x187E194E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public string GOGCGLJMLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E19A10", Offset = "0x7E18C10", VA = "0x187E19A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public string MBKNNNCOLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7E198A0", Offset = "0x7E18AA0", VA = "0x187E198A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public string BAOMPFFEJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E19570", Offset = "0x7E18770", VA = "0x187E19570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E19950", Offset = "0x7E18B50", VA = "0x187E19950")]
	public bool OJNGAEMIOGN([Out] string MBCALNAAFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public CLKGPKEJGOG(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E19810", Offset = "0x7E18A10", VA = "0x187E19810", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(CLKGPKEJGOG CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct KMHGIKJJHCN : IEquatable<KMHGIKJJHCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private MELILGNLOEG JIGPCNMBODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7E26210", Offset = "0x7E25410", VA = "0x187E26210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public MHPIEANPOCL EFEBHGEMEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7E26AE0", Offset = "0x7E25CE0", VA = "0x187E26AE0")]
		get
		{
			return default(MHPIEANPOCL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E26670", Offset = "0x7E25870", VA = "0x187E26670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool IDOLEGILEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E26430", Offset = "0x7E25630", VA = "0x187E26430")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E26D00", Offset = "0x7E25F00", VA = "0x187E26D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public EFNLAMGBNCO<string> OBJEPFKHEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E26310", Offset = "0x7E25510", VA = "0x187E26310")]
		get
		{
			return default(EFNLAMGBNCO<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E26DA0", Offset = "0x7E25FA0", VA = "0x187E26DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public EFNLAMGBNCO<string> CNLDJOPLIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7E269C0", Offset = "0x7E25BC0", VA = "0x187E269C0")]
		get
		{
			return default(EFNLAMGBNCO<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E26BE0", Offset = "0x7E25DE0", VA = "0x187E26BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public EFNLAMGBNCO<string> LHLJMGKFEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E268A0", Offset = "0x7E25AA0", VA = "0x187E268A0")]
		get
		{
			return default(EFNLAMGBNCO<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E264C0", Offset = "0x7E256C0", VA = "0x187E264C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public EFNLAMGBNCO<string> EEDJDBFHGED
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E26780", Offset = "0x7E25980", VA = "0x187E26780")]
		get
		{
			return default(EFNLAMGBNCO<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E26EC0", Offset = "0x7E260C0", VA = "0x187E26EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7E26270", Offset = "0x7E25470", VA = "0x187E26270")]
	public bool BBNMKKGCGNF(EBBGNAFIMFG NLIBDKKPKLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public KMHGIKJJHCN(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static EBBGNAFIMFG PDHAGBEBCNG(KMHGIKJJHCN KJIOHKMJAPE)
	{
		return default(EBBGNAFIMFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E265E0", Offset = "0x7E257E0", VA = "0x187E265E0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(KMHGIKJJHCN CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct MCMLBNBFOKB : IEquatable<MCMLBNBFOKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E29160", Offset = "0x7E28360", VA = "0x187E29160", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(MCMLBNBFOKB CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct MKOGIJHAFPP : IEquatable<MKOGIJHAFPP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E29ED0", Offset = "0x7E290D0", VA = "0x187E29ED0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(MKOGIJHAFPP CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct OIALCOIBKLP : IEquatable<OIALCOIBKLP>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly ComponentTypes HHFJOAONCBA;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly OIALCOIBKLP KIJCOFLKIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Collider AGMBKCPKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BC60", Offset = "0x7E2AE60", VA = "0x187E2BC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public NOFKHNNLBFH GCKCIEMCLHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E2CA30", Offset = "0x7E2BC30", VA = "0x187E2CA30")]
		get
		{
			return default(NOFKHNNLBFH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C6C0", Offset = "0x7E2B8C0", VA = "0x187E2C6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public PDFBMJELBFB LPPOMIADAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C560", Offset = "0x7E2B760", VA = "0x187E2C560")]
		get
		{
			return default(PDFBMJELBFB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C510", Offset = "0x7E2B710", VA = "0x187E2C510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public CICBNKDBBEN MAGKCEAGFGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BEC0", Offset = "0x7E2B0C0", VA = "0x187E2BEC0")]
		get
		{
			return default(CICBNKDBBEN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C940", Offset = "0x7E2BB40", VA = "0x187E2C940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public float AAKGGIPAFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C090", Offset = "0x7E2B290", VA = "0x187E2C090")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C8F0", Offset = "0x7E2BAF0", VA = "0x187E2C8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool PCAJBPMDNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C880", Offset = "0x7E2BA80", VA = "0x187E2C880")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C620", Offset = "0x7E2B820", VA = "0x187E2C620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool AMMGGEMOIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BDB0", Offset = "0x7E2AFB0", VA = "0x187E2BDB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BFF0", Offset = "0x7E2B1F0", VA = "0x187E2BFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public bool POGNBLDDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E2CAD0", Offset = "0x7E2BCD0", VA = "0x187E2CAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C310", Offset = "0x7E2B510", VA = "0x187E2C310")]
	public static bool LKIEKEKMEOJ(OGCPECJLBAM GELDCLGDDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C0D0", Offset = "0x7E2B2D0", VA = "0x187E2C0D0")]
	public static bool LHFIILLJKMI(OGCPECJLBAM GELDCLGDDGL, [Out] OIALCOIBKLP HCHLACCEMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C710", Offset = "0x7E2B910", VA = "0x187E2C710")]
	public bool NLFHDKFFFIP([Out] AOCFFLDGBKH GNJLDOJGEEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7E2BF00", Offset = "0x7E2B100", VA = "0x187E2BF00")]
	public bool JECMPHPHOMJ([Out] EBBGNAFIMFG OLEJNEHCCLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7E2CA70", Offset = "0x7E2BC70", VA = "0x187E2CA70")]
	public bool PKHMIGJBBEP(JMAPILMLMLJ FENFECOCBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C5A0", Offset = "0x7E2B7A0", VA = "0x187E2C5A0")]
	public void MMCGJBEPEFI(JMAPILMLMLJ FENFECOCBGI, bool PGEJJMOHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7E2C990", Offset = "0x7E2BB90", VA = "0x187E2C990")]
	public void PHGENKAGEAE(JMAPILMLMLJ FENFECOCBGI, bool PGEJJMOHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public OIALCOIBKLP(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7E2BE30", Offset = "0x7E2B030", VA = "0x187E2BE30", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(OIALCOIBKLP CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7E2CB50", Offset = "0x7E2BD50", VA = "0x187E2CB50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct CKPFMAPPLCG : IEquatable<CKPFMAPPLCG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool HCNPILLKNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7E19490", Offset = "0x7E18690", VA = "0x187E19490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public CKPFMAPPLCG(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7E19400", Offset = "0x7E18600", VA = "0x187E19400", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(CKPFMAPPLCG CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct BNMNMMFAFJD : IEquatable<BNMNMMFAFJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private KDFJNMOPGNM DKNMLAKDGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7E18D90", Offset = "0x7E17F90", VA = "0x187E18D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7E18E80", Offset = "0x7E18080", VA = "0x187E18E80")]
	public void LANNALGOECD(bool FCIHABEMOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public BNMNMMFAFJD(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7E18DF0", Offset = "0x7E17FF0", VA = "0x187E18DF0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(BNMNMMFAFJD CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct AKJKFLBLANG : IEquatable<AKJKFLBLANG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool BCKDCNEBLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x7E18390", Offset = "0x7E17590", VA = "0x187E18390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool KPFLHKHCLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7E188D0", Offset = "0x7E17AD0", VA = "0x187E188D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool ECBANFNGLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7E185F0", Offset = "0x7E177F0", VA = "0x187E185F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7E18690", Offset = "0x7E17890", VA = "0x187E18690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool PHNGGGBFFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7E18730", Offset = "0x7E17930", VA = "0x187E18730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool NEDJPIAFAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7E180C0", Offset = "0x7E172C0", VA = "0x187E180C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool OBMMLIDHHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7E18420", Offset = "0x7E17620", VA = "0x187E18420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool LCEGLMNOCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7E184C0", Offset = "0x7E176C0", VA = "0x187E184C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool GNGANKBIPCN
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7E18640", Offset = "0x7E17840", VA = "0x187E18640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool OPJBCKNLHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7E17EF0", Offset = "0x7E170F0", VA = "0x187E17EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool OPKOEEIOIPN
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7E18920", Offset = "0x7E17B20", VA = "0x187E18920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool HIICMOGNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7E18470", Offset = "0x7E17670", VA = "0x187E18470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool GCEMOIHADCA
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7E18220", Offset = "0x7E17420", VA = "0x187E18220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool ODCBMDJEFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7E18510", Offset = "0x7E17710", VA = "0x187E18510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool IEJKAIGKMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7E18AE0", Offset = "0x7E17CE0", VA = "0x187E18AE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7E181B0", Offset = "0x7E173B0", VA = "0x187E181B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public FGGMEDFADEL FCILADOGLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7E18780", Offset = "0x7E17980", VA = "0x187E18780")]
		get
		{
			return default(FGGMEDFADEL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7E185A0", Offset = "0x7E177A0", VA = "0x187E185A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool DCNPCNFKLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7E189C0", Offset = "0x7E17BC0", VA = "0x187E189C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public NFJOAPCLPMN IPDANJKPJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x7E18560", Offset = "0x7E17760", VA = "0x187E18560")]
		get
		{
			return default(NFJOAPCLPMN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x7E183D0", Offset = "0x7E175D0", VA = "0x187E183D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public bool MAMNNFBHOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7E182C0", Offset = "0x7E174C0", VA = "0x187E182C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Vector3 BDNIJLDFHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7E17F40", Offset = "0x7E17140", VA = "0x187E17F40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public Vector3 BGPEOHPBBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7E187C0", Offset = "0x7E179C0", VA = "0x187E187C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool JNOGNBGHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x7E17FC0", Offset = "0x7E171C0", VA = "0x187E17FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7E18110", Offset = "0x7E17310", VA = "0x187E18110")]
	public bool CGECDHBGLAI(JMIACHAENFH FENFECOCBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7E18840", Offset = "0x7E17A40", VA = "0x187E18840")]
	public void MGLLJLKBFGE(JMIACHAENFH FENFECOCBGI, bool PGEJJMOHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7E18970", Offset = "0x7E17B70", VA = "0x187E18970")]
	public bool NPHFHFJOAAH(EGKABEIDDMN FENFECOCBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7E186B0", Offset = "0x7E178B0", VA = "0x187E186B0")]
	public void LHLHHCKCJPB(EGKABEIDDMN FENFECOCBGI, bool PGEJJMOHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7E18170", Offset = "0x7E17370", VA = "0x187E18170")]
	public EGKABEIDDMN CJALEAJAMJD()
	{
		return default(EGKABEIDDMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7E18270", Offset = "0x7E17470", VA = "0x187E18270")]
	public bool EHJGNOGDFLB(EGKABEIDDMN KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public AKJKFLBLANG(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7E18300", Offset = "0x7E17500", VA = "0x187E18300", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(AKJKFLBLANG CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct DLMMHNDIIPN : IEquatable<DLMMHNDIIPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private DBGJLBCGJDC JMIDOAAEMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A950", Offset = "0x7E19B50", VA = "0x187E1A950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1AE60", Offset = "0x7E1A060", VA = "0x187E1AE60")]
	public bool NGKMMJJKGEJ(HEGALGDCMOB LHEEKNEOKAD, List<OGCPECJLBAM> MGKDBALIGKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1AC20", Offset = "0x7E19E20", VA = "0x187E1AC20")]
	public int LAPPBPEANJO(HEGALGDCMOB LHEEKNEOKAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1AB10", Offset = "0x7E19D10", VA = "0x187E1AB10")]
	public void JNJBMFAEPFC(List<OGCPECJLBAM> MGKDBALIGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1AD30", Offset = "0x7E19F30", VA = "0x187E1AD30")]
	public int NBGADLHAMML(OGCPECJLBAM LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A680", Offset = "0x7E19880", VA = "0x187E1A680")]
	public OGCPECJLBAM BALDPAFGHOM(int CMDFFDAPDIB, HEGALGDCMOB LHEEKNEOKAD)
	{
		return default(OGCPECJLBAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7E1AF90", Offset = "0x7E1A190", VA = "0x187E1AF90")]
	public void OIKGHLFKOCO(OGCPECJLBAM LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7E1AA60", Offset = "0x7E19C60", VA = "0x187E1AA60")]
	public bool FNIFHOEGFMJ(OGCPECJLBAM LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B0C0", Offset = "0x7E1A2C0", VA = "0x187E1B0C0")]
	public void PMHPHHODDDP(HEGALGDCMOB LHEEKNEOKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A9B0", Offset = "0x7E19BB0", VA = "0x187E1A9B0")]
	public bool FGJOOJKJBCK(OGCPECJLBAM LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A7B0", Offset = "0x7E199B0", VA = "0x187E1A7B0")]
	public bool BFCBKIGFEAL(HEGALGDCMOB LHEEKNEOKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public DLMMHNDIIPN(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A8C0", Offset = "0x7E19AC0", VA = "0x187E1A8C0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(DLMMHNDIIPN CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct BOKDBOEECON : IEquatable<BOKDBOEECON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7E19040", Offset = "0x7E18240", VA = "0x187E19040")]
	public void HIDKPPAHCHM(bool KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7E18F20", Offset = "0x7E18120", VA = "0x187E18F20")]
	public void EMLJGLBMCEH(bool KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x37916F0", Offset = "0x37908F0", VA = "0x1837916F0")]
	public T KALNMJMNLNP<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public BOKDBOEECON(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7E18FB0", Offset = "0x7E181B0", VA = "0x187E18FB0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(BOKDBOEECON CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct HKPLNKPANAL : IEquatable<HKPLNKPANAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool GCPILNGEBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x7E21D30", Offset = "0x7E20F30", VA = "0x187E21D30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7E21CE0", Offset = "0x7E20EE0", VA = "0x187E21CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool EDKFKOCPBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7E21D70", Offset = "0x7E20F70", VA = "0x187E21D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public int BIDLDMGCNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7E21B80", Offset = "0x7E20D80", VA = "0x187E21B80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7E21BC0", Offset = "0x7E20DC0", VA = "0x187E21BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public HKPLNKPANAL(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7E21C50", Offset = "0x7E20E50", VA = "0x187E21C50", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(HKPLNKPANAL CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct NEOKMIIFIMG : IEquatable<NEOKMIIFIMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public int FOJNFBDPBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A0F0", Offset = "0x7E292F0", VA = "0x187E2A0F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A250", Offset = "0x7E29450", VA = "0x187E2A250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public int OPELMIBPEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A060", Offset = "0x7E29260", VA = "0x187E2A060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A0A0", Offset = "0x7E292A0", VA = "0x187E2A0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public uint ICDHCJOHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A1C0", Offset = "0x7E293C0", VA = "0x187E2A1C0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A200", Offset = "0x7E29400", VA = "0x187E2A200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public NEOKMIIFIMG(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A130", Offset = "0x7E29330", VA = "0x187E2A130", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(NEOKMIIFIMG CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct HHNHGILHKIP : IEquatable<HHNHGILHKIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private JKDAMCDCHNH BFLBFGOLCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7E20FA0", Offset = "0x7E201A0", VA = "0x187E20FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private JBHNJIEJDJB KMGLACFOGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7E21340", Offset = "0x7E20540", VA = "0x187E21340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool GJAGADLEOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7E21000", Offset = "0x7E20200", VA = "0x187E21000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool BDFLLFHMHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7E21510", Offset = "0x7E20710", VA = "0x187E21510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool GCGNGCBDDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7E21270", Offset = "0x7E20470", VA = "0x187E21270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool FBELMLGKHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7E217E0", Offset = "0x7E209E0", VA = "0x187E217E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool EFFCEFCPIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7E21240", Offset = "0x7E20440", VA = "0x187E21240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool IMIGKKDHEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7E21750", Offset = "0x7E20950", VA = "0x187E21750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool IOAGCKFMNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7E215B0", Offset = "0x7E207B0", VA = "0x187E215B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool JAHBFFDOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7E213A0", Offset = "0x7E205A0", VA = "0x187E213A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool DEGELAOICND
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7E219C0", Offset = "0x7E20BC0", VA = "0x187E219C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7E21140", Offset = "0x7E20340", VA = "0x187E21140")]
	public bool DNJEPDDCPCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7E212A0", Offset = "0x7E204A0", VA = "0x187E212A0")]
	public OGCPECJLBAM GEJFGKNKGIO(OGCPECJLBAM LBPEJPMBIKP)
	{
		return default(OGCPECJLBAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7E218B0", Offset = "0x7E20AB0", VA = "0x187E218B0")]
	public EBBGNAFIMFG PPCKLMPAMJM()
	{
		return default(EBBGNAFIMFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7E21090", Offset = "0x7E20290", VA = "0x187E21090")]
	public bool DEMIINOBEGC(EBBGNAFIMFG LBPEJPMBIKP, [Out] EBBGNAFIMFG DEFGENADONB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public HHNHGILHKIP(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7E17EB0", Offset = "0x7E170B0", VA = "0x187E17EB0")]
	public static bool PDHAGBEBCNG(HHNHGILHKIP KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7E211B0", Offset = "0x7E203B0", VA = "0x187E211B0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(HHNHGILHKIP CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct AGCGOJCMGCB : IEquatable<AGCGOJCMGCB>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly AGCGOJCMGCB KIJCOFLKIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public OFACAOILFPJ AFKFLEFOHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7E17DD0", Offset = "0x7E16FD0", VA = "0x187E17DD0")]
		get
		{
			return default(OFACAOILFPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public OFLMEILHLBB IDDHCGFKLED
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7E17970", Offset = "0x7E16B70", VA = "0x187E17970")]
		get
		{
			return default(OFLMEILHLBB);
		}
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7E17C50", Offset = "0x7E16E50", VA = "0x187E17C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public FCIAGNOBJCE MLKDHMPMIKD
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7E17BB0", Offset = "0x7E16DB0", VA = "0x187E17BB0")]
		get
		{
			return default(FCIAGNOBJCE);
		}
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7E17B20", Offset = "0x7E16D20", VA = "0x187E17B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public float KJLNENBKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7E177E0", Offset = "0x7E169E0", VA = "0x187E177E0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7E17AA0", Offset = "0x7E16CA0", VA = "0x187E17AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public Vector3 OBPBIJCHCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7E178A0", Offset = "0x7E16AA0", VA = "0x187E178A0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7E17820", Offset = "0x7E16A20", VA = "0x187E17820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public float KHMLNJCKOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7E17D80", Offset = "0x7E16F80", VA = "0x187E17D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public FEDMKIFLINL OEEKOEDDKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7E17D40", Offset = "0x7E16F40", VA = "0x187E17D40")]
		get
		{
			return default(FEDMKIFLINL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7E17E60", Offset = "0x7E17060", VA = "0x187E17E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool KGILOAPKIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7E17B70", Offset = "0x7E16D70", VA = "0x187E17B70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7E17BF0", Offset = "0x7E16DF0", VA = "0x187E17BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public FOKDNEJDOHA DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(FOKDNEJDOHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public IMBIBOMDBCE IGGAGMHAOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(IMBIBOMDBCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x7E17A50", Offset = "0x7E16C50", VA = "0x187E17A50")]
	public JDIDLOLPDDJ FPEBGKIMIGM()
	{
		return default(JDIDLOLPDDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7E17920", Offset = "0x7E16B20", VA = "0x187E17920")]
	public GBAGLKGCOGP DFNHMHMMCBH()
	{
		return default(GBAGLKGCOGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7E17E10", Offset = "0x7E17010", VA = "0x187E17E10")]
	private bool MNDFDIJOLLL(FEDMKIFLINL FENFECOCBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7E17CA0", Offset = "0x7E16EA0", VA = "0x187E17CA0")]
	public void JEHAEJJNHKK(FEDMKIFLINL FENFECOCBGI, bool PGEJJMOHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public AGCGOJCMGCB(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7E17EB0", Offset = "0x7E170B0", VA = "0x187E17EB0")]
	public static bool PDHAGBEBCNG(AGCGOJCMGCB KJIOHKMJAPE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7E17D20", Offset = "0x7E16F20", VA = "0x187E17D20")]
	public static bool JGFOFPDALHN(AGCGOJCMGCB BGPKBCGBDMP, AGCGOJCMGCB NIJBGCGEGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7E179C0", Offset = "0x7E16BC0", VA = "0x187E179C0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(AGCGOJCMGCB CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct JDIDLOLPDDJ : IEquatable<JDIDLOLPDDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public AGCGOJCMGCB KHEOHIEBAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(AGCGOJCMGCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public AJCKMHEMCBO OAHCAKNONAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E24600", Offset = "0x7E23800", VA = "0x187E24600")]
		get
		{
			return default(AJCKMHEMCBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public JDIDLOLPDDJ(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E17EB0", Offset = "0x7E170B0", VA = "0x187E17EB0")]
	public static bool PDHAGBEBCNG(JDIDLOLPDDJ KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E24570", Offset = "0x7E23770", VA = "0x187E24570", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(JDIDLOLPDDJ CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[DefaultMember("Item")]
public readonly struct GBAGLKGCOGP : IEquatable<GBAGLKGCOGP>
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly GBAGLKGCOGP KIJCOFLKIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	private OMAOJKPBNDN GINNEFKMLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E20020", Offset = "0x7E1F220", VA = "0x187E20020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public AGCGOJCMGCB KHEOHIEBAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(AGCGOJCMGCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public FLHGMAEFHJA PIJCNOMHHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E20080", Offset = "0x7E1F280", VA = "0x187E20080")]
		get
		{
			return default(FLHGMAEFHJA);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FD30", Offset = "0x7E1EF30", VA = "0x187E1FD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public IEnumerable<MCHPBLJLBOJ> OJKCFJHFJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E20570", Offset = "0x7E1F770", VA = "0x187E20570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public MCHPBLJLBOJ HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7E201B0", Offset = "0x7E1F3B0", VA = "0x187E201B0")]
		get
		{
			return default(MCHPBLJLBOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FEF0", Offset = "0x7E1F0F0", VA = "0x187E1FEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public FOKDNEJDOHA DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(FOKDNEJDOHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E20350", Offset = "0x7E1F550", VA = "0x187E20350")]
	public MCHPBLJLBOJ PECECAOBPHM(float3? FICCENLPJEL, [Optional] quaternion? NDOBKEDDJAJ, [Optional] Vector3? GPOEDAABNAL)
	{
		return default(MCHPBLJLBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FB00", Offset = "0x7E1ED00", VA = "0x187E1FB00")]
	public MCHPBLJLBOJ AHAFGIOCEMP(int CMDFFDAPDIB, float3? FICCENLPJEL, [Optional] quaternion? NDOBKEDDJAJ, [Optional] Vector3? GPOEDAABNAL)
	{
		return default(MCHPBLJLBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FE50", Offset = "0x7E1F050", VA = "0x187E1FE50")]
	public void EABOBGHIJHA(int CMDFFDAPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E202C0", Offset = "0x7E1F4C0", VA = "0x187E202C0")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public GBAGLKGCOGP(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E17EB0", Offset = "0x7E170B0", VA = "0x187E17EB0")]
	public static bool PDHAGBEBCNG(GBAGLKGCOGP KJIOHKMJAPE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FF80", Offset = "0x7E1F180", VA = "0x187E1FF80")]
	public static bool EEDHALGLIEL(GBAGLKGCOGP BGPKBCGBDMP, GBAGLKGCOGP NIJBGCGEGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FF90", Offset = "0x7E1F190", VA = "0x187E1FF90", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(GBAGLKGCOGP CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct MCHPBLJLBOJ : IEquatable<MCHPBLJLBOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public GBAGLKGCOGP MJKEBOHBDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E29030", Offset = "0x7E28230", VA = "0x187E29030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public float3 DPCDBEOOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E29100", Offset = "0x7E28300", VA = "0x187E29100")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E28ED0", Offset = "0x7E280D0", VA = "0x187E28ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public quaternion BDNOGOADCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E28E80", Offset = "0x7E28080", VA = "0x187E28E80")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7E290B0", Offset = "0x7E282B0", VA = "0x187E290B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public float3 GEDMGNBEJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E28E20", Offset = "0x7E28020", VA = "0x187E28E20")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E28FD0", Offset = "0x7E281D0", VA = "0x187E28FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public CFAEEBOPCFL CHHNELFOPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E28DD0", Offset = "0x7E27FD0", VA = "0x187E28DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E28FC0", Offset = "0x7E281C0", VA = "0x187E28FC0")]
	public void GJFOGMCLLAA(GBAGLKGCOGP KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public MCHPBLJLBOJ(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7E28F30", Offset = "0x7E28130", VA = "0x187E28F30", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(MCHPBLJLBOJ CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct FJNGCINNGDJ : IEquatable<FJNGCINNGDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool EFCNGCFMIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D900", Offset = "0x7E1CB00", VA = "0x187E1D900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public FJNGCINNGDJ(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D970", Offset = "0x7E1CB70", VA = "0x187E1D970", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(FJNGCINNGDJ CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct FBNEFAOLDGD : IEquatable<FBNEFAOLDGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	private FIJOAGNCNMH HLOIGOAPDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D2F0", Offset = "0x7E1C4F0", VA = "0x187E1D2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool MKMIKPGIPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D1C0", Offset = "0x7E1C3C0", VA = "0x187E1D1C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CE30", Offset = "0x7E1C030", VA = "0x187E1CE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public bool IDKGCPHLOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D210", Offset = "0x7E1C410", VA = "0x187E1D210")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CFC0", Offset = "0x7E1C1C0", VA = "0x187E1CFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public float KFCKJEDLNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D770", Offset = "0x7E1C970", VA = "0x187E1D770")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D480", Offset = "0x7E1C680", VA = "0x187E1D480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public bool FFLINDEHFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D170", Offset = "0x7E1C370", VA = "0x187E1D170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D650", Offset = "0x7E1C850", VA = "0x187E1D650")]
	public void JLFBNAAOKPP(int IMMAKBDNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CD20", Offset = "0x7E1BF20", VA = "0x187E1CD20")]
	public bool AAKIHFHCDPD([Out] int IMMAKBDNFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D350", Offset = "0x7E1C550", VA = "0x187E1D350")]
	public void FDDEGKBOADM(bool JLNGFLPNGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D4D0", Offset = "0x7E1C6D0", VA = "0x187E1D4D0")]
	public bool IACDHNKLKMH(ILCFGLPCBBA FENFECOCBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D6F0", Offset = "0x7E1C8F0", VA = "0x187E1D6F0")]
	public void LEOKCDOOPKB(ILCFGLPCBBA FENFECOCBGI, bool PGEJJMOHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D7B0", Offset = "0x7E1C9B0", VA = "0x187E1D7B0")]
	public void LNLEMMPPBLF(float FAOMFFCHGGG, float ANBJEGEKPNG, float LKHLDGFEGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D020", Offset = "0x7E1C220", VA = "0x187E1D020")]
	public void DCLDNBHCJAC(float3 HKKGKCGPCCO, quaternion ALOEOBIOJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D520", Offset = "0x7E1C720", VA = "0x187E1D520")]
	public bool ILPLELDGOMH([Out] float3 HKKGKCGPCCO, [Out] quaternion ALOEOBIOJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CE90", Offset = "0x7E1C090", VA = "0x187E1CE90")]
	public bool CABKADDPOIO([Out] float IBNEGMJBNNN, [Out] float BCAPOPBCHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D3F0", Offset = "0x7E1C5F0", VA = "0x187E1D3F0")]
	public void FNPLDGBMMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public FBNEFAOLDGD(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D260", Offset = "0x7E1C460", VA = "0x187E1D260", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(FBNEFAOLDGD CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct FOKDNEJDOHA : IEquatable<FOKDNEJDOHA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	private MLACKGMOCIO MKHMMGENDBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DBC0", Offset = "0x7E1CDC0", VA = "0x187E1DBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Vector3 DPCDBEOOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E1F350", Offset = "0x7E1E550", VA = "0x187E1F350")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E450", Offset = "0x7E1D650", VA = "0x187E1E450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public Quaternion BDNOGOADCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E300", Offset = "0x7E1D500", VA = "0x187E1E300")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E1F1D0", Offset = "0x7E1E3D0", VA = "0x187E1F1D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public Vector3 GABCDCKCPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E680", Offset = "0x7E1D880", VA = "0x187E1E680")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E5B0", Offset = "0x7E1D7B0", VA = "0x187E1E5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public Quaternion ENFOLGOEPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DF80", Offset = "0x7E1D180", VA = "0x187E1DF80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x7E1F060", Offset = "0x7E1E260", VA = "0x187E1F060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public float DMLBOIHBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x7E1EC10", Offset = "0x7E1DE10", VA = "0x187E1EC10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DCC0", Offset = "0x7E1CEC0", VA = "0x187E1DCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public float NELECBAJGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x7E1EEF0", Offset = "0x7E1E0F0", VA = "0x187E1EEF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public Matrix4x4 LGBMKLCPOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DC80", Offset = "0x7E1CE80", VA = "0x187E1DC80")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public IMBIBOMDBCE IGGAGMHAOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(IMBIBOMDBCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	private MIPBFCPKCOJ ILKAAAENLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BD70", Offset = "0x7E1AF70", VA = "0x187E1BD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E0D0", Offset = "0x7E1D2D0", VA = "0x187E1E0D0")]
	public DONKIJIPKJK DBJHAIDOBGH()
	{
		return default(DONKIJIPKJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F750", Offset = "0x7E1E950", VA = "0x187E1F750")]
	public void OLONHKGIBKA([Out] Matrix4x4 FEOMPHHNKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F940", Offset = "0x7E1EB40", VA = "0x187E1F940")]
	public void PKHHFOMPJHD([In] Vector3 JCHDHELBFIA, [In] Quaternion FODPIPCFDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FA40", Offset = "0x7E1EC40", VA = "0x187E1FA40")]
	public void PKHHFOMPJHD([In] RigidTransform PEMHPIOCAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DD70", Offset = "0x7E1CF70", VA = "0x187E1DD70")]
	public void CFIBIGALLNH([Out] RigidTransform PEMHPIOCAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F650", Offset = "0x7E1E850", VA = "0x187E1F650")]
	public void OIJOLKKGCKO([In] Vector3 BCPLCAGGKPO, [In] Quaternion CJPMDBOOGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F590", Offset = "0x7E1E790", VA = "0x187E1F590")]
	public void OIJOLKKGCKO([In] RigidTransform HCBKMIBOFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E820", Offset = "0x7E1DA20", VA = "0x187E1E820")]
	public void LECCEBJJFMA([Out] Vector3 BCPLCAGGKPO, [Out] Quaternion CJPMDBOOGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E900", Offset = "0x7E1DB00", VA = "0x187E1E900")]
	public void LECCEBJJFMA([Out] RigidTransform PEMHPIOCAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E210", Offset = "0x7E1D410", VA = "0x187E1E210")]
	public UniformTRS ECCHGJABAEG()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E240", Offset = "0x7E1D440", VA = "0x187E1E240")]
	public void ECCHGJABAEG([Out] UniformTRS HCBKMIBOFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E120", Offset = "0x7E1D320", VA = "0x187E1E120")]
	public UniformTRS DJHJMCEMJMM()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E150", Offset = "0x7E1D350", VA = "0x187E1E150")]
	public void DJHJMCEMJMM([Out] UniformTRS PEMHPIOCAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EB20", Offset = "0x7E1DD20", VA = "0x187E1EB20")]
	public Vector3 LLCHFPGHHEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EF90", Offset = "0x7E1E190", VA = "0x187E1EF90")]
	public void MNOCIFMPDGK([In] Vector3 KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EE00", Offset = "0x7E1E000", VA = "0x187E1EE00")]
	public Vector3 MMMCBHNMMFO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E9B0", Offset = "0x7E1DBB0", VA = "0x187E1E9B0")]
	public void LEEIIPPGNKG([In] Vector3 KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F440", Offset = "0x7E1E640", VA = "0x187E1F440")]
	public Quaternion OADKICMINED()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DEB0", Offset = "0x7E1D0B0", VA = "0x187E1DEB0")]
	public void CMMGIHGOPNB([In] Quaternion KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1ECB0", Offset = "0x7E1DEB0", VA = "0x187E1ECB0")]
	public Quaternion MHMDIJDHAAE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F870", Offset = "0x7E1EA70", VA = "0x187E1F870")]
	public void PAEHILFIDLF([In] Quaternion KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F130", Offset = "0x7E1E330", VA = "0x187E1F130")]
	public float NCMDNBPPPPG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E770", Offset = "0x7E1D970", VA = "0x187E1E770")]
	public void KLDONJHKMCI(float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EA80", Offset = "0x7E1DC80", VA = "0x187E1EA80")]
	public float LKBAGKECBFH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F2A0", Offset = "0x7E1E4A0", VA = "0x187E1F2A0")]
	public void NKGMLOMPLHK(float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DE20", Offset = "0x7E1D020", VA = "0x187E1DE20")]
	public Vector3 CHIIKMIOFOK([In] Vector3 JBACNGDELHL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public FOKDNEJDOHA(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E520", Offset = "0x7E1D720", VA = "0x187E1E520", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(FOKDNEJDOHA CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct LJCLFNAGNIL : IEquatable<LJCLFNAGNIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	private OMBGIHJLFOF FFGLPIMJBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x7E28560", Offset = "0x7E27760", VA = "0x187E28560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	private EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7E28390", Offset = "0x7E27590", VA = "0x187E28390")]
	public void ELFJJDFEBPN(string BGOPKLLOOIA, MGGMGKJEFNC BHGHJPNDBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public LJCLFNAGNIL(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x7E284D0", Offset = "0x7E276D0", VA = "0x187E284D0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(LJCLFNAGNIL CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7E17ED0", Offset = "0x7E170D0", VA = "0x187E17ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct FAIDNEBGHKF : IEquatable<FAIDNEBGHKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public CEAHLANEAPC JJJGODAKKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CC30", Offset = "0x7E1BE30", VA = "0x187E1CC30")]
		get
		{
			return default(CEAHLANEAPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public FAIDNEBGHKF(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CBA0", Offset = "0x7E1BDA0", VA = "0x187E1CBA0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(FAIDNEBGHKF CMOCFNBHPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct IBNDLMGPLAJ : IEquatable<IBNDLMGPLAJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct EKIFCPNMNED : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private EBBGNAFIMFG MNPNHJICMND;

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CB00", Offset = "0x7E1BD00", VA = "0x187E1CB00")]
		public EKIFCPNMNED(EBBGNAFIMFG MNPNHJICMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CA70", Offset = "0x7E1BC70", VA = "0x187E1CA70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7E221A0", Offset = "0x7E213A0", VA = "0x187E221A0")]
	public EKIFCPNMNED LOEGJJFGMIL()
	{
		return default(EKIFCPNMNED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7E220B0", Offset = "0x7E212B0", VA = "0x187E220B0")]
	public MMHGACDNFOA KOKAKLANEHM(Allocator DPAKHKILCMF = Allocator.Temp)
	{
		return default(MMHGACDNFOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7E223A0", Offset = "0x7E215A0", VA = "0x187E223A0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> OJDOKEGNAJB(Allocator DPAKHKILCMF = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7E22230", Offset = "0x7E21430", VA = "0x187E22230")]
	public NativeArray<DLILJGCOAIF> NINAEKNINCM(Allocator DPAKHKILCMF = Allocator.Temp)
	{
		return default(NativeArray<DLILJGCOAIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7E22000", Offset = "0x7E21200", VA = "0x187E22000")]
	public NativeArray<DLILJGCOAIF> KNKENDNJHKD(Allocator DPAKHKILCMF = Allocator.Temp)
	{
		return default(NativeArray<DLILJGCOAIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7E21EB0", Offset = "0x7E210B0", VA = "0x187E21EB0")]
	public JCMFEJFBHJF EDAMHAAHINI(Allocator DPAKHKILCMF = Allocator.Temp)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7E222E0", Offset = "0x7E214E0", VA = "0x187E222E0")]
	public JCMFEJFBHJF OEHNFOAMJHH(Allocator DPAKHKILCMF = Allocator.Temp)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7E21DF0", Offset = "0x7E20FF0", VA = "0x187E21DF0")]
	public JCMFEJFBHJF BLGNGOBHPMD(Allocator DPAKHKILCMF = Allocator.Temp)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public IBNDLMGPLAJ(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7E21F70", Offset = "0x7E21170", VA = "0x187E21F70", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(IBNDLMGPLAJ CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7E193E0", Offset = "0x7E185E0", VA = "0x187E193E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct HHHIOELHCHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int AEBOIICOKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int LKONJPFCFGK;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct CJEPKMLCMLN : IEquatable<CJEPKMLCMLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public IBNDLMGPLAJ NKLPPFPIJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(IBNDLMGPLAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public JILLEJOENKD FAFJLKPDBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(JILLEJOENKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public FAIDNEBGHKF MPPCDJPFKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(FAIDNEBGHKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7E19130", Offset = "0x7E18330", VA = "0x187E19130")]
	public bool DBEHNFMJBJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7E19260", Offset = "0x7E18460", VA = "0x187E19260")]
	public bool FGPKCCAKODG([Out] Exception GMBDOBOLCOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public CJEPKMLCMLN(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static EBBGNAFIMFG PDHAGBEBCNG(CJEPKMLCMLN KJIOHKMJAPE)
	{
		return default(EBBGNAFIMFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7E191D0", Offset = "0x7E183D0", VA = "0x187E191D0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(CJEPKMLCMLN CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7E193E0", Offset = "0x7E185E0", VA = "0x187E193E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct EFHJPDPFDHE : IDisposable, IEquatable<EFHJPDPFDHE>
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public static readonly EFHJPDPFDHE KIJCOFLKIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public CJEPKMLCMLN IBALOMCONOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(CJEPKMLCMLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public IBNDLMGPLAJ NKLPPFPIJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(IBNDLMGPLAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C710", Offset = "0x7E1B910", VA = "0x187E1C710")]
	public void BHMMKOPJJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C790", Offset = "0x7E1B990", VA = "0x187E1C790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public EFHJPDPFDHE(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C860", Offset = "0x7E1BA60", VA = "0x187E1C860", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "5")]
	public bool Equals(EFHJPDPFDHE CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C8F0", Offset = "0x7E1BAF0", VA = "0x187E1C8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct JILLEJOENKD : IEquatable<JILLEJOENKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public bool LLKOKCFMJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x7E24640", Offset = "0x7E23840", VA = "0x187E24640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	public JILLEJOENKD(EBBGNAFIMFG MNPNHJICMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AF0", Offset = "0x7E16CF0", VA = "0x187E17AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7E246D0", Offset = "0x7E238D0", VA = "0x187E246D0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7E179B0", Offset = "0x7E16BB0", VA = "0x187E179B0", Slot = "4")]
	public bool Equals(JILLEJOENKD CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7E193E0", Offset = "0x7E185E0", VA = "0x187E193E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class LCHFIMEDAEM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private struct FBKJBOEDJBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Guid DJOIAEMCFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public GMENDOGOHJP KBAOKIFIDBH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private struct GMENDOGOHJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int KJIOHKMJAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int MCBHFLKONDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int AHDPMOGMOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int PCJEEPDAIDP;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x7E20CF0", Offset = "0x7E1FEF0", VA = "0x187E20CF0")]
		public bool OMFKJGMKGDF([Out] DLILJGCOAIF HHOFDEAFCJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7E20D90", Offset = "0x7E1FF90", VA = "0x187E20D90")]
		public GMENDOGOHJP(DLILJGCOAIF HHOFDEAFCJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7E27A10", Offset = "0x7E26C10", VA = "0x187E27A10")]
	public static Guid NMDCFMPICNN(this DLILJGCOAIF HHOFDEAFCJP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7E27AB0", Offset = "0x7E26CB0", VA = "0x187E27AB0")]
	public static bool PAIFJMFEAOD(this Guid DJOIAEMCFDK, [Out] DLILJGCOAIF HHOFDEAFCJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class KDJOFAJKDGI
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7E26130", Offset = "0x7E25330", VA = "0x187E26130")]
	public static EIMDFMFNNAG PDLLLCCCCCP(this EBBGNAFIMFG APBCLGNDGBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x7E25FC0", Offset = "0x7E251C0", VA = "0x187E25FC0")]
	public static LANOECBBLFB OAOPEPGHMCC(this EBBGNAFIMFG APBCLGNDGBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7E25F30", Offset = "0x7E25130", VA = "0x187E25F30")]
	public static EntityManager EPHJNECDEMJ(this EBBGNAFIMFG APBCLGNDGBE)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA44A0", Offset = "0x3AA36A0", VA = "0x183AA44A0")]
	internal static bool IJKOBDFLDHG<T>(this EBBGNAFIMFG APBCLGNDGBE, bool PGEJJMOHEOB) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x7E26020", Offset = "0x7E25220", VA = "0x187E26020")]
	public static bool OMKFIPALNGD(this EBBGNAFIMFG APBCLGNDGBE, OOPJKCMDMCJ MEGAJPAELNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2410", Offset = "0x3AA1610", VA = "0x183AA2410")]
	public static bool GHCKBNFEAKM<T>(this EBBGNAFIMFG APBCLGNDGBE) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x3AA48B0", Offset = "0x3AA3AB0", VA = "0x183AA48B0")]
	public static bool NEGEOCOKLCE<T>(this EBBGNAFIMFG APBCLGNDGBE) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2C30", Offset = "0x3AA1E30", VA = "0x183AA2C30")]
	[MAPEACMPPBB]
	public static T IGEPDDJFNAM<T>(this EBBGNAFIMFG APBCLGNDGBE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F9D0", Offset = "0x3A9EBD0", VA = "0x183A9F9D0")]
	[MAPEACMPPBB]
	public static T BNIEELNIBHP<T>(this EBBGNAFIMFG APBCLGNDGBE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4710", Offset = "0x3AA3910", VA = "0x183AA4710")]
	public static bool MIICEDPKJBD<T>(this EBBGNAFIMFG APBCLGNDGBE, [Out] T KJIOHKMJAPE) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4660", Offset = "0x3AA3860", VA = "0x183AA4660")]
	public static T LGNNNHOEFJE<T>(this EBBGNAFIMFG APBCLGNDGBE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4830", Offset = "0x3AA3A30", VA = "0x183AA4830")]
	public static T NCOMMLFBILP<T>(this EBBGNAFIMFG APBCLGNDGBE) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal static class GKDLAHGMGGB
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[DefaultMember("Item")]
public struct MMHGACDNFOA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private JCMFEJFBHJF LMDCFNDMKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> BHLKBIIEBGB;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5C4DE00", Offset = "0x5C4D000", VA = "0x185C4DE00")]
	public MMHGACDNFOA(JCMFEJFBHJF LMDCFNDMKMH, NativeArray<EntityRemapUtility.EntityRemapInfo> BHLKBIIEBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A020", Offset = "0x7E29220", VA = "0x187E2A020")]
	public LocalId EKOJPGEHMIG(LocalId KFMNDOMPAMC)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7E29FD0", Offset = "0x7E291D0", VA = "0x187E29FD0")]
	public LocalId EKOJPGEHMIG(int CMDFFDAPDIB)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x7E29F60", Offset = "0x7E29160", VA = "0x187E29F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CNGFFFLGOAB
{
	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJNHAFCNFDA(World AFDKGPIKPNA, NativeParallelHashSet<FixedString64Bytes> BNGPJMPDELJ);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PDPEIEABDNI
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JCMFEJFBHJF GEBAPMPPLGM(Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LPOLJBBGBEK(EBBGNAFIMFG DBENCIIAGPJ, [Out] uint APBCLGNDGBE);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KDMEKDPFJOD(EBBGNAFIMFG DBENCIIAGPJ, [Out] uint APBCLGNDGBE);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMOAAHOFEMM(EBBGNAFIMFG DBENCIIAGPJ, uint APBCLGNDGBE);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FMJEILDIDMD(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "5")]
	string NDHONEHMHJC(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ADFBHCIIEGF(EBBGNAFIMFG DBENCIIAGPJ, string APBCLGNDGBE);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OJNGAEMIOGN(EBBGNAFIMFG DBENCIIAGPJ, [Out] string MBCALNAAFAH);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DIFAHCKLKBG(EBBGNAFIMFG DBENCIIAGPJ, string MBCALNAAFAH);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NKLJLHFCPEK
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	Guid JAPDOMLPHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	Guid NFFAFGIPHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PPJNAACOELC(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task NJJIJAMOCMA(OGCPECJLBAM KFMNDOMPAMC);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid CIIJJFMMODP(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AONHOLBGAHD(EBBGNAFIMFG MNPNHJICMND, Guid KHABIKOGJPF);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DKDEJEIBHNB(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JONMMACGIFJ(EBBGNAFIMFG JPCNHODHEGA, EBBGNAFIMFG FLKKOCNDECC);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BPLLIPPDNHF(EBBGNAFIMFG MNPNHJICMND, DLILJGCOAIF LKLCMOKFFEL);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BDBPDGHFPKH
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	Guid JAPDOMLPHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKEFFKOINAK(NativeList<Guid> GHMFLGHFDBM, NativeList<Guid> GMLKNAPAIIB, NativeList<FixedString64Bytes> ABCPBILFEIA);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BMPNPIAAGBO
{
	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JCMFEJFBHJF CKPPFFEMEJC(Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCMFEJFBHJF OLNMAALAANM(Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PLHIEIBAOCL(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EDKFKOCPBML(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FAPINPDDENC(EBBGNAFIMFG DBENCIIAGPJ, [Out] EBBGNAFIMFG ADFHPMBGDIF);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GCPILNGEBKG(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KGHIJAPEJIO(EBBGNAFIMFG DBENCIIAGPJ, int MKCPMOJFGDP);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EBBGNAFIMFG IGHAMJBPJDF(EBBGNAFIMFG ADFHPMBGDIF);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PFFDNAOOMHP(JCMFEJFBHJF IOIHFCOPCJO, bool HDMBKFKALJL);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool INKMGJAHJJJ(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PKDPIIGLALD(EBBGNAFIMFG DBENCIIAGPJ, bool KDJNMMNKPJI);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int HDJEDFFADLP();

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LHKKPFHNJGJ(EBBGNAFIMFG MNPNHJICMND);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PGPOBAMFDJM
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<EBBGNAFIMFG, EBBGNAFIMFG> OKKJJDILICH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<EBBGNAFIMFG, EBBGNAFIMFG> AJJLFMDGADC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<EBBGNAFIMFG, EBBGNAFIMFG, EBBGNAFIMFG> GJMJICKFBBI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<EBBGNAFIMFG> ECAIFFBMIDL;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ADEPHLJKHHD(EBBGNAFIMFG MNPNHJICMND, EBBGNAFIMFG LJNADKJOPFJ);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EBBGNAFIMFG NKCPEFCALBN(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JCMFEJFBHJF ODDBMPKPDKC(EBBGNAFIMFG MNPNHJICMND, Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EBBGNAFIMFG LNMAILJAAMF(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FCPAFFFIPNN(EBBGNAFIMFG MNPNHJICMND, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BPCNOLBOGNI(EBBGNAFIMFG MNPNHJICMND, float LINGFBEKMDG);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NJLLDNBKGFM(EBBGNAFIMFG MNPNHJICMND, [Out] EBBGNAFIMFG FLKKOCNDECC);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LNDGOBAGFBA(EBBGNAFIMFG MNPNHJICMND, [Out] RigidTransform MJKCFKJKHOO);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 DBEOMBACMGG(KNHJEANNDGG BKJAKODNAOC);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion GEAOBCGJAAA(KNHJEANNDGG BKJAKODNAOC);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class NBAGPAGNAGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IOGINFMBIOL
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	object OHIFJFLPGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PNJGIMPDKGK
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKGMELHNKKC(EBBGNAFIMFG KFMNDOMPAMC, NLCJIIIDMMO MHIOLFBBMPO);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFPNMPANPGE(NLCJIIIDMMO MHIOLFBBMPO);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IALEHPDCILI(EBBGNAFIMFG MNPNHJICMND, [Out] NLCJIIIDMMO OEHKPMHMGLO);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[Flags]
public enum NBLLCMPPING
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public readonly struct AMHFAOHMEHG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly string GBOCGPJOEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly T FEOJADDJKIL;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x5010870", Offset = "0x500FA70", VA = "0x185010870")]
	public AMHFAOHMEHG(T FEOJADDJKIL, [Optional][CallerMemberName] string GBOCGPJOEEK)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly AMHFAOHMEHG<int> GHIPEEBAHJO;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly AMHFAOHMEHG<int> ONBKPBJOKLG;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly AMHFAOHMEHG<int> EKINBMBIMOL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public enum GJNFILNEFDG
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class CHBGBLIIAIE
{
	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x13387E0", Offset = "0x13379E0", VA = "0x1813387E0")]
	public static bool EHLJLLHGOJM(this GJNFILNEFDG CKCKEFFHJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x172ACD0", Offset = "0x1729ED0", VA = "0x18172ACD0")]
	public static bool ENPHAOEJLJM(this GJNFILNEFDG CKCKEFFHJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F36290", Offset = "0x2F35490", VA = "0x182F36290")]
	public static bool PKHPCECKGPM(this GJNFILNEFDG CKCKEFFHJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x13387D0", Offset = "0x13379D0", VA = "0x1813387D0")]
	public static bool DMPLLGBIADG(this GJNFILNEFDG CKCKEFFHJAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KMAKGLICNNJ
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum GEGLPPLBBEH
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum OHHBAFDBFJD
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	GEGLPPLBBEH NGCDAILNILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	bool PFLLALIMLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	bool IFGIEJOOMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	OHHBAFDBFJD JMBABKCLOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.Application)]
public interface GPGFGCPFLGA
{
	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	GJNFILNEFDG KAMPINFAGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	GJNFILNEFDG EDIKNCAPOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	GJNFILNEFDG PLOAHEEOBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	GJNFILNEFDG IHNCJHJOAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	GJNFILNEFDG KNNDMGNKKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	GJNFILNEFDG POOIAJFBCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	GJNFILNEFDG FPIAONCOKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	GJNFILNEFDG MMGFEFKJIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	GJNFILNEFDG CDKFAEAFECL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	GJNFILNEFDG KMEGOBEGKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	GJNFILNEFDG LNEEPBOFKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	GJNFILNEFDG CJMPDCFBPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	GJNFILNEFDG NBNLHDGNPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	GJNFILNEFDG COKIBBOCMON
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	GJNFILNEFDG NJLIDFLMPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	GJNFILNEFDG PLIOPPJPMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	GJNFILNEFDG BAJDBHHIFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	GJNFILNEFDG LAPDJDLLPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	GJNFILNEFDG HFPBDHNIBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	GJNFILNEFDG FLFKILDIBCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int AFHCIICHJIO(AMHFAOHMEHG<int> HICOIPDJCOI);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JPIALIKNHCC
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event LCPKIBCGPAC.KNAJCDOHBDH PBBFENKMCPJ;

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EBBGNAFIMFG KGINEHONNLE(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JCMFEJFBHJF KIIKKOJMJDD(Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CFAEEBOPCFL LLNDFOJKGLG(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MNDICMACLNH(IEnumerable<EBBGNAFIMFG> IHNPKFICFDM);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CFAEEBOPCFL GKMKHKGDIGA(EBBGNAFIMFG FLKKOCNDECC, EBBGNAFIMFG LMDCFNDMKMH, bool HOGHKGAJJGF, EBBGNAFIMFG LBPEJPMBIKP);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EBBGNAFIMFG JMBNDFCBJBM(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KMHANLPIIHA(EBBGNAFIMFG MNPNHJICMND, EBBGNAFIMFG FLKKOCNDECC, bool MKIGDJCKCJK = false);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FOGAAHLCKCA(EBBGNAFIMFG MNPNHJICMND, EBBGNAFIMFG FLKKOCNDECC);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HDPKJHBLJGA(EBBGNAFIMFG JBMMNANPJAM, EBBGNAFIMFG IJJOBBLHCAA);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	JCMFEJFBHJF OAOOOLMDBDE(EBBGNAFIMFG PMOPIAOAEIC);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KPDBIJHJFKF(EBBGNAFIMFG MNPNHJICMND, EBBGNAFIMFG JLNDEBLOOPH);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JCMFEJFBHJF HBBJLCKKBPC(JCMFEJFBHJF OLPCAOJAAOJ, NBLLCMPPING FFMDBMBLMEI, Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BGKKJAAPBBH(EBBGNAFIMFG MNPNHJICMND, EBBGNAFIMFG GDOJBHEJNHO);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EBBGNAFIMFG ICIOMGHACCI(EBBGNAFIMFG LBPEJPMBIKP, EBBGNAFIMFG NCMKPPNNFPG);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool OJKAKCOOMNF(EBBGNAFIMFG LBPEJPMBIKP, EBBGNAFIMFG NCMKPPNNFPG, [Out] EBBGNAFIMFG CGEHOPEKHKJ);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	EBBGNAFIMFG JMFPGMMEKOI(EBBGNAFIMFG[] IOIHFCOPCJO);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "18")]
	EBBGNAFIMFG OMHNJGIAKAO(EBBGNAFIMFG MNPNHJICMND, uint OLOCDOKDAOA);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public static class ODCMOHHMJPO
{
	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A820", Offset = "0x7E29A20", VA = "0x187E2A820")]
	public static bool EEFKKNIEIKA(this JPIALIKNHCC OPMMMGOPKMI, EBBGNAFIMFG MNPNHJICMND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A890", Offset = "0x7E29A90", VA = "0x187E2A890")]
	public static JCMFEJFBHJF HBBJLCKKBPC(this JPIALIKNHCC HMJBLCLPFFF, EBBGNAFIMFG MNPNHJICMND, NBLLCMPPING FFMDBMBLMEI, Allocator DPAKHKILCMF)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AD40", Offset = "0x7E29F40", VA = "0x187E2AD40")]
	public static JCMFEJFBHJF NFFPBBBOHHL(this JPIALIKNHCC HMJBLCLPFFF, EBBGNAFIMFG MNPNHJICMND, Allocator DPAKHKILCMF)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AB20", Offset = "0x7E29D20", VA = "0x187E2AB20")]
	public static JCMFEJFBHJF JNMLDLAIEDK(this JPIALIKNHCC HMJBLCLPFFF, EBBGNAFIMFG MNPNHJICMND, Allocator DPAKHKILCMF)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x7E2ACC0", Offset = "0x7E29EC0", VA = "0x187E2ACC0")]
	public static JCMFEJFBHJF LCLLDDDKEIA(this JPIALIKNHCC HMJBLCLPFFF, EBBGNAFIMFG MNPNHJICMND, Allocator DPAKHKILCMF)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AD80", Offset = "0x7E29F80", VA = "0x187E2AD80")]
	public static JCMFEJFBHJF OCIOJLMFHHE(this JPIALIKNHCC HMJBLCLPFFF, EBBGNAFIMFG MNPNHJICMND, Allocator DPAKHKILCMF)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AD00", Offset = "0x7E29F00", VA = "0x187E2AD00")]
	public static JCMFEJFBHJF LNHMOGBJBKM(this JPIALIKNHCC HMJBLCLPFFF, EBBGNAFIMFG MNPNHJICMND, Allocator DPAKHKILCMF)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AC80", Offset = "0x7E29E80", VA = "0x187E2AC80")]
	public static JCMFEJFBHJF KMCANBMFECP(this JPIALIKNHCC HMJBLCLPFFF, EBBGNAFIMFG MNPNHJICMND, Allocator DPAKHKILCMF)
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E2AB60", Offset = "0x7E29D60", VA = "0x187E2AB60")]
	public static JCMFEJFBHJF KMCANBMFECP(this JPIALIKNHCC HMJBLCLPFFF, JCMFEJFBHJF MNPNHJICMND, Allocator DPAKHKILCMF)
	{
		return default(JCMFEJFBHJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MELILGNLOEG
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MHPIEANPOCL KKDDAJHLNCD(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIGEABMCLBP(EBBGNAFIMFG DBENCIIAGPJ, MHPIEANPOCL PMKCOLHCCKK);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BCEEMGCAANN(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KLAELOBODNI(EBBGNAFIMFG DBENCIIAGPJ, bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EFNLAMGBNCO<string> KGLIPJEIMOC(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMJPHFJMBBP(EBBGNAFIMFG DBENCIIAGPJ, EFNLAMGBNCO<string> OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EFNLAMGBNCO<string> IINGGGGMOGK(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIIPNDAIIPO(EBBGNAFIMFG DBENCIIAGPJ, EFNLAMGBNCO<string> OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EFNLAMGBNCO<string> KFLMCKFILKM(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PNGOMNOJHHN(EBBGNAFIMFG DBENCIIAGPJ, EFNLAMGBNCO<string> OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EFNLAMGBNCO<string> HJNIPBIIAGA(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ABFPEHIJGBA(EBBGNAFIMFG DBENCIIAGPJ, EFNLAMGBNCO<string> OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BBNMKKGCGNF(EBBGNAFIMFG DBENCIIAGPJ, EBBGNAFIMFG NLIBDKKPKLB);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CCGDMOADANF
{
	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x7E190D0", Offset = "0x7E182D0", VA = "0x187E190D0", Slot = "0")]
	Task<CJEPKMLCMLN> NFMAOLNKDLK(KPOKEHFKHFL JFJLCELEMGO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "1")]
	void MKBCEDPJKDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NOCNHAAKIII
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event LCPKIBCGPAC.KNAJCDOHBDH PBBFENKMCPJ;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EBBGNAFIMFG JMBNDFCBJBM(EBBGNAFIMFG JPCNHODHEGA);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<EBBGNAFIMFG> POCNEGHGMPB();

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<EBBGNAFIMFG> BEPDENCGLMN(EBBGNAFIMFG FLKKOCNDECC);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BMLNGDNKJOO(EBBGNAFIMFG DHCPIILNCLF, EBBGNAFIMFG CEHGEOEPCCO, [Out] CFAEEBOPCFL LJBFBPMBAOK);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JGOPJKHMMID(EBBGNAFIMFG DHCPIILNCLF, EBBGNAFIMFG JGLIGPGDBBE, [Out] CFAEEBOPCFL LJBFBPMBAOK);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CLPJEJHKMAG(EBBGNAFIMFG DHCPIILNCLF);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FOGAAHLCKCA(EBBGNAFIMFG CLJANGBMFAM, EBBGNAFIMFG DAFAJHDHOLC);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CFAEEBOPCFL JDIPODKKILK(EBBGNAFIMFG MNPNHJICMND);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KFMBDCPEMBA
{
	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	bool LLALGCNMGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	bool CMDBHPNOJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	bool GLLDMCMCBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OJGNHLJAPOC
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HMLLCPDBCMN
{
	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCMJHEGJAFB(EBBGNAFIMFG MNPNHJICMND, OOPJKCMDMCJ MEGAJPAELNI);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GILDDNABAOM(EBBGNAFIMFG MNPNHJICMND, OOPJKCMDMCJ MEGAJPAELNI);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LBKMAPNBIDM
{
	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBNMCFHNKGE([In] float3 JJNJIAILJKL, [In] float3 JBACNGDELHL, float ADBCFFBIBMG, [Out] PPFKIMMDPAK LLOOFEKNKCE, [Out] EBBGNAFIMFG MJAMAMCODKD);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IDGIFKGAKBJ([In] float3 JJNJIAILJKL, float DKGEGBLOEHH, List<EBBGNAFIMFG> IOIHFCOPCJO);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HPHEMPFCPHA(Plane[] OFNKFAIOELL, float3 JJNJIAILJKL, float3 EOMFELMOKKE, quaternion NDOBKEDDJAJ, List<EBBGNAFIMFG> IOIHFCOPCJO);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NLPFECEKCME
{
	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBNMCFHNKGE([In] NativeArray<Entity> HBEMCIPCOAI, [In] float3 JJNJIAILJKL, [In] float3 JBACNGDELHL, [In] NativeArray<PPFKIMMDPAK> MBMJEJBILBN);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> IDGIFKGAKBJ([In] NativeArray<Entity> HBEMCIPCOAI, [In] float3 JJNJIAILJKL, float DKGEGBLOEHH);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> HPHEMPFCPHA([In] NativeArray<Entity> HBEMCIPCOAI, [In] NativeArray<float4> IHBPNGKEDLF);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct AMHHBJOECKH : JHEBGNDPGNA, IEquatable<AMHHBJOECKH>
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public int IJCKDBACFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public int HNJNJKKAINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x2F5C110", Offset = "0x2F5B310", VA = "0x182F5C110", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6E42C20", Offset = "0x6E41E20", VA = "0x186E42C20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x7E18B20", Offset = "0x7E17D20", VA = "0x187E18B20", Slot = "8")]
	public bool Equals(AMHHBJOECKH CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x7E18B70", Offset = "0x7E17D70", VA = "0x187E18B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct PPFKIMMDPAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public float BBDIDNFIGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public float3 BNGNHOGLPHP;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JPOAJNOFHDF
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MIPBFCPKCOJ
{
	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	JKLELGJCNHE KFHDJFHINGL
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<JCMFEJFBHJF, NativeArray<RRObjectPrefabData>> JELDLDJLJPI;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<JCMFEJFBHJF> HBOGJHKKNKD;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JCMFEJFBHJF ICJPKPADFOO();

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IHPINLDMLGD DLLHJKCLEDI(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData GPNMGHIHEAA(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EKMFKFPOGEC(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OGCPECJLBAM MJGCCNHJDCG(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GCIBMHLJOMI(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool POGFCEEOJNO(EBBGNAFIMFG MNPNHJICMND, [Out] Transform JGOMLHGOKKB);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EBBGNAFIMFG AJJEBBHOMBM(DLILJGCOAIF HHOFDEAFCJP);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BHKKEAEHOEL(DLILJGCOAIF HHOFDEAFCJP, [Out] EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DLILJGCOAIF NOAAPKNFAED(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JCMFEJFBHJF AJJEBBHOMBM(NativeArray<DLILJGCOAIF> HHOFDEAFCJP, Allocator DPAKHKILCMF, bool GPMKHLJJEPM = true);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JLFLOJGEOMO(NativeArray<BKIPAKIMEBM> NFBLCBMBHNF, NativeArray<DLILJGCOAIF> MJMIODPCJNK, NativeArray<Entity> GJGEFBJKEDP, EFNLAMGBNCO<DNNLAHBGMBD> CDEAGJOPHBE);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	OGCPECJLBAM KNIKMFAAIBH();

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	OGCPECJLBAM JBKOMICNAJE(RRObjectPrefabData OBMOFEPEPAD, [Optional] DDJGKBBEDKH PJIJELJFMCE);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DBPCCINGKLD OEFLMPCINDJ();

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	GBAGLKGCOGP POIJFJCMCOJ();

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	JDIDLOLPDDJ BMFIEOHADBN(AJCKMHEMCBO GFMCHDEJDIE);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IEOLENJLELI(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool KLOBKCMPIBI(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JCMFEJFBHJF ODICHPMIJIA(JCMFEJFBHJF DADHFNEFFIN, Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool IBDFDDCHHCK(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FFBDACFEIJL(EBBGNAFIMFG MNPNHJICMND, ComponentTypes MLIKFLHJLDP);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "28")]
	EBBGNAFIMFG DJHHKFOKKOM(Transform JGOMLHGOKKB);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class JPJHAEKIFFN
{
	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x7E25C40", Offset = "0x7E24E40", VA = "0x187E25C40")]
	internal static EBBGNAFIMFG OFHDAHFLLBA(this Entity GONFONDIOED, MIPBFCPKCOJ BHGHJPNDBMK)
	{
		return default(EBBGNAFIMFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x7E25860", Offset = "0x7E24A60", VA = "0x187E25860")]
	public static OGCPECJLBAM IGKLAJAADOC(this MIPBFCPKCOJ BHGHJPNDBMK, LocalId MNPNHJICMND)
	{
		return default(OGCPECJLBAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x7E255D0", Offset = "0x7E247D0", VA = "0x187E255D0")]
	public static EBBGNAFIMFG AJJEBBHOMBM(this MIPBFCPKCOJ BHGHJPNDBMK, LocalId MNPNHJICMND)
	{
		return default(EBBGNAFIMFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x7E25BD0", Offset = "0x7E24DD0", VA = "0x187E25BD0")]
	public static DLILJGCOAIF NOAAPKNFAED(this MIPBFCPKCOJ BHGHJPNDBMK, LocalId MNPNHJICMND)
	{
		return default(DLILJGCOAIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x7E25680", Offset = "0x7E24880", VA = "0x187E25680")]
	public static DBPCCINGKLD ALPMOPBHMAP(this MIPBFCPKCOJ BHGHJPNDBMK, RigidTransform HCBKMIBOFFI)
	{
		return default(DBPCCINGKLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x7E25870", Offset = "0x7E24A70", VA = "0x187E25870")]
	public static JDIDLOLPDDJ JFGOPKFOGGK(this MIPBFCPKCOJ BHGHJPNDBMK, AJCKMHEMCBO JHKMGLEBLEB, RigidTransform HCBKMIBOFFI)
	{
		return default(JDIDLOLPDDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x7E25A20", Offset = "0x7E24C20", VA = "0x187E25A20")]
	public static GBAGLKGCOGP NCBNIPJMLIB(this MIPBFCPKCOJ BHGHJPNDBMK, RigidTransform HCBKMIBOFFI)
	{
		return default(GBAGLKGCOGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x7E25830", Offset = "0x7E24A30", VA = "0x187E25830")]
	private static void CFHIDINKDME(OGCPECJLBAM GELDCLGDDGL, RigidTransform HCBKMIBOFFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal interface PCHEDMOHCLA
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JKDAMCDCHNH
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	bool HMCAAOBBEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	EBBGNAFIMFG PEIPOPJBOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	OGCPECJLBAM DHGHBDOJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event MMEMLFIPHHK CEHAFHHIMNN;

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EBBGNAFIMFG ICIOMGHACCI(EBBGNAFIMFG LBPEJPMBIKP, EBBGNAFIMFG NCMKPPNNFPG);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OJKAKCOOMNF(EBBGNAFIMFG LBPEJPMBIKP, EBBGNAFIMFG NCMKPPNNFPG, [Out] EBBGNAFIMFG CGEHOPEKHKJ);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DHCGMNBLFME();

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IOOMOOOPAOP();

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GJAGADLEOIG(EBBGNAFIMFG LBPEJPMBIKP);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IMIGKKDHEJH(EBBGNAFIMFG LBPEJPMBIKP);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public delegate void MMEMLFIPHHK(OGCPECJLBAM DPIKFMEMKGB, OGCPECJLBAM LGNDGAFKNAJ);
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class LMKNMDFKFMF
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7E285C0", Offset = "0x7E277C0", VA = "0x187E285C0")]
	public static bool BPEMBDMINIP(this JKDAMCDCHNH EEOGPBLNKDH, OGCPECJLBAM LBPEJPMBIKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7E28690", Offset = "0x7E27890", VA = "0x187E28690")]
	public static bool GHAIEDKFCMK(this JKDAMCDCHNH EEOGPBLNKDH, EBBGNAFIMFG LBPEJPMBIKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x7E28610", Offset = "0x7E27810", VA = "0x187E28610")]
	public static bool FBELMLGKHDB(this JKDAMCDCHNH EEOGPBLNKDH, EBBGNAFIMFG LBPEJPMBIKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EIILPJKCALH
{
	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHODIOEEOAH(NativeList<RRObjectPrefabData> LPJKHCHCOJM);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DBGJLBCGJDC
{
	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGKMMJJKGEJ(OGCPECJLBAM GELDCLGDDGL, HEGALGDCMOB LHEEKNEOKAD, List<OGCPECJLBAM> MGKDBALIGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LAPPBPEANJO(OGCPECJLBAM GELDCLGDDGL, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNJBMFAEPFC(OGCPECJLBAM GELDCLGDDGL, List<OGCPECJLBAM> MGKDBALIGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NBGADLHAMML(OGCPECJLBAM IMMAKBDNFNI, OGCPECJLBAM LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OGCPECJLBAM BALDPAFGHOM(OGCPECJLBAM IMMAKBDNFNI, int CMDFFDAPDIB, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OIKGHLFKOCO(OGCPECJLBAM IMMAKBDNFNI, OGCPECJLBAM LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FNIFHOEGFMJ(OGCPECJLBAM IMMAKBDNFNI, OGCPECJLBAM LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PMHPHHODDDP(OGCPECJLBAM IMMAKBDNFNI, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FGJOOJKJBCK(OGCPECJLBAM IMMAKBDNFNI, OGCPECJLBAM LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KPPDAHPPMKC(Entity IMMAKBDNFNI, Entity LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GMBDJKFHGGF(Entity IMMAKBDNFNI, HEGALGDCMOB LHEEKNEOKAD);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BFCBKIGFEAL(OGCPECJLBAM LBPEJPMBIKP, HEGALGDCMOB LHEEKNEOKAD);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ONPKACLCBEN
{
	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	FAIDNEBGHKF ELBBLPOEDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEAHLANEAPC FKBODKOKDNN(FAIDNEBGHKF FFNEFMEEJGM);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FAIDNEBGHKF OIACICOILEN();

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FAIDNEBGHKF OEFNMOLJOLH();
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JBHNJIEJDJB
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEMIINOBEGC(EBBGNAFIMFG LBPEJPMBIKP, [Out] EBBGNAFIMFG ENIAIOGCGFD);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GBJODFAGAMG
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIDKPPAHCHM(EBBGNAFIMFG PMOPIAOAEIC, bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMLJGLBMCEH(EBBGNAFIMFG PMOPIAOAEIC, bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFCHAPNJBOK(EBBGNAFIMFG PMOPIAOAEIC, int KJIOHKMJAPE);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OMAOJKPBNDN
{
	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<EBBGNAFIMFG> FJCMHKFCAOB(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EBBGNAFIMFG KMJOAILFPBN(EBBGNAFIMFG MNPNHJICMND, int CMDFFDAPDIB);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GLFOBFBIIAD(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FLHGMAEFHJA JIBAAHDKMBI(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNKANDFMIHD(EBBGNAFIMFG MNPNHJICMND, FLHGMAEFHJA AJLJPILGNIP);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EBBGNAFIMFG HPCPHKDAPEI(EBBGNAFIMFG MNPNHJICMND, [Optional] float3? FICCENLPJEL, [Optional] quaternion? NDOBKEDDJAJ, [Optional] float3? GPOEDAABNAL);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EBBGNAFIMFG EHECIGFAANE(EBBGNAFIMFG MNPNHJICMND, int CMDFFDAPDIB, [Optional] float3? FICCENLPJEL, [Optional] quaternion? NDOBKEDDJAJ, [Optional] float3? GPOEDAABNAL);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OGLEFBFNBKA(EBBGNAFIMFG MNPNHJICMND, int CMDFFDAPDIB);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EPPHAPLCALD(EBBGNAFIMFG MNPNHJICMND);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ILOOIMAGGGA
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DOMBNNPEFED
{
	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	bool IGBMHOOKDND
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJKDDHEJBFK();

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKNKPDCNDDI();

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KILAPPNHJNO();

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABDPDLIFAJM();

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABBCABHFIAI();

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LIFGIPBEOLI();

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KAABFILIKBB();

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IHLLOLBGNAB();

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JMAILAMDKDP();

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IHEPDEKFLGP();

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IFFLOCFDPMJ();

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FFGFEKMDGJD();
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FIJOAGNCNMH
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAKIHFHCDPD(EBBGNAFIMFG LBPEJPMBIKP, [Out] int IMMAKBDNFNI);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLFBNAAOKPP(EBBGNAFIMFG LBPEJPMBIKP, int IMMAKBDNFNI);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDDEGKBOADM(EBBGNAFIMFG LBPEJPMBIKP, bool JLNGFLPNGDF);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LNLEMMPPBLF(EBBGNAFIMFG LBPEJPMBIKP, float FAOMFFCHGGG, float ANBJEGEKPNG, float LKHLDGFEGFF);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CABKADDPOIO(EBBGNAFIMFG MNPNHJICMND, [Out] float ANBJEGEKPNG, [Out] float LKHLDGFEGFF);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DCLDNBHCJAC(EBBGNAFIMFG LBPEJPMBIKP, float3 FICCENLPJEL, quaternion NDOBKEDDJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ILPLELDGOMH(EBBGNAFIMFG LBPEJPMBIKP, [Out] float3 FICCENLPJEL, [Out] quaternion NDOBKEDDJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FNPLDGBMMIN(EBBGNAFIMFG LBPEJPMBIKP);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MLACKGMOCIO
{
	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNOCIFMPDGK(Entity GONFONDIOED, [In] float3 KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 LLCHFPGHHEH(Entity GONFONDIOED);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMMGIHGOPNB(Entity GONFONDIOED, [In] quaternion KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion OADKICMINED(Entity GONFONDIOED);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKHHFOMPJHD(Entity GONFONDIOED, [In] float3 FICCENLPJEL, [In] quaternion NDOBKEDDJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFIBIGALLNH(Entity GONFONDIOED, [Out] RigidTransform KAJHPHBOHBJ);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OIJOLKKGCKO(Entity GONFONDIOED, [In] float3 FICCENLPJEL, [In] quaternion NDOBKEDDJAJ);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LECCEBJJFMA(Entity GONFONDIOED, [Out] float3 FICCENLPJEL, [Out] quaternion NDOBKEDDJAJ);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LECCEBJJFMA(Entity GONFONDIOED, [Out] RigidTransform KAJHPHBOHBJ);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KLDONJHKMCI(Entity GONFONDIOED, float KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float NCMDNBPPPPG(Entity GONFONDIOED);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LEEIIPPGNKG(Entity GONFONDIOED, [In] float3 KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 MMMCBHNMMFO(Entity GONFONDIOED);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PAEHILFIDLF(Entity GONFONDIOED, [In] quaternion KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion MHMDIJDHAAE(Entity GONFONDIOED);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NKGMLOMPLHK(Entity GONFONDIOED, float KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float LKBAGKECBFH(Entity GONFONDIOED);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LILPAEDHOIM(Entity GONFONDIOED, [Out] float4x4 FEOMPHHNKMM);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OHPJOEMJOLM(Entity GONFONDIOED, [In] float4x4 FEOMPHHNKMM);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JOMKINKBALN(Entity GONFONDIOED);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HNHKMEPKNKO(Entity GONFONDIOED, Entity IPGOMKHKGIK, Entity DAFAJHDHOLC);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class MFGDPGGJOAM
{
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DMFEOJCAOCE
{
	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEACHOFEIBH(bool PEMMPDNFBBF);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OMBGIHJLFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IODIKLCAEEJ(EBBGNAFIMFG DBENCIIAGPJ, EFNLAMGBNCO<string> OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCOJOBLOICH(EBBGNAFIMFG DBENCIIAGPJ, EFNLAMGBNCO<string> OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJPJJNNFKLD(EBBGNAFIMFG DBENCIIAGPJ, EFNLAMGBNCO<string> OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALNEPDOADGM(EBBGNAFIMFG DBENCIIAGPJ, EFNLAMGBNCO<string> OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJONKPOOLKB(EBBGNAFIMFG DBENCIIAGPJ, EFNLAMGBNCO<string> OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EHBNBFADIHE(EBBGNAFIMFG DBENCIIAGPJ, EFNLAMGBNCO<string> OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MGFGMAEFIEL(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int BPEKALJFOIK(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int EJMNIHBHJIH(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NKNHMBEFOJB<string> CIGKPAEMKFB(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NPDLNLBOMBK(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NKNHMBEFOJB<string> CEELGPMBKIP(EBBGNAFIMFG DBENCIIAGPJ);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OACPLJPDFGO(EBBGNAFIMFG DBENCIIAGPJ, string BGOPKLLOOIA);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BHGPNAFLLDG(string BGOPKLLOOIA, MGGMGKJEFNC LHIELGELDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EBBGNAFIMFG GBCBPEOAOIO(string BGOPKLLOOIA);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DDOBFIHHDLB(string BGOPKLLOOIA, MGGMGKJEFNC LHIELGELDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ELFJJDFEBPN(EBBGNAFIMFG IILIBLCPPDC, string BGOPKLLOOIA, MGGMGKJEFNC LHIELGELDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NKNHMBEFOJB<string> EPMAODAACBL();
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class GDMBNDOLMPA
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DJMCFBOENOG
{
	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World PMHGKMLIBDA(string LHEBHEJDPOB = "Main");

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World IHMDABBMBGI(string LHEBHEJDPOB = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World IBKIMKFPALC(string LHEBHEJDPOB = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World DMHCBOABJJL(string LHEBHEJDPOB = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LANOECBBLFB
{
	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	World PNOMKFCBDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	World HIDBMGOJALD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	EntityManager EPHJNECDEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	bool CFMEGCKFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase GHPLNJDJMJK(Type GDHKDBJPDLG);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public static class EBMGGJHFCIC
{
	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C5D0", Offset = "0x7E1B7D0", VA = "0x187E1C5D0")]
	public static ComponentSystemBase GPPHMPIIGDA(this World AFDKGPIKPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x3883400", Offset = "0x3882600", VA = "0x183883400")]
	public static T GHPLNJDJMJK<T>(this LANOECBBLFB NIPPOPBBFAB) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CMGFKIJJDDA
{
	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPHGKHKBLIN(NativeListAsync<Entity> JBKMHGMMFLG);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDPIEPFMPLA(FBIMDJLIBNC BJPKIBFILOM);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCFCOGHOPLI(NativeListAsync<Entity> HALLGFCGICD, bool DCFIEIBGBID);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KGDCFGOAKMO();

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NAOMAFCKCFC(Entity OLEJNEHCCLF);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface POCMMAPPNJI
{
	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBMOBKGKPJN(Collider GNJLDOJGEEN, [Out] MKAKBJIMMNG OBDJCKHNHJK);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OLMPGIEFJML
{
	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider CIIGMEJLFOB(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject OLGFGBCNKDO(EBBGNAFIMFG PEEAJPJKJKA, GameObject IJDBKPEJDOI, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPJCBDADAMJ(GameObject GNJLDOJGEEN);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider OKBEDPHMCEA<TCollider>(GameObject IKPIIEOHDJC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JMFEGBKFLNI(Collider GNJLDOJGEEN);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DMPIJFLDPHC<TCollider>(string GBOCGPJOEEK) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AOCFFLDGBKH CEGDGNGEKCJ(EBBGNAFIMFG DMIKBDFJNOA, EBBGNAFIMFG CEFLGLBLELJ, AJCKMHEMCBO CNBONLKOBAE, float3 HKCILKKJFOM, quaternion KKNPLGDLBJB, float3 OJKDLNLPBGA);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NLFHDKFFFIP(EBBGNAFIMFG MNPNHJICMND, [Out] AOCFFLDGBKH GNJLDOJGEEN);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HFMEJGMMGCJ(EBBGNAFIMFG MNPNHJICMND, [Out] EBBGNAFIMFG OLEJNEHCCLF);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public enum OHCHAPDFNEK
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface INAOMOHBGFI
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public struct LEMLGEHIJLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int CNBONLKOBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public GameObject IJDBKPEJDOI;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOIHEGIHAOJ(EBBGNAFIMFG MNPNHJICMND, NOFKHNNLBFH OPMBLHIGABL, bool BIJCEIKDPFL, JMAPILMLMLJ PEJLBFNHGCI);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCGPBBFDOPE(EBBGNAFIMFG MNPNHJICMND, NOFKHNNLBFH OPMBLHIGABL, bool BIJCEIKDPFL, bool GCADNBEDHIB, bool HCIPLMCDIDC);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PMGGNLKKOFA IPNEKNFMDIJ(EBBGNAFIMFG OLEJNEHCCLF, List<EBBGNAFIMFG> HPCOHHEKOPH);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AOCFFLDGBKH OHLACOAGINA(GameObject KDPHGLDBLKL, GameObject NGLDECGHDHI);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHLEPLEPENF(GameObject KDPHGLDBLKL, List<GameObject> DADJELCNIHM);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNIIAJKDFND(GameObject NGLDECGHDHI);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T OKBEDPHMCEA<T>(GameObject IKPIIEOHDJC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JMFEGBKFLNI(Collider GNJLDOJGEEN);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject CIKKDMMLEEA<T>(string GBOCGPJOEEK) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BNKINBJDMNM(Collider GNJLDOJGEEN, [Out] EBBGNAFIMFG IMMAKBDNFNI);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JCMBHNAKCHF(EBBGNAFIMFG MNPNHJICMND, [Out] MKAKBJIMMNG OBDJCKHNHJK);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<OHCHAPDFNEK> LLAMEJEKDJE(Allocator DPAKHKILCMF = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] GJJKKAABKAO();
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DANOBJJICOF
{
	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBPGDPFHMMN(EBBGNAFIMFG MNPNHJICMND, EBBGNAFIMFG KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMNGHOIELBP(EBBGNAFIMFG MNPNHJICMND, EBBGNAFIMFG KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int MGMNBIPABPM(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EBBGNAFIMFG HAGMMKGFPCK(EBBGNAFIMFG MNPNHJICMND, int CMDFFDAPDIB);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JCMFEJFBHJF DENINHOKHDP(EBBGNAFIMFG MNPNHJICMND, Allocator DPAKHKILCMF = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POOKOCCOCLB(EBBGNAFIMFG MNPNHJICMND, object CCLFNPCGNED, EBBGNAFIMFG KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MEPHBBCDEKE(EBBGNAFIMFG MNPNHJICMND, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FMIKNBKGDOB(EBBGNAFIMFG MNPNHJICMND, [Out] EBBGNAFIMFG KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMPKPPEIFIN(EBBGNAFIMFG MNPNHJICMND, float3 KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool COICELAKAMH(EBBGNAFIMFG MNPNHJICMND, [Out] float3 KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IFEOOABEFLM(EBBGNAFIMFG MNPNHJICMND, float3 KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JKCNJJIGEGB(EBBGNAFIMFG MNPNHJICMND, [Out] float3 KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LEJDANOCHIN(EBBGNAFIMFG MNPNHJICMND, (Quaternion rot, Vector3 moments) PLBDLBHPJFE);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JBBPFIHFOIM(EBBGNAFIMFG MNPNHJICMND, [Out] quaternion DIFHEMCKFDL, [Out] float3 IGJIOHHINAL);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AANMOLFBCOO(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 PCPCDICFOOJ(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 OMPMHGEPMLB(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HEIMCLLIJDM(EBBGNAFIMFG MNPNHJICMND, float3 KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FHBPMGBCGHO(EBBGNAFIMFG MNPNHJICMND, float3 KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float LFOEKBJCIOH(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float NLKKBIOOMKE(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NEMGBBHIJJP(EBBGNAFIMFG MNPNHJICMND, float KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IBANPJEKIML(EBBGNAFIMFG MNPNHJICMND, float KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode ONDPGHJFFEB(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MAPNMFHMAKK(EBBGNAFIMFG MNPNHJICMND, CollisionDetectionMode KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CMFBMPLFPMI JCCPEBNOEFG(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GOPKIHKPHFD(EBBGNAFIMFG MNPNHJICMND, CMFBMPLFPMI KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DNBCKDJOJBL(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KCLNPIIGADM(EBBGNAFIMFG MNPNHJICMND, bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "29")]
	EBBGNAFIMFG KGINEHONNLE(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OCHIDPACBEO(EBBGNAFIMFG MNPNHJICMND, EBBGNAFIMFG KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "31")]
	EBBGNAFIMFG JMBNDFCBJBM(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KMHANLPIIHA(EBBGNAFIMFG MNPNHJICMND, EBBGNAFIMFG KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "33")]
	JOHOKOFPFMP HAHLBFENEOB(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void GJNACJMIDCM(EBBGNAFIMFG MNPNHJICMND, JOHOKOFPFMP OJDGNKGODEN);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool OEGPMJPKMFF(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void PNHIPEOPMFO(EBBGNAFIMFG MNPNHJICMND, bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool FAHGBEJGFFA(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JNFEOJFLPKE(EBBGNAFIMFG MNPNHJICMND, bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints NBLJOFPCHHJ(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void JENFADJMCME(EBBGNAFIMFG MNPNHJICMND, RigidbodyConstraints KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float GLNOHJKPMDD(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void AFNEKJCPJMG(EBBGNAFIMFG MNPNHJICMND, float KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float JOKBGHIMENI(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void LOGOHPPEGCP(EBBGNAFIMFG MNPNHJICMND, float KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool FNFMEJGCECO(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void BDAPKMOGAFA(EBBGNAFIMFG MNPNHJICMND, bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool OIBINIKHEID(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void PGMAOMAFLMN(EBBGNAFIMFG MNPNHJICMND, bool KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void AMHIIGKMICN(EBBGNAFIMFG MNPNHJICMND, int KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "50")]
	AMBDNINENEN JIPPIHHMOHC(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void IBOIIJHLIDI(EBBGNAFIMFG MNPNHJICMND, AMBDNINENEN KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "52")]
	ICKNPKALBAM KIOCJOCHAOL(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void HJLMFAJHIDM(EBBGNAFIMFG MNPNHJICMND, ICKNPKALBAM KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float NIIJLHOKKDL(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void EKGHOKOJHHE(EBBGNAFIMFG MNPNHJICMND, float KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void FAPDGGJJNPE(EBBGNAFIMFG MNPNHJICMND, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void KGFKFNGIHKG(EBBGNAFIMFG MNPNHJICMND, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool LFOHLGDBPFG(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void IEDOBFHJBHL(EBBGNAFIMFG MNPNHJICMND, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void MKDJHGLDLLO(EBBGNAFIMFG MNPNHJICMND, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool PNEBOIBILFG(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool OJAEGHHALHM(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody OLOHLJGMDAF(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void CPOEJCABONE(EBBGNAFIMFG MNPNHJICMND, Rigidbody CCNFPPEFCMI);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void JNGNFEOJBBF(EBBGNAFIMFG MNPNHJICMND, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void JADKGBEPFDN(EBBGNAFIMFG MNPNHJICMND, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool CJKOPKPNEFC(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void IBGELDLALJA(EBBGNAFIMFG MNPNHJICMND, float3 AJNMLFPKEJH);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void LPKKDFLNKBL(EBBGNAFIMFG MNPNHJICMND, float3 MKIIBLHCBDM);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool NNKCDMDLCLO(EBBGNAFIMFG MNPNHJICMND, [Out] float3 AJNMLFPKEJH);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool PCPPPCMIJFP(EBBGNAFIMFG MNPNHJICMND, [Out] float3 MKIIBLHCBDM);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool JNAFLDCOEOM(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void AFAJGKOACFB(EBBGNAFIMFG MNPNHJICMND, object CCLFNPCGNED, bool JEHOOBEDLAD);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void MDMCMPHFEKB(EBBGNAFIMFG MNPNHJICMND, bool OKMBMIJGPHF);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void IIDBBNMHLLB(EBBGNAFIMFG MNPNHJICMND);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool IBCNNFCNMHO(EBBGNAFIMFG MNPNHJICMND);
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EMIDEIIGOOC
{
	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAPMLMCEBOM(Entity EPIKFCNDCLG);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEELONGNEHG(Entity EPIKFCNDCLG);

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAKFGGNPGBK(Entity EPIKFCNDCLG);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KDFJNMOPGNM
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OODFNCPDPPG(EBBGNAFIMFG LBPEJPMBIKP, bool FCIHABEMOFP);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public delegate void MCKAKNHIDHA(HBHPHBBJEBO JFMFIGOCNDM);
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public readonly ref struct HBHPHBBJEBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly JCMFEJFBHJF JNFHOBPPFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly NativeArray<byte> MKLGNKECLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly NativeArray<byte> PPABCIAKENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly OOPJKCMDMCJ MEGAJPAELNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly int FAOHBLDKBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Type JOMCMDJHLPB;

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public JCMFEJFBHJF BBIBBEPBIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x51CF3D0", Offset = "0x51CE5D0", VA = "0x1851CF3D0")]
		get
		{
			return default(JCMFEJFBHJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public int PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x7E20F40", Offset = "0x7E20140", VA = "0x187E20F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public OOPJKCMDMCJ DJMDDAMJOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7E0", Offset = "0xA1E9E0", VA = "0x180A1F7E0")]
		get
		{
			return default(OOPJKCMDMCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x7E20F60", Offset = "0x7E20160", VA = "0x187E20F60")]
	public HBHPHBBJEBO(JCMFEJFBHJF JNFHOBPPFBA, NativeArray<byte> MKLGNKECLPO, NativeArray<byte> PPABCIAKENC, OOPJKCMDMCJ MEGAJPAELNI, int FAOHBLDKBMK, Type JOMCMDJHLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x3A19C70", Offset = "0x3A18E70", VA = "0x183A19C70")]
	public NativeArray<T> EJJKPFFEGMA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x3A19CB0", Offset = "0x3A18EB0", VA = "0x183A19CB0")]
	public NativeArray<T> ENODLOLMENB<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x3A19B80", Offset = "0x3A18D80", VA = "0x183A19B80")]
	public (JCMFEJFBHJF, NativeArray<T>, NativeArray<T>) AFHCIICHJIO<T>() where T : struct
	{
		return default((JCMFEJFBHJF, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x7E20F10", Offset = "0x7E20110", VA = "0x187E20F10")]
	public GDOHBJIIFEE BHELNLIOBOE()
	{
		return default(GDOHBJIIFEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface NHCMEGKMCMK
{
	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	string DPFIKOMILHK
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	NHCMEGKMCMK DDKGHLMAACG
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	IEnumerable<NHCMEGKMCMK> MEFGJLFCLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EJGCKAHLIPM
{
	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	NHCMEGKMCMK CPJEHGJKJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	NativeArray<OOPJKCMDMCJ> FJACGAKHDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FNMILPMKACD(OOPJKCMDMCJ MEGAJPAELNI, [Out] NHCMEGKMCMK IMLPAHMDDDJ);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELDCOJNOKAJ(OOPJKCMDMCJ MEGAJPAELNI, MCKAKNHIDHA CCGFDBGMPOL);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNBGJFEBNND(OOPJKCMDMCJ MEGAJPAELNI, MCKAKNHIDHA CCGFDBGMPOL);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KLPOLOEEFJF
{
	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELDCOJNOKAJ(OOPJKCMDMCJ MEGAJPAELNI, MCKAKNHIDHA CCGFDBGMPOL);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNBGJFEBNND(OOPJKCMDMCJ MEGAJPAELNI, MCKAKNHIDHA CCGFDBGMPOL);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public static class MBGIMOJLBJM
{
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KPJGFGIGDHN
{
	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	bool JMMMGDOOOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	KBEPLBOCJCN GMOGICEMHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFPFEFAAEGB(CEAHLANEAPC HHOFDEAFCJP, bool PMHEDLJKGJM);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JMCKFPDLIPH(DLILJGCOAIF HHOFDEAFCJP, OOPJKCMDMCJ MEGAJPAELNI);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DMBKAGPEKLL(NativeArray<DLILJGCOAIF> DKIAFIFHOIC);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class INGJBCBEEOB
{
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public readonly ref struct GDOHBJIIFEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly HBHPHBBJEBO CAIGHLKIDBF;

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public JCMFEJFBHJF BBIBBEPBIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x51CF3D0", Offset = "0x51CE5D0", VA = "0x1851CF3D0")]
		get
		{
			return default(JCMFEJFBHJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x7E20CC0", Offset = "0x7E1FEC0", VA = "0x187E20CC0")]
	public GDOHBJIIFEE(HBHPHBBJEBO CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x7E20A60", Offset = "0x7E1FC60", VA = "0x187E20A60")]
	public JCMFEJFBHJF EJJKPFFEGMA()
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x7E20B90", Offset = "0x7E1FD90", VA = "0x187E20B90")]
	public JCMFEJFBHJF ENODLOLMENB()
	{
		return default(JCMFEJFBHJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x7E20770", Offset = "0x7E1F970", VA = "0x187E20770")]
	public (JCMFEJFBHJF, JCMFEJFBHJF, JCMFEJFBHJF) AFHCIICHJIO()
	{
		return default((JCMFEJFBHJF, JCMFEJFBHJF, JCMFEJFBHJF));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class LOGNFADAPEG
{
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public readonly struct KBEPLBOCJCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly NativeBitArray NANBINMDFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly NativeParallelHashMap<DLILJGCOAIF, int> NEKENMIDBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly NativeParallelHashSet<CEAHLANEAPC> LMHEBLEOLIP;

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public bool HNGFALOPKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x7E25D20", Offset = "0x7E24F20", VA = "0x187E25D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public bool JMMMGDOOOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7E25CF0", Offset = "0x7E24EF0", VA = "0x187E25CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF820", Offset = "0x5CBEA20", VA = "0x185CBF820")]
	public KBEPLBOCJCN(NativeBitArray NANBINMDFHK, NativeParallelHashMap<DLILJGCOAIF, int> NEKENMIDBDH, NativeParallelHashSet<CEAHLANEAPC> LMHEBLEOLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x7E25D40", Offset = "0x7E24F40", VA = "0x187E25D40")]
	public bool JMCKFPDLIPH(DLILJGCOAIF HHOFDEAFCJP, OOPJKCMDMCJ MEGAJPAELNI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DCDAGLEECEJ
{
	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	CHMGPECIKJJ EMPPGDEDAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ILGGNHIGLIB
{
	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCANLDFLAOH(EBBGNAFIMFG MNPNHJICMND, COFGDNEKJBL KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GPGLHFGDHFI LNAIGLCEHAH();
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ODDPDOHMGMG
{
	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMNNCGBMGGE(World AFDKGPIKPNA);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDPFALEGOBJ(World AFDKGPIKPNA);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase BJMMGNEKHBP(World AFDKGPIKPNA);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMIFEFJBMLJ(World AFDKGPIKPNA);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADCBPDFFIMD(World AFDKGPIKPNA);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CNEEBMKLCAP(World AFDKGPIKPNA);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBFDPJNGOHL(World AFDKGPIKPNA);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> MPIPGGOFGAH();
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MMPJOBLMANL
{
	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPDAMFIIMJJ(EBBGNAFIMFG PMOPIAOAEIC, bool KJIOHKMJAPE);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public readonly struct NKEDKNABEDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly IEnumerable<FLNOOMHNJFH> FLJIMAANFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly IReadOnlyList<GameObject> MJAIAIFIFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly IReadOnlyList<int> DNEPGKMEDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly IReadOnlyList<(DLILJGCOAIF, DLILJGCOAIF)> GGKOPLLDPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int OKPFLBAGEFG;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct KGFBPGDGCLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public InventionIdData APBCLGNDGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public InventionInstanceIdData FBECHAPLEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool LHNIMCCDMOH;

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x7E261C0", Offset = "0x7E253C0", VA = "0x187E261C0")]
	public KGFBPGDGCLO(long APBCLGNDGBE, Guid FBECHAPLEEB, bool LHNIMCCDMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.Application)]
public interface DNBBFJFDFKD
{
	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJEPKMLCMLN IKIMKENHMNL(KPOKEHFKHFL EKAOAIAIJGD, int KIGKPDMJBNM = 0, bool JBIKMJPCOEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EFHJPDPFDHE JEJDPBHIKHO(KPOKEHFKHFL EKAOAIAIJGD, EBBGNAFIMFG FLKKOCNDECC, [In] UniformTRS CGJOAHKHPCA, JJFPNJBPBIP EAMJGKMAAPM, [Optional] KGFBPGDGCLO PAHHOABOJKN, bool DPBEFJGKJFI = true, bool JEFEDFKKLIK = false, bool JBIKMJPCOEM = false, bool EIFBPJHHPEG = false);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KAFGIFPICBF JHDKDGFBCCJ();

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KAFGIFPICBF MHMOLNELLMC(JCMFEJFBHJF IOIHFCOPCJO, [In] UniformTRS LEKNHMBILMM, [Optional] JJFPNJBPBIP FKLBKFOHFPO);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DBEHNFMJBJO(EBBGNAFIMFG ICDDNIPPIHM);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FGPKCCAKODG(EBBGNAFIMFG ICDDNIPPIHM, [Out] Exception JLAMGOGLIAG);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<DLILJGCOAIF> NINAEKNINCM(EBBGNAFIMFG ICDDNIPPIHM, Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<DLILJGCOAIF> KNKENDNJHKD(EBBGNAFIMFG ICDDNIPPIHM, Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JCMFEJFBHJF EDAMHAAHINI(EBBGNAFIMFG ICDDNIPPIHM, Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JCMFEJFBHJF OEHNFOAMJHH(EBBGNAFIMFG ICDDNIPPIHM, Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JCMFEJFBHJF KOEOJAMDFKK(EBBGNAFIMFG ICDDNIPPIHM, Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> OJDOKEGNAJB(EBBGNAFIMFG ICDDNIPPIHM, Allocator DPAKHKILCMF);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OEEHADKGEDA(EBBGNAFIMFG ICDDNIPPIHM);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int MPABLEBOLEB(EBBGNAFIMFG ICDDNIPPIHM, int OCEHNHGKKJH);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.Application)]
public interface IAHBNPJKIPC
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0xE50280", Offset = "0xE4F480", VA = "0x180E50280", Slot = "0")]
	bool GHMCGLNMJHJ(object ODLIDIMANGE, NDKAIJEIFHC IKDCGGBMFBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class NPLPLOJEMHF
{
	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A6B0", Offset = "0x7E298B0", VA = "0x187E2A6B0")]
	public static bool GHMCGLNMJHJ(this IAHBNPJKIPC HMJBLCLPFFF, object ODLIDIMANGE, [Out] NDKAIJEIFHC IKDCGGBMFBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public enum JAPOGGMHFHA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface NDKAIJEIFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	BBMDKGLDILO BGLOFMKFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	NPGIOFFINPJ MJAAKMGHDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	bool DALEPDCEKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	bool LMFDBCJGIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object JFCAPMACHDA();

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0xF76C50", Offset = "0xF75E50", VA = "0x180F76C50", Slot = "5")]
	(NPGIOFFINPJ, Dictionary<object, object>) IOIFPPILDFF()
	{
		return default((NPGIOFFINPJ, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "6")]
	(DLILJGCOAIF, NPGIOFFINPJ) BDJAKEGIPJD()
	{
		return default((DLILJGCOAIF, NPGIOFFINPJ));
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "7")]
	DJOPNIMGMHK<(DLILJGCOAIF, NPGIOFFINPJ)> DDBDOFJCEHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0xF76C50", Offset = "0xF75E50", VA = "0x180F76C50", Slot = "8")]
	(GGJDLMJHNMI, byte[]) FLLHAOCGIJE()
	{
		return default((GGJDLMJHNMI, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0xF76C50", Offset = "0xF75E50", VA = "0x180F76C50", Slot = "9")]
	(NJEOJBANFID, byte[]) KFMEBIJHGPD()
	{
		return default((NJEOJBANFID, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0xF76C50", Offset = "0xF75E50", VA = "0x180F76C50", Slot = "10")]
	T FNOJKDEGIOC<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class LNFDEONBPIC
{
	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x7E289E0", Offset = "0x7E27BE0", VA = "0x187E289E0")]
	public static bool MDDINOMNFLJ(this NDKAIJEIFHC HEAHMHOMOPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface BKHLGMOPCJA : DJOPNIMGMHK<DPGDOGEFGCI>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[DefaultMember("Item")]
public interface DJOPNIMGMHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	T HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	int PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public enum BBMDKGLDILO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_JoinRequest = 100,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_JoinResponse = 101,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RR_RoomUpdate = 102,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_PlayerUpdate = 103,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RR_RemotePlayerJoined = 104,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RR_RemotePlayerLeft = 105,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_Leave = 106,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public enum GGJDLMJHNMI : uint
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class EBIEFJOMONM
{
	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C300", Offset = "0x7E1B500", VA = "0x187E1C300")]
	public static DLILJGCOAIF MPKCBAKCMIG(this BAAGKDAJDCP CAIGHLKIDBF)
	{
		return default(DLILJGCOAIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C2B0", Offset = "0x7E1B4B0", VA = "0x187E1C2B0")]
	public static DLILJGCOAIF DMEKCLGKIMH([In] this BAAGKDAJDCP CAIGHLKIDBF)
	{
		return default(DLILJGCOAIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x7DA7030", Offset = "0x7DA6230", VA = "0x187DA7030")]
	public static DLILJGCOAIF PNBMFKMKDLJ(this BAAGKDAJDCP CAIGHLKIDBF)
	{
		return default(DLILJGCOAIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x7DA7030", Offset = "0x7DA6230", VA = "0x187DA7030")]
	public static ViewId IFJLJIAOJGH(this BAAGKDAJDCP CAIGHLKIDBF)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C0E0", Offset = "0x7E1B2E0", VA = "0x187E1C0E0")]
	public static FixedString64Bytes DDIKDMGANPA(this CEAHLANEAPC APBCLGNDGBE)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C340", Offset = "0x7E1B540", VA = "0x187E1C340")]
	public static FixedString64Bytes NCLFMBEAAGP(this DLILJGCOAIF APBCLGNDGBE)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C050", Offset = "0x7E1B250", VA = "0x187E1C050")]
	public static FixedString32Bytes DDIKDMGANPA(this Entity GONFONDIOED)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ELNJBDLJHHA : CGHCLGPOONK
{
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public enum HAGNLPLFHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ANPMBCBECMN
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<object> ELEKHDGOLGE;

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "2")]
	void NEBDADNJKOB(object ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "3")]
	void JKAEDGCMMHB(NJEOJBANFID MLMPPNLIAEF, ReadOnlySpan<byte> EKFBEBELGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	void LIKNNBCDKFC(GGJDLMJHNMI GDHKDBJPDLG, ReadOnlySpan<byte> EKFBEBELGHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LDOMEFKDBMC
{
	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NJEOJBANFID AALPLBFJNPE(ReadOnlySpan<byte> EKFBEBELGHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CFHLMCFDONL
{
	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMEHBFDLFEG(NJEOJBANFID MHDODBCCAJB, ReadOnlySpan<byte> EKFBEBELGHJ);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHBPCOIFKBG(ReadOnlySpan<NJEOJBANFID> CDEBEBBKNGP);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct OKHDCFCEBFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NJEOJBANFID MLMPPNLIAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public ReadOnlyMemory<byte> EKFBEBELGHJ;
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public struct NJEOJBANFID
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static NJEOJBANFID FNMCNHBINAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public CEAHLANEAPC HAPPMEIKPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public int IJCLKCJDNBO;

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	public static CEAHLANEAPC CCGLCOBIFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A4A0", Offset = "0x7E296A0", VA = "0x187E2A4A0")]
		get
		{
			return default(CEAHLANEAPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x51CEE70", Offset = "0x51CE070", VA = "0x1851CEE70")]
	public NJEOJBANFID(CEAHLANEAPC HAPPMEIKPMA, int IJCLKCJDNBO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A2A0", Offset = "0x7E294A0", VA = "0x187E2A2A0")]
	public static bool EEDHALGLIEL([In] NJEOJBANFID LNELGBOPHHN, [In] NJEOJBANFID CKNMBJOIDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A330", Offset = "0x7E29530", VA = "0x187E2A330", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A440", Offset = "0x7E29640", VA = "0x187E2A440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A500", Offset = "0x7E29700", VA = "0x187E2A500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A4F0", Offset = "0x7E296F0", VA = "0x187E2A4F0")]
	public void PCEFEHILDBC([Out] CEAHLANEAPC JFOBNAKMELF, [Out] int IJCLKCJDNBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class ELIPLPPKEBN
{
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct FLNOOMHNJFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Guid DJOIAEMCFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public string FNBPEJBPIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Vector3 FICCENLPJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Quaternion NDOBKEDDJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Vector3 GPOEDAABNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public int DIGBJLFHPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public DDJGKBBEDKH AJLJPILGNIP;

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DAA0", Offset = "0x7E1CCA0", VA = "0x187E1DAA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public enum BLAFPCIDOOA
{
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class MKKKLLKKGCP
{
	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x7E29E90", Offset = "0x7E29090", VA = "0x187E29E90")]
	public static bool DKJIJAMPPCD(this BLAFPCIDOOA GDHKDBJPDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x7E29EC0", Offset = "0x7E290C0", VA = "0x187E29EC0")]
	public static bool MMLLFMFNLEN(this BLAFPCIDOOA GDHKDBJPDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x7E29EB0", Offset = "0x7E290B0", VA = "0x187E29EB0")]
	public static bool EEJHDNJJAFN(this BLAFPCIDOOA GDHKDBJPDLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[Flags]
public enum JNDHCIJCDED
{
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public interface JJFPNJBPBIP
{
	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKLJMCGLEMB([In] Guid LMDCFNDMKMH, [Out] Guid MCOCJMBCCJG);
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[Flags]
public enum HFJAGDDEGOI
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface KAFGIFPICBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	IIMJJNKBLNI HKLGMDEDCPP
	{
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString NNCBIFPMGAG();
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public enum NFJMEABDMEN
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct DOJNALPHLNL : ISystemStateComponentData, IComponentData, IEquatable<DOJNALPHLNL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public float3 IMEAKGLMLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public float3 JEPAAEOIJLA;

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B6A0", Offset = "0x7E1A8A0", VA = "0x187E1B6A0", Slot = "4")]
	public bool Equals(DOJNALPHLNL CMOCFNBHPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NJBMJEMIPPO
{
	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KALNHFACMOM(long GENJIKHAHJC);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADOAHNDAFLD(NativeParallelHashSet<long> HOEGNCPJGOH);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGKILFIPBKI(World AFDKGPIKPNA, NativeParallelHashMap<Guid, long> MAAHDIIGPBA);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FMJEIMEBLLI(DLILJGCOAIF HHOFDEAFCJP);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KLCNCPFAOMM(DLILJGCOAIF HHOFDEAFCJP, [Out] Guid JIONDDPAHJP, [Out] long GENJIKHAHJC);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POJIBMOOLBI(DLILJGCOAIF HHOFDEAFCJP, Guid JIONDDPAHJP, long GENJIKHAHJC);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LAMNMFJAFFE(Guid JIONDDPAHJP);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BCIFCLPBIDA(Guid JIONDDPAHJP, [Out] int KDGOCOIGNMH, [Out] int PPAIDIFMFCI);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PFHGHBNFPMP(Guid JIONDDPAHJP, int KDGOCOIGNMH, int PPAIDIFMFCI);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EBJIEJAGNJI(Guid JIONDDPAHJP);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class JIMOOFOMAIG
{
	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JIMOOFOMAIG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
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
