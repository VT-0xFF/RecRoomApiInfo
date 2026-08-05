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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7ED38B0", Offset = "0x7ED1EB0", VA = "0x187ED38B0", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2251A10", Offset = "0x2250010", VA = "0x182251A10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7780", Offset = "0x7ED5D80", VA = "0x187ED7780")]
		private void FKDKBEPAOOM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7ED78F0", Offset = "0x7ED5EF0", VA = "0x187ED78F0")]
		private void HCPAJCJNEGO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7A60", Offset = "0x7ED6060", VA = "0x187ED7A60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7DA0", Offset = "0x7ED63A0", VA = "0x187ED7DA0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class IEMLMMLMJJM : GOAACIPBCGD, JFAKIPDGBHA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class IMHAAIOMBEP : IEnumerable<APLFKIFOKDH>, IEnumerable, IEnumerator<APLFKIFOKDH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private APLFKIFOKDH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DAHJHHJGHIB localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public DAHJHHJGHIB <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public IEMLMMLMJJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NNEPMGCDLOI <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private IIKPNIBMDFG <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private IIKPNIBMDFG.LKFEKHGMJEE <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private APLFKIFOKDH System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public IMHAAIOMBEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE360", Offset = "0x7ECC960", VA = "0x187ECE360", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDEE0", Offset = "0x7ECC4E0", VA = "0x187ECDEE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDEC0", Offset = "0x7ECC4C0", VA = "0x187ECDEC0")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE240", Offset = "0x7ECC840", VA = "0x187ECE240")]
		private void NECCDOCMECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE310", Offset = "0x7ECC910", VA = "0x187ECE310", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE260", Offset = "0x7ECC860", VA = "0x187ECE260", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<APLFKIFOKDH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE260", Offset = "0x7ECC860", VA = "0x187ECE260", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BGGCMJLPGIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public IEMLMMLMJJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ODNFMHOMGMG nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BGGCMJLPGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2C50", Offset = "0x7EC1250", VA = "0x187EC2C50")]
		internal object AANAAPJPHCD(ODNFMHOMGMG x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DMHGGMPDLEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ODNFMHOMGMG child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BGGCMJLPGIO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DMHGGMPDLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7EC4400", Offset = "0x7EC2A00", VA = "0x187EC4400")]
		internal object ICCGCBHLBMI((ODNFMHOMGMG child, ODNFMHOMGMG nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly LHMKAIAPMBI GIMDOGEAFJP;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly LHMKAIAPMBI CPBJJBJOONE;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly LHMKAIAPMBI LDGAPIMAEJD;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly LHMKAIAPMBI NMMBGDIBECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EGNFIJCEPIJ DJEMCCCNJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KGOKLMGHDGG BCEMINIMFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private HDFJJJHIDHC CFBMOHOBDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private IICANHEJHNJ ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private FOKLIOBGGNN DHBBLFMACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EBAHIDFIMHO OANOGEDFJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NHAJEMBLBNA KIIAJJAGEIB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FLBBOPEIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA50DF0", Offset = "0xA4F3F0", VA = "0x180A50DF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA50E10", Offset = "0xA4F410", VA = "0x180A50E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NLMPFEJEIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<APLFKIFOKDH, APLFKIFOKDH> LINOGAPPPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA8D0", Offset = "0x7EC8ED0", VA = "0x187ECA8D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9C80", Offset = "0x7EC8280", VA = "0x187EC9C80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<APLFKIFOKDH, APLFKIFOKDH> JFGIFDLLJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD180", Offset = "0x7ECB780", VA = "0x187ECD180", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB420", Offset = "0x7EC9A20", VA = "0x187ECB420", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<APLFKIFOKDH, APLFKIFOKDH, APLFKIFOKDH> PLOFENAILGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD8C0", Offset = "0x7ECBEC0", VA = "0x187ECD8C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB020", Offset = "0x7EC9620", VA = "0x187ECB020", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDBD0", Offset = "0x7ECC1D0", VA = "0x187ECDBD0")]
	public IEMLMMLMJJM(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD90", Offset = "0x7EC9390", VA = "0x187ECAD90", Slot = "12")]
	public void FLMOPKJJIJF(GameObject KGMBEOBCDCB, EFEEFHKLJPI KOIEDKJJCMF, DBMEGIMHNHC NDLIFLFKGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC0C0", Offset = "0x7ECA6C0", VA = "0x187ECC0C0", Slot = "26")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBB10", Offset = "0x7ECA110", VA = "0x187ECBB10", Slot = "22")]
	public bool JEIPMMFLDIH(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBCD0", Offset = "0x7ECA2D0", VA = "0x187ECBCD0")]
	private void JHNKLMJNANI(DAHJHHJGHIB FLAMBECDGHO, DAHJHHJGHIB IKHIAPIFLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD6A0", Offset = "0x7ECBCA0", VA = "0x187ECD6A0")]
	private void PDFFOKLKBND(DAHJHHJGHIB FLAMBECDGHO, DAHJHHJGHIB CCHLJMBAEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD440", Offset = "0x7ECBA40", VA = "0x187ECD440")]
	private void PBACOJCIMKH(DAHJHHJGHIB FLAMBECDGHO, DAHJHHJGHIB CCHLJMBAEFB, DAHJHHJGHIB IKHIAPIFLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7ECA980", Offset = "0x7EC8F80", VA = "0x187ECA980")]
	private void FJOPGGAFMCI(DAHJHHJGHIB FLAMBECDGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "13")]
	public void IEMAIHNOLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9980", Offset = "0x7EC7F80", VA = "0x187EC9980", Slot = "14")]
	public void CCHHFLKMKEK(APLFKIFOKDH KMEGNEJIGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "15")]
	public void PAEMAGCOOJI(APLFKIFOKDH KMEGNEJIGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB870", Offset = "0x7EC9E70", VA = "0x187ECB870", Slot = "17")]
	public void JBAMDHAOENK(APLFKIFOKDH KMEGNEJIGOP, APLFKIFOKDH JOKFAHFBNMM, Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB9D0", Offset = "0x7EC9FD0", VA = "0x187ECB9D0")]
	public void JBAMDHAOENK(DAHJHHJGHIB JDOHELGNGHJ, DAHJHHJGHIB JOKFAHFBNMM, Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9410", Offset = "0x7EC7A10", VA = "0x187EC9410")]
	public void BGMBBFGIMBD(APLFKIFOKDH KMEGNEJIGOP, float ADNFJIEHGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB0D0", Offset = "0x7EC96D0", VA = "0x187ECB0D0", Slot = "18")]
	public void GBHEACNCOJP(APLFKIFOKDH BHBHKCNDLFJ, int GGGEILJDDCG, APLFKIFOKDH LHNAJKLAKBI, int OFBFBOINJNL, Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB370", Offset = "0x7EC9970", VA = "0x187ECB370")]
	private float GJJDPCNHDKB(DAHJHHJGHIB JDOHELGNGHJ, DAHJHHJGHIB NBIJLPJHNNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB230", Offset = "0x7EC9830", VA = "0x187ECB230")]
	public void GBHEACNCOJP(DAHJHHJGHIB JDOHELGNGHJ, DAHJHHJGHIB NBIJLPJHNNE, Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII, bool PDPFNKAMFKL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBB60", Offset = "0x7ECA160", VA = "0x187ECBB60", Slot = "19")]
	public void JEPNEKHOKJI(APLFKIFOKDH KMEGNEJIGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD230", Offset = "0x7ECB830", VA = "0x187ECD230", Slot = "16")]
	public void OAGLECEEKMO(APLFKIFOKDH KMEGNEJIGOP, HashSet<APLFKIFOKDH> CBNEFBMPLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "20")]
	public MILLFFLLMNA JMDIMHMELMC(bool EIFKJONKELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "21")]
	public MILLFFLLMNA DEIDAIHOFCJ(HashSet<Guid> KHBIEGNDMPP, bool EIFKJONKELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9EB0", Offset = "0x7EC84B0", VA = "0x187EC9EB0", Slot = "23")]
	public void DLGMDCCJCGK(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB6F0", Offset = "0x7EC9CF0", VA = "0x187ECB6F0", Slot = "24")]
	public void IKBLHENMNEH(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC630", Offset = "0x7ECAC30", VA = "0x187ECC630", Slot = "25")]
	public void MLDDAENFLNC(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCD80", Offset = "0x7ECB380", VA = "0x187ECCD80")]
	private void NGBFFJJBMLB(DAHJHHJGHIB JDOHELGNGHJ, DAHJHHJGHIB NBIJLPJHNNE, Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII, float ADNFJIEHGHC, bool PDPFNKAMFKL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9FC0", Offset = "0x7EC85C0", VA = "0x187EC9FC0")]
	private void EGPKMKECFEB(DAHJHHJGHIB JDOHELGNGHJ, DAHJHHJGHIB BADBAFBEKHJ, Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9120", Offset = "0x7EC7720", VA = "0x187EC9120")]
	private void AHGDOMHAPIP(DAHJHHJGHIB JDOHELGNGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB660", Offset = "0x7EC9C60", VA = "0x187ECB660")]
	[IteratorStateMachine(typeof(IMHAAIOMBEP))]
	public IEnumerable<APLFKIFOKDH> IJEBDJLCFCF(DAHJHHJGHIB OHGBPBLOAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7EC94A0", Offset = "0x7EC7AA0", VA = "0x187EC94A0")]
	internal APLFKIFOKDH BJHPNIHKMME(DAHJHHJGHIB OHGBPBLOAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCBF0", Offset = "0x7ECB1F0", VA = "0x187ECCBF0")]
	internal DAHJHHJGHIB NADMJLJHANM(APLFKIFOKDH KMEGNEJIGOP)
	{
		return default(DAHJHHJGHIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC650", Offset = "0x7ECAC50", VA = "0x187ECC650")]
	private bool MPLMMBFGHLG(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9F60", Offset = "0x7EC8560", VA = "0x187EC9F60")]
	private bool EEHFEKDPHID(ODNFMHOMGMG ANABIAJOBHJ, [Out] APLFKIFOKDH NBIJLPJHNNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7EC95D0", Offset = "0x7EC7BD0", VA = "0x187EC95D0")]
	private APLFKIFOKDH BJHPNIHKMME(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9D30", Offset = "0x7EC8330", VA = "0x187EC9D30")]
	private APLFKIFOKDH CMKPHGJFAFI(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBEE0", Offset = "0x7ECA4E0", VA = "0x187ECBEE0")]
	private APLFKIFOKDH KACKDICCGJD(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9F20", Offset = "0x7EC8520", VA = "0x187EC9F20")]
	private static Guid DMIMIADOJNG(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD970", Offset = "0x7ECBF70", VA = "0x187ECD970")]
	private string PGPHMBHNACA(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB4D0", Offset = "0x7EC9AD0", VA = "0x187ECB4D0")]
	private void IBAFBNHJHLK(APLFKIFOKDH JDOHELGNGHJ, APLFKIFOKDH BADBAFBEKHJ, RigidTransform PFNFBELHBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC310", Offset = "0x7ECA910", VA = "0x187ECC310")]
	private void LNMGAHCOFEB(APLFKIFOKDH BADBAFBEKHJ, APLFKIFOKDH JDOHELGNGHJ, RigidTransform PFNFBELHBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC2B0", Offset = "0x7ECA8B0", VA = "0x187ECC2B0")]
	private void LJBNOECNJGA(APLFKIFOKDH GGFNABANHGE, APLFKIFOKDH JDOHELGNGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC4A0", Offset = "0x7ECAAA0", VA = "0x187ECC4A0")]
	private void MHNBMNFAJCD(APLFKIFOKDH JDOHELGNGHJ, APLFKIFOKDH NBIJLPJHNNE, RigidTransform PFNFBELHBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB760", Offset = "0x7EC9D60", VA = "0x187ECB760")]
	private void IMKACPFPCOO(DAHJHHJGHIB OHGBPBLOAKN, APLFKIFOKDH KMEGNEJIGOP, DAHJHHJGHIB CCHLJMBAEFB, DAHJHHJGHIB IKHIAPIFLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9190", Offset = "0x7EC7790", VA = "0x187EC9190")]
	private void BCLLJNILNFD(DAHJHHJGHIB OHGBPBLOAKN, APLFKIFOKDH KMEGNEJIGOP, APLFKIFOKDH PIBGLJMNHOG, APLFKIFOKDH ADGIOGOLHAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BKOCKANHJIJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IEKIILELFDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public DCNOMJHNEOK container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IEKIILELFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9070", Offset = "0x7EC7670", VA = "0x187EC9070")]
		internal IEMLMMLMJJM MFFCGDEDMGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2D10", Offset = "0x7EC1310", VA = "0x187EC2D10")]
	public static void JCHKLKGEODF(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2CC0", Offset = "0x7EC12C0", VA = "0x187EC2CC0")]
	public static void BNKEPMPCINE(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HHODKHEKIBI : IAEEPMDDHHK, KBMFHFLFHOB
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEMLMMLMJJM MEINKPMCHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly CBOGAMJCCCP AMOFNBICCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly FLOOOCGLDBF ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly PKBALAMPKOB[] IFHGPBMLIAI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public APLFKIFOKDH MEKADEEFMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8E50", Offset = "0x7EC7450", VA = "0x187EC8E50", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public APLFKIFOKDH GHPLFCPIIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7960", Offset = "0x7EC5F60", VA = "0x187EC7960", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 PJEPIKFIFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7EC73C0", Offset = "0x7EC59C0", VA = "0x187EC73C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion IPFMLNEJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7310", Offset = "0x7EC5910", VA = "0x187EC7310", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DBIBBJLDMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8500", Offset = "0x7EC6B00", VA = "0x187EC8500", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<APLFKIFOKDH> PJBONPADFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7640", Offset = "0x7EC5C40", VA = "0x187EC7640", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool NMHOBHEMODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xCCADB0", Offset = "0xCC93B0", VA = "0x180CCADB0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCFFB40", Offset = "0xCFE140", VA = "0x180CFFB40", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9050", Offset = "0x7EC7650", VA = "0x187EC9050", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject IOJHMLDNPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8D70", Offset = "0x7EC7370", VA = "0x187EC8D70", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8D90", Offset = "0x7EC7390", VA = "0x187EC8D90", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid JDMJEBJLFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8EB0", Offset = "0x7EC74B0", VA = "0x187EC8EB0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BMMDBLOJHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8F90", Offset = "0x7EC7590", VA = "0x187EC8F90", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LGPKNFAIKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool HOEAJNHFPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7480", Offset = "0x7EC5A80", VA = "0x187EC7480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event HAPNDEDJOKK IMABHJLPNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8070", Offset = "0x7EC6670", VA = "0x187EC8070", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7EC84A0", Offset = "0x7EC6AA0", VA = "0x187EC84A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HAPNDEDJOKK BEPHBFOELML
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7420", Offset = "0x7EC5A20", VA = "0x187EC7420", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8440", Offset = "0x7EC6A40", VA = "0x187EC8440", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HAPNDEDJOKK AMMKJIIKMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7A20", Offset = "0x7EC6020", VA = "0x187EC7A20", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8310", Offset = "0x7EC6910", VA = "0x187EC8310", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event EBGNCPFBNMD JBOHCEMPKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7EC76C0", Offset = "0x7EC5CC0", VA = "0x187EC76C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7270", Offset = "0x7EC5870", VA = "0x187EC7270", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8C70", Offset = "0x7EC7270", VA = "0x187EC8C70")]
	public HHODKHEKIBI(DAHJHHJGHIB HJMEJBNHKHM, RigidbodyEx ALKKIHFIKDP, CBOGAMJCCCP AMOFNBICCBG, PKBALAMPKOB[] IFHGPBMLIAI, FLOOOCGLDBF ACIHABPADPI, GOAACIPBCGD MEINKPMCHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7EC80D0", Offset = "0x7EC66D0", VA = "0x187EC80D0", Slot = "19")]
	public void JPNPNACFNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "21")]
	public void BCGLIBPEOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEB40", Offset = "0x7BFD140", VA = "0x187BFEB40", Slot = "22")]
	public void IJDNENANOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7370", Offset = "0x7EC5970", VA = "0x187EC7370", Slot = "20")]
	public void BNJPFDALMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8100", Offset = "0x7EC6700", VA = "0x187EC8100", Slot = "25")]
	public void KLAECKJKDHL(int HBHOAEBGOIP, APLFKIFOKDH LHNAJKLAKBI, int JDODEHNKPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8370", Offset = "0x7EC6970", VA = "0x187EC8370", Slot = "26")]
	public void KNHANCLLMKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7A80", Offset = "0x7EC6080", VA = "0x187EC7A80", Slot = "27")]
	public void IIDAENKBMEF(int HBHOAEBGOIP, APLFKIFOKDH BHBHKCNDLFJ, int HIGPMOEJOIF, [Optional] Vector3? LEMKBBMDECK, [Optional] Quaternion? KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7570", Offset = "0x7EC5B70", VA = "0x187EC7570", Slot = "28")]
	public void DINHNBCEHLM(APLFKIFOKDH BHBHKCNDLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8570", Offset = "0x7EC6B70", VA = "0x187EC8570", Slot = "31")]
	public void NGLPINCIFJB(Vector3 KJCDAGDMCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7D60", Offset = "0x7EC6360", VA = "0x187EC7D60", Slot = "29")]
	public void IOLEBEGBMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8980", Offset = "0x7EC6F80", VA = "0x187EC8980", Slot = "30")]
	public void PEFIINFMCCN(int KHMHPNKMLMD, Vector3 JPAIMFCOEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7890", Offset = "0x7EC5E90", VA = "0x187EC7890", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int HBHOAEBGOIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7760", Offset = "0x7EC5D60", VA = "0x187EC7760", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int HBHOAEBGOIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xCA86C0", Offset = "0xCA6CC0", VA = "0x180CA86C0", Slot = "42")]
	public Color GetConnectionSlotColor(int HBHOAEBGOIP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC74D0", Offset = "0x7EC5AD0", VA = "0x187EC74D0", Slot = "43")]
	public bool CanConnectTo(int HBHOAEBGOIP, APLFKIFOKDH ABCIHBACEHL, int NIDGOEEBMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "44")]
	public void ParentChanged(int HBHOAEBGOIP, APLFKIFOKDH IFHPLKHJALD, int FINMENIDOAM, Vector3 AFMKEKPCNGG, Quaternion HKEDDJEFNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "45")]
	public void ChildAdded(int HBHOAEBGOIP, APLFKIFOKDH IBBIBELPNOB, int MBMEOKJOOLP, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "46")]
	public void ChildRemoved(int HBHOAEBGOIP, APLFKIFOKDH EPNHDHMMCFD, int PKPJEGNKMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "47")]
	public void ConnectionModified(int HBHOAEBGOIP, APLFKIFOKDH LHNAJKLAKBI, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8BC0", Offset = "0x7EC71C0", VA = "0x187EC8BC0", Slot = "48")]
	public void RootChanged(APLFKIFOKDH GIAJCPLOBOL, APLFKIFOKDH JHBPFLKECNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7EC8B70", Offset = "0x7EC7170", VA = "0x187EC8B70", Slot = "23")]
	public void PMIGHHIBEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7670", Offset = "0x7EC5C70", VA = "0x187EC7670", Slot = "24")]
	public void GFCEOBPNONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7EC75F0", Offset = "0x7EC5BF0", VA = "0x187EC75F0")]
	private void FBCENHDCAIH(bool BEAODNOMJKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(NPLEHCFGHOL), new string[] { })]
public class OGMFJOKPJGK : NPLEHCFGHOL, IJNPAMHNAJF, IELEAPKDCBK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class GPKLMHNIKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GPKLMHNIKHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private CLLAMCDDCOD ILIOCACLGDN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object ACKLDMPHOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7ED3E40", Offset = "0x7ED2440", VA = "0x187ED3E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3DF0", Offset = "0x7ED23F0", VA = "0x187ED3DF0", Slot = "5")]
	private void FNAOMNCODMK(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x121E280", Offset = "0x121C880", VA = "0x18121E280", Slot = "6")]
	private void MPJIHLCOJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public OGMFJOKPJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(GOAACIPBCGD), new string[] { "Ignore", "Mock" })]
public class EHENMPNHGDE : GOAACIPBCGD, JFAKIPDGBHA
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool FLBBOPEIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NLMPFEJEIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<APLFKIFOKDH, APLFKIFOKDH> LINOGAPPPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7EC4D00", Offset = "0x7EC3300", VA = "0x187EC4D00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7EC4C50", Offset = "0x7EC3250", VA = "0x187EC4C50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<APLFKIFOKDH, APLFKIFOKDH> JFGIFDLLJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC4F10", Offset = "0x7EC3510", VA = "0x187EC4F10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7EC4E60", Offset = "0x7EC3460", VA = "0x187EC4E60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<APLFKIFOKDH, APLFKIFOKDH, APLFKIFOKDH> PLOFENAILGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7EC4FC0", Offset = "0x7EC35C0", VA = "0x187EC4FC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7EC4DB0", Offset = "0x7EC33B0", VA = "0x187EC4DB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "26")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "12")]
	public void FLMOPKJJIJF(GameObject KGMBEOBCDCB, EFEEFHKLJPI KOIEDKJJCMF, DBMEGIMHNHC EGKLIIJKNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "13")]
	public void IEMAIHNOLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "14")]
	public void CCHHFLKMKEK(APLFKIFOKDH KMEGNEJIGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "15")]
	public void PAEMAGCOOJI(APLFKIFOKDH KMEGNEJIGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "16")]
	public void OAGLECEEKMO(APLFKIFOKDH KMEGNEJIGOP, HashSet<APLFKIFOKDH> CBNEFBMPLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "17")]
	public void JBAMDHAOENK(APLFKIFOKDH KMEGNEJIGOP, APLFKIFOKDH JOKFAHFBNMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "18")]
	public void GBHEACNCOJP(APLFKIFOKDH KMEGNEJIGOP, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "19")]
	public void JEPNEKHOKJI(APLFKIFOKDH KMEGNEJIGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "20")]
	public MILLFFLLMNA JMDIMHMELMC(bool EIFKJONKELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "21")]
	public MILLFFLLMNA DEIDAIHOFCJ(HashSet<Guid> KHBIEGNDMPP, bool EIFKJONKELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "22")]
	public bool JEIPMMFLDIH(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "23")]
	public void DLGMDCCJCGK(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "24")]
	public void IKBLHENMNEH(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "25")]
	public void MLDDAENFLNC(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EHENMPNHGDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface APLFKIFOKDH : KBMFHFLFHOB, IEquatable<APLFKIFOKDH>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KBMFHFLFHOB
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	APLFKIFOKDH MEKADEEFMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject IOJHMLDNPHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid JDMJEBJLFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int BMMDBLOJHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LGPKNFAIKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int HBHOAEBGOIP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int HBHOAEBGOIP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int HBHOAEBGOIP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int HBHOAEBGOIP, APLFKIFOKDH ABCIHBACEHL, int AAMJJHHDIKO);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int HBHOAEBGOIP, APLFKIFOKDH IFHPLKHJALD, int FINMENIDOAM, Vector3 AFMKEKPCNGG, Quaternion HKEDDJEFNDD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int HBHOAEBGOIP, APLFKIFOKDH IBBIBELPNOB, int MBMEOKJOOLP, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int HBHOAEBGOIP, APLFKIFOKDH EPNHDHMMCFD, int PKPJEGNKMAB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int HBHOAEBGOIP, APLFKIFOKDH LHNAJKLAKBI, int EPDOKLFJHKG, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(APLFKIFOKDH GIAJCPLOBOL, APLFKIFOKDH JHBPFLKECNF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GOAACIPBCGD : JFAKIPDGBHA
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FLBBOPEIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool NLMPFEJEIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<APLFKIFOKDH, APLFKIFOKDH> LINOGAPPPCG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<APLFKIFOKDH, APLFKIFOKDH> JFGIFDLLJFL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<APLFKIFOKDH, APLFKIFOKDH, APLFKIFOKDH> PLOFENAILGI;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FLMOPKJJIJF(GameObject KGMBEOBCDCB, EFEEFHKLJPI KOIEDKJJCMF, DBMEGIMHNHC GICHKKDOFJJ);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IEMAIHNOLMJ();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CCHHFLKMKEK(APLFKIFOKDH KMEGNEJIGOP);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PAEMAGCOOJI(APLFKIFOKDH KMEGNEJIGOP);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OAGLECEEKMO(APLFKIFOKDH KMEGNEJIGOP, HashSet<APLFKIFOKDH> CBNEFBMPLJO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JBAMDHAOENK(APLFKIFOKDH KMEGNEJIGOP, APLFKIFOKDH JOKFAHFBNMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GBHEACNCOJP(APLFKIFOKDH KMEGNEJIGOP, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JEPNEKHOKJI(APLFKIFOKDH KMEGNEJIGOP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MILLFFLLMNA JMDIMHMELMC(bool EIFKJONKELA);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MILLFFLLMNA DEIDAIHOFCJ(HashSet<Guid> KHBIEGNDMPP, bool EIFKJONKELA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JEIPMMFLDIH(ODNFMHOMGMG ANABIAJOBHJ);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DLGMDCCJCGK(MILLFFLLMNA FCPCBIGAPJJ);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IKBLHENMNEH(MILLFFLLMNA FCPCBIGAPJJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MLDDAENFLNC(MILLFFLLMNA FCPCBIGAPJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IICANHEJHNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	APLFKIFOKDH KACKDICCGJD(int MFJHNBBEAJM);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	APLFKIFOKDH CMKPHGJFAFI(Guid IOMLINOLEAC);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FNKEHKIAONP(APLFKIFOKDH KMEGNEJIGOP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CMPBEJIODPC();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPJMMANAOFL(APLFKIFOKDH AMOFNBICCBG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface FLOOOCGLDBF
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOEAJNHFPBH(CBOGAMJCCCP AMOFNBICCBG);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JOECCDEMMBA(CBOGAMJCCCP AMOFNBICCBG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string DFDMFKJJDBP(CBOGAMJCCCP AMOFNBICCBG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid DHNFEDKMCBL(CBOGAMJCCCP AMOFNBICCBG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int EJKBDILOILD(CBOGAMJCCCP AMOFNBICCBG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OJBDFGOLOBF(CBOGAMJCCCP AMOFNBICCBG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void HAPNDEDJOKK(APLFKIFOKDH BHBHKCNDLFJ, int LBEELNMCJNM, APLFKIFOKDH LHNAJKLAKBI, int DJPPHBPGOMG, [Optional] Vector3? LEMKBBMDECK, [Optional] Quaternion? KOAPCOJKAJK);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void EBGNCPFBNMD(APLFKIFOKDH GIAJCPLOBOL, APLFKIFOKDH JHBPFLKECNF);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CBOGAMJCCCP : APLFKIFOKDH, KBMFHFLFHOB, IEquatable<APLFKIFOKDH>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IAEEPMDDHHK : KBMFHFLFHOB
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	APLFKIFOKDH GHPLFCPIIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<APLFKIFOKDH> PJBONPADFED
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 PJEPIKFIFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion IPFMLNEJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool DBIBBJLDMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool NMHOBHEMODB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event HAPNDEDJOKK IMABHJLPNEP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event HAPNDEDJOKK BEPHBFOELML;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HAPNDEDJOKK AMMKJIIKMAO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event EBGNCPFBNMD JBOHCEMPKOG;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JPNPNACFNCO();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BNJPFDALMCI();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BCGLIBPEOPL();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IJDNENANOKA();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PMIGHHIBEEH();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GFCEOBPNONE();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KLAECKJKDHL(int HBHOAEBGOIP, APLFKIFOKDH LHNAJKLAKBI, int JDODEHNKPMM);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KNHANCLLMKP();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IIDAENKBMEF(int HBHOAEBGOIP, APLFKIFOKDH BHBHKCNDLFJ, int HIGPMOEJOIF, [Optional] Vector3? LEMKBBMDECK, [Optional] Quaternion? KOAPCOJKAJK);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DINHNBCEHLM(APLFKIFOKDH BHBHKCNDLFJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void IOLEBEGBMPK();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PEFIINFMCCN(int KHMHPNKMLMD, Vector3 JPAIMFCOEEF);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NGLPINCIFJB(Vector3 KJCDAGDMCME);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PKBALAMPKOB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 PLDAGAOMOFL
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
public interface EFEEFHKLJPI
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool BJCPIOKCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DCHIIBEABMA ABDCEDJJKON
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, EFEEFHKLJPI
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
			[Cpp2IlInjected.Address(RVA = "0xAA5D80", Offset = "0xAA4380", VA = "0x180AA5D80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public DCHIIBEABMA LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7EC42F0", Offset = "0x7EC28F0", VA = "0x187EC42F0")]
		public static ConnectableConfigData DOJLLOOPGGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7EC43B0", Offset = "0x7EC29B0", VA = "0x187EC43B0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual PLPNNFOLLKA, bool DCFEOFMOCED)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DNDBEDENKIB : IEquatable<DNDBEDENKIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public APLFKIFOKDH KMEGNEJIGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int EHGJOAMMNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int EPDOKLFJHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 LEMKBBMDECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion KOAPCOJKAJK;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4BF0", Offset = "0x7EC31F0", VA = "0x187EC4BF0")]
	public DNDBEDENKIB(APLFKIFOKDH KMEGNEJIGOP, int EHGJOAMMNGG, int EPDOKLFJHKG, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4AC0", Offset = "0x7EC30C0", VA = "0x187EC4AC0")]
	public DNDBEDENKIB(APLFKIFOKDH KMEGNEJIGOP, int EHGJOAMMNGG, int EPDOKLFJHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4B60", Offset = "0x7EC3160", VA = "0x187EC4B60")]
	public DNDBEDENKIB(APLFKIFOKDH KMEGNEJIGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4650", Offset = "0x7EC2C50", VA = "0x187EC4650", Slot = "4")]
	public bool Equals(DNDBEDENKIB HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4700", Offset = "0x7EC2D00", VA = "0x187EC4700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class HGLFOHBDOEN : AKGDFAOCKCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform DFOHJKCGEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private DCHIIBEABMA OOMDKDANOML;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x787FD80", Offset = "0x787E380", VA = "0x18787FD80", Slot = "4")]
	public void FLMOPKJJIJF(Transform DFOHJKCGEGI, DCHIIBEABMA OOMDKDANOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7EC71B0", Offset = "0x7EC57B0", VA = "0x187EC71B0", Slot = "5")]
	public DCHIIBEABMA KDNABNHEPEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7140", Offset = "0x7EC5740", VA = "0x187EC7140", Slot = "6")]
	public void FDHEANLABHL(DCHIIBEABMA AFBLPELCALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HGLFOHBDOEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class PCNCIBPGJGI : IDisposable, AGGLKCONHMN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EJJBMKAINFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public APLFKIFOKDH oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public APLFKIFOKDH newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EJJBMKAINFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7EC5070", Offset = "0x7EC3670", VA = "0x187EC5070")]
		internal bool GACBGEBPLME(HIOIHFFBIKA node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly CAHCDIJBEOF LHAHKAIEDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private BJHIEDMAHIA GFAPGNOAKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private OEPLGODIKBN KLGCFGPCNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool DCFEOFMOCED;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly LHMKAIAPMBI GIPBJKINCEM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HIOIHFFBIKA JOCLBAADBME
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4910", Offset = "0x7ED2F10", VA = "0x187ED4910")]
	public bool OEJDPPFOPLI([In] MEIKGJNEFCB ACJFHCNBBBO, bool DMHADHLEJAP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7ED57D0", Offset = "0x7ED3DD0", VA = "0x187ED57D0")]
	private bool MPDHOEJIOKJ([In] MEIKGJNEFCB ACJFHCNBBBO, bool DMHADHLEJAP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7310", Offset = "0x7ED5910", VA = "0x187ED7310")]
	public PCNCIBPGJGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED45C0", Offset = "0x7ED2BC0", VA = "0x187ED45C0", Slot = "5")]
	public void FLMOPKJJIJF(GOAACIPBCGD MIPDPIDNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4220", Offset = "0x7ED2820", VA = "0x187ED4220", Slot = "17")]
	public void BCAECENJPKM(EANAMKMCBKO BNOBGIHHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7100", Offset = "0x7ED5700", VA = "0x187ED7100", Slot = "12")]
	public void PKHIIDKONJK(Func<APLFKIFOKDH, bool> OMCOEHJDNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7110", Offset = "0x7ED5710", VA = "0x187ED7110")]
	private void PKHIIDKONJK(CAHCDIJBEOF ADFICJOCHFA, Func<APLFKIFOKDH, bool> OMCOEHJDNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4920", Offset = "0x7ED2F20", VA = "0x187ED4920", Slot = "11")]
	public void KFKHMDGIMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4720", Offset = "0x7ED2D20", VA = "0x187ED4720", Slot = "8")]
	public bool GBOAGPPHJFF(APLFKIFOKDH GLFFDNHBPLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6330", Offset = "0x7ED4930", VA = "0x187ED6330")]
	private bool NGHHKEJABAK(APLFKIFOKDH AFONPPNDLIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4670", Offset = "0x7ED2C70", VA = "0x187ED4670")]
	private static bool GBKFKEKJAGC(APLFKIFOKDH AFONPPNDLIK, CAHCDIJBEOF PNMIJFLNLLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4940", Offset = "0x7ED2F40", VA = "0x187ED4940")]
	private void KILDPBIBAOM(Transform KEOJJGDGDML, CAHCDIJBEOF AJKKOAHJOKF, CAHCDIJBEOF[] IPGAFCIPIIO, APLFKIFOKDH OEBOCMBCLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5430", Offset = "0x7ED3A30", VA = "0x187ED5430")]
	private DNDBEDENKIB MHNGGLAFBJE(Transform DIPMEEKFDGJ, DNDBEDENKIB JCHLILOJMCM)
	{
		return default(DNDBEDENKIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4400", Offset = "0x7ED2A00", VA = "0x187ED4400")]
	private static bool CPEKDOIGIPG(CAHCDIJBEOF PNMIJFLNLLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4730", Offset = "0x7ED2D30", VA = "0x187ED4730", Slot = "9")]
	public bool GEPCAGFMJFF(APLFKIFOKDH CEOKOIAKNIO, int HIGPMOEJOIF, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5580", Offset = "0x7ED3B80", VA = "0x187ED5580")]
	private bool MLJLLHJHOME(APLFKIFOKDH CEOKOIAKNIO, int HIGPMOEJOIF, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7ED52B0", Offset = "0x7ED38B0", VA = "0x187ED52B0")]
	private static void LPHBBICFLGC(APLFKIFOKDH CEOKOIAKNIO, int HIGPMOEJOIF, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK, CAHCDIJBEOF OOGJDHKOAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED47F0", Offset = "0x7ED2DF0", VA = "0x187ED47F0")]
	private void IBAFBNHJHLK(APLFKIFOKDH LPGPKPPJKLI, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6A30", Offset = "0x7ED5030", VA = "0x187ED6A30")]
	private void NIFBKOGDCFN(CAHCDIJBEOF ADFICJOCHFA, APLFKIFOKDH PIBGLJMNHOG, APLFKIFOKDH ADGIOGOLHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6AA0", Offset = "0x7ED50A0", VA = "0x187ED6AA0")]
	private void NIFBKOGDCFN(APLFKIFOKDH KMEGNEJIGOP, APLFKIFOKDH PIBGLJMNHOG, APLFKIFOKDH ADGIOGOLHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4250", Offset = "0x7ED2850", VA = "0x187ED4250")]
	private void BCLLJNILNFD(APLFKIFOKDH KMEGNEJIGOP, APLFKIFOKDH PIBGLJMNHOG, APLFKIFOKDH ADGIOGOLHAO, bool EAFJIPGBBCN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED42C0", Offset = "0x7ED28C0", VA = "0x187ED42C0")]
	private void BCLLJNILNFD(CAHCDIJBEOF CMAFOEIBEKN, APLFKIFOKDH OEBOCMBCLEB, APLFKIFOKDH JHBPFLKECNF, bool EAFJIPGBBCN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5190", Offset = "0x7ED3790", VA = "0x187ED5190")]
	private void LNMGAHCOFEB(APLFKIFOKDH JDOHELGNGHJ, int HIGPMOEJOIF, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4F60", Offset = "0x7ED3560", VA = "0x187ED4F60")]
	private void LJBNOECNJGA(HIOIHFFBIKA NBIJLPJHNNE, HIOIHFFBIKA AJMGCDPHAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4E00", Offset = "0x7ED3400", VA = "0x187ED4E00", Slot = "18")]
	public APLFKIFOKDH LGBNAMJCHEH(APLFKIFOKDH KMEGNEJIGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6B10", Offset = "0x7ED5110", VA = "0x187ED6B10", Slot = "13")]
	public void OAGLECEEKMO(APLFKIFOKDH KMEGNEJIGOP, HashSet<APLFKIFOKDH> LLANOGHDINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6EC0", Offset = "0x7ED54C0", VA = "0x187ED6EC0", Slot = "14")]
	public List<APLFKIFOKDH> OGBHOHFNKMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7ED50C0", Offset = "0x7ED36C0", VA = "0x187ED50C0")]
	protected HIOIHFFBIKA LMCBLAEEDFD(HIOIHFFBIKA ADFICJOCHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4070", Offset = "0x7ED2670", VA = "0x187ED4070")]
	protected CAHCDIJBEOF[] BBLLDCKBNDC(CAHCDIJBEOF PNMIJFLNLLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4110", Offset = "0x7ED2710", VA = "0x187ED4110")]
	protected bool BBMEPFHEMBC(APLFKIFOKDH KMEGNEJIGOP, [Out] CAHCDIJBEOF ADFICJOCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3F40", Offset = "0x7ED2540", VA = "0x187ED3F40", Slot = "15")]
	public bool AHBHGLCFNLG(APLFKIFOKDH KMEGNEJIGOP, [Out] DNDBEDENKIB BPCLNDJEAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7ED43C0", Offset = "0x7ED29C0", VA = "0x187ED43C0")]
	protected CAHCDIJBEOF CBDDAEPPFDF(DNDBEDENKIB KLMPPPBFELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4790", Offset = "0x7ED2D90", VA = "0x187ED4790", Slot = "10")]
	public bool HGKIKNJAHHO(APLFKIFOKDH LPGPKPPJKLI, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5D90", Offset = "0x7ED4390", VA = "0x187ED5D90")]
	private bool NBKHEDCDLHL(APLFKIFOKDH LPGPKPPJKLI, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4D30", Offset = "0x7ED3330", VA = "0x187ED4D30")]
	private static bool KOAHAHPKKOI(CAHCDIJBEOF DFCOKJDMKMM, DNDBEDENKIB HFDFOHDEEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4910", Offset = "0x7ED2F10", VA = "0x187ED4910", Slot = "7")]
	private bool ILCLBJCAEGL([In] MEIKGJNEFCB ACJFHCNBBBO, bool DMHADHLEJAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class LJKDCDIDIBE : GOAACIPBCGD, JFAKIPDGBHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly DCNOMJHNEOK FAIEEFHMPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly OEPLGODIKBN KLGCFGPCNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly LCLOFAHMOKD KBGPFGELCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly KGIDEHPFDGO LAFGGEBKJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly AGGLKCONHMN FCPCBIGAPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal HKBJKJDAJAE ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal AGDDAPPMCNL ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal BJHIEDMAHIA MEDPPFJHFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool DCFEOFMOCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool ELOEHCMMEGN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LIKFJIOCIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAA0B10", Offset = "0xA9F110", VA = "0x180AA0B10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAA0B20", Offset = "0xA9F120", VA = "0x180AA0B20")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FLBBOPEIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x11FF7F0", Offset = "0x11FDDF0", VA = "0x1811FF7F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x27B9B70", Offset = "0x27B8170", VA = "0x1827B9B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool NLMPFEJEIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<APLFKIFOKDH, APLFKIFOKDH> LINOGAPPPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1290", Offset = "0x7ECF890", VA = "0x187ED1290", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0FF0", Offset = "0x7ECF5F0", VA = "0x187ED0FF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<APLFKIFOKDH, APLFKIFOKDH> JFGIFDLLJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7ED29C0", Offset = "0x7ED0FC0", VA = "0x187ED29C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1A90", Offset = "0x7ED0090", VA = "0x187ED1A90", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<APLFKIFOKDH, APLFKIFOKDH, APLFKIFOKDH> PLOFENAILGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2C50", Offset = "0x7ED1250", VA = "0x187ED2C50", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7ED18F0", Offset = "0x7ECFEF0", VA = "0x187ED18F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2CB0", Offset = "0x7ED12B0", VA = "0x187ED2CB0")]
	public LJKDCDIDIBE(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED12F0", Offset = "0x7ECF8F0", VA = "0x187ED12F0", Slot = "12")]
	public void FLMOPKJJIJF(GameObject KGMBEOBCDCB, EFEEFHKLJPI KOIEDKJJCMF, DBMEGIMHNHC GICHKKDOFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2220", Offset = "0x7ED0820", VA = "0x187ED2220", Slot = "26")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1AF0", Offset = "0x7ED00F0", VA = "0x187ED1AF0", Slot = "13")]
	public void IEMAIHNOLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0FD0", Offset = "0x7ECF5D0", VA = "0x187ED0FD0", Slot = "14")]
	public void CCHHFLKMKEK(APLFKIFOKDH KMEGNEJIGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1E30", Offset = "0x7ED0430", VA = "0x187ED1E30", Slot = "15")]
	public void PAEMAGCOOJI(APLFKIFOKDH KMEGNEJIGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1E90", Offset = "0x7ED0490", VA = "0x187ED1E90", Slot = "22")]
	public bool JEIPMMFLDIH(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7ED28B0", Offset = "0x7ED0EB0", VA = "0x187ED28B0")]
	internal bool NBKHEDCDLHL([In] MEIKGJNEFCB ACJFHCNBBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2540", Offset = "0x7ED0B40", VA = "0x187ED2540")]
	internal bool KPHOEOIHELL([In] MEIKGJNEFCB ACJFHCNBBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2690", Offset = "0x7ED0C90", VA = "0x187ED2690")]
	internal void MHLHONDGGAL(APLFKIFOKDH KMEGNEJIGOP, int FDBFPIIOEAN, bool DMHADHLEJAP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1E30", Offset = "0x7ED0430", VA = "0x187ED1E30")]
	internal bool JCAMDINDIGI(APLFKIFOKDH MEJMKFJBLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2B10", Offset = "0x7ED1110", VA = "0x187ED2B10")]
	internal bool OIGBMNGINLM(APLFKIFOKDH CEOKOIAKNIO, int HIGPMOEJOIF, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2A20", Offset = "0x7ED1020", VA = "0x187ED2A20", Slot = "16")]
	public void OAGLECEEKMO(APLFKIFOKDH KMEGNEJIGOP, HashSet<APLFKIFOKDH> CBNEFBMPLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1C20", Offset = "0x7ED0220", VA = "0x187ED1C20", Slot = "17")]
	public void JBAMDHAOENK(APLFKIFOKDH CEOKOIAKNIO, APLFKIFOKDH JOKFAHFBNMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1950", Offset = "0x7ECFF50", VA = "0x187ED1950", Slot = "18")]
	public void GBHEACNCOJP(APLFKIFOKDH LPGPKPPJKLI, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1EE0", Offset = "0x7ED04E0", VA = "0x187ED1EE0", Slot = "19")]
	public void JEPNEKHOKJI(APLFKIFOKDH LPGPKPPJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED22F0", Offset = "0x7ED08F0", VA = "0x187ED22F0")]
	public void KNEKBMCLECB([Optional] KNOJHPOMDED IKNFGAPJHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1200", Offset = "0x7ECF800", VA = "0x187ED1200", Slot = "23")]
	public void DLGMDCCJCGK(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7ED20A0", Offset = "0x7ED06A0", VA = "0x187ED20A0", Slot = "20")]
	public MILLFFLLMNA JMDIMHMELMC(bool EIFKJONKELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1050", Offset = "0x7ECF650", VA = "0x187ED1050", Slot = "21")]
	public MILLFFLLMNA DEIDAIHOFCJ(HashSet<Guid> KHBIEGNDMPP, bool EIFKJONKELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2870", Offset = "0x7ED0E70", VA = "0x187ED2870", Slot = "25")]
	public void MLDDAENFLNC(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1B70", Offset = "0x7ED0170", VA = "0x187ED1B70", Slot = "24")]
	public void IKBLHENMNEH(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class OEPLGODIKBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly BGABPBLPFLC<APLFKIFOKDH, APLFKIFOKDH> LINOGAPPPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly BGABPBLPFLC<APLFKIFOKDH, APLFKIFOKDH> JFGIFDLLJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly LLJMDKOFNID<APLFKIFOKDH, APLFKIFOKDH, APLFKIFOKDH> PLOFENAILGI;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3CD0", Offset = "0x7ED22D0", VA = "0x187ED3CD0")]
	public OEPLGODIKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	public void FLMOPKJJIJF(LJKDCDIDIBE MIPDPIDNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3C70", Offset = "0x7ED2270", VA = "0x187ED3C70")]
	public void OKJCCHOONKI(APLFKIFOKDH NBIJLPJHNNE, APLFKIFOKDH JDOHELGNGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3B90", Offset = "0x7ED2190", VA = "0x187ED3B90")]
	public void KPJPCIAIABP(APLFKIFOKDH NBIJLPJHNNE, APLFKIFOKDH JDOHELGNGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3BF0", Offset = "0x7ED21F0", VA = "0x187ED3BF0")]
	public void LCIEOJODPLD(APLFKIFOKDH GGFNABANHGE, APLFKIFOKDH BADBAFBEKHJ, APLFKIFOKDH JDOHELGNGHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class LCLOFAHMOKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private LJKDCDIDIBE MIPDPIDNIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private AGDDAPPMCNL ILCCHPCLICG;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LCLOFAHMOKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0CD0", Offset = "0x7ECF2D0", VA = "0x187ED0CD0")]
	public void FLMOPKJJIJF(LJKDCDIDIBE MIPDPIDNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0BB0", Offset = "0x7ECF1B0", VA = "0x187ED0BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0E10", Offset = "0x7ECF410", VA = "0x187ED0E10")]
	private void IHKADMFIJLN(PECONNHPBAN HKLGEDHKAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0E50", Offset = "0x7ECF450", VA = "0x187ED0E50")]
	private void IMDOMLKACCL(KNOJHPOMDED BIMDGEMNEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0BC0", Offset = "0x7ECF1C0", VA = "0x187ED0BC0")]
	public void EOJPKDHAHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0EC0", Offset = "0x7ECF4C0", VA = "0x187ED0EC0")]
	public void POEIKBAMLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class IMFINBIMKHL
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PPKDOLMFOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public DCNOMJHNEOK container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PPKDOLMFOPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7ED74E0", Offset = "0x7ED5AE0", VA = "0x187ED74E0")]
		internal LJKDCDIDIBE MFFCGDEDMGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDCC0", Offset = "0x7ECC2C0", VA = "0x187ECDCC0")]
	public static void JCHKLKGEODF(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDC40", Offset = "0x7ECC240", VA = "0x187ECDC40")]
	public static void BNKEPMPCINE(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class HAEGKFNPHIJ : IDisposable, BJHIEDMAHIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, DCHIIBEABMA> GPBFDMBDDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly EANAMKMCBKO JDDEOLBFEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private AKGDFAOCKCN DPPKHMGGMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private AGGLKCONHMN FCPCBIGAPJJ;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker JKFJLLJJCPJ;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6EA0", Offset = "0x7EC54A0", VA = "0x187EC6EA0")]
	public HAEGKFNPHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6390", Offset = "0x7EC4990", VA = "0x187EC6390", Slot = "7")]
	public void FLMOPKJJIJF(AGGLKCONHMN FCPCBIGAPJJ, AKGDFAOCKCN DPPKHMGGMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6A50", Offset = "0x7EC5050", VA = "0x187EC6A50", Slot = "5")]
	public void PIDMINMANLN(HIOIHFFBIKA GFIAIIAKBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7EC68E0", Offset = "0x7EC4EE0", VA = "0x187EC68E0", Slot = "9")]
	public void OMKGCCAEMCD(HIOIHFFBIKA LMKIEPCOCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC63D0", Offset = "0x7EC49D0", VA = "0x187EC63D0", Slot = "8")]
	public void NCMENDBKDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6590", Offset = "0x7EC4B90", VA = "0x187EC6590", Slot = "10")]
	public void OMHIJMFAIFK(HIOIHFFBIKA MKEEMACGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6210", Offset = "0x7EC4810", VA = "0x187EC6210", Slot = "11")]
	public void BHENMBFOFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6C90", Offset = "0x7EC5290", VA = "0x187EC6C90")]
	private bool PMNABMHJKJJ(HIOIHFFBIKA LFBNNGIKBPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class KGIDEHPFDGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct BOLFDEIACDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly CAHCDIJBEOF EFHHMFJMLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> KHBIEGNDMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly ODNFMHOMGMG NLLNAJFMJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly ODNFMHOMGMG PNCOHHBJHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool EIFKJONKELA;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool HPMELAAMPLF
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7EC3050", Offset = "0x7EC1650", VA = "0x187EC3050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3750", Offset = "0x7EC1D50", VA = "0x187EC3750")]
		public BOLFDEIACDF(CAHCDIJBEOF EFHHMFJMLKK, HashSet<Guid> KHBIEGNDMPP, bool EIFKJONKELA, [Optional] ODNFMHOMGMG NLLNAJFMJAP, [Optional] ODNFMHOMGMG PNCOHHBJHCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7EC35B0", Offset = "0x7EC1BB0", VA = "0x187EC35B0")]
		public ODNFMHOMGMG LGGJGPOGIBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3380", Offset = "0x7EC1980", VA = "0x187EC3380")]
		private ODNFMHOMGMG HBOOMDFIJPL([Out] ODNFMHOMGMG JGDIJAJNNBI, [Out] ODNFMHOMGMG FGDBAFFHBLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3160", Offset = "0x7EC1760", VA = "0x187EC3160")]
		private ODNFMHOMGMG GNMIDIBKFJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3440", Offset = "0x7EC1A40", VA = "0x187EC3440")]
		private void HELFFNGCAAH(ODNFMHOMGMG ILJHMJKICFG, ODNFMHOMGMG ICJJNEDELAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2E90", Offset = "0x7EC1490", VA = "0x187EC2E90")]
		private void EDFOCAFPINK(ODNFMHOMGMG JGDIJAJNNBI, ODNFMHOMGMG FGDBAFFHBLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private LJKDCDIDIBE MIPDPIDNIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private AGGLKCONHMN FCPCBIGAPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private BJHIEDMAHIA GFAPGNOAKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private AGDDAPPMCNL ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool HJGLJFNBELC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool CMDDOAPFBIC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF5B0", Offset = "0x7ECDBB0", VA = "0x187ECF5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool LIKFJIOCIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF930", Offset = "0x7ECDF30", VA = "0x187ECF930")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFD20", Offset = "0x7ECE320", VA = "0x187ECFD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF300", Offset = "0x7ECD900", VA = "0x187ECF300")]
	public void FLMOPKJJIJF(LJKDCDIDIBE MIPDPIDNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF950", Offset = "0x7ECDF50", VA = "0x187ECF950")]
	public MILLFFLLMNA JMDIMHMELMC(bool EIFKJONKELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7ECED20", Offset = "0x7ECD320", VA = "0x187ECED20")]
	public MILLFFLLMNA DEIDAIHOFCJ(HashSet<Guid> KHBIEGNDMPP, bool EIFKJONKELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEEC0", Offset = "0x7ECD4C0", VA = "0x187ECEEC0")]
	public void DLGMDCCJCGK(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF600", Offset = "0x7ECDC00", VA = "0x187ECF600")]
	public void IKBLHENMNEH(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF390", Offset = "0x7ECD990", VA = "0x187ECF390")]
	public void HKFFLFMHDEO(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFEC0", Offset = "0x7ECE4C0", VA = "0x187ECFEC0")]
	private void KKIDAFHOGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEC30", Offset = "0x7ECD230", VA = "0x187ECEC30")]
	private ODNFMHOMGMG CPBOIBGJBIA(CAHCDIJBEOF ADFICJOCHFA, bool EIFKJONKELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED07A0", Offset = "0x7ECEDA0", VA = "0x187ED07A0")]
	private static void OMPNNIKHBBJ(CAHCDIJBEOF ADFICJOCHFA, bool EIFKJONKELA, ODNFMHOMGMG ANABIAJOBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEF50", Offset = "0x7ECD550", VA = "0x187ECEF50")]
	private void DNLHPIFIMOJ(CAHCDIJBEOF ADFICJOCHFA, bool EIFKJONKELA, ODNFMHOMGMG ANABIAJOBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0710", Offset = "0x7ECED10", VA = "0x187ED0710")]
	private ODNFMHOMGMG OCDIJAIOMGE(CAHCDIJBEOF EFHHMFJMLKK, HashSet<Guid> KHBIEGNDMPP, bool EIFKJONKELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE9B0", Offset = "0x7ECCFB0", VA = "0x187ECE9B0")]
	private bool CLBMMDADHFE(MILLFFLLMNA EOAPKPHDLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED00A0", Offset = "0x7ECE6A0", VA = "0x187ED00A0")]
	private bool MPLMMBFGHLG(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF370", Offset = "0x7ECD970", VA = "0x187ECF370")]
	private bool HKCMHIHKBLN(MILLFFLLMNA FCPCBIGAPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE890", Offset = "0x7ECCE90", VA = "0x187ECE890")]
	private static bool CDCFLONIMEG(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF6A0", Offset = "0x7ECDCA0", VA = "0x187ECF6A0")]
	public static bool JEIPMMFLDIH(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE540", Offset = "0x7ECCB40", VA = "0x187ECE540")]
	private APLFKIFOKDH BJHPNIHKMME(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFD40", Offset = "0x7ECE340", VA = "0x187ECFD40")]
	private APLFKIFOKDH KACKDICCGJD(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF170", Offset = "0x7ECD770", VA = "0x187ECF170")]
	private APLFKIFOKDH FJJODDMLAAN(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9F20", Offset = "0x7EC8520", VA = "0x187EC9F20")]
	private static Guid DMIMIADOJNG(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0A50", Offset = "0x7ECF050", VA = "0x187ED0A50")]
	private string PGPHMBHNACA(ODNFMHOMGMG ANABIAJOBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF3C0", Offset = "0x7ECD9C0", VA = "0x187ECF3C0")]
	private bool HPGKINEAHFF(CAHCDIJBEOF ADFICJOCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFAC0", Offset = "0x7ECE0C0", VA = "0x187ECFAC0")]
	private static void JNBEPDHKOBI(CAHCDIJBEOF EFHHMFJMLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KGIDEHPFDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct MEIKGJNEFCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public APLFKIFOKDH JDOHELGNGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public APLFKIFOKDH NBIJLPJHNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int HIGPMOEJOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int JDODEHNKPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 LEMKBBMDECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion KOAPCOJKAJK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DNDBEDENKIB KHBBFPGAKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7ED3A50", Offset = "0x7ED2050", VA = "0x187ED3A50")]
		get
		{
			return default(DNDBEDENKIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DNDBEDENKIB JIEMIGNAMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7ED3AF0", Offset = "0x7ED20F0", VA = "0x187ED3AF0")]
		get
		{
			return default(DNDBEDENKIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3B20", Offset = "0x7ED2120", VA = "0x187ED3B20")]
	public MEIKGJNEFCB(APLFKIFOKDH JDOHELGNGHJ, APLFKIFOKDH NBIJLPJHNNE, int HIGPMOEJOIF, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface AGGLKCONHMN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	HIOIHFFBIKA JOCLBAADBME
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLMOPKJJIJF(GOAACIPBCGD MIPDPIDNIBN);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OEJDPPFOPLI([In] MEIKGJNEFCB ACJFHCNBBBO, bool DMHADHLEJAP = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GBOAGPPHJFF(APLFKIFOKDH GLFFDNHBPLC);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GEPCAGFMJFF(APLFKIFOKDH CEOKOIAKNIO, int HIGPMOEJOIF, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HGKIKNJAHHO(APLFKIFOKDH LPGPKPPJKLI, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFKHMDGIMOC();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PKHIIDKONJK(Func<APLFKIFOKDH, bool> OMCOEHJDNBJ);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OAGLECEEKMO(APLFKIFOKDH KMEGNEJIGOP, HashSet<APLFKIFOKDH> LLANOGHDINF);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<APLFKIFOKDH> OGBHOHFNKMH();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AHBHGLCFNLG(APLFKIFOKDH KMEGNEJIGOP, [Out] DNDBEDENKIB BPCLNDJEAMN);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BCAECENJPKM(EANAMKMCBKO BNOBGIHHJGL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool EANAMKMCBKO(HIOIHFFBIKA ADFICJOCHFA);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface HIOIHFFBIKA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	APLFKIFOKDH ENMCMNCJMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	HIOIHFFBIKA GCMDLKAOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DNDBEDENKIB CBFONPCFGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool OEHACKIFJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DCHIIBEABMA
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNLBMDNIIGG(APLFKIFOKDH LHNAJKLAKBI, DNDBEDENKIB JDOHELGNGHJ);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLOPLJIOEHH(APLFKIFOKDH LHNAJKLAKBI, DNDBEDENKIB JDOHELGNGHJ);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLLOIIKPGKN(APLFKIFOKDH LHNAJKLAKBI, DNDBEDENKIB JDOHELGNGHJ);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PCIOOFCANBC(APLFKIFOKDH LHNAJKLAKBI, DNDBEDENKIB JDOHELGNGHJ);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DCHIIBEABMA Instantiate(Transform DFOHJKCGEGI);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNBAOKNGOBL();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface AKGDFAOCKCN
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLMOPKJJIJF(Transform DFOHJKCGEGI, DCHIIBEABMA OOMDKDANOML);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCHIIBEABMA KDNABNHEPEO();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDHEANLABHL(DCHIIBEABMA AFBLPELCALG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HKBJKJDAJAE : IICANHEJHNJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOKKGLKLJAL();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NNINPDAGELO(Guid NFFCEGGNLPM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface BJHIEDMAHIA
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIDMINMANLN(HIOIHFFBIKA GFIAIIAKBJL);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLMOPKJJIJF(AGGLKCONHMN FCPCBIGAPJJ, AKGDFAOCKCN IHIPEFFAPIH);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCMENDBKDHO();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OMKGCCAEMCD(HIOIHFFBIKA LMKIEPCOCEM);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMHIJMFAIFK(HIOIHFFBIKA MKEEMACGFAP);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BHENMBFOFBK();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class CAHCDIJBEOF : HIOIHFFBIKA
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FJJLMLMEDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public DNDBEDENKIB nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CAHCDIJBEOF foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FJJLMLMEDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7EC5130", Offset = "0x7EC3730", VA = "0x187EC5130")]
		internal bool IELOMNCBHLF(HIOIHFFBIKA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private DNDBEDENKIB BPCLNDJEAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<CAHCDIJBEOF> OOOMLMJLCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private CAHCDIJBEOF CKKBDECPJIF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DNDBEDENKIB CBFONPCFGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1402580", Offset = "0x1400B80", VA = "0x181402580", Slot = "6")]
		get
		{
			return default(DNDBEDENKIB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1402270", Offset = "0x1400870", VA = "0x181402270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private CAHCDIJBEOF NBIJLPJHNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3CE0", Offset = "0x7EC22E0", VA = "0x187EC3CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public HIOIHFFBIKA GCMDLKAOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public APLFKIFOKDH ENMCMNCJMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OEHACKIFJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3DC0", Offset = "0x7EC23C0", VA = "0x187EC3DC0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool FNMMALHEMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7EC40A0", Offset = "0x7EC26A0", VA = "0x187EC40A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected CAHCDIJBEOF CMAFOEIBEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7EC37C0", Offset = "0x7EC1DC0", VA = "0x187EC37C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4240", Offset = "0x7EC2840", VA = "0x187EC4240")]
	public CAHCDIJBEOF(DNDBEDENKIB CKLJNPDIIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7EC40F0", Offset = "0x7EC26F0", VA = "0x187EC40F0")]
	public CAHCDIJBEOF NOFCKFLGCNH(DNDBEDENKIB HHMFLLFNCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3F20", Offset = "0x7EC2520", VA = "0x187EC3F20")]
	public CAHCDIJBEOF JCJBEFEDHDP(DNDBEDENKIB HPJEMHIIGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EC37E0", Offset = "0x7EC1DE0", VA = "0x187EC37E0")]
	public CAHCDIJBEOF BAFGFGCDOJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3DD0", Offset = "0x7EC23D0", VA = "0x187EC3DD0")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3B30", Offset = "0x7EC2130", VA = "0x187EC3B30")]
	public CAHCDIJBEOF CABHAFPHLEA(DNDBEDENKIB BADBAFBEKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EC39D0", Offset = "0x7EC1FD0", VA = "0x187EC39D0")]
	private static void BCAECENJPKM(CAHCDIJBEOF KPEKMKIEPDJ, EANAMKMCBKO GFCEGHONGDJ, bool FFILJEAEFMJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7EC39C0", Offset = "0x7EC1FC0", VA = "0x187EC39C0", Slot = "9")]
	public void BCAECENJPKM(EANAMKMCBKO BNOBGIHHJGL, bool EAFJIPGBBCN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3BE0", Offset = "0x7EC21E0", VA = "0x187EC3BE0")]
	public static CAHCDIJBEOF CBDDAEPPFDF(CAHCDIJBEOF KPEKMKIEPDJ, DNDBEDENKIB OKJLGKJJPOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface AGDDAPPMCNL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool CMDDOAPFBIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<PECONNHPBAN> IHKADMFIJLN;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<KNOJHPOMDED> IMDOMLKACCL;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PNLBMDNIIGG(LJKDCDIDIBE MIPDPIDNIBN, DBMEGIMHNHC EGKLIIJKNOP);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBAMDHAOENK(APLFKIFOKDH CEOKOIAKNIO, APLFKIFOKDH JOKFAHFBNMM, int HIGPMOEJOIF, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GBHEACNCOJP(APLFKIFOKDH LPGPKPPJKLI, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BLHDKEJEKMP(MILLFFLLMNA FCPBHBIJKPJ, [Optional] KNOJHPOMDED IKNFGAPJHPD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KANBGBCMDHA
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type AKEHBOGGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE4E0", Offset = "0x7ECCAE0", VA = "0x187ECE4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object FNIBPMLJKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE4A0", Offset = "0x7ECCAA0", VA = "0x187ECE4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE440", Offset = "0x7ECCA40", VA = "0x187ECE440")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class FMMLPPELCNE : AGDDAPPMCNL, IDisposable, OOFFMEIPNLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private LJKDCDIDIBE MIPDPIDNIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private DBMEGIMHNHC GICHKKDOFJJ;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool CMDDOAPFBIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7EC56A0", Offset = "0x7EC3CA0", VA = "0x187EC56A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7EC53F0", Offset = "0x7EC39F0", VA = "0x187EC53F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView FMKKJEMGABB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EC58D0", Offset = "0x7EC3ED0", VA = "0x187EC58D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<PECONNHPBAN> IHKADMFIJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7EC5700", Offset = "0x7EC3D00", VA = "0x187EC5700", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EC5430", Offset = "0x7EC3A30", VA = "0x187EC5430", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<KNOJHPOMDED> IMDOMLKACCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7EC5600", Offset = "0x7EC3C00", VA = "0x187EC5600", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7EC5970", Offset = "0x7EC3F70", VA = "0x187EC5970", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5A10", Offset = "0x7EC4010", VA = "0x187EC5A10", Slot = "10")]
	public void PNLBMDNIIGG(LJKDCDIDIBE MIPDPIDNIBN, DBMEGIMHNHC GICHKKDOFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7EC53A0", Offset = "0x7EC39A0", VA = "0x187EC53A0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7EC57A0", Offset = "0x7EC3DA0", VA = "0x187EC57A0", Slot = "11")]
	public void JBAMDHAOENK(APLFKIFOKDH CEOKOIAKNIO, APLFKIFOKDH JOKFAHFBNMM, int HIGPMOEJOIF, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7EC54D0", Offset = "0x7EC3AD0", VA = "0x187EC54D0", Slot = "12")]
	public void GBHEACNCOJP(APLFKIFOKDH LPGPKPPJKLI, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5270", Offset = "0x7EC3870", VA = "0x187EC5270", Slot = "13")]
	public void BLHDKEJEKMP(MILLFFLLMNA FCPBHBIJKPJ, [Optional] KNOJHPOMDED IKNFGAPJHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5CE0", Offset = "0x7EC42E0", VA = "0x187EC5CE0")]
	[ECMJPLLGIBK]
	private void RpcMasterReparentNodes(APLFKIFOKDH LPGPKPPJKLI, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5AE0", Offset = "0x7EC40E0", VA = "0x187EC5AE0")]
	[ECMJPLLGIBK]
	private void RpcMasterModifyNode(APLFKIFOKDH CEOKOIAKNIO, APLFKIFOKDH JOKFAHFBNMM, int HIGPMOEJOIF, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EC60E0", Offset = "0x7EC46E0", VA = "0x187EC60E0")]
	[ECMJPLLGIBK]
	private void RpcReparentNodes(APLFKIFOKDH LPGPKPPJKLI, int CIKHFLBJGBP, APLFKIFOKDH BADBAFBEKHJ, int FINMENIDOAM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK, PEDEIDHCFOB PMMLCILGBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5FF0", Offset = "0x7EC45F0", VA = "0x187EC5FF0")]
	[ECMJPLLGIBK]
	private void RpcModifyNode(APLFKIFOKDH CEOKOIAKNIO, int HIGPMOEJOIF, int JDODEHNKPMM, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK, PEDEIDHCFOB PMMLCILGBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5AA0", Offset = "0x7EC40A0", VA = "0x187EC5AA0")]
	[ECMJPLLGIBK]
	private void RpcDeserializeConnectableGraph(MILLFFLLMNA FCPCBIGAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public FMMLPPELCNE()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, DCHIIBEABMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED30A0", Offset = "0x7ED16A0", VA = "0x187ED30A0", Slot = "4")]
		private void DKJLHBAEFMB(APLFKIFOKDH LHNAJKLAKBI, DNDBEDENKIB JDOHELGNGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED3640", Offset = "0x7ED1C40", VA = "0x187ED3640", Slot = "5")]
		private void PGIPFGFMFNN(APLFKIFOKDH LHNAJKLAKBI, DNDBEDENKIB JDOHELGNGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED3220", Offset = "0x7ED1820", VA = "0x187ED3220", Slot = "6")]
		private void EFGMOKIOAKJ(APLFKIFOKDH LHNAJKLAKBI, DNDBEDENKIB JDOHELGNGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED33E0", Offset = "0x7ED19E0", VA = "0x187ED33E0", Slot = "7")]
		private void LHBGFPIHBAP(APLFKIFOKDH LHNAJKLAKBI, DNDBEDENKIB JDOHELGNGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED35D0", Offset = "0x7ED1BD0", VA = "0x187ED35D0", Slot = "8")]
		private DCHIIBEABMA LJIOADNMFKI(Transform DFOHJKCGEGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED3380", Offset = "0x7ED1980", VA = "0x187ED3380", Slot = "9")]
		private void JOGGIONGNIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class HKALBPLKOFN
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B66530", Offset = "0x3B64B30", VA = "0x183B66530")]
	public static DENBJHILBNE<T> LGGEFIEADPE<T>(this DCNOMJHNEOK FAIEEFHMPLL)
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
