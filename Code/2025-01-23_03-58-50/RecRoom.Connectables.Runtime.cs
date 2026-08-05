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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E88F00", Offset = "0x6E87700", VA = "0x186E88F00", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E91CC0", Offset = "0x6E904C0", VA = "0x186E91CC0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E916B0", Offset = "0x6E8FEB0", VA = "0x186E916B0")]
		private void HOKDCPPBEII(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E91820", Offset = "0x6E90020", VA = "0x186E91820")]
		private void PMABBDBBCMA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E91990", Offset = "0x6E90190", VA = "0x186E91990", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E91D00", Offset = "0x6E90500", VA = "0x186E91D00")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class MPBNCKFEMLN : EIDOFBIJODF, GOCAFABHBEB
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class LHIIFHCBAHI : IEnumerable<FCKPLGCDKOA>, IEnumerable, IEnumerator<FCKPLGCDKOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FCKPLGCDKOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private NLPICMPDONC localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NLPICMPDONC <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MPBNCKFEMLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PJJOGJFNMIM <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DLIACAMIKND.NEGOPGACECP <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FCKPLGCDKOA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAC8700", Offset = "0xAC6F00", VA = "0x180AC8700")]
		[DebuggerHidden]
		public LHIIFHCBAHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E86E80", Offset = "0x6E85680", VA = "0x186E86E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6E869A0", Offset = "0x6E851A0", VA = "0x186E869A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6E86D60", Offset = "0x6E85560", VA = "0x186E86D60")]
		private void PPNAIGJNIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6E86E30", Offset = "0x6E85630", VA = "0x186E86E30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6E86D80", Offset = "0x6E85580", VA = "0x186E86D80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FCKPLGCDKOA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6E86D80", Offset = "0x6E85580", VA = "0x186E86D80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class DNJFHFFIBCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MPBNCKFEMLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KMFGANKOFJA nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DNJFHFFIBCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E82CD0", Offset = "0x6E814D0", VA = "0x186E82CD0")]
		internal object KLBEKDIIPMD(KMFGANKOFJA x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BLONDKEDCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KMFGANKOFJA child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DNJFHFFIBCF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public BLONDKEDCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E7D370", Offset = "0x6E7BB70", VA = "0x186E7D370")]
		internal object BLFKBOJCIBL((KMFGANKOFJA child, KMFGANKOFJA nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly FICDJCDJOAA HIGDJGHCMLP;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly FICDJCDJOAA DHAEAMHFKJA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly FICDJCDJOAA BEBPFMEALOA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly FICDJCDJOAA HPCLABKGPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EAPGCLJFNAN IEFNDKBBNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private HFLAEHHBNFF NBHCIJIPGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private IMJOBFPMAKJ FFEDGNBJNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private ELHPHCOHPKN BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private JBNNPMJGKEL GFPCJBEICHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IHKONCGCMNJ AFLKPGNHIGK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LJDEGIELPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCEF4B0", Offset = "0xCEDCB0", VA = "0x180CEF4B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE1AA50", Offset = "0xE19250", VA = "0x180E1AA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DJLJLLJOEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<FCKPLGCDKOA, FCKPLGCDKOA> HHNJPLPLMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E8DE10", Offset = "0x6E8C610", VA = "0x186E8DE10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E8D3B0", Offset = "0x6E8BBB0", VA = "0x186E8D3B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<FCKPLGCDKOA, FCKPLGCDKOA> COPJBHCHMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B980", Offset = "0x6E8A180", VA = "0x186E8B980", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B820", Offset = "0x6E8A020", VA = "0x186E8B820", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<FCKPLGCDKOA, FCKPLGCDKOA, FCKPLGCDKOA> KFCJHMDKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B8D0", Offset = "0x6E8A0D0", VA = "0x186E8B8D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8F190", Offset = "0x6E8D990", VA = "0x186E8F190", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E90230", Offset = "0x6E8EA30", VA = "0x186E90230")]
	public MPBNCKFEMLN(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D460", Offset = "0x6E8BC60", VA = "0x186E8D460", Slot = "12")]
	public void EHFCOOMFLME(GameObject PBJIFBOBIOP, MPMONOPIJFJ MBJPBFMOFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D060", Offset = "0x6E8B860", VA = "0x186E8D060", Slot = "26")]
	public void DECDNNFOBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F420", Offset = "0x6E8DC20", VA = "0x186E8F420", Slot = "22")]
	public bool OIBCPEENJND(KMFGANKOFJA JLMLAIIAOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FA10", Offset = "0x6E8E210", VA = "0x186E8FA10")]
	private void PDABOOGDMLF(NLPICMPDONC GIFLOHBLNBH, NLPICMPDONC AIPJGGLJBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C350", Offset = "0x6E8AB50", VA = "0x186E8C350")]
	private void BFCKNOMIFID(NLPICMPDONC GIFLOHBLNBH, NLPICMPDONC OGLGPHJLOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E720", Offset = "0x6E8CF20", VA = "0x186E8E720")]
	private void LABGJKICPOM(NLPICMPDONC GIFLOHBLNBH, NLPICMPDONC OGLGPHJLOEA, NLPICMPDONC AIPJGGLJBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E310", Offset = "0x6E8CB10", VA = "0x186E8E310")]
	private void KDOJPMHFIBE(NLPICMPDONC GIFLOHBLNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "13")]
	public void LHNLPLKLOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C570", Offset = "0x6E8AD70", VA = "0x186E8C570", Slot = "14")]
	public void CCEDGNHHKOL(FCKPLGCDKOA EJCDAPFAAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "15")]
	public void NKAGGCHHKCB(FCKPLGCDKOA EJCDAPFAAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C180", Offset = "0x6E8A980", VA = "0x186E8C180", Slot = "17")]
	public void AOJBIMPALBP(FCKPLGCDKOA EJCDAPFAAIN, FCKPLGCDKOA OKJKGIJPCDE, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C040", Offset = "0x6E8A840", VA = "0x186E8C040")]
	public void AOJBIMPALBP(NLPICMPDONC IDCFOEBAIPD, NLPICMPDONC OKJKGIJPCDE, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DA40", Offset = "0x6E8C240", VA = "0x186E8DA40")]
	public void FJJNFJNMEPJ(FCKPLGCDKOA EJCDAPFAAIN, float KDHKEEFDLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E1C0", Offset = "0x6E8C9C0", VA = "0x186E8E1C0", Slot = "18")]
	public void JKNPNEOPAHM(FCKPLGCDKOA ACHJMLGGEOO, int KLIALMIJDBO, FCKPLGCDKOA COPIAPOLKEO, int NJKEJJIEGGG, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DAD0", Offset = "0x6E8C2D0", VA = "0x186E8DAD0")]
	private float HCFIEFMLKNO(NLPICMPDONC IDCFOEBAIPD, NLPICMPDONC NCCLECGLDAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E030", Offset = "0x6E8C830", VA = "0x186E8E030")]
	public void JKNPNEOPAHM(NLPICMPDONC IDCFOEBAIPD, NLPICMPDONC NCCLECGLDAO, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E160", Offset = "0x6E8C960", VA = "0x186E8E160")]
	public void JKNPNEOPAHM(NLPICMPDONC IDCFOEBAIPD, NLPICMPDONC NCCLECGLDAO, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG, float KDHKEEFDLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E980", Offset = "0x6E8D180", VA = "0x186E8E980", Slot = "19")]
	public void LJBBBBNIBDE(FCKPLGCDKOA EJCDAPFAAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E8ED70", Offset = "0x6E8D570", VA = "0x186E8ED70")]
	public bool LPGIMJHOHNE(NLPICMPDONC BCECCNCMCGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DC10", Offset = "0x6E8C410", VA = "0x186E8DC10", Slot = "16")]
	public void HLBOGFNBMIH(FCKPLGCDKOA EJCDAPFAAIN, HashSet<FCKPLGCDKOA> MNJPNHALMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "20")]
	public DEEAMLJIMEG LAALJIFLPPF(bool DFOPAIMFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "21")]
	public DEEAMLJIMEG FDJAPKIEPGP(HashSet<Guid> LJOAOILAIFD, bool DFOPAIMFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C2E0", Offset = "0x6E8AAE0", VA = "0x186E8C2E0", Slot = "23")]
	public void AOKJLKMKKJP(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8B7B0", Offset = "0x6E89FB0", VA = "0x186E8B7B0", Slot = "24")]
	public void AAIDIPNLCKE(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D6D0", Offset = "0x6E8BED0", VA = "0x186E8D6D0", Slot = "25")]
	public void FAEGDACFKPP(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D6F0", Offset = "0x6E8BEF0", VA = "0x186E8D6F0")]
	private void FEIMAMNMJJI(NLPICMPDONC IDCFOEBAIPD, NLPICMPDONC NCCLECGLDAO, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG, float KDHKEEFDLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C8D0", Offset = "0x6E8B0D0", VA = "0x186E8C8D0")]
	private void DDKKDIICFDF(NLPICMPDONC IDCFOEBAIPD, NLPICMPDONC FABMJJHDKOA, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D250", Offset = "0x6E8BA50", VA = "0x186E8D250")]
	private void DEGDBFOGNMC(NLPICMPDONC IDCFOEBAIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DB80", Offset = "0x6E8C380", VA = "0x186E8DB80")]
	[IteratorStateMachine(typeof(LHIIFHCBAHI))]
	public IEnumerable<FCKPLGCDKOA> HCKBBMOBLJF(NLPICMPDONC BCECCNCMCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BB70", Offset = "0x6E8A370", VA = "0x186E8BB70")]
	internal FCKPLGCDKOA AMNJDNMFINJ(NLPICMPDONC BCECCNCMCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BA30", Offset = "0x6E8A230", VA = "0x186E8BA30")]
	internal NLPICMPDONC AJLLGDKGLMM(FCKPLGCDKOA EJCDAPFAAIN)
	{
		return default(NLPICMPDONC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F470", Offset = "0x6E8DC70", VA = "0x186E8F470")]
	private bool PACIADEALOC(KMFGANKOFJA JLMLAIIAOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DEC0", Offset = "0x6E8C6C0", VA = "0x186E8DEC0")]
	private bool JBPHBBAGDGJ(KMFGANKOFJA JLMLAIIAOPK, [Out] FCKPLGCDKOA NCCLECGLDAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BCA0", Offset = "0x6E8A4A0", VA = "0x186E8BCA0")]
	private FCKPLGCDKOA AMNJDNMFINJ(KMFGANKOFJA JLMLAIIAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FF40", Offset = "0x6E8E740", VA = "0x186E8FF40")]
	private FCKPLGCDKOA PMJCBIMFLPA(KMFGANKOFJA JLMLAIIAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F240", Offset = "0x6E8DA40", VA = "0x186E8F240")]
	private FCKPLGCDKOA NCBIMLHPEBK(KMFGANKOFJA JLMLAIIAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A790", Offset = "0x6E88F90", VA = "0x186E8A790")]
	private static Guid MFODECKNHIH(KMFGANKOFJA JLMLAIIAOPK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D2C0", Offset = "0x6E8BAC0", VA = "0x186E8D2C0")]
	private string DFIGNOMJOEO(KMFGANKOFJA JLMLAIIAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F000", Offset = "0x6E8D800", VA = "0x186E8F000")]
	private void MKAMFCGIGJJ(FCKPLGCDKOA IDCFOEBAIPD, FCKPLGCDKOA FABMJJHDKOA, RigidTransform PJDIPJCPCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FDB0", Offset = "0x6E8E5B0", VA = "0x186E8FDB0")]
	private void PGKONIKLPHF(FCKPLGCDKOA FABMJJHDKOA, FCKPLGCDKOA IDCFOEBAIPD, RigidTransform PJDIPJCPCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C870", Offset = "0x6E8B070", VA = "0x186E8C870")]
	private void CJMDJOKACOE(FCKPLGCDKOA GJKNLJJHFGH, FCKPLGCDKOA IDCFOEBAIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FC20", Offset = "0x6E8E420", VA = "0x186E8FC20")]
	private void PGJILEIPBHP(FCKPLGCDKOA IDCFOEBAIPD, FCKPLGCDKOA NCCLECGLDAO, RigidTransform PJDIPJCPCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DF20", Offset = "0x6E8C720", VA = "0x186E8DF20")]
	private void JHCBNHGELBP(NLPICMPDONC BCECCNCMCGN, FCKPLGCDKOA EJCDAPFAAIN, NLPICMPDONC OGLGPHJLOEA, NLPICMPDONC AIPJGGLJBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E8EAF0", Offset = "0x6E8D2F0", VA = "0x186E8EAF0")]
	private void LLBECHEGIIE(NLPICMPDONC BCECCNCMCGN, FCKPLGCDKOA EJCDAPFAAIN, FCKPLGCDKOA EIOFFEKAEKM, FCKPLGCDKOA KACFHLBGDBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KGAMNJMHGLB
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NOFBIJBBKDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CMONJLKOOCI container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NOFBIJBBKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E903E0", Offset = "0x6E8EBE0", VA = "0x186E903E0")]
		internal MPBNCKFEMLN BJBDFPKKPDO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E867D0", Offset = "0x6E84FD0", VA = "0x186E867D0")]
	public static void HMMGOFJMKHC(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E86950", Offset = "0x6E85150", VA = "0x186E86950")]
	public static void JMELEBGIBJH(CMONJLKOOCI MFHCHOKEAIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CHKKFGBAECB : AFBLKFFOJJM, GJDNMOIDJHE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly MPBNCKFEMLN COMFDLFLAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly BJOPIKLIJEP FPIIOMMJKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FEBALIHBCFP BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly LBPNHENIGPK[] FNDDENMFGCH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FCKPLGCDKOA DOHIEHKLAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F180", Offset = "0x6E7D980", VA = "0x186E7F180", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FCKPLGCDKOA DGDFIELCFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E7D6E0", Offset = "0x6E7BEE0", VA = "0x186E7D6E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 DLPFHDCALEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E7EEB0", Offset = "0x6E7D6B0", VA = "0x186E7EEB0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion FPLNENLDLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6E7E3A0", Offset = "0x6E7CBA0", VA = "0x186E7E3A0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NDOGGNECPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6E7E2A0", Offset = "0x6E7CAA0", VA = "0x186E7E2A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<FCKPLGCDKOA> FMCKHLPNDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6E7ED80", Offset = "0x6E7D580", VA = "0x186E7ED80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool HNPDPLBPKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x997550", Offset = "0x995D50", VA = "0x180997550", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99EA30", Offset = "0x99D230", VA = "0x18099EA30", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F380", Offset = "0x6E7DB80", VA = "0x186E7F380", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject BOMBMPDPILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2937F40", Offset = "0x2936740", VA = "0x182937F40", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F0C0", Offset = "0x6E7D8C0", VA = "0x186E7F0C0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid AGEJBGIKBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F1E0", Offset = "0x6E7D9E0", VA = "0x186E7F1E0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int NJLAHPKLDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F2C0", Offset = "0x6E7DAC0", VA = "0x186E7F2C0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FMBCEDGDDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool EELOOAGEFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E7EE60", Offset = "0x6E7D660", VA = "0x186E7EE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event HNJJJKMLDBK GBHHJGNBDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E7D8A0", Offset = "0x6E7C0A0", VA = "0x186E7D8A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6E7DC40", Offset = "0x6E7C440", VA = "0x186E7DC40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HNJJJKMLDBK BOEIEKFJAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6E7EE00", Offset = "0x6E7D600", VA = "0x186E7EE00", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6E7D900", Offset = "0x6E7C100", VA = "0x186E7D900", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HNJJJKMLDBK INMPEAACHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6E7D840", Offset = "0x6E7C040", VA = "0x186E7D840", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6E7E340", Offset = "0x6E7CB40", VA = "0x186E7E340", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event NJMKPAOPJEF HMOALINJBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6E7E200", Offset = "0x6E7CA00", VA = "0x186E7E200", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6E7DEF0", Offset = "0x6E7C6F0", VA = "0x186E7DEF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E7EFC0", Offset = "0x6E7D7C0", VA = "0x186E7EFC0")]
	public CHKKFGBAECB(NLPICMPDONC JDJHDGCHHFG, RigidbodyEx MDLECLEGCKN, BJOPIKLIJEP FPIIOMMJKCL, LBPNHENIGPK[] FNDDENMFGCH, FEBALIHBCFP BIJBPNIFOLE, EIDOFBIJODF COMFDLFLAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E310", Offset = "0x6E7CB10", VA = "0x186E7E310", Slot = "19")]
	public void JNLOKBHKNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "21")]
	public void FKKGGDFFFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7A70", Offset = "0x6CA6270", VA = "0x186CA7A70", Slot = "22")]
	public void NJDPHEBIJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D690", Offset = "0x6E7BE90", VA = "0x186E7D690", Slot = "20")]
	public void CIICEFGCNDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E400", Offset = "0x6E7CC00", VA = "0x186E7E400", Slot = "25")]
	public void KOBIPIGCGHA(int GBLAELHDBMF, FCKPLGCDKOA COPIAPOLKEO, int CJINCJINACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D5C0", Offset = "0x6E7BDC0", VA = "0x186E7D5C0", Slot = "26")]
	public void BDNOEFPEDLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D960", Offset = "0x6E7C160", VA = "0x186E7D960", Slot = "27")]
	public void FKMPKCMENHF(int GBLAELHDBMF, FCKPLGCDKOA ACHJMLGGEOO, int ADFBLAFIEAG, [Optional] Vector3? PEFINJDLJNE, [Optional] Quaternion? AMDPIHMKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E7DF90", Offset = "0x6E7C790", VA = "0x186E7DF90", Slot = "28")]
	public void JFLJFDPKNHN(FCKPLGCDKOA ACHJMLGGEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E970", Offset = "0x6E7D170", VA = "0x186E7E970", Slot = "31")]
	public void MFABCACMJMJ(Vector3 NMCABKBNDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E660", Offset = "0x6E7CE60", VA = "0x186E7E660", Slot = "29")]
	public void LFENDEGBDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E010", Offset = "0x6E7C810", VA = "0x186E7E010", Slot = "30")]
	public void JILGNLPCBHK(int ECDOOAABOPD, Vector3 BJACFEPLELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E7DE20", Offset = "0x6E7C620", VA = "0x186E7DE20", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int GBLAELHDBMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E7DCF0", Offset = "0x6E7C4F0", VA = "0x186E7DCF0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int GBLAELHDBMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA3BF50", Offset = "0xA3A750", VA = "0x180A3BF50", Slot = "42")]
	public Color GetConnectionSlotColor(int GBLAELHDBMF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D7A0", Offset = "0x6E7BFA0", VA = "0x186E7D7A0", Slot = "43")]
	public bool CanConnectTo(int GBLAELHDBMF, FCKPLGCDKOA IPCJDNKAKCJ, int EMJLIHHAEEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "44")]
	public void ParentChanged(int GBLAELHDBMF, FCKPLGCDKOA AOKOOFMGKBB, int HIBHCNKPJCI, Vector3 KNGIHGABNDD, Quaternion CEAFMPNCDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "45")]
	public void ChildAdded(int GBLAELHDBMF, FCKPLGCDKOA LAFKLMFLGLH, int DKLMKCPBIMH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "46")]
	public void ChildRemoved(int GBLAELHDBMF, FCKPLGCDKOA LHINHPMHHBK, int BIFCHKCPCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "47")]
	public void ConnectionModified(int GBLAELHDBMF, FCKPLGCDKOA COPIAPOLKEO, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E7EF10", Offset = "0x6E7D710", VA = "0x186E7EF10", Slot = "48")]
	public void RootChanged(FCKPLGCDKOA HKKJCDDGPOP, FCKPLGCDKOA CAFBFIBFJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E7DCA0", Offset = "0x6E7C4A0", VA = "0x186E7DCA0", Slot = "23")]
	public void GIICLKDGKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E7EDB0", Offset = "0x6E7D5B0", VA = "0x186E7EDB0", Slot = "24")]
	public void NHELOFPNECO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E610", Offset = "0x6E7CE10", VA = "0x186E7E610")]
	private void LACGCLCHDEC(bool MDFOOOENNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(CMFELPFGCMH), new string[] { })]
public class PMJBBDCPMNK : CMFELPFGCMH, HFFMLPMNKCE, FMDAFAPAHCF
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DDJIOGMOFFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PMJBBDCPMNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public DLIACAMIKND localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DDJIOGMOFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6E82A50", Offset = "0x6E81250", VA = "0x186E82A50")]
		internal void OBHIDEDJLDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[DependsOn]
	private NGFJPJGKOCI AFFIFGJEAGI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object PIMCFEJPABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E90FF0", Offset = "0x6E8F7F0", VA = "0x186E90FF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6E90E90", Offset = "0x6E8F690", VA = "0x186E90E90", Slot = "5")]
	public void MFFLOCLFHDP(DLIACAMIKND OBBIGKIBBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E90E40", Offset = "0x6E8F640", VA = "0x186E90E40", Slot = "6")]
	private void CGBPBNNGKAA(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xD002E0", Offset = "0xCFEAE0", VA = "0x180D002E0", Slot = "7")]
	private void IIJGEHKIEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public PMJBBDCPMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(EIDOFBIJODF), new string[] { "Ignore", "Mock" })]
public class PNMBBKOLMCB : EIDOFBIJODF, GOCAFABHBEB
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LJDEGIELPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DJLJLLJOEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<FCKPLGCDKOA, FCKPLGCDKOA> HHNJPLPLMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6E913B0", Offset = "0x6E8FBB0", VA = "0x186E913B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6E91300", Offset = "0x6E8FB00", VA = "0x186E91300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<FCKPLGCDKOA, FCKPLGCDKOA> COPJBHCHMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6E91250", Offset = "0x6E8FA50", VA = "0x186E91250", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E910F0", Offset = "0x6E8F8F0", VA = "0x186E910F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<FCKPLGCDKOA, FCKPLGCDKOA, FCKPLGCDKOA> KFCJHMDKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E911A0", Offset = "0x6E8F9A0", VA = "0x186E911A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E91460", Offset = "0x6E8FC60", VA = "0x186E91460", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "26")]
	public void DECDNNFOBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "12")]
	public void EHFCOOMFLME(GameObject PBJIFBOBIOP, MPMONOPIJFJ MBJPBFMOFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "13")]
	public void LHNLPLKLOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "14")]
	public void CCEDGNHHKOL(FCKPLGCDKOA EJCDAPFAAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "15")]
	public void NKAGGCHHKCB(FCKPLGCDKOA EJCDAPFAAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "16")]
	public void HLBOGFNBMIH(FCKPLGCDKOA EJCDAPFAAIN, HashSet<FCKPLGCDKOA> MNJPNHALMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "17")]
	public void AOJBIMPALBP(FCKPLGCDKOA EJCDAPFAAIN, FCKPLGCDKOA OKJKGIJPCDE, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "18")]
	public void JKNPNEOPAHM(FCKPLGCDKOA EJCDAPFAAIN, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "19")]
	public void LJBBBBNIBDE(FCKPLGCDKOA EJCDAPFAAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "20")]
	public DEEAMLJIMEG LAALJIFLPPF(bool DFOPAIMFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "21")]
	public DEEAMLJIMEG FDJAPKIEPGP(HashSet<Guid> LJOAOILAIFD, bool DFOPAIMFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "22")]
	public bool OIBCPEENJND(KMFGANKOFJA JLMLAIIAOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "23")]
	public void AOKJLKMKKJP(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "24")]
	public void AAIDIPNLCKE(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "25")]
	public void FAEGDACFKPP(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public PNMBBKOLMCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FCKPLGCDKOA : GJDNMOIDJHE, IEquatable<FCKPLGCDKOA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GJDNMOIDJHE
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	FCKPLGCDKOA DOHIEHKLAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject BOMBMPDPILP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid AGEJBGIKBKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int NJLAHPKLDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FMBCEDGDDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int GBLAELHDBMF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int GBLAELHDBMF);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int GBLAELHDBMF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int GBLAELHDBMF, FCKPLGCDKOA IPCJDNKAKCJ, int KGBJEIKFHMD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int GBLAELHDBMF, FCKPLGCDKOA AOKOOFMGKBB, int HIBHCNKPJCI, Vector3 KNGIHGABNDD, Quaternion CEAFMPNCDOO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int GBLAELHDBMF, FCKPLGCDKOA LAFKLMFLGLH, int DKLMKCPBIMH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int GBLAELHDBMF, FCKPLGCDKOA LHINHPMHHBK, int BIFCHKCPCJP);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int GBLAELHDBMF, FCKPLGCDKOA COPIAPOLKEO, int GEKOENDEBLG, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(FCKPLGCDKOA HKKJCDDGPOP, FCKPLGCDKOA CAFBFIBFJEF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EIDOFBIJODF : GOCAFABHBEB
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LJDEGIELPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DJLJLLJOEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FCKPLGCDKOA, FCKPLGCDKOA> HHNJPLPLMNI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<FCKPLGCDKOA, FCKPLGCDKOA> COPJBHCHMKF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<FCKPLGCDKOA, FCKPLGCDKOA, FCKPLGCDKOA> KFCJHMDKDNM;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EHFCOOMFLME(GameObject PBJIFBOBIOP, MPMONOPIJFJ MBJPBFMOFDE);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LHNLPLKLOMD();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CCEDGNHHKOL(FCKPLGCDKOA EJCDAPFAAIN);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NKAGGCHHKCB(FCKPLGCDKOA EJCDAPFAAIN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HLBOGFNBMIH(FCKPLGCDKOA EJCDAPFAAIN, HashSet<FCKPLGCDKOA> MNJPNHALMNB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AOJBIMPALBP(FCKPLGCDKOA EJCDAPFAAIN, FCKPLGCDKOA OKJKGIJPCDE, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JKNPNEOPAHM(FCKPLGCDKOA EJCDAPFAAIN, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LJBBBBNIBDE(FCKPLGCDKOA EJCDAPFAAIN);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DEEAMLJIMEG LAALJIFLPPF(bool DFOPAIMFFIM);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DEEAMLJIMEG FDJAPKIEPGP(HashSet<Guid> LJOAOILAIFD, bool DFOPAIMFFIM);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OIBCPEENJND(KMFGANKOFJA JLMLAIIAOPK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void AOKJLKMKKJP(DEEAMLJIMEG KALPAHICNIE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AAIDIPNLCKE(DEEAMLJIMEG KALPAHICNIE);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FAEGDACFKPP(DEEAMLJIMEG KALPAHICNIE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ELHPHCOHPKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool ILEJCAKOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FCKPLGCDKOA NCBIMLHPEBK(int NDLPIBBIODB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FCKPLGCDKOA PMJCBIMFLPA(Guid LPDPCJIBBPH);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FOLOOKMHPLI(FCKPLGCDKOA EJCDAPFAAIN);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NDDFEMHMGPK();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EMKNKGOKIMK(FCKPLGCDKOA FPIIOMMJKCL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface FEBALIHBCFP
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EELOOAGEFJJ(BJOPIKLIJEP FPIIOMMJKCL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LJBMKELCPPP(BJOPIKLIJEP FPIIOMMJKCL);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string AKJIHCHPLGO(BJOPIKLIJEP FPIIOMMJKCL);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PGKBHBIAGIF(BJOPIKLIJEP FPIIOMMJKCL);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BJBCCLLDOJO(BJOPIKLIJEP FPIIOMMJKCL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LDBKPHIGNCK(BJOPIKLIJEP FPIIOMMJKCL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void HNJJJKMLDBK(FCKPLGCDKOA ACHJMLGGEOO, int ADBPJLLANBL, FCKPLGCDKOA COPIAPOLKEO, int CPOAFNKMKAJ, [Optional] Vector3? PEFINJDLJNE, [Optional] Quaternion? AMDPIHMKEKI);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void NJMKPAOPJEF(FCKPLGCDKOA HKKJCDDGPOP, FCKPLGCDKOA CAFBFIBFJEF);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BJOPIKLIJEP : FCKPLGCDKOA, GJDNMOIDJHE, IEquatable<FCKPLGCDKOA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AFBLKFFOJJM : GJDNMOIDJHE
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FCKPLGCDKOA DGDFIELCFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<FCKPLGCDKOA> FMCKHLPNDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 DLPFHDCALEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion FPLNENLDLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool NDOGGNECPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool HNPDPLBPKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event HNJJJKMLDBK GBHHJGNBDDO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event HNJJJKMLDBK BOEIEKFJAFA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HNJJJKMLDBK INMPEAACHCG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event NJMKPAOPJEF HMOALINJBLE;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JNLOKBHKNIB();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CIICEFGCNDO();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FKKGGDFFFOF();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NJDPHEBIJJI();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GIICLKDGKKB();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NHELOFPNECO();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KOBIPIGCGHA(int GBLAELHDBMF, FCKPLGCDKOA COPIAPOLKEO, int CJINCJINACH);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BDNOEFPEDLG();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void FKMPKCMENHF(int GBLAELHDBMF, FCKPLGCDKOA ACHJMLGGEOO, int ADFBLAFIEAG, [Optional] Vector3? PEFINJDLJNE, [Optional] Quaternion? AMDPIHMKEKI);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JFLJFDPKNHN(FCKPLGCDKOA ACHJMLGGEOO);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LFENDEGBDDG();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JILGNLPCBHK(int ECDOOAABOPD, Vector3 BJACFEPLELN);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MFABCACMJMJ(Vector3 NMCABKBNDAF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LBPNHENIGPK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 DPKFGIMGJBE
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
public interface MPMONOPIJFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MPOILIFPGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LPCGAPKHGAE PCAJFDMODCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, MPMONOPIJFJ
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
			[Cpp2IlInjected.Address(RVA = "0x9575D0", Offset = "0x955DD0", VA = "0x1809575D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public LPCGAPKHGAE LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E82940", Offset = "0x6E81140", VA = "0x186E82940")]
		public static ConnectableConfigData GKFNAOJFPFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E82A00", Offset = "0x6E81200", VA = "0x186E82A00")]
		public ConnectableConfigData(LegacyConnectableLinkVisual OPGMFMOHLHM, bool ADLGAIDBDDB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PMFPPOOGCCA : IEquatable<PMFPPOOGCCA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public FCKPLGCDKOA EJCDAPFAAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int LKLDCOOMHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int GEKOENDEBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 PEFINJDLJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion AMDPIHMKEKI;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6E90D50", Offset = "0x6E8F550", VA = "0x186E90D50")]
	public PMFPPOOGCCA(FCKPLGCDKOA EJCDAPFAAIN, int LKLDCOOMHLD, int GEKOENDEBLG, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6E90CB0", Offset = "0x6E8F4B0", VA = "0x186E90CB0")]
	public PMFPPOOGCCA(FCKPLGCDKOA EJCDAPFAAIN, int LKLDCOOMHLD, int GEKOENDEBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6E90DB0", Offset = "0x6E8F5B0", VA = "0x186E90DB0")]
	public PMFPPOOGCCA(FCKPLGCDKOA EJCDAPFAAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E90840", Offset = "0x6E8F040", VA = "0x186E90840", Slot = "4")]
	public bool Equals(PMFPPOOGCCA LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E908F0", Offset = "0x6E8F0F0", VA = "0x186E908F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class OBKBGMCKDGO : FCLMIFJOGJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform NBEDBEKEEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private LPCGAPKHGAE NCIGOFEFICK;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x690F970", Offset = "0x690E170", VA = "0x18690F970", Slot = "4")]
	public void EHFCOOMFLME(Transform NBEDBEKEEBM, LPCGAPKHGAE NCIGOFEFICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6E90500", Offset = "0x6E8ED00", VA = "0x186E90500", Slot = "5")]
	public LPCGAPKHGAE POMMJHDNDMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6E90490", Offset = "0x6E8EC90", VA = "0x186E90490", Slot = "6")]
	public void FALDNEOANLI(LPCGAPKHGAE BOEKLGBANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public OBKBGMCKDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class CNIFFHGMGLO : IDisposable, ADBMECELNCD
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DIJOCNCDMGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public FCKPLGCDKOA oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public FCKPLGCDKOA newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DIJOCNCDMGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6E82B40", Offset = "0x6E81340", VA = "0x186E82B40")]
		internal bool FDKHKIGGJIB(ALCJJLJPHNN node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly EPPBLMLFKIF NJDLACPEENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private GJDHBBGPMBA MJNEMAJHOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private HOIOFJNLOCB PJDPDJMKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool ADLGAIDBDDB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly FICDJCDJOAA HLCNMCAIDGA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public ALCJJLJPHNN JJAKCGIGEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6E82010", Offset = "0x6E80810", VA = "0x186E82010")]
	public bool MAGDNHPKKFC([In] NNFPCJHHEPB EBNFOODJNOB, bool MJGMHGBGFOO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E7FA00", Offset = "0x6E7E200", VA = "0x186E7FA00")]
	private bool CKGHADGDKPN([In] NNFPCJHHEPB EBNFOODJNOB, bool MJGMHGBGFOO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6E82770", Offset = "0x6E80F70", VA = "0x186E82770")]
	public CNIFFHGMGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6E80260", Offset = "0x6E7EA60", VA = "0x186E80260", Slot = "5")]
	public void EHFCOOMFLME(EIDOFBIJODF JIPBFCNFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6E80310", Offset = "0x6E7EB10", VA = "0x186E80310", Slot = "17")]
	public void EJLDNHKEONK(AFKOKODCFMC KNMHMBJIFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F750", Offset = "0x6E7DF50", VA = "0x186E7F750", Slot = "12")]
	public void BNALNEPKBHM(Func<FCKPLGCDKOA, bool> IEKJBMGMBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F620", Offset = "0x6E7DE20", VA = "0x186E7F620")]
	private void BNALNEPKBHM(EPPBLMLFKIF JLFLGGOOAGI, Func<FCKPLGCDKOA, bool> IEKJBMGMBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6E7FFC0", Offset = "0x6E7E7C0", VA = "0x186E7FFC0", Slot = "11")]
	public void DBGCFBGAOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6E80FC0", Offset = "0x6E7F7C0", VA = "0x186E80FC0", Slot = "8")]
	public bool GMILNPCLMEL(FCKPLGCDKOA LAHKLAKLACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6E80340", Offset = "0x6E7EB40", VA = "0x186E80340")]
	private bool FMAHNGBHOOO(FCKPLGCDKOA NMEOHPFJEFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E82140", Offset = "0x6E80940", VA = "0x186E82140")]
	private static bool MPLHABEBHAE(FCKPLGCDKOA NMEOHPFJEFK, EPPBLMLFKIF JDLLHCCAABM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6E80BE0", Offset = "0x6E7F3E0", VA = "0x186E80BE0")]
	private void GJANFIBEPEA(Transform KEHNJFIJOAE, EPPBLMLFKIF IFEADEFMCGO, EPPBLMLFKIF[] JBBHIMGCKJH, FCKPLGCDKOA IMDKMPJEFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F3A0", Offset = "0x6E7DBA0", VA = "0x186E7F3A0")]
	private PMFPPOOGCCA ADJJOHMINIB(Transform EPLKBGFDKCN, PMFPPOOGCCA EHLDPCFJBND)
	{
		return default(PMFPPOOGCCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E824E0", Offset = "0x6E80CE0", VA = "0x186E824E0")]
	private static bool PODEHODJAAK(EPPBLMLFKIF JDLLHCCAABM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E821F0", Offset = "0x6E809F0", VA = "0x186E821F0", Slot = "9")]
	public bool NGILONCMMMD(FCKPLGCDKOA KCNOPLIGPGJ, int ADFBLAFIEAG, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E80930", Offset = "0x6E7F130", VA = "0x186E80930")]
	private bool GAFCMPEPALE(FCKPLGCDKOA KCNOPLIGPGJ, int ADFBLAFIEAG, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E81910", Offset = "0x6E80110", VA = "0x186E81910")]
	private static void IDFHKEEOPCL(FCKPLGCDKOA KCNOPLIGPGJ, int ADFBLAFIEAG, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI, EPPBLMLFKIF MEMEPDKMLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E82020", Offset = "0x6E80820", VA = "0x186E82020")]
	private void MKAMFCGIGJJ(FCKPLGCDKOA PMAJFDOHJGP, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E801B0", Offset = "0x6E7E9B0", VA = "0x186E801B0")]
	private void DINCFDFILHD(EPPBLMLFKIF JLFLGGOOAGI, FCKPLGCDKOA EIOFFEKAEKM, FCKPLGCDKOA KACFHLBGDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6E80140", Offset = "0x6E7E940", VA = "0x186E80140")]
	private void DINCFDFILHD(FCKPLGCDKOA EJCDAPFAAIN, FCKPLGCDKOA EIOFFEKAEKM, FCKPLGCDKOA KACFHLBGDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6E81EA0", Offset = "0x6E806A0", VA = "0x186E81EA0")]
	private void LLBECHEGIIE(FCKPLGCDKOA EJCDAPFAAIN, FCKPLGCDKOA EIOFFEKAEKM, FCKPLGCDKOA KACFHLBGDBO, bool KKPELIFONII = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E81F10", Offset = "0x6E80710", VA = "0x186E81F10")]
	private void LLBECHEGIIE(EPPBLMLFKIF KAMAKIBPPKG, FCKPLGCDKOA IMDKMPJEFDF, FCKPLGCDKOA CAFBFIBFJEF, bool KKPELIFONII = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6E823C0", Offset = "0x6E80BC0", VA = "0x186E823C0")]
	private void PGKONIKLPHF(FCKPLGCDKOA IDCFOEBAIPD, int ADFBLAFIEAG, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F830", Offset = "0x6E7E030", VA = "0x186E7F830")]
	private void CJMDJOKACOE(ALCJJLJPHNN NCCLECGLDAO, ALCJJLJPHNN DDKCCGPCBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E7FFE0", Offset = "0x6E7E7E0", VA = "0x186E7FFE0", Slot = "18")]
	public FCKPLGCDKOA DHKCJLCNOIC(FCKPLGCDKOA EJCDAPFAAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6E80FD0", Offset = "0x6E7F7D0", VA = "0x186E80FD0", Slot = "13")]
	public void HLBOGFNBMIH(FCKPLGCDKOA EJCDAPFAAIN, HashSet<FCKPLGCDKOA> EBKMKANPPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6E81B50", Offset = "0x6E80350", VA = "0x186E81B50", Slot = "14")]
	public List<FCKPLGCDKOA> JJNBADLDGIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F760", Offset = "0x6E7DF60", VA = "0x186E7F760")]
	protected ALCJJLJPHNN BOJMHKEDJKA(ALCJJLJPHNN JLFLGGOOAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E82320", Offset = "0x6E80B20", VA = "0x186E82320")]
	protected EPPBLMLFKIF[] OELCNNLHOLA(EPPBLMLFKIF JDLLHCCAABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E81D90", Offset = "0x6E80590", VA = "0x186E81D90")]
	protected bool KOPDLODFOHF(FCKPLGCDKOA EJCDAPFAAIN, [Out] EPPBLMLFKIF JLFLGGOOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F4F0", Offset = "0x6E7DCF0", VA = "0x186E7F4F0", Slot = "15")]
	public bool BIOPAIEFFNH(FCKPLGCDKOA EJCDAPFAAIN, [Out] PMFPPOOGCCA NKIKEHJLLPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E80220", Offset = "0x6E7EA20", VA = "0x186E80220")]
	protected EPPBLMLFKIF EFAHEMLFAAB(PMFPPOOGCCA IJMKJJCBGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6E81AF0", Offset = "0x6E802F0", VA = "0x186E81AF0", Slot = "10")]
	public bool INNCFLNMPFI(FCKPLGCDKOA PMAJFDOHJGP, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E81380", Offset = "0x6E7FB80", VA = "0x186E81380")]
	private bool ICJKHPLBPLA(FCKPLGCDKOA PMAJFDOHJGP, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6E82250", Offset = "0x6E80A50", VA = "0x186E82250")]
	private static bool NPECFHPJCHL(EPPBLMLFKIF NLCJOIDCAAJ, PMFPPOOGCCA FNNOECGAIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6E82010", Offset = "0x6E80810", VA = "0x186E82010", Slot = "7")]
	private bool OBGEHCBDJME([In] NNFPCJHHEPB EBNFOODJNOB, bool MJGMHGBGFOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class KFAGPBLLNEF : EIDOFBIJODF, GOCAFABHBEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly CMONJLKOOCI MFHCHOKEAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly HOIOFJNLOCB PJDPDJMKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly BJCPGMNEAAN NEFGNNEJBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly MNPNGCNLIGA BJJGHAKKELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly ADBMECELNCD KALPAHICNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal DMKPFDEIAKJ BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal PLHAJBMCKDI GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal GJDHBBGPMBA DHIEJEKCKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool ADLGAIDBDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool LBAHMCPMGJI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool IAKCJMCHHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xCEF370", Offset = "0xCEDB70", VA = "0x180CEF370")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xE044C0", Offset = "0xE02CC0", VA = "0x180E044C0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LJDEGIELPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xCEF360", Offset = "0xCEDB60", VA = "0x180CEF360", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1EE9A80", Offset = "0x1EE8280", VA = "0x181EE9A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool DJLJLLJOEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<FCKPLGCDKOA, FCKPLGCDKOA> HHNJPLPLMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6E85910", Offset = "0x6E84110", VA = "0x186E85910", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6E84F30", Offset = "0x6E83730", VA = "0x186E84F30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<FCKPLGCDKOA, FCKPLGCDKOA> COPJBHCHMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6E84870", Offset = "0x6E83070", VA = "0x186E84870", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6E847B0", Offset = "0x6E82FB0", VA = "0x186E847B0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<FCKPLGCDKOA, FCKPLGCDKOA, FCKPLGCDKOA> KFCJHMDKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6E84810", Offset = "0x6E83010", VA = "0x186E84810", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6E85E70", Offset = "0x6E84670", VA = "0x186E85E70", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6E863E0", Offset = "0x6E84BE0", VA = "0x186E863E0")]
	public KFAGPBLLNEF(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6E84FF0", Offset = "0x6E837F0", VA = "0x186E84FF0", Slot = "12")]
	public void EHFCOOMFLME(GameObject PBJIFBOBIOP, MPMONOPIJFJ MBJPBFMOFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6E84C50", Offset = "0x6E83450", VA = "0x186E84C50", Slot = "26")]
	public void DECDNNFOBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6E85C30", Offset = "0x6E84430", VA = "0x186E85C30", Slot = "13")]
	public void LHNLPLKLOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6E84B70", Offset = "0x6E83370", VA = "0x186E84B70", Slot = "14")]
	public void CCEDGNHHKOL(FCKPLGCDKOA EJCDAPFAAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6E84F90", Offset = "0x6E83790", VA = "0x186E84F90", Slot = "15")]
	public void NKAGGCHHKCB(FCKPLGCDKOA EJCDAPFAAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E86110", Offset = "0x6E84910", VA = "0x186E86110", Slot = "22")]
	public bool OIBCPEENJND(KMFGANKOFJA JLMLAIIAOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6E84B90", Offset = "0x6E83390", VA = "0x186E84B90")]
	internal bool CKGHADGDKPN([In] NNFPCJHHEPB EBNFOODJNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6E85880", Offset = "0x6E84080", VA = "0x186E85880")]
	internal bool ICJKHPLBPLA([In] NNFPCJHHEPB EBNFOODJNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6E85ED0", Offset = "0x6E846D0", VA = "0x186E85ED0")]
	internal bool NMJPELADCBG([In] NNFPCJHHEPB EBNFOODJNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6E86160", Offset = "0x6E84960", VA = "0x186E86160")]
	internal bool OOANKOJNJOE([In] NNFPCJHHEPB EBNFOODJNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6E85F30", Offset = "0x6E84730", VA = "0x186E85F30")]
	internal void OBILPJGCCBC(FCKPLGCDKOA EJCDAPFAAIN, int MEBGPJDPJLP, bool MJGMHGBGFOO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6E84F90", Offset = "0x6E83790", VA = "0x186E84F90")]
	internal bool EGJEMGDEBFG(FCKPLGCDKOA KBGDKHDOHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6E862B0", Offset = "0x6E84AB0", VA = "0x186E862B0")]
	internal bool POFOBFLJMBB(FCKPLGCDKOA KCNOPLIGPGJ, int ADFBLAFIEAG, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6E85790", Offset = "0x6E83F90", VA = "0x186E85790", Slot = "16")]
	public void HLBOGFNBMIH(FCKPLGCDKOA EJCDAPFAAIN, HashSet<FCKPLGCDKOA> MNJPNHALMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6E848D0", Offset = "0x6E830D0", VA = "0x186E848D0", Slot = "17")]
	public void AOJBIMPALBP(FCKPLGCDKOA KCNOPLIGPGJ, FCKPLGCDKOA OKJKGIJPCDE, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6E85970", Offset = "0x6E84170", VA = "0x186E85970", Slot = "18")]
	public void JKNPNEOPAHM(FCKPLGCDKOA PMAJFDOHJGP, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6E85CB0", Offset = "0x6E844B0", VA = "0x186E85CB0", Slot = "19")]
	public void LJBBBBNIBDE(FCKPLGCDKOA PMAJFDOHJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6E84CF0", Offset = "0x6E834F0", VA = "0x186E84CF0")]
	public void DHONPBGBDCB([Optional] CMNIABPOENF KBCFGEJLMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6E84AE0", Offset = "0x6E832E0", VA = "0x186E84AE0", Slot = "23")]
	public void AOKJLKMKKJP(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6E85AB0", Offset = "0x6E842B0", VA = "0x186E85AB0", Slot = "20")]
	public DEEAMLJIMEG LAALJIFLPPF(bool DFOPAIMFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6E855F0", Offset = "0x6E83DF0", VA = "0x186E855F0", Slot = "21")]
	public DEEAMLJIMEG FDJAPKIEPGP(HashSet<Guid> LJOAOILAIFD, bool DFOPAIMFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6E855B0", Offset = "0x6E83DB0", VA = "0x186E855B0", Slot = "25")]
	public void FAEGDACFKPP(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6E84700", Offset = "0x6E82F00", VA = "0x186E84700", Slot = "24")]
	public void AAIDIPNLCKE(DEEAMLJIMEG KALPAHICNIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class HOIOFJNLOCB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly BHNOANLGPMK<FCKPLGCDKOA, FCKPLGCDKOA> HHNJPLPLMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly BHNOANLGPMK<FCKPLGCDKOA, FCKPLGCDKOA> COPJBHCHMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly IDHKLCOGGHN<FCKPLGCDKOA, FCKPLGCDKOA, FCKPLGCDKOA> KFCJHMDKDNM;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6E845E0", Offset = "0x6E82DE0", VA = "0x186E845E0")]
	public HOIOFJNLOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	public void EHFCOOMFLME(KFAGPBLLNEF JIPBFCNFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6E84580", Offset = "0x6E82D80", VA = "0x186E84580")]
	public void OCHOKHBCIMN(FCKPLGCDKOA NCCLECGLDAO, FCKPLGCDKOA IDCFOEBAIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6E84520", Offset = "0x6E82D20", VA = "0x186E84520")]
	public void DCGJCBMLOAM(FCKPLGCDKOA NCCLECGLDAO, FCKPLGCDKOA IDCFOEBAIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6E844A0", Offset = "0x6E82CA0", VA = "0x186E844A0")]
	public void DBCPADLHFFE(FCKPLGCDKOA GJKNLJJHFGH, FCKPLGCDKOA FABMJJHDKOA, FCKPLGCDKOA IDCFOEBAIPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class BJCPGMNEAAN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private KFAGPBLLNEF JIPBFCNFKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private PLHAJBMCKDI GPBNDJAMPKD;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public BJCPGMNEAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D020", Offset = "0x6E7B820", VA = "0x186E7D020")]
	public void EHFCOOMFLME(KFAGPBLLNEF JIPBFCNFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D010", Offset = "0x6E7B810", VA = "0x186E7D010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D150", Offset = "0x6E7B950", VA = "0x186E7D150")]
	private void FMNBGIEBKJA(CMNIABPOENF FGIHDJGGIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6E7CFA0", Offset = "0x6E7B7A0", VA = "0x186E7CFA0")]
	private void AMOCINDBBJF(CMNIABPOENF HGDGDJOJLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D170", Offset = "0x6E7B970", VA = "0x186E7D170")]
	public void JBFKOCKBLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D270", Offset = "0x6E7BA70", VA = "0x186E7D270")]
	public void LJPNPHJIKDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class OIFEOOIGHJE
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BCNEENEGAGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CMONJLKOOCI container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public BCNEENEGAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6E7C060", Offset = "0x6E7A860", VA = "0x186E7C060")]
		internal KFAGPBLLNEF BJBDFPKKPDO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6E905C0", Offset = "0x6E8EDC0", VA = "0x186E905C0")]
	public static void HMMGOFJMKHC(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6E907C0", Offset = "0x6E8EFC0", VA = "0x186E907C0")]
	public static void JMELEBGIBJH(CMONJLKOOCI MFHCHOKEAIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class BEMGHCPBOAJ : IDisposable, GJDHBBGPMBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, LPCGAPKHGAE> BLJEJCGMLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AFKOKODCFMC JCOGMHFEHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private FCLMIFJOGJK FMMIBJNHACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private ADBMECELNCD KALPAHICNIE;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker PLPKKGCEFFJ;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6E7CEC0", Offset = "0x6E7B6C0", VA = "0x186E7CEC0")]
	public BEMGHCPBOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6E7C410", Offset = "0x6E7AC10", VA = "0x186E7C410", Slot = "7")]
	public void EHFCOOMFLME(ADBMECELNCD KALPAHICNIE, FCLMIFJOGJK FMMIBJNHACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6E7C850", Offset = "0x6E7B050", VA = "0x186E7C850", Slot = "5")]
	public void LMPDOPPNJMP(ALCJJLJPHNN EEFOABEEPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6E7CC20", Offset = "0x6E7B420", VA = "0x186E7CC20", Slot = "9")]
	public void PBEPFBINENJ(ALCJJLJPHNN CHDFFNLKHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6E7C250", Offset = "0x6E7AA50", VA = "0x186E7C250", Slot = "8")]
	public void CADLGPJEIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6E7C450", Offset = "0x6E7AC50", VA = "0x186E7C450", Slot = "10")]
	public void FJCBCMCAMGO(ALCJJLJPHNN DEHNGOFCBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6E7C0D0", Offset = "0x6E7A8D0", VA = "0x186E7C0D0", Slot = "11")]
	public void AMCBJLGCDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6E7C6A0", Offset = "0x6E7AEA0", VA = "0x186E7C6A0")]
	private bool KELDNOFHNPG(ALCJJLJPHNN JOADBJGEHIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class MNPNGCNLIGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct EBELELGPDFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly EPPBLMLFKIF GNIGDOBIMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> LJOAOILAIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly KMFGANKOFJA FADFMHPKMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly KMFGANKOFJA NNAFEPHCAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool DFOPAIMFFIM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool PDABKLHEGDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6E83330", Offset = "0x6E81B30", VA = "0x186E83330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6E83600", Offset = "0x6E81E00", VA = "0x186E83600")]
		public EBELELGPDFB(EPPBLMLFKIF GNIGDOBIMHF, HashSet<Guid> LJOAOILAIFD, bool DFOPAIMFFIM, [Optional] KMFGANKOFJA FADFMHPKMLD, [Optional] KMFGANKOFJA NNAFEPHCAEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6E83190", Offset = "0x6E81990", VA = "0x186E83190")]
		public KMFGANKOFJA KBGBIJFEDIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6E82EB0", Offset = "0x6E816B0", VA = "0x186E82EB0")]
		private KMFGANKOFJA ECOKDMEFMLF([Out] KMFGANKOFJA GNEALLOLNLI, [Out] KMFGANKOFJA NMELDLGIILD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6E82F70", Offset = "0x6E81770", VA = "0x186E82F70")]
		private KMFGANKOFJA EMDOFMFJGNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6E82D40", Offset = "0x6E81540", VA = "0x186E82D40")]
		private void CGOGEHAGKFN(KMFGANKOFJA FBILAKLBKOE, KMFGANKOFJA GMNKAEKMADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6E83440", Offset = "0x6E81C40", VA = "0x186E83440")]
		private void PAPFKEEBEBE(KMFGANKOFJA GNEALLOLNLI, KMFGANKOFJA NMELDLGIILD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private KFAGPBLLNEF JIPBFCNFKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private ADBMECELNCD KALPAHICNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GJDHBBGPMBA MJNEMAJHOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private PLHAJBMCKDI GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool KMHNOLMELOF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool DLBJPOGPMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B4D0", Offset = "0x6E89CD0", VA = "0x186E8B4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool IAKCJMCHHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6E896E0", Offset = "0x6E87EE0", VA = "0x186E896E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6E89EF0", Offset = "0x6E886F0", VA = "0x186E89EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6E89BC0", Offset = "0x6E883C0", VA = "0x186E89BC0")]
	public void EHFCOOMFLME(KFAGPBLLNEF JIPBFCNFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A620", Offset = "0x6E88E20", VA = "0x186E8A620")]
	public DEEAMLJIMEG LAALJIFLPPF(bool DFOPAIMFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6E89F10", Offset = "0x6E88710", VA = "0x186E89F10")]
	public DEEAMLJIMEG FDJAPKIEPGP(HashSet<Guid> LJOAOILAIFD, bool DFOPAIMFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6E894C0", Offset = "0x6E87CC0", VA = "0x186E894C0")]
	public void AOKJLKMKKJP(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6E890A0", Offset = "0x6E878A0", VA = "0x186E890A0")]
	public void AAIDIPNLCKE(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6E89490", Offset = "0x6E87C90", VA = "0x186E89490")]
	public void AOGOJELJIDP(DEEAMLJIMEG KALPAHICNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6E89700", Offset = "0x6E87F00", VA = "0x186E89700")]
	private void DEPNAMOPJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A0B0", Offset = "0x6E888B0", VA = "0x186E8A0B0")]
	private KMFGANKOFJA FPPIPEDGIMA(EPPBLMLFKIF JLFLGGOOAGI, bool DFOPAIMFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A2C0", Offset = "0x6E88AC0", VA = "0x186E8A2C0")]
	private static void JDMEAHEGAEJ(EPPBLMLFKIF JLFLGGOOAGI, bool DFOPAIMFFIM, KMFGANKOFJA JLMLAIIAOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6E8B520", Offset = "0x6E89D20", VA = "0x186E8B520")]
	private void PFBACCLMKEF(EPPBLMLFKIF JLFLGGOOAGI, bool DFOPAIMFFIM, KMFGANKOFJA JLMLAIIAOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A570", Offset = "0x6E88D70", VA = "0x186E8A570")]
	private KMFGANKOFJA JLJNGHPMEII(EPPBLMLFKIF GNIGDOBIMHF, HashSet<Guid> LJOAOILAIFD, bool DFOPAIMFFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A950", Offset = "0x6E89150", VA = "0x186E8A950")]
	private bool NLNGDCHHJJA(DEEAMLJIMEG NKOAOFFBAPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6E8AE60", Offset = "0x6E89660", VA = "0x186E8AE60")]
	private bool PACIADEALOC(KMFGANKOFJA JLMLAIIAOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A600", Offset = "0x6E88E00", VA = "0x186E8A600")]
	private bool KPDGINFPGID(DEEAMLJIMEG KALPAHICNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A1A0", Offset = "0x6E889A0", VA = "0x186E8A1A0")]
	private static bool GAMKLJNPPFC(KMFGANKOFJA JLMLAIIAOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6E8ABD0", Offset = "0x6E893D0", VA = "0x186E8ABD0")]
	public static bool OIBCPEENJND(KMFGANKOFJA JLMLAIIAOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6E89140", Offset = "0x6E87940", VA = "0x186E89140")]
	private FCKPLGCDKOA AMNJDNMFINJ(KMFGANKOFJA JLMLAIIAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A7D0", Offset = "0x6E88FD0", VA = "0x186E8A7D0")]
	private FCKPLGCDKOA NCBIMLHPEBK(KMFGANKOFJA JLMLAIIAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6E89550", Offset = "0x6E87D50", VA = "0x186E89550")]
	private FCKPLGCDKOA COMEAINLEGB(KMFGANKOFJA JLMLAIIAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A790", Offset = "0x6E88F90", VA = "0x186E8A790")]
	private static Guid MFODECKNHIH(KMFGANKOFJA JLMLAIIAOPK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6E898E0", Offset = "0x6E880E0", VA = "0x186E898E0")]
	private string DFIGNOMJOEO(KMFGANKOFJA JLMLAIIAOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6E899D0", Offset = "0x6E881D0", VA = "0x186E899D0")]
	private bool DOPGNONGINH(EPPBLMLFKIF JLFLGGOOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6E89C30", Offset = "0x6E88430", VA = "0x186E89C30")]
	private static void EKPNIBJAELE(EPPBLMLFKIF GNIGDOBIMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public MNPNGCNLIGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct NNFPCJHHEPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public FCKPLGCDKOA IDCFOEBAIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FCKPLGCDKOA NCCLECGLDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int ADFBLAFIEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int CJINCJINACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 PEFINJDLJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion AMDPIHMKEKI;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public PMFPPOOGCCA JKJLMEOJNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6E902A0", Offset = "0x6E8EAA0", VA = "0x186E902A0")]
		get
		{
			return default(PMFPPOOGCCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PMFPPOOGCCA BMFBLJFBALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6E90340", Offset = "0x6E8EB40", VA = "0x186E90340")]
		get
		{
			return default(PMFPPOOGCCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6E90370", Offset = "0x6E8EB70", VA = "0x186E90370")]
	public NNFPCJHHEPB(FCKPLGCDKOA IDCFOEBAIPD, FCKPLGCDKOA NCCLECGLDAO, int ADFBLAFIEAG, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface ADBMECELNCD
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	ALCJJLJPHNN JJAKCGIGEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHFCOOMFLME(EIDOFBIJODF JIPBFCNFKIF);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MAGDNHPKKFC([In] NNFPCJHHEPB EBNFOODJNOB, bool MJGMHGBGFOO = true);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GMILNPCLMEL(FCKPLGCDKOA LAHKLAKLACM);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NGILONCMMMD(FCKPLGCDKOA KCNOPLIGPGJ, int ADFBLAFIEAG, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool INNCFLNMPFI(FCKPLGCDKOA PMAJFDOHJGP, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DBGCFBGAOKF();

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BNALNEPKBHM(Func<FCKPLGCDKOA, bool> IEKJBMGMBGN);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HLBOGFNBMIH(FCKPLGCDKOA EJCDAPFAAIN, HashSet<FCKPLGCDKOA> EBKMKANPPKK);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<FCKPLGCDKOA> JJNBADLDGIJ();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BIOPAIEFFNH(FCKPLGCDKOA EJCDAPFAAIN, [Out] PMFPPOOGCCA NKIKEHJLLPF);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EJLDNHKEONK(AFKOKODCFMC KNMHMBJIFMM);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool AFKOKODCFMC(ALCJJLJPHNN JLFLGGOOAGI);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface ALCJJLJPHNN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	FCKPLGCDKOA OELEIAKGHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	ALCJJLJPHNN MHMOKMJDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PMFPPOOGCCA GDCGFHNGEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool NAODAHJBDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LPCGAPKHGAE : LKFAFMPBBDO.MBEABKOEJJC
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDJJIOLOFEI(FCKPLGCDKOA COPIAPOLKEO, PMFPPOOGCCA IDCFOEBAIPD);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAKIPFFAABL(FCKPLGCDKOA COPIAPOLKEO, PMFPPOOGCCA IDCFOEBAIPD);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOAPBINPFEP(FCKPLGCDKOA COPIAPOLKEO, PMFPPOOGCCA IDCFOEBAIPD);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PCOFOKKGIJD(FCKPLGCDKOA COPIAPOLKEO, PMFPPOOGCCA IDCFOEBAIPD);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LPCGAPKHGAE Instantiate(Transform NBEDBEKEEBM);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ANFLKJPBFFP();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FCLMIFJOGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHFCOOMFLME(Transform NBEDBEKEEBM, LPCGAPKHGAE NCIGOFEFICK);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LPCGAPKHGAE POMMJHDNDMG();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FALDNEOANLI(LPCGAPKHGAE BOEKLGBANJL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DMKPFDEIAKJ : ELHPHCOHPKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LIHGCJHJDAO();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DGFIODPNNJI(Guid HHGNDGOIHEP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GJDHBBGPMBA
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMPDOPPNJMP(ALCJJLJPHNN EEFOABEEPAO);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHFCOOMFLME(ADBMECELNCD KALPAHICNIE, FCLMIFJOGJK IHBNNHGPAEO);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CADLGPJEIGJ();

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBEPFBINENJ(ALCJJLJPHNN CHDFFNLKHJK);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJCBCMCAMGO(ALCJJLJPHNN DEHNGOFCBHP);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AMCBJLGCDMF();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class EPPBLMLFKIF : ALCJJLJPHNN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FBBJIJBJHLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public PMFPPOOGCCA nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public EPPBLMLFKIF foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FBBJIJBJHLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6E841A0", Offset = "0x6E829A0", VA = "0x186E841A0")]
		internal bool FDIINCNGGHN(ALCJJLJPHNN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private PMFPPOOGCCA NKIKEHJLLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<EPPBLMLFKIF> LBGOPIOOHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private EPPBLMLFKIF PBFFIIFKEIA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public PMFPPOOGCCA GDCGFHNGEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xE04140", Offset = "0xE02940", VA = "0x180E04140", Slot = "6")]
		get
		{
			return default(PMFPPOOGCCA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xE04110", Offset = "0xE02910", VA = "0x180E04110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private EPPBLMLFKIF NCCLECGLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E837F0", Offset = "0x6E81FF0", VA = "0x186E837F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ALCJJLJPHNN MHMOKMJDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FCKPLGCDKOA OELEIAKGHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NAODAHJBDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E840E0", Offset = "0x6E828E0", VA = "0x186E840E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool EGKLKLJDPKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E83FC0", Offset = "0x6E827C0", VA = "0x186E83FC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected EPPBLMLFKIF KAMAKIBPPKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E84010", Offset = "0x6E82810", VA = "0x186E84010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E840F0", Offset = "0x6E828F0", VA = "0x186E840F0")]
	public EPPBLMLFKIF(PMFPPOOGCCA LIOOKNHGPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E83E70", Offset = "0x6E82670", VA = "0x186E83E70")]
	public EPPBLMLFKIF EKLHNGDLCJI(PMFPPOOGCCA FNABHMOPBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6E83670", Offset = "0x6E81E70", VA = "0x186E83670")]
	public EPPBLMLFKIF ADJGBDLEOBA(PMFPPOOGCCA BPJPAHAMFBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6E838D0", Offset = "0x6E820D0", VA = "0x186E838D0")]
	public EPPBLMLFKIF CGFLGFPAOEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6E83AB0", Offset = "0x6E822B0", VA = "0x186E83AB0")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E84030", Offset = "0x6E82830", VA = "0x186E84030")]
	public EPPBLMLFKIF HDGMMFDOILJ(PMFPPOOGCCA FABMJJHDKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E83D00", Offset = "0x6E82500", VA = "0x186E83D00")]
	private static void EJLDNHKEONK(EPPBLMLFKIF KCELDAMEDLI, AFKOKODCFMC GFKCDNLMPGP, bool LPBDCAIOOIP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6E83E60", Offset = "0x6E82660", VA = "0x186E83E60", Slot = "9")]
	public void EJLDNHKEONK(AFKOKODCFMC KNMHMBJIFMM, bool KKPELIFONII = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6E83C00", Offset = "0x6E82400", VA = "0x186E83C00")]
	public static EPPBLMLFKIF EFAHEMLFAAB(EPPBLMLFKIF KCELDAMEDLI, PMFPPOOGCCA LJDFKKGBGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface PLHAJBMCKDI
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool DLBJPOGPMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool ILEJCAKOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<CMNIABPOENF> FMNBGIEBKJA;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<CMNIABPOENF> AMOCINDBBJF;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(KFAGPBLLNEF JIPBFCNFKIF);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(FCKPLGCDKOA KCNOPLIGPGJ, FCKPLGCDKOA OKJKGIJPCDE, int ADFBLAFIEAG, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(FCKPLGCDKOA PMAJFDOHJGP, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(DEEAMLJIMEG GHPFDAAACMA, [Optional] CMNIABPOENF KBCFGEJLMHH);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, PLHAJBMCKDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private KFAGPBLLNEF JIPBFCNFKIF;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool DLBJPOGPMAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6E88D00", Offset = "0x6E87500", VA = "0x186E88D00", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool ILEJCAKOEMD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6E88D60", Offset = "0x6E87560", VA = "0x186E88D60", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<CMNIABPOENF> FMNBGIEBKJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6E88C50", Offset = "0x6E87450", VA = "0x186E88C50", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x6E88E50", Offset = "0x6E87650", VA = "0x186E88E50", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<CMNIABPOENF> AMOCINDBBJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x6E88BA0", Offset = "0x6E873A0", VA = "0x186E88BA0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x6E88DA0", Offset = "0x6E875A0", VA = "0x186E88DA0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFE0", Offset = "0x8B97E0", VA = "0x1808BAFE0", Slot = "19")]
		public void SetManager(KFAGPBLLNEF JIPBFCNFKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E88B70", Offset = "0x6E87370", VA = "0x186E88B70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E878F0", Offset = "0x6E860F0", VA = "0x186E878F0", Slot = "23")]
		public void RequestMasterConnectNodes(FCKPLGCDKOA ACHJMLGGEOO, int ADFBLAFIEAG, FCKPLGCDKOA COPIAPOLKEO, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E87A20", Offset = "0x6E86220", VA = "0x186E87A20", Slot = "24")]
		public void RequestMasterDisconnectNode(FCKPLGCDKOA LAHKLAKLACM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E87AE0", Offset = "0x6E862E0", VA = "0x186E87AE0", Slot = "20")]
		public void RequestMasterModifyNode(FCKPLGCDKOA KCNOPLIGPGJ, FCKPLGCDKOA OKJKGIJPCDE, int ADFBLAFIEAG, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E87C10", Offset = "0x6E86410", VA = "0x186E87C10", Slot = "21")]
		public void RequestMasterReparentNodes(FCKPLGCDKOA PMAJFDOHJGP, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6E87D40", Offset = "0x6E86540", VA = "0x186E87D40", Slot = "25")]
		public void RequestMasterReparentToRoot(FCKPLGCDKOA PMAJFDOHJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E877C0", Offset = "0x6E85FC0", VA = "0x186E877C0", Slot = "22")]
		public void RequestDeserializeConnectableGraph(DEEAMLJIMEG GHPFDAAACMA, [Optional] CMNIABPOENF KBCFGEJLMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6E88120", Offset = "0x6E86920", VA = "0x186E88120")]
		[GNEFMPAMHKD]
		private void RpcMasterConnectNodes(FCKPLGCDKOA ACHJMLGGEOO, int ADFBLAFIEAG, FCKPLGCDKOA COPIAPOLKEO, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E883E0", Offset = "0x6E86BE0", VA = "0x186E883E0")]
		[GNEFMPAMHKD]
		private void RpcMasterDisconnectNode(FCKPLGCDKOA LAHKLAKLACM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6E88720", Offset = "0x6E86F20", VA = "0x186E88720")]
		[GNEFMPAMHKD]
		private void RpcMasterReparentNodes(FCKPLGCDKOA PMAJFDOHJGP, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6E88520", Offset = "0x6E86D20", VA = "0x186E88520")]
		[GNEFMPAMHKD]
		private void RpcMasterModifyNode(FCKPLGCDKOA KCNOPLIGPGJ, FCKPLGCDKOA OKJKGIJPCDE, int ADFBLAFIEAG, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6E87F10", Offset = "0x6E86710", VA = "0x186E87F10")]
		[GNEFMPAMHKD]
		private void RpcConnectNodes(FCKPLGCDKOA ACHJMLGGEOO, int ADFBLAFIEAG, FCKPLGCDKOA COPIAPOLKEO, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI, ALLBHCACIAF HKLPIPOPIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E88090", Offset = "0x6E86890", VA = "0x186E88090")]
		[GNEFMPAMHKD]
		private void RpcDisconnectNode(FCKPLGCDKOA LAHKLAKLACM, ALLBHCACIAF HKLPIPOPIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E88A70", Offset = "0x6E87270", VA = "0x186E88A70")]
		[GNEFMPAMHKD]
		private void RpcReparentNodes(FCKPLGCDKOA PMAJFDOHJGP, int BOOFJENCDHI, FCKPLGCDKOA FABMJJHDKOA, int HIBHCNKPJCI, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI, ALLBHCACIAF HKLPIPOPIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E889B0", Offset = "0x6E871B0", VA = "0x186E889B0")]
		[GNEFMPAMHKD]
		private void RpcModifyNode(FCKPLGCDKOA KCNOPLIGPGJ, int ADFBLAFIEAG, int CJINCJINACH, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI, ALLBHCACIAF HKLPIPOPIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E88050", Offset = "0x6E86850", VA = "0x186E88050")]
		[GNEFMPAMHKD]
		private void RpcDeserializeConnectableGraph(DEEAMLJIMEG KALPAHICNIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FE0", Offset = "0x8D17E0", VA = "0x1808D2FE0")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, LPCGAPKHGAE, LKFAFMPBBDO.MBEABKOEJJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6E87640", Offset = "0x6E85E40", VA = "0x186E87640", Slot = "4")]
		private void PKCGFJHKPFA(FCKPLGCDKOA COPIAPOLKEO, PMFPPOOGCCA IDCFOEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E873D0", Offset = "0x6E85BD0", VA = "0x186E873D0", Slot = "5")]
		private void LICHAJOAHAC(FCKPLGCDKOA COPIAPOLKEO, PMFPPOOGCCA IDCFOEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E86EE0", Offset = "0x6E856E0", VA = "0x186E86EE0", Slot = "6")]
		private void BMODNCFOCND(FCKPLGCDKOA COPIAPOLKEO, PMFPPOOGCCA IDCFOEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E871E0", Offset = "0x6E859E0", VA = "0x186E871E0", Slot = "7")]
		private void ELFIEAAKOJD(FCKPLGCDKOA COPIAPOLKEO, PMFPPOOGCCA IDCFOEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E87110", Offset = "0x6E85910", VA = "0x186E87110", Slot = "8")]
		private LPCGAPKHGAE CILNMFPCMJE(Transform NBEDBEKEEBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E87180", Offset = "0x6E85980", VA = "0x186E87180", Slot = "9")]
		private void EKEECENNCNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HFJHAABBCDN
{
	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x30866C0", Offset = "0x3084EC0", VA = "0x1830866C0")]
	public static LPGOMCKJGBE<T> JHPBMPBIBMD<T>(this CMONJLKOOCI MFHCHOKEAIG)
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
