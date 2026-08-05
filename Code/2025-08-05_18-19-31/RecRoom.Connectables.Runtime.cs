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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81C2A70", Offset = "0x81C1E70", VA = "0x1881C2A70", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2353DC0", Offset = "0x23531C0", VA = "0x182353DC0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81CDED0", Offset = "0x81CD2D0", VA = "0x1881CDED0")]
		private void GBFKFENBIAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81CE040", Offset = "0x81CD440", VA = "0x1881CE040")]
		private void NKKCCHCKNGM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81CE1B0", Offset = "0x81CD5B0", VA = "0x1881CE1B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81CE4E0", Offset = "0x81CD8E0", VA = "0x1881CE4E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class MOAAAMPIHJJ : KPMEGGALEPC, LLJNOAGPADG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EMAAMMCHNOP : IEnumerable<AJMBAHDMEPL>, IEnumerable, IEnumerator<AJMBAHDMEPL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private AJMBAHDMEPL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private NAIIODHHNBF localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NAIIODHHNBF <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MOAAAMPIHJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MHFAEJPNHJP <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HOKGPHAPNOB <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private HOKGPHAPNOB.HMFMKBPMCNJ <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private AJMBAHDMEPL System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public EMAAMMCHNOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x81BB180", Offset = "0x81BA580", VA = "0x1881BB180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x81BAD20", Offset = "0x81BA120", VA = "0x1881BAD20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x81BAD00", Offset = "0x81BA100", VA = "0x1881BAD00")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81BACE0", Offset = "0x81BA0E0", VA = "0x1881BACE0")]
		private void AIFLPGLABJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x81BB130", Offset = "0x81BA530", VA = "0x1881BB130", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x81BB080", Offset = "0x81BA480", VA = "0x1881BB080", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AJMBAHDMEPL> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81BB080", Offset = "0x81BA480", VA = "0x1881BB080", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PHOMMOEKOHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MOAAAMPIHJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public KINKPINACFL nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PHOMMOEKOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x81CDAE0", Offset = "0x81CCEE0", VA = "0x1881CDAE0")]
		internal object BMNCJEIFFNO(KINKPINACFL x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DDNNNJBGKGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KINKPINACFL child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public PHOMMOEKOHA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DDNNNJBGKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x81BAA90", Offset = "0x81B9E90", VA = "0x1881BAA90")]
		internal object OMEJFJIGBPP((KINKPINACFL child, KINKPINACFL nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly AKNCNLDICPO GELNLHINMBE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly AKNCNLDICPO OHGEIMPHEOH;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly AKNCNLDICPO BNJHPMFKPBD;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly AKNCNLDICPO KGFNHHMEBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private DHLLNOFKNAA CFHIFBFIMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DDFFIBBBDCI KBKKNFFIIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private FOOPJJDIOEH JAHDLLHLLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private EPINHIDBBLE LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CFLPOFDACJP EMMCOFKMDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private FOMGJMJGJGC AFOKFFMLOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PDJHIFICKBM HPIMCEEIPBG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EGBEIIKGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA703C0", Offset = "0xA6F7C0", VA = "0x180A703C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA70460", Offset = "0xA6F860", VA = "0x180A70460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AODAOIINPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<AJMBAHDMEPL, AJMBAHDMEPL> LPPEIPAEADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81C61A0", Offset = "0x81C55A0", VA = "0x1881C61A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81C5ED0", Offset = "0x81C52D0", VA = "0x1881C5ED0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<AJMBAHDMEPL, AJMBAHDMEPL> HKJOODKGIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81C6250", Offset = "0x81C5650", VA = "0x1881C6250", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81C78B0", Offset = "0x81C6CB0", VA = "0x1881C78B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<AJMBAHDMEPL, AJMBAHDMEPL, AJMBAHDMEPL> IAACFIBNMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81C8A30", Offset = "0x81C7E30", VA = "0x1881C8A30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81C66B0", Offset = "0x81C5AB0", VA = "0x1881C66B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x81C95D0", Offset = "0x81C89D0", VA = "0x1881C95D0")]
	public MOAAAMPIHJJ(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x81C8F50", Offset = "0x81C8350", VA = "0x1881C8F50", Slot = "12")]
	public void PJOFCLDPLJB(GameObject JBJNKCGNJKP, JEBCJLNAPEP ECLHDBEMNAL, HGFINBCKINA KEJCMKLNFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x81C7680", Offset = "0x81C6A80", VA = "0x1881C7680", Slot = "26")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x81C8570", Offset = "0x81C7970", VA = "0x1881C8570", Slot = "22")]
	public bool KMBAJBLGBBC(KINKPINACFL CMHOGPBPNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x81C58C0", Offset = "0x81C4CC0", VA = "0x1881C58C0")]
	private void CLGCMCIJFHC(NAIIODHHNBF JMAFNFHBIBK, NAIIODHHNBF OHOHBLJAAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81C6490", Offset = "0x81C5890", VA = "0x1881C6490")]
	private void GPKEPPAJIBG(NAIIODHHNBF JMAFNFHBIBK, NAIIODHHNBF AHIFNEMLOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81C5660", Offset = "0x81C4A60", VA = "0x1881C5660")]
	private void CKNDHBEGIHD(NAIIODHHNBF JMAFNFHBIBK, NAIIODHHNBF AHIFNEMLOIB, NAIIODHHNBF OHOHBLJAAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81C7EE0", Offset = "0x81C72E0", VA = "0x1881C7EE0")]
	private void KCKCNGGLFHN(NAIIODHHNBF JMAFNFHBIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "13")]
	public void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x81C4B40", Offset = "0x81C3F40", VA = "0x1881C4B40", Slot = "14")]
	public void AAGBOPIEMBE(AJMBAHDMEPL DGNBDNLBGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "15")]
	public void FDMOJFMGAAL(AJMBAHDMEPL DGNBDNLBGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x81C88D0", Offset = "0x81C7CD0", VA = "0x1881C88D0", Slot = "17")]
	public void LGHEPDFGKIA(AJMBAHDMEPL DGNBDNLBGEN, AJMBAHDMEPL NKAOICEGBBD, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x81C8790", Offset = "0x81C7B90", VA = "0x1881C8790")]
	public void LGHEPDFGKIA(NAIIODHHNBF HCOPOFCDINJ, NAIIODHHNBF NKAOICEGBBD, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81C8E50", Offset = "0x81C8250", VA = "0x1881C8E50")]
	public void OINPGPKFNNH(AJMBAHDMEPL DGNBDNLBGEN, float PDCCLEJABHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81C5010", Offset = "0x81C4410", VA = "0x1881C5010", Slot = "18")]
	public void ALOMOPAHGGH(AJMBAHDMEPL DCPDIJDLEOC, int JDDCDIBLPIM, AJMBAHDMEPL FFHGPIDMOAI, int MEIIPOEIFJB, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81C7960", Offset = "0x81C6D60", VA = "0x1881C7960")]
	private float JHFNMFLDBPD(NAIIODHHNBF HCOPOFCDINJ, NAIIODHHNBF JIECBJMGMAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81C4ED0", Offset = "0x81C42D0", VA = "0x1881C4ED0")]
	public void ALOMOPAHGGH(NAIIODHHNBF HCOPOFCDINJ, NAIIODHHNBF JIECBJMGMAC, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP, bool LPNEODOIAFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81C8AE0", Offset = "0x81C7EE0", VA = "0x1881C8AE0", Slot = "19")]
	public void NLDLECBDEFH(AJMBAHDMEPL DGNBDNLBGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81C8C50", Offset = "0x81C8050", VA = "0x1881C8C50", Slot = "16")]
	public void OEPLKEALNHO(AJMBAHDMEPL DGNBDNLBGEN, HashSet<AJMBAHDMEPL> BGDONCIHNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "20")]
	public LFHAHGOLIPJ AAKMJKHAGBK(bool MPPBFPEHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "21")]
	public LFHAHGOLIPJ DAFDLEACLPJ(HashSet<Guid> LPLBPDOHGMP, bool MPPBFPEHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x81C6D00", Offset = "0x81C6100", VA = "0x1881C6D00", Slot = "23")]
	public void HPDIIGNOJLN(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F80", Offset = "0x81C5380", VA = "0x1881C5F80", Slot = "24")]
	public void EGBELKINDOG(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x81C5FF0", Offset = "0x81C53F0", VA = "0x1881C5FF0", Slot = "25")]
	public void EMBHIHLGLAM(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81C5AD0", Offset = "0x81C4ED0", VA = "0x1881C5AD0")]
	private void DGNDBNKFFHJ(NAIIODHHNBF HCOPOFCDINJ, NAIIODHHNBF JIECBJMGMAC, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP, float PDCCLEJABHI, bool LPNEODOIAFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x81C6D70", Offset = "0x81C6170", VA = "0x1881C6D70")]
	private void HPHOAJDJIGB(NAIIODHHNBF HCOPOFCDINJ, NAIIODHHNBF LPICKFBBMGL, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x81C8EE0", Offset = "0x81C82E0", VA = "0x1881C8EE0")]
	private void OKHKELEDGMC(NAIIODHHNBF HCOPOFCDINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81C4E40", Offset = "0x81C4240", VA = "0x1881C4E40")]
	[IteratorStateMachine(typeof(EMAAMMCHNOP))]
	public IEnumerable<AJMBAHDMEPL> AGDBAPKADOL(NAIIODHHNBF HNIIKCBNMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81C7DB0", Offset = "0x81C71B0", VA = "0x1881C7DB0")]
	internal AJMBAHDMEPL JMOMKHNDDPE(NAIIODHHNBF HNIIKCBNMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x81C83E0", Offset = "0x81C77E0", VA = "0x1881C83E0")]
	internal NAIIODHHNBF KHIABFNKMEA(AJMBAHDMEPL DGNBDNLBGEN)
	{
		return default(NAIIODHHNBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81C6760", Offset = "0x81C5B60", VA = "0x1881C6760")]
	private bool HJBBCHNJGHE(KINKPINACFL CMHOGPBPNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81C8730", Offset = "0x81C7B30", VA = "0x1881C8730")]
	private bool LGFGGDLKNFM(KINKPINACFL CMHOGPBPNOC, [Out] AJMBAHDMEPL JIECBJMGMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x81C7A10", Offset = "0x81C6E10", VA = "0x1881C7A10")]
	private AJMBAHDMEPL JMOMKHNDDPE(KINKPINACFL CMHOGPBPNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x81C5300", Offset = "0x81C4700", VA = "0x1881C5300")]
	private AJMBAHDMEPL BAGHLDBBEPF(KINKPINACFL CMHOGPBPNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x81C5480", Offset = "0x81C4880", VA = "0x1881C5480")]
	private AJMBAHDMEPL BGENPHHPMHN(KINKPINACFL CMHOGPBPNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x81C7870", Offset = "0x81C6C70", VA = "0x1881C7870")]
	private static Guid IOIFGMAJCBA(KINKPINACFL CMHOGPBPNOC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x81C82F0", Offset = "0x81C76F0", VA = "0x1881C82F0")]
	private string KFGHKCAJCGA(KINKPINACFL CMHOGPBPNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x81C6010", Offset = "0x81C5410", VA = "0x1881C6010")]
	private void FCCBKAOGDLD(AJMBAHDMEPL HCOPOFCDINJ, AJMBAHDMEPL LPICKFBBMGL, RigidTransform MMPBDMLMPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81C5170", Offset = "0x81C4570", VA = "0x1881C5170")]
	private void AOICDNFEEDM(AJMBAHDMEPL LPICKFBBMGL, AJMBAHDMEPL HCOPOFCDINJ, RigidTransform MMPBDMLMPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x81C86D0", Offset = "0x81C7AD0", VA = "0x1881C86D0")]
	private void LCOPAHPADIH(AJMBAHDMEPL DNNKPCKHKEP, AJMBAHDMEPL HCOPOFCDINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x81C6300", Offset = "0x81C5700", VA = "0x1881C6300")]
	private void GLOMONMPPCP(AJMBAHDMEPL HCOPOFCDINJ, AJMBAHDMEPL JIECBJMGMAC, RigidTransform MMPBDMLMPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x81C85C0", Offset = "0x81C79C0", VA = "0x1881C85C0")]
	private void KPCMOPEHAGD(NAIIODHHNBF HNIIKCBNMGN, AJMBAHDMEPL DGNBDNLBGEN, NAIIODHHNBF AHIFNEMLOIB, NAIIODHHNBF OHOHBLJAAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x81C91E0", Offset = "0x81C85E0", VA = "0x1881C91E0")]
	private void PNLBNOIPGBH(NAIIODHHNBF HNIIKCBNMGN, AJMBAHDMEPL DGNBDNLBGEN, AJMBAHDMEPL ILANCJGFDMK, AJMBAHDMEPL MODBGDDFPPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HOMCJKCICDC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FPPHGGNMLAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JFAGCPCLAAF container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FPPHGGNMLAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81BC5F0", Offset = "0x81BB9F0", VA = "0x1881BC5F0")]
		internal MOAAAMPIHJJ OHJDLJPELHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81C1D70", Offset = "0x81C1170", VA = "0x1881C1D70")]
	public static void AKGMEKBJIMB(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81C1EF0", Offset = "0x81C12F0", VA = "0x1881C1EF0")]
	public static void PGICFAKKEAC(JFAGCPCLAAF MNCIANLLPKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class MHHNIOLPCPO : BFLNPOLNJMB, BCFLLBDNFFM
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly MOAAAMPIHJJ NKBFGHKLFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly LDGJEOFGAPF KLKKBHAJGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly EFLABNBPKFJ LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HKLKCMPKHAG[] APKMNHIMBNI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AJMBAHDMEPL HCNGNCHGGHE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x81C47F0", Offset = "0x81C3BF0", VA = "0x1881C47F0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AJMBAHDMEPL GDKEKBALGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x81C4250", Offset = "0x81C3650", VA = "0x1881C4250", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 NPGHECOLBDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x81C2DE0", Offset = "0x81C21E0", VA = "0x1881C2DE0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion FILAIHFHNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x81C2D80", Offset = "0x81C2180", VA = "0x1881C2D80", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JFILGINGEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x81C4190", Offset = "0x81C3590", VA = "0x1881C4190", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<AJMBAHDMEPL> FHDNMNAOBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x81C4530", Offset = "0x81C3930", VA = "0x1881C4530", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool NNBHFHCHICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD315F0", Offset = "0xD309F0", VA = "0x180D315F0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD58890", Offset = "0xD57C90", VA = "0x180D58890", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x81C49F0", Offset = "0x81C3DF0", VA = "0x1881C49F0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject KBGJEENOIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81C4710", Offset = "0x81C3B10", VA = "0x1881C4710", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81C4730", Offset = "0x81C3B30", VA = "0x1881C4730", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid PIBBAKDNBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x81C4850", Offset = "0x81C3C50", VA = "0x1881C4850", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OLMBEHNLBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x81C4930", Offset = "0x81C3D30", VA = "0x1881C4930", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OPACKHHELOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool GAJKCHMENCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x81C3A10", Offset = "0x81C2E10", VA = "0x1881C3A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event NCNBOEIJHOP MHCNPEOOABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81C4310", Offset = "0x81C3710", VA = "0x1881C4310", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81C3ED0", Offset = "0x81C32D0", VA = "0x1881C3ED0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NCNBOEIJHOP MFCMFLCLMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81C4130", Offset = "0x81C3530", VA = "0x1881C4130", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81C43D0", Offset = "0x81C37D0", VA = "0x1881C43D0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NCNBOEIJHOP LCEKHKBAODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81C4370", Offset = "0x81C3770", VA = "0x1881C4370", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81C3A60", Offset = "0x81C2E60", VA = "0x1881C3A60", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event NFCGFGFELFF PCKFFJICCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81C3450", Offset = "0x81C2850", VA = "0x1881C3450", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x81C2C10", Offset = "0x81C2010", VA = "0x1881C2C10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x81C4610", Offset = "0x81C3A10", VA = "0x1881C4610")]
	public MHHNIOLPCPO(NAIIODHHNBF FBNJAHIFLKC, RigidbodyEx PAIBDGNODBA, LDGJEOFGAPF KLKKBHAJGEI, HKLKCMPKHAG[] APKMNHIMBNI, EFLABNBPKFJ LHIJBEJLBFF, KPMEGGALEPC NKBFGHKLFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x81C4500", Offset = "0x81C3900", VA = "0x1881C4500", Slot = "19")]
	public void PFPNBAHGKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "21")]
	public void GLIIIHOIENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7EE39A0", Offset = "0x7EE2DA0", VA = "0x187EE39A0", Slot = "22")]
	public void LLKKFJGKLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x81C2E40", Offset = "0x81C2240", VA = "0x1881C2E40", Slot = "20")]
	public void BCIEBGDAIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x81C2E90", Offset = "0x81C2290", VA = "0x1881C2E90", Slot = "25")]
	public void BPGBAGLFBGO(int PLKIIJBOGOJ, AJMBAHDMEPL FFHGPIDMOAI, int FHHCIKJICIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x81C2CB0", Offset = "0x81C20B0", VA = "0x1881C2CB0", Slot = "26")]
	public void ANKFEKKDEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x81C34F0", Offset = "0x81C28F0", VA = "0x1881C34F0", Slot = "27")]
	public void DIBBECGNIGE(int PLKIIJBOGOJ, AJMBAHDMEPL DCPDIJDLEOC, int NFHNKAJEHFI, [Optional] Vector3? AMANMLHBFHF, [Optional] Quaternion? HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x81C4480", Offset = "0x81C3880", VA = "0x1881C4480", Slot = "28")]
	public void OPGJDOOKJLM(AJMBAHDMEPL DCPDIJDLEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x81C3AC0", Offset = "0x81C2EC0", VA = "0x1881C3AC0", Slot = "31")]
	public void FJDFCFOIMCI(Vector3 BNBNBOALLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x81C30A0", Offset = "0x81C24A0", VA = "0x1881C30A0", Slot = "29")]
	public void CNLLKLNOKLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81C3820", Offset = "0x81C2C20", VA = "0x1881C3820", Slot = "30")]
	public void DMKICOFNFIL(int NOEININIMIL, Vector3 DPIFCOHCFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81C4060", Offset = "0x81C3460", VA = "0x1881C4060", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int PLKIIJBOGOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x81C3F30", Offset = "0x81C3330", VA = "0x1881C3F30", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int PLKIIJBOGOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAD6900", Offset = "0xAD5D00", VA = "0x180AD6900", Slot = "42")]
	public Color GetConnectionSlotColor(int PLKIIJBOGOJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x81C33B0", Offset = "0x81C27B0", VA = "0x1881C33B0", Slot = "43")]
	public bool CanConnectTo(int PLKIIJBOGOJ, AJMBAHDMEPL DAFLJCPKDMI, int NBMEEILBKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "44")]
	public void ParentChanged(int PLKIIJBOGOJ, AJMBAHDMEPL NMBACKEGNKI, int LJFLJGAMELO, Vector3 OHHDMLKAPLK, Quaternion LCIBFINPOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "45")]
	public void ChildAdded(int PLKIIJBOGOJ, AJMBAHDMEPL DIBGPHOBDBH, int KIDGABMDPBO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "46")]
	public void ChildRemoved(int PLKIIJBOGOJ, AJMBAHDMEPL JGNCDMFDBFL, int BOANOCNLFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "47")]
	public void ConnectionModified(int PLKIIJBOGOJ, AJMBAHDMEPL FFHGPIDMOAI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x81C4560", Offset = "0x81C3960", VA = "0x1881C4560", Slot = "48")]
	public void RootChanged(AJMBAHDMEPL AIIAKPLIDJD, AJMBAHDMEPL ELJGCPDALJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x81C37D0", Offset = "0x81C2BD0", VA = "0x1881C37D0", Slot = "23")]
	public void DKLEFOOHIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x81C4430", Offset = "0x81C3830", VA = "0x1881C4430", Slot = "24")]
	public void LOAADJBCEHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x81C4200", Offset = "0x81C3600", VA = "0x1881C4200")]
	private void JGEHKOJBALA(bool MFGIKOANJEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(MLGGKDADLKN), new string[] { })]
public class PMLJHADKBGG : MLGGKDADLKN, GIBCNELDPEH, OBNIMLJGHNG
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ONMMPFOJIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ONMMPFOJIPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private HNFJKCNJOKJ ANBICBPBIDK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object KKHEBOMDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x81CDBA0", Offset = "0x81CCFA0", VA = "0x1881CDBA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x81CDB50", Offset = "0x81CCF50", VA = "0x1881CDB50", Slot = "5")]
	private void LOIPDCNMFAN(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x12EF0D0", Offset = "0x12EE4D0", VA = "0x1812EF0D0", Slot = "6")]
	private void IBPLCLLIMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PMLJHADKBGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(KPMEGGALEPC), new string[] { "Ignore", "Mock" })]
public class MPJBBNMDFKO : KPMEGGALEPC, LLJNOAGPADG
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool EGBEIIKGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AODAOIINPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<AJMBAHDMEPL, AJMBAHDMEPL> LPPEIPAEADM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x81C9970", Offset = "0x81C8D70", VA = "0x1881C9970", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81C98C0", Offset = "0x81C8CC0", VA = "0x1881C98C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<AJMBAHDMEPL, AJMBAHDMEPL> HKJOODKGIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x81C9A20", Offset = "0x81C8E20", VA = "0x1881C9A20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x81C9B80", Offset = "0x81C8F80", VA = "0x1881C9B80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<AJMBAHDMEPL, AJMBAHDMEPL, AJMBAHDMEPL> IAACFIBNMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x81C9C30", Offset = "0x81C9030", VA = "0x1881C9C30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x81C9AD0", Offset = "0x81C8ED0", VA = "0x1881C9AD0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "26")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "12")]
	public void PJOFCLDPLJB(GameObject JBJNKCGNJKP, JEBCJLNAPEP ECLHDBEMNAL, HGFINBCKINA KNPJODPFIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "13")]
	public void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "14")]
	public void AAGBOPIEMBE(AJMBAHDMEPL DGNBDNLBGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "15")]
	public void FDMOJFMGAAL(AJMBAHDMEPL DGNBDNLBGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "16")]
	public void OEPLKEALNHO(AJMBAHDMEPL DGNBDNLBGEN, HashSet<AJMBAHDMEPL> BGDONCIHNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "17")]
	public void LGHEPDFGKIA(AJMBAHDMEPL DGNBDNLBGEN, AJMBAHDMEPL NKAOICEGBBD, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "18")]
	public void ALOMOPAHGGH(AJMBAHDMEPL DGNBDNLBGEN, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "19")]
	public void NLDLECBDEFH(AJMBAHDMEPL DGNBDNLBGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "20")]
	public LFHAHGOLIPJ AAKMJKHAGBK(bool MPPBFPEHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "21")]
	public LFHAHGOLIPJ DAFDLEACLPJ(HashSet<Guid> LPLBPDOHGMP, bool MPPBFPEHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "22")]
	public bool KMBAJBLGBBC(KINKPINACFL CMHOGPBPNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "23")]
	public void HPDIIGNOJLN(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "24")]
	public void EGBELKINDOG(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "25")]
	public void EMBHIHLGLAM(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MPJBBNMDFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AJMBAHDMEPL : BCFLLBDNFFM, IEquatable<AJMBAHDMEPL>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BCFLLBDNFFM
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	AJMBAHDMEPL HCNGNCHGGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject KBGJEENOIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid PIBBAKDNBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int OLMBEHNLBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OPACKHHELOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int PLKIIJBOGOJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int PLKIIJBOGOJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int PLKIIJBOGOJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int PLKIIJBOGOJ, AJMBAHDMEPL DAFLJCPKDMI, int NIPAOMDCGGG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int PLKIIJBOGOJ, AJMBAHDMEPL NMBACKEGNKI, int LJFLJGAMELO, Vector3 OHHDMLKAPLK, Quaternion LCIBFINPOFA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int PLKIIJBOGOJ, AJMBAHDMEPL DIBGPHOBDBH, int KIDGABMDPBO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int PLKIIJBOGOJ, AJMBAHDMEPL JGNCDMFDBFL, int BOANOCNLFNB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int PLKIIJBOGOJ, AJMBAHDMEPL FFHGPIDMOAI, int KONCDCBBKJK, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(AJMBAHDMEPL AIIAKPLIDJD, AJMBAHDMEPL ELJGCPDALJB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KPMEGGALEPC : LLJNOAGPADG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EGBEIIKGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool AODAOIINPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<AJMBAHDMEPL, AJMBAHDMEPL> LPPEIPAEADM;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<AJMBAHDMEPL, AJMBAHDMEPL> HKJOODKGIAI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<AJMBAHDMEPL, AJMBAHDMEPL, AJMBAHDMEPL> IAACFIBNMCG;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PJOFCLDPLJB(GameObject JBJNKCGNJKP, JEBCJLNAPEP ECLHDBEMNAL, HGFINBCKINA HNBHLACMGEH);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OGELNPLKAMN();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AAGBOPIEMBE(AJMBAHDMEPL DGNBDNLBGEN);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FDMOJFMGAAL(AJMBAHDMEPL DGNBDNLBGEN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OEPLKEALNHO(AJMBAHDMEPL DGNBDNLBGEN, HashSet<AJMBAHDMEPL> BGDONCIHNPM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LGHEPDFGKIA(AJMBAHDMEPL DGNBDNLBGEN, AJMBAHDMEPL NKAOICEGBBD, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ALOMOPAHGGH(AJMBAHDMEPL DGNBDNLBGEN, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NLDLECBDEFH(AJMBAHDMEPL DGNBDNLBGEN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	LFHAHGOLIPJ AAKMJKHAGBK(bool MPPBFPEHJFH);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	LFHAHGOLIPJ DAFDLEACLPJ(HashSet<Guid> LPLBPDOHGMP, bool MPPBFPEHJFH);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KMBAJBLGBBC(KINKPINACFL CMHOGPBPNOC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HPDIIGNOJLN(LFHAHGOLIPJ KBCGJHHFJKD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EGBELKINDOG(LFHAHGOLIPJ KBCGJHHFJKD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EMBHIHLGLAM(LFHAHGOLIPJ KBCGJHHFJKD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EPINHIDBBLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AJMBAHDMEPL BGENPHHPMHN(int FHKBJDEJDLG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AJMBAHDMEPL BAGHLDBBEPF(Guid IIBMEAHJCKG);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AHECPEEDANH(AJMBAHDMEPL DGNBDNLBGEN);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IJMGIKPCEON();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOMIMBHDMKO(AJMBAHDMEPL KLKKBHAJGEI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface EFLABNBPKFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAJKCHMENCK(LDGJEOFGAPF KLKKBHAJGEI);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JKOGJGIEOFA(LDGJEOFGAPF KLKKBHAJGEI);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string GFNAPGHOGBC(LDGJEOFGAPF KLKKBHAJGEI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid IDENBBMNHCN(LDGJEOFGAPF KLKKBHAJGEI);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LABPGAHCLCH(LDGJEOFGAPF KLKKBHAJGEI);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FDAHHFKJLJF(LDGJEOFGAPF KLKKBHAJGEI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void NCNBOEIJHOP(AJMBAHDMEPL DCPDIJDLEOC, int JGFMFAJMOBG, AJMBAHDMEPL FFHGPIDMOAI, int MPLCNBCNGMI, [Optional] Vector3? AMANMLHBFHF, [Optional] Quaternion? HFAPDOPNNFK);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void NFCGFGFELFF(AJMBAHDMEPL AIIAKPLIDJD, AJMBAHDMEPL ELJGCPDALJB);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LDGJEOFGAPF : AJMBAHDMEPL, BCFLLBDNFFM, IEquatable<AJMBAHDMEPL>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BFLNPOLNJMB : BCFLLBDNFFM
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	AJMBAHDMEPL GDKEKBALGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<AJMBAHDMEPL> FHDNMNAOBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 NPGHECOLBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion FILAIHFHNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JFILGINGEHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool NNBHFHCHICD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event NCNBOEIJHOP MHCNPEOOABD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event NCNBOEIJHOP MFCMFLCLMCN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NCNBOEIJHOP LCEKHKBAODO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event NFCGFGFELFF PCKFFJICCNC;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PFPNBAHGKKL();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BCIEBGDAIDM();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GLIIIHOIENL();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LLKKFJGKLII();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DKLEFOOHIFH();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LOAADJBCEHA();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BPGBAGLFBGO(int PLKIIJBOGOJ, AJMBAHDMEPL FFHGPIDMOAI, int FHHCIKJICIP);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ANKFEKKDEGJ();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DIBBECGNIGE(int PLKIIJBOGOJ, AJMBAHDMEPL DCPDIJDLEOC, int NFHNKAJEHFI, [Optional] Vector3? AMANMLHBFHF, [Optional] Quaternion? HFAPDOPNNFK);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OPGJDOOKJLM(AJMBAHDMEPL DCPDIJDLEOC);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CNLLKLNOKLJ();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DMKICOFNFIL(int NOEININIMIL, Vector3 DPIFCOHCFGC);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FJDFCFOIMCI(Vector3 BNBNBOALLAG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HKLKCMPKHAG
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 MLEACBDKCLH
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
public interface JEBCJLNAPEP
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool BGGJBBHOMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HKDNDABGIKO PBHANDCDMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, JEBCJLNAPEP
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
			[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public HKDNDABGIKO LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x81BA980", Offset = "0x81B9D80", VA = "0x1881BA980")]
		public static ConnectableConfigData GODHMKPBHEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x81BAA40", Offset = "0x81B9E40", VA = "0x1881BAA40")]
		public ConnectableConfigData(LegacyConnectableLinkVisual KPNBJJKDBPF, bool MIEBJFJGFKF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NMENEPCHFDM : IEquatable<NMENEPCHFDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public AJMBAHDMEPL DGNBDNLBGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int DNCNBFLLNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int KONCDCBBKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 AMANMLHBFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion HFAPDOPNNFK;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x81CB270", Offset = "0x81CA670", VA = "0x1881CB270")]
	public NMENEPCHFDM(AJMBAHDMEPL DGNBDNLBGEN, int DNCNBFLLNOA, int KONCDCBBKJK, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x81CB360", Offset = "0x81CA760", VA = "0x1881CB360")]
	public NMENEPCHFDM(AJMBAHDMEPL DGNBDNLBGEN, int DNCNBFLLNOA, int KONCDCBBKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x81CB2D0", Offset = "0x81CA6D0", VA = "0x1881CB2D0")]
	public NMENEPCHFDM(AJMBAHDMEPL DGNBDNLBGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x81CADF0", Offset = "0x81CA1F0", VA = "0x1881CADF0", Slot = "4")]
	public bool Equals(NMENEPCHFDM LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x81CAEA0", Offset = "0x81CA2A0", VA = "0x1881CAEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class MLGBLJLFGIH : NGBENHMLEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform GANAIKEBLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private HKDNDABGIKO EBMHEFKJBPE;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7B49E80", Offset = "0x7B49280", VA = "0x187B49E80", Slot = "4")]
	public void PJOFCLDPLJB(Transform GANAIKEBLIG, HKDNDABGIKO EBMHEFKJBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x81C4A80", Offset = "0x81C3E80", VA = "0x1881C4A80", Slot = "5")]
	public HKDNDABGIKO EOOIOHHOJJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x81C4A10", Offset = "0x81C3E10", VA = "0x1881C4A10", Slot = "6")]
	public void ABJBKLDEPAF(HKDNDABGIKO MDMKKEGBIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MLGBLJLFGIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class GKMOOHKPADF : IDisposable, FEJLNKBAEHD
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ENANOHHKNFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AJMBAHDMEPL oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AJMBAHDMEPL newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ENANOHHKNFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x81BC200", Offset = "0x81BB600", VA = "0x1881BC200")]
		internal bool OPCEBCNLGCL(LBBEIMLNHNH node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly NEALJBIHCNL PFKMLPMLHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private OBFFPECDEJM PHFIOMGAMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private FLGPEMHHPDH LIBOFBBNJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool MIEBJFJGFKF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly AKNCNLDICPO HCCOONEIPKN;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LBBEIMLNHNH NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x81BF5E0", Offset = "0x81BE9E0", VA = "0x1881BF5E0")]
	public bool MFGDPHEDOGO([In] BEHMGHOPEFB NGIAGNLBILI, bool DGDPKPFONHM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x81BF020", Offset = "0x81BE420", VA = "0x1881BF020")]
	private bool CCMEHKCLMIL([In] BEHMGHOPEFB NGIAGNLBILI, bool DGDPKPFONHM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x81C1BA0", Offset = "0x81C0FA0", VA = "0x1881C1BA0")]
	public GKMOOHKPADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x81C18B0", Offset = "0x81C0CB0", VA = "0x1881C18B0", Slot = "5")]
	public void PJOFCLDPLJB(KPMEGGALEPC JPGAFCLKGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x81BF5F0", Offset = "0x81BE9F0", VA = "0x1881BF5F0", Slot = "17")]
	public void DPAGPHMFGOG(DOONLDDLBAK BFDLNHAHOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x81BEB50", Offset = "0x81BDF50", VA = "0x1881BEB50", Slot = "12")]
	public void APNMJMBLMCI(Func<AJMBAHDMEPL, bool> EDFMOHDPPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x81BEA20", Offset = "0x81BDE20", VA = "0x1881BEA20")]
	private void APNMJMBLMCI(NEALJBIHCNL BLJBPFHLMML, Func<AJMBAHDMEPL, bool> EDFMOHDPPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x81BEA00", Offset = "0x81BDE00", VA = "0x1881BEA00", Slot = "11")]
	public void AONAJKGNKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x81C0400", Offset = "0x81BF800", VA = "0x1881C0400", Slot = "8")]
	public bool KCALJOPDCAH(AJMBAHDMEPL JAJOCFOCANE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x81C0E00", Offset = "0x81C0200", VA = "0x1881C0E00")]
	private bool NDEOFIGLGOM(AJMBAHDMEPL MPLJJNBOFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x81BE7D0", Offset = "0x81BDBD0", VA = "0x1881BE7D0")]
	private static bool ADCHMBFEDMP(AJMBAHDMEPL MPLJJNBOFDN, NEALJBIHCNL FLEBOIMNBNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x81C05E0", Offset = "0x81BF9E0", VA = "0x1881C05E0")]
	private void LMBHECHMCJM(Transform CMPBGDMFMCO, NEALJBIHCNL OLIEECGPBID, NEALJBIHCNL[] DLLDCOGPKNC, AJMBAHDMEPL DKFFGINBLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x81BF740", Offset = "0x81BEB40", VA = "0x1881BF740")]
	private NMENEPCHFDM FPMDLMIIKPO(Transform NBJMLCEGKKB, NMENEPCHFDM POOLHMLBMIJ)
	{
		return default(NMENEPCHFDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x81C09C0", Offset = "0x81BFDC0", VA = "0x1881C09C0")]
	private static bool MHACHOECHIF(NEALJBIHCNL FLEBOIMNBNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x81BE880", Offset = "0x81BDC80", VA = "0x1881BE880", Slot = "9")]
	public bool AKBHMJOPDCC(AJMBAHDMEPL JGADNDGOEPG, int NFHNKAJEHFI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x81BED70", Offset = "0x81BE170", VA = "0x1881BED70")]
	private bool BLCEJDACGKE(AJMBAHDMEPL JGADNDGOEPG, int NFHNKAJEHFI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x81C0B80", Offset = "0x81BFF80", VA = "0x1881C0B80")]
	private static void MNFBHFAKEIM(AJMBAHDMEPL JGADNDGOEPG, int NFHNKAJEHFI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK, NEALJBIHCNL EMPDHKAOCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x81BF620", Offset = "0x81BEA20", VA = "0x1881BF620")]
	private void FCCBKAOGDLD(AJMBAHDMEPL EGEKKBMNDOF, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x81BED00", Offset = "0x81BE100", VA = "0x1881BED00")]
	private void BHBGLMJLMJM(NEALJBIHCNL BLJBPFHLMML, AJMBAHDMEPL ILANCJGFDMK, AJMBAHDMEPL MODBGDDFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x81BEC90", Offset = "0x81BE090", VA = "0x1881BEC90")]
	private void BHBGLMJLMJM(AJMBAHDMEPL DGNBDNLBGEN, AJMBAHDMEPL ILANCJGFDMK, AJMBAHDMEPL MODBGDDFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x81C1A60", Offset = "0x81C0E60", VA = "0x1881C1A60")]
	private void PNLBNOIPGBH(AJMBAHDMEPL DGNBDNLBGEN, AJMBAHDMEPL ILANCJGFDMK, AJMBAHDMEPL MODBGDDFPPH, bool CHCEHNMNELJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x81C1960", Offset = "0x81C0D60", VA = "0x1881C1960")]
	private void PNLBNOIPGBH(NEALJBIHCNL LDEPDDDHLLO, AJMBAHDMEPL DKFFGINBLDA, AJMBAHDMEPL ELJGCPDALJB, bool CHCEHNMNELJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x81BE8E0", Offset = "0x81BDCE0", VA = "0x1881BE8E0")]
	private void AOICDNFEEDM(AJMBAHDMEPL HCOPOFCDINJ, int NFHNKAJEHFI, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x81C0410", Offset = "0x81BF810", VA = "0x1881C0410")]
	private void LCOPAHPADIH(LBBEIMLNHNH JIECBJMGMAC, LBBEIMLNHNH PNMHNOABDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x81BF890", Offset = "0x81BEC90", VA = "0x1881BF890", Slot = "18")]
	public AJMBAHDMEPL GCKIBEMDAEC(AJMBAHDMEPL DGNBDNLBGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x81C13F0", Offset = "0x81C07F0", VA = "0x1881C13F0", Slot = "13")]
	public void OEPLKEALNHO(AJMBAHDMEPL DGNBDNLBGEN, HashSet<AJMBAHDMEPL> KCIEHBBPJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x81BF9F0", Offset = "0x81BEDF0", VA = "0x1881BF9F0", Slot = "14")]
	public List<AJMBAHDMEPL> GIHAPKKNNEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x81BFD00", Offset = "0x81BF100", VA = "0x1881BFD00")]
	protected LBBEIMLNHNH HDKFMNEBNFE(LBBEIMLNHNH BLJBPFHLMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x81C0D60", Offset = "0x81C0160", VA = "0x1881C0D60")]
	protected NEALJBIHCNL[] NAGGELEAEGH(NEALJBIHCNL FLEBOIMNBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x81C17A0", Offset = "0x81C0BA0", VA = "0x1881C17A0")]
	protected bool OPGGPLDABJN(AJMBAHDMEPL DGNBDNLBGEN, [Out] NEALJBIHCNL BLJBPFHLMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x81BEB60", Offset = "0x81BDF60", VA = "0x1881BEB60", Slot = "15")]
	public bool BCELAFGKKEK(AJMBAHDMEPL DGNBDNLBGEN, [Out] NMENEPCHFDM AFBABGHMPHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x81BFDD0", Offset = "0x81BF1D0", VA = "0x1881BFDD0")]
	protected NEALJBIHCNL ILNKIFICDNB(NMENEPCHFDM JIOPJBPNOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x81C03A0", Offset = "0x81BF7A0", VA = "0x1881C03A0", Slot = "10")]
	public bool JIOEEABHKAN(AJMBAHDMEPL EGEKKBMNDOF, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x81BFE10", Offset = "0x81BF210", VA = "0x1881BFE10")]
	private bool JBGCOBDCKPD(AJMBAHDMEPL EGEKKBMNDOF, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x81BFC30", Offset = "0x81BF030", VA = "0x1881BFC30")]
	private static bool GJKBNHKCELH(NEALJBIHCNL HKIGPKGOJPH, NMENEPCHFDM KEHJGJLKLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x81BF5E0", Offset = "0x81BE9E0", VA = "0x1881BF5E0", Slot = "7")]
	private bool CKJHOEAJHLL([In] BEHMGHOPEFB NGIAGNLBILI, bool DGDPKPFONHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class GKHNOKAEANJ : KPMEGGALEPC, LLJNOAGPADG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly JFAGCPCLAAF MNCIANLLPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly FLGPEMHHPDH LIBOFBBNJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly NHKMMGFMLOH BBODDPOGLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly OAMDMKACFKH NALPDHEMFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly FEJLNKBAEHD KBCGJHHFJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal ENKJHMGICBB LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal BJPOLKGBHLA KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal OBFFPECDEJM MBMPFKJLBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool MIEBJFJGFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool NCLACKLGOGM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool KJOBGNKKNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAC3760", Offset = "0xAC2B60", VA = "0x180AC3760")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAC3770", Offset = "0xAC2B70", VA = "0x180AC3770")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EGBEIIKGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xAD9130", Offset = "0xAD8530", VA = "0x180AD9130", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xAD9070", Offset = "0xAD8470", VA = "0x180AD9070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool AODAOIINPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<AJMBAHDMEPL, AJMBAHDMEPL> LPPEIPAEADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x81BCEA0", Offset = "0x81BC2A0", VA = "0x1881BCEA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x81BCCF0", Offset = "0x81BC0F0", VA = "0x1881BCCF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<AJMBAHDMEPL, AJMBAHDMEPL> HKJOODKGIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x81BCF00", Offset = "0x81BC300", VA = "0x1881BCF00", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x81BD540", Offset = "0x81BC940", VA = "0x1881BD540", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<AJMBAHDMEPL, AJMBAHDMEPL, AJMBAHDMEPL> IAACFIBNMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x81BD800", Offset = "0x81BCC00", VA = "0x1881BD800", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x81BCF60", Offset = "0x81BC360", VA = "0x1881BCF60", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x81BE3E0", Offset = "0x81BD7E0", VA = "0x1881BE3E0")]
	public GKHNOKAEANJ(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x81BDDE0", Offset = "0x81BD1E0", VA = "0x1881BDDE0", Slot = "12")]
	public void PJOFCLDPLJB(GameObject JBJNKCGNJKP, JEBCJLNAPEP ECLHDBEMNAL, HGFINBCKINA HNBHLACMGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x81BD230", Offset = "0x81BC630", VA = "0x1881BD230", Slot = "26")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x81BDD60", Offset = "0x81BD160", VA = "0x1881BDD60", Slot = "13")]
	public void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x81BC710", Offset = "0x81BBB10", VA = "0x1881BC710", Slot = "14")]
	public void AAGBOPIEMBE(AJMBAHDMEPL DGNBDNLBGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x81BCE40", Offset = "0x81BC240", VA = "0x1881BCE40", Slot = "15")]
	public void FDMOJFMGAAL(AJMBAHDMEPL DGNBDNLBGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x81BD5A0", Offset = "0x81BC9A0", VA = "0x1881BD5A0", Slot = "22")]
	public bool KMBAJBLGBBC(KINKPINACFL CMHOGPBPNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x81BD300", Offset = "0x81BC700", VA = "0x1881BD300")]
	internal bool JBGCOBDCKPD([In] BEHMGHOPEFB NGIAGNLBILI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x81BC9F0", Offset = "0x81BBDF0", VA = "0x1881BC9F0")]
	internal bool BOCJHEANFIL([In] BEHMGHOPEFB NGIAGNLBILI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x81BD050", Offset = "0x81BC450", VA = "0x1881BD050")]
	internal void ICPJPLPLGJP(AJMBAHDMEPL DGNBDNLBGEN, int CCMGDNACDMA, bool DGDPKPFONHM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x81BCE40", Offset = "0x81BC240", VA = "0x1881BCE40")]
	internal bool MKMBFGPKBLH(AJMBAHDMEPL NOJJKJFNCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x81BD410", Offset = "0x81BC810", VA = "0x1881BD410")]
	internal bool JELAJHKGKKB(AJMBAHDMEPL JGADNDGOEPG, int NFHNKAJEHFI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x81BDC70", Offset = "0x81BD070", VA = "0x1881BDC70", Slot = "16")]
	public void OEPLKEALNHO(AJMBAHDMEPL DGNBDNLBGEN, HashSet<AJMBAHDMEPL> BGDONCIHNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x81BD5F0", Offset = "0x81BC9F0", VA = "0x1881BD5F0", Slot = "17")]
	public void LGHEPDFGKIA(AJMBAHDMEPL JGADNDGOEPG, AJMBAHDMEPL NKAOICEGBBD, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x81BC8B0", Offset = "0x81BBCB0", VA = "0x1881BC8B0", Slot = "18")]
	public void ALOMOPAHGGH(AJMBAHDMEPL EGEKKBMNDOF, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x81BDAB0", Offset = "0x81BCEB0", VA = "0x1881BDAB0", Slot = "19")]
	public void NLDLECBDEFH(AJMBAHDMEPL EGEKKBMNDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x81BD860", Offset = "0x81BCC60", VA = "0x1881BD860")]
	public void NBOEOKPJPJH([Optional] NELIJLIGAOD NNCJNLLPMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x81BCFC0", Offset = "0x81BC3C0", VA = "0x1881BCFC0", Slot = "23")]
	public void HPDIIGNOJLN(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x81BC730", Offset = "0x81BBB30", VA = "0x1881BC730", Slot = "20")]
	public LFHAHGOLIPJ AAKMJKHAGBK(bool MPPBFPEHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x81BCB40", Offset = "0x81BBF40", VA = "0x1881BCB40", Slot = "21")]
	public LFHAHGOLIPJ DAFDLEACLPJ(HashSet<Guid> LPLBPDOHGMP, bool MPPBFPEHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x81BCE00", Offset = "0x81BC200", VA = "0x1881BCE00", Slot = "25")]
	public void EMBHIHLGLAM(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x81BCD50", Offset = "0x81BC150", VA = "0x1881BCD50", Slot = "24")]
	public void EGBELKINDOG(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class FLGPEMHHPDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly NIFKGGOBKPN<AJMBAHDMEPL, AJMBAHDMEPL> LPPEIPAEADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly NIFKGGOBKPN<AJMBAHDMEPL, AJMBAHDMEPL> HKJOODKGIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly FKJIGLNDBNB<AJMBAHDMEPL, AJMBAHDMEPL, AJMBAHDMEPL> IAACFIBNMCG;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x81BC4D0", Offset = "0x81BB8D0", VA = "0x1881BC4D0")]
	public FLGPEMHHPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	public void PJOFCLDPLJB(GKHNOKAEANJ JPGAFCLKGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x81BC470", Offset = "0x81BB870", VA = "0x1881BC470")]
	public void MBNDJIAHAHM(AJMBAHDMEPL JIECBJMGMAC, AJMBAHDMEPL HCOPOFCDINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x81BC410", Offset = "0x81BB810", VA = "0x1881BC410")]
	public void ICKCJBNBNEM(AJMBAHDMEPL JIECBJMGMAC, AJMBAHDMEPL HCOPOFCDINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x81BC390", Offset = "0x81BB790", VA = "0x1881BC390")]
	public void EMAHFCEGFIF(AJMBAHDMEPL DNNKPCKHKEP, AJMBAHDMEPL LPICKFBBMGL, AJMBAHDMEPL HCOPOFCDINJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class NHKMMGFMLOH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private GKHNOKAEANJ JPGAFCLKGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private BJPOLKGBHLA KMFAHFKEGPF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NHKMMGFMLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x81CACB0", Offset = "0x81CA0B0", VA = "0x1881CACB0")]
	public void PJOFCLDPLJB(GKHNOKAEANJ JPGAFCLKGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x81CAAE0", Offset = "0x81C9EE0", VA = "0x1881CAAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x81CAC70", Offset = "0x81CA070", VA = "0x1881CAC70")]
	private void OJEKKEHIGMN(NNAECDFEPDN BDBJAOEOBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x81CAAF0", Offset = "0x81C9EF0", VA = "0x1881CAAF0")]
	private void EMGLLADPJOK(NELIJLIGAOD JKLJPPBAIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x81CA9D0", Offset = "0x81C9DD0", VA = "0x1881CA9D0")]
	public void CECNJMBFMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x81CAB60", Offset = "0x81C9F60", VA = "0x1881CAB60")]
	public void FMMBGFINKJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MPCCPHLLCPG
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GDOKIKNPKPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public JFAGCPCLAAF container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GDOKIKNPKPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x81BC6A0", Offset = "0x81BBAA0", VA = "0x1881BC6A0")]
		internal GKHNOKAEANJ OHJDLJPELHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x81C9640", Offset = "0x81C8A40", VA = "0x1881C9640")]
	public static void AKGMEKBJIMB(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x81C9840", Offset = "0x81C8C40", VA = "0x1881C9840")]
	public static void PGICFAKKEAC(JFAGCPCLAAF MNCIANLLPKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class AIPCIMEOPDF : IDisposable, OBFFPECDEJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, HKDNDABGIKO> JLJANOBEHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly DOONLDDLBAK BIANJEGPNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NGBENHMLEFO DOCPCJOAHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private FEJLNKBAEHD KBCGJHHFJKD;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker MDCFGPNOMDI;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x81B9E30", Offset = "0x81B9230", VA = "0x1881B9E30")]
	public AIPCIMEOPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x81B9D90", Offset = "0x81B9190", VA = "0x1881B9D90", Slot = "7")]
	public void PJOFCLDPLJB(FEJLNKBAEHD KBCGJHHFJKD, NGBENHMLEFO DOCPCJOAHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x81B9290", Offset = "0x81B8690", VA = "0x1881B9290", Slot = "5")]
	public void DIDANOBHBGO(LBBEIMLNHNH FBMPCJKIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x81B9660", Offset = "0x81B8A60", VA = "0x1881B9660", Slot = "9")]
	public void FBJDBNNJOEO(LBBEIMLNHNH HDAHEIGNENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x81B9BD0", Offset = "0x81B8FD0", VA = "0x1881B9BD0", Slot = "8")]
	public void KEIJMKDGMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x81B9040", Offset = "0x81B8440", VA = "0x1881B9040", Slot = "10")]
	public void AFNKAOOKFNN(LBBEIMLNHNH HCNFCJNACBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x81B98A0", Offset = "0x81B8CA0", VA = "0x1881B98A0", Slot = "11")]
	public void HAHPPCKIHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x81B9A20", Offset = "0x81B8E20", VA = "0x1881B9A20")]
	private bool IGOONDMCLBP(LBBEIMLNHNH FFIGKKPMMAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class OAMDMKACFKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct BPGNMMDLENN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly NEALJBIHCNL AKNMIJNMDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> LPLBPDOHGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly KINKPINACFL BDCMHNJBOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly KINKPINACFL MCJADABFOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool MPPBFPEHJFH;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool NNJEEHLGMKC
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x81BA690", Offset = "0x81B9A90", VA = "0x1881BA690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x81BA910", Offset = "0x81B9D10", VA = "0x1881BA910")]
		public BPGNMMDLENN(NEALJBIHCNL AKNMIJNMDHP, HashSet<Guid> LPLBPDOHGMP, bool MPPBFPEHJFH, [Optional] KINKPINACFL BDCMHNJBOBI, [Optional] KINKPINACFL MCJADABFOJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x81BA050", Offset = "0x81B9450", VA = "0x1881BA050")]
		public KINKPINACFL COFPFOKABJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x81BA5D0", Offset = "0x81B99D0", VA = "0x1881BA5D0")]
		private KINKPINACFL GFDEOHBGGGO([Out] KINKPINACFL OKELOPEBLFJ, [Out] KINKPINACFL CPECEDFHPNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x81BA1F0", Offset = "0x81B95F0", VA = "0x1881BA1F0")]
		private KINKPINACFL FIDCHAOIEGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x81BA7A0", Offset = "0x81B9BA0", VA = "0x1881BA7A0")]
		private void NENEFAILOBO(KINKPINACFL OJLNIIAIHPI, KINKPINACFL MDIHMCJJOOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x81BA410", Offset = "0x81B9810", VA = "0x1881BA410")]
		private void FJDIPBOPIHA(KINKPINACFL OKELOPEBLFJ, KINKPINACFL CPECEDFHPNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private GKHNOKAEANJ JPGAFCLKGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private FEJLNKBAEHD KBCGJHHFJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private OBFFPECDEJM PHFIOMGAMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private BJPOLKGBHLA KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool DDGCPEGKBHK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool OBHAKJDGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x81CB570", Offset = "0x81CA970", VA = "0x1881CB570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool KJOBGNKKNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x81CD030", Offset = "0x81CC430", VA = "0x1881CD030")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x81CB830", Offset = "0x81CAC30", VA = "0x1881CB830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x81CDA00", Offset = "0x81CCE00", VA = "0x1881CDA00")]
	public void PJOFCLDPLJB(GKHNOKAEANJ JPGAFCLKGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x81CB400", Offset = "0x81CA800", VA = "0x1881CB400")]
	public LFHAHGOLIPJ AAKMJKHAGBK(bool MPPBFPEHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x81CB850", Offset = "0x81CAC50", VA = "0x1881CB850")]
	public LFHAHGOLIPJ DAFDLEACLPJ(HashSet<Guid> LPLBPDOHGMP, bool MPPBFPEHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x81CC660", Offset = "0x81CBA60", VA = "0x1881CC660")]
	public void HPDIIGNOJLN(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x81CBCA0", Offset = "0x81CB0A0", VA = "0x1881CBCA0")]
	public void EGBELKINDOG(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x81CBFC0", Offset = "0x81CB3C0", VA = "0x1881CBFC0")]
	public void GGJHNHBBJDJ(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x81CC6F0", Offset = "0x81CBAF0", VA = "0x1881CC6F0")]
	private void JLHFHCJAFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x81CB5C0", Offset = "0x81CA9C0", VA = "0x1881CB5C0")]
	private KINKPINACFL ALBICPIJBDG(NEALJBIHCNL BLJBPFHLMML, bool MPPBFPEHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x81CD290", Offset = "0x81CC690", VA = "0x1881CD290")]
	private static void OEIAKDBLKEA(NEALJBIHCNL BLJBPFHLMML, bool MPPBFPEHJFH, KINKPINACFL CMHOGPBPNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x81CD050", Offset = "0x81CC450", VA = "0x1881CD050")]
	private void MDPADJCKOHF(NEALJBIHCNL BLJBPFHLMML, bool MPPBFPEHJFH, KINKPINACFL CMHOGPBPNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x81CCC20", Offset = "0x81CC020", VA = "0x1881CCC20")]
	private KINKPINACFL KAMBDLMNKHB(NEALJBIHCNL AKNMIJNMDHP, HashSet<Guid> LPLBPDOHGMP, bool MPPBFPEHJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x81CBD40", Offset = "0x81CB140", VA = "0x1881CBD40")]
	private bool GDMJFNDLLAG(LFHAHGOLIPJ JDGEADMBCOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x81CBFF0", Offset = "0x81CB3F0", VA = "0x1881CBFF0")]
	private bool HJBBCHNJGHE(KINKPINACFL CMHOGPBPNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x81CD270", Offset = "0x81CC670", VA = "0x1881CD270")]
	private bool NGAKFFOEOPF(LFHAHGOLIPJ KBCGJHHFJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x81CBB80", Offset = "0x81CAF80", VA = "0x1881CBB80")]
	private static bool EGBAMOHKADK(KINKPINACFL CMHOGPBPNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x81CCDA0", Offset = "0x81CC1A0", VA = "0x1881CCDA0")]
	public static bool KMBAJBLGBBC(KINKPINACFL CMHOGPBPNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x81CC8D0", Offset = "0x81CBCD0", VA = "0x1881CC8D0")]
	private AJMBAHDMEPL JMOMKHNDDPE(KINKPINACFL CMHOGPBPNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x81CB6B0", Offset = "0x81CAAB0", VA = "0x1881CB6B0")]
	private AJMBAHDMEPL BGENPHHPMHN(KINKPINACFL CMHOGPBPNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x81CB9F0", Offset = "0x81CADF0", VA = "0x1881CB9F0")]
	private AJMBAHDMEPL DDJPJAMKNPC(KINKPINACFL CMHOGPBPNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x81C7870", Offset = "0x81C6C70", VA = "0x1881C7870")]
	private static Guid IOIFGMAJCBA(KINKPINACFL CMHOGPBPNOC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x81CCCB0", Offset = "0x81CC0B0", VA = "0x1881CCCB0")]
	private string KFGHKCAJCGA(KINKPINACFL CMHOGPBPNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x81CD540", Offset = "0x81CC940", VA = "0x1881CD540")]
	private bool OGGENCHBPHP(NEALJBIHCNL BLJBPFHLMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x81CD730", Offset = "0x81CCB30", VA = "0x1881CD730")]
	private static void OKAHBCIOANN(NEALJBIHCNL AKNMIJNMDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OAMDMKACFKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct BEHMGHOPEFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public AJMBAHDMEPL HCOPOFCDINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public AJMBAHDMEPL JIECBJMGMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int NFHNKAJEHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int FHHCIKJICIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 AMANMLHBFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion HFAPDOPNNFK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NMENEPCHFDM MIOGGEKDBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x81B9F40", Offset = "0x81B9340", VA = "0x1881B9F40")]
		get
		{
			return default(NMENEPCHFDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NMENEPCHFDM COEPEDJEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x81B9F10", Offset = "0x81B9310", VA = "0x1881B9F10")]
		get
		{
			return default(NMENEPCHFDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x81B9FE0", Offset = "0x81B93E0", VA = "0x1881B9FE0")]
	public BEHMGHOPEFB(AJMBAHDMEPL HCOPOFCDINJ, AJMBAHDMEPL JIECBJMGMAC, int NFHNKAJEHFI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface FEJLNKBAEHD
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LBBEIMLNHNH NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJOFCLDPLJB(KPMEGGALEPC JPGAFCLKGNM);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MFGDPHEDOGO([In] BEHMGHOPEFB NGIAGNLBILI, bool DGDPKPFONHM = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KCALJOPDCAH(AJMBAHDMEPL JAJOCFOCANE);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AKBHMJOPDCC(AJMBAHDMEPL JGADNDGOEPG, int NFHNKAJEHFI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JIOEEABHKAN(AJMBAHDMEPL EGEKKBMNDOF, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AONAJKGNKCC();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void APNMJMBLMCI(Func<AJMBAHDMEPL, bool> EDFMOHDPPLH);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OEPLKEALNHO(AJMBAHDMEPL DGNBDNLBGEN, HashSet<AJMBAHDMEPL> KCIEHBBPJAG);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<AJMBAHDMEPL> GIHAPKKNNEJ();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BCELAFGKKEK(AJMBAHDMEPL DGNBDNLBGEN, [Out] NMENEPCHFDM AFBABGHMPHE);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DPAGPHMFGOG(DOONLDDLBAK BFDLNHAHOHH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool DOONLDDLBAK(LBBEIMLNHNH BLJBPFHLMML);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface LBBEIMLNHNH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	AJMBAHDMEPL MCAIEJEFHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LBBEIMLNHNH BIMLAPPNEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NMENEPCHFDM OAEINFGAEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool AAFMBFNGMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HKDNDABGIKO
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPJPKJAMFMN(AJMBAHDMEPL FFHGPIDMOAI, NMENEPCHFDM HCOPOFCDINJ);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGPMADKCEJN(AJMBAHDMEPL FFHGPIDMOAI, NMENEPCHFDM HCOPOFCDINJ);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMGGLNPNJMN(AJMBAHDMEPL FFHGPIDMOAI, NMENEPCHFDM HCOPOFCDINJ);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENKJHHHNMDE(AJMBAHDMEPL FFHGPIDMOAI, NMENEPCHFDM HCOPOFCDINJ);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HKDNDABGIKO Instantiate(Transform GANAIKEBLIG);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ONLDIMNIKII();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NGBENHMLEFO
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJOFCLDPLJB(Transform GANAIKEBLIG, HKDNDABGIKO EBMHEFKJBPE);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKDNDABGIKO EOOIOHHOJJL();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABJBKLDEPAF(HKDNDABGIKO MDMKKEGBIHI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ENKJHMGICBB : EPINHIDBBLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNAOHBOKIPM();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CEJIKCNNBMO(Guid KBCJANMKKCN);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface OBFFPECDEJM
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIDANOBHBGO(LBBEIMLNHNH FBMPCJKIJNO);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJOFCLDPLJB(FEJLNKBAEHD KBCGJHHFJKD, NGBENHMLEFO LNIHNBNFJGB);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KEIJMKDGMOI();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FBJDBNNJOEO(LBBEIMLNHNH HDAHEIGNENF);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFNKAOOKFNN(LBBEIMLNHNH HCNFCJNACBP);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HAHPPCKIHHK();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class NEALJBIHCNL : LBBEIMLNHNH
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KMHODOAFDMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public NMENEPCHFDM nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NEALJBIHCNL foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KMHODOAFDMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x81C1F40", Offset = "0x81C1340", VA = "0x1881C1F40")]
		internal bool JDBGPGOFFDF(LBBEIMLNHNH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NMENEPCHFDM AFBABGHMPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<NEALJBIHCNL> IBDCABEELNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NEALJBIHCNL MBBBFDAOJKF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NMENEPCHFDM OAEINFGAEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x14EADF0", Offset = "0x14EA1F0", VA = "0x1814EADF0", Slot = "6")]
		get
		{
			return default(NMENEPCHFDM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x14EAD20", Offset = "0x14EA120", VA = "0x1814EAD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private NEALJBIHCNL JIECBJMGMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x81CA540", Offset = "0x81C9940", VA = "0x1881CA540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public LBBEIMLNHNH BIMLAPPNEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AJMBAHDMEPL MCAIEJEFHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool AAFMBFNGMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x81CA620", Offset = "0x81C9A20", VA = "0x1881CA620", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool EBKPGFNNOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x81CA3F0", Offset = "0x81C97F0", VA = "0x1881CA3F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected NEALJBIHCNL LDEPDDDHLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x81CA900", Offset = "0x81C9D00", VA = "0x1881CA900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x81CA920", Offset = "0x81C9D20", VA = "0x1881CA920")]
	public NEALJBIHCNL(NMENEPCHFDM ABGBFOKAACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x81CA7B0", Offset = "0x81C9BB0", VA = "0x1881CA7B0")]
	public NEALJBIHCNL NLKFHPNBABH(NMENEPCHFDM BIJBDNOKHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x81CA630", Offset = "0x81C9A30", VA = "0x1881CA630")]
	public NEALJBIHCNL NLHPLLPEEHE(NMENEPCHFDM DNIENBILBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x81C9EA0", Offset = "0x81C92A0", VA = "0x1881C9EA0")]
	public NEALJBIHCNL CBDHBFLGDII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x81CA2A0", Offset = "0x81C96A0", VA = "0x1881CA2A0")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x81CA1F0", Offset = "0x81C95F0", VA = "0x1881CA1F0")]
	public NEALJBIHCNL HAENONPNKJM(NMENEPCHFDM LPICKFBBMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x81CA080", Offset = "0x81C9480", VA = "0x1881CA080")]
	private static void DPAGPHMFGOG(NEALJBIHCNL LGLOHDKHAEN, DOONLDDLBAK GKJPEAFFBEP, bool CPPDJPDKKNF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x81CA1E0", Offset = "0x81C95E0", VA = "0x1881CA1E0", Slot = "9")]
	public void DPAGPHMFGOG(DOONLDDLBAK BFDLNHAHOHH, bool CHCEHNMNELJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x81CA440", Offset = "0x81C9840", VA = "0x1881CA440")]
	public static NEALJBIHCNL ILNKIFICDNB(NEALJBIHCNL LGLOHDKHAEN, NMENEPCHFDM FGCMOIIFCDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface BJPOLKGBHLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool OBHAKJDGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<NNAECDFEPDN> OJEKKEHIGMN;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<NELIJLIGAOD> EMGLLADPJOK;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IPJPKJAMFMN(GKHNOKAEANJ JPGAFCLKGNM, HGFINBCKINA KNPJODPFIPD);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGHEPDFGKIA(AJMBAHDMEPL JGADNDGOEPG, AJMBAHDMEPL NKAOICEGBBD, int NFHNKAJEHFI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ALOMOPAHGGH(AJMBAHDMEPL EGEKKBMNDOF, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AKEECCGNBGD(LFHAHGOLIPJ HBFGCHKNKIB, [Optional] NELIJLIGAOD NNCJNLLPMHL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LOMHDHFEFKF
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x81C2120", Offset = "0x81C1520", VA = "0x1881C2120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object NKAKNKMIPPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x81C2080", Offset = "0x81C1480", VA = "0x1881C2080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x81C20C0", Offset = "0x81C14C0", VA = "0x1881C20C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class ENAFGJBJLGM : BJPOLKGBHLA, IDisposable, NCGDMBCPODC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private GKHNOKAEANJ JPGAFCLKGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HGFINBCKINA HNBHLACMGEH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool OBHAKJDGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x81BB260", Offset = "0x81BA660", VA = "0x1881BB260", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x81BB9B0", Offset = "0x81BADB0", VA = "0x1881BB9B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView EFNLEGLOEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x81BB660", Offset = "0x81BAA60", VA = "0x1881BB660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NNAECDFEPDN> OJEKKEHIGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x81BB750", Offset = "0x81BAB50", VA = "0x1881BB750", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x81BB9F0", Offset = "0x81BADF0", VA = "0x1881BB9F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NELIJLIGAOD> EMGLLADPJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x81BB2C0", Offset = "0x81BA6C0", VA = "0x1881BB2C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x81BB5C0", Offset = "0x81BA9C0", VA = "0x1881BB5C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x81BB7F0", Offset = "0x81BABF0", VA = "0x1881BB7F0", Slot = "10")]
	public void IPJPKJAMFMN(GKHNOKAEANJ JPGAFCLKGNM, HGFINBCKINA HNBHLACMGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x81BB700", Offset = "0x81BAB00", VA = "0x1881BB700", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x81BB880", Offset = "0x81BAC80", VA = "0x1881BB880", Slot = "11")]
	public void LGHEPDFGKIA(AJMBAHDMEPL JGADNDGOEPG, AJMBAHDMEPL NKAOICEGBBD, int NFHNKAJEHFI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x81BB490", Offset = "0x81BA890", VA = "0x1881BB490", Slot = "12")]
	public void ALOMOPAHGGH(AJMBAHDMEPL EGEKKBMNDOF, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x81BB360", Offset = "0x81BA760", VA = "0x1881BB360", Slot = "13")]
	public void AKEECCGNBGD(LFHAHGOLIPJ HBFGCHKNKIB, [Optional] NELIJLIGAOD NNCJNLLPMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x81BBCD0", Offset = "0x81BB0D0", VA = "0x1881BBCD0")]
	[MGNNEGPEDEK]
	private void RpcMasterReparentNodes(AJMBAHDMEPL EGEKKBMNDOF, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x81BBAD0", Offset = "0x81BAED0", VA = "0x1881BBAD0")]
	[MGNNEGPEDEK]
	private void RpcMasterModifyNode(AJMBAHDMEPL JGADNDGOEPG, AJMBAHDMEPL NKAOICEGBBD, int NFHNKAJEHFI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x81BC0D0", Offset = "0x81BB4D0", VA = "0x1881BC0D0")]
	[MGNNEGPEDEK]
	private void RpcReparentNodes(AJMBAHDMEPL EGEKKBMNDOF, int HHOGDGHGJOG, AJMBAHDMEPL LPICKFBBMGL, int LJFLJGAMELO, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK, DBOHBCPJIND HIIEAFLAMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x81BBFE0", Offset = "0x81BB3E0", VA = "0x1881BBFE0")]
	[MGNNEGPEDEK]
	private void RpcModifyNode(AJMBAHDMEPL JGADNDGOEPG, int NFHNKAJEHFI, int FHHCIKJICIP, Vector3 AMANMLHBFHF, Quaternion HFAPDOPNNFK, DBOHBCPJIND HIIEAFLAMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x81BBA90", Offset = "0x81BAE90", VA = "0x1881BBA90")]
	[MGNNEGPEDEK]
	private void RpcDeserializeConnectableGraph(LFHAHGOLIPJ KBCGJHHFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ENAFGJBJLGM()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, HKDNDABGIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x81C2180", Offset = "0x81C1580", VA = "0x1881C2180", Slot = "4")]
		private void CDEIJNJDHLP(AJMBAHDMEPL FFHGPIDMOAI, NMENEPCHFDM HCOPOFCDINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x81C2720", Offset = "0x81C1B20", VA = "0x1881C2720", Slot = "5")]
		private void IKMKOGJIHDA(AJMBAHDMEPL FFHGPIDMOAI, NMENEPCHFDM HCOPOFCDINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x81C24F0", Offset = "0x81C18F0", VA = "0x1881C24F0", Slot = "6")]
		private void GCHAIIIDGML(AJMBAHDMEPL FFHGPIDMOAI, NMENEPCHFDM HCOPOFCDINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x81C2300", Offset = "0x81C1700", VA = "0x1881C2300", Slot = "7")]
		private void FHIECKFANIJ(AJMBAHDMEPL FFHGPIDMOAI, NMENEPCHFDM HCOPOFCDINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x81C2A00", Offset = "0x81C1E00", VA = "0x1881C2A00", Slot = "8")]
		private HKDNDABGIKO OMMGOJLFPEJ(Transform GANAIKEBLIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x81C29A0", Offset = "0x81C1DA0", VA = "0x1881C29A0", Slot = "9")]
		private void IPAFLCPDKOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NGFPKDDJNLB
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3E5D410", Offset = "0x3E5C810", VA = "0x183E5D410")]
	public static COLHGHKNDPD<T> NNLBCINMFBP<T>(this JFAGCPCLAAF MNCIANLLPKI)
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
