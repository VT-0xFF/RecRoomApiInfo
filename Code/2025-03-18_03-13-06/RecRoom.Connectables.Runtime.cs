using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7534150", Offset = "0x7533350", VA = "0x187534150", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7536370", Offset = "0x7535570", VA = "0x187536370", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7535ED0", Offset = "0x75350D0", VA = "0x187535ED0")]
		private void BCKFAMNGJJN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7535D60", Offset = "0x7534F60", VA = "0x187535D60")]
		private void APGEGEPOGIN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7536040", Offset = "0x7535240", VA = "0x187536040", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75363B0", Offset = "0x75355B0", VA = "0x1875363B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class GJENJPFHNIO : CFEDDCDGFOG, DKPHGOHMHMA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class NDEGFBCLJCK : IEnumerable<BDPKLDEADOF>, IEnumerable, IEnumerator<BDPKLDEADOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private BDPKLDEADOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private EOFNBBMGHCB localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EOFNBBMGHCB <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GJENJPFHNIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private NFIPPAIECID <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private AGCGHKEMDON <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private AGCGHKEMDON.IIDGHDOMLHC <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private BDPKLDEADOF System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public NDEGFBCLJCK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7534A20", Offset = "0x7533C20", VA = "0x187534A20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75345A0", Offset = "0x75337A0", VA = "0x1875345A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7534900", Offset = "0x7533B00", VA = "0x187534900")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7534580", Offset = "0x7533780", VA = "0x187534580")]
		private void HEIMKCGCNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75349D0", Offset = "0x7533BD0", VA = "0x1875349D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7534920", Offset = "0x7533B20", VA = "0x187534920", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BDPKLDEADOF> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7534920", Offset = "0x7533B20", VA = "0x187534920", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EJBFAJCMKPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public GJENJPFHNIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PIHNKOIIPAF nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public EJBFAJCMKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x752B1C0", Offset = "0x752A3C0", VA = "0x18752B1C0")]
		internal object AIAMGJAOJJC(PIHNKOIIPAF x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CLOBAANNLAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public PIHNKOIIPAF child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public EJBFAJCMKPM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CLOBAANNLAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x75282F0", Offset = "0x75274F0", VA = "0x1875282F0")]
		internal object PBGBMDKPKDF((PIHNKOIIPAF child, PIHNKOIIPAF nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly PBBCGFNIILA PEECECKHPMN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly PBBCGFNIILA IBAMBOLHHPO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly PBBCGFNIILA BCKNIKIEAPA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly PBBCGFNIILA LFAENCOEJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private JLBPLEBDGLO BKKPOFBBCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LNBGIMMJJPA PCFNMJHFPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private OOJGFGPONHL DMNOFOLNGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private HHGKFCHBFEC EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private KEIMAMLEGJC MOIFBHDFFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BMPHFFKGFOH LGCLECJNKAM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HMMGIGDCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAEE220", Offset = "0xAED420", VA = "0x180AEE220", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAEDA80", Offset = "0xAECC80", VA = "0x180AEDA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GHGDMGHANNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<BDPKLDEADOF, BDPKLDEADOF> KHIAGPDKDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75311C0", Offset = "0x75303C0", VA = "0x1875311C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x752F5D0", Offset = "0x752E7D0", VA = "0x18752F5D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<BDPKLDEADOF, BDPKLDEADOF> GAKLODBJCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x752DAA0", Offset = "0x752CCA0", VA = "0x18752DAA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x752EBB0", Offset = "0x752DDB0", VA = "0x18752EBB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<BDPKLDEADOF, BDPKLDEADOF, BDPKLDEADOF> ONIBHIKALDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7530320", Offset = "0x752F520", VA = "0x187530320", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7531D60", Offset = "0x7530F60", VA = "0x187531D60", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7532150", Offset = "0x7531350", VA = "0x187532150")]
	public GJENJPFHNIO(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7531A00", Offset = "0x7530C00", VA = "0x187531A00", Slot = "12")]
	public void PDAIGIIELDH(GameObject LNIONOAAAEO, FPJLGLMFNFN MHPNJAFMOHP, ENIIOOLDJGI LBNPCIOEFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7531E10", Offset = "0x7531010", VA = "0x187531E10", Slot = "26")]
	public void PPDMLGCOEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x752FAE0", Offset = "0x752ECE0", VA = "0x18752FAE0", Slot = "22")]
	public bool IFPHNINFHBD(PIHNKOIIPAF CPHOLCKELIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7530090", Offset = "0x752F290", VA = "0x187530090")]
	private void KKBCGINAJOH(EOFNBBMGHCB FCFFIEOBEGB, EOFNBBMGHCB BELNBOIMFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x752EC60", Offset = "0x752DE60", VA = "0x18752EC60")]
	private void ELCGENCECEN(EOFNBBMGHCB FCFFIEOBEGB, EOFNBBMGHCB HBPFIJHIKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x752D7E0", Offset = "0x752C9E0", VA = "0x18752D7E0")]
	private void AOKNIDDCGFD(EOFNBBMGHCB FCFFIEOBEGB, EOFNBBMGHCB HBPFIJHIKIF, EOFNBBMGHCB BELNBOIMFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7530B10", Offset = "0x752FD10", VA = "0x187530B10")]
	private void MMPAHALMNMM(EOFNBBMGHCB FCFFIEOBEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "13")]
	public void DJHAIOPCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x752DBC0", Offset = "0x752CDC0", VA = "0x18752DBC0", Slot = "14")]
	public void COGNOIDNGPM(BDPKLDEADOF PGEJNBOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "15")]
	public void AGGOIHIHDOM(BDPKLDEADOF PGEJNBOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7531060", Offset = "0x7530260", VA = "0x187531060", Slot = "17")]
	public void NBGCMMHAMLC(BDPKLDEADOF PGEJNBOCJDO, BDPKLDEADOF KNLMPEHKLAD, Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7530F20", Offset = "0x7530120", VA = "0x187530F20")]
	public void NBGCMMHAMLC(EOFNBBMGHCB OAOLODPFDMA, EOFNBBMGHCB KNLMPEHKLAD, Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x752FE50", Offset = "0x752F050", VA = "0x18752FE50")]
	public void JIEDOKECKFB(BDPKLDEADOF PGEJNBOCJDO, float IKKLIBHMPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x752F010", Offset = "0x752E210", VA = "0x18752F010", Slot = "18")]
	public void EOAEJPEAIKJ(BDPKLDEADOF EHIJMGECKBB, int ABOFLOOCDFP, BDPKLDEADOF ADBCMPCNGNI, int INOEIPPGHAL, Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x752F8C0", Offset = "0x752EAC0", VA = "0x18752F8C0")]
	private float HAGKLCFHMJL(EOFNBBMGHCB OAOLODPFDMA, EOFNBBMGHCB JNGEIJHHFEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x752F170", Offset = "0x752E370", VA = "0x18752F170")]
	public void EOAEJPEAIKJ(EOFNBBMGHCB OAOLODPFDMA, EOFNBBMGHCB JNGEIJHHFEP, Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA, bool HGJDHLCFEHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x752F970", Offset = "0x752EB70", VA = "0x18752F970", Slot = "19")]
	public void HCMNCGOPGAM(BDPKLDEADOF PGEJNBOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x752F3C0", Offset = "0x752E5C0", VA = "0x18752F3C0", Slot = "16")]
	public void FDBIIPKMEEI(BDPKLDEADOF PGEJNBOCJDO, HashSet<BDPKLDEADOF> DONMINGNPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "20")]
	public MAFLPNHIGMP NBGDPNOCGFN(bool NJLECMIENIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "21")]
	public MAFLPNHIGMP CAGANEBHILF(HashSet<Guid> HIMHIPKPOGI, bool NJLECMIENIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7531990", Offset = "0x7530B90", VA = "0x187531990", Slot = "23")]
	public void PAEGEBNCHPL(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x752F850", Offset = "0x752EA50", VA = "0x18752F850", Slot = "24")]
	public void GKKGNJAFAOB(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7530070", Offset = "0x752F270", VA = "0x187530070", Slot = "25")]
	public void JLJEOPCKBCA(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x752DED0", Offset = "0x752D0D0", VA = "0x18752DED0")]
	private void DIAFIOMPBDM(EOFNBBMGHCB OAOLODPFDMA, EOFNBBMGHCB JNGEIJHHFEP, Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA, float IKKLIBHMPKI, bool HGJDHLCFEHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x752E240", Offset = "0x752D440", VA = "0x18752E240")]
	private void EBHIMHLNCGK(EOFNBBMGHCB OAOLODPFDMA, EOFNBBMGHCB NAAOBFPOHHG, Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x752DB50", Offset = "0x752CD50", VA = "0x18752DB50")]
	private void CJOMPFFJMGO(EOFNBBMGHCB OAOLODPFDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7530290", Offset = "0x752F490", VA = "0x187530290")]
	[IteratorStateMachine(typeof(NDEGFBCLJCK))]
	public IEnumerable<BDPKLDEADOF> LGGKKKBIMKI(EOFNBBMGHCB DEBNBMMFJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7530760", Offset = "0x752F960", VA = "0x187530760")]
	internal BDPKLDEADOF MFMOMPEKIGC(EOFNBBMGHCB DEBNBMMFJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7531270", Offset = "0x7530470", VA = "0x187531270")]
	internal EOFNBBMGHCB OICPICIEGEC(BDPKLDEADOF PGEJNBOCJDO)
	{
		return default(EOFNBBMGHCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7531400", Offset = "0x7530600", VA = "0x187531400")]
	private bool ONGDGIMOFMC(PIHNKOIIPAF CPHOLCKELIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x752DA40", Offset = "0x752CC40", VA = "0x18752DA40")]
	private bool BKMFMMAKAAN(PIHNKOIIPAF CPHOLCKELIL, [Out] BDPKLDEADOF JNGEIJHHFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x75303D0", Offset = "0x752F5D0", VA = "0x1875303D0")]
	private BDPKLDEADOF MFMOMPEKIGC(PIHNKOIIPAF CPHOLCKELIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x752EE80", Offset = "0x752E080", VA = "0x18752EE80")]
	private BDPKLDEADOF EMPEHJDGMBK(PIHNKOIIPAF CPHOLCKELIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x752F680", Offset = "0x752E880", VA = "0x18752F680")]
	private BDPKLDEADOF FPDCOIJOAIL(PIHNKOIIPAF CPHOLCKELIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7529A40", Offset = "0x7528C40", VA = "0x187529A40")]
	private static Guid KAKIMGPOLIM(PIHNKOIIPAF CPHOLCKELIL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7531C70", Offset = "0x7530E70", VA = "0x187531C70")]
	private string PDDBEBHGODC(PIHNKOIIPAF CPHOLCKELIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x752FCC0", Offset = "0x752EEC0", VA = "0x18752FCC0")]
	private void JFELJAIEHHF(BDPKLDEADOF OAOLODPFDMA, BDPKLDEADOF NAAOBFPOHHG, RigidTransform PLPKBFIHFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x752FB30", Offset = "0x752ED30", VA = "0x18752FB30")]
	private void IPLGNGNMDPJ(BDPKLDEADOF NAAOBFPOHHG, BDPKLDEADOF OAOLODPFDMA, RigidTransform PLPKBFIHFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x752EB50", Offset = "0x752DD50", VA = "0x18752EB50")]
	private void EFBHDPIGIGH(BDPKLDEADOF PKMKJKDCFHL, BDPKLDEADOF OAOLODPFDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x752FEE0", Offset = "0x752F0E0", VA = "0x18752FEE0")]
	private void JJIBLGOMGNG(BDPKLDEADOF OAOLODPFDMA, BDPKLDEADOF JNGEIJHHFEP, RigidTransform PLPKBFIHFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x752F2B0", Offset = "0x752E4B0", VA = "0x18752F2B0")]
	private void FAFMHBIJDNI(EOFNBBMGHCB DEBNBMMFJPK, BDPKLDEADOF PGEJNBOCJDO, EOFNBBMGHCB HBPFIJHIKIF, EOFNBBMGHCB BELNBOIMFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7530890", Offset = "0x752FA90", VA = "0x187530890")]
	private void MGBKLEODIHB(EOFNBBMGHCB DEBNBMMFJPK, BDPKLDEADOF PGEJNBOCJDO, BDPKLDEADOF GCKEFNBCFGE, BDPKLDEADOF FEBGLNHMPCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ABOEHELGICH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FEKFBHENGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ANOENEDKKHA container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public FEKFBHENGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x752D310", Offset = "0x752C510", VA = "0x18752D310")]
		internal GJENJPFHNIO HDECKFOFCOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75212F0", Offset = "0x75204F0", VA = "0x1875212F0")]
	public static void EMIGEDFFJEA(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75212A0", Offset = "0x75204A0", VA = "0x1875212A0")]
	public static void DEGPBHFDFEJ(ANOENEDKKHA GFOILLNHEFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CLFOKPDKFFO : HMMHHOMDNHC, PHOBEONJNGL
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly RigidbodyEx DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly GJENJPFHNIO BKGHFLOFGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly MBFJPEOOMLD JKMBCADFLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly LOHHGHFFJBI EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly IPPPEBCFHOM[] ALGABGBLCIN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BDPKLDEADOF LIAHMJIMIII
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x75280C0", Offset = "0x75272C0", VA = "0x1875280C0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BDPKLDEADOF NKGBNBIJMOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75278C0", Offset = "0x7526AC0", VA = "0x1875278C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 PHHNLPCAOCB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7526BE0", Offset = "0x7525DE0", VA = "0x187526BE0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion CEKJMBECBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7526890", Offset = "0x7525A90", VA = "0x187526890", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PJGACLMMCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7526D90", Offset = "0x7525F90", VA = "0x187526D90", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<BDPKLDEADOF> ENMHNMAEFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7527980", Offset = "0x7526B80", VA = "0x187527980", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool LAOCLJMBJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB05410", Offset = "0xB04610", VA = "0x180B05410", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB52430", Offset = "0xB51630", VA = "0x180B52430", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75282D0", Offset = "0x75274D0", VA = "0x1875282D0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject FOFJJMEPKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4520", Offset = "0x2BF3720", VA = "0x182BF4520", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7527FF0", Offset = "0x75271F0", VA = "0x187527FF0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid OHDKIONLAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7528120", Offset = "0x7527320", VA = "0x187528120", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OGIAILJCMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7528200", Offset = "0x7527400", VA = "0x187528200", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PCDIBKIEPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool AIJEDJCPAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7527C90", Offset = "0x7526E90", VA = "0x187527C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JGIJGAJOJEL IFDIMMELIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7527DF0", Offset = "0x7526FF0", VA = "0x187527DF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x75268F0", Offset = "0x7525AF0", VA = "0x1875268F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JGIJGAJOJEL CNCOAIEPGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7527D90", Offset = "0x7526F90", VA = "0x187527D90", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7527860", Offset = "0x7526A60", VA = "0x187527860", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JGIJGAJOJEL LIJNAMAMLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7527D30", Offset = "0x7526F30", VA = "0x187527D30", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7526540", Offset = "0x7525740", VA = "0x187526540", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event PHJOBIBHAOA FOAACBGJFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7527000", Offset = "0x7526200", VA = "0x187527000", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x75270A0", Offset = "0x75262A0", VA = "0x1875270A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7527EF0", Offset = "0x75270F0", VA = "0x187527EF0")]
	public CLFOKPDKFFO(EOFNBBMGHCB BNMNHJKEFGM, RigidbodyEx DNNDAOFODNI, MBFJPEOOMLD JKMBCADFLHC, IPPPEBCFHOM[] ALGABGBLCIN, LOHHGHFFJBI EKJOCLHFECK, CFEDDCDGFOG BKGHFLOFGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7526950", Offset = "0x7525B50", VA = "0x187526950", Slot = "19")]
	public void FDAGCHPOHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "21")]
	public void PLELEJBKMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72D78C0", Offset = "0x72D6AC0", VA = "0x1872D78C0", Slot = "22")]
	public void KJCKODIHHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x75267A0", Offset = "0x75259A0", VA = "0x1875267A0", Slot = "20")]
	public void CHDCILGNCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7526980", Offset = "0x7525B80", VA = "0x187526980", Slot = "25")]
	public void FPDFGMNNOIF(int NHENBDOAMOM, BDPKLDEADOF ADBCMPCNGNI, int OLFGCNMGCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7526C40", Offset = "0x7525E40", VA = "0x187526C40", Slot = "26")]
	public void GGMMNIHCCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75279B0", Offset = "0x7526BB0", VA = "0x1875279B0", Slot = "27")]
	public void MPDFLOPCNII(int NHENBDOAMOM, BDPKLDEADOF EHIJMGECKBB, int IHOHLPPMFNM, [Optional] Vector3? KMPFBIGDKPE, [Optional] Quaternion? FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7526D10", Offset = "0x7525F10", VA = "0x187526D10", Slot = "28")]
	public void GIKBNHEGFJJ(BDPKLDEADOF EHIJMGECKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7527140", Offset = "0x7526340", VA = "0x187527140", Slot = "31")]
	public void JFKGFHNPMIL(Vector3 GANGNJLJLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7527550", Offset = "0x7526750", VA = "0x187527550", Slot = "29")]
	public void JOBLNIIHAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x75265A0", Offset = "0x75257A0", VA = "0x1875265A0", Slot = "30")]
	public void CAAIDDANAGH(int KOOLKCPAFBB, Vector3 GENKBFNNJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7526F30", Offset = "0x7526130", VA = "0x187526F30", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int NHENBDOAMOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7526E00", Offset = "0x7526000", VA = "0x187526E00", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int NHENBDOAMOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAE2F90", Offset = "0xAE2190", VA = "0x180AE2F90", Slot = "42")]
	public Color GetConnectionSlotColor(int NHENBDOAMOM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x75267F0", Offset = "0x75259F0", VA = "0x1875267F0", Slot = "43")]
	public bool CanConnectTo(int NHENBDOAMOM, BDPKLDEADOF CNMHNMFJEHP, int ONKLHAMMLAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "44")]
	public void ParentChanged(int NHENBDOAMOM, BDPKLDEADOF NADKIAHPHGG, int FDPGHHJONAO, Vector3 BEEDOHKEDHP, Quaternion JPPECCGJHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "45")]
	public void ChildAdded(int NHENBDOAMOM, BDPKLDEADOF EFDNNGFBKBI, int BIHKBFEBAPD, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "46")]
	public void ChildRemoved(int NHENBDOAMOM, BDPKLDEADOF ANJAOLMGNDA, int NNDFBNJDDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "47")]
	public void ConnectionModified(int NHENBDOAMOM, BDPKLDEADOF ADBCMPCNGNI, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7527E50", Offset = "0x7527050", VA = "0x187527E50", Slot = "48")]
	public void RootChanged(BDPKLDEADOF EGGKMEGEKHE, BDPKLDEADOF HPNFNLJNLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7526B90", Offset = "0x7525D90", VA = "0x187526B90", Slot = "23")]
	public void GBIFIOMHMFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x75264F0", Offset = "0x75256F0", VA = "0x1875264F0", Slot = "24")]
	public void ACDCDNDOIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7527CE0", Offset = "0x7526EE0", VA = "0x187527CE0")]
	private void OPCCMECNLFJ(bool GPJCAKGMBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(JOMICHNIGIC), new string[] { })]
public class MKBDCDBADKJ : JOMICHNIGIC, ACFHKDFELAE, CBKDENAGIHJ
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AMNLIOKOIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AMNLIOKOIFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[DependsOn]
	private FGPKLLDDKFL OCNNBPCACIL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object AEFBLOLDHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7534480", Offset = "0x7533680", VA = "0x187534480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7534430", Offset = "0x7533630", VA = "0x187534430", Slot = "5")]
	private void LAHBCOILANO(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xFE6320", Offset = "0xFE5520", VA = "0x180FE6320", Slot = "6")]
	private void HCHPEMCKIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public MKBDCDBADKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(CFEDDCDGFOG), new string[] { "Ignore", "Mock" })]
public class GGGFONDOLJD : CFEDDCDGFOG, DKPHGOHMHMA
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HMMGIGDCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GHGDMGHANNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<BDPKLDEADOF, BDPKLDEADOF> KHIAGPDKDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x752D680", Offset = "0x752C880", VA = "0x18752D680", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x752D520", Offset = "0x752C720", VA = "0x18752D520", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<BDPKLDEADOF, BDPKLDEADOF> GAKLODBJCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x752D3C0", Offset = "0x752C5C0", VA = "0x18752D3C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x752D470", Offset = "0x752C670", VA = "0x18752D470", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<BDPKLDEADOF, BDPKLDEADOF, BDPKLDEADOF> ONIBHIKALDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x752D5D0", Offset = "0x752C7D0", VA = "0x18752D5D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x752D730", Offset = "0x752C930", VA = "0x18752D730", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "26")]
	public void PPDMLGCOEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "12")]
	public void PDAIGIIELDH(GameObject LNIONOAAAEO, FPJLGLMFNFN MHPNJAFMOHP, ENIIOOLDJGI PDNEGDCPCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "13")]
	public void DJHAIOPCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "14")]
	public void COGNOIDNGPM(BDPKLDEADOF PGEJNBOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "15")]
	public void AGGOIHIHDOM(BDPKLDEADOF PGEJNBOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "16")]
	public void FDBIIPKMEEI(BDPKLDEADOF PGEJNBOCJDO, HashSet<BDPKLDEADOF> DONMINGNPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "17")]
	public void NBGCMMHAMLC(BDPKLDEADOF PGEJNBOCJDO, BDPKLDEADOF KNLMPEHKLAD, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "18")]
	public void EOAEJPEAIKJ(BDPKLDEADOF PGEJNBOCJDO, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "19")]
	public void HCMNCGOPGAM(BDPKLDEADOF PGEJNBOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "20")]
	public MAFLPNHIGMP NBGDPNOCGFN(bool NJLECMIENIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "21")]
	public MAFLPNHIGMP CAGANEBHILF(HashSet<Guid> HIMHIPKPOGI, bool NJLECMIENIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "22")]
	public bool IFPHNINFHBD(PIHNKOIIPAF CPHOLCKELIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "23")]
	public void PAEGEBNCHPL(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "24")]
	public void GKKGNJAFAOB(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "25")]
	public void JLJEOPCKBCA(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public GGGFONDOLJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BDPKLDEADOF : PHOBEONJNGL, IEquatable<BDPKLDEADOF>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PHOBEONJNGL
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	BDPKLDEADOF LIAHMJIMIII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject FOFJJMEPKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid OHDKIONLAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int OGIAILJCMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool PCDIBKIEPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int NHENBDOAMOM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int NHENBDOAMOM);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int NHENBDOAMOM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int NHENBDOAMOM, BDPKLDEADOF CNMHNMFJEHP, int DAEDEKMPDNN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int NHENBDOAMOM, BDPKLDEADOF NADKIAHPHGG, int FDPGHHJONAO, Vector3 BEEDOHKEDHP, Quaternion JPPECCGJHKP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int NHENBDOAMOM, BDPKLDEADOF EFDNNGFBKBI, int BIHKBFEBAPD, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int NHENBDOAMOM, BDPKLDEADOF ANJAOLMGNDA, int NNDFBNJDDPB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int NHENBDOAMOM, BDPKLDEADOF ADBCMPCNGNI, int DFBJAOIPGPH, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(BDPKLDEADOF EGGKMEGEKHE, BDPKLDEADOF HPNFNLJNLOD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CFEDDCDGFOG : DKPHGOHMHMA
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HMMGIGDCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GHGDMGHANNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<BDPKLDEADOF, BDPKLDEADOF> KHIAGPDKDCN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<BDPKLDEADOF, BDPKLDEADOF> GAKLODBJCJO;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<BDPKLDEADOF, BDPKLDEADOF, BDPKLDEADOF> ONIBHIKALDD;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PDAIGIIELDH(GameObject LNIONOAAAEO, FPJLGLMFNFN MHPNJAFMOHP, ENIIOOLDJGI NLPBCEOPNDC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DJHAIOPCIPI();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void COGNOIDNGPM(BDPKLDEADOF PGEJNBOCJDO);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AGGOIHIHDOM(BDPKLDEADOF PGEJNBOCJDO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FDBIIPKMEEI(BDPKLDEADOF PGEJNBOCJDO, HashSet<BDPKLDEADOF> DONMINGNPMO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NBGCMMHAMLC(BDPKLDEADOF PGEJNBOCJDO, BDPKLDEADOF KNLMPEHKLAD, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EOAEJPEAIKJ(BDPKLDEADOF PGEJNBOCJDO, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HCMNCGOPGAM(BDPKLDEADOF PGEJNBOCJDO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MAFLPNHIGMP NBGDPNOCGFN(bool NJLECMIENIO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MAFLPNHIGMP CAGANEBHILF(HashSet<Guid> HIMHIPKPOGI, bool NJLECMIENIO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IFPHNINFHBD(PIHNKOIIPAF CPHOLCKELIL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PAEGEBNCHPL(MAFLPNHIGMP COLCBEIJDBM);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GKKGNJAFAOB(MAFLPNHIGMP COLCBEIJDBM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JLJEOPCKBCA(MAFLPNHIGMP COLCBEIJDBM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HHGKFCHBFEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool LBBEDEHLLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BDPKLDEADOF FPDCOIJOAIL(int AFMJNACDNMH);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BDPKLDEADOF EMPEHJDGMBK(Guid DMDPIGPMOFM);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KLGFCJJMPJE(BDPKLDEADOF PGEJNBOCJDO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool APJLDJOJHAD();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKFJKEEHHGA(BDPKLDEADOF JKMBCADFLHC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface LOHHGHFFJBI
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AIJEDJCPAAO(MBFJPEOOMLD JKMBCADFLHC);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PGKNKCLAICD(MBFJPEOOMLD JKMBCADFLHC);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string DHKLAFCCNKE(MBFJPEOOMLD JKMBCADFLHC);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid MIOLACPCHCD(MBFJPEOOMLD JKMBCADFLHC);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OGKJMDAMCKP(MBFJPEOOMLD JKMBCADFLHC);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGEKEMCNFHN(MBFJPEOOMLD JKMBCADFLHC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void JGIJGAJOJEL(BDPKLDEADOF EHIJMGECKBB, int CIOEFLAJHHE, BDPKLDEADOF ADBCMPCNGNI, int CMGFBGMGFGN, [Optional] Vector3? KMPFBIGDKPE, [Optional] Quaternion? FCFDNDACGPN);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void PHJOBIBHAOA(BDPKLDEADOF EGGKMEGEKHE, BDPKLDEADOF HPNFNLJNLOD);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MBFJPEOOMLD : BDPKLDEADOF, PHOBEONJNGL, IEquatable<BDPKLDEADOF>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HMMHHOMDNHC : PHOBEONJNGL
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	BDPKLDEADOF NKGBNBIJMOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<BDPKLDEADOF> ENMHNMAEFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 PHHNLPCAOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion CEKJMBECBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool PJGACLMMCDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LAOCLJMBJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event JGIJGAJOJEL IFDIMMELIKE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event JGIJGAJOJEL CNCOAIEPGKM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event JGIJGAJOJEL LIJNAMAMLMF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event PHJOBIBHAOA FOAACBGJFOB;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FDAGCHPOHKC();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CHDCILGNCOK();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PLELEJBKMPK();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KJCKODIHHDP();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GBIFIOMHMFK();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ACDCDNDOIEH();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FPDFGMNNOIF(int NHENBDOAMOM, BDPKLDEADOF ADBCMPCNGNI, int OLFGCNMGCFJ);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GGMMNIHCCGJ();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MPDFLOPCNII(int NHENBDOAMOM, BDPKLDEADOF EHIJMGECKBB, int IHOHLPPMFNM, [Optional] Vector3? KMPFBIGDKPE, [Optional] Quaternion? FCFDNDACGPN);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GIKBNHEGFJJ(BDPKLDEADOF EHIJMGECKBB);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void JOBLNIIHAKI();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CAAIDDANAGH(int KOOLKCPAFBB, Vector3 GENKBFNNJCB);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JFKGFHNPMIL(Vector3 GANGNJLJLDO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IPPPEBCFHOM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 GBAEELOFIOD
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
public interface FPJLGLMFNFN
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool JNEPHIMJEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JMADKDMKBCF LAMFBBIHIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, FPJLGLMFNFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xC04650", Offset = "0xC03850", VA = "0x180C04650", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JMADKDMKBCF LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7528540", Offset = "0x7527740", VA = "0x187528540")]
		public static ConnectableConfigData NHOFFFEDPBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7528600", Offset = "0x7527800", VA = "0x187528600")]
		public ConnectableConfigData(LegacyConnectableLinkVisual HJDMFEJKMGJ, bool GPOENBFPGKB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HCJKHCGFOGA : IEquatable<HCJKHCGFOGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public BDPKLDEADOF PGEJNBOCJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int JDBHPOPEKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int DFBJAOIPGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 KMPFBIGDKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion FCFDNDACGPN;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x75326C0", Offset = "0x75318C0", VA = "0x1875326C0")]
	public HCJKHCGFOGA(BDPKLDEADOF PGEJNBOCJDO, int JDBHPOPEKHM, int DFBJAOIPGPH, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7532720", Offset = "0x7531920", VA = "0x187532720")]
	public HCJKHCGFOGA(BDPKLDEADOF PGEJNBOCJDO, int JDBHPOPEKHM, int DFBJAOIPGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7532640", Offset = "0x7531840", VA = "0x187532640")]
	public HCJKHCGFOGA(BDPKLDEADOF PGEJNBOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x75321C0", Offset = "0x75313C0", VA = "0x1875321C0", Slot = "4")]
	public bool Equals(HCJKHCGFOGA LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7532270", Offset = "0x7531470", VA = "0x187532270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class LJEMDBLHGCM : MMPMADCEKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform LBAHEDDLOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private JMADKDMKBCF PGOBMLNEPJD;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6F78C70", Offset = "0x6F77E70", VA = "0x186F78C70", Slot = "4")]
	public void PDAIGIIELDH(Transform LBAHEDDLOKA, JMADKDMKBCF PGOBMLNEPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x75337F0", Offset = "0x75329F0", VA = "0x1875337F0", Slot = "5")]
	public JMADKDMKBCF GGPJAFMHDFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x75338C0", Offset = "0x7532AC0", VA = "0x1875338C0", Slot = "6")]
	public void PBEKNKFKKIC(JMADKDMKBCF OGLIBBNDEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public LJEMDBLHGCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class AINCOCDDIHL : IDisposable, NJBEJIOEHAD
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BMHNKJHCOHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BDPKLDEADOF oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BDPKLDEADOF newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BMHNKJHCOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7525A00", Offset = "0x7524C00", VA = "0x187525A00")]
		internal bool CDDBAADEKAF(DAGDMKEIAAM node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly BJALCJFPADK FOKAGNIAJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private AHCACLPOBPJ PFBBIOKDKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private BDOCKFOALPM CHFDDPBNFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool GPOENBFPGKB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly PBBCGFNIILA FGOCKJCDHBG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public DAGDMKEIAAM GMOCPPMLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x75222E0", Offset = "0x75214E0", VA = "0x1875222E0")]
	public bool ECOGFEFHAOM([In] PFCKCCPFEPL LJELDKAOCJM, bool MAFBHAMFICC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7523D30", Offset = "0x7522F30", VA = "0x187523D30")]
	private bool KHHGMEEKEEM([In] PFCKCCPFEPL LJELDKAOCJM, bool MAFBHAMFICC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7524820", Offset = "0x7523A20", VA = "0x187524820")]
	public AINCOCDDIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x75245D0", Offset = "0x75237D0", VA = "0x1875245D0", Slot = "5")]
	public void PDAIGIIELDH(CFEDDCDGFOG CKLPHBNMNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7523B20", Offset = "0x7522D20", VA = "0x187523B20", Slot = "17")]
	public void KCGHHHLGBKO(OOFPHKOHMPG GIIPLELNBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7521F50", Offset = "0x7521150", VA = "0x187521F50", Slot = "12")]
	public void DJJBCLPIKEJ(Func<BDPKLDEADOF, bool> PEGADAMMHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7521F60", Offset = "0x7521160", VA = "0x187521F60")]
	private void DJJBCLPIKEJ(BJALCJFPADK ILLDGNOPAEF, Func<BDPKLDEADOF, bool> PEGADAMMHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x75238C0", Offset = "0x7522AC0", VA = "0x1875238C0", Slot = "11")]
	public void IPBFJFBOFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x75238B0", Offset = "0x7522AB0", VA = "0x1875238B0", Slot = "8")]
	public bool IIGBCALPIIJ(BDPKLDEADOF CCFEHKJPDDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7522900", Offset = "0x7521B00", VA = "0x187522900")]
	private bool FHBJJIIMMIJ(BDPKLDEADOF OOEIIPPJANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7522450", Offset = "0x7521650", VA = "0x187522450")]
	private static bool EGEGMEHJLLG(BDPKLDEADOF OOEIIPPJANC, BJALCJFPADK KNEHJICNNIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x75216A0", Offset = "0x75208A0", VA = "0x1875216A0")]
	private void AGOHHNEMGMA(Transform PPBGKFOPBJM, BJALCJFPADK GKAFHJEAHNB, BJALCJFPADK[] ACECJFEFLLM, BDPKLDEADOF JGKPGHCDPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x75230B0", Offset = "0x75222B0", VA = "0x1875230B0")]
	private HCJKHCGFOGA FHHJMNBMPHA(Transform FPOPOBANGDD, HCJKHCGFOGA DKADEGKNDFN)
	{
		return default(HCJKHCGFOGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7521CC0", Offset = "0x7520EC0", VA = "0x187521CC0")]
	private static bool CCIKCEFACCE(BJALCJFPADK KNEHJICNNIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7522500", Offset = "0x7521700", VA = "0x187522500", Slot = "9")]
	public bool EOEGKPBDLLL(BDPKLDEADOF ONHBJCBPHJP, int IHOHLPPMFNM, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7522090", Offset = "0x7521290", VA = "0x187522090")]
	private bool ECABDBGENAO(BDPKLDEADOF ONHBJCBPHJP, int IHOHLPPMFNM, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7523B50", Offset = "0x7522D50", VA = "0x187523B50")]
	private static void KEIFAMOGEIH(BDPKLDEADOF ONHBJCBPHJP, int IHOHLPPMFNM, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN, BJALCJFPADK LLAIJAMIILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7523A00", Offset = "0x7522C00", VA = "0x187523A00")]
	private void JFELJAIEHHF(BDPKLDEADOF DMJMJBEEGKL, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x75246F0", Offset = "0x75238F0", VA = "0x1875246F0")]
	private void PNNJHGJMBJN(BJALCJFPADK ILLDGNOPAEF, BDPKLDEADOF GCKEFNBCFGE, BDPKLDEADOF FEBGLNHMPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7524680", Offset = "0x7523880", VA = "0x187524680")]
	private void PNNJHGJMBJN(BDPKLDEADOF PGEJNBOCJDO, BDPKLDEADOF GCKEFNBCFGE, BDPKLDEADOF FEBGLNHMPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7524330", Offset = "0x7523530", VA = "0x187524330")]
	private void MGBKLEODIHB(BDPKLDEADOF PGEJNBOCJDO, BDPKLDEADOF GCKEFNBCFGE, BDPKLDEADOF FEBGLNHMPCI, bool JOLBPJLFJJH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x75243A0", Offset = "0x75235A0", VA = "0x1875243A0")]
	private void MGBKLEODIHB(BJALCJFPADK BFPPPKIAFBG, BDPKLDEADOF JGKPGHCDPEI, BDPKLDEADOF HPNFNLJNLOD, bool JOLBPJLFJJH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x75238E0", Offset = "0x7522AE0", VA = "0x1875238E0")]
	private void IPLGNGNMDPJ(BDPKLDEADOF OAOLODPFDMA, int IHOHLPPMFNM, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x75222F0", Offset = "0x75214F0", VA = "0x1875222F0")]
	private void EFBHDPIGIGH(DAGDMKEIAAM JNGEIJHHFEP, DAGDMKEIAAM FDPAPPAHJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7521540", Offset = "0x7520740", VA = "0x187521540", Slot = "18")]
	public BDPKLDEADOF ABACFDFMDOJ(BDPKLDEADOF PGEJNBOCJDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7522560", Offset = "0x7521760", VA = "0x187522560", Slot = "13")]
	public void FDBIIPKMEEI(BDPKLDEADOF PGEJNBOCJDO, HashSet<BDPKLDEADOF> BAPFNDCJKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7521A80", Offset = "0x7520C80", VA = "0x187521A80", Slot = "14")]
	public List<BDPKLDEADOF> BAPAPCFHCBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7521470", Offset = "0x7520670", VA = "0x187521470")]
	protected DAGDMKEIAAM AAPLCBKINNL(DAGDMKEIAAM ILLDGNOPAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7523010", Offset = "0x7522210", VA = "0x187523010")]
	protected BJALCJFPADK[] FHGCMLKAEMB(BJALCJFPADK KNEHJICNNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x75237A0", Offset = "0x75229A0", VA = "0x1875237A0")]
	protected bool HPJFOMHCEKD(BDPKLDEADOF PGEJNBOCJDO, [Out] BJALCJFPADK ILLDGNOPAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x75244A0", Offset = "0x75236A0", VA = "0x1875244A0", Slot = "15")]
	public bool OCINMFIBOEH(BDPKLDEADOF PGEJNBOCJDO, [Out] HCJKHCGFOGA LFLDPFDMMDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x75242F0", Offset = "0x75234F0", VA = "0x1875242F0")]
	protected BJALCJFPADK KLNGIGOBEOK(HCJKHCGFOGA EGHIILCKOIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7523CD0", Offset = "0x7522ED0", VA = "0x187523CD0", Slot = "10")]
	public bool KFMPPNNDNAB(BDPKLDEADOF DMJMJBEEGKL, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7523200", Offset = "0x7522400", VA = "0x187523200")]
	private bool HEEBHAHNNJN(BDPKLDEADOF DMJMJBEEGKL, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7521E80", Offset = "0x7521080", VA = "0x187521E80")]
	private static bool CENHNCCCNDG(BJALCJFPADK IFIBNBJFMAD, HCJKHCGFOGA FBJEHFOILKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x75222E0", Offset = "0x75214E0", VA = "0x1875222E0", Slot = "7")]
	private bool JOMNOPNOECA([In] PFCKCCPFEPL LJELDKAOCJM, bool MAFBHAMFICC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class EMKJMADANLO : CFEDDCDGFOG, DKPHGOHMHMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly ANOENEDKKHA GFOILLNHEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly BDOCKFOALPM CHFDDPBNFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly DEJFAMLGAKP FGNAONMKMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly EGJIFLEBDFH EDOFGLHCGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly NJBEJIOEHAD COLCBEIJDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal ONLMMCHAPFM EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal DHPOEAACENJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal AHCACLPOBPJ BLNNHKNBMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool GPOENBFPGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool ECKJKJJFJDI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HJFEJEOLNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAEAD30", Offset = "0xAE9F30", VA = "0x180AEAD30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCDC0", VA = "0x1810DDBC0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HMMGIGDCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xFD73B0", Offset = "0xFD65B0", VA = "0x180FD73B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2394D80", Offset = "0x2393F80", VA = "0x182394D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GHGDMGHANNC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<BDPKLDEADOF, BDPKLDEADOF> KHIAGPDKDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x752C5A0", Offset = "0x752B7A0", VA = "0x18752C5A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x752BC00", Offset = "0x752AE00", VA = "0x18752BC00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<BDPKLDEADOF, BDPKLDEADOF> GAKLODBJCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x752B610", Offset = "0x752A810", VA = "0x18752B610", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x752B960", Offset = "0x752AB60", VA = "0x18752B960", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<BDPKLDEADOF, BDPKLDEADOF, BDPKLDEADOF> ONIBHIKALDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x752C1B0", Offset = "0x752B3B0", VA = "0x18752C1B0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x752CDF0", Offset = "0x752BFF0", VA = "0x18752CDF0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x752CF20", Offset = "0x752C120", VA = "0x18752CF20")]
	public EMKJMADANLO(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x752C7E0", Offset = "0x752B9E0", VA = "0x18752C7E0", Slot = "12")]
	public void PDAIGIIELDH(GameObject LNIONOAAAEO, FPJLGLMFNFN MHPNJAFMOHP, ENIIOOLDJGI NLPBCEOPNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x752CE50", Offset = "0x752C050", VA = "0x18752CE50", Slot = "26")]
	public void PPDMLGCOEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x752B690", Offset = "0x752A890", VA = "0x18752B690", Slot = "13")]
	public void DJHAIOPCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x752B670", Offset = "0x752A870", VA = "0x18752B670", Slot = "14")]
	public void COGNOIDNGPM(BDPKLDEADOF PGEJNBOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x752B230", Offset = "0x752A430", VA = "0x18752B230", Slot = "15")]
	public void AGGOIHIHDOM(BDPKLDEADOF PGEJNBOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x752BFF0", Offset = "0x752B1F0", VA = "0x18752BFF0", Slot = "22")]
	public bool IFPHNINFHBD(PIHNKOIIPAF CPHOLCKELIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x752BEE0", Offset = "0x752B0E0", VA = "0x18752BEE0")]
	internal bool HEEBHAHNNJN([In] PFCKCCPFEPL LJELDKAOCJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x752C600", Offset = "0x752B800", VA = "0x18752C600")]
	internal bool ONLNDLKOHIH([In] PFCKCCPFEPL LJELDKAOCJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x752B290", Offset = "0x752A490", VA = "0x18752B290")]
	internal void BBNKDDOIEPL(BDPKLDEADOF PGEJNBOCJDO, int NBFMDMMLHPB, bool MAFBHAMFICC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x752B230", Offset = "0x752A430", VA = "0x18752B230")]
	internal bool KOKDLGKIJCM(BDPKLDEADOF DMINEEDJFAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x752C080", Offset = "0x752B280", VA = "0x18752C080")]
	internal bool LMHPFPCKGIB(BDPKLDEADOF ONHBJCBPHJP, int IHOHLPPMFNM, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x752BB00", Offset = "0x752AD00", VA = "0x18752BB00", Slot = "16")]
	public void FDBIIPKMEEI(BDPKLDEADOF PGEJNBOCJDO, HashSet<BDPKLDEADOF> DONMINGNPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x752C210", Offset = "0x752B410", VA = "0x18752C210", Slot = "17")]
	public void NBGCMMHAMLC(BDPKLDEADOF ONHBJCBPHJP, BDPKLDEADOF KNLMPEHKLAD, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x752B9C0", Offset = "0x752ABC0", VA = "0x18752B9C0", Slot = "18")]
	public void EOAEJPEAIKJ(BDPKLDEADOF DMJMJBEEGKL, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x752BD10", Offset = "0x752AF10", VA = "0x18752BD10", Slot = "19")]
	public void HCMNCGOPGAM(BDPKLDEADOF DMJMJBEEGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x752B710", Offset = "0x752A910", VA = "0x18752B710")]
	public void EDLBDJMGMGP([Optional] BPHHBLKLOFF IMLNCPGCOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x752C750", Offset = "0x752B950", VA = "0x18752C750", Slot = "23")]
	public void PAEGEBNCHPL(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x752C420", Offset = "0x752B620", VA = "0x18752C420", Slot = "20")]
	public MAFLPNHIGMP NBGDPNOCGFN(bool NJLECMIENIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x752B470", Offset = "0x752A670", VA = "0x18752B470", Slot = "21")]
	public MAFLPNHIGMP CAGANEBHILF(HashSet<Guid> HIMHIPKPOGI, bool NJLECMIENIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x752C040", Offset = "0x752B240", VA = "0x18752C040", Slot = "25")]
	public void JLJEOPCKBCA(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x752BC60", Offset = "0x752AE60", VA = "0x18752BC60", Slot = "24")]
	public void GKKGNJAFAOB(MAFLPNHIGMP COLCBEIJDBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class BDOCKFOALPM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly NENPGIPFKEI<BDPKLDEADOF, BDPKLDEADOF> KHIAGPDKDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly NENPGIPFKEI<BDPKLDEADOF, BDPKLDEADOF> GAKLODBJCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly FDIMHAPMLGB<BDPKLDEADOF, BDPKLDEADOF, BDPKLDEADOF> ONIBHIKALDD;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7524DB0", Offset = "0x7523FB0", VA = "0x187524DB0")]
	public BDOCKFOALPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	public void PDAIGIIELDH(EMKJMADANLO CKLPHBNMNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7524D50", Offset = "0x7523F50", VA = "0x187524D50")]
	public void MNCHBNLBBEH(BDPKLDEADOF JNGEIJHHFEP, BDPKLDEADOF OAOLODPFDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7524CF0", Offset = "0x7523EF0", VA = "0x187524CF0")]
	public void JADLJIFAOMD(BDPKLDEADOF JNGEIJHHFEP, BDPKLDEADOF OAOLODPFDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7524C70", Offset = "0x7523E70", VA = "0x187524C70")]
	public void FONGFPHHOJM(BDPKLDEADOF PKMKJKDCFHL, BDPKLDEADOF NAAOBFPOHHG, BDPKLDEADOF OAOLODPFDMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class DEJFAMLGAKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private EMKJMADANLO CKLPHBNMNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private DHPOEAACENJ IMAAHCGDBEG;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DEJFAMLGAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7528930", Offset = "0x7527B30", VA = "0x187528930")]
	public void PDAIGIIELDH(EMKJMADANLO CKLPHBNMNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x75286C0", Offset = "0x75278C0", VA = "0x1875286C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x75287E0", Offset = "0x75279E0", VA = "0x1875287E0")]
	private void LHJONMEIOND(NEPEIILKAIK ADIMAPFNMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7528650", Offset = "0x7527850", VA = "0x187528650")]
	private void DEOFBNCJHAJ(BPHHBLKLOFF JHMGCOCEGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x75286D0", Offset = "0x75278D0", VA = "0x1875286D0")]
	public void FGIILPCHHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7528820", Offset = "0x7527A20", VA = "0x187528820")]
	public void NLBNOGJHPGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class AIPBFDOJAGI
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JLHLDCBLNND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public ANOENEDKKHA container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JLHLDCBLNND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7533780", Offset = "0x7532980", VA = "0x187533780")]
		internal EMKJMADANLO HDECKFOFCOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7524A70", Offset = "0x7523C70", VA = "0x187524A70")]
	public static void EMIGEDFFJEA(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x75249F0", Offset = "0x7523BF0", VA = "0x1875249F0")]
	public static void DEGPBHFDFEJ(ANOENEDKKHA GFOILLNHEFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class HOHAJMIJAMD : IDisposable, AHCACLPOBPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, JMADKDMKBCF> FEMGCAOKOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly OOFPHKOHMPG IDOJNHPHPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private MMPMADCEKPK FNENHOOMGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NJBEJIOEHAD COLCBEIJDBM;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker EOHLGPAABPO;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x75334E0", Offset = "0x75326E0", VA = "0x1875334E0")]
	public HOHAJMIJAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7533440", Offset = "0x7532640", VA = "0x187533440", Slot = "7")]
	public void PDAIGIIELDH(NJBEJIOEHAD COLCBEIJDBM, MMPMADCEKPK FNENHOOMGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7532E80", Offset = "0x7532080", VA = "0x187532E80", Slot = "5")]
	public void KHGHMODHCEJ(DAGDMKEIAAM AGGLCBIMIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x75332D0", Offset = "0x75324D0", VA = "0x1875332D0", Slot = "9")]
	public void PAFAANAKIEB(DAGDMKEIAAM FDGOAEOFDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x75327C0", Offset = "0x75319C0", VA = "0x1875327C0", Slot = "8")]
	public void BADKEAKEKNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7532B30", Offset = "0x7531D30", VA = "0x187532B30", Slot = "10")]
	public void GHNFLBPGJFC(DAGDMKEIAAM PCKKMLKJFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7533120", Offset = "0x7532320", VA = "0x187533120", Slot = "11")]
	public void OLEHLKKEPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7532980", Offset = "0x7531B80", VA = "0x187532980")]
	private bool BAEHJBJNBPH(DAGDMKEIAAM NEFHNGEGIGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class EGJIFLEBDFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct BODDMAJHCEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly BJALCJFPADK FADLFMEFNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> HIMHIPKPOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly PIHNKOIIPAF LIDIBNINBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly PIHNKOIIPAF FGBHJFAHDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool NJLECMIENIO;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool ENOJMKLLFKC
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7525AC0", Offset = "0x7524CC0", VA = "0x187525AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7526390", Offset = "0x7525590", VA = "0x187526390")]
		public BODDMAJHCEO(BJALCJFPADK FADLFMEFNDA, HashSet<Guid> HIMHIPKPOGI, bool NJLECMIENIO, [Optional] PIHNKOIIPAF LIDIBNINBNO, [Optional] PIHNKOIIPAF FGBHJFAHDCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7525BE0", Offset = "0x7524DE0", VA = "0x187525BE0")]
		public PIHNKOIIPAF JEAAONFOJJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7525FA0", Offset = "0x75251A0", VA = "0x187525FA0")]
		private PIHNKOIIPAF LJHJLHJMNDD([Out] PIHNKOIIPAF JJNDJOPLLLG, [Out] PIHNKOIIPAF MGJNHLJFOGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7525D80", Offset = "0x7524F80", VA = "0x187525D80")]
		private PIHNKOIIPAF LGJBOLNPLLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7526220", Offset = "0x7525420", VA = "0x187526220")]
		private void PPHLJMLDILL(PIHNKOIIPAF BDENFBGNFJH, PIHNKOIIPAF OEEPDHFNPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7526060", Offset = "0x7525260", VA = "0x187526060")]
		private void MDNLIMLJPJC(PIHNKOIIPAF JJNDJOPLLLG, PIHNKOIIPAF MGJNHLJFOGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private EMKJMADANLO CKLPHBNMNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NJBEJIOEHAD COLCBEIJDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private AHCACLPOBPJ PFBBIOKDKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private DHPOEAACENJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool KEFPBBNAMNL;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool PIOMDMDDAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x75299F0", Offset = "0x7528BF0", VA = "0x1875299F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool HJFEJEOLNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7528E30", Offset = "0x7528030", VA = "0x187528E30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x75294F0", Offset = "0x75286F0", VA = "0x1875294F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x752AFF0", Offset = "0x752A1F0", VA = "0x18752AFF0")]
	public void PDAIGIIELDH(EMKJMADANLO CKLPHBNMNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x752A5F0", Offset = "0x75297F0", VA = "0x18752A5F0")]
	public MAFLPNHIGMP NBGDPNOCGFN(bool NJLECMIENIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7528A70", Offset = "0x7527C70", VA = "0x187528A70")]
	public MAFLPNHIGMP CAGANEBHILF(HashSet<Guid> HIMHIPKPOGI, bool NJLECMIENIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x752AF60", Offset = "0x752A160", VA = "0x18752AF60")]
	public void PAEGEBNCHPL(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7529000", Offset = "0x7528200", VA = "0x187529000")]
	public void GKKGNJAFAOB(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7528E50", Offset = "0x7528050", VA = "0x187528E50")]
	public void FDFKCAKEBJG(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x75290A0", Offset = "0x75282A0", VA = "0x1875290A0")]
	private void GNJJHCIEBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x752A330", Offset = "0x7529530", VA = "0x18752A330")]
	private PIHNKOIIPAF MPKIPCNJJKB(BJALCJFPADK ILLDGNOPAEF, bool NJLECMIENIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x75297A0", Offset = "0x75289A0", VA = "0x1875297A0")]
	private static void ILNALFDFBIJ(BJALCJFPADK ILLDGNOPAEF, bool NJLECMIENIO, PIHNKOIIPAF CPHOLCKELIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7528C10", Offset = "0x7527E10", VA = "0x187528C10")]
	private void EBGLNGONEMO(BJALCJFPADK ILLDGNOPAEF, bool NJLECMIENIO, PIHNKOIIPAF CPHOLCKELIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x752A560", Offset = "0x7529760", VA = "0x18752A560")]
	private PIHNKOIIPAF NBFLGGLHPCC(BJALCJFPADK FADLFMEFNDA, HashSet<Guid> HIMHIPKPOGI, bool NJLECMIENIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x752A0A0", Offset = "0x75292A0", VA = "0x18752A0A0")]
	private bool MOHNALFFPKL(MAFLPNHIGMP HKFDKLNMJEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x752A8F0", Offset = "0x7529AF0", VA = "0x18752A8F0")]
	private bool ONGDGIMOFMC(PIHNKOIIPAF CPHOLCKELIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7529B90", Offset = "0x7528D90", VA = "0x187529B90")]
	private bool LKMHJMABFBE(MAFLPNHIGMP COLCBEIJDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7529A80", Offset = "0x7528C80", VA = "0x187529A80")]
	private static bool KMFMCBIBKNB(PIHNKOIIPAF CPHOLCKELIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7529510", Offset = "0x7528710", VA = "0x187529510")]
	public static bool IFPHNINFHBD(PIHNKOIIPAF CPHOLCKELIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7529BB0", Offset = "0x7528DB0", VA = "0x187529BB0")]
	private BDPKLDEADOF MFMOMPEKIGC(PIHNKOIIPAF CPHOLCKELIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7528E80", Offset = "0x7528080", VA = "0x187528E80")]
	private BDPKLDEADOF FPDCOIJOAIL(PIHNKOIIPAF CPHOLCKELIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7529F10", Offset = "0x7529110", VA = "0x187529F10")]
	private BDPKLDEADOF MJLFEOIAALM(PIHNKOIIPAF CPHOLCKELIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7529A40", Offset = "0x7528C40", VA = "0x187529A40")]
	private static Guid KAKIMGPOLIM(PIHNKOIIPAF CPHOLCKELIL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x752B060", Offset = "0x752A260", VA = "0x18752B060")]
	private string PDDBEBHGODC(PIHNKOIIPAF CPHOLCKELIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x752A760", Offset = "0x7529960", VA = "0x18752A760")]
	private bool OMNFMEHOBOH(BJALCJFPADK ILLDGNOPAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7529290", Offset = "0x7528490", VA = "0x187529290")]
	private static void HIAOIJDJOGG(BJALCJFPADK FADLFMEFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public EGJIFLEBDFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct PFCKCCPFEPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public BDPKLDEADOF OAOLODPFDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public BDPKLDEADOF JNGEIJHHFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int IHOHLPPMFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int OLFGCNMGCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 KMPFBIGDKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion FCFDNDACGPN;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HCJKHCGFOGA JPAKJMJBOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7535A10", Offset = "0x7534C10", VA = "0x187535A10")]
		get
		{
			return default(HCJKHCGFOGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HCJKHCGFOGA JGPDFDPMMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7535AB0", Offset = "0x7534CB0", VA = "0x187535AB0")]
		get
		{
			return default(HCJKHCGFOGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7535AE0", Offset = "0x7534CE0", VA = "0x187535AE0")]
	public PFCKCCPFEPL(BDPKLDEADOF OAOLODPFDMA, BDPKLDEADOF JNGEIJHHFEP, int IHOHLPPMFNM, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface NJBEJIOEHAD
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	DAGDMKEIAAM GMOCPPMLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDAIGIIELDH(CFEDDCDGFOG CKLPHBNMNHA);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ECOGFEFHAOM([In] PFCKCCPFEPL LJELDKAOCJM, bool MAFBHAMFICC = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IIGBCALPIIJ(BDPKLDEADOF CCFEHKJPDDH);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EOEGKPBDLLL(BDPKLDEADOF ONHBJCBPHJP, int IHOHLPPMFNM, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KFMPPNNDNAB(BDPKLDEADOF DMJMJBEEGKL, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IPBFJFBOFFD();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DJJBCLPIKEJ(Func<BDPKLDEADOF, bool> PEGADAMMHKJ);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FDBIIPKMEEI(BDPKLDEADOF PGEJNBOCJDO, HashSet<BDPKLDEADOF> BAPFNDCJKGO);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<BDPKLDEADOF> BAPAPCFHCBF();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OCINMFIBOEH(BDPKLDEADOF PGEJNBOCJDO, [Out] HCJKHCGFOGA LFLDPFDMMDM);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KCGHHHLGBKO(OOFPHKOHMPG GIIPLELNBKP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool OOFPHKOHMPG(DAGDMKEIAAM ILLDGNOPAEF);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface DAGDMKEIAAM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BDPKLDEADOF HDCGOGHKPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DAGDMKEIAAM JCHDMDCGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HCJKHCGFOGA MCKFCFDDNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool JBCHLOEBCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JMADKDMKBCF
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMBIHAFPMPJ(BDPKLDEADOF ADBCMPCNGNI, HCJKHCGFOGA OAOLODPFDMA);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPDIABMNACB(BDPKLDEADOF ADBCMPCNGNI, HCJKHCGFOGA OAOLODPFDMA);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INPNOAHPEKF(BDPKLDEADOF ADBCMPCNGNI, HCJKHCGFOGA OAOLODPFDMA);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void APHHGIAOEDD(BDPKLDEADOF ADBCMPCNGNI, HCJKHCGFOGA OAOLODPFDMA);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JMADKDMKBCF Instantiate(Transform LBAHEDDLOKA);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFMIMIFACMK();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface MMPMADCEKPK
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDAIGIIELDH(Transform LBAHEDDLOKA, JMADKDMKBCF PGOBMLNEPJD);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JMADKDMKBCF GGPJAFMHDFF();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBEKNKFKKIC(JMADKDMKBCF OGLIBBNDEPP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ONLMMCHAPFM : HHGKFCHBFEC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBACKIEANAC();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNJPILMPMKL(Guid NDFBNLGMNMN);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface AHCACLPOBPJ
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHGHMODHCEJ(DAGDMKEIAAM AGGLCBIMIIJ);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PDAIGIIELDH(NJBEJIOEHAD COLCBEIJDBM, MMPMADCEKPK AAGOFPDBANG);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BADKEAKEKNC();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PAFAANAKIEB(DAGDMKEIAAM FDGOAEOFDKE);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GHNFLBPGJFC(DAGDMKEIAAM PCKKMLKJFAC);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLEHLKKEPIL();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class BJALCJFPADK : DAGDMKEIAAM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class MINNBKMPEKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public HCJKHCGFOGA nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public BJALCJFPADK foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MINNBKMPEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x75342F0", Offset = "0x75334F0", VA = "0x1875342F0")]
		internal bool MEJPOOPGEFM(DAGDMKEIAAM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HCJKHCGFOGA LFLDPFDMMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<BJALCJFPADK> EALBHAANOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private BJALCJFPADK MLAGCJCCKEL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public HCJKHCGFOGA MCKFCFDDNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x10DD940", Offset = "0x10DCB40", VA = "0x1810DD940", Slot = "6")]
		get
		{
			return default(HCJKHCGFOGA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x10DDC70", Offset = "0x10DCE70", VA = "0x1810DDC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private BJALCJFPADK JNGEIJHHFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7525030", Offset = "0x7524230", VA = "0x187525030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DAGDMKEIAAM JCHDMDCGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BDPKLDEADOF HDCGOGHKPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JBCHLOEBCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7524ED0", Offset = "0x75240D0", VA = "0x187524ED0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool JHNLKAEJALL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7525430", Offset = "0x7524630", VA = "0x187525430", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected BJALCJFPADK BFPPPKIAFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7525480", Offset = "0x7524680", VA = "0x187525480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7525950", Offset = "0x7524B50", VA = "0x187525950")]
	public BJALCJFPADK(HCJKHCGFOGA POOHDHCCHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7524EE0", Offset = "0x75240E0", VA = "0x187524EE0")]
	public BJALCJFPADK DLFMCGODDHH(HCJKHCGFOGA BEJKCPGHOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x75257D0", Offset = "0x75249D0", VA = "0x1875257D0")]
	public BJALCJFPADK PLNCDKLEFDO(HCJKHCGFOGA JGNGOEADEAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x75255F0", Offset = "0x75247F0", VA = "0x1875255F0")]
	public BJALCJFPADK OGPGHNCGHLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x75254A0", Offset = "0x75246A0", VA = "0x1875254A0")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7525110", Offset = "0x7524310", VA = "0x187525110")]
	public BJALCJFPADK IAIPOEAKCPD(HCJKHCGFOGA NAAOBFPOHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x75251D0", Offset = "0x75243D0", VA = "0x1875251D0")]
	private static void KCGHHHLGBKO(BJALCJFPADK MCCIOOILEAM, OOFPHKOHMPG BHEFDPAMAKP, bool APPAMNBOIPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x75251C0", Offset = "0x75243C0", VA = "0x1875251C0", Slot = "9")]
	public void KCGHHHLGBKO(OOFPHKOHMPG GIIPLELNBKP, bool JOLBPJLFJJH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7525330", Offset = "0x7524530", VA = "0x187525330")]
	public static BJALCJFPADK KLNGIGOBEOK(BJALCJFPADK MCCIOOILEAM, HCJKHCGFOGA CEABCFPLEJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface DHPOEAACENJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool PIOMDMDDAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LBBEDEHLLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<NEPEIILKAIK> LHJONMEIOND;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<BPHHBLKLOFF> DEOFBNCJHAJ;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EMBIHAFPMPJ(EMKJMADANLO CKLPHBNMNHA, ENIIOOLDJGI PDNEGDCPCMC);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NBGCMMHAMLC(BDPKLDEADOF ONHBJCBPHJP, BDPKLDEADOF KNLMPEHKLAD, int IHOHLPPMFNM, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EOAEJPEAIKJ(BDPKLDEADOF DMJMJBEEGKL, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AFHKOHIJEKJ(MAFLPNHIGMP AEFLNDLMPAP, [Optional] BPHHBLKLOFF IMLNCPGCOJA);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BPNCCJGLEEO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type FCLHHMOEMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7526490", Offset = "0x7525690", VA = "0x187526490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object JLGHKLNHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7526400", Offset = "0x7525600", VA = "0x187526400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7526440", Offset = "0x7525640", VA = "0x187526440")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class NEKMCNHFNMA : DHPOEAACENJ, IDisposable, KLEKMEOGHLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private EMKJMADANLO CKLPHBNMNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private ENIIOOLDJGI NLPBCEOPNDC;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PIOMDMDDAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7535000", Offset = "0x7534200", VA = "0x187535000", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool LBBEDEHLLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x75350F0", Offset = "0x75342F0", VA = "0x1875350F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView DNNHDCAMIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7535060", Offset = "0x7534260", VA = "0x187535060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NEPEIILKAIK> LHJONMEIOND
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7534C30", Offset = "0x7533E30", VA = "0x187534C30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7534F70", Offset = "0x7534170", VA = "0x187534F70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BPHHBLKLOFF> DEOFBNCJHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7534ED0", Offset = "0x75340D0", VA = "0x187534ED0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7535260", Offset = "0x7534460", VA = "0x187535260", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7534D10", Offset = "0x7533F10", VA = "0x187534D10", Slot = "10")]
	public void EMBIHAFPMPJ(EMKJMADANLO CKLPHBNMNHA, ENIIOOLDJGI NLPBCEOPNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7534CC0", Offset = "0x7533EC0", VA = "0x187534CC0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7535130", Offset = "0x7534330", VA = "0x187535130", Slot = "11")]
	public void NBGCMMHAMLC(BDPKLDEADOF ONHBJCBPHJP, BDPKLDEADOF KNLMPEHKLAD, int IHOHLPPMFNM, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7534DA0", Offset = "0x7533FA0", VA = "0x187534DA0", Slot = "12")]
	public void EOAEJPEAIKJ(BDPKLDEADOF DMJMJBEEGKL, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7534B00", Offset = "0x7533D00", VA = "0x187534B00", Slot = "13")]
	public void AFHKOHIJEKJ(MAFLPNHIGMP AEFLNDLMPAP, [Optional] BPHHBLKLOFF IMLNCPGCOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7535540", Offset = "0x7534740", VA = "0x187535540")]
	[FFNFKFIEFNL]
	private void RpcMasterReparentNodes(BDPKLDEADOF DMJMJBEEGKL, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7535340", Offset = "0x7534540", VA = "0x187535340")]
	[FFNFKFIEFNL]
	private void RpcMasterModifyNode(BDPKLDEADOF ONHBJCBPHJP, BDPKLDEADOF KNLMPEHKLAD, int IHOHLPPMFNM, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7535910", Offset = "0x7534B10", VA = "0x187535910")]
	[FFNFKFIEFNL]
	private void RpcReparentNodes(BDPKLDEADOF DMJMJBEEGKL, int LDCNENCJMGJ, BDPKLDEADOF NAAOBFPOHHG, int FDPGHHJONAO, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN, IKDKLKDIHHN PLEGPIABHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7535850", Offset = "0x7534A50", VA = "0x187535850")]
	[FFNFKFIEFNL]
	private void RpcModifyNode(BDPKLDEADOF ONHBJCBPHJP, int IHOHLPPMFNM, int OLFGCNMGCFJ, Vector3 KMPFBIGDKPE, Quaternion FCFDNDACGPN, IKDKLKDIHHN PLEGPIABHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7535300", Offset = "0x7534500", VA = "0x187535300")]
	[FFNFKFIEFNL]
	private void RpcDeserializeConnectableGraph(MAFLPNHIGMP COLCBEIJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public NEKMCNHFNMA()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, JMADKDMKBCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7533990", Offset = "0x7532B90", VA = "0x187533990", Slot = "4")]
		private void AFPNBOCJDIK(BDPKLDEADOF ADBCMPCNGNI, HCJKHCGFOGA OAOLODPFDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7533D70", Offset = "0x7532F70", VA = "0x187533D70", Slot = "5")]
		private void HIHLOPEEIMM(BDPKLDEADOF ADBCMPCNGNI, HCJKHCGFOGA OAOLODPFDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7533FF0", Offset = "0x75331F0", VA = "0x187533FF0", Slot = "6")]
		private void OHLBMAFDEAB(BDPKLDEADOF ADBCMPCNGNI, HCJKHCGFOGA OAOLODPFDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7533B10", Offset = "0x7532D10", VA = "0x187533B10", Slot = "7")]
		private void DAGBCGGPGNO(BDPKLDEADOF ADBCMPCNGNI, HCJKHCGFOGA OAOLODPFDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7533D00", Offset = "0x7532F00", VA = "0x187533D00", Slot = "8")]
		private JMADKDMKBCF GOKKDAAALMC(Transform LBAHEDDLOKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7533930", Offset = "0x7532B30", VA = "0x187533930", Slot = "9")]
		private void ACIPANCLBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class HMPFDKALOGI
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x34BD9E0", Offset = "0x34BCBE0", VA = "0x1834BD9E0")]
	public static DIGNJKHLCEC<T> PPPFPKDNFCO<T>(this ANOENEDKKHA GFOILLNHEFN)
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
