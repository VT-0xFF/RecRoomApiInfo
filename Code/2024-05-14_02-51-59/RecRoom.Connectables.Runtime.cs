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
using RecRoom.Logging.Attributes;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : DEDNPPDJFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6291B40", Offset = "0x6290540", VA = "0x186291B40", Slot = "4")]
		public override void JIGIEBIDGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
	public class _AssemblyIndex : JFIBNGDIICO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LMAJIBLOEFA bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private LMAJIBLOEFA bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6295060", Offset = "0x6293A60", VA = "0x186295060", Slot = "5")]
		public override void HPCPHMIICDG(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6294EF0", Offset = "0x62938F0", VA = "0x186294EF0")]
		private void BDLNLNECOOJ(DBBHKBEGOEB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62953D0", Offset = "0x6293DD0", VA = "0x1862953D0")]
		private void LEBALFHACLI(DBBHKBEGOEB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62950A0", Offset = "0x6293AA0", VA = "0x1862950A0", Slot = "6")]
		public override void ILFDKCPJAHD(DBBHKBEGOEB registry, [In] GADFEOAAHAK filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "8")]
		public override void OOPDCFDDFOD(MDGGPHKAOOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6295540", Offset = "0x6293F40", VA = "0x186295540")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class ILEIADIJCLK : GJKIJDDCKBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class BHLHAMHHHKE : IEnumerable<FKKKMLOMHOH>, IEnumerable, IEnumerator<FKKKMLOMHOH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FKKKMLOMHOH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private MMBMADJJEAB localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MMBMADJJEAB <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ILEIADIJCLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PHDJGIJHHIJ <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JJOLFCGDJOI.NIFHHJDIDON <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FKKKMLOMHOH System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x820E60", Offset = "0x81F860", VA = "0x180820E60")]
		[DebuggerHidden]
		public BHLHAMHHHKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6281E40", Offset = "0x6280840", VA = "0x186281E40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6281980", Offset = "0x6280380", VA = "0x186281980", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6281960", Offset = "0x6280360", VA = "0x186281960")]
		private void AOIIEBMEGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6281DF0", Offset = "0x62807F0", VA = "0x186281DF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6281D40", Offset = "0x6280740", VA = "0x186281D40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FKKKMLOMHOH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6281D40", Offset = "0x6280740", VA = "0x186281D40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly LBNENDFDEJK OHHCDNHFCLK;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly LBNENDFDEJK ILIIGDIIDOC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly LBNENDFDEJK BEPNBBPDDPN;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly LBNENDFDEJK BMDLGLAMKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private JBLMOBBNPEC HIKBCOGIEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NKGGJAMICIA BMICOFMPFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private OEODAGFIFJP AHPIGGONIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private ILMDJOJAMBL NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private NFMDLGENFJM NCMHOFNMCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly FOFEOENBKAF GIMKPCGFLBB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DNNOPBKFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D47E0", Offset = "0x7D31E0", VA = "0x1807D47E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D43E0", Offset = "0x7D2DE0", VA = "0x1807D43E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MGKLHNCDAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<FKKKMLOMHOH, FKKKMLOMHOH> HMBJDFDELDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6286CF0", Offset = "0x62856F0", VA = "0x186286CF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6286270", Offset = "0x6284C70", VA = "0x186286270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<FKKKMLOMHOH, FKKKMLOMHOH> LGICIKKCNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6287FC0", Offset = "0x62869C0", VA = "0x186287FC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6287760", Offset = "0x6286160", VA = "0x186287760", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<FKKKMLOMHOH, FKKKMLOMHOH, FKKKMLOMHOH> DPPHJPEHCPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6285BB0", Offset = "0x62845B0", VA = "0x186285BB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6285B00", Offset = "0x6284500", VA = "0x186285B00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6288E20", Offset = "0x6287820", VA = "0x186288E20")]
	public ILEIADIJCLK(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6288640", Offset = "0x6287040", VA = "0x186288640", Slot = "12")]
	public void MPOMBMILLLK(GameObject PACDKKMGCFJ, DFJEMOBOFAC IHAMIMJDDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6285C60", Offset = "0x6284660", VA = "0x186285C60", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62835A0", Offset = "0x6281FA0", VA = "0x1862835A0", Slot = "22")]
	public bool JMKLOIEOBKI(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6287810", Offset = "0x6286210", VA = "0x186287810")]
	private void JKFLDBCGMFM(MMBMADJJEAB CBIAIPNMHBA, MMBMADJJEAB EACKAKOIDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6286050", Offset = "0x6284A50", VA = "0x186286050")]
	private void EDEBBGNPEBN(MMBMADJJEAB CBIAIPNMHBA, MMBMADJJEAB IEJKOBKAGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6286320", Offset = "0x6284D20", VA = "0x186286320")]
	private void ENBGCCNPCLK(MMBMADJJEAB CBIAIPNMHBA, MMBMADJJEAB IEJKOBKAGJC, MMBMADJJEAB EACKAKOIDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6286590", Offset = "0x6284F90", VA = "0x186286590")]
	private void FCCJJCOOHOD(MMBMADJJEAB CBIAIPNMHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "13")]
	public void JACDOJBEGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6287450", Offset = "0x6285E50", VA = "0x186287450", Slot = "14")]
	public void JIGIEBIDGIG(FKKKMLOMHOH PHMCJHPHMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "15")]
	public void ILHGCENAOJC(FKKKMLOMHOH PHMCJHPHMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6288A10", Offset = "0x6287410", VA = "0x186288A10", Slot = "17")]
	public void NNPMDGMBFEK(FKKKMLOMHOH PHMCJHPHMDK, FKKKMLOMHOH FKPKOLBGEFJ, Vector3 AFOLKIAHJCP, Quaternion JEMAGIAEKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6288B70", Offset = "0x6287570", VA = "0x186288B70")]
	public void NNPMDGMBFEK(MMBMADJJEAB APJECMEEJIN, MMBMADJJEAB FKPKOLBGEFJ, Vector3 AFOLKIAHJCP, Quaternion JEMAGIAEKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x62888B0", Offset = "0x62872B0", VA = "0x1862888B0")]
	public void NACGHFOMGAD(FKKKMLOMHOH PHMCJHPHMDK, float AFDEFBJNOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6285750", Offset = "0x6284150", VA = "0x186285750", Slot = "18")]
	public void DCNIFJJCBJJ(FKKKMLOMHOH LIPHKABODCG, int GJAHFCIGNEC, FKKKMLOMHOH PGAJJPKGJAA, int MPHHAKGEHCC, Vector3 AFOLKIAHJCP, Quaternion JEMAGIAEKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6285120", Offset = "0x6283B20", VA = "0x186285120")]
	private float BCPMPDCMDHK(MMBMADJJEAB APJECMEEJIN, MMBMADJJEAB HHJLJBMAMDD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6285620", Offset = "0x6284020", VA = "0x186285620")]
	public void DCNIFJJCBJJ(MMBMADJJEAB APJECMEEJIN, MMBMADJJEAB HHJLJBMAMDD, Vector3 AFOLKIAHJCP, Quaternion JEMAGIAEKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62858A0", Offset = "0x62842A0", VA = "0x1862858A0")]
	public void DCNIFJJCBJJ(MMBMADJJEAB APJECMEEJIN, MMBMADJJEAB HHJLJBMAMDD, Vector3 AFOLKIAHJCP, Quaternion JEMAGIAEKCI, float AFDEFBJNOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6285EE0", Offset = "0x62848E0", VA = "0x186285EE0", Slot = "19")]
	public void ECLCOBBPOKO(FKKKMLOMHOH PHMCJHPHMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6285390", Offset = "0x6283D90", VA = "0x186285390")]
	public bool CFCPDAPDDJJ(MMBMADJJEAB OCMIGFBMBMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6286F30", Offset = "0x6285930", VA = "0x186286F30", Slot = "16")]
	public void GBEBJPAJEDF(FKKKMLOMHOH PHMCJHPHMDK, HashSet<FKKKMLOMHOH> DIBJMBKJDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "20")]
	public KPHOIPKOKCK DHGJBFGHGHC(bool EKGBFGJIEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "21")]
	public KPHOIPKOKCK CGKCAJLCFFK(HashSet<Guid> CDKGEMFGCCA, bool EKGBFGJIEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62873E0", Offset = "0x6285DE0", VA = "0x1862873E0", Slot = "23")]
	public void IHPDCKHAPCB(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6288940", Offset = "0x6287340", VA = "0x186288940", Slot = "24")]
	public void NACOJKLBENB(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6284C30", Offset = "0x6283630", VA = "0x186284C30", Slot = "25")]
	public void ADHLAIEKFBJ(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6284760", Offset = "0x6283160", VA = "0x186284760")]
	private void AAOANMOHDHA(MMBMADJJEAB APJECMEEJIN, MMBMADJJEAB HHJLJBMAMDD, Vector3 AFOLKIAHJCP, Quaternion JEMAGIAEKCI, float AFDEFBJNOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6287BB0", Offset = "0x62865B0", VA = "0x186287BB0")]
	private void LCPADKEHOBP(MMBMADJJEAB APJECMEEJIN, MMBMADJJEAB GCDDFMLCKMH, Vector3 AFOLKIAHJCP, Quaternion JEMAGIAEKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6285900", Offset = "0x6284300", VA = "0x186285900")]
	private void DEIFIEEABJB(MMBMADJJEAB APJECMEEJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6285E50", Offset = "0x6284850", VA = "0x186285E50")]
	[IteratorStateMachine(typeof(BHLHAMHHHKE))]
	public IEnumerable<FKKKMLOMHOH> EBEEOICAIEL(MMBMADJJEAB OCMIGFBMBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6284FF0", Offset = "0x62839F0", VA = "0x186284FF0")]
	internal FKKKMLOMHOH AHMADBLPDOL(MMBMADJJEAB OCMIGFBMBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62851D0", Offset = "0x6283BD0", VA = "0x1862851D0")]
	internal MMBMADJJEAB BFCENDCCHAA(FKKKMLOMHOH PHMCJHPHMDK)
	{
		return default(MMBMADJJEAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6288070", Offset = "0x6286A70", VA = "0x186288070")]
	private bool MNFBPOMHJCE(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6284C50", Offset = "0x6283650", VA = "0x186284C50")]
	private bool ADMCMBJJDCB(JMLJJOAAIHO DCIMIGOEEFD, [Out] FKKKMLOMHOH HHJLJBMAMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6284CB0", Offset = "0x62836B0", VA = "0x186284CB0")]
	private FKKKMLOMHOH AHMADBLPDOL(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6287A20", Offset = "0x6286420", VA = "0x186287A20")]
	private FKKKMLOMHOH KIAJJGDNKKE(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6284AC0", Offset = "0x62834C0", VA = "0x186284AC0")]
	private FKKKMLOMHOH ADHGJKPBDIL(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6280A20", Offset = "0x627F420", VA = "0x186280A20")]
	private static Guid HMLMAGLFGLG(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x62852A0", Offset = "0x6283CA0", VA = "0x1862852A0")]
	private string CCFOIGOCCPI(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6287250", Offset = "0x6285C50", VA = "0x186287250")]
	private void HOBGCLFPLIP(FKKKMLOMHOH APJECMEEJIN, FKKKMLOMHOH GCDDFMLCKMH, RigidTransform HKMKIFGLNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6286DA0", Offset = "0x62857A0", VA = "0x186286DA0")]
	private void GADBLBBMGCK(FKKKMLOMHOH GCDDFMLCKMH, FKKKMLOMHOH APJECMEEJIN, RigidTransform HKMKIFGLNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62889B0", Offset = "0x62873B0", VA = "0x1862889B0")]
	private void NGEOHJMIAGD(FKKKMLOMHOH EDLGCAMJGHA, FKKKMLOMHOH APJECMEEJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6285970", Offset = "0x6284370", VA = "0x186285970")]
	private void DFCKILEHGLA(FKKKMLOMHOH APJECMEEJIN, FKKKMLOMHOH HHJLJBMAMDD, RigidTransform HKMKIFGLNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6287140", Offset = "0x6285B40", VA = "0x186287140")]
	private void HHBGDIIKIFL(MMBMADJJEAB OCMIGFBMBMB, FKKKMLOMHOH PHMCJHPHMDK, MMBMADJJEAB IEJKOBKAGJC, MMBMADJJEAB EACKAKOIDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6286A20", Offset = "0x6285420", VA = "0x186286A20")]
	private void FECKMAMFLPA(MMBMADJJEAB OCMIGFBMBMB, FKKKMLOMHOH PHMCJHPHMDK, FKKKMLOMHOH IFJENAFOGFK, FKKKMLOMHOH KGMEKBANJGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NOFNNABGKPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GAKKCBOBAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ICKBMMGCCPN container;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public GAKKCBOBAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6282980", Offset = "0x6281380", VA = "0x186282980")]
		internal ILEIADIJCLK LEBEAEJEBOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6292E90", Offset = "0x6291890", VA = "0x186292E90")]
	public static void PHLODKIBLGJ(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6292E40", Offset = "0x6291840", VA = "0x186292E40")]
	public static void MLHEDAPPBDF(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class ODPMMLJNMMG : FGEGKAFELHK, NBNFKNHMCOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly RigidbodyEx FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly ILEIADIJCLK MJNIGNONFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CPEJHLKPKEI MDEIDKGIOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly JAPJINECHKN NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MJMCMHDCBMF[] MNBIKGLLFKK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FKKKMLOMHOH ENJEAOHFAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6294C20", Offset = "0x6293620", VA = "0x186294C20", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FKKKMLOMHOH KKJFIONKAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6293200", Offset = "0x6291C00", VA = "0x186293200", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 GNMLLNNINHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x62948A0", Offset = "0x62932A0", VA = "0x1862948A0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion KNEHFFIBION
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6294970", Offset = "0x6293370", VA = "0x186294970", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool ECEMICPEPIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6294900", Offset = "0x6293300", VA = "0x186294900", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<FKKKMLOMHOH> CHKFCJDGNJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6293B00", Offset = "0x6292500", VA = "0x186293B00", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool INBDCDLGOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE840", Offset = "0x8AD240", VA = "0x1808AE840", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE960", Offset = "0x8AD360", VA = "0x1808AE960", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6294E30", Offset = "0x6293830", VA = "0x186294E30", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject JKMOLLDKDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x23C4A60", Offset = "0x23C3460", VA = "0x1823C4A60", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6294B50", Offset = "0x6293550", VA = "0x186294B50", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid CJLNLLIEING
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6294C80", Offset = "0x6293680", VA = "0x186294C80", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DEFGAMEGPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6294D60", Offset = "0x6293760", VA = "0x186294D60", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BMCLPKMIIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool AJFKAALBJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6293930", Offset = "0x6292330", VA = "0x186293930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event EMEGMCEMHMD LEGDCKCKGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x62949D0", Offset = "0x62933D0", VA = "0x1862949D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6294630", Offset = "0x6293030", VA = "0x186294630", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EMEGMCEMHMD DFNNDCEDLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62933F0", Offset = "0x6291DF0", VA = "0x1862933F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6293270", Offset = "0x6291C70", VA = "0x186293270", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event EMEGMCEMHMD PHEMBAKBHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x62942F0", Offset = "0x6292CF0", VA = "0x1862942F0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6293980", Offset = "0x6292380", VA = "0x186293980", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event JMCCNHAGHBC IMNAMCLFCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6293160", Offset = "0x6291B60", VA = "0x186293160", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6294250", Offset = "0x6292C50", VA = "0x186294250", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6294A50", Offset = "0x6293450", VA = "0x186294A50")]
	public ODPMMLJNMMG(MMBMADJJEAB FPDMJJHHMMN, RigidbodyEx FBPPOBEEAPL, CPEJHLKPKEI MDEIDKGIOLA, MJMCMHDCBMF[] MNBIKGLLFKK, JAPJINECHKN NJALJHMFPEI, GJKIJDDCKBL MJNIGNONFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6293130", Offset = "0x6291B30", VA = "0x186293130", Slot = "19")]
	public void ADOMGPBBEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "21")]
	public void JHALODNOADE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6108970", Offset = "0x6107370", VA = "0x186108970", Slot = "22")]
	public void AACPPNJFGKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x62938E0", Offset = "0x62922E0", VA = "0x1862938E0", Slot = "20")]
	public void HBIPAHEJJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6294690", Offset = "0x6293090", VA = "0x186294690", Slot = "25")]
	public void MPPABJAOLFB(int NEOBIHFFOEN, FKKKMLOMHOH PGAJJPKGJAA, int GMBELHGMABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x62939E0", Offset = "0x62923E0", VA = "0x1862939E0", Slot = "26")]
	public void HOHJOOGJMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6294350", Offset = "0x6292D50", VA = "0x186294350", Slot = "27")]
	public void LKMLMEEGMHO(int NEOBIHFFOEN, FKKKMLOMHOH LIPHKABODCG, int EMEBAGPGNAE, [Optional] Vector3? GBFCLDMNJNJ, [Optional] Quaternion? MDNCGLDKIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6293370", Offset = "0x6291D70", VA = "0x186293370", Slot = "28")]
	public void DEPNICGHHHL(FKKKMLOMHOH LIPHKABODCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6293B30", Offset = "0x6292530", VA = "0x186293B30", Slot = "31")]
	public void ILLJPNKIPAK(Vector3 FABHADAPPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6293F40", Offset = "0x6292940", VA = "0x186293F40", Slot = "29")]
	public void INOKDIJOAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x62934F0", Offset = "0x6291EF0", VA = "0x1862934F0", Slot = "30")]
	public void GOAMLIMFLCB(int ABBNIPHGMGH, Vector3 BNPKKMNBEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6293810", Offset = "0x6292210", VA = "0x186293810", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int NEOBIHFFOEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x62936E0", Offset = "0x62920E0", VA = "0x1862936E0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int NEOBIHFFOEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x870510", Offset = "0x86EF10", VA = "0x180870510", Slot = "42")]
	public Color GetConnectionSlotColor(int NEOBIHFFOEN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x62932D0", Offset = "0x6291CD0", VA = "0x1862932D0", Slot = "43")]
	public bool CanConnectTo(int NEOBIHFFOEN, FKKKMLOMHOH NHEABEKKPFN, int IBKHOJPPBCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "44")]
	public void ParentChanged(int NEOBIHFFOEN, FKKKMLOMHOH AFLFDOEEDOF, int LICBJDFOCNP, Vector3 GJGFFHCGNHG, Quaternion HOCNKHCDMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "45")]
	public void ChildAdded(int NEOBIHFFOEN, FKKKMLOMHOH LGAKEBGKDJB, int IJBGHDKLLAK, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "46")]
	public void ChildRemoved(int NEOBIHFFOEN, FKKKMLOMHOH JDJOMMIKMGG, int KHDHMLKOJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "47")]
	public void ConnectionModified(int NEOBIHFFOEN, FKKKMLOMHOH PGAJJPKGJAA, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6294A30", Offset = "0x6293430", VA = "0x186294A30", Slot = "48")]
	public void RootChanged(FKKKMLOMHOH IKENHPEAABJ, FKKKMLOMHOH AIPNLPJEBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6293450", Offset = "0x6291E50", VA = "0x186293450", Slot = "23")]
	public void GEGCLGNIKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6293AB0", Offset = "0x62924B0", VA = "0x186293AB0", Slot = "24")]
	public void IAJIBPMNFFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x62934A0", Offset = "0x6291EA0", VA = "0x1862934A0")]
	private void GEMDADLKEPN(bool CPNIHPILKNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[MBBAAMILDKG(typeof(BMLDLPCBPFK), new string[] { })]
public class LOPBCOOJEMJ : BMLDLPCBPFK, IODBKHDEGIK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DAAHMPKFELI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public LOPBCOOJEMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public JJOLFCGDJOI localIds;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public DAAHMPKFELI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62825A0", Offset = "0x6280FA0", VA = "0x1862825A0")]
		internal void JPPDIOELALH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[JGFNALFADIF]
	private HNHOAKIDOJM KGKIIJPBBFB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object FLIDODGBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x628FB40", Offset = "0x628E540", VA = "0x18628FB40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x628F980", Offset = "0x628E380", VA = "0x18628F980", Slot = "6")]
	public void InitReferences(GHIFKENEMPN GIMKPCGFLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x628F9D0", Offset = "0x628E3D0", VA = "0x18628F9D0", Slot = "5")]
	public void JFOBMEGHMMD(JJOLFCGDJOI ONHBEAIBAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public LOPBCOOJEMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[MBBAAMILDKG(typeof(GJKIJDDCKBL), new string[] { "Ignore", "Mock" })]
public class AJJNCMEAKCC : GJKIJDDCKBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DNNOPBKFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MGKLHNCDAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<FKKKMLOMHOH, FKKKMLOMHOH> HMBJDFDELDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x627E8F0", Offset = "0x627D2F0", VA = "0x18627E8F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x627E840", Offset = "0x627D240", VA = "0x18627E840", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<FKKKMLOMHOH, FKKKMLOMHOH> LGICIKKCNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x627EA50", Offset = "0x627D450", VA = "0x18627EA50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x627E9A0", Offset = "0x627D3A0", VA = "0x18627E9A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<FKKKMLOMHOH, FKKKMLOMHOH, FKKKMLOMHOH> DPPHJPEHCPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x627E790", Offset = "0x627D190", VA = "0x18627E790", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x627E6E0", Offset = "0x627D0E0", VA = "0x18627E6E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "12")]
	public void MPOMBMILLLK(GameObject PACDKKMGCFJ, DFJEMOBOFAC IHAMIMJDDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "13")]
	public void JACDOJBEGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "14")]
	public void JIGIEBIDGIG(FKKKMLOMHOH PHMCJHPHMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "15")]
	public void ILHGCENAOJC(FKKKMLOMHOH PHMCJHPHMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "16")]
	public void GBEBJPAJEDF(FKKKMLOMHOH PHMCJHPHMDK, HashSet<FKKKMLOMHOH> DIBJMBKJDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "17")]
	public void NNPMDGMBFEK(FKKKMLOMHOH PHMCJHPHMDK, FKKKMLOMHOH FKPKOLBGEFJ, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "18")]
	public void DCNIFJJCBJJ(FKKKMLOMHOH PHMCJHPHMDK, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "19")]
	public void ECLCOBBPOKO(FKKKMLOMHOH PHMCJHPHMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "20")]
	public KPHOIPKOKCK DHGJBFGHGHC(bool EKGBFGJIEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "21")]
	public KPHOIPKOKCK CGKCAJLCFFK(HashSet<Guid> CDKGEMFGCCA, bool EKGBFGJIEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "22")]
	public bool JMKLOIEOBKI(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "23")]
	public void IHPDCKHAPCB(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "24")]
	public void NACOJKLBENB(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "25")]
	public void ADHLAIEKFBJ(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public AJJNCMEAKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FKKKMLOMHOH : NBNFKNHMCOP, IEquatable<FKKKMLOMHOH>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NBNFKNHMCOP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	FKKKMLOMHOH ENJEAOHFAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject JKMOLLDKDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid CJLNLLIEING
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int DEFGAMEGPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BMCLPKMIIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int NEOBIHFFOEN);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int NEOBIHFFOEN);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int NEOBIHFFOEN);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int NEOBIHFFOEN, FKKKMLOMHOH NHEABEKKPFN, int PDHAMKDHAID);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int NEOBIHFFOEN, FKKKMLOMHOH AFLFDOEEDOF, int LICBJDFOCNP, Vector3 GJGFFHCGNHG, Quaternion HOCNKHCDMAE);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int NEOBIHFFOEN, FKKKMLOMHOH LGAKEBGKDJB, int IJBGHDKLLAK, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int NEOBIHFFOEN, FKKKMLOMHOH JDJOMMIKMGG, int KHDHMLKOJFP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int NEOBIHFFOEN, FKKKMLOMHOH PGAJJPKGJAA, int BNOMNFKIJOB, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(FKKKMLOMHOH IKENHPEAABJ, FKKKMLOMHOH AIPNLPJEBHN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface GJKIJDDCKBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DNNOPBKFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MGKLHNCDAKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FKKKMLOMHOH, FKKKMLOMHOH> HMBJDFDELDK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<FKKKMLOMHOH, FKKKMLOMHOH> LGICIKKCNGM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<FKKKMLOMHOH, FKKKMLOMHOH, FKKKMLOMHOH> DPPHJPEHCPE;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MPOMBMILLLK(GameObject PACDKKMGCFJ, DFJEMOBOFAC IHAMIMJDDKN);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JACDOJBEGNB();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JIGIEBIDGIG(FKKKMLOMHOH PHMCJHPHMDK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ILHGCENAOJC(FKKKMLOMHOH PHMCJHPHMDK);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GBEBJPAJEDF(FKKKMLOMHOH PHMCJHPHMDK, HashSet<FKKKMLOMHOH> DIBJMBKJDJB);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NNPMDGMBFEK(FKKKMLOMHOH PHMCJHPHMDK, FKKKMLOMHOH FKPKOLBGEFJ, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DCNIFJJCBJJ(FKKKMLOMHOH PHMCJHPHMDK, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ECLCOBBPOKO(FKKKMLOMHOH PHMCJHPHMDK);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KPHOIPKOKCK DHGJBFGHGHC(bool EKGBFGJIEOB);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	KPHOIPKOKCK CGKCAJLCFFK(HashSet<Guid> CDKGEMFGCCA, bool EKGBFGJIEOB);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JMKLOIEOBKI(JMLJJOAAIHO DCIMIGOEEFD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IHPDCKHAPCB(KPHOIPKOKCK HFKIFEHLALP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NACOJKLBENB(KPHOIPKOKCK HFKIFEHLALP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ADHLAIEKFBJ(KPHOIPKOKCK HFKIFEHLALP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ILMDJOJAMBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DMPMMNCDIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FKKKMLOMHOH ADHGJKPBDIL(int CIOAOLGOEEC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKKKMLOMHOH KIAJJGDNKKE(Guid IAEEJHHEIDH);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHAJOIAJMFC(FKKKMLOMHOH PHMCJHPHMDK);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GNHFCHBIIJL();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLDKLPKGLPL(FKKKMLOMHOH MDEIDKGIOLA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface JAPJINECHKN
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJFKAALBJCJ(CPEJHLKPKEI MDEIDKGIOLA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ACMNJDEAABD(CPEJHLKPKEI MDEIDKGIOLA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string IOFGJEGEGBC(CPEJHLKPKEI MDEIDKGIOLA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid APHFGMBEHCL(CPEJHLKPKEI MDEIDKGIOLA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LFLFJMONMPG(CPEJHLKPKEI MDEIDKGIOLA);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIPJHFJMMEP(CPEJHLKPKEI MDEIDKGIOLA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void EMEGMCEMHMD(FKKKMLOMHOH LIPHKABODCG, int GDAMDJAFPJF, FKKKMLOMHOH PGAJJPKGJAA, int IKKMJGMEPIL, [Optional] Vector3? GBFCLDMNJNJ, [Optional] Quaternion? MDNCGLDKIJE);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void JMCCNHAGHBC(FKKKMLOMHOH IKENHPEAABJ, FKKKMLOMHOH AIPNLPJEBHN);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CPEJHLKPKEI : FKKKMLOMHOH, NBNFKNHMCOP, IEquatable<FKKKMLOMHOH>
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FGEGKAFELHK : NBNFKNHMCOP
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FKKKMLOMHOH KKJFIONKAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<FKKKMLOMHOH> CHKFCJDGNJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 GNMLLNNINHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion KNEHFFIBION
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool ECEMICPEPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool INBDCDLGOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event EMEGMCEMHMD LEGDCKCKGAH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event EMEGMCEMHMD DFNNDCEDLIB;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event EMEGMCEMHMD PHEMBAKBHCE;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event JMCCNHAGHBC IMNAMCLFCDM;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ADOMGPBBEKI();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HBIPAHEJJPN();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JHALODNOADE();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AACPPNJFGKC();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GEGCLGNIKGE();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IAJIBPMNFFM();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MPPABJAOLFB(int NEOBIHFFOEN, FKKKMLOMHOH PGAJJPKGJAA, int GMBELHGMABN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HOHJOOGJMFP();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LKMLMEEGMHO(int NEOBIHFFOEN, FKKKMLOMHOH LIPHKABODCG, int EMEBAGPGNAE, [Optional] Vector3? GBFCLDMNJNJ, [Optional] Quaternion? MDNCGLDKIJE);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DEPNICGHHHL(FKKKMLOMHOH LIPHKABODCG);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void INOKDIJOAKC();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GOAMLIMFLCB(int ABBNIPHGMGH, Vector3 BNPKKMNBEBA);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ILLJPNKIPAK(Vector3 FABHADAPPGE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MJMCMHDCBMF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 OFAALFDKIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DFJEMOBOFAC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool HKEHNMNPOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EOHNBGKKFKO CCJGIELGKGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ConnectableConfigData : ScriptableObject, DFJEMOBOFAC
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x860540", Offset = "0x85EF40", VA = "0x180860540", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public EOHNBGKKFKO LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x62824A0", Offset = "0x6280EA0", VA = "0x1862824A0")]
		public static ConnectableConfigData NFFPOMHOMEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6282550", Offset = "0x6280F50", VA = "0x186282550")]
		public ConnectableConfigData(LegacyConnectableLinkVisual ICMKIGOCOKL, bool CGACEHFLJJG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BICBPKGIEFE : IEquatable<BICBPKGIEFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public FKKKMLOMHOH PHMCJHPHMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int BCBPFMFEAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int BNOMNFKIJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Vector3 GBFCLDMNJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Quaternion MDNCGLDKIJE;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x62823A0", Offset = "0x6280DA0", VA = "0x1862823A0")]
	public BICBPKGIEFE(FKKKMLOMHOH PHMCJHPHMDK, int BCBPFMFEAHC, int BNOMNFKIJOB, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6282400", Offset = "0x6280E00", VA = "0x186282400")]
	public BICBPKGIEFE(FKKKMLOMHOH PHMCJHPHMDK, int BCBPFMFEAHC, int BNOMNFKIJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6282310", Offset = "0x6280D10", VA = "0x186282310")]
	public BICBPKGIEFE(FKKKMLOMHOH PHMCJHPHMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6281EA0", Offset = "0x62808A0", VA = "0x186281EA0", Slot = "4")]
	public bool Equals(BICBPKGIEFE HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6281F50", Offset = "0x6280950", VA = "0x186281F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[UnityEngine.Scripting.Preserve]
public class NOKHINONJEB : JIJHLNKNFAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform OEIDOHJNAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EOHNBGKKFKO CFDKKPPANII;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F9A0", Offset = "0x5D8E3A0", VA = "0x185D8F9A0", Slot = "4")]
	public void MPOMBMILLLK(Transform OEIDOHJNAOK, EOHNBGKKFKO CFDKKPPANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6293010", Offset = "0x6291A10", VA = "0x186293010", Slot = "5")]
	public EOHNBGKKFKO AFFMPPJHIKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x62930E0", Offset = "0x6291AE0", VA = "0x1862930E0", Slot = "6")]
	public void PLMJGNLNJMC(EOHNBGKKFKO HFDCPOEIJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public NOKHINONJEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal class LKNONMELCKC : IDisposable, EJKMEDAMLDL
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HIJLPIEKMDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public FKKKMLOMHOH oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public FKKKMLOMHOH newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HIJLPIEKMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6282A30", Offset = "0x6281430", VA = "0x186282A30")]
		internal bool FJIFLGDHJCD(LJNPJDELHPK node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly JHMPLMFOJEN CFKLINGGJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private BHAHECKAIGK ENBIGLEHNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private JNGDINGNDHL GFKFCFMECNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool CGACEHFLJJG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LJNPJDELHPK PCJLIOJLCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x628B3A0", Offset = "0x6289DA0", VA = "0x18628B3A0")]
	public bool JGKOBAOKDPD([In] MIEGOOPOOBD ABDLEBPKDKC, bool JMCFBEJCMPM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x628E670", Offset = "0x628D070", VA = "0x18628E670")]
	private bool KBIKLCGAEAC([In] MIEGOOPOOBD ABDLEBPKDKC, bool JMCFBEJCMPM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x628F7B0", Offset = "0x628E1B0", VA = "0x18628F7B0")]
	public LKNONMELCKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x628EDC0", Offset = "0x628D7C0", VA = "0x18628EDC0", Slot = "5")]
	public void MPOMBMILLLK(GJKIJDDCKBL KEKOHNJFKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x628ADA0", Offset = "0x62897A0", VA = "0x18628ADA0", Slot = "17")]
	public void ANBKPGDGFMF(NKBDNDHCPFL JNDJHGKPENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x628DF10", Offset = "0x628C910", VA = "0x18628DF10", Slot = "12")]
	public void IDNHGLFAFGI(Func<FKKKMLOMHOH, bool> KCFJKHDAIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x628DC20", Offset = "0x628C620", VA = "0x18628DC20")]
	private void IDNHGLFAFGI(JHMPLMFOJEN KDIAAEPKAII, Func<FKKKMLOMHOH, bool> KCFJKHDAIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x628F050", Offset = "0x628DA50", VA = "0x18628F050", Slot = "11")]
	public void OEHOMEFGJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x628E3D0", Offset = "0x628CDD0", VA = "0x18628E3D0", Slot = "8")]
	public bool JKEOADHMKAJ(FKKKMLOMHOH JDPOBBHHNGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x628B630", Offset = "0x628A030", VA = "0x18628B630")]
	private bool CKGJHPCOMPO(FKKKMLOMHOH HDJOMKIFFDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x628D710", Offset = "0x628C110", VA = "0x18628D710")]
	private static bool GNDJHEHLMKE(FKKKMLOMHOH HDJOMKIFFDH, JHMPLMFOJEN BEEHDEFCICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x628DFF0", Offset = "0x628C9F0", VA = "0x18628DFF0")]
	private void JJOKEGGMDJJ(Transform AMOKBGMMPPD, JHMPLMFOJEN AGLMDGLHIAI, JHMPLMFOJEN[] MKOPFPGLEHL, FKKKMLOMHOH JJCOAGMOKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x628BE10", Offset = "0x628A810", VA = "0x18628BE10")]
	private BICBPKGIEFE DBHIHLHJFGC(Transform AAJJBMMNDEP, BICBPKGIEFE CMAPDKFAMNJ)
	{
		return default(BICBPKGIEFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x628F070", Offset = "0x628DA70", VA = "0x18628F070")]
	private static bool OFJEPAOOPOI(JHMPLMFOJEN BEEHDEFCICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x628DF20", Offset = "0x628C920", VA = "0x18628DF20")]
	private string IOFGJEGEGBC(FKKKMLOMHOH PHMCJHPHMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x628EC40", Offset = "0x628D640", VA = "0x18628EC40")]
	private string LFLFJMONMPG(FKKKMLOMHOH PHMCJHPHMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x628C560", Offset = "0x628AF60", VA = "0x18628C560")]
	private void DEPEMPFMEPJ([In] MIEGOOPOOBD ABDLEBPKDKC, bool ODHGHOOKBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x628D540", Offset = "0x628BF40", VA = "0x18628D540")]
	private void GBKLLJJOMDP(FKKKMLOMHOH APJECMEEJIN, bool ODHGHOOKBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x628ADD0", Offset = "0x62897D0", VA = "0x18628ADD0")]
	private void BNKPNAHMEHK(FKKKMLOMHOH GHJPPLIEFCL, int EMEBAGPGNAE, FKKKMLOMHOH GCDDFMLCKMH, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE, bool ODHGHOOKBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x628BF60", Offset = "0x628A960", VA = "0x18628BF60")]
	private void DDHAODLIKCI(FKKKMLOMHOH JANEFBOHNFL, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE, bool FGHEHJEPJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x628D7C0", Offset = "0x628C1C0", VA = "0x18628D7C0", Slot = "9")]
	public bool HKODNGCPJEI(FKKKMLOMHOH JANEFBOHNFL, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x628AB70", Offset = "0x6289570", VA = "0x18628AB70")]
	private bool AJLPBJKBCNF(FKKKMLOMHOH JANEFBOHNFL, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x628DAA0", Offset = "0x628C4A0", VA = "0x18628DAA0")]
	private static void IDIJBCEBAPG(FKKKMLOMHOH JANEFBOHNFL, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE, JHMPLMFOJEN DLDEFPFFIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x628D980", Offset = "0x628C380", VA = "0x18628D980")]
	private void HOBGCLFPLIP(FKKKMLOMHOH GHJPPLIEFCL, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x628D8A0", Offset = "0x628C2A0", VA = "0x18628D8A0")]
	private void HLAFIKKJJJP(JHMPLMFOJEN KDIAAEPKAII, FKKKMLOMHOH IFJENAFOGFK, FKKKMLOMHOH KGMEKBANJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x628D910", Offset = "0x628C310", VA = "0x18628D910")]
	private void HLAFIKKJJJP(FKKKMLOMHOH PHMCJHPHMDK, FKKKMLOMHOH IFJENAFOGFK, FKKKMLOMHOH KGMEKBANJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x628CED0", Offset = "0x628B8D0", VA = "0x18628CED0")]
	private void FECKMAMFLPA(FKKKMLOMHOH PHMCJHPHMDK, FKKKMLOMHOH IFJENAFOGFK, FKKKMLOMHOH KGMEKBANJGP, bool GEEEGCNOAMP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x628CDD0", Offset = "0x628B7D0", VA = "0x18628CDD0")]
	private void FECKMAMFLPA(JHMPLMFOJEN AKBOHBAKCNP, FKKKMLOMHOH JJCOAGMOKIK, FKKKMLOMHOH AIPNLPJEBHN, bool GEEEGCNOAMP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x628D070", Offset = "0x628BA70", VA = "0x18628D070")]
	private void GADBLBBMGCK(FKKKMLOMHOH APJECMEEJIN, int EMEBAGPGNAE, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x628EE50", Offset = "0x628D850", VA = "0x18628EE50")]
	private void NGEOHJMIAGD(LJNPJDELHPK HHJLJBMAMDD, LJNPJDELHPK DHJDGNGJFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x628CB80", Offset = "0x628B580", VA = "0x18628CB80", Slot = "18")]
	public FKKKMLOMHOH EEGBDOCILIC(FKKKMLOMHOH PHMCJHPHMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x628D190", Offset = "0x628BB90", VA = "0x18628D190", Slot = "13")]
	public void GBEBJPAJEDF(FKKKMLOMHOH PHMCJHPHMDK, HashSet<FKKKMLOMHOH> ODEPCCMGPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x628B3F0", Offset = "0x6289DF0", VA = "0x18628B3F0", Slot = "14")]
	public List<FKKKMLOMHOH> CIEGNCONLBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x628E5A0", Offset = "0x628CFA0", VA = "0x18628E5A0")]
	protected LJNPJDELHPK KAOCLLMCIOC(LJNPJDELHPK KDIAAEPKAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x628EFB0", Offset = "0x628D9B0", VA = "0x18628EFB0")]
	protected JHMPLMFOJEN[] NIFNPCKPLNK(JHMPLMFOJEN BEEHDEFCICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x628BD00", Offset = "0x628A700", VA = "0x18628BD00")]
	protected bool CMMACJDCHGE(FKKKMLOMHOH PHMCJHPHMDK, [Out] JHMPLMFOJEN KDIAAEPKAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x628CF40", Offset = "0x628B940", VA = "0x18628CF40", Slot = "15")]
	public bool FGHKMHHOMNA(FKKKMLOMHOH PHMCJHPHMDK, [Out] BICBPKGIEFE KGLINOICFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x628ECB0", Offset = "0x628D6B0", VA = "0x18628ECB0")]
	protected JHMPLMFOJEN LGCIGMIONAK(BICBPKGIEFE KIKGHICPIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x628CCE0", Offset = "0x628B6E0", VA = "0x18628CCE0", Slot = "10")]
	public bool EHBOGECJIPM(FKKKMLOMHOH GHJPPLIEFCL, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x628F230", Offset = "0x628DC30", VA = "0x18628F230")]
	private bool OLGJNPIILPE(FKKKMLOMHOH GHJPPLIEFCL, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x628ECF0", Offset = "0x628D6F0", VA = "0x18628ECF0")]
	private static bool MPJGEFLPNAP(JHMPLMFOJEN JBJAKKBBFMB, BICBPKGIEFE DAONIGMCHAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x628B3A0", Offset = "0x6289DA0", VA = "0x18628B3A0", Slot = "7")]
	private bool BOAKKBCNDEA([In] MIEGOOPOOBD ABDLEBPKDKC, bool JMCFBEJCMPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[UnityEngine.Scripting.Preserve]
internal class IEKFEJMKMCL : GJKIJDDCKBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly ICKBMMGCCPN NFHEIBLLDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly JNGDINGNDHL GFKFCFMECNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly MLALEDBOIAD FCLCPCNAEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly BFKFJDKDJBH NCHAPMEDOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly EJKMEDAMLDL HFKIFEHLALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal KANOLLOOODF NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal JHBCEMNALLK LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal BHAHECKAIGK OIMAEEPLOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal bool CGACEHFLJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool EJNFKBIAAMG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool NCMLLOPBJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x17AAF60", Offset = "0x17A9960", VA = "0x1817AAF60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x17AAF90", Offset = "0x17A9990", VA = "0x1817AAF90")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DNNOPBKFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x17AAF80", Offset = "0x17A9980", VA = "0x1817AAF80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x17AAF40", Offset = "0x17A9940", VA = "0x1817AAF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MGKLHNCDAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<FKKKMLOMHOH, FKKKMLOMHOH> HMBJDFDELDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6283220", Offset = "0x6281C20", VA = "0x186283220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x62831C0", Offset = "0x6281BC0", VA = "0x1862831C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<FKKKMLOMHOH, FKKKMLOMHOH> LGICIKKCNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6283670", Offset = "0x6282070", VA = "0x186283670", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6283540", Offset = "0x6281F40", VA = "0x186283540", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<FKKKMLOMHOH, FKKKMLOMHOH, FKKKMLOMHOH> DPPHJPEHCPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6282EF0", Offset = "0x62818F0", VA = "0x186282EF0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6282CB0", Offset = "0x62816B0", VA = "0x186282CB0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6284370", Offset = "0x6282D70", VA = "0x186284370")]
	public IEKFEJMKMCL(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x62837E0", Offset = "0x62821E0", VA = "0x1862837E0", Slot = "12")]
	public void MPOMBMILLLK(GameObject PACDKKMGCFJ, DFJEMOBOFAC IHAMIMJDDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6282F50", Offset = "0x6281950", VA = "0x186282F50", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6283470", Offset = "0x6281E70", VA = "0x186283470", Slot = "13")]
	public void JACDOJBEGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6283520", Offset = "0x6281F20", VA = "0x186283520", Slot = "14")]
	public void JIGIEBIDGIG(FKKKMLOMHOH PHMCJHPHMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6283280", Offset = "0x6281C80", VA = "0x186283280", Slot = "15")]
	public void ILHGCENAOJC(FKKKMLOMHOH PHMCJHPHMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x62835A0", Offset = "0x6281FA0", VA = "0x1862835A0", Slot = "22")]
	public bool JMKLOIEOBKI(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x62835B0", Offset = "0x6281FB0", VA = "0x1862835B0")]
	internal bool KBIKLCGAEAC([In] MIEGOOPOOBD ABDLEBPKDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x62842E0", Offset = "0x6282CE0", VA = "0x1862842E0")]
	internal bool OLGJNPIILPE([In] MIEGOOPOOBD ABDLEBPKDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x62834C0", Offset = "0x6281EC0", VA = "0x1862834C0")]
	internal bool JENAKMAEAHL([In] MIEGOOPOOBD ABDLEBPKDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6284190", Offset = "0x6282B90", VA = "0x186284190")]
	internal bool OHMJDJMHLOG([In] MIEGOOPOOBD ABDLEBPKDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6282D10", Offset = "0x6281710", VA = "0x186282D10")]
	internal void DJJFEALHOPD(FKKKMLOMHOH PHMCJHPHMDK, int LBKNPAGCENA, bool JMCFBEJCMPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6283280", Offset = "0x6281C80", VA = "0x186283280")]
	internal bool FPJEPBFCHEC(FKKKMLOMHOH PACIPMNIMMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6283DA0", Offset = "0x62827A0", VA = "0x186283DA0")]
	internal bool NACHKJGHLAM(FKKKMLOMHOH JANEFBOHNFL, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x62832E0", Offset = "0x6281CE0", VA = "0x1862832E0", Slot = "16")]
	public void GBEBJPAJEDF(FKKKMLOMHOH PHMCJHPHMDK, HashSet<FKKKMLOMHOH> DIBJMBKJDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6283F80", Offset = "0x6282980", VA = "0x186283F80", Slot = "17")]
	public void NNPMDGMBFEK(FKKKMLOMHOH JANEFBOHNFL, FKKKMLOMHOH FKPKOLBGEFJ, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6282B50", Offset = "0x6281550", VA = "0x186282B50", Slot = "18")]
	public void DCNIFJJCBJJ(FKKKMLOMHOH GHJPPLIEFCL, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6282FF0", Offset = "0x62819F0", VA = "0x186282FF0", Slot = "19")]
	public void ECLCOBBPOKO(FKKKMLOMHOH GHJPPLIEFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x62836D0", Offset = "0x62820D0", VA = "0x1862836D0")]
	public void MNGBHFMBAGL([Optional] HLNBBHAOHIL GFPDLJIEJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x62833E0", Offset = "0x6281DE0", VA = "0x1862833E0", Slot = "23")]
	public void IHPDCKHAPCB(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6282C90", Offset = "0x6281690", VA = "0x186282C90", Slot = "20")]
	public KPHOIPKOKCK DHGJBFGHGHC(bool EKGBFGJIEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6282B30", Offset = "0x6281530", VA = "0x186282B30", Slot = "21")]
	public KPHOIPKOKCK CGKCAJLCFFK(HashSet<Guid> CDKGEMFGCCA, bool EKGBFGJIEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6282AF0", Offset = "0x62814F0", VA = "0x186282AF0", Slot = "25")]
	public void ADHLAIEKFBJ(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6283ED0", Offset = "0x62828D0", VA = "0x186283ED0", Slot = "24")]
	public void NACOJKLBENB(KPHOIPKOKCK HFKIFEHLALP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class JNGDINGNDHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly EHCOJMJAODL<FKKKMLOMHOH, FKKKMLOMHOH> HMBJDFDELDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly EHCOJMJAODL<FKKKMLOMHOH, FKKKMLOMHOH> LGICIKKCNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly CNADDHFABOJ<FKKKMLOMHOH, FKKKMLOMHOH, FKKKMLOMHOH> DPPHJPEHCPE;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x628A170", Offset = "0x6288B70", VA = "0x18628A170")]
	public JNGDINGNDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	public void MPOMBMILLLK(IEKFEJMKMCL KEKOHNJFKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x628A0B0", Offset = "0x6288AB0", VA = "0x18628A0B0")]
	public void COGNJDGCHLC(FKKKMLOMHOH HHJLJBMAMDD, FKKKMLOMHOH APJECMEEJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x628A110", Offset = "0x6288B10", VA = "0x18628A110")]
	public void EJAEECDJKPH(FKKKMLOMHOH HHJLJBMAMDD, FKKKMLOMHOH APJECMEEJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x628A030", Offset = "0x6288A30", VA = "0x18628A030")]
	public void BDPEKECBLLO(FKKKMLOMHOH EDLGCAMJGHA, FKKKMLOMHOH GCDDFMLCKMH, FKKKMLOMHOH APJECMEEJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class MLALEDBOIAD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private IEKFEJMKMCL KEKOHNJFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private JHBCEMNALLK LKKONKMIDFE;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public MLALEDBOIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6291E80", Offset = "0x6290880", VA = "0x186291E80")]
	public void MPOMBMILLLK(IEKFEJMKMCL KEKOHNJFKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6291E50", Offset = "0x6290850", VA = "0x186291E50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6291E60", Offset = "0x6290860", VA = "0x186291E60")]
	private void EJOHKNPMEFG(HLNBBHAOHIL NHKDHOFEECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6291FB0", Offset = "0x62909B0", VA = "0x186291FB0")]
	private void NOAJOFAEIKM(HLNBBHAOHIL NAAKMJMNPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6291D50", Offset = "0x6290750", VA = "0x186291D50")]
	public void AFPPDILFKEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6292020", Offset = "0x6290A20", VA = "0x186292020")]
	public void NPFKNMGMGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class IMCFLPMJHGO
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NLOMBBGPKHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ICKBMMGCCPN container;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public NLOMBBGPKHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6292DD0", Offset = "0x62917D0", VA = "0x186292DD0")]
		internal IEKFEJMKMCL LEBEAEJEBOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6288F10", Offset = "0x6287910", VA = "0x186288F10")]
	public static void PHLODKIBLGJ(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6288E90", Offset = "0x6287890", VA = "0x186288E90")]
	public static void MLHEDAPPBDF(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[UnityEngine.Scripting.Preserve]
internal class NBJLCOMBBLF : IDisposable, BHAHECKAIGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Dictionary<int, EOHNBGKKFKO> FGIACNJNDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly NKBDNDHCPFL PADONGAKGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private JIJHLNKNFAG IAFLBHJLPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private EJKMEDAMLDL HFKIFEHLALP;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6292CF0", Offset = "0x62916F0", VA = "0x186292CF0")]
	public NBJLCOMBBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6292CB0", Offset = "0x62916B0", VA = "0x186292CB0", Slot = "7")]
	public void MPOMBMILLLK(EJKMEDAMLDL HFKIFEHLALP, JIJHLNKNFAG IAFLBHJLPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x62926E0", Offset = "0x62910E0", VA = "0x1862926E0", Slot = "5")]
	public void JBFNCDFHDOD(LJNPJDELHPK PDGBMLKPGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6292B40", Offset = "0x6291540", VA = "0x186292B40", Slot = "9")]
	public void MONMPDJMFEI(LJNPJDELHPK DNKLCLONNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6292980", Offset = "0x6291380", VA = "0x186292980", Slot = "8")]
	public void JLAJKJGBMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x62921E0", Offset = "0x6290BE0", VA = "0x1862921E0", Slot = "10")]
	public void DADHAMOAKNG(LJNPJDELHPK OFMGMLJAPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6292120", Offset = "0x6290B20", VA = "0x186292120", Slot = "11")]
	public void ANDOIMJADAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6292530", Offset = "0x6290F30", VA = "0x186292530")]
	private bool ELLHPFFAGDC(LJNPJDELHPK ANGOLELPPJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class BFKFJDKDJBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct LACCPMFCHLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly JHMPLMFOJEN OLODMILGBCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly HashSet<Guid> CDKGEMFGCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly JMLJJOAAIHO JFJKNFLEPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly JMLJJOAAIHO FLABCLFOPOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly bool EKGBFGJIEOB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool OLCALENOOOH
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x628A5C0", Offset = "0x6288FC0", VA = "0x18628A5C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x628AB00", Offset = "0x6289500", VA = "0x18628AB00")]
		public LACCPMFCHLD(JHMPLMFOJEN OLODMILGBCN, HashSet<Guid> CDKGEMFGCCA, bool EKGBFGJIEOB, [Optional] JMLJJOAAIHO JFJKNFLEPMP, [Optional] JMLJJOAAIHO FLABCLFOPOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x628A450", Offset = "0x6288E50", VA = "0x18628A450")]
		public JMLJJOAAIHO BOALAEMEPIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x628A6E0", Offset = "0x62890E0", VA = "0x18628A6E0")]
		private JMLJJOAAIHO OEINJOKCNLC([Out] JMLJJOAAIHO FGBIKNMJEHA, [Out] JMLJJOAAIHO IGBNKBGGAAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x628A910", Offset = "0x6289310", VA = "0x18628A910")]
		private JMLJJOAAIHO PFJLJOEGNMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x628A7A0", Offset = "0x62891A0", VA = "0x18628A7A0")]
		private void PCGBHOBFIOE(JMLJJOAAIHO NGNMDMLMIME, JMLJJOAAIHO IDEGAMJGGBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x628A290", Offset = "0x6288C90", VA = "0x18628A290")]
		private void BDIANKDDMOM(JMLJJOAAIHO FGBIKNMJEHA, JMLJJOAAIHO IGBNKBGGAAG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private IEKFEJMKMCL KEKOHNJFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private EJKMEDAMLDL HFKIFEHLALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private BHAHECKAIGK ENBIGLEHNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private JHBCEMNALLK LKKONKMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool AECGAEBKLEF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool NKNFMIMNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6280BC0", Offset = "0x627F5C0", VA = "0x186280BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool NCMLLOPBJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6281940", Offset = "0x6280340", VA = "0x186281940")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6280EF0", Offset = "0x627F8F0", VA = "0x186280EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6281810", Offset = "0x6280210", VA = "0x186281810")]
	public void MPOMBMILLLK(IEKFEJMKMCL KEKOHNJFKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x627FD40", Offset = "0x627E740", VA = "0x18627FD40")]
	public KPHOIPKOKCK DHGJBFGHGHC(bool EKGBFGJIEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x627F2C0", Offset = "0x627DCC0", VA = "0x18627F2C0")]
	public KPHOIPKOKCK CGKCAJLCFFK(HashSet<Guid> CDKGEMFGCCA, bool EKGBFGJIEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6280C10", Offset = "0x627F610", VA = "0x186280C10")]
	public void IHPDCKHAPCB(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6281880", Offset = "0x6280280", VA = "0x186281880")]
	public void NACOJKLBENB(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x627EFB0", Offset = "0x627D9B0", VA = "0x18627EFB0")]
	public void BGPDJAPKGED(KPHOIPKOKCK HFKIFEHLALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x627F900", Offset = "0x627E300", VA = "0x18627F900")]
	private void CLGHJDDDJOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x627EFE0", Offset = "0x627D9E0", VA = "0x18627EFE0")]
	private JMLJJOAAIHO BLHJCFMBPFO(JHMPLMFOJEN KDIAAEPKAII, bool EKGBFGJIEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x627FAF0", Offset = "0x627E4F0", VA = "0x18627FAF0")]
	private static void CNJBEMEKKKM(JHMPLMFOJEN KDIAAEPKAII, bool EKGBFGJIEOB, JMLJJOAAIHO DCIMIGOEEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6280800", Offset = "0x627F200", VA = "0x186280800")]
	private void HJDCEPCNMNG(JHMPLMFOJEN KDIAAEPKAII, bool EKGBFGJIEOB, JMLJJOAAIHO DCIMIGOEEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6280770", Offset = "0x627F170", VA = "0x186280770")]
	private JMLJJOAAIHO HFCPIJKALJM(JHMPLMFOJEN OLODMILGBCN, HashSet<Guid> CDKGEMFGCCA, bool EKGBFGJIEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6280F10", Offset = "0x627F910", VA = "0x186280F10")]
	private bool KPKHBOGAINC(KPHOIPKOKCK KINIIGNMPLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x62811A0", Offset = "0x627FBA0", VA = "0x1862811A0")]
	private bool MNFBPOMHJCE(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6281920", Offset = "0x6280320", VA = "0x186281920")]
	private bool OHMNDPKOGFH(KPHOIPKOKCK HFKIFEHLALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6280280", Offset = "0x627EC80", VA = "0x186280280")]
	private static bool GFDBDANFPMD(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6280CA0", Offset = "0x627F6A0", VA = "0x186280CA0")]
	public static bool JMKLOIEOBKI(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x627EC80", Offset = "0x627D680", VA = "0x18627EC80")]
	private FKKKMLOMHOH AHMADBLPDOL(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x627EB00", Offset = "0x627D500", VA = "0x18627EB00")]
	private FKKKMLOMHOH ADHGJKPBDIL(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6280600", Offset = "0x627F000", VA = "0x186280600")]
	private FKKKMLOMHOH HEIEIALCDFE(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6280A20", Offset = "0x627F420", VA = "0x186280A20")]
	private static Guid HMLMAGLFGLG(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x627F1D0", Offset = "0x627DBD0", VA = "0x18627F1D0")]
	private string CCFOIGOCCPI(JMLJJOAAIHO DCIMIGOEEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6280A60", Offset = "0x627F460", VA = "0x186280A60")]
	private bool HONHMBDDPLL(JHMPLMFOJEN KDIAAEPKAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x62803A0", Offset = "0x627EDA0", VA = "0x1862803A0")]
	private static void HABEKOJBFLJ(JHMPLMFOJEN OLODMILGBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public BFKFJDKDJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct MIEGOOPOOBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public FKKKMLOMHOH APJECMEEJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public FKKKMLOMHOH HHJLJBMAMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int EMEBAGPGNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int GMBELHGMABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector3 GBFCLDMNJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Quaternion MDNCGLDKIJE;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BICBPKGIEFE OBJFNEEFLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6291C40", Offset = "0x6290640", VA = "0x186291C40")]
		get
		{
			return default(BICBPKGIEFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BICBPKGIEFE FABEHEOENDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6291C10", Offset = "0x6290610", VA = "0x186291C10")]
		get
		{
			return default(BICBPKGIEFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6291CE0", Offset = "0x62906E0", VA = "0x186291CE0")]
	public MIEGOOPOOBD(FKKKMLOMHOH APJECMEEJIN, FKKKMLOMHOH HHJLJBMAMDD, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface EJKMEDAMLDL
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LJNPJDELHPK PCJLIOJLCMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPOMBMILLLK(GJKIJDDCKBL KEKOHNJFKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JGKOBAOKDPD([In] MIEGOOPOOBD ABDLEBPKDKC, bool JMCFBEJCMPM = true);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JKEOADHMKAJ(FKKKMLOMHOH JDPOBBHHNGC);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HKODNGCPJEI(FKKKMLOMHOH JANEFBOHNFL, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EHBOGECJIPM(FKKKMLOMHOH GHJPPLIEFCL, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OEHOMEFGJGH();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IDNHGLFAFGI(Func<FKKKMLOMHOH, bool> KCFJKHDAIHM);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GBEBJPAJEDF(FKKKMLOMHOH PHMCJHPHMDK, HashSet<FKKKMLOMHOH> ODEPCCMGPLI);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<FKKKMLOMHOH> CIEGNCONLBN();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FGHKMHHOMNA(FKKKMLOMHOH PHMCJHPHMDK, [Out] BICBPKGIEFE KGLINOICFBP);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ANBKPGDGFMF(NKBDNDHCPFL JNDJHGKPENH);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal delegate bool NKBDNDHCPFL(LJNPJDELHPK KDIAAEPKAII);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface LJNPJDELHPK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	FKKKMLOMHOH EOGHPJFCNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LJNPJDELHPK OCIMJODBDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BICBPKGIEFE DFKLOMGBLNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool KIKOPPFMODG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface EOHNBGKKFKO
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMGPKAMLICG(FKKKMLOMHOH PGAJJPKGJAA, BICBPKGIEFE APJECMEEJIN);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMJOAAJDGMA(FKKKMLOMHOH PGAJJPKGJAA, BICBPKGIEFE APJECMEEJIN);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOFBMGLCFBK(FKKKMLOMHOH PGAJJPKGJAA, BICBPKGIEFE APJECMEEJIN);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLKDNBADJBD(FKKKMLOMHOH PGAJJPKGJAA, BICBPKGIEFE APJECMEEJIN);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EOHNBGKKFKO Instantiate(Transform OEIDOHJNAOK);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KDNFCEDEOOI();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JIJHLNKNFAG
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPOMBMILLLK(Transform OEIDOHJNAOK, EOHNBGKKFKO CFDKKPPANII);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EOHNBGKKFKO AFFMPPJHIKI();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLMJGNLNJMC(EOHNBGKKFKO HFDCPOEIJOO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KANOLLOOODF : ILMDJOJAMBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLCFGLBPLDG(Guid FBMGKPMGCBD);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface BHAHECKAIGK
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBFNCDFHDOD(LJNPJDELHPK PDGBMLKPGFI);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPOMBMILLLK(EJKMEDAMLDL HFKIFEHLALP, JIJHLNKNFAG IPLMIIHDMOC);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLAJKJGBMAL();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MONMPDJMFEI(LJNPJDELHPK DNKLCLONNIE);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DADHAMOAKNG(LJNPJDELHPK OFMGMLJAPPF);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ANDOIMJADAB();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class JHMPLMFOJEN : LJNPJDELHPK
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DHEBKCIGGKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public BICBPKGIEFE nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public JHMPLMFOJEN foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public DHEBKCIGGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6282690", Offset = "0x6281090", VA = "0x186282690")]
		internal bool DBMOANIJJCK(LJNPJDELHPK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private BICBPKGIEFE KGLINOICFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LinkedList<JHMPLMFOJEN> PFDJACJHAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private JHMPLMFOJEN FBBJNLNLGJJ;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BICBPKGIEFE DFKLOMGBLNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3578520", Offset = "0x3576F20", VA = "0x183578520", Slot = "6")]
		get
		{
			return default(BICBPKGIEFE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6289F50", Offset = "0x6288950", VA = "0x186289F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private JHMPLMFOJEN HHJLJBMAMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6289DC0", Offset = "0x62887C0", VA = "0x186289DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public LJNPJDELHPK OCIMJODBDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FKKKMLOMHOH EOGHPJFCNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KIKOPPFMODG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6289660", Offset = "0x6288060", VA = "0x186289660", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NCINOLDLOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6289D70", Offset = "0x6288770", VA = "0x186289D70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected JHMPLMFOJEN AKBOHBAKCNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6289640", Offset = "0x6288040", VA = "0x186289640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6289F80", Offset = "0x6288980", VA = "0x186289F80")]
	public JHMPLMFOJEN(BICBPKGIEFE FLJBHFKPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6289670", Offset = "0x6288070", VA = "0x186289670")]
	public JHMPLMFOJEN HMKOOHPFFKM(BICBPKGIEFE MGNMDABJAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x62897C0", Offset = "0x62881C0", VA = "0x1862897C0")]
	public JHMPLMFOJEN KOFHNLLLAJK(BICBPKGIEFE JKCBJEDEKGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6289B90", Offset = "0x6288590", VA = "0x186289B90")]
	public JHMPLMFOJEN MDELFCPLFEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6289940", Offset = "0x6288340", VA = "0x186289940")]
	public void LDCFGOINEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6289EA0", Offset = "0x62888A0", VA = "0x186289EA0")]
	public JHMPLMFOJEN NFDAKFIKPNC(BICBPKGIEFE GCDDFMLCKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6289120", Offset = "0x6287B20", VA = "0x186289120")]
	private static void ANBKPGDGFMF(JHMPLMFOJEN PGPCEMHEONA, NKBDNDHCPFL EHNGFDOGIGP, bool DNNAMNGAOBN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6289110", Offset = "0x6287B10", VA = "0x186289110", Slot = "9")]
	public void ANBKPGDGFMF(NKBDNDHCPFL JNDJHGKPENH, bool GEEEGCNOAMP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6289280", Offset = "0x6287C80", VA = "0x186289280")]
	public static string ANHGGIFLDOJ(JHMPLMFOJEN PGPCEMHEONA, int LFMFICHNHDC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6289A90", Offset = "0x6288490", VA = "0x186289A90")]
	public static JHMPLMFOJEN LGCIGMIONAK(JHMPLMFOJEN PGPCEMHEONA, BICBPKGIEFE ADKPOOJEPIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface JHBCEMNALLK
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool NKNFMIMNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DMPMMNCDIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<HLNBBHAOHIL> EJOHKNPMEFG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<HLNBBHAOHIL> NOAJOFAEIKM;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(IEKFEJMKMCL KEKOHNJFKFJ);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(FKKKMLOMHOH JANEFBOHNFL, FKKKMLOMHOH FKPKOLBGEFJ, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(FKKKMLOMHOH GHJPPLIEFCL, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(KPHOIPKOKCK BDCCJAOPCDF, [Optional] HLNBBHAOHIL GFPDLJIEJGH);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, JHBCEMNALLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private IEKFEJMKMCL KEKOHNJFKFJ;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool NKNFMIMNKEG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x6291940", Offset = "0x6290340", VA = "0x186291940", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool DMPMMNCDIMA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x62919A0", Offset = "0x62903A0", VA = "0x1862919A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<HLNBBHAOHIL> EJOHKNPMEFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x6291890", Offset = "0x6290290", VA = "0x186291890", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6291A90", Offset = "0x6290490", VA = "0x186291A90", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<HLNBBHAOHIL> NOAJOFAEIKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x62917E0", Offset = "0x62901E0", VA = "0x1862917E0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x62919E0", Offset = "0x62903E0", VA = "0x1862919E0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C00", Offset = "0x7C8600", VA = "0x1807C9C00", Slot = "19")]
		public void SetManager(IEKFEJMKMCL KEKOHNJFKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x62917B0", Offset = "0x62901B0", VA = "0x1862917B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6290530", Offset = "0x628EF30", VA = "0x186290530", Slot = "23")]
		public void RequestMasterConnectNodes(FKKKMLOMHOH LIPHKABODCG, int EMEBAGPGNAE, FKKKMLOMHOH PGAJJPKGJAA, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6290660", Offset = "0x628F060", VA = "0x186290660", Slot = "24")]
		public void RequestMasterDisconnectNode(FKKKMLOMHOH JDPOBBHHNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6290720", Offset = "0x628F120", VA = "0x186290720", Slot = "20")]
		public void RequestMasterModifyNode(FKKKMLOMHOH JANEFBOHNFL, FKKKMLOMHOH FKPKOLBGEFJ, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6290850", Offset = "0x628F250", VA = "0x186290850", Slot = "21")]
		public void RequestMasterReparentNodes(FKKKMLOMHOH GHJPPLIEFCL, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6290980", Offset = "0x628F380", VA = "0x186290980", Slot = "25")]
		public void RequestMasterReparentToRoot(FKKKMLOMHOH GHJPPLIEFCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6290400", Offset = "0x628EE00", VA = "0x186290400", Slot = "22")]
		public void RequestDeserializeConnectableGraph(KPHOIPKOKCK BDCCJAOPCDF, [Optional] HLNBBHAOHIL GFPDLJIEJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6290D60", Offset = "0x628F760", VA = "0x186290D60")]
		[NFKHBBEIBMC]
		private void RpcMasterConnectNodes(FKKKMLOMHOH LIPHKABODCG, int EMEBAGPGNAE, FKKKMLOMHOH PGAJJPKGJAA, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6291020", Offset = "0x628FA20", VA = "0x186291020")]
		[NFKHBBEIBMC]
		private void RpcMasterDisconnectNode(FKKKMLOMHOH JDPOBBHHNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6291360", Offset = "0x628FD60", VA = "0x186291360")]
		[NFKHBBEIBMC]
		private void RpcMasterReparentNodes(FKKKMLOMHOH GHJPPLIEFCL, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6291160", Offset = "0x628FB60", VA = "0x186291160")]
		[NFKHBBEIBMC]
		private void RpcMasterModifyNode(FKKKMLOMHOH JANEFBOHNFL, FKKKMLOMHOH FKPKOLBGEFJ, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6290B50", Offset = "0x628F550", VA = "0x186290B50")]
		[NFKHBBEIBMC]
		private void RpcConnectNodes(FKKKMLOMHOH LIPHKABODCG, int EMEBAGPGNAE, FKKKMLOMHOH PGAJJPKGJAA, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE, CNOPJKHJHBO GJNDFNILACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6290CD0", Offset = "0x628F6D0", VA = "0x186290CD0")]
		[NFKHBBEIBMC]
		private void RpcDisconnectNode(FKKKMLOMHOH JDPOBBHHNGC, CNOPJKHJHBO GJNDFNILACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x62916B0", Offset = "0x62900B0", VA = "0x1862916B0")]
		[NFKHBBEIBMC]
		private void RpcReparentNodes(FKKKMLOMHOH GHJPPLIEFCL, int KNBPKMFFOHP, FKKKMLOMHOH GCDDFMLCKMH, int LICBJDFOCNP, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE, CNOPJKHJHBO GJNDFNILACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x62915F0", Offset = "0x628FFF0", VA = "0x1862915F0")]
		[NFKHBBEIBMC]
		private void RpcModifyNode(FKKKMLOMHOH JANEFBOHNFL, int EMEBAGPGNAE, int GMBELHGMABN, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE, CNOPJKHJHBO GJNDFNILACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6290C90", Offset = "0x628F690", VA = "0x186290C90")]
		[NFKHBBEIBMC]
		private void RpcDeserializeConnectableGraph(KPHOIPKOKCK HFKIFEHLALP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DF180", Offset = "0x7DDB80", VA = "0x1807DF180")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, EOHNBGKKFKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6290280", Offset = "0x628EC80", VA = "0x186290280", Slot = "4")]
		private void PAACPELEEFA(FKKKMLOMHOH PGAJJPKGJAA, BICBPKGIEFE APJECMEEJIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x628FC40", Offset = "0x628E640", VA = "0x18628FC40", Slot = "5")]
		private void DBNIHJJPKEH(FKKKMLOMHOH PGAJJPKGJAA, BICBPKGIEFE APJECMEEJIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x628FF80", Offset = "0x628E980", VA = "0x18628FF80", Slot = "6")]
		private void HHKENFNDEJB(FKKKMLOMHOH PGAJJPKGJAA, BICBPKGIEFE APJECMEEJIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6290090", Offset = "0x628EA90", VA = "0x186290090", Slot = "7")]
		private void MEFBJEEHAHC(FKKKMLOMHOH PGAJJPKGJAA, BICBPKGIEFE APJECMEEJIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x628FEB0", Offset = "0x628E8B0", VA = "0x18628FEB0", Slot = "8")]
		private EOHNBGKKFKO FKHNBHBMIOL(Transform OEIDOHJNAOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x628FF20", Offset = "0x628E920", VA = "0x18628FF20", Slot = "9")]
		private void GAGNFNNAGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OJMPPKOICEE
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6670", Offset = "0x2AB5070", VA = "0x182AB6670")]
	public static CHNEJBOPDIO<T> FPNJFEOPAAO<T>(this ICKBMMGCCPN NFHEIBLLDGM)
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
