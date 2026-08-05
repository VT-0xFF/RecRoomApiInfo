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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8415440", Offset = "0x8413A40", VA = "0x188415440", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23FEEA0", Offset = "0x23FD4A0", VA = "0x1823FEEA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x841D370", Offset = "0x841B970", VA = "0x18841D370")]
		private void BFHOJBJGDPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x841D4E0", Offset = "0x841BAE0", VA = "0x18841D4E0")]
		private void KNNDHOHFANH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x841D650", Offset = "0x841BC50", VA = "0x18841D650", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x841D990", Offset = "0x841BF90", VA = "0x18841D990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class LBABGHLCADN : NBIIKBHEMIJ, DCEPPCNEFDI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class AAHGGKANNLP : IEnumerable<OKACHIBMKGD>, IEnumerable, IEnumerator<OKACHIBMKGD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private OKACHIBMKGD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private NLPLHJLLGBB localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NLPLHJLLGBB <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public LBABGHLCADN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HNBHNOBANOG <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private PDHGKNBOAKO <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private PDHGKNBOAKO.INJOMFCHHBJ <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private OKACHIBMKGD System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public AAHGGKANNLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8408B40", Offset = "0x8407140", VA = "0x188408B40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84086E0", Offset = "0x8406CE0", VA = "0x1884086E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84086C0", Offset = "0x8406CC0", VA = "0x1884086C0")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84086A0", Offset = "0x8406CA0", VA = "0x1884086A0")]
		private void FECGMFJNPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8408AF0", Offset = "0x84070F0", VA = "0x188408AF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8408A40", Offset = "0x8407040", VA = "0x188408A40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OKACHIBMKGD> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8408A40", Offset = "0x8407040", VA = "0x188408A40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DOPNDIBDHPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LBABGHLCADN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public LJADOIIMAPO nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DOPNDIBDHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8409390", Offset = "0x8407990", VA = "0x188409390")]
		internal object OANELGLGOGL(LJADOIIMAPO x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PCELFHOMNLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public LJADOIIMAPO child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DOPNDIBDHPE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PCELFHOMNLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8419F30", Offset = "0x8418530", VA = "0x188419F30")]
		internal object PDEPPCFKGHH((LJADOIIMAPO child, LJADOIIMAPO nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly IPHNFELODMJ DEKFIKFPNCC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly IPHNFELODMJ BKHJHFFOEBD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly IPHNFELODMJ HFEFMLJMIPE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IPHNFELODMJ OKACMFOMCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private AFGPKHPOMIB PCIAHMLOMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private OJHGNPOOCLL KBGMGHOLOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private BLCEJAOLGDJ NKBIKAMFAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OMBPNCAHOJD OHPHIKCFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private JNPPPJEJEON LONMFMIANGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HJAJILCFGKE GNBCLKHAFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ELCJHMDILDE KADNKCJPKCH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JNKPFBIAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5550", Offset = "0xAA3B50", VA = "0x180AA5550", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAA5500", Offset = "0xAA3B00", VA = "0x180AA5500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IJNDCAEJOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<OKACHIBMKGD, OKACHIBMKGD> LHIGDOEHMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8411FB0", Offset = "0x84105B0", VA = "0x188411FB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8410430", Offset = "0x840EA30", VA = "0x188410430", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<OKACHIBMKGD, OKACHIBMKGD> IFPONFKPKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x840FD80", Offset = "0x840E380", VA = "0x18840FD80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x840FCD0", Offset = "0x840E2D0", VA = "0x18840FCD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<OKACHIBMKGD, OKACHIBMKGD, OKACHIBMKGD> DLDLANJANBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8411BF0", Offset = "0x84101F0", VA = "0x188411BF0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8412060", Offset = "0x8410660", VA = "0x188412060", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8413960", Offset = "0x8411F60", VA = "0x188413960")]
	public LBABGHLCADN(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x840FA40", Offset = "0x840E040", VA = "0x18840FA40", Slot = "12")]
	public void BDBKJLHAGCA(GameObject JJEACKINPOJ, OBBDKNEOGOJ KBENEOFIFOL, ANNCENGJKKN OBAFOAGLIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84119B0", Offset = "0x840FFB0", VA = "0x1884119B0", Slot = "26")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8411BA0", Offset = "0x84101A0", VA = "0x188411BA0", Slot = "22")]
	public bool HEMCFGLMMLG(LJADOIIMAPO PFIDGGFALEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8410F70", Offset = "0x840F570", VA = "0x188410F70")]
	private void FNCMILMIEMM(NLPLHJLLGBB MHBODOHCMCO, NLPLHJLLGBB NAJIGMFBPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x840F820", Offset = "0x840DE20", VA = "0x18840F820")]
	private void AONCIEIBCID(NLPLHJLLGBB MHBODOHCMCO, NLPLHJLLGBB GAMLAOGLGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84104E0", Offset = "0x840EAE0", VA = "0x1884104E0")]
	private void DJDMKOJKNHO(NLPLHJLLGBB MHBODOHCMCO, NLPLHJLLGBB GAMLAOGLGBB, NLPLHJLLGBB NAJIGMFBPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8410B60", Offset = "0x840F160", VA = "0x188410B60")]
	private void FLFBBLFNMLN(NLPLHJLLGBB MHBODOHCMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "13")]
	public void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8412EA0", Offset = "0x84114A0", VA = "0x188412EA0", Slot = "14")]
	public void NCEHDCEOICJ(OKACHIBMKGD DFELMPOJHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "15")]
	public void HKHOCFFLDMG(OKACHIBMKGD DFELMPOJHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8413550", Offset = "0x8411B50", VA = "0x188413550", Slot = "17")]
	public void PMLIFLACKOJ(OKACHIBMKGD DFELMPOJHGA, OKACHIBMKGD EFLCEMIEHCM, Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84136B0", Offset = "0x8411CB0", VA = "0x1884136B0")]
	public void PMLIFLACKOJ(NLPLHJLLGBB PEKDBPKONMC, NLPLHJLLGBB EFLCEMIEHCM, Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8410740", Offset = "0x840ED40", VA = "0x188410740")]
	public void DKMEJBAHOOB(OKACHIBMKGD DFELMPOJHGA, float BJNPNLJGPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8412110", Offset = "0x8410710", VA = "0x188412110", Slot = "18")]
	public void KJNJGOFLBPH(OKACHIBMKGD GMONIEGJHHK, int LMNMINNODHI, OKACHIBMKGD DFOMLHDLFPK, int NEELACHFAJI, Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8411790", Offset = "0x840FD90", VA = "0x188411790")]
	private float GMLFACHNGFG(NLPLHJLLGBB PEKDBPKONMC, NLPLHJLLGBB BEBONNCPGLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8412270", Offset = "0x8410870", VA = "0x188412270")]
	public void KJNJGOFLBPH(NLPLHJLLGBB PEKDBPKONMC, NLPLHJLLGBB BEBONNCPGLF, Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK, bool LMBHHIPMGBE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8411840", Offset = "0x840FE40", VA = "0x188411840", Slot = "19")]
	public void GPEJKKFAPAA(OKACHIBMKGD DFELMPOJHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84131B0", Offset = "0x84117B0", VA = "0x1884131B0", Slot = "16")]
	public void OGOBMJCCEGF(OKACHIBMKGD DFELMPOJHGA, HashSet<OKACHIBMKGD> ILGPINFIBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "20")]
	public IKDOHLKMJIE OLIIFCEGOEB(bool NEBEFHEBPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "21")]
	public IKDOHLKMJIE GLIDBDHMFNB(HashSet<Guid> LEFHEAJHDCO, bool NEBEFHEBPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8411180", Offset = "0x840F780", VA = "0x188411180", Slot = "23")]
	public void GLNEDMPHCFO(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84124C0", Offset = "0x8410AC0", VA = "0x1884124C0", Slot = "24")]
	public void LAMODEMPHMC(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8412A20", Offset = "0x8411020", VA = "0x188412A20", Slot = "25")]
	public void LHDJBBJACPN(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8410020", Offset = "0x840E620", VA = "0x188410020")]
	private void DFAHGAMKIGN(NLPLHJLLGBB PEKDBPKONMC, NLPLHJLLGBB BEBONNCPGLF, Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK, float BJNPNLJGPDG, bool LMBHHIPMGBE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x840EEA0", Offset = "0x840D4A0", VA = "0x18840EEA0")]
	private void AFCMDBGMBFI(NLPLHJLLGBB PEKDBPKONMC, NLPLHJLLGBB JBFCMKMBEEK, Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x840F7B0", Offset = "0x840DDB0", VA = "0x18840F7B0")]
	private void AHOJJOLKEDK(NLPLHJLLGBB PEKDBPKONMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8411CA0", Offset = "0x84102A0", VA = "0x188411CA0")]
	[IteratorStateMachine(typeof(AAHGGKANNLP))]
	public IEnumerable<OKACHIBMKGD> HLEEFHFFAOG(NLPLHJLLGBB BJCKBJFHLNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8412530", Offset = "0x8410B30", VA = "0x188412530")]
	internal OKACHIBMKGD LFFEKFCAPKP(NLPLHJLLGBB BJCKBJFHLNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84109C0", Offset = "0x840EFC0", VA = "0x1884109C0")]
	internal NLPLHJLLGBB FDENDNFCGCN(OKACHIBMKGD DFELMPOJHGA)
	{
		return default(NLPLHJLLGBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84111F0", Offset = "0x840F7F0", VA = "0x1884111F0")]
	private bool GMIKPLKCGOG(LJADOIIMAPO PFIDGGFALEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84107D0", Offset = "0x840EDD0", VA = "0x1884107D0")]
	private bool EAKJKPGOCDJ(LJADOIIMAPO PFIDGGFALEN, [Out] OKACHIBMKGD BEBONNCPGLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8412670", Offset = "0x8410C70", VA = "0x188412670")]
	private OKACHIBMKGD LFFEKFCAPKP(LJADOIIMAPO PFIDGGFALEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x840FE30", Offset = "0x840E430", VA = "0x18840FE30")]
	private OKACHIBMKGD CNACIEJKCKL(LJADOIIMAPO PFIDGGFALEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8412CC0", Offset = "0x84112C0", VA = "0x188412CC0")]
	private OKACHIBMKGD MPGHKCKHFMH(LJADOIIMAPO PFIDGGFALEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8409600", Offset = "0x8407C00", VA = "0x188409600")]
	private static Guid BKBCOFFBPPK(LJADOIIMAPO PFIDGGFALEN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8412BD0", Offset = "0x84111D0", VA = "0x188412BD0")]
	private string MKIMMHHFOCM(LJADOIIMAPO PFIDGGFALEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8410830", Offset = "0x840EE30", VA = "0x188410830")]
	private void FBFCFOGAKMJ(OKACHIBMKGD PEKDBPKONMC, OKACHIBMKGD JBFCMKMBEEK, RigidTransform PDIPPFLBMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84133C0", Offset = "0x84119C0", VA = "0x1884133C0")]
	private void PHHEFLLCKCO(OKACHIBMKGD JBFCMKMBEEK, OKACHIBMKGD PEKDBPKONMC, RigidTransform PDIPPFLBMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x840FFC0", Offset = "0x840E5C0", VA = "0x18840FFC0")]
	private void DBJLOIDALBM(OKACHIBMKGD LJNFPGEOOPK, OKACHIBMKGD PEKDBPKONMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8412A40", Offset = "0x8411040", VA = "0x188412A40")]
	private void MJFFBOKCEJP(OKACHIBMKGD PEKDBPKONMC, OKACHIBMKGD BEBONNCPGLF, RigidTransform PDIPPFLBMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84123B0", Offset = "0x84109B0", VA = "0x1884123B0")]
	private void KKECAKABCAD(NLPLHJLLGBB BJCKBJFHLNJ, OKACHIBMKGD DFELMPOJHGA, NLPLHJLLGBB GAMLAOGLGBB, NLPLHJLLGBB NAJIGMFBPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8411D30", Offset = "0x8410330", VA = "0x188411D30")]
	private void HMAEOJCGCOB(NLPLHJLLGBB BJCKBJFHLNJ, OKACHIBMKGD DFELMPOJHGA, OKACHIBMKGD MNPHCCKECFL, OKACHIBMKGD MDCDIDODDBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BONKANCJBBM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MJMPIFMMFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NMNJFHODGJA container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MJMPIFMMFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8416110", Offset = "0x8414710", VA = "0x188416110")]
		internal LBABGHLCADN BJONPEPOKFF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8408D70", Offset = "0x8407370", VA = "0x188408D70")]
	public static void ICDGEOGILHE(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8408EF0", Offset = "0x84074F0", VA = "0x188408EF0")]
	public static void JHIJMBAMDID(NMNJFHODGJA JBBCAANONNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class PLJNCHPEFFE : LONHHGOCJDD, BBFONHNMCPD
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly LBABGHLCADN MENJEKNIGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly LILDEPMNLAO NLHNGCKJADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly IPEGHLHMGBC OHPHIKCFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly LLGGNBKHOEB[] JMJBFKGFNMA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OKACHIBMKGD NADJFFBGGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x841CF10", Offset = "0x841B510", VA = "0x18841CF10", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OKACHIBMKGD HOABOOJMBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x841BE40", Offset = "0x841A440", VA = "0x18841BE40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 HCHKMNHHJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x841B7F0", Offset = "0x8419DF0", VA = "0x18841B7F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion NMIBNIBBFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x841C5B0", Offset = "0x841ABB0", VA = "0x18841C5B0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EJAJEJCLHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x841B310", Offset = "0x8419910", VA = "0x18841B310", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<OKACHIBMKGD> AHFNLNKFPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x841CAF0", Offset = "0x841B0F0", VA = "0x18841CAF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool MPOPAHIFNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xDB20C0", Offset = "0xDB06C0", VA = "0x180DB20C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xDCD310", Offset = "0xDCB910", VA = "0x180DCD310", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x841D120", Offset = "0x841B720", VA = "0x18841D120", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject HPNHKENLPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x841CE20", Offset = "0x841B420", VA = "0x18841CE20", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x841CE40", Offset = "0x841B440", VA = "0x18841CE40", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid AJLBLMGMABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x841CF70", Offset = "0x841B570", VA = "0x18841CF70", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KJCIDALPAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x841D050", Offset = "0x841B650", VA = "0x18841D050", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool IKCGKMBAODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool PBGHMKDGHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x841C4C0", Offset = "0x841AAC0", VA = "0x18841C4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event LLIMOJEEDMP HDPBMCKDFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x841CBC0", Offset = "0x841B1C0", VA = "0x18841CBC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x841BD80", Offset = "0x841A380", VA = "0x18841BD80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LLIMOJEEDMP GPPDJOKMEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x841BDE0", Offset = "0x841A3E0", VA = "0x18841BDE0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x841B790", Offset = "0x8419D90", VA = "0x18841B790", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LLIMOJEEDMP HGMIBNOCOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x841C460", Offset = "0x841AA60", VA = "0x18841C460", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x841B8F0", Offset = "0x8419EF0", VA = "0x18841B8F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event JICDDDEPJBI LDMHABFCBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x841B850", Offset = "0x8419E50", VA = "0x18841B850", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x841C510", Offset = "0x841AB10", VA = "0x18841C510", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x841CD20", Offset = "0x841B320", VA = "0x18841CD20")]
	public PLJNCHPEFFE(NLPLHJLLGBB OIHEEOJKKOF, RigidbodyEx JDPJJGMMDGH, LILDEPMNLAO NLHNGCKJADO, LLGGNBKHOEB[] JMJBFKGFNMA, IPEGHLHMGBC OHPHIKCFIBF, NBIIKBHEMIJ MENJEKNIGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x841BFD0", Offset = "0x841A5D0", VA = "0x18841BFD0", Slot = "19")]
	public void GIEDMCCENPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "21")]
	public void DNMEFNFEIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8105D40", Offset = "0x8104340", VA = "0x188105D40", Slot = "22")]
	public void BFNEOIAGIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x841CC20", Offset = "0x841B220", VA = "0x18841CC20", Slot = "20")]
	public void PLMAAMEONBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x841C000", Offset = "0x841A600", VA = "0x18841C000", Slot = "25")]
	public void GIJEEMAAKDD(int HCFDHKABBFP, OKACHIBMKGD DFOMLHDLFPK, int DFKADBCNBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x841BF00", Offset = "0x841A500", VA = "0x18841BF00", Slot = "26")]
	public void GEFBKKBIMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x841C810", Offset = "0x841AE10", VA = "0x18841C810", Slot = "27")]
	public void KKMBJJDEDMF(int HCFDHKABBFP, OKACHIBMKGD GMONIEGJHHK, int BOJFLMLAHIL, [Optional] Vector3? LCJCICAHHCF, [Optional] Quaternion? DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x841BC60", Offset = "0x841A260", VA = "0x18841BC60", Slot = "28")]
	public void CPFHBKAJPKJ(OKACHIBMKGD GMONIEGJHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x841B380", Offset = "0x8419980", VA = "0x18841B380", Slot = "31")]
	public void BCHOCIGCJIC(Vector3 EANHJGACELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x841B950", Offset = "0x8419F50", VA = "0x18841B950", Slot = "29")]
	public void CGMJCJOAGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x841C610", Offset = "0x841AC10", VA = "0x18841C610", Slot = "30")]
	public void JOBPINHKDPD(int PMIGBJGNLLP, Vector3 ALFMKPLFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x841C390", Offset = "0x841A990", VA = "0x18841C390", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int HCFDHKABBFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x841C260", Offset = "0x841A860", VA = "0x18841C260", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int HCFDHKABBFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB0B180", Offset = "0xB09780", VA = "0x180B0B180", Slot = "42")]
	public Color GetConnectionSlotColor(int HCFDHKABBFP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x841BCE0", Offset = "0x841A2E0", VA = "0x18841BCE0", Slot = "43")]
	public bool CanConnectTo(int HCFDHKABBFP, OKACHIBMKGD DHLDEGNDEPE, int BEMJLNAJCEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "44")]
	public void ParentChanged(int HCFDHKABBFP, OKACHIBMKGD AHLHOLFBNJI, int FOBOINCIKAL, Vector3 PPCPOGIMDMA, Quaternion KDLJPMMIMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "45")]
	public void ChildAdded(int HCFDHKABBFP, OKACHIBMKGD ECFAMBAIFCI, int DOKJEGBCJPM, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "46")]
	public void ChildRemoved(int HCFDHKABBFP, OKACHIBMKGD OLIIPFPLGCF, int JAEFFBMGHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "47")]
	public void ConnectionModified(int HCFDHKABBFP, OKACHIBMKGD DFOMLHDLFPK, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x841CC70", Offset = "0x841B270", VA = "0x18841CC70", Slot = "48")]
	public void RootChanged(OKACHIBMKGD ENHKLOKPEPD, OKACHIBMKGD HJHBKDMCBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x841CB20", Offset = "0x841B120", VA = "0x18841CB20", Slot = "23")]
	public void OBHAECNBPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x841C210", Offset = "0x841A810", VA = "0x18841C210", Slot = "24")]
	public void GPBLOIHBGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x841CB70", Offset = "0x841B170", VA = "0x18841CB70")]
	private void OHLHNONFFNL(bool BEDDIODENHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(BMMPJAGNPHD), new string[] { })]
public class ADBADKFKEGF : BMMPJAGNPHD, HKPOOEHKBFO, PFDHPBBBFAF
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AKALKAEALMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AKALKAEALMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private KFOKIKACKHP AJLGIFGJLEI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object HKAEACJCDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8408C70", Offset = "0x8407270", VA = "0x188408C70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8408C20", Offset = "0x8407220", VA = "0x188408C20", Slot = "5")]
	private void CMMNFFLCJOL(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x135CED0", Offset = "0x135B4D0", VA = "0x18135CED0", Slot = "6")]
	private void GCOCFFJOAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public ADBADKFKEGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(NBIIKBHEMIJ), new string[] { "Ignore", "Mock" })]
public class PLECIABKBCC : NBIIKBHEMIJ, DCEPPCNEFDI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool JNKPFBIAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IJNDCAEJOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<OKACHIBMKGD, OKACHIBMKGD> LHIGDOEHMML
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x841B1B0", Offset = "0x84197B0", VA = "0x18841B1B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x841B050", Offset = "0x8419650", VA = "0x18841B050", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<OKACHIBMKGD, OKACHIBMKGD> IFPONFKPKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x841AFA0", Offset = "0x84195A0", VA = "0x18841AFA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x841AEF0", Offset = "0x84194F0", VA = "0x18841AEF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<OKACHIBMKGD, OKACHIBMKGD, OKACHIBMKGD> DLDLANJANBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x841B100", Offset = "0x8419700", VA = "0x18841B100", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x841B260", Offset = "0x8419860", VA = "0x18841B260", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "26")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "12")]
	public void BDBKJLHAGCA(GameObject JJEACKINPOJ, OBBDKNEOGOJ KBENEOFIFOL, ANNCENGJKKN AKCNGNFLEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "13")]
	public void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "14")]
	public void NCEHDCEOICJ(OKACHIBMKGD DFELMPOJHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "15")]
	public void HKHOCFFLDMG(OKACHIBMKGD DFELMPOJHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "16")]
	public void OGOBMJCCEGF(OKACHIBMKGD DFELMPOJHGA, HashSet<OKACHIBMKGD> ILGPINFIBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "17")]
	public void PMLIFLACKOJ(OKACHIBMKGD DFELMPOJHGA, OKACHIBMKGD EFLCEMIEHCM, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "18")]
	public void KJNJGOFLBPH(OKACHIBMKGD DFELMPOJHGA, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "19")]
	public void GPEJKKFAPAA(OKACHIBMKGD DFELMPOJHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "20")]
	public IKDOHLKMJIE OLIIFCEGOEB(bool NEBEFHEBPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "21")]
	public IKDOHLKMJIE GLIDBDHMFNB(HashSet<Guid> LEFHEAJHDCO, bool NEBEFHEBPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "22")]
	public bool HEMCFGLMMLG(LJADOIIMAPO PFIDGGFALEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "23")]
	public void GLNEDMPHCFO(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "24")]
	public void LAMODEMPHMC(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "25")]
	public void LHDJBBJACPN(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public PLECIABKBCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OKACHIBMKGD : BBFONHNMCPD, IEquatable<OKACHIBMKGD>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BBFONHNMCPD
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	OKACHIBMKGD NADJFFBGGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject HPNHKENLPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid AJLBLMGMABP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int KJCIDALPAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool IKCGKMBAODI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int HCFDHKABBFP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int HCFDHKABBFP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int HCFDHKABBFP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int HCFDHKABBFP, OKACHIBMKGD DHLDEGNDEPE, int MJKPDPODPAP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int HCFDHKABBFP, OKACHIBMKGD AHLHOLFBNJI, int FOBOINCIKAL, Vector3 PPCPOGIMDMA, Quaternion KDLJPMMIMAJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int HCFDHKABBFP, OKACHIBMKGD ECFAMBAIFCI, int DOKJEGBCJPM, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int HCFDHKABBFP, OKACHIBMKGD OLIIPFPLGCF, int JAEFFBMGHDA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int HCFDHKABBFP, OKACHIBMKGD DFOMLHDLFPK, int KLGFPNJJIPA, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(OKACHIBMKGD ENHKLOKPEPD, OKACHIBMKGD HJHBKDMCBEM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NBIIKBHEMIJ : DCEPPCNEFDI
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool JNKPFBIAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IJNDCAEJOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<OKACHIBMKGD, OKACHIBMKGD> LHIGDOEHMML;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<OKACHIBMKGD, OKACHIBMKGD> IFPONFKPKAG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<OKACHIBMKGD, OKACHIBMKGD, OKACHIBMKGD> DLDLANJANBM;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BDBKJLHAGCA(GameObject JJEACKINPOJ, OBBDKNEOGOJ KBENEOFIFOL, ANNCENGJKKN ONAMDPCNJOJ);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FPGILMIKMIA();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCEHDCEOICJ(OKACHIBMKGD DFELMPOJHGA);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HKHOCFFLDMG(OKACHIBMKGD DFELMPOJHGA);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OGOBMJCCEGF(OKACHIBMKGD DFELMPOJHGA, HashSet<OKACHIBMKGD> ILGPINFIBPK);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PMLIFLACKOJ(OKACHIBMKGD DFELMPOJHGA, OKACHIBMKGD EFLCEMIEHCM, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KJNJGOFLBPH(OKACHIBMKGD DFELMPOJHGA, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GPEJKKFAPAA(OKACHIBMKGD DFELMPOJHGA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IKDOHLKMJIE OLIIFCEGOEB(bool NEBEFHEBPAC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IKDOHLKMJIE GLIDBDHMFNB(HashSet<Guid> LEFHEAJHDCO, bool NEBEFHEBPAC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HEMCFGLMMLG(LJADOIIMAPO PFIDGGFALEN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GLNEDMPHCFO(IKDOHLKMJIE HEKJGPKFKAD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LAMODEMPHMC(IKDOHLKMJIE HEKJGPKFKAD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LHDJBBJACPN(IKDOHLKMJIE HEKJGPKFKAD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OMBPNCAHOJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OPHODICPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKACHIBMKGD MPGHKCKHFMH(int POGFMIOEHHC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OKACHIBMKGD CNACIEJKCKL(Guid FPAEMBJCHOO);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DEHIACMCGME(OKACHIBMKGD DFELMPOJHGA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JCNFIDOCAEH();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGKOODCCDJJ(OKACHIBMKGD NLHNGCKJADO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface IPEGHLHMGBC
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBGHMKDGHAD(LILDEPMNLAO NLHNGCKJADO);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEKGNNCBMCN(LILDEPMNLAO NLHNGCKJADO);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string HIEMKEHKMOC(LILDEPMNLAO NLHNGCKJADO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid HMEOFMEMAKL(LILDEPMNLAO NLHNGCKJADO);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AFPIPKGPKID(LILDEPMNLAO NLHNGCKJADO);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKKLAPNHMLJ(LILDEPMNLAO NLHNGCKJADO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void LLIMOJEEDMP(OKACHIBMKGD GMONIEGJHHK, int DOHKPMPGBAM, OKACHIBMKGD DFOMLHDLFPK, int GPOBJDHMEGN, [Optional] Vector3? LCJCICAHHCF, [Optional] Quaternion? DKBCGKBLKHL);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void JICDDDEPJBI(OKACHIBMKGD ENHKLOKPEPD, OKACHIBMKGD HJHBKDMCBEM);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LILDEPMNLAO : OKACHIBMKGD, BBFONHNMCPD, IEquatable<OKACHIBMKGD>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LONHHGOCJDD : BBFONHNMCPD
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OKACHIBMKGD HOABOOJMBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<OKACHIBMKGD> AHFNLNKFPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 HCHKMNHHJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion NMIBNIBBFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool EJAJEJCLHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool MPOPAHIFNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event LLIMOJEEDMP HDPBMCKDFEN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event LLIMOJEEDMP GPPDJOKMEFN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event LLIMOJEEDMP HGMIBNOCOFO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event JICDDDEPJBI LDMHABFCBBB;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GIEDMCCENPN();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PLMAAMEONBL();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DNMEFNFEIFP();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BFNEOIAGIGB();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OBHAECNBPGF();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GPBLOIHBGJH();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GIJEEMAAKDD(int HCFDHKABBFP, OKACHIBMKGD DFOMLHDLFPK, int DFKADBCNBNK);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GEFBKKBIMKE();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KKMBJJDEDMF(int HCFDHKABBFP, OKACHIBMKGD GMONIEGJHHK, int BOJFLMLAHIL, [Optional] Vector3? LCJCICAHHCF, [Optional] Quaternion? DKBCGKBLKHL);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CPFHBKAJPKJ(OKACHIBMKGD GMONIEGJHHK);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CGMJCJOAGCE();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JOBPINHKDPD(int PMIGBJGNLLP, Vector3 ALFMKPLFANJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BCHOCIGCJIC(Vector3 EANHJGACELJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LLGGNBKHOEB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 IMHDIFFKOHE
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
public interface OBBDKNEOGOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool ACPCCMHDBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FAAGPPFAKMN HFDMIAGHJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, OBBDKNEOGOJ
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
			[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB24ED0", VA = "0x180B268D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FAAGPPFAKMN LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8409080", Offset = "0x8407680", VA = "0x188409080")]
		public static ConnectableConfigData CGNDLDHGGKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8409140", Offset = "0x8407740", VA = "0x188409140")]
		public ConnectableConfigData(LegacyConnectableLinkVisual LKDNJEDHHDC, bool AOMBJDIOKMM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OJLPFLPKDEG : IEquatable<OJLPFLPKDEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public OKACHIBMKGD DFELMPOJHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int HGIMHJPBGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int KLGFPNJJIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 LCJCICAHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion DKBCGKBLKHL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8419E30", Offset = "0x8418430", VA = "0x188419E30")]
	public OJLPFLPKDEG(OKACHIBMKGD DFELMPOJHGA, int HGIMHJPBGBB, int KLGFPNJJIPA, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8419E90", Offset = "0x8418490", VA = "0x188419E90")]
	public OJLPFLPKDEG(OKACHIBMKGD DFELMPOJHGA, int HGIMHJPBGBB, int KLGFPNJJIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8419DA0", Offset = "0x84183A0", VA = "0x188419DA0")]
	public OJLPFLPKDEG(OKACHIBMKGD DFELMPOJHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8419930", Offset = "0x8417F30", VA = "0x188419930", Slot = "4")]
	public bool Equals(OJLPFLPKDEG AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x84199E0", Offset = "0x8417FE0", VA = "0x1884199E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class CNHONEOJECE : OELGFJOKPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform CCHLCEHOKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private FAAGPPFAKMN BFMAIEMAGMF;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7D84620", Offset = "0x7D82C20", VA = "0x187D84620", Slot = "4")]
	public void BDBKJLHAGCA(Transform CCHLCEHOKAD, FAAGPPFAKMN BFMAIEMAGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8408F40", Offset = "0x8407540", VA = "0x188408F40", Slot = "5")]
	public FAAGPPFAKMN AINCCICMPPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8409010", Offset = "0x8407610", VA = "0x188409010", Slot = "6")]
	public void DLLAJEOACGB(FAAGPPFAKMN CPDCBPOICNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public CNHONEOJECE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class NAKLINPCBMG : IDisposable, LNDPONPLDHC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DEODDOJCKEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public OKACHIBMKGD oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public OKACHIBMKGD newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DEODDOJCKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8409190", Offset = "0x8407790", VA = "0x188409190")]
		internal bool KMDAKDLALFO(CCGJLGPNJDE node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly MHAJGALPLKD HIDNENKIDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private GJKDHKJFFFH FLIFIIKDPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private FBPEGPDAPAH OIDEONFEIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool AOMBJDIOKMM;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly IPHNFELODMJ IMHKIBJCOMG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CCGJLGPNJDE HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8418220", Offset = "0x8416820", VA = "0x188418220")]
	public bool JAIBKGBLGCG([In] NEIEBIJMJJG CDDIADBJAOB, bool OAJKAHDDNOH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8416910", Offset = "0x8414F10", VA = "0x188416910")]
	private bool BPFOECEDIGK([In] NEIEBIJMJJG CDDIADBJAOB, bool OAJKAHDDNOH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x84195B0", Offset = "0x8417BB0", VA = "0x1884195B0")]
	public NAKLINPCBMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8416790", Offset = "0x8414D90", VA = "0x188416790", Slot = "5")]
	public void BDBKJLHAGCA(NBIIKBHEMIJ IHEHADIIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8417C60", Offset = "0x8416260", VA = "0x188417C60", Slot = "17")]
	public void ELIKKIFGEMF(PEDPKPBDKHE LAOAAOBGDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8417F40", Offset = "0x8416540", VA = "0x188417F40", Slot = "12")]
	public void FJFFKLOBDFP(Func<OKACHIBMKGD, bool> IDEDHNDHHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8417E10", Offset = "0x8416410", VA = "0x188417E10")]
	private void FJFFKLOBDFP(MHAJGALPLKD EMOGDLPNEGA, Func<OKACHIBMKGD, bool> IDEDHNDHHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8416770", Offset = "0x8414D70", VA = "0x188416770", Slot = "11")]
	public void ALDHHFKCPIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8418210", Offset = "0x8416810", VA = "0x188418210", Slot = "8")]
	public bool IFKKHAKJPCA(OKACHIBMKGD ABIEICCMIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8417410", Offset = "0x8415A10", VA = "0x188417410")]
	private bool EJKAAGBOJHA(OKACHIBMKGD IOFEEGEAMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8418AF0", Offset = "0x84170F0", VA = "0x188418AF0")]
	private static bool KILOKAFJCGH(OKACHIBMKGD IOFEEGEAMCB, MHAJGALPLKD IFFAJHBCLLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8418230", Offset = "0x8416830", VA = "0x188418230")]
	private void JNGPJHLLDDJ(Transform ONOFGCFDJGN, MHAJGALPLKD LCEEPKENPEP, MHAJGALPLKD[] BLPFMHBAKFL, OKACHIBMKGD BGMMCKLDMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8417B10", Offset = "0x8416110", VA = "0x188417B10")]
	private OJLPFLPKDEG EKPFBCKECMO(Transform JGFAEFIMMMP, OJLPFLPKDEG ABJHFDCPGPE)
	{
		return default(OJLPFLPKDEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8418620", Offset = "0x8416C20", VA = "0x188418620")]
	private static bool KADJHLOHNJC(MHAJGALPLKD IFFAJHBCLLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8418FB0", Offset = "0x84175B0", VA = "0x188418FB0", Slot = "9")]
	public bool OFIFHBFMPIA(OKACHIBMKGD GGKIKHOCECN, int BOJFLMLAHIL, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x84171C0", Offset = "0x84157C0", VA = "0x1884171C0")]
	private bool DNIAALKAFAK(OKACHIBMKGD GGKIKHOCECN, int BOJFLMLAHIL, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8417040", Offset = "0x8415640", VA = "0x188417040")]
	private static void DMPEHPAGDGI(OKACHIBMKGD GGKIKHOCECN, int BOJFLMLAHIL, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL, MHAJGALPLKD HIJNBKAHIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8417CF0", Offset = "0x84162F0", VA = "0x188417CF0")]
	private void FBFCFOGAKMJ(OKACHIBMKGD CFDLAIKOMND, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8418A80", Offset = "0x8417080", VA = "0x188418A80")]
	private void KFDMAPNIFGA(MHAJGALPLKD EMOGDLPNEGA, OKACHIBMKGD MNPHCCKECFL, OKACHIBMKGD MDCDIDODDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8418A10", Offset = "0x8417010", VA = "0x188418A10")]
	private void KFDMAPNIFGA(OKACHIBMKGD DFELMPOJHGA, OKACHIBMKGD MNPHCCKECFL, OKACHIBMKGD MDCDIDODDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x84180A0", Offset = "0x84166A0", VA = "0x1884180A0")]
	private void HMAEOJCGCOB(OKACHIBMKGD DFELMPOJHGA, OKACHIBMKGD MNPHCCKECFL, OKACHIBMKGD MDCDIDODDBB, bool BGLAHBJBFMC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8418110", Offset = "0x8416710", VA = "0x188418110")]
	private void HMAEOJCGCOB(MHAJGALPLKD BOCNDANOLJJ, OKACHIBMKGD BGMMCKLDMPI, OKACHIBMKGD HJHBKDMCBEM, bool BGLAHBJBFMC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x84193C0", Offset = "0x84179C0", VA = "0x1884193C0")]
	private void PHHEFLLCKCO(OKACHIBMKGD PEKDBPKONMC, int BOJFLMLAHIL, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8416EE0", Offset = "0x84154E0", VA = "0x188416EE0")]
	private void DBJLOIDALBM(CCGJLGPNJDE BEBONNCPGLF, CCGJLGPNJDE CCMONDHMLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x84188B0", Offset = "0x8416EB0", VA = "0x1884188B0", Slot = "18")]
	public OKACHIBMKGD KEKGOFGDCJJ(OKACHIBMKGD DFELMPOJHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8419010", Offset = "0x8417610", VA = "0x188419010", Slot = "13")]
	public void OGOBMJCCEGF(OKACHIBMKGD DFELMPOJHGA, HashSet<OKACHIBMKGD> FOAOHDLONHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8418D70", Offset = "0x8417370", VA = "0x188418D70", Slot = "14")]
	public List<OKACHIBMKGD> NCJDADNEDGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x84187E0", Offset = "0x8416DE0", VA = "0x1884187E0")]
	protected CCGJLGPNJDE KBBIBCOOLDE(CCGJLGPNJDE EMOGDLPNEGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8418CD0", Offset = "0x84172D0", VA = "0x188418CD0")]
	protected MHAJGALPLKD[] LOBNCDINODL(MHAJGALPLKD IFFAJHBCLLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8417F90", Offset = "0x8416590", VA = "0x188417F90")]
	protected bool GMPAJBOKDAG(OKACHIBMKGD DFELMPOJHGA, [Out] MHAJGALPLKD EMOGDLPNEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8418BA0", Offset = "0x84171A0", VA = "0x188418BA0", Slot = "15")]
	public bool LMMOPHNMGJC(OKACHIBMKGD DFELMPOJHGA, [Out] OJLPFLPKDEG LOFIFNJLGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8417F50", Offset = "0x8416550", VA = "0x188417F50")]
	protected MHAJGALPLKD FNDKCKCGKBD(OJLPFLPKDEG EIIOJAJHHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8417C90", Offset = "0x8416290", VA = "0x188417C90", Slot = "10")]
	public bool EOMDGLGFBEF(OKACHIBMKGD CFDLAIKOMND, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x84161C0", Offset = "0x84147C0", VA = "0x1884161C0")]
	private bool ALCKKMFJEHL(OKACHIBMKGD CFDLAIKOMND, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8416840", Offset = "0x8414E40", VA = "0x188416840")]
	private static bool BFLEPEOCMCK(MHAJGALPLKD GIALGHKDDFJ, OJLPFLPKDEG DEKALGFMPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8418220", Offset = "0x8416820", VA = "0x188418220", Slot = "7")]
	private bool IFOGBCIDMPE([In] NEIEBIJMJJG CDDIADBJAOB, bool OAJKAHDDNOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class GKMEECMLBBK : NBIIKBHEMIJ, DCEPPCNEFDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly NMNJFHODGJA JBBCAANONNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly FBPEGPDAPAH OIDEONFEIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly GBPKGJBMGOP JMCGLNAJJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly ENGCCMGFEMJ PEOMNHNMDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly LNDPONPLDHC HEKJGPKFKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal KBAEHBDOJJG OHPHIKCFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal MNOINPEHHKE JOLGKKEKLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal GJKDHKJFFFH CGMMMIKJJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool AOMBJDIOKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool DDEHINADKMP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LCPINOBHIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAF9E30", Offset = "0xAF8430", VA = "0x180AF9E30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAF9E40", Offset = "0xAF8440", VA = "0x180AF9E40")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool JNKPFBIAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB2DC40", Offset = "0xB2C240", VA = "0x180B2DC40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xB2DCE0", Offset = "0xB2C2E0", VA = "0x180B2DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IJNDCAEJOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<OKACHIBMKGD, OKACHIBMKGD> LHIGDOEHMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x840D2E0", Offset = "0x840B8E0", VA = "0x18840D2E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x840CC70", Offset = "0x840B270", VA = "0x18840CC70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<OKACHIBMKGD, OKACHIBMKGD> IFPONFKPKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x840CC10", Offset = "0x840B210", VA = "0x18840CC10", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x840C950", Offset = "0x840AF50", VA = "0x18840C950", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<OKACHIBMKGD, OKACHIBMKGD, OKACHIBMKGD> DLDLANJANBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x840D280", Offset = "0x840B880", VA = "0x18840D280", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x840D660", Offset = "0x840BC60", VA = "0x18840D660", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x840DEF0", Offset = "0x840C4F0", VA = "0x18840DEF0")]
	public GKMEECMLBBK(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x840C2E0", Offset = "0x840A8E0", VA = "0x18840C2E0", Slot = "12")]
	public void BDBKJLHAGCA(GameObject JJEACKINPOJ, OBBDKNEOGOJ KBENEOFIFOL, ANNCENGJKKN ONAMDPCNJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x840D160", Offset = "0x840B760", VA = "0x18840D160", Slot = "26")]
	public void HDAIJOIMLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x840CCD0", Offset = "0x840B2D0", VA = "0x18840CCD0", Slot = "13")]
	public void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x840D8F0", Offset = "0x840BEF0", VA = "0x18840D8F0", Slot = "14")]
	public void NCEHDCEOICJ(OKACHIBMKGD DFELMPOJHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x840C8F0", Offset = "0x840AEF0", VA = "0x18840C8F0", Slot = "15")]
	public void HKHOCFFLDMG(OKACHIBMKGD DFELMPOJHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x840D230", Offset = "0x840B830", VA = "0x18840D230", Slot = "22")]
	public bool HEMCFGLMMLG(LJADOIIMAPO PFIDGGFALEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x840C1D0", Offset = "0x840A7D0", VA = "0x18840C1D0")]
	internal bool ALCKKMFJEHL([In] NEIEBIJMJJG CDDIADBJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x840D910", Offset = "0x840BF10", VA = "0x18840D910")]
	internal bool NHIMAKAMLHA([In] NEIEBIJMJJG CDDIADBJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x840D480", Offset = "0x840BA80", VA = "0x18840D480")]
	internal void IKHPPEIAOCN(OKACHIBMKGD DFELMPOJHGA, int IPKBLDLAKMA, bool OAJKAHDDNOH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x840C8F0", Offset = "0x840AEF0", VA = "0x18840C8F0")]
	internal bool BJNNBAADAJJ(OKACHIBMKGD NBMPFDOBNJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x840D340", Offset = "0x840B940", VA = "0x18840D340")]
	internal bool ICFJFHEPING(OKACHIBMKGD GGKIKHOCECN, int BOJFLMLAHIL, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x840DA60", Offset = "0x840C060", VA = "0x18840DA60", Slot = "16")]
	public void OGOBMJCCEGF(OKACHIBMKGD DFELMPOJHGA, HashSet<OKACHIBMKGD> ILGPINFIBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x840DCE0", Offset = "0x840C2E0", VA = "0x18840DCE0", Slot = "17")]
	public void PMLIFLACKOJ(OKACHIBMKGD GGKIKHOCECN, OKACHIBMKGD EFLCEMIEHCM, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x840D6C0", Offset = "0x840BCC0", VA = "0x18840D6C0", Slot = "18")]
	public void KJNJGOFLBPH(OKACHIBMKGD CFDLAIKOMND, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x840CF90", Offset = "0x840B590", VA = "0x18840CF90", Slot = "19")]
	public void GPEJKKFAPAA(OKACHIBMKGD CFDLAIKOMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x840C9B0", Offset = "0x840AFB0", VA = "0x18840C9B0")]
	public void BOMMMEAOCPO([Optional] MEINMPIOLGA BIDBHBJLIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x840CF00", Offset = "0x840B500", VA = "0x18840CF00", Slot = "23")]
	public void GLNEDMPHCFO(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x840DB60", Offset = "0x840C160", VA = "0x18840DB60", Slot = "20")]
	public IKDOHLKMJIE OLIIFCEGOEB(bool NEBEFHEBPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x840CD50", Offset = "0x840B350", VA = "0x18840CD50", Slot = "21")]
	public IKDOHLKMJIE GLIDBDHMFNB(HashSet<Guid> LEFHEAJHDCO, bool NEBEFHEBPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x840D8B0", Offset = "0x840BEB0", VA = "0x18840D8B0", Slot = "25")]
	public void LHDJBBJACPN(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x840D800", Offset = "0x840BE00", VA = "0x18840D800", Slot = "24")]
	public void LAMODEMPHMC(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class FBPEGPDAPAH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly FCCGMMLDHAB<OKACHIBMKGD, OKACHIBMKGD> LHIGDOEHMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly FCCGMMLDHAB<OKACHIBMKGD, OKACHIBMKGD> IFPONFKPKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly KBNGHJAFOPM<OKACHIBMKGD, OKACHIBMKGD, OKACHIBMKGD> DLDLANJANBM;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x840BC90", Offset = "0x840A290", VA = "0x18840BC90")]
	public FBPEGPDAPAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	public void BDBKJLHAGCA(GKMEECMLBBK IHEHADIIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x840BBB0", Offset = "0x840A1B0", VA = "0x18840BBB0")]
	public void FJCMDLJDBIG(OKACHIBMKGD BEBONNCPGLF, OKACHIBMKGD PEKDBPKONMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x840BB50", Offset = "0x840A150", VA = "0x18840BB50")]
	public void BFENABLMAND(OKACHIBMKGD BEBONNCPGLF, OKACHIBMKGD PEKDBPKONMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x840BC10", Offset = "0x840A210", VA = "0x18840BC10")]
	public void IFINKNFJILL(OKACHIBMKGD LJNFPGEOOPK, OKACHIBMKGD JBFCMKMBEEK, OKACHIBMKGD PEKDBPKONMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class GBPKGJBMGOP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private GKMEECMLBBK IHEHADIIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private MNOINPEHHKE JOLGKKEKLAC;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public GBPKGJBMGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x840BDB0", Offset = "0x840A3B0", VA = "0x18840BDB0")]
	public void BDBKJLHAGCA(GKMEECMLBBK IHEHADIIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x840C040", Offset = "0x840A640", VA = "0x18840C040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x840BEF0", Offset = "0x840A4F0", VA = "0x18840BEF0")]
	private void CPDPIBNFDKD(NOCCEEEBCMN JPKKOPNBEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x840C050", Offset = "0x840A650", VA = "0x18840C050")]
	private void MCIFEABBMOH(MEINMPIOLGA KEDGBKADGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x840C0C0", Offset = "0x840A6C0", VA = "0x18840C0C0")]
	public void NCKGEGNFFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x840BF30", Offset = "0x840A530", VA = "0x18840BF30")]
	public void DKIBAILCBCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KJKEPIIKGEA
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OGBBAKGCLAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NMNJFHODGJA container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public OGBBAKGCLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x84198C0", Offset = "0x8417EC0", VA = "0x1884198C0")]
		internal GKMEECMLBBK BJONPEPOKFF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x840EC20", Offset = "0x840D220", VA = "0x18840EC20")]
	public static void ICDGEOGILHE(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x840EE20", Offset = "0x840D420", VA = "0x18840EE20")]
	public static void JHIJMBAMDID(NMNJFHODGJA JBBCAANONNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class PHANDJAPLPN : IDisposable, GJKDHKJFFFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, FAAGPPFAKMN> JAAMHOKOLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly PEDPKPBDKHE EBBDFDNKEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private OELGFJOKPAH NAKGGLJDOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private LNDPONPLDHC HEKJGPKFKAD;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker NJKOPHMKGND;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x841AE10", Offset = "0x8419410", VA = "0x18841AE10")]
	public PHANDJAPLPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x841A180", Offset = "0x8418780", VA = "0x18841A180", Slot = "7")]
	public void BDBKJLHAGCA(LNDPONPLDHC HEKJGPKFKAD, OELGFJOKPAH NAKGGLJDOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x841A830", Offset = "0x8418E30", VA = "0x18841A830", Slot = "5")]
	public void LHPJEAKCJBP(CCGJLGPNJDE LIADKNPHBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x841A6C0", Offset = "0x8418CC0", VA = "0x18841A6C0", Slot = "9")]
	public void LFFHBGDOEIJ(CCGJLGPNJDE PLFFAMBABKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x841AA70", Offset = "0x8419070", VA = "0x18841AA70", Slot = "8")]
	public void LOOJDOEJCBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x841A1C0", Offset = "0x84187C0", VA = "0x18841A1C0", Slot = "10")]
	public void HDJEPBFPNOJ(CCGJLGPNJDE CHJNGPMNDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x841AC30", Offset = "0x8419230", VA = "0x18841AC30", Slot = "11")]
	public void OEHMMJBAMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x841A510", Offset = "0x8418B10", VA = "0x18841A510")]
	private bool HGPFAHNONBD(CCGJLGPNJDE FMCINJJNLDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class ENGCCMGFEMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct IIPMCHPMADK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly MHAJGALPLKD MBOHPLNLJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> LEFHEAJHDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly LJADOIIMAPO AHMMNAKIPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly LJADOIIMAPO DPDBPGNDPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool NEBEFHEBPAC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool BHGDLKINCAH
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x840E700", Offset = "0x840CD00", VA = "0x18840E700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x840EBB0", Offset = "0x840D1B0", VA = "0x18840EBB0")]
		public IIPMCHPMADK(MHAJGALPLKD MBOHPLNLJEK, HashSet<Guid> LEFHEAJHDCO, bool NEBEFHEBPAC, [Optional] LJADOIIMAPO AHMMNAKIPBA, [Optional] LJADOIIMAPO DPDBPGNDPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x840E4A0", Offset = "0x840CAA0", VA = "0x18840E4A0")]
		public LJADOIIMAPO ANHNANMIGBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x840E640", Offset = "0x840CC40", VA = "0x18840E640")]
		private LJADOIIMAPO HOEEIDDEOMJ([Out] LJADOIIMAPO IIGBPOOECJM, [Out] LJADOIIMAPO HCDOBNEKGEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x840E820", Offset = "0x840CE20", VA = "0x18840E820")]
		private LJADOIIMAPO MNNBMLPCOKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x840EA40", Offset = "0x840D040", VA = "0x18840EA40")]
		private void OFLLHADKGNB(LJADOIIMAPO HMHBLCPACOI, LJADOIIMAPO DGFOEHNABIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x840E2E0", Offset = "0x840C8E0", VA = "0x18840E2E0")]
		private void ABOGKNBMPNL(LJADOIIMAPO IIGBPOOECJM, LJADOIIMAPO HCDOBNEKGEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private GKMEECMLBBK IHEHADIIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private LNDPONPLDHC HEKJGPKFKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private GJKDHKJFFFH FLIFIIKDPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private MNOINPEHHKE JOLGKKEKLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool NDNAAEKKHDI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool MNFHACKJACC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x840AC70", Offset = "0x8409270", VA = "0x18840AC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool LCPINOBHIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8409A60", Offset = "0x8408060", VA = "0x188409A60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x840B140", Offset = "0x8409740", VA = "0x18840B140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8409590", Offset = "0x8407B90", VA = "0x188409590")]
	public void BDBKJLHAGCA(GKMEECMLBBK IHEHADIIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x840B850", Offset = "0x8409E50", VA = "0x18840B850")]
	public IKDOHLKMJIE OLIIFCEGOEB(bool NEBEFHEBPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8409D60", Offset = "0x8408360", VA = "0x188409D60")]
	public IKDOHLKMJIE GLIDBDHMFNB(HashSet<Guid> LEFHEAJHDCO, bool NEBEFHEBPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8409F00", Offset = "0x8408500", VA = "0x188409F00")]
	public void GLNEDMPHCFO(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x840AD50", Offset = "0x8409350", VA = "0x18840AD50")]
	public void LAMODEMPHMC(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8409A80", Offset = "0x8408080", VA = "0x188409A80")]
	public void EJBNPOOLICG(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8409870", Offset = "0x8407E70", VA = "0x188409870")]
	private void EACKBKJECLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8409640", Offset = "0x8407C40", VA = "0x188409640")]
	private LJADOIIMAPO DFJHHCBPKLK(MHAJGALPLKD EMOGDLPNEGA, bool NEBEFHEBPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x840A600", Offset = "0x8408C00", VA = "0x18840A600")]
	private static void HEBFDDHCDJA(MHAJGALPLKD EMOGDLPNEGA, bool NEBEFHEBPAC, LJADOIIMAPO PFIDGGFALEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x840B630", Offset = "0x8409C30", VA = "0x18840B630")]
	private void OJHIBFGKBJC(MHAJGALPLKD EMOGDLPNEGA, bool NEBEFHEBPAC, LJADOIIMAPO PFIDGGFALEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x840ACC0", Offset = "0x84092C0", VA = "0x18840ACC0")]
	private LJADOIIMAPO KBDPCDJLLCJ(MHAJGALPLKD MBOHPLNLJEK, HashSet<Guid> LEFHEAJHDCO, bool NEBEFHEBPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8409AB0", Offset = "0x84080B0", VA = "0x188409AB0")]
	private bool GCAIJGMEGFA(IKDOHLKMJIE PJMIMLFBNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8409F90", Offset = "0x8408590", VA = "0x188409F90")]
	private bool GMIKPLKCGOG(LJADOIIMAPO PFIDGGFALEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8409D40", Offset = "0x8408340", VA = "0x188409D40")]
	private bool GCBPBMNPHIG(IKDOHLKMJIE HEKJGPKFKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x840B9C0", Offset = "0x8409FC0", VA = "0x18840B9C0")]
	private static bool OMBALACHPEE(LJADOIIMAPO PFIDGGFALEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x840A850", Offset = "0x8408E50", VA = "0x18840A850")]
	public static bool HEMCFGLMMLG(LJADOIIMAPO PFIDGGFALEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x840ADF0", Offset = "0x84093F0", VA = "0x18840ADF0")]
	private OKACHIBMKGD LFFEKFCAPKP(LJADOIIMAPO PFIDGGFALEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x840B4B0", Offset = "0x8409AB0", VA = "0x18840B4B0")]
	private OKACHIBMKGD MPGHKCKHFMH(LJADOIIMAPO PFIDGGFALEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8409400", Offset = "0x8407A00", VA = "0x188409400")]
	private OKACHIBMKGD ALHINLPLMIP(LJADOIIMAPO PFIDGGFALEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8409600", Offset = "0x8407C00", VA = "0x188409600")]
	private static Guid BKBCOFFBPPK(LJADOIIMAPO PFIDGGFALEN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x840B3C0", Offset = "0x84099C0", VA = "0x18840B3C0")]
	private string MKIMMHHFOCM(LJADOIIMAPO PFIDGGFALEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x840AAE0", Offset = "0x84090E0", VA = "0x18840AAE0")]
	private bool HKHONGCHJDJ(MHAJGALPLKD EMOGDLPNEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x840B160", Offset = "0x8409760", VA = "0x18840B160")]
	private static void MKAOHIIEKCL(MHAJGALPLKD MBOHPLNLJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public ENGCCMGFEMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct NEIEBIJMJJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public OKACHIBMKGD PEKDBPKONMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public OKACHIBMKGD BEBONNCPGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int BOJFLMLAHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int DFKADBCNBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 LCJCICAHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion DKBCGKBLKHL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public OJLPFLPKDEG BMNCENNIAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8419780", Offset = "0x8417D80", VA = "0x188419780")]
		get
		{
			return default(OJLPFLPKDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OJLPFLPKDEG PJBPOFHDHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8419820", Offset = "0x8417E20", VA = "0x188419820")]
		get
		{
			return default(OJLPFLPKDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8419850", Offset = "0x8417E50", VA = "0x188419850")]
	public NEIEBIJMJJG(OKACHIBMKGD PEKDBPKONMC, OKACHIBMKGD BEBONNCPGLF, int BOJFLMLAHIL, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface LNDPONPLDHC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CCGJLGPNJDE HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDBKJLHAGCA(NBIIKBHEMIJ IHEHADIIJNO);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JAIBKGBLGCG([In] NEIEBIJMJJG CDDIADBJAOB, bool OAJKAHDDNOH = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IFKKHAKJPCA(OKACHIBMKGD ABIEICCMIOH);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OFIFHBFMPIA(OKACHIBMKGD GGKIKHOCECN, int BOJFLMLAHIL, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EOMDGLGFBEF(OKACHIBMKGD CFDLAIKOMND, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ALDHHFKCPIO();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FJFFKLOBDFP(Func<OKACHIBMKGD, bool> IDEDHNDHHJC);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OGOBMJCCEGF(OKACHIBMKGD DFELMPOJHGA, HashSet<OKACHIBMKGD> FOAOHDLONHA);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<OKACHIBMKGD> NCJDADNEDGI();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LMMOPHNMGJC(OKACHIBMKGD DFELMPOJHGA, [Out] OJLPFLPKDEG LOFIFNJLGNA);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ELIKKIFGEMF(PEDPKPBDKHE LAOAAOBGDLL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool PEDPKPBDKHE(CCGJLGPNJDE EMOGDLPNEGA);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface CCGJLGPNJDE
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OKACHIBMKGD DAPKPHNFLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CCGJLGPNJDE IFNCNLOFOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OJLPFLPKDEG JKBPPPPMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CPLLCPOGEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FAAGPPFAKMN
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAKAIDJFGEI(OKACHIBMKGD DFOMLHDLFPK, OJLPFLPKDEG PEKDBPKONMC);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENNFFEECLAH(OKACHIBMKGD DFOMLHDLFPK, OJLPFLPKDEG PEKDBPKONMC);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACDNFJEBCKH(OKACHIBMKGD DFOMLHDLFPK, OJLPFLPKDEG PEKDBPKONMC);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHGKPPOMIDG(OKACHIBMKGD DFOMLHDLFPK, OJLPFLPKDEG PEKDBPKONMC);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FAAGPPFAKMN Instantiate(Transform CCHLCEHOKAD);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GELLEPHLJAH();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface OELGFJOKPAH
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDBKJLHAGCA(Transform CCHLCEHOKAD, FAAGPPFAKMN BFMAIEMAGMF);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FAAGPPFAKMN AINCCICMPPO();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLLAJEOACGB(FAAGPPFAKMN CPDCBPOICNG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface KBAEHBDOJJG : OMBPNCAHOJD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LPGMJHBPPBJ();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HGOKBCELOJO(Guid EIEGDICNOIG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GJKDHKJFFFH
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHPJEAKCJBP(CCGJLGPNJDE LIADKNPHBII);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDBKJLHAGCA(LNDPONPLDHC HEKJGPKFKAD, OELGFJOKPAH GKBEAKEPGKP);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LOOJDOEJCBO();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFFHBGDOEIJ(CCGJLGPNJDE PLFFAMBABKH);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDJEPBFPNOJ(CCGJLGPNJDE CHJNGPMNDPI);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OEHMMJBAMEI();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class MHAJGALPLKD : CCGJLGPNJDE
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DOHHFJKEBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public OJLPFLPKDEG nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public MHAJGALPLKD foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DOHHFJKEBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8409250", Offset = "0x8407850", VA = "0x188409250")]
		internal bool FOEKBPNHPJB(CCGJLGPNJDE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private OJLPFLPKDEG LOFIFNJLGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<MHAJGALPLKD> OOBEGDFAKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private MHAJGALPLKD OJJKOPJDCGE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public OJLPFLPKDEG JKBPPPPMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x157A6A0", Offset = "0x1578CA0", VA = "0x18157A6A0", Slot = "6")]
		get
		{
			return default(OJLPFLPKDEG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x157B100", Offset = "0x1579700", VA = "0x18157B100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private MHAJGALPLKD BEBONNCPGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8415F80", Offset = "0x8414580", VA = "0x188415F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public CCGJLGPNJDE IFNCNLOFOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OKACHIBMKGD DAPKPHNFLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CPLLCPOGEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8415910", Offset = "0x8413F10", VA = "0x188415910", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool AKGEEECFLIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8415E60", Offset = "0x8414460", VA = "0x188415E60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected MHAJGALPLKD BOCNDANOLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8415F60", Offset = "0x8414560", VA = "0x188415F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8416060", Offset = "0x8414660", VA = "0x188416060")]
	public MHAJGALPLKD(OJLPFLPKDEG PHOPDKPKNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x84155E0", Offset = "0x8413BE0", VA = "0x1884155E0")]
	public MHAJGALPLKD ANIDMLCEDFO(OJLPFLPKDEG CGOFINKJNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8415CE0", Offset = "0x84142E0", VA = "0x188415CE0")]
	public MHAJGALPLKD GBCBKHJFGFG(OJLPFLPKDEG AMBJCLDPIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8415730", Offset = "0x8413D30", VA = "0x188415730")]
	public MHAJGALPLKD CBELOMAGFLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8415920", Offset = "0x8413F20", VA = "0x188415920")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8415EB0", Offset = "0x84144B0", VA = "0x188415EB0")]
	public MHAJGALPLKD KKMFJLEJIIM(OJLPFLPKDEG JBFCMKMBEEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8415A70", Offset = "0x8414070", VA = "0x188415A70")]
	private static void ELIKKIFGEMF(MHAJGALPLKD MMINBADOHJI, PEDPKPBDKHE ENKJLGJOKLD, bool MMFEIIPAICK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8415BD0", Offset = "0x84141D0", VA = "0x188415BD0", Slot = "9")]
	public void ELIKKIFGEMF(PEDPKPBDKHE LAOAAOBGDLL, bool BGLAHBJBFMC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8415BE0", Offset = "0x84141E0", VA = "0x188415BE0")]
	public static MHAJGALPLKD FNDKCKCGKBD(MHAJGALPLKD MMINBADOHJI, OJLPFLPKDEG MKIIECBMCAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface MNOINPEHHKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool MNFHACKJACC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool OPHODICPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<NOCCEEEBCMN> CPDPIBNFDKD;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<MEINMPIOLGA> MCIFEABBMOH;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HAKAIDJFGEI(GKMEECMLBBK IHEHADIIJNO, ANNCENGJKKN AKCNGNFLEDI);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PMLIFLACKOJ(OKACHIBMKGD GGKIKHOCECN, OKACHIBMKGD EFLCEMIEHCM, int BOJFLMLAHIL, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KJNJGOFLBPH(OKACHIBMKGD CFDLAIKOMND, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GAICBGPLJBP(IKDOHLKMJIE MKDMOBNDKCL, [Optional] MEINMPIOLGA BIDBHBJLIML);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LCMIGBFCCLM
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type HIKNDMJOAGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x84139D0", Offset = "0x8411FD0", VA = "0x1884139D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object EHBCEBDHHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8413A30", Offset = "0x8412030", VA = "0x188413A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8413A70", Offset = "0x8412070", VA = "0x188413A70")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class LDCGKNHIBON : MNOINPEHHKE, IDisposable, CGBFDMEMEEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private GKMEECMLBBK IHEHADIIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private ANNCENGJKKN ONAMDPCNJOJ;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool MNFHACKJACC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8413E60", Offset = "0x8412460", VA = "0x188413E60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool OPHODICPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8413AD0", Offset = "0x84120D0", VA = "0x188413AD0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView CMHJKEMAFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8413EC0", Offset = "0x84124C0", VA = "0x188413EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NOCCEEEBCMN> CPDPIBNFDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8414090", Offset = "0x8412690", VA = "0x188414090", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8413B60", Offset = "0x8412160", VA = "0x188413B60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<MEINMPIOLGA> MCIFEABBMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8413D30", Offset = "0x8412330", VA = "0x188413D30", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8414130", Offset = "0x8412730", VA = "0x188414130", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8413DD0", Offset = "0x84123D0", VA = "0x188413DD0", Slot = "10")]
	public void HAKAIDJFGEI(GKMEECMLBBK IHEHADIIJNO, ANNCENGJKKN ONAMDPCNJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8413B10", Offset = "0x8412110", VA = "0x188413B10", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x84141D0", Offset = "0x84127D0", VA = "0x1884141D0", Slot = "11")]
	public void PMLIFLACKOJ(OKACHIBMKGD GGKIKHOCECN, OKACHIBMKGD EFLCEMIEHCM, int BOJFLMLAHIL, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8413F60", Offset = "0x8412560", VA = "0x188413F60", Slot = "12")]
	public void KJNJGOFLBPH(OKACHIBMKGD CFDLAIKOMND, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8413C00", Offset = "0x8412200", VA = "0x188413C00", Slot = "13")]
	public void GAICBGPLJBP(IKDOHLKMJIE MKDMOBNDKCL, [Optional] MEINMPIOLGA BIDBHBJLIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8414540", Offset = "0x8412B40", VA = "0x188414540")]
	[FPDADGGBBPP]
	private void RpcMasterReparentNodes(OKACHIBMKGD CFDLAIKOMND, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8414340", Offset = "0x8412940", VA = "0x188414340")]
	[FPDADGGBBPP]
	private void RpcMasterModifyNode(OKACHIBMKGD GGKIKHOCECN, OKACHIBMKGD EFLCEMIEHCM, int BOJFLMLAHIL, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8414940", Offset = "0x8412F40", VA = "0x188414940")]
	[FPDADGGBBPP]
	private void RpcReparentNodes(OKACHIBMKGD CFDLAIKOMND, int HHOFEHMFONP, OKACHIBMKGD JBFCMKMBEEK, int FOBOINCIKAL, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL, KFPLHECPDME KHHMGFIJALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8414850", Offset = "0x8412E50", VA = "0x188414850")]
	[FPDADGGBBPP]
	private void RpcModifyNode(OKACHIBMKGD GGKIKHOCECN, int BOJFLMLAHIL, int DFKADBCNBNK, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL, KFPLHECPDME KHHMGFIJALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8414300", Offset = "0x8412900", VA = "0x188414300")]
	[FPDADGGBBPP]
	private void RpcDeserializeConnectableGraph(IKDOHLKMJIE HEKJGPKFKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public LDCGKNHIBON()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, FAAGPPFAKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8414C30", Offset = "0x8413230", VA = "0x188414C30", Slot = "4")]
		private void AMNFKNGIPAP(OKACHIBMKGD DFOMLHDLFPK, OJLPFLPKDEG PEKDBPKONMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8415010", Offset = "0x8413610", VA = "0x188415010", Slot = "5")]
		private void JHCHLHGGCJM(OKACHIBMKGD DFOMLHDLFPK, OJLPFLPKDEG PEKDBPKONMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8415280", Offset = "0x8413880", VA = "0x188415280", Slot = "6")]
		private void NKFMFDOJGBC(OKACHIBMKGD DFOMLHDLFPK, OJLPFLPKDEG PEKDBPKONMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8414E20", Offset = "0x8413420", VA = "0x188414E20", Slot = "7")]
		private void IELDKNCJLGD(OKACHIBMKGD DFOMLHDLFPK, OJLPFLPKDEG PEKDBPKONMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8414DB0", Offset = "0x84133B0", VA = "0x188414DB0", Slot = "8")]
		private FAAGPPFAKMN DPKILIHFEBK(Transform CCHLCEHOKAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x84153E0", Offset = "0x84139E0", VA = "0x1884153E0", Slot = "9")]
		private void PHMJEIJCANH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OCPACDFIMME
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F78330", Offset = "0x3F76930", VA = "0x183F78330")]
	public static NDGKMFCGPKI<T> FKJEPIFIPLO<T>(this NMNJFHODGJA JBBCAANONNB)
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
