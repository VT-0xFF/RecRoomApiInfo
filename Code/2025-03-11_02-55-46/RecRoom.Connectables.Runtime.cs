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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x751E0E0", Offset = "0x751D4E0", VA = "0x18751E0E0", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
			[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75246B0", Offset = "0x7523AB0", VA = "0x1875246B0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7524200", Offset = "0x7523600", VA = "0x187524200")]
		private void PFONFFPEPLP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7524090", Offset = "0x7523490", VA = "0x187524090")]
		private void OHDICCNDNDO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7524370", Offset = "0x7523770", VA = "0x187524370", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75246F0", Offset = "0x7523AF0", VA = "0x1875246F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class MDPKIOJBOFN : DIOHDNOMOBA, JOOHDJKBMLK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class NAAOAPAOAND : IEnumerable<ILPCDBFIODI>, IEnumerable, IEnumerator<ILPCDBFIODI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ILPCDBFIODI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private DHFHGDGMDKP localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DHFHGDGMDKP <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MDPKIOJBOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private KFKIFDIIJNI <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private FDAOOOIOHPG <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private FDAOOOIOHPG.LHKDNNFAIJF <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private ILPCDBFIODI System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public NAAOAPAOAND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x75230F0", Offset = "0x75224F0", VA = "0x1875230F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7522C90", Offset = "0x7522090", VA = "0x187522C90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7522C70", Offset = "0x7522070", VA = "0x187522C70")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7522C50", Offset = "0x7522050", VA = "0x187522C50")]
		private void GADEEDGNJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75230A0", Offset = "0x75224A0", VA = "0x1875230A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7522FF0", Offset = "0x75223F0", VA = "0x187522FF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ILPCDBFIODI> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7522FF0", Offset = "0x75223F0", VA = "0x187522FF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DNDIMBDIMKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MDPKIOJBOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public IMOGLCFALMH nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DNDIMBDIMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7511390", Offset = "0x7510790", VA = "0x187511390")]
		internal object PNBEDOPODEJ(IMOGLCFALMH x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PNGBBLKJNNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public IMOGLCFALMH child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DNDIMBDIMKF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PNGBBLKJNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7523C30", Offset = "0x7523030", VA = "0x187523C30")]
		internal object KLHBOLEMHHL((IMOGLCFALMH child, IMOGLCFALMH nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly HLBHMADGLFA OCJNDAEANJO;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HLBHMADGLFA HGKOAANOAOP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly HLBHMADGLFA EDDLBNPNPLG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HLBHMADGLFA KCFMIFNCGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GJENNGAMEEC NKKJKOLLMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private INBLPBNKNCC PGHOOLCHGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private PKHIKGNKLCD CHCPBFIDEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private NPBFKOCBJIP DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private FLMONHKGPCL FINOBGDPFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly AIJOFLJFOPF BHDEAEIFGBG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DAOBNBLDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAF16A0", Offset = "0xAF0AA0", VA = "0x180AF16A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAF0C60", Offset = "0xAF0060", VA = "0x180AF0C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IFJAFJOHLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<ILPCDBFIODI, ILPCDBFIODI> IADFELJMABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7521C60", Offset = "0x7521060", VA = "0x187521C60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x751FDE0", Offset = "0x751F1E0", VA = "0x18751FDE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<ILPCDBFIODI, ILPCDBFIODI> ODILNEFBFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x751F730", Offset = "0x751EB30", VA = "0x18751F730", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x751EAB0", Offset = "0x751DEB0", VA = "0x18751EAB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<ILPCDBFIODI, ILPCDBFIODI, ILPCDBFIODI> JFLNJICMECG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7521800", Offset = "0x7520C00", VA = "0x187521800", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7522360", Offset = "0x7521760", VA = "0x187522360", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7522BE0", Offset = "0x7521FE0", VA = "0x187522BE0")]
	public MDPKIOJBOFN(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7522410", Offset = "0x7521810", VA = "0x187522410", Slot = "12")]
	public void OBBALIPJEND(GameObject IIKFCCENKCC, OCJMCPMAMIL KJFFIGCPHJB, FKAGEINKELN IIAPBBKGPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x751E740", Offset = "0x751DB40", VA = "0x18751E740", Slot = "26")]
	public void CAHNJLIHDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x751EE40", Offset = "0x751E240", VA = "0x18751EE40", Slot = "22")]
	public bool EEFAEGFDAHI(IMOGLCFALMH HGLMIIIBLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x751F870", Offset = "0x751EC70", VA = "0x18751F870")]
	private void HCBOKFHIHFN(DHFHGDGMDKP DFFIHHMKCMG, DHFHGDGMDKP DEFENKPOBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7520020", Offset = "0x751F420", VA = "0x187520020")]
	private void HMMLBLHNMAC(DHFHGDGMDKP DFFIHHMKCMG, DHFHGDGMDKP PCLEEKJMACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75218B0", Offset = "0x7520CB0", VA = "0x1875218B0")]
	private void MEDGOJFEOED(DHFHGDGMDKP DFFIHHMKCMG, DHFHGDGMDKP PCLEEKJMACJ, DHFHGDGMDKP DEFENKPOBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7520240", Offset = "0x751F640", VA = "0x187520240")]
	private void HOKKEHLOHEK(DHFHGDGMDKP DFFIHHMKCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "13")]
	public void PCKKFECIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7520820", Offset = "0x751FC20", VA = "0x187520820", Slot = "14")]
	public void ICLMLJMBJAH(ILPCDBFIODI EKPNEEKDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "15")]
	public void ILNKADBLJLK(ILPCDBFIODI EKPNEEKDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x751E4A0", Offset = "0x751D8A0", VA = "0x18751E4A0", Slot = "17")]
	public void BOKFFPGLBBB(ILPCDBFIODI EKPNEEKDFFI, ILPCDBFIODI MBBHHOOLMHK, Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x751E600", Offset = "0x751DA00", VA = "0x18751E600")]
	public void BOKFFPGLBBB(DHFHGDGMDKP HJDJLPGLCKM, DHFHGDGMDKP MBBHHOOLMHK, Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x751E280", Offset = "0x751D680", VA = "0x18751E280")]
	public void AMDIFPCLKJC(ILPCDBFIODI EKPNEEKDFFI, float KDMIHODHLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7520D10", Offset = "0x7520110", VA = "0x187520D10", Slot = "18")]
	public void IMGLBGFMNCN(ILPCDBFIODI FDFMBDAEBAO, int MOJOBCCOKDP, ILPCDBFIODI JGICCHNECHN, int LCONBBGDPDD, Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7520B20", Offset = "0x751FF20", VA = "0x187520B20")]
	private float IKCBIDBHJFN(DHFHGDGMDKP HJDJLPGLCKM, DHFHGDGMDKP HKNGNFLDPKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7520BD0", Offset = "0x751FFD0", VA = "0x187520BD0")]
	public void IMGLBGFMNCN(DHFHGDGMDKP HJDJLPGLCKM, DHFHGDGMDKP HKNGNFLDPKM, Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA, bool NJAFPGMFLDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x751F5A0", Offset = "0x751E9A0", VA = "0x18751F5A0", Slot = "19")]
	public void GNICAIKLIHJ(ILPCDBFIODI EKPNEEKDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x751EC30", Offset = "0x751E030", VA = "0x18751EC30", Slot = "16")]
	public void DKBGKFMDNJJ(ILPCDBFIODI EKPNEEKDFFI, HashSet<ILPCDBFIODI> JEBBLDGCFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "20")]
	public EECKBFDOJLE GCFOOJNALIK(bool HMLKHDEOILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "21")]
	public EECKBFDOJLE JJMNCPJAOME(HashSet<Guid> DMLHANCGOGF, bool HMLKHDEOILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7521790", Offset = "0x7520B90", VA = "0x187521790", Slot = "23")]
	public void MBDMPEFGNKI(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x751EBC0", Offset = "0x751DFC0", VA = "0x18751EBC0", Slot = "24")]
	public void DFEFEDOMHHN(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x751F710", Offset = "0x751EB10", VA = "0x18751F710", Slot = "25")]
	public void GNPNECLHAOM(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x751FA80", Offset = "0x751EE80", VA = "0x18751FA80")]
	private void HHHLIIAOBMK(DHFHGDGMDKP HJDJLPGLCKM, DHFHGDGMDKP HKNGNFLDPKM, Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA, float KDMIHODHLMD, bool NJAFPGMFLDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7520E70", Offset = "0x7520270", VA = "0x187520E70")]
	private void KANHGGJFDLE(DHFHGDGMDKP HJDJLPGLCKM, DHFHGDGMDKP DDPMGHJOAAI, Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x751EFA0", Offset = "0x751E3A0", VA = "0x18751EFA0")]
	private void FIPCFAOIKAI(DHFHGDGMDKP HJDJLPGLCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x751F7E0", Offset = "0x751EBE0", VA = "0x18751F7E0")]
	[IteratorStateMachine(typeof(NAAOAPAOAND))]
	public IEnumerable<ILPCDBFIODI> HBEMDANMCEE(DHFHGDGMDKP DKAEPFAKBGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7522230", Offset = "0x7521630", VA = "0x187522230")]
	internal ILPCDBFIODI NNEGELNFENM(DHFHGDGMDKP DKAEPFAKBGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7521D10", Offset = "0x7521110", VA = "0x187521D10")]
	internal DHFHGDGMDKP NAJJPBNNLBA(ILPCDBFIODI EKPNEEKDFFI)
	{
		return default(DHFHGDGMDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x751F010", Offset = "0x751E410", VA = "0x18751F010")]
	private bool GBDNANCHIAH(IMOGLCFALMH HGLMIIIBLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x751EB60", Offset = "0x751DF60", VA = "0x18751EB60")]
	private bool CHOOEICDHDB(IMOGLCFALMH HGLMIIIBLAB, [Out] ILPCDBFIODI HKNGNFLDPKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7521EA0", Offset = "0x75212A0", VA = "0x187521EA0")]
	private ILPCDBFIODI NNEGELNFENM(IMOGLCFALMH HGLMIIIBLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x751E930", Offset = "0x751DD30", VA = "0x18751E930")]
	private ILPCDBFIODI CCLIBKKCHGB(IMOGLCFALMH HGLMIIIBLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7520650", Offset = "0x751FA50", VA = "0x187520650")]
	private ILPCDBFIODI IBAILEAELAA(IMOGLCFALMH HGLMIIIBLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7519B00", Offset = "0x7518F00", VA = "0x187519B00")]
	private static Guid KPMPBAFNILH(IMOGLCFALMH HGLMIIIBLAB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7521B70", Offset = "0x7520F70", VA = "0x187521B70")]
	private string MLPLIJAIAJK(IMOGLCFALMH HGLMIIIBLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x751E310", Offset = "0x751D710", VA = "0x18751E310")]
	private void BOHHBJMFIOJ(ILPCDBFIODI HJDJLPGLCKM, ILPCDBFIODI DDPMGHJOAAI, RigidTransform NGECFHBCAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x751FE90", Offset = "0x751F290", VA = "0x18751FE90")]
	private void HLHPIKLOOKK(ILPCDBFIODI DDPMGHJOAAI, ILPCDBFIODI HJDJLPGLCKM, RigidTransform NGECFHBCAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7521B10", Offset = "0x7520F10", VA = "0x187521B10")]
	private void MJOKDBPBNIC(ILPCDBFIODI HFGFDGPFODE, ILPCDBFIODI HJDJLPGLCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7522680", Offset = "0x7521A80", VA = "0x187522680")]
	private void OJNEGHIAFHG(ILPCDBFIODI HJDJLPGLCKM, ILPCDBFIODI HKNGNFLDPKM, RigidTransform NGECFHBCAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x751EE90", Offset = "0x751E290", VA = "0x18751EE90")]
	private void ELEIAECNMPH(DHFHGDGMDKP DKAEPFAKBGE, ILPCDBFIODI EKPNEEKDFFI, DHFHGDGMDKP PCLEEKJMACJ, DHFHGDGMDKP DEFENKPOBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7522810", Offset = "0x7521C10", VA = "0x187522810")]
	private void PIFAFLBIKLF(DHFHGDGMDKP DKAEPFAKBGE, ILPCDBFIODI EKPNEEKDFFI, ILPCDBFIODI JGJFFFEHKCH, ILPCDBFIODI DGMNHFMCLFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PKGBHGHENBI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LPNANFMMAAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LEPFMCICNAK container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LPNANFMMAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x751D820", Offset = "0x751CC20", VA = "0x18751D820")]
		internal MDPKIOJBOFN DNCAAGDEOJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7523AB0", Offset = "0x7522EB0", VA = "0x187523AB0")]
	public static void MLFGCDKIBAD(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7523A60", Offset = "0x7522E60", VA = "0x187523A60")]
	public static void AMJCFPJDHKE(LEPFMCICNAK EOMAFKDOFHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class IGKEGKCJNAK : LIAANJAEFBH, PKNFNMOMJLP
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly RigidbodyEx BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly MDPKIOJBOFN HCJLBAECCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JFDBLFDDOLK KGAKMABCKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly AOODMDFNNCP DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly KANGMMFIGMK[] BADFCGLLJMH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DHFHGDGMDKP HLHCGJDBCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(DHFHGDGMDKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ILPCDBFIODI HHGLGGMEIGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x75177E0", Offset = "0x7516BE0", VA = "0x1875177E0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ILPCDBFIODI NMGAHAMMNNK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7517220", Offset = "0x7516620", VA = "0x187517220", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 GJHDANAOEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7515FA0", Offset = "0x75153A0", VA = "0x187515FA0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion JJNDGLKEOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7515C60", Offset = "0x7515060", VA = "0x187515C60", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LLOIKMINKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7517420", Offset = "0x7516820", VA = "0x187517420", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<ILPCDBFIODI> IEPHLDHHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7515C30", Offset = "0x7515030", VA = "0x187515C30", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool AAOKDNNODAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB07F00", Offset = "0xB07300", VA = "0x180B07F00", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB54B50", Offset = "0xB53F50", VA = "0x180B54B50", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform KCFIKHGOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75179E0", Offset = "0x7516DE0", VA = "0x1875179E0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject ILEPLPIMKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BEB770", Offset = "0x2BEAB70", VA = "0x182BEB770", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7517720", Offset = "0x7516B20", VA = "0x187517720", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid LPNHEMLKGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7517840", Offset = "0x7516C40", VA = "0x187517840", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MLPJPDJCBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7517920", Offset = "0x7516D20", VA = "0x187517920", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool AIDFCLNMFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool CNGNBFCAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7516390", Offset = "0x7515790", VA = "0x187516390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event HDIMDDPDAPO MACLEPKCFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7517160", Offset = "0x7516560", VA = "0x187517160", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x75166C0", Offset = "0x7515AC0", VA = "0x1875166C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HDIMDDPDAPO GNDJPCPJIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7516E50", Offset = "0x7516250", VA = "0x187516E50", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x75171C0", Offset = "0x75165C0", VA = "0x1875171C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HDIMDDPDAPO HBKHDKIHMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7517360", Offset = "0x7516760", VA = "0x187517360", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x75173C0", Offset = "0x75167C0", VA = "0x1875173C0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event ANDHKOKAOBM MPMMEMCIGFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7517490", Offset = "0x7516890", VA = "0x187517490", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7516EB0", Offset = "0x75162B0", VA = "0x187516EB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7517620", Offset = "0x7516A20", VA = "0x187517620")]
	public IGKEGKCJNAK(DHFHGDGMDKP INABPBPJONL, RigidbodyEx BHMMCABJHIL, JFDBLFDDOLK KGAKMABCKBN, KANGMMFIGMK[] BADFCGLLJMH, AOODMDFNNCP DCHKFKLALGC, DIOHDNOMOBA HCJLBAECCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7516000", Offset = "0x7515400", VA = "0x187516000", Slot = "19")]
	public void FDCAHJOBADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "21")]
	public void DAELEAJIGHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72D01B0", Offset = "0x72CF5B0", VA = "0x1872D01B0", Slot = "22")]
	public void NJMBGNBHCOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7515F50", Offset = "0x7515350", VA = "0x187515F50", Slot = "20")]
	public void EDANEBCOOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7516F50", Offset = "0x7516350", VA = "0x187516F50", Slot = "25")]
	public void LKKFBFFHEEP(int ECDHCNPANAN, ILPCDBFIODI JGICCHNECHN, int DOFBCPNKMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7516D30", Offset = "0x7516130", VA = "0x187516D30", Slot = "26")]
	public void HEKCIDGGAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75163E0", Offset = "0x75157E0", VA = "0x1875163E0", Slot = "27")]
	public void GJIMLDAAANC(int ECDHCNPANAN, ILPCDBFIODI FDFMBDAEBAO, int BALMMLDENDN, [Optional] Vector3? GPDJFCMGAKD, [Optional] Quaternion? OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75172E0", Offset = "0x75166E0", VA = "0x1875172E0", Slot = "28")]
	public void NCHAEABFHFD(ILPCDBFIODI FDFMBDAEBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7516920", Offset = "0x7515D20", VA = "0x187516920", Slot = "31")]
	public void HAKBNHGEPKM(Vector3 DDOAOKLMCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7516030", Offset = "0x7515430", VA = "0x187516030", Slot = "29")]
	public void FELCNFKGLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7515CC0", Offset = "0x75150C0", VA = "0x187515CC0", Slot = "30")]
	public void CBPIIFFOBMC(int FFCBHHABFJN, Vector3 PCEPJNOLMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7516850", Offset = "0x7515C50", VA = "0x187516850", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int ECDHCNPANAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7516720", Offset = "0x7515B20", VA = "0x187516720", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int ECDHCNPANAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAE59A0", Offset = "0xAE4DA0", VA = "0x180AE59A0", Slot = "42")]
	public Color GetConnectionSlotColor(int ECDHCNPANAN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7515EB0", Offset = "0x75152B0", VA = "0x187515EB0", Slot = "43")]
	public bool CanConnectTo(int ECDHCNPANAN, ILPCDBFIODI HOFIOIKHOCD, int HKALDABBFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "44")]
	public void ParentChanged(int ECDHCNPANAN, ILPCDBFIODI PAHEKKBGPLE, int EACAHMBPOHA, Vector3 DBBGJLLNAPE, Quaternion BIACMALNFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "45")]
	public void ChildAdded(int ECDHCNPANAN, ILPCDBFIODI FELGDHODEMF, int KBBFMFPHLKA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "46")]
	public void ChildRemoved(int ECDHCNPANAN, ILPCDBFIODI EAPOGPOCNBE, int PFHFHCOHBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "47")]
	public void ConnectionModified(int ECDHCNPANAN, ILPCDBFIODI JGICCHNECHN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7517580", Offset = "0x7516980", VA = "0x187517580", Slot = "48")]
	public void RootChanged(ILPCDBFIODI DPMBBEGLGDJ, ILPCDBFIODI GCOBJMDAGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7516340", Offset = "0x7515740", VA = "0x187516340", Slot = "23")]
	public void FHBPPEOKKKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7517530", Offset = "0x7516930", VA = "0x187517530", Slot = "24")]
	public void PLIEPMEGGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7516E00", Offset = "0x7516200", VA = "0x187516E00")]
	private void HMFCJLDPCOA(bool BHIOMKHKAIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(NKIJHFCGJCO), new string[] { })]
public class JKCDOEFJLNO : NKIJHFCGJCO, FCCMCMPLEOO, KMADININNGI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class HODADAAFPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HODADAAFPKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[DependsOn]
	private KCBHHIMEJLL GDFLHALIOAL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object POHFIAPNPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7517A50", Offset = "0x7516E50", VA = "0x187517A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7517A00", Offset = "0x7516E00", VA = "0x187517A00", Slot = "5")]
	private void AONIDMJBHFK(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xFDAD20", Offset = "0xFDA120", VA = "0x180FDAD20", Slot = "6")]
	private void EGAMOOCMNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public JKCDOEFJLNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(DIOHDNOMOBA), new string[] { "Ignore", "Mock" })]
public class BHMKHPJGEML : DIOHDNOMOBA, JOOHDJKBMLK
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DAOBNBLDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IFJAFJOHLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<ILPCDBFIODI, ILPCDBFIODI> IADFELJMABC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x750FB60", Offset = "0x750EF60", VA = "0x18750FB60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x750FA00", Offset = "0x750EE00", VA = "0x18750FA00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<ILPCDBFIODI, ILPCDBFIODI> ODILNEFBFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x750F950", Offset = "0x750ED50", VA = "0x18750F950", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x750F8A0", Offset = "0x750ECA0", VA = "0x18750F8A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<ILPCDBFIODI, ILPCDBFIODI, ILPCDBFIODI> JFLNJICMECG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x750FAB0", Offset = "0x750EEB0", VA = "0x18750FAB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x750FC10", Offset = "0x750F010", VA = "0x18750FC10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "26")]
	public void CAHNJLIHDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "12")]
	public void OBBALIPJEND(GameObject IIKFCCENKCC, OCJMCPMAMIL KJFFIGCPHJB, FKAGEINKELN LANJGPFGCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "13")]
	public void PCKKFECIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "14")]
	public void ICLMLJMBJAH(ILPCDBFIODI EKPNEEKDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "15")]
	public void ILNKADBLJLK(ILPCDBFIODI EKPNEEKDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "16")]
	public void DKBGKFMDNJJ(ILPCDBFIODI EKPNEEKDFFI, HashSet<ILPCDBFIODI> JEBBLDGCFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "17")]
	public void BOKFFPGLBBB(ILPCDBFIODI EKPNEEKDFFI, ILPCDBFIODI MBBHHOOLMHK, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "18")]
	public void IMGLBGFMNCN(ILPCDBFIODI EKPNEEKDFFI, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "19")]
	public void GNICAIKLIHJ(ILPCDBFIODI EKPNEEKDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "20")]
	public EECKBFDOJLE GCFOOJNALIK(bool HMLKHDEOILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "21")]
	public EECKBFDOJLE JJMNCPJAOME(HashSet<Guid> DMLHANCGOGF, bool HMLKHDEOILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "22")]
	public bool EEFAEGFDAHI(IMOGLCFALMH HGLMIIIBLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "23")]
	public void MBDMPEFGNKI(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "24")]
	public void DFEFEDOMHHN(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "25")]
	public void GNPNECLHAOM(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public BHMKHPJGEML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ILPCDBFIODI : PKNFNMOMJLP, IEquatable<ILPCDBFIODI>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PKNFNMOMJLP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	ILPCDBFIODI HHGLGGMEIGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform KCFIKHGOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject ILEPLPIMKGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid LPNHEMLKGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int MLPJPDJCBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DHFHGDGMDKP HLHCGJDBCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool AIDFCLNMFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int ECDHCNPANAN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int ECDHCNPANAN);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int ECDHCNPANAN);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int ECDHCNPANAN, ILPCDBFIODI HOFIOIKHOCD, int MJNOKDDAANG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int ECDHCNPANAN, ILPCDBFIODI PAHEKKBGPLE, int EACAHMBPOHA, Vector3 DBBGJLLNAPE, Quaternion BIACMALNFPH);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int ECDHCNPANAN, ILPCDBFIODI FELGDHODEMF, int KBBFMFPHLKA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int ECDHCNPANAN, ILPCDBFIODI EAPOGPOCNBE, int PFHFHCOHBHF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int ECDHCNPANAN, ILPCDBFIODI JGICCHNECHN, int HHCPHKEEFPL, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(ILPCDBFIODI DPMBBEGLGDJ, ILPCDBFIODI GCOBJMDAGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DIOHDNOMOBA : JOOHDJKBMLK
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DAOBNBLDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IFJAFJOHLND
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<ILPCDBFIODI, ILPCDBFIODI> IADFELJMABC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<ILPCDBFIODI, ILPCDBFIODI> ODILNEFBFCF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<ILPCDBFIODI, ILPCDBFIODI, ILPCDBFIODI> JFLNJICMECG;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OBBALIPJEND(GameObject IIKFCCENKCC, OCJMCPMAMIL KJFFIGCPHJB, FKAGEINKELN DAMPCFINHMA);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PCKKFECIKBA();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ICLMLJMBJAH(ILPCDBFIODI EKPNEEKDFFI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ILNKADBLJLK(ILPCDBFIODI EKPNEEKDFFI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DKBGKFMDNJJ(ILPCDBFIODI EKPNEEKDFFI, HashSet<ILPCDBFIODI> JEBBLDGCFIH);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BOKFFPGLBBB(ILPCDBFIODI EKPNEEKDFFI, ILPCDBFIODI MBBHHOOLMHK, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IMGLBGFMNCN(ILPCDBFIODI EKPNEEKDFFI, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GNICAIKLIHJ(ILPCDBFIODI EKPNEEKDFFI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	EECKBFDOJLE GCFOOJNALIK(bool HMLKHDEOILP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	EECKBFDOJLE JJMNCPJAOME(HashSet<Guid> DMLHANCGOGF, bool HMLKHDEOILP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EEFAEGFDAHI(IMOGLCFALMH HGLMIIIBLAB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MBDMPEFGNKI(EECKBFDOJLE ADKLABHDFKM);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DFEFEDOMHHN(EECKBFDOJLE ADKLABHDFKM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GNPNECLHAOM(EECKBFDOJLE ADKLABHDFKM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NPBFKOCBJIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool EJIKBACHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ILPCDBFIODI IBAILEAELAA(int LPAMGICLDID);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ILPCDBFIODI CCLIBKKCHGB(Guid HNAAOBGLBEN);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JPGJMPFHFHA(ILPCDBFIODI EKPNEEKDFFI);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IJLDDNOOFKJ();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMEIJIIDAHK(ILPCDBFIODI KGAKMABCKBN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface AOODMDFNNCP
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNGNBFCAKFF(JFDBLFDDOLK KGAKMABCKBN);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHECJMLFBKH(JFDBLFDDOLK KGAKMABCKBN);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string DDKOLAHMBKB(JFDBLFDDOLK KGAKMABCKBN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid BMGCKLAFBMA(JFDBLFDDOLK KGAKMABCKBN);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HHHKOFMGPPB(JFDBLFDDOLK KGAKMABCKBN);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FCACEKBJIFC(JFDBLFDDOLK KGAKMABCKBN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void HDIMDDPDAPO(ILPCDBFIODI FDFMBDAEBAO, int BFBOOBJCPEP, ILPCDBFIODI JGICCHNECHN, int OCEOLFOKCAI, [Optional] Vector3? GPDJFCMGAKD, [Optional] Quaternion? OJEPNOPOOJP);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void ANDHKOKAOBM(ILPCDBFIODI DPMBBEGLGDJ, ILPCDBFIODI GCOBJMDAGAH);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JFDBLFDDOLK : ILPCDBFIODI, PKNFNMOMJLP, IEquatable<ILPCDBFIODI>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LIAANJAEFBH : PKNFNMOMJLP
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	ILPCDBFIODI NMGAHAMMNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<ILPCDBFIODI> IEPHLDHHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 GJHDANAOEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion JJNDGLKEOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool LLOIKMINKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool AAOKDNNODAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event HDIMDDPDAPO MACLEPKCFJA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event HDIMDDPDAPO GNDJPCPJIBE;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HDIMDDPDAPO HBKHDKIHMHM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event ANDHKOKAOBM MPMMEMCIGFA;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FDCAHJOBADK();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EDANEBCOOOB();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DAELEAJIGHO();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NJMBGNBHCOF();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FHBPPEOKKKN();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PLIEPMEGGDP();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LKKFBFFHEEP(int ECDHCNPANAN, ILPCDBFIODI JGICCHNECHN, int DOFBCPNKMMH);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HEKCIDGGAMH();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GJIMLDAAANC(int ECDHCNPANAN, ILPCDBFIODI FDFMBDAEBAO, int BALMMLDENDN, [Optional] Vector3? GPDJFCMGAKD, [Optional] Quaternion? OJEPNOPOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NCHAEABFHFD(ILPCDBFIODI FDFMBDAEBAO);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FELCNFKGLKK();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CBPIIFFOBMC(int FFCBHHABFJN, Vector3 PCEPJNOLMFA);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HAKBNHGEPKM(Vector3 DDOAOKLMCAD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KANGMMFIGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 BOHPNJLDIJE
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
public interface OCJMCPMAMIL
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OFMJOAECANO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DPHGGKBDBOK MENJHBELNEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, OCJMCPMAMIL
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
			[Cpp2IlInjected.Address(RVA = "0xC02DE0", Offset = "0xC021E0", VA = "0x180C02DE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public DPHGGKBDBOK LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7510E60", Offset = "0x7510260", VA = "0x187510E60")]
		public static ConnectableConfigData OCIBBEHHCEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7510F20", Offset = "0x7510320", VA = "0x187510F20")]
		public ConnectableConfigData(LegacyConnectableLinkVisual FAJDGNHAGPD, bool MMFJBABGIJF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PJGFGOHGJPB : IEquatable<PJGFGOHGJPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public ILPCDBFIODI EKPNEEKDFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int ABHPEBOHJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int HHCPHKEEFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 GPDJFCMGAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion OJEPNOPOOJP;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7523A00", Offset = "0x7522E00", VA = "0x187523A00")]
	public PJGFGOHGJPB(ILPCDBFIODI EKPNEEKDFFI, int ABHPEBOHJHB, int HHCPHKEEFPL, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x75238E0", Offset = "0x7522CE0", VA = "0x1875238E0")]
	public PJGFGOHGJPB(ILPCDBFIODI EKPNEEKDFFI, int ABHPEBOHJHB, int HHCPHKEEFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7523980", Offset = "0x7522D80", VA = "0x187523980")]
	public PJGFGOHGJPB(ILPCDBFIODI EKPNEEKDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7523470", Offset = "0x7522870", VA = "0x187523470", Slot = "4")]
	public bool Equals(PJGFGOHGJPB MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7523520", Offset = "0x7522920", VA = "0x187523520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class BBFALJJFDCE : FMBDFLKIJPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform NCNOHDPHPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private DPHGGKBDBOK HGLGBHMFBAO;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6F54730", Offset = "0x6F53B30", VA = "0x186F54730", Slot = "4")]
	public void OBBALIPJEND(Transform NCNOHDPHPJB, DPHGGKBDBOK HGLGBHMFBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x750F770", Offset = "0x750EB70", VA = "0x18750F770", Slot = "5")]
	public DPHGGKBDBOK JOPANBPMFJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x750F830", Offset = "0x750EC30", VA = "0x18750F830", Slot = "6")]
	public void LDNAJELAOJH(DPHGGKBDBOK KDMKAFBKELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public BBFALJJFDCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class LELAHGMGFED : IDisposable, JNDIFIDLEEB
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KFMGEKDBHIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ILPCDBFIODI oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public ILPCDBFIODI newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KFMGEKDBHIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7517B50", Offset = "0x7516F50", VA = "0x187517B50")]
		internal bool DNJPLJGDLAC(LINIOFDEBNL node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly FIOJEFDNJIB IIIPBCJOALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private CDDCIDFMPNB JHJKMHPPOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private FDCPANPANII JLKPPHLJAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool MMFJBABGIJF;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly HLBHMADGLFA GDCELEEEOHD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LINIOFDEBNL JMIAMIHOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x751A7D0", Offset = "0x7519BD0", VA = "0x18751A7D0")]
	public bool KHPOIGLLKJL([In] DOMKLOMJNDI MJFOKKFMONL, bool EBCLMCMPFEH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x751BC80", Offset = "0x751B080", VA = "0x18751BC80")]
	private bool LBAONFFJOHP([In] DOMKLOMJNDI MJFOKKFMONL, bool EBCLMCMPFEH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x751D650", Offset = "0x751CA50", VA = "0x18751D650")]
	public LELAHGMGFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x751C7B0", Offset = "0x751BBB0", VA = "0x18751C7B0", Slot = "5")]
	public void OBBALIPJEND(DIOHDNOMOBA FDIJEKJEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x751ADC0", Offset = "0x751A1C0", VA = "0x18751ADC0", Slot = "17")]
	public void FIMAGIAGPEI(CAIEDLFHMNI LOGLEICCEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x751C860", Offset = "0x751BC60", VA = "0x18751C860", Slot = "12")]
	public void OBFIJFNNHDI(Func<ILPCDBFIODI, bool> DNFPGELLJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x751C870", Offset = "0x751BC70", VA = "0x18751C870")]
	private void OBFIJFNNHDI(FIOJEFDNJIB IKAPMMHHNFM, Func<ILPCDBFIODI, bool> DNFPGELLJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x751BC60", Offset = "0x751B060", VA = "0x18751BC60", Slot = "11")]
	public void KFCFMDAHIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x751BBF0", Offset = "0x751AFF0", VA = "0x18751BBF0", Slot = "8")]
	public bool INCGFIKKLIB(ILPCDBFIODI HEOJPOACIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x751CA00", Offset = "0x751BE00", VA = "0x18751CA00")]
	private bool PBOJGCNPADK(ILPCDBFIODI OLKAAJOPOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x751A590", Offset = "0x7519990", VA = "0x18751A590")]
	private static bool CKMHDBEJKIO(ILPCDBFIODI OLKAAJOPOJI, FIOJEFDNJIB LKLHCLMDAHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x751B030", Offset = "0x751A430", VA = "0x18751B030")]
	private void FKFICINEJGF(Transform LKJDPBBBPEP, FIOJEFDNJIB BEMLICOOCJF, FIOJEFDNJIB[] NHAKKHCKFNB, ILPCDBFIODI MAAKADHKLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x751A680", Offset = "0x7519A80", VA = "0x18751A680")]
	private PJGFGOHGJPB DFGGNLOEHPJ(Transform AJFAJBCBDAL, PJGFGOHGJPB KJDEAGAMKCF)
	{
		return default(PJGFGOHGJPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x751C240", Offset = "0x751B640", VA = "0x18751C240")]
	private static bool LBFBOBMFJON(FIOJEFDNJIB LKLHCLMDAHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x751BC00", Offset = "0x751B000", VA = "0x18751BC00", Slot = "9")]
	public bool INIFDNNBKLK(ILPCDBFIODI JFPOIPGLDJB, int BALMMLDENDN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x751D100", Offset = "0x751C500", VA = "0x18751D100")]
	private bool PHJCOEGOMJO(ILPCDBFIODI JFPOIPGLDJB, int BALMMLDENDN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x751C400", Offset = "0x751B800", VA = "0x18751C400")]
	private static void LPFBAMBGNFM(ILPCDBFIODI JFPOIPGLDJB, int BALMMLDENDN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP, FIOJEFDNJIB GGINJCPPIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x751A470", Offset = "0x7519870", VA = "0x18751A470")]
	private void BOHHBJMFIOJ(ILPCDBFIODI BNFKNGGCAJN, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x751AD50", Offset = "0x751A150", VA = "0x18751AD50")]
	private void EFLKNFEFJOD(FIOJEFDNJIB IKAPMMHHNFM, ILPCDBFIODI JGJFFFEHKCH, ILPCDBFIODI DGMNHFMCLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x751ACE0", Offset = "0x751A0E0", VA = "0x18751ACE0")]
	private void EFLKNFEFJOD(ILPCDBFIODI EKPNEEKDFFI, ILPCDBFIODI JGJFFFEHKCH, ILPCDBFIODI DGMNHFMCLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x751D350", Offset = "0x751C750", VA = "0x18751D350")]
	private void PIFAFLBIKLF(ILPCDBFIODI EKPNEEKDFFI, ILPCDBFIODI JGJFFFEHKCH, ILPCDBFIODI DGMNHFMCLFL, bool LFOEDJFFJHK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x751D3C0", Offset = "0x751C7C0", VA = "0x18751D3C0")]
	private void PIFAFLBIKLF(FIOJEFDNJIB HAIKBOLEOOP, ILPCDBFIODI MAAKADHKLBB, ILPCDBFIODI GCOBJMDAGAH, bool LFOEDJFFJHK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x751B420", Offset = "0x751A820", VA = "0x18751B420")]
	private void HLHPIKLOOKK(ILPCDBFIODI HJDJLPGLCKM, int BALMMLDENDN, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x751C580", Offset = "0x751B980", VA = "0x18751C580")]
	private void MJOKDBPBNIC(LINIOFDEBNL HKNGNFLDPKM, LINIOFDEBNL ENLLOOBJMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x751AB80", Offset = "0x7519F80", VA = "0x18751AB80", Slot = "18")]
	public ILPCDBFIODI DMMIBPJPEPE(ILPCDBFIODI EKPNEEKDFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x751A7E0", Offset = "0x7519BE0", VA = "0x18751A7E0", Slot = "13")]
	public void DKBGKFMDNJJ(ILPCDBFIODI EKPNEEKDFFI, HashSet<ILPCDBFIODI> HCNNDMBAHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x751ADF0", Offset = "0x751A1F0", VA = "0x18751ADF0", Slot = "14")]
	public List<ILPCDBFIODI> FJDDHFGKAJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x751D4C0", Offset = "0x751C8C0", VA = "0x18751D4C0")]
	protected LINIOFDEBNL PPOKHCHDLIO(LINIOFDEBNL IKAPMMHHNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x751A2A0", Offset = "0x75196A0", VA = "0x18751A2A0")]
	protected FIOJEFDNJIB[] BENANPINILK(FIOJEFDNJIB LKLHCLMDAHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x751BAE0", Offset = "0x751AEE0", VA = "0x18751BAE0")]
	protected bool IFFKIKACGKP(ILPCDBFIODI EKPNEEKDFFI, [Out] FIOJEFDNJIB IKAPMMHHNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x751A340", Offset = "0x7519740", VA = "0x18751A340", Slot = "15")]
	public bool BILPFOOMCIO(ILPCDBFIODI EKPNEEKDFFI, [Out] PJGFGOHGJPB AOLCPPHLPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x751A640", Offset = "0x7519A40", VA = "0x18751A640")]
	protected FIOJEFDNJIB DBKGIIHBLMD(PJGFGOHGJPB BMKICNFKDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x751C9A0", Offset = "0x751BDA0", VA = "0x18751C9A0", Slot = "10")]
	public bool OILDBIKEFAG(ILPCDBFIODI BNFKNGGCAJN, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x751B540", Offset = "0x751A940", VA = "0x18751B540")]
	private bool HMIJCGJHANJ(ILPCDBFIODI BNFKNGGCAJN, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x751C6E0", Offset = "0x751BAE0", VA = "0x18751C6E0")]
	private static bool NJHCCBJNIHI(FIOJEFDNJIB PMAILIAEBNN, PJGFGOHGJPB LGKEOCCEMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x751A7D0", Offset = "0x7519BD0", VA = "0x18751A7D0", Slot = "7")]
	private bool DHDMEFDIFHL([In] DOMKLOMJNDI MJFOKKFMONL, bool EBCLMCMPFEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class FAPJEGOACGH : DIOHDNOMOBA, JOOHDJKBMLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly LEPFMCICNAK EOMAFKDOFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly FDCPANPANII JLKPPHLJAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly DIJDHMMKDGN ADGENDJBCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly LBGECAOMIFC DDPCGJLCPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly JNDIFIDLEEB ADKLABHDFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal AIGMGBGGCKD DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal FJMKLCPEPEO BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal CDDCIDFMPNB EKFKMEEFNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool MMFJBABGIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool JBFPBMPKEMM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool AHNDNGLEBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAEEDC0", Offset = "0xAEE1C0", VA = "0x180AEEDC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x10DE750", Offset = "0x10DDB50", VA = "0x1810DE750")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DAOBNBLDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xFD26B0", Offset = "0xFD1AB0", VA = "0x180FD26B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2391BC0", Offset = "0x2390FC0", VA = "0x182391BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IFJAFJOHLND
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<ILPCDBFIODI, ILPCDBFIODI> IADFELJMABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7512900", Offset = "0x7511D00", VA = "0x187512900", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7512140", Offset = "0x7511540", VA = "0x187512140", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<ILPCDBFIODI, ILPCDBFIODI> ODILNEFBFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7511F90", Offset = "0x7511390", VA = "0x187511F90", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7511960", Offset = "0x7510D60", VA = "0x187511960", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<ILPCDBFIODI, ILPCDBFIODI, ILPCDBFIODI> JFLNJICMECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x75128A0", Offset = "0x7511CA0", VA = "0x1875128A0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7512B40", Offset = "0x7511F40", VA = "0x187512B40", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7513220", Offset = "0x7512620", VA = "0x187513220")]
	public FAPJEGOACGH(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7512BA0", Offset = "0x7511FA0", VA = "0x187512BA0", Slot = "12")]
	public void OBBALIPJEND(GameObject IIKFCCENKCC, OCJMCPMAMIL KJFFIGCPHJB, FKAGEINKELN DAMPCFINHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7511890", Offset = "0x7510C90", VA = "0x187511890", Slot = "26")]
	public void CAHNJLIHDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x75131A0", Offset = "0x75125A0", VA = "0x1875131A0", Slot = "13")]
	public void PCKKFECIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x75122B0", Offset = "0x75116B0", VA = "0x1875122B0", Slot = "14")]
	public void ICLMLJMBJAH(ILPCDBFIODI EKPNEEKDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7511D30", Offset = "0x7511130", VA = "0x187511D30", Slot = "15")]
	public void ILNKADBLJLK(ILPCDBFIODI EKPNEEKDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7511B60", Offset = "0x7510F60", VA = "0x187511B60", Slot = "22")]
	public bool EEFAEGFDAHI(IMOGLCFALMH HGLMIIIBLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x75121A0", Offset = "0x75115A0", VA = "0x1875121A0")]
	internal bool HMIJCGJHANJ([In] DOMKLOMJNDI MJFOKKFMONL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7511FF0", Offset = "0x75113F0", VA = "0x187511FF0")]
	internal bool HEPFOMGFCPD([In] DOMKLOMJNDI MJFOKKFMONL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7512960", Offset = "0x7511D60", VA = "0x187512960")]
	internal void NGGAONDIHBJ(ILPCDBFIODI EKPNEEKDFFI, int GDALNJJHFNH, bool EBCLMCMPFEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7511D30", Offset = "0x7511130", VA = "0x187511D30")]
	internal bool GICMBJMMMGK(ILPCDBFIODI FGKGCDENGOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7511540", Offset = "0x7510940", VA = "0x187511540")]
	internal bool BDEPJMENCKD(ILPCDBFIODI JFPOIPGLDJB, int BALMMLDENDN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7511A70", Offset = "0x7510E70", VA = "0x187511A70", Slot = "16")]
	public void DKBGKFMDNJJ(ILPCDBFIODI EKPNEEKDFFI, HashSet<ILPCDBFIODI> JEBBLDGCFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7511680", Offset = "0x7510A80", VA = "0x187511680", Slot = "17")]
	public void BOKFFPGLBBB(ILPCDBFIODI JFPOIPGLDJB, ILPCDBFIODI MBBHHOOLMHK, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x75122D0", Offset = "0x75116D0", VA = "0x1875122D0", Slot = "18")]
	public void IMGLBGFMNCN(ILPCDBFIODI BNFKNGGCAJN, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7511D90", Offset = "0x7511190", VA = "0x187511D90", Slot = "19")]
	public void GNICAIKLIHJ(ILPCDBFIODI BNFKNGGCAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x75125C0", Offset = "0x75119C0", VA = "0x1875125C0")]
	public void LCPLGEFABFF([Optional] HKLPGICCIDE GOEACIANFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7512810", Offset = "0x7511C10", VA = "0x187512810", Slot = "23")]
	public void MBDMPEFGNKI(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7511BB0", Offset = "0x7510FB0", VA = "0x187511BB0", Slot = "20")]
	public EECKBFDOJLE GCFOOJNALIK(bool HMLKHDEOILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7512410", Offset = "0x7511810", VA = "0x187512410", Slot = "21")]
	public EECKBFDOJLE JJMNCPJAOME(HashSet<Guid> DMLHANCGOGF, bool HMLKHDEOILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7511F50", Offset = "0x7511350", VA = "0x187511F50", Slot = "25")]
	public void GNPNECLHAOM(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x75119C0", Offset = "0x7510DC0", VA = "0x1875119C0", Slot = "24")]
	public void DFEFEDOMHHN(EECKBFDOJLE ADKLABHDFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class FDCPANPANII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly EIILHECILIH<ILPCDBFIODI, ILPCDBFIODI> IADFELJMABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly EIILHECILIH<ILPCDBFIODI, ILPCDBFIODI> ODILNEFBFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly KDOINBBPKIH<ILPCDBFIODI, ILPCDBFIODI, ILPCDBFIODI> JFLNJICMECG;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7513750", Offset = "0x7512B50", VA = "0x187513750")]
	public FDCPANPANII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	public void OBBALIPJEND(FAPJEGOACGH FDIJEKJEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7513610", Offset = "0x7512A10", VA = "0x187513610")]
	public void GPICEGLKBMB(ILPCDBFIODI HKNGNFLDPKM, ILPCDBFIODI HJDJLPGLCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7513670", Offset = "0x7512A70", VA = "0x187513670")]
	public void JJJDGGMAHKO(ILPCDBFIODI HKNGNFLDPKM, ILPCDBFIODI HJDJLPGLCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x75136D0", Offset = "0x7512AD0", VA = "0x1875136D0")]
	public void LFGMEPDJLOP(ILPCDBFIODI HFGFDGPFODE, ILPCDBFIODI DDPMGHJOAAI, ILPCDBFIODI HJDJLPGLCKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class DIJDHMMKDGN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private FAPJEGOACGH FDIJEKJEAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private FJMKLCPEPEO BCLILIMLEBK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public DIJDHMMKDGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7511250", Offset = "0x7510650", VA = "0x187511250")]
	public void OBBALIPJEND(FAPJEGOACGH FDIJEKJEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x75110C0", Offset = "0x75104C0", VA = "0x1875110C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7510F70", Offset = "0x7510370", VA = "0x187510F70")]
	private void BBMKHNFGAKB(EKCODMPEECK FDLLGPFCFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x75110D0", Offset = "0x75104D0", VA = "0x1875110D0")]
	private void HBOHENDGLFP(HKLPGICCIDE AMLNFABCAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7511140", Offset = "0x7510540", VA = "0x187511140")]
	public void IKFHKHBDICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7510FB0", Offset = "0x75103B0", VA = "0x187510FB0")]
	public void BEABFDJMGGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class BPLICPMFPMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NELBFLIOACB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LEPFMCICNAK container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NELBFLIOACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x75232C0", Offset = "0x75226C0", VA = "0x1875232C0")]
		internal FAPJEGOACGH DNCAAGDEOJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7510C60", Offset = "0x7510060", VA = "0x187510C60")]
	public static void MLFGCDKIBAD(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7510BE0", Offset = "0x750FFE0", VA = "0x187510BE0")]
	public static void AMJCFPJDHKE(LEPFMCICNAK EOMAFKDOFHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class HOHMIODJPPJ : IDisposable, CDDCIDFMPNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, DPHGGKBDBOK> ABEGAGKKOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CAIEDLFHMNI LKMFHMHANNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private FMBDFLKIJPN FKMNDBNEPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private JNDIFIDLEEB ADKLABHDFKM;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker ANDCPMAJPBJ;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7515B50", Offset = "0x7514F50", VA = "0x187515B50")]
	public HOHMIODJPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7515900", Offset = "0x7514D00", VA = "0x187515900", Slot = "7")]
	public void OBBALIPJEND(JNDIFIDLEEB ADKLABHDFKM, FMBDFLKIJPN FKMNDBNEPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x75156C0", Offset = "0x7514AC0", VA = "0x1875156C0", Slot = "5")]
	public void MNPEBCOCAEG(LINIOFDEBNL ILJPOHENPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x75151E0", Offset = "0x75145E0", VA = "0x1875151E0", Slot = "9")]
	public void FLMPNEDMBJI(LINIOFDEBNL JLHLENMEPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7515500", Offset = "0x7514900", VA = "0x187515500", Slot = "8")]
	public void MJNMOAFDGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7514E90", Offset = "0x7514290", VA = "0x187514E90", Slot = "10")]
	public void CFICIKHGKGB(LINIOFDEBNL PDBLEGIKIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7515350", Offset = "0x7514750", VA = "0x187515350", Slot = "11")]
	public void FOLPDFAPNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7515940", Offset = "0x7514D40", VA = "0x187515940")]
	private bool PBHHFCNCKKL(LINIOFDEBNL AHFGMNBCHCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class LBGECAOMIFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct GJFDLHBAING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly FIOJEFDNJIB JACOGKFEMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> DMLHANCGOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly IMOGLCFALMH IHKKIKCIGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly IMOGLCFALMH LLPLCLOOCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool HMLKHDEOILP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool GDGLLDMGNFM
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7514540", Offset = "0x7513940", VA = "0x187514540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7514C60", Offset = "0x7514060", VA = "0x187514C60")]
		public GJFDLHBAING(FIOJEFDNJIB JACOGKFEMNN, HashSet<Guid> DMLHANCGOGF, bool HMLKHDEOILP, [Optional] IMOGLCFALMH IHKKIKCIGCF, [Optional] IMOGLCFALMH LLPLCLOOCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x75143A0", Offset = "0x75137A0", VA = "0x1875143A0")]
		public IMOGLCFALMH EFGCEHNIDJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x75147C0", Offset = "0x7513BC0", VA = "0x1875147C0")]
		private IMOGLCFALMH KDCFBGFHAOJ([Out] IMOGLCFALMH OLIBBADMBOD, [Out] IMOGLCFALMH AHFNNKIOCPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7514880", Offset = "0x7513C80", VA = "0x187514880")]
		private IMOGLCFALMH MMCAOCCPBPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7514650", Offset = "0x7513A50", VA = "0x187514650")]
		private void IBJIDIOLCJE(IMOGLCFALMH LGOAAKOPDEK, IMOGLCFALMH EKIDBCLJHME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7514AA0", Offset = "0x7513EA0", VA = "0x187514AA0")]
		private void NOGDMADDBCI(IMOGLCFALMH OLIBBADMBOD, IMOGLCFALMH AHFNNKIOCPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private FAPJEGOACGH FDIJEKJEAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private JNDIFIDLEEB ADKLABHDFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private CDDCIDFMPNB JHJKMHPPOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private FJMKLCPEPEO BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool FNGPFOMGBOO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool KEDJJCJEBNE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7518C30", Offset = "0x7518030", VA = "0x187518C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool AHNDNGLEBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7519B40", Offset = "0x7518F40", VA = "0x187519B40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7519560", Offset = "0x7518960", VA = "0x187519560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x751A030", Offset = "0x7519430", VA = "0x18751A030")]
	public void OBBALIPJEND(FAPJEGOACGH FDIJEKJEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7518AC0", Offset = "0x7517EC0", VA = "0x187518AC0")]
	public EECKBFDOJLE GCFOOJNALIK(bool HMLKHDEOILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x75193C0", Offset = "0x75187C0", VA = "0x1875193C0")]
	public EECKBFDOJLE JJMNCPJAOME(HashSet<Guid> DMLHANCGOGF, bool HMLKHDEOILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7519B60", Offset = "0x7518F60", VA = "0x187519B60")]
	public void MBDMPEFGNKI(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7517C40", Offset = "0x7517040", VA = "0x187517C40")]
	public void DFEFEDOMHHN(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7517C10", Offset = "0x7517010", VA = "0x187517C10")]
	public void ANKHPAEMCMA(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7518280", Offset = "0x7517680", VA = "0x187518280")]
	private void FKKKABEPGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7517CE0", Offset = "0x75170E0", VA = "0x187517CE0")]
	private IMOGLCFALMH DPNKCJBLHOC(FIOJEFDNJIB IKAPMMHHNFM, bool HMLKHDEOILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x75190F0", Offset = "0x75184F0", VA = "0x1875190F0")]
	private static void INEGGMEDBGB(FIOJEFDNJIB IKAPMMHHNFM, bool HMLKHDEOILP, IMOGLCFALMH HGLMIIIBLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7518060", Offset = "0x7517460", VA = "0x187518060")]
	private void FDPHNKGHGMD(FIOJEFDNJIB IKAPMMHHNFM, bool HMLKHDEOILP, IMOGLCFALMH HGLMIIIBLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7518E00", Offset = "0x7518200", VA = "0x187518E00")]
	private IMOGLCFALMH IIEIPNHGPHC(FIOJEFDNJIB JACOGKFEMNN, HashSet<Guid> DMLHANCGOGF, bool HMLKHDEOILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7519880", Offset = "0x7518C80", VA = "0x187519880")]
	private bool KPLNNJADMHO(EECKBFDOJLE EBLHCLNKIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7518460", Offset = "0x7517860", VA = "0x187518460")]
	private bool GBDNANCHIAH(IMOGLCFALMH HGLMIIIBLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x75193A0", Offset = "0x75187A0", VA = "0x1875193A0")]
	private bool INKLINAGDLL(EECKBFDOJLE ADKLABHDFKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7519580", Offset = "0x7518980", VA = "0x187519580")]
	private static bool KAKNJBIMAPC(IMOGLCFALMH HGLMIIIBLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7517DD0", Offset = "0x75171D0", VA = "0x187517DD0")]
	public static bool EEFAEGFDAHI(IMOGLCFALMH HGLMIIIBLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7519CE0", Offset = "0x75190E0", VA = "0x187519CE0")]
	private ILPCDBFIODI NNEGELNFENM(IMOGLCFALMH HGLMIIIBLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7518C80", Offset = "0x7518080", VA = "0x187518C80")]
	private ILPCDBFIODI IBAILEAELAA(IMOGLCFALMH HGLMIIIBLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x751A0A0", Offset = "0x75194A0", VA = "0x18751A0A0")]
	private ILPCDBFIODI OEAOAFMGBFM(IMOGLCFALMH HGLMIIIBLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7519B00", Offset = "0x7518F00", VA = "0x187519B00")]
	private static Guid KPMPBAFNILH(IMOGLCFALMH HGLMIIIBLAB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7519BF0", Offset = "0x7518FF0", VA = "0x187519BF0")]
	private string MLPLIJAIAJK(IMOGLCFALMH HGLMIIIBLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7519690", Offset = "0x7518A90", VA = "0x187519690")]
	private bool KLGMNNKHOAP(FIOJEFDNJIB IKAPMMHHNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7518E90", Offset = "0x7518290", VA = "0x187518E90")]
	private static void ILNFIJKNOHN(FIOJEFDNJIB JACOGKFEMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public LBGECAOMIFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct DOMKLOMJNDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public ILPCDBFIODI HJDJLPGLCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public ILPCDBFIODI HKNGNFLDPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int BALMMLDENDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int DOFBCPNKMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 GPDJFCMGAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion OJEPNOPOOJP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public PJGFGOHGJPB LOLCJKNHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7511430", Offset = "0x7510830", VA = "0x187511430")]
		get
		{
			return default(PJGFGOHGJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PJGFGOHGJPB HLCKNBBEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7511400", Offset = "0x7510800", VA = "0x187511400")]
		get
		{
			return default(PJGFGOHGJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x75114D0", Offset = "0x75108D0", VA = "0x1875114D0")]
	public DOMKLOMJNDI(ILPCDBFIODI HJDJLPGLCKM, ILPCDBFIODI HKNGNFLDPKM, int BALMMLDENDN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface JNDIFIDLEEB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LINIOFDEBNL JMIAMIHOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBBALIPJEND(DIOHDNOMOBA FDIJEKJEAKE);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHPOIGLLKJL([In] DOMKLOMJNDI MJFOKKFMONL, bool EBCLMCMPFEH = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool INCGFIKKLIB(ILPCDBFIODI HEOJPOACIHD);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool INIFDNNBKLK(ILPCDBFIODI JFPOIPGLDJB, int BALMMLDENDN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OILDBIKEFAG(ILPCDBFIODI BNFKNGGCAJN, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFCFMDAHIKO();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OBFIJFNNHDI(Func<ILPCDBFIODI, bool> DNFPGELLJMF);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DKBGKFMDNJJ(ILPCDBFIODI EKPNEEKDFFI, HashSet<ILPCDBFIODI> HCNNDMBAHHA);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<ILPCDBFIODI> FJDDHFGKAJJ();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BILPFOOMCIO(ILPCDBFIODI EKPNEEKDFFI, [Out] PJGFGOHGJPB AOLCPPHLPIH);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FIMAGIAGPEI(CAIEDLFHMNI LOGLEICCEGM);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool CAIEDLFHMNI(LINIOFDEBNL IKAPMMHHNFM);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface LINIOFDEBNL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ILPCDBFIODI JGOJNBHOAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LINIOFDEBNL GPOFIBLNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PJGFGOHGJPB ALENGDOKFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool ODPHDKAKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DPHGGKBDBOK
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEKFCHHLHOB(ILPCDBFIODI JGICCHNECHN, PJGFGOHGJPB HJDJLPGLCKM);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIAPHPAEPML(ILPCDBFIODI JGICCHNECHN, PJGFGOHGJPB HJDJLPGLCKM);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBHKGIJFCPE(ILPCDBFIODI JGICCHNECHN, PJGFGOHGJPB HJDJLPGLCKM);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFOJJBCLBIE(ILPCDBFIODI JGICCHNECHN, PJGFGOHGJPB HJDJLPGLCKM);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPHGGKBDBOK Instantiate(Transform NCNOHDPHPJB);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FKLDNICNGJG();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FMBDFLKIJPN
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBBALIPJEND(Transform NCNOHDPHPJB, DPHGGKBDBOK HGLGBHMFBAO);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPHGGKBDBOK JOPANBPMFJP();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LDNAJELAOJH(DPHGGKBDBOK KDMKAFBKELK);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface AIGMGBGGCKD : NPBFKOCBJIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPPIBNLBCJN();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCDPCMOCDGE(Guid MMHINFKMJNK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface CDDCIDFMPNB
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNPEBCOCAEG(LINIOFDEBNL ILJPOHENPGA);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBBALIPJEND(JNDIFIDLEEB ADKLABHDFKM, FMBDFLKIJPN IBPNPPCOPEE);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MJNMOAFDGFC();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLMPNEDMBJI(LINIOFDEBNL JLHLENMEPPA);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFICIKHGKGB(LINIOFDEBNL PDBLEGIKIMN);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FOLPDFAPNDD();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class FIOJEFDNJIB : LINIOFDEBNL
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NPPIJCNNENB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public PJGFGOHGJPB nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FIOJEFDNJIB foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NPPIJCNNENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7523330", Offset = "0x7522730", VA = "0x187523330")]
		internal bool IFPDADDBOGA(LINIOFDEBNL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private PJGFGOHGJPB AOLCPPHLPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<FIOJEFDNJIB> BDIJHLKFMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private FIOJEFDNJIB KDMKKLJGOPD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public PJGFGOHGJPB ALENGDOKFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x10DE300", Offset = "0x10DD700", VA = "0x1810DE300", Slot = "6")]
		get
		{
			return default(PJGFGOHGJPB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x10DDF60", Offset = "0x10DD360", VA = "0x1810DDF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private FIOJEFDNJIB HKNGNFLDPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7513B60", Offset = "0x7512F60", VA = "0x187513B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public LINIOFDEBNL GPOFIBLNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ILPCDBFIODI JGOJNBHOAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ODPHDKAKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x75138C0", Offset = "0x7512CC0", VA = "0x1875138C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KBIOCNDEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7513870", Offset = "0x7512C70", VA = "0x187513870", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected FIOJEFDNJIB HAIKBOLEOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x75139D0", Offset = "0x7512DD0", VA = "0x1875139D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x75142F0", Offset = "0x75136F0", VA = "0x1875142F0")]
	public FIOJEFDNJIB(PJGFGOHGJPB LEHIIMDIPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7513E40", Offset = "0x7513240", VA = "0x187513E40")]
	public FIOJEFDNJIB JNBHLINGEHE(PJGFGOHGJPB DPBCLDEMJLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7513F90", Offset = "0x7513390", VA = "0x187513F90")]
	public FIOJEFDNJIB LGKPBCDLCIA(PJGFGOHGJPB NOJPBDMOJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7514110", Offset = "0x7513510", VA = "0x187514110")]
	public FIOJEFDNJIB PBIACPFCCPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7513CF0", Offset = "0x75130F0", VA = "0x187513CF0")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7513C40", Offset = "0x7513040", VA = "0x187513C40")]
	public FIOJEFDNJIB HNLGAJHJGJG(PJGFGOHGJPB DDPMGHJOAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7513A00", Offset = "0x7512E00", VA = "0x187513A00")]
	private static void FIMAGIAGPEI(FIOJEFDNJIB ODPCKCFALAC, CAIEDLFHMNI IFKMLHMDOLM, bool DMANNFOEJAH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x75139F0", Offset = "0x7512DF0", VA = "0x1875139F0", Slot = "9")]
	public void FIMAGIAGPEI(CAIEDLFHMNI LOGLEICCEGM, bool LFOEDJFFJHK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x75138D0", Offset = "0x7512CD0", VA = "0x1875138D0")]
	public static FIOJEFDNJIB DBKGIIHBLMD(FIOJEFDNJIB ODPCKCFALAC, PJGFGOHGJPB ICDLIIIPDLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface FJMKLCPEPEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool KEDJJCJEBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool EJIKBACHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<EKCODMPEECK> BBMKHNFGAKB;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<HKLPGICCIDE> HBOHENDGLFP;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MEKFCHHLHOB(FAPJEGOACGH FDIJEKJEAKE, FKAGEINKELN LANJGPFGCOB);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BOKFFPGLBBB(ILPCDBFIODI JFPOIPGLDJB, ILPCDBFIODI MBBHHOOLMHK, int BALMMLDENDN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMGLBGFMNCN(ILPCDBFIODI BNFKNGGCAJN, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NOCAPAPMIHC(EECKBFDOJLE OKHPDOADNDF, [Optional] HKLPGICCIDE GOEACIANFNN);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NDJIFENHFGO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type ELLKCGJJEKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7523220", Offset = "0x7522620", VA = "0x187523220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object AJPLFLPAHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7523280", Offset = "0x7522680", VA = "0x187523280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x75231D0", Offset = "0x75225D0", VA = "0x1875231D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class BOAGKEILDMG : FJMKLCPEPEO, IDisposable, NCFCPHOFALI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private FAPJEGOACGH FDIJEKJEAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private FKAGEINKELN DAMPCFINHMA;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KEDJJCJEBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x750FE40", Offset = "0x750F240", VA = "0x18750FE40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool EJIKBACHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x750FF40", Offset = "0x750F340", VA = "0x18750FF40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView ENLEKBFDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x750FEA0", Offset = "0x750F2A0", VA = "0x18750FEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<EKCODMPEECK> BBMKHNFGAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7510280", Offset = "0x750F680", VA = "0x187510280", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7510150", Offset = "0x750F550", VA = "0x187510150", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<HKLPGICCIDE> HBOHENDGLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x750FF80", Offset = "0x750F380", VA = "0x18750FF80", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x75101E0", Offset = "0x750F5E0", VA = "0x1875101E0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7510310", Offset = "0x750F710", VA = "0x187510310", Slot = "10")]
	public void MEKFCHHLHOB(FAPJEGOACGH FDIJEKJEAKE, FKAGEINKELN DAMPCFINHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x750FDF0", Offset = "0x750F1F0", VA = "0x18750FDF0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x750FCC0", Offset = "0x750F0C0", VA = "0x18750FCC0", Slot = "11")]
	public void BOKFFPGLBBB(ILPCDBFIODI JFPOIPGLDJB, ILPCDBFIODI MBBHHOOLMHK, int BALMMLDENDN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7510020", Offset = "0x750F420", VA = "0x187510020", Slot = "12")]
	public void IMGLBGFMNCN(ILPCDBFIODI BNFKNGGCAJN, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x75103A0", Offset = "0x750F7A0", VA = "0x1875103A0", Slot = "13")]
	public void NOCAPAPMIHC(EECKBFDOJLE OKHPDOADNDF, [Optional] HKLPGICCIDE GOEACIANFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7510710", Offset = "0x750FB10", VA = "0x187510710")]
	[OLPIBCJIGLH]
	private void RpcMasterReparentNodes(ILPCDBFIODI BNFKNGGCAJN, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7510510", Offset = "0x750F910", VA = "0x187510510")]
	[OLPIBCJIGLH]
	private void RpcMasterModifyNode(ILPCDBFIODI JFPOIPGLDJB, ILPCDBFIODI MBBHHOOLMHK, int BALMMLDENDN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7510AE0", Offset = "0x750FEE0", VA = "0x187510AE0")]
	[OLPIBCJIGLH]
	private void RpcReparentNodes(ILPCDBFIODI BNFKNGGCAJN, int GCBNINJJDAA, ILPCDBFIODI DDPMGHJOAAI, int EACAHMBPOHA, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP, PAGFBIILLBC BPOKEBMHADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7510A20", Offset = "0x750FE20", VA = "0x187510A20")]
	[OLPIBCJIGLH]
	private void RpcModifyNode(ILPCDBFIODI JFPOIPGLDJB, int BALMMLDENDN, int DOFBCPNKMMH, Vector3 GPDJFCMGAKD, Quaternion OJEPNOPOOJP, PAGFBIILLBC BPOKEBMHADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x75104D0", Offset = "0x750F8D0", VA = "0x1875104D0")]
	[OLPIBCJIGLH]
	private void RpcDeserializeConnectableGraph(EECKBFDOJLE ADKLABHDFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public BOAGKEILDMG()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, DPHGGKBDBOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x751D940", Offset = "0x751CD40", VA = "0x18751D940", Slot = "4")]
		private void GBJMJONBJDK(ILPCDBFIODI JGICCHNECHN, PJGFGOHGJPB HJDJLPGLCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x751DE70", Offset = "0x751D270", VA = "0x18751DE70", Slot = "5")]
		private void OLIDJLCONFF(ILPCDBFIODI JGICCHNECHN, PJGFGOHGJPB HJDJLPGLCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x751DCB0", Offset = "0x751D0B0", VA = "0x18751DCB0", Slot = "6")]
		private void KCNJENNPEDO(ILPCDBFIODI JGICCHNECHN, PJGFGOHGJPB HJDJLPGLCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x751DAC0", Offset = "0x751CEC0", VA = "0x18751DAC0", Slot = "7")]
		private void HAPEFOAEAGD(ILPCDBFIODI JGICCHNECHN, PJGFGOHGJPB HJDJLPGLCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x751D8D0", Offset = "0x751CCD0", VA = "0x18751D8D0", Slot = "8")]
		private DPHGGKBDBOK FKELBELENAM(Transform NCNOHDPHPJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x751DE10", Offset = "0x751D210", VA = "0x18751DE10", Slot = "9")]
		private void KGDLACFGIJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class JFIHEFPMIPP
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x351B0A0", Offset = "0x351A4A0", VA = "0x18351B0A0")]
	public static AHCLDOEBAPN<T> FGGMJEIMOAD<T>(this LEPFMCICNAK EOMAFKDOFHE)
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
