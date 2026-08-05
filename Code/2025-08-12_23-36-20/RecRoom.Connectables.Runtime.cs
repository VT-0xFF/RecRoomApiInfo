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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x829FA00", Offset = "0x829E800", VA = "0x18829FA00", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x238F970", Offset = "0x238E770", VA = "0x18238F970", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82ACC60", Offset = "0x82ABA60", VA = "0x1882ACC60")]
		private void EDICDPMMNIG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82ACAF0", Offset = "0x82AB8F0", VA = "0x1882ACAF0")]
		private void DGAAKECFDPD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82ACDD0", Offset = "0x82ABBD0", VA = "0x1882ACDD0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82AD110", Offset = "0x82ABF10", VA = "0x1882AD110")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class NJDHAHLLJNN : EPFEKLMAJND, JDBGEACJNEG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MMDNDACFGNJ : IEnumerable<DPLPABAANPI>, IEnumerable, IEnumerator<DPLPABAANPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private DPLPABAANPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CLPADLABDGI localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CLPADLABDGI <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NJDHAHLLJNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NKPGLIPFHAL <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private INGCKODPEPI <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private INGCKODPEPI.CIDBMLFFKOM <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DPLPABAANPI System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public MMDNDACFGNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82A0040", Offset = "0x829EE40", VA = "0x1882A0040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x829FBC0", Offset = "0x829E9C0", VA = "0x18829FBC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x829FF20", Offset = "0x829ED20", VA = "0x18829FF20")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x829FBA0", Offset = "0x829E9A0", VA = "0x18829FBA0")]
		private void DFGOGGAACMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x829FFF0", Offset = "0x829EDF0", VA = "0x18829FFF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x829FF40", Offset = "0x829ED40", VA = "0x18829FF40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DPLPABAANPI> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x829FF40", Offset = "0x829ED40", VA = "0x18829FF40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class HNKEGJODHJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NJDHAHLLJNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public GOKMFNHMGAG nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HNKEGJODHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x829E960", Offset = "0x829D760", VA = "0x18829E960")]
		internal object JNDCGCPJNBN(GOKMFNHMGAG x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DOBADLBMOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GOKMFNHMGAG child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HNKEGJODHJI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DOBADLBMOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x829CE50", Offset = "0x829BC50", VA = "0x18829CE50")]
		internal object OIGAAHFMPEG((GOKMFNHMGAG child, GOKMFNHMGAG nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ALMLLDBPKBM EPHMHIBAPGM;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ALMLLDBPKBM AFANHCAODBP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly ALMLLDBPKBM KLJHMGHCNGC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly ALMLLDBPKBM DIECJHOEDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private LAMALDPDKJM BCAIJBHPLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IBKCEPLCLAA PMABOMPCCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LMNDMENDAKD NOLBIGEFMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private FOABOBOLCLP OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private BCICJPBDLAP PFNNNPIGKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private JGPAKENGFEL MCNHJILIOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PCPEGLMDJKJ GLBBEGAGJCC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KFLGDPOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA98B80", Offset = "0xA97980", VA = "0x180A98B80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA98B30", Offset = "0xA97930", VA = "0x180A98B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BMCJECEGCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<DPLPABAANPI, DPLPABAANPI> HANGNNHAKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82A8C20", Offset = "0x82A7A20", VA = "0x1882A8C20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82A59D0", Offset = "0x82A47D0", VA = "0x1882A59D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<DPLPABAANPI, DPLPABAANPI> BADEECEBMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82A5A80", Offset = "0x82A4880", VA = "0x1882A5A80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82A8280", Offset = "0x82A7080", VA = "0x1882A8280", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<DPLPABAANPI, DPLPABAANPI, DPLPABAANPI> GOGMJCDLAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82A60A0", Offset = "0x82A4EA0", VA = "0x1882A60A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82A69F0", Offset = "0x82A57F0", VA = "0x1882A69F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82A9F40", Offset = "0x82A8D40", VA = "0x1882A9F40")]
	public NJDHAHLLJNN(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82A7150", Offset = "0x82A5F50", VA = "0x1882A7150", Slot = "12")]
	public void IEHCJBEIMLK(GameObject DFFAMKHOIDB, MNGEMECMANL PEKGCMBPODM, OOPMGCPHKML JFKPMDJNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82A64F0", Offset = "0x82A52F0", VA = "0x1882A64F0", Slot = "26")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82A78B0", Offset = "0x82A66B0", VA = "0x1882A78B0", Slot = "22")]
	public bool JHIBHIBLKGD(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82A61E0", Offset = "0x82A4FE0", VA = "0x1882A61E0")]
	private void DNNFJJBDFJD(CLPADLABDGI ADDJCBPIAAK, CLPADLABDGI ABMDIDNJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82A6D60", Offset = "0x82A5B60", VA = "0x1882A6D60")]
	private void GIEDJGNDAIG(CLPADLABDGI ADDJCBPIAAK, CLPADLABDGI HNHMHBCEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82A6AA0", Offset = "0x82A58A0", VA = "0x1882A6AA0")]
	private void FLLLENDBLHA(CLPADLABDGI ADDJCBPIAAK, CLPADLABDGI HNHMHBCEGEE, CLPADLABDGI ABMDIDNJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82A99E0", Offset = "0x82A87E0", VA = "0x1882A99E0")]
	private void PNDNIPLAEID(CLPADLABDGI ADDJCBPIAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "13")]
	public void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82A66E0", Offset = "0x82A54E0", VA = "0x1882A66E0", Slot = "14")]
	public void FAIIODDINIJ(DPLPABAANPI BCNMCDHKPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "15")]
	public void IIOINIJEMOP(DPLPABAANPI BCNMCDHKPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82A8E10", Offset = "0x82A7C10", VA = "0x1882A8E10", Slot = "17")]
	public void NEEIJFAIEOP(DPLPABAANPI BCNMCDHKPLK, DPLPABAANPI PHADFJEKGPM, Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82A8CD0", Offset = "0x82A7AD0", VA = "0x1882A8CD0")]
	public void NEEIJFAIEOP(CLPADLABDGI NKJCHADOMOJ, CLPADLABDGI PHADFJEKGPM, Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82A63F0", Offset = "0x82A51F0", VA = "0x1882A63F0")]
	public void DOMDONECMGC(DPLPABAANPI BCNMCDHKPLK, float GONFABNGNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82A90B0", Offset = "0x82A7EB0", VA = "0x1882A90B0", Slot = "18")]
	public void OKCOLILHFCC(DPLPABAANPI AOMOLKOFFPM, int FJOGNOIBPJJ, DPLPABAANPI CHADLIJCIHO, int PPHFKMGAPBO, Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82A8F70", Offset = "0x82A7D70", VA = "0x1882A8F70")]
	private float NIBMHHJJJBH(CLPADLABDGI NKJCHADOMOJ, CLPADLABDGI PJGOIMBEKPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82A9210", Offset = "0x82A8010", VA = "0x1882A9210")]
	public void OKCOLILHFCC(CLPADLABDGI NKJCHADOMOJ, CLPADLABDGI PJGOIMBEKPK, Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG, bool GDMACOJOHMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82A5750", Offset = "0x82A4550", VA = "0x1882A5750", Slot = "19")]
	public void AGCGMBFODGF(DPLPABAANPI BCNMCDHKPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82A5B30", Offset = "0x82A4930", VA = "0x1882A5B30", Slot = "16")]
	public void BIIFGJBEBCI(DPLPABAANPI BCNMCDHKPLK, HashSet<DPLPABAANPI> LGDAIOAPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "20")]
	public KGNLCKIHNBM DKDPNGMPFGN(bool LHFFBMJKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "21")]
	public KGNLCKIHNBM NJIBFNNANND(HashSet<Guid> EFDNNGCNOPJ, bool LHFFBMJKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82A6480", Offset = "0x82A5280", VA = "0x1882A6480", Slot = "23")]
	public void EECMCJAIJHO(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x82A7900", Offset = "0x82A6700", VA = "0x1882A7900", Slot = "24")]
	public void JOMIOGCCJPJ(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x82A61C0", Offset = "0x82A4FC0", VA = "0x1882A61C0", Slot = "25")]
	public void DLJMCKEOHKL(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x82A94E0", Offset = "0x82A82E0", VA = "0x1882A94E0")]
	private void OMGAHNNNLMM(CLPADLABDGI NKJCHADOMOJ, CLPADLABDGI PJGOIMBEKPK, Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG, float GONFABNGNBG, bool GDMACOJOHMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x82A8330", Offset = "0x82A7130", VA = "0x1882A8330")]
	private void MJIKCJHMMIA(CLPADLABDGI NKJCHADOMOJ, CLPADLABDGI HNDFKDHDHKN, Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82A6150", Offset = "0x82A4F50", VA = "0x1882A6150")]
	private void DDMKMKLOIGL(CLPADLABDGI NKJCHADOMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x82A9020", Offset = "0x82A7E20", VA = "0x1882A9020")]
	[IteratorStateMachine(typeof(MMDNDACFGNJ))]
	public IEnumerable<DPLPABAANPI> NPHKBKMKGKL(CLPADLABDGI DPODDKLLKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82A7770", Offset = "0x82A6570", VA = "0x1882A7770")]
	internal DPLPABAANPI IGLBIJIBJNF(CLPADLABDGI DPODDKLLKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82A80F0", Offset = "0x82A6EF0", VA = "0x1882A80F0")]
	internal CLPADLABDGI LGOGNKACHEB(DPLPABAANPI BCNMCDHKPLK)
	{
		return default(CLPADLABDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82A7970", Offset = "0x82A6770", VA = "0x1882A7970")]
	private bool KLEFBNBCOBJ(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82A7F00", Offset = "0x82A6D00", VA = "0x1882A7F00")]
	private bool KPFMNOCOGMG(GOKMFNHMGAG ILCELEMMMGJ, [Out] DPLPABAANPI PJGOIMBEKPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82A73E0", Offset = "0x82A61E0", VA = "0x1882A73E0")]
	private DPLPABAANPI IGLBIJIBJNF(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x82A6F80", Offset = "0x82A5D80", VA = "0x1882A6F80")]
	private DPLPABAANPI HGOGJFCDEMC(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x82A5ED0", Offset = "0x82A4CD0", VA = "0x1882A5ED0")]
	private DPLPABAANPI CCKLJBBPCLO(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82A7110", Offset = "0x82A5F10", VA = "0x1882A7110")]
	private static Guid IAOGODILDAO(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x82A98F0", Offset = "0x82A86F0", VA = "0x1882A98F0")]
	private string OOPENPAEHBD(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x82A5D40", Offset = "0x82A4B40", VA = "0x1882A5D40")]
	private void BLKKHEEFMAI(DPLPABAANPI NKJCHADOMOJ, DPLPABAANPI HNDFKDHDHKN, RigidTransform JLCFMKHFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x82A7F60", Offset = "0x82A6D60", VA = "0x1882A7F60")]
	private void LBCPJFMDGON(DPLPABAANPI HNDFKDHDHKN, DPLPABAANPI NKJCHADOMOJ, RigidTransform JLCFMKHFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x82A6D00", Offset = "0x82A5B00", VA = "0x1882A6D00")]
	private void GGNMEINEOAD(DPLPABAANPI NMPEBJLLKBE, DPLPABAANPI NKJCHADOMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x82A9350", Offset = "0x82A8150", VA = "0x1882A9350")]
	private void OMEHGIEGHIE(DPLPABAANPI NKJCHADOMOJ, DPLPABAANPI PJGOIMBEKPK, RigidTransform JLCFMKHFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x82A58C0", Offset = "0x82A46C0", VA = "0x1882A58C0")]
	private void ANFHHBJLGCL(CLPADLABDGI DPODDKLLKHL, DPLPABAANPI BCNMCDHKPLK, CLPADLABDGI HNHMHBCEGEE, CLPADLABDGI ABMDIDNJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82A54D0", Offset = "0x82A42D0", VA = "0x1882A54D0")]
	private void ADOBIFOGNEO(CLPADLABDGI DPODDKLLKHL, DPLPABAANPI BCNMCDHKPLK, DPLPABAANPI EJMAFOBPKDL, DPLPABAANPI POAGCKPNEPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OAPGGGDHFEK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FPBCHPEJLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public HJFNEHLLJBB container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FPBCHPEJLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x829D9D0", Offset = "0x829C7D0", VA = "0x18829D9D0")]
		internal NJDHAHLLJNN IPHPENPCOFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82AA020", Offset = "0x82A8E20", VA = "0x1882AA020")]
	public static void BOBDKMHPHCM(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82AA1A0", Offset = "0x82A8FA0", VA = "0x1882AA1A0")]
	public static void MDIGHOMOCGG(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NHNPBDDHFIO : CDKFNDPHHFG, NOFBIIEANMF
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly NJDHAHLLJNN EMJICKMMFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BFLKCHNJMGF DBAPNBJNGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LOLIKIHKMMK OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly DCILGMKDDGK[] CCGBLGIHBEN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DPLPABAANPI HPFFIAPMLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x82A52A0", Offset = "0x82A40A0", VA = "0x1882A52A0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DPLPABAANPI LNHNBBCKLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x82A41B0", Offset = "0x82A2FB0", VA = "0x1882A41B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 GCGCAHJOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x82A4270", Offset = "0x82A3070", VA = "0x1882A4270", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion IJNEFJDPJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82A39E0", Offset = "0x82A27E0", VA = "0x1882A39E0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HEOAGIGFNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x82A4600", Offset = "0x82A3400", VA = "0x1882A4600", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<DPLPABAANPI> LFGEIJFPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82A4B20", Offset = "0x82A3920", VA = "0x1882A4B20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool APLMKGJJJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD913B0", Offset = "0xD901B0", VA = "0x180D913B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xDACDA0", Offset = "0xDABBA0", VA = "0x180DACDA0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x82A54B0", Offset = "0x82A42B0", VA = "0x1882A54B0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject AHIOLNHEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82A51B0", Offset = "0x82A3FB0", VA = "0x1882A51B0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x82A51D0", Offset = "0x82A3FD0", VA = "0x1882A51D0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid DJMOMLEBGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82A5300", Offset = "0x82A4100", VA = "0x1882A5300", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int AFOOBDFKFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x82A53E0", Offset = "0x82A41E0", VA = "0x1882A53E0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LJLFJDNFMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JDDLFMMGINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82A4160", Offset = "0x82A2F60", VA = "0x1882A4160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JFPCLOLFDCG DPKCCIAGNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x82A3980", Offset = "0x82A2780", VA = "0x1882A3980", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x82A36B0", Offset = "0x82A24B0", VA = "0x1882A36B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JFPCLOLFDCG MMCLBLNLNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x82A4BA0", Offset = "0x82A39A0", VA = "0x1882A4BA0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82A45A0", Offset = "0x82A33A0", VA = "0x1882A45A0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JFPCLOLFDCG LGHJKFFNEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82A4740", Offset = "0x82A3540", VA = "0x1882A4740", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x82A3710", Offset = "0x82A2510", VA = "0x1882A3710", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event LCOGAIPKCHE LHKDHFNGBON
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x82A47A0", Offset = "0x82A35A0", VA = "0x1882A47A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82A42D0", Offset = "0x82A30D0", VA = "0x1882A42D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82A50B0", Offset = "0x82A3EB0", VA = "0x1882A50B0")]
	public NHNPBDDHFIO(CLPADLABDGI JIKGGNOOJMH, RigidbodyEx HFFACBJLEBJ, BFLKCHNJMGF DBAPNBJNGHG, DCILGMKDDGK[] CCGBLGIHBEN, LOLIKIHKMMK OLPMMDDOCOO, EPFEKLMAJND EMJICKMMFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x82A4370", Offset = "0x82A3170", VA = "0x1882A4370", Slot = "19")]
	public void IODAHCPKPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "21")]
	public void OGAOPFFBOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7F60", Offset = "0x7FB6D60", VA = "0x187FB7F60", Slot = "22")]
	public void IINJNEHILOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x82A3E40", Offset = "0x82A2C40", VA = "0x1882A3E40", Slot = "20")]
	public void DGOFKDGOMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x82A3770", Offset = "0x82A2570", VA = "0x1882A3770", Slot = "25")]
	public void BCJLNCHHJMH(int CLACIKMEOPD, DPLPABAANPI CHADLIJCIHO, int MDOCMLCBGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x82A4670", Offset = "0x82A3470", VA = "0x1882A4670", Slot = "26")]
	public void KEJGKLJCMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x82A4840", Offset = "0x82A3640", VA = "0x1882A4840", Slot = "27")]
	public void LFNMOICJFLF(int CLACIKMEOPD, DPLPABAANPI AOMOLKOFFPM, int BDJOHJMMNOI, [Optional] Vector3? OBBBPEHENBE, [Optional] Quaternion? LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82A3E90", Offset = "0x82A2C90", VA = "0x1882A3E90", Slot = "28")]
	public void DMNPDPPKDPK(DPLPABAANPI AOMOLKOFFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x82A4C00", Offset = "0x82A3A00", VA = "0x1882A4C00", Slot = "31")]
	public void OHDCJDPDEIO(Vector3 MBIIPPNKKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82A3A40", Offset = "0x82A2840", VA = "0x1882A3A40", Slot = "29")]
	public void CGJGOOOAJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82A43A0", Offset = "0x82A31A0", VA = "0x1882A43A0", Slot = "30")]
	public void JBOKAFMCOKC(int JJJJBEGKNIN, Vector3 EEIHHMMODIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x82A4090", Offset = "0x82A2E90", VA = "0x1882A4090", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int CLACIKMEOPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82A3F60", Offset = "0x82A2D60", VA = "0x1882A3F60", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int CLACIKMEOPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB14DA0", Offset = "0xB13BA0", VA = "0x180B14DA0", Slot = "42")]
	public Color GetConnectionSlotColor(int CLACIKMEOPD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x82A3D50", Offset = "0x82A2B50", VA = "0x1882A3D50", Slot = "43")]
	public bool CanConnectTo(int CLACIKMEOPD, DPLPABAANPI CNBNGJDLANB, int EMNHFFFOHLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "44")]
	public void ParentChanged(int CLACIKMEOPD, DPLPABAANPI OIDFIOJLCHO, int NHIDJBBEFDC, Vector3 GEFCEFPIEND, Quaternion LGCGIEIANOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "45")]
	public void ChildAdded(int CLACIKMEOPD, DPLPABAANPI JDENCMDBMMO, int NJNGCEIFGMP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "46")]
	public void ChildRemoved(int CLACIKMEOPD, DPLPABAANPI CFPIAMEJDFJ, int PLFNIBGIKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "47")]
	public void ConnectionModified(int CLACIKMEOPD, DPLPABAANPI CHADLIJCIHO, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x82A5010", Offset = "0x82A3E10", VA = "0x1882A5010", Slot = "48")]
	public void RootChanged(DPLPABAANPI MKOMJBBHDCO, DPLPABAANPI HGOICDGBJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x82A4B50", Offset = "0x82A3950", VA = "0x1882A4B50", Slot = "23")]
	public void MKLGADEMDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x82A3DF0", Offset = "0x82A2BF0", VA = "0x1882A3DF0", Slot = "24")]
	public void DFGFFNCNOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x82A3F10", Offset = "0x82A2D10", VA = "0x1882A3F10")]
	private void EICONKDEPMJ(bool JNKLGALNMAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(MLFEJDDCGOL), new string[] { })]
public class KFDAJIPHDBP : MLFEJDDCGOL, IHLGGOCLGIA, BOIHHABJILH
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AOFCNCLKNLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AOFCNCLKNLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private EBHJCGEOKAB IHDHFEFDGDE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object DBAMKDGNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x829ECD0", Offset = "0x829DAD0", VA = "0x18829ECD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x829EC80", Offset = "0x829DA80", VA = "0x18829EC80", Slot = "5")]
	private void LFGDJFPHPKJ(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x130AE30", Offset = "0x1309C30", VA = "0x18130AE30", Slot = "6")]
	private void HJBDBNLCEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KFDAJIPHDBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(EPFEKLMAJND), new string[] { "Ignore", "Mock" })]
public class CFGDGELOBHM : EPFEKLMAJND, JDBGEACJNEG
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KFLGDPOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BMCJECEGCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<DPLPABAANPI, DPLPABAANPI> HANGNNHAKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x829AA60", Offset = "0x8299860", VA = "0x18829AA60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x829A6F0", Offset = "0x82994F0", VA = "0x18829A6F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<DPLPABAANPI, DPLPABAANPI> BADEECEBMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x829A7A0", Offset = "0x82995A0", VA = "0x18829A7A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x829A9B0", Offset = "0x82997B0", VA = "0x18829A9B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<DPLPABAANPI, DPLPABAANPI, DPLPABAANPI> GOGMJCDLAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x829A850", Offset = "0x8299650", VA = "0x18829A850", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x829A900", Offset = "0x8299700", VA = "0x18829A900", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "26")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "12")]
	public void IEHCJBEIMLK(GameObject DFFAMKHOIDB, MNGEMECMANL PEKGCMBPODM, OOPMGCPHKML AGDANODEHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "13")]
	public void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "14")]
	public void FAIIODDINIJ(DPLPABAANPI BCNMCDHKPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "15")]
	public void IIOINIJEMOP(DPLPABAANPI BCNMCDHKPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "16")]
	public void BIIFGJBEBCI(DPLPABAANPI BCNMCDHKPLK, HashSet<DPLPABAANPI> LGDAIOAPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "17")]
	public void NEEIJFAIEOP(DPLPABAANPI BCNMCDHKPLK, DPLPABAANPI PHADFJEKGPM, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "18")]
	public void OKCOLILHFCC(DPLPABAANPI BCNMCDHKPLK, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "19")]
	public void AGCGMBFODGF(DPLPABAANPI BCNMCDHKPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "20")]
	public KGNLCKIHNBM DKDPNGMPFGN(bool LHFFBMJKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "21")]
	public KGNLCKIHNBM NJIBFNNANND(HashSet<Guid> EFDNNGCNOPJ, bool LHFFBMJKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "22")]
	public bool JHIBHIBLKGD(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "23")]
	public void EECMCJAIJHO(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "24")]
	public void JOMIOGCCJPJ(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "25")]
	public void DLJMCKEOHKL(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CFGDGELOBHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DPLPABAANPI : NOFBIIEANMF, IEquatable<DPLPABAANPI>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NOFBIIEANMF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	DPLPABAANPI HPFFIAPMLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject AHIOLNHEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid DJMOMLEBGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int AFOOBDFKFKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LJLFJDNFMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int CLACIKMEOPD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int CLACIKMEOPD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int CLACIKMEOPD);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int CLACIKMEOPD, DPLPABAANPI CNBNGJDLANB, int KDEHBGFFHFO);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int CLACIKMEOPD, DPLPABAANPI OIDFIOJLCHO, int NHIDJBBEFDC, Vector3 GEFCEFPIEND, Quaternion LGCGIEIANOK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int CLACIKMEOPD, DPLPABAANPI JDENCMDBMMO, int NJNGCEIFGMP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int CLACIKMEOPD, DPLPABAANPI CFPIAMEJDFJ, int PLFNIBGIKLM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int CLACIKMEOPD, DPLPABAANPI CHADLIJCIHO, int CLCBKIFJIAD, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(DPLPABAANPI MKOMJBBHDCO, DPLPABAANPI HGOICDGBJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EPFEKLMAJND : JDBGEACJNEG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool KFLGDPOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BMCJECEGCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<DPLPABAANPI, DPLPABAANPI> HANGNNHAKDN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<DPLPABAANPI, DPLPABAANPI> BADEECEBMFJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<DPLPABAANPI, DPLPABAANPI, DPLPABAANPI> GOGMJCDLAHA;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IEHCJBEIMLK(GameObject DFFAMKHOIDB, MNGEMECMANL PEKGCMBPODM, OOPMGCPHKML NDHEIGJKNON);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AFCEEABIEMI();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FAIIODDINIJ(DPLPABAANPI BCNMCDHKPLK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IIOINIJEMOP(DPLPABAANPI BCNMCDHKPLK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BIIFGJBEBCI(DPLPABAANPI BCNMCDHKPLK, HashSet<DPLPABAANPI> LGDAIOAPLKE);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NEEIJFAIEOP(DPLPABAANPI BCNMCDHKPLK, DPLPABAANPI PHADFJEKGPM, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OKCOLILHFCC(DPLPABAANPI BCNMCDHKPLK, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AGCGMBFODGF(DPLPABAANPI BCNMCDHKPLK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KGNLCKIHNBM DKDPNGMPFGN(bool LHFFBMJKNHL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	KGNLCKIHNBM NJIBFNNANND(HashSet<Guid> EFDNNGCNOPJ, bool LHFFBMJKNHL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JHIBHIBLKGD(GOKMFNHMGAG ILCELEMMMGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EECMCJAIJHO(KGNLCKIHNBM CPOICOGAHOC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JOMIOGCCJPJ(KGNLCKIHNBM CPOICOGAHOC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DLJMCKEOHKL(KGNLCKIHNBM CPOICOGAHOC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FOABOBOLCLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OEAHHMAJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPLPABAANPI CCKLJBBPCLO(int FNFDIECIKMG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPLPABAANPI HGOGJFCDEMC(Guid FAEJMDLDPED);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IGIBMBOMJHL(DPLPABAANPI BCNMCDHKPLK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MMMKMBHLGKA();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHHCPHDEHJC(DPLPABAANPI DBAPNBJNGHG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface LOLIKIHKMMK
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JDDLFMMGINL(BFLKCHNJMGF DBAPNBJNGHG);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MKEBAEBKAGN(BFLKCHNJMGF DBAPNBJNGHG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string LNIADHOBGPE(BFLKCHNJMGF DBAPNBJNGHG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid BALLFGLDFMC(BFLKCHNJMGF DBAPNBJNGHG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GLHPKBPFJMG(BFLKCHNJMGF DBAPNBJNGHG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOLCPOPOLCM(BFLKCHNJMGF DBAPNBJNGHG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void JFPCLOLFDCG(DPLPABAANPI AOMOLKOFFPM, int AOCDNLCLKMC, DPLPABAANPI CHADLIJCIHO, int LAONPDOHJLM, [Optional] Vector3? OBBBPEHENBE, [Optional] Quaternion? LAPDLKCLKNC);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void LCOGAIPKCHE(DPLPABAANPI MKOMJBBHDCO, DPLPABAANPI HGOICDGBJFF);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BFLKCHNJMGF : DPLPABAANPI, NOFBIIEANMF, IEquatable<DPLPABAANPI>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CDKFNDPHHFG : NOFBIIEANMF
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DPLPABAANPI LNHNBBCKLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<DPLPABAANPI> LFGEIJFPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 GCGCAHJOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion IJNEFJDPJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool HEOAGIGFNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool APLMKGJJJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event JFPCLOLFDCG DPKCCIAGNAB;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event JFPCLOLFDCG MMCLBLNLNBF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event JFPCLOLFDCG LGHJKFFNEEE;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event LCOGAIPKCHE LHKDHFNGBON;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IODAHCPKPHJ();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DGOFKDGOMGH();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OGAOPFFBOKA();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IINJNEHILOI();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MKLGADEMDCM();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DFGFFNCNOOD();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BCJLNCHHJMH(int CLACIKMEOPD, DPLPABAANPI CHADLIJCIHO, int MDOCMLCBGAP);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KEJGKLJCMNO();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LFNMOICJFLF(int CLACIKMEOPD, DPLPABAANPI AOMOLKOFFPM, int BDJOHJMMNOI, [Optional] Vector3? OBBBPEHENBE, [Optional] Quaternion? LAPDLKCLKNC);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DMNPDPPKDPK(DPLPABAANPI AOMOLKOFFPM);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CGJGOOOAJBK();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JBOKAFMCOKC(int JJJJBEGKNIN, Vector3 EEIHHMMODIJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void OHDCJDPDEIO(Vector3 MBIIPPNKKLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DCILGMKDDGK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 EBNKPEBMMPM
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
public interface MNGEMECMANL
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool FJOAMNPIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PIDJOMILKKC LMEBGBBPHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, MNGEMECMANL
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
			[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public PIDJOMILKKC LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x829CC00", Offset = "0x829BA00", VA = "0x18829CC00")]
		public static ConnectableConfigData GDJMHKJICOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x829CCC0", Offset = "0x829BAC0", VA = "0x18829CCC0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual LOIFHHIGOCI, bool KGEBNLPBIIB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct ECMJMKIDDNP : IEquatable<ECMJMKIDDNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public DPLPABAANPI BCNMCDHKPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int HPEFGPPMOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int CLCBKIFJIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 OBBBPEHENBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion LAPDLKCLKNC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x829D630", Offset = "0x829C430", VA = "0x18829D630")]
	public ECMJMKIDDNP(DPLPABAANPI BCNMCDHKPLK, int HPEFGPPMOIE, int CLCBKIFJIAD, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x829D590", Offset = "0x829C390", VA = "0x18829D590")]
	public ECMJMKIDDNP(DPLPABAANPI BCNMCDHKPLK, int HPEFGPPMOIE, int CLCBKIFJIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x829D510", Offset = "0x829C310", VA = "0x18829D510")]
	public ECMJMKIDDNP(DPLPABAANPI BCNMCDHKPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x829D0A0", Offset = "0x829BEA0", VA = "0x18829D0A0", Slot = "4")]
	public bool Equals(ECMJMKIDDNP FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x829D150", Offset = "0x829BF50", VA = "0x18829D150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class GFABENCAMFF : PNBJNMMNKCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform DNNOOFELIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private PIDJOMILKKC MMGDONCDDJI;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7C319B0", Offset = "0x7C307B0", VA = "0x187C319B0", Slot = "4")]
	public void IEHCJBEIMLK(Transform DNNOOFELIOA, PIDJOMILKKC MMGDONCDDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x829DA80", Offset = "0x829C880", VA = "0x18829DA80", Slot = "5")]
	public PIDJOMILKKC BBBLBBKFKEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x829DB50", Offset = "0x829C950", VA = "0x18829DB50", Slot = "6")]
	public void LHFHMMECKOG(PIDJOMILKKC AKFOIMGNKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public GFABENCAMFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class NHMKOAOKDDN : IDisposable, DMPCFJFJIFJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EOFLGNHHGMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public DPLPABAANPI oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DPLPABAANPI newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EOFLGNHHGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x829D690", Offset = "0x829C490", VA = "0x18829D690")]
		internal bool BBJNGAFGOFH(KJLMDBEEGDA node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly ALPLBKLEEFC OGKKCPDOEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private JKJMMLHFKEO IBAMONLOCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private AGPAIAEFPFA LEIEIBBJFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool KGEBNLPBIIB;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly ALMLLDBPKBM GGGAEKPAFIH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KJLMDBEEGDA CNGEAHLGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x82A1C20", Offset = "0x82A0A20", VA = "0x1882A1C20")]
	public bool HCCHMKFOFOI([In] DFGFPGILAJG KANAIIDGHCH, bool LCIMCINNIEN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x82A0290", Offset = "0x829F090", VA = "0x1882A0290")]
	private bool AKMHNBPJGJN([In] DFGFPGILAJG KANAIIDGHCH, bool LCIMCINNIEN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x82A34E0", Offset = "0x82A22E0", VA = "0x1882A34E0")]
	public NHMKOAOKDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x82A1E70", Offset = "0x82A0C70", VA = "0x1882A1E70", Slot = "5")]
	public void IEHCJBEIMLK(EPFEKLMAJND EKOKCFOMOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x82A0850", Offset = "0x829F650", VA = "0x1882A0850", Slot = "17")]
	public void BEEJJOEIOJL(HGBCJJPEOFD LBJMJKFNAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x82A20E0", Offset = "0x82A0EE0", VA = "0x1882A20E0", Slot = "12")]
	public void INDLIFJCFLC(Func<DPLPABAANPI, bool> NCIGOHOEGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x82A20F0", Offset = "0x82A0EF0", VA = "0x1882A20F0")]
	private void INDLIFJCFLC(ALPLBKLEEFC DFHOHFFNCIJ, Func<DPLPABAANPI, bool> NCIGOHOEGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x82A3330", Offset = "0x82A2130", VA = "0x1882A3330", Slot = "11")]
	public void OMFMNINFGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x82A1600", Offset = "0x82A0400", VA = "0x1882A1600", Slot = "8")]
	public bool FEILHPBIJIF(DPLPABAANPI IBNMAIFDKJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x82A28E0", Offset = "0x82A16E0", VA = "0x1882A28E0")]
	private bool KANPNPAEDLK(DPLPABAANPI ELGMFIIFJFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x82A1280", Offset = "0x82A0080", VA = "0x1882A1280")]
	private static bool EEFLBOGKCFP(DPLPABAANPI ELGMFIIFJFL, ALPLBKLEEFC KEMBGDAOLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x82A0E90", Offset = "0x829FC90", VA = "0x1882A0E90")]
	private void DIKMCEMPOLB(Transform BOHAJPFPBCH, ALPLBKLEEFC PEHCKHJBFNO, ALPLBKLEEFC[] CMDBEOMHACJ, DPLPABAANPI CPADHCCIAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x82A0D40", Offset = "0x829FB40", VA = "0x1882A0D40")]
	private ECMJMKIDDNP CLBJCHPNBGB(Transform DLGFNMIENDK, ECMJMKIDDNP JKOKIPKGOEA)
	{
		return default(ECMJMKIDDNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x82A1F20", Offset = "0x82A0D20", VA = "0x1882A1F20")]
	private static bool ILDOOOKEKCK(ALPLBKLEEFC KEMBGDAOLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x82A3100", Offset = "0x82A1F00", VA = "0x1882A3100", Slot = "9")]
	public bool LGIBNBLNCNP(DPLPABAANPI LEOFPDMNNPM, int BDJOHJMMNOI, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x82A1610", Offset = "0x82A0410", VA = "0x1882A1610")]
	private bool FIBBFDCEEML(DPLPABAANPI LEOFPDMNNPM, int BDJOHJMMNOI, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x82A1860", Offset = "0x82A0660", VA = "0x1882A1860")]
	private static void FJGGMNHOEFL(DPLPABAANPI LEOFPDMNNPM, int BDJOHJMMNOI, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC, ALPLBKLEEFC GCACJEEBHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x82A0C20", Offset = "0x829FA20", VA = "0x1882A0C20")]
	private void BLKKHEEFMAI(DPLPABAANPI NIMHPPDKKKG, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x82A19E0", Offset = "0x82A07E0", VA = "0x1882A19E0")]
	private void FLKOJPMKNDL(ALPLBKLEEFC DFHOHFFNCIJ, DPLPABAANPI EJMAFOBPKDL, DPLPABAANPI POAGCKPNEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x82A1A50", Offset = "0x82A0850", VA = "0x1882A1A50")]
	private void FLKOJPMKNDL(DPLPABAANPI BCNMCDHKPLK, DPLPABAANPI EJMAFOBPKDL, DPLPABAANPI POAGCKPNEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x82A0220", Offset = "0x829F020", VA = "0x1882A0220")]
	private void ADOBIFOGNEO(DPLPABAANPI BCNMCDHKPLK, DPLPABAANPI EJMAFOBPKDL, DPLPABAANPI POAGCKPNEPL, bool NDECDHFKGLO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x82A0120", Offset = "0x829EF20", VA = "0x1882A0120")]
	private void ADOBIFOGNEO(ALPLBKLEEFC MMENCBNBOBJ, DPLPABAANPI CPADHCCIAOK, DPLPABAANPI HGOICDGBJFF, bool NDECDHFKGLO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x82A2FE0", Offset = "0x82A1DE0", VA = "0x1882A2FE0")]
	private void LBCPJFMDGON(DPLPABAANPI NKJCHADOMOJ, int BDJOHJMMNOI, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x82A1AC0", Offset = "0x82A08C0", VA = "0x1882A1AC0")]
	private void GGNMEINEOAD(KJLMDBEEGDA PJGOIMBEKPK, KJLMDBEEGDA KBMPGGOGDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x82A14A0", Offset = "0x82A02A0", VA = "0x1882A14A0", Slot = "18")]
	public DPLPABAANPI FDNLDOOKPED(DPLPABAANPI BCNMCDHKPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x82A0880", Offset = "0x829F680", VA = "0x1882A0880", Slot = "13")]
	public void BIIFGJBEBCI(DPLPABAANPI BCNMCDHKPLK, HashSet<DPLPABAANPI> BMNPABOHLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x82A1C30", Offset = "0x82A0A30", VA = "0x1882A1C30", Slot = "14")]
	public List<DPLPABAANPI> IEDOHFNLCJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x82A3160", Offset = "0x82A1F60", VA = "0x1882A3160")]
	protected KJLMDBEEGDA MBEPHGAHJLN(KJLMDBEEGDA DFHOHFFNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x82A3230", Offset = "0x82A2030", VA = "0x1882A3230")]
	protected ALPLBKLEEFC[] OBJGOOBHPID(ALPLBKLEEFC KEMBGDAOLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x82A2220", Offset = "0x82A1020", VA = "0x1882A2220")]
	protected bool IOKMCOFAGII(DPLPABAANPI BCNMCDHKPLK, [Out] ALPLBKLEEFC DFHOHFFNCIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x82A1330", Offset = "0x82A0130", VA = "0x1882A1330", Slot = "15")]
	public bool EKNCLGOIGIK(DPLPABAANPI BCNMCDHKPLK, [Out] ECMJMKIDDNP OMJEADEGHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x82A1460", Offset = "0x82A0260", VA = "0x1882A1460")]
	protected ALPLBKLEEFC EMJKGFCGLIF(ECMJMKIDDNP PDFEJEIGMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x82A32D0", Offset = "0x82A20D0", VA = "0x1882A32D0", Slot = "10")]
	public bool OCHGHLGBLNO(DPLPABAANPI NIMHPPDKKKG, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x82A2330", Offset = "0x82A1130", VA = "0x1882A2330")]
	private bool KAMJECCCOMO(DPLPABAANPI NIMHPPDKKKG, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x82A3350", Offset = "0x82A2150", VA = "0x1882A3350")]
	private static bool PKOIOBLBHDE(ALPLBKLEEFC KLBLPNMDMMK, ECMJMKIDDNP EOBFCBNGKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x82A1C20", Offset = "0x82A0A20", VA = "0x1882A1C20", Slot = "7")]
	private bool OIKCLFNEPHO([In] DFGFPGILAJG KANAIIDGHCH, bool LCIMCINNIEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class CMDNBOLGGNG : EPFEKLMAJND, JDBGEACJNEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly HJFNEHLLJBB HPOMHCIJOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly AGPAIAEFPFA LEIEIBBJFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly KNBFEBICLKP KAOMOFECKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly OHKAKFPNEIL DHMGPMHFCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly DMPCFJFJIFJ CPOICOGAHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal FMMOJBHMCMI OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal GPHPJDECEON LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal JKJMMLHFKEO GGLPIHMENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool KGEBNLPBIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool CGMOKBJMCGP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LEJEGMHJLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAE9940", Offset = "0xAE8740", VA = "0x180AE9940")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAE9950", Offset = "0xAE8750", VA = "0x180AE9950")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KFLGDPOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB1E4D0", Offset = "0xB1D2D0", VA = "0x180B1E4D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xB1E520", Offset = "0xB1D320", VA = "0x180B1E520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BMCJECEGCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<DPLPABAANPI, DPLPABAANPI> HANGNNHAKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x829C2C0", Offset = "0x829B0C0", VA = "0x18829C2C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x829AD60", Offset = "0x8299B60", VA = "0x18829AD60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<DPLPABAANPI, DPLPABAANPI> BADEECEBMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x829ADC0", Offset = "0x8299BC0", VA = "0x18829ADC0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x829C260", Offset = "0x829B060", VA = "0x18829C260", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<DPLPABAANPI, DPLPABAANPI, DPLPABAANPI> GOGMJCDLAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x829AF20", Offset = "0x8299D20", VA = "0x18829AF20", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x829B500", Offset = "0x829A300", VA = "0x18829B500", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x829C810", Offset = "0x829B610", VA = "0x18829C810")]
	public CMDNBOLGGNG(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x829B6A0", Offset = "0x829A4A0", VA = "0x18829B6A0", Slot = "12")]
	public void IEHCJBEIMLK(GameObject DFFAMKHOIDB, MNGEMECMANL PEKGCMBPODM, OOPMGCPHKML NDHEIGJKNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x829B410", Offset = "0x829A210", VA = "0x18829B410", Slot = "26")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x829AB10", Offset = "0x8299910", VA = "0x18829AB10", Slot = "13")]
	public void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x829B4E0", Offset = "0x829A2E0", VA = "0x18829B4E0", Slot = "14")]
	public void FAIIODDINIJ(DPLPABAANPI BCNMCDHKPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x829B160", Offset = "0x8299F60", VA = "0x18829B160", Slot = "15")]
	public void IIOINIJEMOP(DPLPABAANPI BCNMCDHKPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x829BF00", Offset = "0x829AD00", VA = "0x18829BF00", Slot = "22")]
	public bool JHIBHIBLKGD(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x829C000", Offset = "0x829AE00", VA = "0x18829C000")]
	internal bool KAMJECCCOMO([In] DFGFPGILAJG KANAIIDGHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x829C110", Offset = "0x829AF10", VA = "0x18829C110")]
	internal bool KDJJAIIGEMD([In] DFGFPGILAJG KANAIIDGHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x829AF80", Offset = "0x8299D80", VA = "0x18829AF80")]
	internal void CMMEFENOCEJ(DPLPABAANPI BCNMCDHKPLK, int HNDODMNCMLI, bool LCIMCINNIEN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x829B160", Offset = "0x8299F60", VA = "0x18829B160")]
	internal bool DJONIHDFNPH(DPLPABAANPI IDIMHHPODPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x829B560", Offset = "0x829A360", VA = "0x18829B560")]
	internal bool FIHJPOICDIM(DPLPABAANPI LEOFPDMNNPM, int BDJOHJMMNOI, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x829AE20", Offset = "0x8299C20", VA = "0x18829AE20", Slot = "16")]
	public void BIIFGJBEBCI(DPLPABAANPI BCNMCDHKPLK, HashSet<DPLPABAANPI> LGDAIOAPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x829C320", Offset = "0x829B120", VA = "0x18829C320", Slot = "17")]
	public void NEEIJFAIEOP(DPLPABAANPI LEOFPDMNNPM, DPLPABAANPI PHADFJEKGPM, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x829C6D0", Offset = "0x829B4D0", VA = "0x18829C6D0", Slot = "18")]
	public void OKCOLILHFCC(DPLPABAANPI NIMHPPDKKKG, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x829AB90", Offset = "0x8299990", VA = "0x18829AB90", Slot = "19")]
	public void AGCGMBFODGF(DPLPABAANPI NIMHPPDKKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x829BCB0", Offset = "0x829AAB0", VA = "0x18829BCB0")]
	public void IFNGPPLLAGG([Optional] AFLCFHLHEHB BHFGGJOAMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x829B380", Offset = "0x829A180", VA = "0x18829B380", Slot = "23")]
	public void EECMCJAIJHO(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x829B1C0", Offset = "0x8299FC0", VA = "0x18829B1C0", Slot = "20")]
	public KGNLCKIHNBM DKDPNGMPFGN(bool LHFFBMJKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x829C530", Offset = "0x829B330", VA = "0x18829C530", Slot = "21")]
	public KGNLCKIHNBM NJIBFNNANND(HashSet<Guid> EFDNNGCNOPJ, bool LHFFBMJKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x829B340", Offset = "0x829A140", VA = "0x18829B340", Slot = "25")]
	public void DLJMCKEOHKL(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x829BF50", Offset = "0x829AD50", VA = "0x18829BF50", Slot = "24")]
	public void JOMIOGCCJPJ(KGNLCKIHNBM CPOICOGAHOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class AGPAIAEFPFA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly FLNBPEKPFIH<DPLPABAANPI, DPLPABAANPI> HANGNNHAKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly FLNBPEKPFIH<DPLPABAANPI, DPLPABAANPI> BADEECEBMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly PMFLBKNAJDA<DPLPABAANPI, DPLPABAANPI, DPLPABAANPI> GOGMJCDLAHA;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x82980B0", Offset = "0x8296EB0", VA = "0x1882980B0")]
	public AGPAIAEFPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	public void IEHCJBEIMLK(CMDNBOLGGNG EKOKCFOMOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8298050", Offset = "0x8296E50", VA = "0x188298050")]
	public void HAADIGFAGON(DPLPABAANPI PJGOIMBEKPK, DPLPABAANPI NKJCHADOMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8297FF0", Offset = "0x8296DF0", VA = "0x188297FF0")]
	public void GKAMGGPLNNE(DPLPABAANPI PJGOIMBEKPK, DPLPABAANPI NKJCHADOMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8297F70", Offset = "0x8296D70", VA = "0x188297F70")]
	public void DJNNDNOOJJO(DPLPABAANPI NMPEBJLLKBE, DPLPABAANPI HNDFKDHDHKN, DPLPABAANPI NKJCHADOMOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class KNBFEBICLKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private CMDNBOLGGNG EKOKCFOMOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private GPHPJDECEON LPOEOKNKAFK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KNBFEBICLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x829EF60", Offset = "0x829DD60", VA = "0x18829EF60")]
	public void IEHCJBEIMLK(CMDNBOLGGNG EKOKCFOMOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x829EEE0", Offset = "0x829DCE0", VA = "0x18829EEE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x829F0A0", Offset = "0x829DEA0", VA = "0x18829F0A0")]
	private void MNOFPEGAJIP(JCHCDPDFDDM GAILPBKIIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x829EEF0", Offset = "0x829DCF0", VA = "0x18829EEF0")]
	private void FAAGDJAINLF(AFLCFHLHEHB HJOAMDGBOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x829F0E0", Offset = "0x829DEE0", VA = "0x18829F0E0")]
	public void MPBLDAIEDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x829EDD0", Offset = "0x829DBD0", VA = "0x18829EDD0")]
	public void AKHJAMOFBAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FEIDPLBFNBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NJIOPBLDCDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public HJFNEHLLJBB container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NJIOPBLDCDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x82A9FB0", Offset = "0x82A8DB0", VA = "0x1882A9FB0")]
		internal CMDNBOLGGNG IPHPENPCOFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x829D750", Offset = "0x829C550", VA = "0x18829D750")]
	public static void BOBDKMHPHCM(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x829D950", Offset = "0x829C750", VA = "0x18829D950")]
	public static void MDIGHOMOCGG(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class HADLPFKNOOA : IDisposable, JKJMMLHFKEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, PIDJOMILKKC> KALGKKDHBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly HGBCJJPEOFD EFBBGEFNBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PNBJNMMNKCP IJIAOFHPIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private DMPCFJFJIFJ CPOICOGAHOC;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker HKIKNIFJGID;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x829E880", Offset = "0x829D680", VA = "0x18829E880")]
	public HADLPFKNOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x829E0A0", Offset = "0x829CEA0", VA = "0x18829E0A0", Slot = "7")]
	public void IEHCJBEIMLK(DMPCFJFJIFJ CPOICOGAHOC, PNBJNMMNKCP IJIAOFHPIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x829E430", Offset = "0x829D230", VA = "0x18829E430", Slot = "5")]
	public void LEGOMFPCAJF(KJLMDBEEGDA HIMHKCFHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x829DD70", Offset = "0x829CB70", VA = "0x18829DD70", Slot = "9")]
	public void DCLBIEEHOFA(KJLMDBEEGDA AFPBHNFMONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x829DEE0", Offset = "0x829CCE0", VA = "0x18829DEE0", Slot = "8")]
	public void EBBIKAAOAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x829E0E0", Offset = "0x829CEE0", VA = "0x18829E0E0", Slot = "10")]
	public void KFLELDPELEA(KJLMDBEEGDA PFIDEELJCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x829DBC0", Offset = "0x829C9C0", VA = "0x18829DBC0", Slot = "11")]
	public void CNCCEANMLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x829E670", Offset = "0x829D470", VA = "0x18829E670")]
	private bool OHLHMJOGDJP(KJLMDBEEGDA DPBDKFEONOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class OHKAKFPNEIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct BGAILNEAIFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly ALPLBKLEEFC IGNMPOLDHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> EFDNNGCNOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly GOKMFNHMGAG KFGLKIMJOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly GOKMFNHMGAG HLJCLJFOOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool LHFFBMJKNHL;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool BJJJPCODCLF
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8299450", Offset = "0x8298250", VA = "0x188299450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8299710", Offset = "0x8298510", VA = "0x188299710")]
		public BGAILNEAIFA(ALPLBKLEEFC IGNMPOLDHGG, HashSet<Guid> EFDNNGCNOPJ, bool LHFFBMJKNHL, [Optional] GOKMFNHMGAG KFGLKIMJOEE, [Optional] GOKMFNHMGAG HLJCLJFOOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8299570", Offset = "0x8298370", VA = "0x188299570")]
		public GOKMFNHMGAG OFACCHGGJAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8298E40", Offset = "0x8297C40", VA = "0x188298E40")]
		private GOKMFNHMGAG ADLHDFCPLGM([Out] GOKMFNHMGAG LBPCHINHJGE, [Out] GOKMFNHMGAG AKJOOIIHELL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8298F00", Offset = "0x8297D00", VA = "0x188298F00")]
		private GOKMFNHMGAG CFNLEJOGCLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x82992E0", Offset = "0x82980E0", VA = "0x1882992E0")]
		private void MLGJMMADPIL(GOKMFNHMGAG KPCAOGFNMBF, GOKMFNHMGAG PJIIMAHAICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8299120", Offset = "0x8297F20", VA = "0x188299120")]
		private void HBJCIGLKDGM(GOKMFNHMGAG LBPCHINHJGE, GOKMFNHMGAG AKJOOIIHELL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private CMDNBOLGGNG EKOKCFOMOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private DMPCFJFJIFJ CPOICOGAHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private JKJMMLHFKEO IBAMONLOCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private GPHPJDECEON LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool PKOIJIICINA;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool IANNKDFOPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x82ABAA0", Offset = "0x82AA8A0", VA = "0x1882ABAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool LEJEGMHJLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x82AC280", Offset = "0x82AB080", VA = "0x1882AC280")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x82AAE20", Offset = "0x82A9C20", VA = "0x1882AAE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x82AAE40", Offset = "0x82A9C40", VA = "0x1882AAE40")]
	public void IEHCJBEIMLK(CMDNBOLGGNG EKOKCFOMOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x82AA610", Offset = "0x82A9410", VA = "0x1882AA610")]
	public KGNLCKIHNBM DKDPNGMPFGN(bool LHFFBMJKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x82AC3B0", Offset = "0x82AB1B0", VA = "0x1882AC3B0")]
	public KGNLCKIHNBM NJIBFNNANND(HashSet<Guid> EFDNNGCNOPJ, bool LHFFBMJKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x82AA780", Offset = "0x82A9580", VA = "0x1882AA780")]
	public void EECMCJAIJHO(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x82ABAF0", Offset = "0x82AA8F0", VA = "0x1882ABAF0")]
	public void JOMIOGCCJPJ(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x82AA1F0", Offset = "0x82A8FF0", VA = "0x1882AA1F0")]
	public void BMFCHNCALJN(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x82AAC30", Offset = "0x82A9A30", VA = "0x1882AAC30")]
	private void HMPFNFHLLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x82AC640", Offset = "0x82AB440", VA = "0x1882AC640")]
	private GOKMFNHMGAG PJECBELGKMC(ALPLBKLEEFC DFHOHFFNCIJ, bool LHFFBMJKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x82AA3A0", Offset = "0x82A91A0", VA = "0x1882AA3A0")]
	private static void DAAGOJIPFDL(ALPLBKLEEFC DFHOHFFNCIJ, bool LHFFBMJKNHL, GOKMFNHMGAG ILCELEMMMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x82AB200", Offset = "0x82AA000", VA = "0x1882AB200")]
	private void IOPJACMLMEP(ALPLBKLEEFC DFHOHFFNCIJ, bool LHFFBMJKNHL, GOKMFNHMGAG ILCELEMMMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x82AC1F0", Offset = "0x82AAFF0", VA = "0x1882AC1F0")]
	private GOKMFNHMGAG MGDOHDJBHGN(ALPLBKLEEFC IGNMPOLDHGG, HashSet<Guid> EFDNNGCNOPJ, bool LHFFBMJKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x82AA810", Offset = "0x82A9610", VA = "0x1882AA810")]
	private bool GLICMEOGMDN(KGNLCKIHNBM IJDKLGEHBLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x82ABB90", Offset = "0x82AA990", VA = "0x1882ABB90")]
	private bool KLEFBNBCOBJ(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x82AA5F0", Offset = "0x82A93F0", VA = "0x1882AA5F0")]
	private bool DELBFJDJLIJ(KGNLCKIHNBM CPOICOGAHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x82AC2A0", Offset = "0x82AB0A0", VA = "0x1882AC2A0")]
	private static bool NEOBKEDIKOF(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x82AB5B0", Offset = "0x82AA3B0", VA = "0x1882AB5B0")]
	public static bool JHIBHIBLKGD(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x82AAEB0", Offset = "0x82A9CB0", VA = "0x1882AAEB0")]
	private DPLPABAANPI IGLBIJIBJNF(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x82AA220", Offset = "0x82A9020", VA = "0x1882AA220")]
	private DPLPABAANPI CCKLJBBPCLO(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x82AB420", Offset = "0x82AA220", VA = "0x1882AB420")]
	private DPLPABAANPI JBJBBLJDIED(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x82A7110", Offset = "0x82A5F10", VA = "0x1882A7110")]
	private static Guid IAOGODILDAO(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x82AC550", Offset = "0x82AB350", VA = "0x1882AC550")]
	private string OOPENPAEHBD(GOKMFNHMGAG ILCELEMMMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x82AAAA0", Offset = "0x82A98A0", VA = "0x1882AAAA0")]
	private bool HBDHAMOIIFF(ALPLBKLEEFC DFHOHFFNCIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x82AB840", Offset = "0x82AA640", VA = "0x1882AB840")]
	private static void JHMAJACIIJJ(ALPLBKLEEFC IGNMPOLDHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OHKAKFPNEIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct DFGFPGILAJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public DPLPABAANPI NKJCHADOMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public DPLPABAANPI PJGOIMBEKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int BDJOHJMMNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int MDOCMLCBGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 OBBBPEHENBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion LAPDLKCLKNC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ECMJMKIDDNP NCOFPNMGBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x829CD40", Offset = "0x829BB40", VA = "0x18829CD40")]
		get
		{
			return default(ECMJMKIDDNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public ECMJMKIDDNP MFNCABKOGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x829CD10", Offset = "0x829BB10", VA = "0x18829CD10")]
		get
		{
			return default(ECMJMKIDDNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x829CDE0", Offset = "0x829BBE0", VA = "0x18829CDE0")]
	public DFGFPGILAJG(DPLPABAANPI NKJCHADOMOJ, DPLPABAANPI PJGOIMBEKPK, int BDJOHJMMNOI, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface DMPCFJFJIFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KJLMDBEEGDA CNGEAHLGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEHCJBEIMLK(EPFEKLMAJND EKOKCFOMOOD);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HCCHMKFOFOI([In] DFGFPGILAJG KANAIIDGHCH, bool LCIMCINNIEN = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FEILHPBIJIF(DPLPABAANPI IBNMAIFDKJI);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LGIBNBLNCNP(DPLPABAANPI LEOFPDMNNPM, int BDJOHJMMNOI, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OCHGHLGBLNO(DPLPABAANPI NIMHPPDKKKG, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OMFMNINFGLH();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INDLIFJCFLC(Func<DPLPABAANPI, bool> NCIGOHOEGGD);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BIIFGJBEBCI(DPLPABAANPI BCNMCDHKPLK, HashSet<DPLPABAANPI> BMNPABOHLGE);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<DPLPABAANPI> IEDOHFNLCJD();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EKNCLGOIGIK(DPLPABAANPI BCNMCDHKPLK, [Out] ECMJMKIDDNP OMJEADEGHBG);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BEEJJOEIOJL(HGBCJJPEOFD LBJMJKFNAPH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool HGBCJJPEOFD(KJLMDBEEGDA DFHOHFFNCIJ);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KJLMDBEEGDA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DPLPABAANPI JDKCLIJLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KJLMDBEEGDA PJMJBHEBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ECMJMKIDDNP EINOGJOCDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CCJFNIKGMOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PIDJOMILKKC
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHDKBDCHLCM(DPLPABAANPI CHADLIJCIHO, ECMJMKIDDNP NKJCHADOMOJ);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEGCMJGCIJI(DPLPABAANPI CHADLIJCIHO, ECMJMKIDDNP NKJCHADOMOJ);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKOJEALIOPC(DPLPABAANPI CHADLIJCIHO, ECMJMKIDDNP NKJCHADOMOJ);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMNIOCJOIPI(DPLPABAANPI CHADLIJCIHO, ECMJMKIDDNP NKJCHADOMOJ);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PIDJOMILKKC Instantiate(Transform DNNOOFELIOA);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFDBANBONAB();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PNBJNMMNKCP
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEHCJBEIMLK(Transform DNNOOFELIOA, PIDJOMILKKC MMGDONCDDJI);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIDJOMILKKC BBBLBBKFKEO();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHFHMMECKOG(PIDJOMILKKC AKFOIMGNKFE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FMMOJBHMCMI : FOABOBOLCLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHFHLDLILPH();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJNGNDAIJDB(Guid GIFNCLMKCEA);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface JKJMMLHFKEO
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEGOMFPCAJF(KJLMDBEEGDA HIMHKCFHNJP);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEHCJBEIMLK(DMPCFJFJIFJ CPOICOGAHOC, PNBJNMMNKCP JDJDJLNHLHK);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBBIKAAOAPN();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCLBIEEHOFA(KJLMDBEEGDA AFPBHNFMONC);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFLELDPELEA(KJLMDBEEGDA PFIDEELJCAI);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CNCCEANMLFL();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class ALPLBKLEEFC : KJLMDBEEGDA
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AJPJNJKPNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public ECMJMKIDDNP nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public ALPLBKLEEFC foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AJPJNJKPNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x82981D0", Offset = "0x8296FD0", VA = "0x1882981D0")]
		internal bool EPIIAABKKDJ(KJLMDBEEGDA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private ECMJMKIDDNP OMJEADEGHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<ALPLBKLEEFC> OHHIJKHDBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ALPLBKLEEFC FFNNDELEINA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ECMJMKIDDNP EINOGJOCDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x15289C0", Offset = "0x15277C0", VA = "0x1815289C0", Slot = "6")]
		get
		{
			return default(ECMJMKIDDNP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1528EA0", Offset = "0x1527CA0", VA = "0x181528EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private ALPLBKLEEFC PJGOIMBEKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8298C90", Offset = "0x8297A90", VA = "0x188298C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KJLMDBEEGDA PJMJBHEBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DPLPABAANPI JDKCLIJLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CCJFNIKGMOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8298600", Offset = "0x8297400", VA = "0x188298600", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DJPCDCHHBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8298860", Offset = "0x8297660", VA = "0x188298860", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected ALPLBKLEEFC MMENCBNBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8298D70", Offset = "0x8297B70", VA = "0x188298D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8298D90", Offset = "0x8297B90", VA = "0x188298D90")]
	public ALPLBKLEEFC(ECMJMKIDDNP AJLLAKCONAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x82988B0", Offset = "0x82976B0", VA = "0x1882988B0")]
	public ALPLBKLEEFC JGFALDPOFMH(ECMJMKIDDNP FNFBFEIIILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8298310", Offset = "0x8297110", VA = "0x188298310")]
	public ALPLBKLEEFC BAPKMEFINKI(ECMJMKIDDNP LHCFDAJGBEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8298A00", Offset = "0x8297800", VA = "0x188298A00")]
	public ALPLBKLEEFC MDNHCHGJFLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8298710", Offset = "0x8297510", VA = "0x188298710")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8298BE0", Offset = "0x82979E0", VA = "0x188298BE0")]
	public ALPLBKLEEFC OKBLDPAHCHJ(ECMJMKIDDNP HNDFKDHDHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x82984A0", Offset = "0x82972A0", VA = "0x1882984A0")]
	private static void BEEJJOEIOJL(ALPLBKLEEFC OIGPPOGMMOD, HGBCJJPEOFD HOGFKMCBALA, bool BFECPFGKENA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8298490", Offset = "0x8297290", VA = "0x188298490", Slot = "9")]
	public void BEEJJOEIOJL(HGBCJJPEOFD LBJMJKFNAPH, bool NDECDHFKGLO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8298610", Offset = "0x8297410", VA = "0x188298610")]
	public static ALPLBKLEEFC EMJKGFCGLIF(ALPLBKLEEFC OIGPPOGMMOD, ECMJMKIDDNP IJPOADJNJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface GPHPJDECEON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IANNKDFOPJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool OEAHHMAJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<JCHCDPDFDDM> MNOFPEGAJIP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<AFLCFHLHEHB> FAAGDJAINLF;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MHDKBDCHLCM(CMDNBOLGGNG EKOKCFOMOOD, OOPMGCPHKML AGDANODEHFD);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NEEIJFAIEOP(DPLPABAANPI LEOFPDMNNPM, DPLPABAANPI PHADFJEKGPM, int BDJOHJMMNOI, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OKCOLILHFCC(DPLPABAANPI NIMHPPDKKKG, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EMLHHMNBAGI(KGNLCKIHNBM EPAGJAGGIJF, [Optional] AFLCFHLHEHB BHFGGJOAMJB);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IJFHHGBGOPF
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x829EA20", Offset = "0x829D820", VA = "0x18829EA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object MOIOIMEFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x829EA80", Offset = "0x829D880", VA = "0x18829EA80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x829E9D0", Offset = "0x829D7D0", VA = "0x18829E9D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class CCHHDAPDIHD : GPHPJDECEON, IDisposable, PCOBGDPJCFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private CMDNBOLGGNG EKOKCFOMOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private OOPMGCPHKML NDHEIGJKNON;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool IANNKDFOPJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8299AC0", Offset = "0x82988C0", VA = "0x188299AC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool OEAHHMAJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8299C50", Offset = "0x8298A50", VA = "0x188299C50", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView ECNDCIBHKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8299EF0", Offset = "0x8298CF0", VA = "0x188299EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<JCHCDPDFDDM> MNOFPEGAJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8299810", Offset = "0x8298610", VA = "0x188299810", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8299780", Offset = "0x8298580", VA = "0x188299780", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<AFLCFHLHEHB> FAAGDJAINLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x82998A0", Offset = "0x82986A0", VA = "0x1882998A0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8299B20", Offset = "0x8298920", VA = "0x188299B20", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8299BC0", Offset = "0x82989C0", VA = "0x188299BC0", Slot = "10")]
	public void MHDKBDCHLCM(CMDNBOLGGNG EKOKCFOMOOD, OOPMGCPHKML NDHEIGJKNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8299940", Offset = "0x8298740", VA = "0x188299940", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8299C90", Offset = "0x8298A90", VA = "0x188299C90", Slot = "11")]
	public void NEEIJFAIEOP(DPLPABAANPI LEOFPDMNNPM, DPLPABAANPI PHADFJEKGPM, int BDJOHJMMNOI, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8299DC0", Offset = "0x8298BC0", VA = "0x188299DC0", Slot = "12")]
	public void OKCOLILHFCC(DPLPABAANPI NIMHPPDKKKG, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8299990", Offset = "0x8298790", VA = "0x188299990", Slot = "13")]
	public void EMLHHMNBAGI(KGNLCKIHNBM EPAGJAGGIJF, [Optional] AFLCFHLHEHB BHFGGJOAMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x829A1C0", Offset = "0x8298FC0", VA = "0x18829A1C0")]
	[HMNKOIHOGHH]
	private void RpcMasterReparentNodes(DPLPABAANPI NIMHPPDKKKG, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8299FC0", Offset = "0x8298DC0", VA = "0x188299FC0")]
	[HMNKOIHOGHH]
	private void RpcMasterModifyNode(DPLPABAANPI LEOFPDMNNPM, DPLPABAANPI PHADFJEKGPM, int BDJOHJMMNOI, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x829A5C0", Offset = "0x82993C0", VA = "0x18829A5C0")]
	[HMNKOIHOGHH]
	private void RpcReparentNodes(DPLPABAANPI NIMHPPDKKKG, int ABNLLFEONKH, DPLPABAANPI HNDFKDHDHKN, int NHIDJBBEFDC, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC, PDCFLIPGAOH NGDLBLOAJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x829A4D0", Offset = "0x82992D0", VA = "0x18829A4D0")]
	[HMNKOIHOGHH]
	private void RpcModifyNode(DPLPABAANPI LEOFPDMNNPM, int BDJOHJMMNOI, int MDOCMLCBGAP, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC, PDCFLIPGAOH NGDLBLOAJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8299F80", Offset = "0x8298D80", VA = "0x188299F80")]
	[HMNKOIHOGHH]
	private void RpcDeserializeConnectableGraph(KGNLCKIHNBM CPOICOGAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CCHHDAPDIHD()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, PIDJOMILKKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x829F880", Offset = "0x829E680", VA = "0x18829F880", Slot = "4")]
		private void PGPMAOFGHHB(DPLPABAANPI CHADLIJCIHO, ECMJMKIDDNP NKJCHADOMOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x829F1F0", Offset = "0x829DFF0", VA = "0x18829F1F0", Slot = "5")]
		private void CDFAJAKGEGI(DPLPABAANPI CHADLIJCIHO, ECMJMKIDDNP NKJCHADOMOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x829F6C0", Offset = "0x829E4C0", VA = "0x18829F6C0", Slot = "6")]
		private void NDLLDHMNAIJ(DPLPABAANPI CHADLIJCIHO, ECMJMKIDDNP NKJCHADOMOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x829F4D0", Offset = "0x829E2D0", VA = "0x18829F4D0", Slot = "7")]
		private void EFKGOBGEPBN(DPLPABAANPI CHADLIJCIHO, ECMJMKIDDNP NKJCHADOMOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x829F460", Offset = "0x829E260", VA = "0x18829F460", Slot = "8")]
		private PIDJOMILKKC COAAKOFFNPD(Transform DNNOOFELIOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x829F820", Offset = "0x829E620", VA = "0x18829F820", Slot = "9")]
		private void NJICEEJIGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DOPNDLPLPEP
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F410", Offset = "0x3B5E210", VA = "0x183B5F410")]
	public static LGLINHNIDAE<T> DKHIEHDJGCC<T>(this HJFNEHLLJBB HPOMHCIJOHD)
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
