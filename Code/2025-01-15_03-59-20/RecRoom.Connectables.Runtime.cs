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
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F35B10", Offset = "0x6F34F10", VA = "0x186F35B10", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C860", Offset = "0x6F3BC60", VA = "0x186F3C860", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C3C0", Offset = "0x6F3B7C0", VA = "0x186F3C3C0")]
		private void PKLDHDIFILK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C250", Offset = "0x6F3B650", VA = "0x186F3C250")]
		private void KNPLIPKNCKI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C530", Offset = "0x6F3B930", VA = "0x186F3C530", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C8A0", Offset = "0x6F3BCA0", VA = "0x186F3C8A0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class BKANEHMCGBC : MACBICNHBEL, FCDDCBJENJH
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class AJBEGFCMOIA : IEnumerable<PDNDLAIMNIC>, IEnumerable, IEnumerator<PDNDLAIMNIC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private PDNDLAIMNIC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private AOMADBOBEAJ localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AOMADBOBEAJ <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BKANEHMCGBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private ENHHHCAGNII <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DFMAFHIFHME.EBEAIBHPIMN <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private PDNDLAIMNIC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xADC3A0", Offset = "0xADB7A0", VA = "0x180ADC3A0")]
		[DebuggerHidden]
		public AJBEGFCMOIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F271B0", Offset = "0x6F265B0", VA = "0x186F271B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F26CD0", Offset = "0x6F260D0", VA = "0x186F26CD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F27090", Offset = "0x6F26490", VA = "0x186F27090")]
		private void NOLPLDAPGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F27160", Offset = "0x6F26560", VA = "0x186F27160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F270B0", Offset = "0x6F264B0", VA = "0x186F270B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PDNDLAIMNIC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F270B0", Offset = "0x6F264B0", VA = "0x186F270B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class DHNLNJILAII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BKANEHMCGBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GDCNFDIBHNF nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DHNLNJILAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E3A0", Offset = "0x6F2D7A0", VA = "0x186F2E3A0")]
		internal object AAAFLKGJBKO(GDCNFDIBHNF x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DPJJINHOMJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public GDCNFDIBHNF child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DHNLNJILAII CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DPJJINHOMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E410", Offset = "0x6F2D810", VA = "0x186F2E410")]
		internal object GHCGMGACKIP((GDCNFDIBHNF child, GDCNFDIBHNF nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly GKOKEEMOOFG GHGFCEEOLGC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly GKOKEEMOOFG EHGIGGEIEGB;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly GKOKEEMOOFG FBJMMLLELHN;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly GKOKEEMOOFG PAGABJOPFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OEHGMMFAPNP BEHBJOHLAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LBKPIKLOHEL BDGKALLONKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LHAACOMCFDP LEFCIGEDKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private APOLJOLGJOE IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CMJCBAIFNMJ EBPOLOFFMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CLFDOLBIAIC LAACHEAGFPC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BEICAADJBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCF7040", Offset = "0xCF6440", VA = "0x180CF7040", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE27B70", Offset = "0xE26F70", VA = "0x180E27B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GNNGFFLACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<PDNDLAIMNIC, PDNDLAIMNIC> HAOFIBFJCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A1E0", Offset = "0x6F295E0", VA = "0x186F2A1E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F28670", Offset = "0x6F27A70", VA = "0x186F28670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<PDNDLAIMNIC, PDNDLAIMNIC> IEHILDJFPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F28F20", Offset = "0x6F28320", VA = "0x186F28F20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F27D80", Offset = "0x6F27180", VA = "0x186F27D80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<PDNDLAIMNIC, PDNDLAIMNIC, PDNDLAIMNIC> BGHBCDIDIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F27CD0", Offset = "0x6F270D0", VA = "0x186F27CD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F27E30", Offset = "0x6F27230", VA = "0x186F27E30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C080", Offset = "0x6F2B480", VA = "0x186F2C080")]
	public BKANEHMCGBC(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BAC0", Offset = "0x6F2AEC0", VA = "0x186F2BAC0", Slot = "12")]
	public void OOJJEJPOBFE(GameObject MCCIFMIMANN, GGINMMJCPIB MFHLPNFABOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B640", Offset = "0x6F2AA40", VA = "0x186F2B640", Slot = "26")]
	public void OBDLHHEKPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AF00", Offset = "0x6F2A300", VA = "0x186F2AF00", Slot = "22")]
	public bool KMBFGGJFHHD(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F29110", Offset = "0x6F28510", VA = "0x186F29110")]
	private void HBJLDIKBCLM(AOMADBOBEAJ FOIIEDCGGGN, AOMADBOBEAJ HIELJOHDBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F28D00", Offset = "0x6F28100", VA = "0x186F28D00")]
	private void FDBGCOPLEBL(AOMADBOBEAJ FOIIEDCGGGN, AOMADBOBEAJ BNBOAIJBMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F294A0", Offset = "0x6F288A0", VA = "0x186F294A0")]
	private void HPDFIMJFCBI(AOMADBOBEAJ FOIIEDCGGGN, AOMADBOBEAJ BNBOAIJBMHM, AOMADBOBEAJ HIELJOHDBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A290", Offset = "0x6F29690", VA = "0x186F2A290")]
	private void KBLDJLKLFAL(AOMADBOBEAJ FOIIEDCGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "13")]
	public void BFLBMILJDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F28720", Offset = "0x6F27B20", VA = "0x186F28720", Slot = "14")]
	public void EMOBGIHOLPD(PDNDLAIMNIC ECHMDKMCJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "15")]
	public void AFELCEKEOAN(PDNDLAIMNIC ECHMDKMCJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F278F0", Offset = "0x6F26CF0", VA = "0x186F278F0", Slot = "17")]
	public void AGJGNACKCPD(PDNDLAIMNIC ECHMDKMCJFA, PDNDLAIMNIC EFGHGKGDOLP, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F277B0", Offset = "0x6F26BB0", VA = "0x186F277B0")]
	public void AGJGNACKCPD(AOMADBOBEAJ FKLPGABAEFE, AOMADBOBEAJ EFGHGKGDOLP, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F27F50", Offset = "0x6F27350", VA = "0x186F27F50")]
	public void DLKLHHNNIPH(PDNDLAIMNIC ECHMDKMCJFA, float KFDBLNFGAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F28B50", Offset = "0x6F27F50", VA = "0x186F28B50", Slot = "18")]
	public void FBILJMEBBAD(PDNDLAIMNIC MKEIIEIKLOF, int NJGKGLKDLJC, PDNDLAIMNIC MIHNPBFLFJI, int BDKIJGDNFAD, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F29060", Offset = "0x6F28460", VA = "0x186F29060")]
	private float GMFOJNJCIGE(AOMADBOBEAJ FKLPGABAEFE, AOMADBOBEAJ AMMKPAGCALK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F28A20", Offset = "0x6F27E20", VA = "0x186F28A20")]
	public void FBILJMEBBAD(AOMADBOBEAJ FKLPGABAEFE, AOMADBOBEAJ AMMKPAGCALK, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F28CA0", Offset = "0x6F280A0", VA = "0x186F28CA0")]
	public void FBILJMEBBAD(AOMADBOBEAJ FKLPGABAEFE, AOMADBOBEAJ AMMKPAGCALK, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK, float KFDBLNFGAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F299D0", Offset = "0x6F28DD0", VA = "0x186F299D0", Slot = "19")]
	public void IGMDAKNGEEC(PDNDLAIMNIC ECHMDKMCJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B830", Offset = "0x6F2AC30", VA = "0x186F2B830")]
	public bool OHCFGHKOLDL(AOMADBOBEAJ FCHDAFNGEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BD30", Offset = "0x6F2B130", VA = "0x186F2BD30", Slot = "16")]
	public void OPIJPOEONGG(PDNDLAIMNIC ECHMDKMCJFA, HashSet<PDNDLAIMNIC> FCMPKKOFJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "20")]
	public CIIDELJIHKK JKAFJBDBEAI(bool GMHKPKFOPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "21")]
	public CIIDELJIHKK DJCDIIKPALF(HashSet<Guid> OCLAIIHIPMM, bool GMHKPKFOPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AE90", Offset = "0x6F2A290", VA = "0x186F2AE90", Slot = "23")]
	public void KKPHIBCGDBP(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AE20", Offset = "0x6F2A220", VA = "0x186F2AE20", Slot = "24")]
	public void KFMGMAIABDO(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B2D0", Offset = "0x6F2A6D0", VA = "0x186F2B2D0", Slot = "25")]
	public void MDBJCKBADOF(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B2F0", Offset = "0x6F2A6F0", VA = "0x186F2B2F0")]
	private void NDJGCCGMMOI(AOMADBOBEAJ FKLPGABAEFE, AOMADBOBEAJ AMMKPAGCALK, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK, float KFDBLNFGAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A6A0", Offset = "0x6F29AA0", VA = "0x186F2A6A0")]
	private void KCDKEMEHPLK(AOMADBOBEAJ FKLPGABAEFE, AOMADBOBEAJ NBJNONHAKJK, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F27EE0", Offset = "0x6F272E0", VA = "0x186F27EE0")]
	private void DIHNIOGCBHI(AOMADBOBEAJ FKLPGABAEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F28FD0", Offset = "0x6F283D0", VA = "0x186F28FD0")]
	[IteratorStateMachine(typeof(AJBEGFCMOIA))]
	public IEnumerable<PDNDLAIMNIC> GFCJCNIEIJB(AOMADBOBEAJ FCHDAFNGEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F281B0", Offset = "0x6F275B0", VA = "0x186F281B0")]
	internal PDNDLAIMNIC EBMDKDLAKBA(AOMADBOBEAJ FCHDAFNGEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F29700", Offset = "0x6F28B00", VA = "0x186F29700")]
	internal AOMADBOBEAJ HPFIBDBFOPH(PDNDLAIMNIC ECHMDKMCJFA)
	{
		return default(AOMADBOBEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F29C50", Offset = "0x6F29050", VA = "0x186F29C50")]
	private bool JOFOJHOLGIK(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B120", Offset = "0x6F2A520", VA = "0x186F2B120")]
	private bool LDODGLJONOD(GDCNFDIBHNF AIGKLGGBPNP, [Out] PDNDLAIMNIC AMMKPAGCALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F282E0", Offset = "0x6F276E0", VA = "0x186F282E0")]
	private PDNDLAIMNIC EBMDKDLAKBA(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F27630", Offset = "0x6F26A30", VA = "0x186F27630")]
	private PDNDLAIMNIC AEMOKIJGOEA(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F27FE0", Offset = "0x6F273E0", VA = "0x186F27FE0")]
	private PDNDLAIMNIC EAFPBBFIOLF(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AF50", Offset = "0x6F2A350", VA = "0x186F2AF50")]
	private static Guid KMHEEDMMCFJ(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B1E0", Offset = "0x6F2A5E0", VA = "0x186F2B1E0")]
	private string LKFIAKOKLGP(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F29840", Offset = "0x6F28C40", VA = "0x186F29840")]
	private void IBMJJOPBPAA(PDNDLAIMNIC FKLPGABAEFE, PDNDLAIMNIC NBJNONHAKJK, RigidTransform CFHDOPANNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AF90", Offset = "0x6F2A390", VA = "0x186F2AF90")]
	private void LAAJDCNMANB(PDNDLAIMNIC NBJNONHAKJK, PDNDLAIMNIC FKLPGABAEFE, RigidTransform CFHDOPANNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B180", Offset = "0x6F2A580", VA = "0x186F2B180")]
	private void LKCDGHNNMEA(PDNDLAIMNIC DKEOBCPHOMK, PDNDLAIMNIC FKLPGABAEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F29310", Offset = "0x6F28710", VA = "0x186F29310")]
	private void HJEAHMINGAB(PDNDLAIMNIC FKLPGABAEFE, PDNDLAIMNIC AMMKPAGCALK, RigidTransform CFHDOPANNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F29B40", Offset = "0x6F28F40", VA = "0x186F29B40")]
	private void IJPJJOKMNJL(AOMADBOBEAJ FCHDAFNGEPF, PDNDLAIMNIC ECHMDKMCJFA, AOMADBOBEAJ BNBOAIJBMHM, AOMADBOBEAJ HIELJOHDBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F27A50", Offset = "0x6F26E50", VA = "0x186F27A50")]
	private void BFFEIIPFALM(AOMADBOBEAJ FCHDAFNGEPF, PDNDLAIMNIC ECHMDKMCJFA, PDNDLAIMNIC EIDBPOEJPOG, PDNDLAIMNIC NFMMNJIBIAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JGJNNADCNCD
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LLOAEHGOKHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CGJHFFGEHKC container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public LLOAEHGOKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F33A80", Offset = "0x6F32E80", VA = "0x186F33A80")]
		internal BKANEHMCGBC GPGNHGJJBOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F335C0", Offset = "0x6F329C0", VA = "0x186F335C0")]
	public static void CIPNFKJEAPC(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6F33740", Offset = "0x6F32B40", VA = "0x186F33740")]
	public static void NGEFHPNJKDI(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class BNJICDIFIIA : MPPEGFMKGLP, MDNDPFBGIDI
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly BKANEHMCGBC LEPGPIPMLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly OJFOHCCPPLI GHKMJNONPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EAONBBNEGDN IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly GACMHDNJIJP[] MMNCHPGNGBH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PDNDLAIMNIC PIEFHBNPMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DCA0", Offset = "0x6F2D0A0", VA = "0x186F2DCA0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PDNDLAIMNIC INNGLAAMGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CDB0", Offset = "0x6F2C1B0", VA = "0x186F2CDB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 ACDOIAIGJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D190", Offset = "0x6F2C590", VA = "0x186F2D190", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion GAMLJENJPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D430", Offset = "0x6F2C830", VA = "0x186F2D430", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IEJAEAPDLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D0C0", Offset = "0x6F2C4C0", VA = "0x186F2D0C0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<PDNDLAIMNIC> PHPLAIHHMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D600", Offset = "0x6F2CA00", VA = "0x186F2D600", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool GHDECCPPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9A2F80", Offset = "0x9A2380", VA = "0x1809A2F80", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9A3BD0", Offset = "0x9A2FD0", VA = "0x1809A3BD0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DEA0", Offset = "0x6F2D2A0", VA = "0x186F2DEA0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject ILKBGMGJJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2933750", Offset = "0x2932B50", VA = "0x182933750", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DBE0", Offset = "0x6F2CFE0", VA = "0x186F2DBE0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid MCLEDEAGAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DD00", Offset = "0x6F2D100", VA = "0x186F2DD00", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HHFIFFBDDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DDE0", Offset = "0x6F2D1E0", VA = "0x186F2DDE0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool CCONEJJOPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JACPDHJGPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D3E0", Offset = "0x6F2C7E0", VA = "0x186F2D3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event NEGMIJALCKA IKIOHHEHCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D490", Offset = "0x6F2C890", VA = "0x186F2D490", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D5A0", Offset = "0x6F2C9A0", VA = "0x186F2D5A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NEGMIJALCKA AOBPPHJJKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CBE0", Offset = "0x6F2BFE0", VA = "0x186F2CBE0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D130", Offset = "0x6F2C530", VA = "0x186F2D130", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NEGMIJALCKA JFGEOCCCIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CA40", Offset = "0x6F2BE40", VA = "0x186F2CA40", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C9E0", Offset = "0x6F2BDE0", VA = "0x186F2C9E0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event FLNIHBKKLMP IKGFAPPNMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C3D0", Offset = "0x6F2B7D0", VA = "0x186F2C3D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CB40", Offset = "0x6F2BF40", VA = "0x186F2CB40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DAE0", Offset = "0x6F2CEE0", VA = "0x186F2DAE0")]
	public BNJICDIFIIA(AOMADBOBEAJ NKCFJFCLAAC, RigidbodyEx EBMLJFOEMMC, OJFOHCCPPLI GHKMJNONPHP, GACMHDNJIJP[] MMNCHPGNGBH, EAONBBNEGDN IHMGMGMEKPB, MACBICNHBEL LEPGPIPMLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D4F0", Offset = "0x6F2C8F0", VA = "0x186F2D4F0", Slot = "19")]
	public void OCFCMPGINLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "21")]
	public void BBFCIGOENPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D3EDB0", Offset = "0x6D3E1B0", VA = "0x186D3EDB0", Slot = "22")]
	public void PDNHLCKEJHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D070", Offset = "0x6F2C470", VA = "0x186F2D070", Slot = "20")]
	public void INEAJMHODFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C470", Offset = "0x6F2B870", VA = "0x186F2C470", Slot = "25")]
	public void BFNIPBIMPON(int HMHBLOONOPO, PDNDLAIMNIC MIHNPBFLFJI, int NABPNEAIIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2CCE0", Offset = "0x6F2C0E0", VA = "0x186F2CCE0", Slot = "26")]
	public void GGDPEEMKNIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C0F0", Offset = "0x6F2B4F0", VA = "0x186F2C0F0", Slot = "27")]
	public void AGDJJCGLGLI(int HMHBLOONOPO, PDNDLAIMNIC MKEIIEIKLOF, int IGEFDBBFNHK, [Optional] Vector3? GENECOFMCJE, [Optional] Quaternion? MADPMBLAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D520", Offset = "0x6F2C920", VA = "0x186F2D520", Slot = "28")]
	public void PDKMBHJAFGG(PDNDLAIMNIC MKEIIEIKLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D630", Offset = "0x6F2CA30", VA = "0x186F2D630", Slot = "31")]
	public void PPAELNGDAGD(Vector3 LEAHAOMEKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C6D0", Offset = "0x6F2BAD0", VA = "0x186F2C6D0", Slot = "29")]
	public void BMFOKPFLEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D1F0", Offset = "0x6F2C5F0", VA = "0x186F2D1F0", Slot = "30")]
	public void LBLFDFGADIM(int IIACLAMOIEE, Vector3 MIIBBEPBJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F2CFA0", Offset = "0x6F2C3A0", VA = "0x186F2CFA0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int HMHBLOONOPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F2CE70", Offset = "0x6F2C270", VA = "0x186F2CE70", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int HMHBLOONOPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA4A4B0", Offset = "0xA498B0", VA = "0x180A4A4B0", Slot = "42")]
	public Color GetConnectionSlotColor(int HMHBLOONOPO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2CAA0", Offset = "0x6F2BEA0", VA = "0x186F2CAA0", Slot = "43")]
	public bool CanConnectTo(int HMHBLOONOPO, PDNDLAIMNIC HFPDIEDEOPE, int DDMHJEJLCLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "44")]
	public void ParentChanged(int HMHBLOONOPO, PDNDLAIMNIC ONAHEAEEJME, int FEMDOGJLFHJ, Vector3 FAOKPAANHEC, Quaternion BEIKNNBDJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "45")]
	public void ChildAdded(int HMHBLOONOPO, PDNDLAIMNIC LAPLPDGBPEM, int NMOJHPHDECF, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "46")]
	public void ChildRemoved(int HMHBLOONOPO, PDNDLAIMNIC PCGKKIMENKI, int EDBLPEAJKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "47")]
	public void ConnectionModified(int HMHBLOONOPO, PDNDLAIMNIC MIHNPBFLFJI, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DA40", Offset = "0x6F2CE40", VA = "0x186F2DA40", Slot = "48")]
	public void RootChanged(PDNDLAIMNIC EPGKKDLMDNC, PDNDLAIMNIC LPKLKFODEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F2CC40", Offset = "0x6F2C040", VA = "0x186F2CC40", Slot = "23")]
	public void FNAABBEHDHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F2CC90", Offset = "0x6F2C090", VA = "0x186F2CC90", Slot = "24")]
	public void GAAFGMDHOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C680", Offset = "0x6F2BA80", VA = "0x186F2C680")]
	private void BGOFBKKKGJD(bool PEHFAFJHLIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(FMCBKOLALGM), new string[] { })]
public class HGJOJMOAGCJ : FMCBKOLALGM, IBKPHGCGFKM, PMFJAPPJIBL
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NNEBBMHLNDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public HGJOJMOAGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public DFMAFHIFHME localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NNEBBMHLNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F39530", Offset = "0x6F38930", VA = "0x186F39530")]
		internal void CGDNJJFCLMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[DependsOn]
	private FCELLDBBGCG OGOGOLFFADO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object JEBOAFAOOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F30B70", Offset = "0x6F2FF70", VA = "0x186F30B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F30C00", Offset = "0x6F30000", VA = "0x186F30C00", Slot = "5")]
	public void OKNAOEPPDCB(DFMAFHIFHME LGIFMBNGOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6F30B20", Offset = "0x6F2FF20", VA = "0x186F30B20", Slot = "6")]
	private void CNKJMHHGNCN(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xD13730", Offset = "0xD12B30", VA = "0x180D13730", Slot = "7")]
	private void GHHONKMBLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public HGJOJMOAGCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(MACBICNHBEL), new string[] { "Ignore", "Mock" })]
public class AJEJCIGGLCC : MACBICNHBEL, FCDDCBJENJH
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool BEICAADJBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GNNGFFLACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<PDNDLAIMNIC, PDNDLAIMNIC> HAOFIBFJCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F27580", Offset = "0x6F26980", VA = "0x186F27580", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F27420", Offset = "0x6F26820", VA = "0x186F27420", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<PDNDLAIMNIC, PDNDLAIMNIC> IEHILDJFPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F274D0", Offset = "0x6F268D0", VA = "0x186F274D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F272C0", Offset = "0x6F266C0", VA = "0x186F272C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<PDNDLAIMNIC, PDNDLAIMNIC, PDNDLAIMNIC> BGHBCDIDIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F27210", Offset = "0x6F26610", VA = "0x186F27210", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F27370", Offset = "0x6F26770", VA = "0x186F27370", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "26")]
	public void OBDLHHEKPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "12")]
	public void OOJJEJPOBFE(GameObject MCCIFMIMANN, GGINMMJCPIB MFHLPNFABOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "13")]
	public void BFLBMILJDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "14")]
	public void EMOBGIHOLPD(PDNDLAIMNIC ECHMDKMCJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "15")]
	public void AFELCEKEOAN(PDNDLAIMNIC ECHMDKMCJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "16")]
	public void OPIJPOEONGG(PDNDLAIMNIC ECHMDKMCJFA, HashSet<PDNDLAIMNIC> FCMPKKOFJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "17")]
	public void AGJGNACKCPD(PDNDLAIMNIC ECHMDKMCJFA, PDNDLAIMNIC EFGHGKGDOLP, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "18")]
	public void FBILJMEBBAD(PDNDLAIMNIC ECHMDKMCJFA, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "19")]
	public void IGMDAKNGEEC(PDNDLAIMNIC ECHMDKMCJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "20")]
	public CIIDELJIHKK JKAFJBDBEAI(bool GMHKPKFOPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "21")]
	public CIIDELJIHKK DJCDIIKPALF(HashSet<Guid> OCLAIIHIPMM, bool GMHKPKFOPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "22")]
	public bool KMBFGGJFHHD(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "23")]
	public void KKPHIBCGDBP(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "24")]
	public void KFMGMAIABDO(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "25")]
	public void MDBJCKBADOF(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public AJEJCIGGLCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PDNDLAIMNIC : MDNDPFBGIDI, IEquatable<PDNDLAIMNIC>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MDNDPFBGIDI
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	PDNDLAIMNIC PIEFHBNPMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject ILKBGMGJJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid MCLEDEAGAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int HHFIFFBDDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CCONEJJOPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int HMHBLOONOPO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int HMHBLOONOPO);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int HMHBLOONOPO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int HMHBLOONOPO, PDNDLAIMNIC HFPDIEDEOPE, int LDIBPHEIFPO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int HMHBLOONOPO, PDNDLAIMNIC ONAHEAEEJME, int FEMDOGJLFHJ, Vector3 FAOKPAANHEC, Quaternion BEIKNNBDJGE);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int HMHBLOONOPO, PDNDLAIMNIC LAPLPDGBPEM, int NMOJHPHDECF, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int HMHBLOONOPO, PDNDLAIMNIC PCGKKIMENKI, int EDBLPEAJKJH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int HMHBLOONOPO, PDNDLAIMNIC MIHNPBFLFJI, int AIGPIKKOCHA, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(PDNDLAIMNIC EPGKKDLMDNC, PDNDLAIMNIC LPKLKFODEKH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MACBICNHBEL : FCDDCBJENJH
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BEICAADJBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GNNGFFLACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<PDNDLAIMNIC, PDNDLAIMNIC> HAOFIBFJCEP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<PDNDLAIMNIC, PDNDLAIMNIC> IEHILDJFPDL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<PDNDLAIMNIC, PDNDLAIMNIC, PDNDLAIMNIC> BGHBCDIDIKO;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OOJJEJPOBFE(GameObject MCCIFMIMANN, GGINMMJCPIB MFHLPNFABOE);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BFLBMILJDBK();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EMOBGIHOLPD(PDNDLAIMNIC ECHMDKMCJFA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AFELCEKEOAN(PDNDLAIMNIC ECHMDKMCJFA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OPIJPOEONGG(PDNDLAIMNIC ECHMDKMCJFA, HashSet<PDNDLAIMNIC> FCMPKKOFJCJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AGJGNACKCPD(PDNDLAIMNIC ECHMDKMCJFA, PDNDLAIMNIC EFGHGKGDOLP, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FBILJMEBBAD(PDNDLAIMNIC ECHMDKMCJFA, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IGMDAKNGEEC(PDNDLAIMNIC ECHMDKMCJFA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CIIDELJIHKK JKAFJBDBEAI(bool GMHKPKFOPCE);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CIIDELJIHKK DJCDIIKPALF(HashSet<Guid> OCLAIIHIPMM, bool GMHKPKFOPCE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KMBFGGJFHHD(GDCNFDIBHNF AIGKLGGBPNP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KKPHIBCGDBP(CIIDELJIHKK CIBJIJAGOGC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KFMGMAIABDO(CIIDELJIHKK CIBJIJAGOGC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MDBJCKBADOF(CIIDELJIHKK CIBJIJAGOGC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface APOLJOLGJOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FIJHLCJHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PDNDLAIMNIC EAFPBBFIOLF(int EFKHHDMAOBK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PDNDLAIMNIC AEMOKIJGOEA(Guid BDFJGJGIHBK);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ELEEBNHKDDN(PDNDLAIMNIC ECHMDKMCJFA);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HFEDNNOIICH();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEHDNNMHFID(PDNDLAIMNIC GHKMJNONPHP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface EAONBBNEGDN
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JACPDHJGPIO(OJFOHCCPPLI GHKMJNONPHP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DMNGBKBAIIA(OJFOHCCPPLI GHKMJNONPHP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string MJHPHAJMAJO(OJFOHCCPPLI GHKMJNONPHP);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid EHFDGOCLCBO(OJFOHCCPPLI GHKMJNONPHP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AHAPJAEBDBI(OJFOHCCPPLI GHKMJNONPHP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFCDKNMLHAE(OJFOHCCPPLI GHKMJNONPHP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void NEGMIJALCKA(PDNDLAIMNIC MKEIIEIKLOF, int GLLLKPDBODD, PDNDLAIMNIC MIHNPBFLFJI, int CPODLODCIGO, [Optional] Vector3? GENECOFMCJE, [Optional] Quaternion? MADPMBLAMGB);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void FLNIHBKKLMP(PDNDLAIMNIC EPGKKDLMDNC, PDNDLAIMNIC LPKLKFODEKH);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OJFOHCCPPLI : PDNDLAIMNIC, MDNDPFBGIDI, IEquatable<PDNDLAIMNIC>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MPPEGFMKGLP : MDNDPFBGIDI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PDNDLAIMNIC INNGLAAMGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<PDNDLAIMNIC> PHPLAIHHMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 ACDOIAIGJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion GAMLJENJPJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool IEJAEAPDLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool GHDECCPPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event NEGMIJALCKA IKIOHHEHCEG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event NEGMIJALCKA AOBPPHJJKLL;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NEGMIJALCKA JFGEOCCCIOM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event FLNIHBKKLMP IKGFAPPNMOC;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OCFCMPGINLD();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void INEAJMHODFF();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BBFCIGOENPK();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PDNHLCKEJHG();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FNAABBEHDHB();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GAAFGMDHOKE();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BFNIPBIMPON(int HMHBLOONOPO, PDNDLAIMNIC MIHNPBFLFJI, int NABPNEAIIAH);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GGDPEEMKNIP();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AGDJJCGLGLI(int HMHBLOONOPO, PDNDLAIMNIC MKEIIEIKLOF, int IGEFDBBFNHK, [Optional] Vector3? GENECOFMCJE, [Optional] Quaternion? MADPMBLAMGB);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PDKMBHJAFGG(PDNDLAIMNIC MKEIIEIKLOF);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BMFOKPFLEKG();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LBLFDFGADIM(int IIACLAMOIEE, Vector3 MIIBBEPBJLP);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PPAELNGDAGD(Vector3 LEAHAOMEKJK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GACMHDNJIJP
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 KLBGAPIDOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GGINMMJCPIB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MGNDCLLLLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FCPELHCBMML ELGDKPCMFIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, GGINMMJCPIB
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
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x96F330", Offset = "0x96E730", VA = "0x18096F330", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FCPELHCBMML LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E290", Offset = "0x6F2D690", VA = "0x186F2E290")]
		public static ConnectableConfigData BJLBDOPMPEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E350", Offset = "0x6F2D750", VA = "0x186F2E350")]
		public ConnectableConfigData(LegacyConnectableLinkVisual OPNBKHFDLGA, bool KDHADKOLDOM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PDMPPCOEAIA : IEquatable<PDMPPCOEAIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public PDNDLAIMNIC ECHMDKMCJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int PIIALHEOFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int AIGPIKKOCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 GENECOFMCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion MADPMBLAMGB;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BDC0", Offset = "0x6F3B1C0", VA = "0x186F3BDC0")]
	public PDMPPCOEAIA(PDNDLAIMNIC ECHMDKMCJFA, int PIIALHEOFHP, int AIGPIKKOCHA, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BEA0", Offset = "0x6F3B2A0", VA = "0x186F3BEA0")]
	public PDMPPCOEAIA(PDNDLAIMNIC ECHMDKMCJFA, int PIIALHEOFHP, int AIGPIKKOCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BE20", Offset = "0x6F3B220", VA = "0x186F3BE20")]
	public PDMPPCOEAIA(PDNDLAIMNIC ECHMDKMCJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B950", Offset = "0x6F3AD50", VA = "0x186F3B950", Slot = "4")]
	public bool Equals(PDMPPCOEAIA BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BA00", Offset = "0x6F3AE00", VA = "0x186F3BA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class FBJOPHEAJOP : ICGMKEDHHFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform KELFOJAPBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private FCPELHCBMML GANPDJLIIKG;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x69C6970", Offset = "0x69C5D70", VA = "0x1869C6970", Slot = "4")]
	public void OOJJEJPOBFE(Transform KELFOJAPBEF, FCPELHCBMML GANPDJLIIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E660", Offset = "0x6F2DA60", VA = "0x186F2E660", Slot = "5")]
	public FCPELHCBMML DLFCBHEHCMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E720", Offset = "0x6F2DB20", VA = "0x186F2E720", Slot = "6")]
	public void JAMDOBPPFKK(FCPELHCBMML KEJIKJHADGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public FBJOPHEAJOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class MCNEFIMAPKA : IDisposable, FDLGDJDLGJE
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PFLLHKNBFJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PDNDLAIMNIC oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public PDNDLAIMNIC newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PFLLHKNBFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BF40", Offset = "0x6F3B340", VA = "0x186F3BF40")]
		internal bool GJMNFIAPKEO(ALNLPNEKFJA node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly FLOHCBPMPFL FNAMLFNJIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private JLKHPLPHJIO OALMBJGMHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private ONKGKDIHHKI GGPLCIOHPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool KDHADKOLDOM;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly GKOKEEMOOFG GNENPHEHOKD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public ALNLPNEKFJA FFIKGEIEAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6F36060", Offset = "0x6F35460", VA = "0x186F36060")]
	public bool CHONFOFNCMO([In] NIINDHEPCLN JGCOLLOOLHL, bool KJMHPJAGNEA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6F381D0", Offset = "0x6F375D0", VA = "0x186F381D0")]
	private bool MJGFHCDANFK([In] NIINDHEPCLN JGCOLLOOLHL, bool KJMHPJAGNEA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6F39060", Offset = "0x6F38460", VA = "0x186F39060")]
	public MCNEFIMAPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6F38A40", Offset = "0x6F37E40", VA = "0x186F38A40", Slot = "5")]
	public void OOJJEJPOBFE(MACBICNHBEL KCLPDCIIPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6F36BD0", Offset = "0x6F35FD0", VA = "0x186F36BD0", Slot = "17")]
	public void HHEDBIOCNKH(LIHKODOPIKJ CPIKECCHPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6F36D30", Offset = "0x6F36130", VA = "0x186F36D30", Slot = "12")]
	public void HIFPCJEJLMN(Func<PDNDLAIMNIC, bool> EBABANHPBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6F36C00", Offset = "0x6F36000", VA = "0x186F36C00")]
	private void HIFPCJEJLMN(FLOHCBPMPFL AJLPJFOPFCG, Func<PDNDLAIMNIC, bool> EBABANHPBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6F36A90", Offset = "0x6F35E90", VA = "0x186F36A90", Slot = "11")]
	public void GLFAFMCFFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6F36070", Offset = "0x6F35470", VA = "0x186F36070", Slot = "8")]
	public bool CJONPFEEHFP(PDNDLAIMNIC FBMACFDALCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6F37490", Offset = "0x6F36890", VA = "0x186F37490")]
	private bool JEMFMCCPPKG(PDNDLAIMNIC CBIAGMGLDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6F364A0", Offset = "0x6F358A0", VA = "0x186F364A0")]
	private static bool EHHJJDAPCAM(PDNDLAIMNIC CBIAGMGLDAP, FLOHCBPMPFL LDJPLAFJABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6F366B0", Offset = "0x6F35AB0", VA = "0x186F366B0")]
	private void GCNNDINECBK(Transform JMLDIAPJHDH, FLOHCBPMPFL ALNAKFPJDGP, FLOHCBPMPFL[] OPKJLNLFDJA, PDNDLAIMNIC NJEGMAIEGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6F38080", Offset = "0x6F37480", VA = "0x186F38080")]
	private PDMPPCOEAIA MGOJAPFDLAF(Transform FDHDNLBLINE, PDMPPCOEAIA CMGECMNINDP)
	{
		return default(PDMPPCOEAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6F361B0", Offset = "0x6F355B0", VA = "0x186F361B0")]
	private static bool DOHODDBMFOF(FLOHCBPMPFL LDJPLAFJABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6F36080", Offset = "0x6F35480", VA = "0x186F36080", Slot = "9")]
	public bool CMALBGCKABG(PDNDLAIMNIC NBGBGKCCFAM, int IGEFDBBFNHK, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6F38790", Offset = "0x6F37B90", VA = "0x186F38790")]
	private bool OJOBCEFCHDG(PDNDLAIMNIC NBGBGKCCFAM, int IGEFDBBFNHK, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6F37A80", Offset = "0x6F36E80", VA = "0x186F37A80")]
	private static void KGCJPHLKLOJ(PDNDLAIMNIC NBGBGKCCFAM, int IGEFDBBFNHK, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB, FLOHCBPMPFL DPEIJGEFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6F36D40", Offset = "0x6F36140", VA = "0x186F36D40")]
	private void IBMJJOPBPAA(PDNDLAIMNIC DNJPKGFIIIJ, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6F36AF0", Offset = "0x6F35EF0", VA = "0x186F36AF0")]
	private void HGNDGIOANMC(FLOHCBPMPFL AJLPJFOPFCG, PDNDLAIMNIC EIDBPOEJPOG, PDNDLAIMNIC NFMMNJIBIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6F36B60", Offset = "0x6F35F60", VA = "0x186F36B60")]
	private void HGNDGIOANMC(PDNDLAIMNIC ECHMDKMCJFA, PDNDLAIMNIC EIDBPOEJPOG, PDNDLAIMNIC NFMMNJIBIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6F35EF0", Offset = "0x6F352F0", VA = "0x186F35EF0")]
	private void BFFEIIPFALM(PDNDLAIMNIC ECHMDKMCJFA, PDNDLAIMNIC EIDBPOEJPOG, PDNDLAIMNIC NFMMNJIBIAP, bool MOICAPIHCAB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6F35F60", Offset = "0x6F35360", VA = "0x186F35F60")]
	private void BFFEIIPFALM(FLOHCBPMPFL NIMLNKDMKHI, PDNDLAIMNIC NJEGMAIEGAC, PDNDLAIMNIC LPKLKFODEKH, bool MOICAPIHCAB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6F37C60", Offset = "0x6F37060", VA = "0x186F37C60")]
	private void LAAJDCNMANB(PDNDLAIMNIC FKLPGABAEFE, int IGEFDBBFNHK, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6F37EB0", Offset = "0x6F372B0", VA = "0x186F37EB0")]
	private void LKCDGHNNMEA(ALNLPNEKFJA AMMKPAGCALK, ALNLPNEKFJA IIKGAAHENMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6F36550", Offset = "0x6F35950", VA = "0x186F36550", Slot = "18")]
	public PDNDLAIMNIC FHOBAOHPGCA(PDNDLAIMNIC ECHMDKMCJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6F38AF0", Offset = "0x6F37EF0", VA = "0x186F38AF0", Slot = "13")]
	public void OPIJPOEONGG(PDNDLAIMNIC ECHMDKMCJFA, HashSet<PDNDLAIMNIC> FOEICNAAOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6F35CB0", Offset = "0x6F350B0", VA = "0x186F35CB0", Slot = "14")]
	public List<PDNDLAIMNIC> AHKDBGADLGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6F37DE0", Offset = "0x6F371E0", VA = "0x186F37DE0")]
	protected ALNLPNEKFJA LHDLIPDBEMP(ALNLPNEKFJA AJLPJFOPFCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6F373F0", Offset = "0x6F367F0", VA = "0x186F373F0")]
	protected FLOHCBPMPFL[] ILLAFILNCPN(FLOHCBPMPFL LDJPLAFJABD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6F38E90", Offset = "0x6F38290", VA = "0x186F38E90")]
	protected bool PIFDGPAIIHH(PDNDLAIMNIC ECHMDKMCJFA, [Out] FLOHCBPMPFL AJLPJFOPFCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6F36370", Offset = "0x6F35770", VA = "0x186F36370", Slot = "15")]
	public bool DPHBMIICHPL(PDNDLAIMNIC ECHMDKMCJFA, [Out] PDMPPCOEAIA FNFAGOGEOBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6F36AB0", Offset = "0x6F35EB0", VA = "0x186F36AB0")]
	protected FLOHCBPMPFL GLJJLCINFMD(PDMPPCOEAIA COOBIIKBPJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6F37D80", Offset = "0x6F37180", VA = "0x186F37D80", Slot = "10")]
	public bool LANKOKNBIMM(PDNDLAIMNIC DNJPKGFIIIJ, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6F36E60", Offset = "0x6F36260", VA = "0x186F36E60")]
	private bool IKHKMNNEOGD(PDNDLAIMNIC DNJPKGFIIIJ, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F360E0", Offset = "0x6F354E0", VA = "0x186F360E0")]
	private static bool DCKJHEFBEPD(FLOHCBPMPFL OMOOPJMMNDA, PDMPPCOEAIA POMBFNEKBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6F36060", Offset = "0x6F35460", VA = "0x186F36060", Slot = "7")]
	private bool NEBILDFDEAH([In] NIINDHEPCLN JGCOLLOOLHL, bool KJMHPJAGNEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class OODJCHDPDND : MACBICNHBEL, FCDDCBJENJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly CGJHFFGEHKC CLDCJHAFFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly ONKGKDIHHKI GGPLCIOHPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly BOAFPDADAPB CCJJDAAOKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly IMJINLLEBFP GNDOANNBDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly FDLGDJDLGJE CIBJIJAGOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal HICMFDJKOHM IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal HKCPMNKPLOG NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal JLKHPLPHJIO LFGDLCFJJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool KDHADKOLDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool APAMHOBPKIF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool IFLNIODDIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6F00", Offset = "0xCF6300", VA = "0x180CF6F00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x11C57C0", Offset = "0x11C4BC0", VA = "0x1811C57C0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BEICAADJBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6EF0", Offset = "0xCF62F0", VA = "0x180CF6EF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1EF9450", Offset = "0x1EF8850", VA = "0x181EF9450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GNNGFFLACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<PDNDLAIMNIC, PDNDLAIMNIC> HAOFIBFJCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6F3A990", Offset = "0x6F39D90", VA = "0x186F3A990", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6F39E30", Offset = "0x6F39230", VA = "0x186F39E30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<PDNDLAIMNIC, PDNDLAIMNIC> IEHILDJFPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6F3A140", Offset = "0x6F39540", VA = "0x186F3A140", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6F39BD0", Offset = "0x6F38FD0", VA = "0x186F39BD0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<PDNDLAIMNIC, PDNDLAIMNIC, PDNDLAIMNIC> BGHBCDIDIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6F39B70", Offset = "0x6F38F70", VA = "0x186F39B70", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6F39C30", Offset = "0x6F39030", VA = "0x186F39C30", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B560", Offset = "0x6F3A960", VA = "0x186F3B560")]
	public OODJCHDPDND(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AEB0", Offset = "0x6F3A2B0", VA = "0x186F3AEB0", Slot = "12")]
	public void OOJJEJPOBFE(GameObject MCCIFMIMANN, GGINMMJCPIB MFHLPNFABOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6F3ADB0", Offset = "0x6F3A1B0", VA = "0x186F3ADB0", Slot = "26")]
	public void OBDLHHEKPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6F39AF0", Offset = "0x6F38EF0", VA = "0x186F39AF0", Slot = "13")]
	public void BFLBMILJDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6F39FE0", Offset = "0x6F393E0", VA = "0x186F39FE0", Slot = "14")]
	public void EMOBGIHOLPD(PDNDLAIMNIC ECHMDKMCJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6F39880", Offset = "0x6F38C80", VA = "0x186F39880", Slot = "15")]
	public void AFELCEKEOAN(PDNDLAIMNIC ECHMDKMCJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AB30", Offset = "0x6F39F30", VA = "0x186F3AB30", Slot = "22")]
	public bool KMBFGGJFHHD(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6F3ABC0", Offset = "0x6F39FC0", VA = "0x186F3ABC0")]
	internal bool MJGFHCDANFK([In] NIINDHEPCLN JGCOLLOOLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A780", Offset = "0x6F39B80", VA = "0x186F3A780")]
	internal bool IKHKMNNEOGD([In] NIINDHEPCLN JGCOLLOOLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AE50", Offset = "0x6F3A250", VA = "0x186F3AE50")]
	internal bool OEMBLLCBNID([In] NIINDHEPCLN JGCOLLOOLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6F39E90", Offset = "0x6F39290", VA = "0x186F39E90")]
	internal bool EHBMIEHJNCG([In] NIINDHEPCLN JGCOLLOOLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A1A0", Offset = "0x6F395A0", VA = "0x186F3A1A0")]
	internal void GANCGJJHOJE(PDNDLAIMNIC ECHMDKMCJFA, int FJGMCICPAAM, bool KJMHPJAGNEA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6F39880", Offset = "0x6F38C80", VA = "0x186F39880")]
	internal bool MDEKELDNKOE(PDNDLAIMNIC OOEOPDBEGEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AC80", Offset = "0x6F3A080", VA = "0x186F3AC80")]
	internal bool NJOBFKAJMOK(PDNDLAIMNIC NBGBGKCCFAM, int IGEFDBBFNHK, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B470", Offset = "0x6F3A870", VA = "0x186F3B470", Slot = "16")]
	public void OPIJPOEONGG(PDNDLAIMNIC ECHMDKMCJFA, HashSet<PDNDLAIMNIC> FCMPKKOFJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6F398E0", Offset = "0x6F38CE0", VA = "0x186F398E0", Slot = "17")]
	public void AGJGNACKCPD(PDNDLAIMNIC NBGBGKCCFAM, PDNDLAIMNIC EFGHGKGDOLP, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A000", Offset = "0x6F39400", VA = "0x186F3A000", Slot = "18")]
	public void FBILJMEBBAD(PDNDLAIMNIC DNJPKGFIIIJ, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A380", Offset = "0x6F39780", VA = "0x186F3A380", Slot = "19")]
	public void IGMDAKNGEEC(PDNDLAIMNIC DNJPKGFIIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A540", Offset = "0x6F39940", VA = "0x186F3A540")]
	public void IKECJKHDKGA([Optional] DIAHAEPANBO LONGBDMAJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AAA0", Offset = "0x6F39EA0", VA = "0x186F3AAA0", Slot = "23")]
	public void KKPHIBCGDBP(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A810", Offset = "0x6F39C10", VA = "0x186F3A810", Slot = "20")]
	public CIIDELJIHKK JKAFJBDBEAI(bool GMHKPKFOPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6F39C90", Offset = "0x6F39090", VA = "0x186F39C90", Slot = "21")]
	public CIIDELJIHKK DJCDIIKPALF(HashSet<Guid> OCLAIIHIPMM, bool GMHKPKFOPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AB80", Offset = "0x6F39F80", VA = "0x186F3AB80", Slot = "25")]
	public void MDBJCKBADOF(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6F3A9F0", Offset = "0x6F39DF0", VA = "0x186F3A9F0", Slot = "24")]
	public void KFMGMAIABDO(CIIDELJIHKK CIBJIJAGOGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class ONKGKDIHHKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly ECDLJKHIKLK<PDNDLAIMNIC, PDNDLAIMNIC> HAOFIBFJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly ECDLJKHIKLK<PDNDLAIMNIC, PDNDLAIMNIC> IEHILDJFPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly MACPLFCKHIA<PDNDLAIMNIC, PDNDLAIMNIC, PDNDLAIMNIC> BGHBCDIDIKO;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6F39760", Offset = "0x6F38B60", VA = "0x186F39760")]
	public ONKGKDIHHKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	public void OOJJEJPOBFE(OODJCHDPDND KCLPDCIIPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6F39700", Offset = "0x6F38B00", VA = "0x186F39700")]
	public void IJBAEKIKBNP(PDNDLAIMNIC AMMKPAGCALK, PDNDLAIMNIC FKLPGABAEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6F39620", Offset = "0x6F38A20", VA = "0x186F39620")]
	public void DBILHOCFAGN(PDNDLAIMNIC AMMKPAGCALK, PDNDLAIMNIC FKLPGABAEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6F39680", Offset = "0x6F38A80", VA = "0x186F39680")]
	public void GLAJMIHBPPB(PDNDLAIMNIC DKEOBCPHOMK, PDNDLAIMNIC NBJNONHAKJK, PDNDLAIMNIC FKLPGABAEFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class BOAFPDADAPB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private OODJCHDPDND KCLPDCIIPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HKCPMNKPLOG NPGFBLNGFLA;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BOAFPDADAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E160", Offset = "0x6F2D560", VA = "0x186F2E160")]
	public void OOJJEJPOBFE(OODJCHDPDND KCLPDCIIPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E0C0", Offset = "0x6F2D4C0", VA = "0x186F2E0C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E140", Offset = "0x6F2D540", VA = "0x186F2E140")]
	private void OHJAFJEFDKI(DIAHAEPANBO FFBDHANOEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E0D0", Offset = "0x6F2D4D0", VA = "0x186F2E0D0")]
	private void FJJECOMGFJN(DIAHAEPANBO IMCIBCNBLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DFC0", Offset = "0x6F2D3C0", VA = "0x186F2DFC0")]
	public void DKKLEHOJLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DEC0", Offset = "0x6F2D2C0", VA = "0x186F2DEC0")]
	public void AOPAJPOFJOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LEPGKIHCCIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JJMLJLAIOGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CGJHFFGEHKC container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JJMLJLAIOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6F33790", Offset = "0x6F32B90", VA = "0x186F33790")]
		internal OODJCHDPDND GPGNHGJJBOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F33800", Offset = "0x6F32C00", VA = "0x186F33800")]
	public static void CIPNFKJEAPC(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F33A00", Offset = "0x6F32E00", VA = "0x186F33A00")]
	public static void NGEFHPNJKDI(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class GPCPCPAFLON : IDisposable, JLKHPLPHJIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, FCPELHCBMML> BNGLMLJBLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LIHKODOPIKJ KDHBDENGMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private ICGMKEDHHFL DFBOLFEDINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private FDLGDJDLGJE CIBJIJAGOGC;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker FNEGNAHEMDK;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6F30A40", Offset = "0x6F2FE40", VA = "0x186F30A40")]
	public GPCPCPAFLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6F30420", Offset = "0x6F2F820", VA = "0x186F30420", Slot = "7")]
	public void OOJJEJPOBFE(FDLGDJDLGJE CIBJIJAGOGC, ICGMKEDHHFL DFBOLFEDINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6F30610", Offset = "0x6F2FA10", VA = "0x186F30610", Slot = "5")]
	public void PAMHBHLAOOA(ALNLPNEKFJA IGJEBKELOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FDE0", Offset = "0x6F2F1E0", VA = "0x186F2FDE0", Slot = "9")]
	public void CJNNNIIFJHM(ALNLPNEKFJA CIOBODNGMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FC20", Offset = "0x6F2F020", VA = "0x186F2FC20", Slot = "8")]
	public void BIECOGMJPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6F30020", Offset = "0x6F2F420", VA = "0x186F30020", Slot = "10")]
	public void DFADCHGMJFP(ALNLPNEKFJA AJJKACKDJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6F30270", Offset = "0x6F2F670", VA = "0x186F30270", Slot = "11")]
	public void FLJLFDKLFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6F30460", Offset = "0x6F2F860", VA = "0x186F30460")]
	private bool PAALOPPFNGK(ALNLPNEKFJA NKCIADHLFMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class IMJINLLEBFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct GNBKCAAFIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly FLOHCBPMPFL OMEKBEGFEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> OCLAIIHIPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly GDCNFDIBHNF FKHDJBBFAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly GDCNFDIBHNF CAFOOHMCMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool GMHKPKFOPCE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool NEDCGNJLAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6F2F2F0", Offset = "0x6F2E6F0", VA = "0x186F2F2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6F2FBB0", Offset = "0x6F2EFB0", VA = "0x186F2FBB0")]
		public GNBKCAAFIED(FLOHCBPMPFL OMEKBEGFEOB, HashSet<Guid> OCLAIIHIPMM, bool GMHKPKFOPCE, [Optional] GDCNFDIBHNF FKHDJBBFAKP, [Optional] GDCNFDIBHNF CAFOOHMCMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F7E0", Offset = "0x6F2EBE0", VA = "0x186F2F7E0")]
		public GDCNFDIBHNF GKPJGNLGAKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6F2FAF0", Offset = "0x6F2EEF0", VA = "0x186F2FAF0")]
		private GDCNFDIBHNF JOCAHLNFFOD([Out] GDCNFDIBHNF FEINILKDDLJ, [Out] GDCNFDIBHNF AGCGEBOEBLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F5C0", Offset = "0x6F2E9C0", VA = "0x186F2F5C0")]
		private GDCNFDIBHNF GEFHHPOFMHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F980", Offset = "0x6F2ED80", VA = "0x186F2F980")]
		private void HDBCEFHDNLE(GDCNFDIBHNF JOLMBINGMEB, GDCNFDIBHNF PBPEKLHIECL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F400", Offset = "0x6F2E800", VA = "0x186F2F400")]
		private void EKPBNCOMPPH(GDCNFDIBHNF FEINILKDDLJ, GDCNFDIBHNF AGCGEBOEBLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private OODJCHDPDND KCLPDCIIPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private FDLGDJDLGJE CIBJIJAGOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private JLKHPLPHJIO OALMBJGMHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private HKCPMNKPLOG NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool MMOGLCJMKFD;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool KDEJNELFCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6F31EC0", Offset = "0x6F312C0", VA = "0x186F31EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool IFLNIODDIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6F31B80", Offset = "0x6F30F80", VA = "0x186F31B80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F32860", Offset = "0x6F31C60", VA = "0x186F32860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6F334E0", Offset = "0x6F328E0", VA = "0x186F334E0")]
	public void OOJJEJPOBFE(OODJCHDPDND KCLPDCIIPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6F32090", Offset = "0x6F31490", VA = "0x186F32090")]
	public CIIDELJIHKK JKAFJBDBEAI(bool GMHKPKFOPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6F31190", Offset = "0x6F30590", VA = "0x186F31190")]
	public CIIDELJIHKK DJCDIIKPALF(HashSet<Guid> OCLAIIHIPMM, bool GMHKPKFOPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6F32940", Offset = "0x6F31D40", VA = "0x186F32940")]
	public void KKPHIBCGDBP(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6F32880", Offset = "0x6F31C80", VA = "0x186F32880")]
	public void KFMGMAIABDO(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6F31E90", Offset = "0x6F31290", VA = "0x186F31E90")]
	public void FJDIDMOEAON(CIIDELJIHKK CIBJIJAGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6F31CB0", Offset = "0x6F310B0", VA = "0x186F31CB0")]
	private void EKAHMAONBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6F31F10", Offset = "0x6F31310", VA = "0x186F31F10")]
	private GDCNFDIBHNF GBKNOCPODMJ(FLOHCBPMPFL AJLPJFOPFCG, bool GMHKPKFOPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6F33230", Offset = "0x6F32630", VA = "0x186F33230")]
	private static void OHNCFJLMOHH(FLOHCBPMPFL AJLPJFOPFCG, bool GMHKPKFOPCE, GDCNFDIBHNF AIGKLGGBPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6F32C60", Offset = "0x6F32060", VA = "0x186F32C60")]
	private void LGLAFLHAEIP(FLOHCBPMPFL AJLPJFOPFCG, bool GMHKPKFOPCE, GDCNFDIBHNF AIGKLGGBPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6F32000", Offset = "0x6F31400", VA = "0x186F32000")]
	private GDCNFDIBHNF GIGEHPLINPB(FLOHCBPMPFL OMEKBEGFEOB, HashSet<Guid> OCLAIIHIPMM, bool GMHKPKFOPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6F30F10", Offset = "0x6F30310", VA = "0x186F30F10")]
	private bool AAGHCDBICIN(CIIDELJIHKK GCAHECHGLFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6F32200", Offset = "0x6F31600", VA = "0x186F32200")]
	private bool JOFOJHOLGIK(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6F32920", Offset = "0x6F31D20", VA = "0x186F32920")]
	private bool KIKIADIOOGC(CIIDELJIHKK CIBJIJAGOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6F31BA0", Offset = "0x6F30FA0", VA = "0x186F31BA0")]
	private static bool EJJJHAJFMGG(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6F329D0", Offset = "0x6F31DD0", VA = "0x186F329D0")]
	public static bool KMBFGGJFHHD(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6F316A0", Offset = "0x6F30AA0", VA = "0x186F316A0")]
	private PDNDLAIMNIC EBMDKDLAKBA(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6F31520", Offset = "0x6F30920", VA = "0x186F31520")]
	private PDNDLAIMNIC EAFPBBFIOLF(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6F319F0", Offset = "0x6F30DF0", VA = "0x186F319F0")]
	private PDNDLAIMNIC ECJBLJMAOOB(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AF50", Offset = "0x6F2A350", VA = "0x186F2AF50")]
	private static Guid KMHEEDMMCFJ(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6F32E80", Offset = "0x6F32280", VA = "0x186F32E80")]
	private string LKFIAKOKLGP(GDCNFDIBHNF AIGKLGGBPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F31330", Offset = "0x6F30730", VA = "0x186F31330")]
	private bool DLHKNNJBHOE(FLOHCBPMPFL AJLPJFOPFCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F32F70", Offset = "0x6F32370", VA = "0x186F32F70")]
	private static void MPBMJBPLIIC(FLOHCBPMPFL OMEKBEGFEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public IMJINLLEBFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct NIINDHEPCLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public PDNDLAIMNIC FKLPGABAEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public PDNDLAIMNIC AMMKPAGCALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int IGEFDBBFNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int NABPNEAIIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 GENECOFMCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion MADPMBLAMGB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public PDMPPCOEAIA NLDLPLOJMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6F393F0", Offset = "0x6F387F0", VA = "0x186F393F0")]
		get
		{
			return default(PDMPPCOEAIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PDMPPCOEAIA LKGAMKPCEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6F39490", Offset = "0x6F38890", VA = "0x186F39490")]
		get
		{
			return default(PDMPPCOEAIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6F394C0", Offset = "0x6F388C0", VA = "0x186F394C0")]
	public NIINDHEPCLN(PDNDLAIMNIC FKLPGABAEFE, PDNDLAIMNIC AMMKPAGCALK, int IGEFDBBFNHK, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface FDLGDJDLGJE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	ALNLPNEKFJA FFIKGEIEAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOJJEJPOBFE(MACBICNHBEL KCLPDCIIPCH);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CHONFOFNCMO([In] NIINDHEPCLN JGCOLLOOLHL, bool KJMHPJAGNEA = true);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CJONPFEEHFP(PDNDLAIMNIC FBMACFDALCM);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CMALBGCKABG(PDNDLAIMNIC NBGBGKCCFAM, int IGEFDBBFNHK, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LANKOKNBIMM(PDNDLAIMNIC DNJPKGFIIIJ, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GLFAFMCFFMG();

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HIFPCJEJLMN(Func<PDNDLAIMNIC, bool> EBABANHPBNK);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OPIJPOEONGG(PDNDLAIMNIC ECHMDKMCJFA, HashSet<PDNDLAIMNIC> FOEICNAAOBE);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<PDNDLAIMNIC> AHKDBGADLGN();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DPHBMIICHPL(PDNDLAIMNIC ECHMDKMCJFA, [Out] PDMPPCOEAIA FNFAGOGEOBK);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HHEDBIOCNKH(LIHKODOPIKJ CPIKECCHPBJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool LIHKODOPIKJ(ALNLPNEKFJA AJLPJFOPFCG);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface ALNLPNEKFJA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	PDNDLAIMNIC MBKPBJNGMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	ALNLPNEKFJA HOBMCFDJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PDMPPCOEAIA EPCKNIJONFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool FIOCAMAMCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FCPELHCBMML : JJJIGBPKNBA.BBCPCGGBHPG
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKOIGPCFEMK(PDNDLAIMNIC MIHNPBFLFJI, PDMPPCOEAIA FKLPGABAEFE);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCHNDHENPFO(PDNDLAIMNIC MIHNPBFLFJI, PDMPPCOEAIA FKLPGABAEFE);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LADKIONEDJB(PDNDLAIMNIC MIHNPBFLFJI, PDMPPCOEAIA FKLPGABAEFE);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AKJPDALMKHK(PDNDLAIMNIC MIHNPBFLFJI, PDMPPCOEAIA FKLPGABAEFE);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FCPELHCBMML Instantiate(Transform KELFOJAPBEF);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DNAOJJGPLEN();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface ICGMKEDHHFL
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOJJEJPOBFE(Transform KELFOJAPBEF, FCPELHCBMML GANPDJLIIKG);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FCPELHCBMML DLFCBHEHCMH();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAMDOBPPFKK(FCPELHCBMML KEJIKJHADGH);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HICMFDJKOHM : APOLJOLGJOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFGBIPNLPHF();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CMBINDOAEDO(Guid PHAPCMPPFPA);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface JLKHPLPHJIO
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAMHBHLAOOA(ALNLPNEKFJA IGJEBKELOMM);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOJJEJPOBFE(FDLGDJDLGJE CIBJIJAGOGC, ICGMKEDHHFL FCBHOIFNEAN);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BIECOGMJPOI();

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJNNNIIFJHM(ALNLPNEKFJA CIOBODNGMCN);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DFADCHGMJFP(ALNLPNEKFJA AJJKACKDJFH);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FLJLFDKLFAI();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class FLOHCBPMPFL : ALNLPNEKFJA
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IJFCHPLMPJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public PDMPPCOEAIA nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FLOHCBPMPFL foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public IJFCHPLMPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F30DD0", Offset = "0x6F301D0", VA = "0x186F30DD0")]
		internal bool OAKDDHNJBCG(ALNLPNEKFJA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private PDMPPCOEAIA FNFAGOGEOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<FLOHCBPMPFL> GKKJFBEKOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private FLOHCBPMPFL CDEEPNNDFBG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public PDMPPCOEAIA EPCKNIJONFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D36800", Offset = "0x3D35C00", VA = "0x183D36800", Slot = "6")]
		get
		{
			return default(PDMPPCOEAIA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F130", Offset = "0x6F2E530", VA = "0x186F2F130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private FLOHCBPMPFL AMMKPAGCALK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F160", Offset = "0x6F2E560", VA = "0x186F2F160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ALNLPNEKFJA HOBMCFDJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public PDNDLAIMNIC MBKPBJNGMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FIOCAMAMCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F2EB70", Offset = "0x6F2DF70", VA = "0x186F2EB70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool FEENPPPMDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F2ECA0", Offset = "0x6F2E0A0", VA = "0x186F2ECA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected FLOHCBPMPFL NIMLNKDMKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F2EB80", Offset = "0x6F2DF80", VA = "0x186F2EB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F240", Offset = "0x6F2E640", VA = "0x186F2F240")]
	public FLOHCBPMPFL(PDMPPCOEAIA GDCBPKEICAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EFE0", Offset = "0x6F2E3E0", VA = "0x186F2EFE0")]
	public FLOHCBPMPFL JJNGPMHDKCP(PDMPPCOEAIA CPBLPJFNOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F2ECF0", Offset = "0x6F2E0F0", VA = "0x186F2ECF0")]
	public FLOHCBPMPFL HBDJLPNKKPD(PDMPPCOEAIA IEAOMMLGCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E840", Offset = "0x6F2DC40", VA = "0x186F2E840")]
	public FLOHCBPMPFL BDKJEBALGLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EA20", Offset = "0x6F2DE20", VA = "0x186F2EA20")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E790", Offset = "0x6F2DB90", VA = "0x186F2E790")]
	public FLOHCBPMPFL AHOEPFLJPPF(PDMPPCOEAIA NBJNONHAKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EE70", Offset = "0x6F2E270", VA = "0x186F2EE70")]
	private static void HHEDBIOCNKH(FLOHCBPMPFL FPFCFKBBLKE, LIHKODOPIKJ CGENICICIAO, bool FNJBGKEEDBK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EFD0", Offset = "0x6F2E3D0", VA = "0x186F2EFD0", Slot = "9")]
	public void HHEDBIOCNKH(LIHKODOPIKJ CPIKECCHPBJ, bool MOICAPIHCAB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EBA0", Offset = "0x6F2DFA0", VA = "0x186F2EBA0")]
	public static FLOHCBPMPFL GLJJLCINFMD(FLOHCBPMPFL FPFCFKBBLKE, PDMPPCOEAIA MPDJHDCBKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface HKCPMNKPLOG
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool KDEJNELFCND
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool FIJHLCJHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<DIAHAEPANBO> OHJAFJEFDKI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<DIAHAEPANBO> FJJECOMGFJN;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(OODJCHDPDND KCLPDCIIPCH);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(PDNDLAIMNIC NBGBGKCCFAM, PDNDLAIMNIC EFGHGKGDOLP, int IGEFDBBFNHK, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(PDNDLAIMNIC DNJPKGFIIIJ, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(CIIDELJIHKK NBOMIKBDGCJ, [Optional] DIAHAEPANBO LONGBDMAJPJ);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, HKCPMNKPLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private OODJCHDPDND KCLPDCIIPCH;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool KDEJNELFCND
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6F35930", Offset = "0x6F34D30", VA = "0x186F35930", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool FIJHLCJHAJE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6F35990", Offset = "0x6F34D90", VA = "0x186F35990", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<DIAHAEPANBO> OHJAFJEFDKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6F35890", Offset = "0x6F34C90", VA = "0x186F35890", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x6F35A70", Offset = "0x6F34E70", VA = "0x186F35A70", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<DIAHAEPANBO> FJJECOMGFJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x6F357F0", Offset = "0x6F34BF0", VA = "0x186F357F0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x6F359D0", Offset = "0x6F34DD0", VA = "0x186F359D0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D0CD0", Offset = "0x8D00D0", VA = "0x1808D0CD0", Slot = "19")]
		public void SetManager(OODJCHDPDND KCLPDCIIPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F357C0", Offset = "0x6F34BC0", VA = "0x186F357C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F34540", Offset = "0x6F33940", VA = "0x186F34540", Slot = "23")]
		public void RequestMasterConnectNodes(PDNDLAIMNIC MKEIIEIKLOF, int IGEFDBBFNHK, PDNDLAIMNIC MIHNPBFLFJI, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F34670", Offset = "0x6F33A70", VA = "0x186F34670", Slot = "24")]
		public void RequestMasterDisconnectNode(PDNDLAIMNIC FBMACFDALCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F34730", Offset = "0x6F33B30", VA = "0x186F34730", Slot = "20")]
		public void RequestMasterModifyNode(PDNDLAIMNIC NBGBGKCCFAM, PDNDLAIMNIC EFGHGKGDOLP, int IGEFDBBFNHK, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F34860", Offset = "0x6F33C60", VA = "0x186F34860", Slot = "21")]
		public void RequestMasterReparentNodes(PDNDLAIMNIC DNJPKGFIIIJ, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F34990", Offset = "0x6F33D90", VA = "0x186F34990", Slot = "25")]
		public void RequestMasterReparentToRoot(PDNDLAIMNIC DNJPKGFIIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F34410", Offset = "0x6F33810", VA = "0x186F34410", Slot = "22")]
		public void RequestDeserializeConnectableGraph(CIIDELJIHKK NBOMIKBDGCJ, [Optional] DIAHAEPANBO LONGBDMAJPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F34D70", Offset = "0x6F34170", VA = "0x186F34D70")]
		[DNIOHPJJOLB]
		private void RpcMasterConnectNodes(PDNDLAIMNIC MKEIIEIKLOF, int IGEFDBBFNHK, PDNDLAIMNIC MIHNPBFLFJI, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F35030", Offset = "0x6F34430", VA = "0x186F35030")]
		[DNIOHPJJOLB]
		private void RpcMasterDisconnectNode(PDNDLAIMNIC FBMACFDALCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F35370", Offset = "0x6F34770", VA = "0x186F35370")]
		[DNIOHPJJOLB]
		private void RpcMasterReparentNodes(PDNDLAIMNIC DNJPKGFIIIJ, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F35170", Offset = "0x6F34570", VA = "0x186F35170")]
		[DNIOHPJJOLB]
		private void RpcMasterModifyNode(PDNDLAIMNIC NBGBGKCCFAM, PDNDLAIMNIC EFGHGKGDOLP, int IGEFDBBFNHK, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F34B60", Offset = "0x6F33F60", VA = "0x186F34B60")]
		[DNIOHPJJOLB]
		private void RpcConnectNodes(PDNDLAIMNIC MKEIIEIKLOF, int IGEFDBBFNHK, PDNDLAIMNIC MIHNPBFLFJI, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB, ICHBALBJGGP NNADPMKMFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F34CE0", Offset = "0x6F340E0", VA = "0x186F34CE0")]
		[DNIOHPJJOLB]
		private void RpcDisconnectNode(PDNDLAIMNIC FBMACFDALCM, ICHBALBJGGP NNADPMKMFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F356C0", Offset = "0x6F34AC0", VA = "0x186F356C0")]
		[DNIOHPJJOLB]
		private void RpcReparentNodes(PDNDLAIMNIC DNJPKGFIIIJ, int IHECEOCEBPM, PDNDLAIMNIC NBJNONHAKJK, int FEMDOGJLFHJ, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB, ICHBALBJGGP NNADPMKMFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F35600", Offset = "0x6F34A00", VA = "0x186F35600")]
		[DNIOHPJJOLB]
		private void RpcModifyNode(PDNDLAIMNIC NBGBGKCCFAM, int IGEFDBBFNHK, int NABPNEAIIAH, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB, ICHBALBJGGP NNADPMKMFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F34CA0", Offset = "0x6F340A0", VA = "0x186F34CA0")]
		[DNIOHPJJOLB]
		private void RpcDeserializeConnectableGraph(CIIDELJIHKK CIBJIJAGOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E3600", Offset = "0x8E2A00", VA = "0x1808E3600")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, FCPELHCBMML, JJJIGBPKNBA.BBCPCGGBHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F33B90", Offset = "0x6F32F90", VA = "0x186F33B90", Slot = "4")]
		private void EGMIPAKPBGD(PDNDLAIMNIC MIHNPBFLFJI, PDMPPCOEAIA FKLPGABAEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F33F40", Offset = "0x6F33340", VA = "0x186F33F40", Slot = "5")]
		private void KJMEHFCIECH(PDNDLAIMNIC MIHNPBFLFJI, PDMPPCOEAIA FKLPGABAEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F33D10", Offset = "0x6F33110", VA = "0x186F33D10", Slot = "6")]
		private void GIKIKEGIAEC(PDNDLAIMNIC MIHNPBFLFJI, PDMPPCOEAIA FKLPGABAEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F34220", Offset = "0x6F33620", VA = "0x186F34220", Slot = "7")]
		private void LBOBJBGHNFD(PDNDLAIMNIC MIHNPBFLFJI, PDMPPCOEAIA FKLPGABAEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F341B0", Offset = "0x6F335B0", VA = "0x186F341B0", Slot = "8")]
		private FCPELHCBMML LBJHLOBFLLJ(Transform KELFOJAPBEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F33B30", Offset = "0x6F32F30", VA = "0x186F33B30", Slot = "9")]
		private void BDBKMJIFBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class PDPPIIOCIAO
{
	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3221DB0", Offset = "0x32211B0", VA = "0x183221DB0")]
	public static LJBDNODAIKE<T> JMLIOOAIFNG<T>(this CGJHFFGEHKC CLDCJHAFFHO)
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
