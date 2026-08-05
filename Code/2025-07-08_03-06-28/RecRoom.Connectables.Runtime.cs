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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5270", Offset = "0x7FE4070", VA = "0x187FE5270", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x22D3BE0", Offset = "0x22D29E0", VA = "0x1822D3BE0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FE83E0", Offset = "0x7FE71E0", VA = "0x187FE83E0")]
		private void AFKHLAMEPCM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7FE8550", Offset = "0x7FE7350", VA = "0x187FE8550")]
		private void DBFIEBKHIEP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7FE86C0", Offset = "0x7FE74C0", VA = "0x187FE86C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7FE8A00", Offset = "0x7FE7800", VA = "0x187FE8A00")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class HGGAHBHKPHE : CMAGGNHNBPB, GNJFBAIKFDH
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class JFNINLGNAAK : IEnumerable<LLIKCNAHAKG>, IEnumerable, IEnumerator<LLIKCNAHAKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private LLIKCNAHAKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JDKDDPDJCCM localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JDKDDPDJCCM <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public HGGAHBHKPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BPAIJKJGNLD <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private OEPFMPMHIKM <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OEPFMPMHIKM.FFJLONIPPFH <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LLIKCNAHAKG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public JFNINLGNAAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFDE0", Offset = "0x7FDEBE0", VA = "0x187FDFDE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF980", Offset = "0x7FDE780", VA = "0x187FDF980", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF960", Offset = "0x7FDE760", VA = "0x187FDF960")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF940", Offset = "0x7FDE740", VA = "0x187FDF940")]
		private void ICJNGMGPPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFD90", Offset = "0x7FDEB90", VA = "0x187FDFD90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFCE0", Offset = "0x7FDEAE0", VA = "0x187FDFCE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LLIKCNAHAKG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFCE0", Offset = "0x7FDEAE0", VA = "0x187FDFCE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BALBCEJCOLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HGGAHBHKPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public NJCFHFGHMNO nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BALBCEJCOLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3FE0", Offset = "0x7FD2DE0", VA = "0x187FD3FE0")]
		internal object HKNGPGAKKCL(NJCFHFGHMNO x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class GNJHMIGPJAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public NJCFHFGHMNO child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BALBCEJCOLG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GNJHMIGPJAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9B50", Offset = "0x7FD8950", VA = "0x187FD9B50")]
		internal object FFIPDAIAELK((NJCFHFGHMNO child, NJCFHFGHMNO nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly PHLHEDGDBJO OKDLHOGMNON;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly PHLHEDGDBJO BDAJPHFKKDP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly PHLHEDGDBJO ANBBECGHNKB;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly PHLHEDGDBJO JLJPLOAPBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OCKCODPKJMC CJPCLHALEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EDOOOMLBJKI FDEBGGJNHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private ICGPKIBCHFK CGPPCCGLHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private KGOHMADMHLM JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private ABBJJOAJNJJ PBGFIHMGIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PFNANCDILGF DJHINHOAANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly OIPGDOEHLDA HOEHAJENLGD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DDMFODGPIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA604E0", Offset = "0xA5F2E0", VA = "0x180A604E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA60420", Offset = "0xA5F220", VA = "0x180A60420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EAJDDIJONJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<LLIKCNAHAKG, LLIKCNAHAKG> LJILGOIMFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7FDDF60", Offset = "0x7FDCD60", VA = "0x187FDDF60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDACD0", Offset = "0x7FD9AD0", VA = "0x187FDACD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<LLIKCNAHAKG, LLIKCNAHAKG> FPCDPHEGBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9DF0", Offset = "0x7FD8BF0", VA = "0x187FD9DF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA320", Offset = "0x7FD9120", VA = "0x187FDA320", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<LLIKCNAHAKG, LLIKCNAHAKG, LLIKCNAHAKG> KPIGCDLBHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA3D0", Offset = "0x7FD91D0", VA = "0x187FDA3D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE630", Offset = "0x7FDD430", VA = "0x187FDE630", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE850", Offset = "0x7FDD650", VA = "0x187FDE850")]
	public HGGAHBHKPHE(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAA40", Offset = "0x7FD9840", VA = "0x187FDAA40", Slot = "12")]
	public void DGPDNICIDDD(GameObject JLNNGPHDMLM, LLJNHOLHNEI GCJFGPIMCIB, GILKKONIJPN DFODLDMBKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAD80", Offset = "0x7FD9B80", VA = "0x187FDAD80", Slot = "26")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9DA0", Offset = "0x7FD8BA0", VA = "0x187FD9DA0", Slot = "22")]
	public bool AKBCIBICHPB(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBBC0", Offset = "0x7FDA9C0", VA = "0x187FDBBC0")]
	private void JECPMOPKAIP(JDKDDPDJCCM FIAHHIIPNAP, JDKDDPDJCCM GJDFLFABNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9EA0", Offset = "0x7FD8CA0", VA = "0x187FD9EA0")]
	private void BFMFCINCPFA(JDKDDPDJCCM FIAHHIIPNAP, JDKDDPDJCCM JPEIGAJGHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA0C0", Offset = "0x7FD8EC0", VA = "0x187FDA0C0")]
	private void BGCOPLNCBOE(JDKDDPDJCCM FIAHHIIPNAP, JDKDDPDJCCM JPEIGAJGHNN, JDKDDPDJCCM GJDFLFABNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA630", Offset = "0x7FD9430", VA = "0x187FDA630")]
	private void DFONCFKALBC(JDKDDPDJCCM FIAHHIIPNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "13")]
	public void FLCGEBIGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB830", Offset = "0x7FDA630", VA = "0x187FDB830", Slot = "14")]
	public void HIMDKAKGPHI(LLIKCNAHAKG IPCPMJOJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "15")]
	public void NDMNNAOCPHL(LLIKCNAHAKG IPCPMJOJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE260", Offset = "0x7FDD060", VA = "0x187FDE260", Slot = "17")]
	public void OJLMHMEHFPP(LLIKCNAHAKG IPCPMJOJNDE, LLIKCNAHAKG MBIBBOJNGAN, Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE120", Offset = "0x7FDCF20", VA = "0x187FDE120")]
	public void OJLMHMEHFPP(JDKDDPDJCCM CCEEMHPLNFI, JDKDDPDJCCM MBIBBOJNGAN, Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA480", Offset = "0x7FD9280", VA = "0x187FDA480")]
	public void CMFACFDPNBA(LLIKCNAHAKG IPCPMJOJNDE, float JPCENJALCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCCC0", Offset = "0x7FDBAC0", VA = "0x187FDCCC0", Slot = "18")]
	public void MHAKJAOHCON(LLIKCNAHAKG EKEGNKCPFND, int DCGOFHHFILP, LLIKCNAHAKG GBHDLIMNBCL, int IJLJCJJFGJH, Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA510", Offset = "0x7FD9310", VA = "0x187FDA510")]
	private float COFFJMINLIA(JDKDDPDJCCM CCEEMHPLNFI, JDKDDPDJCCM CMDMCJGFCDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCB80", Offset = "0x7FDB980", VA = "0x187FDCB80")]
	public void MHAKJAOHCON(JDKDDPDJCCM CCEEMHPLNFI, JDKDDPDJCCM CMDMCJGFCDK, Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL, bool ELBOBGFPLJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB540", Offset = "0x7FDA340", VA = "0x187FDB540", Slot = "19")]
	public void GFKJPGKNOGG(LLIKCNAHAKG IPCPMJOJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE3C0", Offset = "0x7FDD1C0", VA = "0x187FDE3C0", Slot = "16")]
	public void OMLCGINCNNJ(LLIKCNAHAKG IPCPMJOJNDE, HashSet<LLIKCNAHAKG> BFFPDNIKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "20")]
	public JNIBGFPEKJC JIFNPBFPABC(bool MHODODKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "21")]
	public JNIBGFPEKJC POLJGIJCHDB(HashSet<Guid> COMGIIMPIFO, bool MHODODKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD040", Offset = "0x7FDBE40", VA = "0x187FDD040", Slot = "23")]
	public void NACDPDLMMNM(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA5C0", Offset = "0x7FD93C0", VA = "0x187FDA5C0", Slot = "24")]
	public void DADBFMLNNMC(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBB30", Offset = "0x7FDA930", VA = "0x187FDBB30", Slot = "25")]
	public void IIDOFPKCBLD(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB100", Offset = "0x7FD9F00", VA = "0x187FDB100")]
	private void FJGNOGLABKD(JDKDDPDJCCM CCEEMHPLNFI, JDKDDPDJCCM CMDMCJGFCDK, Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL, float JPCENJALCCP, bool ELBOBGFPLJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD0B0", Offset = "0x7FDBEB0", VA = "0x187FDD0B0")]
	private void NBFIEPLOHMM(JDKDDPDJCCM CCEEMHPLNFI, JDKDDPDJCCM HCGMLNGABFM, Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBB50", Offset = "0x7FDA950", VA = "0x187FDBB50")]
	private void JCAPLCPLFFM(JDKDDPDJCCM CCEEMHPLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCE20", Offset = "0x7FDBC20", VA = "0x187FDCE20")]
	[IteratorStateMachine(typeof(JFNINLGNAAK))]
	public IEnumerable<LLIKCNAHAKG> MODBLNCIFJH(JDKDDPDJCCM OPKFGAAECNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC900", Offset = "0x7FDB700", VA = "0x187FDC900")]
	internal LLIKCNAHAKG LOICMNFMHGK(JDKDDPDJCCM OPKFGAAECNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC3C0", Offset = "0x7FDB1C0", VA = "0x187FDC3C0")]
	internal JDKDDPDJCCM KKOPLJOCPCP(LLIKCNAHAKG IPCPMJOJNDE)
	{
		return default(JDKDDPDJCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD9C0", Offset = "0x7FDC7C0", VA = "0x187FDD9C0")]
	private bool NEGHBFBHHPJ(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCA30", Offset = "0x7FDB830", VA = "0x187FDCA30")]
	private bool MCNIPGPAKOC(NJCFHFGHMNO JCEFHNCIHBC, [Out] LLIKCNAHAKG CMDMCJGFCDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC550", Offset = "0x7FDB350", VA = "0x187FDC550")]
	private LLIKCNAHAKG LOICMNFMHGK(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB6B0", Offset = "0x7FDA4B0", VA = "0x187FDB6B0")]
	private LLIKCNAHAKG HGGNGGKEAEI(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBF60", Offset = "0x7FDAD60", VA = "0x187FDBF60")]
	private LLIKCNAHAKG JMLLFLLHCFJ(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB500", Offset = "0x7FDA300", VA = "0x187FDB500")]
	private static Guid GCKBHGOOCJM(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCA90", Offset = "0x7FDB890", VA = "0x187FDCA90")]
	private string MFKIIPHFJON(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBDD0", Offset = "0x7FDABD0", VA = "0x187FDBDD0")]
	private void JJGKDBDMCGB(LLIKCNAHAKG CCEEMHPLNFI, LLIKCNAHAKG HCGMLNGABFM, RigidTransform DGPLBJKFJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCEB0", Offset = "0x7FDBCB0", VA = "0x187FDCEB0")]
	private void MOIICGBCHHJ(LLIKCNAHAKG HCGMLNGABFM, LLIKCNAHAKG CCEEMHPLNFI, RigidTransform DGPLBJKFJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE5D0", Offset = "0x7FDD3D0", VA = "0x187FDE5D0")]
	private void OOICJABKNDO(LLIKCNAHAKG MHFMOLFCLCB, LLIKCNAHAKG CCEEMHPLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAF70", Offset = "0x7FD9D70", VA = "0x187FDAF70")]
	private void FGDOBHOBACB(LLIKCNAHAKG CCEEMHPLNFI, LLIKCNAHAKG CMDMCJGFCDK, RigidTransform DGPLBJKFJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE010", Offset = "0x7FDCE10", VA = "0x187FDE010")]
	private void OJGAONOMHGB(JDKDDPDJCCM OPKFGAAECNB, LLIKCNAHAKG IPCPMJOJNDE, JDKDDPDJCCM JPEIGAJGHNN, JDKDDPDJCCM GJDFLFABNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC140", Offset = "0x7FDAF40", VA = "0x187FDC140")]
	private void KCIKGEEOMEB(JDKDDPDJCCM OPKFGAAECNB, LLIKCNAHAKG IPCPMJOJNDE, LLIKCNAHAKG HPIHOGLHOFM, LLIKCNAHAKG GAALPIBIDLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HKMIGAGPCJI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class AGNFBBMEBIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public LOAHJOOKLEP container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AGNFBBMEBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3CD0", Offset = "0x7FD2AD0", VA = "0x187FD3CD0")]
		internal HGGAHBHKPHE AHKMGDBLJKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE910", Offset = "0x7FDD710", VA = "0x187FDE910")]
	public static void HNGCEEBEJFD(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE8C0", Offset = "0x7FDD6C0", VA = "0x187FDE8C0")]
	public static void CJPCCHLIAFL(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KGIDJAPGBHL : DMKCABKFNIP, NNMIMMONIGH
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HGGAHBHKPHE LHLFBEHMIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly AOFOOKADOKO JOOGPFGLKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly MKBCOFBDIAH JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly AKMDDLJDJAM[] BIGOJEIAKJN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LLIKCNAHAKG MBNPIEDLKOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1AA0", Offset = "0x7FE08A0", VA = "0x187FE1AA0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LLIKCNAHAKG FJDEEGODKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0D00", Offset = "0x7FDFB00", VA = "0x187FE0D00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 JOCMEHJPKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1300", Offset = "0x7FE0100", VA = "0x187FE1300", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion OHLEOBKHNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0B90", Offset = "0x7FDF990", VA = "0x187FE0B90", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CCNBEBJNHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0B20", Offset = "0x7FDF920", VA = "0x187FE0B20", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<LLIKCNAHAKG> BHIEAEJHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0960", Offset = "0x7FDF760", VA = "0x187FE0960", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool GGBPBINAOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD238D0", Offset = "0xD226D0", VA = "0x180D238D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD58A40", Offset = "0xD57840", VA = "0x180D58A40", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1CA0", Offset = "0x7FE0AA0", VA = "0x187FE1CA0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject GJPFCDPKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7FE19C0", Offset = "0x7FE07C0", VA = "0x187FE19C0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7FE19E0", Offset = "0x7FE07E0", VA = "0x187FE19E0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid GOKFOCIFJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1B00", Offset = "0x7FE0900", VA = "0x187FE1B00", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HMIGHANEGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1BE0", Offset = "0x7FE09E0", VA = "0x187FE1BE0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool CKLJLMBGBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool PCDGJHLIIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0BF0", Offset = "0x7FDF9F0", VA = "0x187FE0BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MDDBEBHNHHA NBEMLOGNNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0C40", Offset = "0x7FDFA40", VA = "0x187FE0C40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0E20", Offset = "0x7FDFC20", VA = "0x187FE0E20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MDDBEBHNHHA DNMMMEMMMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0990", Offset = "0x7FDF790", VA = "0x187FE0990", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7FE09F0", Offset = "0x7FDF7F0", VA = "0x187FE09F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MDDBEBHNHHA JFMEJLPFHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0DC0", Offset = "0x7FDFBC0", VA = "0x187FE0DC0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0CA0", Offset = "0x7FDFAA0", VA = "0x187FE0CA0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event APPKFLKDMDP KGFEPKHGDHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE08C0", Offset = "0x7FDF6C0", VA = "0x187FE08C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1360", Offset = "0x7FE0160", VA = "0x187FE1360", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7FE18C0", Offset = "0x7FE06C0", VA = "0x187FE18C0")]
	public KGIDJAPGBHL(JDKDDPDJCCM ANPENHHJGPC, RigidbodyEx BNHFIJBCOJI, AOFOOKADOKO JOOGPFGLKIG, AKMDDLJDJAM[] BIGOJEIAKJN, MKBCOFBDIAH JBNGHMBPLHF, CMAGGNHNBPB LHLFBEHMIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1280", Offset = "0x7FE0080", VA = "0x187FE1280", Slot = "19")]
	public void NBAJAKOOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "21")]
	public void PMCMOOHADII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D23520", Offset = "0x7D22320", VA = "0x187D23520", Slot = "22")]
	public void MAPKEJDFPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFF40", Offset = "0x7FDED40", VA = "0x187FDFF40", Slot = "20")]
	public void BCBLGFMJHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1070", Offset = "0x7FDFE70", VA = "0x187FE1070", Slot = "25")]
	public void MIHOJMNFKCH(int DIAAGCLKBAB, LLIKCNAHAKG GBHDLIMNBCL, int EPIHAMIOGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0A50", Offset = "0x7FDF850", VA = "0x187FE0A50", Slot = "26")]
	public void IAGCKHNPEEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFF90", Offset = "0x7FDED90", VA = "0x187FDFF90", Slot = "27")]
	public void BHBCPFLCPOC(int DIAAGCLKBAB, LLIKCNAHAKG EKEGNKCPFND, int KCMPGCMAGGL, [Optional] Vector3? AHONFNANHOA, [Optional] Quaternion? CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFEC0", Offset = "0x7FDECC0", VA = "0x187FDFEC0", Slot = "28")]
	public void AFMDMEDPMGE(LLIKCNAHAKG EKEGNKCPFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1400", Offset = "0x7FE0200", VA = "0x187FE1400", Slot = "31")]
	public void PLHIGBBCINB(Vector3 EHDKOBHPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0310", Offset = "0x7FDF110", VA = "0x187FE0310", Slot = "29")]
	public void FGEFLJBFOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0E80", Offset = "0x7FDFC80", VA = "0x187FE0E80", Slot = "30")]
	public void MIGHLCNDKDC(int CKFKPOAGPKN, Vector3 MLCPBGGGOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FE07F0", Offset = "0x7FDF5F0", VA = "0x187FE07F0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int DIAAGCLKBAB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FE06C0", Offset = "0x7FDF4C0", VA = "0x187FE06C0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int DIAAGCLKBAB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAC0AB0", Offset = "0xABF8B0", VA = "0x180AC0AB0", Slot = "42")]
	public Color GetConnectionSlotColor(int DIAAGCLKBAB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0270", Offset = "0x7FDF070", VA = "0x187FE0270", Slot = "43")]
	public bool CanConnectTo(int DIAAGCLKBAB, LLIKCNAHAKG IHMKGFFDEDC, int JDEPPNGDEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "44")]
	public void ParentChanged(int DIAAGCLKBAB, LLIKCNAHAKG HGMPDNKMGDM, int CBAMGIAFONH, Vector3 PHIFIMDOABI, Quaternion MLKPDJGEKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "45")]
	public void ChildAdded(int DIAAGCLKBAB, LLIKCNAHAKG HFAGDODPMIG, int NDNDHIGLJGO, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "46")]
	public void ChildRemoved(int DIAAGCLKBAB, LLIKCNAHAKG DNEEPMNONAP, int NJCJEGJOAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "47")]
	public void ConnectionModified(int DIAAGCLKBAB, LLIKCNAHAKG GBHDLIMNBCL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1810", Offset = "0x7FE0610", VA = "0x187FE1810", Slot = "48")]
	public void RootChanged(LLIKCNAHAKG GDLDGLJNAAL, LLIKCNAHAKG GDNMLJEMGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0670", Offset = "0x7FDF470", VA = "0x187FE0670", Slot = "23")]
	public void GEPLFLANIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0620", Offset = "0x7FDF420", VA = "0x187FE0620", Slot = "24")]
	public void FOHGMOEBLNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7FE12B0", Offset = "0x7FE00B0", VA = "0x187FE12B0")]
	private void NGPNLMGIKAF(bool BNGLBPBOLGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(OIHCNBECOFH), new string[] { })]
public class KKEBNNOBLCB : OIHCNBECOFH, KFAMAKMBLEN, HGADKLGPBDL
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BGKILOKDCID
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BGKILOKDCID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private EOPHEMDGEFM FHICECHOKKP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object IOELIDJHBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E50", Offset = "0x7FE0C50", VA = "0x187FE1E50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1E00", Offset = "0x7FE0C00", VA = "0x187FE1E00", Slot = "5")]
	private void BIPCOHCEAAL(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x128F760", Offset = "0x128E560", VA = "0x18128F760", Slot = "6")]
	private void AABAMDPDGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public KKEBNNOBLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(CMAGGNHNBPB), new string[] { "Ignore", "Mock" })]
public class AAKNAJILNDA : CMAGGNHNBPB, GNJFBAIKFDH
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DDMFODGPIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EAJDDIJONJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<LLIKCNAHAKG, LLIKCNAHAKG> LJILGOIMFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3B70", Offset = "0x7FD2970", VA = "0x187FD3B70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3AC0", Offset = "0x7FD28C0", VA = "0x187FD3AC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<LLIKCNAHAKG, LLIKCNAHAKG> FPCDPHEGBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD38B0", Offset = "0x7FD26B0", VA = "0x187FD38B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3960", Offset = "0x7FD2760", VA = "0x187FD3960", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<LLIKCNAHAKG, LLIKCNAHAKG, LLIKCNAHAKG> KPIGCDLBHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3A10", Offset = "0x7FD2810", VA = "0x187FD3A10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3C20", Offset = "0x7FD2A20", VA = "0x187FD3C20", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "26")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "12")]
	public void DGPDNICIDDD(GameObject JLNNGPHDMLM, LLJNHOLHNEI GCJFGPIMCIB, GILKKONIJPN ADDEGPDDIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "13")]
	public void FLCGEBIGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "14")]
	public void HIMDKAKGPHI(LLIKCNAHAKG IPCPMJOJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "15")]
	public void NDMNNAOCPHL(LLIKCNAHAKG IPCPMJOJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "16")]
	public void OMLCGINCNNJ(LLIKCNAHAKG IPCPMJOJNDE, HashSet<LLIKCNAHAKG> BFFPDNIKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "17")]
	public void OJLMHMEHFPP(LLIKCNAHAKG IPCPMJOJNDE, LLIKCNAHAKG MBIBBOJNGAN, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "18")]
	public void MHAKJAOHCON(LLIKCNAHAKG IPCPMJOJNDE, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "19")]
	public void GFKJPGKNOGG(LLIKCNAHAKG IPCPMJOJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "20")]
	public JNIBGFPEKJC JIFNPBFPABC(bool MHODODKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "21")]
	public JNIBGFPEKJC POLJGIJCHDB(HashSet<Guid> COMGIIMPIFO, bool MHODODKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "22")]
	public bool AKBCIBICHPB(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "23")]
	public void NACDPDLMMNM(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "24")]
	public void DADBFMLNNMC(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "25")]
	public void IIDOFPKCBLD(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public AAKNAJILNDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LLIKCNAHAKG : NNMIMMONIGH, IEquatable<LLIKCNAHAKG>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NNMIMMONIGH
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	LLIKCNAHAKG MBNPIEDLKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject GJPFCDPKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid GOKFOCIFJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int HMIGHANEGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CKLJLMBGBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int DIAAGCLKBAB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int DIAAGCLKBAB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int DIAAGCLKBAB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int DIAAGCLKBAB, LLIKCNAHAKG IHMKGFFDEDC, int AGHLGMMIJHG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int DIAAGCLKBAB, LLIKCNAHAKG HGMPDNKMGDM, int CBAMGIAFONH, Vector3 PHIFIMDOABI, Quaternion MLKPDJGEKAE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int DIAAGCLKBAB, LLIKCNAHAKG HFAGDODPMIG, int NDNDHIGLJGO, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int DIAAGCLKBAB, LLIKCNAHAKG DNEEPMNONAP, int NJCJEGJOAIJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int DIAAGCLKBAB, LLIKCNAHAKG GBHDLIMNBCL, int DKGINOBLPON, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(LLIKCNAHAKG GDLDGLJNAAL, LLIKCNAHAKG GDNMLJEMGFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CMAGGNHNBPB : GNJFBAIKFDH
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DDMFODGPIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool EAJDDIJONJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LLIKCNAHAKG, LLIKCNAHAKG> LJILGOIMFCD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<LLIKCNAHAKG, LLIKCNAHAKG> FPCDPHEGBMN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<LLIKCNAHAKG, LLIKCNAHAKG, LLIKCNAHAKG> KPIGCDLBHGL;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGPDNICIDDD(GameObject JLNNGPHDMLM, LLJNHOLHNEI GCJFGPIMCIB, GILKKONIJPN FHLNHENKGOB);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FLCGEBIGNJN();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HIMDKAKGPHI(LLIKCNAHAKG IPCPMJOJNDE);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NDMNNAOCPHL(LLIKCNAHAKG IPCPMJOJNDE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OMLCGINCNNJ(LLIKCNAHAKG IPCPMJOJNDE, HashSet<LLIKCNAHAKG> BFFPDNIKIML);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OJLMHMEHFPP(LLIKCNAHAKG IPCPMJOJNDE, LLIKCNAHAKG MBIBBOJNGAN, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MHAKJAOHCON(LLIKCNAHAKG IPCPMJOJNDE, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GFKJPGKNOGG(LLIKCNAHAKG IPCPMJOJNDE);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JNIBGFPEKJC JIFNPBFPABC(bool MHODODKLPDJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JNIBGFPEKJC POLJGIJCHDB(HashSet<Guid> COMGIIMPIFO, bool MHODODKLPDJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool AKBCIBICHPB(NJCFHFGHMNO JCEFHNCIHBC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NACDPDLMMNM(JNIBGFPEKJC IELCAHEPMOF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DADBFMLNNMC(JNIBGFPEKJC IELCAHEPMOF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IIDOFPKCBLD(JNIBGFPEKJC IELCAHEPMOF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KGOHMADMHLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FIGMIMCIHME
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LLIKCNAHAKG JMLLFLLHCFJ(int KHACKKEFMFI);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LLIKCNAHAKG HGGNGGKEAEI(Guid GDCBOGBGLAC);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KGDGBHJIBEK(LLIKCNAHAKG IPCPMJOJNDE);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KMNFJKCDLLA();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AJJABOLHBLJ(LLIKCNAHAKG JOOGPFGLKIG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface MKBCOFBDIAH
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCDGJHLIIGH(AOFOOKADOKO JOOGPFGLKIG);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ONHICADNJGN(AOFOOKADOKO JOOGPFGLKIG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string FLHFMIAGBDG(AOFOOKADOKO JOOGPFGLKIG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PJPGJIBKJAO(AOFOOKADOKO JOOGPFGLKIG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ELGBHFPGKKA(AOFOOKADOKO JOOGPFGLKIG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DEGOJMOIJBF(AOFOOKADOKO JOOGPFGLKIG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void MDDBEBHNHHA(LLIKCNAHAKG EKEGNKCPFND, int JNPKNHNPKCB, LLIKCNAHAKG GBHDLIMNBCL, int DFODPIECDIO, [Optional] Vector3? AHONFNANHOA, [Optional] Quaternion? CFNHDKBODKB);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void APPKFLKDMDP(LLIKCNAHAKG GDLDGLJNAAL, LLIKCNAHAKG GDNMLJEMGFJ);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AOFOOKADOKO : LLIKCNAHAKG, NNMIMMONIGH, IEquatable<LLIKCNAHAKG>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DMKCABKFNIP : NNMIMMONIGH
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LLIKCNAHAKG FJDEEGODKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<LLIKCNAHAKG> BHIEAEJHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 JOCMEHJPKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion OHLEOBKHNDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool CCNBEBJNHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool GGBPBINAOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event MDDBEBHNHHA NBEMLOGNNFI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event MDDBEBHNHHA DNMMMEMMMPC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event MDDBEBHNHHA JFMEJLPFHIA;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event APPKFLKDMDP KGFEPKHGDHH;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NBAJAKOOJPL();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BCBLGFMJHPB();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PMCMOOHADII();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MAPKEJDFPEG();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GEPLFLANIDH();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FOHGMOEBLNK();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MIHOJMNFKCH(int DIAAGCLKBAB, LLIKCNAHAKG GBHDLIMNBCL, int EPIHAMIOGLB);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IAGCKHNPEEB();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BHBCPFLCPOC(int DIAAGCLKBAB, LLIKCNAHAKG EKEGNKCPFND, int KCMPGCMAGGL, [Optional] Vector3? AHONFNANHOA, [Optional] Quaternion? CFNHDKBODKB);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AFMDMEDPMGE(LLIKCNAHAKG EKEGNKCPFND);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FGEFLJBFOGG();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MIGHLCNDKDC(int CKFKPOAGPKN, Vector3 MLCPBGGGOAK);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PLHIGBBCINB(Vector3 EHDKOBHPJEB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AKMDDLJDJAM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 KNOEHCGPLEM
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
public interface LLJNHOLHNEI
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool GHBGBGPFNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JAHIDJOCJLK HFDOAHBPJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, LLJNHOLHNEI
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
			[Cpp2IlInjected.Address(RVA = "0xAAA5A0", Offset = "0xAA93A0", VA = "0x180AAA5A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JAHIDJOCJLK LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4FE0", Offset = "0x7FD3DE0", VA = "0x187FD4FE0")]
		public static ConnectableConfigData JELIMKHFCJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD50A0", Offset = "0x7FD3EA0", VA = "0x187FD50A0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual AKMCJNAKDGH, bool FGNCLFODJFA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FMLKFLBIENH : IEquatable<FMLKFLBIENH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LLIKCNAHAKG IPCPMJOJNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int MGGAEMKOADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int DKGINOBLPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 AHONFNANHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion CFNHDKBODKB;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9AF0", Offset = "0x7FD88F0", VA = "0x187FD9AF0")]
	public FMLKFLBIENH(LLIKCNAHAKG IPCPMJOJNDE, int MGGAEMKOADB, int DKGINOBLPON, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7FD99C0", Offset = "0x7FD87C0", VA = "0x187FD99C0")]
	public FMLKFLBIENH(LLIKCNAHAKG IPCPMJOJNDE, int MGGAEMKOADB, int DKGINOBLPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9A60", Offset = "0x7FD8860", VA = "0x187FD9A60")]
	public FMLKFLBIENH(LLIKCNAHAKG IPCPMJOJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9540", Offset = "0x7FD8340", VA = "0x187FD9540", Slot = "4")]
	public bool Equals(FMLKFLBIENH LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7FD95F0", Offset = "0x7FD83F0", VA = "0x187FD95F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class NDMBBGLOBGD : JJCDCPONDCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform OLPMPAIMKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private JAHIDJOCJLK EJOIDDPJCKI;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x798A8A0", Offset = "0x79896A0", VA = "0x18798A8A0", Slot = "4")]
	public void DGPDNICIDDD(Transform OLPMPAIMKPI, JAHIDJOCJLK EJOIDDPJCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7FE55D0", Offset = "0x7FE43D0", VA = "0x187FE55D0", Slot = "5")]
	public JAHIDJOCJLK JFJKIKDMFBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5690", Offset = "0x7FE4490", VA = "0x187FE5690", Slot = "6")]
	public void MPAJFKPKNBM(JAHIDJOCJLK GOEMBOJPCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public NDMBBGLOBGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class FIOCOENHEHB : IDisposable, NKPLPBPOICL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ONEJPIIKCIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LLIKCNAHAKG oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public LLIKCNAHAKG newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ONEJPIIKCIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE80F0", Offset = "0x7FE6EF0", VA = "0x187FE80F0")]
		internal bool CJJMAGPLJDM(IGBDGGEPFKG node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly EBALOEGILLN HOOOGBOIHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private HJDBNKHLBLG FJCAKNDGAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private APKNIHMHGIC HIEOEHIBOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool FGNCLFODJFA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly PHLHEDGDBJO DCDCCPMGPKE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IGBDGGEPFKG KBGGJKBKACF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7FD76B0", Offset = "0x7FD64B0", VA = "0x187FD76B0")]
	public bool JFOIHBDCODL([In] KIEGDINFLPG BOIPFNOKGBJ, bool HEAFLCAEALG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7FD80E0", Offset = "0x7FD6EE0", VA = "0x187FD80E0")]
	private bool NFHCOBJAFNB([In] KIEGDINFLPG BOIPFNOKGBJ, bool HEAFLCAEALG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9370", Offset = "0x7FD8170", VA = "0x187FD9370")]
	public FIOCOENHEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6B50", Offset = "0x7FD5950", VA = "0x187FD6B50", Slot = "5")]
	public void DGPDNICIDDD(CMAGGNHNBPB HEJIJKOGOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9270", Offset = "0x7FD8070", VA = "0x187FD9270", Slot = "17")]
	public void PGKGKJJNKEE(HIMCJJFHNEA JCDKDANAIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6D40", Offset = "0x7FD5B40", VA = "0x187FD6D40", Slot = "12")]
	public void HGIPJFAJBAG(Func<LLIKCNAHAKG, bool> LBAJLANLLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6C10", Offset = "0x7FD5A10", VA = "0x187FD6C10")]
	private void HGIPJFAJBAG(EBALOEGILLN FNINGPDJHMC, Func<LLIKCNAHAKG, bool> LBAJLANLLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7690", Offset = "0x7FD6490", VA = "0x187FD7690", Slot = "11")]
	public void JBMJKFPKLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6C00", Offset = "0x7FD5A00", VA = "0x187FD6C00", Slot = "8")]
	public bool GHKJPIGACAA(LLIKCNAHAKG HJGHPKLOEIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6D50", Offset = "0x7FD5B50", VA = "0x187FD6D50")]
	private bool HNBAPGGMEJG(LLIKCNAHAKG GAGKKMIFJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7FD90F0", Offset = "0x7FD7EF0", VA = "0x187FD90F0")]
	private static bool PACLAFKFCJC(LLIKCNAHAKG GAGKKMIFJBK, EBALOEGILLN FOBPELKPOHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7FD87F0", Offset = "0x7FD75F0", VA = "0x187FD87F0")]
	private void NNEIAMPAMMD(Transform KCGJGMCJECN, EBALOEGILLN KKOJAANCCKE, EBALOEGILLN[] KOBHOEDPAKO, LLIKCNAHAKG GMMAKBLPMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7FD86A0", Offset = "0x7FD74A0", VA = "0x187FD86A0")]
	private FMLKFLBIENH NFOIPFJOPBM(Transform MDFEKLCIJIG, FMLKFLBIENH KLEENEOKIPF)
	{
		return default(FMLKFLBIENH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5FA0", Offset = "0x7FD4DA0", VA = "0x187FD5FA0")]
	private static bool AFHFHKKFBMA(EBALOEGILLN FOBPELKPOHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7A20", Offset = "0x7FD6820", VA = "0x187FD7A20", Slot = "9")]
	public bool KNIMGCFIBHD(LLIKCNAHAKG FKMKINLKOOF, int KCMPGCMAGGL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7C90", Offset = "0x7FD6A90", VA = "0x187FD7C90")]
	private bool MMCBEBGNJHG(LLIKCNAHAKG FKMKINLKOOF, int KCMPGCMAGGL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7FD69D0", Offset = "0x7FD57D0", VA = "0x187FD69D0")]
	private static void CONADIEBOLN(LLIKCNAHAKG FKMKINLKOOF, int KCMPGCMAGGL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB, EBALOEGILLN NIEGDGPOIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD76C0", Offset = "0x7FD64C0", VA = "0x187FD76C0")]
	private void JJGKDBDMCGB(LLIKCNAHAKG LNIDOKHMMAO, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7C20", Offset = "0x7FD6A20", VA = "0x187FD7C20")]
	private void LMEKAEGGHMG(EBALOEGILLN FNINGPDJHMC, LLIKCNAHAKG HPIHOGLHOFM, LLIKCNAHAKG GAALPIBIDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7BB0", Offset = "0x7FD69B0", VA = "0x187FD7BB0")]
	private void LMEKAEGGHMG(LLIKCNAHAKG IPCPMJOJNDE, LLIKCNAHAKG HPIHOGLHOFM, LLIKCNAHAKG GAALPIBIDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD77E0", Offset = "0x7FD65E0", VA = "0x187FD77E0")]
	private void KCIKGEEOMEB(LLIKCNAHAKG IPCPMJOJNDE, LLIKCNAHAKG HPIHOGLHOFM, LLIKCNAHAKG GAALPIBIDLB, bool IIJPEPCOGOJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7850", Offset = "0x7FD6650", VA = "0x187FD7850")]
	private void KCIKGEEOMEB(EBALOEGILLN EGPDFGOHLFM, LLIKCNAHAKG GMMAKBLPMBM, LLIKCNAHAKG GDNMLJEMGFJ, bool IIJPEPCOGOJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7EE0", Offset = "0x7FD6CE0", VA = "0x187FD7EE0")]
	private void MOIICGBCHHJ(LLIKCNAHAKG CCEEMHPLNFI, int KCMPGCMAGGL, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8F90", Offset = "0x7FD7D90", VA = "0x187FD8F90")]
	private void OOICJABKNDO(IGBDGGEPFKG CMDMCJGFCDK, IGBDGGEPFKG MKECOOGBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6160", Offset = "0x7FD4F60", VA = "0x187FD6160", Slot = "18")]
	public LLIKCNAHAKG AJGNNOAEBMF(LLIKCNAHAKG IPCPMJOJNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8BE0", Offset = "0x7FD79E0", VA = "0x187FD8BE0", Slot = "13")]
	public void OMLCGINCNNJ(LLIKCNAHAKG IPCPMJOJNDE, HashSet<LLIKCNAHAKG> PIIIMLMMDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7450", Offset = "0x7FD6250", VA = "0x187FD7450", Slot = "14")]
	public List<LLIKCNAHAKG> IMJIELIJNBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7FD91A0", Offset = "0x7FD7FA0", VA = "0x187FD91A0")]
	protected IGBDGGEPFKG PCMNCMNHBFO(IGBDGGEPFKG FNINGPDJHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8040", Offset = "0x7FD6E40", VA = "0x187FD8040")]
	protected EBALOEGILLN[] NDIJGCJAKGN(EBALOEGILLN FOBPELKPOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7FD62C0", Offset = "0x7FD50C0", VA = "0x187FD62C0")]
	protected bool BJHMPEONFEC(LLIKCNAHAKG IPCPMJOJNDE, [Out] EBALOEGILLN FNINGPDJHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7A80", Offset = "0x7FD6880", VA = "0x187FD7A80", Slot = "15")]
	public bool LCFHPMJJDFO(LLIKCNAHAKG IPCPMJOJNDE, [Out] FMLKFLBIENH OGHADPLBFJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8000", Offset = "0x7FD6E00", VA = "0x187FD8000")]
	protected EBALOEGILLN MPELLBGLNJF(FMLKFLBIENH BFFEDKHPOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7FD63D0", Offset = "0x7FD51D0", VA = "0x187FD63D0", Slot = "10")]
	public bool CBJCJIKJPLN(LLIKCNAHAKG LNIDOKHMMAO, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6430", Offset = "0x7FD5230", VA = "0x187FD6430")]
	private bool CKEOKCCMLFD(LLIKCNAHAKG LNIDOKHMMAO, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7950", Offset = "0x7FD6750", VA = "0x187FD7950")]
	private static bool KLPFGIKLAEH(EBALOEGILLN AAKKAEHIBHM, FMLKFLBIENH CFKGFJGDNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD76B0", Offset = "0x7FD64B0", VA = "0x187FD76B0", Slot = "7")]
	private bool KIJCBBHPKCH([In] KIEGDINFLPG BOIPFNOKGBJ, bool HEAFLCAEALG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class NNKJKBECIPO : CMAGGNHNBPB, GNJFBAIKFDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly LOAHJOOKLEP CHDHLAGMCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly APKNIHMHGIC HIEOEHIBOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly LBBPBLELCAO NIJOCHLCMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly LGOCILKKKEP DJGPPMPEPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly NKPLPBPOICL IELCAHEPMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal MICELNLPCAK JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal JJPFOLHAFKL LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal HJDBNKHLBLG EEOGILPBBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool FGNCLFODJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool PGKADENFPEA;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool ADNMNLCJOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAA9E50", Offset = "0xAA8C50", VA = "0x180AA9E50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9E60", Offset = "0xAA8C60", VA = "0x180AA9E60")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DDMFODGPIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xACBBD0", Offset = "0xACA9D0", VA = "0x180ACBBD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xACBBE0", Offset = "0xACA9E0", VA = "0x180ACBBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool EAJDDIJONJB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LLIKCNAHAKG, LLIKCNAHAKG> LJILGOIMFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6E70", Offset = "0x7FE5C70", VA = "0x187FE6E70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7FE61D0", Offset = "0x7FE4FD0", VA = "0x187FE61D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LLIKCNAHAKG, LLIKCNAHAKG> FPCDPHEGBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5750", Offset = "0x7FE4550", VA = "0x187FE5750", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7FE57B0", Offset = "0x7FE45B0", VA = "0x187FE57B0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LLIKCNAHAKG, LLIKCNAHAKG, LLIKCNAHAKG> KPIGCDLBHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5870", Offset = "0x7FE4670", VA = "0x187FE5870", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7FE71D0", Offset = "0x7FE5FD0", VA = "0x187FE71D0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE73D0", Offset = "0x7FE61D0", VA = "0x187FE73D0")]
	public NNKJKBECIPO(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5BD0", Offset = "0x7FE49D0", VA = "0x187FE5BD0", Slot = "12")]
	public void DGPDNICIDDD(GameObject JLNNGPHDMLM, LLJNHOLHNEI GCJFGPIMCIB, GILKKONIJPN FHLNHENKGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6230", Offset = "0x7FE5030", VA = "0x187FE6230", Slot = "26")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6300", Offset = "0x7FE5100", VA = "0x187FE6300", Slot = "13")]
	public void FLCGEBIGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6970", Offset = "0x7FE5770", VA = "0x187FE6970", Slot = "14")]
	public void HIMDKAKGPHI(LLIKCNAHAKG IPCPMJOJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5810", Offset = "0x7FE4610", VA = "0x187FE5810", Slot = "15")]
	public void NDMNNAOCPHL(LLIKCNAHAKG IPCPMJOJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5700", Offset = "0x7FE4500", VA = "0x187FE5700", Slot = "22")]
	public bool AKBCIBICHPB(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7FE58D0", Offset = "0x7FE46D0", VA = "0x187FE58D0")]
	internal bool CKEOKCCMLFD([In] KIEGDINFLPG BOIPFNOKGBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6B50", Offset = "0x7FE5950", VA = "0x187FE6B50")]
	internal bool LDMABDDEDGL([In] KIEGDINFLPG BOIPFNOKGBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6790", Offset = "0x7FE5590", VA = "0x187FE6790")]
	internal void HCEDJJLDALH(LLIKCNAHAKG IPCPMJOJNDE, int DFGKLHNJKLF, bool HEAFLCAEALG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5810", Offset = "0x7FE4610", VA = "0x187FE5810")]
	internal bool BNMBBFKFPDG(LLIKCNAHAKG KEAELNPIDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7FE59E0", Offset = "0x7FE47E0", VA = "0x187FE59E0")]
	internal bool CPCCPBELLNA(LLIKCNAHAKG FKMKINLKOOF, int KCMPGCMAGGL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE70E0", Offset = "0x7FE5EE0", VA = "0x187FE70E0", Slot = "16")]
	public void OMLCGINCNNJ(LLIKCNAHAKG IPCPMJOJNDE, HashSet<LLIKCNAHAKG> BFFPDNIKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6ED0", Offset = "0x7FE5CD0", VA = "0x187FE6ED0", Slot = "17")]
	public void OJLMHMEHFPP(LLIKCNAHAKG FKMKINLKOOF, LLIKCNAHAKG MBIBBOJNGAN, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6CA0", Offset = "0x7FE5AA0", VA = "0x187FE6CA0", Slot = "18")]
	public void MHAKJAOHCON(LLIKCNAHAKG LNIDOKHMMAO, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE65D0", Offset = "0x7FE53D0", VA = "0x187FE65D0", Slot = "19")]
	public void GFKJPGKNOGG(LLIKCNAHAKG LNIDOKHMMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6380", Offset = "0x7FE5180", VA = "0x187FE6380")]
	public void GABECEJMBAC([Optional] CDKFIILELLC EOINKBDLADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6DE0", Offset = "0x7FE5BE0", VA = "0x187FE6DE0", Slot = "23")]
	public void NACDPDLMMNM(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7FE69D0", Offset = "0x7FE57D0", VA = "0x187FE69D0", Slot = "20")]
	public JNIBGFPEKJC JIFNPBFPABC(bool MHODODKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7230", Offset = "0x7FE6030", VA = "0x187FE7230", Slot = "21")]
	public JNIBGFPEKJC POLJGIJCHDB(HashSet<Guid> COMGIIMPIFO, bool MHODODKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6990", Offset = "0x7FE5790", VA = "0x187FE6990", Slot = "25")]
	public void IIDOFPKCBLD(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5B20", Offset = "0x7FE4920", VA = "0x187FE5B20", Slot = "24")]
	public void DADBFMLNNMC(JNIBGFPEKJC IELCAHEPMOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class APKNIHMHGIC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly HLGFIGBDGLB<LLIKCNAHAKG, LLIKCNAHAKG> LJILGOIMFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly HLGFIGBDGLB<LLIKCNAHAKG, LLIKCNAHAKG> FPCDPHEGBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly BMJGKBDHKMP<LLIKCNAHAKG, LLIKCNAHAKG, LLIKCNAHAKG> KPIGCDLBHGL;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3EC0", Offset = "0x7FD2CC0", VA = "0x187FD3EC0")]
	public APKNIHMHGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	public void DGPDNICIDDD(NNKJKBECIPO HEJIJKOGOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3D80", Offset = "0x7FD2B80", VA = "0x187FD3D80")]
	public void BHMEJDGBLFH(LLIKCNAHAKG CMDMCJGFCDK, LLIKCNAHAKG CCEEMHPLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3E60", Offset = "0x7FD2C60", VA = "0x187FD3E60")]
	public void NNPLBNJCEIC(LLIKCNAHAKG CMDMCJGFCDK, LLIKCNAHAKG CCEEMHPLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3DE0", Offset = "0x7FD2BE0", VA = "0x187FD3DE0")]
	public void JBPPAKLIMGN(LLIKCNAHAKG MHFMOLFCLCB, LLIKCNAHAKG HCGMLNGABFM, LLIKCNAHAKG CCEEMHPLNFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class LBBPBLELCAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NNKJKBECIPO HEJIJKOGOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private JJPFOLHAFKL LEFGLILMCMC;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public LBBPBLELCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1FC0", Offset = "0x7FE0DC0", VA = "0x187FE1FC0")]
	public void DGPDNICIDDD(NNKJKBECIPO HEJIJKOGOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2100", Offset = "0x7FE0F00", VA = "0x187FE2100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2220", Offset = "0x7FE1020", VA = "0x187FE2220")]
	private void NAAKAKLDAMI(GLHCBKLDIDI DGOGGKOBPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1F50", Offset = "0x7FE0D50", VA = "0x187FE1F50")]
	private void CGBHEFOCDEF(CDKFIILELLC LLBLGOOBCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2110", Offset = "0x7FE0F10", VA = "0x187FE2110")]
	public void LNLLOKNEGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2260", Offset = "0x7FE1060", VA = "0x187FE2260")]
	public void NKBKDHHLMCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FCMOGCABFJB
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LBHPAGEOABK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LOAHJOOKLEP container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LBHPAGEOABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2370", Offset = "0x7FE1170", VA = "0x187FE2370")]
		internal NNKJKBECIPO AHKMGDBLJKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5DA0", Offset = "0x7FD4BA0", VA = "0x187FD5DA0")]
	public static void HNGCEEBEJFD(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5D20", Offset = "0x7FD4B20", VA = "0x187FD5D20")]
	public static void CJPCCHLIAFL(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class IJBDOBAKPMH : IDisposable, HJDBNKHLBLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, JAHIDJOCJLK> FHIBMCACFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly HIMCJJFHNEA BDBONIMCHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private JJCDCPONDCH PHAEOJDOJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NKPLPBPOICL IELCAHEPMOF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker PADLBBLNJBG;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF720", Offset = "0x7FDE520", VA = "0x187FDF720")]
	public IJBDOBAKPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEFA0", Offset = "0x7FDDDA0", VA = "0x187FDEFA0", Slot = "7")]
	public void DGPDNICIDDD(NKPLPBPOICL IELCAHEPMOF, JJCDCPONDCH PHAEOJDOJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF480", Offset = "0x7FDE280", VA = "0x187FDF480", Slot = "5")]
	public void IGDEJDCOPAI(IGBDGGEPFKG GMNBNEJDBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEFE0", Offset = "0x7FDDDE0", VA = "0x187FDEFE0", Slot = "9")]
	public void FGFPHHCEDIE(IGBDGGEPFKG JBLKDDLPMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEDE0", Offset = "0x7FDDBE0", VA = "0x187FDEDE0", Slot = "8")]
	public void BMIDDFHDADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEA90", Offset = "0x7FDD890", VA = "0x187FDEA90", Slot = "10")]
	public void BMCDMAKLPJM(IGBDGGEPFKG IPKDNDNEPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF150", Offset = "0x7FDDF50", VA = "0x187FDF150", Slot = "11")]
	public void FJHCONOBPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF2D0", Offset = "0x7FDE0D0", VA = "0x187FDF2D0")]
	private bool IANJCELGFLB(IGBDGGEPFKG GAHCIOCKFAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class LGOCILKKKEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct NPPJGFHICBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly EBALOEGILLN MBBEFBHPGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> COMGIIMPIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly NJCFHFGHMNO LFDJGEHIJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly NJCFHFGHMNO BBEKHCHKCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool MHODODKLPDJ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool HJCLIABGEHP
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE77C0", Offset = "0x7FE65C0", VA = "0x187FE77C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE8080", Offset = "0x7FE6E80", VA = "0x187FE8080")]
		public NPPJGFHICBO(EBALOEGILLN MBBEFBHPGCB, HashSet<Guid> COMGIIMPIFO, bool MHODODKLPDJ, [Optional] NJCFHFGHMNO LFDJGEHIJBO, [Optional] NJCFHFGHMNO BBEKHCHKCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE7D20", Offset = "0x7FE6B20", VA = "0x187FE7D20")]
		public NJCFHFGHMNO NEJFHFKCOKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE78D0", Offset = "0x7FE66D0", VA = "0x187FE78D0")]
		private NJCFHFGHMNO BHLIMCMEFKN([Out] NJCFHFGHMNO JFHCAGFAHCH, [Out] NJCFHFGHMNO FGJACFMMHHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7FE7B00", Offset = "0x7FE6900", VA = "0x187FE7B00")]
		private NJCFHFGHMNO JEMPKPIMMCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7FE7990", Offset = "0x7FE6790", VA = "0x187FE7990")]
		private void GDPHKCPGGFO(NJCFHFGHMNO IAEDPFELEPA, NJCFHFGHMNO CDDNDINPCCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7FE7EC0", Offset = "0x7FE6CC0", VA = "0x187FE7EC0")]
		private void NNIJPNCMGEF(NJCFHFGHMNO JFHCAGFAHCH, NJCFHFGHMNO FGJACFMMHHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NNKJKBECIPO HEJIJKOGOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NKPLPBPOICL IELCAHEPMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private HJDBNKHLBLG FJCAKNDGAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private JJPFOLHAFKL LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool OJPEMJGPDMH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool JPFIMGNHAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4640", Offset = "0x7FE3440", VA = "0x187FE4640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool ADNMNLCJOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3760", Offset = "0x7FE2560", VA = "0x187FE3760")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3220", Offset = "0x7FE2020", VA = "0x187FE3220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7FE29C0", Offset = "0x7FE17C0", VA = "0x187FE29C0")]
	public void DGPDNICIDDD(NNKJKBECIPO HEJIJKOGOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7FE35F0", Offset = "0x7FE23F0", VA = "0x187FE35F0")]
	public JNIBGFPEKJC JIFNPBFPABC(bool MHODODKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4840", Offset = "0x7FE3640", VA = "0x187FE4840")]
	public JNIBGFPEKJC POLJGIJCHDB(HashSet<Guid> COMGIIMPIFO, bool MHODODKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3F40", Offset = "0x7FE2D40", VA = "0x187FE3F40")]
	public void NACDPDLMMNM(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2920", Offset = "0x7FE1720", VA = "0x187FE2920")]
	public void DADBFMLNNMC(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7FE28F0", Offset = "0x7FE16F0", VA = "0x187FE28F0")]
	public void AOPAFPIBJND(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3D60", Offset = "0x7FE2B60", VA = "0x187FE3D60")]
	private void MMPNPPHKEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2C90", Offset = "0x7FE1A90", VA = "0x187FE2C90")]
	private NJCFHFGHMNO EDCEJGCNLNJ(EBALOEGILLN FNINGPDJHMC, bool MHODODKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2F70", Offset = "0x7FE1D70", VA = "0x187FE2F70")]
	private static void HBCGIIHEEJM(EBALOEGILLN FNINGPDJHMC, bool MHODODKLPDJ, NJCFHFGHMNO JCEFHNCIHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3240", Offset = "0x7FE2040", VA = "0x187FE3240")]
	private void IOGIOGOOEHB(EBALOEGILLN FNINGPDJHMC, bool MHODODKLPDJ, NJCFHFGHMNO JCEFHNCIHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE47B0", Offset = "0x7FE35B0", VA = "0x187FE47B0")]
	private NJCFHFGHMNO PBJICHBNLEE(EBALOEGILLN MBBEFBHPGCB, HashSet<Guid> COMGIIMPIFO, bool MHODODKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2670", Offset = "0x7FE1470", VA = "0x187FE2670")]
	private bool AMIKADGNKOC(JNIBGFPEKJC DGMOHPHGINO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3FD0", Offset = "0x7FE2DD0", VA = "0x187FE3FD0")]
	private bool NEGHBFBHHPJ(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3900", Offset = "0x7FE2700", VA = "0x187FE3900")]
	private bool KMGHKBOFADJ(JNIBGFPEKJC IELCAHEPMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4690", Offset = "0x7FE3490", VA = "0x187FE4690")]
	private static bool OPAINDCFGMB(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7FE23E0", Offset = "0x7FE11E0", VA = "0x187FE23E0")]
	public static bool AKBCIBICHPB(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3920", Offset = "0x7FE2720", VA = "0x187FE3920")]
	private LLIKCNAHAKG LOICMNFMHGK(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3780", Offset = "0x7FE2580", VA = "0x187FE3780")]
	private LLIKCNAHAKG JMLLFLLHCFJ(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3460", Offset = "0x7FE2260", VA = "0x187FE3460")]
	private LLIKCNAHAKG JDAFPJJGCBM(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB500", Offset = "0x7FDA300", VA = "0x187FDB500")]
	private static Guid GCKBHGOOCJM(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3C70", Offset = "0x7FE2A70", VA = "0x187FE3C70")]
	private string MFKIIPHFJON(NJCFHFGHMNO JCEFHNCIHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2D80", Offset = "0x7FE1B80", VA = "0x187FE2D80")]
	private bool EPAOOEJILDH(EBALOEGILLN FNINGPDJHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2A30", Offset = "0x7FE1830", VA = "0x187FE2A30")]
	private static void DOGBBBGBDEO(EBALOEGILLN MBBEFBHPGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public LGOCILKKKEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct KIEGDINFLPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public LLIKCNAHAKG CCEEMHPLNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public LLIKCNAHAKG CMDMCJGFCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int KCMPGCMAGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int EPIHAMIOGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 AHONFNANHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion CFNHDKBODKB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public FMLKFLBIENH CDBCMLCHNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1CF0", Offset = "0x7FE0AF0", VA = "0x187FE1CF0")]
		get
		{
			return default(FMLKFLBIENH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FMLKFLBIENH JGGGAOKOEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1CC0", Offset = "0x7FE0AC0", VA = "0x187FE1CC0")]
		get
		{
			return default(FMLKFLBIENH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1D90", Offset = "0x7FE0B90", VA = "0x187FE1D90")]
	public KIEGDINFLPG(LLIKCNAHAKG CCEEMHPLNFI, LLIKCNAHAKG CMDMCJGFCDK, int KCMPGCMAGGL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface NKPLPBPOICL
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IGBDGGEPFKG KBGGJKBKACF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGPDNICIDDD(CMAGGNHNBPB HEJIJKOGOJP);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JFOIHBDCODL([In] KIEGDINFLPG BOIPFNOKGBJ, bool HEAFLCAEALG = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GHKJPIGACAA(LLIKCNAHAKG HJGHPKLOEIO);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KNIMGCFIBHD(LLIKCNAHAKG FKMKINLKOOF, int KCMPGCMAGGL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CBJCJIKJPLN(LLIKCNAHAKG LNIDOKHMMAO, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JBMJKFPKLHL();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HGIPJFAJBAG(Func<LLIKCNAHAKG, bool> LBAJLANLLDP);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OMLCGINCNNJ(LLIKCNAHAKG IPCPMJOJNDE, HashSet<LLIKCNAHAKG> PIIIMLMMDAH);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<LLIKCNAHAKG> IMJIELIJNBO();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LCFHPMJJDFO(LLIKCNAHAKG IPCPMJOJNDE, [Out] FMLKFLBIENH OGHADPLBFJO);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PGKGKJJNKEE(HIMCJJFHNEA JCDKDANAIEK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool HIMCJJFHNEA(IGBDGGEPFKG FNINGPDJHMC);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface IGBDGGEPFKG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LLIKCNAHAKG EBAIAIAOLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IGBDGGEPFKG BOOKBNFDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FMLKFLBIENH OCNOEGKIILK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool IGMJLHMCHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JAHIDJOCJLK
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONJHMMKMDOB(LLIKCNAHAKG GBHDLIMNBCL, FMLKFLBIENH CCEEMHPLNFI);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JELKKBIJBEL(LLIKCNAHAKG GBHDLIMNBCL, FMLKFLBIENH CCEEMHPLNFI);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFONNEMHDLM(LLIKCNAHAKG GBHDLIMNBCL, FMLKFLBIENH CCEEMHPLNFI);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNEGIKOGCJB(LLIKCNAHAKG GBHDLIMNBCL, FMLKFLBIENH CCEEMHPLNFI);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JAHIDJOCJLK Instantiate(Transform OLPMPAIMKPI);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOGGHIAGAGL();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JJCDCPONDCH
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGPDNICIDDD(Transform OLPMPAIMKPI, JAHIDJOCJLK EJOIDDPJCKI);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JAHIDJOCJLK JFJKIKDMFBH();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPAJFKPKNBM(JAHIDJOCJLK GOEMBOJPCOP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface MICELNLPCAK : KGOHMADMHLM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PIFNGDNHNEJ();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DBKOCABDDDO(Guid ABICANLPDAM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface HJDBNKHLBLG
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGDEJDCOPAI(IGBDGGEPFKG GMNBNEJDBIB);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGPDNICIDDD(NKPLPBPOICL IELCAHEPMOF, JJCDCPONDCH CDIEHECKNFH);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMIDDFHDADA();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGFPHHCEDIE(IGBDGGEPFKG JBLKDDLPMOB);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMCDMAKLPJM(IGBDGGEPFKG IPKDNDNEPFF);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FJHCONOBPFL();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class EBALOEGILLN : IGBDGGEPFKG
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IJKALPHKLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FMLKFLBIENH nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public EBALOEGILLN foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IJKALPHKLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF800", Offset = "0x7FDE600", VA = "0x187FDF800")]
		internal bool CECHNDFPDCN(IGBDGGEPFKG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private FMLKFLBIENH OGHADPLBFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<EBALOEGILLN> GIEBAJEANFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private EBALOEGILLN HBLNBJOOHMC;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public FMLKFLBIENH OCNOEGKIILK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x145FD20", Offset = "0x145EB20", VA = "0x18145FD20", Slot = "6")]
		get
		{
			return default(FMLKFLBIENH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x145F6C0", Offset = "0x145E4C0", VA = "0x18145F6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private EBALOEGILLN CMDMCJGFCDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5400", Offset = "0x7FD4200", VA = "0x187FD5400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IGBDGGEPFKG BOOKBNFDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LLIKCNAHAKG EBAIAIAOLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IGMJLHMCHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5320", Offset = "0x7FD4120", VA = "0x187FD5320", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ICEOINKGIEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD50F0", Offset = "0x7FD3EF0", VA = "0x187FD50F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected EBALOEGILLN EGPDFGOHLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5330", Offset = "0x7FD4130", VA = "0x187FD5330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5B70", Offset = "0x7FD4970", VA = "0x187FD5B70")]
	public EBALOEGILLN(FMLKFLBIENH GCLNCPGMIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD54E0", Offset = "0x7FD42E0", VA = "0x187FD54E0")]
	public EBALOEGILLN JPPKNGDDBDO(FMLKFLBIENH CBIKCLMHEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5880", Offset = "0x7FD4680", VA = "0x187FD5880")]
	public EBALOEGILLN MPKGHPHKDFK(FMLKFLBIENH DOHJJAOJIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5140", Offset = "0x7FD3F40", VA = "0x187FD5140")]
	public EBALOEGILLN EBNLHEFHMEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5630", Offset = "0x7FD4430", VA = "0x187FD5630")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5350", Offset = "0x7FD4150", VA = "0x187FD5350")]
	public EBALOEGILLN IFEBPAKEDOL(FMLKFLBIENH HCGMLNGABFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5A10", Offset = "0x7FD4810", VA = "0x187FD5A10")]
	private static void PGKGKJJNKEE(EBALOEGILLN ECFEHAGEEIC, HIMCJJFHNEA POKDMNFNEPP, bool FKPBIGNOCAD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5A00", Offset = "0x7FD4800", VA = "0x187FD5A00", Slot = "9")]
	public void PGKGKJJNKEE(HIMCJJFHNEA JCDKDANAIEK, bool IIJPEPCOGOJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5780", Offset = "0x7FD4580", VA = "0x187FD5780")]
	public static EBALOEGILLN MPELLBGLNJF(EBALOEGILLN ECFEHAGEEIC, FMLKFLBIENH MCGMMGCHGGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface JJPFOLHAFKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool JPFIMGNHAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool FIGMIMCIHME
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<GLHCBKLDIDI> NAAKAKLDAMI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<CDKFIILELLC> CGBHEFOCDEF;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ONJHMMKMDOB(NNKJKBECIPO HEJIJKOGOJP, GILKKONIJPN ADDEGPDDIFF);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OJLMHMEHFPP(LLIKCNAHAKG FKMKINLKOOF, LLIKCNAHAKG MBIBBOJNGAN, int KCMPGCMAGGL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MHAKJAOHCON(LLIKCNAHAKG LNIDOKHMMAO, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BECAANPJIOA(JNIBGFPEKJC GIPDGGBKMIA, [Optional] CDKFIILELLC EOINKBDLADE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EBOJAJPNCEP
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type KICDHMJGHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5CC0", Offset = "0x7FD4AC0", VA = "0x187FD5CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object ODAOEPEFKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5C20", Offset = "0x7FD4A20", VA = "0x187FD5C20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5C60", Offset = "0x7FD4A60", VA = "0x187FD5C60")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class CPGEGNCJAGJ : JJPFOLHAFKL, IDisposable, GHGFLPEAIKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NNKJKBECIPO HEJIJKOGOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private GILKKONIJPN FHLNHENKGOB;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool JPFIMGNHAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4650", Offset = "0x7FD3450", VA = "0x187FD4650", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool FIGMIMCIHME
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4180", Offset = "0x7FD2F80", VA = "0x187FD4180", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView CGEBGCELNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD43F0", Offset = "0x7FD31F0", VA = "0x187FD43F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<GLHCBKLDIDI> NAAKAKLDAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4350", Offset = "0x7FD3150", VA = "0x187FD4350", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4260", Offset = "0x7FD3060", VA = "0x187FD4260", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<CDKFIILELLC> CGBHEFOCDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD45B0", Offset = "0x7FD33B0", VA = "0x187FD45B0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD41C0", Offset = "0x7FD2FC0", VA = "0x187FD41C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7FD47E0", Offset = "0x7FD35E0", VA = "0x187FD47E0", Slot = "10")]
	public void ONJHMMKMDOB(NNKJKBECIPO HEJIJKOGOJP, GILKKONIJPN FHLNHENKGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4300", Offset = "0x7FD3100", VA = "0x187FD4300", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD46B0", Offset = "0x7FD34B0", VA = "0x187FD46B0", Slot = "11")]
	public void OJLMHMEHFPP(LLIKCNAHAKG FKMKINLKOOF, LLIKCNAHAKG MBIBBOJNGAN, int KCMPGCMAGGL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4480", Offset = "0x7FD3280", VA = "0x187FD4480", Slot = "12")]
	public void MHAKJAOHCON(LLIKCNAHAKG LNIDOKHMMAO, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4050", Offset = "0x7FD2E50", VA = "0x187FD4050", Slot = "13")]
	public void BECAANPJIOA(JNIBGFPEKJC GIPDGGBKMIA, [Optional] CDKFIILELLC EOINKBDLADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4AB0", Offset = "0x7FD38B0", VA = "0x187FD4AB0")]
	[OGGONGCJDAC]
	private void RpcMasterReparentNodes(LLIKCNAHAKG LNIDOKHMMAO, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7FD48B0", Offset = "0x7FD36B0", VA = "0x187FD48B0")]
	[OGGONGCJDAC]
	private void RpcMasterModifyNode(LLIKCNAHAKG FKMKINLKOOF, LLIKCNAHAKG MBIBBOJNGAN, int KCMPGCMAGGL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4EB0", Offset = "0x7FD3CB0", VA = "0x187FD4EB0")]
	[OGGONGCJDAC]
	private void RpcReparentNodes(LLIKCNAHAKG LNIDOKHMMAO, int LNFKCONEHGE, LLIKCNAHAKG HCGMLNGABFM, int CBAMGIAFONH, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB, HIMONOOAFHI OCALDNLMION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4DC0", Offset = "0x7FD3BC0", VA = "0x187FD4DC0")]
	[OGGONGCJDAC]
	private void RpcModifyNode(LLIKCNAHAKG FKMKINLKOOF, int KCMPGCMAGGL, int EPIHAMIOGLB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB, HIMONOOAFHI OCALDNLMION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4870", Offset = "0x7FD3670", VA = "0x187FD4870")]
	[OGGONGCJDAC]
	private void RpcDeserializeConnectableGraph(JNIBGFPEKJC IELCAHEPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public CPGEGNCJAGJ()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, JAHIDJOCJLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7FE50F0", Offset = "0x7FE3EF0", VA = "0x187FE50F0", Slot = "4")]
		private void PGKPFONBFHF(LLIKCNAHAKG GBHDLIMNBCL, FMLKFLBIENH CCEEMHPLNFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4AB0", Offset = "0x7FE38B0", VA = "0x187FE4AB0", Slot = "5")]
		private void CAGHHHHMLOO(LLIKCNAHAKG GBHDLIMNBCL, FMLKFLBIENH CCEEMHPLNFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4F20", Offset = "0x7FE3D20", VA = "0x187FE4F20", Slot = "6")]
		private void MJCLMPGBKAC(LLIKCNAHAKG GBHDLIMNBCL, FMLKFLBIENH CCEEMHPLNFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4D30", Offset = "0x7FE3B30", VA = "0x187FE4D30", Slot = "7")]
		private void GBCHLPEJJCD(LLIKCNAHAKG GBHDLIMNBCL, FMLKFLBIENH CCEEMHPLNFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5080", Offset = "0x7FE3E80", VA = "0x187FE5080", Slot = "8")]
		private JAHIDJOCJLK NGCNAIBELAG(Transform OLPMPAIMKPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4A50", Offset = "0x7FE3850", VA = "0x187FE4A50", Slot = "9")]
		private void BCJIEOEDILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class JEDNNILDKOI
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3BEB000", Offset = "0x3BE9E00", VA = "0x183BEB000")]
	public static IOFNOBJJFOC<T> IMAOLFJDCBJ<T>(this LOAHJOOKLEP CHDHLAGMCKI)
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
