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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B80940", Offset = "0x7B7FB40", VA = "0x187B80940", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x216AEA0", Offset = "0x216A0A0", VA = "0x18216AEA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B87630", Offset = "0x7B86830", VA = "0x187B87630")]
		private void AGIDAPFICKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B877A0", Offset = "0x7B869A0", VA = "0x187B877A0")]
		private void EKPABHIKONH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B87910", Offset = "0x7B86B10", VA = "0x187B87910", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B87C50", Offset = "0x7B86E50", VA = "0x187B87C50")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class CBKFECJFFIL : HGAAMOCBEIA, EJADEOIPJPK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class DJHABFAFDIB : IEnumerable<IOFKNAPGAKK>, IEnumerable, IEnumerator<IOFKNAPGAKK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IOFKNAPGAKK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private EBBGNAFIMFG localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public EBBGNAFIMFG <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CBKFECJFFIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MIPBFCPKCOJ <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JCMFEJFBHJF <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JCMFEJFBHJF.DJAANNCJHAK <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private IOFKNAPGAKK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public DJHABFAFDIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B7ACD0", Offset = "0x7B79ED0", VA = "0x187B7ACD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A870", Offset = "0x7B79A70", VA = "0x187B7A870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A830", Offset = "0x7B79A30", VA = "0x187B7A830")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A850", Offset = "0x7B79A50", VA = "0x187B7A850")]
		private void GHEPLDLLGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B7AC80", Offset = "0x7B79E80", VA = "0x187B7AC80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B7ABD0", Offset = "0x7B79DD0", VA = "0x187B7ABD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IOFKNAPGAKK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B7ABD0", Offset = "0x7B79DD0", VA = "0x187B7ABD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MAMAGFKKBCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CBKFECJFFIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public KPPAPHMMKAL nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MAMAGFKKBCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B80AE0", Offset = "0x7B7FCE0", VA = "0x187B80AE0")]
		internal object HBGLDNAOEJL(KPPAPHMMKAL x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LLECIJKGGEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KPPAPHMMKAL child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MAMAGFKKBCD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LLECIJKGGEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7FED0", Offset = "0x7B7F0D0", VA = "0x187B7FED0")]
		internal object IPENJGPENHB((KPPAPHMMKAL child, KPPAPHMMKAL nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly KEPOMIIOHBM PBGAOLMLKLH;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly KEPOMIIOHBM GIIJLNOPFFD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly KEPOMIIOHBM HBPGJPFKHDD;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly KEPOMIIOHBM DECCNDOFJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PGPOBAMFDJM EFPDPMOIODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private JPIALIKNHCC OPMMMGOPKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private MLACKGMOCIO MMKFKPABCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MJBJCBIGLPD PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private NKLJLHFCPEK AKHADIKOCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private NOCNHAAKIII IIEBKBPAACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HHAEJFPLINH BNPCDJLAAMK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OIFFEBPIEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA0FD10", Offset = "0xA0EF10", VA = "0x180A0FD10", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC10", Offset = "0xA0EE10", VA = "0x180A0FC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MKGNOFCLEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<IOFKNAPGAKK, IOFKNAPGAKK> OKKJJDILICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B76230", Offset = "0x7B75430", VA = "0x187B76230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B76EB0", Offset = "0x7B760B0", VA = "0x187B76EB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<IOFKNAPGAKK, IOFKNAPGAKK> AJJLFMDGADC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B762E0", Offset = "0x7B754E0", VA = "0x187B762E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B76790", Offset = "0x7B75990", VA = "0x187B76790", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<IOFKNAPGAKK, IOFKNAPGAKK, IOFKNAPGAKK> IALMBJNDCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B77430", Offset = "0x7B76630", VA = "0x187B77430", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B776F0", Offset = "0x7B768F0", VA = "0x187B776F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7B785C0", Offset = "0x7B777C0", VA = "0x187B785C0")]
	public CBKFECJFFIL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B73B40", Offset = "0x7B72D40", VA = "0x187B73B40", Slot = "12")]
	public void AFLILFPIJAH(GameObject LBBGHAOMHLO, EINMKHKMNFL KFNDNHHBCEI, OJDEBPCEDIL GCPKMNCMKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B78280", Offset = "0x7B77480", VA = "0x187B78280", Slot = "26")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B756D0", Offset = "0x7B748D0", VA = "0x187B756D0", Slot = "22")]
	public bool EAEJIMPPFHB(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B774E0", Offset = "0x7B766E0", VA = "0x187B774E0")]
	private void LBICJBDPEBM(EBBGNAFIMFG BAOHOFCJGMD, EBBGNAFIMFG OEMGNMMGLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B76990", Offset = "0x7B75B90", VA = "0x187B76990")]
	private void HJIMHIBEEAF(EBBGNAFIMFG BAOHOFCJGMD, EBBGNAFIMFG FMIGOBCEINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B74C90", Offset = "0x7B73E90", VA = "0x187B74C90")]
	private void BFNEAKNOPFK(EBBGNAFIMFG BAOHOFCJGMD, EBBGNAFIMFG FMIGOBCEINO, EBBGNAFIMFG OEMGNMMGLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B752C0", Offset = "0x7B744C0", VA = "0x187B752C0")]
	private void DBMOJAJEHEF(EBBGNAFIMFG BAOHOFCJGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "13")]
	public void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B75DB0", Offset = "0x7B74FB0", VA = "0x187B75DB0", Slot = "14")]
	public void ELDCOJNOKAJ(IOFKNAPGAKK BKJAKODNAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "15")]
	public void JNBGJFEBNND(IOFKNAPGAKK BKJAKODNAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B77930", Offset = "0x7B76B30", VA = "0x187B77930", Slot = "17")]
	public void MNIMEBNGDFA(IOFKNAPGAKK BKJAKODNAOC, IOFKNAPGAKK JADHHDJNNPE, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B77A90", Offset = "0x7B76C90", VA = "0x187B77A90")]
	public void MNIMEBNGDFA(EBBGNAFIMFG JPCNHODHEGA, EBBGNAFIMFG JADHHDJNNPE, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B750C0", Offset = "0x7B742C0", VA = "0x187B750C0")]
	public void BPCNOLBOGNI(IOFKNAPGAKK BKJAKODNAOC, float LINGFBEKMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B749F0", Offset = "0x7B73BF0", VA = "0x187B749F0", Slot = "18")]
	public void AKPMBMGGKCJ(IOFKNAPGAKK CBOGKJOGDFG, int HMCGEFPJJDJ, IOFKNAPGAKK PDMJGIAMKBP, int HKIGICOHPKF, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B781D0", Offset = "0x7B773D0", VA = "0x187B781D0")]
	private float OPFMLDNOHIE(EBBGNAFIMFG JPCNHODHEGA, EBBGNAFIMFG FLKKOCNDECC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B74B50", Offset = "0x7B73D50", VA = "0x187B74B50")]
	public void AKPMBMGGKCJ(EBBGNAFIMFG JPCNHODHEGA, EBBGNAFIMFG FLKKOCNDECC, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK, bool AFMEPJDIKLK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B760C0", Offset = "0x7B752C0", VA = "0x187B760C0", Slot = "19")]
	public void ENJGLMCCMPA(IOFKNAPGAKK BKJAKODNAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B76580", Offset = "0x7B75780", VA = "0x187B76580", Slot = "16")]
	public void GGAJCHCDOBC(IOFKNAPGAKK BKJAKODNAOC, HashSet<IOFKNAPGAKK> BNGJLHMADGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "20")]
	public DKAIOKKDNAG LPKOFFLLHLG(bool ICDOHKECDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "21")]
	public DKAIOKKDNAG AMNPNAAPLAG(HashSet<Guid> DIHLAEBJOIL, bool ICDOHKECDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B75150", Offset = "0x7B74350", VA = "0x187B75150", Slot = "23")]
	public void CABCLFKJMOD(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B78160", Offset = "0x7B77360", VA = "0x187B78160", Slot = "24")]
	public void NMDPAIBBCKA(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B76E90", Offset = "0x7B76090", VA = "0x187B76E90", Slot = "25")]
	public void KGINIEPCLDN(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B75720", Offset = "0x7B74920", VA = "0x187B75720")]
	private void ECJCADCPGEN(EBBGNAFIMFG JPCNHODHEGA, EBBGNAFIMFG FLKKOCNDECC, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK, float LINGFBEKMDG, bool AFMEPJDIKLK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B73F60", Offset = "0x7B73160", VA = "0x187B73F60")]
	private void AHKNDAHHHBO(EBBGNAFIMFG JPCNHODHEGA, EBBGNAFIMFG DAFAJHDHOLC, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B751C0", Offset = "0x7B743C0", VA = "0x187B751C0")]
	private void CILOFLLAMGM(EBBGNAFIMFG JPCNHODHEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B75230", Offset = "0x7B74430", VA = "0x187B75230")]
	[IteratorStateMachine(typeof(DJHABFAFDIB))]
	public IEnumerable<IOFKNAPGAKK> CMEKDDCLJNO(EBBGNAFIMFG MNPNHJICMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B76F60", Offset = "0x7B76160", VA = "0x187B76F60")]
	internal IOFKNAPGAKK KMKBBPBHKBE(EBBGNAFIMFG MNPNHJICMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B74860", Offset = "0x7B73A60", VA = "0x187B74860")]
	internal EBBGNAFIMFG AJJEBBHOMBM(IOFKNAPGAKK BKJAKODNAOC)
	{
		return default(EBBGNAFIMFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B77BD0", Offset = "0x7B76DD0", VA = "0x187B77BD0")]
	private bool NKDOEPNIMMK(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B76520", Offset = "0x7B75720", VA = "0x187B76520")]
	private bool GBNOCOFJDKC(KPPAPHMMKAL DDCBOGLJKIC, [Out] IOFKNAPGAKK FLKKOCNDECC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B770A0", Offset = "0x7B762A0", VA = "0x187B770A0")]
	private IOFKNAPGAKK KMKBBPBHKBE(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B73DD0", Offset = "0x7B72FD0", VA = "0x187B73DD0")]
	private IOFKNAPGAKK AGCIKOJJIMK(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B74EF0", Offset = "0x7B740F0", VA = "0x187B74EF0")]
	private IOFKNAPGAKK BGFJAOPILOD(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B76840", Offset = "0x7B75A40", VA = "0x187B76840")]
	private static Guid HBFFNFCOLEI(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B76C10", Offset = "0x7B75E10", VA = "0x187B76C10")]
	private string HNMNDAFPLBF(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B777A0", Offset = "0x7B769A0", VA = "0x187B777A0")]
	private void LKDJJBFHHJK(IOFKNAPGAKK JPCNHODHEGA, IOFKNAPGAKK DAFAJHDHOLC, RigidTransform HCBKMIBOFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B76D00", Offset = "0x7B75F00", VA = "0x187B76D00")]
	private void JHHKFFGPCHE(IOFKNAPGAKK DAFAJHDHOLC, IOFKNAPGAKK JPCNHODHEGA, RigidTransform HCBKMIBOFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B76BB0", Offset = "0x7B75DB0", VA = "0x187B76BB0")]
	private void HLIEOHNFGAO(IOFKNAPGAKK IPGOMKHKGIK, IOFKNAPGAKK JPCNHODHEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7B76390", Offset = "0x7B75590", VA = "0x187B76390")]
	private void FICAGEDDLNC(IOFKNAPGAKK JPCNHODHEGA, IOFKNAPGAKK FLKKOCNDECC, RigidTransform HCBKMIBOFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B76880", Offset = "0x7B75A80", VA = "0x187B76880")]
	private void HGMDANDHBCL(EBBGNAFIMFG MNPNHJICMND, IOFKNAPGAKK BKJAKODNAOC, EBBGNAFIMFG FMIGOBCEINO, EBBGNAFIMFG OEMGNMMGLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B75B30", Offset = "0x7B74D30", VA = "0x187B75B30")]
	private void EKPCIDFAFCC(EBBGNAFIMFG MNPNHJICMND, IOFKNAPGAKK BKJAKODNAOC, IOFKNAPGAKK OGIMAJLLPDJ, IOFKNAPGAKK LCNCFEHAGKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LHCHBJJGAGE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class AOJAGADAMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public FJCFOKJAKFO container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AOJAGADAMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B73A90", Offset = "0x7B72C90", VA = "0x187B73A90")]
		internal CBKFECJFFIL GIOMDJEGKBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FAF0", Offset = "0x7B7ECF0", VA = "0x187B7FAF0")]
	public static void ICEIMLGPLMP(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FAA0", Offset = "0x7B7ECA0", VA = "0x187B7FAA0")]
	public static void ANHGOEKILBF(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class MLMEIMPCOOK : CEJDEGIHIJP, OEPFAAGAOIA
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly CBKFECJFFIL PLOHGBPMMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly OIOJJEMHAHE JHCDKAJHGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly PNGBOFNOMON PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly KCOKNMFAANN[] HEANPHPKIDC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IOFKNAPGAKK FMEOFOLHMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B82B60", Offset = "0x7B81D60", VA = "0x187B82B60", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IOFKNAPGAKK POMJPEGACNK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B81140", Offset = "0x7B80340", VA = "0x187B81140", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 NECCHEFECPG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7B80F70", Offset = "0x7B80170", VA = "0x187B80F70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion NNGHMFGLODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B82570", Offset = "0x7B81770", VA = "0x187B82570", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FAGPKAKEBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7B82620", Offset = "0x7B81820", VA = "0x187B82620", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<IOFKNAPGAKK> CLBIMGMADDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B82790", Offset = "0x7B81990", VA = "0x187B82790", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool LCNJJDBPKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC777B0", Offset = "0xC769B0", VA = "0x180C777B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCAC420", Offset = "0xCAB620", VA = "0x180CAC420", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B82D70", Offset = "0x7B81F70", VA = "0x187B82D70", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject DEOJDBDDHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7B82A70", Offset = "0x7B81C70", VA = "0x187B82A70", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7B82A90", Offset = "0x7B81C90", VA = "0x187B82A90", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid ECHNIONAHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7B82BC0", Offset = "0x7B81DC0", VA = "0x187B82BC0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IFKONBJEGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7B82CA0", Offset = "0x7B81EA0", VA = "0x187B82CA0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool KBDFFNPFMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool MNNOAIJDPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7B825D0", Offset = "0x7B817D0", VA = "0x187B825D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event KDANNOPBHNC HCABFPMBGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7B82690", Offset = "0x7B81890", VA = "0x187B82690", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B82440", Offset = "0x7B81640", VA = "0x187B82440", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KDANNOPBHNC GGPKPMMALCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7B827C0", Offset = "0x7B819C0", VA = "0x187B827C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7B81D30", Offset = "0x7B80F30", VA = "0x187B81D30", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event KDANNOPBHNC IDKIHOHKLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7B818C0", Offset = "0x7B80AC0", VA = "0x187B818C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7B82870", Offset = "0x7B81A70", VA = "0x187B82870", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event OEAKGKFLMJD HKFDHPBACOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B826F0", Offset = "0x7B818F0", VA = "0x187B826F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B810A0", Offset = "0x7B802A0", VA = "0x187B810A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B82970", Offset = "0x7B81B70", VA = "0x187B82970")]
	public MLMEIMPCOOK(EBBGNAFIMFG PMOPIAOAEIC, RigidbodyEx MCFDCNGFCOI, OIOJJEMHAHE JHCDKAJHGJB, KCOKNMFAANN[] HEANPHPKIDC, PNGBOFNOMON PLKEMCOOOMD, HGAAMOCBEIA PLOHGBPMMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B812A0", Offset = "0x7B804A0", VA = "0x187B812A0", Slot = "19")]
	public void DDADFJBFCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "21")]
	public void LBCIOHBFBMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x78CCBD0", Offset = "0x78CBDD0", VA = "0x1878CCBD0", Slot = "22")]
	public void GBBAKCDFBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B82820", Offset = "0x7B81A20", VA = "0x187B82820", Slot = "20")]
	public void PDKHLGCCMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7B82230", Offset = "0x7B81430", VA = "0x187B82230", Slot = "25")]
	public void ICMICBBKKBB(int OGILDHNCIGB, IOFKNAPGAKK PDMJGIAMKBP, int KLMIPCIIFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7B80FD0", Offset = "0x7B801D0", VA = "0x187B80FD0", Slot = "26")]
	public void BLNBFHPMEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7B812D0", Offset = "0x7B804D0", VA = "0x187B812D0", Slot = "27")]
	public void EHJNEILAKML(int OGILDHNCIGB, IOFKNAPGAKK CBOGKJOGDFG, int OKNGCHFMMAJ, [Optional] Vector3? CECHGNICGIG, [Optional] Quaternion? KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B824A0", Offset = "0x7B816A0", VA = "0x187B824A0", Slot = "28")]
	public void LCDJLLLPNCP(IOFKNAPGAKK CBOGKJOGDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B81920", Offset = "0x7B80B20", VA = "0x187B81920", Slot = "31")]
	public void GDFBGDJOLII(Vector3 MLCGBKCKNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B815B0", Offset = "0x7B807B0", VA = "0x187B815B0", Slot = "29")]
	public void EKNHAEPBPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B81DE0", Offset = "0x7B80FE0", VA = "0x187B81DE0", Slot = "30")]
	public void GMFEKLPPHCL(int CMDFFDAPDIB, Vector3 ICPEADDPOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B82110", Offset = "0x7B81310", VA = "0x187B82110", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int OGILDHNCIGB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B81FE0", Offset = "0x7B811E0", VA = "0x187B81FE0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int OGILDHNCIGB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xC55400", Offset = "0xC54600", VA = "0x180C55400", Slot = "42")]
	public Color GetConnectionSlotColor(int OGILDHNCIGB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B81200", Offset = "0x7B80400", VA = "0x187B81200", Slot = "43")]
	public bool CanConnectTo(int OGILDHNCIGB, IOFKNAPGAKK MNNOPHFOFEG, int PONONBDEOMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "44")]
	public void ParentChanged(int OGILDHNCIGB, IOFKNAPGAKK BLEKGCHDOOP, int GFDIIOLNFNA, Vector3 EKMAMICMBKE, Quaternion FEFCPOLIKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "45")]
	public void ChildAdded(int OGILDHNCIGB, IOFKNAPGAKK PPNIAPHJMKP, int AGKGMGIGMNF, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "46")]
	public void ChildRemoved(int OGILDHNCIGB, IOFKNAPGAKK LKKGAACLIED, int LLGGAHLCKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "47")]
	public void ConnectionModified(int OGILDHNCIGB, IOFKNAPGAKK PDMJGIAMKBP, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B828D0", Offset = "0x7B81AD0", VA = "0x187B828D0", Slot = "48")]
	public void RootChanged(IOFKNAPGAKK HFCOMKHDGPG, IOFKNAPGAKK CMFBBMGIPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B82520", Offset = "0x7B81720", VA = "0x187B82520", Slot = "23")]
	public void LFBGPEAALDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B81D90", Offset = "0x7B80F90", VA = "0x187B81D90", Slot = "24")]
	public void GJMGCPIBPAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7B821E0", Offset = "0x7B813E0", VA = "0x187B821E0")]
	private void HIDKPPAHCHM(bool LEFNNHHNKLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(IOGINFMBIOL), new string[] { })]
public class PJPBNMLMOPD : IOGINFMBIOL, LNIDKKDBPDJ, OBFJDPCMLDN
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ACJBGEGCFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ACJBGEGCFAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private DICMDELNMBC KOHBDHDNGIJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object OHIFJFLPGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7B87320", Offset = "0x7B86520", VA = "0x187B87320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7B872D0", Offset = "0x7B864D0", VA = "0x187B872D0", Slot = "5")]
	private void DDIHEPEDMIL(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1187CA0", Offset = "0x1186EA0", VA = "0x181187CA0", Slot = "6")]
	private void OEBCMEIKBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PJPBNMLMOPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(HGAAMOCBEIA), new string[] { "Ignore", "Mock" })]
public class MLEFBCLDJJD : HGAAMOCBEIA, EJADEOIPJPK
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OIFFEBPIEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MKGNOFCLEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<IOFKNAPGAKK, IOFKNAPGAKK> OKKJJDILICH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B80B50", Offset = "0x7B7FD50", VA = "0x187B80B50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B80D60", Offset = "0x7B7FF60", VA = "0x187B80D60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<IOFKNAPGAKK, IOFKNAPGAKK> AJJLFMDGADC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B80C00", Offset = "0x7B7FE00", VA = "0x187B80C00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B80CB0", Offset = "0x7B7FEB0", VA = "0x187B80CB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<IOFKNAPGAKK, IOFKNAPGAKK, IOFKNAPGAKK> IALMBJNDCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B80E10", Offset = "0x7B80010", VA = "0x187B80E10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B80EC0", Offset = "0x7B800C0", VA = "0x187B80EC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "26")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "12")]
	public void AFLILFPIJAH(GameObject LBBGHAOMHLO, EINMKHKMNFL KFNDNHHBCEI, OJDEBPCEDIL JIHBCCKGMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "13")]
	public void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "14")]
	public void ELDCOJNOKAJ(IOFKNAPGAKK BKJAKODNAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "15")]
	public void JNBGJFEBNND(IOFKNAPGAKK BKJAKODNAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "16")]
	public void GGAJCHCDOBC(IOFKNAPGAKK BKJAKODNAOC, HashSet<IOFKNAPGAKK> BNGJLHMADGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "17")]
	public void MNIMEBNGDFA(IOFKNAPGAKK BKJAKODNAOC, IOFKNAPGAKK JADHHDJNNPE, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "18")]
	public void AKPMBMGGKCJ(IOFKNAPGAKK BKJAKODNAOC, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "19")]
	public void ENJGLMCCMPA(IOFKNAPGAKK BKJAKODNAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "20")]
	public DKAIOKKDNAG LPKOFFLLHLG(bool ICDOHKECDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "21")]
	public DKAIOKKDNAG AMNPNAAPLAG(HashSet<Guid> DIHLAEBJOIL, bool ICDOHKECDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "22")]
	public bool EAEJIMPPFHB(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "23")]
	public void CABCLFKJMOD(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "24")]
	public void NMDPAIBBCKA(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "25")]
	public void KGINIEPCLDN(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public MLEFBCLDJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IOFKNAPGAKK : OEPFAAGAOIA, IEquatable<IOFKNAPGAKK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OEPFAAGAOIA
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	IOFKNAPGAKK FMEOFOLHMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject DEOJDBDDHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid ECHNIONAHBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int IFKONBJEGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KBDFFNPFMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int OGILDHNCIGB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int OGILDHNCIGB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int OGILDHNCIGB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int OGILDHNCIGB, IOFKNAPGAKK MNNOPHFOFEG, int GGONHLEMANP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int OGILDHNCIGB, IOFKNAPGAKK BLEKGCHDOOP, int GFDIIOLNFNA, Vector3 EKMAMICMBKE, Quaternion FEFCPOLIKOF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int OGILDHNCIGB, IOFKNAPGAKK PPNIAPHJMKP, int AGKGMGIGMNF, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int OGILDHNCIGB, IOFKNAPGAKK LKKGAACLIED, int LLGGAHLCKMF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int OGILDHNCIGB, IOFKNAPGAKK PDMJGIAMKBP, int HBOKEOMMCFP, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(IOFKNAPGAKK HFCOMKHDGPG, IOFKNAPGAKK CMFBBMGIPGI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HGAAMOCBEIA : EJADEOIPJPK
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool OIFFEBPIEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MKGNOFCLEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<IOFKNAPGAKK, IOFKNAPGAKK> OKKJJDILICH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<IOFKNAPGAKK, IOFKNAPGAKK> AJJLFMDGADC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<IOFKNAPGAKK, IOFKNAPGAKK, IOFKNAPGAKK> IALMBJNDCJN;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AFLILFPIJAH(GameObject LBBGHAOMHLO, EINMKHKMNFL KFNDNHHBCEI, OJDEBPCEDIL KCMOFNCANGP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KJFMNLEBHBJ();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ELDCOJNOKAJ(IOFKNAPGAKK BKJAKODNAOC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JNBGJFEBNND(IOFKNAPGAKK BKJAKODNAOC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GGAJCHCDOBC(IOFKNAPGAKK BKJAKODNAOC, HashSet<IOFKNAPGAKK> BNGJLHMADGL);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MNIMEBNGDFA(IOFKNAPGAKK BKJAKODNAOC, IOFKNAPGAKK JADHHDJNNPE, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AKPMBMGGKCJ(IOFKNAPGAKK BKJAKODNAOC, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ENJGLMCCMPA(IOFKNAPGAKK BKJAKODNAOC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DKAIOKKDNAG LPKOFFLLHLG(bool ICDOHKECDNK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DKAIOKKDNAG AMNPNAAPLAG(HashSet<Guid> DIHLAEBJOIL, bool ICDOHKECDNK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EAEJIMPPFHB(KPPAPHMMKAL DDCBOGLJKIC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CABCLFKJMOD(DKAIOKKDNAG HGNFKKHGAON);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NMDPAIBBCKA(DKAIOKKDNAG HGNFKKHGAON);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KGINIEPCLDN(DKAIOKKDNAG HGNFKKHGAON);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MJBJCBIGLPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool LNOIDHHPFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IOFKNAPGAKK BGFJAOPILOD(int EPBMAKFOPEN);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IOFKNAPGAKK AGCIKOJJIMK(Guid NFHKCGOCKPK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMELGGCDLAJ(IOFKNAPGAKK BKJAKODNAOC);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IPFOJFMCGDL();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAIHMJOEGLH(IOFKNAPGAKK JHCDKAJHGJB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface PNGBOFNOMON
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNNOAIJDPFB(OIOJJEMHAHE JHCDKAJHGJB);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFABMKCJFDO(OIOJJEMHAHE JHCDKAJHGJB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string FHDCCKMLJEL(OIOJJEMHAHE JHCDKAJHGJB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid KCEDLPKELBI(OIOJJEMHAHE JHCDKAJHGJB);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GIBIFFHADLO(OIOJJEMHAHE JHCDKAJHGJB);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLDAAENFPBI(OIOJJEMHAHE JHCDKAJHGJB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void KDANNOPBHNC(IOFKNAPGAKK CBOGKJOGDFG, int GOABGOKEBIA, IOFKNAPGAKK PDMJGIAMKBP, int PPIPCPKGENJ, [Optional] Vector3? CECHGNICGIG, [Optional] Quaternion? KJMIGAMAAFG);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void OEAKGKFLMJD(IOFKNAPGAKK HFCOMKHDGPG, IOFKNAPGAKK CMFBBMGIPGI);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OIOJJEMHAHE : IOFKNAPGAKK, OEPFAAGAOIA, IEquatable<IOFKNAPGAKK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CEJDEGIHIJP : OEPFAAGAOIA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IOFKNAPGAKK POMJPEGACNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<IOFKNAPGAKK> CLBIMGMADDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 NECCHEFECPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion NNGHMFGLODO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool FAGPKAKEBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LCNJJDBPKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event KDANNOPBHNC HCABFPMBGMC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event KDANNOPBHNC GGPKPMMALCG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event KDANNOPBHNC IDKIHOHKLJI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event OEAKGKFLMJD HKFDHPBACOL;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DDADFJBFCMK();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PDKHLGCCMGJ();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LBCIOHBFBMA();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GBBAKCDFBGO();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LFBGPEAALDI();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GJMGCPIBPAD();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ICMICBBKKBB(int OGILDHNCIGB, IOFKNAPGAKK PDMJGIAMKBP, int KLMIPCIIFLG);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BLNBFHPMEJE();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EHJNEILAKML(int OGILDHNCIGB, IOFKNAPGAKK CBOGKJOGDFG, int OKNGCHFMMAJ, [Optional] Vector3? CECHGNICGIG, [Optional] Quaternion? KJMIGAMAAFG);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LCDJLLLPNCP(IOFKNAPGAKK CBOGKJOGDFG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EKNHAEPBPMD();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GMFEKLPPHCL(int CMDFFDAPDIB, Vector3 ICPEADDPOJA);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GDFBGDJOLII(Vector3 MLCGBKCKNJN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KCOKNMFAANN
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 DFNCCCFOPAN
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
public interface EINMKHKMNFL
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MBDJAKBOHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FBCEBBBLDOI AENPAHJFKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, EINMKHKMNFL
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
			[Cpp2IlInjected.Address(RVA = "0xB16990", Offset = "0xB15B90", VA = "0x180B16990", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FBCEBBBLDOI LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A720", Offset = "0x7B79920", VA = "0x187B7A720")]
		public static ConnectableConfigData FBDADJAKAAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A7E0", Offset = "0x7B799E0", VA = "0x187B7A7E0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual DCFIKBIPIAK, bool KAOEDBLFDLI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HDHGPACDHMM : IEquatable<HDHGPACDHMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IOFKNAPGAKK BKJAKODNAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int JDNOBKHDIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int HBOKEOMMCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 CECHGNICGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion KJMIGAMAAFG;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F4C0", Offset = "0x7B7E6C0", VA = "0x187B7F4C0")]
	public HDHGPACDHMM(IOFKNAPGAKK BKJAKODNAOC, int JDNOBKHDIMM, int HBOKEOMMCFP, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F5A0", Offset = "0x7B7E7A0", VA = "0x187B7F5A0")]
	public HDHGPACDHMM(IOFKNAPGAKK BKJAKODNAOC, int JDNOBKHDIMM, int HBOKEOMMCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F520", Offset = "0x7B7E720", VA = "0x187B7F520")]
	public HDHGPACDHMM(IOFKNAPGAKK BKJAKODNAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F040", Offset = "0x7B7E240", VA = "0x187B7F040", Slot = "4")]
	public bool Equals(HDHGPACDHMM CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F0F0", Offset = "0x7B7E2F0", VA = "0x187B7F0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class PGOOPIFJKCC : ONLOHOEDECD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform JGOMLHGOKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private FBCEBBBLDOI KPPDNKFAKLH;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x754A260", Offset = "0x7549460", VA = "0x18754A260", Slot = "4")]
	public void AFLILFPIJAH(Transform JGOMLHGOKKB, FBCEBBBLDOI KPPDNKFAKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7B86D70", Offset = "0x7B85F70", VA = "0x187B86D70", Slot = "5")]
	public FBCEBBBLDOI FBFAILODILP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7B86E40", Offset = "0x7B86040", VA = "0x187B86E40", Slot = "6")]
	public void LLMFFCDELKO(FBCEBBBLDOI AGCEKPHFPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PGOOPIFJKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class FPAGGKMNDNC : IDisposable, OMNDKMCANPB
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AEIBKBHHAEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IOFKNAPGAKK oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public IOFKNAPGAKK newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AEIBKBHHAEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7B739D0", Offset = "0x7B72BD0", VA = "0x187B739D0")]
		internal bool IGGCNPLMGHD(AKNPEFPJMPI node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly PFBILMFEJKJ NFFMDAOFMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private IAHPILIMLMC OGKMIGEONKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private LIFOBMHEPBK FANIAMKJHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool KAOEDBLFDLI;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly KEPOMIIOHBM MLHDNGJBCAN;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public AKNPEFPJMPI LHGFIGHCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CC60", Offset = "0x7B7BE60", VA = "0x187B7CC60")]
	public bool GFICPOGMLHO([In] LDBGKDBPIJJ CAIGHLKIDBF, bool OHNMPKHNJMD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C6A0", Offset = "0x7B7B8A0", VA = "0x187B7C6A0")]
	private bool GEBEAHHHJNJ([In] LDBGKDBPIJJ CAIGHLKIDBF, bool OHNMPKHNJMD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7B7ED30", Offset = "0x7B7DF30", VA = "0x187B7ED30")]
	public FPAGGKMNDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B970", Offset = "0x7B7AB70", VA = "0x187B7B970", Slot = "5")]
	public void AFLILFPIJAH(HGAAMOCBEIA OBHJPIMFHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D620", Offset = "0x7B7C820", VA = "0x187B7D620", Slot = "17")]
	public void HJJAGLNENIF(BEELCBHOCDC MHPGHAHOBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C690", Offset = "0x7B7B890", VA = "0x187B7C690", Slot = "12")]
	public void FNOKOEMOIPP(Func<IOFKNAPGAKK, bool> ANNAHNMFKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C560", Offset = "0x7B7B760", VA = "0x187B7C560")]
	private void FNOKOEMOIPP(PFBILMFEJKJ HFACGLFOMBB, Func<IOFKNAPGAKK, bool> ANNAHNMFKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D4B0", Offset = "0x7B7C6B0", VA = "0x187B7D4B0", Slot = "11")]
	public void HECPKCHIJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7B7E140", Offset = "0x7B7D340", VA = "0x187B7E140", Slot = "8")]
	public bool LBAFDJKHLNK(IOFKNAPGAKK GBPKLFHPOPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D8E0", Offset = "0x7B7CAE0", VA = "0x187B7D8E0")]
	private bool IJFCMOEEGFB(IOFKNAPGAKK NGPCJGEMLKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D400", Offset = "0x7B7C600", VA = "0x187B7D400")]
	private static bool GIKLHNBICJN(IOFKNAPGAKK NGPCJGEMLKK, PFBILMFEJKJ MBOPOCAKJIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D010", Offset = "0x7B7C210", VA = "0x187B7D010")]
	private void GGFBPFNHLCA(Transform JFHHPHFHFHP, PFBILMFEJKJ OHLKPJNHLJE, PFBILMFEJKJ[] BMMKJGPPBDK, IOFKNAPGAKK KCGGMEBCEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D4D0", Offset = "0x7B7C6D0", VA = "0x187B7D4D0")]
	private HDHGPACDHMM HIHOGNBFCPA(Transform FMFGPIKKBIK, HDHGPACDHMM LBEOOMFDKAH)
	{
		return default(HDHGPACDHMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BAF0", Offset = "0x7B7ACF0", VA = "0x187B7BAF0")]
	private static bool CBODJLADMKH(PFBILMFEJKJ MBOPOCAKJIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D7B0", Offset = "0x7B7C9B0", VA = "0x187B7D7B0", Slot = "9")]
	public bool IDEACNMEOAP(IOFKNAPGAKK KJMPLOMPDHG, int OKNGCHFMMAJ, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BE20", Offset = "0x7B7B020", VA = "0x187B7BE20")]
	private bool ELILONKOCAG(IOFKNAPGAKK KJMPLOMPDHG, int OKNGCHFMMAJ, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C070", Offset = "0x7B7B270", VA = "0x187B7C070")]
	private static void FCCGKOJKKOK(IOFKNAPGAKK KJMPLOMPDHG, int OKNGCHFMMAJ, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG, PFBILMFEJKJ DFLNOGGDNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7B7E150", Offset = "0x7B7D350", VA = "0x187B7E150")]
	private void LKDJJBFHHJK(IOFKNAPGAKK HAEGNGADNID, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7EAA0", Offset = "0x7B7DCA0", VA = "0x187B7EAA0")]
	private void PFGBHHAPFAO(PFBILMFEJKJ HFACGLFOMBB, IOFKNAPGAKK OGIMAJLLPDJ, IOFKNAPGAKK LCNCFEHAGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7B7EA30", Offset = "0x7B7DC30", VA = "0x187B7EA30")]
	private void PFGBHHAPFAO(IOFKNAPGAKK BKJAKODNAOC, IOFKNAPGAKK OGIMAJLLPDJ, IOFKNAPGAKK LCNCFEHAGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BCB0", Offset = "0x7B7AEB0", VA = "0x187B7BCB0")]
	private void EKPCIDFAFCC(IOFKNAPGAKK BKJAKODNAOC, IOFKNAPGAKK OGIMAJLLPDJ, IOFKNAPGAKK LCNCFEHAGKF, bool FHDFEBGCHEL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BD20", Offset = "0x7B7AF20", VA = "0x187B7BD20")]
	private void EKPCIDFAFCC(PFBILMFEJKJ OLEJNEHCCLF, IOFKNAPGAKK KCGGMEBCEMN, IOFKNAPGAKK CMFBBMGIPGI, bool FHDFEBGCHEL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7B7DFE0", Offset = "0x7B7D1E0", VA = "0x187B7DFE0")]
	private void JHHKFFGPCHE(IOFKNAPGAKK JPCNHODHEGA, int OKNGCHFMMAJ, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D650", Offset = "0x7B7C850", VA = "0x187B7D650")]
	private void HLIEOHNFGAO(AKNPEFPJMPI FLKKOCNDECC, AKNPEFPJMPI GBEKMKGKLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7B7EB10", Offset = "0x7B7DD10", VA = "0x187B7EB10", Slot = "18")]
	public IOFKNAPGAKK PKPHNIJEKFJ(IOFKNAPGAKK BKJAKODNAOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CC70", Offset = "0x7B7BE70", VA = "0x187B7CC70", Slot = "13")]
	public void GGAJCHCDOBC(IOFKNAPGAKK BKJAKODNAOC, HashSet<IOFKNAPGAKK> OOPLODGPJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C320", Offset = "0x7B7B520", VA = "0x187B7C320", Slot = "14")]
	public List<IOFKNAPGAKK> FMPOGLMOJNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BA20", Offset = "0x7B7AC20", VA = "0x187B7BA20")]
	protected AKNPEFPJMPI AKBKEGBPHPG(AKNPEFPJMPI HFACGLFOMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7B7E270", Offset = "0x7B7D470", VA = "0x187B7E270")]
	protected PFBILMFEJKJ[] MBDGEKOBAPN(PFBILMFEJKJ MBOPOCAKJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7B7E8C0", Offset = "0x7B7DAC0", VA = "0x187B7E8C0")]
	protected bool NHLLAMPMGMD(IOFKNAPGAKK BKJAKODNAOC, [Out] PFBILMFEJKJ HFACGLFOMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C1F0", Offset = "0x7B7B3F0", VA = "0x187B7C1F0", Slot = "15")]
	public bool FLNFAJLDKKE(IOFKNAPGAKK BKJAKODNAOC, [Out] HDHGPACDHMM IGHILDNOEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7B7E100", Offset = "0x7B7D300", VA = "0x187B7E100")]
	protected PFBILMFEJKJ JPKMAGMDFFD(HDHGPACDHMM NCEBBDMCAEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7B7E9D0", Offset = "0x7B7DBD0", VA = "0x187B7E9D0", Slot = "10")]
	public bool OEJHAMJBDOM(IOFKNAPGAKK HAEGNGADNID, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7B7E310", Offset = "0x7B7D510", VA = "0x187B7E310")]
	private bool MCOOKNOOFDC(IOFKNAPGAKK HAEGNGADNID, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D810", Offset = "0x7B7CA10", VA = "0x187B7D810")]
	private static bool IIHLPDJKFFI(PFBILMFEJKJ CLCJBFJKFKD, HDHGPACDHMM OMONFFIHIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CC60", Offset = "0x7B7BE60", VA = "0x187B7CC60", Slot = "7")]
	private bool LNOBPEDNKCF([In] LDBGKDBPIJJ CAIGHLKIDBF, bool OHNMPKHNJMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class CGNMKBMIJGC : HGAAMOCBEIA, EJADEOIPJPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly FJCFOKJAKFO MBLPEFIMNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly LIFOBMHEPBK FANIAMKJHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly PIKKPPPOPIP LEJBDONELOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly PEHFIHOCDKD FLONKPCJDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly OMNDKMCANPB HGNFKKHGAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal PEAPLBIMDJF PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal CAAMFLADIOO NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal IAHPILIMLMC LJBDOIFCCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool KAOEDBLFDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool DLANINDJBIC;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BENENHMOMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xC62DA0", Offset = "0xC61FA0", VA = "0x180C62DA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x13562B0", Offset = "0x13554B0", VA = "0x1813562B0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OIFFEBPIEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x11360D0", Offset = "0x11352D0", VA = "0x1811360D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x26D9E90", Offset = "0x26D9090", VA = "0x1826D9E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MKGNOFCLEEE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<IOFKNAPGAKK, IOFKNAPGAKK> OKKJJDILICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7B79440", Offset = "0x7B78640", VA = "0x187B79440", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7B79BF0", Offset = "0x7B78DF0", VA = "0x187B79BF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<IOFKNAPGAKK, IOFKNAPGAKK> AJJLFMDGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B795F0", Offset = "0x7B787F0", VA = "0x187B795F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B79750", Offset = "0x7B78950", VA = "0x187B79750", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<IOFKNAPGAKK, IOFKNAPGAKK, IOFKNAPGAKK> IALMBJNDCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7B79C50", Offset = "0x7B78E50", VA = "0x187B79C50", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7B79CB0", Offset = "0x7B78EB0", VA = "0x187B79CB0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A330", Offset = "0x7B79530", VA = "0x187B7A330")]
	public CGNMKBMIJGC(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7B78630", Offset = "0x7B77830", VA = "0x187B78630", Slot = "12")]
	public void AFLILFPIJAH(GameObject LBBGHAOMHLO, EINMKHKMNFL KFNDNHHBCEI, OJDEBPCEDIL KCMOFNCANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A260", Offset = "0x7B79460", VA = "0x187B7A260", Slot = "26")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7B79B70", Offset = "0x7B78D70", VA = "0x187B79B70", Slot = "13")]
	public void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7B79250", Offset = "0x7B78450", VA = "0x187B79250", Slot = "14")]
	public void ELDCOJNOKAJ(IOFKNAPGAKK BKJAKODNAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7B798F0", Offset = "0x7B78AF0", VA = "0x187B798F0", Slot = "15")]
	public void JNBGJFEBNND(IOFKNAPGAKK BKJAKODNAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7B79200", Offset = "0x7B78400", VA = "0x187B79200", Slot = "22")]
	public bool EAEJIMPPFHB(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7B79E90", Offset = "0x7B79090", VA = "0x187B79E90")]
	internal bool MCOOKNOOFDC([In] LDBGKDBPIJJ CAIGHLKIDBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7B794A0", Offset = "0x7B786A0", VA = "0x187B794A0")]
	internal bool FAEMJLEFKHC([In] LDBGKDBPIJJ CAIGHLKIDBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7B79950", Offset = "0x7B78B50", VA = "0x187B79950")]
	internal void KDPMJAGLGEB(IOFKNAPGAKK BKJAKODNAOC, int IJNEPKLNHNB, bool OHNMPKHNJMD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7B798F0", Offset = "0x7B78AF0", VA = "0x187B798F0")]
	internal bool HCJKABMBJGN(IOFKNAPGAKK CEFFOBKGKDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7B797B0", Offset = "0x7B789B0", VA = "0x187B797B0")]
	internal bool HAFOCHCJKDM(IOFKNAPGAKK KJMPLOMPDHG, int OKNGCHFMMAJ, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7B79650", Offset = "0x7B78850", VA = "0x187B79650", Slot = "16")]
	public void GGAJCHCDOBC(IOFKNAPGAKK BKJAKODNAOC, HashSet<IOFKNAPGAKK> BNGJLHMADGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7B79FA0", Offset = "0x7B791A0", VA = "0x187B79FA0", Slot = "17")]
	public void MNIMEBNGDFA(IOFKNAPGAKK KJMPLOMPDHG, IOFKNAPGAKK JADHHDJNNPE, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7B78E90", Offset = "0x7B78090", VA = "0x187B78E90", Slot = "18")]
	public void AKPMBMGGKCJ(IOFKNAPGAKK HAEGNGADNID, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7B79270", Offset = "0x7B78470", VA = "0x187B79270", Slot = "19")]
	public void ENJGLMCCMPA(IOFKNAPGAKK HAEGNGADNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7B78C40", Offset = "0x7B77E40", VA = "0x187B78C40")]
	public void AJKOBILMNDP([Optional] BNFABCHNBCL MHCAGFPLHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7B79170", Offset = "0x7B78370", VA = "0x187B79170", Slot = "23")]
	public void CABCLFKJMOD(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7B79D10", Offset = "0x7B78F10", VA = "0x187B79D10", Slot = "20")]
	public DKAIOKKDNAG LPKOFFLLHLG(bool ICDOHKECDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7B78FD0", Offset = "0x7B781D0", VA = "0x187B78FD0", Slot = "21")]
	public DKAIOKKDNAG AMNPNAAPLAG(HashSet<Guid> DIHLAEBJOIL, bool ICDOHKECDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7B79B30", Offset = "0x7B78D30", VA = "0x187B79B30", Slot = "25")]
	public void KGINIEPCLDN(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A1B0", Offset = "0x7B793B0", VA = "0x187B7A1B0", Slot = "24")]
	public void NMDPAIBBCKA(DKAIOKKDNAG HGNFKKHGAON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class LIFOBMHEPBK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly LDFPLGIGGEB<IOFKNAPGAKK, IOFKNAPGAKK> OKKJJDILICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly LDFPLGIGGEB<IOFKNAPGAKK, IOFKNAPGAKK> AJJLFMDGADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly NDONKLDDPDL<IOFKNAPGAKK, IOFKNAPGAKK, IOFKNAPGAKK> IALMBJNDCJN;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FDB0", Offset = "0x7B7EFB0", VA = "0x187B7FDB0")]
	public LIFOBMHEPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	public void AFLILFPIJAH(CGNMKBMIJGC OBHJPIMFHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FC70", Offset = "0x7B7EE70", VA = "0x187B7FC70")]
	public void EGDINHFDAPH(IOFKNAPGAKK FLKKOCNDECC, IOFKNAPGAKK JPCNHODHEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FD50", Offset = "0x7B7EF50", VA = "0x187B7FD50")]
	public void KLBONKMOELK(IOFKNAPGAKK FLKKOCNDECC, IOFKNAPGAKK JPCNHODHEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FCD0", Offset = "0x7B7EED0", VA = "0x187B7FCD0")]
	public void EODAEBONHNI(IOFKNAPGAKK IPGOMKHKGIK, IOFKNAPGAKK DAFAJHDHOLC, IOFKNAPGAKK JPCNHODHEGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class PIKKPPPOPIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private CGNMKBMIJGC OBHJPIMFHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private CAAMFLADIOO NCFBNFPHDDJ;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PIKKPPPOPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B86EB0", Offset = "0x7B860B0", VA = "0x187B86EB0")]
	public void AFLILFPIJAH(CGNMKBMIJGC OBHJPIMFHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7B86FF0", Offset = "0x7B861F0", VA = "0x187B86FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7B87110", Offset = "0x7B86310", VA = "0x187B87110")]
	private void JKMDGJEJMLG(NPGIOFFINPJ LPGODJOFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7B87260", Offset = "0x7B86460", VA = "0x187B87260")]
	private void PONJHEFHAJM(BNFABCHNBCL AHEOAPACCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7B87000", Offset = "0x7B86200", VA = "0x187B87000")]
	public void GOHLMJIJABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7B87150", Offset = "0x7B86350", VA = "0x187B87150")]
	public void JPJJGLMPGDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DNDIAFKCCLP
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KLJHHDFMLIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public FJCFOKJAKFO container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KLJHHDFMLIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F8F0", Offset = "0x7B7EAF0", VA = "0x187B7F8F0")]
		internal CGNMKBMIJGC GIOMDJEGKBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B770", Offset = "0x7B7A970", VA = "0x187B7B770")]
	public static void ICEIMLGPLMP(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B6F0", Offset = "0x7B7A8F0", VA = "0x187B7B6F0")]
	public static void ANHGOEKILBF(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class OIGHOAIJACG : IDisposable, IAHPILIMLMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, FBCEBBBLDOI> HJBBMEADLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly BEELCBHOCDC KLFBFMNIANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private ONLOHOEDECD MCBHFLKONDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private OMNDKMCANPB HGNFKKHGAON;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker IBLIIICDFKI;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7B83A50", Offset = "0x7B82C50", VA = "0x187B83A50")]
	public OIGHOAIJACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7B82D90", Offset = "0x7B81F90", VA = "0x187B82D90", Slot = "7")]
	public void AFLILFPIJAH(OMNDKMCANPB HGNFKKHGAON, ONLOHOEDECD MCBHFLKONDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7B82F40", Offset = "0x7B82140", VA = "0x187B82F40", Slot = "5")]
	public void CJFJFIHFLOD(AKNPEFPJMPI NBMHOEENPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7B82DD0", Offset = "0x7B81FD0", VA = "0x187B82DD0", Slot = "9")]
	public void BGKDJKCGFGD(AKNPEFPJMPI MAFGJNILKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7B83680", Offset = "0x7B82880", VA = "0x187B83680", Slot = "8")]
	public void JDLDKLAEFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7B83330", Offset = "0x7B82530", VA = "0x187B83330", Slot = "10")]
	public void JBDDJEKOJFI(AKNPEFPJMPI EKKLNMNBGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7B83840", Offset = "0x7B82A40", VA = "0x187B83840", Slot = "11")]
	public void LDPKIHDJBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7B83180", Offset = "0x7B82380", VA = "0x187B83180")]
	private bool FCBIOJMGGJE(AKNPEFPJMPI KAMENFELAAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class PEHFIHOCDKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct DKCHHJNHKGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly PFBILMFEJKJ GCENJDPDKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> DIHLAEBJOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly KPPAPHMMKAL NCJPDEJGNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly KPPAPHMMKAL GGEMEBEPIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool ICDOHKECDNK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool GAONKBNLBMB
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7B7B170", Offset = "0x7B7A370", VA = "0x187B7B170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7B7B680", Offset = "0x7B7A880", VA = "0x187B7B680")]
		public DKCHHJNHKGL(PFBILMFEJKJ GCENJDPDKGA, HashSet<Guid> DIHLAEBJOIL, bool ICDOHKECDNK, [Optional] KPPAPHMMKAL NCJPDEJGNNN, [Optional] KPPAPHMMKAL GGEMEBEPIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7B7AFD0", Offset = "0x7B7A1D0", VA = "0x187B7AFD0")]
		public KPPAPHMMKAL ELKKKBEIKKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7B5C0", Offset = "0x7B7A7C0", VA = "0x187B7B5C0")]
		private KPPAPHMMKAL PJAJGIOEAMI([Out] KPPAPHMMKAL ALNPGCJKPHI, [Out] KPPAPHMMKAL GBFPJOEPCGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7B7ADB0", Offset = "0x7B79FB0", VA = "0x187B7ADB0")]
		private KPPAPHMMKAL EHLPEJPPFPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7B7B290", Offset = "0x7B7A490", VA = "0x187B7B290")]
		private void IOOGIIFKCKI(KPPAPHMMKAL IBFAKIKJLLL, KPPAPHMMKAL BGBDCGODKDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7B7B400", Offset = "0x7B7A600", VA = "0x187B7B400")]
		private void LLLOPFOMCKE(KPPAPHMMKAL ALNPGCJKPHI, KPPAPHMMKAL GBFPJOEPCGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private CGNMKBMIJGC OBHJPIMFHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private OMNDKMCANPB HGNFKKHGAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private IAHPILIMLMC OGKMIGEONKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private CAAMFLADIOO NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool AEJNOEFPKGO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool JFOFHFCJJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7B84680", Offset = "0x7B83880", VA = "0x187B84680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool BENENHMOMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7B847E0", Offset = "0x7B839E0", VA = "0x187B847E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7B843D0", Offset = "0x7B835D0", VA = "0x187B843D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7B83B30", Offset = "0x7B82D30", VA = "0x187B83B30")]
	public void AFLILFPIJAH(CGNMKBMIJGC OBHJPIMFHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7B854D0", Offset = "0x7B846D0", VA = "0x187B854D0")]
	public DKAIOKKDNAG LPKOFFLLHLG(bool ICDOHKECDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7B83E30", Offset = "0x7B83030", VA = "0x187B83E30")]
	public DKAIOKKDNAG AMNPNAAPLAG(HashSet<Guid> DIHLAEBJOIL, bool ICDOHKECDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7B84340", Offset = "0x7B83540", VA = "0x187B84340")]
	public void CABCLFKJMOD(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7B85D40", Offset = "0x7B84F40", VA = "0x187B85D40")]
	public void NMDPAIBBCKA(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7B85DE0", Offset = "0x7B84FE0", VA = "0x187B85DE0")]
	public void OCENBDBDGMG(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7B84150", Offset = "0x7B83350", VA = "0x187B84150")]
	private void BMOCAAGOPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7B85FA0", Offset = "0x7B851A0", VA = "0x187B85FA0")]
	private KPPAPHMMKAL OEPPLBMFNPD(PFBILMFEJKJ HFACGLFOMBB, bool ICDOHKECDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7B84B10", Offset = "0x7B83D10", VA = "0x187B84B10")]
	private static void JJIAMCIDBBK(PFBILMFEJKJ HFACGLFOMBB, bool ICDOHKECDNK, KPPAPHMMKAL DDCBOGLJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7B848F0", Offset = "0x7B83AF0", VA = "0x187B848F0")]
	private void JGGPKDCDAFO(PFBILMFEJKJ HFACGLFOMBB, bool ICDOHKECDNK, KPPAPHMMKAL DDCBOGLJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7B85640", Offset = "0x7B84840", VA = "0x187B85640")]
	private KPPAPHMMKAL MCLGCLCANNL(PFBILMFEJKJ GCENJDPDKGA, HashSet<Guid> DIHLAEBJOIL, bool ICDOHKECDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7B83BA0", Offset = "0x7B82DA0", VA = "0x187B83BA0")]
	private bool AKIAFAMAMEL(DKAIOKKDNAG EJEJKPIJEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7B856D0", Offset = "0x7B848D0", VA = "0x187B856D0")]
	private bool NKDOEPNIMMK(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7B84FC0", Offset = "0x7B841C0", VA = "0x187B84FC0")]
	private bool KKPAEOAHLOK(DKAIOKKDNAG HGNFKKHGAON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7B846D0", Offset = "0x7B838D0", VA = "0x187B846D0")]
	private static bool HIOIFMCPIJE(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7B843F0", Offset = "0x7B835F0", VA = "0x187B843F0")]
	public static bool EAEJIMPPFHB(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7B84FE0", Offset = "0x7B841E0", VA = "0x187B84FE0")]
	private IOFKNAPGAKK KMKBBPBHKBE(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7B83FD0", Offset = "0x7B831D0", VA = "0x187B83FD0")]
	private IOFKNAPGAKK BGFJAOPILOD(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7B85E10", Offset = "0x7B85010", VA = "0x187B85E10")]
	private IOFKNAPGAKK ODIJPHMAPAM(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7B76840", Offset = "0x7B75A40", VA = "0x187B76840")]
	private static Guid HBFFNFCOLEI(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7B84800", Offset = "0x7B83A00", VA = "0x187B84800")]
	private string HNMNDAFPLBF(KPPAPHMMKAL DDCBOGLJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7B85340", Offset = "0x7B84540", VA = "0x187B85340")]
	private bool KPPKDJGPIEN(PFBILMFEJKJ HFACGLFOMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7B84D60", Offset = "0x7B83F60", VA = "0x187B84D60")]
	private static void KBOFMJDCDLN(PFBILMFEJKJ GCENJDPDKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PEHFIHOCDKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct LDBGKDBPIJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public IOFKNAPGAKK JPCNHODHEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public IOFKNAPGAKK FLKKOCNDECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int OKNGCHFMMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int KLMIPCIIFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 CECHGNICGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion KJMIGAMAAFG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HDHGPACDHMM JKEMPKACFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F990", Offset = "0x7B7EB90", VA = "0x187B7F990")]
		get
		{
			return default(HDHGPACDHMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HDHGPACDHMM LGKPPAKFPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F960", Offset = "0x7B7EB60", VA = "0x187B7F960")]
		get
		{
			return default(HDHGPACDHMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FA30", Offset = "0x7B7EC30", VA = "0x187B7FA30")]
	public LDBGKDBPIJJ(IOFKNAPGAKK JPCNHODHEGA, IOFKNAPGAKK FLKKOCNDECC, int OKNGCHFMMAJ, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface OMNDKMCANPB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	AKNPEFPJMPI LHGFIGHCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFLILFPIJAH(HGAAMOCBEIA OBHJPIMFHEM);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFICPOGMLHO([In] LDBGKDBPIJJ CAIGHLKIDBF, bool OHNMPKHNJMD = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LBAFDJKHLNK(IOFKNAPGAKK GBPKLFHPOPB);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IDEACNMEOAP(IOFKNAPGAKK KJMPLOMPDHG, int OKNGCHFMMAJ, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OEJHAMJBDOM(IOFKNAPGAKK HAEGNGADNID, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HECPKCHIJKB();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FNOKOEMOIPP(Func<IOFKNAPGAKK, bool> ANNAHNMFKEM);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GGAJCHCDOBC(IOFKNAPGAKK BKJAKODNAOC, HashSet<IOFKNAPGAKK> OOPLODGPJGE);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<IOFKNAPGAKK> FMPOGLMOJNE();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FLNFAJLDKKE(IOFKNAPGAKK BKJAKODNAOC, [Out] HDHGPACDHMM IGHILDNOEMG);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HJJAGLNENIF(BEELCBHOCDC MHPGHAHOBNK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool BEELCBHOCDC(AKNPEFPJMPI HFACGLFOMBB);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface AKNPEFPJMPI
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IOFKNAPGAKK FFJAKDGAKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AKNPEFPJMPI MBPBJNDLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HDHGPACDHMM BJBGPKCEPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool GGNKGLPACJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FBCEBBBLDOI
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJDFNMPLFGP(IOFKNAPGAKK PDMJGIAMKBP, HDHGPACDHMM JPCNHODHEGA);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKEGBFJCNJE(IOFKNAPGAKK PDMJGIAMKBP, HDHGPACDHMM JPCNHODHEGA);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGCAFLJCNCD(IOFKNAPGAKK PDMJGIAMKBP, HDHGPACDHMM JPCNHODHEGA);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHKJJJCFGGI(IOFKNAPGAKK PDMJGIAMKBP, HDHGPACDHMM JPCNHODHEGA);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FBCEBBBLDOI Instantiate(Transform JGOMLHGOKKB);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BEPHGAAGPAM();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface ONLOHOEDECD
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFLILFPIJAH(Transform JGOMLHGOKKB, FBCEBBBLDOI KPPDNKFAKLH);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FBCEBBBLDOI FBFAILODILP();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLMFFCDELKO(FBCEBBBLDOI AGCEKPHFPMB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface PEAPLBIMDJF : MJBJCBIGLPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJKGCPEEBGO();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DNMHLFCBDOK(Guid BGFODCFIGMI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface IAHPILIMLMC
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJFJFIHFLOD(AKNPEFPJMPI NBMHOEENPFC);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFLILFPIJAH(OMNDKMCANPB HGNFKKHGAON, ONLOHOEDECD COMJJGDDAHD);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JDLDKLAEFBE();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGKDJKCGFGD(AKNPEFPJMPI MAFGJNILKHP);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBDDJEKOJFI(AKNPEFPJMPI EKKLNMNBGMJ);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LDPKIHDJBBE();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class PFBILMFEJKJ : AKNPEFPJMPI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GNBDDAPCJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HDHGPACDHMM nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public PFBILMFEJKJ foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GNBDDAPCJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B7EF00", Offset = "0x7B7E100", VA = "0x187B7EF00")]
		internal bool NHAHGEIDNHH(AKNPEFPJMPI x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private HDHGPACDHMM IGHILDNOEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<PFBILMFEJKJ> LCLFLBDOHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private PFBILMFEJKJ KEAPBKKPHFO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public HDHGPACDHMM BJBGPKCEPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1356500", Offset = "0x1355700", VA = "0x181356500", Slot = "6")]
		get
		{
			return default(HDHGPACDHMM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1355F50", Offset = "0x1355150", VA = "0x181355F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private PFBILMFEJKJ FLKKOCNDECC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B86BE0", Offset = "0x7B85DE0", VA = "0x187B86BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public AKNPEFPJMPI MBPBJNDLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IOFKNAPGAKK FFJAKDGAKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool GGNKGLPACJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B865B0", Offset = "0x7B857B0", VA = "0x187B865B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CDDHCFJDAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B866C0", Offset = "0x7B858C0", VA = "0x187B866C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected PFBILMFEJKJ OLEJNEHCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B86710", Offset = "0x7B85910", VA = "0x187B86710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7B86CC0", Offset = "0x7B85EC0", VA = "0x187B86CC0")]
	public PFBILMFEJKJ(HDHGPACDHMM HLEHLENKNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B86240", Offset = "0x7B85440", VA = "0x187B86240")]
	public PFBILMFEJKJ BBPGDPFHMMN(HDHGPACDHMM MINMJNPKIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B86880", Offset = "0x7B85A80", VA = "0x187B86880")]
	public PFBILMFEJKJ PAFAKGNLNCB(HDHGPACDHMM DFKMEBPGGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B86A00", Offset = "0x7B85C00", VA = "0x187B86A00")]
	public PFBILMFEJKJ PKCJOLGDFLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B86730", Offset = "0x7B85930", VA = "0x187B86730")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B86390", Offset = "0x7B85590", VA = "0x187B86390")]
	public PFBILMFEJKJ DHBPMEGBLKK(HDHGPACDHMM DAFAJHDHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7B86440", Offset = "0x7B85640", VA = "0x187B86440")]
	private static void HJJAGLNENIF(PFBILMFEJKJ OBAJACOBCDJ, BEELCBHOCDC LPBJFFLCJMN, bool LAFNBKENKCE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B865A0", Offset = "0x7B857A0", VA = "0x187B865A0", Slot = "9")]
	public void HJJAGLNENIF(BEELCBHOCDC MHPGHAHOBNK, bool FHDFEBGCHEL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7B865C0", Offset = "0x7B857C0", VA = "0x187B865C0")]
	public static PFBILMFEJKJ JPKMAGMDFFD(PFBILMFEJKJ OBAJACOBCDJ, HDHGPACDHMM JJODGPPNJKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface CAAMFLADIOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool JFOFHFCJJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LNOIDHHPFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<NPGIOFFINPJ> JKMDGJEJMLG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<BNFABCHNBCL> PONJHEFHAJM;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IJDFNMPLFGP(CGNMKBMIJGC OBHJPIMFHEM, OJDEBPCEDIL JIHBCCKGMLM);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MNIMEBNGDFA(IOFKNAPGAKK KJMPLOMPDHG, IOFKNAPGAKK JADHHDJNNPE, int OKNGCHFMMAJ, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AKPMBMGGKCJ(IOFKNAPGAKK HAEGNGADNID, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MGGLILGIOLD(DKAIOKKDNAG PFOBOHHLGPO, [Optional] BNFABCHNBCL MHCAGFPLHHC);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KFPBKKBFOCD
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type BGLOFMKFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F890", Offset = "0x7B7EA90", VA = "0x187B7F890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object AIBLJDBPKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F800", Offset = "0x7B7EA00", VA = "0x187B7F800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F840", Offset = "0x7B7EA40", VA = "0x187B7F840")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class AAPPJENMIFF : CAAMFLADIOO, IDisposable, OOECHMNDMCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private CGNMKBMIJGC OBHJPIMFHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private OJDEBPCEDIL KCMOFNCANGP;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool JFOFHFCJJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B72C80", Offset = "0x7B71E80", VA = "0x187B72C80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool LNOIDHHPFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B73180", Offset = "0x7B72380", VA = "0x187B73180", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView LMONFAIDLHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B72E90", Offset = "0x7B72090", VA = "0x187B72E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NPGIOFFINPJ> JKMDGJEJMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B72E00", Offset = "0x7B72000", VA = "0x187B72E00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B72CE0", Offset = "0x7B71EE0", VA = "0x187B72CE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BNFABCHNBCL> PONJHEFHAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B72B90", Offset = "0x7B71D90", VA = "0x187B72B90", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B731C0", Offset = "0x7B723C0", VA = "0x187B731C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7B72D70", Offset = "0x7B71F70", VA = "0x187B72D70", Slot = "10")]
	public void IJDFNMPLFGP(CGNMKBMIJGC OBHJPIMFHEM, OJDEBPCEDIL KCMOFNCANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B72C30", Offset = "0x7B71E30", VA = "0x187B72C30", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B73050", Offset = "0x7B72250", VA = "0x187B73050", Slot = "11")]
	public void MNIMEBNGDFA(IOFKNAPGAKK KJMPLOMPDHG, IOFKNAPGAKK JADHHDJNNPE, int OKNGCHFMMAJ, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7B72A60", Offset = "0x7B71C60", VA = "0x187B72A60", Slot = "12")]
	public void AKPMBMGGKCJ(IOFKNAPGAKK HAEGNGADNID, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7B72F20", Offset = "0x7B72120", VA = "0x187B72F20", Slot = "13")]
	public void MGGLILGIOLD(DKAIOKKDNAG PFOBOHHLGPO, [Optional] BNFABCHNBCL MHCAGFPLHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7B734A0", Offset = "0x7B726A0", VA = "0x187B734A0")]
	[KCNCHMBHOPM]
	private void RpcMasterReparentNodes(IOFKNAPGAKK HAEGNGADNID, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7B732A0", Offset = "0x7B724A0", VA = "0x187B732A0")]
	[KCNCHMBHOPM]
	private void RpcMasterModifyNode(IOFKNAPGAKK KJMPLOMPDHG, IOFKNAPGAKK JADHHDJNNPE, int OKNGCHFMMAJ, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7B738A0", Offset = "0x7B72AA0", VA = "0x187B738A0")]
	[KCNCHMBHOPM]
	private void RpcReparentNodes(IOFKNAPGAKK HAEGNGADNID, int DAEDEPOFDLD, IOFKNAPGAKK DAFAJHDHOLC, int GFDIIOLNFNA, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG, GIKIDEGCBCI IFDDCBHIBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7B737B0", Offset = "0x7B729B0", VA = "0x187B737B0")]
	[KCNCHMBHOPM]
	private void RpcModifyNode(IOFKNAPGAKK KJMPLOMPDHG, int OKNGCHFMMAJ, int KLMIPCIIFLG, Vector3 CECHGNICGIG, Quaternion KJMIGAMAAFG, GIKIDEGCBCI IFDDCBHIBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7B73260", Offset = "0x7B72460", VA = "0x187B73260")]
	[KCNCHMBHOPM]
	private void RpcDeserializeConnectableGraph(DKAIOKKDNAG HGNFKKHGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public AAPPJENMIFF()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, FBCEBBBLDOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B80540", Offset = "0x7B7F740", VA = "0x187B80540", Slot = "4")]
		private void LMHINLKILEO(IOFKNAPGAKK PDMJGIAMKBP, HDHGPACDHMM JPCNHODHEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B806C0", Offset = "0x7B7F8C0", VA = "0x187B806C0", Slot = "5")]
		private void PMKGFEJEPBP(IOFKNAPGAKK PDMJGIAMKBP, HDHGPACDHMM JPCNHODHEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B803E0", Offset = "0x7B7F5E0", VA = "0x187B803E0", Slot = "6")]
		private void KABJBGGOGJE(IOFKNAPGAKK PDMJGIAMKBP, HDHGPACDHMM JPCNHODHEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B80180", Offset = "0x7B7F380", VA = "0x187B80180", Slot = "7")]
		private void GLAEEJGMLFK(IOFKNAPGAKK PDMJGIAMKBP, HDHGPACDHMM JPCNHODHEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B80370", Offset = "0x7B7F570", VA = "0x187B80370", Slot = "8")]
		private FBCEBBBLDOI HEOLHGGDKFO(Transform JGOMLHGOKKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B80120", Offset = "0x7B7F320", VA = "0x187B80120", Slot = "9")]
		private void EEKDBKPMIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class JMCDNJBAOPK
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C080", Offset = "0x3A6B280", VA = "0x183A6C080")]
	public static NMAHKGMEKGP<T> OHIEJHANIIG<T>(this FJCFOKJAKFO MBLPEFIMNGA)
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
