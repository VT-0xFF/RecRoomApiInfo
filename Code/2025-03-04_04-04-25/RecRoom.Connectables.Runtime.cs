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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x743C300", Offset = "0x743A900", VA = "0x18743C300", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x743DB70", Offset = "0x743C170", VA = "0x18743DB70", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x743D6D0", Offset = "0x743BCD0", VA = "0x18743D6D0")]
		private void ECIMOAOBJPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x743D560", Offset = "0x743BB60", VA = "0x18743D560")]
		private void BGELMNPCJDF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x743D840", Offset = "0x743BE40", VA = "0x18743D840", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x743DBB0", Offset = "0x743C1B0", VA = "0x18743DBB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class CDFPMHBFAGL : OHCENGCLELO, CBANIPAPHBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ICHLJJOHPOA : IEnumerable<BMDPNNJJDCJ>, IEnumerable, IEnumerator<BMDPNNJJDCJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private BMDPNNJJDCJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FHNHGOPNICC localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FHNHGOPNICC <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CDFPMHBFAGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ANDACNBFJKF <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PCANLNGHNBK <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private PCANLNGHNBK.LDKKNBPLJAF <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private BMDPNNJJDCJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public ICHLJJOHPOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7431750", Offset = "0x742FD50", VA = "0x187431750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74312F0", Offset = "0x742F8F0", VA = "0x1874312F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74312B0", Offset = "0x742F8B0", VA = "0x1874312B0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x74312D0", Offset = "0x742F8D0", VA = "0x1874312D0")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7431700", Offset = "0x742FD00", VA = "0x187431700", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7431650", Offset = "0x742FC50", VA = "0x187431650", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BMDPNNJJDCJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7431650", Offset = "0x742FC50", VA = "0x187431650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class POOOPLOCEBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public CDFPMHBFAGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ODFHIEJDKOP nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public POOOPLOCEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x743D2C0", Offset = "0x743B8C0", VA = "0x18743D2C0")]
		internal object NMKHLCKIAPI(ODFHIEJDKOP x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EECCPMKGDGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ODFHIEJDKOP child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public POOOPLOCEBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EECCPMKGDGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x742E6F0", Offset = "0x742CCF0", VA = "0x18742E6F0")]
		internal object JNBCLHNMLIN((ODFHIEJDKOP child, ODFHIEJDKOP nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly IBCMILIKEJG LEDEGELNLOI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly IBCMILIKEJG ABAABDJBJLF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly IBCMILIKEJG DBJOHNJFCFM;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IBCMILIKEJG CABCBDDOKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GIFNIBDCFIP FKHJKFDBNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IMLCHGCIBDL PNMHGOHNFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private FDJNGADHLPI LGGGNOENHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private HHHJMGJEPOI MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private PGCIHGMCKEE ILAAHLCCMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HEMIOEPGHGJ BMEANEKLBID;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA97260", Offset = "0xA95860", VA = "0x180A97260", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA96770", Offset = "0xA94D70", VA = "0x180A96770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BKHOANOEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> CNCOJEHHKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x742AA10", Offset = "0x7429010", VA = "0x18742AA10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7428FC0", Offset = "0x74275C0", VA = "0x187428FC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> EEPGEGJEBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x742CB10", Offset = "0x742B110", VA = "0x18742CB10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74294D0", Offset = "0x7427AD0", VA = "0x1874294D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ, BMDPNNJJDCJ> LLGDDAPECOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x742C6E0", Offset = "0x742ACE0", VA = "0x18742C6E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x742A020", Offset = "0x7428620", VA = "0x18742A020", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x742D610", Offset = "0x742BC10", VA = "0x18742D610")]
	public CDFPMHBFAGL(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x742BF40", Offset = "0x742A540", VA = "0x18742BF40", Slot = "12")]
	public void HPHCPPKCEKM(GameObject HHDLNMHBJJD, HILBNBMHMGD CPGFCKFAAJC, OAEFICKFFBI FNPCBNFJCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x742AEE0", Offset = "0x74294E0", VA = "0x18742AEE0", Slot = "26")]
	public void GFJNPMIAIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x742A0D0", Offset = "0x74286D0", VA = "0x18742A0D0", Slot = "22")]
	public bool ENABCDCINBE(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x742C4D0", Offset = "0x742AAD0", VA = "0x18742C4D0")]
	private void KDFHOLKLEPK(FHNHGOPNICC ELIIKDDDLGB, FHNHGOPNICC PCKJFEDJEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x742B0D0", Offset = "0x74296D0", VA = "0x18742B0D0")]
	private void GFNEBHBNAFG(FHNHGOPNICC ELIIKDDDLGB, FHNHGOPNICC BBKBAPMPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x742D0B0", Offset = "0x742B6B0", VA = "0x18742D0B0")]
	private void PDFBGANAGBC(FHNHGOPNICC ELIIKDDDLGB, FHNHGOPNICC BBKBAPMPONA, FHNHGOPNICC PCKJFEDJEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x742B7C0", Offset = "0x7429DC0", VA = "0x18742B7C0")]
	private void HFIPPEOJBNK(FHNHGOPNICC ELIIKDDDLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "13")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x742CBC0", Offset = "0x742B1C0", VA = "0x18742CBC0", Slot = "14")]
	public void OCICFIBHEPA(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "15")]
	public void IBEJEPFGGMM(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x742C790", Offset = "0x742AD90", VA = "0x18742C790", Slot = "17")]
	public void LLMBDHEJHGE(BMDPNNJJDCJ DGKBEFCBLCI, BMDPNNJJDCJ FMAJOMKBBMP, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x742C8F0", Offset = "0x742AEF0", VA = "0x18742C8F0")]
	public void LLMBDHEJHGE(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC FMAJOMKBBMP, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x742A980", Offset = "0x7428F80", VA = "0x18742A980")]
	public void FFBIFGIFHAL(BMDPNNJJDCJ DGKBEFCBLCI, float OPPJBCDKOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x742A6E0", Offset = "0x7428CE0", VA = "0x18742A6E0", Slot = "18")]
	public void FDGMIEJFDNJ(BMDPNNJJDCJ HMIAHNIHHOM, int ICHHEIADNOI, BMDPNNJJDCJ AHMIAIKKBKL, int PMNBMAJCEME, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x742AE30", Offset = "0x7429430", VA = "0x18742AE30")]
	private float FLNIOKLBFDE(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC LDIAONMHHPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x742A840", Offset = "0x7428E40", VA = "0x18742A840")]
	public void FDGMIEJFDNJ(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC LDIAONMHHPK, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, bool PPMANIBBLFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7428D60", Offset = "0x7427360", VA = "0x187428D60", Slot = "19")]
	public void AJGFFNFOFIC(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x742BD30", Offset = "0x742A330", VA = "0x18742BD30", Slot = "16")]
	public void HMPAJJANHCC(BMDPNNJJDCJ DGKBEFCBLCI, HashSet<BMDPNNJJDCJ> FELJDIHAKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "20")]
	public IHGCCLJDJEE PBPEPBPIFOJ(bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "21")]
	public IHGCCLJDJEE MCCLCEJLBJB(HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x742CA30", Offset = "0x742B030", VA = "0x18742CA30", Slot = "23")]
	public void MFNFOOHBAHK(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x742CAA0", Offset = "0x742B0A0", VA = "0x18742CAA0", Slot = "24")]
	public void MJJFJPKBIEO(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x742A6C0", Offset = "0x7428CC0", VA = "0x18742A6C0", Slot = "25")]
	public void FABEOONEPGL(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x742AAC0", Offset = "0x74290C0", VA = "0x18742AAC0")]
	private void FHIEGGHEFKM(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC LDIAONMHHPK, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, float OPPJBCDKOCC, bool PPMANIBBLFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74295E0", Offset = "0x7427BE0", VA = "0x1874295E0")]
	private void EDCENNDMDCD(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC DFDGPBFKIGC, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x742BCC0", Offset = "0x742A2C0", VA = "0x18742BCC0")]
	private void HLMFIIOEDEF(FHNHGOPNICC DJHFBAMKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7428F30", Offset = "0x7427530", VA = "0x187428F30")]
	[IteratorStateMachine(typeof(ICHLJJOHPOA))]
	public IEnumerable<BMDPNNJJDCJ> ANLDBMMHINN(FHNHGOPNICC KPOCLGHHOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x742B2F0", Offset = "0x74298F0", VA = "0x18742B2F0")]
	internal BMDPNNJJDCJ GJFAHCHJCBO(FHNHGOPNICC KPOCLGHHOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x742CED0", Offset = "0x742B4D0", VA = "0x18742CED0")]
	internal FHNHGOPNICC OGJAACJLCME(BMDPNNJJDCJ DGKBEFCBLCI)
	{
		return default(FHNHGOPNICC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x742A120", Offset = "0x7428720", VA = "0x18742A120")]
	private bool EOMBLENGFCH(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7429580", Offset = "0x7427B80", VA = "0x187429580")]
	private bool DPOAOGPDENB(ODFHIEJDKOP NAKBEFGIDDJ, [Out] BMDPNNJJDCJ LDIAONMHHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x742B420", Offset = "0x7429A20", VA = "0x18742B420")]
	private BMDPNNJJDCJ GJFAHCHJCBO(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x742D310", Offset = "0x742B910", VA = "0x18742D310")]
	private BMDPNNJJDCJ PGLOBOEKLDL(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x74292F0", Offset = "0x74278F0", VA = "0x1874292F0")]
	private BMDPNNJJDCJ CJMCDIJPDGH(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x742D070", Offset = "0x742B670", VA = "0x18742D070")]
	private static Guid PBJIOLICEMK(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x742BBD0", Offset = "0x742A1D0", VA = "0x18742BBD0")]
	private string HFNDCKKBJED(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7428BD0", Offset = "0x74271D0", VA = "0x187428BD0")]
	private void AIMANGHICGJ(BMDPNNJJDCJ DJHFBAMKFNI, BMDPNNJJDCJ DFDGPBFKIGC, RigidTransform EJDKLMAIDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x742C1B0", Offset = "0x742A7B0", VA = "0x18742C1B0")]
	private void IDNFBJHKCDI(BMDPNNJJDCJ DFDGPBFKIGC, BMDPNNJJDCJ DJHFBAMKFNI, RigidTransform EJDKLMAIDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7428ED0", Offset = "0x74274D0", VA = "0x187428ED0")]
	private void AKJIJGAEJLH(BMDPNNJJDCJ OIKBDABGNHP, BMDPNNJJDCJ DJHFBAMKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x742C340", Offset = "0x742A940", VA = "0x18742C340")]
	private void IFOFLPLEBOD(BMDPNNJJDCJ DJHFBAMKFNI, BMDPNNJJDCJ LDIAONMHHPK, RigidTransform EJDKLMAIDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7429F10", Offset = "0x7428510", VA = "0x187429F10")]
	private void EGGJNKIJMCN(FHNHGOPNICC KPOCLGHHOEP, BMDPNNJJDCJ DGKBEFCBLCI, FHNHGOPNICC BBKBAPMPONA, FHNHGOPNICC PCKJFEDJEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7429070", Offset = "0x7427670", VA = "0x187429070")]
	private void CCPNKCPLPLI(FHNHGOPNICC KPOCLGHHOEP, BMDPNNJJDCJ DGKBEFCBLCI, BMDPNNJJDCJ NDHOCLFLKAM, BMDPNNJJDCJ FIHALPBMNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OHLECKNGGMI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MELOKLADEKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GFKEMDIOCPC container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MELOKLADEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x743C4A0", Offset = "0x743AAA0", VA = "0x18743C4A0")]
		internal CDFPMHBFAGL FJDPDOMOIJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x743D0F0", Offset = "0x743B6F0", VA = "0x18743D0F0")]
	public static void CJMJKGHCPGN(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x743D270", Offset = "0x743B870", VA = "0x18743D270")]
	public static void IBCFIICLCCD(GFKEMDIOCPC MGOKPJKELJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class GCJNFGEGBHG : ALLCOIPAOAC, ONJCEPPJAHP
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly RigidbodyEx AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly CDFPMHBFAGL BJOMCLEDIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IBFCIOCDIDP IEMGOLPAHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly FINKGIKFNPA MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly ICJKHAFGCHI[] JMEACMPDFNH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BMDPNNJJDCJ CNJIEKHIMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x74307E0", Offset = "0x742EDE0", VA = "0x1874307E0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BMDPNNJJDCJ MEJALMHKJIG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x742FB00", Offset = "0x742E100", VA = "0x18742FB00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 DJNMIGFFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7430330", Offset = "0x742E930", VA = "0x187430330", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion BKBAJDPGCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x742EEE0", Offset = "0x742D4E0", VA = "0x18742EEE0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LOIHDHDIPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x742F7B0", Offset = "0x742DDB0", VA = "0x18742F7B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<BMDPNNJJDCJ> CALKOPHCDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x742F370", Offset = "0x742D970", VA = "0x18742F370", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool NEGDHCENKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAAE920", Offset = "0xAACF20", VA = "0x180AAE920", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAE45B0", Offset = "0xAE2BB0", VA = "0x180AE45B0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x74309F0", Offset = "0x742EFF0", VA = "0x1874309F0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject PFCBGIFALLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB2E0", Offset = "0x2BB98E0", VA = "0x182BBB2E0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7430710", Offset = "0x742ED10", VA = "0x187430710", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid PEABBCDCPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7430840", Offset = "0x742EE40", VA = "0x187430840", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int PONOHOGAKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7430920", Offset = "0x742EF20", VA = "0x187430920", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool CBPMGCPOPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JCNMFNFCCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x742F600", Offset = "0x742DC00", VA = "0x18742F600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event FBJJJHMCECB CLJFNAILKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x742F650", Offset = "0x742DC50", VA = "0x18742F650", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x742F0B0", Offset = "0x742D6B0", VA = "0x18742F0B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FBJJJHMCECB FHHIAAKDMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x742EC80", Offset = "0x742D280", VA = "0x18742EC80", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7430500", Offset = "0x742EB00", VA = "0x187430500", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FBJJJHMCECB GKIDOELNNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x742F750", Offset = "0x742DD50", VA = "0x18742F750", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x742F5A0", Offset = "0x742DBA0", VA = "0x18742F5A0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event KAEJELBOGIP EHCAKFJEKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7430410", Offset = "0x742EA10", VA = "0x187430410", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x742F6B0", Offset = "0x742DCB0", VA = "0x18742F6B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7430610", Offset = "0x742EC10", VA = "0x187430610")]
	public GCJNFGEGBHG(FHNHGOPNICC NMFKPCDLLEP, RigidbodyEx AMDJMIBOJED, IBFCIOCDIDP IEMGOLPAHNK, ICJKHAFGCHI[] JMEACMPDFNH, FINKGIKFNPA MOKEOOADLAP, OHCENGCLELO BJOMCLEDIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x742EC00", Offset = "0x742D200", VA = "0x18742EC00", Slot = "19")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "21")]
	public void DLGONACNNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x720ACE0", Offset = "0x72092E0", VA = "0x18720ACE0", Slot = "22")]
	public void IJFBDABDJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x742F110", Offset = "0x742D710", VA = "0x18742F110", Slot = "20")]
	public void EKFPEOGCKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x742F160", Offset = "0x742D760", VA = "0x18742F160", Slot = "25")]
	public void FKFKOOMLMNF(int IGEFECFIJLF, BMDPNNJJDCJ AHMIAIKKBKL, int EFNKBBPCJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x742EFE0", Offset = "0x742D5E0", VA = "0x18742EFE0", Slot = "26")]
	public void DFKLEHLOEIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x742F820", Offset = "0x742DE20", VA = "0x18742F820", Slot = "27")]
	public void LEJEILDFOAN(int IGEFECFIJLF, BMDPNNJJDCJ HMIAHNIHHOM, int ELJKAFNIPLE, [Optional] Vector3? FDCPPCKCABA, [Optional] Quaternion? IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7430390", Offset = "0x742E990", VA = "0x187430390", Slot = "28")]
	public void OJHJAAGEFEO(BMDPNNJJDCJ HMIAHNIHHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x742FED0", Offset = "0x742E4D0", VA = "0x18742FED0", Slot = "31")]
	public void MPFOPNOMMGN(Vector3 PHPEMJEBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x742FBC0", Offset = "0x742E1C0", VA = "0x18742FBC0", Slot = "29")]
	public void MOKDHCBEDDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x742ECE0", Offset = "0x742D2E0", VA = "0x18742ECE0", Slot = "30")]
	public void CKCMHAEBGIF(int EAHKFAJBNDN, Vector3 MIGPGADKMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x742F4D0", Offset = "0x742DAD0", VA = "0x18742F4D0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int IGEFECFIJLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x742F3A0", Offset = "0x742D9A0", VA = "0x18742F3A0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int IGEFECFIJLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA8B570", Offset = "0xA89B70", VA = "0x180A8B570", Slot = "42")]
	public Color GetConnectionSlotColor(int IGEFECFIJLF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x742EF40", Offset = "0x742D540", VA = "0x18742EF40", Slot = "43")]
	public bool CanConnectTo(int IGEFECFIJLF, BMDPNNJJDCJ BIDIEDLBPGA, int FLGBKFLJHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "44")]
	public void ParentChanged(int IGEFECFIJLF, BMDPNNJJDCJ DPPMAPDPENM, int KHPPENBDGCK, Vector3 JKIPLEFGDOM, Quaternion FOLGOFGMMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "45")]
	public void ChildAdded(int IGEFECFIJLF, BMDPNNJJDCJ DAMJKCBOKML, int DMKDLFPBCPK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "46")]
	public void ChildRemoved(int IGEFECFIJLF, BMDPNNJJDCJ BJGKCKKBPII, int DBMJLCMCMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "47")]
	public void ConnectionModified(int IGEFECFIJLF, BMDPNNJJDCJ AHMIAIKKBKL, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7430560", Offset = "0x742EB60", VA = "0x187430560", Slot = "48")]
	public void RootChanged(BMDPNNJJDCJ EHHFKAPFPMI, BMDPNNJJDCJ CEBMPGCDNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x742EC30", Offset = "0x742D230", VA = "0x18742EC30", Slot = "23")]
	public void AGPJHJCJPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x74304B0", Offset = "0x742EAB0", VA = "0x1874304B0", Slot = "24")]
	public void OPCNIMNAJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x74302E0", Offset = "0x742E8E0", VA = "0x1874302E0")]
	private void NKICFGFBLHG(bool IOCJOGLFEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(FNHEEJOANFA), new string[] { })]
public class GPKMHIGKFMJ : FNHEEJOANFA, ENAMDDMDDNO, EKIGFHLMNBE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class IANCCANPKDB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IANCCANPKDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[DependsOn]
	private NMLBDKMKDCC KPHLIDJMEFA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object DJFPOPGBOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7431070", Offset = "0x742F670", VA = "0x187431070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7431020", Offset = "0x742F620", VA = "0x187431020", Slot = "5")]
	private void GIBJGOKIIIN(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xF6DAD0", Offset = "0xF6C0D0", VA = "0x180F6DAD0", Slot = "6")]
	private void LCJILCFFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public GPKMHIGKFMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(OHCENGCLELO), new string[] { "Ignore", "Mock" })]
public class IJJHIDLNHIJ : OHCENGCLELO, CBANIPAPHBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BKHOANOEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> CNCOJEHHKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7432060", Offset = "0x7430660", VA = "0x187432060", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7431E50", Offset = "0x7430450", VA = "0x187431E50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> EEPGEGJEBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74321C0", Offset = "0x74307C0", VA = "0x1874321C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7431F00", Offset = "0x7430500", VA = "0x187431F00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ, BMDPNNJJDCJ> LLGDDAPECOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7432110", Offset = "0x7430710", VA = "0x187432110", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7431FB0", Offset = "0x74305B0", VA = "0x187431FB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "26")]
	public void GFJNPMIAIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "12")]
	public void HPHCPPKCEKM(GameObject HHDLNMHBJJD, HILBNBMHMGD CPGFCKFAAJC, OAEFICKFFBI BFJDNIICDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "13")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "14")]
	public void OCICFIBHEPA(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "15")]
	public void IBEJEPFGGMM(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "16")]
	public void HMPAJJANHCC(BMDPNNJJDCJ DGKBEFCBLCI, HashSet<BMDPNNJJDCJ> FELJDIHAKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "17")]
	public void LLMBDHEJHGE(BMDPNNJJDCJ DGKBEFCBLCI, BMDPNNJJDCJ FMAJOMKBBMP, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "18")]
	public void FDGMIEJFDNJ(BMDPNNJJDCJ DGKBEFCBLCI, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "19")]
	public void AJGFFNFOFIC(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "20")]
	public IHGCCLJDJEE PBPEPBPIFOJ(bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "21")]
	public IHGCCLJDJEE MCCLCEJLBJB(HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "22")]
	public bool ENABCDCINBE(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "23")]
	public void MFNFOOHBAHK(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "24")]
	public void MJJFJPKBIEO(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "25")]
	public void FABEOONEPGL(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public IJJHIDLNHIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BMDPNNJJDCJ : ONJCEPPJAHP, IEquatable<BMDPNNJJDCJ>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ONJCEPPJAHP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	BMDPNNJJDCJ CNJIEKHIMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject PFCBGIFALLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid PEABBCDCPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int PONOHOGAKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CBPMGCPOPMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int IGEFECFIJLF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int IGEFECFIJLF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int IGEFECFIJLF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int IGEFECFIJLF, BMDPNNJJDCJ BIDIEDLBPGA, int AFPLFAHMEKF);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int IGEFECFIJLF, BMDPNNJJDCJ DPPMAPDPENM, int KHPPENBDGCK, Vector3 JKIPLEFGDOM, Quaternion FOLGOFGMMFJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int IGEFECFIJLF, BMDPNNJJDCJ DAMJKCBOKML, int DMKDLFPBCPK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int IGEFECFIJLF, BMDPNNJJDCJ BJGKCKKBPII, int DBMJLCMCMGD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int IGEFECFIJLF, BMDPNNJJDCJ AHMIAIKKBKL, int JODIBACAJNE, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(BMDPNNJJDCJ EHHFKAPFPMI, BMDPNNJJDCJ CEBMPGCDNIA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OHCENGCLELO : CBANIPAPHBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BKHOANOEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> CNCOJEHHKPE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> EEPGEGJEBOL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<BMDPNNJJDCJ, BMDPNNJJDCJ, BMDPNNJJDCJ> LLGDDAPECOH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HPHCPPKCEKM(GameObject HHDLNMHBJJD, HILBNBMHMGD CPGFCKFAAJC, OAEFICKFFBI PLMOGFFBIKA);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PLJNMJIHBJD();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OCICFIBHEPA(BMDPNNJJDCJ DGKBEFCBLCI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IBEJEPFGGMM(BMDPNNJJDCJ DGKBEFCBLCI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HMPAJJANHCC(BMDPNNJJDCJ DGKBEFCBLCI, HashSet<BMDPNNJJDCJ> FELJDIHAKCA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LLMBDHEJHGE(BMDPNNJJDCJ DGKBEFCBLCI, BMDPNNJJDCJ FMAJOMKBBMP, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FDGMIEJFDNJ(BMDPNNJJDCJ DGKBEFCBLCI, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AJGFFNFOFIC(BMDPNNJJDCJ DGKBEFCBLCI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IHGCCLJDJEE PBPEPBPIFOJ(bool BIKMDKDNAOA);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IHGCCLJDJEE MCCLCEJLBJB(HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool ENABCDCINBE(ODFHIEJDKOP NAKBEFGIDDJ);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MFNFOOHBAHK(IHGCCLJDJEE CJLJJENJCHE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MJJFJPKBIEO(IHGCCLJDJEE CJLJJENJCHE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FABEOONEPGL(IHGCCLJDJEE CJLJJENJCHE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HHHJMGJEPOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DIHDOFMHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMDPNNJJDCJ CJMCDIJPDGH(int HMLBEPAJOAO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMDPNNJJDCJ PGLOBOEKLDL(Guid IPJKPLLEKIE);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ILAJAANDDKB(BMDPNNJJDCJ DGKBEFCBLCI);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DALLBLMIAME();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDACDDFBOCG(BMDPNNJJDCJ IEMGOLPAHNK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface FINKGIKFNPA
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JCNMFNFCCML(IBFCIOCDIDP IEMGOLPAHNK);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POLNIGJLFJM(IBFCIOCDIDP IEMGOLPAHNK);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string KCGJNGEHEKH(IBFCIOCDIDP IEMGOLPAHNK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid AFBKIIBJBAE(IBFCIOCDIDP IEMGOLPAHNK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CPGJGPOBFAF(IBFCIOCDIDP IEMGOLPAHNK);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NCHIPCHKNIH(IBFCIOCDIDP IEMGOLPAHNK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void FBJJJHMCECB(BMDPNNJJDCJ HMIAHNIHHOM, int CBDHGPANJJM, BMDPNNJJDCJ AHMIAIKKBKL, int MKCJOAHJJLN, [Optional] Vector3? FDCPPCKCABA, [Optional] Quaternion? IEODDBPKAOA);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void KAEJELBOGIP(BMDPNNJJDCJ EHHFKAPFPMI, BMDPNNJJDCJ CEBMPGCDNIA);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IBFCIOCDIDP : BMDPNNJJDCJ, ONJCEPPJAHP, IEquatable<BMDPNNJJDCJ>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ALLCOIPAOAC : ONJCEPPJAHP
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	BMDPNNJJDCJ MEJALMHKJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<BMDPNNJJDCJ> CALKOPHCDHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 DJNMIGFFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion BKBAJDPGCJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool LOIHDHDIPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool NEGDHCENKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event FBJJJHMCECB CLJFNAILKMA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event FBJJJHMCECB FHHIAAKDMLK;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event FBJJJHMCECB GKIDOELNNBC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event KAEJELBOGIP EHCAKFJEKKO;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AEGNBCCGJEM();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EKFPEOGCKKC();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DLGONACNNEP();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IJFBDABDJPD();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void AGPJHJCJPDH();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OPCNIMNAJBG();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FKFKOOMLMNF(int IGEFECFIJLF, BMDPNNJJDCJ AHMIAIKKBKL, int EFNKBBPCJHM);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DFKLEHLOEIE();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LEJEILDFOAN(int IGEFECFIJLF, BMDPNNJJDCJ HMIAHNIHHOM, int ELJKAFNIPLE, [Optional] Vector3? FDCPPCKCABA, [Optional] Quaternion? IEODDBPKAOA);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OJHJAAGEFEO(BMDPNNJJDCJ HMIAHNIHHOM);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void MOKDHCBEDDL();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CKCMHAEBGIF(int EAHKFAJBNDN, Vector3 MIGPGADKMKK);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MPFOPNOMMGN(Vector3 PHPEMJEBCJP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ICJKHAFGCHI
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 MHPOCMEOHNM
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
public interface HILBNBMHMGD
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NDMDLCCAEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NGOMIHOGADO DLNIMDPJHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, HILBNBMHMGD
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
			[Cpp2IlInjected.Address(RVA = "0xBB40B0", Offset = "0xBB26B0", VA = "0x180BB40B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public NGOMIHOGADO LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x742E5E0", Offset = "0x742CBE0", VA = "0x18742E5E0")]
		public static ConnectableConfigData MEOPIEKILPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x742E6A0", Offset = "0x742CCA0", VA = "0x18742E6A0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual DDBMPCBOGHA, bool APOEHFIIACM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GOFPOGHLFFG : IEquatable<GOFPOGHLFFG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public BMDPNNJJDCJ DGKBEFCBLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int CPNKOGECOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int JODIBACAJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 FDCPPCKCABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion IEODDBPKAOA;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7430FC0", Offset = "0x742F5C0", VA = "0x187430FC0")]
	public GOFPOGHLFFG(BMDPNNJJDCJ DGKBEFCBLCI, int CPNKOGECOFG, int JODIBACAJNE, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7430F20", Offset = "0x742F520", VA = "0x187430F20")]
	public GOFPOGHLFFG(BMDPNNJJDCJ DGKBEFCBLCI, int CPNKOGECOFG, int JODIBACAJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7430E90", Offset = "0x742F490", VA = "0x187430E90")]
	public GOFPOGHLFFG(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7430A10", Offset = "0x742F010", VA = "0x187430A10", Slot = "4")]
	public bool Equals(GOFPOGHLFFG OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7430AC0", Offset = "0x742F0C0", VA = "0x187430AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class IDLKAKKFONB : ALOKGODEANA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform EJNLPEDOMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private NGOMIHOGADO KALEKMNLDMM;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E66740", Offset = "0x6E64D40", VA = "0x186E66740", Slot = "4")]
	public void HPHCPPKCEKM(Transform EJNLPEDOMDD, NGOMIHOGADO KALEKMNLDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x74318A0", Offset = "0x742FEA0", VA = "0x1874318A0", Slot = "5")]
	public NGOMIHOGADO COJHCACLDLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7431830", Offset = "0x742FE30", VA = "0x187431830", Slot = "6")]
	public void CECIFJNFCFB(NGOMIHOGADO EMPNCNGFEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public IDLKAKKFONB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KDFCGKMNDCC : IDisposable, FAEBNAJOBDC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IECDHKOKKFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BMDPNNJJDCJ oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BMDPNNJJDCJ newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IECDHKOKKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7431970", Offset = "0x742FF70", VA = "0x187431970")]
		internal bool AHPMKJLLICG(GAEKAMDMECB node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly LLIEBCFGNOO PMJKOMMPAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private PHOKLPIAJNA NCNJMNAJMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NBKCKKJIDPP HHONMODOICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool APOEHFIIACM;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly IBCMILIKEJG NDOCJAODLGH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public GAEKAMDMECB HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x74341F0", Offset = "0x74327F0", VA = "0x1874341F0")]
	public bool JCOBJLBEPOK([In] HAOAACJBKAA GIDGOODJFLJ, bool KGLEDONBJKL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7435320", Offset = "0x7433920", VA = "0x187435320")]
	private bool KMHHJPBGDGH([In] HAOAACJBKAA GIDGOODJFLJ, bool KGLEDONBJKL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x74365D0", Offset = "0x7434BD0", VA = "0x1874365D0")]
	public KDFCGKMNDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7434E00", Offset = "0x7433400", VA = "0x187434E00", Slot = "5")]
	public void HPHCPPKCEKM(OHCENGCLELO JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7434820", Offset = "0x7432E20", VA = "0x187434820", Slot = "17")]
	public void GFIPODBBGDC(BGGDFHKINDH IJCKFHFIADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7434910", Offset = "0x7432F10", VA = "0x187434910", Slot = "12")]
	public void HAINDHHJEHL(Func<BMDPNNJJDCJ, bool> PFLNFMCJAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7434920", Offset = "0x7432F20", VA = "0x187434920")]
	private void HAINDHHJEHL(LLIEBCFGNOO HPEELAFENFB, Func<BMDPNNJJDCJ, bool> PFLNFMCJAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x74345E0", Offset = "0x7432BE0", VA = "0x1874345E0", Slot = "11")]
	public void EHKGPBPGAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7433630", Offset = "0x7431C30", VA = "0x187433630", Slot = "8")]
	public bool BOIFBBLIOKE(BMDPNNJJDCJ JBDHHGFOJCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x74358F0", Offset = "0x7433EF0", VA = "0x1874358F0")]
	private bool MFKJFACNJCK(BMDPNNJJDCJ GAGCPKGCEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7436450", Offset = "0x7434A50", VA = "0x187436450")]
	private static bool PBIMIHABGIB(BMDPNNJJDCJ GAGCPKGCEHA, LLIEBCFGNOO GMNMBMECJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7434200", Offset = "0x7432800", VA = "0x187434200")]
	private void DLHGEGKHFBK(Transform AAIOFDMKLDO, LLIEBCFGNOO IOIGMILKNFL, LLIEBCFGNOO[] KKHJLIOOCBE, BMDPNNJJDCJ PHIADFFDCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x74346D0", Offset = "0x7432CD0", VA = "0x1874346D0")]
	private GOFPOGHLFFG FIMPLMLMNCJ(Transform PIALODGLINC, GOFPOGHLFFG BFOFMIMHFBO)
	{
		return default(GOFPOGHLFFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7433470", Offset = "0x7431A70", VA = "0x187433470")]
	private static bool AKOFOJEHGEA(LLIEBCFGNOO GMNMBMECJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x74348B0", Offset = "0x7432EB0", VA = "0x1874348B0", Slot = "9")]
	public bool GKHPHBLNFJF(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x74337B0", Offset = "0x7431DB0", VA = "0x1874337B0")]
	private bool CGEFGLECCJC(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7433A00", Offset = "0x7432000", VA = "0x187433A00")]
	private static void CMNHFFINGMC(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA, LLIEBCFGNOO DCOHENGBAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x74331F0", Offset = "0x74317F0", VA = "0x1874331F0")]
	private void AIMANGHICGJ(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7434F20", Offset = "0x7433520", VA = "0x187434F20")]
	private void HPNBPCELNDF(LLIEBCFGNOO HPEELAFENFB, BMDPNNJJDCJ NDHOCLFLKAM, BMDPNNJJDCJ FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7434EB0", Offset = "0x74334B0", VA = "0x187434EB0")]
	private void HPNBPCELNDF(BMDPNNJJDCJ DGKBEFCBLCI, BMDPNNJJDCJ NDHOCLFLKAM, BMDPNNJJDCJ FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7433740", Offset = "0x7431D40", VA = "0x187433740")]
	private void CCPNKCPLPLI(BMDPNNJJDCJ DGKBEFCBLCI, BMDPNNJJDCJ NDHOCLFLKAM, BMDPNNJJDCJ FIHALPBMNML, bool HELGNHEAPFL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7433640", Offset = "0x7431C40", VA = "0x187433640")]
	private void CCPNKCPLPLI(LLIEBCFGNOO JGHOOBNHEJB, BMDPNNJJDCJ PHIADFFDCPL, BMDPNNJJDCJ CEBMPGCDNIA, bool HELGNHEAPFL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7434F90", Offset = "0x7433590", VA = "0x187434F90")]
	private void IDNFBJHKCDI(BMDPNNJJDCJ DJHFBAMKFNI, int ELJKAFNIPLE, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7433310", Offset = "0x7431910", VA = "0x187433310")]
	private void AKJIJGAEJLH(GAEKAMDMECB LDIAONMHHPK, GAEKAMDMECB GFCCEHHKEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x74350B0", Offset = "0x74336B0", VA = "0x1874350B0", Slot = "18")]
	public BMDPNNJJDCJ IPJDPKGIANF(BMDPNNJJDCJ DGKBEFCBLCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7434A50", Offset = "0x7433050", VA = "0x187434A50", Slot = "13")]
	public void HMPAJJANHCC(BMDPNNJJDCJ DGKBEFCBLCI, HashSet<BMDPNNJJDCJ> OAGFMCDBLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7436000", Offset = "0x7434600", VA = "0x187436000", Slot = "14")]
	public List<BMDPNNJJDCJ> MHPHOEIODLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7433B80", Offset = "0x7432180", VA = "0x187433B80")]
	protected GAEKAMDMECB CNCMNFAGHGD(GAEKAMDMECB HPEELAFENFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x74363B0", Offset = "0x74349B0", VA = "0x1874363B0")]
	protected LLIEBCFGNOO[] OBHBFOKBDNL(LLIEBCFGNOO GMNMBMECJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7435210", Offset = "0x7433810", VA = "0x187435210")]
	protected bool KELLMMEGJKC(BMDPNNJJDCJ DGKBEFCBLCI, [Out] LLIEBCFGNOO HPEELAFENFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7436240", Offset = "0x7434840", VA = "0x187436240", Slot = "15")]
	public bool MJGJFBLCNKN(BMDPNNJJDCJ DGKBEFCBLCI, [Out] GOFPOGHLFFG MHCBFDEDFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7436370", Offset = "0x7434970", VA = "0x187436370")]
	protected LLIEBCFGNOO NHAFAFEDIJE(GOFPOGHLFFG HIBIIBEDDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7434850", Offset = "0x7432E50", VA = "0x187434850", Slot = "10")]
	public bool GGNFNMNIOOM(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7433C50", Offset = "0x7432250", VA = "0x187433C50")]
	private bool DAHDMJKOFBF(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7434600", Offset = "0x7432C00", VA = "0x187434600")]
	private static bool EKNMDJBNCIE(LLIEBCFGNOO GCBFKIFBNFN, GOFPOGHLFFG EKKEGOEFOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x74341F0", Offset = "0x74327F0", VA = "0x1874341F0", Slot = "7")]
	private bool DAHIDNCFMFN([In] HAOAACJBKAA GIDGOODJFLJ, bool KGLEDONBJKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class KNECIKJHIBH : OHCENGCLELO, CBANIPAPHBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly GFKEMDIOCPC MGOKPJKELJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly NBKCKKJIDPP HHONMODOICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly IILJICLEBCF LOBHICGCLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly LNKGJAPBBAB OJJBPCKNKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly FAEBNAJOBDC CJLJJENJCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal JDDJAHDINGD MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal KGABAFFINOA MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal PHOKLPIAJNA NBAIOBMKBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool APOEHFIIACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool GPJLFDEHIKO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DNBMAFDNKMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93170", VA = "0x180A94B70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1087FB0", Offset = "0x10865B0", VA = "0x181087FB0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xF63360", Offset = "0xF61960", VA = "0x180F63360", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2322D40", Offset = "0x2321340", VA = "0x182322D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BKHOANOEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> CNCOJEHHKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7436EC0", Offset = "0x74354C0", VA = "0x187436EC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7436970", Offset = "0x7434F70", VA = "0x187436970", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> EEPGEGJEBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7438220", Offset = "0x7436820", VA = "0x187438220", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7436C30", Offset = "0x7435230", VA = "0x187436C30", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ, BMDPNNJJDCJ> LLGDDAPECOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7437AE0", Offset = "0x74360E0", VA = "0x187437AE0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7436C90", Offset = "0x7435290", VA = "0x187436C90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x74384A0", Offset = "0x7436AA0", VA = "0x1874384A0")]
	public KNECIKJHIBH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7437340", Offset = "0x7435940", VA = "0x187437340", Slot = "12")]
	public void HPHCPPKCEKM(GameObject HHDLNMHBJJD, HILBNBMHMGD CPGFCKFAAJC, OAEFICKFFBI PLMOGFFBIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7437170", Offset = "0x7435770", VA = "0x187437170", Slot = "26")]
	public void GFJNPMIAIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7438420", Offset = "0x7436A20", VA = "0x187438420", Slot = "13")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7438280", Offset = "0x7436880", VA = "0x187438280", Slot = "14")]
	public void OCICFIBHEPA(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7437950", Offset = "0x7435F50", VA = "0x187437950", Slot = "15")]
	public void IBEJEPFGGMM(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7436CF0", Offset = "0x74352F0", VA = "0x187436CF0", Slot = "22")]
	public bool ENABCDCINBE(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x74369D0", Offset = "0x7434FD0", VA = "0x1874369D0")]
	internal bool DAHDMJKOFBF([In] HAOAACJBKAA GIDGOODJFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7436AE0", Offset = "0x74350E0", VA = "0x187436AE0")]
	internal bool DKEHPKIMNDP([In] HAOAACJBKAA GIDGOODJFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7437D50", Offset = "0x7436350", VA = "0x187437D50")]
	internal void LPHJGDNAOON(BMDPNNJJDCJ DGKBEFCBLCI, int PNDNDJJIALM, bool KGLEDONBJKL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7437950", Offset = "0x7435F50", VA = "0x187437950")]
	internal bool OPHBEDDFLEH(BMDPNNJJDCJ EAGNCHAAGEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x74379B0", Offset = "0x7435FB0", VA = "0x1874379B0")]
	internal bool ICIFNCAOKCP(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7437240", Offset = "0x7435840", VA = "0x187437240", Slot = "16")]
	public void HMPAJJANHCC(BMDPNNJJDCJ DGKBEFCBLCI, HashSet<BMDPNNJJDCJ> FELJDIHAKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7437B40", Offset = "0x7436140", VA = "0x187437B40", Slot = "17")]
	public void LLMBDHEJHGE(BMDPNNJJDCJ KLBPPOINCGA, BMDPNNJJDCJ FMAJOMKBBMP, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7436D80", Offset = "0x7435380", VA = "0x187436D80", Slot = "18")]
	public void FDGMIEJFDNJ(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x74367A0", Offset = "0x7434DA0", VA = "0x1874367A0", Slot = "19")]
	public void AJGFFNFOFIC(BMDPNNJJDCJ KFJDBHMHCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7436F20", Offset = "0x7435520", VA = "0x187436F20")]
	public void GCJFCHFCBNH([Optional] NCINHCIEICL PPKDOHLPHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x74380E0", Offset = "0x74366E0", VA = "0x1874380E0", Slot = "23")]
	public void MFNFOOHBAHK(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x74382A0", Offset = "0x74368A0", VA = "0x1874382A0", Slot = "20")]
	public IHGCCLJDJEE PBPEPBPIFOJ(bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7437F30", Offset = "0x7436530", VA = "0x187437F30", Slot = "21")]
	public IHGCCLJDJEE MCCLCEJLBJB(HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7436D40", Offset = "0x7435340", VA = "0x187436D40", Slot = "25")]
	public void FABEOONEPGL(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7438170", Offset = "0x7436770", VA = "0x187438170", Slot = "24")]
	public void MJJFJPKBIEO(IHGCCLJDJEE CJLJJENJCHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class NBKCKKJIDPP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly FLEKKBCEDJE<BMDPNNJJDCJ, BMDPNNJJDCJ> CNCOJEHHKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly FLEKKBCEDJE<BMDPNNJJDCJ, BMDPNNJJDCJ> EEPGEGJEBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly BEABIOOFOBA<BMDPNNJJDCJ, BMDPNNJJDCJ, BMDPNNJJDCJ> LLGDDAPECOH;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x743C690", Offset = "0x743AC90", VA = "0x18743C690")]
	public NBKCKKJIDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	public void HPHCPPKCEKM(KNECIKJHIBH JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x743C5B0", Offset = "0x743ABB0", VA = "0x18743C5B0")]
	public void JLKLPNGFJEF(BMDPNNJJDCJ LDIAONMHHPK, BMDPNNJJDCJ DJHFBAMKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x743C550", Offset = "0x743AB50", VA = "0x18743C550")]
	public void EHMKHLJAKFB(BMDPNNJJDCJ LDIAONMHHPK, BMDPNNJJDCJ DJHFBAMKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x743C610", Offset = "0x743AC10", VA = "0x18743C610")]
	public void KCILAGHJKBE(BMDPNNJJDCJ OIKBDABGNHP, BMDPNNJJDCJ DFDGPBFKIGC, BMDPNNJJDCJ DJHFBAMKFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class IILJICLEBCF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private KNECIKJHIBH JEIEGFHFIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private KGABAFFINOA MGMCFGLJIGI;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public IILJICLEBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7431B50", Offset = "0x7430150", VA = "0x187431B50")]
	public void HPHCPPKCEKM(KNECIKJHIBH JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7431A30", Offset = "0x7430030", VA = "0x187431A30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7431E10", Offset = "0x7430410", VA = "0x187431E10")]
	private void OCPIAHCOEHP(NOONNECLOAO KHELFHBHLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7431DA0", Offset = "0x74303A0", VA = "0x187431DA0")]
	private void KPAOCMPFANM(NCINHCIEICL HNCEPNONCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7431C90", Offset = "0x7430290", VA = "0x187431C90")]
	public void KBPFLILAILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7431A40", Offset = "0x7430040", VA = "0x187431A40")]
	public void ECAFHDHKJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class BCOBFBAGKKL
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JENLDJKMNKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GFKEMDIOCPC container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JENLDJKMNKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7432270", Offset = "0x7430870", VA = "0x187432270")]
		internal KNECIKJHIBH FJDPDOMOIJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7428950", Offset = "0x7426F50", VA = "0x187428950")]
	public static void CJMJKGHCPGN(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7428B50", Offset = "0x7427150", VA = "0x187428B50")]
	public static void IBCFIICLCCD(GFKEMDIOCPC MGOKPJKELJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class JIBACOONKDP : IDisposable, PHOKLPIAJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, NGOMIHOGADO> LJNKGPJJONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly BGGDFHKINDH BDFEGCPAGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private ALOKGODEANA PBNKONBPKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private FAEBNAJOBDC CJLJJENJCHE;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker BDLEPPEOJLD;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7433110", Offset = "0x7431710", VA = "0x187433110")]
	public JIBACOONKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7432A30", Offset = "0x7431030", VA = "0x187432A30", Slot = "7")]
	public void HPHCPPKCEKM(FAEBNAJOBDC CJLJJENJCHE, ALOKGODEANA PBNKONBPKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x74325D0", Offset = "0x7430BD0", VA = "0x1874325D0", Slot = "5")]
	public void DAMGIEBFLDH(GAEKAMDMECB KEBENFLEMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7432F40", Offset = "0x7431540", VA = "0x187432F40", Slot = "9")]
	public void KJNAPOBBAJF(GAEKAMDMECB EADKNFPHMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7432870", Offset = "0x7430E70", VA = "0x187432870", Slot = "8")]
	public void GAIGEJODCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7432A70", Offset = "0x7431070", VA = "0x187432A70", Slot = "10")]
	public void IEEJNJENMJH(GAEKAMDMECB BLCLNFMNMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7432DC0", Offset = "0x74313C0", VA = "0x187432DC0", Slot = "11")]
	public void JDLPDPIBBBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7432420", Offset = "0x7430A20", VA = "0x187432420")]
	private bool BHEJJKOFFCC(GAEKAMDMECB EOJJAMCHAEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class LNKGJAPBBAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct NGNBPAHPBKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly LLIEBCFGNOO CCJEABFOBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> JHCPKFDAGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly ODFHIEJDKOP AILCALMDIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly ODFHIEJDKOP OBPCEMHKNLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool BIKMDKDNAOA;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool NBFLBFEOHHA
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x743C9D0", Offset = "0x743AFD0", VA = "0x18743C9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x743D080", Offset = "0x743B680", VA = "0x18743D080")]
		public NGNBPAHPBKL(LLIEBCFGNOO CCJEABFOBAG, HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA, [Optional] ODFHIEJDKOP AILCALMDIND, [Optional] ODFHIEJDKOP OBPCEMHKNLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x743CC60", Offset = "0x743B260", VA = "0x18743CC60")]
		public ODFHIEJDKOP IMJDHHAECMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x743CE00", Offset = "0x743B400", VA = "0x18743CE00")]
		private ODFHIEJDKOP JCJLFBJIINP([Out] ODFHIEJDKOP GHOCIMALEHP, [Out] ODFHIEJDKOP AECCIKOFCKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x743C7B0", Offset = "0x743ADB0", VA = "0x18743C7B0")]
		private ODFHIEJDKOP COKIBBKBBKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x743CAF0", Offset = "0x743B0F0", VA = "0x18743CAF0")]
		private void GFKGKGCJIAG(ODFHIEJDKOP OGBBOHKGIFL, ODFHIEJDKOP FJCOKOJCEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x743CEC0", Offset = "0x743B4C0", VA = "0x18743CEC0")]
		private void PECGKMDCDAP(ODFHIEJDKOP GHOCIMALEHP, ODFHIEJDKOP AECCIKOFCKH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private KNECIKJHIBH JEIEGFHFIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private FAEBNAJOBDC CJLJJENJCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private PHOKLPIAJNA NCNJMNAJMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private KGABAFFINOA MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool BPDCCHONIDC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool LAHDBDBPJFB
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x743AC80", Offset = "0x7439280", VA = "0x18743AC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool DNBMAFDNKMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x74393C0", Offset = "0x74379C0", VA = "0x1874393C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x743B620", Offset = "0x7439C20", VA = "0x18743B620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x743AC10", Offset = "0x7439210", VA = "0x18743AC10")]
	public void HPHCPPKCEKM(KNECIKJHIBH JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x743B6E0", Offset = "0x7439CE0", VA = "0x18743B6E0")]
	public IHGCCLJDJEE PBPEPBPIFOJ(bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x743B360", Offset = "0x7439960", VA = "0x18743B360")]
	public IHGCCLJDJEE MCCLCEJLBJB(HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x743B590", Offset = "0x7439B90", VA = "0x18743B590")]
	public void MFNFOOHBAHK(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x743B640", Offset = "0x7439C40", VA = "0x18743B640")]
	public void MJJFJPKBIEO(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x743A530", Offset = "0x7438B30", VA = "0x18743A530")]
	public void GEIDDHBAKAK(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x743A320", Offset = "0x7438920", VA = "0x18743A320")]
	private void FLNBADNPNPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x74397F0", Offset = "0x7437DF0", VA = "0x1874397F0")]
	private ODFHIEJDKOP EHPLCFIGNNI(LLIEBCFGNOO HPEELAFENFB, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x743B110", Offset = "0x7439710", VA = "0x18743B110")]
	private static void LPONPCAEGGK(LLIEBCFGNOO HPEELAFENFB, bool BIKMDKDNAOA, ODFHIEJDKOP NAKBEFGIDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x743B850", Offset = "0x7439E50", VA = "0x18743B850")]
	private void PMLEDJNLIGD(LLIEBCFGNOO HPEELAFENFB, bool BIKMDKDNAOA, ODFHIEJDKOP NAKBEFGIDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x743B500", Offset = "0x7439B00", VA = "0x18743B500")]
	private ODFHIEJDKOP MEADOCHCJPO(LLIEBCFGNOO CCJEABFOBAG, HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x74393E0", Offset = "0x74379E0", VA = "0x1874393E0")]
	private bool CEPIMNAELOI(IHGCCLJDJEE JMGPEDKGBMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7439CB0", Offset = "0x74382B0", VA = "0x187439CB0")]
	private bool EOMBLENGFCH(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x743A510", Offset = "0x7438B10", VA = "0x18743A510")]
	private bool FNOLELGPNDH(IHGCCLJDJEE CJLJJENJCHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x743ACD0", Offset = "0x74392D0", VA = "0x18743ACD0")]
	private static bool INDECDAHGGI(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7439A20", Offset = "0x7438020", VA = "0x187439A20")]
	public static bool ENABCDCINBE(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x743A560", Offset = "0x7438B60", VA = "0x18743A560")]
	private BMDPNNJJDCJ GJFAHCHJCBO(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7439670", Offset = "0x7437C70", VA = "0x187439670")]
	private BMDPNNJJDCJ CJMCDIJPDGH(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x743AF80", Offset = "0x7439580", VA = "0x18743AF80")]
	private BMDPNNJJDCJ KHCMPBGCPNF(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x742D070", Offset = "0x742B670", VA = "0x18742D070")]
	private static Guid PBJIOLICEMK(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x743AB20", Offset = "0x7439120", VA = "0x18743AB20")]
	private string HFNDCKKBJED(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x743ADF0", Offset = "0x74393F0", VA = "0x18743ADF0")]
	private bool JOLEOIHKOLE(LLIEBCFGNOO HPEELAFENFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x743A8C0", Offset = "0x7438EC0", VA = "0x18743A8C0")]
	private static void HBEDDDNAIEH(LLIEBCFGNOO CCJEABFOBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public LNKGJAPBBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct HAOAACJBKAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public BMDPNNJJDCJ DJHFBAMKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public BMDPNNJJDCJ LDIAONMHHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int ELJKAFNIPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int EFNKBBPCJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 FDCPPCKCABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion IEODDBPKAOA;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GOFPOGHLFFG IFBOHPODKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7431170", Offset = "0x742F770", VA = "0x187431170")]
		get
		{
			return default(GOFPOGHLFFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GOFPOGHLFFG DPJIHCLLBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7431210", Offset = "0x742F810", VA = "0x187431210")]
		get
		{
			return default(GOFPOGHLFFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7431240", Offset = "0x742F840", VA = "0x187431240")]
	public HAOAACJBKAA(BMDPNNJJDCJ DJHFBAMKFNI, BMDPNNJJDCJ LDIAONMHHPK, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface FAEBNAJOBDC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GAEKAMDMECB HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPHCPPKCEKM(OHCENGCLELO JEIEGFHFIPA);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JCOBJLBEPOK([In] HAOAACJBKAA GIDGOODJFLJ, bool KGLEDONBJKL = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BOIFBBLIOKE(BMDPNNJJDCJ JBDHHGFOJCF);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GKHPHBLNFJF(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GGNFNMNIOOM(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHKGPBPGAML();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HAINDHHJEHL(Func<BMDPNNJJDCJ, bool> PFLNFMCJAJN);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HMPAJJANHCC(BMDPNNJJDCJ DGKBEFCBLCI, HashSet<BMDPNNJJDCJ> OAGFMCDBLLC);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<BMDPNNJJDCJ> MHPHOEIODLK();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MJGJFBLCNKN(BMDPNNJJDCJ DGKBEFCBLCI, [Out] GOFPOGHLFFG MHCBFDEDFNP);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GFIPODBBGDC(BGGDFHKINDH IJCKFHFIADK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool BGGDFHKINDH(GAEKAMDMECB HPEELAFENFB);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface GAEKAMDMECB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BMDPNNJJDCJ DHAGKBFFCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	GAEKAMDMECB IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GOFPOGHLFFG BNAODCHOALO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EBFIHILEAOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NGOMIHOGADO
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIDIOEOELJF(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEENMAMPBJO(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFCAKINBCDB(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KPNDOPCBKGK(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NGOMIHOGADO Instantiate(Transform EJNLPEDOMDD);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHAKNCNBNPL();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface ALOKGODEANA
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPHCPPKCEKM(Transform EJNLPEDOMDD, NGOMIHOGADO KALEKMNLDMM);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGOMIHOGADO COJHCACLDLP();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CECIFJNFCFB(NGOMIHOGADO EMPNCNGFEKG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface JDDJAHDINGD : HHHJMGJEPOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEPEDKHAFLB();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ADAKCMNDDKJ(Guid IEJINLAAIEE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface PHOKLPIAJNA
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAMGIEBFLDH(GAEKAMDMECB KEBENFLEMLP);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPHCPPKCEKM(FAEBNAJOBDC CJLJJENJCHE, ALOKGODEANA JAEFBAMIADG);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GAIGEJODCGG();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJNAPOBBAJF(GAEKAMDMECB EADKNFPHMGJ);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEEJNJENMJH(GAEKAMDMECB BLCLNFMNMAK);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JDLPDPIBBBF();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class LLIEBCFGNOO : GAEKAMDMECB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JFHDEPHBIOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public GOFPOGHLFFG nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LLIEBCFGNOO foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JFHDEPHBIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x74322E0", Offset = "0x74308E0", VA = "0x1874322E0")]
		internal bool LJFKBBEFNPE(GAEKAMDMECB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private GOFPOGHLFFG MHCBFDEDFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<LLIEBCFGNOO> OAHIIDOOIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private LLIEBCFGNOO CHGECNLHCJK;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GOFPOGHLFFG BNAODCHOALO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1088140", Offset = "0x1086740", VA = "0x181088140", Slot = "6")]
		get
		{
			return default(GOFPOGHLFFG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x10879F0", Offset = "0x1085FF0", VA = "0x1810879F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private LLIEBCFGNOO LDIAONMHHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7438890", Offset = "0x7436E90", VA = "0x187438890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GAEKAMDMECB IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BMDPNNJJDCJ DHAGKBFFCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EBFIHILEAOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7438C30", Offset = "0x7437230", VA = "0x187438C30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OLPBAAADNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7438FE0", Offset = "0x74375E0", VA = "0x187438FE0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected LLIEBCFGNOO JGHOOBNHEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7438C40", Offset = "0x7437240", VA = "0x187438C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7439310", Offset = "0x7437910", VA = "0x187439310")]
	public LLIEBCFGNOO(GOFPOGHLFFG GHLHAGGBNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7438970", Offset = "0x7436F70", VA = "0x187438970")]
	public LLIEBCFGNOO FCMEIMELBLA(GOFPOGHLFFG EJBMEPGMCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7438E60", Offset = "0x7437460", VA = "0x187438E60")]
	public LLIEBCFGNOO LJACAJGLHLO(GOFPOGHLFFG MPKPJAENDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7439130", Offset = "0x7437730", VA = "0x187439130")]
	public LLIEBCFGNOO OCDDHDAHAOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7438C60", Offset = "0x7437260", VA = "0x187438C60")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7438DB0", Offset = "0x74373B0", VA = "0x187438DB0")]
	public LLIEBCFGNOO LFPNKOEPGMI(GOFPOGHLFFG DFDGPBFKIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7438AD0", Offset = "0x74370D0", VA = "0x187438AD0")]
	private static void GFIPODBBGDC(LLIEBCFGNOO IAMBHBMEKKO, BGGDFHKINDH FFEBDLHFDKK, bool EOJCGGEPPMA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7438AC0", Offset = "0x74370C0", VA = "0x187438AC0", Slot = "9")]
	public void GFIPODBBGDC(BGGDFHKINDH IJCKFHFIADK, bool HELGNHEAPFL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7439030", Offset = "0x7437630", VA = "0x187439030")]
	public static LLIEBCFGNOO NHAFAFEDIJE(LLIEBCFGNOO IAMBHBMEKKO, GOFPOGHLFFG DLEPFHGNPFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface KGABAFFINOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool LAHDBDBPJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DIHDOFMHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<NOONNECLOAO> OCPIAHCOEHP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<NCINHCIEICL> KPAOCMPFANM;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CIDIOEOELJF(KNECIKJHIBH JEIEGFHFIPA, OAEFICKFFBI BFJDNIICDEO);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LLMBDHEJHGE(BMDPNNJJDCJ KLBPPOINCGA, BMDPNNJJDCJ FMAJOMKBBMP, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FDGMIEJFDNJ(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MCJNDNPOAFJ(IHGCCLJDJEE DMILEGFNFHB, [Optional] NCINHCIEICL PPKDOHLPHLD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EKMPHKABHIN
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type LNMDBHDAJAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x742E9A0", Offset = "0x742CFA0", VA = "0x18742E9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x742EA00", Offset = "0x742D000", VA = "0x18742EA00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x742E940", Offset = "0x742CF40", VA = "0x18742E940")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class CGJCKFKODJN : KGABAFFINOA, IDisposable, MDLPCNOGCPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private KNECIKJHIBH JEIEGFHFIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private OAEFICKFFBI PLMOGFFBIKA;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool LAHDBDBPJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x742D940", Offset = "0x742BF40", VA = "0x18742D940", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool DIHDOFMHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x742DE90", Offset = "0x742C490", VA = "0x18742DE90", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView AFFLOGFACDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x742D9A0", Offset = "0x742BFA0", VA = "0x18742D9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NOONNECLOAO> OCPIAHCOEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x742DA40", Offset = "0x742C040", VA = "0x18742DA40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x742DDF0", Offset = "0x742C3F0", VA = "0x18742DDF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NCINHCIEICL> KPAOCMPFANM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x742D890", Offset = "0x742BE90", VA = "0x18742D890", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x742DAE0", Offset = "0x742C0E0", VA = "0x18742DAE0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x742D680", Offset = "0x742BC80", VA = "0x18742D680", Slot = "10")]
	public void CIDIOEOELJF(KNECIKJHIBH JEIEGFHFIPA, OAEFICKFFBI PLMOGFFBIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x742D710", Offset = "0x742BD10", VA = "0x18742D710", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x742DB90", Offset = "0x742C190", VA = "0x18742DB90", Slot = "11")]
	public void LLMBDHEJHGE(BMDPNNJJDCJ KLBPPOINCGA, BMDPNNJJDCJ FMAJOMKBBMP, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x742D760", Offset = "0x742BD60", VA = "0x18742D760", Slot = "12")]
	public void FDGMIEJFDNJ(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x742DCC0", Offset = "0x742C2C0", VA = "0x18742DCC0", Slot = "13")]
	public void MCJNDNPOAFJ(IHGCCLJDJEE DMILEGFNFHB, [Optional] NCINHCIEICL PPKDOHLPHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x742E110", Offset = "0x742C710", VA = "0x18742E110")]
	[NMPKCFGNPNG]
	private void RpcMasterReparentNodes(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x742DF10", Offset = "0x742C510", VA = "0x18742DF10")]
	[NMPKCFGNPNG]
	private void RpcMasterModifyNode(BMDPNNJJDCJ KLBPPOINCGA, BMDPNNJJDCJ FMAJOMKBBMP, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x742E4E0", Offset = "0x742CAE0", VA = "0x18742E4E0")]
	[NMPKCFGNPNG]
	private void RpcReparentNodes(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA, NNDJIBOLGAI OCBOKBINLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x742E420", Offset = "0x742CA20", VA = "0x18742E420")]
	[NMPKCFGNPNG]
	private void RpcModifyNode(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA, NNDJIBOLGAI OCBOKBINLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x742DED0", Offset = "0x742C4D0", VA = "0x18742DED0")]
	[NMPKCFGNPNG]
	private void RpcDeserializeConnectableGraph(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public CGJCKFKODJN()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, NGOMIHOGADO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x743BFC0", Offset = "0x743A5C0", VA = "0x18743BFC0", Slot = "4")]
		private void KNNJPDAOLDB(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x743BAE0", Offset = "0x743A0E0", VA = "0x18743BAE0", Slot = "5")]
		private void CNABIACDNPH(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x743C1A0", Offset = "0x743A7A0", VA = "0x18743C1A0", Slot = "6")]
		private void LMLCHPFKOCN(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x743BDD0", Offset = "0x743A3D0", VA = "0x18743BDD0", Slot = "7")]
		private void GEJFOFKKLNJ(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x743BD60", Offset = "0x743A360", VA = "0x18743BD60", Slot = "8")]
		private NGOMIHOGADO DLKLLHFBCAP(Transform EJNLPEDOMDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x743C140", Offset = "0x743A740", VA = "0x18743C140", Slot = "9")]
		private void KODOHMEPIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class BKPEAOMBAIE
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x319A3A0", Offset = "0x31989A0", VA = "0x18319A3A0")]
	public static JPNGJOHGMAE<T> OKGJLOONGMO<T>(this GFKEMDIOCPC MGOKPJKELJG)
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
