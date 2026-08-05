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
		[Cpp2IlInjected.Address(RVA = "0x739E260", Offset = "0x739D660", VA = "0x18739E260", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x739FAD0", Offset = "0x739EED0", VA = "0x18739FAD0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x739F630", Offset = "0x739EA30", VA = "0x18739F630")]
		private void ECIMOAOBJPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x739F4C0", Offset = "0x739E8C0", VA = "0x18739F4C0")]
		private void BGELMNPCJDF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x739F7A0", Offset = "0x739EBA0", VA = "0x18739F7A0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x739FB10", Offset = "0x739EF10", VA = "0x18739FB10")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public ICHLJJOHPOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x73936B0", Offset = "0x7392AB0", VA = "0x1873936B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7393250", Offset = "0x7392650", VA = "0x187393250", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7393210", Offset = "0x7392610", VA = "0x187393210")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7393230", Offset = "0x7392630", VA = "0x187393230")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7393660", Offset = "0x7392A60", VA = "0x187393660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73935B0", Offset = "0x73929B0", VA = "0x1873935B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BMDPNNJJDCJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x73935B0", Offset = "0x73929B0", VA = "0x1873935B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public POOOPLOCEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x739F220", Offset = "0x739E620", VA = "0x18739F220")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EECCPMKGDGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7390650", Offset = "0x738FA50", VA = "0x187390650")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8F3A0", Offset = "0xA8E7A0", VA = "0x180A8F3A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA8E8B0", Offset = "0xA8DCB0", VA = "0x180A8E8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BKHOANOEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> CNCOJEHHKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x738C970", Offset = "0x738BD70", VA = "0x18738C970", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x738AF20", Offset = "0x738A320", VA = "0x18738AF20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> EEPGEGJEBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x738EA70", Offset = "0x738DE70", VA = "0x18738EA70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x738B430", Offset = "0x738A830", VA = "0x18738B430", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ, BMDPNNJJDCJ> LLGDDAPECOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x738E640", Offset = "0x738DA40", VA = "0x18738E640", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x738BF80", Offset = "0x738B380", VA = "0x18738BF80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x738F570", Offset = "0x738E970", VA = "0x18738F570")]
	public CDFPMHBFAGL(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x738DEA0", Offset = "0x738D2A0", VA = "0x18738DEA0", Slot = "12")]
	public void HPHCPPKCEKM(GameObject HHDLNMHBJJD, HILBNBMHMGD CPGFCKFAAJC, OAEFICKFFBI FNPCBNFJCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x738CE40", Offset = "0x738C240", VA = "0x18738CE40", Slot = "26")]
	public void GFJNPMIAIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x738C030", Offset = "0x738B430", VA = "0x18738C030", Slot = "22")]
	public bool ENABCDCINBE(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x738E430", Offset = "0x738D830", VA = "0x18738E430")]
	private void KDFHOLKLEPK(FHNHGOPNICC ELIIKDDDLGB, FHNHGOPNICC PCKJFEDJEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x738D030", Offset = "0x738C430", VA = "0x18738D030")]
	private void GFNEBHBNAFG(FHNHGOPNICC ELIIKDDDLGB, FHNHGOPNICC BBKBAPMPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x738F010", Offset = "0x738E410", VA = "0x18738F010")]
	private void PDFBGANAGBC(FHNHGOPNICC ELIIKDDDLGB, FHNHGOPNICC BBKBAPMPONA, FHNHGOPNICC PCKJFEDJEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x738D720", Offset = "0x738CB20", VA = "0x18738D720")]
	private void HFIPPEOJBNK(FHNHGOPNICC ELIIKDDDLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "13")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x738EB20", Offset = "0x738DF20", VA = "0x18738EB20", Slot = "14")]
	public void OCICFIBHEPA(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "15")]
	public void IBEJEPFGGMM(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x738E6F0", Offset = "0x738DAF0", VA = "0x18738E6F0", Slot = "17")]
	public void LLMBDHEJHGE(BMDPNNJJDCJ DGKBEFCBLCI, BMDPNNJJDCJ FMAJOMKBBMP, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x738E850", Offset = "0x738DC50", VA = "0x18738E850")]
	public void LLMBDHEJHGE(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC FMAJOMKBBMP, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x738C8E0", Offset = "0x738BCE0", VA = "0x18738C8E0")]
	public void FFBIFGIFHAL(BMDPNNJJDCJ DGKBEFCBLCI, float OPPJBCDKOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x738C640", Offset = "0x738BA40", VA = "0x18738C640", Slot = "18")]
	public void FDGMIEJFDNJ(BMDPNNJJDCJ HMIAHNIHHOM, int ICHHEIADNOI, BMDPNNJJDCJ AHMIAIKKBKL, int PMNBMAJCEME, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x738CD90", Offset = "0x738C190", VA = "0x18738CD90")]
	private float FLNIOKLBFDE(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC LDIAONMHHPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x738C7A0", Offset = "0x738BBA0", VA = "0x18738C7A0")]
	public void FDGMIEJFDNJ(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC LDIAONMHHPK, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, bool PPMANIBBLFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x738ACC0", Offset = "0x738A0C0", VA = "0x18738ACC0", Slot = "19")]
	public void AJGFFNFOFIC(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x738DC90", Offset = "0x738D090", VA = "0x18738DC90", Slot = "16")]
	public void HMPAJJANHCC(BMDPNNJJDCJ DGKBEFCBLCI, HashSet<BMDPNNJJDCJ> FELJDIHAKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "20")]
	public IHGCCLJDJEE PBPEPBPIFOJ(bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "21")]
	public IHGCCLJDJEE MCCLCEJLBJB(HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x738E990", Offset = "0x738DD90", VA = "0x18738E990", Slot = "23")]
	public void MFNFOOHBAHK(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x738EA00", Offset = "0x738DE00", VA = "0x18738EA00", Slot = "24")]
	public void MJJFJPKBIEO(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x738C620", Offset = "0x738BA20", VA = "0x18738C620", Slot = "25")]
	public void FABEOONEPGL(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x738CA20", Offset = "0x738BE20", VA = "0x18738CA20")]
	private void FHIEGGHEFKM(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC LDIAONMHHPK, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, float OPPJBCDKOCC, bool PPMANIBBLFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x738B540", Offset = "0x738A940", VA = "0x18738B540")]
	private void EDCENNDMDCD(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC DFDGPBFKIGC, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x738DC20", Offset = "0x738D020", VA = "0x18738DC20")]
	private void HLMFIIOEDEF(FHNHGOPNICC DJHFBAMKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x738AE90", Offset = "0x738A290", VA = "0x18738AE90")]
	[IteratorStateMachine(typeof(ICHLJJOHPOA))]
	public IEnumerable<BMDPNNJJDCJ> ANLDBMMHINN(FHNHGOPNICC KPOCLGHHOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x738D250", Offset = "0x738C650", VA = "0x18738D250")]
	internal BMDPNNJJDCJ GJFAHCHJCBO(FHNHGOPNICC KPOCLGHHOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x738EE30", Offset = "0x738E230", VA = "0x18738EE30")]
	internal FHNHGOPNICC OGJAACJLCME(BMDPNNJJDCJ DGKBEFCBLCI)
	{
		return default(FHNHGOPNICC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x738C080", Offset = "0x738B480", VA = "0x18738C080")]
	private bool EOMBLENGFCH(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x738B4E0", Offset = "0x738A8E0", VA = "0x18738B4E0")]
	private bool DPOAOGPDENB(ODFHIEJDKOP NAKBEFGIDDJ, [Out] BMDPNNJJDCJ LDIAONMHHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x738D380", Offset = "0x738C780", VA = "0x18738D380")]
	private BMDPNNJJDCJ GJFAHCHJCBO(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x738F270", Offset = "0x738E670", VA = "0x18738F270")]
	private BMDPNNJJDCJ PGLOBOEKLDL(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x738B250", Offset = "0x738A650", VA = "0x18738B250")]
	private BMDPNNJJDCJ CJMCDIJPDGH(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x738EFD0", Offset = "0x738E3D0", VA = "0x18738EFD0")]
	private static Guid PBJIOLICEMK(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x738DB30", Offset = "0x738CF30", VA = "0x18738DB30")]
	private string HFNDCKKBJED(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x738AB30", Offset = "0x7389F30", VA = "0x18738AB30")]
	private void AIMANGHICGJ(BMDPNNJJDCJ DJHFBAMKFNI, BMDPNNJJDCJ DFDGPBFKIGC, RigidTransform EJDKLMAIDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x738E110", Offset = "0x738D510", VA = "0x18738E110")]
	private void IDNFBJHKCDI(BMDPNNJJDCJ DFDGPBFKIGC, BMDPNNJJDCJ DJHFBAMKFNI, RigidTransform EJDKLMAIDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x738AE30", Offset = "0x738A230", VA = "0x18738AE30")]
	private void AKJIJGAEJLH(BMDPNNJJDCJ OIKBDABGNHP, BMDPNNJJDCJ DJHFBAMKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x738E2A0", Offset = "0x738D6A0", VA = "0x18738E2A0")]
	private void IFOFLPLEBOD(BMDPNNJJDCJ DJHFBAMKFNI, BMDPNNJJDCJ LDIAONMHHPK, RigidTransform EJDKLMAIDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x738BE70", Offset = "0x738B270", VA = "0x18738BE70")]
	private void EGGJNKIJMCN(FHNHGOPNICC KPOCLGHHOEP, BMDPNNJJDCJ DGKBEFCBLCI, FHNHGOPNICC BBKBAPMPONA, FHNHGOPNICC PCKJFEDJEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x738AFD0", Offset = "0x738A3D0", VA = "0x18738AFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MELOKLADEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x739E400", Offset = "0x739D800", VA = "0x18739E400")]
		internal CDFPMHBFAGL FJDPDOMOIJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x739F050", Offset = "0x739E450", VA = "0x18739F050")]
	public static void CJMJKGHCPGN(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x739F1D0", Offset = "0x739E5D0", VA = "0x18739F1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0", Slot = "38")]
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
		[Cpp2IlInjected.Address(RVA = "0x7392740", Offset = "0x7391B40", VA = "0x187392740", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BMDPNNJJDCJ MEJALMHKJIG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7391A60", Offset = "0x7390E60", VA = "0x187391A60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 DJNMIGFFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7392290", Offset = "0x7391690", VA = "0x187392290", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion BKBAJDPGCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7390E40", Offset = "0x7390240", VA = "0x187390E40", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LOIHDHDIPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7391710", Offset = "0x7390B10", VA = "0x187391710", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<BMDPNNJJDCJ> CALKOPHCDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x73912D0", Offset = "0x73906D0", VA = "0x1873912D0", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA6A00", Offset = "0xAA5E00", VA = "0x180AA6A00", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xADC660", Offset = "0xADBA60", VA = "0x180ADC660", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7392950", Offset = "0x7391D50", VA = "0x187392950", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject PFCBGIFALLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B85300", Offset = "0x2B84700", VA = "0x182B85300", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7392670", Offset = "0x7391A70", VA = "0x187392670", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid PEABBCDCPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x73927A0", Offset = "0x7391BA0", VA = "0x1873927A0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int PONOHOGAKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7392880", Offset = "0x7391C80", VA = "0x187392880", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool CBPMGCPOPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JCNMFNFCCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7391560", Offset = "0x7390960", VA = "0x187391560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event FBJJJHMCECB CLJFNAILKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x73915B0", Offset = "0x73909B0", VA = "0x1873915B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7391010", Offset = "0x7390410", VA = "0x187391010", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FBJJJHMCECB FHHIAAKDMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7390BE0", Offset = "0x738FFE0", VA = "0x187390BE0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7392460", Offset = "0x7391860", VA = "0x187392460", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FBJJJHMCECB GKIDOELNNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x73916B0", Offset = "0x7390AB0", VA = "0x1873916B0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7391500", Offset = "0x7390900", VA = "0x187391500", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event KAEJELBOGIP EHCAKFJEKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7392370", Offset = "0x7391770", VA = "0x187392370", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7391610", Offset = "0x7390A10", VA = "0x187391610", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7392570", Offset = "0x7391970", VA = "0x187392570")]
	public GCJNFGEGBHG(FHNHGOPNICC NMFKPCDLLEP, RigidbodyEx AMDJMIBOJED, IBFCIOCDIDP IEMGOLPAHNK, ICJKHAFGCHI[] JMEACMPDFNH, FINKGIKFNPA MOKEOOADLAP, OHCENGCLELO BJOMCLEDIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7390B60", Offset = "0x738FF60", VA = "0x187390B60", Slot = "19")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "21")]
	public void DLGONACNNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x717DD80", Offset = "0x717D180", VA = "0x18717DD80", Slot = "22")]
	public void IJFBDABDJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7391070", Offset = "0x7390470", VA = "0x187391070", Slot = "20")]
	public void EKFPEOGCKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73910C0", Offset = "0x73904C0", VA = "0x1873910C0", Slot = "25")]
	public void FKFKOOMLMNF(int IGEFECFIJLF, BMDPNNJJDCJ AHMIAIKKBKL, int EFNKBBPCJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7390F40", Offset = "0x7390340", VA = "0x187390F40", Slot = "26")]
	public void DFKLEHLOEIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7391780", Offset = "0x7390B80", VA = "0x187391780", Slot = "27")]
	public void LEJEILDFOAN(int IGEFECFIJLF, BMDPNNJJDCJ HMIAHNIHHOM, int ELJKAFNIPLE, [Optional] Vector3? FDCPPCKCABA, [Optional] Quaternion? IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x73922F0", Offset = "0x73916F0", VA = "0x1873922F0", Slot = "28")]
	public void OJHJAAGEFEO(BMDPNNJJDCJ HMIAHNIHHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7391E30", Offset = "0x7391230", VA = "0x187391E30", Slot = "31")]
	public void MPFOPNOMMGN(Vector3 PHPEMJEBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7391B20", Offset = "0x7390F20", VA = "0x187391B20", Slot = "29")]
	public void MOKDHCBEDDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7390C40", Offset = "0x7390040", VA = "0x187390C40", Slot = "30")]
	public void CKCMHAEBGIF(int EAHKFAJBNDN, Vector3 MIGPGADKMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7391430", Offset = "0x7390830", VA = "0x187391430", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int IGEFECFIJLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7391300", Offset = "0x7390700", VA = "0x187391300", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int IGEFECFIJLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA836C0", Offset = "0xA82AC0", VA = "0x180A836C0", Slot = "42")]
	public Color GetConnectionSlotColor(int IGEFECFIJLF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7390EA0", Offset = "0x73902A0", VA = "0x187390EA0", Slot = "43")]
	public bool CanConnectTo(int IGEFECFIJLF, BMDPNNJJDCJ BIDIEDLBPGA, int FLGBKFLJHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "44")]
	public void ParentChanged(int IGEFECFIJLF, BMDPNNJJDCJ DPPMAPDPENM, int KHPPENBDGCK, Vector3 JKIPLEFGDOM, Quaternion FOLGOFGMMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "45")]
	public void ChildAdded(int IGEFECFIJLF, BMDPNNJJDCJ DAMJKCBOKML, int DMKDLFPBCPK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "46")]
	public void ChildRemoved(int IGEFECFIJLF, BMDPNNJJDCJ BJGKCKKBPII, int DBMJLCMCMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "47")]
	public void ConnectionModified(int IGEFECFIJLF, BMDPNNJJDCJ AHMIAIKKBKL, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x73924C0", Offset = "0x73918C0", VA = "0x1873924C0", Slot = "48")]
	public void RootChanged(BMDPNNJJDCJ EHHFKAPFPMI, BMDPNNJJDCJ CEBMPGCDNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7390B90", Offset = "0x738FF90", VA = "0x187390B90", Slot = "23")]
	public void AGPJHJCJPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7392410", Offset = "0x7391810", VA = "0x187392410", Slot = "24")]
	public void OPCNIMNAJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7392240", Offset = "0x7391640", VA = "0x187392240")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7392FD0", Offset = "0x73923D0", VA = "0x187392FD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7392F80", Offset = "0x7392380", VA = "0x187392F80", Slot = "5")]
	private void GIBJGOKIIIN(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xF5B430", Offset = "0xF5A830", VA = "0x180F5B430", Slot = "6")]
	private void LCJILCFFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BKHOANOEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> CNCOJEHHKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7393FC0", Offset = "0x73933C0", VA = "0x187393FC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7393DB0", Offset = "0x73931B0", VA = "0x187393DB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> EEPGEGJEBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7394120", Offset = "0x7393520", VA = "0x187394120", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7393E60", Offset = "0x7393260", VA = "0x187393E60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ, BMDPNNJJDCJ> LLGDDAPECOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7394070", Offset = "0x7393470", VA = "0x187394070", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7393F10", Offset = "0x7393310", VA = "0x187393F10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "26")]
	public void GFJNPMIAIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "12")]
	public void HPHCPPKCEKM(GameObject HHDLNMHBJJD, HILBNBMHMGD CPGFCKFAAJC, OAEFICKFFBI BFJDNIICDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "13")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "14")]
	public void OCICFIBHEPA(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "15")]
	public void IBEJEPFGGMM(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "16")]
	public void HMPAJJANHCC(BMDPNNJJDCJ DGKBEFCBLCI, HashSet<BMDPNNJJDCJ> FELJDIHAKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "17")]
	public void LLMBDHEJHGE(BMDPNNJJDCJ DGKBEFCBLCI, BMDPNNJJDCJ FMAJOMKBBMP, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "18")]
	public void FDGMIEJFDNJ(BMDPNNJJDCJ DGKBEFCBLCI, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "19")]
	public void AJGFFNFOFIC(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "20")]
	public IHGCCLJDJEE PBPEPBPIFOJ(bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "21")]
	public IHGCCLJDJEE MCCLCEJLBJB(HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "22")]
	public bool ENABCDCINBE(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "23")]
	public void MFNFOOHBAHK(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "24")]
	public void MJJFJPKBIEO(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "25")]
	public void FABEOONEPGL(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xBACAA0", Offset = "0xBABEA0", VA = "0x180BACAA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public NGOMIHOGADO LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7390540", Offset = "0x738F940", VA = "0x187390540")]
		public static ConnectableConfigData MEOPIEKILPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7390600", Offset = "0x738FA00", VA = "0x187390600")]
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
	[Cpp2IlInjected.Address(RVA = "0x7392F20", Offset = "0x7392320", VA = "0x187392F20")]
	public GOFPOGHLFFG(BMDPNNJJDCJ DGKBEFCBLCI, int CPNKOGECOFG, int JODIBACAJNE, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7392E80", Offset = "0x7392280", VA = "0x187392E80")]
	public GOFPOGHLFFG(BMDPNNJJDCJ DGKBEFCBLCI, int CPNKOGECOFG, int JODIBACAJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7392DF0", Offset = "0x73921F0", VA = "0x187392DF0")]
	public GOFPOGHLFFG(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7392970", Offset = "0x7391D70", VA = "0x187392970", Slot = "4")]
	public bool Equals(GOFPOGHLFFG OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7392A20", Offset = "0x7391E20", VA = "0x187392A20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E03D70", Offset = "0x6E03170", VA = "0x186E03D70", Slot = "4")]
	public void HPHCPPKCEKM(Transform EJNLPEDOMDD, NGOMIHOGADO KALEKMNLDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7393800", Offset = "0x7392C00", VA = "0x187393800", Slot = "5")]
	public NGOMIHOGADO COJHCACLDLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7393790", Offset = "0x7392B90", VA = "0x187393790", Slot = "6")]
	public void CECIFJNFCFB(NGOMIHOGADO EMPNCNGFEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IECDHKOKKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x73938D0", Offset = "0x7392CD0", VA = "0x1873938D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7396150", Offset = "0x7395550", VA = "0x187396150")]
	public bool JCOBJLBEPOK([In] HAOAACJBKAA GIDGOODJFLJ, bool KGLEDONBJKL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7397280", Offset = "0x7396680", VA = "0x187397280")]
	private bool KMHHJPBGDGH([In] HAOAACJBKAA GIDGOODJFLJ, bool KGLEDONBJKL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7398530", Offset = "0x7397930", VA = "0x187398530")]
	public KDFCGKMNDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7396D60", Offset = "0x7396160", VA = "0x187396D60", Slot = "5")]
	public void HPHCPPKCEKM(OHCENGCLELO JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7396780", Offset = "0x7395B80", VA = "0x187396780", Slot = "17")]
	public void GFIPODBBGDC(BGGDFHKINDH IJCKFHFIADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7396870", Offset = "0x7395C70", VA = "0x187396870", Slot = "12")]
	public void HAINDHHJEHL(Func<BMDPNNJJDCJ, bool> PFLNFMCJAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7396880", Offset = "0x7395C80", VA = "0x187396880")]
	private void HAINDHHJEHL(LLIEBCFGNOO HPEELAFENFB, Func<BMDPNNJJDCJ, bool> PFLNFMCJAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7396540", Offset = "0x7395940", VA = "0x187396540", Slot = "11")]
	public void EHKGPBPGAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7395590", Offset = "0x7394990", VA = "0x187395590", Slot = "8")]
	public bool BOIFBBLIOKE(BMDPNNJJDCJ JBDHHGFOJCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7397850", Offset = "0x7396C50", VA = "0x187397850")]
	private bool MFKJFACNJCK(BMDPNNJJDCJ GAGCPKGCEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x73983B0", Offset = "0x73977B0", VA = "0x1873983B0")]
	private static bool PBIMIHABGIB(BMDPNNJJDCJ GAGCPKGCEHA, LLIEBCFGNOO GMNMBMECJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7396160", Offset = "0x7395560", VA = "0x187396160")]
	private void DLHGEGKHFBK(Transform AAIOFDMKLDO, LLIEBCFGNOO IOIGMILKNFL, LLIEBCFGNOO[] KKHJLIOOCBE, BMDPNNJJDCJ PHIADFFDCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7396630", Offset = "0x7395A30", VA = "0x187396630")]
	private GOFPOGHLFFG FIMPLMLMNCJ(Transform PIALODGLINC, GOFPOGHLFFG BFOFMIMHFBO)
	{
		return default(GOFPOGHLFFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x73953D0", Offset = "0x73947D0", VA = "0x1873953D0")]
	private static bool AKOFOJEHGEA(LLIEBCFGNOO GMNMBMECJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7396810", Offset = "0x7395C10", VA = "0x187396810", Slot = "9")]
	public bool GKHPHBLNFJF(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7395710", Offset = "0x7394B10", VA = "0x187395710")]
	private bool CGEFGLECCJC(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7395960", Offset = "0x7394D60", VA = "0x187395960")]
	private static void CMNHFFINGMC(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA, LLIEBCFGNOO DCOHENGBAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7395150", Offset = "0x7394550", VA = "0x187395150")]
	private void AIMANGHICGJ(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7396E80", Offset = "0x7396280", VA = "0x187396E80")]
	private void HPNBPCELNDF(LLIEBCFGNOO HPEELAFENFB, BMDPNNJJDCJ NDHOCLFLKAM, BMDPNNJJDCJ FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7396E10", Offset = "0x7396210", VA = "0x187396E10")]
	private void HPNBPCELNDF(BMDPNNJJDCJ DGKBEFCBLCI, BMDPNNJJDCJ NDHOCLFLKAM, BMDPNNJJDCJ FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x73956A0", Offset = "0x7394AA0", VA = "0x1873956A0")]
	private void CCPNKCPLPLI(BMDPNNJJDCJ DGKBEFCBLCI, BMDPNNJJDCJ NDHOCLFLKAM, BMDPNNJJDCJ FIHALPBMNML, bool HELGNHEAPFL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x73955A0", Offset = "0x73949A0", VA = "0x1873955A0")]
	private void CCPNKCPLPLI(LLIEBCFGNOO JGHOOBNHEJB, BMDPNNJJDCJ PHIADFFDCPL, BMDPNNJJDCJ CEBMPGCDNIA, bool HELGNHEAPFL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7396EF0", Offset = "0x73962F0", VA = "0x187396EF0")]
	private void IDNFBJHKCDI(BMDPNNJJDCJ DJHFBAMKFNI, int ELJKAFNIPLE, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7395270", Offset = "0x7394670", VA = "0x187395270")]
	private void AKJIJGAEJLH(GAEKAMDMECB LDIAONMHHPK, GAEKAMDMECB GFCCEHHKEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7397010", Offset = "0x7396410", VA = "0x187397010", Slot = "18")]
	public BMDPNNJJDCJ IPJDPKGIANF(BMDPNNJJDCJ DGKBEFCBLCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x73969B0", Offset = "0x7395DB0", VA = "0x1873969B0", Slot = "13")]
	public void HMPAJJANHCC(BMDPNNJJDCJ DGKBEFCBLCI, HashSet<BMDPNNJJDCJ> OAGFMCDBLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7397F60", Offset = "0x7397360", VA = "0x187397F60", Slot = "14")]
	public List<BMDPNNJJDCJ> MHPHOEIODLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7395AE0", Offset = "0x7394EE0", VA = "0x187395AE0")]
	protected GAEKAMDMECB CNCMNFAGHGD(GAEKAMDMECB HPEELAFENFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7398310", Offset = "0x7397710", VA = "0x187398310")]
	protected LLIEBCFGNOO[] OBHBFOKBDNL(LLIEBCFGNOO GMNMBMECJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7397170", Offset = "0x7396570", VA = "0x187397170")]
	protected bool KELLMMEGJKC(BMDPNNJJDCJ DGKBEFCBLCI, [Out] LLIEBCFGNOO HPEELAFENFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x73981A0", Offset = "0x73975A0", VA = "0x1873981A0", Slot = "15")]
	public bool MJGJFBLCNKN(BMDPNNJJDCJ DGKBEFCBLCI, [Out] GOFPOGHLFFG MHCBFDEDFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x73982D0", Offset = "0x73976D0", VA = "0x1873982D0")]
	protected LLIEBCFGNOO NHAFAFEDIJE(GOFPOGHLFFG HIBIIBEDDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x73967B0", Offset = "0x7395BB0", VA = "0x1873967B0", Slot = "10")]
	public bool GGNFNMNIOOM(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7395BB0", Offset = "0x7394FB0", VA = "0x187395BB0")]
	private bool DAHDMJKOFBF(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7396560", Offset = "0x7395960", VA = "0x187396560")]
	private static bool EKNMDJBNCIE(LLIEBCFGNOO GCBFKIFBNFN, GOFPOGHLFFG EKKEGOEFOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7396150", Offset = "0x7395550", VA = "0x187396150", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8CCC0", Offset = "0xA8C0C0", VA = "0x180A8CCC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x10733E0", Offset = "0x10727E0", VA = "0x1810733E0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xF50CC0", Offset = "0xF500C0", VA = "0x180F50CC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x22F0C00", Offset = "0x22F0000", VA = "0x1822F0C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BKHOANOEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> CNCOJEHHKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7398E20", Offset = "0x7398220", VA = "0x187398E20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x73988D0", Offset = "0x7397CD0", VA = "0x1873988D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ> EEPGEGJEBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x739A180", Offset = "0x7399580", VA = "0x18739A180", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7398B90", Offset = "0x7397F90", VA = "0x187398B90", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<BMDPNNJJDCJ, BMDPNNJJDCJ, BMDPNNJJDCJ> LLGDDAPECOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7399A40", Offset = "0x7398E40", VA = "0x187399A40", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7398BF0", Offset = "0x7397FF0", VA = "0x187398BF0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x739A400", Offset = "0x7399800", VA = "0x18739A400")]
	public KNECIKJHIBH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x73992A0", Offset = "0x73986A0", VA = "0x1873992A0", Slot = "12")]
	public void HPHCPPKCEKM(GameObject HHDLNMHBJJD, HILBNBMHMGD CPGFCKFAAJC, OAEFICKFFBI PLMOGFFBIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x73990D0", Offset = "0x73984D0", VA = "0x1873990D0", Slot = "26")]
	public void GFJNPMIAIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x739A380", Offset = "0x7399780", VA = "0x18739A380", Slot = "13")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x739A1E0", Offset = "0x73995E0", VA = "0x18739A1E0", Slot = "14")]
	public void OCICFIBHEPA(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x73998B0", Offset = "0x7398CB0", VA = "0x1873998B0", Slot = "15")]
	public void IBEJEPFGGMM(BMDPNNJJDCJ DGKBEFCBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7398C50", Offset = "0x7398050", VA = "0x187398C50", Slot = "22")]
	public bool ENABCDCINBE(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7398930", Offset = "0x7397D30", VA = "0x187398930")]
	internal bool DAHDMJKOFBF([In] HAOAACJBKAA GIDGOODJFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7398A40", Offset = "0x7397E40", VA = "0x187398A40")]
	internal bool DKEHPKIMNDP([In] HAOAACJBKAA GIDGOODJFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7399CB0", Offset = "0x73990B0", VA = "0x187399CB0")]
	internal void LPHJGDNAOON(BMDPNNJJDCJ DGKBEFCBLCI, int PNDNDJJIALM, bool KGLEDONBJKL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x73998B0", Offset = "0x7398CB0", VA = "0x1873998B0")]
	internal bool OPHBEDDFLEH(BMDPNNJJDCJ EAGNCHAAGEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7399910", Offset = "0x7398D10", VA = "0x187399910")]
	internal bool ICIFNCAOKCP(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x73991A0", Offset = "0x73985A0", VA = "0x1873991A0", Slot = "16")]
	public void HMPAJJANHCC(BMDPNNJJDCJ DGKBEFCBLCI, HashSet<BMDPNNJJDCJ> FELJDIHAKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7399AA0", Offset = "0x7398EA0", VA = "0x187399AA0", Slot = "17")]
	public void LLMBDHEJHGE(BMDPNNJJDCJ KLBPPOINCGA, BMDPNNJJDCJ FMAJOMKBBMP, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7398CE0", Offset = "0x73980E0", VA = "0x187398CE0", Slot = "18")]
	public void FDGMIEJFDNJ(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7398700", Offset = "0x7397B00", VA = "0x187398700", Slot = "19")]
	public void AJGFFNFOFIC(BMDPNNJJDCJ KFJDBHMHCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7398E80", Offset = "0x7398280", VA = "0x187398E80")]
	public void GCJFCHFCBNH([Optional] NCINHCIEICL PPKDOHLPHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x739A040", Offset = "0x7399440", VA = "0x18739A040", Slot = "23")]
	public void MFNFOOHBAHK(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x739A200", Offset = "0x7399600", VA = "0x18739A200", Slot = "20")]
	public IHGCCLJDJEE PBPEPBPIFOJ(bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7399E90", Offset = "0x7399290", VA = "0x187399E90", Slot = "21")]
	public IHGCCLJDJEE MCCLCEJLBJB(HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7398CA0", Offset = "0x73980A0", VA = "0x187398CA0", Slot = "25")]
	public void FABEOONEPGL(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x739A0D0", Offset = "0x73994D0", VA = "0x18739A0D0", Slot = "24")]
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
	[Cpp2IlInjected.Address(RVA = "0x739E5F0", Offset = "0x739D9F0", VA = "0x18739E5F0")]
	public NBKCKKJIDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	public void HPHCPPKCEKM(KNECIKJHIBH JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x739E510", Offset = "0x739D910", VA = "0x18739E510")]
	public void JLKLPNGFJEF(BMDPNNJJDCJ LDIAONMHHPK, BMDPNNJJDCJ DJHFBAMKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x739E4B0", Offset = "0x739D8B0", VA = "0x18739E4B0")]
	public void EHMKHLJAKFB(BMDPNNJJDCJ LDIAONMHHPK, BMDPNNJJDCJ DJHFBAMKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x739E570", Offset = "0x739D970", VA = "0x18739E570")]
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
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public IILJICLEBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7393AB0", Offset = "0x7392EB0", VA = "0x187393AB0")]
	public void HPHCPPKCEKM(KNECIKJHIBH JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7393990", Offset = "0x7392D90", VA = "0x187393990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7393D70", Offset = "0x7393170", VA = "0x187393D70")]
	private void OCPIAHCOEHP(NOONNECLOAO KHELFHBHLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7393D00", Offset = "0x7393100", VA = "0x187393D00")]
	private void KPAOCMPFANM(NCINHCIEICL HNCEPNONCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7393BF0", Offset = "0x7392FF0", VA = "0x187393BF0")]
	public void KBPFLILAILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x73939A0", Offset = "0x7392DA0", VA = "0x1873939A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JENLDJKMNKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x73941D0", Offset = "0x73935D0", VA = "0x1873941D0")]
		internal KNECIKJHIBH FJDPDOMOIJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x738A8B0", Offset = "0x7389CB0", VA = "0x18738A8B0")]
	public static void CJMJKGHCPGN(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x738AAB0", Offset = "0x7389EB0", VA = "0x18738AAB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7395070", Offset = "0x7394470", VA = "0x187395070")]
	public JIBACOONKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7394990", Offset = "0x7393D90", VA = "0x187394990", Slot = "7")]
	public void HPHCPPKCEKM(FAEBNAJOBDC CJLJJENJCHE, ALOKGODEANA PBNKONBPKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7394530", Offset = "0x7393930", VA = "0x187394530", Slot = "5")]
	public void DAMGIEBFLDH(GAEKAMDMECB KEBENFLEMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7394EA0", Offset = "0x73942A0", VA = "0x187394EA0", Slot = "9")]
	public void KJNAPOBBAJF(GAEKAMDMECB EADKNFPHMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x73947D0", Offset = "0x7393BD0", VA = "0x1873947D0", Slot = "8")]
	public void GAIGEJODCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x73949D0", Offset = "0x7393DD0", VA = "0x1873949D0", Slot = "10")]
	public void IEEJNJENMJH(GAEKAMDMECB BLCLNFMNMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7394D20", Offset = "0x7394120", VA = "0x187394D20", Slot = "11")]
	public void JDLPDPIBBBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7394380", Offset = "0x7393780", VA = "0x187394380")]
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
			[Cpp2IlInjected.Address(RVA = "0x739E930", Offset = "0x739DD30", VA = "0x18739E930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x739EFE0", Offset = "0x739E3E0", VA = "0x18739EFE0")]
		public NGNBPAHPBKL(LLIEBCFGNOO CCJEABFOBAG, HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA, [Optional] ODFHIEJDKOP AILCALMDIND, [Optional] ODFHIEJDKOP OBPCEMHKNLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x739EBC0", Offset = "0x739DFC0", VA = "0x18739EBC0")]
		public ODFHIEJDKOP IMJDHHAECMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x739ED60", Offset = "0x739E160", VA = "0x18739ED60")]
		private ODFHIEJDKOP JCJLFBJIINP([Out] ODFHIEJDKOP GHOCIMALEHP, [Out] ODFHIEJDKOP AECCIKOFCKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x739E710", Offset = "0x739DB10", VA = "0x18739E710")]
		private ODFHIEJDKOP COKIBBKBBKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x739EA50", Offset = "0x739DE50", VA = "0x18739EA50")]
		private void GFKGKGCJIAG(ODFHIEJDKOP OGBBOHKGIFL, ODFHIEJDKOP FJCOKOJCEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x739EE20", Offset = "0x739E220", VA = "0x18739EE20")]
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
		[Cpp2IlInjected.Address(RVA = "0x739CBE0", Offset = "0x739BFE0", VA = "0x18739CBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool DNBMAFDNKMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x739B320", Offset = "0x739A720", VA = "0x18739B320")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x739D580", Offset = "0x739C980", VA = "0x18739D580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x739CB70", Offset = "0x739BF70", VA = "0x18739CB70")]
	public void HPHCPPKCEKM(KNECIKJHIBH JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x739D640", Offset = "0x739CA40", VA = "0x18739D640")]
	public IHGCCLJDJEE PBPEPBPIFOJ(bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x739D2C0", Offset = "0x739C6C0", VA = "0x18739D2C0")]
	public IHGCCLJDJEE MCCLCEJLBJB(HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x739D4F0", Offset = "0x739C8F0", VA = "0x18739D4F0")]
	public void MFNFOOHBAHK(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x739D5A0", Offset = "0x739C9A0", VA = "0x18739D5A0")]
	public void MJJFJPKBIEO(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x739C490", Offset = "0x739B890", VA = "0x18739C490")]
	public void GEIDDHBAKAK(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x739C280", Offset = "0x739B680", VA = "0x18739C280")]
	private void FLNBADNPNPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x739B750", Offset = "0x739AB50", VA = "0x18739B750")]
	private ODFHIEJDKOP EHPLCFIGNNI(LLIEBCFGNOO HPEELAFENFB, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x739D070", Offset = "0x739C470", VA = "0x18739D070")]
	private static void LPONPCAEGGK(LLIEBCFGNOO HPEELAFENFB, bool BIKMDKDNAOA, ODFHIEJDKOP NAKBEFGIDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x739D7B0", Offset = "0x739CBB0", VA = "0x18739D7B0")]
	private void PMLEDJNLIGD(LLIEBCFGNOO HPEELAFENFB, bool BIKMDKDNAOA, ODFHIEJDKOP NAKBEFGIDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x739D460", Offset = "0x739C860", VA = "0x18739D460")]
	private ODFHIEJDKOP MEADOCHCJPO(LLIEBCFGNOO CCJEABFOBAG, HashSet<Guid> JHCPKFDAGCF, bool BIKMDKDNAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x739B340", Offset = "0x739A740", VA = "0x18739B340")]
	private bool CEPIMNAELOI(IHGCCLJDJEE JMGPEDKGBMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x739BC10", Offset = "0x739B010", VA = "0x18739BC10")]
	private bool EOMBLENGFCH(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x739C470", Offset = "0x739B870", VA = "0x18739C470")]
	private bool FNOLELGPNDH(IHGCCLJDJEE CJLJJENJCHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x739CC30", Offset = "0x739C030", VA = "0x18739CC30")]
	private static bool INDECDAHGGI(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x739B980", Offset = "0x739AD80", VA = "0x18739B980")]
	public static bool ENABCDCINBE(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x739C4C0", Offset = "0x739B8C0", VA = "0x18739C4C0")]
	private BMDPNNJJDCJ GJFAHCHJCBO(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x739B5D0", Offset = "0x739A9D0", VA = "0x18739B5D0")]
	private BMDPNNJJDCJ CJMCDIJPDGH(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x739CEE0", Offset = "0x739C2E0", VA = "0x18739CEE0")]
	private BMDPNNJJDCJ KHCMPBGCPNF(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x738EFD0", Offset = "0x738E3D0", VA = "0x18738EFD0")]
	private static Guid PBJIOLICEMK(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x739CA80", Offset = "0x739BE80", VA = "0x18739CA80")]
	private string HFNDCKKBJED(ODFHIEJDKOP NAKBEFGIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x739CD50", Offset = "0x739C150", VA = "0x18739CD50")]
	private bool JOLEOIHKOLE(LLIEBCFGNOO HPEELAFENFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x739C820", Offset = "0x739BC20", VA = "0x18739C820")]
	private static void HBEDDDNAIEH(LLIEBCFGNOO CCJEABFOBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x73930D0", Offset = "0x73924D0", VA = "0x1873930D0")]
		get
		{
			return default(GOFPOGHLFFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GOFPOGHLFFG DPJIHCLLBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7393170", Offset = "0x7392570", VA = "0x187393170")]
		get
		{
			return default(GOFPOGHLFFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x73931A0", Offset = "0x73925A0", VA = "0x1873931A0")]
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
public interface NGOMIHOGADO : JOFABJOMOHJ.NLOJJCOOMEC
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JFHDEPHBIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7394240", Offset = "0x7393640", VA = "0x187394240")]
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
		[Cpp2IlInjected.Address(RVA = "0x1073570", Offset = "0x1072970", VA = "0x181073570", Slot = "6")]
		get
		{
			return default(GOFPOGHLFFG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1072E20", Offset = "0x1072220", VA = "0x181072E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private LLIEBCFGNOO LDIAONMHHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x739A7F0", Offset = "0x7399BF0", VA = "0x18739A7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GAEKAMDMECB IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BMDPNNJJDCJ DHAGKBFFCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EBFIHILEAOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x739AB90", Offset = "0x7399F90", VA = "0x18739AB90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OLPBAAADNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x739AF40", Offset = "0x739A340", VA = "0x18739AF40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected LLIEBCFGNOO JGHOOBNHEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x739ABA0", Offset = "0x7399FA0", VA = "0x18739ABA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x739B270", Offset = "0x739A670", VA = "0x18739B270")]
	public LLIEBCFGNOO(GOFPOGHLFFG GHLHAGGBNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x739A8D0", Offset = "0x7399CD0", VA = "0x18739A8D0")]
	public LLIEBCFGNOO FCMEIMELBLA(GOFPOGHLFFG EJBMEPGMCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x739ADC0", Offset = "0x739A1C0", VA = "0x18739ADC0")]
	public LLIEBCFGNOO LJACAJGLHLO(GOFPOGHLFFG MPKPJAENDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x739B090", Offset = "0x739A490", VA = "0x18739B090")]
	public LLIEBCFGNOO OCDDHDAHAOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x739ABC0", Offset = "0x7399FC0", VA = "0x18739ABC0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x739AD10", Offset = "0x739A110", VA = "0x18739AD10")]
	public LLIEBCFGNOO LFPNKOEPGMI(GOFPOGHLFFG DFDGPBFKIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x739AA30", Offset = "0x7399E30", VA = "0x18739AA30")]
	private static void GFIPODBBGDC(LLIEBCFGNOO IAMBHBMEKKO, BGGDFHKINDH FFEBDLHFDKK, bool EOJCGGEPPMA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x739AA20", Offset = "0x7399E20", VA = "0x18739AA20", Slot = "9")]
	public void GFIPODBBGDC(BGGDFHKINDH IJCKFHFIADK, bool HELGNHEAPFL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x739AF90", Offset = "0x739A390", VA = "0x18739AF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7390900", Offset = "0x738FD00", VA = "0x187390900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7390960", Offset = "0x738FD60", VA = "0x187390960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x73908A0", Offset = "0x738FCA0", VA = "0x1873908A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x738F8A0", Offset = "0x738ECA0", VA = "0x18738F8A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool DIHDOFMHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x738FDF0", Offset = "0x738F1F0", VA = "0x18738FDF0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView AFFLOGFACDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x738F900", Offset = "0x738ED00", VA = "0x18738F900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NOONNECLOAO> OCPIAHCOEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x738F9A0", Offset = "0x738EDA0", VA = "0x18738F9A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x738FD50", Offset = "0x738F150", VA = "0x18738FD50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NCINHCIEICL> KPAOCMPFANM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x738F7F0", Offset = "0x738EBF0", VA = "0x18738F7F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x738FA40", Offset = "0x738EE40", VA = "0x18738FA40", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x738F5E0", Offset = "0x738E9E0", VA = "0x18738F5E0", Slot = "10")]
	public void CIDIOEOELJF(KNECIKJHIBH JEIEGFHFIPA, OAEFICKFFBI PLMOGFFBIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x738F670", Offset = "0x738EA70", VA = "0x18738F670", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x738FAF0", Offset = "0x738EEF0", VA = "0x18738FAF0", Slot = "11")]
	public void LLMBDHEJHGE(BMDPNNJJDCJ KLBPPOINCGA, BMDPNNJJDCJ FMAJOMKBBMP, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x738F6C0", Offset = "0x738EAC0", VA = "0x18738F6C0", Slot = "12")]
	public void FDGMIEJFDNJ(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x738FC20", Offset = "0x738F020", VA = "0x18738FC20", Slot = "13")]
	public void MCJNDNPOAFJ(IHGCCLJDJEE DMILEGFNFHB, [Optional] NCINHCIEICL PPKDOHLPHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7390070", Offset = "0x738F470", VA = "0x187390070")]
	[NMPKCFGNPNG]
	private void RpcMasterReparentNodes(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x738FE70", Offset = "0x738F270", VA = "0x18738FE70")]
	[NMPKCFGNPNG]
	private void RpcMasterModifyNode(BMDPNNJJDCJ KLBPPOINCGA, BMDPNNJJDCJ FMAJOMKBBMP, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7390440", Offset = "0x738F840", VA = "0x187390440")]
	[NMPKCFGNPNG]
	private void RpcReparentNodes(BMDPNNJJDCJ KFJDBHMHCDD, int AAMENBOCCMH, BMDPNNJJDCJ DFDGPBFKIGC, int KHPPENBDGCK, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA, NNDJIBOLGAI OCBOKBINLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7390380", Offset = "0x738F780", VA = "0x187390380")]
	[NMPKCFGNPNG]
	private void RpcModifyNode(BMDPNNJJDCJ KLBPPOINCGA, int ELJKAFNIPLE, int EFNKBBPCJHM, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA, NNDJIBOLGAI OCBOKBINLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x738FE30", Offset = "0x738F230", VA = "0x18738FE30")]
	[NMPKCFGNPNG]
	private void RpcDeserializeConnectableGraph(IHGCCLJDJEE CJLJJENJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public CGJCKFKODJN()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, NGOMIHOGADO, JOFABJOMOHJ.NLOJJCOOMEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x739DF20", Offset = "0x739D320", VA = "0x18739DF20", Slot = "4")]
		private void KNNJPDAOLDB(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x739DA40", Offset = "0x739CE40", VA = "0x18739DA40", Slot = "5")]
		private void CNABIACDNPH(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x739E100", Offset = "0x739D500", VA = "0x18739E100", Slot = "6")]
		private void LMLCHPFKOCN(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x739DD30", Offset = "0x739D130", VA = "0x18739DD30", Slot = "7")]
		private void GEJFOFKKLNJ(BMDPNNJJDCJ AHMIAIKKBKL, GOFPOGHLFFG DJHFBAMKFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x739DCC0", Offset = "0x739D0C0", VA = "0x18739DCC0", Slot = "8")]
		private NGOMIHOGADO DLKLLHFBCAP(Transform EJNLPEDOMDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x739E0A0", Offset = "0x739D4A0", VA = "0x18739E0A0", Slot = "9")]
		private void KODOHMEPIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class BKPEAOMBAIE
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3153A40", Offset = "0x3152E40", VA = "0x183153A40")]
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
