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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80907B0", Offset = "0x808F7B0", VA = "0x1880907B0", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2317030", Offset = "0x2316030", VA = "0x182317030", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8095E80", Offset = "0x8094E80", VA = "0x188095E80")]
		private void MNKCLNFPDFM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8095D10", Offset = "0x8094D10", VA = "0x188095D10")]
		private void JFDGNDHPLAM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8095FF0", Offset = "0x8094FF0", VA = "0x188095FF0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8096320", Offset = "0x8095320", VA = "0x188096320")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class DPAPFPAMPDE : BJCCBEPGIGE, MEIFILLJDCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ODPHFPAEJEK : IEnumerable<HKAGDGALOBK>, IEnumerable, IEnumerator<HKAGDGALOBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private HKAGDGALOBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GOLADBGGMAB localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GOLADBGGMAB <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DPAPFPAMPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MLBLOFEMENF <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private CMDLBMCKJFH <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private CMDLBMCKJFH.KGNGLEEIJOK <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HKAGDGALOBK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public ODPHFPAEJEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8092090", Offset = "0x8091090", VA = "0x188092090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8091C30", Offset = "0x8090C30", VA = "0x188091C30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8091BF0", Offset = "0x8090BF0", VA = "0x188091BF0")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8091C10", Offset = "0x8090C10", VA = "0x188091C10")]
		private void FNICMDFFEAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8092040", Offset = "0x8091040", VA = "0x188092040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8091F90", Offset = "0x8090F90", VA = "0x188091F90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HKAGDGALOBK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8091F90", Offset = "0x8090F90", VA = "0x188091F90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DAJFCHJGPFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DPAPFPAMPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public HLJDEFAJFEC nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DAJFCHJGPFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8083B30", Offset = "0x8082B30", VA = "0x188083B30")]
		internal object CFJKJHFOAPN(HLJDEFAJFEC x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ECMHNECDHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HLJDEFAJFEC child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DAJFCHJGPFF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ECMHNECDHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x80889A0", Offset = "0x80879A0", VA = "0x1880889A0")]
		internal object MPDNFBHCMPO((HLJDEFAJFEC child, HLJDEFAJFEC nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ONIHMLNNEEF JKLPBCFHNNG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ONIHMLNNEEF LIOJDKPEPGN;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly ONIHMLNNEEF EOOFHIEGPEL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly ONIHMLNNEEF BNOJDFDDHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private BNKIBCCPBDC EFLAKLJIAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ALDCMNCNIJH PCPALLGGNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private CPPFMOPAJKK OIEPJHNBFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private COOJGHAECDK JMDACFLNFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private KBGMLCPGKEG EDPKNDPEAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private FOGHOLNHJOB OGCPMPMJKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PFNICHBNDIH CCGPMJFFCDG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CEHLMEAICFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA683F0", Offset = "0xA673F0", VA = "0x180A683F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA683C0", Offset = "0xA673C0", VA = "0x180A683C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CINMECNEFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<HKAGDGALOBK, HKAGDGALOBK> LFFNABNCDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80859B0", Offset = "0x80849B0", VA = "0x1880859B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8087BF0", Offset = "0x8086BF0", VA = "0x188087BF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<HKAGDGALOBK, HKAGDGALOBK> LDHNCHKNEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80856B0", Offset = "0x80846B0", VA = "0x1880856B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8087CA0", Offset = "0x8086CA0", VA = "0x188087CA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<HKAGDGALOBK, HKAGDGALOBK, HKAGDGALOBK> BJBAILHLMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8085AF0", Offset = "0x8084AF0", VA = "0x188085AF0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8088520", Offset = "0x8087520", VA = "0x188088520", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8088930", Offset = "0x8087930", VA = "0x188088930")]
	public DPAPFPAMPDE(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8087E10", Offset = "0x8086E10", VA = "0x188087E10", Slot = "12")]
	public void OCOPJMCPGIB(GameObject GLGAAAMILBJ, JKCBIJDFNAC AEKAINJKFJG, HEHIDMNDMCM JLNNGEFEACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80885D0", Offset = "0x80875D0", VA = "0x1880885D0", Slot = "26")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8087DC0", Offset = "0x8086DC0", VA = "0x188087DC0", Slot = "22")]
	public bool OCHOLNMCOIL(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8086D90", Offset = "0x8085D90", VA = "0x188086D90")]
	private void KGGOPMBBMBH(GOLADBGGMAB NIIJFOGHIMJ, GOLADBGGMAB ICPGCNLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8084710", Offset = "0x8083710", VA = "0x188084710")]
	private void CBFIKMICOIP(GOLADBGGMAB NIIJFOGHIMJ, GOLADBGGMAB HODELBIDFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8088230", Offset = "0x8087230", VA = "0x188088230")]
	private void OHDBDHHNPDI(GOLADBGGMAB NIIJFOGHIMJ, GOLADBGGMAB HODELBIDFMD, GOLADBGGMAB ICPGCNLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80877E0", Offset = "0x80867E0", VA = "0x1880877E0")]
	private void MPKJDECOKMO(GOLADBGGMAB NIIJFOGHIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "13")]
	public void PHBANHJIEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8083F50", Offset = "0x8082F50", VA = "0x188083F50", Slot = "14")]
	public void AMNFOKHCMAP(HKAGDGALOBK GNJGGOGMDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "15")]
	public void JBLNIGGOIJH(HKAGDGALOBK GNJGGOGMDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80873B0", Offset = "0x80863B0", VA = "0x1880873B0", Slot = "17")]
	public void MFGFAACNNFE(HKAGDGALOBK GNJGGOGMDMB, HKAGDGALOBK LJBCBHDDAOM, Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8087510", Offset = "0x8086510", VA = "0x188087510")]
	public void MFGFAACNNFE(GOLADBGGMAB EMABJDLOPJA, GOLADBGGMAB LJBCBHDDAOM, Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8084D40", Offset = "0x8083D40", VA = "0x188084D40")]
	public void EAACKEDALMG(HKAGDGALOBK GNJGGOGMDMB, float DFIAMPCHCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8084260", Offset = "0x8083260", VA = "0x188084260", Slot = "18")]
	public void BCLIMPFHKPC(HKAGDGALOBK CEOHFNFKPMI, int NJJFHOCBAPO, HKAGDGALOBK OLLJPOIEFJH, int KFDANIACAKB, Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8083EA0", Offset = "0x8082EA0", VA = "0x188083EA0")]
	private float ACDBLIBDNJC(GOLADBGGMAB EMABJDLOPJA, GOLADBGGMAB EBJBKAEFOPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80843C0", Offset = "0x80833C0", VA = "0x1880843C0")]
	public void BCLIMPFHKPC(GOLADBGGMAB EMABJDLOPJA, GOLADBGGMAB EBJBKAEFOPM, Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN, bool AAFCKOMMNNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8086FA0", Offset = "0x8085FA0", VA = "0x188086FA0", Slot = "19")]
	public void KPOPGCNJHHA(HKAGDGALOBK GNJGGOGMDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8084500", Offset = "0x8083500", VA = "0x188084500", Slot = "16")]
	public void BMJDEDHHEMD(HKAGDGALOBK GNJGGOGMDMB, HashSet<HKAGDGALOBK> BOMOAJHOJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "20")]
	public PMGHIJOEHAP FDAFGIHPCAN(bool BIALBDGBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "21")]
	public PMGHIJOEHAP AKMPAPAHDJI(HashSet<Guid> KCCKEIMHEII, bool BIALBDGBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8088490", Offset = "0x8087490", VA = "0x188088490", Slot = "23")]
	public void OKCGFMHJILH(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8087D50", Offset = "0x8086D50", VA = "0x188087D50", Slot = "24")]
	public void NNKGBCBMIIG(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8088500", Offset = "0x8087500", VA = "0x188088500", Slot = "25")]
	public void OKCHPNKPOHL(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8084DD0", Offset = "0x8083DD0", VA = "0x188084DD0")]
	private void EGNFEOMIJKE(GOLADBGGMAB EMABJDLOPJA, GOLADBGGMAB EBJBKAEFOPM, Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN, float DFIAMPCHCLH, bool AAFCKOMMNNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80863C0", Offset = "0x80853C0", VA = "0x1880863C0")]
	private void IPGCMOMJFIL(GOLADBGGMAB EMABJDLOPJA, GOLADBGGMAB BKAKGIFOLLC, Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8085940", Offset = "0x8084940", VA = "0x188085940")]
	private void FIEHLHIEMGH(GOLADBGGMAB EMABJDLOPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8085A60", Offset = "0x8084A60", VA = "0x188085A60")]
	[IteratorStateMachine(typeof(ODPHFPAEJEK))]
	public IEnumerable<HKAGDGALOBK> FNHBJKOOKID(GOLADBGGMAB MPAKEJAFLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80851E0", Offset = "0x80841E0", VA = "0x1880851E0")]
	internal HKAGDGALOBK EKLFFDLGCLG(GOLADBGGMAB MPAKEJAFLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8084BB0", Offset = "0x8083BB0", VA = "0x188084BB0")]
	internal GOLADBGGMAB DOHKCNJAFOJ(HKAGDGALOBK GNJGGOGMDMB)
	{
		return default(GOLADBGGMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8085E20", Offset = "0x8084E20", VA = "0x188085E20")]
	private bool ICNJFJPIENL(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8086CD0", Offset = "0x8085CD0", VA = "0x188086CD0")]
	private bool JDGLOEJFECP(HLJDEFAJFEC BMNJGIBEPLM, [Out] HKAGDGALOBK EBJBKAEFOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8085310", Offset = "0x8084310", VA = "0x188085310")]
	private HKAGDGALOBK EKLFFDLGCLG(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8087110", Offset = "0x8086110", VA = "0x188087110")]
	private HKAGDGALOBK LENFNIGCPGE(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8085760", Offset = "0x8084760", VA = "0x188085760")]
	private HKAGDGALOBK FDFPMCHAFEO(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8083300", Offset = "0x8082300", VA = "0x188083300")]
	private static Guid NOCEIGKOHKF(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8085BA0", Offset = "0x8084BA0", VA = "0x188085BA0")]
	private string GMPPPAPPABL(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x80880A0", Offset = "0x80870A0", VA = "0x1880880A0")]
	private void OFFHEBFFPGK(HKAGDGALOBK EMABJDLOPJA, HKAGDGALOBK BKAKGIFOLLC, RigidTransform LELMEFHHAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8085C90", Offset = "0x8084C90", VA = "0x188085C90")]
	private void HLOINEIBHDJ(HKAGDGALOBK BKAKGIFOLLC, HKAGDGALOBK EMABJDLOPJA, RigidTransform LELMEFHHAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8086D30", Offset = "0x8085D30", VA = "0x188086D30")]
	private void KDOLADAGPJB(HKAGDGALOBK BECJAAKDIOB, HKAGDGALOBK EMABJDLOPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8087650", Offset = "0x8086650", VA = "0x188087650")]
	private void MOABFECBEGJ(HKAGDGALOBK EMABJDLOPJA, HKAGDGALOBK EBJBKAEFOPM, RigidTransform LELMEFHHAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80872A0", Offset = "0x80862A0", VA = "0x1880872A0")]
	private void LKHILOOHNBM(GOLADBGGMAB MPAKEJAFLKL, HKAGDGALOBK GNJGGOGMDMB, GOLADBGGMAB HODELBIDFMD, GOLADBGGMAB ICPGCNLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8084930", Offset = "0x8083930", VA = "0x188084930")]
	private void DAFHJDKPKDO(GOLADBGGMAB MPAKEJAFLKL, HKAGDGALOBK GNJGGOGMDMB, HKAGDGALOBK FBBKKJELEBA, HKAGDGALOBK NBJIPLGHAHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JDDDPIHEEFK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MFODFFOPDIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CBHAAKGBAOP container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MFODFFOPDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8090950", Offset = "0x808F950", VA = "0x188090950")]
		internal DPAPFPAMPDE HOKODHAIIFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x808CE80", Offset = "0x808BE80", VA = "0x18808CE80")]
	public static void DIIHGFPAMDD(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x808D000", Offset = "0x808C000", VA = "0x18808D000")]
	public static void OKGALJKDBCD(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JHCECGDDBKJ : JGNMFJJLDBL, GDIHGOFAPJG
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly DPAPFPAMPDE OPCBJKGCHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly KOCJANJFMOG JEALGJBNHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly GFBOBDJJHMH JMDACFLNFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly OLMIKGNNFCF[] EADIIHLECCG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HKAGDGALOBK HHFGKCLKHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x808EC50", Offset = "0x808DC50", VA = "0x18808EC50", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HKAGDGALOBK ELHCLLIHBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x808E610", Offset = "0x808D610", VA = "0x18808E610", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 NMHABJGNCPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x808DAA0", Offset = "0x808CAA0", VA = "0x18808DAA0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion JLONAHEGJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x808E370", Offset = "0x808D370", VA = "0x18808E370", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EKBOIIONLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x808D6D0", Offset = "0x808C6D0", VA = "0x18808D6D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<HKAGDGALOBK> BEMHLNBIFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x808E5E0", Offset = "0x808D5E0", VA = "0x18808E5E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool AHJGAHMOLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD243C0", Offset = "0xD233C0", VA = "0x180D243C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD4B2C0", Offset = "0xD4A2C0", VA = "0x180D4B2C0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x808EE60", Offset = "0x808DE60", VA = "0x18808EE60", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject HLLLIANPJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x808EB60", Offset = "0x808DB60", VA = "0x18808EB60", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x808EB80", Offset = "0x808DB80", VA = "0x18808EB80", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid LBFBFGJPFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x808ECB0", Offset = "0x808DCB0", VA = "0x18808ECB0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MCHEIGBHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x808ED90", Offset = "0x808DD90", VA = "0x18808ED90", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BAPLPNPBCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool ABFKKPMLEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x808DDA0", Offset = "0x808CDA0", VA = "0x18808DDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event DEKEEAMPAEO JOFLIEOJCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x808DEC0", Offset = "0x808CEC0", VA = "0x18808DEC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x808D550", Offset = "0x808C550", VA = "0x18808D550", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event DEKEEAMPAEO NHBGAPAOPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x808E120", Offset = "0x808D120", VA = "0x18808E120", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x808E180", Offset = "0x808D180", VA = "0x18808E180", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event DEKEEAMPAEO OHLLCJPINGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x808E2B0", Offset = "0x808D2B0", VA = "0x18808E2B0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x808E310", Offset = "0x808D310", VA = "0x18808E310", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event BLDOPJFOAHB LKEIDAGLOII
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x808DD00", Offset = "0x808CD00", VA = "0x18808DD00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x808DDF0", Offset = "0x808CDF0", VA = "0x18808DDF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x808EA60", Offset = "0x808DA60", VA = "0x18808EA60")]
	public JHCECGDDBKJ(GOLADBGGMAB NCIBPMAFIKA, RigidbodyEx FBMIODACPPK, KOCJANJFMOG JEALGJBNHKL, OLMIKGNNFCF[] EADIIHLECCG, GFBOBDJJHMH JMDACFLNFAD, BJCCBEPGIGE OPCBJKGCHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x808DE90", Offset = "0x808CE90", VA = "0x18808DE90", Slot = "19")]
	public void IDNMFFEDDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "21")]
	public void JGMJGLGHHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD850", Offset = "0x7DAC850", VA = "0x187DAD850", Slot = "22")]
	public void DIIIHKAFLJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x808D050", Offset = "0x808C050", VA = "0x18808D050", Slot = "20")]
	public void AGMPLOGOAAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x808E3D0", Offset = "0x808D3D0", VA = "0x18808E3D0", Slot = "25")]
	public void MJBJOGFDFGI(int PMHKCALIGKJ, HKAGDGALOBK OLLJPOIEFJH, int BBOFJJCPFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x808E1E0", Offset = "0x808D1E0", VA = "0x18808E1E0", Slot = "26")]
	public void JGAFAIOLMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x808E6D0", Offset = "0x808D6D0", VA = "0x18808E6D0", Slot = "27")]
	public void ONGBEHPFHFB(int PMHKCALIGKJ, HKAGDGALOBK CEOHFNFKPMI, int KGCOJLCLKCD, [Optional] Vector3? ACIPKJDGIOE, [Optional] Quaternion? INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x808D650", Offset = "0x808C650", VA = "0x18808D650", Slot = "28")]
	public void DCAAFIBLIMF(HKAGDGALOBK CEOHFNFKPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x808D140", Offset = "0x808C140", VA = "0x18808D140", Slot = "31")]
	public void BIOPJLJMCCJ(Vector3 BKPFMPJNAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x808D740", Offset = "0x808C740", VA = "0x18808D740", Slot = "29")]
	public void FENBBCKBPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x808DF20", Offset = "0x808CF20", VA = "0x18808DF20", Slot = "30")]
	public void IGMJAODFLLN(int HLGKMAPOEBE, Vector3 GGHGIDAMNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x808DC30", Offset = "0x808CC30", VA = "0x18808DC30", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int PMHKCALIGKJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x808DB00", Offset = "0x808CB00", VA = "0x18808DB00", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int PMHKCALIGKJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xACA7D0", Offset = "0xAC97D0", VA = "0x180ACA7D0", Slot = "42")]
	public Color GetConnectionSlotColor(int PMHKCALIGKJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x808D5B0", Offset = "0x808C5B0", VA = "0x18808D5B0", Slot = "43")]
	public bool CanConnectTo(int PMHKCALIGKJ, HKAGDGALOBK DNAFOHFDBCH, int BMEJIAPIALA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "44")]
	public void ParentChanged(int PMHKCALIGKJ, HKAGDGALOBK MAFDNNIBDBP, int BOKOIFKOAFL, Vector3 PHKKFAPDDMA, Quaternion NJMICBMLEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "45")]
	public void ChildAdded(int PMHKCALIGKJ, HKAGDGALOBK JPHGLBOOFCP, int CAMOPAOEJCI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "46")]
	public void ChildRemoved(int PMHKCALIGKJ, HKAGDGALOBK CIDEBFNBOGH, int DHEMJLDIICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "47")]
	public void ConnectionModified(int PMHKCALIGKJ, HKAGDGALOBK OLLJPOIEFJH, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x808E9B0", Offset = "0x808D9B0", VA = "0x18808E9B0", Slot = "48")]
	public void RootChanged(HKAGDGALOBK BLJBEBHAOOJ, HKAGDGALOBK GALBOOELDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x808DA50", Offset = "0x808CA50", VA = "0x18808DA50", Slot = "23")]
	public void GKIFDNANEEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x808D0A0", Offset = "0x808C0A0", VA = "0x18808D0A0", Slot = "24")]
	public void BBJIADBLELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x808D0F0", Offset = "0x808C0F0", VA = "0x18808D0F0")]
	private void BFBCJLDPFKH(bool KNLFHOPNBND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(HJCGFPPEFMF), new string[] { })]
public class BMJIDHIMIBO : HJCGFPPEFMF, KELFAPLDHJK, GDOFPGECDFM
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AHHMNGBMGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public AHHMNGBMGLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private POOLAKCKNGM IEHKKLCADNA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object LOCHEGAJICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8083920", Offset = "0x8082920", VA = "0x188083920", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x80838D0", Offset = "0x80828D0", VA = "0x1880838D0", Slot = "5")]
	private void FDOELKOHJIM(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x12C4280", Offset = "0x12C3280", VA = "0x1812C4280", Slot = "6")]
	private void BBFHDNOELJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BMJIDHIMIBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(BJCCBEPGIGE), new string[] { "Ignore", "Mock" })]
public class FGJHMFEBIJO : BJCCBEPGIGE, MEIFILLJDCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CEHLMEAICFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CINMECNEFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<HKAGDGALOBK, HKAGDGALOBK> LFFNABNCDFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8088F00", Offset = "0x8087F00", VA = "0x188088F00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8089060", Offset = "0x8088060", VA = "0x188089060", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<HKAGDGALOBK, HKAGDGALOBK> LDHNCHKNEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8088E50", Offset = "0x8087E50", VA = "0x188088E50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8089110", Offset = "0x8088110", VA = "0x188089110", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<HKAGDGALOBK, HKAGDGALOBK, HKAGDGALOBK> BJBAILHLMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8088FB0", Offset = "0x8087FB0", VA = "0x188088FB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x80891C0", Offset = "0x80881C0", VA = "0x1880891C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "26")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "12")]
	public void OCOPJMCPGIB(GameObject GLGAAAMILBJ, JKCBIJDFNAC AEKAINJKFJG, HEHIDMNDMCM CONGFNFMFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "13")]
	public void PHBANHJIEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "14")]
	public void AMNFOKHCMAP(HKAGDGALOBK GNJGGOGMDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "15")]
	public void JBLNIGGOIJH(HKAGDGALOBK GNJGGOGMDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "16")]
	public void BMJDEDHHEMD(HKAGDGALOBK GNJGGOGMDMB, HashSet<HKAGDGALOBK> BOMOAJHOJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "17")]
	public void MFGFAACNNFE(HKAGDGALOBK GNJGGOGMDMB, HKAGDGALOBK LJBCBHDDAOM, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "18")]
	public void BCLIMPFHKPC(HKAGDGALOBK GNJGGOGMDMB, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "19")]
	public void KPOPGCNJHHA(HKAGDGALOBK GNJGGOGMDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "20")]
	public PMGHIJOEHAP FDAFGIHPCAN(bool BIALBDGBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "21")]
	public PMGHIJOEHAP AKMPAPAHDJI(HashSet<Guid> KCCKEIMHEII, bool BIALBDGBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "22")]
	public bool OCHOLNMCOIL(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "23")]
	public void OKCGFMHJILH(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "24")]
	public void NNKGBCBMIIG(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "25")]
	public void OKCHPNKPOHL(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FGJHMFEBIJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HKAGDGALOBK : GDIHGOFAPJG, IEquatable<HKAGDGALOBK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GDIHGOFAPJG
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HKAGDGALOBK HHFGKCLKHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject HLLLIANPJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid LBFBFGJPFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int MCHEIGBHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BAPLPNPBCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int PMHKCALIGKJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int PMHKCALIGKJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int PMHKCALIGKJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int PMHKCALIGKJ, HKAGDGALOBK DNAFOHFDBCH, int IJNJLBNLJEI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int PMHKCALIGKJ, HKAGDGALOBK MAFDNNIBDBP, int BOKOIFKOAFL, Vector3 PHKKFAPDDMA, Quaternion NJMICBMLEEM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int PMHKCALIGKJ, HKAGDGALOBK JPHGLBOOFCP, int CAMOPAOEJCI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int PMHKCALIGKJ, HKAGDGALOBK CIDEBFNBOGH, int DHEMJLDIICA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int PMHKCALIGKJ, HKAGDGALOBK OLLJPOIEFJH, int ICCBLCEGCGO, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(HKAGDGALOBK BLJBEBHAOOJ, HKAGDGALOBK GALBOOELDHG);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BJCCBEPGIGE : MEIFILLJDCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CEHLMEAICFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CINMECNEFID
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HKAGDGALOBK, HKAGDGALOBK> LFFNABNCDFI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HKAGDGALOBK, HKAGDGALOBK> LDHNCHKNEBC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<HKAGDGALOBK, HKAGDGALOBK, HKAGDGALOBK> BJBAILHLMLP;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OCOPJMCPGIB(GameObject GLGAAAMILBJ, JKCBIJDFNAC AEKAINJKFJG, HEHIDMNDMCM PDOFLBCHBKH);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PHBANHJIEKG();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMNFOKHCMAP(HKAGDGALOBK GNJGGOGMDMB);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JBLNIGGOIJH(HKAGDGALOBK GNJGGOGMDMB);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BMJDEDHHEMD(HKAGDGALOBK GNJGGOGMDMB, HashSet<HKAGDGALOBK> BOMOAJHOJKO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MFGFAACNNFE(HKAGDGALOBK GNJGGOGMDMB, HKAGDGALOBK LJBCBHDDAOM, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BCLIMPFHKPC(HKAGDGALOBK GNJGGOGMDMB, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KPOPGCNJHHA(HKAGDGALOBK GNJGGOGMDMB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PMGHIJOEHAP FDAFGIHPCAN(bool BIALBDGBAMK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PMGHIJOEHAP AKMPAPAHDJI(HashSet<Guid> KCCKEIMHEII, bool BIALBDGBAMK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OCHOLNMCOIL(HLJDEFAJFEC BMNJGIBEPLM);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OKCGFMHJILH(PMGHIJOEHAP BKGCMOAONFI);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NNKGBCBMIIG(PMGHIJOEHAP BKGCMOAONFI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OKCHPNKPOHL(PMGHIJOEHAP BKGCMOAONFI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface COOJGHAECDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OAFDKAKOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKAGDGALOBK FDFPMCHAFEO(int JMFNCMHOPBO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HKAGDGALOBK LENFNIGCPGE(Guid LNAIJECMLPK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KMKDLECELJF(HKAGDGALOBK GNJGGOGMDMB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ONKECFFGMBD();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKMJFKAICHM(HKAGDGALOBK JEALGJBNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface GFBOBDJJHMH
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ABFKKPMLEEN(KOCJANJFMOG JEALGJBNHKL);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OAMIJHCNNBL(KOCJANJFMOG JEALGJBNHKL);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string JEOAAFAGAFB(KOCJANJFMOG JEALGJBNHKL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid HJABMKJMAFC(KOCJANJFMOG JEALGJBNHKL);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HGKGCMPABOF(KOCJANJFMOG JEALGJBNHKL);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJAIFGHOOKC(KOCJANJFMOG JEALGJBNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void DEKEEAMPAEO(HKAGDGALOBK CEOHFNFKPMI, int HMDFBNMLODJ, HKAGDGALOBK OLLJPOIEFJH, int GFMOMLCOBLJ, [Optional] Vector3? ACIPKJDGIOE, [Optional] Quaternion? INKBIHGIPOO);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void BLDOPJFOAHB(HKAGDGALOBK BLJBEBHAOOJ, HKAGDGALOBK GALBOOELDHG);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KOCJANJFMOG : HKAGDGALOBK, GDIHGOFAPJG, IEquatable<HKAGDGALOBK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JGNMFJJLDBL : GDIHGOFAPJG
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HKAGDGALOBK ELHCLLIHBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<HKAGDGALOBK> BEMHLNBIFIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 NMHABJGNCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion JLONAHEGJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool EKBOIIONLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool AHJGAHMOLND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event DEKEEAMPAEO JOFLIEOJCAJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event DEKEEAMPAEO NHBGAPAOPHC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event DEKEEAMPAEO OHLLCJPINGB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event BLDOPJFOAHB LKEIDAGLOII;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IDNMFFEDDDN();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AGMPLOGOAAB();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JGMJGLGHHHP();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DIIIHKAFLJI();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GKIFDNANEEB();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BBJIADBLELM();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MJBJOGFDFGI(int PMHKCALIGKJ, HKAGDGALOBK OLLJPOIEFJH, int BBOFJJCPFFI);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JGAFAIOLMDE();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ONGBEHPFHFB(int PMHKCALIGKJ, HKAGDGALOBK CEOHFNFKPMI, int KGCOJLCLKCD, [Optional] Vector3? ACIPKJDGIOE, [Optional] Quaternion? INKBIHGIPOO);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DCAAFIBLIMF(HKAGDGALOBK CEOHFNFKPMI);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FENBBCKBPOM();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IGMJAODFLLN(int HLGKMAPOEBE, Vector3 GGHGIDAMNEE);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BIOPJLJMCCJ(Vector3 BKPFMPJNAGN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OLMIKGNNFCF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 LMPOFMHCONF
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
public interface JKCBIJDFNAC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DALOILMHNIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NEGECIBDEEK LFMOGIDMDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, JKCBIJDFNAC
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
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public NEGECIBDEEK LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8083A20", Offset = "0x8082A20", VA = "0x188083A20")]
		public static ConnectableConfigData CKNBEGPNNMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8083AE0", Offset = "0x8082AE0", VA = "0x188083AE0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual BLFEANPIJPL, bool HMJHMHHLLHF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LAIFDLAPOLH : IEquatable<LAIFDLAPOLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public HKAGDGALOBK GNJGGOGMDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int GBBHBDCDACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int ICCBLCEGCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 ACIPKJDGIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion INKBIHGIPOO;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x808F460", Offset = "0x808E460", VA = "0x18808F460")]
	public LAIFDLAPOLH(HKAGDGALOBK GNJGGOGMDMB, int GBBHBDCDACM, int ICCBLCEGCGO, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x808F3C0", Offset = "0x808E3C0", VA = "0x18808F3C0")]
	public LAIFDLAPOLH(HKAGDGALOBK GNJGGOGMDMB, int GBBHBDCDACM, int ICCBLCEGCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x808F4C0", Offset = "0x808E4C0", VA = "0x18808F4C0")]
	public LAIFDLAPOLH(HKAGDGALOBK GNJGGOGMDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x808EF40", Offset = "0x808DF40", VA = "0x18808EF40", Slot = "4")]
	public bool Equals(LAIFDLAPOLH EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x808EFF0", Offset = "0x808DFF0", VA = "0x18808EFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class DMOGLEHOIFI : NAKMILOJHKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform PLPGMCABFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private NEGECIBDEEK EJBJPCAFJEB;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A860", Offset = "0x7A29860", VA = "0x187A2A860", Slot = "4")]
	public void OCOPJMCPGIB(Transform PLPGMCABFBF, NEGECIBDEEK EJBJPCAFJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8083DD0", Offset = "0x8082DD0", VA = "0x188083DD0", Slot = "5")]
	public NEGECIBDEEK HMDLIDMPKBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8083D60", Offset = "0x8082D60", VA = "0x188083D60", Slot = "6")]
	public void ALGOPCFNEIJ(NEGECIBDEEK KAFDFKPMGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DMOGLEHOIFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class PEBGPLAELBK : IDisposable, LHLJECBFMLP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KCMGDAGGNHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HKAGDGALOBK oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public HKAGDGALOBK newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KCMGDAGGNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x808EE80", Offset = "0x808DE80", VA = "0x18808EE80")]
		internal bool PIKCEGFOCIN(CEDAFAFMGDJ node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IMFJLJINCOG LOCELJOBKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private IENLBPECIAL MDCDBBHBDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private FEIFLCGPHCH JFIAKHFDPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool HMJHMHHLLHF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly ONIHMLNNEEF JJCHOGIADKF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CEDAFAFMGDJ AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x80939F0", Offset = "0x80929F0", VA = "0x1880939F0")]
	public bool EOAIPMBHFAC([In] PANBCIJMJFJ INCJDDLACNP, bool IMBKEOGBELE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8094390", Offset = "0x8093390", VA = "0x188094390")]
	private bool LDHIHHCDONJ([In] PANBCIJMJFJ INCJDDLACNP, bool IMBKEOGBELE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8095910", Offset = "0x8094910", VA = "0x188095910")]
	public PEBGPLAELBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8094E20", Offset = "0x8093E20", VA = "0x188094E20", Slot = "5")]
	public void OCOPJMCPGIB(BJCCBEPGIGE PAOKFDJPALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8094A10", Offset = "0x8093A10", VA = "0x188094A10", Slot = "17")]
	public void NOGMAEKEEEB(NADNAOCKDOO HCEFPMMOBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8095830", Offset = "0x8094830", VA = "0x188095830", Slot = "12")]
	public void PDJLIKOAJGO(Func<HKAGDGALOBK, bool> EGGAIGKCDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8095700", Offset = "0x8094700", VA = "0x188095700")]
	private void PDJLIKOAJGO(IMFJLJINCOG ABOLKPCCJOL, Func<HKAGDGALOBK, bool> EGGAIGKCDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x80928C0", Offset = "0x80918C0", VA = "0x1880928C0", Slot = "11")]
	public void BHHHPBDNKLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8094960", Offset = "0x8093960", VA = "0x188094960", Slot = "8")]
	public bool MOKFCKKJBNB(HKAGDGALOBK MMHIMJKGLKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8094FF0", Offset = "0x8093FF0", VA = "0x188094FF0")]
	private bool PAFALKEEEBJ(HKAGDGALOBK JJGHDPLEPML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8093220", Offset = "0x8092220", VA = "0x188093220")]
	private static bool DFMHPPBBJPJ(HKAGDGALOBK JJGHDPLEPML, IMFJLJINCOG OBKMPLDLJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8094A40", Offset = "0x8093A40", VA = "0x188094A40")]
	private void OBIGLDOJOIA(Transform GKCBIILLKHA, IMFJLJINCOG BGBLKAOJPAA, IMFJLJINCOG[] DOKCDIICOLG, HKAGDGALOBK KKGBJGCBHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8092530", Offset = "0x8091530", VA = "0x188092530")]
	private LAIFDLAPOLH BECPNEDOIGD(Transform KIEHFGAMALG, LAIFDLAPOLH CONAPBLMGMG)
	{
		return default(LAIFDLAPOLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8093BF0", Offset = "0x8092BF0", VA = "0x188093BF0")]
	private static bool IOKAAPKNBGB(IMFJLJINCOG OBKMPLDLJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8092F20", Offset = "0x8091F20", VA = "0x188092F20", Slot = "9")]
	public bool CGJNMHFNHIK(HKAGDGALOBK OMPBPBPIHDF, int KGCOJLCLKCD, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8092920", Offset = "0x8091920", VA = "0x188092920")]
	private bool BJBLFNGMADD(HKAGDGALOBK OMPBPBPIHDF, int KGCOJLCLKCD, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8093870", Offset = "0x8092870", VA = "0x188093870")]
	private static void EHAIHMIMHEA(HKAGDGALOBK OMPBPBPIHDF, int KGCOJLCLKCD, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO, IMFJLJINCOG MDAJMCCJCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8094ED0", Offset = "0x8093ED0", VA = "0x188094ED0")]
	private void OFFHEBFFPGK(HKAGDGALOBK LGGHCBACILP, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8093E20", Offset = "0x8092E20", VA = "0x188093E20")]
	private void IPNLIFCADCO(IMFJLJINCOG ABOLKPCCJOL, HKAGDGALOBK FBBKKJELEBA, HKAGDGALOBK NBJIPLGHAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8093DB0", Offset = "0x8092DB0", VA = "0x188093DB0")]
	private void IPNLIFCADCO(HKAGDGALOBK GNJGGOGMDMB, HKAGDGALOBK FBBKKJELEBA, HKAGDGALOBK NBJIPLGHAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8093150", Offset = "0x8092150", VA = "0x188093150")]
	private void DAFHJDKPKDO(HKAGDGALOBK GNJGGOGMDMB, HKAGDGALOBK FBBKKJELEBA, HKAGDGALOBK NBJIPLGHAHH, bool FMFCCKHKEKM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8093050", Offset = "0x8092050", VA = "0x188093050")]
	private void DAFHJDKPKDO(IMFJLJINCOG NKBKNNLLHKF, HKAGDGALOBK KKGBJGCBHNG, HKAGDGALOBK GALBOOELDHG, bool FMFCCKHKEKM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8093AD0", Offset = "0x8092AD0", VA = "0x188093AD0")]
	private void HLOINEIBHDJ(HKAGDGALOBK EMABJDLOPJA, int KGCOJLCLKCD, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8093FA0", Offset = "0x8092FA0", VA = "0x188093FA0")]
	private void KDOLADAGPJB(CEDAFAFMGDJ EBJBKAEFOPM, CEDAFAFMGDJ IMMCCHBCKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8094230", Offset = "0x8093230", VA = "0x188094230", Slot = "18")]
	public HKAGDGALOBK KOOIGDBBJJH(HKAGDGALOBK GNJGGOGMDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8092B70", Offset = "0x8091B70", VA = "0x188092B70", Slot = "13")]
	public void BMJDEDHHEMD(HKAGDGALOBK GNJGGOGMDMB, HashSet<HKAGDGALOBK> MHEEKFJDBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8092680", Offset = "0x8091680", VA = "0x188092680", Slot = "14")]
	public List<HKAGDGALOBK> BFJEHHHGKBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8092F80", Offset = "0x8091F80", VA = "0x188092F80")]
	protected CEDAFAFMGDJ CIACOOAEHCI(CEDAFAFMGDJ ABOLKPCCJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8094970", Offset = "0x8093970", VA = "0x188094970")]
	protected IMFJLJINCOG[] NBDINFFCDDF(IMFJLJINCOG OBKMPLDLJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8093E90", Offset = "0x8092E90", VA = "0x188093E90")]
	protected bool KBIPFIKEJOG(HKAGDGALOBK GNJGGOGMDMB, [Out] IMFJLJINCOG ABOLKPCCJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8094100", Offset = "0x8093100", VA = "0x188094100", Slot = "15")]
	public bool KGGNALNOKKB(HKAGDGALOBK GNJGGOGMDMB, [Out] LAIFDLAPOLH MEFCBJKMEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x80928E0", Offset = "0x80918E0", VA = "0x1880928E0")]
	protected IMFJLJINCOG BHICDKOJJFE(LAIFDLAPOLH NCIDNCAEDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x80931C0", Offset = "0x80921C0", VA = "0x1880931C0", Slot = "10")]
	public bool DDCLFEILLCF(HKAGDGALOBK LGGHCBACILP, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x80932D0", Offset = "0x80922D0", VA = "0x1880932D0")]
	private bool DGHEKMCCIAE(HKAGDGALOBK LGGHCBACILP, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8093A00", Offset = "0x8092A00", VA = "0x188093A00")]
	private static bool GJGNIOHPGBB(IMFJLJINCOG KIOGDLKPCEE, LAIFDLAPOLH DBJMPNBKNDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x80939F0", Offset = "0x80929F0", VA = "0x1880939F0", Slot = "7")]
	private bool GENBNGALJDG([In] PANBCIJMJFJ INCJDDLACNP, bool IMBKEOGBELE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class HNKDHAEGBJO : BJCCBEPGIGE, MEIFILLJDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly CBHAAKGBAOP PFJIPDCNGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly FEIFLCGPHCH JFIAKHFDPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly NIOLOFOGCJG DCICKMFBBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly AKKCJNBJECI JFOFGGINHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly LHLJECBFMLP BKGCMOAONFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal BOLEAHOPGDF JMDACFLNFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal PBOKEHNNOJL LHHAPIMNBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal IENLBPECIAL ABACFAJCJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool HMJHMHHLLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool KGHPBNFFIPN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HHCPFBGIKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAB3ED0", Offset = "0xAB2ED0", VA = "0x180AB3ED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAB3EE0", Offset = "0xAB2EE0", VA = "0x180AB3EE0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CEHLMEAICFL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xAD32C0", Offset = "0xAD22C0", VA = "0x180AD32C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xAD32B0", Offset = "0xAD22B0", VA = "0x180AD32B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool CINMECNEFID
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HKAGDGALOBK, HKAGDGALOBK> LFFNABNCDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x808AD20", Offset = "0x8089D20", VA = "0x18808AD20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x808B4A0", Offset = "0x808A4A0", VA = "0x18808B4A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HKAGDGALOBK, HKAGDGALOBK> LDHNCHKNEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x808A8F0", Offset = "0x80898F0", VA = "0x18808A8F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x808B500", Offset = "0x808A500", VA = "0x18808B500", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HKAGDGALOBK, HKAGDGALOBK, HKAGDGALOBK> BJBAILHLMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x808AD80", Offset = "0x8089D80", VA = "0x18808AD80", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x808BDC0", Offset = "0x808ADC0", VA = "0x18808BDC0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x808BEF0", Offset = "0x808AEF0", VA = "0x18808BEF0")]
	public HNKDHAEGBJO(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x808B660", Offset = "0x808A660", VA = "0x18808B660", Slot = "12")]
	public void OCOPJMCPGIB(GameObject GLGAAAMILBJ, JKCBIJDFNAC AEKAINJKFJG, HEHIDMNDMCM PDOFLBCHBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x808BE20", Offset = "0x808AE20", VA = "0x18808BE20", Slot = "26")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x808BD40", Offset = "0x808AD40", VA = "0x18808BD40", Slot = "13")]
	public void PHBANHJIEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x808A580", Offset = "0x8089580", VA = "0x18808A580", Slot = "14")]
	public void AMNFOKHCMAP(HKAGDGALOBK GNJGGOGMDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x808AF10", Offset = "0x8089F10", VA = "0x18808AF10", Slot = "15")]
	public void JBLNIGGOIJH(HKAGDGALOBK GNJGGOGMDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x808B610", Offset = "0x808A610", VA = "0x18808B610", Slot = "22")]
	public bool OCHOLNMCOIL(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x808A7E0", Offset = "0x80897E0", VA = "0x18808A7E0")]
	internal bool DGHEKMCCIAE([In] PANBCIJMJFJ INCJDDLACNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x808AF70", Offset = "0x8089F70", VA = "0x18808AF70")]
	internal bool KALCINGNNCE([In] PANBCIJMJFJ INCJDDLACNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x808A200", Offset = "0x8089200", VA = "0x18808A200")]
	internal void AJIFPGEGIDG(HKAGDGALOBK GNJGGOGMDMB, int DHLEPFNBACE, bool IMBKEOGBELE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x808AF10", Offset = "0x8089F10", VA = "0x18808AF10")]
	internal bool PANPPMMNHBO(HKAGDGALOBK JJAPNCKAABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x808ADE0", Offset = "0x8089DE0", VA = "0x18808ADE0")]
	internal bool HLAHJLCCAOK(HKAGDGALOBK OMPBPBPIHDF, int KGCOJLCLKCD, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x808A6E0", Offset = "0x80896E0", VA = "0x18808A6E0", Slot = "16")]
	public void BMJDEDHHEMD(HKAGDGALOBK GNJGGOGMDMB, HashSet<HKAGDGALOBK> BOMOAJHOJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x808B290", Offset = "0x808A290", VA = "0x18808B290", Slot = "17")]
	public void MFGFAACNNFE(HKAGDGALOBK OMPBPBPIHDF, HKAGDGALOBK LJBCBHDDAOM, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x808A5A0", Offset = "0x80895A0", VA = "0x18808A5A0", Slot = "18")]
	public void BCLIMPFHKPC(HKAGDGALOBK LGGHCBACILP, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x808B0C0", Offset = "0x808A0C0", VA = "0x18808B0C0", Slot = "19")]
	public void KPOPGCNJHHA(HKAGDGALOBK LGGHCBACILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x808AAD0", Offset = "0x8089AD0", VA = "0x18808AAD0")]
	public void FEAJFOMFPNE([Optional] IALDHONKEJC KANIKAPEEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x808BC70", Offset = "0x808AC70", VA = "0x18808BC70", Slot = "23")]
	public void OKCGFMHJILH(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x808A950", Offset = "0x8089950", VA = "0x18808A950", Slot = "20")]
	public PMGHIJOEHAP FDAFGIHPCAN(bool BIALBDGBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x808A3E0", Offset = "0x80893E0", VA = "0x18808A3E0", Slot = "21")]
	public PMGHIJOEHAP AKMPAPAHDJI(HashSet<Guid> KCCKEIMHEII, bool BIALBDGBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x808BD00", Offset = "0x808AD00", VA = "0x18808BD00", Slot = "25")]
	public void OKCHPNKPOHL(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x808B560", Offset = "0x808A560", VA = "0x18808B560", Slot = "24")]
	public void NNKGBCBMIIG(PMGHIJOEHAP BKGCMOAONFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class FEIFLCGPHCH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly MDNONHHFIOF<HKAGDGALOBK, HKAGDGALOBK> LFFNABNCDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly MDNONHHFIOF<HKAGDGALOBK, HKAGDGALOBK> LDHNCHKNEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly GHCPNHMBOCA<HKAGDGALOBK, HKAGDGALOBK, HKAGDGALOBK> BJBAILHLMLP;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8088D30", Offset = "0x8087D30", VA = "0x188088D30")]
	public FEIFLCGPHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	public void OCOPJMCPGIB(HNKDHAEGBJO PAOKFDJPALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8088C70", Offset = "0x8087C70", VA = "0x188088C70")]
	public void GNPECBCLEEN(HKAGDGALOBK EBJBKAEFOPM, HKAGDGALOBK EMABJDLOPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8088CD0", Offset = "0x8087CD0", VA = "0x188088CD0")]
	public void HNKMDJGGFMI(HKAGDGALOBK EBJBKAEFOPM, HKAGDGALOBK EMABJDLOPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8088BF0", Offset = "0x8087BF0", VA = "0x188088BF0")]
	public void GGANKIKMDEM(HKAGDGALOBK BECJAAKDIOB, HKAGDGALOBK BKAKGIFOLLC, HKAGDGALOBK EMABJDLOPJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class NIOLOFOGCJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HNKDHAEGBJO PAOKFDJPALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private PBOKEHNNOJL LHHAPIMNBBP;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NIOLOFOGCJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x80919A0", Offset = "0x80909A0", VA = "0x1880919A0")]
	public void OCOPJMCPGIB(HNKDHAEGBJO PAOKFDJPALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8091950", Offset = "0x8090950", VA = "0x188091950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8091960", Offset = "0x8090960", VA = "0x188091960")]
	private void JEGLGOBDLHE(DOHKIBLNJFC KJENEIANJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x80918E0", Offset = "0x80908E0", VA = "0x1880918E0")]
	private void DKJJDCIGHLD(IALDHONKEJC IFFACPNEAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x80917D0", Offset = "0x80907D0", VA = "0x1880917D0")]
	public void DHDCJKDDIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8091AE0", Offset = "0x8090AE0", VA = "0x188091AE0")]
	public void PANNLHIKKFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PAMLFOLCGPD
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IGLIBBAMLIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public CBHAAKGBAOP container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public IGLIBBAMLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x808C2E0", Offset = "0x808B2E0", VA = "0x18808C2E0")]
		internal HNKDHAEGBJO HOKODHAIIFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8092170", Offset = "0x8091170", VA = "0x188092170")]
	public static void DIIHGFPAMDD(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8092370", Offset = "0x8091370", VA = "0x188092370")]
	public static void OKGALJKDBCD(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class NGHDPJILJFM : IDisposable, IENLBPECIAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, NEGECIBDEEK> FLOIKINLBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NADNAOCKDOO HKADJDPGLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NAKMILOJHKL DAKOFAPAGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private LHLJECBFMLP BKGCMOAONFI;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker MJJLHGKKJLK;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x80916F0", Offset = "0x80906F0", VA = "0x1880916F0")]
	public NGHDPJILJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8091650", Offset = "0x8090650", VA = "0x188091650", Slot = "7")]
	public void OCOPJMCPGIB(LHLJECBFMLP BKGCMOAONFI, NAKMILOJHKL DAKOFAPAGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8090BB0", Offset = "0x808FBB0", VA = "0x188090BB0", Slot = "5")]
	public void FONOIKALLDF(CEDAFAFMGDJ NGKEPNBGCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8090E50", Offset = "0x808FE50", VA = "0x188090E50", Slot = "9")]
	public void JPMLDAONBLK(CEDAFAFMGDJ BCAJDMJGAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8090FC0", Offset = "0x808FFC0", VA = "0x188090FC0", Slot = "8")]
	public void KLGHAOILOFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8091180", Offset = "0x8090180", VA = "0x188091180", Slot = "10")]
	public void NAHJMLCPCFM(CEDAFAFMGDJ LIFKFPCKDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x80914D0", Offset = "0x80904D0", VA = "0x1880914D0", Slot = "11")]
	public void NNGGGBKGJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8090A00", Offset = "0x808FA00", VA = "0x188090A00")]
	private bool CNHEOHLBJPL(CEDAFAFMGDJ FPGAPNMDKDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class AKKCJNBJECI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct LCJBFPILDHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly IMFJLJINCOG EGMOOOBJJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> KCCKEIMHEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly HLJDEFAJFEC JNOEAPAMJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly HLJDEFAJFEC AKIIJAJCDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool BIALBDGBAMK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool IBPDEKPMJOG
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x808FA20", Offset = "0x808EA20", VA = "0x18808FA20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x808FE20", Offset = "0x808EE20", VA = "0x18808FE20")]
		public LCJBFPILDHP(IMFJLJINCOG EGMOOOBJJFA, HashSet<Guid> KCCKEIMHEII, bool BIALBDGBAMK, [Optional] HLJDEFAJFEC JNOEAPAMJON, [Optional] HLJDEFAJFEC AKIIJAJCDHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x808F710", Offset = "0x808E710", VA = "0x18808F710")]
		public HLJDEFAJFEC FBGBLPHHDGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x808FB40", Offset = "0x808EB40", VA = "0x18808FB40")]
		private HLJDEFAJFEC MOHEJLKPLHJ([Out] HLJDEFAJFEC HPMABNJPPAG, [Out] HLJDEFAJFEC NDNEMDCBJCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x808FC00", Offset = "0x808EC00", VA = "0x18808FC00")]
		private HLJDEFAJFEC PALGJIBGPBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x808F8B0", Offset = "0x808E8B0", VA = "0x18808F8B0")]
		private void GFNKGOLBOMN(HLJDEFAJFEC FFGICKKLBLO, HLJDEFAJFEC OMGNBIJGMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x808F550", Offset = "0x808E550", VA = "0x18808F550")]
		private void CLPIHIMIOFA(HLJDEFAJFEC HPMABNJPPAG, HLJDEFAJFEC NDNEMDCBJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private HNKDHAEGBJO PAOKFDJPALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private LHLJECBFMLP BKGCMOAONFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private IENLBPECIAL MDCDBBHBDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private PBOKEHNNOJL LHHAPIMNBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool NEDPAHPNFIF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool PGECBOJPPDI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x80836D0", Offset = "0x80826D0", VA = "0x1880836D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool HHCPFBGIKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8082DE0", Offset = "0x8081DE0", VA = "0x188082DE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8081E50", Offset = "0x8080E50", VA = "0x188081E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x80835D0", Offset = "0x80825D0", VA = "0x1880835D0")]
	public void OCOPJMCPGIB(HNKDHAEGBJO PAOKFDJPALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8081930", Offset = "0x8080930", VA = "0x188081930")]
	public PMGHIJOEHAP FDAFGIHPCAN(bool BIALBDGBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8081030", Offset = "0x8080030", VA = "0x188081030")]
	public PMGHIJOEHAP AKMPAPAHDJI(HashSet<Guid> KCCKEIMHEII, bool BIALBDGBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8083640", Offset = "0x8082640", VA = "0x188083640")]
	public void OKCGFMHJILH(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8083260", Offset = "0x8082260", VA = "0x188083260")]
	public void NNKGBCBMIIG(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x80812F0", Offset = "0x80802F0", VA = "0x1880812F0")]
	public void CIDIEPEAPMN(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8082E20", Offset = "0x8081E20", VA = "0x188082E20")]
	private void MLPKPEOOLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8081C20", Offset = "0x8080C20", VA = "0x188081C20")]
	private HLJDEFAJFEC FMHEHGKMDMK(IMFJLJINCOG ABOLKPCCJOL, bool BIALBDGBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8083010", Offset = "0x8082010", VA = "0x188083010")]
	private static void MOIEJBJJMGP(IMFJLJINCOG ABOLKPCCJOL, bool BIALBDGBAMK, HLJDEFAJFEC BMNJGIBEPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x80813B0", Offset = "0x80803B0", VA = "0x1880813B0")]
	private void ECKEJCAOJBC(IMFJLJINCOG ABOLKPCCJOL, bool BIALBDGBAMK, HLJDEFAJFEC BMNJGIBEPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8081320", Offset = "0x8080320", VA = "0x188081320")]
	private HLJDEFAJFEC DGBDPMDPABG(IMFJLJINCOG EGMOOOBJJFA, HashSet<Guid> KCCKEIMHEII, bool BIALBDGBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8082760", Offset = "0x8081760", VA = "0x188082760")]
	private bool ILGCHFOAKEA(PMGHIJOEHAP PCJBLEJIMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8081F60", Offset = "0x8080F60", VA = "0x188081F60")]
	private bool ICNJFJPIENL(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8082E00", Offset = "0x8081E00", VA = "0x188082E00")]
	private bool LIAPODIGLNN(PMGHIJOEHAP BKGCMOAONFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x80811D0", Offset = "0x80801D0", VA = "0x1880811D0")]
	private static bool BAPPNILNJIC(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8083340", Offset = "0x8082340", VA = "0x188083340")]
	public static bool OCHOLNMCOIL(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x80815D0", Offset = "0x80805D0", VA = "0x1880815D0")]
	private HKAGDGALOBK EKLFFDLGCLG(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8081AA0", Offset = "0x8080AA0", VA = "0x188081AA0")]
	private HKAGDGALOBK FDFPMCHAFEO(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x80825D0", Offset = "0x80815D0", VA = "0x1880825D0")]
	private HKAGDGALOBK IKJHKBIDFBF(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8083300", Offset = "0x8082300", VA = "0x188083300")]
	private static Guid NOCEIGKOHKF(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8081E70", Offset = "0x8080E70", VA = "0x188081E70")]
	private string GMPPPAPPABL(HLJDEFAJFEC BMNJGIBEPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x80829F0", Offset = "0x80819F0", VA = "0x1880829F0")]
	private bool JIKFDNLLMGP(IMFJLJINCOG ABOLKPCCJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8082B80", Offset = "0x8081B80", VA = "0x188082B80")]
	private static void KCNGHDMFGFN(IMFJLJINCOG EGMOOOBJJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public AKKCJNBJECI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct PANBCIJMJFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public HKAGDGALOBK EMABJDLOPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public HKAGDGALOBK EBJBKAEFOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int KGCOJLCLKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int BBOFJJCPFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 ACIPKJDGIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion INKBIHGIPOO;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LAIFDLAPOLH EJEAAHBPHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8092420", Offset = "0x8091420", VA = "0x188092420")]
		get
		{
			return default(LAIFDLAPOLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LAIFDLAPOLH BKCPKAKJNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x80923F0", Offset = "0x80913F0", VA = "0x1880923F0")]
		get
		{
			return default(LAIFDLAPOLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x80924C0", Offset = "0x80914C0", VA = "0x1880924C0")]
	public PANBCIJMJFJ(HKAGDGALOBK EMABJDLOPJA, HKAGDGALOBK EBJBKAEFOPM, int KGCOJLCLKCD, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface LHLJECBFMLP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CEDAFAFMGDJ AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCOPJMCPGIB(BJCCBEPGIGE PAOKFDJPALE);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EOAIPMBHFAC([In] PANBCIJMJFJ INCJDDLACNP, bool IMBKEOGBELE = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MOKFCKKJBNB(HKAGDGALOBK MMHIMJKGLKK);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CGJNMHFNHIK(HKAGDGALOBK OMPBPBPIHDF, int KGCOJLCLKCD, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DDCLFEILLCF(HKAGDGALOBK LGGHCBACILP, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BHHHPBDNKLG();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PDJLIKOAJGO(Func<HKAGDGALOBK, bool> EGGAIGKCDDD);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BMJDEDHHEMD(HKAGDGALOBK GNJGGOGMDMB, HashSet<HKAGDGALOBK> MHEEKFJDBIN);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<HKAGDGALOBK> BFJEHHHGKBC();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KGGNALNOKKB(HKAGDGALOBK GNJGGOGMDMB, [Out] LAIFDLAPOLH MEFCBJKMEAL);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NOGMAEKEEEB(NADNAOCKDOO HCEFPMMOBCM);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool NADNAOCKDOO(CEDAFAFMGDJ ABOLKPCCJOL);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface CEDAFAFMGDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HKAGDGALOBK ALAHFLNNJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CEDAFAFMGDJ GDFCPOBJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LAIFDLAPOLH LDGGHCDCJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool JKNFEGEOHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NEGECIBDEEK
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMCEEELLBNF(HKAGDGALOBK OLLJPOIEFJH, LAIFDLAPOLH EMABJDLOPJA);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOAHPCPCFHA(HKAGDGALOBK OLLJPOIEFJH, LAIFDLAPOLH EMABJDLOPJA);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCMLDBMGJPL(HKAGDGALOBK OLLJPOIEFJH, LAIFDLAPOLH EMABJDLOPJA);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKGDIFHCLAJ(HKAGDGALOBK OLLJPOIEFJH, LAIFDLAPOLH EMABJDLOPJA);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NEGECIBDEEK Instantiate(Transform PLPGMCABFBF);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBLOHGCCHFB();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NAKMILOJHKL
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCOPJMCPGIB(Transform PLPGMCABFBF, NEGECIBDEEK EJBJPCAFJEB);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NEGECIBDEEK HMDLIDMPKBL();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALGOPCFNEIJ(NEGECIBDEEK KAFDFKPMGOE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface BOLEAHOPGDF : COOJGHAECDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMGPMDDKGCM();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGJHBJPJIBK(Guid ACHLNPFJANI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface IENLBPECIAL
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FONOIKALLDF(CEDAFAFMGDJ NGKEPNBGCMK);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCOPJMCPGIB(LHLJECBFMLP BKGCMOAONFI, NAKMILOJHKL OCDHHMHCLFA);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KLGHAOILOFB();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPMLDAONBLK(CEDAFAFMGDJ BCAJDMJGAGF);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NAHJMLCPCFM(CEDAFAFMGDJ LIFKFPCKDMF);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NNGGGBKGJDH();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class IMFJLJINCOG : CEDAFAFMGDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class APBGONNMFCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LAIFDLAPOLH nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public IMFJLJINCOG foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public APBGONNMFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8083790", Offset = "0x8082790", VA = "0x188083790")]
		internal bool LEAMPCELGPF(CEDAFAFMGDJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private LAIFDLAPOLH MEFCBJKMEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<IMFJLJINCOG> JAKCMLAGBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private IMFJLJINCOG NGBJOEDKELD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public LAIFDLAPOLH LDGGHCDCJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x148B920", Offset = "0x148A920", VA = "0x18148B920", Slot = "6")]
		get
		{
			return default(LAIFDLAPOLH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x148BA00", Offset = "0x148AA00", VA = "0x18148BA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private IMFJLJINCOG EBJBKAEFOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x808CB70", Offset = "0x808BB70", VA = "0x18808CB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public CEDAFAFMGDJ GDFCPOBJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HKAGDGALOBK ALAHFLNNJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JKNFEGEOHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x808CDC0", Offset = "0x808BDC0", VA = "0x18808CDC0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DGBLCONBKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x808C720", Offset = "0x808B720", VA = "0x18808C720", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected IMFJLJINCOG NKBKNNLLHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x808CB50", Offset = "0x808BB50", VA = "0x18808CB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x808CDD0", Offset = "0x808BDD0", VA = "0x18808CDD0")]
	public IMFJLJINCOG(LAIFDLAPOLH MABLGOPMCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x808C350", Offset = "0x808B350", VA = "0x18808C350")]
	public IMFJLJINCOG BDMFDANLNLE(LAIFDLAPOLH OGGBHMPLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x808C4A0", Offset = "0x808B4A0", VA = "0x18808C4A0")]
	public IMFJLJINCOG BFGJMMFDLOM(LAIFDLAPOLH OEHPJMDPEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x808C970", Offset = "0x808B970", VA = "0x18808C970")]
	public IMFJLJINCOG LKIPLGLLFFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x808C820", Offset = "0x808B820", VA = "0x18808C820")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x808C770", Offset = "0x808B770", VA = "0x18808C770")]
	public IMFJLJINCOG IIIBKIPEKLL(LAIFDLAPOLH BKAKGIFOLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x808CC60", Offset = "0x808BC60", VA = "0x18808CC60")]
	private static void NOGMAEKEEEB(IMFJLJINCOG NEKJIHBMBCN, NADNAOCKDOO JPJEPABDFKF, bool GNPHMAPBOIE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x808CC50", Offset = "0x808BC50", VA = "0x18808CC50", Slot = "9")]
	public void NOGMAEKEEEB(NADNAOCKDOO HCEFPMMOBCM, bool FMFCCKHKEKM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x808C620", Offset = "0x808B620", VA = "0x18808C620")]
	public static IMFJLJINCOG BHICDKOJJFE(IMFJLJINCOG NEKJIHBMBCN, LAIFDLAPOLH FGEIEAKNPAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface PBOKEHNNOJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool PGECBOJPPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool OAFDKAKOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<DOHKIBLNJFC> JEGLGOBDLHE;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<IALDHONKEJC> DKJJDCIGHLD;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LMCEEELLBNF(HNKDHAEGBJO PAOKFDJPALE, HEHIDMNDMCM CONGFNFMFDI);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MFGFAACNNFE(HKAGDGALOBK OMPBPBPIHDF, HKAGDGALOBK LJBCBHDDAOM, int KGCOJLCLKCD, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BCLIMPFHKPC(HKAGDGALOBK LGGHCBACILP, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CLAMLABGGJP(PMGHIJOEHAP PLFMDBHNGFO, [Optional] IALDHONKEJC KANIKAPEEIF);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LDKPCFEBBAO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x808FF30", Offset = "0x808EF30", VA = "0x18808FF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object KONBGMLOLPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x808FEF0", Offset = "0x808EEF0", VA = "0x18808FEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x808FE90", Offset = "0x808EE90", VA = "0x18808FE90")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class HFAJKPEMDEF : PBOKEHNNOJL, IDisposable, HOCNAJGAJIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private HNKDHAEGBJO PAOKFDJPALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HEHIDMNDMCM PDOFLBCHBKH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PGECBOJPPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8089A30", Offset = "0x8088A30", VA = "0x188089A30", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool OAFDKAKOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8089300", Offset = "0x8088300", VA = "0x188089300", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView ENHBJGICMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8089270", Offset = "0x8088270", VA = "0x188089270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<DOHKIBLNJFC> JEGLGOBDLHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8089470", Offset = "0x8088470", VA = "0x188089470", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8089730", Offset = "0x8088730", VA = "0x188089730", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<IALDHONKEJC> DKJJDCIGHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8089690", Offset = "0x8088690", VA = "0x188089690", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8089990", Offset = "0x8088990", VA = "0x188089990", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x80897D0", Offset = "0x80887D0", VA = "0x1880897D0", Slot = "10")]
	public void LMCEEELLBNF(HNKDHAEGBJO PAOKFDJPALE, HEHIDMNDMCM PDOFLBCHBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8089640", Offset = "0x8088640", VA = "0x188089640", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8089860", Offset = "0x8088860", VA = "0x188089860", Slot = "11")]
	public void MFGFAACNNFE(HKAGDGALOBK OMPBPBPIHDF, HKAGDGALOBK LJBCBHDDAOM, int KGCOJLCLKCD, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8089340", Offset = "0x8088340", VA = "0x188089340", Slot = "12")]
	public void BCLIMPFHKPC(HKAGDGALOBK LGGHCBACILP, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8089510", Offset = "0x8088510", VA = "0x188089510", Slot = "13")]
	public void CLAMLABGGJP(PMGHIJOEHAP PLFMDBHNGFO, [Optional] IALDHONKEJC KANIKAPEEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8089CD0", Offset = "0x8088CD0", VA = "0x188089CD0")]
	[DMLIGKAMJGD]
	private void RpcMasterReparentNodes(HKAGDGALOBK LGGHCBACILP, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8089AD0", Offset = "0x8088AD0", VA = "0x188089AD0")]
	[DMLIGKAMJGD]
	private void RpcMasterModifyNode(HKAGDGALOBK OMPBPBPIHDF, HKAGDGALOBK LJBCBHDDAOM, int KGCOJLCLKCD, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x808A0D0", Offset = "0x80890D0", VA = "0x18808A0D0")]
	[DMLIGKAMJGD]
	private void RpcReparentNodes(HKAGDGALOBK LGGHCBACILP, int LIGLJDHNPFG, HKAGDGALOBK BKAKGIFOLLC, int BOKOIFKOAFL, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO, KODDFPHIGAD KIJLEJBGELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8089FE0", Offset = "0x8088FE0", VA = "0x188089FE0")]
	[DMLIGKAMJGD]
	private void RpcModifyNode(HKAGDGALOBK OMPBPBPIHDF, int KGCOJLCLKCD, int BBOFJJCPFFI, Vector3 ACIPKJDGIOE, Quaternion INKBIHGIPOO, KODDFPHIGAD KIJLEJBGELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8089A90", Offset = "0x8088A90", VA = "0x188089A90")]
	[DMLIGKAMJGD]
	private void RpcDeserializeConnectableGraph(PMGHIJOEHAP BKGCMOAONFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HFAJKPEMDEF()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, NEGECIBDEEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x80903D0", Offset = "0x808F3D0", VA = "0x1880903D0", Slot = "4")]
		private void IHJMLECDEJG(HKAGDGALOBK OLLJPOIEFJH, LAIFDLAPOLH EMABJDLOPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x80900F0", Offset = "0x808F0F0", VA = "0x1880900F0", Slot = "5")]
		private void DAEIPFPOPMB(HKAGDGALOBK OLLJPOIEFJH, LAIFDLAPOLH EMABJDLOPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x808FF90", Offset = "0x808EF90", VA = "0x18808FF90", Slot = "6")]
		private void AEFBFGJKEMD(HKAGDGALOBK OLLJPOIEFJH, LAIFDLAPOLH EMABJDLOPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x80905C0", Offset = "0x808F5C0", VA = "0x1880905C0", Slot = "7")]
		private void OAILPEAAIFF(HKAGDGALOBK OLLJPOIEFJH, LAIFDLAPOLH EMABJDLOPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8090550", Offset = "0x808F550", VA = "0x188090550", Slot = "8")]
		private NEGECIBDEEK JAHIFFLFHFB(Transform PLPGMCABFBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8090370", Offset = "0x808F370", VA = "0x188090370", Slot = "9")]
		private void GJOLJHNCGNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FGNLNCKENGL
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D810", Offset = "0x3C3C810", VA = "0x183C3D810")]
	public static LDINOIJEIPJ<T> GLOHKFPBPEO<T>(this CBHAAKGBAOP PFJIPDCNGCE)
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
