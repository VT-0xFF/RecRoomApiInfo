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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73E52A0", Offset = "0x73E3EA0", VA = "0x1873E52A0", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x73EBE20", Offset = "0x73EAA20", VA = "0x1873EBE20", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73EB980", Offset = "0x73EA580", VA = "0x1873EB980")]
		private void MPLOOPBCFDI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73EB810", Offset = "0x73EA410", VA = "0x1873EB810")]
		private void GLOJJDDILEC(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73EBAF0", Offset = "0x73EA6F0", VA = "0x1873EBAF0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73EBE60", Offset = "0x73EAA60", VA = "0x1873EBE60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class CBLOHALAJAI : NIPGPNECFKB, PPOHJMEPICJ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PHILCDKECEA : IEnumerable<JHDJHDKFFOE>, IEnumerable, IEnumerator<JHDJHDKFFOE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private JHDJHDKFFOE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private OJMCCDFHBJG localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OJMCCDFHBJG <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CBLOHALAJAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private JCGKMOCONDO <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OMGFNECLCEJ <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private OMGFNECLCEJ.GDHHFODINGE <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private JHDJHDKFFOE System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public PHILCDKECEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x73EB520", Offset = "0x73EA120", VA = "0x1873EB520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x73EB0C0", Offset = "0x73E9CC0", VA = "0x1873EB0C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x73EB080", Offset = "0x73E9C80", VA = "0x1873EB080")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x73EB0A0", Offset = "0x73E9CA0", VA = "0x1873EB0A0")]
		private void BENEFBJOBNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x73EB4D0", Offset = "0x73EA0D0", VA = "0x1873EB4D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73EB420", Offset = "0x73EA020", VA = "0x1873EB420", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JHDJHDKFFOE> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x73EB420", Offset = "0x73EA020", VA = "0x1873EB420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ABCGANIOFPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public CBLOHALAJAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CBPBFKPJEMN nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public ABCGANIOFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x73D6D40", Offset = "0x73D5940", VA = "0x1873D6D40")]
		internal object KDCLBMBOBEI(CBPBFKPJEMN x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PDABMOIOHMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CBPBFKPJEMN child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ABCGANIOFPK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PDABMOIOHMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x73EAE30", Offset = "0x73E9A30", VA = "0x1873EAE30")]
		internal object IFPJPJKFEDK((CBPBFKPJEMN child, CBPBFKPJEMN nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly NDNFAPMFFIF FELNKHBOCFC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly NDNFAPMFFIF CDKMNDACOMH;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly NDNFAPMFFIF ODLFFBLHCAE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly NDNFAPMFFIF PNDIOOMJJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private NBNNMFACLOB PLCHIEAAOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BFCGPAEHKNA IFJIIPEPJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private JJLPEBMBDPJ DPPIJJGOBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private KFNDIGPCLCM JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private NEOCDLGJFLO IAMPAJLOAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IFKNHGHGOLD CHJFHCEJGHO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LIANHAMAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA9BC40", Offset = "0xA9A840", VA = "0x180A9BC40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA9A700", Offset = "0xA99300", VA = "0x180A9A700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FJDEDMBKDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<JHDJHDKFFOE, JHDJHDKFFOE> GJLIDAFBHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x73D8840", Offset = "0x73D7440", VA = "0x1873D8840", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73D8B00", Offset = "0x73D7700", VA = "0x1873D8B00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<JHDJHDKFFOE, JHDJHDKFFOE> JKKFNEOJEAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x73D7020", Offset = "0x73D5C20", VA = "0x1873D7020", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73D9DA0", Offset = "0x73D89A0", VA = "0x1873D9DA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<JHDJHDKFFOE, JHDJHDKFFOE, JHDJHDKFFOE> DJDOJBKMIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x73D7260", Offset = "0x73D5E60", VA = "0x1873D7260", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x73DA0F0", Offset = "0x73D8CF0", VA = "0x1873DA0F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x73DB770", Offset = "0x73DA370", VA = "0x1873DB770")]
	public CBLOHALAJAI(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x73D6DB0", Offset = "0x73D59B0", VA = "0x1873D6DB0", Slot = "12")]
	public void AIMKJDEKJHN(GameObject PHPLOOLODCB, NGGBLPLCAGJ DLGPLGMIHDG, DIMMMCLADKM DAHPADKNCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x73D8E50", Offset = "0x73D7A50", VA = "0x1873D8E50", Slot = "26")]
	public void GMJHFFLJMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x73D7C50", Offset = "0x73D6850", VA = "0x1873D7C50", Slot = "22")]
	public bool EENMFIFCEND(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x73D91D0", Offset = "0x73D7DD0", VA = "0x1873D91D0")]
	private void HIIIHPDCECD(OJMCCDFHBJG NAIEOHIJFHK, OJMCCDFHBJG DDDFNGDFKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x73D7620", Offset = "0x73D6220", VA = "0x1873D7620")]
	private void EANGCIANAEG(OJMCCDFHBJG NAIEOHIJFHK, OJMCCDFHBJG ILNGLAOHHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x73D9860", Offset = "0x73D8460", VA = "0x1873D9860")]
	private void IIDPEKJLIIA(OJMCCDFHBJG NAIEOHIJFHK, OJMCCDFHBJG ILNGLAOHHKL, OJMCCDFHBJG DDDFNGDFKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x73D7840", Offset = "0x73D6440", VA = "0x1873D7840")]
	private void EDDHPAFLMIP(OJMCCDFHBJG NAIEOHIJFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "13")]
	public void KAFGFLAKMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x73D7310", Offset = "0x73D5F10", VA = "0x1873D7310", Slot = "14")]
	public void CHOGICNNBDH(JHDJHDKFFOE AKLAICMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "15")]
	public void MKLJCELBDDO(JHDJHDKFFOE AKLAICMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x73D8BB0", Offset = "0x73D77B0", VA = "0x1873D8BB0", Slot = "17")]
	public void GMEFEIBIJKN(JHDJHDKFFOE AKLAICMBCOK, JHDJHDKFFOE CEHCBLINDLP, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x73D8D10", Offset = "0x73D7910", VA = "0x1873D8D10")]
	public void GMEFEIBIJKN(OJMCCDFHBJG DEDKLMDDBBA, OJMCCDFHBJG CEHCBLINDLP, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x73DA2A0", Offset = "0x73D8EA0", VA = "0x1873DA2A0")]
	public void LKLFBAOHOPJ(JHDJHDKFFOE AKLAICMBCOK, float CBPAGEIDANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x73D7DE0", Offset = "0x73D69E0", VA = "0x1873D7DE0", Slot = "18")]
	public void EEOFOPFGAJE(JHDJHDKFFOE NKKIBMPBDON, int APDBEMFMDME, JHDJHDKFFOE PCDMFIFHBNH, int JEAPIAEHNPH, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x73DB570", Offset = "0x73DA170", VA = "0x1873DB570")]
	private float PNIBMGMHAEN(OJMCCDFHBJG DEDKLMDDBBA, OJMCCDFHBJG KOIBCEOILEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x73D7CA0", Offset = "0x73D68A0", VA = "0x1873D7CA0")]
	public void EEOFOPFGAJE(OJMCCDFHBJG DEDKLMDDBBA, OJMCCDFHBJG KOIBCEOILEL, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ, bool CBPKMJPOMEH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x73D9560", Offset = "0x73D8160", VA = "0x1873D9560", Slot = "19")]
	public void IANPKACKDGI(JHDJHDKFFOE AKLAICMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x73D88F0", Offset = "0x73D74F0", VA = "0x1873D88F0", Slot = "16")]
	public void FJIJNHKMKKE(JHDJHDKFFOE AKLAICMBCOK, HashSet<JHDJHDKFFOE> GPPGLPPDEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "20")]
	public MBJGAHEFDMD EBKKDMBIPJK(bool AOCKCLGDMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "21")]
	public MBJGAHEFDMD HINAHFIAMIP(HashSet<Guid> BPNDGPMCJIO, bool AOCKCLGDMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x73DA230", Offset = "0x73D8E30", VA = "0x1873DA230", Slot = "23")]
	public void LHMKEKHPNEE(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x73DB340", Offset = "0x73D9F40", VA = "0x1873DB340", Slot = "24")]
	public void NJAPDHBNPMD(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x73DA330", Offset = "0x73D8F30", VA = "0x1873DA330", Slot = "25")]
	public void MCJAKHENFOI(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x73D84D0", Offset = "0x73D70D0", VA = "0x1873D84D0")]
	private void FBBAFBLDKOM(OJMCCDFHBJG DEDKLMDDBBA, OJMCCDFHBJG KOIBCEOILEL, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ, float CBPAGEIDANI, bool CBPKMJPOMEH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x73DAA20", Offset = "0x73D9620", VA = "0x1873DAA20")]
	private void NGLMIMALOFK(OJMCCDFHBJG DEDKLMDDBBA, OJMCCDFHBJG BDHPANPFDPF, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x73DB4A0", Offset = "0x73DA0A0", VA = "0x1873DB4A0")]
	private void PJNGEHKCBJA(OJMCCDFHBJG DEDKLMDDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x73DA1A0", Offset = "0x73D8DA0", VA = "0x1873DA1A0")]
	[IteratorStateMachine(typeof(PHILCDKECEA))]
	public IEnumerable<JHDJHDKFFOE> KOHMJDJKBGI(OJMCCDFHBJG JKOPHJKJLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x73DA8F0", Offset = "0x73D94F0", VA = "0x1873DA8F0")]
	internal JHDJHDKFFOE NFFMPGEHCIF(OJMCCDFHBJG JKOPHJKJLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x73D9040", Offset = "0x73D7C40", VA = "0x1873D9040")]
	internal OJMCCDFHBJG HCNIEKPEEAF(JHDJHDKFFOE AKLAICMBCOK)
	{
		return default(OJMCCDFHBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x73D7F40", Offset = "0x73D6B40", VA = "0x1873D7F40")]
	private bool EMAACIJONLO(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x73D9AC0", Offset = "0x73D86C0", VA = "0x1873D9AC0")]
	private bool IKLCBJLIANG(CBPBFKPJEMN HDBPBMNJNAE, [Out] JHDJHDKFFOE KOIBCEOILEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73DA560", Offset = "0x73D9160", VA = "0x1873DA560")]
	private JHDJHDKFFOE NFFMPGEHCIF(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x73D96D0", Offset = "0x73D82D0", VA = "0x1873D96D0")]
	private JHDJHDKFFOE IBABAJEELKL(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x73DA390", Offset = "0x73D8F90", VA = "0x1873DA390")]
	private JHDJHDKFFOE MNEBPFIFIMG(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x73DA350", Offset = "0x73D8F50", VA = "0x1873DA350")]
	private static Guid MLPGPNJMJNB(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x73DB3B0", Offset = "0x73D9FB0", VA = "0x1873DB3B0")]
	private string PBBNNNBKGCC(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x73D93D0", Offset = "0x73D7FD0", VA = "0x1873D93D0")]
	private void HLAJCEAGHBD(JHDJHDKFFOE DEDKLMDDBBA, JHDJHDKFFOE BDHPANPFDPF, RigidTransform EHFLCNPKDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x73D70D0", Offset = "0x73D5CD0", VA = "0x1873D70D0")]
	private void BEGIEPLIIJF(JHDJHDKFFOE BDHPANPFDPF, JHDJHDKFFOE DEDKLMDDBBA, RigidTransform EHFLCNPKDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x73DB510", Offset = "0x73DA110", VA = "0x1873DB510")]
	private void PLFOLOPDKJH(JHDJHDKFFOE MHNGCBODOJP, JHDJHDKFFOE DEDKLMDDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73D9E50", Offset = "0x73D8A50", VA = "0x1873D9E50")]
	private void KHEBOLPHAHG(JHDJHDKFFOE DEDKLMDDBBA, JHDJHDKFFOE KOIBCEOILEL, RigidTransform EHFLCNPKDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x73D9FE0", Offset = "0x73D8BE0", VA = "0x1873D9FE0")]
	private void KJPNDDAJEBL(OJMCCDFHBJG JKOPHJKJLOL, JHDJHDKFFOE AKLAICMBCOK, OJMCCDFHBJG ILNGLAOHHKL, OJMCCDFHBJG DDDFNGDFKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x73D9B20", Offset = "0x73D8720", VA = "0x1873D9B20")]
	private void JJFAFLDOPLE(OJMCCDFHBJG JKOPHJKJLOL, JHDJHDKFFOE AKLAICMBCOK, JHDJHDKFFOE FIMHFEEBPLE, JHDJHDKFFOE JBLNPFGIKHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OFOGAAIJEFH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EEFIPJEPJIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KPLLBHIBBNH container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public EEFIPJEPJIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x73DD920", Offset = "0x73DC520", VA = "0x1873DD920")]
		internal CBLOHALAJAI DJOMCDLMNNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x73EA570", Offset = "0x73E9170", VA = "0x1873EA570")]
	public static void NFMHINFHOBK(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x73EA6F0", Offset = "0x73E92F0", VA = "0x1873EA6F0")]
	public static void NGCOMLKGGGA(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class COLLIOLECHD : NPODGCNJCCL, EEDMKEAAIMG
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly RigidbodyEx PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly CBLOHALAJAI COJFEIEGHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly MOJIIACGNHA GNBCPMDIALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly DOIOCIBLPIJ JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly ICOCMEHAPHE[] IANEOBFFPNH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JHDJHDKFFOE BEEPJGJJDLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x73DD3B0", Offset = "0x73DBFB0", VA = "0x1873DD3B0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JHDJHDKFFOE JOLCLJGJHID
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x73DB9C0", Offset = "0x73DA5C0", VA = "0x1873DB9C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 FAGPBPOBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x73DBFB0", Offset = "0x73DABB0", VA = "0x1873DBFB0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion NCOGNPNJOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x73DCBF0", Offset = "0x73DB7F0", VA = "0x1873DCBF0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IGJCPCMANEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x73DB7E0", Offset = "0x73DA3E0", VA = "0x1873DB7E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<JHDJHDKFFOE> GEGFKEPMNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x73DD0B0", Offset = "0x73DBCB0", VA = "0x1873DD0B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool FBKEILIMEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAB3FB0", Offset = "0xAB2BB0", VA = "0x180AB3FB0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAE9AC0", Offset = "0xAE86C0", VA = "0x180AE9AC0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x73DD5C0", Offset = "0x73DC1C0", VA = "0x1873DD5C0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject FOFMPGFPBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B633C0", Offset = "0x2B61FC0", VA = "0x182B633C0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x73DD2E0", Offset = "0x73DBEE0", VA = "0x1873DD2E0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid GLAPPOPNDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x73DD410", Offset = "0x73DC010", VA = "0x1873DD410", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JLKPJNDIKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x73DD4F0", Offset = "0x73DC0F0", VA = "0x1873DD4F0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HJCLJDJKFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool NDJMOFANMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x73DC420", Offset = "0x73DB020", VA = "0x1873DC420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event DAOIJHJMAOM BJAMFHKGNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x73DBA80", Offset = "0x73DA680", VA = "0x1873DBA80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x73DC010", Offset = "0x73DAC10", VA = "0x1873DC010", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event DAOIJHJMAOM ADLNKBGPBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x73DCAF0", Offset = "0x73DB6F0", VA = "0x1873DCAF0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x73DCA90", Offset = "0x73DB690", VA = "0x1873DCA90", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event DAOIJHJMAOM KHFEPJICFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x73DD0E0", Offset = "0x73DBCE0", VA = "0x1873DD0E0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x73DD050", Offset = "0x73DBC50", VA = "0x1873DD050", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event LODNJOEMIOB HJDBACLJFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x73DC070", Offset = "0x73DAC70", VA = "0x1873DC070", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x73DCFB0", Offset = "0x73DBBB0", VA = "0x1873DCFB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x73DD1E0", Offset = "0x73DBDE0", VA = "0x1873DD1E0")]
	public COLLIOLECHD(OJMCCDFHBJG KJFLIOABFFB, RigidbodyEx PPJMBNBBIOK, MOJIIACGNHA GNBCPMDIALH, ICOCMEHAPHE[] IANEOBFFPNH, DOIOCIBLPIJ JOHAHHCBBCJ, NIPGPNECFKB COJFEIEGHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x73DB8F0", Offset = "0x73DA4F0", VA = "0x1873DB8F0", Slot = "19")]
	public void DKEOJGLDIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "21")]
	public void MGFICLCGDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x71FBD80", Offset = "0x71FA980", VA = "0x1871FBD80", Slot = "22")]
	public void IMOAJNGJPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x73DCBA0", Offset = "0x73DB7A0", VA = "0x1873DCBA0", Slot = "20")]
	public void MEKDGOPFPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73DC880", Offset = "0x73DB480", VA = "0x1873DC880", Slot = "25")]
	public void LJFDBIOEFBA(int BLLDGEOBAAE, JHDJHDKFFOE PCDMFIFHBNH, int KCHPPEDAMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x73DBEE0", Offset = "0x73DAAE0", VA = "0x1873DBEE0", Slot = "26")]
	public void HFPBIPJHCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x73DCC50", Offset = "0x73DB850", VA = "0x1873DCC50", Slot = "27")]
	public void MJOBJFBMGFP(int BLLDGEOBAAE, JHDJHDKFFOE NKKIBMPBDON, int GGAIGEOHNHI, [Optional] Vector3? JKEOCFELGEH, [Optional] Quaternion? BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x73DCF30", Offset = "0x73DBB30", VA = "0x1873DCF30", Slot = "28")]
	public void MLJLBBIHNLD(JHDJHDKFFOE NKKIBMPBDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x73DC470", Offset = "0x73DB070", VA = "0x1873DC470", Slot = "31")]
	public void LGANMCJDLGP(Vector3 GMCBCIEBJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x73DC110", Offset = "0x73DAD10", VA = "0x1873DC110", Slot = "29")]
	public void KNMGLKBGEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x73DBCE0", Offset = "0x73DA8E0", VA = "0x1873DBCE0", Slot = "30")]
	public void HBDGOMHAJIM(int BIEEMEKMINN, Vector3 CHHMDBOKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x73DBC10", Offset = "0x73DA810", VA = "0x1873DBC10", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int BLLDGEOBAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x73DBAE0", Offset = "0x73DA6E0", VA = "0x1873DBAE0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int BLLDGEOBAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA90DF0", Offset = "0xA8F9F0", VA = "0x180A90DF0", Slot = "42")]
	public Color GetConnectionSlotColor(int BLLDGEOBAAE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x73DB850", Offset = "0x73DA450", VA = "0x1873DB850", Slot = "43")]
	public bool CanConnectTo(int BLLDGEOBAAE, JHDJHDKFFOE HCKIHDABLIL, int IOFMIACJCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "44")]
	public void ParentChanged(int BLLDGEOBAAE, JHDJHDKFFOE JAHFKHDPIJN, int NPHKLBFFCMM, Vector3 MOBKPHCDFMB, Quaternion OLNKJBFHNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "45")]
	public void ChildAdded(int BLLDGEOBAAE, JHDJHDKFFOE LPEFCBDJLCN, int PGDCNABKCOA, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "46")]
	public void ChildRemoved(int BLLDGEOBAAE, JHDJHDKFFOE GGLAOMMBLFH, int LOCFDIDJPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "47")]
	public void ConnectionModified(int BLLDGEOBAAE, JHDJHDKFFOE PCDMFIFHBNH, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x73DD140", Offset = "0x73DBD40", VA = "0x1873DD140", Slot = "48")]
	public void RootChanged(JHDJHDKFFOE EJLNNLOOIAE, JHDJHDKFFOE DIEPBFPAIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x73DB920", Offset = "0x73DA520", VA = "0x1873DB920", Slot = "23")]
	public void DOFDNDDGKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x73DB970", Offset = "0x73DA570", VA = "0x1873DB970", Slot = "24")]
	public void EGHPANMGEGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x73DCB50", Offset = "0x73DB750", VA = "0x1873DCB50")]
	private void MDAIOAFAFLA(bool MABHEMPFJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(OPHOBJGEAKL), new string[] { })]
public class KNMEKNONPPI : OPHOBJGEAKL, EPCACDHCPJF, KKIFGLMKOAD
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LNDMOAADHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public LNDMOAADHPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[DependsOn]
	private NCGIDMDNHJD ENEHENBPLMA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object MCHLKABPDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x73E4930", Offset = "0x73E3530", VA = "0x1873E4930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73E49C0", Offset = "0x73E35C0", VA = "0x1873E49C0", Slot = "5")]
	private void KOFKNPJJNIF(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xF73A20", Offset = "0xF72620", VA = "0x180F73A20", Slot = "6")]
	private void KNGPAJOOJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public KNMEKNONPPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(NIPGPNECFKB), new string[] { "Ignore", "Mock" })]
public class HHHHPPNDAHJ : NIPGPNECFKB, PPOHJMEPICJ
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LIANHAMAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FJDEDMBKDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<JHDJHDKFFOE, JHDJHDKFFOE> GJLIDAFBHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x73E1020", Offset = "0x73DFC20", VA = "0x1873E1020", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x73E10D0", Offset = "0x73DFCD0", VA = "0x1873E10D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<JHDJHDKFFOE, JHDJHDKFFOE> JKKFNEOJEAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x73E0EC0", Offset = "0x73DFAC0", VA = "0x1873E0EC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x73E1180", Offset = "0x73DFD80", VA = "0x1873E1180", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<JHDJHDKFFOE, JHDJHDKFFOE, JHDJHDKFFOE> DJDOJBKMIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x73E0F70", Offset = "0x73DFB70", VA = "0x1873E0F70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x73E1230", Offset = "0x73DFE30", VA = "0x1873E1230", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "26")]
	public void GMJHFFLJMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "12")]
	public void AIMKJDEKJHN(GameObject PHPLOOLODCB, NGGBLPLCAGJ DLGPLGMIHDG, DIMMMCLADKM DJEEMGGBLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "13")]
	public void KAFGFLAKMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "14")]
	public void CHOGICNNBDH(JHDJHDKFFOE AKLAICMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "15")]
	public void MKLJCELBDDO(JHDJHDKFFOE AKLAICMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "16")]
	public void FJIJNHKMKKE(JHDJHDKFFOE AKLAICMBCOK, HashSet<JHDJHDKFFOE> GPPGLPPDEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "17")]
	public void GMEFEIBIJKN(JHDJHDKFFOE AKLAICMBCOK, JHDJHDKFFOE CEHCBLINDLP, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "18")]
	public void EEOFOPFGAJE(JHDJHDKFFOE AKLAICMBCOK, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "19")]
	public void IANPKACKDGI(JHDJHDKFFOE AKLAICMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "20")]
	public MBJGAHEFDMD EBKKDMBIPJK(bool AOCKCLGDMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "21")]
	public MBJGAHEFDMD HINAHFIAMIP(HashSet<Guid> BPNDGPMCJIO, bool AOCKCLGDMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "22")]
	public bool EENMFIFCEND(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "23")]
	public void LHMKEKHPNEE(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "24")]
	public void NJAPDHBNPMD(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "25")]
	public void MCJAKHENFOI(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public HHHHPPNDAHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHDJHDKFFOE : EEDMKEAAIMG, IEquatable<JHDJHDKFFOE>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EEDMKEAAIMG
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JHDJHDKFFOE BEEPJGJJDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject FOFMPGFPBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid GLAPPOPNDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int JLKPJNDIKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HJCLJDJKFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int BLLDGEOBAAE);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int BLLDGEOBAAE);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int BLLDGEOBAAE);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int BLLDGEOBAAE, JHDJHDKFFOE HCKIHDABLIL, int GMIPLDGOOJG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int BLLDGEOBAAE, JHDJHDKFFOE JAHFKHDPIJN, int NPHKLBFFCMM, Vector3 MOBKPHCDFMB, Quaternion OLNKJBFHNFD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int BLLDGEOBAAE, JHDJHDKFFOE LPEFCBDJLCN, int PGDCNABKCOA, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int BLLDGEOBAAE, JHDJHDKFFOE GGLAOMMBLFH, int LOCFDIDJPEM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int BLLDGEOBAAE, JHDJHDKFFOE PCDMFIFHBNH, int OEGEMFHDIHI, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(JHDJHDKFFOE EJLNNLOOIAE, JHDJHDKFFOE DIEPBFPAIGK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NIPGPNECFKB : PPOHJMEPICJ
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LIANHAMAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FJDEDMBKDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<JHDJHDKFFOE, JHDJHDKFFOE> GJLIDAFBHHA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JHDJHDKFFOE, JHDJHDKFFOE> JKKFNEOJEAG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JHDJHDKFFOE, JHDJHDKFFOE, JHDJHDKFFOE> DJDOJBKMIHA;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AIMKJDEKJHN(GameObject PHPLOOLODCB, NGGBLPLCAGJ DLGPLGMIHDG, DIMMMCLADKM BHLGFKAEOGE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KAFGFLAKMPI();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CHOGICNNBDH(JHDJHDKFFOE AKLAICMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MKLJCELBDDO(JHDJHDKFFOE AKLAICMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FJIJNHKMKKE(JHDJHDKFFOE AKLAICMBCOK, HashSet<JHDJHDKFFOE> GPPGLPPDEPM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GMEFEIBIJKN(JHDJHDKFFOE AKLAICMBCOK, JHDJHDKFFOE CEHCBLINDLP, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EEOFOPFGAJE(JHDJHDKFFOE AKLAICMBCOK, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IANPKACKDGI(JHDJHDKFFOE AKLAICMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MBJGAHEFDMD EBKKDMBIPJK(bool AOCKCLGDMDP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MBJGAHEFDMD HINAHFIAMIP(HashSet<Guid> BPNDGPMCJIO, bool AOCKCLGDMDP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EENMFIFCEND(CBPBFKPJEMN HDBPBMNJNAE);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LHMKEKHPNEE(MBJGAHEFDMD GGBMBLFEJIF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NJAPDHBNPMD(MBJGAHEFDMD GGBMBLFEJIF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MCJAKHENFOI(MBJGAHEFDMD GGBMBLFEJIF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KFNDIGPCLCM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool AAFFOOJAEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JHDJHDKFFOE MNEBPFIFIMG(int FOIDGOHENEH);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JHDJHDKFFOE IBABAJEELKL(Guid MBFAONOFCDA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GAHCKOKMJNF(JHDJHDKFFOE AKLAICMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KHGBBFGCKKJ();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCAGPHFEBCA(JHDJHDKFFOE GNBCPMDIALH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface DOIOCIBLPIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDJMOFANMCE(MOJIIACGNHA GNBCPMDIALH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIGCCCNKAPL(MOJIIACGNHA GNBCPMDIALH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string GCGCIKAAENB(MOJIIACGNHA GNBCPMDIALH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid LKPMDGKKEIO(MOJIIACGNHA GNBCPMDIALH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NNDAKHOJAFA(MOJIIACGNHA GNBCPMDIALH);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OHLIBLBLMBI(MOJIIACGNHA GNBCPMDIALH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void DAOIJHJMAOM(JHDJHDKFFOE NKKIBMPBDON, int MANDAGEEFDD, JHDJHDKFFOE PCDMFIFHBNH, int EDFJIBCKGLB, [Optional] Vector3? JKEOCFELGEH, [Optional] Quaternion? BOMOEFFKLHC);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void LODNJOEMIOB(JHDJHDKFFOE EJLNNLOOIAE, JHDJHDKFFOE DIEPBFPAIGK);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MOJIIACGNHA : JHDJHDKFFOE, EEDMKEAAIMG, IEquatable<JHDJHDKFFOE>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NPODGCNJCCL : EEDMKEAAIMG
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JHDJHDKFFOE JOLCLJGJHID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<JHDJHDKFFOE> GEGFKEPMNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 FAGPBPOBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion NCOGNPNJOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool IGJCPCMANEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FBKEILIMEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event DAOIJHJMAOM BJAMFHKGNOA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event DAOIJHJMAOM ADLNKBGPBKB;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event DAOIJHJMAOM KHFEPJICFIJ;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event LODNJOEMIOB HJDBACLJFKN;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DKEOJGLDIFP();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MEKDGOPFPIM();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MGFICLCGDNE();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IMOAJNGJPLB();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DOFDNDDGKBB();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EGHPANMGEGA();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LJFDBIOEFBA(int BLLDGEOBAAE, JHDJHDKFFOE PCDMFIFHBNH, int KCHPPEDAMDK);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HFPBIPJHCDI();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MJOBJFBMGFP(int BLLDGEOBAAE, JHDJHDKFFOE NKKIBMPBDON, int GGAIGEOHNHI, [Optional] Vector3? JKEOCFELGEH, [Optional] Quaternion? BOMOEFFKLHC);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MLJLBBIHNLD(JHDJHDKFFOE NKKIBMPBDON);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void KNMGLKBGEAC();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HBDGOMHAJIM(int BIEEMEKMINN, Vector3 CHHMDBOKADH);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LGANMCJDLGP(Vector3 GMCBCIEBJHE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ICOCMEHAPHE
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 FAOKOKPDHMB
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
public interface NGGBLPLCAGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool LMLHDHKMFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EAPPOBEFHEI MEEIDDIBCOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, NGGBLPLCAGJ
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
			[Cpp2IlInjected.Address(RVA = "0xBB8D00", Offset = "0xBB7900", VA = "0x180BB8D00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public EAPPOBEFHEI LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x73DD5E0", Offset = "0x73DC1E0", VA = "0x1873DD5E0")]
		public static ConnectableConfigData PFALJDFDCNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x73DD6A0", Offset = "0x73DC2A0", VA = "0x1873DD6A0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual ONCHGJDAFNH, bool EHPDFHAPHEB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OIGNINLFHBM : IEquatable<OIGNINLFHBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public JHDJHDKFFOE AKLAICMBCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int MOLBMOPPCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int OEGEMFHDIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 JKEOCFELGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion BOMOEFFKLHC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x73EABC0", Offset = "0x73E97C0", VA = "0x1873EABC0")]
	public OIGNINLFHBM(JHDJHDKFFOE AKLAICMBCOK, int MOLBMOPPCBL, int OEGEMFHDIHI, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x73EAC20", Offset = "0x73E9820", VA = "0x1873EAC20")]
	public OIGNINLFHBM(JHDJHDKFFOE AKLAICMBCOK, int MOLBMOPPCBL, int OEGEMFHDIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x73EACC0", Offset = "0x73E98C0", VA = "0x1873EACC0")]
	public OIGNINLFHBM(JHDJHDKFFOE AKLAICMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x73EA740", Offset = "0x73E9340", VA = "0x1873EA740", Slot = "4")]
	public bool Equals(OIGNINLFHBM PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x73EA7F0", Offset = "0x73E93F0", VA = "0x1873EA7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class EKFBDPGGCBP : BLJFBBPKCFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform FDCDPIOJPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EAPPOBEFHEI IBGNEABLPPN;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E6CA70", Offset = "0x6E6B670", VA = "0x186E6CA70", Slot = "4")]
	public void AIMKJDEKJHN(Transform FDCDPIOJPOG, EAPPOBEFHEI IBGNEABLPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x73DDA40", Offset = "0x73DC640", VA = "0x1873DDA40", Slot = "5")]
	public EAPPOBEFHEI HDBDDADNGHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x73DD9D0", Offset = "0x73DC5D0", VA = "0x1873DD9D0", Slot = "6")]
	public void CGHDNBMGKMF(EAPPOBEFHEI AHLNEFKMLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public EKFBDPGGCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class OCMKJIPPEJF : IDisposable, OIHJODLENEP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MLCHBECOBBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public JHDJHDKFFOE oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public JHDJHDKFFOE newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public MLCHBECOBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x73E5FE0", Offset = "0x73E4BE0", VA = "0x1873E5FE0")]
		internal bool DNBENJDOKEE(FMFNDGOEKBB node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly NBDMHCIFKJO EOKJLIALLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private DLHNBHHGNFH OBDBEHINMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MAGBDDKAFJC IFDKMFMNDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool EHPDFHAPHEB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly NDNFAPMFFIF APOKKLEHJOA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public FMFNDGOEKBB JHCLOFMDCND
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x73E9580", Offset = "0x73E8180", VA = "0x1873E9580")]
	public bool LKPDNEPFDPE([In] KJHDMBCEJHP LLDJIJICLJF, bool KAINMELCIJI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x73E7EE0", Offset = "0x73E6AE0", VA = "0x1873E7EE0")]
	private bool FECAMKNNGIG([In] KJHDMBCEJHP LLDJIJICLJF, bool KAINMELCIJI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x73E9F80", Offset = "0x73E8B80", VA = "0x1873E9F80")]
	public OCMKJIPPEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x73E6BD0", Offset = "0x73E57D0", VA = "0x1873E6BD0", Slot = "5")]
	public void AIMKJDEKJHN(NIPGPNECFKB JHBOJJACLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x73E96E0", Offset = "0x73E82E0", VA = "0x1873E96E0", Slot = "17")]
	public void NONMNGKIELB(DAMGKCOMOPD DKDPAFJDNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x73E8A40", Offset = "0x73E7640", VA = "0x1873E8A40", Slot = "12")]
	public void GANNDFCCJJF(Func<JHDJHDKFFOE, bool> IPHBDMHKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x73E8910", Offset = "0x73E7510", VA = "0x1873E8910")]
	private void GANNDFCCJJF(NBDMHCIFKJO PCMPEACCDMA, Func<JHDJHDKFFOE, bool> IPHBDMHKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x73E7E60", Offset = "0x73E6A60", VA = "0x1873E7E60", Slot = "11")]
	public void CMIEPPHDNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x73E9DD0", Offset = "0x73E89D0", VA = "0x1873E9DD0", Slot = "8")]
	public bool PMGPHBJBFOE(JHDJHDKFFOE HGLCKCIMFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x73E6C80", Offset = "0x73E5880", VA = "0x1873E6C80")]
	private bool ANPHIPNIFDO(JHDJHDKFFOE GPFNIMGNCNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x73E94D0", Offset = "0x73E80D0", VA = "0x1873E94D0")]
	private static bool KONLCHMEGID(JHDJHDKFFOE GPFNIMGNCNO, NBDMHCIFKJO JHFPIKMFJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x73E90F0", Offset = "0x73E7CF0", VA = "0x1873E90F0")]
	private void KJCPANNLPEI(Transform BBPFBPBENNG, NBDMHCIFKJO HLGCMLDCEME, NBDMHCIFKJO[] OBMLKPDDLPJ, JHDJHDKFFOE PKHNKCMDILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x73E9590", Offset = "0x73E8190", VA = "0x1873E9590")]
	private OIGNINLFHBM NLJCADOCCCF(Transform FJLODGANFPA, OIGNINLFHBM APAEKOAKHAN)
	{
		return default(OIGNINLFHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x73E8CB0", Offset = "0x73E78B0", VA = "0x1873E8CB0")]
	private static bool JEDHCBFKJGN(NBDMHCIFKJO JHFPIKMFJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x73E7E80", Offset = "0x73E6A80", VA = "0x1873E7E80", Slot = "9")]
	public bool EFDAENDEFNL(JHDJHDKFFOE OHBIDNIEDDA, int GGAIGEOHNHI, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x73E9950", Offset = "0x73E8550", VA = "0x1873E9950")]
	private bool PGKIBHLHLKF(JHDJHDKFFOE OHBIDNIEDDA, int GGAIGEOHNHI, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x73E7CE0", Offset = "0x73E68E0", VA = "0x1873E7CE0")]
	private static void CKPJJPANIED(JHDJHDKFFOE OHBIDNIEDDA, int GGAIGEOHNHI, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC, NBDMHCIFKJO NLCHMIABEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x73E8B50", Offset = "0x73E7750", VA = "0x1873E8B50")]
	private void HLAJCEAGHBD(JHDJHDKFFOE HDAJBMBFNOL, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x73E9DE0", Offset = "0x73E89E0", VA = "0x1873E9DE0")]
	private void PPMPMNCJLON(NBDMHCIFKJO PCMPEACCDMA, JHDJHDKFFOE FIMHFEEBPLE, JHDJHDKFFOE JBLNPFGIKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x73E9E50", Offset = "0x73E8A50", VA = "0x1873E9E50")]
	private void PPMPMNCJLON(JHDJHDKFFOE AKLAICMBCOK, JHDJHDKFFOE FIMHFEEBPLE, JHDJHDKFFOE JBLNPFGIKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x73E8F70", Offset = "0x73E7B70", VA = "0x1873E8F70")]
	private void JJFAFLDOPLE(JHDJHDKFFOE AKLAICMBCOK, JHDJHDKFFOE FIMHFEEBPLE, JHDJHDKFFOE JBLNPFGIKHB, bool BBIHPHNLENK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x73E8E70", Offset = "0x73E7A70", VA = "0x1873E8E70")]
	private void JJFAFLDOPLE(NBDMHCIFKJO EBMDCHEPJIM, JHDJHDKFFOE PKHNKCMDILA, JHDJHDKFFOE DIEPBFPAIGK, bool BBIHPHNLENK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x73E74C0", Offset = "0x73E60C0", VA = "0x1873E74C0")]
	private void BEGIEPLIIJF(JHDJHDKFFOE DEDKLMDDBBA, int GGAIGEOHNHI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x73E9BA0", Offset = "0x73E87A0", VA = "0x1873E9BA0")]
	private void PLFOLOPDKJH(FMFNDGOEKBB KOIBCEOILEL, FMFNDGOEKBB IBGHDDMHLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x73E75E0", Offset = "0x73E61E0", VA = "0x1873E75E0", Slot = "18")]
	public JHDJHDKFFOE BIOMLMGHLGF(JHDJHDKFFOE AKLAICMBCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x73E84A0", Offset = "0x73E70A0", VA = "0x1873E84A0", Slot = "13")]
	public void FJIJNHKMKKE(JHDJHDKFFOE AKLAICMBCOK, HashSet<JHDJHDKFFOE> AMMBIACFLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x73E9710", Offset = "0x73E8310", VA = "0x1873E9710", Slot = "14")]
	public List<JHDJHDKFFOE> OADKHAIIGBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x73E8840", Offset = "0x73E7440", VA = "0x1873E8840")]
	protected FMFNDGOEKBB FNEMCAFEFNA(FMFNDGOEKBB PCMPEACCDMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x73E8A50", Offset = "0x73E7650", VA = "0x1873E8A50")]
	protected NBDMHCIFKJO[] GKLHFFKBBOF(NBDMHCIFKJO JHFPIKMFJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x73E8FE0", Offset = "0x73E7BE0", VA = "0x1873E8FE0")]
	protected bool JJONEHIKPBP(JHDJHDKFFOE AKLAICMBCOK, [Out] NBDMHCIFKJO PCMPEACCDMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x73E7390", Offset = "0x73E5F90", VA = "0x1873E7390", Slot = "15")]
	public bool BCJMCPHPKMB(JHDJHDKFFOE AKLAICMBCOK, [Out] OIGNINLFHBM PKLFMNLEDPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x73E8C70", Offset = "0x73E7870", VA = "0x1873E8C70")]
	protected NBDMHCIFKJO HMJNNCHJMGE(OIGNINLFHBM JPGMGBCABPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x73E8AF0", Offset = "0x73E76F0", VA = "0x1873E8AF0", Slot = "10")]
	public bool GNFAFMOKCMP(JHDJHDKFFOE HDAJBMBFNOL, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x73E7740", Offset = "0x73E6340", VA = "0x1873E7740")]
	private bool BPIPMEDNLGF(JHDJHDKFFOE HDAJBMBFNOL, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x73E9D00", Offset = "0x73E8900", VA = "0x1873E9D00")]
	private static bool PLMGODOLFEH(NBDMHCIFKJO BBCEHLCKCCL, OIGNINLFHBM JIHIBBLBFEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x73E9580", Offset = "0x73E8180", VA = "0x1873E9580", Slot = "7")]
	private bool MNLNDBDONIL([In] KJHDMBCEJHP LLDJIJICLJF, bool KAINMELCIJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class GNCGOCMBGIF : NIPGPNECFKB, PPOHJMEPICJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly KPLLBHIBBNH AGGFAPJEEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly MAGBDDKAFJC IFDKMFMNDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly OEJBKMAHDHI PAECCENPCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly KMKHLNMJAJB BJLFJOAKLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly OIHJODLENEP GGBMBLFEJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal CMLBJGPEBOM JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal IGNCNIBFMAE CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal DLHNBHHGNFH FDMNCPPNEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool EHPDFHAPHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool POFFODBCMAH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool OCLKLCKKOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA98A80", Offset = "0xA97680", VA = "0x180A98A80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1075E10", Offset = "0x1074A10", VA = "0x181075E10")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LIANHAMAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xF569D0", Offset = "0xF555D0", VA = "0x180F569D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x22DCB70", Offset = "0x22DB770", VA = "0x1822DCB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FJDEDMBKDLO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JHDJHDKFFOE, JHDJHDKFFOE> GJLIDAFBHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x73DE910", Offset = "0x73DD510", VA = "0x1873DE910", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x73DEA70", Offset = "0x73DD670", VA = "0x1873DEA70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JHDJHDKFFOE, JHDJHDKFFOE> JKKFNEOJEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x73DE410", Offset = "0x73DD010", VA = "0x1873DE410", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x73DF5D0", Offset = "0x73DE1D0", VA = "0x1873DF5D0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JHDJHDKFFOE, JHDJHDKFFOE, JHDJHDKFFOE> DJDOJBKMIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x73DE580", Offset = "0x73DD180", VA = "0x1873DE580", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x73DF630", Offset = "0x73DE230", VA = "0x1873DF630", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x73DF940", Offset = "0x73DE540", VA = "0x1873DF940")]
	public GNCGOCMBGIF(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x73DDC50", Offset = "0x73DC850", VA = "0x1873DDC50", Slot = "12")]
	public void AIMKJDEKJHN(GameObject PHPLOOLODCB, NGGBLPLCAGJ DLGPLGMIHDG, DIMMMCLADKM BHLGFKAEOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x73DECE0", Offset = "0x73DD8E0", VA = "0x1873DECE0", Slot = "26")]
	public void GMJHFFLJMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x73DF550", Offset = "0x73DE150", VA = "0x1873DF550", Slot = "13")]
	public void KAFGFLAKMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x73DE5E0", Offset = "0x73DD1E0", VA = "0x1873DE5E0", Slot = "14")]
	public void CHOGICNNBDH(JHDJHDKFFOE AKLAICMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x73DE3B0", Offset = "0x73DCFB0", VA = "0x1873DE3B0", Slot = "15")]
	public void MKLJCELBDDO(JHDJHDKFFOE AKLAICMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x73DE780", Offset = "0x73DD380", VA = "0x1873DE780", Slot = "22")]
	public bool EENMFIFCEND(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x73DE470", Offset = "0x73DD070", VA = "0x1873DE470")]
	internal bool BPIPMEDNLGF([In] KJHDMBCEJHP LLDJIJICLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x73DE260", Offset = "0x73DCE60", VA = "0x1873DE260")]
	internal bool AMKOCNDFJPP([In] KJHDMBCEJHP LLDJIJICLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x73DF370", Offset = "0x73DDF70", VA = "0x1873DF370")]
	internal void INICKJMCFHD(JHDJHDKFFOE AKLAICMBCOK, int GKMIDPLMCMM, bool KAINMELCIJI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x73DE3B0", Offset = "0x73DCFB0", VA = "0x1873DE3B0")]
	internal bool AODPHJIGPLG(JHDJHDKFFOE NNDCJJGEBKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x73DF810", Offset = "0x73DE410", VA = "0x1873DF810")]
	internal bool PIPANLDIGNB(JHDJHDKFFOE OHBIDNIEDDA, int GGAIGEOHNHI, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x73DE970", Offset = "0x73DD570", VA = "0x1873DE970", Slot = "16")]
	public void FJIJNHKMKKE(JHDJHDKFFOE AKLAICMBCOK, HashSet<JHDJHDKFFOE> GPPGLPPDEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x73DEAD0", Offset = "0x73DD6D0", VA = "0x1873DEAD0", Slot = "17")]
	public void GMEFEIBIJKN(JHDJHDKFFOE OHBIDNIEDDA, JHDJHDKFFOE CEHCBLINDLP, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x73DE7D0", Offset = "0x73DD3D0", VA = "0x1873DE7D0", Slot = "18")]
	public void EEOFOPFGAJE(JHDJHDKFFOE HDAJBMBFNOL, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x73DF1A0", Offset = "0x73DDDA0", VA = "0x1873DF1A0", Slot = "19")]
	public void IANPKACKDGI(JHDJHDKFFOE HDAJBMBFNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x73DEDB0", Offset = "0x73DD9B0", VA = "0x1873DEDB0")]
	public void HEANJJKADHC([Optional] NIHEANECFCA LFKGAEHPCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x73DF690", Offset = "0x73DE290", VA = "0x1873DF690", Slot = "23")]
	public void LHMKEKHPNEE(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x73DE600", Offset = "0x73DD200", VA = "0x1873DE600", Slot = "20")]
	public MBJGAHEFDMD EBKKDMBIPJK(bool AOCKCLGDMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x73DF000", Offset = "0x73DDC00", VA = "0x1873DF000", Slot = "21")]
	public MBJGAHEFDMD HINAHFIAMIP(HashSet<Guid> BPNDGPMCJIO, bool AOCKCLGDMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x73DF720", Offset = "0x73DE320", VA = "0x1873DF720", Slot = "25")]
	public void MCJAKHENFOI(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x73DF760", Offset = "0x73DE360", VA = "0x1873DF760", Slot = "24")]
	public void NJAPDHBNPMD(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class MAGBDDKAFJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly NFIBJPEHBKM<JHDJHDKFFOE, JHDJHDKFFOE> GJLIDAFBHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly NFIBJPEHBKM<JHDJHDKFFOE, JHDJHDKFFOE> JKKFNEOJEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly MJGEHAGLALK<JHDJHDKFFOE, JHDJHDKFFOE, JHDJHDKFFOE> DJDOJBKMIHA;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x73E5580", Offset = "0x73E4180", VA = "0x1873E5580")]
	public MAGBDDKAFJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	public void AIMKJDEKJHN(GNCGOCMBGIF JHBOJJACLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x73E54C0", Offset = "0x73E40C0", VA = "0x1873E54C0")]
	public void KBAMKLEKJFF(JHDJHDKFFOE KOIBCEOILEL, JHDJHDKFFOE DEDKLMDDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x73E5520", Offset = "0x73E4120", VA = "0x1873E5520")]
	public void OAMKOGOMKCO(JHDJHDKFFOE KOIBCEOILEL, JHDJHDKFFOE DEDKLMDDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x73E5440", Offset = "0x73E4040", VA = "0x1873E5440")]
	public void EDPGIDJIFFH(JHDJHDKFFOE MHNGCBODOJP, JHDJHDKFFOE BDHPANPFDPF, JHDJHDKFFOE DEDKLMDDBBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class OEJBKMAHDHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private GNCGOCMBGIF JHBOJJACLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private IGNCNIBFMAE CDOHCPAIEHP;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public OEJBKMAHDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x73EA150", Offset = "0x73E8D50", VA = "0x1873EA150")]
	public void AIMKJDEKJHN(GNCGOCMBGIF JHBOJJACLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x73EA290", Offset = "0x73E8E90", VA = "0x1873EA290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x73EA530", Offset = "0x73E9130", VA = "0x1873EA530")]
	private void PNJHOLPAEGG(GEDEGCEHLJI GMOJJMIJPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x73EA3B0", Offset = "0x73E8FB0", VA = "0x1873EA3B0")]
	private void IOLDOLDCCHA(NIHEANECFCA OBEGOENJFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x73EA2A0", Offset = "0x73E8EA0", VA = "0x1873EA2A0")]
	public void IFPNNMKKIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x73EA420", Offset = "0x73E9020", VA = "0x1873EA420")]
	public void LBKBGDJNLEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class HBFCLPMKBGG
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DFJGGJPLDIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KPLLBHIBBNH container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public DFJGGJPLDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x73DD8B0", Offset = "0x73DC4B0", VA = "0x1873DD8B0")]
		internal GNCGOCMBGIF DJOMCDLMNNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x73E0C40", Offset = "0x73DF840", VA = "0x1873E0C40")]
	public static void NFMHINFHOBK(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x73E0E40", Offset = "0x73DFA40", VA = "0x1873E0E40")]
	public static void NGCOMLKGGGA(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class KGPODHPPDGD : IDisposable, DLHNBHHGNFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, EAPPOBEFHEI> CLGGCOKFMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly DAMGKCOMOPD MGGBENDHLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private BLJFBBPKCFD LNIKHLPMKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private OIHJODLENEP GGBMBLFEJIF;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker EPBPKGNHHPN;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x73E2000", Offset = "0x73E0C00", VA = "0x1873E2000")]
	public KGPODHPPDGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x73E12E0", Offset = "0x73DFEE0", VA = "0x1873E12E0", Slot = "7")]
	public void AIMKJDEKJHN(OIHJODLENEP GGBMBLFEJIF, BLJFBBPKCFD LNIKHLPMKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x73E1690", Offset = "0x73E0290", VA = "0x1873E1690", Slot = "5")]
	public void ICFMPILIEGN(FMFNDGOEKBB NNCDPHMKCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x73E1E30", Offset = "0x73E0A30", VA = "0x1873E1E30", Slot = "9")]
	public void NPCKAKBPNKO(FMFNDGOEKBB BIHHODLOOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x73E1320", Offset = "0x73DFF20", VA = "0x1873E1320", Slot = "8")]
	public void GEEALLGAGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x73E1AE0", Offset = "0x73E06E0", VA = "0x1873E1AE0", Slot = "10")]
	public void NCBCFCPLFIG(FMFNDGOEKBB LKKJGOICDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x73E1930", Offset = "0x73E0530", VA = "0x1873E1930", Slot = "11")]
	public void JMFFJAGJLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x73E14E0", Offset = "0x73E00E0", VA = "0x1873E14E0")]
	private bool HHHIIOJKPGF(FMFNDGOEKBB MHDGHBLPNDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class KMKHLNMJAJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct MEJEKLOGLFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly NBDMHCIFKJO GJALCJLHDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> BPNDGPMCJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly CBPBFKPJEMN FCPPNNBIPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly CBPBFKPJEMN GGMPKKDFHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool AOCKCLGDMDP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool IIKONINFDML
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x73E56A0", Offset = "0x73E42A0", VA = "0x1873E56A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x73E5F70", Offset = "0x73E4B70", VA = "0x1873E5F70")]
		public MEJEKLOGLFJ(NBDMHCIFKJO GJALCJLHDNC, HashSet<Guid> BPNDGPMCJIO, bool AOCKCLGDMDP, [Optional] CBPBFKPJEMN FCPPNNBIPBA, [Optional] CBPBFKPJEMN GGMPKKDFHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x73E57C0", Offset = "0x73E43C0", VA = "0x1873E57C0")]
		public CBPBFKPJEMN DHDDBDHCOJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x73E5AD0", Offset = "0x73E46D0", VA = "0x1873E5AD0")]
		private CBPBFKPJEMN JHCJKFANHHL([Out] CBPBFKPJEMN FBEFOLMEPIO, [Out] CBPBFKPJEMN BCJJJOMEBOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x73E5B90", Offset = "0x73E4790", VA = "0x1873E5B90")]
		private CBPBFKPJEMN KGBLNKGJMHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x73E5960", Offset = "0x73E4560", VA = "0x1873E5960")]
		private void HNFPIBBJMCK(CBPBFKPJEMN CCLDLOIPIGK, CBPBFKPJEMN GPCNAELLGBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x73E5DB0", Offset = "0x73E49B0", VA = "0x1873E5DB0")]
		private void OOOHGANBDGE(CBPBFKPJEMN FBEFOLMEPIO, CBPBFKPJEMN BCJJJOMEBOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private GNCGOCMBGIF JHBOJJACLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private OIHJODLENEP GGBMBLFEJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private DLHNBHHGNFH OBDBEHINMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private IGNCNIBFMAE CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool JGOAGFBHLJC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool FLNAPMDEODF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x73E3970", Offset = "0x73E2570", VA = "0x1873E3970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool OCLKLCKKOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x73E37B0", Offset = "0x73E23B0", VA = "0x1873E37B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x73E25F0", Offset = "0x73E11F0", VA = "0x1873E25F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x73E2220", Offset = "0x73E0E20", VA = "0x1873E2220")]
	public void AIMKJDEKJHN(GNCGOCMBGIF JHBOJJACLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x73E2610", Offset = "0x73E1210", VA = "0x1873E2610")]
	public MBJGAHEFDMD EBKKDMBIPJK(bool AOCKCLGDMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x73E37D0", Offset = "0x73E23D0", VA = "0x1873E37D0")]
	public MBJGAHEFDMD HINAHFIAMIP(HashSet<Guid> BPNDGPMCJIO, bool AOCKCLGDMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x73E3E10", Offset = "0x73E2A10", VA = "0x1873E3E10")]
	public void LHMKEKHPNEE(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x73E4570", Offset = "0x73E3170", VA = "0x1873E4570")]
	public void NJAPDHBNPMD(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x73E47A0", Offset = "0x73E33A0", VA = "0x1873E47A0")]
	public void OFFBDNLFDOK(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x73E3EA0", Offset = "0x73E2AA0", VA = "0x1873E3EA0")]
	private void MDDFCGDBEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x73E3BE0", Offset = "0x73E27E0", VA = "0x1873E3BE0")]
	private CBPBFKPJEMN KJCMCKOKPFN(NBDMHCIFKJO PCMPEACCDMA, bool AOCKCLGDMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x73E2290", Offset = "0x73E0E90", VA = "0x1873E2290")]
	private static void CLGBEEIJCMK(NBDMHCIFKJO PCMPEACCDMA, bool AOCKCLGDMDP, CBPBFKPJEMN HDBPBMNJNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x73E3590", Offset = "0x73E2190", VA = "0x1873E3590")]
	private void GPJIGOAHPDJ(NBDMHCIFKJO PCMPEACCDMA, bool AOCKCLGDMDP, CBPBFKPJEMN HDBPBMNJNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x73E39C0", Offset = "0x73E25C0", VA = "0x1873E39C0")]
	private CBPBFKPJEMN JEJFJEGABCK(NBDMHCIFKJO GJALCJLHDNC, HashSet<Guid> BPNDGPMCJIO, bool AOCKCLGDMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x73E2A10", Offset = "0x73E1610", VA = "0x1873E2A10")]
	private bool EFNHBBANJAI(MBJGAHEFDMD EAFFKCEOACB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x73E2CA0", Offset = "0x73E18A0", VA = "0x1873E2CA0")]
	private bool EMAACIJONLO(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x73E3310", Offset = "0x73E1F10", VA = "0x1873E3310")]
	private bool FGIINNNAEMN(MBJGAHEFDMD GGBMBLFEJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x73E24E0", Offset = "0x73E10E0", VA = "0x1873E24E0")]
	private static bool CNNBLGDJJDC(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x73E2780", Offset = "0x73E1380", VA = "0x1873E2780")]
	public static bool EENMFIFCEND(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x73E4210", Offset = "0x73E2E10", VA = "0x1873E4210")]
	private JHDJHDKFFOE NFFMPGEHCIF(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x73E4090", Offset = "0x73E2C90", VA = "0x1873E4090")]
	private JHDJHDKFFOE MNEBPFIFIMG(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x73E3A50", Offset = "0x73E2650", VA = "0x1873E3A50")]
	private JHDJHDKFFOE KHIJBFPAFJD(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x73DA350", Offset = "0x73D8F50", VA = "0x1873DA350")]
	private static Guid MLPGPNJMJNB(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x73E47D0", Offset = "0x73E33D0", VA = "0x1873E47D0")]
	private string PBBNNNBKGCC(CBPBFKPJEMN HDBPBMNJNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x73E4610", Offset = "0x73E3210", VA = "0x1873E4610")]
	private bool OCCLBOEMIEP(NBDMHCIFKJO PCMPEACCDMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x73E3330", Offset = "0x73E1F30", VA = "0x1873E3330")]
	private static void GDAFGJGELBE(NBDMHCIFKJO GJALCJLHDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public KMKHLNMJAJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct KJHDMBCEJHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public JHDJHDKFFOE DEDKLMDDBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public JHDJHDKFFOE KOIBCEOILEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int GGAIGEOHNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int KCHPPEDAMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 JKEOCFELGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion BOMOEFFKLHC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public OIGNINLFHBM ENGGLJHLNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x73E2110", Offset = "0x73E0D10", VA = "0x1873E2110")]
		get
		{
			return default(OIGNINLFHBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OIGNINLFHBM EABNANDDLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x73E20E0", Offset = "0x73E0CE0", VA = "0x1873E20E0")]
		get
		{
			return default(OIGNINLFHBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x73E21B0", Offset = "0x73E0DB0", VA = "0x1873E21B0")]
	public KJHDMBCEJHP(JHDJHDKFFOE DEDKLMDDBBA, JHDJHDKFFOE KOIBCEOILEL, int GGAIGEOHNHI, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface OIHJODLENEP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FMFNDGOEKBB JHCLOFMDCND
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIMKJDEKJHN(NIPGPNECFKB JHBOJJACLJB);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LKPDNEPFDPE([In] KJHDMBCEJHP LLDJIJICLJF, bool KAINMELCIJI = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PMGPHBJBFOE(JHDJHDKFFOE HGLCKCIMFKJ);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EFDAENDEFNL(JHDJHDKFFOE OHBIDNIEDDA, int GGAIGEOHNHI, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GNFAFMOKCMP(JHDJHDKFFOE HDAJBMBFNOL, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CMIEPPHDNPE();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GANNDFCCJJF(Func<JHDJHDKFFOE, bool> IPHBDMHKNNM);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FJIJNHKMKKE(JHDJHDKFFOE AKLAICMBCOK, HashSet<JHDJHDKFFOE> AMMBIACFLKD);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<JHDJHDKFFOE> OADKHAIIGBL();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BCJMCPHPKMB(JHDJHDKFFOE AKLAICMBCOK, [Out] OIGNINLFHBM PKLFMNLEDPM);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NONMNGKIELB(DAMGKCOMOPD DKDPAFJDNNF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool DAMGKCOMOPD(FMFNDGOEKBB PCMPEACCDMA);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface FMFNDGOEKBB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JHDJHDKFFOE IBKICKANPML
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	FMFNDGOEKBB HNLFKIAHAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OIGNINLFHBM BINDBHIKOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool KFIAKKOOBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface EAPPOBEFHEI : JJJBBNHMIFL.NEEFIEJPFND
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGFFJCPBDPD(JHDJHDKFFOE PCDMFIFHBNH, OIGNINLFHBM DEDKLMDDBBA);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJPJBJMFBLD(JHDJHDKFFOE PCDMFIFHBNH, OIGNINLFHBM DEDKLMDDBBA);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPIPJMPJELF(JHDJHDKFFOE PCDMFIFHBNH, OIGNINLFHBM DEDKLMDDBBA);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AJDHMBFHKBI(JHDJHDKFFOE PCDMFIFHBNH, OIGNINLFHBM DEDKLMDDBBA);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EAPPOBEFHEI Instantiate(Transform FDCDPIOJPOG);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LOIALHEPEBI();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface BLJFBBPKCFD
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIMKJDEKJHN(Transform FDCDPIOJPOG, EAPPOBEFHEI IBGNEABLPPN);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EAPPOBEFHEI HDBDDADNGHO();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGHDNBMGKMF(EAPPOBEFHEI AHLNEFKMLKI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CMLBJGPEBOM : KFNDIGPCLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLNEFLLCBGC();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ALCFEPODFKA(Guid DIDCADGGMMP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DLHNBHHGNFH
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICFMPILIEGN(FMFNDGOEKBB NNCDPHMKCHC);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIMKJDEKJHN(OIHJODLENEP GGBMBLFEJIF, BLJFBBPKCFD BHHCJJJJCBF);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEEALLGAGCA();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPCKAKBPNKO(FMFNDGOEKBB BIHHODLOOMC);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NCBCFCPLFIG(FMFNDGOEKBB LKKJGOICDCN);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMFFJAGJLEE();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class NBDMHCIFKJO : FMFNDGOEKBB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FDABCNIAHAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OIGNINLFHBM nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public NBDMHCIFKJO foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FDABCNIAHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x73DDB10", Offset = "0x73DC710", VA = "0x1873DDB10")]
		internal bool JNNAFPKFCOJ(FMFNDGOEKBB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private OIGNINLFHBM PKLFMNLEDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<NBDMHCIFKJO> GIFGPMEDCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NBDMHCIFKJO MKNKHFAOAPP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public OIGNINLFHBM BINDBHIKOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1075DC0", Offset = "0x10749C0", VA = "0x181075DC0", Slot = "6")]
		get
		{
			return default(OIGNINLFHBM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1075DE0", Offset = "0x10749E0", VA = "0x181075DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private NBDMHCIFKJO KOIBCEOILEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BD20", VA = "0x18095D120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x73E68D0", Offset = "0x73E54D0", VA = "0x1873E68D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FMFNDGOEKBB HNLFKIAHAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BD20", VA = "0x18095D120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JHDJHDKFFOE IBKICKANPML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KFIAKKOOBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x73E65F0", Offset = "0x73E51F0", VA = "0x1873E65F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PFMDJKLIHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x73E64A0", Offset = "0x73E50A0", VA = "0x1873E64A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected NBDMHCIFKJO EBMDCHEPJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x73E6330", Offset = "0x73E4F30", VA = "0x1873E6330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x73E6B20", Offset = "0x73E5720", VA = "0x1873E6B20")]
	public NBDMHCIFKJO(OIGNINLFHBM LJGOKOIPJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x73E6350", Offset = "0x73E4F50", VA = "0x1873E6350")]
	public NBDMHCIFKJO FOMJBDKJEKF(OIGNINLFHBM LMCMHOKIIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x73E6600", Offset = "0x73E5200", VA = "0x1873E6600")]
	public NBDMHCIFKJO MCGKKOBOPEK(OIGNINLFHBM GBBBKJEADAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x73E60A0", Offset = "0x73E4CA0", VA = "0x1873E60A0")]
	public NBDMHCIFKJO BLAPNJAELFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x73E6780", Offset = "0x73E5380", VA = "0x1873E6780")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x73E6280", Offset = "0x73E4E80", VA = "0x1873E6280")]
	public NBDMHCIFKJO BLLFMDAIBDD(OIGNINLFHBM BDHPANPFDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x73E69B0", Offset = "0x73E55B0", VA = "0x1873E69B0")]
	private static void NONMNGKIELB(NBDMHCIFKJO EMEMBNEKABC, DAMGKCOMOPD GAJFLBPNGCK, bool PFLJLOKMCDA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x73E6B10", Offset = "0x73E5710", VA = "0x1873E6B10", Slot = "9")]
	public void NONMNGKIELB(DAMGKCOMOPD DKDPAFJDNNF, bool BBIHPHNLENK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x73E64F0", Offset = "0x73E50F0", VA = "0x1873E64F0")]
	public static NBDMHCIFKJO HMJNNCHJMGE(NBDMHCIFKJO EMEMBNEKABC, OIGNINLFHBM BLNLIBGFLIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface IGNCNIBFMAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool FLNAPMDEODF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool AAFFOOJAEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<GEDEGCEHLJI> PNJHOLPAEGG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<NIHEANECFCA> IOLDOLDCCHA;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HGFFJCPBDPD(GNCGOCMBGIF JHBOJJACLJB, DIMMMCLADKM DJEEMGGBLGG);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GMEFEIBIJKN(JHDJHDKFFOE OHBIDNIEDDA, JHDJHDKFFOE CEHCBLINDLP, int GGAIGEOHNHI, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EEOFOPFGAJE(JHDJHDKFFOE HDAJBMBFNOL, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DPCOMMAABCE(MBJGAHEFDMD APALENHEDOM, [Optional] NIHEANECFCA LFKGAEHPCHD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OIPCLJAADMO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type JCIALHFDOME
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x73EAD40", Offset = "0x73E9940", VA = "0x1873EAD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object FFLNCJPMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x73EADF0", Offset = "0x73E99F0", VA = "0x1873EADF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x73EADA0", Offset = "0x73E99A0", VA = "0x1873EADA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class HACAHGJOJKF : IGNCNIBFMAE, IDisposable, LBAFFJBBCBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GNCGOCMBGIF JHBOJJACLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private DIMMMCLADKM BHLGFKAEOGE;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool FLNAPMDEODF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x73E02C0", Offset = "0x73DEEC0", VA = "0x1873E02C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool AAFFOOJAEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x73E0320", Offset = "0x73DEF20", VA = "0x1873E0320", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView CHLOACJGDEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x73E0070", Offset = "0x73DEC70", VA = "0x1873E0070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<GEDEGCEHLJI> PNJHOLPAEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x73DFD30", Offset = "0x73DE930", VA = "0x1873DFD30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x73E0360", Offset = "0x73DEF60", VA = "0x1873E0360", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NIHEANECFCA> IOLDOLDCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x73E0490", Offset = "0x73DF090", VA = "0x1873E0490", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x73E03F0", Offset = "0x73DEFF0", VA = "0x1873E03F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DEE30", VA = "0x1873E0230", Slot = "10")]
	public void HGFFJCPBDPD(GNCGOCMBGIF JHBOJJACLJB, DIMMMCLADKM BHLGFKAEOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x73DFEF0", Offset = "0x73DEAF0", VA = "0x1873DFEF0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x73E0100", Offset = "0x73DED00", VA = "0x1873E0100", Slot = "11")]
	public void GMEFEIBIJKN(JHDJHDKFFOE OHBIDNIEDDA, JHDJHDKFFOE CEHCBLINDLP, int GGAIGEOHNHI, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x73DFF40", Offset = "0x73DEB40", VA = "0x1873DFF40", Slot = "12")]
	public void EEOFOPFGAJE(JHDJHDKFFOE HDAJBMBFNOL, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x73DFDC0", Offset = "0x73DE9C0", VA = "0x1873DFDC0", Slot = "13")]
	public void DPCOMMAABCE(MBJGAHEFDMD APALENHEDOM, [Optional] NIHEANECFCA LFKGAEHPCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x73E0770", Offset = "0x73DF370", VA = "0x1873E0770")]
	[AJPIJFNMHAB]
	private void RpcMasterReparentNodes(JHDJHDKFFOE HDAJBMBFNOL, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x73E0570", Offset = "0x73DF170", VA = "0x1873E0570")]
	[AJPIJFNMHAB]
	private void RpcMasterModifyNode(JHDJHDKFFOE OHBIDNIEDDA, JHDJHDKFFOE CEHCBLINDLP, int GGAIGEOHNHI, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x73E0B40", Offset = "0x73DF740", VA = "0x1873E0B40")]
	[AJPIJFNMHAB]
	private void RpcReparentNodes(JHDJHDKFFOE HDAJBMBFNOL, int EJIADCJMDJI, JHDJHDKFFOE BDHPANPFDPF, int NPHKLBFFCMM, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC, PANJABPLHFP PGIPPGHOMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x73E0A80", Offset = "0x73DF680", VA = "0x1873E0A80")]
	[AJPIJFNMHAB]
	private void RpcModifyNode(JHDJHDKFFOE OHBIDNIEDDA, int GGAIGEOHNHI, int KCHPPEDAMDK, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC, PANJABPLHFP PGIPPGHOMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x73E0530", Offset = "0x73DF130", VA = "0x1873E0530")]
	[AJPIJFNMHAB]
	private void RpcDeserializeConnectableGraph(MBJGAHEFDMD GGBMBLFEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public HACAHGJOJKF()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, EAPPOBEFHEI, JJJBBNHMIFL.NEEFIEJPFND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x73E4D00", Offset = "0x73E3900", VA = "0x1873E4D00", Slot = "4")]
		private void ECLCCMLLIHE(JHDJHDKFFOE PCDMFIFHBNH, OIGNINLFHBM DEDKLMDDBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x73E4A80", Offset = "0x73E3680", VA = "0x1873E4A80", Slot = "5")]
		private void DLJDAJKLFBJ(JHDJHDKFFOE PCDMFIFHBNH, OIGNINLFHBM DEDKLMDDBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x73E4E80", Offset = "0x73E3A80", VA = "0x1873E4E80", Slot = "6")]
		private void FLEPBOIKAFF(JHDJHDKFFOE PCDMFIFHBNH, OIGNINLFHBM DEDKLMDDBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x73E4FE0", Offset = "0x73E3BE0", VA = "0x1873E4FE0", Slot = "7")]
		private void FLKDGMGAHPK(JHDJHDKFFOE PCDMFIFHBNH, OIGNINLFHBM DEDKLMDDBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x73E5230", Offset = "0x73E3E30", VA = "0x1873E5230", Slot = "8")]
		private EAPPOBEFHEI OACDHJEHBFG(Transform FDCDPIOJPOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x73E51D0", Offset = "0x73E3DD0", VA = "0x1873E51D0", Slot = "9")]
		private void KNMEFAAGLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LCGABDLJLKI
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3447800", Offset = "0x3446400", VA = "0x183447800")]
	public static KNKIGJEHMJP<T> CAKBJGOFCED<T>(this KPLLBHIBBNH AGGFAPJEEEN)
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
