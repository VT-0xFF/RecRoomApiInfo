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
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B85A90", Offset = "0x6B84690", VA = "0x186B85A90", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
			[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B89B60", Offset = "0x6B88760", VA = "0x186B89B60", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B896B0", Offset = "0x6B882B0", VA = "0x186B896B0")]
		private void MNIOJKDAHNG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B89540", Offset = "0x6B88140", VA = "0x186B89540")]
		private void FOMIKMKGDKF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B89820", Offset = "0x6B88420", VA = "0x186B89820", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B89BA0", Offset = "0x6B887A0", VA = "0x186B89BA0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class GBCKHNLKBGP : LOFCGFLCLPH, POGLPIENEJD
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class DPKGJDMJFIF : IEnumerable<MCGCBPGIFFK>, IEnumerable, IEnumerator<MCGCBPGIFFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private MCGCBPGIFFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private JBKDGFJKCIL localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JBKDGFJKCIL <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GBCKHNLKBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private OIMOBMEJAIF <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DBLPDLFFIKD.FNBPAMMBELK <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private MCGCBPGIFFK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8E1390", Offset = "0x8DFF90", VA = "0x1808E1390")]
		[DebuggerHidden]
		public DPKGJDMJFIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6B799D0", Offset = "0x6B785D0", VA = "0x186B799D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6B79510", Offset = "0x6B78110", VA = "0x186B79510", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B794F0", Offset = "0x6B780F0", VA = "0x186B794F0")]
		private void GOOHPDHLOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6B79980", Offset = "0x6B78580", VA = "0x186B79980", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6B798D0", Offset = "0x6B784D0", VA = "0x186B798D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MCGCBPGIFFK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B798D0", Offset = "0x6B784D0", VA = "0x186B798D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ONALFEDEIMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GBCKHNLKBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public IAFKMCJGOCF nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ONALFEDEIMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B885D0", Offset = "0x6B871D0", VA = "0x186B885D0")]
		internal object GKCFIACPDFC(IAFKMCJGOCF x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JHFMJMLNBKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IAFKMCJGOCF child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public ONALFEDEIMF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public JHFMJMLNBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B832E0", Offset = "0x6B81EE0", VA = "0x186B832E0")]
		internal object PDLLEHDJMJD((IAFKMCJGOCF child, IAFKMCJGOCF nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly BNHLDIHMNLF HJLFNMGPPPO;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly BNHLDIHMNLF PBHNPHPBBHO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly BNHLDIHMNLF EHDKFNDHCCD;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly BNHLDIHMNLF AFGJHAPLMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private IIONMFDLBIG ODODKCDIGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private PGJHHNGEJGI OAPHHHCNFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private DNJBJGGECOC MBHBKNMDPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PPEAMPJMKFM CPKOIOKIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private BFNGOOHGMMN JPJOIBILBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KEDKLEKLGOF AOJEPPFAEBK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KIIJDPHLFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xADFBB0", Offset = "0xADE7B0", VA = "0x180ADFBB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xBFBE60", Offset = "0xBFAA60", VA = "0x180BFBE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ONPKAAENNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<MCGCBPGIFFK, MCGCBPGIFFK> INPFFJJLNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B7D2E0", Offset = "0x6B7BEE0", VA = "0x186B7D2E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6B80270", Offset = "0x6B7EE70", VA = "0x186B80270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<MCGCBPGIFFK, MCGCBPGIFFK> DNHFDMPAEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B7D390", Offset = "0x6B7BF90", VA = "0x186B7D390", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E790", Offset = "0x6B7D390", VA = "0x186B7E790", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<MCGCBPGIFFK, MCGCBPGIFFK, MCGCBPGIFFK> PJFHNFNHJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6B7C170", Offset = "0x6B7AD70", VA = "0x186B7C170", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B7BD20", Offset = "0x6B7A920", VA = "0x186B7BD20", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B80470", Offset = "0x6B7F070", VA = "0x186B80470")]
	public GBCKHNLKBGP(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E2A0", Offset = "0x6B7CEA0", VA = "0x186B7E2A0", Slot = "12")]
	public void KMAKNPIEEHP(GameObject DKOODDCANLH, EKMEPFCBAHM FFCBBGOKAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B7F280", Offset = "0x6B7DE80", VA = "0x186B7F280", Slot = "26")]
	public void NPJJLDNPIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D8E0", Offset = "0x6B7C4E0", VA = "0x186B7D8E0", Slot = "22")]
	public bool JCGOAMGBHAI(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EEA0", Offset = "0x6B7DAA0", VA = "0x186B7EEA0")]
	private void LNDMKOGCLOB(JBKDGFJKCIL BPEBNPINAPE, JBKDGFJKCIL ODMOPDILPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B7F810", Offset = "0x6B7E410", VA = "0x186B7F810")]
	private void OOIBDHPECFB(JBKDGFJKCIL BPEBNPINAPE, JBKDGFJKCIL NMODKJNOJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B7CC60", Offset = "0x6B7B860", VA = "0x186B7CC60")]
	private void FOHIHMDAIOH(JBKDGFJKCIL BPEBNPINAPE, JBKDGFJKCIL NMODKJNOJGI, JBKDGFJKCIL ODMOPDILPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D440", Offset = "0x6B7C040", VA = "0x186B7D440")]
	private void ILNJBPGPHCC(JBKDGFJKCIL BPEBNPINAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "13")]
	public void HMDNBLCBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B7FC00", Offset = "0x6B7E800", VA = "0x186B7FC00", Slot = "14")]
	public void PEGPHNFMEDB(MCGCBPGIFFK BGFPAPJDPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "15")]
	public void ACKIONKPNNI(MCGCBPGIFFK BGFPAPJDPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C9C0", Offset = "0x6B7B5C0", VA = "0x186B7C9C0", Slot = "17")]
	public void FDGOMJHODOI(MCGCBPGIFFK BGFPAPJDPKA, MCGCBPGIFFK GNNEFKJIDDM, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B7CB20", Offset = "0x6B7B720", VA = "0x186B7CB20")]
	public void FDGOMJHODOI(JBKDGFJKCIL MADODMHNENF, JBKDGFJKCIL GNNEFKJIDDM, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C500", Offset = "0x6B7B100", VA = "0x186B7C500")]
	public void BPOOIIJOJGN(MCGCBPGIFFK BGFPAPJDPKA, float OHFKKMGCGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C3B0", Offset = "0x6B7AFB0", VA = "0x186B7C3B0", Slot = "18")]
	public void AIFCDBHFDNH(MCGCBPGIFFK BGHANJJAEMJ, int BAEIHMBDGMB, MCGCBPGIFFK AKNDPNAKNIL, int HCKNODKIBGJ, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C590", Offset = "0x6B7B190", VA = "0x186B7C590")]
	private float CABEHKMPNFH(JBKDGFJKCIL MADODMHNENF, JBKDGFJKCIL CDBGCEIGNJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C220", Offset = "0x6B7AE20", VA = "0x186B7C220")]
	public void AIFCDBHFDNH(JBKDGFJKCIL MADODMHNENF, JBKDGFJKCIL CDBGCEIGNJC, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C350", Offset = "0x6B7AF50", VA = "0x186B7C350")]
	public void AIFCDBHFDNH(JBKDGFJKCIL MADODMHNENF, JBKDGFJKCIL CDBGCEIGNJC, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ, float OHFKKMGCGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B7F0B0", Offset = "0x6B7DCB0", VA = "0x186B7F0B0", Slot = "19")]
	public void MAKOMKOBFLK(MCGCBPGIFFK BGFPAPJDPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B7F470", Offset = "0x6B7E070", VA = "0x186B7F470")]
	public bool OFKMCIEGPEA(JBKDGFJKCIL DKAIINNEBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B7BF60", Offset = "0x6B7AB60", VA = "0x186B7BF60", Slot = "16")]
	public void AHAEBKKFDHP(MCGCBPGIFFK BGFPAPJDPKA, HashSet<MCGCBPGIFFK> HEBDIEPOLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "20")]
	public HPOPPJJILEF IKNGDLFNPBC(bool CBPDFHNDFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "21")]
	public HPOPPJJILEF OBDPNNCHFEJ(HashSet<Guid> HFBLFIKGIPN, bool CBPDFHNDFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C8B0", Offset = "0x6B7B4B0", VA = "0x186B7C8B0", Slot = "23")]
	public void EPAJMLGMMEN(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C640", Offset = "0x6B7B240", VA = "0x186B7C640", Slot = "24")]
	public void CJEDMBAPGAG(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E190", Offset = "0x6B7CD90", VA = "0x186B7E190", Slot = "25")]
	public void KIDFFBIEDGC(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B7FF10", Offset = "0x6B7EB10", VA = "0x186B7FF10")]
	private void PFIAKBKIKAG(JBKDGFJKCIL MADODMHNENF, JBKDGFJKCIL CDBGCEIGNJC, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ, float OHFKKMGCGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B7CEC0", Offset = "0x6B7BAC0", VA = "0x186B7CEC0")]
	private void GDEKKECFKOJ(JBKDGFJKCIL MADODMHNENF, JBKDGFJKCIL NDJJLBGHFGF, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C840", Offset = "0x6B7B440", VA = "0x186B7C840")]
	private void DOHFIAMDJAK(JBKDGFJKCIL MADODMHNENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D850", Offset = "0x6B7C450", VA = "0x186B7D850")]
	[IteratorStateMachine(typeof(DPKGJDMJFIF))]
	public IEnumerable<MCGCBPGIFFK> INKCJNDKFCA(JBKDGFJKCIL DKAIINNEBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EBD0", Offset = "0x6B7D7D0", VA = "0x186B7EBD0")]
	internal MCGCBPGIFFK LJIMOMPOCEP(JBKDGFJKCIL DKAIINNEBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E050", Offset = "0x6B7CC50", VA = "0x186B7E050")]
	internal JBKDGFJKCIL KEGHICFGFBF(MCGCBPGIFFK BGFPAPJDPKA)
	{
		return default(JBKDGFJKCIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D930", Offset = "0x6B7C530", VA = "0x186B7D930")]
	private bool JHMPHIGCGIP(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C920", Offset = "0x6B7B520", VA = "0x186B7C920")]
	private bool EPPEAHLJJBG(IAFKMCJGOCF NEMFFPFIOFE, [Out] MCGCBPGIFFK CDBGCEIGNJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E840", Offset = "0x6B7D440", VA = "0x186B7E840")]
	private MCGCBPGIFFK LJIMOMPOCEP(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B7BDD0", Offset = "0x6B7A9D0", VA = "0x186B7BDD0")]
	private MCGCBPGIFFK AGIOJPCFNKP(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B7FA30", Offset = "0x6B7E630", VA = "0x186B7FA30")]
	private MCGCBPGIFFK PDMGECNOIIB(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C980", Offset = "0x6B7B580", VA = "0x186B7C980")]
	private static Guid FACBPOECGNB(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E1B0", Offset = "0x6B7CDB0", VA = "0x186B7E1B0")]
	private string KKHPDNPKGOK(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C6B0", Offset = "0x6B7B2B0", VA = "0x186B7C6B0")]
	private void COOEIHGCJIM(MCGCBPGIFFK MADODMHNENF, MCGCBPGIFFK NDJJLBGHFGF, RigidTransform MBPIJGCEGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B7ED10", Offset = "0x6B7D910", VA = "0x186B7ED10")]
	private void LMINHDHBLKL(MCGCBPGIFFK NDJJLBGHFGF, MCGCBPGIFFK MADODMHNENF, RigidTransform MBPIJGCEGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B7F220", Offset = "0x6B7DE20", VA = "0x186B7F220")]
	private void MHBKNDEJLKM(MCGCBPGIFFK ANOJJEOFNJL, MCGCBPGIFFK MADODMHNENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DEC0", Offset = "0x6B7CAC0", VA = "0x186B7DEC0")]
	private void JONONIFAOLD(MCGCBPGIFFK MADODMHNENF, MCGCBPGIFFK CDBGCEIGNJC, RigidTransform MBPIJGCEGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B7F700", Offset = "0x6B7E300", VA = "0x186B7F700")]
	private void OIFHCEEEIJE(JBKDGFJKCIL DKAIINNEBFL, MCGCBPGIFFK BGFPAPJDPKA, JBKDGFJKCIL NMODKJNOJGI, JBKDGFJKCIL ODMOPDILPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E510", Offset = "0x6B7D110", VA = "0x186B7E510")]
	private void KPJJMHNEFJG(JBKDGFJKCIL DKAIINNEBFL, MCGCBPGIFFK BGFPAPJDPKA, MCGCBPGIFFK OBHCFKBCNEP, MCGCBPGIFFK ABLLBFFMFIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FCPPMAFLEJM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HJEGHMICMMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public EAEKKMJPCLA container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public HJEGHMICMMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6B82350", Offset = "0x6B80F50", VA = "0x186B82350")]
		internal GBCKHNLKBGP CPMCIHMFNIG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6B7BBA0", Offset = "0x6B7A7A0", VA = "0x186B7BBA0")]
	public static void LNBDEJAELFK(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6B7BB50", Offset = "0x6B7A750", VA = "0x186B7BB50")]
	public static void ADCIJKIONPI(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HFGGCCNFGEC : CEGBCMBMBGK, HEPLNBKAMLM
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly GBCKHNLKBGP NCJFODCKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly KOGDFPIGACH KIILJHLMJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly DOHBDGEEKGE CPKOIOKIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JIEIHCIKLKF[] MFGPEGKDPKB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MCGCBPGIFFK GBPJALAAIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6B82120", Offset = "0x6B80D20", VA = "0x186B82120", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MCGCBPGIFFK MCHKPCFHLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6B80ED0", Offset = "0x6B7FAD0", VA = "0x186B80ED0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 OPANPKHOJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6B808A0", Offset = "0x6B7F4A0", VA = "0x186B808A0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion MNLNGGCIJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6B80FF0", Offset = "0x6B7FBF0", VA = "0x186B80FF0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DOLKKGFIHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6B81700", Offset = "0x6B80300", VA = "0x186B81700", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<MCGCBPGIFFK> KBOAFLIGCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B81050", Offset = "0x6B7FC50", VA = "0x186B81050", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool PBAMHIMOOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8F4160", Offset = "0x8F2D60", VA = "0x1808F4160", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8F3BB0", Offset = "0x8F27B0", VA = "0x1808F3BB0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B82330", Offset = "0x6B80F30", VA = "0x186B82330", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject MNEKHEHNFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x27439D0", Offset = "0x27425D0", VA = "0x1827439D0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6B82050", Offset = "0x6B80C50", VA = "0x186B82050", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid HPKEKFACKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B82180", Offset = "0x6B80D80", VA = "0x186B82180", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HAABPJAMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B82260", Offset = "0x6B80E60", VA = "0x186B82260", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GEJKIGGLBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JKFFBLGCLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6B81B90", Offset = "0x6B80790", VA = "0x186B81B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event PDFFILNGPNE KDKLHBNCCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B80C70", Offset = "0x6B7F870", VA = "0x186B80C70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6B81490", Offset = "0x6B80090", VA = "0x186B81490", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event PDFFILNGPNE AHGMIGNIHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6B80900", Offset = "0x6B7F500", VA = "0x186B80900", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6B80550", Offset = "0x6B7F150", VA = "0x186B80550", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PDFFILNGPNE CAOGBBAMJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6B81D80", Offset = "0x6B80980", VA = "0x186B81D80", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6B80F90", Offset = "0x6B7FB90", VA = "0x186B80F90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event GJKGOOFOHEE KIALMKOEKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6B81770", Offset = "0x6B80370", VA = "0x186B81770", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6B81BE0", Offset = "0x6B807E0", VA = "0x186B81BE0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B81F50", Offset = "0x6B80B50", VA = "0x186B81F50")]
	public HFGGCCNFGEC(JBKDGFJKCIL IMOBCMCECHO, RigidbodyEx OMKKPDAIFOD, KOGDFPIGACH KIILJHLMJDH, JIEIHCIKLKF[] MFGPEGKDPKB, DOHBDGEEKGE CPKOIOKIGEH, LOFCGFLCLPH NCJFODCKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B81D50", Offset = "0x6B80950", VA = "0x186B81D50", Slot = "19")]
	public void OJANEOIFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "21")]
	public void JMAOCAKMFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x699C260", Offset = "0x699AE60", VA = "0x18699C260", Slot = "22")]
	public void HNINKCHHMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B81AF0", Offset = "0x6B806F0", VA = "0x186B81AF0", Slot = "20")]
	public void LMFNDHIOLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B814F0", Offset = "0x6B800F0", VA = "0x186B814F0", Slot = "25")]
	public void KBDMLHBCEHA(int NNHFLNLJLGN, MCGCBPGIFFK AKNDPNAKNIL, int BHHLBOENJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B81DE0", Offset = "0x6B809E0", VA = "0x186B81DE0", Slot = "26")]
	public void PLBOJGKABLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B81810", Offset = "0x6B80410", VA = "0x186B81810", Slot = "27")]
	public void LLNNIPADBEJ(int NNHFLNLJLGN, MCGCBPGIFFK BGHANJJAEMJ, int GIHDMNBJPCD, [Optional] Vector3? IPHLOHGCGMJ, [Optional] Quaternion? BBGFLNFMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B81CD0", Offset = "0x6B808D0", VA = "0x186B81CD0", Slot = "28")]
	public void OIEOBCNMHKD(MCGCBPGIFFK BGHANJJAEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B81080", Offset = "0x6B7FC80", VA = "0x186B81080", Slot = "31")]
	public void JJKNAGKGOJK(Vector3 OEPABFLPGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B80960", Offset = "0x6B7F560", VA = "0x186B80960", Slot = "29")]
	public void FANNKKODGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B805B0", Offset = "0x6B7F1B0", VA = "0x186B805B0", Slot = "30")]
	public void CDAAFBOJPGN(int MFJLAMOCOBC, Vector3 KDELOFLMOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B80E00", Offset = "0x6B7FA00", VA = "0x186B80E00", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int NNHFLNLJLGN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B80CD0", Offset = "0x6B7F8D0", VA = "0x186B80CD0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int NNHFLNLJLGN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA5D300", Offset = "0xA5BF00", VA = "0x180A5D300", Slot = "42")]
	public Color GetConnectionSlotColor(int NNHFLNLJLGN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B80800", Offset = "0x6B7F400", VA = "0x186B80800", Slot = "43")]
	public bool CanConnectTo(int NNHFLNLJLGN, MCGCBPGIFFK IDGGKOFPOFC, int NDPAOOFIMMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "44")]
	public void ParentChanged(int NNHFLNLJLGN, MCGCBPGIFFK IMILKGGAEKE, int KMPKCOIGECJ, Vector3 BOEMPGJKNCH, Quaternion CPEPJGADBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "45")]
	public void ChildAdded(int NNHFLNLJLGN, MCGCBPGIFFK EJBEIDBGJHP, int NECJCDOBOCI, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "46")]
	public void ChildRemoved(int NNHFLNLJLGN, MCGCBPGIFFK LAAPLFMDODB, int PIMCKGGPCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "47")]
	public void ConnectionModified(int NNHFLNLJLGN, MCGCBPGIFFK AKNDPNAKNIL, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6B81EB0", Offset = "0x6B80AB0", VA = "0x186B81EB0", Slot = "48")]
	public void RootChanged(MCGCBPGIFFK KHLBIHBBGAP, MCGCBPGIFFK NHIBONPMFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6B807B0", Offset = "0x6B7F3B0", VA = "0x186B807B0", Slot = "23")]
	public void CGOOGNOEPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B81C80", Offset = "0x6B80880", VA = "0x186B81C80", Slot = "24")]
	public void OFJEBMOBNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B81B40", Offset = "0x6B80740", VA = "0x186B81B40")]
	private void MCIBGCONIDP(bool PHOIGNIPCBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(JEBGGLFMBOH), new string[] { })]
public class OKANKNGPIBF : JEBGGLFMBOH, LCGGPACKJOJ, EIHOCFDABND
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KFOCANCGILB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public OKANKNGPIBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public DBLPDLFFIKD localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public KFOCANCGILB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6B83950", Offset = "0x6B82550", VA = "0x186B83950")]
		internal void NHHFMKFAGIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[DependsOn]
	private FNKJONIKKCD PIAKONPJLMJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object NBLMAPKAOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6B85DE0", Offset = "0x6B849E0", VA = "0x186B85DE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B85C30", Offset = "0x6B84830", VA = "0x186B85C30", Slot = "5")]
	public void APCKEGINAKG(DBLPDLFFIKD CNEBDANMKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B85D90", Offset = "0x6B84990", VA = "0x186B85D90", Slot = "6")]
	private void GGEGDPIKPLN(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAE9C20", Offset = "0xAE8820", VA = "0x180AE9C20", Slot = "7")]
	private void AEHPABPDHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public OKANKNGPIBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(LOFCGFLCLPH), new string[] { "Ignore", "Mock" })]
public class JHPINLHOCHH : LOFCGFLCLPH, POGLPIENEJD
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KIIJDPHLFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ONPKAAENNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<MCGCBPGIFFK, MCGCBPGIFFK> INPFFJJLNNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6B83690", Offset = "0x6B82290", VA = "0x186B83690", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6B838A0", Offset = "0x6B824A0", VA = "0x186B838A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<MCGCBPGIFFK, MCGCBPGIFFK> DNHFDMPAEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6B83740", Offset = "0x6B82340", VA = "0x186B83740", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6B837F0", Offset = "0x6B823F0", VA = "0x186B837F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<MCGCBPGIFFK, MCGCBPGIFFK, MCGCBPGIFFK> PJFHNFNHJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6B835E0", Offset = "0x6B821E0", VA = "0x186B835E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6B83530", Offset = "0x6B82130", VA = "0x186B83530", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "26")]
	public void NPJJLDNPIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "12")]
	public void KMAKNPIEEHP(GameObject DKOODDCANLH, EKMEPFCBAHM FFCBBGOKAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "13")]
	public void HMDNBLCBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "14")]
	public void PEGPHNFMEDB(MCGCBPGIFFK BGFPAPJDPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "15")]
	public void ACKIONKPNNI(MCGCBPGIFFK BGFPAPJDPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "16")]
	public void AHAEBKKFDHP(MCGCBPGIFFK BGFPAPJDPKA, HashSet<MCGCBPGIFFK> HEBDIEPOLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "17")]
	public void FDGOMJHODOI(MCGCBPGIFFK BGFPAPJDPKA, MCGCBPGIFFK GNNEFKJIDDM, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "18")]
	public void AIFCDBHFDNH(MCGCBPGIFFK BGFPAPJDPKA, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "19")]
	public void MAKOMKOBFLK(MCGCBPGIFFK BGFPAPJDPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "20")]
	public HPOPPJJILEF IKNGDLFNPBC(bool CBPDFHNDFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "21")]
	public HPOPPJJILEF OBDPNNCHFEJ(HashSet<Guid> HFBLFIKGIPN, bool CBPDFHNDFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "22")]
	public bool JCGOAMGBHAI(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "23")]
	public void EPAJMLGMMEN(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "24")]
	public void CJEDMBAPGAG(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "25")]
	public void KIDFFBIEDGC(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public JHPINLHOCHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MCGCBPGIFFK : HEPLNBKAMLM, IEquatable<MCGCBPGIFFK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HEPLNBKAMLM
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MCGCBPGIFFK GBPJALAAIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject MNEKHEHNFLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid HPKEKFACKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int HAABPJAMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GEJKIGGLBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int NNHFLNLJLGN);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int NNHFLNLJLGN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int NNHFLNLJLGN);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int NNHFLNLJLGN, MCGCBPGIFFK IDGGKOFPOFC, int CNKDKJGMBBB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int NNHFLNLJLGN, MCGCBPGIFFK IMILKGGAEKE, int KMPKCOIGECJ, Vector3 BOEMPGJKNCH, Quaternion CPEPJGADBLC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int NNHFLNLJLGN, MCGCBPGIFFK EJBEIDBGJHP, int NECJCDOBOCI, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int NNHFLNLJLGN, MCGCBPGIFFK LAAPLFMDODB, int PIMCKGGPCEG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int NNHFLNLJLGN, MCGCBPGIFFK AKNDPNAKNIL, int OBIPFHHGDDE, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(MCGCBPGIFFK KHLBIHBBGAP, MCGCBPGIFFK NHIBONPMFCN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LOFCGFLCLPH : POGLPIENEJD
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool KIIJDPHLFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool ONPKAAENNAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MCGCBPGIFFK, MCGCBPGIFFK> INPFFJJLNNK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<MCGCBPGIFFK, MCGCBPGIFFK> DNHFDMPAEPJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<MCGCBPGIFFK, MCGCBPGIFFK, MCGCBPGIFFK> PJFHNFNHJDM;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KMAKNPIEEHP(GameObject DKOODDCANLH, EKMEPFCBAHM FFCBBGOKAOB);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HMDNBLCBPCK();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PEGPHNFMEDB(MCGCBPGIFFK BGFPAPJDPKA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ACKIONKPNNI(MCGCBPGIFFK BGFPAPJDPKA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AHAEBKKFDHP(MCGCBPGIFFK BGFPAPJDPKA, HashSet<MCGCBPGIFFK> HEBDIEPOLJH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FDGOMJHODOI(MCGCBPGIFFK BGFPAPJDPKA, MCGCBPGIFFK GNNEFKJIDDM, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AIFCDBHFDNH(MCGCBPGIFFK BGFPAPJDPKA, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MAKOMKOBFLK(MCGCBPGIFFK BGFPAPJDPKA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HPOPPJJILEF IKNGDLFNPBC(bool CBPDFHNDFAI);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	HPOPPJJILEF OBDPNNCHFEJ(HashSet<Guid> HFBLFIKGIPN, bool CBPDFHNDFAI);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JCGOAMGBHAI(IAFKMCJGOCF NEMFFPFIOFE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EPAJMLGMMEN(HPOPPJJILEF DMKHGPNMEMB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CJEDMBAPGAG(HPOPPJJILEF DMKHGPNMEMB);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KIDFFBIEDGC(HPOPPJJILEF DMKHGPNMEMB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PPEAMPJMKFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool LPBCKNAKDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MCGCBPGIFFK PDMGECNOIIB(int MEPBLMJCDPF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MCGCBPGIFFK AGIOJPCFNKP(Guid NEOKCOAIFAA);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HOJHGJJKMKC(MCGCBPGIFFK BGFPAPJDPKA);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CONOINNPAAO();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LLFFJIKJOMN(MCGCBPGIFFK KIILJHLMJDH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface DOHBDGEEKGE
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JKFFBLGCLDH(KOGDFPIGACH KIILJHLMJDH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GDFBENGKHFD(KOGDFPIGACH KIILJHLMJDH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string OCHJADHPEEP(KOGDFPIGACH KIILJHLMJDH);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid OMLOKODIPHJ(KOGDFPIGACH KIILJHLMJDH);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JLIEINIHAMG(KOGDFPIGACH KIILJHLMJDH);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JDIJEAKOGJE(KOGDFPIGACH KIILJHLMJDH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void PDFFILNGPNE(MCGCBPGIFFK BGHANJJAEMJ, int EBOEGMNDKDB, MCGCBPGIFFK AKNDPNAKNIL, int DDCPGDMDPNL, [Optional] Vector3? IPHLOHGCGMJ, [Optional] Quaternion? BBGFLNFMMOM);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void GJKGOOFOHEE(MCGCBPGIFFK KHLBIHBBGAP, MCGCBPGIFFK NHIBONPMFCN);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KOGDFPIGACH : MCGCBPGIFFK, HEPLNBKAMLM, IEquatable<MCGCBPGIFFK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CEGBCMBMBGK : HEPLNBKAMLM
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MCGCBPGIFFK MCHKPCFHLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<MCGCBPGIFFK> KBOAFLIGCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 OPANPKHOJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion MNLNGGCIJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool DOLKKGFIHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool PBAMHIMOOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event PDFFILNGPNE KDKLHBNCCJD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event PDFFILNGPNE AHGMIGNIHND;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event PDFFILNGPNE CAOGBBAMJFH;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event GJKGOOFOHEE KIALMKOEKPE;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OJANEOIFOLO();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LMFNDHIOLEF();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JMAOCAKMFEE();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HNINKCHHMKG();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CGOOGNOEPPG();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OFJEBMOBNHL();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KBDMLHBCEHA(int NNHFLNLJLGN, MCGCBPGIFFK AKNDPNAKNIL, int BHHLBOENJLA);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PLBOJGKABLF();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LLNNIPADBEJ(int NNHFLNLJLGN, MCGCBPGIFFK BGHANJJAEMJ, int GIHDMNBJPCD, [Optional] Vector3? IPHLOHGCGMJ, [Optional] Quaternion? BBGFLNFMMOM);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OIEOBCNMHKD(MCGCBPGIFFK BGHANJJAEMJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FANNKKODGNF();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CDAAFBOJPGN(int MFJLAMOCOBC, Vector3 KDELOFLMOME);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JJKNAGKGOJK(Vector3 OEPABFLPGEM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JIEIHCIKLKF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 FMHEONKMADO
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
public interface EKMEPFCBAHM
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OONPBAOMFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NFLKCLEEPIM PGLALGPFBGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, EKMEPFCBAHM
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
			[Cpp2IlInjected.Address(RVA = "0xA22440", Offset = "0xA21040", VA = "0x180A22440", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public NFLKCLEEPIM LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6B78DF0", Offset = "0x6B779F0", VA = "0x186B78DF0")]
		public static ConnectableConfigData DIDGFFAOAPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6B78EB0", Offset = "0x6B77AB0", VA = "0x186B78EB0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual MPHAAENNIHI, bool GMGGHALLLME)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DNHAIPPHFFB : IEquatable<DNHAIPPHFFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public MCGCBPGIFFK BGFPAPJDPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int MDHMFNHCIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int OBIPFHHGDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 IPHLOHGCGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion BBGFLNFMMOM;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6B79370", Offset = "0x6B77F70", VA = "0x186B79370")]
	public DNHAIPPHFFB(MCGCBPGIFFK BGFPAPJDPKA, int MDHMFNHCIOG, int OBIPFHHGDDE, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6B793D0", Offset = "0x6B77FD0", VA = "0x186B793D0")]
	public DNHAIPPHFFB(MCGCBPGIFFK BGFPAPJDPKA, int MDHMFNHCIOG, int OBIPFHHGDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6B79470", Offset = "0x6B78070", VA = "0x186B79470")]
	public DNHAIPPHFFB(MCGCBPGIFFK BGFPAPJDPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6B78F00", Offset = "0x6B77B00", VA = "0x186B78F00", Slot = "4")]
	public bool Equals(DNHAIPPHFFB FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6B78FB0", Offset = "0x6B77BB0", VA = "0x186B78FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class ICOOHBBNPDF : NCOJMOEIJME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform OHCKGBMFMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private NFLKCLEEPIM MGAJBOJMOEF;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x662ACA0", Offset = "0x66298A0", VA = "0x18662ACA0", Slot = "4")]
	public void KMAKNPIEEHP(Transform OHCKGBMFMEE, NFLKCLEEPIM MGAJBOJMOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6B82470", Offset = "0x6B81070", VA = "0x186B82470", Slot = "5")]
	public NFLKCLEEPIM HJNLHPFEGKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6B82400", Offset = "0x6B81000", VA = "0x186B82400", Slot = "6")]
	public void CFANCJOCANN(NFLKCLEEPIM MFDKIHCAEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public ICOOHBBNPDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class BGMPIDOHPOC : IDisposable, KEKKKGCJALC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CCENOCEKEKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public MCGCBPGIFFK oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public MCGCBPGIFFK newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public CCENOCEKEKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6B78090", Offset = "0x6B76C90", VA = "0x186B78090")]
		internal bool KNJDKOJIAIH(OKOHMNMMJDO node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly CHDHHMFHOMI JKOJBIHLENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private FHDAOFCCGAC PICJHHLDLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private AIIHMPMPFKI PGLAHKPDOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool GMGGHALLLME;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly BNHLDIHMNLF KOAKOBPMENA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public OKOHMNMMJDO JAFALLCEFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6B75200", Offset = "0x6B73E00", VA = "0x186B75200")]
	public bool BBOHKIDOIJI([In] KMLEEACFFNO BFLLAIFBMAJ, bool GOBMDIGFHIN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6B75430", Offset = "0x6B74030", VA = "0x186B75430")]
	private bool BGBNDBMCBHA([In] KMLEEACFFNO BFLLAIFBMAJ, bool GOBMDIGFHIN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6B77EC0", Offset = "0x6B76AC0", VA = "0x186B77EC0")]
	public BGMPIDOHPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6B77700", Offset = "0x6B76300", VA = "0x186B77700", Slot = "5")]
	public void KMAKNPIEEHP(LOFCGFLCLPH IGEADGIGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6B77CF0", Offset = "0x6B768F0", VA = "0x186B77CF0", Slot = "17")]
	public void NCACPBNFBAA(LNKHBOMMJBI NNGDIBHFMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6B75E50", Offset = "0x6B74A50", VA = "0x186B75E50", Slot = "12")]
	public void EAKJPINPGKB(Func<MCGCBPGIFFK, bool> PEOPMLNFACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6B75D20", Offset = "0x6B74920", VA = "0x186B75D20")]
	private void EAKJPINPGKB(CHDHHMFHOMI HNCCPGMBLOD, Func<MCGCBPGIFFK, bool> PEOPMLNFACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6B762B0", Offset = "0x6B74EB0", VA = "0x186B762B0", Slot = "11")]
	public void FFHEENJNOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6B75D10", Offset = "0x6B74910", VA = "0x186B75D10", Slot = "8")]
	public bool DNCIAIGILJP(MCGCBPGIFFK BFODAHCAPMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6B76C30", Offset = "0x6B75830", VA = "0x186B76C30")]
	private bool IMILCFIICLN(MCGCBPGIFFK DFLEFIPKJPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6B77330", Offset = "0x6B75F30", VA = "0x186B77330")]
	private static bool JDANFNOPGHC(MCGCBPGIFFK DFLEFIPKJPB, CHDHHMFHOMI MONCMHNLLEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6B75EC0", Offset = "0x6B74AC0", VA = "0x186B75EC0")]
	private void FCBKLNDEIML(Transform KJCJLCMDAFK, CHDHHMFHOMI IPDEOLPGANP, CHDHHMFHOMI[] EOBDEJBNFFJ, MCGCBPGIFFK OENHAEKJKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6B77A40", Offset = "0x6B76640", VA = "0x186B77A40")]
	private DNHAIPPHFFB MBNDKGHJGED(Transform OHHMBECLJPO, DNHAIPPHFFB LLOPAPICKEE)
	{
		return default(DNHAIPPHFFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6B75270", Offset = "0x6B73E70", VA = "0x186B75270")]
	private static bool BFLLJINDMGN(CHDHHMFHOMI MONCMHNLLEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6B75210", Offset = "0x6B73E10", VA = "0x186B75210", Slot = "9")]
	public bool BFCDOBHDBBD(MCGCBPGIFFK BGHDIOANDNN, int GIHDMNBJPCD, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6B74B00", Offset = "0x6B73700", VA = "0x186B74B00")]
	private bool ACIGBPJOCIN(MCGCBPGIFFK BGHDIOANDNN, int GIHDMNBJPCD, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6B762D0", Offset = "0x6B74ED0", VA = "0x186B762D0")]
	private static void FKNKFKDCFHD(MCGCBPGIFFK BGHDIOANDNN, int GIHDMNBJPCD, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM, CHDHHMFHOMI HHMFBKIPNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6B75BF0", Offset = "0x6B747F0", VA = "0x186B75BF0")]
	private void COOEIHGCJIM(MCGCBPGIFFK IEOCMHDNLJF, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6B773E0", Offset = "0x6B75FE0", VA = "0x186B773E0")]
	private void JFLPOHENFGG(CHDHHMFHOMI HNCCPGMBLOD, MCGCBPGIFFK OBHCFKBCNEP, MCGCBPGIFFK ABLLBFFMFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6B77450", Offset = "0x6B76050", VA = "0x186B77450")]
	private void JFLPOHENFGG(MCGCBPGIFFK BGFPAPJDPKA, MCGCBPGIFFK OBHCFKBCNEP, MCGCBPGIFFK ABLLBFFMFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6B777B0", Offset = "0x6B763B0", VA = "0x186B777B0")]
	private void KPJJMHNEFJG(MCGCBPGIFFK BGFPAPJDPKA, MCGCBPGIFFK OBHCFKBCNEP, MCGCBPGIFFK ABLLBFFMFIH, bool HGAHCLBDEPP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6B77820", Offset = "0x6B76420", VA = "0x186B77820")]
	private void KPJJMHNEFJG(CHDHHMFHOMI AHFIDHNOIFE, MCGCBPGIFFK OENHAEKJKPL, MCGCBPGIFFK NHIBONPMFCN, bool HGAHCLBDEPP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6B77920", Offset = "0x6B76520", VA = "0x186B77920")]
	private void LMINHDHBLKL(MCGCBPGIFFK MADODMHNENF, int GIHDMNBJPCD, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6B77B90", Offset = "0x6B76790", VA = "0x186B77B90")]
	private void MHBKNDEJLKM(OKOHMNMMJDO CDBGCEIGNJC, OKOHMNMMJDO BPLKJFJOEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6B76520", Offset = "0x6B75120", VA = "0x186B76520", Slot = "18")]
	public MCGCBPGIFFK HHLIGCAFDLE(MCGCBPGIFFK BGFPAPJDPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6B74E60", Offset = "0x6B73A60", VA = "0x186B74E60", Slot = "13")]
	public void AHAEBKKFDHP(MCGCBPGIFFK BGFPAPJDPKA, HashSet<MCGCBPGIFFK> CNAJKEGIJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6B774C0", Offset = "0x6B760C0", VA = "0x186B774C0", Slot = "14")]
	public List<MCGCBPGIFFK> JOPHCJGGPHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6B75B20", Offset = "0x6B74720", VA = "0x186B75B20")]
	protected OKOHMNMMJDO CNAIKCNDDOG(OKOHMNMMJDO HNCCPGMBLOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6B77D60", Offset = "0x6B76960", VA = "0x186B77D60")]
	protected CHDHHMFHOMI[] OANNAJOKPGH(CHDHHMFHOMI MONCMHNLLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6B74D50", Offset = "0x6B73950", VA = "0x186B74D50")]
	protected bool AGJHNBOEDDA(MCGCBPGIFFK BGFPAPJDPKA, [Out] CHDHHMFHOMI HNCCPGMBLOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6B759F0", Offset = "0x6B745F0", VA = "0x186B759F0", Slot = "15")]
	public bool BNCHDNCDGAK(MCGCBPGIFFK BGFPAPJDPKA, [Out] DNHAIPPHFFB EAOPAKEIIKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6B77D20", Offset = "0x6B76920", VA = "0x186B77D20")]
	protected CHDHHMFHOMI NMFELKLKPFK(DNHAIPPHFFB KENPDONLOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6B75E60", Offset = "0x6B74A60", VA = "0x186B75E60", Slot = "10")]
	public bool ECJPLCDGBED(MCGCBPGIFFK IEOCMHDNLJF, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6B76680", Offset = "0x6B75280", VA = "0x186B76680")]
	private bool HOEDIEBEOPL(MCGCBPGIFFK IEOCMHDNLJF, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6B76450", Offset = "0x6B75050", VA = "0x186B76450")]
	private static bool GLHEEIHKKAD(CHDHHMFHOMI KLLEGIIMGGM, DNHAIPPHFFB ACMMGPDIFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6B75200", Offset = "0x6B73E00", VA = "0x186B75200", Slot = "7")]
	private bool JKBIPKCOJOP([In] KMLEEACFFNO BFLLAIFBMAJ, bool GOBMDIGFHIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class EECGGAMHNLA : LOFCGFLCLPH, POGLPIENEJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly EAEKKMJPCLA EBEEBGHJNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly AIIHMPMPFKI PGLAHKPDOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly AFDHCEIFHKK PPHHKCPPHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly OMPGHKBOPDH CCLELPJEKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly KEKKKGCJALC DMKHGPNMEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal ELJBNMKPADO CPKOIOKIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal AMGAFPMMIOK EAKHDFPJOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal FHDAOFCCGAC POEKEAAKAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool GMGGHALLLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool FPKBOBNHKMJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HHNDLDMPGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xADFA70", Offset = "0xADE670", VA = "0x180ADFA70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xFA16A0", Offset = "0xFA02A0", VA = "0x180FA16A0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KIIJDPHLFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xADFA60", Offset = "0xADE660", VA = "0x180ADFA60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1C0D490", Offset = "0x1C0C090", VA = "0x181C0D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool ONPKAAENNAO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MCGCBPGIFFK, MCGCBPGIFFK> INPFFJJLNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6B7A690", Offset = "0x6B79290", VA = "0x186B7A690", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B700", Offset = "0x6B7A300", VA = "0x186B7B700", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MCGCBPGIFFK, MCGCBPGIFFK> DNHFDMPAEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6B7A780", Offset = "0x6B79380", VA = "0x186B7A780", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B210", Offset = "0x6B79E10", VA = "0x186B7B210", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MCGCBPGIFFK, MCGCBPGIFFK, MCGCBPGIFFK> PJFHNFNHJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6B79BF0", Offset = "0x6B787F0", VA = "0x186B79BF0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6B79A90", Offset = "0x6B78690", VA = "0x186B79A90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B760", Offset = "0x6B7A360", VA = "0x186B7B760")]
	public EECGGAMHNLA(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6B7AC40", Offset = "0x6B79840", VA = "0x186B7AC40", Slot = "12")]
	public void KMAKNPIEEHP(GameObject DKOODDCANLH, EKMEPFCBAHM FFCBBGOKAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B4A0", Offset = "0x6B7A0A0", VA = "0x186B7B4A0", Slot = "26")]
	public void NPJJLDNPIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A610", Offset = "0x6B79210", VA = "0x186B7A610", Slot = "13")]
	public void HMDNBLCBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B6E0", Offset = "0x6B7A2E0", VA = "0x186B7B6E0", Slot = "14")]
	public void PEGPHNFMEDB(MCGCBPGIFFK BGFPAPJDPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6B79A30", Offset = "0x6B78630", VA = "0x186B79A30", Slot = "15")]
	public void ACKIONKPNNI(MCGCBPGIFFK BGFPAPJDPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A960", Offset = "0x6B79560", VA = "0x186B7A960", Slot = "22")]
	public bool JCGOAMGBHAI(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6B79D90", Offset = "0x6B78990", VA = "0x186B79D90")]
	internal bool BGBNDBMCBHA([In] KMLEEACFFNO BFLLAIFBMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A6F0", Offset = "0x6B792F0", VA = "0x186B7A6F0")]
	internal bool HOEDIEBEOPL([In] KMLEEACFFNO BFLLAIFBMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B440", Offset = "0x6B7A040", VA = "0x186B7B440")]
	internal bool NGLGBOHHCJB([In] KMLEEACFFNO BFLLAIFBMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A040", Offset = "0x6B78C40", VA = "0x186B7A040")]
	internal bool DFDBJPJLEIE([In] KMLEEACFFNO BFLLAIFBMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A430", Offset = "0x6B79030", VA = "0x186B7A430")]
	internal void HJBPMILEGME(MCGCBPGIFFK BGFPAPJDPKA, int BCHDKMCEMPP, bool GOBMDIGFHIN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6B79A30", Offset = "0x6B78630", VA = "0x186B79A30")]
	internal bool ECDJLLBGPEH(MCGCBPGIFFK NKOABHPBGDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6B79F00", Offset = "0x6B78B00", VA = "0x186B79F00")]
	internal bool DFBLBNIHNDO(MCGCBPGIFFK BGHDIOANDNN, int GIHDMNBJPCD, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6B79AF0", Offset = "0x6B786F0", VA = "0x186B79AF0", Slot = "16")]
	public void AHAEBKKFDHP(MCGCBPGIFFK BGFPAPJDPKA, HashSet<MCGCBPGIFFK> HEBDIEPOLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A220", Offset = "0x6B78E20", VA = "0x186B7A220", Slot = "17")]
	public void FDGOMJHODOI(MCGCBPGIFFK BGHDIOANDNN, MCGCBPGIFFK GNNEFKJIDDM, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6B79C50", Offset = "0x6B78850", VA = "0x186B79C50", Slot = "18")]
	public void AIFCDBHFDNH(MCGCBPGIFFK IEOCMHDNLJF, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B270", Offset = "0x6B79E70", VA = "0x186B7B270", Slot = "19")]
	public void MAKOMKOBFLK(MCGCBPGIFFK IEOCMHDNLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A9F0", Offset = "0x6B795F0", VA = "0x186B7A9F0")]
	public void KKCPEGAKLNE([Optional] ADOPHAKHHNJ KJGCBLOLNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A190", Offset = "0x6B78D90", VA = "0x186B7A190", Slot = "23")]
	public void EPAJMLGMMEN(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A7E0", Offset = "0x6B793E0", VA = "0x186B7A7E0", Slot = "20")]
	public HPOPPJJILEF IKNGDLFNPBC(bool CBPDFHNDFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B540", Offset = "0x6B7A140", VA = "0x186B7B540", Slot = "21")]
	public HPOPPJJILEF OBDPNNCHFEJ(HashSet<Guid> HFBLFIKGIPN, bool CBPDFHNDFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A9B0", Offset = "0x6B795B0", VA = "0x186B7A9B0", Slot = "25")]
	public void KIDFFBIEDGC(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6B79E50", Offset = "0x6B78A50", VA = "0x186B79E50", Slot = "24")]
	public void CJEDMBAPGAG(HPOPPJJILEF DMKHGPNMEMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class AIIHMPMPFKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly OKECIPBPIAC<MCGCBPGIFFK, MCGCBPGIFFK> INPFFJJLNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly OKECIPBPIAC<MCGCBPGIFFK, MCGCBPGIFFK> DNHFDMPAEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly BOHHPOGCOJJ<MCGCBPGIFFK, MCGCBPGIFFK, MCGCBPGIFFK> PJFHNFNHJDM;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6B749E0", Offset = "0x6B735E0", VA = "0x186B749E0")]
	public AIIHMPMPFKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	public void KMAKNPIEEHP(EECGGAMHNLA IGEADGIGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6B748A0", Offset = "0x6B734A0", VA = "0x186B748A0")]
	public void DFHICLHENDG(MCGCBPGIFFK CDBGCEIGNJC, MCGCBPGIFFK MADODMHNENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6B74980", Offset = "0x6B73580", VA = "0x186B74980")]
	public void OICPMHNBOAM(MCGCBPGIFFK CDBGCEIGNJC, MCGCBPGIFFK MADODMHNENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6B74900", Offset = "0x6B73500", VA = "0x186B74900")]
	public void HFHCNMBPMKF(MCGCBPGIFFK ANOJJEOFNJL, MCGCBPGIFFK NDJJLBGHFGF, MCGCBPGIFFK MADODMHNENF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class AFDHCEIFHKK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private EECGGAMHNLA IGEADGIGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private AMGAFPMMIOK EAKHDFPJOPO;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public AFDHCEIFHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6B74650", Offset = "0x6B73250", VA = "0x186B74650")]
	public void KMAKNPIEEHP(EECGGAMHNLA IGEADGIGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6B74640", Offset = "0x6B73240", VA = "0x186B74640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6B74780", Offset = "0x6B73380", VA = "0x186B74780")]
	private void LGMFOFGMKNB(ADOPHAKHHNJ PMNDEDNNDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6B745D0", Offset = "0x6B731D0", VA = "0x186B745D0")]
	private void DMAPDNMIHDJ(ADOPHAKHHNJ PJAFELCOJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6B747A0", Offset = "0x6B733A0", VA = "0x186B747A0")]
	public void LPDBICNKBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6B744D0", Offset = "0x6B730D0", VA = "0x186B744D0")]
	public void BBKAHGOOGBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PBMPKAFINJK
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GJCBHGLNMBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EAEKKMJPCLA container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public GJCBHGLNMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6B804E0", Offset = "0x6B7F0E0", VA = "0x186B804E0")]
		internal EECGGAMHNLA CPMCIHMFNIG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6B886C0", Offset = "0x6B872C0", VA = "0x186B886C0")]
	public static void LNBDEJAELFK(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6B88640", Offset = "0x6B87240", VA = "0x186B88640")]
	public static void ADCIJKIONPI(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class JGNNEECDJGF : IDisposable, FHDAOFCCGAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, NFLKCLEEPIM> BGJGANIPFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LNKHBOMMJBI CEIAMFPAHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NCOJMOEIJME KLBMMHEFIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private KEKKKGCJALC DMKHGPNMEMB;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker JFPGJKNGPEG;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6B83200", Offset = "0x6B81E00", VA = "0x186B83200")]
	public JGNNEECDJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6B82AF0", Offset = "0x6B816F0", VA = "0x186B82AF0", Slot = "7")]
	public void KMAKNPIEEHP(KEKKKGCJALC DMKHGPNMEMB, NCOJMOEIJME KLBMMHEFIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6B828B0", Offset = "0x6B814B0", VA = "0x186B828B0", Slot = "5")]
	public void FHPCBEPHKKK(OKOHMNMMJDO NOBHMABKJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6B83030", Offset = "0x6B81C30", VA = "0x186B83030", Slot = "9")]
	public void OPPKFBEHJMM(OKOHMNMMJDO HFCJILDLMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6B82540", Offset = "0x6B81140", VA = "0x186B82540", Slot = "8")]
	public void CJANPNEFJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6B82CE0", Offset = "0x6B818E0", VA = "0x186B82CE0", Slot = "10")]
	public void NDNHGCHBKPI(OKOHMNMMJDO OMABEPHMDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6B82B30", Offset = "0x6B81730", VA = "0x186B82B30", Slot = "11")]
	public void MOEMMMBOLCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6B82700", Offset = "0x6B81300", VA = "0x186B82700")]
	private bool DCMGGPOCGDB(OKOHMNMMJDO BJFIIBACKFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class OMPGHKBOPDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct PGKEDBAICBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly CHDHHMFHOMI EMLAANJDEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> HFBLFIKGIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly IAFKMCJGOCF BHPJMAKNCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly IAFKMCJGOCF BDABBLAHOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool CBPDFHNDFAI;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool FHFLJNGCIDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6B88E10", Offset = "0x6B87A10", VA = "0x186B88E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6B89350", Offset = "0x6B87F50", VA = "0x186B89350")]
		public PGKEDBAICBL(CHDHHMFHOMI EMLAANJDEDL, HashSet<Guid> HFBLFIKGIPN, bool CBPDFHNDFAI, [Optional] IAFKMCJGOCF BHPJMAKNCKF, [Optional] IAFKMCJGOCF BDABBLAHOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6B890F0", Offset = "0x6B87CF0", VA = "0x186B890F0")]
		public IAFKMCJGOCF IMPFBNFMBKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6B89290", Offset = "0x6B87E90", VA = "0x186B89290")]
		private IAFKMCJGOCF LNADPMPPFFF([Out] IAFKMCJGOCF OAJADBAPGII, [Out] IAFKMCJGOCF HENIEPOHEDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6B88A80", Offset = "0x6B87680", VA = "0x186B88A80")]
		private IAFKMCJGOCF AEKPEECCKBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6B88CA0", Offset = "0x6B878A0", VA = "0x186B88CA0")]
		private void BGBDACDCLGK(IAFKMCJGOCF EPJMENCDGFO, IAFKMCJGOCF DACJNOFOIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6B88F30", Offset = "0x6B87B30", VA = "0x186B88F30")]
		private void FFLELCHALLM(IAFKMCJGOCF OAJADBAPGII, IAFKMCJGOCF HENIEPOHEDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private EECGGAMHNLA IGEADGIGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private KEKKKGCJALC DMKHGPNMEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private FHDAOFCCGAC PICJHHLDLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private AMGAFPMMIOK EAKHDFPJOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool MLGKJFGOFNP;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool LNGPGLHHJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6B874D0", Offset = "0x6B860D0", VA = "0x186B874D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool HHNDLDMPGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6B86160", Offset = "0x6B84D60", VA = "0x186B86160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6B87B30", Offset = "0x6B86730", VA = "0x186B87B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6B87520", Offset = "0x6B86120", VA = "0x186B87520")]
	public void KMAKNPIEEHP(EECGGAMHNLA IGEADGIGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6B864D0", Offset = "0x6B850D0", VA = "0x186B864D0")]
	public HPOPPJJILEF IKNGDLFNPBC(bool CBPDFHNDFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6B880B0", Offset = "0x6B86CB0", VA = "0x186B880B0")]
	public HPOPPJJILEF OBDPNNCHFEJ(HashSet<Guid> HFBLFIKGIPN, bool CBPDFHNDFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6B86440", Offset = "0x6B85040", VA = "0x186B86440")]
	public void EPAJMLGMMEN(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6B86180", Offset = "0x6B84D80", VA = "0x186B86180")]
	public void CJEDMBAPGAG(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6B87D40", Offset = "0x6B86940", VA = "0x186B87D40")]
	public void NFGIACIFNHI(HPOPPJJILEF DMKHGPNMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6B87B50", Offset = "0x6B86750", VA = "0x186B87B50")]
	private void LNKKGLINGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6B87E80", Offset = "0x6B86A80", VA = "0x186B87E80")]
	private IAFKMCJGOCF NLCCBLIEOLF(CHDHHMFHOMI HNCCPGMBLOD, bool CBPDFHNDFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6B87590", Offset = "0x6B86190", VA = "0x186B87590")]
	private static void LFAGHPFCMPG(CHDHHMFHOMI HNCCPGMBLOD, bool CBPDFHNDFAI, IAFKMCJGOCF NEMFFPFIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6B86220", Offset = "0x6B84E20", VA = "0x186B86220")]
	private void CPLDMNENDKF(CHDHHMFHOMI HNCCPGMBLOD, bool CBPDFHNDFAI, IAFKMCJGOCF NEMFFPFIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6B86640", Offset = "0x6B85240", VA = "0x186B86640")]
	private IAFKMCJGOCF IMDHDKLADBM(CHDHHMFHOMI EMLAANJDEDL, HashSet<Guid> HFBLFIKGIPN, bool CBPDFHNDFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6B86960", Offset = "0x6B85560", VA = "0x186B86960")]
	private bool JHFEOPCMKLB(HPOPPJJILEF FEOLNLEPCGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6B86BF0", Offset = "0x6B857F0", VA = "0x186B86BF0")]
	private bool JHMPHIGCGIP(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6B86140", Offset = "0x6B84D40", VA = "0x186B86140")]
	private bool CGHLNANLEIC(HPOPPJJILEF DMKHGPNMEMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6B87D70", Offset = "0x6B86970", VA = "0x186B87D70")]
	private static bool NFJPOLGGLMG(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6B866D0", Offset = "0x6B852D0", VA = "0x186B866D0")]
	public static bool JCGOAMGBHAI(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6B877E0", Offset = "0x6B863E0", VA = "0x186B877E0")]
	private MCGCBPGIFFK LJIMOMPOCEP(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6B883E0", Offset = "0x6B86FE0", VA = "0x186B883E0")]
	private MCGCBPGIFFK PDMGECNOIIB(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6B88250", Offset = "0x6B86E50", VA = "0x186B88250")]
	private MCGCBPGIFFK OKNOKDEOMJB(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C980", Offset = "0x6B7B580", VA = "0x186B7C980")]
	private static Guid FACBPOECGNB(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6B873E0", Offset = "0x6B85FE0", VA = "0x186B873E0")]
	private string KKHPDNPKGOK(IAFKMCJGOCF NEMFFPFIOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6B87250", Offset = "0x6B85E50", VA = "0x186B87250")]
	private bool JLOGCLHMIKF(CHDHHMFHOMI HNCCPGMBLOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6B85EE0", Offset = "0x6B84AE0", VA = "0x186B85EE0")]
	private static void BIHHBFJFJNM(CHDHHMFHOMI EMLAANJDEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public OMPGHKBOPDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct KMLEEACFFNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public MCGCBPGIFFK MADODMHNENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public MCGCBPGIFFK CDBGCEIGNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int GIHDMNBJPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int BHHLBOENJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 IPHLOHGCGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion BBGFLNFMMOM;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DNHAIPPHFFB OMGODMINHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6B83A70", Offset = "0x6B82670", VA = "0x186B83A70")]
		get
		{
			return default(DNHAIPPHFFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DNHAIPPHFFB NMKDKNKCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6B83A40", Offset = "0x6B82640", VA = "0x186B83A40")]
		get
		{
			return default(DNHAIPPHFFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6B83B10", Offset = "0x6B82710", VA = "0x186B83B10")]
	public KMLEEACFFNO(MCGCBPGIFFK MADODMHNENF, MCGCBPGIFFK CDBGCEIGNJC, int GIHDMNBJPCD, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface KEKKKGCJALC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OKOHMNMMJDO JAFALLCEFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMAKNPIEEHP(LOFCGFLCLPH IGEADGIGICG);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BBOHKIDOIJI([In] KMLEEACFFNO BFLLAIFBMAJ, bool GOBMDIGFHIN = true);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DNCIAIGILJP(MCGCBPGIFFK BFODAHCAPMO);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BFCDOBHDBBD(MCGCBPGIFFK BGHDIOANDNN, int GIHDMNBJPCD, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ECJPLCDGBED(MCGCBPGIFFK IEOCMHDNLJF, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FFHEENJNOFN();

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EAKJPINPGKB(Func<MCGCBPGIFFK, bool> PEOPMLNFACB);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AHAEBKKFDHP(MCGCBPGIFFK BGFPAPJDPKA, HashSet<MCGCBPGIFFK> CNAJKEGIJOC);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<MCGCBPGIFFK> JOPHCJGGPHL();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BNCHDNCDGAK(MCGCBPGIFFK BGFPAPJDPKA, [Out] DNHAIPPHFFB EAOPAKEIIKG);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NCACPBNFBAA(LNKHBOMMJBI NNGDIBHFMBF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool LNKHBOMMJBI(OKOHMNMMJDO HNCCPGMBLOD);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface OKOHMNMMJDO
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MCGCBPGIFFK KMIHFKOHMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	OKOHMNMMJDO GGAFGBKJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DNHAIPPHFFB PPBOLIALEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool PDIPANPHOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NFLKCLEEPIM : HNCNHOONNPG.EHEFCKJDJIE
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIBOHFMOAPI(MCGCBPGIFFK AKNDPNAKNIL, DNHAIPPHFFB MADODMHNENF);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIIIAHBMDDJ(MCGCBPGIFFK AKNDPNAKNIL, DNHAIPPHFFB MADODMHNENF);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLAAAPMDNBI(MCGCBPGIFFK AKNDPNAKNIL, DNHAIPPHFFB MADODMHNENF);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOOKJKDDFGP(MCGCBPGIFFK AKNDPNAKNIL, DNHAIPPHFFB MADODMHNENF);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NFLKCLEEPIM Instantiate(Transform OHCKGBMFMEE);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAMNEBLPMKL();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NCOJMOEIJME
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMAKNPIEEHP(Transform OHCKGBMFMEE, NFLKCLEEPIM MGAJBOJMOEF);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NFLKCLEEPIM HJNLHPFEGKB();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFANCJOCANN(NFLKCLEEPIM MFDKIHCAEBA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ELJBNMKPADO : PPEAMPJMKFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OELAMAEPHFJ();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PMJECIMNEGO(Guid EFCDLMBDPAA);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface FHDAOFCCGAC
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHPCBEPHKKK(OKOHMNMMJDO NOBHMABKJBD);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMAKNPIEEHP(KEKKKGCJALC DMKHGPNMEMB, NCOJMOEIJME INEEILFFCFF);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJANPNEFJOD();

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPPKFBEHJMM(OKOHMNMMJDO HFCJILDLMBB);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDNHGCHBKPI(OKOHMNMMJDO OMABEPHMDCG);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MOEMMMBOLCD();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class CHDHHMFHOMI : OKOHMNMMJDO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CNPMPLMACJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public DNHAIPPHFFB nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CHDHHMFHOMI foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public CNPMPLMACJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6B78CB0", Offset = "0x6B778B0", VA = "0x186B78CB0")]
		internal bool NOOJCGNENJE(OKOHMNMMJDO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private DNHAIPPHFFB EAOPAKEIIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<CHDHHMFHOMI> HJJBBJPJLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private CHDHHMFHOMI HDENOFHLOEM;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DNHAIPPHFFB PPBOLIALEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6C80", Offset = "0x3AE5880", VA = "0x183AE6C80", Slot = "6")]
		get
		{
			return default(DNHAIPPHFFB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6B78960", Offset = "0x6B77560", VA = "0x186B78960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private CHDHHMFHOMI CDBGCEIGNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x88C620", Offset = "0x88B220", VA = "0x18088C620")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6B78680", Offset = "0x6B77280", VA = "0x186B78680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OKOHMNMMJDO GGAFGBKJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x88C620", Offset = "0x88B220", VA = "0x18088C620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MCGCBPGIFFK KMIHFKOHMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PDIPANPHOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6B78150", Offset = "0x6B76D50", VA = "0x186B78150", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool APKDICNKLPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6B784B0", Offset = "0x6B770B0", VA = "0x186B784B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected CHDHHMFHOMI AHFIDHNOIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6B782B0", Offset = "0x6B76EB0", VA = "0x186B782B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6B78C00", Offset = "0x6B77800", VA = "0x186B78C00")]
	public CHDHHMFHOMI(DNHAIPPHFFB FIKIPJIMCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6B78810", Offset = "0x6B77410", VA = "0x186B78810")]
	public CHDHHMFHOMI KICAOPFBPDO(DNHAIPPHFFB CBDMEDGLEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B78500", Offset = "0x6B77100", VA = "0x186B78500")]
	public CHDHHMFHOMI DNFCGJCICJK(DNHAIPPHFFB IPHCGNJHHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B782D0", Offset = "0x6B76ED0", VA = "0x186B782D0")]
	public CHDHHMFHOMI CEFMELNJEMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B78160", Offset = "0x6B76D60", VA = "0x186B78160")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B78760", Offset = "0x6B77360", VA = "0x186B78760")]
	public CHDHHMFHOMI HKNNPCLMKNK(DNHAIPPHFFB NDJJLBGHFGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6B78990", Offset = "0x6B77590", VA = "0x186B78990")]
	private static void NCACPBNFBAA(CHDHHMFHOMI DDFLOPPFHPB, LNKHBOMMJBI BALHNEMLIEH, bool BDKMBDBMCFM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6B78AF0", Offset = "0x6B776F0", VA = "0x186B78AF0", Slot = "9")]
	public void NCACPBNFBAA(LNKHBOMMJBI NNGDIBHFMBF, bool HGAHCLBDEPP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B78B00", Offset = "0x6B77700", VA = "0x186B78B00")]
	public static CHDHHMFHOMI NMFELKLKPFK(CHDHHMFHOMI DDFLOPPFHPB, DNHAIPPHFFB FOPCGLDIGCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface AMGAFPMMIOK
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool LNGPGLHHJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LPBCKNAKDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<ADOPHAKHHNJ> LGMFOFGMKNB;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<ADOPHAKHHNJ> DMAPDNMIHDJ;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(EECGGAMHNLA IGEADGIGICG);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(MCGCBPGIFFK BGHDIOANDNN, MCGCBPGIFFK GNNEFKJIDDM, int GIHDMNBJPCD, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(MCGCBPGIFFK IEOCMHDNLJF, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(HPOPPJJILEF PPMOGNDOGHD, [Optional] ADOPHAKHHNJ KJGCBLOLNHN);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, AMGAFPMMIOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private EECGGAMHNLA IGEADGIGICG;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool LNGPGLHHJFA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6B858B0", Offset = "0x6B844B0", VA = "0x186B858B0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool LPBCKNAKDMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6B85910", Offset = "0x6B84510", VA = "0x186B85910", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<ADOPHAKHHNJ> LGMFOFGMKNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6B85810", Offset = "0x6B84410", VA = "0x186B85810", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x6B859F0", Offset = "0x6B845F0", VA = "0x186B859F0", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<ADOPHAKHHNJ> DMAPDNMIHDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x6B85770", Offset = "0x6B84370", VA = "0x186B85770", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x6B85950", Offset = "0x6B84550", VA = "0x186B85950", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x88C510", Offset = "0x88B110", VA = "0x18088C510", Slot = "19")]
		public void SetManager(EECGGAMHNLA IGEADGIGICG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B85740", Offset = "0x6B84340", VA = "0x186B85740")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B844C0", Offset = "0x6B830C0", VA = "0x186B844C0", Slot = "23")]
		public void RequestMasterConnectNodes(MCGCBPGIFFK BGHANJJAEMJ, int GIHDMNBJPCD, MCGCBPGIFFK AKNDPNAKNIL, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B845F0", Offset = "0x6B831F0", VA = "0x186B845F0", Slot = "24")]
		public void RequestMasterDisconnectNode(MCGCBPGIFFK BFODAHCAPMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6B846B0", Offset = "0x6B832B0", VA = "0x186B846B0", Slot = "20")]
		public void RequestMasterModifyNode(MCGCBPGIFFK BGHDIOANDNN, MCGCBPGIFFK GNNEFKJIDDM, int GIHDMNBJPCD, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6B847E0", Offset = "0x6B833E0", VA = "0x186B847E0", Slot = "21")]
		public void RequestMasterReparentNodes(MCGCBPGIFFK IEOCMHDNLJF, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6B84910", Offset = "0x6B83510", VA = "0x186B84910", Slot = "25")]
		public void RequestMasterReparentToRoot(MCGCBPGIFFK IEOCMHDNLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6B84390", Offset = "0x6B82F90", VA = "0x186B84390", Slot = "22")]
		public void RequestDeserializeConnectableGraph(HPOPPJJILEF PPMOGNDOGHD, [Optional] ADOPHAKHHNJ KJGCBLOLNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B84CF0", Offset = "0x6B838F0", VA = "0x186B84CF0")]
		[HCGOMCJIDFD]
		private void RpcMasterConnectNodes(MCGCBPGIFFK BGHANJJAEMJ, int GIHDMNBJPCD, MCGCBPGIFFK AKNDPNAKNIL, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6B84FB0", Offset = "0x6B83BB0", VA = "0x186B84FB0")]
		[HCGOMCJIDFD]
		private void RpcMasterDisconnectNode(MCGCBPGIFFK BFODAHCAPMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6B852F0", Offset = "0x6B83EF0", VA = "0x186B852F0")]
		[HCGOMCJIDFD]
		private void RpcMasterReparentNodes(MCGCBPGIFFK IEOCMHDNLJF, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6B850F0", Offset = "0x6B83CF0", VA = "0x186B850F0")]
		[HCGOMCJIDFD]
		private void RpcMasterModifyNode(MCGCBPGIFFK BGHDIOANDNN, MCGCBPGIFFK GNNEFKJIDDM, int GIHDMNBJPCD, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6B84AE0", Offset = "0x6B836E0", VA = "0x186B84AE0")]
		[HCGOMCJIDFD]
		private void RpcConnectNodes(MCGCBPGIFFK BGHANJJAEMJ, int GIHDMNBJPCD, MCGCBPGIFFK AKNDPNAKNIL, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM, PIMOANJCOIA MPHCKFOAPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6B84C60", Offset = "0x6B83860", VA = "0x186B84C60")]
		[HCGOMCJIDFD]
		private void RpcDisconnectNode(MCGCBPGIFFK BFODAHCAPMO, PIMOANJCOIA MPHCKFOAPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6B85640", Offset = "0x6B84240", VA = "0x186B85640")]
		[HCGOMCJIDFD]
		private void RpcReparentNodes(MCGCBPGIFFK IEOCMHDNLJF, int FENMPKKPNCE, MCGCBPGIFFK NDJJLBGHFGF, int KMPKCOIGECJ, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM, PIMOANJCOIA MPHCKFOAPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6B85580", Offset = "0x6B84180", VA = "0x186B85580")]
		[HCGOMCJIDFD]
		private void RpcModifyNode(MCGCBPGIFFK BGHDIOANDNN, int GIHDMNBJPCD, int BHHLBOENJLA, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM, PIMOANJCOIA MPHCKFOAPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6B84C20", Offset = "0x6B83820", VA = "0x186B84C20")]
		[HCGOMCJIDFD]
		private void RpcDeserializeConnectableGraph(HPOPPJJILEF DMKHGPNMEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E10", Offset = "0x8A3A10", VA = "0x1808A4E10")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, NFLKCLEEPIM, HNCNHOONNPG.EHEFCKJDJIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6B83FE0", Offset = "0x6B82BE0", VA = "0x186B83FE0", Slot = "4")]
		private void IEDNCMFGAIC(MCGCBPGIFFK AKNDPNAKNIL, DNHAIPPHFFB MADODMHNENF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6B83D70", Offset = "0x6B82970", VA = "0x186B83D70", Slot = "5")]
		private void GDKDAPKHGHD(MCGCBPGIFFK AKNDPNAKNIL, DNHAIPPHFFB MADODMHNENF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6B841D0", Offset = "0x6B82DD0", VA = "0x186B841D0", Slot = "6")]
		private void JOPFKACPIEG(MCGCBPGIFFK AKNDPNAKNIL, DNHAIPPHFFB MADODMHNENF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6B83B80", Offset = "0x6B82780", VA = "0x186B83B80", Slot = "7")]
		private void ADOFABPLLNN(MCGCBPGIFFK AKNDPNAKNIL, DNHAIPPHFFB MADODMHNENF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6B84160", Offset = "0x6B82D60", VA = "0x186B84160", Slot = "8")]
		private NFLKCLEEPIM JIPPMCEEEKE(Transform OHCKGBMFMEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6B84330", Offset = "0x6B82F30", VA = "0x186B84330", Slot = "9")]
		private void KMOIMACFFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BLKPOPOPFNB
{
	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B98450", Offset = "0x2B97050", VA = "0x182B98450")]
	public static FENIMEKCCJE<T> IPHOJFFHJJG<T>(this EAEKKMJPCLA EBEEBGHJNFK)
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
