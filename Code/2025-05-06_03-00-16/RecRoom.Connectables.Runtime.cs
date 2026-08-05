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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A51640", Offset = "0x7A4FE40", VA = "0x187A51640", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B830", Offset = "0x7A5A030", VA = "0x187A5B830", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B220", Offset = "0x7A59A20", VA = "0x187A5B220")]
		private void BEJJPGDKNLF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B390", Offset = "0x7A59B90", VA = "0x187A5B390")]
		private void ODKKLPNPFCE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B500", Offset = "0x7A59D00", VA = "0x187A5B500", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B870", Offset = "0x7A5A070", VA = "0x187A5B870")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class NIAAKBGANBM : IFKLCCFLMMA, JPHALCNLDIO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class JGEOGMOCGJE : IEnumerable<MDKBEOKIPPL>, IEnumerable, IEnumerator<MDKBEOKIPPL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private MDKBEOKIPPL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private FGFPKLDJIEL localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FGFPKLDJIEL <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NIAAKBGANBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private EFICJEHFEEE <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private DPONIGJFOLB <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private DPONIGJFOLB.AKKGPGDEMNP <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private MDKBEOKIPPL System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public JGEOGMOCGJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A500A0", Offset = "0x7A4E8A0", VA = "0x187A500A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A4FC40", Offset = "0x7A4E440", VA = "0x187A4FC40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7A4FC00", Offset = "0x7A4E400", VA = "0x187A4FC00")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7A4FC20", Offset = "0x7A4E420", VA = "0x187A4FC20")]
		private void LGFFOGMDBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7A50050", Offset = "0x7A4E850", VA = "0x187A50050", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7A4FFA0", Offset = "0x7A4E7A0", VA = "0x187A4FFA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MDKBEOKIPPL> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7A4FFA0", Offset = "0x7A4E7A0", VA = "0x187A4FFA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MAEKBIFCDPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NIAAKBGANBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public DOFEKKANHKF nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MAEKBIFCDPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7A517E0", Offset = "0x7A4FFE0", VA = "0x187A517E0")]
		internal object GCBIACKDEIO(DOFEKKANHKF x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ODJKOLLDNMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DOFEKKANHKF child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MAEKBIFCDPN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ODJKOLLDNMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7A58250", Offset = "0x7A56A50", VA = "0x187A58250")]
		internal object LKOOKPBCKCC((DOFEKKANHKF child, DOFEKKANHKF nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly LLPKKNNAIAE KOGGEDPALDL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly LLPKKNNAIAE EEMIJDAFPKK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly LLPKKNNAIAE DLNGJPLEGFF;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly LLPKKNNAIAE JPJOGDEDANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GODLKGCKBJN GIMGHPKAEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KOMJNIJGCJJ MDDANENBEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private GLMBECBONIF CJDGNPCLPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private KLFAIEJGMLP LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private DPLIOIGJMLF GNHNJLPKMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private DBJIFOGNHIO MJNCEJEJJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MHDFNKHNBGK OLDEEBBAPCA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AFPBFKGMNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9E24B0", Offset = "0x9E0CB0", VA = "0x1809E24B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9E2380", Offset = "0x9E0B80", VA = "0x1809E2380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FKFIEOCOGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<MDKBEOKIPPL, MDKBEOKIPPL> KNAJNKHAMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7A54F30", Offset = "0x7A53730", VA = "0x187A54F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7A54FE0", Offset = "0x7A537E0", VA = "0x187A54FE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<MDKBEOKIPPL, MDKBEOKIPPL> GDKODLBBOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A55C20", Offset = "0x7A54420", VA = "0x187A55C20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A57FE0", Offset = "0x7A567E0", VA = "0x187A57FE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<MDKBEOKIPPL, MDKBEOKIPPL, MDKBEOKIPPL> PFLGPLDIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A54270", Offset = "0x7A52A70", VA = "0x187A54270", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7A54AA0", Offset = "0x7A532A0", VA = "0x187A54AA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A581E0", Offset = "0x7A569E0", VA = "0x187A581E0")]
	public NIAAKBGANBM(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A57820", Offset = "0x7A56020", VA = "0x187A57820", Slot = "12")]
	public void NPIOKLMMDIH(GameObject KJMBGAPFJAM, KDDGMLHDPDI PMOLHNABPOL, LFJEOOBHGCN IEFOJDMLPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A54BB0", Offset = "0x7A533B0", VA = "0x187A54BB0", Slot = "26")]
	public void DPMOIAAKAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A55520", Offset = "0x7A53D20", VA = "0x187A55520", Slot = "22")]
	public bool FPBHGHLPJAI(DOFEKKANHKF HGAAJHCCLOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A55570", Offset = "0x7A53D70", VA = "0x187A55570")]
	private void GFBNGMBAKEL(FGFPKLDJIEL NGDDKOONAII, FGFPKLDJIEL JGGJMMJEBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A543B0", Offset = "0x7A52BB0", VA = "0x187A543B0")]
	private void CJBPGANJNBD(FGFPKLDJIEL NGDDKOONAII, FGFPKLDJIEL HDBOJBANKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A53960", Offset = "0x7A52160", VA = "0x187A53960")]
	private void AIKFMBJOPCC(FGFPKLDJIEL NGDDKOONAII, FGFPKLDJIEL HDBOJBANKLG, FGFPKLDJIEL JGGJMMJEBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A57AB0", Offset = "0x7A562B0", VA = "0x187A57AB0")]
	private void OGPEMJCEEKL(FGFPKLDJIEL NGDDKOONAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "13")]
	public void MAEEPMKIKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7A55CD0", Offset = "0x7A544D0", VA = "0x187A55CD0", Slot = "14")]
	public void JNEAPGDNFGC(MDKBEOKIPPL OKJLAPLBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "15")]
	public void IMKDBAIPGDE(MDKBEOKIPPL OKJLAPLBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7A53BC0", Offset = "0x7A523C0", VA = "0x187A53BC0", Slot = "17")]
	public void BGPLEDEJCME(MDKBEOKIPPL OKJLAPLBHOI, MDKBEOKIPPL DDBMPDNHJIM, Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A53D20", Offset = "0x7A52520", VA = "0x187A53D20")]
	public void BGPLEDEJCME(FGFPKLDJIEL NGDINOANFEF, FGFPKLDJIEL DDBMPDNHJIM, Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7A56B90", Offset = "0x7A55390", VA = "0x187A56B90")]
	public void NBCNECGLKJA(MDKBEOKIPPL OKJLAPLBHOI, float EIKFDBNGDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7A56C60", Offset = "0x7A55460", VA = "0x187A56C60", Slot = "18")]
	public void NEDAGKENHNC(MDKBEOKIPPL MBMGFPJENPK, int MFBAAKMEOPO, MDKBEOKIPPL MJKMPACPODB, int KLCGODLMAEL, Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7A57F30", Offset = "0x7A56730", VA = "0x187A57F30")]
	private float PBMAJKMKLBB(FGFPKLDJIEL NGDINOANFEF, FGFPKLDJIEL DFPCBMGPBFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7A56DC0", Offset = "0x7A555C0", VA = "0x187A56DC0")]
	public void NEDAGKENHNC(FGFPKLDJIEL NGDINOANFEF, FGFPKLDJIEL DFPCBMGPBFO, Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML, bool FJKOKLKKOPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A54760", Offset = "0x7A52F60", VA = "0x187A54760", Slot = "19")]
	public void CPAPKKGNHPL(MDKBEOKIPPL OKJLAPLBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A55900", Offset = "0x7A54100", VA = "0x187A55900", Slot = "16")]
	public void IKDFBOPGJJF(MDKBEOKIPPL OKJLAPLBHOI, HashSet<MDKBEOKIPPL> PCPFGHOLEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "20")]
	public CKPJMHLMLJF ACLGJGACBHF(bool JICGABHFIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "21")]
	public CKPJMHLMLJF FNDIBIDKAIO(HashSet<Guid> BDEKIHDEEFL, bool JICGABHFIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A57EC0", Offset = "0x7A566C0", VA = "0x187A57EC0", Slot = "23")]
	public void OOPJLDLFGJK(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A53760", Offset = "0x7A51F60", VA = "0x187A53760", Slot = "24")]
	public void AHHLPKIIGDH(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A55500", Offset = "0x7A53D00", VA = "0x187A55500", Slot = "25")]
	public void FMJIBJAFBLN(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A550F0", Offset = "0x7A538F0", VA = "0x187A550F0")]
	private void FDLJHEDCCBO(FGFPKLDJIEL NGDINOANFEF, FGFPKLDJIEL DFPCBMGPBFO, Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML, float EIKFDBNGDHM, bool FJKOKLKKOPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A56F00", Offset = "0x7A55700", VA = "0x187A56F00")]
	private void NODLJKEHKDC(FGFPKLDJIEL NGDINOANFEF, FGFPKLDJIEL GPDOCAJDCGI, Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A560D0", Offset = "0x7A548D0", VA = "0x187A560D0")]
	private void KMPMIDHEOEH(FGFPKLDJIEL NGDINOANFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A54320", Offset = "0x7A52B20", VA = "0x187A54320")]
	[IteratorStateMachine(typeof(JGEOGMOCGJE))]
	public IEnumerable<MDKBEOKIPPL> CGCLLLDHINL(FGFPKLDJIEL DGLFHMAFDAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A56140", Offset = "0x7A54940", VA = "0x187A56140")]
	internal MDKBEOKIPPL LKBNCEGNJNI(FGFPKLDJIEL DGLFHMAFDAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7A545D0", Offset = "0x7A52DD0", VA = "0x187A545D0")]
	internal FGFPKLDJIEL CMHJBHJFJHC(MDKBEOKIPPL OKJLAPLBHOI)
	{
		return default(FGFPKLDJIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7A56600", Offset = "0x7A54E00", VA = "0x187A56600")]
	private bool MLICAPNCICA(DOFEKKANHKF HGAAJHCCLOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7A55090", Offset = "0x7A53890", VA = "0x187A55090")]
	private bool FDLFABBPAHD(DOFEKKANHKF HGAAJHCCLOF, [Out] MDKBEOKIPPL DFPCBMGPBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7A56270", Offset = "0x7A54A70", VA = "0x187A56270")]
	private MDKBEOKIPPL LKBNCEGNJNI(DOFEKKANHKF HGAAJHCCLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A537D0", Offset = "0x7A51FD0", VA = "0x187A537D0")]
	private MDKBEOKIPPL AIBLKFEIHJH(DOFEKKANHKF HGAAJHCCLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7A548D0", Offset = "0x7A530D0", VA = "0x187A548D0")]
	private MDKBEOKIPPL CPDANAKLJMF(DOFEKKANHKF HGAAJHCCLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7A56C20", Offset = "0x7A55420", VA = "0x187A56C20")]
	private static Guid NCDGMIHNONH(DOFEKKANHKF HGAAJHCCLOF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7A55FE0", Offset = "0x7A547E0", VA = "0x187A55FE0")]
	private string KLLIECEEAOM(DOFEKKANHKF HGAAJHCCLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A55770", Offset = "0x7A53F70", VA = "0x187A55770")]
	private void HBMEMEKHEBH(MDKBEOKIPPL NGDINOANFEF, MDKBEOKIPPL GPDOCAJDCGI, RigidTransform GGLAGEKANKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7A54DA0", Offset = "0x7A535A0", VA = "0x187A54DA0")]
	private void EFIIGHLJNDI(MDKBEOKIPPL GPDOCAJDCGI, MDKBEOKIPPL NGDINOANFEF, RigidTransform GGLAGEKANKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7A54B50", Offset = "0x7A53350", VA = "0x187A54B50")]
	private void DGAKNOMJBLK(MDKBEOKIPPL HLEGNILMIKJ, MDKBEOKIPPL NGDINOANFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7A540E0", Offset = "0x7A528E0", VA = "0x187A540E0")]
	private void BMDLHCAPKCK(MDKBEOKIPPL NGDINOANFEF, MDKBEOKIPPL DFPCBMGPBFO, RigidTransform GGLAGEKANKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7A55B10", Offset = "0x7A54310", VA = "0x187A55B10")]
	private void JCDKMDLDPJE(FGFPKLDJIEL DGLFHMAFDAJ, MDKBEOKIPPL OKJLAPLBHOI, FGFPKLDJIEL HDBOJBANKLG, FGFPKLDJIEL JGGJMMJEBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A53E60", Offset = "0x7A52660", VA = "0x187A53E60")]
	private void BHCMHLHOKOB(FGFPKLDJIEL DGLFHMAFDAJ, MDKBEOKIPPL OKJLAPLBHOI, MDKBEOKIPPL HHMGAGINJIB, MDKBEOKIPPL DFMIOKFFOEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IPIDALLNEFF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PFAPGLGDHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public HHDGAAFLDEF container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PFAPGLGDHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AF60", Offset = "0x7A59760", VA = "0x187A5AF60")]
		internal NIAAKBGANBM NAPAIJCOGFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F940", Offset = "0x7A4E140", VA = "0x187A4F940")]
	public static void LIJPFPPOPFH(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F8F0", Offset = "0x7A4E0F0", VA = "0x187A4F8F0")]
	public static void DPGGPBDHCLA(HHDGAAFLDEF PMKEELMHMLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class MFIGNJLFGJH : KMEHPAKIHNO, KIHJCKMCDOF
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly NIAAKBGANBM GCMGBMBNNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly LAKIMNJBMNA BEMGIEEAHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly OPFAHDEKAIK LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly DKMDMDLIIHC[] HAKOMPEKONC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MDKBEOKIPPL MAMDDJFOBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7A53440", Offset = "0x7A51C40", VA = "0x187A53440", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MDKBEOKIPPL CDJJMKOBMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7A530A0", Offset = "0x7A518A0", VA = "0x187A530A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 NLNAMFKLJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7A52420", Offset = "0x7A50C20", VA = "0x187A52420", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion NHLMLEAMCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7A51F30", Offset = "0x7A50730", VA = "0x187A51F30", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JCCLJAJFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7A522D0", Offset = "0x7A50AD0", VA = "0x187A522D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<MDKBEOKIPPL> MCMJMDFHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7A52D50", Offset = "0x7A51550", VA = "0x187A52D50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool GHAAMHOHNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBFD9E0", Offset = "0xBFC1E0", VA = "0x180BFD9E0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC03A50", Offset = "0xC02250", VA = "0x180C03A50", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7A53650", Offset = "0x7A51E50", VA = "0x187A53650", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject KHPLFMGJOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7A53350", Offset = "0x7A51B50", VA = "0x187A53350", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7A53370", Offset = "0x7A51B70", VA = "0x187A53370", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid MLFGGJGDMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7A534A0", Offset = "0x7A51CA0", VA = "0x187A534A0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int INDMJNOOHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7A53580", Offset = "0x7A51D80", VA = "0x187A53580", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GBHKADGOLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool FMACJJANBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7A53160", Offset = "0x7A51960", VA = "0x187A53160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JNENPLDOFLK NBAOBOOGGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7A51B60", Offset = "0x7A50360", VA = "0x187A51B60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7A52480", Offset = "0x7A50C80", VA = "0x187A52480", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JNENPLDOFLK OIACKCBLODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7A52340", Offset = "0x7A50B40", VA = "0x187A52340", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7A52EF0", Offset = "0x7A516F0", VA = "0x187A52EF0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JNENPLDOFLK IDDOBALKFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7A52FF0", Offset = "0x7A517F0", VA = "0x187A52FF0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7A51ED0", Offset = "0x7A506D0", VA = "0x187A51ED0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event MMILCMGAOOH MOAMFGABKEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7A52230", Offset = "0x7A50A30", VA = "0x187A52230", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A52E50", Offset = "0x7A51650", VA = "0x187A52E50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7A53250", Offset = "0x7A51A50", VA = "0x187A53250")]
	public MFIGNJLFGJH(FGFPKLDJIEL GHMCDKKCGHO, RigidbodyEx MHNKLADFOHL, LAKIMNJBMNA BEMGIEEAHDP, DKMDMDLIIHC[] HAKOMPEKONC, OPFAHDEKAIK LMJFACKNPAI, IFKLCCFLMMA GCMGBMBNNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7A51850", Offset = "0x7A50050", VA = "0x187A51850", Slot = "19")]
	public void AEBHHIOLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "21")]
	public void MAINGAIBABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x77A8AE0", Offset = "0x77A72E0", VA = "0x1877A8AE0", Slot = "22")]
	public void MMPFDJKNIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7A52B00", Offset = "0x7A51300", VA = "0x187A52B00", Slot = "20")]
	public void GIABKOFDCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7A524E0", Offset = "0x7A50CE0", VA = "0x187A524E0", Slot = "25")]
	public void GBBEIIKDAAE(int NNHGELLNEAO, MDKBEOKIPPL MJKMPACPODB, int OOEMCGECECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7A52D80", Offset = "0x7A51580", VA = "0x187A52D80", Slot = "26")]
	public void HLAHPCEAFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7A51880", Offset = "0x7A50080", VA = "0x187A51880", Slot = "27")]
	public void BKJIJJPIBKG(int NNHGELLNEAO, MDKBEOKIPPL MBMGFPJENPK, int ANAEEFGGIMC, [Optional] Vector3? FPOMPEMDEMP, [Optional] Quaternion? BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A523A0", Offset = "0x7A50BA0", VA = "0x187A523A0", Slot = "28")]
	public void EMPHHLMJPCL(MDKBEOKIPPL MBMGFPJENPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A526F0", Offset = "0x7A50EF0", VA = "0x187A526F0", Slot = "31")]
	public void GDLCGCGANOF(Vector3 CFLCGMJMPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A51BC0", Offset = "0x7A503C0", VA = "0x187A51BC0", Slot = "29")]
	public void CELBFMOBGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7A51F90", Offset = "0x7A50790", VA = "0x187A51F90", Slot = "30")]
	public void CPEJPDAJPDI(int FPEOONOJHML, Vector3 NANJGAHEDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7A52C80", Offset = "0x7A51480", VA = "0x187A52C80", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int NNHGELLNEAO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A52B50", Offset = "0x7A51350", VA = "0x187A52B50", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int NNHGELLNEAO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xBD6AA0", Offset = "0xBD52A0", VA = "0x180BD6AA0", Slot = "42")]
	public Color GetConnectionSlotColor(int NNHGELLNEAO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A52190", Offset = "0x7A50990", VA = "0x187A52190", Slot = "43")]
	public bool CanConnectTo(int NNHGELLNEAO, MDKBEOKIPPL BMPADFPLCPA, int AFBPPIACMJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "44")]
	public void ParentChanged(int NNHGELLNEAO, MDKBEOKIPPL KIDFDLAHNDD, int GHPFEKDOPKJ, Vector3 CEMLCGJJEDD, Quaternion OKODJJGEBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "45")]
	public void ChildAdded(int NNHGELLNEAO, MDKBEOKIPPL ICCFKECNAPG, int GFILOEIAKLB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "46")]
	public void ChildRemoved(int NNHGELLNEAO, MDKBEOKIPPL PMPIJAKKPJL, int FICCLJCEEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "47")]
	public void ConnectionModified(int NNHGELLNEAO, MDKBEOKIPPL MJKMPACPODB, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A531B0", Offset = "0x7A519B0", VA = "0x187A531B0", Slot = "48")]
	public void RootChanged(MDKBEOKIPPL ICPAKKIFBDK, MDKBEOKIPPL NGKMMGOCEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7A52F50", Offset = "0x7A51750", VA = "0x187A52F50", Slot = "23")]
	public void KAMDFOEEOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7A53050", Offset = "0x7A51850", VA = "0x187A53050", Slot = "24")]
	public void MOJIKBGHCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7A52FA0", Offset = "0x7A517A0", VA = "0x187A52FA0")]
	private void KNKAFBMGBBK(bool AHPLHAHEPLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(KHDECKDGGAP), new string[] { })]
public class OJPJBIAMPBE : KHDECKDGGAP, KKFFKJEIEOE, CDBAFKLBPMB
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class GONLMGKCOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GONLMGKCOLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private LEFFBBHDGKI MHBIGPFAJHC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object MMPCFANFGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7A584F0", Offset = "0x7A56CF0", VA = "0x187A584F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7A584A0", Offset = "0x7A56CA0", VA = "0x187A584A0", Slot = "5")]
	private void ECHJCHGCHFC(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1118BD0", Offset = "0x11173D0", VA = "0x181118BD0", Slot = "6")]
	private void BKNPNDBLAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public OJPJBIAMPBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(IFKLCCFLMMA), new string[] { "Ignore", "Mock" })]
public class IELNJAFALEP : IFKLCCFLMMA, JPHALCNLDIO
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool AFPBFKGMNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FKFIEOCOGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<MDKBEOKIPPL, MDKBEOKIPPL> KNAJNKHAMOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7A4F630", Offset = "0x7A4DE30", VA = "0x187A4F630", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7A4F6E0", Offset = "0x7A4DEE0", VA = "0x187A4F6E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<MDKBEOKIPPL, MDKBEOKIPPL> GDKODLBBOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4F790", Offset = "0x7A4DF90", VA = "0x187A4F790", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7A4F840", Offset = "0x7A4E040", VA = "0x187A4F840", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<MDKBEOKIPPL, MDKBEOKIPPL, MDKBEOKIPPL> PFLGPLDIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4F4D0", Offset = "0x7A4DCD0", VA = "0x187A4F4D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7A4F580", Offset = "0x7A4DD80", VA = "0x187A4F580", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "26")]
	public void DPMOIAAKAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "12")]
	public void NPIOKLMMDIH(GameObject KJMBGAPFJAM, KDDGMLHDPDI PMOLHNABPOL, LFJEOOBHGCN DNKPKNGFNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "13")]
	public void MAEEPMKIKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "14")]
	public void JNEAPGDNFGC(MDKBEOKIPPL OKJLAPLBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "15")]
	public void IMKDBAIPGDE(MDKBEOKIPPL OKJLAPLBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "16")]
	public void IKDFBOPGJJF(MDKBEOKIPPL OKJLAPLBHOI, HashSet<MDKBEOKIPPL> PCPFGHOLEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "17")]
	public void BGPLEDEJCME(MDKBEOKIPPL OKJLAPLBHOI, MDKBEOKIPPL DDBMPDNHJIM, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "18")]
	public void NEDAGKENHNC(MDKBEOKIPPL OKJLAPLBHOI, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "19")]
	public void CPAPKKGNHPL(MDKBEOKIPPL OKJLAPLBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "20")]
	public CKPJMHLMLJF ACLGJGACBHF(bool JICGABHFIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "21")]
	public CKPJMHLMLJF FNDIBIDKAIO(HashSet<Guid> BDEKIHDEEFL, bool JICGABHFIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "22")]
	public bool FPBHGHLPJAI(DOFEKKANHKF HGAAJHCCLOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "23")]
	public void OOPJLDLFGJK(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "24")]
	public void AHHLPKIIGDH(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "25")]
	public void FMJIBJAFBLN(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public IELNJAFALEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MDKBEOKIPPL : KIHJCKMCDOF, IEquatable<MDKBEOKIPPL>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KIHJCKMCDOF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MDKBEOKIPPL MAMDDJFOBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject KHPLFMGJOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid MLFGGJGDMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int INDMJNOOHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GBHKADGOLGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int NNHGELLNEAO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int NNHGELLNEAO);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int NNHGELLNEAO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int NNHGELLNEAO, MDKBEOKIPPL BMPADFPLCPA, int NFHECCPHCPJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int NNHGELLNEAO, MDKBEOKIPPL KIDFDLAHNDD, int GHPFEKDOPKJ, Vector3 CEMLCGJJEDD, Quaternion OKODJJGEBBB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int NNHGELLNEAO, MDKBEOKIPPL ICCFKECNAPG, int GFILOEIAKLB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int NNHGELLNEAO, MDKBEOKIPPL PMPIJAKKPJL, int FICCLJCEEPA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int NNHGELLNEAO, MDKBEOKIPPL MJKMPACPODB, int NPJCBDCCLJH, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(MDKBEOKIPPL ICPAKKIFBDK, MDKBEOKIPPL NGKMMGOCEGO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IFKLCCFLMMA : JPHALCNLDIO
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool AFPBFKGMNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FKFIEOCOGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MDKBEOKIPPL, MDKBEOKIPPL> KNAJNKHAMOF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<MDKBEOKIPPL, MDKBEOKIPPL> GDKODLBBOEP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<MDKBEOKIPPL, MDKBEOKIPPL, MDKBEOKIPPL> PFLGPLDIMOG;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NPIOKLMMDIH(GameObject KJMBGAPFJAM, KDDGMLHDPDI PMOLHNABPOL, LFJEOOBHGCN BCKEDMLKOHD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MAEEPMKIKNH();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JNEAPGDNFGC(MDKBEOKIPPL OKJLAPLBHOI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IMKDBAIPGDE(MDKBEOKIPPL OKJLAPLBHOI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IKDFBOPGJJF(MDKBEOKIPPL OKJLAPLBHOI, HashSet<MDKBEOKIPPL> PCPFGHOLEHD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BGPLEDEJCME(MDKBEOKIPPL OKJLAPLBHOI, MDKBEOKIPPL DDBMPDNHJIM, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NEDAGKENHNC(MDKBEOKIPPL OKJLAPLBHOI, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CPAPKKGNHPL(MDKBEOKIPPL OKJLAPLBHOI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CKPJMHLMLJF ACLGJGACBHF(bool JICGABHFIAF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CKPJMHLMLJF FNDIBIDKAIO(HashSet<Guid> BDEKIHDEEFL, bool JICGABHFIAF);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FPBHGHLPJAI(DOFEKKANHKF HGAAJHCCLOF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OOPJLDLFGJK(CKPJMHLMLJF LJMFKPGJJNC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AHHLPKIIGDH(CKPJMHLMLJF LJMFKPGJJNC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FMJIBJAFBLN(CKPJMHLMLJF LJMFKPGJJNC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KLFAIEJGMLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool ADAEIDAFINM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MDKBEOKIPPL CPDANAKLJMF(int CKBAHGKJLNE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MDKBEOKIPPL AIBLKFEIHJH(Guid KPMHENHOBBK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMLFFPOAOHL(MDKBEOKIPPL OKJLAPLBHOI);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FJGODPJACEF();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDFMHIBGIMP(MDKBEOKIPPL BEMGIEEAHDP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface OPFAHDEKAIK
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMACJJANBKN(LAKIMNJBMNA BEMGIEEAHDP);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LHGKNEEPLJJ(LAKIMNJBMNA BEMGIEEAHDP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string LDEONIAINDM(LAKIMNJBMNA BEMGIEEAHDP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid JNNCCALBOIB(LAKIMNJBMNA BEMGIEEAHDP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CLDBMNKIKMI(LAKIMNJBMNA BEMGIEEAHDP);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCFNGMFEIMD(LAKIMNJBMNA BEMGIEEAHDP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void JNENPLDOFLK(MDKBEOKIPPL MBMGFPJENPK, int DOHFKNAKALI, MDKBEOKIPPL MJKMPACPODB, int NOAMKHEIBAP, [Optional] Vector3? FPOMPEMDEMP, [Optional] Quaternion? BEOOEAAADEN);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void MMILCMGAOOH(MDKBEOKIPPL ICPAKKIFBDK, MDKBEOKIPPL NGKMMGOCEGO);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LAKIMNJBMNA : MDKBEOKIPPL, KIHJCKMCDOF, IEquatable<MDKBEOKIPPL>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KMEHPAKIHNO : KIHJCKMCDOF
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MDKBEOKIPPL CDJJMKOBMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<MDKBEOKIPPL> MCMJMDFHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 NLNAMFKLJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion NHLMLEAMCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JCCLJAJFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool GHAAMHOHNGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event JNENPLDOFLK NBAOBOOGGIB;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event JNENPLDOFLK OIACKCBLODK;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event JNENPLDOFLK IDDOBALKFBD;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event MMILCMGAOOH MOAMFGABKEN;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AEBHHIOLPOG();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GIABKOFDCIF();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MAINGAIBABO();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MMPFDJKNIHM();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KAMDFOEEOHM();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MOJIKBGHCKG();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GBBEIIKDAAE(int NNHGELLNEAO, MDKBEOKIPPL MJKMPACPODB, int OOEMCGECECB);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HLAHPCEAFPD();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BKJIJJPIBKG(int NNHGELLNEAO, MDKBEOKIPPL MBMGFPJENPK, int ANAEEFGGIMC, [Optional] Vector3? FPOMPEMDEMP, [Optional] Quaternion? BEOOEAAADEN);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EMPHHLMJPCL(MDKBEOKIPPL MBMGFPJENPK);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CELBFMOBGMG();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CPEJPDAJPDI(int FPEOONOJHML, Vector3 NANJGAHEDND);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GDLCGCGANOF(Vector3 CFLCGMJMPLD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DKMDMDLIIHC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 DJCPFKDJAFB
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
public interface KDDGMLHDPDI
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IKGABMPNEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JGFIJCPIBKD NDIEIGKONEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, KDDGMLHDPDI
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
			[Cpp2IlInjected.Address(RVA = "0xA85410", Offset = "0xA83C10", VA = "0x180A85410", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JGFIJCPIBKD LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A49CF0", Offset = "0x7A484F0", VA = "0x187A49CF0")]
		public static ConnectableConfigData JGIHKPCOLLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A49DB0", Offset = "0x7A485B0", VA = "0x187A49DB0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual JDHEBIDIKJA, bool BNCAONBDLFC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GDJICIGNNID : IEquatable<GDJICIGNNID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public MDKBEOKIPPL OKJLAPLBHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int OPKLODOCMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int NPJCBDCCLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 FPOMPEMDEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion BEOOEAAADEN;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D910", Offset = "0x7A4C110", VA = "0x187A4D910")]
	public GDJICIGNNID(MDKBEOKIPPL OKJLAPLBHOI, int OPKLODOCMCI, int NPJCBDCCLJH, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D970", Offset = "0x7A4C170", VA = "0x187A4D970")]
	public GDJICIGNNID(MDKBEOKIPPL OKJLAPLBHOI, int OPKLODOCMCI, int NPJCBDCCLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DA10", Offset = "0x7A4C210", VA = "0x187A4DA10")]
	public GDJICIGNNID(MDKBEOKIPPL OKJLAPLBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D4A0", Offset = "0x7A4BCA0", VA = "0x187A4D4A0", Slot = "4")]
	public bool Equals(GDJICIGNNID PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D550", Offset = "0x7A4BD50", VA = "0x187A4D550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class FFGLDPMPIKA : KGKJLFFDDFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform POFBAOBKAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private JGFIJCPIBKD JJAKBPKAKCA;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7440AE0", Offset = "0x743F2E0", VA = "0x187440AE0", Slot = "4")]
	public void NPIOKLMMDIH(Transform POFBAOBKAGL, JGFIJCPIBKD JJAKBPKAKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A0D0", Offset = "0x7A488D0", VA = "0x187A4A0D0", Slot = "5")]
	public JGFIJCPIBKD PFBBGJGGBEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A060", Offset = "0x7A48860", VA = "0x187A4A060", Slot = "6")]
	public void HMEOKONKKEA(JGFIJCPIBKD FDOCLNLOLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FFGLDPMPIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class CNELMNJDLGN : IDisposable, GBDOBIOCGIL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CGOCGOBEOJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public MDKBEOKIPPL oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public MDKBEOKIPPL newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public CGOCGOBEOJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7A466B0", Offset = "0x7A44EB0", VA = "0x187A466B0")]
		internal bool FPAOBCABNGC(PLHJIALFGGK node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly GDMLPILFMNK MEJMCHLHCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private JFDBGPELEKB DMGFKEFKPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private DKIEFNELOOA NAEDIAJJFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool BNCAONBDLFC;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly LLPKKNNAIAE DFKDAOPHAEF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public PLHJIALFGGK DFJAHCLMMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7A47C40", Offset = "0x7A46440", VA = "0x187A47C40")]
	public bool KJAGPCEMBCK([In] KAFPOALHGGA NFNBKNAJBPN, bool AHNABHCJADP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7A474C0", Offset = "0x7A45CC0", VA = "0x187A474C0")]
	private bool DDDPMPONHAP([In] KAFPOALHGGA NFNBKNAJBPN, bool AHNABHCJADP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7A49B20", Offset = "0x7A48320", VA = "0x187A49B20")]
	public CNELMNJDLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7A49610", Offset = "0x7A47E10", VA = "0x187A49610", Slot = "5")]
	public void NPIOKLMMDIH(IFKLCCFLMMA IPKPNIAEJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7A49250", Offset = "0x7A47A50", VA = "0x187A49250", Slot = "17")]
	public void KJEDGCELLFF(FKAIKIPNIEG NELMOECDPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7A481A0", Offset = "0x7A469A0", VA = "0x187A481A0", Slot = "12")]
	public void GKPJMFBCILO(Func<MDKBEOKIPPL, bool> OCMNLCOAMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7A48070", Offset = "0x7A46870", VA = "0x187A48070")]
	private void GKPJMFBCILO(GDMLPILFMNK GDFCBMOFMFN, Func<MDKBEOKIPPL, bool> OCMNLCOAMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7A49280", Offset = "0x7A47A80", VA = "0x187A49280", Slot = "11")]
	public void LLMOHJNDPIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7A47D70", Offset = "0x7A46570", VA = "0x187A47D70", Slot = "8")]
	public bool FGLKJIGEKFO(MDKBEOKIPPL GHKHALNLOFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7A48430", Offset = "0x7A46C30", VA = "0x187A48430")]
	private bool IFKNCMMGMFB(MDKBEOKIPPL ABLGCIPJDJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7A49910", Offset = "0x7A48110", VA = "0x187A49910")]
	private static bool PHLIPEMKCIN(MDKBEOKIPPL ABLGCIPJDJC, GDMLPILFMNK LBIBOIDAHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7A46F90", Offset = "0x7A45790", VA = "0x187A46F90")]
	private void CCDHJGHCOAO(Transform IIKLCCBPPJI, GDMLPILFMNK GPLDLDOILJJ, GDMLPILFMNK[] IGGCKFILIHP, MDKBEOKIPPL APILCALLJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7A47370", Offset = "0x7A45B70", VA = "0x187A47370")]
	private GDJICIGNNID CNMPDCBDCNJ(Transform PAANFEJKMMH, GDJICIGNNID MGIJLBFJDGP)
	{
		return default(GDJICIGNNID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7A48EE0", Offset = "0x7A476E0", VA = "0x187A48EE0")]
	private static bool JPGFHMAIFPK(GDMLPILFMNK LBIBOIDAHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7A499C0", Offset = "0x7A481C0", VA = "0x187A499C0", Slot = "9")]
	public bool PJJCAACHHHP(MDKBEOKIPPL FLBCLKGDNLP, int ANAEEFGGIMC, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7A47E20", Offset = "0x7A46620", VA = "0x187A47E20")]
	private bool GFHMGIKEDNP(MDKBEOKIPPL FLBCLKGDNLP, int ANAEEFGGIMC, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7A49790", Offset = "0x7A47F90", VA = "0x187A49790")]
	private static void OPNHIIOHOJJ(MDKBEOKIPPL FLBCLKGDNLP, int ANAEEFGGIMC, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN, GDMLPILFMNK BMNIJJBMABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7A481B0", Offset = "0x7A469B0", VA = "0x187A481B0")]
	private void HBMEMEKHEBH(MDKBEOKIPPL HBPADCPHPIG, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7A49110", Offset = "0x7A47910", VA = "0x187A49110")]
	private void JPKBKDPICCO(GDMLPILFMNK GDFCBMOFMFN, MDKBEOKIPPL HHMGAGINJIB, MDKBEOKIPPL DFMIOKFFOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7A490A0", Offset = "0x7A478A0", VA = "0x187A490A0")]
	private void JPKBKDPICCO(MDKBEOKIPPL OKJLAPLBHOI, MDKBEOKIPPL HHMGAGINJIB, MDKBEOKIPPL DFMIOKFFOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7A46F20", Offset = "0x7A45720", VA = "0x187A46F20")]
	private void BHCMHLHOKOB(MDKBEOKIPPL OKJLAPLBHOI, MDKBEOKIPPL HHMGAGINJIB, MDKBEOKIPPL DFMIOKFFOEB, bool BGFPICKKCCO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7A46E20", Offset = "0x7A45620", VA = "0x187A46E20")]
	private void BHCMHLHOKOB(GDMLPILFMNK PNDCHGJLEGG, MDKBEOKIPPL APILCALLJIO, MDKBEOKIPPL NGKMMGOCEGO, bool BGFPICKKCCO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7A47C50", Offset = "0x7A46450", VA = "0x187A47C50")]
	private void EFIIGHLJNDI(MDKBEOKIPPL NGDINOANFEF, int ANAEEFGGIMC, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7A47A80", Offset = "0x7A46280", VA = "0x187A47A80")]
	private void DGAKNOMJBLK(PLHJIALFGGK DFPCBMGPBFO, PLHJIALFGGK BEIOPFGHLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7A482D0", Offset = "0x7A46AD0", VA = "0x187A482D0", Slot = "18")]
	public MDKBEOKIPPL IAFNEGELAMD(MDKBEOKIPPL OKJLAPLBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7A48B40", Offset = "0x7A47340", VA = "0x187A48B40", Slot = "13")]
	public void IKDFBOPGJJF(MDKBEOKIPPL OKJLAPLBHOI, HashSet<MDKBEOKIPPL> LIJPOHIJDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7A492A0", Offset = "0x7A47AA0", VA = "0x187A492A0", Slot = "14")]
	public List<MDKBEOKIPPL> NEGNPMLCOHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7A49180", Offset = "0x7A47980", VA = "0x187A49180")]
	protected PLHJIALFGGK KHPDMLFENNG(PLHJIALFGGK GDFCBMOFMFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7A47D80", Offset = "0x7A46580", VA = "0x187A47D80")]
	protected GDMLPILFMNK[] FHEDHNKCICF(GDMLPILFMNK LBIBOIDAHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7A46770", Offset = "0x7A44F70", VA = "0x187A46770")]
	protected bool AFCCAFICGFJ(MDKBEOKIPPL OKJLAPLBHOI, [Out] GDMLPILFMNK GDFCBMOFMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7A494E0", Offset = "0x7A47CE0", VA = "0x187A494E0", Slot = "15")]
	public bool NLOHPAJDGHL(MDKBEOKIPPL OKJLAPLBHOI, [Out] GDJICIGNNID AMLOMBMBLGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7A49A20", Offset = "0x7A48220", VA = "0x187A49A20")]
	protected GDMLPILFMNK PJPALODICAM(GDJICIGNNID FOPJLDNMMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7A47BE0", Offset = "0x7A463E0", VA = "0x187A47BE0", Slot = "10")]
	public bool DPPLLKLGMCI(MDKBEOKIPPL HBPADCPHPIG, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7A46880", Offset = "0x7A45080", VA = "0x187A46880")]
	private bool AGHCBEEGFID(MDKBEOKIPPL HBPADCPHPIG, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7A496C0", Offset = "0x7A47EC0", VA = "0x187A496C0")]
	private static bool OFCKIIFCNBH(GDMLPILFMNK ODGFKOIGFBB, GDJICIGNNID HPENHLOOKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7A47C40", Offset = "0x7A46440", VA = "0x187A47C40", Slot = "7")]
	private bool EDCIDNPHOOD([In] KAFPOALHGGA NFNBKNAJBPN, bool AHNABHCJADP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class FPOHPGECAKF : IFKLCCFLMMA, JPHALCNLDIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly HHDGAAFLDEF PMKEELMHMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly DKIEFNELOOA NAEDIAJJFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly FKEEJDFMPFL OEEFELPBINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly OMGGOPJEOAE NJJPLADCJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly GBDOBIOCGIL LJMFKPGJJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal DJONMFKFFAB LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal KBAPKHHNMEC HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal JFDBGPELEKB BJNNICMLEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool BNCAONBDLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool AEDPDHMPNEE;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DIJINBGCJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xBDF3B0", Offset = "0xBDDBB0", VA = "0x180BDF3B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x122ECC0", Offset = "0x122D4C0", VA = "0x18122ECC0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AFPBFKGMNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x110B4D0", Offset = "0x1109CD0", VA = "0x18110B4D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2562C00", Offset = "0x2561400", VA = "0x182562C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FKFIEOCOGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MDKBEOKIPPL, MDKBEOKIPPL> KNAJNKHAMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7A4BEC0", Offset = "0x7A4A6C0", VA = "0x187A4BEC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7A4BF20", Offset = "0x7A4A720", VA = "0x187A4BF20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MDKBEOKIPPL, MDKBEOKIPPL> GDKODLBBOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7A4C460", Offset = "0x7A4AC60", VA = "0x187A4C460", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7A4D050", Offset = "0x7A4B850", VA = "0x187A4D050", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MDKBEOKIPPL, MDKBEOKIPPL, MDKBEOKIPPL> PFLGPLDIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7A4B910", Offset = "0x7A4A110", VA = "0x187A4B910", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7A4BB40", Offset = "0x7A4A340", VA = "0x187A4BB40", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4D0B0", Offset = "0x7A4B8B0", VA = "0x187A4D0B0")]
	public FPOHPGECAKF(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C880", Offset = "0x7A4B080", VA = "0x187A4C880", Slot = "12")]
	public void NPIOKLMMDIH(GameObject KJMBGAPFJAM, KDDGMLHDPDI PMOLHNABPOL, LFJEOOBHGCN BCKEDMLKOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7A4BBA0", Offset = "0x7A4A3A0", VA = "0x187A4BBA0", Slot = "26")]
	public void DPMOIAAKAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C4E0", Offset = "0x7A4ACE0", VA = "0x187A4C4E0", Slot = "13")]
	public void MAEEPMKIKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C4C0", Offset = "0x7A4ACC0", VA = "0x187A4C4C0", Slot = "14")]
	public void JNEAPGDNFGC(MDKBEOKIPPL OKJLAPLBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C400", Offset = "0x7A4AC00", VA = "0x187A4C400", Slot = "15")]
	public void IMKDBAIPGDE(MDKBEOKIPPL OKJLAPLBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C160", Offset = "0x7A4A960", VA = "0x187A4C160", Slot = "22")]
	public bool FPBHGHLPJAI(DOFEKKANHKF HGAAJHCCLOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B540", Offset = "0x7A49D40", VA = "0x187A4B540")]
	internal bool AGHCBEEGFID([In] KAFPOALHGGA NFNBKNAJBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C1B0", Offset = "0x7A4A9B0", VA = "0x187A4C1B0")]
	internal bool IADHLAHPHAD([In] KAFPOALHGGA NFNBKNAJBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C6A0", Offset = "0x7A4AEA0", VA = "0x187A4C6A0")]
	internal void NIHBNCAFCAN(MDKBEOKIPPL OKJLAPLBHOI, int JNNAFFGKKFL, bool AHNABHCJADP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C400", Offset = "0x7A4AC00", VA = "0x187A4C400")]
	internal bool PEDHPDIFEML(MDKBEOKIPPL DFGCBOKMFOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7A4CF20", Offset = "0x7A4B720", VA = "0x187A4CF20")]
	internal bool PAEPFIOJEKI(MDKBEOKIPPL FLBCLKGDNLP, int ANAEEFGGIMC, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C300", Offset = "0x7A4AB00", VA = "0x187A4C300", Slot = "16")]
	public void IKDFBOPGJJF(MDKBEOKIPPL OKJLAPLBHOI, HashSet<MDKBEOKIPPL> PCPFGHOLEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B700", Offset = "0x7A49F00", VA = "0x187A4B700", Slot = "17")]
	public void BGPLEDEJCME(MDKBEOKIPPL FLBCLKGDNLP, MDKBEOKIPPL DDBMPDNHJIM, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7A4C560", Offset = "0x7A4AD60", VA = "0x187A4C560", Slot = "18")]
	public void NEDAGKENHNC(MDKBEOKIPPL HBPADCPHPIG, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B970", Offset = "0x7A4A170", VA = "0x187A4B970", Slot = "19")]
	public void CPAPKKGNHPL(MDKBEOKIPPL HBPADCPHPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4BC70", Offset = "0x7A4A470", VA = "0x187A4BC70")]
	public void ELHBIFJCOMB([Optional] AHMCPLGEOJF PFBHOEIAGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7A4CE90", Offset = "0x7A4B690", VA = "0x187A4CE90", Slot = "23")]
	public void OOPJLDLFGJK(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B3C0", Offset = "0x7A49BC0", VA = "0x187A4B3C0", Slot = "20")]
	public CKPJMHLMLJF ACLGJGACBHF(bool JICGABHFIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7A4BFC0", Offset = "0x7A4A7C0", VA = "0x187A4BFC0", Slot = "21")]
	public CKPJMHLMLJF FNDIBIDKAIO(HashSet<Guid> BDEKIHDEEFL, bool JICGABHFIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7A4BF80", Offset = "0x7A4A780", VA = "0x187A4BF80", Slot = "25")]
	public void FMJIBJAFBLN(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B650", Offset = "0x7A49E50", VA = "0x187A4B650", Slot = "24")]
	public void AHHLPKIIGDH(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class DKIEFNELOOA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly LLDDHLANFDF<MDKBEOKIPPL, MDKBEOKIPPL> KNAJNKHAMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly LLDDHLANFDF<MDKBEOKIPPL, MDKBEOKIPPL> GDKODLBBOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly PBNCAGPCDPH<MDKBEOKIPPL, MDKBEOKIPPL, MDKBEOKIPPL> PFLGPLDIMOG;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7A49F40", Offset = "0x7A48740", VA = "0x187A49F40")]
	public DKIEFNELOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	public void NPIOKLMMDIH(FPOHPGECAKF IPKPNIAEJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7A49EE0", Offset = "0x7A486E0", VA = "0x187A49EE0")]
	public void PPNPMEMOAGC(MDKBEOKIPPL DFPCBMGPBFO, MDKBEOKIPPL NGDINOANFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7A49E80", Offset = "0x7A48680", VA = "0x187A49E80")]
	public void IKJFBHNAJJB(MDKBEOKIPPL DFPCBMGPBFO, MDKBEOKIPPL NGDINOANFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7A49E00", Offset = "0x7A48600", VA = "0x187A49E00")]
	public void EAICGFCJLFC(MDKBEOKIPPL HLEGNILMIKJ, MDKBEOKIPPL GPDOCAJDCGI, MDKBEOKIPPL NGDINOANFEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FKEEJDFMPFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private FPOHPGECAKF IPKPNIAEJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private KBAPKHHNMEC HIEPPCLFHOF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FKEEJDFMPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A370", Offset = "0x7A48B70", VA = "0x187A4A370")]
	public void NPIOKLMMDIH(FPOHPGECAKF IPKPNIAEJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A210", Offset = "0x7A48A10", VA = "0x187A4A210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A330", Offset = "0x7A48B30", VA = "0x187A4A330")]
	private void NONPGHCKOAP(NDBHNEPADKO OJPIEODNKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A1A0", Offset = "0x7A489A0", VA = "0x187A4A1A0")]
	private void CHBCPHDBKNH(AHMCPLGEOJF ADFADKOABNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A4B0", Offset = "0x7A48CB0", VA = "0x187A4A4B0")]
	public void OOJFOEPMKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A220", Offset = "0x7A48A20", VA = "0x187A4A220")]
	public void EJGKLNKIIFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class OKFJGFIDLII
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LFCBJMIFEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public HHDGAAFLDEF container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LFCBJMIFEJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7A50DC0", Offset = "0x7A4F5C0", VA = "0x187A50DC0")]
		internal FPOHPGECAKF NAPAIJCOGFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7A58670", Offset = "0x7A56E70", VA = "0x187A58670")]
	public static void LIJPFPPOPFH(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7A585F0", Offset = "0x7A56DF0", VA = "0x187A585F0")]
	public static void DPGGPBDHCLA(HHDGAAFLDEF PMKEELMHMLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class FPNGKGJBJIN : IDisposable, JFDBGPELEKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, JGFIJCPIBKD> MOCLEHKMNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FKAIKIPNIEG NHJIOAPMODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private KGKJLFFDDFI IJBDMIGIKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private GBDOBIOCGIL LJMFKPGJJNC;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker LCDDOGDMBKJ;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B2E0", Offset = "0x7A49AE0", VA = "0x187A4B2E0")]
	public FPNGKGJBJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7A4B240", Offset = "0x7A49A40", VA = "0x187A4B240", Slot = "7")]
	public void NPIOKLMMDIH(GBDOBIOCGIL LJMFKPGJJNC, KGKJLFFDDFI IJBDMIGIKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7A4AFA0", Offset = "0x7A497A0", VA = "0x187A4AFA0", Slot = "5")]
	public void MPLBMLBHBAK(PLHJIALFGGK PBMLNIONPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A5C0", Offset = "0x7A48DC0", VA = "0x187A4A5C0", Slot = "9")]
	public void BIINPPLILBD(PLHJIALFGGK NKEDLEBEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ADE0", Offset = "0x7A495E0", VA = "0x187A4ADE0", Slot = "8")]
	public void LGLJKHNOMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A8E0", Offset = "0x7A490E0", VA = "0x187A4A8E0", Slot = "10")]
	public void HNOAPJAJHBI(PLHJIALFGGK FBKAGDJMGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7A4AC30", Offset = "0x7A49430", VA = "0x187A4AC30", Slot = "11")]
	public void KCLHJKNDNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A730", Offset = "0x7A48F30", VA = "0x187A4A730")]
	private bool HGFEOLFDNCO(PLHJIALFGGK PEDIPEHLBOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class OMGGOPJEOAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct JOPHCGOAEEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly GDMLPILFMNK LKHOFDIJNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> BDEKIHDEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly DOFEKKANHKF OLJENMFKLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly DOFEKKANHKF DMIEMCJFHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool JICGABHFIAF;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool ICIODODFDAH
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7A50AF0", Offset = "0x7A4F2F0", VA = "0x187A50AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7A50C10", Offset = "0x7A4F410", VA = "0x187A50C10")]
		public JOPHCGOAEEN(GDMLPILFMNK LKHOFDIJNCO, HashSet<Guid> BDEKIHDEEFL, bool JICGABHFIAF, [Optional] DOFEKKANHKF OLJENMFKLEC, [Optional] DOFEKKANHKF DMIEMCJFHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7A50950", Offset = "0x7A4F150", VA = "0x187A50950")]
		public DOFEKKANHKF LIJGMGKAKKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7A50340", Offset = "0x7A4EB40", VA = "0x187A50340")]
		private DOFEKKANHKF BLHCLDJAJDL([Out] DOFEKKANHKF MHBHCFIMHNB, [Out] DOFEKKANHKF BBDEFBOFDJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7A50730", Offset = "0x7A4EF30", VA = "0x187A50730")]
		private DOFEKKANHKF KLLJOIHBHCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7A50400", Offset = "0x7A4EC00", VA = "0x187A50400")]
		private void EIHIBAJMHCK(DOFEKKANHKF EBHGNNONKDM, DOFEKKANHKF JCEJNBHLPPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7A50570", Offset = "0x7A4ED70", VA = "0x187A50570")]
		private void JMIAOFKAIEE(DOFEKKANHKF MHBHCFIMHNB, DOFEKKANHKF BBDEFBOFDJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private FPOHPGECAKF IPKPNIAEJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GBDOBIOCGIL LJMFKPGJJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private JFDBGPELEKB DMGFKEFKPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private KBAPKHHNMEC HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool DFBCGOLCKOA;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool PJLDHGKHEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A4B0", Offset = "0x7A58CB0", VA = "0x187A5A4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool DIJINBGCJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7A59B50", Offset = "0x7A58350", VA = "0x187A59B50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7A596E0", Offset = "0x7A57EE0", VA = "0x187A596E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7A5AB60", Offset = "0x7A59360", VA = "0x187A5AB60")]
	public void NPIOKLMMDIH(FPOHPGECAKF IPKPNIAEJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7A58870", Offset = "0x7A57070", VA = "0x187A58870")]
	public CKPJMHLMLJF ACLGJGACBHF(bool JICGABHFIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7A592B0", Offset = "0x7A57AB0", VA = "0x187A592B0")]
	public CKPJMHLMLJF FNDIBIDKAIO(HashSet<Guid> BDEKIHDEEFL, bool JICGABHFIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7A5ABD0", Offset = "0x7A593D0", VA = "0x187A5ABD0")]
	public void OOPJLDLFGJK(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7A589E0", Offset = "0x7A571E0", VA = "0x187A589E0")]
	public void AHHLPKIIGDH(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7A58C10", Offset = "0x7A57410", VA = "0x187A58C10")]
	public void CEEBLBFLBJE(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7A590C0", Offset = "0x7A578C0", VA = "0x187A590C0")]
	private void FDKNIJNNNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7A59700", Offset = "0x7A57F00", VA = "0x187A59700")]
	private DOFEKKANHKF HBIMJNLFIFO(GDMLPILFMNK GDFCBMOFMFN, bool JICGABHFIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7A58E70", Offset = "0x7A57670", VA = "0x187A58E70")]
	private static void ELNNBCOACCM(GDMLPILFMNK GDFCBMOFMFN, bool JICGABHFIAF, DOFEKKANHKF HGAAJHCCLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7A59930", Offset = "0x7A58130", VA = "0x187A59930")]
	private void HKAECICIHLL(GDMLPILFMNK GDFCBMOFMFN, bool JICGABHFIAF, DOFEKKANHKF HGAAJHCCLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7A58DE0", Offset = "0x7A575E0", VA = "0x187A58DE0")]
	private DOFEKKANHKF EHDKMEIIBNH(GDMLPILFMNK LKHOFDIJNCO, HashSet<Guid> BDEKIHDEEFL, bool JICGABHFIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7A5AC60", Offset = "0x7A59460", VA = "0x187A5AC60")]
	private bool PJJDBGIHBNN(CKPJMHLMLJF CFOFHMCCLKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7A5A500", Offset = "0x7A58D00", VA = "0x187A5A500")]
	private bool MLICAPNCICA(DOFEKKANHKF HGAAJHCCLOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7A58DC0", Offset = "0x7A575C0", VA = "0x187A58DC0")]
	private bool EADDDIPMGOL(CKPJMHLMLJF LJMFKPGJJNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7A59D00", Offset = "0x7A58500", VA = "0x187A59D00")]
	private static bool KCCHBPFJEFB(DOFEKKANHKF HGAAJHCCLOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7A59450", Offset = "0x7A57C50", VA = "0x187A59450")]
	public static bool FPBHGHLPJAI(DOFEKKANHKF HGAAJHCCLOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7A5A160", Offset = "0x7A58960", VA = "0x187A5A160")]
	private MDKBEOKIPPL LKBNCEGNJNI(DOFEKKANHKF HGAAJHCCLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7A58C40", Offset = "0x7A57440", VA = "0x187A58C40")]
	private MDKBEOKIPPL CPDANAKLJMF(DOFEKKANHKF HGAAJHCCLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7A59B70", Offset = "0x7A58370", VA = "0x187A59B70")]
	private MDKBEOKIPPL JOJPFPMHDFD(DOFEKKANHKF HGAAJHCCLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7A56C20", Offset = "0x7A55420", VA = "0x187A56C20")]
	private static Guid NCDGMIHNONH(DOFEKKANHKF HGAAJHCCLOF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7A59E10", Offset = "0x7A58610", VA = "0x187A59E10")]
	private string KLLIECEEAOM(DOFEKKANHKF HGAAJHCCLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7A58A80", Offset = "0x7A57280", VA = "0x187A58A80")]
	private bool BKJCABLBKPA(GDMLPILFMNK GDFCBMOFMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7A59F00", Offset = "0x7A58700", VA = "0x187A59F00")]
	private static void LCFALJFCKCN(GDMLPILFMNK LKHOFDIJNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public OMGGOPJEOAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct KAFPOALHGGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public MDKBEOKIPPL NGDINOANFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public MDKBEOKIPPL DFPCBMGPBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int ANAEEFGGIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int OOEMCGECECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 FPOMPEMDEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion BEOOEAAADEN;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GDJICIGNNID DEELMLABEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7A50CB0", Offset = "0x7A4F4B0", VA = "0x187A50CB0")]
		get
		{
			return default(GDJICIGNNID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GDJICIGNNID EDMMHDIECGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7A50C80", Offset = "0x7A4F480", VA = "0x187A50C80")]
		get
		{
			return default(GDJICIGNNID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7A50D50", Offset = "0x7A4F550", VA = "0x187A50D50")]
	public KAFPOALHGGA(MDKBEOKIPPL NGDINOANFEF, MDKBEOKIPPL DFPCBMGPBFO, int ANAEEFGGIMC, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface GBDOBIOCGIL
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PLHJIALFGGK DFJAHCLMMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPIOKLMMDIH(IFKLCCFLMMA IPKPNIAEJDE);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KJAGPCEMBCK([In] KAFPOALHGGA NFNBKNAJBPN, bool AHNABHCJADP = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FGLKJIGEKFO(MDKBEOKIPPL GHKHALNLOFH);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PJJCAACHHHP(MDKBEOKIPPL FLBCLKGDNLP, int ANAEEFGGIMC, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DPPLLKLGMCI(MDKBEOKIPPL HBPADCPHPIG, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LLMOHJNDPIJ();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GKPJMFBCILO(Func<MDKBEOKIPPL, bool> OCMNLCOAMOD);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IKDFBOPGJJF(MDKBEOKIPPL OKJLAPLBHOI, HashSet<MDKBEOKIPPL> LIJPOHIJDLM);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<MDKBEOKIPPL> NEGNPMLCOHF();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NLOHPAJDGHL(MDKBEOKIPPL OKJLAPLBHOI, [Out] GDJICIGNNID AMLOMBMBLGG);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KJEDGCELLFF(FKAIKIPNIEG NELMOECDPJP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool FKAIKIPNIEG(PLHJIALFGGK GDFCBMOFMFN);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface PLHJIALFGGK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MDKBEOKIPPL NBIIFMDHEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PLHJIALFGGK BKMKKMCIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GDJICIGNNID ANLIOPGFBED
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CAAEBALFIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JGFIJCPIBKD
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILJHHMHPGDK(MDKBEOKIPPL MJKMPACPODB, GDJICIGNNID NGDINOANFEF);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGLKLLDDEPI(MDKBEOKIPPL MJKMPACPODB, GDJICIGNNID NGDINOANFEF);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEJPNPFOCFP(MDKBEOKIPPL MJKMPACPODB, GDJICIGNNID NGDINOANFEF);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DIHJMMFJHLC(MDKBEOKIPPL MJKMPACPODB, GDJICIGNNID NGDINOANFEF);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JGFIJCPIBKD Instantiate(Transform POFBAOBKAGL);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNAKPKDGKOD();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface KGKJLFFDDFI
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPIOKLMMDIH(Transform POFBAOBKAGL, JGFIJCPIBKD JJAKBPKAKCA);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JGFIJCPIBKD PFBBGJGGBEL();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMEOKONKKEA(JGFIJCPIBKD FDOCLNLOLHE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DJONMFKFFAB : KLFAIEJGMLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBCALDGAKHE();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDPGDDIJNPK(Guid OLBCGDKCLDF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface JFDBGPELEKB
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPLBMLBHBAK(PLHJIALFGGK PBMLNIONPNF);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPIOKLMMDIH(GBDOBIOCGIL LJMFKPGJJNC, KGKJLFFDDFI HKCBONALAMI);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGLJKHNOMHO();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIINPPLILBD(PLHJIALFGGK NKEDLEBEGGM);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HNOAPJAJHBI(PLHJIALFGGK FBKAGDJMGNO);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCLHJKNDNAH();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class GDMLPILFMNK : PLHJIALFGGK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JAFAPDFPPHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GDJICIGNNID nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public GDMLPILFMNK foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JAFAPDFPPHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7A4FAC0", Offset = "0x7A4E2C0", VA = "0x187A4FAC0")]
		internal bool OBECFHJIOKL(PLHJIALFGGK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private GDJICIGNNID AMLOMBMBLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<GDMLPILFMNK> MHBEANDDIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GDMLPILFMNK GNFBADHLMBL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GDJICIGNNID ANLIOPGFBED
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x122F4B0", Offset = "0x122DCB0", VA = "0x18122F4B0", Slot = "6")]
		get
		{
			return default(GDJICIGNNID);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x122EE20", Offset = "0x122D620", VA = "0x18122EE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private GDMLPILFMNK DFPCBMGPBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A4E330", Offset = "0x7A4CB30", VA = "0x187A4E330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PLHJIALFGGK BKMKKMCIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MDKBEOKIPPL NBIIFMDHEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CAAEBALFIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A4E1D0", Offset = "0x7A4C9D0", VA = "0x187A4E1D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NICBFBDEPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A4E010", Offset = "0x7A4C810", VA = "0x187A4E010", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected GDMLPILFMNK PNDCHGJLEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A4DC70", Offset = "0x7A4C470", VA = "0x187A4DC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7A4E510", Offset = "0x7A4CD10", VA = "0x187A4E510")]
	public GDMLPILFMNK(GDJICIGNNID ABIENGEBMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DD40", Offset = "0x7A4C540", VA = "0x187A4DD40")]
	public GDMLPILFMNK JFLMNIPCHGD(GDJICIGNNID DPBIBHDNLDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DE90", Offset = "0x7A4C690", VA = "0x187A4DE90")]
	public GDMLPILFMNK KBAJHEKJEEB(GDJICIGNNID KBDJOEAKNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DA90", Offset = "0x7A4C290", VA = "0x187A4DA90")]
	public GDMLPILFMNK AHELLINFOCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7A4E1E0", Offset = "0x7A4C9E0", VA = "0x187A4E1E0")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7A4DC90", Offset = "0x7A4C490", VA = "0x187A4DC90")]
	public GDMLPILFMNK HPFNBCNEJHD(GDJICIGNNID GPDOCAJDCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7A4E060", Offset = "0x7A4C860", VA = "0x187A4E060")]
	private static void KJEDGCELLFF(GDMLPILFMNK FKFGIGKCEPK, FKAIKIPNIEG EIJBIEHCPFH, bool ONKGFKEOMEC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7A4E1C0", Offset = "0x7A4C9C0", VA = "0x187A4E1C0", Slot = "9")]
	public void KJEDGCELLFF(FKAIKIPNIEG NELMOECDPJP, bool BGFPICKKCCO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7A4E410", Offset = "0x7A4CC10", VA = "0x187A4E410")]
	public static GDMLPILFMNK PJPALODICAM(GDMLPILFMNK FKFGIGKCEPK, GDJICIGNNID LOBKNOBKJLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface KBAPKHHNMEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool PJLDHGKHEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool ADAEIDAFINM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<NDBHNEPADKO> NONPGHCKOAP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<AHMCPLGEOJF> CHBCPHDBKNH;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILJHHMHPGDK(FPOHPGECAKF IPKPNIAEJDE, LFJEOOBHGCN DNKPKNGFNNN);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BGPLEDEJCME(MDKBEOKIPPL FLBCLKGDNLP, MDKBEOKIPPL DDBMPDNHJIM, int ANAEEFGGIMC, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NEDAGKENHNC(MDKBEOKIPPL HBPADCPHPIG, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JCPLHMCHCOA(CKPJMHLMLJF DCFGEFAEIEM, [Optional] AHMCPLGEOJF PFBHOEIAGDC);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MHANLBIFAHP
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type PALJBODIBGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7A536C0", Offset = "0x7A51EC0", VA = "0x187A536C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object DJLOIKDDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A53720", Offset = "0x7A51F20", VA = "0x187A53720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A53670", Offset = "0x7A51E70", VA = "0x187A53670")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class GKLNPFNNHIA : KBAPKHHNMEC, IDisposable, NFBKCCOFLBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private FPOHPGECAKF IPKPNIAEJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private LFJEOOBHGCN BCKEDMLKOHD;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PJLDHGKHEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7A4EB50", Offset = "0x7A4D350", VA = "0x187A4EB50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool ADAEIDAFINM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A4ED80", Offset = "0x7A4D580", VA = "0x187A4ED80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView BMPKGEDPAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A4E6F0", Offset = "0x7A4CEF0", VA = "0x187A4E6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NDBHNEPADKO> NONPGHCKOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A4EAC0", Offset = "0x7A4D2C0", VA = "0x187A4EAC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7A4E900", Offset = "0x7A4D100", VA = "0x187A4E900", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<AHMCPLGEOJF> CHBCPHDBKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A4E780", Offset = "0x7A4CF80", VA = "0x187A4E780", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A4ECE0", Offset = "0x7A4D4E0", VA = "0x187A4ECE0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7A4E870", Offset = "0x7A4D070", VA = "0x187A4E870", Slot = "10")]
	public void ILJHHMHPGDK(FPOHPGECAKF IPKPNIAEJDE, LFJEOOBHGCN BCKEDMLKOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7A4E820", Offset = "0x7A4D020", VA = "0x187A4E820", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7A4E5C0", Offset = "0x7A4CDC0", VA = "0x187A4E5C0", Slot = "11")]
	public void BGPLEDEJCME(MDKBEOKIPPL FLBCLKGDNLP, MDKBEOKIPPL DDBMPDNHJIM, int ANAEEFGGIMC, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7A4EBB0", Offset = "0x7A4D3B0", VA = "0x187A4EBB0", Slot = "12")]
	public void NEDAGKENHNC(MDKBEOKIPPL HBPADCPHPIG, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7A4E990", Offset = "0x7A4D190", VA = "0x187A4E990", Slot = "13")]
	public void JCPLHMCHCOA(CKPJMHLMLJF DCFGEFAEIEM, [Optional] AHMCPLGEOJF PFBHOEIAGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F000", Offset = "0x7A4D800", VA = "0x187A4F000")]
	[FNNKNPEGGMF]
	private void RpcMasterReparentNodes(MDKBEOKIPPL HBPADCPHPIG, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7A4EE00", Offset = "0x7A4D600", VA = "0x187A4EE00")]
	[FNNKNPEGGMF]
	private void RpcMasterModifyNode(MDKBEOKIPPL FLBCLKGDNLP, MDKBEOKIPPL DDBMPDNHJIM, int ANAEEFGGIMC, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F3D0", Offset = "0x7A4DBD0", VA = "0x187A4F3D0")]
	[FNNKNPEGGMF]
	private void RpcReparentNodes(MDKBEOKIPPL HBPADCPHPIG, int JILOONNLCMG, MDKBEOKIPPL GPDOCAJDCGI, int GHPFEKDOPKJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN, KFPLHKFPBEI DGDHENFIOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7A4F310", Offset = "0x7A4DB10", VA = "0x187A4F310")]
	[FNNKNPEGGMF]
	private void RpcModifyNode(MDKBEOKIPPL FLBCLKGDNLP, int ANAEEFGGIMC, int OOEMCGECECB, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN, KFPLHKFPBEI DGDHENFIOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7A4EDC0", Offset = "0x7A4D5C0", VA = "0x187A4EDC0")]
	[FNNKNPEGGMF]
	private void RpcDeserializeConnectableGraph(CKPJMHLMLJF LJMFKPGJJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public GKLNPFNNHIA()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, JGFIJCPIBKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A512D0", Offset = "0x7A4FAD0", VA = "0x187A512D0", Slot = "4")]
		private void JACMIGAMAJK(MDKBEOKIPPL MJKMPACPODB, GDJICIGNNID NGDINOANFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A51060", Offset = "0x7A4F860", VA = "0x187A51060", Slot = "5")]
		private void INAGDIAIGNK(MDKBEOKIPPL MJKMPACPODB, GDJICIGNNID NGDINOANFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7A50F00", Offset = "0x7A4F700", VA = "0x187A50F00", Slot = "6")]
		private void IABFGEDGMBH(MDKBEOKIPPL MJKMPACPODB, GDJICIGNNID NGDINOANFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A51450", Offset = "0x7A4FC50", VA = "0x187A51450", Slot = "7")]
		private void MNIEBJANFJE(MDKBEOKIPPL MJKMPACPODB, GDJICIGNNID NGDINOANFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A50E90", Offset = "0x7A4F690", VA = "0x187A50E90", Slot = "8")]
		private JGFIJCPIBKD FOMLKCOHCND(Transform POFBAOBKAGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A50E30", Offset = "0x7A4F630", VA = "0x187A50E30", Slot = "9")]
		private void DFFONFPCCNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class HGBMPFCCNCH
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x37B6E00", Offset = "0x37B5600", VA = "0x1837B6E00")]
	public static GADINIBPIOP<T> CAOILNCCCFF<T>(this HHDGAAFLDEF PMKEELMHMLA)
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
