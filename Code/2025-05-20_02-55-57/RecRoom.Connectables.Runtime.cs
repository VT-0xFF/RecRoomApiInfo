using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.ObjectModel;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9100", Offset = "0x7BC8300", VA = "0x187BC9100", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB7C0", Offset = "0x7BCA9C0", VA = "0x187BCB7C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB320", Offset = "0x7BCA520", VA = "0x187BCB320")]
		private void NDIKJDPGAHM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB1B0", Offset = "0x7BCA3B0", VA = "0x187BCB1B0")]
		private void BKLJKGOJGMF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB490", Offset = "0x7BCA690", VA = "0x187BCB490", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB800", Offset = "0x7BCAA00", VA = "0x187BCB800")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class LEPBKMNADAN : KHPMJGOPOBA, AOOLNAMPIBN
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MKHCAFEBEKG : IEnumerable<HOFKHCMGAOH>, IEnumerable, IEnumerator<HOFKHCMGAOH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private HOFKHCMGAOH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private HAONCNNABLP localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public HAONCNNABLP <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public LEPBKMNADAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IPHDOCEGNCL <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private AIKGNMJNLMB <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private AIKGNMJNLMB.HGLDAILFKHN <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HOFKHCMGAOH System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public MKHCAFEBEKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BCAB00", Offset = "0x7BC9D00", VA = "0x187BCAB00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA6A0", Offset = "0x7BC98A0", VA = "0x187BCA6A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA660", Offset = "0x7BC9860", VA = "0x187BCA660")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA680", Offset = "0x7BC9880", VA = "0x187BCA680")]
		private void GCCIFBPGOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BCAAB0", Offset = "0x7BC9CB0", VA = "0x187BCAAB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7BCAA00", Offset = "0x7BC9C00", VA = "0x187BCAA00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HOFKHCMGAOH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BCAA00", Offset = "0x7BC9C00", VA = "0x187BCAA00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MHJFJFHENEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LEPBKMNADAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public KKLPCIGPLCO nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MHJFJFHENEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9CB0", Offset = "0x7BC8EB0", VA = "0x187BC9CB0")]
		internal object AIKDIJMBBLP(KKLPCIGPLCO x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CLPOACAGEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KKLPCIGPLCO child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MHJFJFHENEJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CLPOACAGEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBAC30", Offset = "0x7BB9E30", VA = "0x187BBAC30")]
		internal object DEIGDHDBAHB((KKLPCIGPLCO child, KKLPCIGPLCO nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly FODGIOKBGBI NNAAJNGHPLN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly FODGIOKBGBI OAHJJDAEBPC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly FODGIOKBGBI HGIPCBHCAFJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly FODGIOKBGBI MHOMAFDLFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PIDMLFLMPKJ PEGFOGJLNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FNKGGFNAPJH PGJKOLBGJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private EDLCJCKFFCD OKGGHLOIPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private JLLAKILHOPP OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private BCOLMCEKFDN IKLABGOFMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MJNIFJDKDCD KIFDPLFPBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly IDGKAHHDFEE JIHODFEAJIC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GLGAHOJADMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D80", Offset = "0x9F5F80", VA = "0x1809F6D80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D60", Offset = "0x9F5F60", VA = "0x1809F6D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FFKHDJLNAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<HOFKHCMGAOH, HOFKHCMGAOH> BGMOHNNMMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8610", Offset = "0x7BC7810", VA = "0x187BC8610", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC45D0", Offset = "0x7BC37D0", VA = "0x187BC45D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<HOFKHCMGAOH, HOFKHCMGAOH> AAEICLNMKFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5740", Offset = "0x7BC4940", VA = "0x187BC5740", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6340", Offset = "0x7BC5540", VA = "0x187BC6340", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<HOFKHCMGAOH, HOFKHCMGAOH, HOFKHCMGAOH> IKHILOFFDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5B40", Offset = "0x7BC4D40", VA = "0x187BC5B40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4320", Offset = "0x7BC3520", VA = "0x187BC4320", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8880", Offset = "0x7BC7A80", VA = "0x187BC8880")]
	public LEPBKMNADAN(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5D80", Offset = "0x7BC4F80", VA = "0x187BC5D80", Slot = "12")]
	public void ILLMBOBOELN(GameObject GNOLFLMODHC, ABPOKIIIBLP JJBICEGPACG, FCJMGEEKKCC NEGFBCIAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BC46F0", Offset = "0x7BC38F0", VA = "0x187BC46F0", Slot = "26")]
	public void EFOAOCGHIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BC42D0", Offset = "0x7BC34D0", VA = "0x187BC42D0", Slot = "22")]
	public bool BCKGEJPAMKI(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BC43D0", Offset = "0x7BC35D0", VA = "0x187BC43D0")]
	private void DBCBHGKGFNA(HAONCNNABLP JBMAABNOLNF, HAONCNNABLP AMCLMEHBLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BC64E0", Offset = "0x7BC56E0", VA = "0x187BC64E0")]
	private void KJAFPMFIFOP(HAONCNNABLP JBMAABNOLNF, HAONCNNABLP MEOFNDCDMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BC60E0", Offset = "0x7BC52E0", VA = "0x187BC60E0")]
	private void JJGDBMKOPIA(HAONCNNABLP JBMAABNOLNF, HAONCNNABLP MEOFNDCDMCD, HAONCNNABLP AMCLMEHBLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BC48E0", Offset = "0x7BC3AE0", VA = "0x187BC48E0")]
	private void EOGCANBJDDH(HAONCNNABLP JBMAABNOLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "13")]
	public void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8210", Offset = "0x7BC7410", VA = "0x187BC8210", Slot = "14")]
	public void OOCHIMKFMHO(HOFKHCMGAOH KKKHMJMHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "15")]
	public void DDBNGFDLKBA(HOFKHCMGAOH KKKHMJMHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C10", Offset = "0x7BC6E10", VA = "0x187BC7C10", Slot = "17")]
	public void NPDCIKOFJLJ(HOFKHCMGAOH KKKHMJMHPKI, HOFKHCMGAOH LGBHMLDJCBK, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7D70", Offset = "0x7BC6F70", VA = "0x187BC7D70")]
	public void NPDCIKOFJLJ(HAONCNNABLP NCMJKLKGNMA, HAONCNNABLP LGBHMLDJCBK, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8520", Offset = "0x7BC7720", VA = "0x187BC8520")]
	public void PHDPKILMLJF(HOFKHCMGAOH KKKHMJMHPKI, float AHAJKIHFAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4CF0", Offset = "0x7BC3EF0", VA = "0x187BC4CF0", Slot = "18")]
	public void FABANGHLBLF(HOFKHCMGAOH GCBGMEIDCGI, int DNFCOFKFDIO, HOFKHCMGAOH KHOANOOGHMG, int HKMMECJPPCF, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5900", Offset = "0x7BC4B00", VA = "0x187BC5900")]
	private float HPOJNMLNBNF(HAONCNNABLP NCMJKLKGNMA, HAONCNNABLP NJHDJGHEICO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4E50", Offset = "0x7BC4050", VA = "0x187BC4E50")]
	public void FABANGHLBLF(HAONCNNABLP NCMJKLKGNMA, HAONCNNABLP NJHDJGHEICO, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC, bool BAFBBFEPCFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BC80A0", Offset = "0x7BC72A0", VA = "0x187BC80A0", Slot = "19")]
	public void OLHAGHEMCKD(HOFKHCMGAOH KKKHMJMHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BC40C0", Offset = "0x7BC32C0", VA = "0x187BC40C0", Slot = "16")]
	public void BBBMPLDENLE(HOFKHCMGAOH KKKHMJMHPKI, HashSet<HOFKHCMGAOH> BJFMAPNMJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "20")]
	public NINHFMBNDNP AJAGLFBPIJI(bool NFEOHEMOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "21")]
	public NINHFMBNDNP KLBJLDGDIMK(HashSet<Guid> IOKIOAKBOBB, bool NFEOHEMOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BC86C0", Offset = "0x7BC78C0", VA = "0x187BC86C0", Slot = "23")]
	public void PMCFLHBPIEJ(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6070", Offset = "0x7BC5270", VA = "0x187BC6070", Slot = "24")]
	public void JIFDAFGBPGK(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7EB0", Offset = "0x7BC70B0", VA = "0x187BC7EB0", Slot = "25")]
	public void OBHBBBHPDIL(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC71B0", Offset = "0x7BC63B0", VA = "0x187BC71B0")]
	private void MDALPMOACKE(HAONCNNABLP NCMJKLKGNMA, HAONCNNABLP NJHDJGHEICO, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC, float AHAJKIHFAHH, bool BAFBBFEPCFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6700", Offset = "0x7BC5900", VA = "0x187BC6700")]
	private void KMJBODHOEKP(HAONCNNABLP NCMJKLKGNMA, HAONCNNABLP LMLNPPNKKKE, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4680", Offset = "0x7BC3880", VA = "0x187BC4680")]
	private void EEIPBFDPAPM(HAONCNNABLP NCMJKLKGNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC56B0", Offset = "0x7BC48B0", VA = "0x187BC56B0")]
	[IteratorStateMachine(typeof(MKHCAFEBEKG))]
	public IEnumerable<HOFKHCMGAOH> FMANLAHCAKH(HAONCNNABLP EANCCIKOAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7950", Offset = "0x7BC6B50", VA = "0x187BC7950")]
	internal HOFKHCMGAOH MNNIGCEFGJO(HAONCNNABLP EANCCIKOAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5520", Offset = "0x7BC4720", VA = "0x187BC5520")]
	internal HAONCNNABLP FJHOHMBGJFB(HOFKHCMGAOH KKKHMJMHPKI)
	{
		return default(HAONCNNABLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4F90", Offset = "0x7BC4190", VA = "0x187BC4F90")]
	private bool FICFHFFKBBA(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BC85B0", Offset = "0x7BC77B0", VA = "0x187BC85B0")]
	private bool PICAICKHGAC(KKLPCIGPLCO HHHCEJKIPDB, [Out] HOFKHCMGAOH NJHDJGHEICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7BC75C0", Offset = "0x7BC67C0", VA = "0x187BC75C0")]
	private HOFKHCMGAOH MNNIGCEFGJO(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7A80", Offset = "0x7BC6C80", VA = "0x187BC7A80")]
	private HOFKHCMGAOH NEDGMDPIMFO(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7ED0", Offset = "0x7BC70D0", VA = "0x187BC7ED0")]
	private HOFKHCMGAOH OINHJIIPBIK(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF820", Offset = "0x7BBEA20", VA = "0x187BBF820")]
	private static Guid CEHBIONNBPB(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BC63F0", Offset = "0x7BC55F0", VA = "0x187BC63F0")]
	private string KECNCEPFGLB(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7020", Offset = "0x7BC6220", VA = "0x187BC7020")]
	private void LDBPIIIEHCE(HOFKHCMGAOH NCMJKLKGNMA, HOFKHCMGAOH LMLNPPNKKKE, RigidTransform PLCNEOBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5BF0", Offset = "0x7BC4DF0", VA = "0x187BC5BF0")]
	private void IGDLPHLJCIO(HOFKHCMGAOH LMLNPPNKKKE, HOFKHCMGAOH NCMJKLKGNMA, RigidTransform PLCNEOBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6010", Offset = "0x7BC5210", VA = "0x187BC6010")]
	private void JBJDCFHMGPI(HOFKHCMGAOH MABBFKJJEHJ, HOFKHCMGAOH NCMJKLKGNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC59B0", Offset = "0x7BC4BB0", VA = "0x187BC59B0")]
	private void IBBLCCJAMJB(HOFKHCMGAOH NCMJKLKGNMA, HOFKHCMGAOH NJHDJGHEICO, RigidTransform PLCNEOBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC57F0", Offset = "0x7BC49F0", VA = "0x187BC57F0")]
	private void HLCBKEOJMDI(HAONCNNABLP EANCCIKOAFJ, HOFKHCMGAOH KKKHMJMHPKI, HAONCNNABLP MEOFNDCDMCD, HAONCNNABLP AMCLMEHBLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3E40", Offset = "0x7BC3040", VA = "0x187BC3E40")]
	private void AFKJJOOCCOH(HAONCNNABLP EANCCIKOAFJ, HOFKHCMGAOH KKKHMJMHPKI, HOFKHCMGAOH PMBLPHMHJIA, HOFKHCMGAOH GLLHECMHDGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LCIJECELDFD
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ANCECPENAEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public HILJAABEPDC container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ANCECPENAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7BB66B0", Offset = "0x7BB58B0", VA = "0x187BB66B0")]
		internal LEPBKMNADAN FDCONIMLAOB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3C70", Offset = "0x7BC2E70", VA = "0x187BC3C70")]
	public static void DODMFJOIFBE(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3DF0", Offset = "0x7BC2FF0", VA = "0x187BC3DF0")]
	public static void MMJNAAHDKCD(HILJAABEPDC NPCDKJJJIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KDMAKPIMHJN : DBLPMBNGMML, IGOHBIJKGKO
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly LEPBKMNADAN IKOPAAKLIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly ABEDCLHDDJJ LHDPHCBDIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly AMBOENCFONM OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly JFIMANMKGLE[] NBMNENFONAA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HOFKHCMGAOH CLICOOACLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3A40", Offset = "0x7BC2C40", VA = "0x187BC3A40", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HOFKHCMGAOH LKECGDNEMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2070", Offset = "0x7BC1270", VA = "0x187BC2070", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 MODMODKIAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC21D0", Offset = "0x7BC13D0", VA = "0x187BC21D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion LEDGBNJBBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BC32A0", Offset = "0x7BC24A0", VA = "0x187BC32A0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CHOIGPJLPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2A40", Offset = "0x7BC1C40", VA = "0x187BC2A40", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<HOFKHCMGAOH> AEAKKLMBPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F50", Offset = "0x7BC1150", VA = "0x187BC1F50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool DMLOKOMAEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC1FDB0", Offset = "0xC1EFB0", VA = "0x180C1FDB0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC54940", Offset = "0xC53B40", VA = "0x180C54940", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3C50", Offset = "0x7BC2E50", VA = "0x187BC3C50", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject FMNMJJFPHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3950", Offset = "0x7BC2B50", VA = "0x187BC3950", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3970", Offset = "0x7BC2B70", VA = "0x187BC3970", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid NPCAIJNAHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3AA0", Offset = "0x7BC2CA0", VA = "0x187BC3AA0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OFNPNPGIEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3B80", Offset = "0x7BC2D80", VA = "0x187BC3B80", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool AALCLGLKBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool BNIILIHNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F80", Offset = "0x7BC1180", VA = "0x187BC1F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event GKOFNGHHDOP NFDPPIOBHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2230", Offset = "0x7BC1430", VA = "0x187BC2230", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7BC29E0", Offset = "0x7BC1BE0", VA = "0x187BC29E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GKOFNGHHDOP HDILNMKFCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2D90", Offset = "0x7BC1F90", VA = "0x187BC2D90", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3500", Offset = "0x7BC2700", VA = "0x187BC3500", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GKOFNGHHDOP AHPIEDBIFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1EF0", Offset = "0x7BC10F0", VA = "0x187BC1EF0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3380", Offset = "0x7BC2580", VA = "0x187BC3380", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event MILDFNILOMM DPHPCOKKAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2130", Offset = "0x7BC1330", VA = "0x187BC2130", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1E50", Offset = "0x7BC1050", VA = "0x187BC1E50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3850", Offset = "0x7BC2A50", VA = "0x187BC3850")]
	public KDMAKPIMHJN(HAONCNNABLP CFNHEFEFHMG, RigidbodyEx EACFJGMBJAK, ABEDCLHDDJJ LHDPHCBDIOL, JFIMANMKGLE[] NBMNENFONAA, AMBOENCFONM OIONFMJBFHJ, KHPMJGOPOBA IKOPAAKLIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2290", Offset = "0x7BC1490", VA = "0x187BC2290", Slot = "19")]
	public void FONBPOKANLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "21")]
	public void LDJMIGDDIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x79036C0", Offset = "0x79028C0", VA = "0x1879036C0", Slot = "22")]
	public void NHNMGJHDNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3250", Offset = "0x7BC2450", VA = "0x187BC3250", Slot = "20")]
	public void MBLDJPNEDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC22C0", Offset = "0x7BC14C0", VA = "0x187BC22C0", Slot = "25")]
	public void GMMOPMBELPO(int OIKCJAGJBDC, HOFKHCMGAOH KHOANOOGHMG, int JBLJADGBCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3430", Offset = "0x7BC2630", VA = "0x187BC3430", Slot = "26")]
	public void NNELNEJCAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2AB0", Offset = "0x7BC1CB0", VA = "0x187BC2AB0", Slot = "27")]
	public void JAAOOFKCFEA(int OIKCJAGJBDC, HOFKHCMGAOH GCBGMEIDCGI, int LPJBLAGCDOO, [Optional] Vector3? CIJJBMEMMJD, [Optional] Quaternion? JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3300", Offset = "0x7BC2500", VA = "0x187BC3300", Slot = "28")]
	public void MJHHHNJIGJO(HOFKHCMGAOH GCBGMEIDCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2DF0", Offset = "0x7BC1FF0", VA = "0x187BC2DF0", Slot = "31")]
	public void KJAIGBPCPDH(Vector3 POABIGHHOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC26D0", Offset = "0x7BC18D0", VA = "0x187BC26D0", Slot = "29")]
	public void HGOFKBMDJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7BC35B0", Offset = "0x7BC27B0", VA = "0x187BC35B0", Slot = "30")]
	public void PIMFIBDFIAL(int NIBICIJAIGM, Vector3 IOHMIDHCEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2600", Offset = "0x7BC1800", VA = "0x187BC2600", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int OIKCJAGJBDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BC24D0", Offset = "0x7BC16D0", VA = "0x187BC24D0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int OIKCJAGJBDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xBFD830", Offset = "0xBFCA30", VA = "0x180BFD830", Slot = "42")]
	public Color GetConnectionSlotColor(int OIKCJAGJBDC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1FD0", Offset = "0x7BC11D0", VA = "0x187BC1FD0", Slot = "43")]
	public bool CanConnectTo(int OIKCJAGJBDC, HOFKHCMGAOH MFOENGLFNEG, int DJAFLDHMALH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "44")]
	public void ParentChanged(int OIKCJAGJBDC, HOFKHCMGAOH CAGJMKMNDAA, int JPNIPAPCHMK, Vector3 EECNHDFDDPL, Quaternion DNODCHELIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "45")]
	public void ChildAdded(int OIKCJAGJBDC, HOFKHCMGAOH BKFPOKCDNIP, int GKBLDICPPDG, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "46")]
	public void ChildRemoved(int OIKCJAGJBDC, HOFKHCMGAOH BFMHHIDGJKB, int BOJDNKHCPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "47")]
	public void ConnectionModified(int OIKCJAGJBDC, HOFKHCMGAOH KHOANOOGHMG, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC37B0", Offset = "0x7BC29B0", VA = "0x187BC37B0", Slot = "48")]
	public void RootChanged(HOFKHCMGAOH MKFPMMNFCLK, HOFKHCMGAOH JONCNNNFBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3560", Offset = "0x7BC2760", VA = "0x187BC3560", Slot = "23")]
	public void PIDHCMDHLIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7BC33E0", Offset = "0x7BC25E0", VA = "0x187BC33E0", Slot = "24")]
	public void NBIOHMKPFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3200", Offset = "0x7BC2400", VA = "0x187BC3200")]
	private void KKDBCDJMBDO(bool IODEAOADMNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(DOCMNJKMPKG), new string[] { })]
public class CICDGACADGK : DOCMNJKMPKG, BJIBPMDIMDH, GKBPCKLNOCI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BOLCICIOENG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BOLCICIOENG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private AIOIFLCKICD GBEOAHCNHMI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object CGLDIHNGOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7BBAAE0", Offset = "0x7BB9CE0", VA = "0x187BBAAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7BBAB70", Offset = "0x7BB9D70", VA = "0x187BBAB70", Slot = "5")]
	private void NPKMOIIMNFA(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x11530D0", Offset = "0x11522D0", VA = "0x1811530D0", Slot = "6")]
	private void JNNNBCINACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CICDGACADGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(KHPMJGOPOBA), new string[] { "Ignore", "Mock" })]
public class IHDAHDEDLMH : KHPMJGOPOBA, AOOLNAMPIBN
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GLGAHOJADMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FFKHDJLNAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<HOFKHCMGAOH, HOFKHCMGAOH> BGMOHNNMMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF260", Offset = "0x7BBE460", VA = "0x187BBF260", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEFA0", Offset = "0x7BBE1A0", VA = "0x187BBEFA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<HOFKHCMGAOH, HOFKHCMGAOH> AAEICLNMKFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF050", Offset = "0x7BBE250", VA = "0x187BBF050", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF1B0", Offset = "0x7BBE3B0", VA = "0x187BBF1B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<HOFKHCMGAOH, HOFKHCMGAOH, HOFKHCMGAOH> IKHILOFFDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF100", Offset = "0x7BBE300", VA = "0x187BBF100", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEEF0", Offset = "0x7BBE0F0", VA = "0x187BBEEF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "26")]
	public void EFOAOCGHIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "12")]
	public void ILLMBOBOELN(GameObject GNOLFLMODHC, ABPOKIIIBLP JJBICEGPACG, FCJMGEEKKCC OJDKNJKJHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "13")]
	public void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "14")]
	public void OOCHIMKFMHO(HOFKHCMGAOH KKKHMJMHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "15")]
	public void DDBNGFDLKBA(HOFKHCMGAOH KKKHMJMHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "16")]
	public void BBBMPLDENLE(HOFKHCMGAOH KKKHMJMHPKI, HashSet<HOFKHCMGAOH> BJFMAPNMJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "17")]
	public void NPDCIKOFJLJ(HOFKHCMGAOH KKKHMJMHPKI, HOFKHCMGAOH LGBHMLDJCBK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "18")]
	public void FABANGHLBLF(HOFKHCMGAOH KKKHMJMHPKI, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "19")]
	public void OLHAGHEMCKD(HOFKHCMGAOH KKKHMJMHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "20")]
	public NINHFMBNDNP AJAGLFBPIJI(bool NFEOHEMOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "21")]
	public NINHFMBNDNP KLBJLDGDIMK(HashSet<Guid> IOKIOAKBOBB, bool NFEOHEMOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "22")]
	public bool BCKGEJPAMKI(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "23")]
	public void PMCFLHBPIEJ(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "24")]
	public void JIFDAFGBPGK(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "25")]
	public void OBHBBBHPDIL(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public IHDAHDEDLMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HOFKHCMGAOH : IGOHBIJKGKO, IEquatable<HOFKHCMGAOH>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IGOHBIJKGKO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HOFKHCMGAOH CLICOOACLLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject FMNMJJFPHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid NPCAIJNAHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int OFNPNPGIEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool AALCLGLKBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int OIKCJAGJBDC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int OIKCJAGJBDC);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int OIKCJAGJBDC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int OIKCJAGJBDC, HOFKHCMGAOH MFOENGLFNEG, int AAMHKEIICGC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int OIKCJAGJBDC, HOFKHCMGAOH CAGJMKMNDAA, int JPNIPAPCHMK, Vector3 EECNHDFDDPL, Quaternion DNODCHELIHB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int OIKCJAGJBDC, HOFKHCMGAOH BKFPOKCDNIP, int GKBLDICPPDG, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int OIKCJAGJBDC, HOFKHCMGAOH BFMHHIDGJKB, int BOJDNKHCPLA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int OIKCJAGJBDC, HOFKHCMGAOH KHOANOOGHMG, int DGCOOOGHBDB, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(HOFKHCMGAOH MKFPMMNFCLK, HOFKHCMGAOH JONCNNNFBJO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KHPMJGOPOBA : AOOLNAMPIBN
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool GLGAHOJADMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FFKHDJLNAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HOFKHCMGAOH, HOFKHCMGAOH> BGMOHNNMMCJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HOFKHCMGAOH, HOFKHCMGAOH> AAEICLNMKFN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<HOFKHCMGAOH, HOFKHCMGAOH, HOFKHCMGAOH> IKHILOFFDFF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ILLMBOBOELN(GameObject GNOLFLMODHC, ABPOKIIIBLP JJBICEGPACG, FCJMGEEKKCC PJEHPIKPHJO);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IOJFMKAPHLJ();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OOCHIMKFMHO(HOFKHCMGAOH KKKHMJMHPKI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DDBNGFDLKBA(HOFKHCMGAOH KKKHMJMHPKI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BBBMPLDENLE(HOFKHCMGAOH KKKHMJMHPKI, HashSet<HOFKHCMGAOH> BJFMAPNMJDK);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NPDCIKOFJLJ(HOFKHCMGAOH KKKHMJMHPKI, HOFKHCMGAOH LGBHMLDJCBK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FABANGHLBLF(HOFKHCMGAOH KKKHMJMHPKI, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OLHAGHEMCKD(HOFKHCMGAOH KKKHMJMHPKI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NINHFMBNDNP AJAGLFBPIJI(bool NFEOHEMOCPN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NINHFMBNDNP KLBJLDGDIMK(HashSet<Guid> IOKIOAKBOBB, bool NFEOHEMOCPN);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BCKGEJPAMKI(KKLPCIGPLCO HHHCEJKIPDB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PMCFLHBPIEJ(NINHFMBNDNP CPICBKAHABD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JIFDAFGBPGK(NINHFMBNDNP CPICBKAHABD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OBHBBBHPDIL(NINHFMBNDNP CPICBKAHABD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JLLAKILHOPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OPIIEEFNEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOFKHCMGAOH OINHJIIPBIK(int JEEOIOLKEGL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HOFKHCMGAOH NEDGMDPIMFO(Guid HKHFAPPEGJE);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HGPDPLBOKLI(HOFKHCMGAOH KKKHMJMHPKI);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AILOAICGFFF();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJABCECICKO(HOFKHCMGAOH LHDPHCBDIOL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface AMBOENCFONM
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNIILIHNGAP(ABEDCLHDDJJ LHDPHCBDIOL);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLBKDHFKJIB(ABEDCLHDDJJ LHDPHCBDIOL);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string PPEHOOIOPHC(ABEDCLHDDJJ LHDPHCBDIOL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid KBGKAPIEBGB(ABEDCLHDDJJ LHDPHCBDIOL);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int PFFIBHAMLMA(ABEDCLHDDJJ LHDPHCBDIOL);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHKAHJGMEKG(ABEDCLHDDJJ LHDPHCBDIOL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void GKOFNGHHDOP(HOFKHCMGAOH GCBGMEIDCGI, int EGOOLJNHBCI, HOFKHCMGAOH KHOANOOGHMG, int CKEPAJEKCAI, [Optional] Vector3? CIJJBMEMMJD, [Optional] Quaternion? JDNLHFOOAEK);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void MILDFNILOMM(HOFKHCMGAOH MKFPMMNFCLK, HOFKHCMGAOH JONCNNNFBJO);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ABEDCLHDDJJ : HOFKHCMGAOH, IGOHBIJKGKO, IEquatable<HOFKHCMGAOH>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DBLPMBNGMML : IGOHBIJKGKO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HOFKHCMGAOH LKECGDNEMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<HOFKHCMGAOH> AEAKKLMBPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 MODMODKIAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion LEDGBNJBBEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool CHOIGPJLPCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool DMLOKOMAEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event GKOFNGHHDOP NFDPPIOBHIN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event GKOFNGHHDOP HDILNMKFCFA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event GKOFNGHHDOP AHPIEDBIFNE;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event MILDFNILOMM DPHPCOKKAKH;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FONBPOKANLB();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MBLDJPNEDPM();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LDJMIGDDIMM();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NHNMGJHDNPC();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PIDHCMDHLIE();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NBIOHMKPFDB();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GMMOPMBELPO(int OIKCJAGJBDC, HOFKHCMGAOH KHOANOOGHMG, int JBLJADGBCAM);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NNELNEJCAKN();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JAAOOFKCFEA(int OIKCJAGJBDC, HOFKHCMGAOH GCBGMEIDCGI, int LPJBLAGCDOO, [Optional] Vector3? CIJJBMEMMJD, [Optional] Quaternion? JDNLHFOOAEK);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MJHHHNJIGJO(HOFKHCMGAOH GCBGMEIDCGI);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HGOFKBMDJBL();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PIMFIBDFIAL(int NIBICIJAIGM, Vector3 IOHMIDHCEGD);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KJAIGBPCPDH(Vector3 POABIGHHOML);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JFIMANMKGLE
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 DBOODFHKIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ABPOKIIIBLP
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool EHANDGGECNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	OIKMBPPIFGA KLGNJMJGHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, ABPOKIIIBLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAACFF0", Offset = "0xAAC1F0", VA = "0x180AACFF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public OIKMBPPIFGA LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCF70", Offset = "0x7BBC170", VA = "0x187BBCF70")]
		public static ConnectableConfigData FHIOLDLAKDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD030", Offset = "0x7BBC230", VA = "0x187BBD030")]
		public ConnectableConfigData(LegacyConnectableLinkVisual GKEJKMNJKKD, bool AGNCDGLKGIP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MCGBKIJCKNK : IEquatable<MCGBKIJCKNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public HOFKHCMGAOH KKKHMJMHPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int FIAODFNFKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int DGCOOOGHBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 CIJJBMEMMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion JDNLHFOOAEK;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9C50", Offset = "0x7BC8E50", VA = "0x187BC9C50")]
	public MCGBKIJCKNK(HOFKHCMGAOH KKKHMJMHPKI, int FIAODFNFKEN, int DGCOOOGHBDB, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9BB0", Offset = "0x7BC8DB0", VA = "0x187BC9BB0")]
	public MCGBKIJCKNK(HOFKHCMGAOH KKKHMJMHPKI, int FIAODFNFKEN, int DGCOOOGHBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9B30", Offset = "0x7BC8D30", VA = "0x187BC9B30")]
	public MCGBKIJCKNK(HOFKHCMGAOH KKKHMJMHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7BC96C0", Offset = "0x7BC88C0", VA = "0x187BC96C0", Slot = "4")]
	public bool Equals(MCGBKIJCKNK FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9770", Offset = "0x7BC8970", VA = "0x187BC9770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class GLNHKAAINDP : GMIBLJIOBJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform PMPOHKBNMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private OIKMBPPIFGA EJEFJEGJOMB;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x759F990", Offset = "0x759EB90", VA = "0x18759F990", Slot = "4")]
	public void ILLMBOBOELN(Transform PMPOHKBNMIB, OIKMBPPIFGA EJEFJEGJOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD300", Offset = "0x7BBC500", VA = "0x187BBD300", Slot = "5")]
	public OIKMBPPIFGA ENGJFMJKEMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD3D0", Offset = "0x7BBC5D0", VA = "0x187BBD3D0", Slot = "6")]
	public void KHJBPDHLMDI(OIKMBPPIFGA MNLDMIPAPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GLNHKAAINDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class BNNBLCAOAGB : IDisposable, FAFBKICGGFI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DEPOFPADLHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HOFKHCMGAOH oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public HOFKHCMGAOH newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DEPOFPADLHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD080", Offset = "0x7BBC280", VA = "0x187BBD080")]
		internal bool JFLCCMCEGBG(KEMBOPIKJAF node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly HDKDLFGJFCA AMBINODOGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NHIHKBBKOMH BLHDMMGJNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private JNFLAJOLHNO HCMOKBCCKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool AGNCDGLKGIP;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly FODGIOKBGBI JLOBOEJKLGG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KEMBOPIKJAF ADHDCGIKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7790", Offset = "0x7BB6990", VA = "0x187BB7790")]
	public bool EOOMODLFPEB([In] OLCKNBODBHB DHAOEHNLNON, bool MODOMJEDIJA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8AF0", Offset = "0x7BB7CF0", VA = "0x187BB8AF0")]
	private bool NFAGPMKEHOF([In] OLCKNBODBHB DHAOEHNLNON, bool MODOMJEDIJA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9B10", Offset = "0x7BB8D10", VA = "0x187BB9B10")]
	public BNNBLCAOAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7CF0", Offset = "0x7BB6EF0", VA = "0x187BB7CF0", Slot = "5")]
	public void ILLMBOBOELN(KHPMJGOPOBA MHGFNMBGACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7BA0", Offset = "0x7BB6DA0", VA = "0x187BB7BA0", Slot = "17")]
	public void HFCFEOMMOLG(NKBFLLKLKLH LKEPFHDAAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB96C0", Offset = "0x7BB88C0", VA = "0x187BB96C0", Slot = "12")]
	public void OPPHPBOGDPE(Func<HOFKHCMGAOH, bool> IEMJIIBFLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB96D0", Offset = "0x7BB88D0", VA = "0x187BB96D0")]
	private void OPPHPBOGDPE(HDKDLFGJFCA GCEDHPINDAM, Func<HOFKHCMGAOH, bool> IEMJIIBFLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8180", Offset = "0x7BB7380", VA = "0x187BB8180", Slot = "11")]
	public void LLENKLKMFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8170", Offset = "0x7BB7370", VA = "0x187BB8170", Slot = "8")]
	public bool LFMBBAMAFDK(HOFKHCMGAOH HBMFOHENICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7BB83E0", Offset = "0x7BB75E0", VA = "0x187BB83E0")]
	private bool NCIMFBIBECL(HOFKHCMGAOH BOEEPCPMCBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7F40", Offset = "0x7BB7140", VA = "0x187BB7F40")]
	private static bool JIKNDODIDBF(HOFKHCMGAOH BOEEPCPMCBF, HDKDLFGJFCA JLGJJLKGOIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7BB90B0", Offset = "0x7BB82B0", VA = "0x187BB90B0")]
	private void NJOPPADEJBL(Transform JPAKDILABMA, HDKDLFGJFCA CBEGCOPHPHB, HDKDLFGJFCA[] KHKKPGNCJIP, HOFKHCMGAOH DEFJPKCKIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9570", Offset = "0x7BB8770", VA = "0x187BB9570")]
	private MCGBKIJCKNK OFPBLDONLCF(Transform HLBNHMPACCH, MCGBKIJCKNK GBGGGMHKFID)
	{
		return default(MCGBKIJCKNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6D40", Offset = "0x7BB5F40", VA = "0x187BB6D40")]
	private static bool BMJMOHAEGPE(HDKDLFGJFCA JLGJJLKGOIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7900", Offset = "0x7BB6B00", VA = "0x187BB7900", Slot = "9")]
	public bool FGGFDDDGIHI(HOFKHCMGAOH KEELDCOOLDK, int LPJBLAGCDOO, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9800", Offset = "0x7BB8A00", VA = "0x187BB9800")]
	private bool PNEADICFBPD(HOFKHCMGAOH KEELDCOOLDK, int LPJBLAGCDOO, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6FD0", Offset = "0x7BB61D0", VA = "0x187BB6FD0")]
	private static void DBGPNGGEFAN(HOFKHCMGAOH KEELDCOOLDK, int LPJBLAGCDOO, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK, HDKDLFGJFCA FINNBGLAGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8050", Offset = "0x7BB7250", VA = "0x187BB8050")]
	private void LDBPIIIEHCE(HOFKHCMGAOH IHIJJHCHABN, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9490", Offset = "0x7BB8690", VA = "0x187BB9490")]
	private void OBCLJAENMBM(HDKDLFGJFCA GCEDHPINDAM, HOFKHCMGAOH PMBLPHMHJIA, HOFKHCMGAOH GLLHECMHDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9500", Offset = "0x7BB8700", VA = "0x187BB9500")]
	private void OBCLJAENMBM(HOFKHCMGAOH KKKHMJMHPKI, HOFKHCMGAOH PMBLPHMHJIA, HOFKHCMGAOH GLLHECMHDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6760", Offset = "0x7BB5960", VA = "0x187BB6760")]
	private void AFKJJOOCCOH(HOFKHCMGAOH KKKHMJMHPKI, HOFKHCMGAOH PMBLPHMHJIA, HOFKHCMGAOH GLLHECMHDGK, bool CEKGONKCBNM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB67D0", Offset = "0x7BB59D0", VA = "0x187BB67D0")]
	private void AFKJJOOCCOH(HDKDLFGJFCA FHPKLENNKKO, HOFKHCMGAOH DEFJPKCKIAF, HOFKHCMGAOH JONCNNNFBJO, bool CEKGONKCBNM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7BD0", Offset = "0x7BB6DD0", VA = "0x187BB7BD0")]
	private void IGDLPHLJCIO(HOFKHCMGAOH NCMJKLKGNMA, int LPJBLAGCDOO, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7DA0", Offset = "0x7BB6FA0", VA = "0x187BB7DA0")]
	private void JBJDCFHMGPI(KEMBOPIKJAF NJHDJGHEICO, KEMBOPIKJAF FODGFLNJBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7BB77A0", Offset = "0x7BB69A0", VA = "0x187BB77A0", Slot = "18")]
	public HOFKHCMGAOH FEDLHJAFOJE(HOFKHCMGAOH KKKHMJMHPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7BB68D0", Offset = "0x7BB5AD0", VA = "0x187BB68D0", Slot = "13")]
	public void BBBMPLDENLE(HOFKHCMGAOH KKKHMJMHPKI, HashSet<HOFKHCMGAOH> AFJHIDCLANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7960", Offset = "0x7BB6B60", VA = "0x187BB7960", Slot = "14")]
	public List<HOFKHCMGAOH> FNADJINGOHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6F00", Offset = "0x7BB6100", VA = "0x187BB6F00")]
	protected KEMBOPIKJAF BPPJMPCOPJB(KEMBOPIKJAF GCEDHPINDAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7150", Offset = "0x7BB6350", VA = "0x187BB7150")]
	protected HDKDLFGJFCA[] EIPICCAKGJC(HDKDLFGJFCA JLGJJLKGOIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7BB82D0", Offset = "0x7BB74D0", VA = "0x187BB82D0")]
	protected bool MJKIENHFKNB(HOFKHCMGAOH KKKHMJMHPKI, [Out] HDKDLFGJFCA GCEDHPINDAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7BB81A0", Offset = "0x7BB73A0", VA = "0x187BB81A0", Slot = "15")]
	public bool MGHABBDMFBP(HOFKHCMGAOH KKKHMJMHPKI, [Out] MCGBKIJCKNK DCAJIAPJNGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7F00", Offset = "0x7BB7100", VA = "0x187BB7F00")]
	protected HDKDLFGJFCA JDFBMFDPJCC(MCGBKIJCKNK HNAIGKLPFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7FF0", Offset = "0x7BB71F0", VA = "0x187BB7FF0", Slot = "10")]
	public bool JINBPIJKPJK(HOFKHCMGAOH IHIJJHCHABN, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB71F0", Offset = "0x7BB63F0", VA = "0x187BB71F0")]
	private bool ENPPKILLGFL(HOFKHCMGAOH IHIJJHCHABN, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6C70", Offset = "0x7BB5E70", VA = "0x187BB6C70")]
	private static bool BIFOBJEBGJD(HDKDLFGJFCA IKDBGNCPLIC, MCGBKIJCKNK MOIGDPLKEDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7790", Offset = "0x7BB6990", VA = "0x187BB7790", Slot = "7")]
	private bool JBNIGEOAKJJ([In] OLCKNBODBHB DHAOEHNLNON, bool MODOMJEDIJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class CPADIHODECG : KHPMJGOPOBA, AOOLNAMPIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly HILJAABEPDC NPCDKJJJIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly JNFLAJOLHNO HCMOKBCCKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly MBIFBBFHDNI ODIDAJDIJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly JFMBCFICHCI PAOFPLDJLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly FAFBKICGGFI CPICBKAHABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal CGFOILOPEHH OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal OELALKDBEGJ GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal NHIHKBBKOMH DLAHOOEOJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool AGNCDGLKGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool IKCHFHBEJJC;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BCOAOKLLDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xC04960", Offset = "0xC03B60", VA = "0x180C04960")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1276710", Offset = "0x1275910", VA = "0x181276710")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GLGAHOJADMO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x113E7C0", Offset = "0x113D9C0", VA = "0x18113E7C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x25DCF20", Offset = "0x25DC120", VA = "0x1825DCF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FFKHDJLNAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HOFKHCMGAOH, HOFKHCMGAOH> BGMOHNNMMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCA90", Offset = "0x7BBBC90", VA = "0x187BBCA90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB490", Offset = "0x7BBA690", VA = "0x187BBB490", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HOFKHCMGAOH, HOFKHCMGAOH> AAEICLNMKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB810", Offset = "0x7BBAA10", VA = "0x187BBB810", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC440", Offset = "0x7BBB640", VA = "0x187BBC440", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HOFKHCMGAOH, HOFKHCMGAOH, HOFKHCMGAOH> IKHILOFFDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7BBBAC0", Offset = "0x7BBACC0", VA = "0x187BBBAC0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB150", Offset = "0x7BBA350", VA = "0x187BBB150", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCB80", Offset = "0x7BBBD80", VA = "0x187BBCB80")]
	public CPADIHODECG(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBBB20", Offset = "0x7BBAD20", VA = "0x187BBBB20", Slot = "12")]
	public void ILLMBOBOELN(GameObject GNOLFLMODHC, ABPOKIIIBLP JJBICEGPACG, FCJMGEEKKCC PJEHPIKPHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB4F0", Offset = "0x7BBA6F0", VA = "0x187BBB4F0", Slot = "26")]
	public void EFOAOCGHIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC130", Offset = "0x7BBB330", VA = "0x187BBC130", Slot = "13")]
	public void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCA70", Offset = "0x7BBBC70", VA = "0x187BBCA70", Slot = "14")]
	public void OOCHIMKFMHO(HOFKHCMGAOH KKKHMJMHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB430", Offset = "0x7BBA630", VA = "0x187BBB430", Slot = "15")]
	public void DDBNGFDLKBA(HOFKHCMGAOH KKKHMJMHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB100", Offset = "0x7BBA300", VA = "0x187BBB100", Slot = "22")]
	public bool BCKGEJPAMKI(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB5C0", Offset = "0x7BBA7C0", VA = "0x187BBB5C0")]
	internal bool ENPPKILLGFL([In] OLCKNBODBHB DHAOEHNLNON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB1B0", Offset = "0x7BBA3B0", VA = "0x187BBB1B0")]
	internal bool CFOGJJDGHFG([In] OLCKNBODBHB DHAOEHNLNON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC260", Offset = "0x7BBB460", VA = "0x187BBC260")]
	internal void JLIJGAEGEHP(HOFKHCMGAOH KKKHMJMHPKI, int AJFBOLOJOIK, bool MODOMJEDIJA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB430", Offset = "0x7BBA630", VA = "0x187BBB430")]
	internal bool OKHNCAGNOGA(HOFKHCMGAOH MFEOOKEKIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB300", Offset = "0x7BBA500", VA = "0x187BBB300")]
	internal bool CGNGDHAKKGH(HOFKHCMGAOH KEELDCOOLDK, int LPJBLAGCDOO, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB000", Offset = "0x7BBA200", VA = "0x187BBB000", Slot = "16")]
	public void BBBMPLDENLE(HOFKHCMGAOH KKKHMJMHPKI, HashSet<HOFKHCMGAOH> BJFMAPNMJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC650", Offset = "0x7BBB850", VA = "0x187BBC650", Slot = "17")]
	public void NPDCIKOFJLJ(HOFKHCMGAOH KEELDCOOLDK, HOFKHCMGAOH LGBHMLDJCBK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB6D0", Offset = "0x7BBA8D0", VA = "0x187BBB6D0", Slot = "18")]
	public void FABANGHLBLF(HOFKHCMGAOH IHIJJHCHABN, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC8A0", Offset = "0x7BBBAA0", VA = "0x187BBC8A0", Slot = "19")]
	public void OLHAGHEMCKD(HOFKHCMGAOH IHIJJHCHABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB870", Offset = "0x7BBAA70", VA = "0x187BBB870")]
	public void HEGOANEBCAM([Optional] KPDBONCIMNC APHFJDLBLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCAF0", Offset = "0x7BBBCF0", VA = "0x187BBCAF0", Slot = "23")]
	public void PMCFLHBPIEJ(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7BBAE80", Offset = "0x7BBA080", VA = "0x187BBAE80", Slot = "20")]
	public NINHFMBNDNP AJAGLFBPIJI(bool NFEOHEMOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC4A0", Offset = "0x7BBB6A0", VA = "0x187BBC4A0", Slot = "21")]
	public NINHFMBNDNP KLBJLDGDIMK(HashSet<Guid> IOKIOAKBOBB, bool NFEOHEMOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC860", Offset = "0x7BBBA60", VA = "0x187BBC860", Slot = "25")]
	public void OBHBBBHPDIL(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC1B0", Offset = "0x7BBB3B0", VA = "0x187BBC1B0", Slot = "24")]
	public void JIFDAFGBPGK(NINHFMBNDNP CPICBKAHABD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class JNFLAJOLHNO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly PFCLJBDPGOA<HOFKHCMGAOH, HOFKHCMGAOH> BGMOHNNMMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly PFCLJBDPGOA<HOFKHCMGAOH, HOFKHCMGAOH> AAEICLNMKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly BGBNJBDHOLE<HOFKHCMGAOH, HOFKHCMGAOH, HOFKHCMGAOH> IKHILOFFDFF;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1BF0", Offset = "0x7BC0DF0", VA = "0x187BC1BF0")]
	public JNFLAJOLHNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	public void ILLMBOBOELN(CPADIHODECG MHGFNMBGACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1B90", Offset = "0x7BC0D90", VA = "0x187BC1B90")]
	public void NIIOELPGLMC(HOFKHCMGAOH NJHDJGHEICO, HOFKHCMGAOH NCMJKLKGNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1B30", Offset = "0x7BC0D30", VA = "0x187BC1B30")]
	public void NIGFKGDKAAN(HOFKHCMGAOH NJHDJGHEICO, HOFKHCMGAOH NCMJKLKGNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1AB0", Offset = "0x7BC0CB0", VA = "0x187BC1AB0")]
	public void EDHALBPJAIK(HOFKHCMGAOH MABBFKJJEHJ, HOFKHCMGAOH LMLNPPNKKKE, HOFKHCMGAOH NCMJKLKGNMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class MBIFBBFHDNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private CPADIHODECG MHGFNMBGACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private OELALKDBEGJ GCMEJOEAFHA;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MBIFBBFHDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9360", Offset = "0x7BC8560", VA = "0x187BC9360")]
	public void ILLMBOBOELN(CPADIHODECG MHGFNMBGACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC92E0", Offset = "0x7BC84E0", VA = "0x187BC92E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC92A0", Offset = "0x7BC84A0", VA = "0x187BC92A0")]
	private void BNEHFDHDMJK(MMNMPKDPAGK KOCMKKLCMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC92F0", Offset = "0x7BC84F0", VA = "0x187BC92F0")]
	private void EGLNBJMLJNN(KPDBONCIMNC NMAPFLEKNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC95B0", Offset = "0x7BC87B0", VA = "0x187BC95B0")]
	public void LDFOJBIFJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7BC94A0", Offset = "0x7BC86A0", VA = "0x187BC94A0")]
	public void KMMFDGOAKFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class POCFMAKMAPC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JFPIDFIPIFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public HILJAABEPDC container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JFPIDFIPIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1A40", Offset = "0x7BC0C40", VA = "0x187BC1A40")]
		internal CPADIHODECG FDCONIMLAOB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAD20", Offset = "0x7BC9F20", VA = "0x187BCAD20")]
	public static void DODMFJOIFBE(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAF20", Offset = "0x7BCA120", VA = "0x187BCAF20")]
	public static void MMJNAAHDKCD(HILJAABEPDC NPCDKJJJIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class CGOBKDEIGME : IDisposable, NHIHKBBKOMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, OIKMBPPIFGA> KPGLNMELKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NKBFLLKLKLH LNDBGCIGECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private GMIBLJIOBJA MJJPIMBMHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private FAFBKICGGFI CPICBKAHABD;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker HJCOBOMKDOI;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7BBAA00", Offset = "0x7BB9C00", VA = "0x187BBAA00")]
	public CGOBKDEIGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA7B0", Offset = "0x7BB99B0", VA = "0x187BBA7B0", Slot = "7")]
	public void ILLMBOBOELN(FAFBKICGGFI CPICBKAHABD, GMIBLJIOBJA MJJPIMBMHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9CE0", Offset = "0x7BB8EE0", VA = "0x187BB9CE0", Slot = "5")]
	public void FEAFELHEHBM(KEMBOPIKJAF GMEPEHDKEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA640", Offset = "0x7BB9840", VA = "0x187BBA640", Slot = "9")]
	public void ILFKLCJAIMB(KEMBOPIKJAF HFLCPNEOENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA2D0", Offset = "0x7BB94D0", VA = "0x187BBA2D0", Slot = "8")]
	public void HEIPOEJFOGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9F80", Offset = "0x7BB9180", VA = "0x187BB9F80", Slot = "10")]
	public void GOBFGPMLEKK(KEMBOPIKJAF GCIPDOEKJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA490", Offset = "0x7BB9690", VA = "0x187BBA490", Slot = "11")]
	public void HMPKBCPGGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA7F0", Offset = "0x7BB99F0", VA = "0x187BBA7F0")]
	private bool MOPOGMFOPLK(KEMBOPIKJAF EMNFBEIKLFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class JFMBCFICHCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct MHLGDFIKJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HDKDLFGJFCA OKNOBPIKKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> IOKIOAKBOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly KKLPCIGPLCO LBLHMHACJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly KKLPCIGPLCO DIJKCEIJKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool NFEOHEMOCPN;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool FOINJLIGGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7BCA030", Offset = "0x7BC9230", VA = "0x187BCA030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA5F0", Offset = "0x7BC97F0", VA = "0x187BCA5F0")]
		public MHLGDFIKJGH(HDKDLFGJFCA OKNOBPIKKJA, HashSet<Guid> IOKIOAKBOBB, bool NFEOHEMOCPN, [Optional] KKLPCIGPLCO LBLHMHACJCG, [Optional] KKLPCIGPLCO DIJKCEIJKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9E90", Offset = "0x7BC9090", VA = "0x187BC9E90")]
		public KKLPCIGPLCO CEBCPPBDNIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA370", Offset = "0x7BC9570", VA = "0x187BCA370")]
		private KKLPCIGPLCO KKKADJKABNC([Out] KKLPCIGPLCO MFONMFMGAGJ, [Out] KKLPCIGPLCO GLPMPGEMFMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA150", Offset = "0x7BC9350", VA = "0x187BCA150")]
		private KKLPCIGPLCO INFLMEGMGIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9D20", Offset = "0x7BC8F20", VA = "0x187BC9D20")]
		private void ACEPECLHOGJ(KKLPCIGPLCO PCBGLLLEEEM, KKLPCIGPLCO CLGGOONFGHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA430", Offset = "0x7BC9630", VA = "0x187BCA430")]
		private void MEPJMANEDHB(KKLPCIGPLCO MFONMFMGAGJ, KKLPCIGPLCO GLPMPGEMFMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private CPADIHODECG MHGFNMBGACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private FAFBKICGGFI CPICBKAHABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NHIHKBBKOMH BLHDMMGJNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private OELALKDBEGJ GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool DBGHKHEDNMH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool BNONMCLGINM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC05F0", Offset = "0x7BBF7F0", VA = "0x187BC05F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool BCOAOKLLDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1090", Offset = "0x7BC0290", VA = "0x187BC1090")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1070", Offset = "0x7BC0270", VA = "0x187BC1070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7BC06F0", Offset = "0x7BBF8F0", VA = "0x187BC06F0")]
	public void ILLMBOBOELN(CPADIHODECG MHGFNMBGACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF420", Offset = "0x7BBE620", VA = "0x187BBF420")]
	public NINHFMBNDNP AJAGLFBPIJI(bool NFEOHEMOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0B80", Offset = "0x7BBFD80", VA = "0x187BC0B80")]
	public NINHFMBNDNP KLBJLDGDIMK(HashSet<Guid> IOKIOAKBOBB, bool NFEOHEMOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7BC16E0", Offset = "0x7BC08E0", VA = "0x187BC16E0")]
	public void PMCFLHBPIEJ(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7BC09F0", Offset = "0x7BBFBF0", VA = "0x187BC09F0")]
	public void JIFDAFGBPGK(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7BC16B0", Offset = "0x7BC08B0", VA = "0x187BC16B0")]
	public void PGNAKEEPIFI(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFA80", Offset = "0x7BBEC80", VA = "0x187BBFA80")]
	private void CNJMPBFAGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1230", Offset = "0x7BC0430", VA = "0x187BC1230")]
	private KKLPCIGPLCO OKMOOMELAKP(HDKDLFGJFCA GCEDHPINDAM, bool NFEOHEMOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1460", Offset = "0x7BC0660", VA = "0x187BC1460")]
	private static void OOOKMJFBCGF(HDKDLFGJFCA GCEDHPINDAM, bool NFEOHEMOCPN, KKLPCIGPLCO HHHCEJKIPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF860", Offset = "0x7BBEA60", VA = "0x187BBF860")]
	private void CFNCIJDMEPN(HDKDLFGJFCA GCEDHPINDAM, bool NFEOHEMOCPN, KKLPCIGPLCO HHHCEJKIPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0660", Offset = "0x7BBF860", VA = "0x187BC0660")]
	private KKLPCIGPLCO HLLCPGBDCGL(HDKDLFGJFCA OKNOBPIKKJA, HashSet<Guid> IOKIOAKBOBB, bool NFEOHEMOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0760", Offset = "0x7BBF960", VA = "0x187BC0760")]
	private bool IOGMMAAKDOO(NINHFMBNDNP NEPDMCPJDFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFE00", Offset = "0x7BBF000", VA = "0x187BBFE00")]
	private bool FICFHFFKBBA(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0640", Offset = "0x7BBF840", VA = "0x187BC0640")]
	private bool HJAGGMAGLFL(NINHFMBNDNP CPICBKAHABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF310", Offset = "0x7BBE510", VA = "0x187BBF310")]
	private static bool AHMFDMLKOFP(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF590", Offset = "0x7BBE790", VA = "0x187BBF590")]
	public static bool BCKGEJPAMKI(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0D20", Offset = "0x7BBFF20", VA = "0x187BC0D20")]
	private HOFKHCMGAOH MNNIGCEFGJO(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7BC10B0", Offset = "0x7BC02B0", VA = "0x187BC10B0")]
	private HOFKHCMGAOH OINHJIIPBIK(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFC70", Offset = "0x7BBEE70", VA = "0x187BBFC70")]
	private HOFKHCMGAOH DKBJCIPDAHP(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF820", Offset = "0x7BBEA20", VA = "0x187BBF820")]
	private static Guid CEHBIONNBPB(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0A90", Offset = "0x7BBFC90", VA = "0x187BC0A90")]
	private string KECNCEPFGLB(KKLPCIGPLCO HHHCEJKIPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0460", Offset = "0x7BBF660", VA = "0x187BC0460")]
	private bool FNJIEMFEIGK(HDKDLFGJFCA GCEDHPINDAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1770", Offset = "0x7BC0970", VA = "0x187BC1770")]
	private static void PMGOFKANAJN(HDKDLFGJFCA OKNOBPIKKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JFMBCFICHCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct OLCKNBODBHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public HOFKHCMGAOH NCMJKLKGNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public HOFKHCMGAOH NJHDJGHEICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int LPJBLAGCDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int JBLJADGBCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 CIJJBMEMMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion JDNLHFOOAEK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MCGBKIJCKNK MNODBCMEPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7BCABE0", Offset = "0x7BC9DE0", VA = "0x187BCABE0")]
		get
		{
			return default(MCGBKIJCKNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MCGBKIJCKNK OPPKMKCMMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7BCAC80", Offset = "0x7BC9E80", VA = "0x187BCAC80")]
		get
		{
			return default(MCGBKIJCKNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7BCACB0", Offset = "0x7BC9EB0", VA = "0x187BCACB0")]
	public OLCKNBODBHB(HOFKHCMGAOH NCMJKLKGNMA, HOFKHCMGAOH NJHDJGHEICO, int LPJBLAGCDOO, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface FAFBKICGGFI
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KEMBOPIKJAF ADHDCGIKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILLMBOBOELN(KHPMJGOPOBA MHGFNMBGACA);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EOOMODLFPEB([In] OLCKNBODBHB DHAOEHNLNON, bool MODOMJEDIJA = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LFMBBAMAFDK(HOFKHCMGAOH HBMFOHENICA);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FGGFDDDGIHI(HOFKHCMGAOH KEELDCOOLDK, int LPJBLAGCDOO, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JINBPIJKPJK(HOFKHCMGAOH IHIJJHCHABN, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LLENKLKMFKF();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPPHPBOGDPE(Func<HOFKHCMGAOH, bool> IEMJIIBFLGG);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BBBMPLDENLE(HOFKHCMGAOH KKKHMJMHPKI, HashSet<HOFKHCMGAOH> AFJHIDCLANH);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<HOFKHCMGAOH> FNADJINGOHI();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MGHABBDMFBP(HOFKHCMGAOH KKKHMJMHPKI, [Out] MCGBKIJCKNK DCAJIAPJNGL);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HFCFEOMMOLG(NKBFLLKLKLH LKEPFHDAAED);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool NKBFLLKLKLH(KEMBOPIKJAF GCEDHPINDAM);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KEMBOPIKJAF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HOFKHCMGAOH DICEGLFLNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KEMBOPIKJAF EKNHDPMCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MCGBKIJCKNK JAEGFPBIKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HBAFELAAOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OIKMBPPIFGA
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNFKMEBPDCG(HOFKHCMGAOH KHOANOOGHMG, MCGBKIJCKNK NCMJKLKGNMA);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEDLINMKEEI(HOFKHCMGAOH KHOANOOGHMG, MCGBKIJCKNK NCMJKLKGNMA);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GDPEPEHHMEA(HOFKHCMGAOH KHOANOOGHMG, MCGBKIJCKNK NCMJKLKGNMA);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPDJGKJMFIE(HOFKHCMGAOH KHOANOOGHMG, MCGBKIJCKNK NCMJKLKGNMA);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OIKMBPPIFGA Instantiate(Transform PMPOHKBNMIB);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NHLEMPKJEGJ();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface GMIBLJIOBJA
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILLMBOBOELN(Transform PMPOHKBNMIB, OIKMBPPIFGA EJEFJEGJOMB);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OIKMBPPIFGA ENGJFMJKEMG();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHJBPDHLMDI(OIKMBPPIFGA MNLDMIPAPPP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CGFOILOPEHH : JLLAKILHOPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNPAJOOIIBE();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FOHBCGLHPKB(Guid PGKMPKPKBOJ);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface NHIHKBBKOMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEAFELHEHBM(KEMBOPIKJAF GMEPEHDKEEE);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILLMBOBOELN(FAFBKICGGFI CPICBKAHABD, GMIBLJIOBJA MOMPGHILOCD);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEIPOEJFOGI();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILFKLCJAIMB(KEMBOPIKJAF HFLCPNEOENJ);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GOBFGPMLEKK(KEMBOPIKJAF GCIPDOEKJDI);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HMPKBCPGGPF();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class HDKDLFGJFCA : KEMBOPIKJAF
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JPIDGCAFMDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public MCGBKIJCKNK nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public HDKDLFGJFCA foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JPIDGCAFMDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1D10", Offset = "0x7BC0F10", VA = "0x187BC1D10")]
		internal bool JMNBEHFDLNM(KEMBOPIKJAF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private MCGBKIJCKNK DCAJIAPJNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<HDKDLFGJFCA> MKHNEOCCLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private HDKDLFGJFCA AOAFOJCGFBB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MCGBKIJCKNK JAEGFPBIKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1276860", Offset = "0x1275A60", VA = "0x181276860", Slot = "6")]
		get
		{
			return default(MCGBKIJCKNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1276250", Offset = "0x1275450", VA = "0x181276250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private HDKDLFGJFCA NJHDJGHEICO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD760", Offset = "0x7BBC960", VA = "0x187BBD760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KEMBOPIKJAF EKNHDPMCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HOFKHCMGAOH DICEGLFLNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HBAFELAAOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BBDC90", Offset = "0x7BBCE90", VA = "0x187BBDC90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool HAHLBLAFPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD710", Offset = "0x7BBC910", VA = "0x187BBD710", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected HDKDLFGJFCA FHPKLENNKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BBDDF0", Offset = "0x7BBCFF0", VA = "0x187BBDDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDEC0", Offset = "0x7BBD0C0", VA = "0x187BBDEC0")]
	public HDKDLFGJFCA(MCGBKIJCKNK GIBGLPMENII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDCA0", Offset = "0x7BBCEA0", VA = "0x187BBDCA0")]
	public HDKDLFGJFCA LPBOLFEOHNB(MCGBKIJCKNK JKGNPAOAMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD590", Offset = "0x7BBC790", VA = "0x187BBD590")]
	public HDKDLFGJFCA GCCJFBHHKHJ(MCGBKIJCKNK NEFMIJMOGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDAB0", Offset = "0x7BBCCB0", VA = "0x187BBDAB0")]
	public HDKDLFGJFCA KKKHDEJPLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD440", Offset = "0x7BBC640", VA = "0x187BBD440")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDE10", Offset = "0x7BBD010", VA = "0x187BBDE10")]
	public HDKDLFGJFCA NNGADDPCJDO(MCGBKIJCKNK LMLNPPNKKKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD840", Offset = "0x7BBCA40", VA = "0x187BBD840")]
	private static void HFCFEOMMOLG(HDKDLFGJFCA JNMOGFNADLB, NKBFLLKLKLH AFMEMNMIOCM, bool BFDGJHMGDNO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD9A0", Offset = "0x7BBCBA0", VA = "0x187BBD9A0", Slot = "9")]
	public void HFCFEOMMOLG(NKBFLLKLKLH LKEPFHDAAED, bool CEKGONKCBNM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD9B0", Offset = "0x7BBCBB0", VA = "0x187BBD9B0")]
	public static HDKDLFGJFCA JDFBMFDPJCC(HDKDLFGJFCA JNMOGFNADLB, MCGBKIJCKNK OGNGDELBBHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface OELALKDBEGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool BNONMCLGINM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool OPIIEEFNEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<MMNMPKDPAGK> BNEHFDHDMJK;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<KPDBONCIMNC> EGLNBJMLJNN;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MNFKMEBPDCG(CPADIHODECG MHGFNMBGACA, FCJMGEEKKCC OJDKNJKJHGB);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NPDCIKOFJLJ(HOFKHCMGAOH KEELDCOOLDK, HOFKHCMGAOH LGBHMLDJCBK, int LPJBLAGCDOO, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FABANGHLBLF(HOFKHCMGAOH IHIJJHCHABN, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OCODKIICLGM(NINHFMBNDNP HANBCNJMFMD, [Optional] KPDBONCIMNC APHFJDLBLCF);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AEDMKPBJOMA
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BB65C0", Offset = "0x7BB57C0", VA = "0x187BB65C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object NDDGJHHDBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6620", Offset = "0x7BB5820", VA = "0x187BB6620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6660", Offset = "0x7BB5860", VA = "0x187BB6660")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class IGJCDJIKMGM : OELALKDBEGJ, IDisposable, MBAJEBDBADL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private CPADIHODECG MHGFNMBGACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private FCJMGEEKKCC PJEHPIKPHJO;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BNONMCLGINM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE190", Offset = "0x7BBD390", VA = "0x187BBE190", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool OPIIEEFNEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE1F0", Offset = "0x7BBD3F0", VA = "0x187BBE1F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView OCDHKACHOON
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE360", Offset = "0x7BBD560", VA = "0x187BBE360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<MMNMPKDPAGK> BNEHFDHDMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE230", Offset = "0x7BBD430", VA = "0x187BBE230", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE490", Offset = "0x7BBD690", VA = "0x187BBE490", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<KPDBONCIMNC> EGLNBJMLJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE0F0", Offset = "0x7BBD2F0", VA = "0x187BBE0F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE2C0", Offset = "0x7BBD4C0", VA = "0x187BBE2C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE400", Offset = "0x7BBD600", VA = "0x187BBE400", Slot = "10")]
	public void MNFKMEBPDCG(CPADIHODECG MHGFNMBGACA, FCJMGEEKKCC PJEHPIKPHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDF70", Offset = "0x7BBD170", VA = "0x187BBDF70", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE520", Offset = "0x7BBD720", VA = "0x187BBE520", Slot = "11")]
	public void NPDCIKOFJLJ(HOFKHCMGAOH KEELDCOOLDK, HOFKHCMGAOH LGBHMLDJCBK, int LPJBLAGCDOO, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDFC0", Offset = "0x7BBD1C0", VA = "0x187BBDFC0", Slot = "12")]
	public void FABANGHLBLF(HOFKHCMGAOH IHIJJHCHABN, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE650", Offset = "0x7BBD850", VA = "0x187BBE650", Slot = "13")]
	public void OCODKIICLGM(NINHFMBNDNP HANBCNJMFMD, [Optional] KPDBONCIMNC APHFJDLBLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE9C0", Offset = "0x7BBDBC0", VA = "0x187BBE9C0")]
	[LILBIBIOCJC]
	private void RpcMasterReparentNodes(HOFKHCMGAOH IHIJJHCHABN, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE7C0", Offset = "0x7BBD9C0", VA = "0x187BBE7C0")]
	[LILBIBIOCJC]
	private void RpcMasterModifyNode(HOFKHCMGAOH KEELDCOOLDK, HOFKHCMGAOH LGBHMLDJCBK, int LPJBLAGCDOO, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7BBEDC0", Offset = "0x7BBDFC0", VA = "0x187BBEDC0")]
	[LILBIBIOCJC]
	private void RpcReparentNodes(HOFKHCMGAOH IHIJJHCHABN, int KBKJKIBDKLA, HOFKHCMGAOH LMLNPPNKKKE, int JPNIPAPCHMK, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK, IJHMLFCLBCG NIOLGPBJEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7BBECD0", Offset = "0x7BBDED0", VA = "0x187BBECD0")]
	[LILBIBIOCJC]
	private void RpcModifyNode(HOFKHCMGAOH KEELDCOOLDK, int LPJBLAGCDOO, int JBLJADGBCAM, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK, IJHMLFCLBCG NIOLGPBJEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE780", Offset = "0x7BBD980", VA = "0x187BBE780")]
	[LILBIBIOCJC]
	private void RpcDeserializeConnectableGraph(NINHFMBNDNP CPICBKAHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public IGJCDJIKMGM()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, OIKMBPPIFGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8D50", Offset = "0x7BC7F50", VA = "0x187BC8D50", Slot = "4")]
		private void JFJPDFEJNAC(HOFKHCMGAOH KHOANOOGHMG, MCGBKIJCKNK NCMJKLKGNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BC88F0", Offset = "0x7BC7AF0", VA = "0x187BC88F0", Slot = "5")]
		private void GJILNECGIIL(HOFKHCMGAOH KHOANOOGHMG, MCGBKIJCKNK NCMJKLKGNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8ED0", Offset = "0x7BC80D0", VA = "0x187BC8ED0", Slot = "6")]
		private void MPFHJKMLOGN(HOFKHCMGAOH KHOANOOGHMG, MCGBKIJCKNK NCMJKLKGNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8B60", Offset = "0x7BC7D60", VA = "0x187BC8B60", Slot = "7")]
		private void HLHGPHJENJD(HOFKHCMGAOH KHOANOOGHMG, MCGBKIJCKNK NCMJKLKGNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9090", Offset = "0x7BC8290", VA = "0x187BC9090", Slot = "8")]
		private OIKMBPPIFGA PAFBOELBHFD(Transform PMPOHKBNMIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9030", Offset = "0x7BC8230", VA = "0x187BC9030", Slot = "9")]
		private void NJLDAAOEGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class ICFNJHNMPJH
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3844230", Offset = "0x3843430", VA = "0x183844230")]
	public static MPFMKOAOEMJ<T> KLHIFOKJFGP<T>(this HILJAABEPDC NPCDKJJJIDL)
	{
		return null;
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
