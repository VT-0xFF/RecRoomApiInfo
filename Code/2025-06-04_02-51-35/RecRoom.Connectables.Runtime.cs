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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE530", Offset = "0x7ECCD30", VA = "0x187ECE530", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x21579F0", Offset = "0x21561F0", VA = "0x1821579F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7ED30C0", Offset = "0x7ED18C0", VA = "0x187ED30C0")]
		private void MBKOFANELHN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2F50", Offset = "0x7ED1750", VA = "0x187ED2F50")]
		private void EDNGKHAEMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7ED3230", Offset = "0x7ED1A30", VA = "0x187ED3230", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7ED3560", Offset = "0x7ED1D60", VA = "0x187ED3560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class HBJLCBEIGMC : PLIPKJPCDON, DEPOIAMCLIH
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GKEEMMJLLOG : IEnumerable<PPPEJBOJAOM>, IEnumerable, IEnumerator<PPPEJBOJAOM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private PPPEJBOJAOM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private BMGFKKCFMCO localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BMGFKKCFMCO <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public HBJLCBEIGMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IPIPLKEIAHG <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private KDLFINJPBNM <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private KDLFINJPBNM.NIBDHJHDHFI <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private PPPEJBOJAOM System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public GKEEMMJLLOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8400", Offset = "0x7EC6C00", VA = "0x187EC8400", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7FA0", Offset = "0x7EC67A0", VA = "0x187EC7FA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7F80", Offset = "0x7EC6780", VA = "0x187EC7F80")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7F60", Offset = "0x7EC6760", VA = "0x187EC7F60")]
		private void CLFKDHFELPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7EC83B0", Offset = "0x7EC6BB0", VA = "0x187EC83B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8300", Offset = "0x7EC6B00", VA = "0x187EC8300", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PPPEJBOJAOM> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8300", Offset = "0x7EC6B00", VA = "0x187EC8300", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class HDEPKGGBPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HBJLCBEIGMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public MINGNBNMEMF nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HDEPKGGBPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCF40", Offset = "0x7ECB740", VA = "0x187ECCF40")]
		internal object NGAHJDHAJPM(MINGNBNMEMF x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AIEKHEIDCAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public MINGNBNMEMF child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HDEPKGGBPCC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AIEKHEIDCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF170", Offset = "0x7EBD970", VA = "0x187EBF170")]
		internal object AKFNNDKFONI((MINGNBNMEMF child, MINGNBNMEMF nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly BMELPJIFPCL INAKIBLNAIK;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly BMELPJIFPCL DDHMFDOEFBA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly BMELPJIFPCL NIIAFODCCAA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly BMELPJIFPCL AHOEDEGALJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private HAMJIEEPBNM PCCEBJOBNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KCEOHGNKGFN DPFNGOIDMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private HJKEFICBHPD JBDDNDJKFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PBCMDGMCKCN PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CDHMBEHALEL CAFGHLJIFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private ENMKEMIGGFF NMNLKNBJPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CEJNMCMOCOK NOKFLPEFADE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JNLECKPDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4B0", Offset = "0xA2BCB0", VA = "0x180A2D4B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA2D490", Offset = "0xA2BC90", VA = "0x180A2D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IOGPDPJECEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<PPPEJBOJAOM, PPPEJBOJAOM> KGLOBAGEIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8C10", Offset = "0x7EC7410", VA = "0x187EC8C10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8B60", Offset = "0x7EC7360", VA = "0x187EC8B60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<PPPEJBOJAOM, PPPEJBOJAOM> NMCHLKCILNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7ECBF30", Offset = "0x7ECA730", VA = "0x187ECBF30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB9C0", Offset = "0x7ECA1C0", VA = "0x187ECB9C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<PPPEJBOJAOM, PPPEJBOJAOM, PPPEJBOJAOM> CFFAMFPHBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB070", Offset = "0x7EC9870", VA = "0x187ECB070", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB910", Offset = "0x7ECA110", VA = "0x187ECB910", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCED0", Offset = "0x7ECB6D0", VA = "0x187ECCED0")]
	public HBJLCBEIGMC(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7ECA760", Offset = "0x7EC8F60", VA = "0x187ECA760", Slot = "12")]
	public void IEAMPCKAMFG(GameObject EMOLHEPHCGI, FJCOGDGECNG CLDCCHIABHB, IPIOCEKPADE OHCFIGMIAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7EC84E0", Offset = "0x7EC6CE0", VA = "0x187EC84E0", Slot = "26")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8870", Offset = "0x7EC7070", VA = "0x187EC8870", Slot = "22")]
	public bool BHCIIMHOEIO(MINGNBNMEMF IJCALHAOPEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9350", Offset = "0x7EC7B50", VA = "0x187EC9350")]
	private void EMKOEPKAGFM(BMGFKKCFMCO DMFOEJLEMCI, BMGFKKCFMCO NKEAHDNEPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7EC95C0", Offset = "0x7EC7DC0", VA = "0x187EC95C0")]
	private void FMHHIBIPGFD(BMGFKKCFMCO DMFOEJLEMCI, BMGFKKCFMCO GFJBBEBEBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7ECA500", Offset = "0x7EC8D00", VA = "0x187ECA500")]
	private void HIPHNMAIJDP(BMGFKKCFMCO DMFOEJLEMCI, BMGFKKCFMCO GFJBBEBEBHK, BMGFKKCFMCO NKEAHDNEPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAC60", Offset = "0x7EC9460", VA = "0x187ECAC60")]
	private void IPJJACCFPCN(BMGFKKCFMCO DMFOEJLEMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "13")]
	public void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB210", Offset = "0x7EC9A10", VA = "0x187ECB210", Slot = "14")]
	public void KELFLPPCOLM(PPPEJBOJAOM GFAMPLNMOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "15")]
	public void HIDPNIODDKH(PPPEJBOJAOM GFAMPLNMOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7ECA210", Offset = "0x7EC8A10", VA = "0x187ECA210", Slot = "17")]
	public void GMKAKGNFKFA(PPPEJBOJAOM GFAMPLNMOKM, PPPEJBOJAOM MDDEGKANBMI, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECA0D0", Offset = "0x7EC88D0", VA = "0x187ECA0D0")]
	public void GMKAKGNFKFA(BMGFKKCFMCO LNFGEICLAJH, BMGFKKCFMCO MDDEGKANBMI, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC92C0", Offset = "0x7EC7AC0", VA = "0x187EC92C0")]
	public void ECAJAOAGOCO(PPPEJBOJAOM GFAMPLNMOKM, float GGCNJHLPPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8A00", Offset = "0x7EC7200", VA = "0x187EC8A00", Slot = "18")]
	public void BIEEPBKFECI(PPPEJBOJAOM NCMEEMPLIMB, int JHMBFFBCEKJ, PPPEJBOJAOM IEJHGGLDHAD, int KIBLBOFIGLC, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8FD0", Offset = "0x7EC77D0", VA = "0x187EC8FD0")]
	private float DEDIKGEIAIP(BMGFKKCFMCO LNFGEICLAJH, BMGFKKCFMCO MJNLMOPPION)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7EC88C0", Offset = "0x7EC70C0", VA = "0x187EC88C0")]
	public void BIEEPBKFECI(BMGFKKCFMCO LNFGEICLAJH, BMGFKKCFMCO MJNLMOPPION, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO, bool CJLHPMEOBNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9970", Offset = "0x7EC8170", VA = "0x187EC9970", Slot = "19")]
	public void GEEJAMLGKOF(PPPEJBOJAOM GFAMPLNMOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7ECA9F0", Offset = "0x7EC91F0", VA = "0x187ECA9F0", Slot = "16")]
	public void IGAHMBKCDDM(PPPEJBOJAOM GFAMPLNMOKM, HashSet<PPPEJBOJAOM> EOBJEIOGAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "20")]
	public NIPLJADAEIJ FKOLLFELGGB(bool HLIGGKFJFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "21")]
	public NIPLJADAEIJ FJFFAKMGFDD(HashSet<Guid> MFHOICIJFHM, bool HLIGGKFJFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7ECABF0", Offset = "0x7EC93F0", VA = "0x187ECABF0", Slot = "23")]
	public void IHGIJCDAIBK(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9550", Offset = "0x7EC7D50", VA = "0x187EC9550", Slot = "24")]
	public void FFPDEILBMNJ(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8850", Offset = "0x7EC7050", VA = "0x187EC8850", Slot = "25")]
	public void ANMHHCJLMJG(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB510", Offset = "0x7EC9D10", VA = "0x187ECB510")]
	private void KKGDMEOKFIP(BMGFKKCFMCO LNFGEICLAJH, BMGFKKCFMCO MJNLMOPPION, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO, float GGCNJHLPPIH, bool CJLHPMEOBNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC370", Offset = "0x7ECAB70", VA = "0x187ECC370")]
	private void PICGFONKNEL(BMGFKKCFMCO LNFGEICLAJH, BMGFKKCFMCO OOBPPDKPNFF, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9080", Offset = "0x7EC7880", VA = "0x187EC9080")]
	private void DEOAMGFJOKL(BMGFKKCFMCO LNFGEICLAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCCF0", Offset = "0x7ECB4F0", VA = "0x187ECCCF0")]
	[IteratorStateMachine(typeof(GKEEMMJLLOG))]
	public IEnumerable<PPPEJBOJAOM> PPJCLNKICDJ(BMGFKKCFMCO MIKNGKGCFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBA70", Offset = "0x7ECA270", VA = "0x187ECBA70")]
	internal PPPEJBOJAOM MAMJLPJLCLO(BMGFKKCFMCO MIKNGKGCFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8E50", Offset = "0x7EC7650", VA = "0x187EC8E50")]
	internal BMGFKKCFMCO CLJMENPAMPK(PPPEJBOJAOM GFAMPLNMOKM)
	{
		return default(BMGFKKCFMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9B40", Offset = "0x7EC8340", VA = "0x187EC9B40")]
	private bool GMIJNMCKAGG(MINGNBNMEMF IJCALHAOPEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCC90", Offset = "0x7ECB490", VA = "0x187ECCC90")]
	private bool PNBILNAGBII(MINGNBNMEMF IJCALHAOPEH, [Out] PPPEJBOJAOM MJNLMOPPION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBBA0", Offset = "0x7ECA3A0", VA = "0x187ECBBA0")]
	private PPPEJBOJAOM MAMJLPJLCLO(MINGNBNMEMF IJCALHAOPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7EC86D0", Offset = "0x7EC6ED0", VA = "0x187EC86D0")]
	private PPPEJBOJAOM ALFGDMLLHJN(MINGNBNMEMF IJCALHAOPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7EC90F0", Offset = "0x7EC78F0", VA = "0x187EC90F0")]
	private PPPEJBOJAOM DOKMKPAGMCC(MINGNBNMEMF IJCALHAOPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2A40", Offset = "0x7EC1240", VA = "0x187EC2A40")]
	private static Guid PBAIEOLPLDG(MINGNBNMEMF IJCALHAOPEH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB120", Offset = "0x7EC9920", VA = "0x187ECB120")]
	private string KAFINLPABGD(MINGNBNMEMF IJCALHAOPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8CC0", Offset = "0x7EC74C0", VA = "0x187EC8CC0")]
	private void CILGFGHOCCK(PPPEJBOJAOM LNFGEICLAJH, PPPEJBOJAOM OOBPPDKPNFF, RigidTransform IPFGPMNNMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7ECA370", Offset = "0x7EC8B70", VA = "0x187ECA370")]
	private void GNBGFDMEBJN(PPPEJBOJAOM OOBPPDKPNFF, PPPEJBOJAOM LNFGEICLAJH, RigidTransform IPFGPMNNMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9AE0", Offset = "0x7EC82E0", VA = "0x187EC9AE0")]
	private void GJAHEBMFEAE(PPPEJBOJAOM OFDEGCGBALE, PPPEJBOJAOM LNFGEICLAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC97E0", Offset = "0x7EC7FE0", VA = "0x187EC97E0")]
	private void GCEOGFBGBLI(PPPEJBOJAOM LNFGEICLAJH, PPPEJBOJAOM MJNLMOPPION, RigidTransform IPFGPMNNMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC260", Offset = "0x7ECAA60", VA = "0x187ECC260")]
	private void PCKGJHIINHL(BMGFKKCFMCO MIKNGKGCFKJ, PPPEJBOJAOM GFAMPLNMOKM, BMGFKKCFMCO GFJBBEBEBHK, BMGFKKCFMCO NKEAHDNEPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBFE0", Offset = "0x7ECA7E0", VA = "0x187ECBFE0")]
	private void OACGALDGFIE(BMGFKKCFMCO MIKNGKGCFKJ, PPPEJBOJAOM GFAMPLNMOKM, PPPEJBOJAOM EJGDPCOPGNC, PPPEJBOJAOM OCDACCBEEAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class APOMPOAIJFD
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IDNMNDLCLOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public OIKNHNBNAFI container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IDNMNDLCLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD630", Offset = "0x7ECBE30", VA = "0x187ECD630")]
		internal HBJLCBEIGMC MGJOOKAPJAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF410", Offset = "0x7EBDC10", VA = "0x187EBF410")]
	public static void PEOKBFAFGOK(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF3C0", Offset = "0x7EBDBC0", VA = "0x187EBF3C0")]
	public static void EBHOLJOKOBM(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class OGNDMIHGLNM : IKEKMDEKPHB, FGCAMDFHFMK
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HBJLCBEIGMC KBCAIOJOAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly JCBKFPKEMJF FDBDINAKFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly NGHPHCIBPNM PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HDCPFEOLCDP[] IIAKLPCJPHB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PPPEJBOJAOM JGLEIHNLDOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2480", Offset = "0x7ED0C80", VA = "0x187ED2480", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PPPEJBOJAOM ONNLAMHKJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0CE0", Offset = "0x7ECF4E0", VA = "0x187ED0CE0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 EPIILAPHNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1DF0", Offset = "0x7ED05F0", VA = "0x187ED1DF0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion CBPDKLHHPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1990", Offset = "0x7ED0190", VA = "0x187ED1990", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BJIMFOCODHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1210", Offset = "0x7ECFA10", VA = "0x187ED1210", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<PPPEJBOJAOM> IKBGHPNDJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7ED08B0", Offset = "0x7ECF0B0", VA = "0x187ED08B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool DCFGHIJADFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC9B980", Offset = "0xC9A180", VA = "0x180C9B980", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCCFEA0", Offset = "0xCCE6A0", VA = "0x180CCFEA0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2680", Offset = "0x7ED0E80", VA = "0x187ED2680", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject CBMGDPANAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7ED23A0", Offset = "0x7ED0BA0", VA = "0x187ED23A0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7ED23C0", Offset = "0x7ED0BC0", VA = "0x187ED23C0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid NCMKEBKDODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7ED24E0", Offset = "0x7ED0CE0", VA = "0x187ED24E0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JHEBDJEAKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7ED25C0", Offset = "0x7ED0DC0", VA = "0x187ED25C0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BJMANLABICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool FDGJDDEPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7ED21B0", Offset = "0x7ED09B0", VA = "0x187ED21B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JHFLNGJMMGO PJFIPOCGPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7ED19F0", Offset = "0x7ED01F0", VA = "0x187ED19F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0DA0", Offset = "0x7ECF5A0", VA = "0x187ED0DA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JHFLNGJMMGO PFHEHPNMDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0930", Offset = "0x7ECF130", VA = "0x187ED0930", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7ED18E0", Offset = "0x7ED00E0", VA = "0x187ED18E0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JHFLNGJMMGO GKMHFMKMPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1D90", Offset = "0x7ED0590", VA = "0x187ED1D90", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1560", Offset = "0x7ECFD60", VA = "0x187ED1560", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event NFCAOMMCEPK OLDEBCEANOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED15C0", Offset = "0x7ECFDC0", VA = "0x187ED15C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0A30", Offset = "0x7ECF230", VA = "0x187ED0A30", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7ED22A0", Offset = "0x7ED0AA0", VA = "0x187ED22A0")]
	public OGNDMIHGLNM(BMGFKKCFMCO BDGEMDMFHPC, RigidbodyEx ACGABOLDOKP, JCBKFPKEMJF FDBDINAKFAI, HDCPFEOLCDP[] IIAKLPCJPHB, NGHPHCIBPNM PJHMONPOPCI, PLIPKJPCDON KBCAIOJOAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1660", Offset = "0x7ECFE60", VA = "0x187ED1660", Slot = "19")]
	public void GPGBEHCLMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "21")]
	public void MGLDDHHDJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C44B50", Offset = "0x7C43350", VA = "0x187C44B50", Slot = "22")]
	public void GPNEJIFMJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1890", Offset = "0x7ED0090", VA = "0x187ED1890", Slot = "20")]
	public void IDHAAILNKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0AD0", Offset = "0x7ECF2D0", VA = "0x187ED0AD0", Slot = "25")]
	public void DNFBNBNEBMB(int CCICCCPLFEJ, PPPEJBOJAOM IEJHGGLDHAD, int FLCJLLOKEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1A50", Offset = "0x7ED0250", VA = "0x187ED1A50", Slot = "26")]
	public void KLIDPIFICJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1280", Offset = "0x7ECFA80", VA = "0x187ED1280", Slot = "27")]
	public void FHLEOAOFIAI(int CCICCCPLFEJ, PPPEJBOJAOM NCMEEMPLIMB, int KCONAMHDDOK, [Optional] Vector3? CGHFJMHBGHH, [Optional] Quaternion? LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1B20", Offset = "0x7ED0320", VA = "0x187ED1B20", Slot = "28")]
	public void LBNOMHJCNIJ(PPPEJBOJAOM NCMEEMPLIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0E00", Offset = "0x7ECF600", VA = "0x187ED0E00", Slot = "31")]
	public void FAEDDGLBIHP(Vector3 IBFNBEJCBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1EA0", Offset = "0x7ED06A0", VA = "0x187ED1EA0", Slot = "29")]
	public void NPKGFEOLCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1BA0", Offset = "0x7ED03A0", VA = "0x187ED1BA0", Slot = "30")]
	public void LPPFEICGAEP(int PNJCJGEIDHG, Vector3 HFIBPPGFFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7ED17C0", Offset = "0x7ECFFC0", VA = "0x187ED17C0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int CCICCCPLFEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1690", Offset = "0x7ECFE90", VA = "0x187ED1690", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int CCICCCPLFEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xC79360", Offset = "0xC77B60", VA = "0x180C79360", Slot = "42")]
	public Color GetConnectionSlotColor(int CCICCCPLFEJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0990", Offset = "0x7ECF190", VA = "0x187ED0990", Slot = "43")]
	public bool CanConnectTo(int CCICCCPLFEJ, PPPEJBOJAOM JMKCBNIHHAM, int PMBNIJKMAHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "44")]
	public void ParentChanged(int CCICCCPLFEJ, PPPEJBOJAOM ILEPJMLGBGJ, int JBINMOABDPH, Vector3 IKNAEELKMFO, Quaternion OGGODNJOGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "45")]
	public void ChildAdded(int CCICCCPLFEJ, PPPEJBOJAOM BIBIBNDLBMP, int KHALMIMLECJ, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "46")]
	public void ChildRemoved(int CCICCCPLFEJ, PPPEJBOJAOM KJEGHDIOAIB, int NBCHCFNGODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "47")]
	public void ConnectionModified(int CCICCCPLFEJ, PPPEJBOJAOM IEJHGGLDHAD, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2200", Offset = "0x7ED0A00", VA = "0x187ED2200", Slot = "48")]
	public void RootChanged(PPPEJBOJAOM CDLPDJLPHMO, PPPEJBOJAOM JOEEFKFEMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1940", Offset = "0x7ED0140", VA = "0x187ED1940", Slot = "23")]
	public void JAFHEICHJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1E50", Offset = "0x7ED0650", VA = "0x187ED1E50", Slot = "24")]
	public void NNDJJCNKPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7ED08E0", Offset = "0x7ECF0E0", VA = "0x187ED08E0")]
	private void CJJBFICGDGC(bool HAHECIDGDGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(LEGHIHFCIHK), new string[] { })]
public class CIIKKGJFGBF : LEGHIHFCIHK, JCLLOKFPFOL, FFGPMFMFIPE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DLANNHJDBJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DLANNHJDBJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private MEGKOKINDKJ DLJGBAKBBOP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object MFMHBDEDDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3860", Offset = "0x7EC2060", VA = "0x187EC3860", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3810", Offset = "0x7EC2010", VA = "0x187EC3810", Slot = "5")]
	private void DJHOLMKIEEJ(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1196B40", Offset = "0x1195340", VA = "0x181196B40", Slot = "6")]
	private void BFECBMINEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CIIKKGJFGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(PLIPKJPCDON), new string[] { "Ignore", "Mock" })]
public class HMGIAFAAHBB : PLIPKJPCDON, DEPOIAMCLIH
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool JNLECKPDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IOGPDPJECEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<PPPEJBOJAOM, PPPEJBOJAOM> KGLOBAGEIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD2C0", Offset = "0x7ECBAC0", VA = "0x187ECD2C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD210", Offset = "0x7ECBA10", VA = "0x187ECD210", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<PPPEJBOJAOM, PPPEJBOJAOM> NMCHLKCILNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD580", Offset = "0x7ECBD80", VA = "0x187ECD580", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD4D0", Offset = "0x7ECBCD0", VA = "0x187ECD4D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<PPPEJBOJAOM, PPPEJBOJAOM, PPPEJBOJAOM> CFFAMFPHBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD370", Offset = "0x7ECBB70", VA = "0x187ECD370", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD420", Offset = "0x7ECBC20", VA = "0x187ECD420", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "26")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "12")]
	public void IEAMPCKAMFG(GameObject EMOLHEPHCGI, FJCOGDGECNG CLDCCHIABHB, IPIOCEKPADE MPHHBBDCNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "13")]
	public void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "14")]
	public void KELFLPPCOLM(PPPEJBOJAOM GFAMPLNMOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "15")]
	public void HIDPNIODDKH(PPPEJBOJAOM GFAMPLNMOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "16")]
	public void IGAHMBKCDDM(PPPEJBOJAOM GFAMPLNMOKM, HashSet<PPPEJBOJAOM> EOBJEIOGAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "17")]
	public void GMKAKGNFKFA(PPPEJBOJAOM GFAMPLNMOKM, PPPEJBOJAOM MDDEGKANBMI, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "18")]
	public void BIEEPBKFECI(PPPEJBOJAOM GFAMPLNMOKM, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "19")]
	public void GEEJAMLGKOF(PPPEJBOJAOM GFAMPLNMOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "20")]
	public NIPLJADAEIJ FKOLLFELGGB(bool HLIGGKFJFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "21")]
	public NIPLJADAEIJ FJFFAKMGFDD(HashSet<Guid> MFHOICIJFHM, bool HLIGGKFJFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "22")]
	public bool BHCIIMHOEIO(MINGNBNMEMF IJCALHAOPEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "23")]
	public void IHGIJCDAIBK(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "24")]
	public void FFPDEILBMNJ(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "25")]
	public void ANMHHCJLMJG(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HMGIAFAAHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PPPEJBOJAOM : FGCAMDFHFMK, IEquatable<PPPEJBOJAOM>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FGCAMDFHFMK
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	PPPEJBOJAOM JGLEIHNLDOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject CBMGDPANAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid NCMKEBKDODN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int JHEBDJEAKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BJMANLABICA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int CCICCCPLFEJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int CCICCCPLFEJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int CCICCCPLFEJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int CCICCCPLFEJ, PPPEJBOJAOM JMKCBNIHHAM, int GPIFLICBBNJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int CCICCCPLFEJ, PPPEJBOJAOM ILEPJMLGBGJ, int JBINMOABDPH, Vector3 IKNAEELKMFO, Quaternion OGGODNJOGBI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int CCICCCPLFEJ, PPPEJBOJAOM BIBIBNDLBMP, int KHALMIMLECJ, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int CCICCCPLFEJ, PPPEJBOJAOM KJEGHDIOAIB, int NBCHCFNGODP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int CCICCCPLFEJ, PPPEJBOJAOM IEJHGGLDHAD, int KCOJOMOEABD, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(PPPEJBOJAOM CDLPDJLPHMO, PPPEJBOJAOM JOEEFKFEMIL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PLIPKJPCDON : DEPOIAMCLIH
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool JNLECKPDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IOGPDPJECEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<PPPEJBOJAOM, PPPEJBOJAOM> KGLOBAGEIEA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<PPPEJBOJAOM, PPPEJBOJAOM> NMCHLKCILNI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<PPPEJBOJAOM, PPPEJBOJAOM, PPPEJBOJAOM> CFFAMFPHBEO;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IEAMPCKAMFG(GameObject EMOLHEPHCGI, FJCOGDGECNG CLDCCHIABHB, IPIOCEKPADE IMBANAEPIKK);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JNHFKCNMNLI();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KELFLPPCOLM(PPPEJBOJAOM GFAMPLNMOKM);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HIDPNIODDKH(PPPEJBOJAOM GFAMPLNMOKM);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IGAHMBKCDDM(PPPEJBOJAOM GFAMPLNMOKM, HashSet<PPPEJBOJAOM> EOBJEIOGAMC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GMKAKGNFKFA(PPPEJBOJAOM GFAMPLNMOKM, PPPEJBOJAOM MDDEGKANBMI, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BIEEPBKFECI(PPPEJBOJAOM GFAMPLNMOKM, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GEEJAMLGKOF(PPPEJBOJAOM GFAMPLNMOKM);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NIPLJADAEIJ FKOLLFELGGB(bool HLIGGKFJFIJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NIPLJADAEIJ FJFFAKMGFDD(HashSet<Guid> MFHOICIJFHM, bool HLIGGKFJFIJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BHCIIMHOEIO(MINGNBNMEMF IJCALHAOPEH);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IHGIJCDAIBK(NIPLJADAEIJ OPFJIIPHLBO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FFPDEILBMNJ(NIPLJADAEIJ OPFJIIPHLBO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ANMHHCJLMJG(NIPLJADAEIJ OPFJIIPHLBO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PBCMDGMCKCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IHCLLIGFBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PPPEJBOJAOM DOKMKPAGMCC(int NNKHKOELHFF);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PPPEJBOJAOM ALFGDMLLHJN(Guid DILGAGCILPH);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HBHIDJBHHCL(PPPEJBOJAOM GFAMPLNMOKM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LOLHNHOAJNN();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHAJBAMDKEE(PPPEJBOJAOM FDBDINAKFAI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface NGHPHCIBPNM
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDGJDDEPNBF(JCBKFPKEMJF FDBDINAKFAI);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ANDELKEECNG(JCBKFPKEMJF FDBDINAKFAI);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string DLGIOPODMEM(JCBKFPKEMJF FDBDINAKFAI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid GMFPCIFLCFO(JCBKFPKEMJF FDBDINAKFAI);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KKEFDMBFFHH(JCBKFPKEMJF FDBDINAKFAI);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AOMBMOIHGMB(JCBKFPKEMJF FDBDINAKFAI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void JHFLNGJMMGO(PPPEJBOJAOM NCMEEMPLIMB, int DHEPFNDDHNC, PPPEJBOJAOM IEJHGGLDHAD, int AEGDGENAJDA, [Optional] Vector3? CGHFJMHBGHH, [Optional] Quaternion? LHADJKBBBLM);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void NFCAOMMCEPK(PPPEJBOJAOM CDLPDJLPHMO, PPPEJBOJAOM JOEEFKFEMIL);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JCBKFPKEMJF : PPPEJBOJAOM, FGCAMDFHFMK, IEquatable<PPPEJBOJAOM>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IKEKMDEKPHB : FGCAMDFHFMK
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PPPEJBOJAOM ONNLAMHKJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<PPPEJBOJAOM> IKBGHPNDJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 EPIILAPHNCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion CBPDKLHHPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool BJIMFOCODHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool DCFGHIJADFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event JHFLNGJMMGO PJFIPOCGPPF;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event JHFLNGJMMGO PFHEHPNMDLB;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event JHFLNGJMMGO GKMHFMKMPMI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event NFCAOMMCEPK OLDEBCEANOK;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GPGBEHCLMLG();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IDHAAILNKGM();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MGLDDHHDJOA();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GPNEJIFMJLF();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JAFHEICHJEJ();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NNDJJCNKPDG();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DNFBNBNEBMB(int CCICCCPLFEJ, PPPEJBOJAOM IEJHGGLDHAD, int FLCJLLOKEIM);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KLIDPIFICJP();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void FHLEOAOFIAI(int CCICCCPLFEJ, PPPEJBOJAOM NCMEEMPLIMB, int KCONAMHDDOK, [Optional] Vector3? CGHFJMHBGHH, [Optional] Quaternion? LHADJKBBBLM);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LBNOMHJCNIJ(PPPEJBOJAOM NCMEEMPLIMB);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NPKGFEOLCMP();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LPPFEICGAEP(int PNJCJGEIDHG, Vector3 HFIBPPGFFAG);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FAEDDGLBIHP(Vector3 IBFNBEJCBAD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HDCPFEOLCDP
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 JCPGLBEAKMP
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
public interface FJCOGDGECNG
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DDIGEHADJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ALMDJEEMGMB JBALNLDNPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, FJCOGDGECNG
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
			[Cpp2IlInjected.Address(RVA = "0xA76470", Offset = "0xA74C70", VA = "0x180A76470", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ALMDJEEMGMB LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3960", Offset = "0x7EC2160", VA = "0x187EC3960")]
		public static ConnectableConfigData HDJNEPBHMOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3A20", Offset = "0x7EC2220", VA = "0x187EC3A20")]
		public ConnectableConfigData(LegacyConnectableLinkVisual JBKHIJNDECH, bool OLKLOBNKCKH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BBJGBJEBCID : IEquatable<BBJGBJEBCID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public PPPEJBOJAOM GFAMPLNMOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int MPDDLGFNLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int KCOJOMOEABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 CGHFJMHBGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion LHADJKBBBLM;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7EBFB20", Offset = "0x7EBE320", VA = "0x187EBFB20")]
	public BBJGBJEBCID(PPPEJBOJAOM GFAMPLNMOKM, int MPDDLGFNLIA, int KCOJOMOEABD, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7EBFA00", Offset = "0x7EBE200", VA = "0x187EBFA00")]
	public BBJGBJEBCID(PPPEJBOJAOM GFAMPLNMOKM, int MPDDLGFNLIA, int KCOJOMOEABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7EBFAA0", Offset = "0x7EBE2A0", VA = "0x187EBFAA0")]
	public BBJGBJEBCID(PPPEJBOJAOM GFAMPLNMOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF590", Offset = "0x7EBDD90", VA = "0x187EBF590", Slot = "4")]
	public bool Equals(BBJGBJEBCID KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF640", Offset = "0x7EBDE40", VA = "0x187EBF640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class KOADKCHEJEJ : JODDNOEHNEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform KCODNJGBFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private ALMDJEEMGMB BHMLGGOCOHA;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x78AF4E0", Offset = "0x78ADCE0", VA = "0x1878AF4E0", Slot = "4")]
	public void IEAMPCKAMFG(Transform KCODNJGBFEK, ALMDJEEMGMB BHMLGGOCOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDB90", Offset = "0x7ECC390", VA = "0x187ECDB90", Slot = "5")]
	public ALMDJEEMGMB INFLPLKFMHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDB20", Offset = "0x7ECC320", VA = "0x187ECDB20", Slot = "6")]
	public void DJOPOCPDKFN(ALMDJEEMGMB MJCANLPGHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public KOADKCHEJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class GIIINHIJEPA : IDisposable, IAHFLOMMMFK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KBKCPEOCLAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public PPPEJBOJAOM oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public PPPEJBOJAOM newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KBKCPEOCLAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD8A0", Offset = "0x7ECC0A0", VA = "0x187ECD8A0")]
		internal bool OBLHNPNDLBD(EDECLBBIOKJ node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly CIFPDFMJLAI OLFBBBLMAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private ECEJOJHMKDG KMOHFFDDNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private HIFJMHNOCFL CGEDDGPEAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool OLKLOBNKCKH;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly BMELPJIFPCL DKAMBLIOGIA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public EDECLBBIOKJ LCHPFLHNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7250", Offset = "0x7EC5A50", VA = "0x187EC7250")]
	public bool NHIDPIJPJFM([In] MNKALELAPLA IMINNNCPCJF, bool CIBIFGHHMLF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7EC55D0", Offset = "0x7EC3DD0", VA = "0x187EC55D0")]
	private bool FOMLAJINBBI([In] MNKALELAPLA IMINNNCPCJF, bool CIBIFGHHMLF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7D90", Offset = "0x7EC6590", VA = "0x187EC7D90")]
	public GIIINHIJEPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6D80", Offset = "0x7EC5580", VA = "0x187EC6D80", Slot = "5")]
	public void IEAMPCKAMFG(PLIPKJPCDON EGOJLGMOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC55A0", Offset = "0x7EC3DA0", VA = "0x187EC55A0", Slot = "17")]
	public void FIHKIGAENJF(IIOKPLABNAM LKHIOLGKDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5210", Offset = "0x7EC3A10", VA = "0x187EC5210", Slot = "12")]
	public void EFIABMPIOAI(Func<PPPEJBOJAOM, bool> HCFMNEKCAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7EC50E0", Offset = "0x7EC38E0", VA = "0x187EC50E0")]
	private void EFIABMPIOAI(CIFPDFMJLAI CJEDGIAKFCF, Func<PPPEJBOJAOM, bool> HCFMNEKCAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC71D0", Offset = "0x7EC59D0", VA = "0x187EC71D0", Slot = "11")]
	public void IGJLPIFIGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4EF0", Offset = "0x7EC36F0", VA = "0x187EC4EF0", Slot = "8")]
	public bool CLJJEOKGEHO(PPPEJBOJAOM PBHBHBGLABE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6330", Offset = "0x7EC4B30", VA = "0x187EC6330")]
	private bool HFDPKDAEGDL(PPPEJBOJAOM BGKDIEGHMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7EC74E0", Offset = "0x7EC5CE0", VA = "0x187EC74E0")]
	private static bool NCMPJDNKJCL(PPPEJBOJAOM BGKDIEGHMCF, CIFPDFMJLAI EAACHNLFNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5D60", Offset = "0x7EC4560", VA = "0x187EC5D60")]
	private void GKKGDEEPOPN(Transform ALBLCKLOFEA, CIFPDFMJLAI AIBGDJAEOEP, CIFPDFMJLAI[] NCLGKDJHIDC, PPPEJBOJAOM JINKDGGOBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7260", Offset = "0x7EC5A60", VA = "0x187EC7260")]
	private BBJGBJEBCID LFKOODEHCOJ(Transform JBOCABGGMJL, BBJGBJEBCID CBEJLAFAHHC)
	{
		return default(BBJGBJEBCID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6B60", Offset = "0x7EC5360", VA = "0x187EC6B60")]
	private static bool IBODEIEPECB(CIFPDFMJLAI EAACHNLFNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6D20", Offset = "0x7EC5520", VA = "0x187EC6D20", Slot = "9")]
	public bool ICCHFPGFDNP(PPPEJBOJAOM EFCGGCHGIPP, int KCONAMHDDOK, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5220", Offset = "0x7EC3A20", VA = "0x187EC5220")]
	private bool EFLFLECJHOH(PPPEJBOJAOM EFCGGCHGIPP, int KCONAMHDDOK, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4F00", Offset = "0x7EC3700", VA = "0x187EC4F00")]
	private static void DJCNMJCPMKI(PPPEJBOJAOM EFCGGCHGIPP, int KCONAMHDDOK, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM, CIFPDFMJLAI IHDLIODAPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4DD0", Offset = "0x7EC35D0", VA = "0x187EC4DD0")]
	private void CILGFGHOCCK(PPPEJBOJAOM MPLDCOIMIFI, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC49E0", Offset = "0x7EC31E0", VA = "0x187EC49E0")]
	private void ADBABNEIMMA(CIFPDFMJLAI CJEDGIAKFCF, PPPEJBOJAOM EJGDPCOPGNC, PPPEJBOJAOM OCDACCBEEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4A50", Offset = "0x7EC3250", VA = "0x187EC4A50")]
	private void ADBABNEIMMA(PPPEJBOJAOM GFAMPLNMOKM, PPPEJBOJAOM EJGDPCOPGNC, PPPEJBOJAOM OCDACCBEEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7690", Offset = "0x7EC5E90", VA = "0x187EC7690")]
	private void OACGALDGFIE(PPPEJBOJAOM GFAMPLNMOKM, PPPEJBOJAOM EJGDPCOPGNC, PPPEJBOJAOM OCDACCBEEAO, bool FCENCLOFOHA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7590", Offset = "0x7EC5D90", VA = "0x187EC7590")]
	private void OACGALDGFIE(CIFPDFMJLAI MJAMEBJFAIN, PPPEJBOJAOM JINKDGGOBGF, PPPEJBOJAOM JOEEFKFEMIL, bool FCENCLOFOHA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6140", Offset = "0x7EC4940", VA = "0x187EC6140")]
	private void GNBGFDMEBJN(PPPEJBOJAOM LNFGEICLAJH, int KCONAMHDDOK, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5B90", Offset = "0x7EC4390", VA = "0x187EC5B90")]
	private void GJAHEBMFEAE(EDECLBBIOKJ MJNLMOPPION, EDECLBBIOKJ FPMEKPDHNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4C70", Offset = "0x7EC3470", VA = "0x187EC4C70", Slot = "18")]
	public PPPEJBOJAOM BKMJDBCFBHA(PPPEJBOJAOM GFAMPLNMOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6E30", Offset = "0x7EC5630", VA = "0x187EC6E30", Slot = "13")]
	public void IGAHMBKCDDM(PPPEJBOJAOM GFAMPLNMOKM, HashSet<PPPEJBOJAOM> LNDKCCANMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6920", Offset = "0x7EC5120", VA = "0x187EC6920", Slot = "14")]
	public List<PPPEJBOJAOM> HIGNNBEONIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6260", Offset = "0x7EC4A60", VA = "0x187EC6260")]
	protected EDECLBBIOKJ HFBILBCMOAN(EDECLBBIOKJ CJEDGIAKFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4AC0", Offset = "0x7EC32C0", VA = "0x187EC4AC0")]
	protected CIFPDFMJLAI[] AGDHCFJIEBD(CIFPDFMJLAI EAACHNLFNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4B60", Offset = "0x7EC3360", VA = "0x187EC4B60")]
	protected bool BCEOOOLNJLM(PPPEJBOJAOM GFAMPLNMOKM, [Out] CIFPDFMJLAI CJEDGIAKFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7EC73B0", Offset = "0x7EC5BB0", VA = "0x187EC73B0", Slot = "15")]
	public bool LKCAAGMHAKP(PPPEJBOJAOM GFAMPLNMOKM, [Out] BBJGBJEBCID HGHLKMJAKCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7700", Offset = "0x7EC5F00", VA = "0x187EC7700")]
	protected CIFPDFMJLAI OEMOMIMFPPK(BBJGBJEBCID GKPHGFBHHFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7EC71F0", Offset = "0x7EC59F0", VA = "0x187EC71F0", Slot = "10")]
	public bool JIIOCACHBBD(PPPEJBOJAOM MPLDCOIMIFI, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7740", Offset = "0x7EC5F40", VA = "0x187EC7740")]
	private bool PKMNJLCNMCM(PPPEJBOJAOM MPLDCOIMIFI, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC54D0", Offset = "0x7EC3CD0", VA = "0x187EC54D0")]
	private static bool FGKANIJEDHP(CIFPDFMJLAI KFCIOEHGFGE, BBJGBJEBCID DKNDDAJCAHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7250", Offset = "0x7EC5A50", VA = "0x187EC7250", Slot = "7")]
	private bool KAJNGEAODLN([In] MNKALELAPLA IMINNNCPCJF, bool CIBIFGHHMLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class MEHOCGECLGB : PLIPKJPCDON, DEPOIAMCLIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly OIKNHNBNAFI MBKOPLBCEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly HIFJMHNOCFL CGEDDGPEAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly PJHILBNEAOP HBPHPIFLAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly CBNADINPBKJ PCOOLHCJLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly IAHFLOMMMFK OPFJIIPHLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal LILEJBCBHKM PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal EBFDGENNCCG FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal ECEJOJHMKDG FOPIBKAGCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool OLKLOBNKCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool KBOKDKMHPDB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HPOKCJAONCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xC81BE0", Offset = "0xC803E0", VA = "0x180C81BE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x136EFB0", Offset = "0x136D7B0", VA = "0x18136EFB0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool JNLECKPDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1155DC0", Offset = "0x11545C0", VA = "0x181155DC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x26C1D70", Offset = "0x26C0570", VA = "0x1826C1D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IOGPDPJECEL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<PPPEJBOJAOM, PPPEJBOJAOM> KGLOBAGEIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE9D0", Offset = "0x7ECD1D0", VA = "0x187ECE9D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE970", Offset = "0x7ECD170", VA = "0x187ECE970", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<PPPEJBOJAOM, PPPEJBOJAOM> NMCHLKCILNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0210", Offset = "0x7ECEA10", VA = "0x187ED0210", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFEA0", Offset = "0x7ECE6A0", VA = "0x187ECFEA0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<PPPEJBOJAOM, PPPEJBOJAOM, PPPEJBOJAOM> CFFAMFPHBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFD40", Offset = "0x7ECE540", VA = "0x187ECFD40", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFE40", Offset = "0x7ECE640", VA = "0x187ECFE40", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0380", Offset = "0x7ECEB80", VA = "0x187ED0380")]
	public MEHOCGECLGB(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF5C0", Offset = "0x7ECDDC0", VA = "0x187ECF5C0", Slot = "12")]
	public void IEAMPCKAMFG(GameObject EMOLHEPHCGI, FJCOGDGECNG CLDCCHIABHB, IPIOCEKPADE IMBANAEPIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE6D0", Offset = "0x7ECCED0", VA = "0x187ECE6D0", Slot = "26")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFDA0", Offset = "0x7ECE5A0", VA = "0x187ECFDA0", Slot = "13")]
	public void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFE20", Offset = "0x7ECE620", VA = "0x187ECFE20", Slot = "14")]
	public void KELFLPPCOLM(PPPEJBOJAOM GFAMPLNMOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF560", Offset = "0x7ECDD60", VA = "0x187ECF560", Slot = "15")]
	public void HIDPNIODDKH(PPPEJBOJAOM GFAMPLNMOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE7E0", Offset = "0x7ECCFE0", VA = "0x187ECE7E0", Slot = "22")]
	public bool BHCIIMHOEIO(MINGNBNMEMF IJCALHAOPEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0270", Offset = "0x7ECEA70", VA = "0x187ED0270")]
	internal bool PKMNJLCNMCM([In] MNKALELAPLA IMINNNCPCJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF410", Offset = "0x7ECDC10", VA = "0x187ECF410")]
	internal bool HHAFIOGEEMB([In] MNKALELAPLA IMINNNCPCJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0030", Offset = "0x7ECE830", VA = "0x187ED0030")]
	internal void NIOKPEBOOCL(PPPEJBOJAOM GFAMPLNMOKM, int DGMBOHHBELE, bool CIBIFGHHMLF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF560", Offset = "0x7ECDD60", VA = "0x187ECF560")]
	internal bool OBIFBIIJPDL(PPPEJBOJAOM NILCDEOMKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFF00", Offset = "0x7ECE700", VA = "0x187ECFF00")]
	internal bool MCCBFGPGFIN(PPPEJBOJAOM EFCGGCHGIPP, int KCONAMHDDOK, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFBC0", Offset = "0x7ECE3C0", VA = "0x187ECFBC0", Slot = "16")]
	public void IGAHMBKCDDM(PPPEJBOJAOM GFAMPLNMOKM, HashSet<PPPEJBOJAOM> EOBJEIOGAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF200", Offset = "0x7ECDA00", VA = "0x187ECF200", Slot = "17")]
	public void GMKAKGNFKFA(PPPEJBOJAOM EFCGGCHGIPP, PPPEJBOJAOM MDDEGKANBMI, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE830", Offset = "0x7ECD030", VA = "0x187ECE830", Slot = "18")]
	public void BIEEPBKFECI(PPPEJBOJAOM MPLDCOIMIFI, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF040", Offset = "0x7ECD840", VA = "0x187ECF040", Slot = "19")]
	public void GEEJAMLGKOF(PPPEJBOJAOM MPLDCOIMIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEA30", Offset = "0x7ECD230", VA = "0x187ECEA30")]
	public void CJLKNCBOHCB([Optional] EIGONBNGIIK MJJJAOPAIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFCB0", Offset = "0x7ECE4B0", VA = "0x187ECFCB0", Slot = "23")]
	public void IHGIJCDAIBK(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEEC0", Offset = "0x7ECD6C0", VA = "0x187ECEEC0", Slot = "20")]
	public NIPLJADAEIJ FKOLLFELGGB(bool HLIGGKFJFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7ECED20", Offset = "0x7ECD520", VA = "0x187ECED20", Slot = "21")]
	public NIPLJADAEIJ FJFFAKMGFDD(HashSet<Guid> MFHOICIJFHM, bool HLIGGKFJFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE7A0", Offset = "0x7ECCFA0", VA = "0x187ECE7A0", Slot = "25")]
	public void ANMHHCJLMJG(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEC70", Offset = "0x7ECD470", VA = "0x187ECEC70", Slot = "24")]
	public void FFPDEILBMNJ(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class HIFJMHNOCFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly EGCONEOAIAE<PPPEJBOJAOM, PPPEJBOJAOM> KGLOBAGEIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly EGCONEOAIAE<PPPEJBOJAOM, PPPEJBOJAOM> NMCHLKCILNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly LHOJEGADNEI<PPPEJBOJAOM, PPPEJBOJAOM, PPPEJBOJAOM> CFFAMFPHBEO;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD0F0", Offset = "0x7ECB8F0", VA = "0x187ECD0F0")]
	public HIFJMHNOCFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	public void IEAMPCKAMFG(MEHOCGECLGB EGOJLGMOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD090", Offset = "0x7ECB890", VA = "0x187ECD090")]
	public void NPEGFONCAOE(PPPEJBOJAOM MJNLMOPPION, PPPEJBOJAOM LNFGEICLAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCFB0", Offset = "0x7ECB7B0", VA = "0x187ECCFB0")]
	public void JFGEMKIIEPM(PPPEJBOJAOM MJNLMOPPION, PPPEJBOJAOM LNFGEICLAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD010", Offset = "0x7ECB810", VA = "0x187ECD010")]
	public void KAGCPBCLMMK(PPPEJBOJAOM OFDEGCGBALE, PPPEJBOJAOM OOBPPDKPNFF, PPPEJBOJAOM LNFGEICLAJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class PJHILBNEAOP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private MEHOCGECLGB EGOJLGMOLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private EBFDGENNCCG FLIPFCGMCOP;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PJHILBNEAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2A40", Offset = "0x7ED1240", VA = "0x187ED2A40")]
	public void IEAMPCKAMFG(MEHOCGECLGB EGOJLGMOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2920", Offset = "0x7ED1120", VA = "0x187ED2920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2B80", Offset = "0x7ED1380", VA = "0x187ED2B80")]
	private void LCGFLBJBMDO(GBNNBLFIGLH FIOLDALLLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2BC0", Offset = "0x7ED13C0", VA = "0x187ED2BC0")]
	private void NCFLGNMOMLP(EIGONBNGIIK LJBMHOEFMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2930", Offset = "0x7ED1130", VA = "0x187ED2930")]
	public void ENNGKFCFPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2C30", Offset = "0x7ED1430", VA = "0x187ED2C30")]
	public void PPMDLMIJFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PIKMLDLBFCA
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ABNOPFKEELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public OIKNHNBNAFI container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ABNOPFKEELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7EBE200", Offset = "0x7EBCA00", VA = "0x187EBE200")]
		internal MEHOCGECLGB MGJOOKAPJAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2720", Offset = "0x7ED0F20", VA = "0x187ED2720")]
	public static void PEOKBFAFGOK(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7ED26A0", Offset = "0x7ED0EA0", VA = "0x187ED26A0")]
	public static void EBHOLJOKOBM(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class ACGKJOEILJB : IDisposable, ECEJOJHMKDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, ALMDJEEMGMB> BLFJBCKFGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly IIOKPLABNAM CGAKECPDBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private JODDNOEHNEL GIJBBJGBHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private IAHFLOMMMFK OPFJIIPHLBO;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker FLFOGCIOLDE;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF090", Offset = "0x7EBD890", VA = "0x187EBF090")]
	public ACGKJOEILJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE670", Offset = "0x7EBCE70", VA = "0x187EBE670", Slot = "7")]
	public void IEAMPCKAMFG(IAHFLOMMMFK OPFJIIPHLBO, JODDNOEHNEL GIJBBJGBHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE8F0", Offset = "0x7EBD0F0", VA = "0x187EBE8F0", Slot = "5")]
	public void LKPIJIDACCM(EDECLBBIOKJ PIMIELEAHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE6B0", Offset = "0x7EBCEB0", VA = "0x187EBE6B0", Slot = "9")]
	public void JFEOJMEKCAO(EDECLBBIOKJ BHEEGMEGBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7EBEE70", Offset = "0x7EBD670", VA = "0x187EBEE70", Slot = "8")]
	public void MMPNBGGOJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE270", Offset = "0x7EBCA70", VA = "0x187EBE270", Slot = "10")]
	public void BBGDNOLNEIG(EDECLBBIOKJ JLGIALCFBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7EBECC0", Offset = "0x7EBD4C0", VA = "0x187EBECC0", Slot = "11")]
	public void MJGOKECPDKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE4C0", Offset = "0x7EBCCC0", VA = "0x187EBE4C0")]
	private bool DJDCAKDDMDB(EDECLBBIOKJ IHGBDKLNHAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class CBNADINPBKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct BCKDJFPFIAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly CIFPDFMJLAI NAFDMHMLFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> MFHOICIJFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly MINGNBNMEMF FLEALIOHMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly MINGNBNMEMF MMOFOEMLBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool HLIGGKFJFIJ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool LIDCEJOKDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7EBFE00", Offset = "0x7EBE600", VA = "0x187EBFE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC0440", Offset = "0x7EBEC40", VA = "0x187EC0440")]
		public BCKDJFPFIAB(CIFPDFMJLAI NAFDMHMLFMF, HashSet<Guid> MFHOICIJFHM, bool HLIGGKFJFIJ, [Optional] MINGNBNMEMF FLEALIOHMFJ, [Optional] MINGNBNMEMF MMOFOEMLBMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFF10", Offset = "0x7EBE710", VA = "0x187EBFF10")]
		public MINGNBNMEMF GJCNJFECIPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFD40", Offset = "0x7EBE540", VA = "0x187EBFD40")]
		private MINGNBNMEMF CLKHFFIKNAP([Out] MINGNBNMEMF KJIBICBPMMJ, [Out] MINGNBNMEMF JHOKCDAAFEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7EC00B0", Offset = "0x7EBE8B0", VA = "0x187EC00B0")]
		private MINGNBNMEMF JMCBEOAEFJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7EC02D0", Offset = "0x7EBEAD0", VA = "0x187EC02D0")]
		private void ODKODEFDKGM(MINGNBNMEMF LLHKBFJPLDI, MINGNBNMEMF JAJAHMOJAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFB80", Offset = "0x7EBE380", VA = "0x187EBFB80")]
		private void AEMKDIEENOG(MINGNBNMEMF KJIBICBPMMJ, MINGNBNMEMF JHOKCDAAFEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private MEHOCGECLGB EGOJLGMOLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private IAHFLOMMMFK OPFJIIPHLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private ECEJOJHMKDG KMOHFFDDNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EBFDGENNCCG FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool BAPMFMDGFIH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool BJCEJBEDHKP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2690", Offset = "0x7EC0E90", VA = "0x187EC2690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool HPOKCJAONCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7EC20A0", Offset = "0x7EC08A0", VA = "0x187EC20A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7EC1F90", Offset = "0x7EC0790", VA = "0x187EC1F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1BE0", Offset = "0x7EC03E0", VA = "0x187EC1BE0")]
	public void IEAMPCKAMFG(MEHOCGECLGB EGOJLGMOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1280", Offset = "0x7EBFA80", VA = "0x187EC1280")]
	public NIPLJADAEIJ FKOLLFELGGB(bool HLIGGKFJFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7EC10E0", Offset = "0x7EBF8E0", VA = "0x187EC10E0")]
	public NIPLJADAEIJ FJFFAKMGFDD(HashSet<Guid> MFHOICIJFHM, bool HLIGGKFJFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1C50", Offset = "0x7EC0450", VA = "0x187EC1C50")]
	public void IHGIJCDAIBK(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1040", Offset = "0x7EBF840", VA = "0x187EC1040")]
	public void FFPDEILBMNJ(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2A10", Offset = "0x7EC1210", VA = "0x187EC2A10")]
	public void OHLFAPHFABJ(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0610", Offset = "0x7EBEE10", VA = "0x187EC0610")]
	private void AOFIMLMLAEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0D40", Offset = "0x7EBF540", VA = "0x187EC0D40")]
	private MINGNBNMEMF CFOBOBFJEAI(CIFPDFMJLAI CJEDGIAKFCF, bool HLIGGKFJFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1CE0", Offset = "0x7EC04E0", VA = "0x187EC1CE0")]
	private static void JBPOGLNIHCA(CIFPDFMJLAI CJEDGIAKFCF, bool HLIGGKFJFIJ, MINGNBNMEMF IJCALHAOPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC27F0", Offset = "0x7EC0FF0", VA = "0x187EC27F0")]
	private void NLDFEBLFOJJ(CIFPDFMJLAI CJEDGIAKFCF, bool HLIGGKFJFIJ, MINGNBNMEMF IJCALHAOPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0E30", Offset = "0x7EBF630", VA = "0x187EC0E30")]
	private MINGNBNMEMF CKJOMFGGCNH(CIFPDFMJLAI NAFDMHMLFMF, HashSet<Guid> MFHOICIJFHM, bool HLIGGKFJFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7EC20C0", Offset = "0x7EC08C0", VA = "0x187EC20C0")]
	private bool LJLCBGMADKL(NIPLJADAEIJ OHNHPAHDOON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC13F0", Offset = "0x7EBFBF0", VA = "0x187EC13F0")]
	private bool GMIJNMCKAGG(MINGNBNMEMF IJCALHAOPEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7EC05F0", Offset = "0x7EBEDF0", VA = "0x187EC05F0")]
	private bool ALBKJEPJOFG(NIPLJADAEIJ OPFJIIPHLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7EC26E0", Offset = "0x7EC0EE0", VA = "0x187EC26E0")]
	private static bool NDCJBDBOJGA(MINGNBNMEMF IJCALHAOPEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7EC07F0", Offset = "0x7EBEFF0", VA = "0x187EC07F0")]
	public static bool BHCIIMHOEIO(MINGNBNMEMF IJCALHAOPEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2340", Offset = "0x7EC0B40", VA = "0x187EC2340")]
	private PPPEJBOJAOM MAMJLPJLCLO(MINGNBNMEMF IJCALHAOPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0EC0", Offset = "0x7EBF6C0", VA = "0x187EC0EC0")]
	private PPPEJBOJAOM DOKMKPAGMCC(MINGNBNMEMF IJCALHAOPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1A50", Offset = "0x7EC0250", VA = "0x187EC1A50")]
	private PPPEJBOJAOM IAEMINIJCKO(MINGNBNMEMF IJCALHAOPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2A40", Offset = "0x7EC1240", VA = "0x187EC2A40")]
	private static Guid PBAIEOLPLDG(MINGNBNMEMF IJCALHAOPEH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1FB0", Offset = "0x7EC07B0", VA = "0x187EC1FB0")]
	private string KAFINLPABGD(MINGNBNMEMF IJCALHAOPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2A80", Offset = "0x7EC1280", VA = "0x187EC2A80")]
	private bool PILKEOELCCJ(CIFPDFMJLAI CJEDGIAKFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0A80", Offset = "0x7EBF280", VA = "0x187EC0A80")]
	private static void CDNCFCPOHLM(CIFPDFMJLAI NAFDMHMLFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CBNADINPBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct MNKALELAPLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public PPPEJBOJAOM LNFGEICLAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public PPPEJBOJAOM MJNLMOPPION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int KCONAMHDDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int FLCJLLOKEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 CGHFJMHBGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion LHADJKBBBLM;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BBJGBJEBCID NNIJCLBFAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0770", Offset = "0x7ECEF70", VA = "0x187ED0770")]
		get
		{
			return default(BBJGBJEBCID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BBJGBJEBCID KPKBBKHAKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0810", Offset = "0x7ECF010", VA = "0x187ED0810")]
		get
		{
			return default(BBJGBJEBCID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0840", Offset = "0x7ECF040", VA = "0x187ED0840")]
	public MNKALELAPLA(PPPEJBOJAOM LNFGEICLAJH, PPPEJBOJAOM MJNLMOPPION, int KCONAMHDDOK, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface IAHFLOMMMFK
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EDECLBBIOKJ LCHPFLHNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEAMPCKAMFG(PLIPKJPCDON EGOJLGMOLFK);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHIDPIJPJFM([In] MNKALELAPLA IMINNNCPCJF, bool CIBIFGHHMLF = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CLJJEOKGEHO(PPPEJBOJAOM PBHBHBGLABE);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ICCHFPGFDNP(PPPEJBOJAOM EFCGGCHGIPP, int KCONAMHDDOK, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JIIOCACHBBD(PPPEJBOJAOM MPLDCOIMIFI, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IGJLPIFIGMJ();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EFIABMPIOAI(Func<PPPEJBOJAOM, bool> HCFMNEKCAOP);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IGAHMBKCDDM(PPPEJBOJAOM GFAMPLNMOKM, HashSet<PPPEJBOJAOM> LNDKCCANMNC);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<PPPEJBOJAOM> HIGNNBEONIL();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LKCAAGMHAKP(PPPEJBOJAOM GFAMPLNMOKM, [Out] BBJGBJEBCID HGHLKMJAKCH);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FIHKIGAENJF(IIOKPLABNAM LKHIOLGKDDF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool IIOKPLABNAM(EDECLBBIOKJ CJEDGIAKFCF);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface EDECLBBIOKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	PPPEJBOJAOM BIAMMEMLAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EDECLBBIOKJ IFICPJBFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BBJGBJEBCID KMBAJEBKKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool DHBCGGNBPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface ALMDJEEMGMB
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNPKBJNJFKN(PPPEJBOJAOM IEJHGGLDHAD, BBJGBJEBCID LNFGEICLAJH);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBCHAOLDLCO(PPPEJBOJAOM IEJHGGLDHAD, BBJGBJEBCID LNFGEICLAJH);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IANBFFBHKKA(PPPEJBOJAOM IEJHGGLDHAD, BBJGBJEBCID LNFGEICLAJH);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OABOAEODOKP(PPPEJBOJAOM IEJHGGLDHAD, BBJGBJEBCID LNFGEICLAJH);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ALMDJEEMGMB Instantiate(Transform KCODNJGBFEK);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMIAFMKGHIE();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JODDNOEHNEL
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEAMPCKAMFG(Transform KCODNJGBFEK, ALMDJEEMGMB BHMLGGOCOHA);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ALMDJEEMGMB INFLPLKFMHG();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJOPOCPDKFN(ALMDJEEMGMB MJCANLPGHKP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LILEJBCBHKM : PBCMDGMCKCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCHIMNGGMOP();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BEFODIJKDEB(Guid CNLMHNDILAN);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface ECEJOJHMKDG
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKPIJIDACCM(EDECLBBIOKJ PIMIELEAHJA);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEAMPCKAMFG(IAHFLOMMMFK OPFJIIPHLBO, JODDNOEHNEL CIGOPBPACLA);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMPNBGGOJNJ();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFEOJMEKCAO(EDECLBBIOKJ BHEEGMEGBFD);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBGDNOLNEIG(EDECLBBIOKJ JLGIALCFBEG);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MJGOKECPDKN();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class CIFPDFMJLAI : EDECLBBIOKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CBENEBEICMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public BBJGBJEBCID nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CIFPDFMJLAI foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CBENEBEICMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7EC04B0", Offset = "0x7EBECB0", VA = "0x187EC04B0")]
		internal bool PPFDMCEKAHK(EDECLBBIOKJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private BBJGBJEBCID HGHLKMJAKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<CIFPDFMJLAI> FGPCCDOIGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private CIFPDFMJLAI KMHIDLPNBPG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BBJGBJEBCID KMBAJEBKKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x136EB20", Offset = "0x136D320", VA = "0x18136EB20", Slot = "6")]
		get
		{
			return default(BBJGBJEBCID);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x136E490", Offset = "0x136CC90", VA = "0x18136E490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private CIFPDFMJLAI MJNLMOPPION
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7EC31F0", Offset = "0x7EC19F0", VA = "0x187EC31F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EDECLBBIOKJ IFICPJBFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public PPPEJBOJAOM BIAMMEMLAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DHBCGGNBPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7EC35D0", Offset = "0x7EC1DD0", VA = "0x187EC35D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GCADJIIBIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3030", Offset = "0x7EC1830", VA = "0x187EC3030", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected CIFPDFMJLAI MJAMEBJFAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7EC32D0", Offset = "0x7EC1AD0", VA = "0x187EC32D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3760", Offset = "0x7EC1F60", VA = "0x187EC3760")]
	public CIFPDFMJLAI(BBJGBJEBCID MJBKBPMAMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2CE0", Offset = "0x7EC14E0", VA = "0x187EC2CE0")]
	public CIFPDFMJLAI BFNMONPOGNP(BBJGBJEBCID DLHFCKKOEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EC35E0", Offset = "0x7EC1DE0", VA = "0x187EC35E0")]
	public CIFPDFMJLAI PJGLMHLNHKL(BBJGBJEBCID CEDLIHBHNCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EC32F0", Offset = "0x7EC1AF0", VA = "0x187EC32F0")]
	public CIFPDFMJLAI HKOLMKDGPPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2E30", Offset = "0x7EC1630", VA = "0x187EC2E30")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2F80", Offset = "0x7EC1780", VA = "0x187EC2F80")]
	public CIFPDFMJLAI DGLJLNJLFEM(BBJGBJEBCID OOBPPDKPNFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3080", Offset = "0x7EC1880", VA = "0x187EC3080")]
	private static void FIHKIGAENJF(CIFPDFMJLAI DJKNAFDLBBO, IIOKPLABNAM OPKHOBALIGI, bool CPFIHCMHLMC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7EC31E0", Offset = "0x7EC19E0", VA = "0x187EC31E0", Slot = "9")]
	public void FIHKIGAENJF(IIOKPLABNAM LKHIOLGKDDF, bool FCENCLOFOHA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7EC34D0", Offset = "0x7EC1CD0", VA = "0x187EC34D0")]
	public static CIFPDFMJLAI OEMOMIMFPPK(CIFPDFMJLAI DJKNAFDLBBO, BBJGBJEBCID DKKOHFPICCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface EBFDGENNCCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool BJCEJBEDHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool IHCLLIGFBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<GBNNBLFIGLH> LCGFLBJBMDO;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<EIGONBNGIIK> NCFLGNMOMLP;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HNPKBJNJFKN(MEHOCGECLGB EGOJLGMOLFK, IPIOCEKPADE MPHHBBDCNDF);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GMKAKGNFKFA(PPPEJBOJAOM EFCGGCHGIPP, PPPEJBOJAOM MDDEGKANBMI, int KCONAMHDDOK, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BIEEPBKFECI(PPPEJBOJAOM MPLDCOIMIFI, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JIPIIAAPHIB(NIPLJADAEIJ LOBDGMCAENC, [Optional] EIGONBNGIIK MJJJAOPAIFH);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KEJPLAOIBJP
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type PBNBGAHIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDAC0", Offset = "0x7ECC2C0", VA = "0x187ECDAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object HPECEAELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDA30", Offset = "0x7ECC230", VA = "0x187ECDA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDA70", Offset = "0x7ECC270", VA = "0x187ECDA70")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class DJAFNCPLKFM : EBFDGENNCCG, IDisposable, AHHPCEBMDAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private MEHOCGECLGB EGOJLGMOLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IPIOCEKPADE IMBANAEPIKK;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BJCEJBEDHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7EC40E0", Offset = "0x7EC28E0", VA = "0x187EC40E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool IHCLLIGFBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3CD0", Offset = "0x7EC24D0", VA = "0x187EC3CD0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView BFEMADNEOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EC4140", Offset = "0x7EC2940", VA = "0x187EC4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<GBNNBLFIGLH> LCGFLBJBMDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3D60", Offset = "0x7EC2560", VA = "0x187EC3D60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3B10", Offset = "0x7EC2310", VA = "0x187EC3B10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<EIGONBNGIIK> NCFLGNMOMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3A70", Offset = "0x7EC2270", VA = "0x187EC3A70", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7EC41D0", Offset = "0x7EC29D0", VA = "0x187EC41D0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3F20", Offset = "0x7EC2720", VA = "0x187EC3F20", Slot = "10")]
	public void HNPKBJNJFKN(MEHOCGECLGB EGOJLGMOLFK, IPIOCEKPADE IMBANAEPIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3D10", Offset = "0x7EC2510", VA = "0x187EC3D10", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3DF0", Offset = "0x7EC25F0", VA = "0x187EC3DF0", Slot = "11")]
	public void GMKAKGNFKFA(PPPEJBOJAOM EFCGGCHGIPP, PPPEJBOJAOM MDDEGKANBMI, int KCONAMHDDOK, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3BA0", Offset = "0x7EC23A0", VA = "0x187EC3BA0", Slot = "12")]
	public void BIEEPBKFECI(PPPEJBOJAOM MPLDCOIMIFI, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3FB0", Offset = "0x7EC27B0", VA = "0x187EC3FB0", Slot = "13")]
	public void JIPIIAAPHIB(NIPLJADAEIJ LOBDGMCAENC, [Optional] EIGONBNGIIK MJJJAOPAIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7EC44B0", Offset = "0x7EC2CB0", VA = "0x187EC44B0")]
	[KFLNGMOCLGM]
	private void RpcMasterReparentNodes(PPPEJBOJAOM MPLDCOIMIFI, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EC42B0", Offset = "0x7EC2AB0", VA = "0x187EC42B0")]
	[KFLNGMOCLGM]
	private void RpcMasterModifyNode(PPPEJBOJAOM EFCGGCHGIPP, PPPEJBOJAOM MDDEGKANBMI, int KCONAMHDDOK, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EC48B0", Offset = "0x7EC30B0", VA = "0x187EC48B0")]
	[KFLNGMOCLGM]
	private void RpcReparentNodes(PPPEJBOJAOM MPLDCOIMIFI, int MJDACJBCAIP, PPPEJBOJAOM OOBPPDKPNFF, int JBINMOABDPH, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM, AKPFKMFKLAA CHCEHGEGCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EC47C0", Offset = "0x7EC2FC0", VA = "0x187EC47C0")]
	[KFLNGMOCLGM]
	private void RpcModifyNode(PPPEJBOJAOM EFCGGCHGIPP, int KCONAMHDDOK, int FLCJLLOKEIM, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM, AKPFKMFKLAA CHCEHGEGCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4270", Offset = "0x7EC2A70", VA = "0x187EC4270")]
	[KFLNGMOCLGM]
	private void RpcDeserializeConnectableGraph(NIPLJADAEIJ OPFJIIPHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DJAFNCPLKFM()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, ALMDJEEMGMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE0F0", Offset = "0x7ECC8F0", VA = "0x187ECE0F0", Slot = "4")]
		private void NOKGHNLPIOF(PPPEJBOJAOM IEJHGGLDHAD, BBJGBJEBCID LNFGEICLAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDC50", Offset = "0x7ECC450", VA = "0x187ECDC50", Slot = "5")]
		private void IGFMCBMJMEB(PPPEJBOJAOM IEJHGGLDHAD, BBJGBJEBCID LNFGEICLAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDEC0", Offset = "0x7ECC6C0", VA = "0x187ECDEC0", Slot = "6")]
		private void JKALBOBAICI(PPPEJBOJAOM IEJHGGLDHAD, BBJGBJEBCID LNFGEICLAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE2E0", Offset = "0x7ECCAE0", VA = "0x187ECE2E0", Slot = "7")]
		private void OLALHNAFMED(PPPEJBOJAOM IEJHGGLDHAD, BBJGBJEBCID LNFGEICLAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE270", Offset = "0x7ECCA70", VA = "0x187ECE270", Slot = "8")]
		private ALMDJEEMGMB OGMOIDFPKPL(Transform KCODNJGBFEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE4D0", Offset = "0x7ECCCD0", VA = "0x187ECE4D0", Slot = "9")]
		private void PFEPHFGLCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OHGICBHBGOA
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DF40", Offset = "0x3B7C740", VA = "0x183B7DF40")]
	public static BMPBFGBDKJA<T> GDGGLBIBOPA<T>(this OIKNHNBNAFI MBKOPLBCEJA)
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
