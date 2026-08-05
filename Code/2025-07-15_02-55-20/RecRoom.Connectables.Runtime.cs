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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8018A90", Offset = "0x8017690", VA = "0x188018A90", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x230C5A0", Offset = "0x230B1A0", VA = "0x18230C5A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80226C0", Offset = "0x80212C0", VA = "0x1880226C0")]
		private void GAOPLNBGOGD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8022550", Offset = "0x8021150", VA = "0x188022550")]
		private void BBOPNMEHPCH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8022830", Offset = "0x8021430", VA = "0x188022830", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8022B60", Offset = "0x8021760", VA = "0x188022B60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class GHPKHJKHDEA : BOKGDJLALCE, IBPJLLPNJDI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class OHNGDNFKGAJ : IEnumerable<ECAKKCIBNCI>, IEnumerable, IEnumerator<ECAKKCIBNCI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private ECAKKCIBNCI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CFFDHOCCNNL localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CFFDHOCCNNL <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GHPKHJKHDEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HAOJOPIKEAB <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HFAACADMMPC <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private HFAACADMMPC.JEIHCPFDCNE <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private ECAKKCIBNCI System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public OHNGDNFKGAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8021730", Offset = "0x8020330", VA = "0x188021730", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80212D0", Offset = "0x801FED0", VA = "0x1880212D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8021290", Offset = "0x801FE90", VA = "0x188021290")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80212B0", Offset = "0x801FEB0", VA = "0x1880212B0")]
		private void KBNMMFGEPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x80216E0", Offset = "0x80202E0", VA = "0x1880216E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8021630", Offset = "0x8020230", VA = "0x188021630", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ECAKKCIBNCI> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8021630", Offset = "0x8020230", VA = "0x188021630", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MJGKECEHOEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public GHPKHJKHDEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public IJNCJFOMLFN nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public MJGKECEHOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x801C1E0", Offset = "0x801ADE0", VA = "0x18801C1E0")]
		internal object MMKHENFHJLD(IJNCJFOMLFN x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CNEMFECGNBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IJNCJFOMLFN child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MJGKECEHOEJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CNEMFECGNBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x800E770", Offset = "0x800D370", VA = "0x18800E770")]
		internal object EAELHCGJALO((IJNCJFOMLFN child, IJNCJFOMLFN nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly PEOHNMCPNIJ BBPKIIHEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly PEOHNMCPNIJ BANNNAGIIBA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly PEOHNMCPNIJ LAMHBCFNKIG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly PEOHNMCPNIJ AMACMOOHBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private HDGLCOCHNOP PKDHFCFPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private PAAJHIOLAGJ EJLIMJDFHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private DDHLMFDNOPE GMEBFIBEGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private NEAHEEDFJGJ FFBAIGJFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private ONEIBFNCCHG OAIMCOBNNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CLBOLGMGHEH FDBCHLAFJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PPEMOEKBADK HKAENDMEAII;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LBGGGNEDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5F0", Offset = "0xA5A1F0", VA = "0x180A5B5F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5C0", Offset = "0xA5A1C0", VA = "0x180A5B5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FNAKAPBGCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<ECAKKCIBNCI, ECAKKCIBNCI> MBKPAGMMCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x800F220", Offset = "0x800DE20", VA = "0x18800F220", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8010F30", Offset = "0x800FB30", VA = "0x188010F30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<ECAKKCIBNCI, ECAKKCIBNCI> DOLCDFCIIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8010E80", Offset = "0x800FA80", VA = "0x188010E80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x800FFF0", Offset = "0x800EBF0", VA = "0x18800FFF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<ECAKKCIBNCI, ECAKKCIBNCI, ECAKKCIBNCI> JOAHDDFDMEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80114E0", Offset = "0x80100E0", VA = "0x1880114E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80133F0", Offset = "0x8011FF0", VA = "0x1880133F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8013CF0", Offset = "0x80128F0", VA = "0x188013CF0")]
	public GHPKHJKHDEA(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x800FA90", Offset = "0x800E690", VA = "0x18800FA90", Slot = "12")]
	public void BFHPBJMBKJO(GameObject HLOIBGDKPID, GPIJLDEBGCM BGHDNGFOMEF, ABEHIAPNEJL NGJLHELIFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8010130", Offset = "0x800ED30", VA = "0x188010130", Slot = "26")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x800FD20", Offset = "0x800E920", VA = "0x18800FD20", Slot = "22")]
	public bool BFPDGFKJKAN(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8010320", Offset = "0x800EF20", VA = "0x188010320")]
	private void EEDOCHKEMMI(CFFDHOCCNNL IPHFNLHIGPC, CFFDHOCCNNL NMMECABJAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8011A00", Offset = "0x8010600", VA = "0x188011A00")]
	private void HLICIJLNOKC(CFFDHOCCNNL IPHFNLHIGPC, CFFDHOCCNNL NBHHIGIFKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8013510", Offset = "0x8012110", VA = "0x188013510")]
	private void PBPNMJPDLEP(CFFDHOCCNNL IPHFNLHIGPC, CFFDHOCCNNL NBHHIGIFKGB, CFFDHOCCNNL NMMECABJAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80115F0", Offset = "0x80101F0", VA = "0x1880115F0")]
	private void HDFGIOFFIHB(CFFDHOCCNNL IPHFNLHIGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "13")]
	public void MONBEGLCAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x800F570", Offset = "0x800E170", VA = "0x18800F570", Slot = "14")]
	public void AMHLLDBNIFP(ECAKKCIBNCI JPOGJOKKBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "15")]
	public void ADKBIHLFMAC(ECAKKCIBNCI JPOGJOKKBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x800F2D0", Offset = "0x800DED0", VA = "0x18800F2D0", Slot = "17")]
	public void AEKEOOGOKBF(ECAKKCIBNCI JPOGJOKKBEK, ECAKKCIBNCI HMACDOLINHA, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x800F430", Offset = "0x800E030", VA = "0x18800F430")]
	public void AEKEOOGOKBF(CFFDHOCCNNL EPHCGLFDDNO, CFFDHOCCNNL HMACDOLINHA, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x80125B0", Offset = "0x80111B0", VA = "0x1880125B0")]
	public void JLGGFENFABN(ECAKKCIBNCI JPOGJOKKBEK, float ECOEJMIBMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80112F0", Offset = "0x800FEF0", VA = "0x1880112F0", Slot = "18")]
	public void GICODOIAPOC(ECAKKCIBNCI HPJBONKAHNP, int INGIFGNJLPM, ECAKKCIBNCI FHEOEBJJJLN, int BFBDBALPGKO, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8012500", Offset = "0x8011100", VA = "0x188012500")]
	private float JINBMFDEBEF(CFFDHOCCNNL EPHCGLFDDNO, CFFDHOCCNNL IEPNOLIPIDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80111B0", Offset = "0x800FDB0", VA = "0x1880111B0")]
	public void GICODOIAPOC(CFFDHOCCNNL EPHCGLFDDNO, CFFDHOCCNNL IEPNOLIPIDE, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN, bool MBFIOOEOEDF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8010FE0", Offset = "0x800FBE0", VA = "0x188010FE0", Slot = "19")]
	public void FGBDKDIMFAJ(ECAKKCIBNCI JPOGJOKKBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x800F880", Offset = "0x800E480", VA = "0x18800F880", Slot = "16")]
	public void AOBFDMMHFAO(ECAKKCIBNCI JPOGJOKKBEK, HashSet<ECAKKCIBNCI> KDJMNJDBIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "20")]
	public OLMJEBKIAHL CNDGHKHDOEI(bool AKLANDDLLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "21")]
	public OLMJEBKIAHL BDKDFEBIJCF(HashSet<Guid> NMFMJBPFPJJ, bool AKLANDDLLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8011470", Offset = "0x8010070", VA = "0x188011470", Slot = "23")]
	public void GMIMJFEPJDG(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x80134A0", Offset = "0x80120A0", VA = "0x1880134A0", Slot = "24")]
	public void OPIEONEMBNP(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8011450", Offset = "0x8010050", VA = "0x188011450", Slot = "25")]
	public void GLBPMNOHHFO(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8013770", Offset = "0x8012370", VA = "0x188013770")]
	private void PFINLNCEAKC(CFFDHOCCNNL EPHCGLFDDNO, CFFDHOCCNNL IEPNOLIPIDE, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN, float ECOEJMIBMGD, bool MBFIOOEOEDF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8010570", Offset = "0x800F170", VA = "0x188010570")]
	private void FCFLGBBKMJL(CFFDHOCCNNL EPHCGLFDDNO, CFFDHOCCNNL AHLLNEDBFNM, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8012B40", Offset = "0x8011740", VA = "0x188012B40")]
	private void LDNAMHAGNMJ(CFFDHOCCNNL EPHCGLFDDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80100A0", Offset = "0x800ECA0", VA = "0x1880100A0")]
	[IteratorStateMachine(typeof(OHNGDNFKGAJ))]
	public IEnumerable<ECAKKCIBNCI> DGPHBDMIANL(CFFDHOCCNNL ILPOHEPFNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8011DB0", Offset = "0x80109B0", VA = "0x188011DB0")]
	internal ECAKKCIBNCI IEFNOFDAFBK(CFFDHOCCNNL ILPOHEPFNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8012820", Offset = "0x8011420", VA = "0x188012820")]
	internal CFFDHOCCNNL KEFBCGIGIBO(ECAKKCIBNCI JPOGJOKKBEK)
	{
		return default(CFFDHOCCNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8012BB0", Offset = "0x80117B0", VA = "0x188012BB0")]
	private bool LJGJKILDDBI(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8011150", Offset = "0x800FD50", VA = "0x188011150")]
	private bool FJAMBLDFCJJ(IJNCJFOMLFN GLMMAMOKOAD, [Out] ECAKKCIBNCI IEPNOLIPIDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8011EE0", Offset = "0x8010AE0", VA = "0x188011EE0")]
	private ECAKKCIBNCI IEFNOFDAFBK(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8011C20", Offset = "0x8010820", VA = "0x188011C20")]
	private ECAKKCIBNCI IAAOLGOCMMG(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8012640", Offset = "0x8011240", VA = "0x188012640")]
	private ECAKKCIBNCI JOMHMMDEJBI(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8010530", Offset = "0x800F130", VA = "0x188010530")]
	private static Guid EMNOJNJCIJM(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8012280", Offset = "0x8010E80", VA = "0x188012280")]
	private string INDHAIEEJEL(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8013260", Offset = "0x8011E60", VA = "0x188013260")]
	private void MBDGKIDAGKM(ECAKKCIBNCI EPHCGLFDDNO, ECAKKCIBNCI AHLLNEDBFNM, RigidTransform HPMDLPBCCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80129B0", Offset = "0x80115B0", VA = "0x1880129B0")]
	private void KFBOGNEGKML(ECAKKCIBNCI AHLLNEDBFNM, ECAKKCIBNCI EPHCGLFDDNO, RigidTransform HPMDLPBCCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8011590", Offset = "0x8010190", VA = "0x188011590")]
	private void GOLNJHKCOGG(ECAKKCIBNCI EAAAJHJCLLM, ECAKKCIBNCI EPHCGLFDDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8012370", Offset = "0x8010F70", VA = "0x188012370")]
	private void JDCBEJPGEAC(ECAKKCIBNCI EPHCGLFDDNO, ECAKKCIBNCI IEPNOLIPIDE, RigidTransform HPMDLPBCCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8013150", Offset = "0x8011D50", VA = "0x188013150")]
	private void LMGJGHODIDL(CFFDHOCCNNL ILPOHEPFNOO, ECAKKCIBNCI JPOGJOKKBEK, CFFDHOCCNNL NBHHIGIFKGB, CFFDHOCCNNL NMMECABJAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x800FD70", Offset = "0x800E970", VA = "0x18800FD70")]
	private void CLFODEEPPMG(CFFDHOCCNNL ILPOHEPFNOO, ECAKKCIBNCI JPOGJOKKBEK, ECAKKCIBNCI GBGPCLILINB, ECAKKCIBNCI FBDLNDCFCLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PIKKGOFAEKG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IMGOONNNOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public LGPCNHIHIDJ container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public IMGOONNNOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8017230", Offset = "0x8015E30", VA = "0x188017230")]
		internal GHPKHJKHDEA FJJLOHFEBHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8021810", Offset = "0x8020410", VA = "0x188021810")]
	public static void FMFLDGFJCKJ(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8021990", Offset = "0x8020590", VA = "0x188021990")]
	public static void KLDLMILLCIC(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class IDAPNGAMLOC : KEJOIPDBHAP, FFBJMMLEFMO
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly GHPKHJKHDEA BCDKEDFFOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly KFELJJDCHJI OPBLPOLOGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly IIEPJGPJPCE FFBAIGJFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HBGJNHBGNDJ[] CCKBNFGHCIH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ECAKKCIBNCI GONLDGKCBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8017000", Offset = "0x8015C00", VA = "0x188017000", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ECAKKCIBNCI DEJMOBGKGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8015520", Offset = "0x8014120", VA = "0x188015520", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 AFBGADMODEC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x80165D0", Offset = "0x80151D0", VA = "0x1880165D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion AAHPDKKFHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8015730", Offset = "0x8014330", VA = "0x188015730", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GJAMPDOABGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8016A40", Offset = "0x8015640", VA = "0x188016A40", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<ECAKKCIBNCI> EJEJOBBHOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8016D30", Offset = "0x8015930", VA = "0x188016D30", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool OGNHNOMDEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD297D0", Offset = "0xD283D0", VA = "0x180D297D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD5E830", Offset = "0xD5D430", VA = "0x180D5E830", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8017210", Offset = "0x8015E10", VA = "0x188017210", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject LKABGMIDCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8016F10", Offset = "0x8015B10", VA = "0x188016F10", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8016F30", Offset = "0x8015B30", VA = "0x188016F30", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid EFCEKHIEAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8017060", Offset = "0x8015C60", VA = "0x188017060", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OFFOELFHACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8017140", Offset = "0x8015D40", VA = "0x188017140", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MHNDFDEAHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool AIHCABJGCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8015C00", Offset = "0x8014800", VA = "0x188015C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event GOAHPAMFKBM LDIDLMBAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8015680", Offset = "0x8014280", VA = "0x188015680", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8015EB0", Offset = "0x8014AB0", VA = "0x188015EB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GOAHPAMFKBM PBJGDNMICJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8015E50", Offset = "0x8014A50", VA = "0x188015E50", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8015790", Offset = "0x8014390", VA = "0x188015790", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GOAHPAMFKBM JGBJLPFOICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8016630", Offset = "0x8015230", VA = "0x188016630", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8016170", Offset = "0x8014D70", VA = "0x188016170", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event DDBJCDKNIEL DHGHHEDFNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8016690", Offset = "0x8015290", VA = "0x188016690", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x80161D0", Offset = "0x8014DD0", VA = "0x1880161D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8016E10", Offset = "0x8015A10", VA = "0x188016E10")]
	public IDAPNGAMLOC(CFFDHOCCNNL LNPPHFKBHPJ, RigidbodyEx HOAOIBONAAE, KFELJJDCHJI OPBLPOLOGBG, HBGJNHBGNDJ[] CCKBNFGHCIH, IIEPJGPJPCE FFBAIGJFNPP, BOKGDJLALCE BCDKEDFFOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8016B00", Offset = "0x8015700", VA = "0x188016B00", Slot = "19")]
	public void ONFOCPIMDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "21")]
	public void KMAPIJLPMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A390", Offset = "0x7D38F90", VA = "0x187D3A390", Slot = "22")]
	public void GMAMACLAJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8016120", Offset = "0x8014D20", VA = "0x188016120", Slot = "20")]
	public void JLODMKOIAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8015F10", Offset = "0x8014B10", VA = "0x188015F10", Slot = "25")]
	public void IABCJHJBJIP(int BPDOMCLPJCD, ECAKKCIBNCI FHEOEBJJJLN, int JPECKFDHBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8015450", Offset = "0x8014050", VA = "0x188015450", Slot = "26")]
	public void BGKLMAGJBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x80162F0", Offset = "0x8014EF0", VA = "0x1880162F0", Slot = "27")]
	public void KMNHCBCKCAL(int BPDOMCLPJCD, ECAKKCIBNCI HPJBONKAHNP, int AEHHBDFCBIG, [Optional] Vector3? IDJEELMAACC, [Optional] Quaternion? KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8016270", Offset = "0x8014E70", VA = "0x188016270", Slot = "28")]
	public void JPPNCOEBPJC(ECAKKCIBNCI HPJBONKAHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x80157F0", Offset = "0x80143F0", VA = "0x1880157F0", Slot = "31")]
	public void EIAIHIBHPIC(Vector3 LHJMBANEHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8016730", Offset = "0x8015330", VA = "0x188016730", Slot = "29")]
	public void NBEKNLHAMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8016B30", Offset = "0x8015730", VA = "0x188016B30", Slot = "30")]
	public void PDCMNOKJOBP(int LCCBBMBENOH, Vector3 ALEIFNEHIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8015D80", Offset = "0x8014980", VA = "0x188015D80", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int BPDOMCLPJCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8015C50", Offset = "0x8014850", VA = "0x188015C50", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int BPDOMCLPJCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAC4E20", Offset = "0xAC3A20", VA = "0x180AC4E20", Slot = "42")]
	public Color GetConnectionSlotColor(int BPDOMCLPJCD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x80155E0", Offset = "0x80141E0", VA = "0x1880155E0", Slot = "43")]
	public bool CanConnectTo(int BPDOMCLPJCD, ECAKKCIBNCI CDEICKHEDEE, int CGKIEHDFOEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "44")]
	public void ParentChanged(int BPDOMCLPJCD, ECAKKCIBNCI BPALEFPMNFG, int ENPNOIOOJNL, Vector3 AOGEHDGMDKH, Quaternion CJAOOBJJBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "45")]
	public void ChildAdded(int BPDOMCLPJCD, ECAKKCIBNCI GFHHIDEFHIB, int NPOGIKKDNLD, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "46")]
	public void ChildRemoved(int BPDOMCLPJCD, ECAKKCIBNCI AALBBGICJOC, int LBJJNFMPFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "47")]
	public void ConnectionModified(int BPDOMCLPJCD, ECAKKCIBNCI FHEOEBJJJLN, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8016D60", Offset = "0x8015960", VA = "0x188016D60", Slot = "48")]
	public void RootChanged(ECAKKCIBNCI ECPFKIAMLPD, ECAKKCIBNCI KLBNLHBONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80156E0", Offset = "0x80142E0", VA = "0x1880156E0", Slot = "23")]
	public void DKGJJDMPOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8016AB0", Offset = "0x80156B0", VA = "0x188016AB0", Slot = "24")]
	public void OLLKMPGFECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8015400", Offset = "0x8014000", VA = "0x188015400")]
	private void BCOHDFHCOBH(bool NBLNIFEBACA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(IBJJOLANEGC), new string[] { })]
public class BBFANDMKDGK : IBJJOLANEGC, FPAFPEELFNB, EFGOCCCLGDB
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NNABBCFJAOI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NNABBCFJAOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private HAHMMNIOMKC IEAEJIDPCDO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object OMMFCEJNDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x800D870", Offset = "0x800C470", VA = "0x18800D870", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x800D900", Offset = "0x800C500", VA = "0x18800D900", Slot = "5")]
	private void HMKAAGAACIK(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x128AEC0", Offset = "0x1289AC0", VA = "0x18128AEC0", Slot = "6")]
	private void GJFDCMOAOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public BBFANDMKDGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(BOKGDJLALCE), new string[] { "Ignore", "Mock" })]
public class MLOALJLEFLL : BOKGDJLALCE, IBPJLLPNJDI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LBGGGNEDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FNAKAPBGCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<ECAKKCIBNCI, ECAKKCIBNCI> MBKPAGMMCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x801C250", Offset = "0x801AE50", VA = "0x18801C250", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x801C460", Offset = "0x801B060", VA = "0x18801C460", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<ECAKKCIBNCI, ECAKKCIBNCI> DOLCDFCIIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x801C3B0", Offset = "0x801AFB0", VA = "0x18801C3B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x801C300", Offset = "0x801AF00", VA = "0x18801C300", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<ECAKKCIBNCI, ECAKKCIBNCI, ECAKKCIBNCI> JOAHDDFDMEC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x801C510", Offset = "0x801B110", VA = "0x18801C510", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x801C5C0", Offset = "0x801B1C0", VA = "0x18801C5C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "26")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "12")]
	public void BFHPBJMBKJO(GameObject HLOIBGDKPID, GPIJLDEBGCM BGHDNGFOMEF, ABEHIAPNEJL AAFHGAGLEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "13")]
	public void MONBEGLCAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "14")]
	public void AMHLLDBNIFP(ECAKKCIBNCI JPOGJOKKBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "15")]
	public void ADKBIHLFMAC(ECAKKCIBNCI JPOGJOKKBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "16")]
	public void AOBFDMMHFAO(ECAKKCIBNCI JPOGJOKKBEK, HashSet<ECAKKCIBNCI> KDJMNJDBIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "17")]
	public void AEKEOOGOKBF(ECAKKCIBNCI JPOGJOKKBEK, ECAKKCIBNCI HMACDOLINHA, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "18")]
	public void GICODOIAPOC(ECAKKCIBNCI JPOGJOKKBEK, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "19")]
	public void FGBDKDIMFAJ(ECAKKCIBNCI JPOGJOKKBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "20")]
	public OLMJEBKIAHL CNDGHKHDOEI(bool AKLANDDLLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "21")]
	public OLMJEBKIAHL BDKDFEBIJCF(HashSet<Guid> NMFMJBPFPJJ, bool AKLANDDLLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "22")]
	public bool BFPDGFKJKAN(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "23")]
	public void GMIMJFEPJDG(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "24")]
	public void OPIEONEMBNP(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "25")]
	public void GLBPMNOHHFO(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MLOALJLEFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ECAKKCIBNCI : FFBJMMLEFMO, IEquatable<ECAKKCIBNCI>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FFBJMMLEFMO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	ECAKKCIBNCI GONLDGKCBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject LKABGMIDCKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid EFCEKHIEAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int OFFOELFHACB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MHNDFDEAHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int BPDOMCLPJCD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int BPDOMCLPJCD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int BPDOMCLPJCD);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int BPDOMCLPJCD, ECAKKCIBNCI CDEICKHEDEE, int JJDBFDOMIBE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int BPDOMCLPJCD, ECAKKCIBNCI BPALEFPMNFG, int ENPNOIOOJNL, Vector3 AOGEHDGMDKH, Quaternion CJAOOBJJBGF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int BPDOMCLPJCD, ECAKKCIBNCI GFHHIDEFHIB, int NPOGIKKDNLD, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int BPDOMCLPJCD, ECAKKCIBNCI AALBBGICJOC, int LBJJNFMPFCM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int BPDOMCLPJCD, ECAKKCIBNCI FHEOEBJJJLN, int BBDBLAJCLLL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(ECAKKCIBNCI ECPFKIAMLPD, ECAKKCIBNCI KLBNLHBONAC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BOKGDJLALCE : IBPJLLPNJDI
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LBGGGNEDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FNAKAPBGCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<ECAKKCIBNCI, ECAKKCIBNCI> MBKPAGMMCNC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<ECAKKCIBNCI, ECAKKCIBNCI> DOLCDFCIIGJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<ECAKKCIBNCI, ECAKKCIBNCI, ECAKKCIBNCI> JOAHDDFDMEC;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BFHPBJMBKJO(GameObject HLOIBGDKPID, GPIJLDEBGCM BGHDNGFOMEF, ABEHIAPNEJL CJMAHEGCKBE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MONBEGLCAAD();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMHLLDBNIFP(ECAKKCIBNCI JPOGJOKKBEK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ADKBIHLFMAC(ECAKKCIBNCI JPOGJOKKBEK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AOBFDMMHFAO(ECAKKCIBNCI JPOGJOKKBEK, HashSet<ECAKKCIBNCI> KDJMNJDBIJC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AEKEOOGOKBF(ECAKKCIBNCI JPOGJOKKBEK, ECAKKCIBNCI HMACDOLINHA, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GICODOIAPOC(ECAKKCIBNCI JPOGJOKKBEK, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FGBDKDIMFAJ(ECAKKCIBNCI JPOGJOKKBEK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OLMJEBKIAHL CNDGHKHDOEI(bool AKLANDDLLKO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	OLMJEBKIAHL BDKDFEBIJCF(HashSet<Guid> NMFMJBPFPJJ, bool AKLANDDLLKO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BFPDGFKJKAN(IJNCJFOMLFN GLMMAMOKOAD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GMIMJFEPJDG(OLMJEBKIAHL EAMANPAHEGF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OPIEONEMBNP(OLMJEBKIAHL EAMANPAHEGF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GLBPMNOHHFO(OLMJEBKIAHL EAMANPAHEGF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NEAHEEDFJGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool LAJILHFCAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ECAKKCIBNCI JOMHMMDEJBI(int LODHKLDKPDJ);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ECAKKCIBNCI IAAOLGOCMMG(Guid ALNLNIENMBM);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FLEIAANNLGG(ECAKKCIBNCI JPOGJOKKBEK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EBHFKDGHIHC();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CPDNMBLGKCJ(ECAKKCIBNCI OPBLPOLOGBG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface IIEPJGPJPCE
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AIHCABJGCKC(KFELJJDCHJI OPBLPOLOGBG);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EEBCNEEBPAG(KFELJJDCHJI OPBLPOLOGBG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string BDCDKDKODAN(KFELJJDCHJI OPBLPOLOGBG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid MBGHKCDHECP(KFELJJDCHJI OPBLPOLOGBG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BCPIAFGFPNK(KFELJJDCHJI OPBLPOLOGBG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ALLCAEIGPOF(KFELJJDCHJI OPBLPOLOGBG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void GOAHPAMFKBM(ECAKKCIBNCI HPJBONKAHNP, int EMNHEDAHDGN, ECAKKCIBNCI FHEOEBJJJLN, int EOLPLNNPIEB, [Optional] Vector3? IDJEELMAACC, [Optional] Quaternion? KGEHBNLCJNG);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void DDBJCDKNIEL(ECAKKCIBNCI ECPFKIAMLPD, ECAKKCIBNCI KLBNLHBONAC);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KFELJJDCHJI : ECAKKCIBNCI, FFBJMMLEFMO, IEquatable<ECAKKCIBNCI>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KEJOIPDBHAP : FFBJMMLEFMO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	ECAKKCIBNCI DEJMOBGKGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<ECAKKCIBNCI> EJEJOBBHOEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 AFBGADMODEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion AAHPDKKFHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool GJAMPDOABGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool OGNHNOMDEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event GOAHPAMFKBM LDIDLMBAGFK;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event GOAHPAMFKBM PBJGDNMICJK;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event GOAHPAMFKBM JGBJLPFOICH;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event DDBJCDKNIEL DHGHHEDFNHF;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ONFOCPIMDHM();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JLODMKOIAML();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KMAPIJLPMBF();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GMAMACLAJML();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DKGJJDMPOKH();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OLLKMPGFECC();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IABCJHJBJIP(int BPDOMCLPJCD, ECAKKCIBNCI FHEOEBJJJLN, int JPECKFDHBKE);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BGKLMAGJBBJ();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KMNHCBCKCAL(int BPDOMCLPJCD, ECAKKCIBNCI HPJBONKAHNP, int AEHHBDFCBIG, [Optional] Vector3? IDJEELMAACC, [Optional] Quaternion? KGEHBNLCJNG);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JPPNCOEBPJC(ECAKKCIBNCI HPJBONKAHNP);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NBEKNLHAMIJ();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PDCMNOKJOBP(int LCCBBMBENOH, Vector3 ALEIFNEHIBI);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EIAIHIBHPIC(Vector3 LHJMBANEHLP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HBGJNHBGNDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 CBJFEBNOLHD
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
public interface GPIJLDEBGCM
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool CKPHMKHOMFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NHNNCOBBOMA CNAGEELPFCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, GPIJLDEBGCM
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
			[Cpp2IlInjected.Address(RVA = "0xAB4C80", Offset = "0xAB3880", VA = "0x180AB4C80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public NHNNCOBBOMA LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x800E9C0", Offset = "0x800D5C0", VA = "0x18800E9C0")]
		public static ConnectableConfigData EJJBPMEBGEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x800EA80", Offset = "0x800D680", VA = "0x18800EA80")]
		public ConnectableConfigData(LegacyConnectableLinkVisual NAOLLHNPFLL, bool INFIKDINFEA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GOIMLBEBFIC : IEquatable<GOIMLBEBFIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public ECAKKCIBNCI JPOGJOKKBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int BLCEDCKLLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int BBDBLAJCLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 IDJEELMAACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion KGEHBNLCJNG;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8014430", Offset = "0x8013030", VA = "0x188014430")]
	public GOIMLBEBFIC(ECAKKCIBNCI JPOGJOKKBEK, int BLCEDCKLLLI, int BBDBLAJCLLL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8014490", Offset = "0x8013090", VA = "0x188014490")]
	public GOIMLBEBFIC(ECAKKCIBNCI JPOGJOKKBEK, int BLCEDCKLLLI, int BBDBLAJCLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x80143A0", Offset = "0x8012FA0", VA = "0x1880143A0")]
	public GOIMLBEBFIC(ECAKKCIBNCI JPOGJOKKBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8013F20", Offset = "0x8012B20", VA = "0x188013F20", Slot = "4")]
	public bool Equals(GOIMLBEBFIC IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8013FD0", Offset = "0x8012BD0", VA = "0x188013FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class CANEOBKMPEN : ABBGGIKDBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform LMGPODOPMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private NHNNCOBBOMA NCKGEEIGKOH;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x79ADB50", Offset = "0x79AC750", VA = "0x1879ADB50", Slot = "4")]
	public void BFHPBJMBKJO(Transform LMGPODOPMIJ, NHNNCOBBOMA NCKGEEIGKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x800E630", Offset = "0x800D230", VA = "0x18800E630", Slot = "5")]
	public NHNNCOBBOMA HPFAOEHPNEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x800E700", Offset = "0x800D300", VA = "0x18800E700", Slot = "6")]
	public void JIOMHINBMFN(NHNNCOBBOMA POGFCLFDCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public CANEOBKMPEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class MHFPPPPADFN : IDisposable, FHCCFIOFEMK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EMHIOEHBKCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public ECAKKCIBNCI oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ECAKKCIBNCI newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public EMHIOEHBKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x800EFB0", Offset = "0x800DBB0", VA = "0x18800EFB0")]
		internal bool BMOPPHKKGGM(IPMBJHJEAGK node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly BJKDHJOONBP JOHDHDBIKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private AIPIGBCECAC AKAIIHMCOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private DEOKOENMDNE BNIPHBJIACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool INFIKDINFEA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly PEOHNMCPNIJ EPCOPCGCEBF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IPMBJHJEAGK AMCBICJEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x801AEC0", Offset = "0x8019AC0", VA = "0x18801AEC0")]
	public bool IELCCAIAKMG([In] BBPALFAPADO CBCNBAPLLJM, bool NKECOBNGPPF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x801A730", Offset = "0x8019330", VA = "0x18801A730")]
	private bool GHGONKNHNJL([In] BBPALFAPADO CBCNBAPLLJM, bool NKECOBNGPPF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x801C010", Offset = "0x801AC10", VA = "0x18801C010")]
	public MHFPPPPADFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8019820", Offset = "0x8018420", VA = "0x188019820", Slot = "5")]
	public void BFHPBJMBKJO(BOKGDJLALCE GHKGDJLGKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x801BF10", Offset = "0x801AB10", VA = "0x18801BF10", Slot = "17")]
	public void PJKPHMNFNIH(JFBCJHEAEMP HFBNHPDLHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x801A700", Offset = "0x8019300", VA = "0x18801A700", Slot = "12")]
	public void EPFCANLDPHA(Func<ECAKKCIBNCI, bool> BENBDHMPHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x801A5D0", Offset = "0x80191D0", VA = "0x18801A5D0")]
	private void EPFCANLDPHA(BJKDHJOONBP PBBEMEGKFPO, Func<ECAKKCIBNCI, bool> BENBDHMPHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x801A710", Offset = "0x8019310", VA = "0x18801A710", Slot = "11")]
	public void GEGBBKLHOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x801BF00", Offset = "0x801AB00", VA = "0x18801BF00", Slot = "8")]
	public bool PJKGEHCBACF(ECAKKCIBNCI OLGLLNCNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8018C30", Offset = "0x8017830", VA = "0x188018C30")]
	private bool AKOKNKNKKJL(ECAKKCIBNCI KAHPDBHEGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x801BC50", Offset = "0x801A850", VA = "0x18801BC50")]
	private static bool ODJOHDAEPMH(ECAKKCIBNCI KAHPDBHEGHA, BJKDHJOONBP GBJCCPBLABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x801B4C0", Offset = "0x801A0C0", VA = "0x18801B4C0")]
	private void KONHEGMIEOO(Transform LGOLPMMHHOL, BJKDHJOONBP OGFBAEJOFKA, BJKDHJOONBP[] CFFCOIOFNJB, ECAKKCIBNCI AFNPGBEEHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8019E70", Offset = "0x8018A70", VA = "0x188019E70")]
	private GOIMLBEBFIC BHOGMGBGHHN(Transform FLJPPLPGJLM, GOIMLBEBFIC KCNNDOMEEHK)
	{
		return default(GOIMLBEBFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x801BA90", Offset = "0x801A690", VA = "0x18801BA90")]
	private static bool NOMGNOBGOCP(BJKDHJOONBP GBJCCPBLABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x801AE60", Offset = "0x8019A60", VA = "0x18801AE60", Slot = "9")]
	public bool HMAKGGNLDGC(ECAKKCIBNCI ILNKGDCCMNP, int AEHHBDFCBIG, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8019FC0", Offset = "0x8018BC0", VA = "0x188019FC0")]
	private bool BLFNEOGBMOK(ECAKKCIBNCI ILNKGDCCMNP, int AEHHBDFCBIG, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x801AED0", Offset = "0x8019AD0", VA = "0x18801AED0")]
	private static void JJDIMCACHGH(ECAKKCIBNCI ILNKGDCCMNP, int AEHHBDFCBIG, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG, BJKDHJOONBP DPEIDHMEHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x801B970", Offset = "0x801A570", VA = "0x18801B970")]
	private void MBDGKIDAGKM(ECAKKCIBNCI MCFIMDIPBJP, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x801A280", Offset = "0x8018E80", VA = "0x18801A280")]
	private void CCLOBILOAJJ(BJKDHJOONBP PBBEMEGKFPO, ECAKKCIBNCI GBGPCLILINB, ECAKKCIBNCI FBDLNDCFCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x801A210", Offset = "0x8018E10", VA = "0x18801A210")]
	private void CCLOBILOAJJ(ECAKKCIBNCI JPOGJOKKBEK, ECAKKCIBNCI GBGPCLILINB, ECAKKCIBNCI FBDLNDCFCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x801A2F0", Offset = "0x8018EF0", VA = "0x18801A2F0")]
	private void CLFODEEPPMG(ECAKKCIBNCI JPOGJOKKBEK, ECAKKCIBNCI GBGPCLILINB, ECAKKCIBNCI FBDLNDCFCLJ, bool HNJHMJOCGKA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x801A360", Offset = "0x8018F60", VA = "0x18801A360")]
	private void CLFODEEPPMG(BJKDHJOONBP OLIIIAEGOLD, ECAKKCIBNCI AFNPGBEEHPM, ECAKKCIBNCI KLBNLHBONAC, bool HNJHMJOCGKA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x801B050", Offset = "0x8019C50", VA = "0x18801B050")]
	private void KFBOGNEGKML(ECAKKCIBNCI EPHCGLFDDNO, int AEHHBDFCBIG, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x801AD00", Offset = "0x8019900", VA = "0x18801AD00")]
	private void GOLNJHKCOGG(IPMBJHJEAGK IEPNOLIPIDE, IPMBJHJEAGK MJMGBCMNIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x801BD40", Offset = "0x801A940", VA = "0x18801BD40", Slot = "18")]
	public ECAKKCIBNCI OMIPDFPHOEC(ECAKKCIBNCI JPOGJOKKBEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8019340", Offset = "0x8017F40", VA = "0x188019340", Slot = "13")]
	public void AOBFDMMHFAO(ECAKKCIBNCI JPOGJOKKBEK, HashSet<ECAKKCIBNCI> IDGADLBPKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x801B170", Offset = "0x8019D70", VA = "0x18801B170", Slot = "14")]
	public List<ECAKKCIBNCI> KIIOMLMDNPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x801A500", Offset = "0x8019100", VA = "0x18801A500")]
	protected IPMBJHJEAGK EDKOPNNPLAP(IPMBJHJEAGK PBBEMEGKFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x801A460", Offset = "0x8019060", VA = "0x18801A460")]
	protected BJKDHJOONBP[] EALHNEPJELE(BJKDHJOONBP GBJCCPBLABD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x801B3B0", Offset = "0x8019FB0", VA = "0x18801B3B0")]
	protected bool KKDGODMCELC(ECAKKCIBNCI JPOGJOKKBEK, [Out] BJKDHJOONBP PBBEMEGKFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x80196F0", Offset = "0x80182F0", VA = "0x1880196F0", Slot = "15")]
	public bool BDHFPCBIDOM(ECAKKCIBNCI JPOGJOKKBEK, [Out] GOIMLBEBFIC BCGBNAFECDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x801BD00", Offset = "0x801A900", VA = "0x18801BD00")]
	protected BJKDHJOONBP OJCGKIGGFHF(GOIMLBEBFIC CGLIGKJOGGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x801BEA0", Offset = "0x801AAA0", VA = "0x18801BEA0", Slot = "10")]
	public bool ONONJNNGGBA(ECAKKCIBNCI MCFIMDIPBJP, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x80198D0", Offset = "0x80184D0", VA = "0x1880198D0")]
	private bool BFIOAHDIIMA(ECAKKCIBNCI MCFIMDIPBJP, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x801B8A0", Offset = "0x801A4A0", VA = "0x18801B8A0")]
	private static bool LPDKJHMNKOH(BJKDHJOONBP DMFJKGDIGLD, GOIMLBEBFIC BGGBBFLOEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x801AEC0", Offset = "0x8019AC0", VA = "0x18801AEC0", Slot = "7")]
	private bool JJJJKBNAHGF([In] BBPALFAPADO CBCNBAPLLJM, bool NKECOBNGPPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class NOFGCMBKLOA : BOKGDJLALCE, IBPJLLPNJDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly LGPCNHIHIDJ EHEGCBFMKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly DEOKOENMDNE BNIPHBJIACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly ODCJNLKKBPF ODHJLCDHEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly NDMPKFNJCEM EKBOBHAINMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly FHCCFIOFEMK EAMANPAHEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal DLJBGMNLNLA FFBAIGJFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal BMJBNPODEKG OMNFPJIOKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal AIPIGBCECAC FJEMJBDJOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool INFIKDINFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool PNGDJINBAPK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool MDLCIOPFDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAB0090", Offset = "0xAAEC90", VA = "0x180AB0090")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAB00A0", Offset = "0xAAECA0", VA = "0x180AB00A0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LBGGGNEDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xACDD00", Offset = "0xACC900", VA = "0x180ACDD00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xACDDB0", Offset = "0xACC9B0", VA = "0x180ACDDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FNAKAPBGCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<ECAKKCIBNCI, ECAKKCIBNCI> MBKPAGMMCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x801EDF0", Offset = "0x801D9F0", VA = "0x18801EDF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x80200D0", Offset = "0x801ECD0", VA = "0x1880200D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<ECAKKCIBNCI, ECAKKCIBNCI> DOLCDFCIIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8020070", Offset = "0x801EC70", VA = "0x188020070", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x801FF40", Offset = "0x801EB40", VA = "0x18801FF40", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<ECAKKCIBNCI, ECAKKCIBNCI, ECAKKCIBNCI> JOAHDDFDMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8020760", Offset = "0x801F360", VA = "0x188020760", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x80208F0", Offset = "0x801F4F0", VA = "0x1880208F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8020A80", Offset = "0x801F680", VA = "0x188020A80")]
	public NOFGCMBKLOA(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x801F470", Offset = "0x801E070", VA = "0x18801F470", Slot = "12")]
	public void BFHPBJMBKJO(GameObject HLOIBGDKPID, GPIJLDEBGCM BGHDNGFOMEF, ABEHIAPNEJL CJMAHEGCKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x801FFA0", Offset = "0x801EBA0", VA = "0x18801FFA0", Slot = "26")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8020950", Offset = "0x801F550", VA = "0x188020950", Slot = "13")]
	public void MONBEGLCAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x801F060", Offset = "0x801DC60", VA = "0x18801F060", Slot = "14")]
	public void AMHLLDBNIFP(ECAKKCIBNCI JPOGJOKKBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x801ED90", Offset = "0x801D990", VA = "0x18801ED90", Slot = "15")]
	public void ADKBIHLFMAC(ECAKKCIBNCI JPOGJOKKBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x801FD70", Offset = "0x801E970", VA = "0x18801FD70", Slot = "22")]
	public bool BFPDGFKJKAN(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x801FA80", Offset = "0x801E680", VA = "0x18801FA80")]
	internal bool BFIOAHDIIMA([In] BBPALFAPADO CBCNBAPLLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x801F320", Offset = "0x801DF20", VA = "0x18801F320")]
	internal bool BDPLLLGMADE([In] BBPALFAPADO CBCNBAPLLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x801FB90", Offset = "0x801E790", VA = "0x18801FB90")]
	internal void BFMJBFGODAN(ECAKKCIBNCI JPOGJOKKBEK, int JCENCCJFLON, bool NKECOBNGPPF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x801ED90", Offset = "0x801D990", VA = "0x18801ED90")]
	internal bool OOJLGILOFPF(ECAKKCIBNCI DOKCCDMGLHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x80207C0", Offset = "0x801F3C0", VA = "0x1880207C0")]
	internal bool LDPMHEIKKHG(ECAKKCIBNCI ILNKGDCCMNP, int AEHHBDFCBIG, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x801F080", Offset = "0x801DC80", VA = "0x18801F080", Slot = "16")]
	public void AOBFDMMHFAO(ECAKKCIBNCI JPOGJOKKBEK, HashSet<ECAKKCIBNCI> KDJMNJDBIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x801EE50", Offset = "0x801DA50", VA = "0x18801EE50", Slot = "17")]
	public void AEKEOOGOKBF(ECAKKCIBNCI ILNKGDCCMNP, ECAKKCIBNCI HMACDOLINHA, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8020550", Offset = "0x801F150", VA = "0x188020550", Slot = "18")]
	public void GICODOIAPOC(ECAKKCIBNCI MCFIMDIPBJP, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8020380", Offset = "0x801EF80", VA = "0x188020380", Slot = "19")]
	public void FGBDKDIMFAJ(ECAKKCIBNCI MCFIMDIPBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8020130", Offset = "0x801ED30", VA = "0x188020130")]
	public void FFCGNFDIKJN([Optional] PLCCGHEKGIM MBEBFIOEPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x80206D0", Offset = "0x801F2D0", VA = "0x1880206D0", Slot = "23")]
	public void GMIMJFEPJDG(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x801FDC0", Offset = "0x801E9C0", VA = "0x18801FDC0", Slot = "20")]
	public OLMJEBKIAHL CNDGHKHDOEI(bool AKLANDDLLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x801F180", Offset = "0x801DD80", VA = "0x18801F180", Slot = "21")]
	public OLMJEBKIAHL BDKDFEBIJCF(HashSet<Guid> NMFMJBPFPJJ, bool AKLANDDLLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8020690", Offset = "0x801F290", VA = "0x188020690", Slot = "25")]
	public void GLBPMNOHHFO(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x80209D0", Offset = "0x801F5D0", VA = "0x1880209D0", Slot = "24")]
	public void OPIEONEMBNP(OLMJEBKIAHL EAMANPAHEGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class DEOKOENMDNE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly KLPJLNGNINA<ECAKKCIBNCI, ECAKKCIBNCI> MBKPAGMMCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly KLPJLNGNINA<ECAKKCIBNCI, ECAKKCIBNCI> DOLCDFCIIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly IKGOKGNLKCJ<ECAKKCIBNCI, ECAKKCIBNCI, ECAKKCIBNCI> JOAHDDFDMEC;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x800EC10", Offset = "0x800D810", VA = "0x18800EC10")]
	public DEOKOENMDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	public void BFHPBJMBKJO(NOFGCMBKLOA GHKGDJLGKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x800EB30", Offset = "0x800D730", VA = "0x18800EB30")]
	public void LEMEOJFLNLJ(ECAKKCIBNCI IEPNOLIPIDE, ECAKKCIBNCI EPHCGLFDDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x800EAD0", Offset = "0x800D6D0", VA = "0x18800EAD0")]
	public void IEGMGLOICNH(ECAKKCIBNCI IEPNOLIPIDE, ECAKKCIBNCI EPHCGLFDDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x800EB90", Offset = "0x800D790", VA = "0x18800EB90")]
	public void PHEBIILOEKA(ECAKKCIBNCI EAAAJHJCLLM, ECAKKCIBNCI AHLLNEDBFNM, ECAKKCIBNCI EPHCGLFDDNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class ODCJNLKKBPF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NOFGCMBKLOA GHKGDJLGKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private BMJBNPODEKG OMNFPJIOKPC;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public ODCJNLKKBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8020EB0", Offset = "0x801FAB0", VA = "0x188020EB0")]
	public void BFHPBJMBKJO(NOFGCMBKLOA GHKGDJLGKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8020FF0", Offset = "0x801FBF0", VA = "0x188020FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8020E70", Offset = "0x801FA70", VA = "0x188020E70")]
	private void BCOAMOOCCFN(MKFFFMAICOP LHBOIGHHIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8021000", Offset = "0x801FC00", VA = "0x188021000")]
	private void FFEJIBNHGKG(PLCCGHEKGIM KFDOAKEPDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8021180", Offset = "0x801FD80", VA = "0x188021180")]
	public void OICPBHEMKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8021070", Offset = "0x801FC70", VA = "0x188021070")]
	public void GPLGLLNGLBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DLLEFOIDMGF
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FECCHFLACLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LGPCNHIHIDJ container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FECCHFLACLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x800F070", Offset = "0x800DC70", VA = "0x18800F070")]
		internal NOFGCMBKLOA FJJLOHFEBHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x800ED30", Offset = "0x800D930", VA = "0x18800ED30")]
	public static void FMFLDGFJCKJ(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x800EF30", Offset = "0x800DB30", VA = "0x18800EF30")]
	public static void KLDLMILLCIC(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class HDAGKECBKHD : IDisposable, AIPIGBCECAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, NHNNCOBBOMA> JEODNNGKKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly JFBCJHEAEMP IBGIAGGPHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private ABBGGIKDBDA IFCMDBPBLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private FHCCFIOFEMK EAMANPAHEGF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker DNCHAKNCLDE;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8015220", Offset = "0x8013E20", VA = "0x188015220")]
	public HDAGKECBKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8014530", Offset = "0x8013130", VA = "0x188014530", Slot = "7")]
	public void BFHPBJMBKJO(FHCCFIOFEMK EAMANPAHEGF, ABBGGIKDBDA IFCMDBPBLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8014570", Offset = "0x8013170", VA = "0x188014570", Slot = "5")]
	public void DDFJEIHJEGE(IPMBJHJEAGK IAIGOFOKMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8014B50", Offset = "0x8013750", VA = "0x188014B50", Slot = "9")]
	public void HFNKHJBLAJL(IPMBJHJEAGK FPGKOFBLDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8014810", Offset = "0x8013410", VA = "0x188014810", Slot = "8")]
	public void FKPEMMMKBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8014E70", Offset = "0x8013A70", VA = "0x188014E70", Slot = "10")]
	public void OCLNKDGMNNO(IPMBJHJEAGK JOBJDEHOKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x80149D0", Offset = "0x80135D0", VA = "0x1880149D0", Slot = "11")]
	public void GLMPKJCHAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8014CC0", Offset = "0x80138C0", VA = "0x188014CC0")]
	private bool HKGNDBBEBAO(IPMBJHJEAGK PJNOJDKODDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class NDMPKFNJCEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct PPDJJLHAPAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly BJKDHJOONBP OMBJILKNELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> NMFMJBPFPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly IJNCJFOMLFN NFNHPEODBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly IJNCJFOMLFN NAICOAOCODI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool AKLANDDLLKO;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool MNNIGEKBBIA
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8021E30", Offset = "0x8020A30", VA = "0x188021E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x80222B0", Offset = "0x8020EB0", VA = "0x1880222B0")]
		public PPDJJLHAPAC(BJKDHJOONBP OMBJILKNELC, HashSet<Guid> NMFMJBPFPJJ, bool AKLANDDLLKO, [Optional] IJNCJFOMLFN NFNHPEODBFC, [Optional] IJNCJFOMLFN NAICOAOCODI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8022110", Offset = "0x8020D10", VA = "0x188022110")]
		public IJNCJFOMLFN PBHGMJKEMBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8021D70", Offset = "0x8020970", VA = "0x188021D70")]
		private IJNCJFOMLFN IJAGAKAFACM([Out] IJNCJFOMLFN LLEFEIKDDPN, [Out] IJNCJFOMLFN GNNEDNCGMFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x80219E0", Offset = "0x80205E0", VA = "0x1880219E0")]
		private IJNCJFOMLFN DEFNEGBBLHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8021C00", Offset = "0x8020800", VA = "0x188021C00")]
		private void HHENCEELDAC(IJNCJFOMLFN NPOADOOCJLF, IJNCJFOMLFN PEBMOMFLMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8021F50", Offset = "0x8020B50", VA = "0x188021F50")]
		private void NFPKOLBJEPG(IJNCJFOMLFN LLEFEIKDDPN, IJNCJFOMLFN GNNEDNCGMFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NOFGCMBKLOA GHKGDJLGKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private FHCCFIOFEMK EAMANPAHEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private AIPIGBCECAC AKAIIHMCOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private BMJBNPODEKG OMNFPJIOKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool IIEBAODOCLF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool HOBANNDKMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x801DAA0", Offset = "0x801C6A0", VA = "0x18801DAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool MDLCIOPFDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x801DD60", Offset = "0x801C960", VA = "0x18801DD60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x801D690", Offset = "0x801C290", VA = "0x18801D690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x801C810", Offset = "0x801B410", VA = "0x18801C810")]
	public void BFHPBJMBKJO(NOFGCMBKLOA GHKGDJLGKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x801CB10", Offset = "0x801B710", VA = "0x18801CB10")]
	public OLMJEBKIAHL CNDGHKHDOEI(bool AKLANDDLLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x801C670", Offset = "0x801B270", VA = "0x18801C670")]
	public OLMJEBKIAHL BDKDFEBIJCF(HashSet<Guid> NMFMJBPFPJJ, bool AKLANDDLLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x801D6B0", Offset = "0x801C2B0", VA = "0x18801D6B0")]
	public void GMIMJFEPJDG(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x801EA60", Offset = "0x801D660", VA = "0x18801EA60")]
	public void OPIEONEMBNP(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x801DFE0", Offset = "0x801CBE0", VA = "0x18801DFE0")]
	public void KIBJGPDCFBA(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x801CFE0", Offset = "0x801BBE0", VA = "0x18801CFE0")]
	private void FHPMHMDJJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x801D1D0", Offset = "0x801BDD0", VA = "0x18801D1D0")]
	private IJNCJFOMLFN FILJLEIMNHI(BJKDHJOONBP PBBEMEGKFPO, bool AKLANDDLLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x801E010", Offset = "0x801CC10", VA = "0x18801E010")]
	private static void KIKIPCNJDHM(BJKDHJOONBP PBBEMEGKFPO, bool AKLANDDLLKO, IJNCJFOMLFN GLMMAMOKOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x801EB00", Offset = "0x801D700", VA = "0x18801EB00")]
	private void PPLDCDHHDNG(BJKDHJOONBP PBBEMEGKFPO, bool AKLANDDLLKO, IJNCJFOMLFN GLMMAMOKOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x801CE10", Offset = "0x801BA10", VA = "0x18801CE10")]
	private IJNCJFOMLFN EGKCJFPMNDF(BJKDHJOONBP OMBJILKNELC, HashSet<Guid> NMFMJBPFPJJ, bool AKLANDDLLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x801D400", Offset = "0x801C000", VA = "0x18801D400")]
	private bool FPPMBKIMOAH(OLMJEBKIAHL KDGIHOGLJDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x801E3F0", Offset = "0x801CFF0", VA = "0x18801E3F0")]
	private bool LJGJKILDDBI(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x801CEA0", Offset = "0x801BAA0", VA = "0x18801CEA0")]
	private bool EPGENECCFPI(OLMJEBKIAHL EAMANPAHEGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x801CEC0", Offset = "0x801BAC0", VA = "0x18801CEC0")]
	private static bool FAALBAGIHOB(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x801C880", Offset = "0x801B480", VA = "0x18801C880")]
	public static bool BFPDGFKJKAN(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x801D740", Offset = "0x801C340", VA = "0x18801D740")]
	private ECAKKCIBNCI IEFNOFDAFBK(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x801DBE0", Offset = "0x801C7E0", VA = "0x18801DBE0")]
	private ECAKKCIBNCI JOMHMMDEJBI(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x801CC80", Offset = "0x801B880", VA = "0x18801CC80")]
	private ECAKKCIBNCI DAEBHKMHKBO(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8010530", Offset = "0x800F130", VA = "0x188010530")]
	private static Guid EMNOJNJCIJM(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x801DAF0", Offset = "0x801C6F0", VA = "0x18801DAF0")]
	private string INDHAIEEJEL(IJNCJFOMLFN GLMMAMOKOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x801E260", Offset = "0x801CE60", VA = "0x18801E260")]
	private bool LGNHMJDNMCJ(BJKDHJOONBP PBBEMEGKFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x801DD80", Offset = "0x801C980", VA = "0x18801DD80")]
	private static void KGMKBEOJPCG(BJKDHJOONBP OMBJILKNELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public NDMPKFNJCEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct BBPALFAPADO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public ECAKKCIBNCI EPHCGLFDDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public ECAKKCIBNCI IEPNOLIPIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int AEHHBDFCBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int JPECKFDHBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 IDJEELMAACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion KGEHBNLCJNG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GOIMLBEBFIC HNCIHNCBGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x800D9C0", Offset = "0x800C5C0", VA = "0x18800D9C0")]
		get
		{
			return default(GOIMLBEBFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GOIMLBEBFIC OFAHELIBOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x800DA60", Offset = "0x800C660", VA = "0x18800DA60")]
		get
		{
			return default(GOIMLBEBFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x800DA90", Offset = "0x800C690", VA = "0x18800DA90")]
	public BBPALFAPADO(ECAKKCIBNCI EPHCGLFDDNO, ECAKKCIBNCI IEPNOLIPIDE, int AEHHBDFCBIG, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface FHCCFIOFEMK
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IPMBJHJEAGK AMCBICJEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFHPBJMBKJO(BOKGDJLALCE GHKGDJLGKOB);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IELCCAIAKMG([In] BBPALFAPADO CBCNBAPLLJM, bool NKECOBNGPPF = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PJKGEHCBACF(ECAKKCIBNCI OLGLLNCNBMH);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HMAKGGNLDGC(ECAKKCIBNCI ILNKGDCCMNP, int AEHHBDFCBIG, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ONONJNNGGBA(ECAKKCIBNCI MCFIMDIPBJP, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GEGBBKLHOGO();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EPFCANLDPHA(Func<ECAKKCIBNCI, bool> BENBDHMPHMA);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AOBFDMMHFAO(ECAKKCIBNCI JPOGJOKKBEK, HashSet<ECAKKCIBNCI> IDGADLBPKEE);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<ECAKKCIBNCI> KIIOMLMDNPN();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BDHFPCBIDOM(ECAKKCIBNCI JPOGJOKKBEK, [Out] GOIMLBEBFIC BCGBNAFECDN);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PJKPHMNFNIH(JFBCJHEAEMP HFBNHPDLHHL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool JFBCJHEAEMP(IPMBJHJEAGK PBBEMEGKFPO);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface IPMBJHJEAGK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ECAKKCIBNCI AMMHIMPAPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IPMBJHJEAGK CCBOMPENMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GOIMLBEBFIC GPLIIEDNLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool IEIAFLCCFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NHNNCOBBOMA
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBACPPGGEHG(ECAKKCIBNCI FHEOEBJJJLN, GOIMLBEBFIC EPHCGLFDDNO);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOGGJNFAPHN(ECAKKCIBNCI FHEOEBJJJLN, GOIMLBEBFIC EPHCGLFDDNO);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IPHBBFMPBAD(ECAKKCIBNCI FHEOEBJJJLN, GOIMLBEBFIC EPHCGLFDDNO);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOGJCJKNAAL(ECAKKCIBNCI FHEOEBJJJLN, GOIMLBEBFIC EPHCGLFDDNO);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NHNNCOBBOMA Instantiate(Transform LMGPODOPMIJ);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PCEOKDJFDMA();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface ABBGGIKDBDA
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFHPBJMBKJO(Transform LMGPODOPMIJ, NHNNCOBBOMA NCKGEEIGKOH);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NHNNCOBBOMA HPFAOEHPNEB();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIOMHINBMFN(NHNNCOBBOMA POGFCLFDCDD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DLJBGMNLNLA : NEAHEEDFJGJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MABLGDLHBNE();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HLIKOOKAEJA(Guid MJIIKICHOLO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface AIPIGBCECAC
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDFJEIHJEGE(IPMBJHJEAGK IAIGOFOKMBF);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFHPBJMBKJO(FHCCFIOFEMK EAMANPAHEGF, ABBGGIKDBDA AHDDFAPMDMG);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKPEMMMKBPL();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFNKHJBLAJL(IPMBJHJEAGK FPGKOFBLDMO);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCLNKDGMNNO(IPMBJHJEAGK JOBJDEHOKEF);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GLMPKJCHAOC();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class BJKDHJOONBP : IPMBJHJEAGK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GBBNEEMJJCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GOIMLBEBFIC nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public BJKDHJOONBP foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GBBNEEMJJCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x800F0E0", Offset = "0x800DCE0", VA = "0x18800F0E0")]
		internal bool AODAPDCDHPD(IPMBJHJEAGK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private GOIMLBEBFIC BCGBNAFECDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<BJKDHJOONBP> LPOCBIDNPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private BJKDHJOONBP EKLFBMPDHIO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GOIMLBEBFIC GPLIIEDNLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1474260", Offset = "0x1472E60", VA = "0x181474260", Slot = "6")]
		get
		{
			return default(GOIMLBEBFIC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1473D70", Offset = "0x1472970", VA = "0x181473D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private BJKDHJOONBP IEPNOLIPIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x800DBB0", Offset = "0x800C7B0", VA = "0x18800DBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IPMBJHJEAGK CCBOMPENMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ECAKKCIBNCI AMMHIMPAPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IEIAFLCCFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x800E190", Offset = "0x800CD90", VA = "0x18800E190", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PPDIOGIPJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x800DC90", Offset = "0x800C890", VA = "0x18800DC90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected BJKDHJOONBP OLIIIAEGOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x800E1A0", Offset = "0x800CDA0", VA = "0x18800E1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x800E580", Offset = "0x800D180", VA = "0x18800E580")]
	public BJKDHJOONBP(GOIMLBEBFIC FHLEPGMLGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x800E430", Offset = "0x800D030", VA = "0x18800E430")]
	public BJKDHJOONBP PLLMLKANMJK(GOIMLBEBFIC NBNBBPHNPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x800E010", Offset = "0x800CC10", VA = "0x18800E010")]
	public BJKDHJOONBP KMMAJAJICOO(GOIMLBEBFIC JKKKBNKFBJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x800DCE0", Offset = "0x800C8E0", VA = "0x18800DCE0")]
	public BJKDHJOONBP ENKPLOICKCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x800DEC0", Offset = "0x800CAC0", VA = "0x18800DEC0")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x800DB00", Offset = "0x800C700", VA = "0x18800DB00")]
	public BJKDHJOONBP AFKGBDJLODC(GOIMLBEBFIC AHLLNEDBFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x800E2C0", Offset = "0x800CEC0", VA = "0x18800E2C0")]
	private static void PJKPHMNFNIH(BJKDHJOONBP NIECEOFKMIH, JFBCJHEAEMP AANPCLICOIE, bool DKKBKHBJNDF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x800E420", Offset = "0x800D020", VA = "0x18800E420", Slot = "9")]
	public void PJKPHMNFNIH(JFBCJHEAEMP HFBNHPDLHHL, bool HNJHMJOCGKA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x800E1C0", Offset = "0x800CDC0", VA = "0x18800E1C0")]
	public static BJKDHJOONBP OJCGKIGGFHF(BJKDHJOONBP NIECEOFKMIH, GOIMLBEBFIC LAJOAMFNGNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface BMJBNPODEKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool HOBANNDKMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LAJILHFCAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<MKFFFMAICOP> BCOAMOOCCFN;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<PLCCGHEKGIM> FFEJIBNHGKG;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CBACPPGGEHG(NOFGCMBKLOA GHKGDJLGKOB, ABEHIAPNEJL AAFHGAGLEFF);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AEKEOOGOKBF(ECAKKCIBNCI ILNKGDCCMNP, ECAKKCIBNCI HMACDOLINHA, int AEHHBDFCBIG, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GICODOIAPOC(ECAKKCIBNCI MCFIMDIPBJP, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GIHEBCGBIAB(OLMJEBKIAHL KCFOPEEKFHL, [Optional] PLCCGHEKGIM MBEBFIOEPGE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HNJCCDPBDOK
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type GJCIAOMMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x80153A0", Offset = "0x8013FA0", VA = "0x1880153A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object MFAGMJBMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8015300", Offset = "0x8013F00", VA = "0x188015300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8015340", Offset = "0x8013F40", VA = "0x188015340")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class KINPFILDOAN : BMJBNPODEKG, IDisposable, LPNKHPBOEKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NOFGCMBKLOA GHKGDJLGKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private ABEHIAPNEJL CJMAHEGCKBE;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HOBANNDKMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8017960", Offset = "0x8016560", VA = "0x188017960", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool LAJILHFCAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8017880", Offset = "0x8016480", VA = "0x188017880", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView HABLGGMFJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8017410", Offset = "0x8016010", VA = "0x188017410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<MKFFFMAICOP> BCOAMOOCCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x80178C0", Offset = "0x80164C0", VA = "0x1880178C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8017580", Offset = "0x8016180", VA = "0x188017580", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<PLCCGHEKGIM> FFEJIBNHGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8017A60", Offset = "0x8016660", VA = "0x188017A60", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x80179C0", Offset = "0x80165C0", VA = "0x1880179C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x80174A0", Offset = "0x80160A0", VA = "0x1880174A0", Slot = "10")]
	public void CBACPPGGEHG(NOFGCMBKLOA GHKGDJLGKOB, ABEHIAPNEJL CJMAHEGCKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8017530", Offset = "0x8016130", VA = "0x188017530", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x80172E0", Offset = "0x8015EE0", VA = "0x1880172E0", Slot = "11")]
	public void AEKEOOGOKBF(ECAKKCIBNCI ILNKGDCCMNP, ECAKKCIBNCI HMACDOLINHA, int AEHHBDFCBIG, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8017620", Offset = "0x8016220", VA = "0x188017620", Slot = "12")]
	public void GICODOIAPOC(ECAKKCIBNCI MCFIMDIPBJP, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8017750", Offset = "0x8016350", VA = "0x188017750", Slot = "13")]
	public void GIHEBCGBIAB(OLMJEBKIAHL KCFOPEEKFHL, [Optional] PLCCGHEKGIM MBEBFIOEPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8017D40", Offset = "0x8016940", VA = "0x188017D40")]
	[LGDDHCFHIFD]
	private void RpcMasterReparentNodes(ECAKKCIBNCI MCFIMDIPBJP, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8017B40", Offset = "0x8016740", VA = "0x188017B40")]
	[LGDDHCFHIFD]
	private void RpcMasterModifyNode(ECAKKCIBNCI ILNKGDCCMNP, ECAKKCIBNCI HMACDOLINHA, int AEHHBDFCBIG, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8018140", Offset = "0x8016D40", VA = "0x188018140")]
	[LGDDHCFHIFD]
	private void RpcReparentNodes(ECAKKCIBNCI MCFIMDIPBJP, int GBPAKHEFLCK, ECAKKCIBNCI AHLLNEDBFNM, int ENPNOIOOJNL, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG, ILALCDLDIIG JHNCLAICFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8018050", Offset = "0x8016C50", VA = "0x188018050")]
	[LGDDHCFHIFD]
	private void RpcModifyNode(ECAKKCIBNCI ILNKGDCCMNP, int AEHHBDFCBIG, int JPECKFDHBKE, Vector3 IDJEELMAACC, Quaternion KGEHBNLCJNG, ILALCDLDIIG JHNCLAICFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8017B00", Offset = "0x8016700", VA = "0x188017B00")]
	[LGDDHCFHIFD]
	private void RpcDeserializeConnectableGraph(OLMJEBKIAHL EAMANPAHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public KINPFILDOAN()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, NHNNCOBBOMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8018740", Offset = "0x8017340", VA = "0x188018740", Slot = "4")]
		private void LNDFLIHLLLN(ECAKKCIBNCI FHEOEBJJJLN, GOIMLBEBFIC EPHCGLFDDNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8018270", Offset = "0x8016E70", VA = "0x188018270", Slot = "5")]
		private void FNNMKMKLLIC(ECAKKCIBNCI FHEOEBJJJLN, GOIMLBEBFIC EPHCGLFDDNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x80188C0", Offset = "0x80174C0", VA = "0x1880188C0", Slot = "6")]
		private void NGLMGLIKJOO(ECAKKCIBNCI FHEOEBJJJLN, GOIMLBEBFIC EPHCGLFDDNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x80184F0", Offset = "0x80170F0", VA = "0x1880184F0", Slot = "7")]
		private void KKFHAGGEOEP(ECAKKCIBNCI FHEOEBJJJLN, GOIMLBEBFIC EPHCGLFDDNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8018A20", Offset = "0x8017620", VA = "0x188018A20", Slot = "8")]
		private NHNNCOBBOMA OIOHBJOJEOB(Transform LMGPODOPMIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x80186E0", Offset = "0x80172E0", VA = "0x1880186E0", Slot = "9")]
		private void KMBFPOBDDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NPKNBCGIKIJ
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF640", Offset = "0x3DCE240", VA = "0x183DCF640")]
	public static CMGIFHOAAJB<T> FEJAOJNCCOG<T>(this LGPCNHIHIDJ EHEGCBFMKDA)
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
