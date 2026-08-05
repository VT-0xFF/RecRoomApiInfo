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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8225460", Offset = "0x8223E60", VA = "0x188225460", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2349C00", Offset = "0x2348600", VA = "0x182349C00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8227060", Offset = "0x8225A60", VA = "0x188227060")]
		private void JKAPILFGJLE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8226EF0", Offset = "0x82258F0", VA = "0x188226EF0")]
		private void BEAEGHPCFKG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82271D0", Offset = "0x8225BD0", VA = "0x1882271D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8227500", Offset = "0x8225F00", VA = "0x188227500")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class GIGCMAKNAJO : JOADNKCGLME, NAGAKFIOPNO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GPGBCDICHMH : IEnumerable<MOAMDBGDHOE>, IEnumerable, IEnumerator<MOAMDBGDHOE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private MOAMDBGDHOE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DOIIIDJCDGH localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public DOIIIDJCDGH <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GIGCMAKNAJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private DHIIJDNMGLD <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private LOFEKKDNAJB <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private LOFEKKDNAJB.KEOCKOIDPOK <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private MOAMDBGDHOE System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public GPGBCDICHMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x821E4D0", Offset = "0x821CED0", VA = "0x18821E4D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x821E050", Offset = "0x821CA50", VA = "0x18821E050", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x821E030", Offset = "0x821CA30", VA = "0x18821E030")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x821E3B0", Offset = "0x821CDB0", VA = "0x18821E3B0")]
		private void NADPDCNBFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x821E480", Offset = "0x821CE80", VA = "0x18821E480", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x821E3D0", Offset = "0x821CDD0", VA = "0x18821E3D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MOAMDBGDHOE> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x821E3D0", Offset = "0x821CDD0", VA = "0x18821E3D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class IGJHBLFOCLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public GIGCMAKNAJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CCELPEKIHEB nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public IGJHBLFOCLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x821E900", Offset = "0x821D300", VA = "0x18821E900")]
		internal object HBLDKFFLGGN(CCELPEKIHEB x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IAGDCGOLNFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CCELPEKIHEB child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IGJHBLFOCLE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public IAGDCGOLNFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x821E6B0", Offset = "0x821D0B0", VA = "0x18821E6B0")]
		internal object NEDMGNJDHLK((CCELPEKIHEB child, CCELPEKIHEB nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly MEBJEIOEDLD FBAMGEOMOHA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly MEBJEIOEDLD CIFLICCNHBF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly MEBJEIOEDLD GDFMMAHKMNF;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly MEBJEIOEDLD PLBHHLFAMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private DBNPHICECAH FFNGPKEGMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KJEJNICMLBO LANNHJEFEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private NPHMHJLBEIO HMJDJAAIHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private ALLJLHEOFMH JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CDAECHDMKKL CHMEIMFBPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private ODIHIJIOMNL NFKGFGOALMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly GAMNBBGFJEO INBLNPFFLJN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HCIBKCBAOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA91C40", Offset = "0xA90640", VA = "0x180A91C40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA91C60", Offset = "0xA90660", VA = "0x180A91C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EEAIJNBGOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<MOAMDBGDHOE, MOAMDBGDHOE> MOOGANIMPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x821D340", Offset = "0x821BD40", VA = "0x18821D340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8219F70", Offset = "0x8218970", VA = "0x188219F70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<MOAMDBGDHOE, MOAMDBGDHOE> IHBFELLKJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x821D290", Offset = "0x821BC90", VA = "0x18821D290", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x821CC50", Offset = "0x821B650", VA = "0x18821CC50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<MOAMDBGDHOE, MOAMDBGDHOE, MOAMDBGDHOE> HOEIAOMJKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x821AC10", Offset = "0x8219610", VA = "0x18821AC10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x821C8D0", Offset = "0x821B2D0", VA = "0x18821C8D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x821DFC0", Offset = "0x821C9C0", VA = "0x18821DFC0")]
	public GIGCMAKNAJO(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x821C010", Offset = "0x821AA10", VA = "0x18821C010", Slot = "12")]
	public void ICNIAFDKEKI(GameObject CEENMGBCJEJ, HPPMMMFHBEL PKNBLBNKJOD, CNLFCKONHLA AANOAFILNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x821D690", Offset = "0x821C090", VA = "0x18821D690", Slot = "26")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8219520", Offset = "0x8217F20", VA = "0x188219520", Slot = "22")]
	public bool BAEDIEHCIIE(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x821A020", Offset = "0x8218A20", VA = "0x18821A020")]
	private void CFLPKGNMKEI(DOIIIDJCDGH PEPJMOGCLIA, DOIIIDJCDGH IJDEAEOJKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x821C2A0", Offset = "0x821ACA0", VA = "0x18821C2A0")]
	private void IGKGIEJKJJJ(DOIIIDJCDGH PEPJMOGCLIA, DOIIIDJCDGH PNGIOOJCDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x821C9F0", Offset = "0x821B3F0", VA = "0x18821C9F0")]
	private void LIGGEKJECKO(DOIIIDJCDGH PEPJMOGCLIA, DOIIIDJCDGH PNGIOOJCDJD, DOIIIDJCDGH IJDEAEOJKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x821B990", Offset = "0x821A390", VA = "0x18821B990")]
	private void HCJPGBGJPEP(DOIIIDJCDGH PEPJMOGCLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "13")]
	public void AIICKBIOPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x821CF80", Offset = "0x821B980", VA = "0x18821CF80", Slot = "14")]
	public void MAJNBNPDEEJ(MOAMDBGDHOE KPDCNGDJNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "15")]
	public void CPOFHABEGHF(MOAMDBGDHOE KPDCNGDJNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x821A970", Offset = "0x8219370", VA = "0x18821A970", Slot = "17")]
	public void EIFGHPFFGMJ(MOAMDBGDHOE KPDCNGDJNGC, MOAMDBGDHOE EFHEFHNONAF, Vector3 GDEEHHOMKPN, Quaternion IEBOBJIHNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x821AAD0", Offset = "0x82194D0", VA = "0x18821AAD0")]
	public void EIFGHPFFGMJ(DOIIIDJCDGH KOAIHIGOIMD, DOIIIDJCDGH EFHEFHNONAF, Vector3 GDEEHHOMKPN, Quaternion IEBOBJIHNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x821BF80", Offset = "0x821A980", VA = "0x18821BF80")]
	public void HIDPGPGIPIB(MOAMDBGDHOE KPDCNGDJNGC, float HIEAAJPFMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x821A810", Offset = "0x8219210", VA = "0x18821A810", Slot = "18")]
	public void ECEFEAGFHIB(MOAMDBGDHOE GDBIGEGDAMG, int HNGLPLJEJAK, MOAMDBGDHOE OHCCHOPPCDN, int FLJLKLJKOJF, Vector3 GDEEHHOMKPN, Quaternion IEBOBJIHNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x821DDA0", Offset = "0x821C7A0", VA = "0x18821DDA0")]
	private float PIKHGNLJGDA(DOIIIDJCDGH KOAIHIGOIMD, DOIIIDJCDGH DFKFFPKHNCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x821A6D0", Offset = "0x82190D0", VA = "0x18821A6D0")]
	public void ECEFEAGFHIB(DOIIIDJCDGH KOAIHIGOIMD, DOIIIDJCDGH DFKFFPKHNCH, Vector3 GDEEHHOMKPN, Quaternion IEBOBJIHNAD, bool OEHCCIEPBDN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x821D880", Offset = "0x821C280", VA = "0x18821D880", Slot = "19")]
	public void OCPFDKKHAGJ(MOAMDBGDHOE KPDCNGDJNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x821C660", Offset = "0x821B060", VA = "0x18821C660", Slot = "16")]
	public void JCAFNKJJDDM(MOAMDBGDHOE KPDCNGDJNGC, HashSet<MOAMDBGDHOE> LNDAPAJGDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "20")]
	public JBNEINGIMJO IFGNPBHMMJG(bool NEANEFAHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "21")]
	public JBNEINGIMJO PDLPMCNONIJ(HashSet<Guid> BIOKEGBLEJO, bool NEANEFAHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x821B320", Offset = "0x8219D20", VA = "0x18821B320", Slot = "23")]
	public void FMPHFHDEPDJ(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x821DD30", Offset = "0x821C730", VA = "0x18821DD30", Slot = "24")]
	public void PEKBPOFMMBL(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x821DB80", Offset = "0x821C580", VA = "0x18821DB80", Slot = "25")]
	public void OPNCEHJMFDN(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x821A230", Offset = "0x8218C30", VA = "0x18821A230")]
	private void CJGHOAHJAMD(DOIIIDJCDGH KOAIHIGOIMD, DOIIIDJCDGH DFKFFPKHNCH, Vector3 GDEEHHOMKPN, Quaternion IEBOBJIHNAD, float HIEAAJPFMEJ, bool OEHCCIEPBDN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8219660", Offset = "0x8218060", VA = "0x188219660")]
	private void CDMCEJIOHCC(DOIIIDJCDGH KOAIHIGOIMD, DOIIIDJCDGH OGINNIAMBHJ, Vector3 GDEEHHOMKPN, Quaternion IEBOBJIHNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x821C980", Offset = "0x821B380", VA = "0x18821C980")]
	private void LDIKOCDNDKI(DOIIIDJCDGH KOAIHIGOIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x821A640", Offset = "0x8219040", VA = "0x18821A640")]
	[IteratorStateMachine(typeof(GPGBCDICHMH))]
	public IEnumerable<MOAMDBGDHOE> DKDGHACIIHM(DOIIIDJCDGH DBDHPICCKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x821B1F0", Offset = "0x8219BF0", VA = "0x18821B1F0")]
	internal MOAMDBGDHOE FEPOIDHCBGI(DOIIIDJCDGH DBDHPICCKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x821C4C0", Offset = "0x821AEC0", VA = "0x18821C4C0")]
	internal DOIIIDJCDGH IGOIIBEKOJM(MOAMDBGDHOE KPDCNGDJNGC)
	{
		return default(DOIIIDJCDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x821B3F0", Offset = "0x8219DF0", VA = "0x18821B3F0")]
	private bool GJENPJLPBKH(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x821C870", Offset = "0x821B270", VA = "0x18821C870")]
	private bool JDIBLCDDMOE(CCELPEKIHEB BFDHJGKAFLJ, [Out] MOAMDBGDHOE DFKFFPKHNCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x821AE50", Offset = "0x8219850", VA = "0x18821AE50")]
	private MOAMDBGDHOE FEPOIDHCBGI(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x821D3F0", Offset = "0x821BDF0", VA = "0x18821D3F0")]
	private MOAMDBGDHOE MOHJAKBCHBJ(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x821BDA0", Offset = "0x821A7A0", VA = "0x18821BDA0")]
	private MOAMDBGDHOE HEAOHNDGKBA(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8214480", Offset = "0x8212E80", VA = "0x188214480")]
	private static Guid LGPKMKBFDCJ(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8219570", Offset = "0x8217F70", VA = "0x188219570")]
	private string BHLBLKKGIMM(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x821ACC0", Offset = "0x82196C0", VA = "0x18821ACC0")]
	private void FBGNHPIBFDG(MOAMDBGDHOE KOAIHIGOIMD, MOAMDBGDHOE OGINNIAMBHJ, RigidTransform ABNMGHKPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x821D9F0", Offset = "0x821C3F0", VA = "0x18821D9F0")]
	private void OPBLNFMCMJL(MOAMDBGDHOE OGINNIAMBHJ, MOAMDBGDHOE KOAIHIGOIMD, RigidTransform ABNMGHKPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x821B390", Offset = "0x8219D90", VA = "0x18821B390")]
	private void GGLEFMOFGJK(MOAMDBGDHOE LKOPHANLFAH, MOAMDBGDHOE KOAIHIGOIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x821DBA0", Offset = "0x821C5A0", VA = "0x18821DBA0")]
	private void PEDHAIDHNDE(MOAMDBGDHOE KOAIHIGOIMD, MOAMDBGDHOE DFKFFPKHNCH, RigidTransform ABNMGHKPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x821D580", Offset = "0x821BF80", VA = "0x18821D580")]
	private void MOIJCMLEBGJ(DOIIIDJCDGH DBDHPICCKFG, MOAMDBGDHOE KPDCNGDJNGC, DOIIIDJCDGH PNGIOOJCDJD, DOIIIDJCDGH IJDEAEOJKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x821CD00", Offset = "0x821B700", VA = "0x18821CD00")]
	private void LPNOBDPHDOG(DOIIIDJCDGH DBDHPICCKFG, MOAMDBGDHOE KPDCNGDJNGC, MOAMDBGDHOE FJICMPILNEH, MOAMDBGDHOE PLGDJOLKAAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FCDMGDCLECE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BEJJEILFMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CFAMNNNCHJA container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BEJJEILFMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8214AB0", Offset = "0x82134B0", VA = "0x188214AB0")]
		internal GIGCMAKNAJO IEHFBCENPPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8215DA0", Offset = "0x82147A0", VA = "0x188215DA0")]
	public static void CNMHKOOJKDO(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8215F20", Offset = "0x8214920", VA = "0x188215F20")]
	public static void LHAKPFAOCKK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JDOKLJFDLJP : LJAICAMCIOM, OFEFAIOAIHI
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly GIGCMAKNAJO MELBPLDDLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly DOMAFHOFEED OIMCPJPGPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly GCEGLDJFKFL JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly PIFIGJFIMED[] HIMKPEAPDDA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MOAMDBGDHOE GKHJMIHFIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8222210", Offset = "0x8220C10", VA = "0x188222210", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MOAMDBGDHOE CEMOKMKFBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8221CA0", Offset = "0x82206A0", VA = "0x188221CA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 FPJPAOFOLPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8220ED0", Offset = "0x821F8D0", VA = "0x188220ED0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion GEJAIAJGGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82218C0", Offset = "0x82202C0", VA = "0x1882218C0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JFFNBINBPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x82216F0", Offset = "0x82200F0", VA = "0x1882216F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<MOAMDBGDHOE> JDAJLKKNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8220610", Offset = "0x821F010", VA = "0x188220610", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool GLIAELDKOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD49710", Offset = "0xD48110", VA = "0x180D49710", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD706F0", Offset = "0xD6F0F0", VA = "0x180D706F0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8222420", Offset = "0x8220E20", VA = "0x188222420", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject GNMGDLNMGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8222120", Offset = "0x8220B20", VA = "0x188222120", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8222140", Offset = "0x8220B40", VA = "0x188222140", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid PNPLJBJKEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8222270", Offset = "0x8220C70", VA = "0x188222270", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JFIPJIBKCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8222350", Offset = "0x8220D50", VA = "0x188222350", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool ICMMHJKIMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JEGMNJHGAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82216A0", Offset = "0x82200A0", VA = "0x1882216A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JEHPOBEJHFC BCNDEOFLNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8220E20", Offset = "0x821F820", VA = "0x188220E20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8221640", Offset = "0x8220040", VA = "0x188221640", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JEHPOBEJHFC CFLKJPABLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8220F90", Offset = "0x821F990", VA = "0x188220F90", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8220F30", Offset = "0x821F930", VA = "0x188220F30", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JEHPOBEJHFC ACJDHADOODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8220910", Offset = "0x821F310", VA = "0x188220910", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8221830", Offset = "0x8220230", VA = "0x188221830", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event ELBGHCNOEDB KHJJGPFCPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8221090", Offset = "0x821FA90", VA = "0x188221090", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8221C00", Offset = "0x8220600", VA = "0x188221C00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8222020", Offset = "0x8220A20", VA = "0x188222020")]
	public JDOKLJFDLJP(DOIIIDJCDGH JGBFCMNOFDB, RigidbodyEx NMIAFFNIHJH, DOMAFHOFEED OIMCPJPGPMM, PIFIGJFIMED[] HIMKPEAPDDA, GCEGLDJFKFL JDNAAPNIDID, JOADNKCGLME MELBPLDDLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8221890", Offset = "0x8220290", VA = "0x188221890", Slot = "19")]
	public void NNIEBIADIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "21")]
	public void ODDDHPOJDLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F39560", Offset = "0x7F37F60", VA = "0x187F39560", Slot = "22")]
	public void DIGBOGHHPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8221040", Offset = "0x821FA40", VA = "0x188221040", Slot = "20")]
	public void GMHPCBOPLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8221D60", Offset = "0x8220760", VA = "0x188221D60", Slot = "25")]
	public void PJKMLKBHPAE(int ACGPIJNDEDI, MOAMDBGDHOE OHCCHOPPCDN, int LEPNDIGDGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8221760", Offset = "0x8220160", VA = "0x188221760", Slot = "26")]
	public void MKLNNEOMFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8221920", Offset = "0x8220320", VA = "0x188221920", Slot = "27")]
	public void OHGLBHDCDKG(int ACGPIJNDEDI, MOAMDBGDHOE GDBIGEGDAMG, int ENIGHPKELGL, [Optional] Vector3? AHFMAPLJEED, [Optional] Quaternion? MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8220890", Offset = "0x821F290", VA = "0x188220890", Slot = "28")]
	public void CFHGBMGPEDP(MOAMDBGDHOE GDBIGEGDAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8220A10", Offset = "0x821F410", VA = "0x188220A10", Slot = "31")]
	public void DFFLLCEDNAG(Vector3 INLKDFBHNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8221330", Offset = "0x821FD30", VA = "0x188221330", Slot = "29")]
	public void HIBJACEEJIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8220690", Offset = "0x821F090", VA = "0x188220690", Slot = "30")]
	public void CAMOKCBAJLA(int FILGHJLFKAL, Vector3 FBHMIIMHGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8221260", Offset = "0x821FC60", VA = "0x188221260", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int ACGPIJNDEDI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8221130", Offset = "0x821FB30", VA = "0x188221130", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int ACGPIJNDEDI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAEF5C0", Offset = "0xAEDFC0", VA = "0x180AEF5C0", Slot = "42")]
	public Color GetConnectionSlotColor(int ACGPIJNDEDI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8220970", Offset = "0x821F370", VA = "0x188220970", Slot = "43")]
	public bool CanConnectTo(int ACGPIJNDEDI, MOAMDBGDHOE KNKBLHDENIJ, int MBILPPICAEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "44")]
	public void ParentChanged(int ACGPIJNDEDI, MOAMDBGDHOE ADOCFCBLLGH, int HIABPODCIFC, Vector3 OKDKGFGDBHO, Quaternion HLLFJFCLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "45")]
	public void ChildAdded(int ACGPIJNDEDI, MOAMDBGDHOE BIOCGEFNBGJ, int KMDGNGHKMJE, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "46")]
	public void ChildRemoved(int ACGPIJNDEDI, MOAMDBGDHOE AFJOOCBHLIK, int OKEAIPBGGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "47")]
	public void ConnectionModified(int ACGPIJNDEDI, MOAMDBGDHOE OHCCHOPPCDN, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8221F70", Offset = "0x8220970", VA = "0x188221F70", Slot = "48")]
	public void RootChanged(MOAMDBGDHOE GCLDJADELKP, MOAMDBGDHOE EHKCNEFJOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8220FF0", Offset = "0x821F9F0", VA = "0x188220FF0", Slot = "23")]
	public void GGFINDEICHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8220640", Offset = "0x821F040", VA = "0x188220640", Slot = "24")]
	public void AOJGGMPOPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8220E80", Offset = "0x821F880", VA = "0x188220E80")]
	private void EKFIMGLIBGG(bool LDFHCGIAHMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(EDIKJCFLPOK), new string[] { })]
public class AGBKIOIIEFI : EDIKJCFLPOK, ELBBPAKODBM, MOJJPNLDPDK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BGDNGNMFPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BGDNGNMFPKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private MNHBLPDGOEN KPICELCLOBJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object LCGPABNJMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8214960", Offset = "0x8213360", VA = "0x188214960", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x82149F0", Offset = "0x82133F0", VA = "0x1882149F0", Slot = "5")]
	private void PJJHJIAFIHL(JFKAHIBHGGP INBLNPFFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x12E6830", Offset = "0x12E5230", VA = "0x1812E6830", Slot = "6")]
	private void AHPLLBHAECI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public AGBKIOIIEFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(JOADNKCGLME), new string[] { "Ignore", "Mock" })]
public class KJNDKKMKBEL : JOADNKCGLME, NAGAKFIOPNO
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HCIBKCBAOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EEAIJNBGOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<MOAMDBGDHOE, MOAMDBGDHOE> MOOGANIMPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8222970", Offset = "0x8221370", VA = "0x188222970", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8222600", Offset = "0x8221000", VA = "0x188222600", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<MOAMDBGDHOE, MOAMDBGDHOE> IHBFELLKJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x82228C0", Offset = "0x82212C0", VA = "0x1882228C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8222810", Offset = "0x8221210", VA = "0x188222810", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<MOAMDBGDHOE, MOAMDBGDHOE, MOAMDBGDHOE> HOEIAOMJKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x82226B0", Offset = "0x82210B0", VA = "0x1882226B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8222760", Offset = "0x8221160", VA = "0x188222760", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "26")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "12")]
	public void ICNIAFDKEKI(GameObject CEENMGBCJEJ, HPPMMMFHBEL PKNBLBNKJOD, CNLFCKONHLA HLNCMFCIMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "13")]
	public void AIICKBIOPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "14")]
	public void MAJNBNPDEEJ(MOAMDBGDHOE KPDCNGDJNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "15")]
	public void CPOFHABEGHF(MOAMDBGDHOE KPDCNGDJNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "16")]
	public void JCAFNKJJDDM(MOAMDBGDHOE KPDCNGDJNGC, HashSet<MOAMDBGDHOE> LNDAPAJGDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "17")]
	public void EIFGHPFFGMJ(MOAMDBGDHOE KPDCNGDJNGC, MOAMDBGDHOE EFHEFHNONAF, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "18")]
	public void ECEFEAGFHIB(MOAMDBGDHOE KPDCNGDJNGC, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "19")]
	public void OCPFDKKHAGJ(MOAMDBGDHOE KPDCNGDJNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "20")]
	public JBNEINGIMJO IFGNPBHMMJG(bool NEANEFAHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "21")]
	public JBNEINGIMJO PDLPMCNONIJ(HashSet<Guid> BIOKEGBLEJO, bool NEANEFAHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "22")]
	public bool BAEDIEHCIIE(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "23")]
	public void FMPHFHDEPDJ(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "24")]
	public void PEKBPOFMMBL(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "25")]
	public void OPNCEHJMFDN(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KJNDKKMKBEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MOAMDBGDHOE : OFEFAIOAIHI, IEquatable<MOAMDBGDHOE>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OFEFAIOAIHI
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MOAMDBGDHOE GKHJMIHFIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject GNMGDLNMGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid PNPLJBJKEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int JFIPJIBKCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool ICMMHJKIMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int ACGPIJNDEDI);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int ACGPIJNDEDI);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int ACGPIJNDEDI);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int ACGPIJNDEDI, MOAMDBGDHOE KNKBLHDENIJ, int ECMJNBEBNIF);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int ACGPIJNDEDI, MOAMDBGDHOE ADOCFCBLLGH, int HIABPODCIFC, Vector3 OKDKGFGDBHO, Quaternion HLLFJFCLBJJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int ACGPIJNDEDI, MOAMDBGDHOE BIOCGEFNBGJ, int KMDGNGHKMJE, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int ACGPIJNDEDI, MOAMDBGDHOE AFJOOCBHLIK, int OKEAIPBGGCB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int ACGPIJNDEDI, MOAMDBGDHOE OHCCHOPPCDN, int KDBOBOFKOJN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(MOAMDBGDHOE GCLDJADELKP, MOAMDBGDHOE EHKCNEFJOCO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JOADNKCGLME : NAGAKFIOPNO
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HCIBKCBAOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool EEAIJNBGOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MOAMDBGDHOE, MOAMDBGDHOE> MOOGANIMPBI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<MOAMDBGDHOE, MOAMDBGDHOE> IHBFELLKJEO;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<MOAMDBGDHOE, MOAMDBGDHOE, MOAMDBGDHOE> HOEIAOMJKGI;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ICNIAFDKEKI(GameObject CEENMGBCJEJ, HPPMMMFHBEL PKNBLBNKJOD, CNLFCKONHLA ODDBFNIEDLH);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AIICKBIOPNB();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MAJNBNPDEEJ(MOAMDBGDHOE KPDCNGDJNGC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CPOFHABEGHF(MOAMDBGDHOE KPDCNGDJNGC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JCAFNKJJDDM(MOAMDBGDHOE KPDCNGDJNGC, HashSet<MOAMDBGDHOE> LNDAPAJGDEJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EIFGHPFFGMJ(MOAMDBGDHOE KPDCNGDJNGC, MOAMDBGDHOE EFHEFHNONAF, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ECEFEAGFHIB(MOAMDBGDHOE KPDCNGDJNGC, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OCPFDKKHAGJ(MOAMDBGDHOE KPDCNGDJNGC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JBNEINGIMJO IFGNPBHMMJG(bool NEANEFAHLDE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JBNEINGIMJO PDLPMCNONIJ(HashSet<Guid> BIOKEGBLEJO, bool NEANEFAHLDE);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BAEDIEHCIIE(CCELPEKIHEB BFDHJGKAFLJ);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FMPHFHDEPDJ(JBNEINGIMJO IEEBPAIPHOB);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PEKBPOFMMBL(JBNEINGIMJO IEEBPAIPHOB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OPNCEHJMFDN(JBNEINGIMJO IEEBPAIPHOB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ALLJLHEOFMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MOAMDBGDHOE HEAOHNDGKBA(int ELLEHGDJHCE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MOAMDBGDHOE MOHJAKBCHBJ(Guid KLDGLLENIOP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GOLKAGGMAMP(MOAMDBGDHOE KPDCNGDJNGC);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GJBALBNGHCH();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBOBIBKMLPA(MOAMDBGDHOE OIMCPJPGPMM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface GCEGLDJFKFL
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEGMNJHGAAK(DOMAFHOFEED OIMCPJPGPMM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LOKMNAFEOKK(DOMAFHOFEED OIMCPJPGPMM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string DOPPIIMCJCF(DOMAFHOFEED OIMCPJPGPMM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PFPBPKKBLPE(DOMAFHOFEED OIMCPJPGPMM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BOMJCDCIPAC(DOMAFHOFEED OIMCPJPGPMM);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FOCBOMMOFAP(DOMAFHOFEED OIMCPJPGPMM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void JEHPOBEJHFC(MOAMDBGDHOE GDBIGEGDAMG, int CMNLMKCJAAL, MOAMDBGDHOE OHCCHOPPCDN, int BPBAKPHEBEJ, [Optional] Vector3? AHFMAPLJEED, [Optional] Quaternion? MCFJIBPNDCC);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void ELBGHCNOEDB(MOAMDBGDHOE GCLDJADELKP, MOAMDBGDHOE EHKCNEFJOCO);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DOMAFHOFEED : MOAMDBGDHOE, OFEFAIOAIHI, IEquatable<MOAMDBGDHOE>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LJAICAMCIOM : OFEFAIOAIHI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MOAMDBGDHOE CEMOKMKFBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<MOAMDBGDHOE> JDAJLKKNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 FPJPAOFOLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion GEJAIAJGGFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JFFNBINBPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool GLIAELDKOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event JEHPOBEJHFC BCNDEOFLNBA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event JEHPOBEJHFC CFLKJPABLMA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event JEHPOBEJHFC ACJDHADOODG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event ELBGHCNOEDB KHJJGPFCPKF;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NNIEBIADIDG();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GMHPCBOPLJD();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ODDDHPOJDLC();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DIGBOGHHPEH();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GGFINDEICHD();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AOJGGMPOPJF();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PJKMLKBHPAE(int ACGPIJNDEDI, MOAMDBGDHOE OHCCHOPPCDN, int LEPNDIGDGKN);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MKLNNEOMFJL();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OHGLBHDCDKG(int ACGPIJNDEDI, MOAMDBGDHOE GDBIGEGDAMG, int ENIGHPKELGL, [Optional] Vector3? AHFMAPLJEED, [Optional] Quaternion? MCFJIBPNDCC);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CFHGBMGPEDP(MOAMDBGDHOE GDBIGEGDAMG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HIBJACEEJIP();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CAMOKCBAJLA(int FILGHJLFKAL, Vector3 FBHMIIMHGKJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DFFLLCEDNAG(Vector3 INLKDFBHNDD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PIFIGJFIMED
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 OEOMKHCONDA
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
public interface HPPMMMFHBEL
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool POCOFMNLFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PCHBMACPAAN EPEGJGAMCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, HPPMMMFHBEL
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
			[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public PCHBMACPAAN LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8215690", Offset = "0x8214090", VA = "0x188215690")]
		public static ConnectableConfigData MACKBLNPAMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8215750", Offset = "0x8214150", VA = "0x188215750")]
		public ConnectableConfigData(LegacyConnectableLinkVisual PFCKOCFBBDE, bool GFLBFHLCNIC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct ECEBMMADODF : IEquatable<ECEBMMADODF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public MOAMDBGDHOE KPDCNGDJNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int DOBBKHLICOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int KDBOBOFKOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 AHFMAPLJEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion MCFJIBPNDCC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8215D40", Offset = "0x8214740", VA = "0x188215D40")]
	public ECEBMMADODF(MOAMDBGDHOE KPDCNGDJNGC, int DOBBKHLICOG, int KDBOBOFKOJN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8215C10", Offset = "0x8214610", VA = "0x188215C10")]
	public ECEBMMADODF(MOAMDBGDHOE KPDCNGDJNGC, int DOBBKHLICOG, int KDBOBOFKOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8215CB0", Offset = "0x82146B0", VA = "0x188215CB0")]
	public ECEBMMADODF(MOAMDBGDHOE KPDCNGDJNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x82157A0", Offset = "0x82141A0", VA = "0x1882157A0", Slot = "4")]
	public bool Equals(ECEBMMADODF EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8215850", Offset = "0x8214250", VA = "0x188215850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class ONGFHBDBPCM : JJAHOMBBOKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform EOBBLENOIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private PCHBMACPAAN LPOJDHLGLMK;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0060", Offset = "0x7BAEA60", VA = "0x187BB0060", Slot = "4")]
	public void ICNIAFDKEKI(Transform EOBBLENOIHL, PCHBMACPAAN LPOJDHLGLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8226BF0", Offset = "0x82255F0", VA = "0x188226BF0", Slot = "5")]
	public PCHBMACPAAN HCKLGLPGFDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8226B80", Offset = "0x8225580", VA = "0x188226B80", Slot = "6")]
	public void BHJNEGOKHGN(PCHBMACPAAN IOABECJBJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public ONGFHBDBPCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class GCPFBJOAHDJ : IDisposable, JNOKBEBNGCK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MDKNBEAFILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public MOAMDBGDHOE oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public MOAMDBGDHOE newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MDKNBEAFILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8225600", Offset = "0x8224000", VA = "0x188225600")]
		internal bool CBKCGKOODDG(NDAOHKFAPMM node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly BJAPFHDNLFL DCCGHBMCPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DPPHKPFJOEE HEPIGOCMEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private NIIBADDOCGO LLMHINCMLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool GFLBFHLCNIC;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly MEBJEIOEDLD BGNKCEDNECK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public NDAOHKFAPMM BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8216800", Offset = "0x8215200", VA = "0x188216800")]
	public bool AIDDHLOEAEJ([In] LHCACBHIANF GPCDCFCPGFK, bool DOFJCDJILLN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8216EA0", Offset = "0x82158A0", VA = "0x188216EA0")]
	private bool CFALIPKDJKO([In] LHCACBHIANF GPCDCFCPGFK, bool DOFJCDJILLN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8219350", Offset = "0x8217D50", VA = "0x188219350")]
	public GCPFBJOAHDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8218580", Offset = "0x8216F80", VA = "0x188218580", Slot = "5")]
	public void ICNIAFDKEKI(JOADNKCGLME NKHELPOPPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8218F20", Offset = "0x8217920", VA = "0x188218F20", Slot = "17")]
	public void NHAGHFGGOCM(ODPOEMLGMOG EMBEDGKMMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8219270", Offset = "0x8217C70", VA = "0x188219270", Slot = "12")]
	public void PMKPKLBNKGK(Func<MOAMDBGDHOE, bool> NENDLGNEFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8219140", Offset = "0x8217B40", VA = "0x188219140")]
	private void PMKPKLBNKGK(BJAPFHDNLFL AAPGFEFGBOK, Func<MOAMDBGDHOE, bool> NENDLGNEFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8216E80", Offset = "0x8215880", VA = "0x188216E80", Slot = "11")]
	public void CEJMBCJDIHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8218E70", Offset = "0x8217870", VA = "0x188218E70", Slot = "8")]
	public bool MHJPOJHKNMA(MOAMDBGDHOE KALFJKNKPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x82160F0", Offset = "0x8214AF0", VA = "0x1882160F0")]
	private bool AEPHBFCFDCB(MOAMDBGDHOE DOCJJENGJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8218BF0", Offset = "0x82175F0", VA = "0x188218BF0")]
	private static bool LLILIGOHAOP(MOAMDBGDHOE DOCJJENGJNG, BJAPFHDNLFL OAIOLJICNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8217F50", Offset = "0x8216950", VA = "0x188217F50")]
	private void HOOGDKNOGCK(Transform KIDEAOANEMP, BJAPFHDNLFL BBKLGLEHDDI, BJAPFHDNLFL[] DPFFMFNBPDA, MOAMDBGDHOE DFOMENGLNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x82178A0", Offset = "0x82162A0", VA = "0x1882178A0")]
	private ECEBMMADODF DEPDHLKGJAN(Transform NJACHBEBDKN, ECEBMMADODF AHJHOBABPOO)
	{
		return default(ECEBMMADODF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8217470", Offset = "0x8215E70", VA = "0x188217470")]
	private static bool CHDOIOFDDPD(BJAPFHDNLFL OAIOLJICNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8218E10", Offset = "0x8217810", VA = "0x188218E10", Slot = "9")]
	public bool MBELAEKONCM(MOAMDBGDHOE DNDFLOHOONF, int ENIGHPKELGL, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8218330", Offset = "0x8216D30", VA = "0x188218330")]
	private bool ICJJABHFNJJ(MOAMDBGDHOE DNDFLOHOONF, int ENIGHPKELGL, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8215F70", Offset = "0x8214970", VA = "0x188215F70")]
	private static void ADDFFPIHIAI(MOAMDBGDHOE DNDFLOHOONF, int ENIGHPKELGL, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC, BJAPFHDNLFL ODBKKDBMACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8217C70", Offset = "0x8216670", VA = "0x188217C70")]
	private void FBGNHPIBFDG(MOAMDBGDHOE KCKNOBEOEIL, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x82186A0", Offset = "0x82170A0", VA = "0x1882186A0")]
	private void INBKBGBOFKO(BJAPFHDNLFL AAPGFEFGBOK, MOAMDBGDHOE FJICMPILNEH, MOAMDBGDHOE PLGDJOLKAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8218630", Offset = "0x8217030", VA = "0x188218630")]
	private void INBKBGBOFKO(MOAMDBGDHOE KPDCNGDJNGC, MOAMDBGDHOE FJICMPILNEH, MOAMDBGDHOE PLGDJOLKAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8218DA0", Offset = "0x82177A0", VA = "0x188218DA0")]
	private void LPNOBDPHDOG(MOAMDBGDHOE KPDCNGDJNGC, MOAMDBGDHOE FJICMPILNEH, MOAMDBGDHOE PLGDJOLKAAK, bool MBBEBOHGDCN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8218CA0", Offset = "0x82176A0", VA = "0x188218CA0")]
	private void LPNOBDPHDOG(BJAPFHDNLFL PJFDNMGHMBL, MOAMDBGDHOE DFOMENGLNJL, MOAMDBGDHOE EHKCNEFJOCO, bool MBBEBOHGDCN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8219020", Offset = "0x8217A20", VA = "0x188219020")]
	private void OPBLNFMCMJL(MOAMDBGDHOE KOAIHIGOIMD, int ENIGHPKELGL, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8217D90", Offset = "0x8216790", VA = "0x188217D90")]
	private void GGLEFMOFGJK(NDAOHKFAPMM DFKFFPKHNCH, NDAOHKFAPMM BLLADCNCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8217740", Offset = "0x8216140", VA = "0x188217740", Slot = "18")]
	public MOAMDBGDHOE CNHHCBJACHP(MOAMDBGDHOE KPDCNGDJNGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8218710", Offset = "0x8217110", VA = "0x188218710", Slot = "13")]
	public void JCAFNKJJDDM(MOAMDBGDHOE KPDCNGDJNGC, HashSet<MOAMDBGDHOE> GILLGKFJEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8217A30", Offset = "0x8216430", VA = "0x188217A30", Slot = "14")]
	public List<MOAMDBGDHOE> DJMEAACBHOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8216DB0", Offset = "0x82157B0", VA = "0x188216DB0")]
	protected NDAOHKFAPMM APHPOGICFMK(NDAOHKFAPMM AAPGFEFGBOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8218E80", Offset = "0x8217880", VA = "0x188218E80")]
	protected BJAPFHDNLFL[] NGKJFFACMPN(BJAPFHDNLFL OAIOLJICNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8217630", Offset = "0x8216030", VA = "0x188217630")]
	protected bool CHGCPOFFJKD(MOAMDBGDHOE KPDCNGDJNGC, [Out] BJAPFHDNLFL AAPGFEFGBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8218AC0", Offset = "0x82174C0", VA = "0x188218AC0", Slot = "15")]
	public bool KOEMHHPDPNB(MOAMDBGDHOE KPDCNGDJNGC, [Out] ECEBMMADODF DGJNLNHGIGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x82179F0", Offset = "0x82163F0", VA = "0x1882179F0")]
	protected BJAPFHDNLFL DHHPCNEMMBH(ECEBMMADODF IPNJFGFJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8217EF0", Offset = "0x82168F0", VA = "0x188217EF0", Slot = "10")]
	public bool HOBIEPBBGKK(MOAMDBGDHOE KCKNOBEOEIL, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8216810", Offset = "0x8215210", VA = "0x188216810")]
	private bool AONGNGOBEJN(MOAMDBGDHOE KCKNOBEOEIL, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8218F50", Offset = "0x8217950", VA = "0x188218F50")]
	private static bool OJJHEJLAPHB(BJAPFHDNLFL BIOCJNJNLDL, ECEBMMADODF GFNNCCCPHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8216800", Offset = "0x8215200", VA = "0x188216800", Slot = "7")]
	private bool BDDPJAKHKBD([In] LHCACBHIANF GPCDCFCPGFK, bool DOFJCDJILLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class KNBJKEKBIFH : JOADNKCGLME, NAGAKFIOPNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly CFAMNNNCHJA JBOIKIICKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly NIIBADDOCGO LLMHINCMLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly NKHKPFJINFC LMEIDNHEGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly ABGJLDOPFHE ONAJACONLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly JNOKBEBNGCK IEEBPAIPHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal MAKJGOBDCDD JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal LPFNEPJMBDM HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal DPPHKPFJOEE KPLFPDHMBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool GFLBFHLCNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool BOCGFAGJBLP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DLEMFOKNAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAD83D0", Offset = "0xAD6DD0", VA = "0x180AD83D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAD83E0", Offset = "0xAD6DE0", VA = "0x180AD83E0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HCIBKCBAOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xAF4170", Offset = "0xAF2B70", VA = "0x180AF4170", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xAF4150", Offset = "0xAF2B50", VA = "0x180AF4150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool EEAIJNBGOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MOAMDBGDHOE, MOAMDBGDHOE> MOOGANIMPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8223E00", Offset = "0x8222800", VA = "0x188223E00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8222C00", Offset = "0x8221600", VA = "0x188222C00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MOAMDBGDHOE, MOAMDBGDHOE> IHBFELLKJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8223DA0", Offset = "0x82227A0", VA = "0x188223DA0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8223D20", Offset = "0x8222720", VA = "0x188223D20", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MOAMDBGDHOE, MOAMDBGDHOE, MOAMDBGDHOE> HOEIAOMJKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8223010", Offset = "0x8221A10", VA = "0x188223010", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8223CC0", Offset = "0x82226C0", VA = "0x188223CC0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8224720", Offset = "0x8223120", VA = "0x188224720")]
	public KNBJKEKBIFH(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8223430", Offset = "0x8221E30", VA = "0x188223430", Slot = "12")]
	public void ICNIAFDKEKI(GameObject CEENMGBCJEJ, HPPMMMFHBEL PKNBLBNKJOD, CNLFCKONHLA ODDBFNIEDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x82240B0", Offset = "0x8222AB0", VA = "0x1882240B0", Slot = "26")]
	public void NOAMAPCJEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8222A20", Offset = "0x8221420", VA = "0x188222A20", Slot = "13")]
	public void AIICKBIOPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8223D80", Offset = "0x8222780", VA = "0x188223D80", Slot = "14")]
	public void MAJNBNPDEEJ(MOAMDBGDHOE KPDCNGDJNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x8222C60", Offset = "0x8221660", VA = "0x188222C60", Slot = "15")]
	public void CPOFHABEGHF(MOAMDBGDHOE KPDCNGDJNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8222BB0", Offset = "0x82215B0", VA = "0x188222BB0", Slot = "22")]
	public bool BAEDIEHCIIE(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x8222AA0", Offset = "0x82214A0", VA = "0x188222AA0")]
	internal bool AONGNGOBEJN([In] LHCACBHIANF GPCDCFCPGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x82232E0", Offset = "0x8221CE0", VA = "0x1882232E0")]
	internal bool GPPDKHAPFGN([In] LHCACBHIANF GPCDCFCPGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x8223100", Offset = "0x8221B00", VA = "0x188223100")]
	internal void GEDJPPIHBKP(MOAMDBGDHOE KPDCNGDJNGC, int MFILPCKNKCC, bool DOFJCDJILLN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8222C60", Offset = "0x8221660", VA = "0x188222C60")]
	internal bool EMPIHGOLKGH(MOAMDBGDHOE MAOHNDMONHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8224350", Offset = "0x8222D50", VA = "0x188224350")]
	internal bool OKMIHGIIECJ(MOAMDBGDHOE DNDFLOHOONF, int ENIGHPKELGL, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8223BC0", Offset = "0x82225C0", VA = "0x188223BC0", Slot = "16")]
	public void JCAFNKJJDDM(MOAMDBGDHOE KPDCNGDJNGC, HashSet<MOAMDBGDHOE> LNDAPAJGDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8222E00", Offset = "0x8221800", VA = "0x188222E00", Slot = "17")]
	public void EIFGHPFFGMJ(MOAMDBGDHOE DNDFLOHOONF, MOAMDBGDHOE EFHEFHNONAF, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8222CC0", Offset = "0x82216C0", VA = "0x188222CC0", Slot = "18")]
	public void ECEFEAGFHIB(MOAMDBGDHOE KCKNOBEOEIL, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8224180", Offset = "0x8222B80", VA = "0x188224180", Slot = "19")]
	public void OCPFDKKHAGJ(MOAMDBGDHOE KCKNOBEOEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8223E60", Offset = "0x8222860", VA = "0x188223E60")]
	public void NEONNFDGEGE([Optional] POIAKMBAMML PHKMOEJJGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8223070", Offset = "0x8221A70", VA = "0x188223070", Slot = "23")]
	public void FMPHFHDEPDJ(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8223A40", Offset = "0x8222440", VA = "0x188223A40", Slot = "20")]
	public JBNEINGIMJO IFGNPBHMMJG(bool NEANEFAHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x82244C0", Offset = "0x8222EC0", VA = "0x1882244C0", Slot = "21")]
	public JBNEINGIMJO PDLPMCNONIJ(HashSet<Guid> BIOKEGBLEJO, bool NEANEFAHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8224480", Offset = "0x8222E80", VA = "0x188224480", Slot = "25")]
	public void OPNCEHJMFDN(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8224670", Offset = "0x8223070", VA = "0x188224670", Slot = "24")]
	public void PEKBPOFMMBL(JBNEINGIMJO IEEBPAIPHOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class NIIBADDOCGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly NCMMNGPOLDF<MOAMDBGDHOE, MOAMDBGDHOE> MOOGANIMPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly NCMMNGPOLDF<MOAMDBGDHOE, MOAMDBGDHOE> IHBFELLKJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly BNGHPJPHPGN<MOAMDBGDHOE, MOAMDBGDHOE, MOAMDBGDHOE> HOEIAOMJKGI;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x82265D0", Offset = "0x8224FD0", VA = "0x1882265D0")]
	public NIIBADDOCGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	public void ICNIAFDKEKI(KNBJKEKBIFH NKHELPOPPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8226510", Offset = "0x8224F10", VA = "0x188226510")]
	public void KGKMKFMODIL(MOAMDBGDHOE DFKFFPKHNCH, MOAMDBGDHOE KOAIHIGOIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8226570", Offset = "0x8224F70", VA = "0x188226570")]
	public void PNHPJBELEAD(MOAMDBGDHOE DFKFFPKHNCH, MOAMDBGDHOE KOAIHIGOIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8226490", Offset = "0x8224E90", VA = "0x188226490")]
	public void IJFEPFGJCJB(MOAMDBGDHOE LKOPHANLFAH, MOAMDBGDHOE OGINNIAMBHJ, MOAMDBGDHOE KOAIHIGOIMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class NKHKPFJINFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private KNBJKEKBIFH NKHELPOPPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private LPFNEPJMBDM HFINBJNJOEI;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NKHKPFJINFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8226740", Offset = "0x8225140", VA = "0x188226740")]
	public void ICNIAFDKEKI(KNBJKEKBIFH NKHELPOPPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8226730", Offset = "0x8225130", VA = "0x188226730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x82266F0", Offset = "0x82250F0", VA = "0x1882266F0")]
	private void BNKEHHGDODB(IOMKCHPPNFJ PCJBPIKLFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8226AA0", Offset = "0x82254A0", VA = "0x188226AA0")]
	private void PLJMNGGJIOE(POIAKMBAMML GHEODBLCLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8226990", Offset = "0x8225390", VA = "0x188226990")]
	public void KBKJDPHGBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8226880", Offset = "0x8225280", VA = "0x188226880")]
	public void KBGGPGDOLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class ILIHMDEENCF
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OJMDBINEGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public CFAMNNNCHJA container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OJMDBINEGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8226B10", Offset = "0x8225510", VA = "0x188226B10")]
		internal KNBJKEKBIFH IEHFBCENPPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x821F910", Offset = "0x821E310", VA = "0x18821F910")]
	public static void CNMHKOOJKDO(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x821FB10", Offset = "0x821E510", VA = "0x18821FB10")]
	public static void LHAKPFAOCKK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class NEDLOJNBFIF : IDisposable, DPPHKPFJOEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, PCHBMACPAAN> PBMNNIOBMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly ODPOEMLGMOG GBKMGCGKHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private JJAHOMBBOKP CBCHDGOOHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private JNOKBEBNGCK IEEBPAIPHOB;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker NOKJJPEDMMJ;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x82263B0", Offset = "0x8224DB0", VA = "0x1882263B0")]
	public NEDLOJNBFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8225BA0", Offset = "0x82245A0", VA = "0x188225BA0", Slot = "7")]
	public void ICNIAFDKEKI(JNOKBEBNGCK IEEBPAIPHOB, JJAHOMBBOKP CBCHDGOOHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8225BE0", Offset = "0x82245E0", VA = "0x188225BE0", Slot = "5")]
	public void JNIGPCGOFPF(NDAOHKFAPMM DCMMMFCHPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8225A30", Offset = "0x8224430", VA = "0x188225A30", Slot = "9")]
	public void HMINNODGOJH(NDAOHKFAPMM JGFNNAGGDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8225870", Offset = "0x8224270", VA = "0x188225870", Slot = "8")]
	public void EOMLHPDHJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8226000", Offset = "0x8224A00", VA = "0x188226000", Slot = "10")]
	public void MNKLDMKFPFK(NDAOHKFAPMM BLDADJIJLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8225E80", Offset = "0x8224880", VA = "0x188225E80", Slot = "11")]
	public void LJBNKJHGIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x82256C0", Offset = "0x82240C0", VA = "0x1882256C0")]
	private bool CJKHALHBBBN(NDAOHKFAPMM AMLMOHAGJJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class ABGJLDOPFHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct IOKFKLKPFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly BJAPFHDNLFL MFJAKPDBMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> BIOKEGBLEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly CCELPEKIHEB JCELEBHFLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly CCELPEKIHEB LKKDJIMCHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool NEANEFAHLDE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool LLNFHEJHNJO
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x821FFB0", Offset = "0x821E9B0", VA = "0x18821FFB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8220460", Offset = "0x821EE60", VA = "0x188220460")]
		public IOKFKLKPFFJ(BJAPFHDNLFL MFJAKPDBMGC, HashSet<Guid> BIOKEGBLEJO, bool NEANEFAHLDE, [Optional] CCELPEKIHEB JCELEBHFLPN, [Optional] CCELPEKIHEB LKKDJIMCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x821FB90", Offset = "0x821E590", VA = "0x18821FB90")]
		public CCELPEKIHEB AGNKEKDJGCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x821FD30", Offset = "0x821E730", VA = "0x18821FD30")]
		private CCELPEKIHEB APDFGPLNLJG([Out] CCELPEKIHEB OFIOJFHKMAN, [Out] CCELPEKIHEB NBAMGAHABLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8220240", Offset = "0x821EC40", VA = "0x188220240")]
		private CCELPEKIHEB LFKNPELNAGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x82200D0", Offset = "0x821EAD0", VA = "0x1882200D0")]
		private void KCPEIKCODKA(CCELPEKIHEB JPFIACLNJOG, CCELPEKIHEB PGNMHGCNKGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x821FDF0", Offset = "0x821E7F0", VA = "0x18821FDF0")]
		private void GPHBNKAOFBM(CCELPEKIHEB OFIOJFHKMAN, CCELPEKIHEB NBAMGAHABLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private KNBJKEKBIFH NKHELPOPPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private JNOKBEBNGCK IEEBPAIPHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private DPPHKPFJOEE HEPIGOCMEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private LPFNEPJMBDM HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool NBMLOLPKPCH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool BKPLBENEFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8212C60", Offset = "0x8211660", VA = "0x188212C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool DLEMFOKNAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x82127F0", Offset = "0x82111F0", VA = "0x1882127F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8213F60", Offset = "0x8212960", VA = "0x188213F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8214110", Offset = "0x8212B10", VA = "0x188214110")]
	public void ICNIAFDKEKI(KNBJKEKBIFH NKHELPOPPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8214180", Offset = "0x8212B80", VA = "0x188214180")]
	public JBNEINGIMJO IFGNPBHMMJG(bool NEANEFAHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x82146B0", Offset = "0x82130B0", VA = "0x1882146B0")]
	public JBNEINGIMJO PDLPMCNONIJ(HashSet<Guid> BIOKEGBLEJO, bool NEANEFAHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8213280", Offset = "0x8211C80", VA = "0x188213280")]
	public void FMPHFHDEPDJ(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8214850", Offset = "0x8213250", VA = "0x188214850")]
	public void PEKBPOFMMBL(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8213250", Offset = "0x8211C50", VA = "0x188213250")]
	public void FKCIPDBBALC(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x82144C0", Offset = "0x8212EC0", VA = "0x1882144C0")]
	private void MILPELKMOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8212810", Offset = "0x8211210", VA = "0x188212810")]
	private CCELPEKIHEB BJEDLNMNONH(BJAPFHDNLFL AAPGFEFGBOK, bool NEANEFAHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8212CB0", Offset = "0x82116B0", VA = "0x188212CB0")]
	private static void EKNOFENINHH(BJAPFHDNLFL AAPGFEFGBOK, bool NEANEFAHLDE, CCELPEKIHEB BFDHJGKAFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8212A40", Offset = "0x8211440", VA = "0x188212A40")]
	private void DAEMLCGILFP(BJAPFHDNLFL AAPGFEFGBOK, bool NEANEFAHLDE, CCELPEKIHEB BFDHJGKAFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8213AC0", Offset = "0x82124C0", VA = "0x188213AC0")]
	private CCELPEKIHEB GKBKJJMNDNI(BJAPFHDNLFL MFJAKPDBMGC, HashSet<Guid> BIOKEGBLEJO, bool NEANEFAHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8213B50", Offset = "0x8212550", VA = "0x188213B50")]
	private bool GPMEAGOKMAL(JBNEINGIMJO CMMGJNLDMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8213450", Offset = "0x8211E50", VA = "0x188213450")]
	private bool GJENPJLPBKH(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8213310", Offset = "0x8211D10", VA = "0x188213310")]
	private bool FPHAIKPFKIE(JBNEINGIMJO IEEBPAIPHOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8213330", Offset = "0x8211D30", VA = "0x188213330")]
	private static bool GBFCPCDBNGO(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8212470", Offset = "0x8210E70", VA = "0x188212470")]
	public static bool BAEDIEHCIIE(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8212F00", Offset = "0x8211900", VA = "0x188212F00")]
	private MOAMDBGDHOE FEPOIDHCBGI(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8213DE0", Offset = "0x82127E0", VA = "0x188213DE0")]
	private MOAMDBGDHOE HEAOHNDGKBA(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x82142F0", Offset = "0x8212CF0", VA = "0x1882142F0")]
	private MOAMDBGDHOE IMEHOBKBDMO(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8214480", Offset = "0x8212E80", VA = "0x188214480")]
	private static Guid LGPKMKBFDCJ(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8212700", Offset = "0x8211100", VA = "0x188212700")]
	private string BHLBLKKGIMM(CCELPEKIHEB BFDHJGKAFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8213F80", Offset = "0x8212980", VA = "0x188213F80")]
	private bool HPNEINHKOJE(BJAPFHDNLFL AAPGFEFGBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8212210", Offset = "0x8210C10", VA = "0x188212210")]
	private static void ANAOIDEEFAG(BJAPFHDNLFL MFJAKPDBMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public ABGJLDOPFHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct LHCACBHIANF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public MOAMDBGDHOE KOAIHIGOIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public MOAMDBGDHOE DFKFFPKHNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int ENIGHPKELGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int LEPNDIGDGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 AHFMAPLJEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion MCFJIBPNDCC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ECEBMMADODF NELHFOOCDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8224B10", Offset = "0x8223510", VA = "0x188224B10")]
		get
		{
			return default(ECEBMMADODF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public ECEBMMADODF MCHJEPAKLGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8224BB0", Offset = "0x82235B0", VA = "0x188224BB0")]
		get
		{
			return default(ECEBMMADODF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8224BE0", Offset = "0x82235E0", VA = "0x188224BE0")]
	public LHCACBHIANF(MOAMDBGDHOE KOAIHIGOIMD, MOAMDBGDHOE DFKFFPKHNCH, int ENIGHPKELGL, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface JNOKBEBNGCK
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NDAOHKFAPMM BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICNIAFDKEKI(JOADNKCGLME NKHELPOPPEM);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AIDDHLOEAEJ([In] LHCACBHIANF GPCDCFCPGFK, bool DOFJCDJILLN = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHJPOJHKNMA(MOAMDBGDHOE KALFJKNKPFL);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MBELAEKONCM(MOAMDBGDHOE DNDFLOHOONF, int ENIGHPKELGL, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HOBIEPBBGKK(MOAMDBGDHOE KCKNOBEOEIL, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CEJMBCJDIHH();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PMKPKLBNKGK(Func<MOAMDBGDHOE, bool> NENDLGNEFMI);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JCAFNKJJDDM(MOAMDBGDHOE KPDCNGDJNGC, HashSet<MOAMDBGDHOE> GILLGKFJEGC);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<MOAMDBGDHOE> DJMEAACBHOL();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KOEMHHPDPNB(MOAMDBGDHOE KPDCNGDJNGC, [Out] ECEBMMADODF DGJNLNHGIGC);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NHAGHFGGOCM(ODPOEMLGMOG EMBEDGKMMHB);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool ODPOEMLGMOG(NDAOHKFAPMM AAPGFEFGBOK);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface NDAOHKFAPMM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MOAMDBGDHOE KAPMGIELMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	NDAOHKFAPMM KJNLPEJOCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ECEBMMADODF JMOJBPDMMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool GINAKBDPGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PCHBMACPAAN
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEKLAJMLNPO(MOAMDBGDHOE OHCCHOPPCDN, ECEBMMADODF KOAIHIGOIMD);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAMDFOJAIBO(MOAMDBGDHOE OHCCHOPPCDN, ECEBMMADODF KOAIHIGOIMD);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENAOIGBKGEF(MOAMDBGDHOE OHCCHOPPCDN, ECEBMMADODF KOAIHIGOIMD);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNHLEGNHEIL(MOAMDBGDHOE OHCCHOPPCDN, ECEBMMADODF KOAIHIGOIMD);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PCHBMACPAAN Instantiate(Transform EOBBLENOIHL);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NHMIPJFACPH();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JJAHOMBBOKP
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICNIAFDKEKI(Transform EOBBLENOIHL, PCHBMACPAAN LPOJDHLGLMK);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PCHBMACPAAN HCKLGLPGFDK();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHJNEGOKHGN(PCHBMACPAAN IOABECJBJLI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface MAKJGOBDCDD : ALLJLHEOFMH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLGPOCDJLEI();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FKFFGCCGFEN(Guid FPCKBBHLCAF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DPPHKPFJOEE
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNIGPCGOFPF(NDAOHKFAPMM DCMMMFCHPNK);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICNIAFDKEKI(JNOKBEBNGCK IEEBPAIPHOB, JJAHOMBBOKP ALNFDLNNHLB);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOMLHPDHJPK();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HMINNODGOJH(NDAOHKFAPMM JGFNNAGGDAF);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MNKLDMKFPFK(NDAOHKFAPMM BLDADJIJLLI);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LJBNKJHGIAG();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class BJAPFHDNLFL : NDAOHKFAPMM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JDEHCCELODJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public ECEBMMADODF nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public BJAPFHDNLFL foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JDEHCCELODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x82204D0", Offset = "0x821EED0", VA = "0x1882204D0")]
		internal bool COENBPJMICM(NDAOHKFAPMM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private ECEBMMADODF DGJNLNHGIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<BJAPFHDNLFL> PGBFILJDFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private BJAPFHDNLFL KCHGKHNFBCI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ECEBMMADODF JMOJBPDMMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x14E4D20", Offset = "0x14E3720", VA = "0x1814E4D20", Slot = "6")]
		get
		{
			return default(ECEBMMADODF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x14E4850", Offset = "0x14E3250", VA = "0x1814E4850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private BJAPFHDNLFL DFKFFPKHNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8215140", Offset = "0x8213B40", VA = "0x188215140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NDAOHKFAPMM KJNLPEJOCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MOAMDBGDHOE KAPMGIELMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool GINAKBDPGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8214E90", Offset = "0x8213890", VA = "0x188214E90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool JIFIGGBCHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x82150F0", Offset = "0x8213AF0", VA = "0x1882150F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected BJAPFHDNLFL PJFDNMGHMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x82155C0", Offset = "0x8213FC0", VA = "0x1882155C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x82155E0", Offset = "0x8213FE0", VA = "0x1882155E0")]
	public BJAPFHDNLFL(ECEBMMADODF JPCIOCEOGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x8214FA0", Offset = "0x82139A0", VA = "0x188214FA0")]
	public BJAPFHDNLFL GGEKGIEHAKM(ECEBMMADODF JAFBKLGGJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8215220", Offset = "0x8213C20", VA = "0x188215220")]
	public BJAPFHDNLFL JNCOLEEFCNF(ECEBMMADODF GGBIMGCBMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8214B60", Offset = "0x8213560", VA = "0x188214B60")]
	public BJAPFHDNLFL BBOPECIHIDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8214D40", Offset = "0x8213740", VA = "0x188214D40")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x82153A0", Offset = "0x8213DA0", VA = "0x1882153A0")]
	public BJAPFHDNLFL KPDFEIDEPEF(ECEBMMADODF OGINNIAMBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8215450", Offset = "0x8213E50", VA = "0x188215450")]
	private static void NHAGHFGGOCM(BJAPFHDNLFL GOLLFHOOJNB, ODPOEMLGMOG EANMJMPIOGJ, bool CBHMBAHMPFC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x82155B0", Offset = "0x8213FB0", VA = "0x1882155B0", Slot = "9")]
	public void NHAGHFGGOCM(ODPOEMLGMOG EMBEDGKMMHB, bool MBBEBOHGDCN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8214EA0", Offset = "0x82138A0", VA = "0x188214EA0")]
	public static BJAPFHDNLFL DHHPCNEMMBH(BJAPFHDNLFL GOLLFHOOJNB, ECEBMMADODF OCBDCGHJJNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface LPFNEPJMBDM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool BKPLBENEFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<IOMKCHPPNFJ> BNKEHHGDODB;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<POIAKMBAMML> PLJMNGGJIOE;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CEKLAJMLNPO(KNBJKEKBIFH NKHELPOPPEM, CNLFCKONHLA HLNCMFCIMFF);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EIFGHPFFGMJ(MOAMDBGDHOE DNDFLOHOONF, MOAMDBGDHOE EFHEFHNONAF, int ENIGHPKELGL, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ECEFEAGFHIB(MOAMDBGDHOE KCKNOBEOEIL, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MKMNFADGCCE(JBNEINGIMJO MIHKBABOCNA, [Optional] POIAKMBAMML PHKMOEJJGIC);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HAIOAIPNGOC
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x821E5F0", Offset = "0x821CFF0", VA = "0x18821E5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object NDAIDGNOFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x821E5B0", Offset = "0x821CFB0", VA = "0x18821E5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x821E650", Offset = "0x821D050", VA = "0x18821E650")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class IGLBDAMHJGN : LPFNEPJMBDM, IDisposable, LLBCKFDJPMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private KNBJKEKBIFH NKHELPOPPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private CNLFCKONHLA ODDBFNIEDLH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BKPLBENEFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x821EB80", Offset = "0x821D580", VA = "0x18821EB80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x821EF90", Offset = "0x821D990", VA = "0x18821EF90", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView FGAIALOPAOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x821EEF0", Offset = "0x821D8F0", VA = "0x18821EEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<IOMKCHPPNFJ> BNKEHHGDODB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x821EE50", Offset = "0x821D850", VA = "0x18821EE50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x821ED10", Offset = "0x821D710", VA = "0x18821ED10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<POIAKMBAMML> PLJMNGGJIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x821F100", Offset = "0x821DB00", VA = "0x18821F100", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x821EDB0", Offset = "0x821D7B0", VA = "0x18821EDB0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x821E970", Offset = "0x821D370", VA = "0x18821E970", Slot = "10")]
	public void CEKLAJMLNPO(KNBJKEKBIFH NKHELPOPPEM, CNLFCKONHLA ODDBFNIEDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x821EA00", Offset = "0x821D400", VA = "0x18821EA00", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x821EBE0", Offset = "0x821D5E0", VA = "0x18821EBE0", Slot = "11")]
	public void EIFGHPFFGMJ(MOAMDBGDHOE DNDFLOHOONF, MOAMDBGDHOE EFHEFHNONAF, int ENIGHPKELGL, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x821EA50", Offset = "0x821D450", VA = "0x18821EA50", Slot = "12")]
	public void ECEFEAGFHIB(MOAMDBGDHOE KCKNOBEOEIL, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x821EFD0", Offset = "0x821D9D0", VA = "0x18821EFD0", Slot = "13")]
	public void MKMNFADGCCE(JBNEINGIMJO MIHKBABOCNA, [Optional] POIAKMBAMML PHKMOEJJGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x821F3E0", Offset = "0x821DDE0", VA = "0x18821F3E0")]
	[IBFCMPGKLPH]
	private void RpcMasterReparentNodes(MOAMDBGDHOE KCKNOBEOEIL, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x821F1E0", Offset = "0x821DBE0", VA = "0x18821F1E0")]
	[IBFCMPGKLPH]
	private void RpcMasterModifyNode(MOAMDBGDHOE DNDFLOHOONF, MOAMDBGDHOE EFHEFHNONAF, int ENIGHPKELGL, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x821F7E0", Offset = "0x821E1E0", VA = "0x18821F7E0")]
	[IBFCMPGKLPH]
	private void RpcReparentNodes(MOAMDBGDHOE KCKNOBEOEIL, int PMIJPPAAHNB, MOAMDBGDHOE OGINNIAMBHJ, int HIABPODCIFC, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC, IIMDHKOLHCE OHIFACIKMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x821F6F0", Offset = "0x821E0F0", VA = "0x18821F6F0")]
	[IBFCMPGKLPH]
	private void RpcModifyNode(MOAMDBGDHOE DNDFLOHOONF, int ENIGHPKELGL, int LEPNDIGDGKN, Vector3 AHFMAPLJEED, Quaternion MCFJIBPNDCC, IIMDHKOLHCE OHIFACIKMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x821F1A0", Offset = "0x821DBA0", VA = "0x18821F1A0")]
	[IBFCMPGKLPH]
	private void RpcDeserializeConnectableGraph(JBNEINGIMJO IEEBPAIPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IGLBDAMHJGN()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, PCHBMACPAAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8224C50", Offset = "0x8223650", VA = "0x188224C50", Slot = "4")]
		private void EAOJLIMJIFH(MOAMDBGDHOE OHCCHOPPCDN, ECEBMMADODF KOAIHIGOIMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8224F90", Offset = "0x8223990", VA = "0x188224F90", Slot = "5")]
		private void JMOMGNECHOE(MOAMDBGDHOE OHCCHOPPCDN, ECEBMMADODF KOAIHIGOIMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8224DD0", Offset = "0x82237D0", VA = "0x188224DD0", Slot = "6")]
		private void HENFFKFDFAN(MOAMDBGDHOE OHCCHOPPCDN, ECEBMMADODF KOAIHIGOIMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8225270", Offset = "0x8223C70", VA = "0x188225270", Slot = "7")]
		private void PKCNMOJIEEB(MOAMDBGDHOE OHCCHOPPCDN, ECEBMMADODF KOAIHIGOIMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8225200", Offset = "0x8223C00", VA = "0x188225200", Slot = "8")]
		private PCHBMACPAAN KODIFOKIONI(Transform EOBBLENOIHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8224F30", Offset = "0x8223930", VA = "0x188224F30", Slot = "9")]
		private void JKCCOPANCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OMBKCLFHDMH
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3E4CFA0", Offset = "0x3E4B9A0", VA = "0x183E4CFA0")]
	public static KKHLMDEPMND<T> FCNMCOANLLF<T>(this CFAMNNNCHJA JBOIKIICKBA)
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
