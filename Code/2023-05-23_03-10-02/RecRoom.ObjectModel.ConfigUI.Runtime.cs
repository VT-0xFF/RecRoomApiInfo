using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.CodeGen.Attributes;
using RecRoom.Components;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal struct PAAFCEGGAPC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F26CA0", Offset = "0x6F260A0", VA = "0x186F26CA0")]
	public static NativeList<int> ODDIANJIMEA(AKEJCMHMCDK HIDLNGIDPHM, JIMDJIJECBG ILDDOIKKONE)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F26AC0", Offset = "0x6F25EC0", VA = "0x186F26AC0")]
	private static bool AMGPFFPOODE(FKGHEBGADOE MMNEFCOHNGA, AKEJCMHMCDK HIDLNGIDPHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal struct BBIBKLDBDLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int MCHHBPHHMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public int FIDMLDAHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public int LHEGNPFIDGH;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal abstract class NDBELIPDNDK : CGGMCFDBACK, BHIJDJDKPDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FKGHEBGADOE[] MCBLOLAFOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private FKGHEBGADOE[] KLEDCBKECAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FKGHEBGADOE[] FPAGOFDFPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public FKGHEBGADOE[] BGDGHEMFFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract GPHNDJBMNHN[] HIDNBBOBBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract GPHNDJBMNHN[] MNONILLFJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F251A0", Offset = "0x6F245A0", VA = "0x186F251A0", Slot = "6")]
	public void CEBPBFKDMNN(LGJPMHDMNKE IOCLBOMOEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, AKEJCMHMCDK HIDLNGIDPHM, JIMDJIJECBG ILDDOIKKONE, HCEDMHJILLI KOIGCJCDPJN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2911830", Offset = "0x2910C30", VA = "0x182911830")]
	protected static T AJAAPFIKIOM<T>(AKEJCMHMCDK HIDLNGIDPHM, FKGHEBGADOE MMNEFCOHNGA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2911880", Offset = "0x2910C80", VA = "0x182911880")]
	protected static void EMKCPHAHKEE<T>(AKEJCMHMCDK HIDLNGIDPHM, FKGHEBGADOE MMNEFCOHNGA, T EOEKGHMNIDN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	protected NDBELIPDNDK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct IGNEMBMEKAJ : IComparer<BBIBKLDBDLK>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F23040", Offset = "0x6F22440", VA = "0x186F23040", Slot = "4")]
	public int Compare(BBIBKLDBDLK ELMEJGEELII, BBIBKLDBDLK EOKEPOJIFJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F23050", Offset = "0x6F22450", VA = "0x186F23050")]
	public static void PFDOMCFIJGE(NativeList<BBIBKLDBDLK> DGDPMMFACGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OLKEOMKJAKB : CBGEFOBBEBH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly FKGHEBGADOE MMNEFCOHNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JIMDJIJECBG EHCALDODJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AKEJCMHMCDK HIDLNGIDPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool OLOGLDMJOBK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string EKGMLAPMPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F26400", Offset = "0x6F25800", VA = "0x186F26400", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BHHODJDPJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F26660", Offset = "0x6F25A60", VA = "0x186F26660", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MLKCCEGIBBL AIGMGLFGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F261E0", Offset = "0x6F255E0", VA = "0x186F261E0", Slot = "8")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type KEFHMMCGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F26850", Offset = "0x6F25C50", VA = "0x186F26850", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action FLPEAEPONAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F265C0", Offset = "0x6F259C0", VA = "0x186F265C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F26450", Offset = "0x6F25850", VA = "0x186F26450", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F269C0", Offset = "0x6F25DC0", VA = "0x186F269C0")]
	public OLKEOMKJAKB(AKEJCMHMCDK HIDLNGIDPHM, FKGHEBGADOE MMNEFCOHNGA, JIMDJIJECBG EHCALDODJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F267A0", Offset = "0x6F25BA0", VA = "0x186F267A0")]
	private void JFPKKAPMJEI(IMDEFFNCIAA IEFFONDNDLL, CDCHAKEJFEI GAEHKOIHPJO, GGCEFKOAKOD CBANDKAJFBB, GGCEFKOAKOD MJGOBCMBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F268A0", Offset = "0x6F25CA0", VA = "0x186F268A0", Slot = "10")]
	public void LLPKLFBKNII(FKDDJKLFJDM EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F26260", Offset = "0x6F25660", VA = "0x186F26260", Slot = "11")]
	public void BCHEBCENJDG(GGCEFKOAKOD EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F264F0", Offset = "0x6F258F0", VA = "0x186F264F0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LIJDKBBANIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F24F80", Offset = "0x6F24380", VA = "0x186F24F80")]
	public static bool HDPDBFNDNLE(this FKGHEBGADOE MMNEFCOHNGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[EADPCOLIJKG(typeof(Vector3))]
internal class DLMONLEGNBL : global::KJLJAOKNPAC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NFFJJBAGNGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CBGEFOBBEBH property;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NFFJJBAGNGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F25680", Offset = "0x6F24A80", VA = "0x186F25680")]
		internal float EIJGPCAAEII()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F256D0", Offset = "0x6F24AD0", VA = "0x186F256D0")]
		internal void IOFCKNGIPEH(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F256F0", Offset = "0x6F24AF0", VA = "0x186F256F0")]
		internal float PCANIMIKMGN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F25670", Offset = "0x6F24A70", VA = "0x186F25670")]
		internal void CJLPLJJNDFA(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F25740", Offset = "0x6F24B40", VA = "0x186F25740")]
		internal float PPCJAOIAMDD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F256E0", Offset = "0x6F24AE0", VA = "0x186F256E0")]
		internal void ONKPOEPEMHI(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F255B0", Offset = "0x6F249B0", VA = "0x186F255B0")]
		internal void AANCAFJEAAM(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F21E40", Offset = "0x6F21240", VA = "0x186F21E40", Slot = "5")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F22260", Offset = "0x6F21660", VA = "0x186F22260")]
	public DLMONLEGNBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[EADPCOLIJKG(typeof(uint))]
internal class DHMNGKOOFFJ : global::KJLJAOKNPAC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DAKDKBGGPDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CBGEFOBBEBH property;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DAKDKBGGPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F21730", Offset = "0x6F20B30", VA = "0x186F21730")]
		internal int EIJGPCAAEII()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F21770", Offset = "0x6F20B70", VA = "0x186F21770")]
		internal void IOFCKNGIPEH(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F21800", Offset = "0x6F20C00", VA = "0x186F21800", Slot = "5")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F219C0", Offset = "0x6F20DC0", VA = "0x186F219C0")]
	public DHMNGKOOFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Class)]
public class INFJBLBFAJH : LFDBIAJJEOP
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F23170", Offset = "0x6F22570", VA = "0x186F23170")]
	public INFJBLBFAJH(int MAOODCNPJOI = 1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[INFJBLBFAJH(1)]
internal sealed class CNOJOBDLOFB : MEKGJJDCNMC, JMCPOGAEOGI, BHIJDJDKPDC
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FGDHCOBBEAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CBGEFOBBEBH property;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FGDHCOBBEAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F22390", Offset = "0x6F21790", VA = "0x186F22390")]
		internal bool EIJGPCAAEII()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6F223E0", Offset = "0x6F217E0", VA = "0x186F223E0")]
		internal string IOFCKNGIPEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F22460", Offset = "0x6F21860", VA = "0x186F22460")]
		internal void PCANIMIKMGN(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F222A0", Offset = "0x6F216A0", VA = "0x186F222A0")]
		internal string CJLPLJJNDFA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F21570", Offset = "0x6F20970", VA = "0x186F21570", Slot = "4")]
	public int IEMHABMPMDA(LGJPMHDMNKE EHCALDODJBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F21100", Offset = "0x6F20500", VA = "0x186F21100", Slot = "5")]
	public void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public CNOJOBDLOFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[EADPCOLIJKG(typeof(FixedString64Bytes))]
internal class FGEIMDMPNKC : global::KJLJAOKNPAC<FixedString64Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class CPJJEFFFMBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CBGEFOBBEBH property;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CPJJEFFFMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F21620", Offset = "0x6F20A20", VA = "0x186F21620")]
		internal string EIJGPCAAEII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F216A0", Offset = "0x6F20AA0", VA = "0x186F216A0")]
		internal void IOFCKNGIPEH(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F224F0", Offset = "0x6F218F0", VA = "0x186F224F0", Slot = "5")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F226B0", Offset = "0x6F21AB0", VA = "0x186F226B0")]
	public FGEIMDMPNKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal struct OHIIEHHHPPI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NativeBitArray OPEBKKAFEIH;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F26180", Offset = "0x6F25580", VA = "0x186F26180")]
	public OHIIEHHHPPI(int HHFCIFFLNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F25F50", Offset = "0x6F25350", VA = "0x186F25F50")]
	public static OHIIEHHHPPI MJCBDGGNAIN(int FJOEBJHKPLP, NativeArray<int> PGJHKOKFEAD)
	{
		return default(OHIIEHHHPPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E60", Offset = "0x6F25260", VA = "0x186F25E60")]
	public bool AOCFEFKNCBK(int CJOLACIBAJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E70", Offset = "0x6F25270", VA = "0x186F25E70")]
	public void BCHEBCENJDG(int CJOLACIBAJH, bool EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E90", Offset = "0x6F25290", VA = "0x186F25E90")]
	public bool FNCFDDLJEEJ(FKGHEBGADOE[] PGJHKOKFEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F260C0", Offset = "0x6F254C0", VA = "0x186F260C0")]
	public bool NDKIPKFNHLO(FKGHEBGADOE[] PGJHKOKFEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E80", Offset = "0x6F25280", VA = "0x186F25E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class JFFBBMDIMBG
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly JIMDJIJECBG ILDDOIKKONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LGJPMHDMNKE IOCLBOMOEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<BHIJDJDKPDC> HGFMKJMDFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NHBEIDKDOOO BMFAMONHJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeMultiHashMap<int, int> LLJDEOABOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> CCILGLBJFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool OLOGLDMJOBK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<BHIJDJDKPDC> DEADBKLANGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F24B10", Offset = "0x6F23F10", VA = "0x186F24B10")]
	public JFFBBMDIMBG(JIMDJIJECBG ILDDOIKKONE, LGJPMHDMNKE IOCLBOMOEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F238C0", Offset = "0x6F22CC0", VA = "0x186F238C0")]
	public void BPGEOBNBMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F24350", Offset = "0x6F23750", VA = "0x186F24350")]
	public void KJDLCGMDEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F24530", Offset = "0x6F23930", VA = "0x186F24530")]
	public NativeList<BBIBKLDBDLK> KJLENIJHDAA(NativeArray<int> PGJHKOKFEAD)
	{
		return default(NativeList<BBIBKLDBDLK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F23D20", Offset = "0x6F23120", VA = "0x186F23D20")]
	private bool CEAEJJGNIBC(BHIJDJDKPDC KJGLFNFICOA, OHIIEHHHPPI BDNGCDPEJEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x20CED40", Offset = "0x20CE140", VA = "0x1820CED40")]
	private void OPFOLGOPGKO<TInterface, TAttribute>(Action<TInterface, TAttribute> NONJIGPIBJK) where TInterface : BHIJDJDKPDC where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F249B0", Offset = "0x6F23DB0", VA = "0x186F249B0")]
	private void MCNBCIAOGLL(Type ONBHBHIHHNE, Type NCNENBBEGJH, Type KPADOPGBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x20CECE0", Offset = "0x20CE0E0", VA = "0x1820CECE0")]
	private TInterface LKFBKOICLJE<TInterface>(Type ONBHBHIHHNE)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F23C50", Offset = "0x6F23050", VA = "0x186F23C50")]
	private void CDGKLMODEIN(BHIJDJDKPDC KJGLFNFICOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F249E0", Offset = "0x6F23DE0", VA = "0x186F249E0")]
	private int NLOKPODJDCP(BHIJDJDKPDC OIAILNCPEGI, int LHEGNPFIDGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F23F00", Offset = "0x6F23300", VA = "0x186F23F00")]
	private void EOLOFJGBOKB(JMCPOGAEOGI KJGLFNFICOA, EADPCOLIJKG PCHDNJJCDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F23990", Offset = "0x6F22D90", VA = "0x186F23990")]
	private void BPIMBNFNIKA(IBGMMAHIFGC KJGLFNFICOA, LHBPNEDCDHJ PCHDNJJCDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F241B0", Offset = "0x6F235B0", VA = "0x186F241B0")]
	private void GLBPDGKAMNN(CGGMCFDBACK KJGLFNFICOA, NJGIMBLNLHM PCHDNJJCDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F23DF0", Offset = "0x6F231F0", VA = "0x186F23DF0")]
	private void CEMBEBKCLFO(MEKGJJDCNMC KJGLFNFICOA, INFJBLBFAJH PCHDNJJCDEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[EADPCOLIJKG(typeof(float))]
internal class ILABLFJGADN : global::KJLJAOKNPAC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F230A0", Offset = "0x6F224A0", VA = "0x186F230A0", Slot = "5")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F23130", Offset = "0x6F22530", VA = "0x186F23130")]
	public ILABLFJGADN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal abstract class KJLJAOKNPAC<T> : JMCPOGAEOGI, BHIJDJDKPDC where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CBPNPANBKOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CBGEFOBBEBH property;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public CBPNPANBKOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x35A6F10", Offset = "0x35A6310", VA = "0x1835A6F10")]
		internal bool FJFLMOCIGNL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x42F2440", Offset = "0x42F1840", VA = "0x1842F2440")]
	protected KJLJAOKNPAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x42F1830", Offset = "0x42F0C30", VA = "0x1842F1830")]
	protected void GHKHMAGHAND(IEJHEMDBKJC DJBMAHFONBK, CBGEFOBBEBH MMNEFCOHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x42F1E60", Offset = "0x42F1260", VA = "0x1842F1E60")]
	protected void IIIMPNPKGCH(global::CDDKMBOPCAN<T> DJBMAHFONBK, CBGEFOBBEBH MMNEFCOHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[EADPCOLIJKG(typeof(FixedString32Bytes))]
internal class PAFAOIKCCOP : global::KJLJAOKNPAC<FixedString32Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class GDHFKDPAIPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CBGEFOBBEBH property;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GDHFKDPAIPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F226F0", Offset = "0x6F21AF0", VA = "0x186F226F0")]
		internal string EIJGPCAAEII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F22750", Offset = "0x6F21B50", VA = "0x186F22750")]
		internal void IOFCKNGIPEH(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F26EC0", Offset = "0x6F262C0", VA = "0x186F26EC0", Slot = "5")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F27080", Offset = "0x6F26480", VA = "0x186F27080")]
	public PAFAOIKCCOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[EADPCOLIJKG(typeof(bool))]
internal class LCOENEJEKKO : global::KJLJAOKNPAC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F24EB0", Offset = "0x6F242B0", VA = "0x186F24EB0", Slot = "5")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F24F40", Offset = "0x6F24340", VA = "0x186F24F40")]
	public LCOENEJEKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal abstract class DCDFKBONHJF : global::DILEDCFLCFM<Enum>, IBGMMAHIFGC, JMCPOGAEOGI, BHIJDJDKPDC
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract bool HCMBPJKEIIB(Type ONBHBHIHHNE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F217C0", Offset = "0x6F20BC0", VA = "0x186F217C0")]
	protected DCDFKBONHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal abstract class DILEDCFLCFM<T> : JMCPOGAEOGI, BHIJDJDKPDC where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GOJPABJEFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CBGEFOBBEBH property;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public GOJPABJEFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x57875E0", Offset = "0x57869E0", VA = "0x1857875E0")]
		internal bool FJFLMOCIGNL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x360FB90", Offset = "0x360EF90", VA = "0x18360FB90")]
	protected DILEDCFLCFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x360F4A0", Offset = "0x360E8A0", VA = "0x18360F4A0")]
	protected void GHKHMAGHAND(IEJHEMDBKJC DJBMAHFONBK, CBGEFOBBEBH MMNEFCOHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x360F8C0", Offset = "0x360ECC0", VA = "0x18360F8C0")]
	protected void IIIMPNPKGCH(global::CDDKMBOPCAN<T> DJBMAHFONBK, CBGEFOBBEBH MMNEFCOHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[EADPCOLIJKG(typeof(RenderableColor), 1)]
internal class OFOMFMEEFGM : global::DILEDCFLCFM<RenderableColor>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F25CB0", Offset = "0x6F250B0", VA = "0x186F25CB0", Slot = "5")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E20", Offset = "0x6F25220", VA = "0x186F25E20")]
	public OFOMFMEEFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[NJGIMBLNLHM(2)]
internal class HDCJHNDILCD : NDBELIPDNDK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GPCJFLBBNFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AKEJCMHMCDK targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HDCJHNDILCD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GPCJFLBBNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F227C0", Offset = "0x6F21BC0", VA = "0x186F227C0")]
		internal (int, int) EIJGPCAAEII()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F228F0", Offset = "0x6F21CF0", VA = "0x186F228F0")]
		internal void IOFCKNGIPEH((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected override GPHNDJBMNHN[] MNONILLFJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F22AE0", Offset = "0x6F21EE0", VA = "0x186F22AE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected override GPHNDJBMNHN[] HIDNBBOBBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F22F60", Offset = "0x6F22360", VA = "0x186F22F60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F22BC0", Offset = "0x6F21FC0", VA = "0x186F22BC0", Slot = "10")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, AKEJCMHMCDK HIDLNGIDPHM, JIMDJIJECBG ILDDOIKKONE, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public HDCJHNDILCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[LHBPNEDCDHJ(0)]
internal class KOHPFBLLIDB : DCDFKBONHJF
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F24D40", Offset = "0x6F24140", VA = "0x186F24D40", Slot = "5")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F24DF0", Offset = "0x6F241F0", VA = "0x186F24DF0", Slot = "7")]
	public override bool HCMBPJKEIIB(Type ONBHBHIHHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6F217C0", Offset = "0x6F20BC0", VA = "0x186F217C0")]
	public KOHPFBLLIDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class CNOICDMCPFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly JIMDJIJECBG ILDDOIKKONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly LGJPMHDMNKE IOCLBOMOEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HCEDMHJILLI KOIGCJCDPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Action<BBIBKLDBDLK> EKFHNINDCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<BGHGHILBACL> PNKFCPNAAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<BGHGHILBACL, List<BBIBKLDBDLK>> IHLELLNHIMO;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F20FE0", Offset = "0x6F203E0", VA = "0x186F20FE0")]
	public CNOICDMCPFE(JIMDJIJECBG ILDDOIKKONE, LGJPMHDMNKE IOCLBOMOEBD, HCEDMHJILLI KOIGCJCDPJN, Action<BBIBKLDBDLK> EKFHNINDCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F20AA0", Offset = "0x6F1FEA0", VA = "0x186F20AA0")]
	public void OAFDBFLCHKJ(NativeList<BBIBKLDBDLK> DGDPMMFACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6F20EC0", Offset = "0x6F202C0", VA = "0x186F20EC0")]
	private void PNLOLAHGLMJ(BGHGHILBACL ACHKMLIMANN, BBIBKLDBDLK BFINLNADCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F20620", Offset = "0x6F1FA20", VA = "0x186F20620")]
	public void LIGCOLDLIKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F20680", Offset = "0x6F1FA80", VA = "0x186F20680")]
	private void NKLBMOKEAFF(BGHGHILBACL ACHKMLIMANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F20E20", Offset = "0x6F20220", VA = "0x186F20E20")]
	private void PBIECELFELE(BGHGHILBACL ACHKMLIMANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DGOAMDMMJCP(typeof(BMILFIABBPB), new string[] { })]
internal class CKAAAGFKJCH : BMILFIABBPB, LCECMPMAFGI, IKNHCAJMNBA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[HIOFMIONOOD]
	private LGJPMHDMNKE IOCLBOMOEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[HIOFMIONOOD]
	private JIMDJIJECBG ILDDOIKKONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[HIOFMIONOOD]
	private HCEDMHJILLI LMLKKIHCDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private JFFBBMDIMBG GOMEPAOEJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private AKEJCMHMCDK HIDLNGIDPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<CBGEFOBBEBH> JHPEEAFBBOG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F20090", Offset = "0x6F1F490", VA = "0x186F20090", Slot = "5")]
	public void InitReferences(INPLDICFFFN LOBBJNOOMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F201A0", Offset = "0x6F1F5A0", VA = "0x186F201A0", Slot = "6")]
	public void MKGGPELCJDG(INPLDICFFFN LOBBJNOOMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F8D0", Offset = "0x6F1ECD0", VA = "0x186F1F8D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F9B0", Offset = "0x6F1EDB0", VA = "0x186F1F9B0", Slot = "4")]
	public void ECIELFAJKLG(AKEJCMHMCDK FOIKCNCPLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F20120", Offset = "0x6F1F520", VA = "0x186F20120")]
	private void MIODOLANPKP(AKEJCMHMCDK FOIKCNCPLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FEB0", Offset = "0x6F1F2B0", VA = "0x186F1FEB0")]
	private void HHGOFCLAIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F550", Offset = "0x6F1E950", VA = "0x186F1F550")]
	private void BNAEBMJEMFC(BBIBKLDBDLK BFINLNADCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F205A0", Offset = "0x6F1F9A0", VA = "0x186F205A0")]
	public CKAAAGFKJCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal struct IOGAMDOFGPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly LGJPMHDMNKE IOCLBOMOEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly List<BHIJDJDKPDC> HGFMKJMDFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<BBIBKLDBDLK> EGIMNCBGPPC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NativeList<BBIBKLDBDLK> OFCEDJNICEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89ED30", Offset = "0x89E130", VA = "0x18089ED30")]
		get
		{
			return default(NativeList<BBIBKLDBDLK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F23840", Offset = "0x6F22C40", VA = "0x186F23840")]
	public IOGAMDOFGPE(LGJPMHDMNKE IOCLBOMOEBD, List<BHIJDJDKPDC> HGFMKJMDFOC, NativeArray<BBIBKLDBDLK> DGDPMMFACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F23250", Offset = "0x6F22650", VA = "0x186F23250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F23290", Offset = "0x6F22690", VA = "0x186F23290")]
	private NativeList<BBIBKLDBDLK> MJCEDEGMABJ(NativeArray<BBIBKLDBDLK> PDKKAECFLBA)
	{
		return default(NativeList<BBIBKLDBDLK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6F23180", Offset = "0x6F22580", VA = "0x186F23180")]
	private bool DCMFKBBNJFD(BHIJDJDKPDC KJGLFNFICOA, OHIIEHHHPPI OGNMPEMNPMK, int FIDMLDAHJGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F23680", Offset = "0x6F22A80", VA = "0x186F23680")]
	private void NNLIIECJPLB(BHIJDJDKPDC KJGLFNFICOA, OHIIEHHHPPI OPEBKKAFEIH, int FIDMLDAHJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[LHBPNEDCDHJ(0)]
internal class HBEEMCLPPBB : DCDFKBONHJF
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F22980", Offset = "0x6F21D80", VA = "0x186F22980", Slot = "5")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6F22A30", Offset = "0x6F21E30", VA = "0x186F22A30", Slot = "7")]
	public override bool HCMBPJKEIIB(Type ONBHBHIHHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6F217C0", Offset = "0x6F20BC0", VA = "0x186F217C0")]
	public HBEEMCLPPBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class NHBEIDKDOOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class DKFLOGAMJGO : IEnumerable<FKGHEBGADOE>, IEnumerable, IEnumerator<FKGHEBGADOE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private FKGHEBGADOE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NHBEIDKDOOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private long <key>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private NativeMultiHashMap<long, int>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <index>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private FKGHEBGADOE System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public DKFLOGAMJGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F21DC0", Offset = "0x6F211C0", VA = "0x186F21DC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F21A50", Offset = "0x6F20E50", VA = "0x186F21A50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F21A00", Offset = "0x6F20E00", VA = "0x186F21A00")]
		private void DJGMDMALOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F21D80", Offset = "0x6F21180", VA = "0x186F21D80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F21CD0", Offset = "0x6F210D0", VA = "0x186F21CD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FKGHEBGADOE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F21CD0", Offset = "0x6F210D0", VA = "0x186F21CD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly LGJPMHDMNKE IOCLBOMOEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeMultiHashMap<long, int> BMFAMONHJBP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6F259B0", Offset = "0x6F24DB0", VA = "0x186F259B0")]
	public NHBEIDKDOOO(LGJPMHDMNKE IOCLBOMOEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6F25890", Offset = "0x6F24C90", VA = "0x186F25890")]
	[IteratorStateMachine(typeof(DKFLOGAMJGO))]
	public IEnumerable<FKGHEBGADOE> FKGNFCBMOEN(Type ONBHBHIHHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6F25850", Offset = "0x6F24C50", VA = "0x186F25850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6F25790", Offset = "0x6F24B90", VA = "0x186F25790")]
	private long DOPFPPPAMMN(FKGHEBGADOE MMNEFCOHNGA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6F25810", Offset = "0x6F24C10", VA = "0x186F25810")]
	private long DOPFPPPAMMN(Type ONBHBHIHHNE)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[EADPCOLIJKG(typeof(int))]
internal class JJCNKHADHCF : global::KJLJAOKNPAC<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6F24C70", Offset = "0x6F24070", VA = "0x186F24C70", Slot = "5")]
	public override void BNAEBMJEMFC(CBGEFOBBEBH MMNEFCOHNGA, HCEDMHJILLI KOIGCJCDPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6F24D00", Offset = "0x6F24100", VA = "0x186F24D00")]
	public JJCNKHADHCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal static class NBEMPDODLHF
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F250C0", Offset = "0x6F244C0", VA = "0x186F250C0")]
	public static void GFAHFENBHGB(Type DMAFHJOOLDP, Type FKFNHNJCBAO)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Preserve]
	internal class _RRAssemblyIndex : NKAPIKLJHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6F270C0", Offset = "0x6F264C0", VA = "0x186F270C0", Slot = "6")]
		public sealed override void HMIKMLFKAMC(DNCOCLAAHJO JGHGBFJPJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F271C0", Offset = "0x6F265C0", VA = "0x186F271C0", Slot = "4")]
		public sealed override void MEBDGDDNOCJ()
		{
		}
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
