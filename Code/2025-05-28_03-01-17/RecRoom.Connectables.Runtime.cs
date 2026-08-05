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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8890", Offset = "0x7CC7690", VA = "0x187CC8890", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE070", Offset = "0x7CCCE70", VA = "0x187CCE070", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7CCDBC0", Offset = "0x7CCC9C0", VA = "0x187CCDBC0")]
		private void OCIJCOAIOEO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7CCDA50", Offset = "0x7CCC850", VA = "0x187CCDA50")]
		private void JOJOLCIOGCC(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7CCDD30", Offset = "0x7CCCB30", VA = "0x187CCDD30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE0B0", Offset = "0x7CCCEB0", VA = "0x187CCE0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class EMPOMMDILON : CGGFBEGKHOF, IMNKKHLGPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class IPNODOCJAKH : IEnumerable<LOFJHEPBONG>, IEnumerable, IEnumerator<LOFJHEPBONG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private LOFJHEPBONG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JBBGAMGOICI localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JBBGAMGOICI <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EMPOMMDILON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private FNPHLLFAMCL <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private LHGPEBNJFMN <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private LHGPEBNJFMN.ICMECJBJJII <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LOFJHEPBONG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public IPNODOCJAKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3F20", Offset = "0x7CC2D20", VA = "0x187CC3F20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3AA0", Offset = "0x7CC28A0", VA = "0x187CC3AA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3E00", Offset = "0x7CC2C00", VA = "0x187CC3E00")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3A80", Offset = "0x7CC2880", VA = "0x187CC3A80")]
		private void IMLDEFFNBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3ED0", Offset = "0x7CC2CD0", VA = "0x187CC3ED0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3E20", Offset = "0x7CC2C20", VA = "0x187CC3E20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LOFJHEPBONG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3E20", Offset = "0x7CC2C20", VA = "0x187CC3E20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MMCIMGAJNMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public EMPOMMDILON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public OPHHACDDLLH nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MMCIMGAJNMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8A30", Offset = "0x7CC7830", VA = "0x187CC8A30")]
		internal object ENGPHPCIKBO(OPHHACDDLLH x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NKBLPPILLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public OPHHACDDLLH child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MMCIMGAJNMH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NKBLPPILLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8AA0", Offset = "0x7CC78A0", VA = "0x187CC8AA0")]
		internal object INCONDGNBEI((OPHHACDDLLH child, OPHHACDDLLH nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly IEBEPMGFCGH FBNIECMABCB;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly IEBEPMGFCGH OOMPPLLNPHB;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly IEBEPMGFCGH NJJLCIMEKJN;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IEBEPMGFCGH HMFOFAGILLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OOEFJPHJGKF IPMKACOKACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private HKNJHJGCLNN JHIOCMNHFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private HCALMMNKPKA BEILFLKLOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PBDAMGFEFEG LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private JCIKEDDHEJM AFANCFDMPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private ACCMOKPPGII PNGKBGCHBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BOGNLGINFDP EPHKCBICOBM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PIFBNBODPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED40", Offset = "0xA0DB40", VA = "0x180A0ED40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAD0", Offset = "0xA0D8D0", VA = "0x180A0EAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EJPLFDCHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<LOFJHEPBONG, LOFJHEPBONG> KNEDFCIMPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA2F0", Offset = "0x7CB90F0", VA = "0x187CBA2F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CBCF20", Offset = "0x7CBBD20", VA = "0x187CBCF20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<LOFJHEPBONG, LOFJHEPBONG> EBMGPFKFGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA6A0", Offset = "0x7CB94A0", VA = "0x187CBA6A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB350", Offset = "0x7CBA150", VA = "0x187CBB350", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<LOFJHEPBONG, LOFJHEPBONG, LOFJHEPBONG> IEOEDHHJIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC2E0", Offset = "0x7CBB0E0", VA = "0x187CBC2E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD660", Offset = "0x7CBC460", VA = "0x187CBD660", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDD70", Offset = "0x7CBCB70", VA = "0x187CBDD70")]
	public EMPOMMDILON(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB600", Offset = "0x7CBA400", VA = "0x187CBB600", Slot = "12")]
	public void IANLJFINMMK(GameObject MMMAEDGEACA, JPFEEFLJGMJ GMDBEFLFKFA, BOPCNFFABJA HLDOEFCHGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9C80", Offset = "0x7CB8A80", VA = "0x187CB9C80", Slot = "26")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCED0", Offset = "0x7CBBCD0", VA = "0x187CBCED0", Slot = "22")]
	public bool OAEHMMFCBAP(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC830", Offset = "0x7CBB630", VA = "0x187CBC830")]
	private void MEPOPGLCMCJ(JBBGAMGOICI AKDAJLIOHNO, JBBGAMGOICI CIPKHFNKANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9310", Offset = "0x7CB8110", VA = "0x187CB9310")]
	private void CFLPPPMCDME(JBBGAMGOICI AKDAJLIOHNO, JBBGAMGOICI HJODCFIKOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB0F0", Offset = "0x7CB9EF0", VA = "0x187CBB0F0")]
	private void HKFKNPBNFON(JBBGAMGOICI AKDAJLIOHNO, JBBGAMGOICI HJODCFIKOEA, JBBGAMGOICI CIPKHFNKANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD250", Offset = "0x7CBC050", VA = "0x187CBD250")]
	private void OPGIEABPBGA(JBBGAMGOICI AKDAJLIOHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "13")]
	public void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBFD0", Offset = "0x7CBADD0", VA = "0x187CBBFD0", Slot = "14")]
	public void KEMEJJLNDFN(LOFJHEPBONG FOGLBBODFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "15")]
	public void NGPIMBAFGHP(LOFJHEPBONG FOGLBBODFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB900", Offset = "0x7CBA700", VA = "0x187CBB900", Slot = "17")]
	public void IGCCOBKMBNL(LOFJHEPBONG FOGLBBODFNF, LOFJHEPBONG EGLAKHLHFPB, Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBA60", Offset = "0x7CBA860", VA = "0x187CBBA60")]
	public void IGCCOBKMBNL(JBBGAMGOICI OBOFPKCKJOC, JBBGAMGOICI EGLAKHLHFPB, Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9280", Offset = "0x7CB8080", VA = "0x187CB9280")]
	public void BLEMPAMKKKF(LOFJHEPBONG FOGLBBODFNF, float HNMJCJFPGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBE70", Offset = "0x7CBAC70", VA = "0x187CBBE70", Slot = "18")]
	public void JKOHCGCBCOA(LOFJHEPBONG HHLJJEKFBCG, int PCDPGKKACFG, LOFJHEPBONG LNIMMCMHBBL, int CEKIHIAFBMD, Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA050", Offset = "0x7CB8E50", VA = "0x187CBA050")]
	private float EDIPIOIEAGL(JBBGAMGOICI OBOFPKCKJOC, JBBGAMGOICI BOGJJGPKPIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBD30", Offset = "0x7CBAB30", VA = "0x187CBBD30")]
	public void JKOHCGCBCOA(JBBGAMGOICI OBOFPKCKJOC, JBBGAMGOICI BOGJJGPKPIJ, Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL, bool CAECDCGBMBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9B10", Offset = "0x7CB8910", VA = "0x187CB9B10", Slot = "19")]
	public void CMACCBNFAOL(LOFJHEPBONG FOGLBBODFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCA40", Offset = "0x7CBB840", VA = "0x187CBCA40", Slot = "16")]
	public void NDALADOMKOK(LOFJHEPBONG FOGLBBODFNF, HashSet<LOFJHEPBONG> AOHKIMMCLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "20")]
	public HFFEILKEBJG HOALJHDOPPF(bool AFDFMLMIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "21")]
	public HFFEILKEBJG NBOOCFNJPOM(HashSet<Guid> ABGEMAMNMBF, bool AFDFMLMIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB890", Offset = "0x7CBA690", VA = "0x187CBB890", Slot = "23")]
	public void IGBJEJNNPJL(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA750", Offset = "0x7CB9550", VA = "0x187CBA750", Slot = "24")]
	public void HIAOHGLBKIJ(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9260", Offset = "0x7CB8060", VA = "0x187CB9260", Slot = "25")]
	public void BJLICLKHJNA(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC420", Offset = "0x7CBB220", VA = "0x187CBC420")]
	private void MEHHCENKPEN(JBBGAMGOICI OBOFPKCKJOC, JBBGAMGOICI BOGJJGPKPIJ, Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL, float HNMJCJFPGDA, bool CAECDCGBMBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA7C0", Offset = "0x7CB95C0", VA = "0x187CBA7C0")]
	private void HKDPPJKFCEB(JBBGAMGOICI OBOFPKCKJOC, JBBGAMGOICI JDMAEDJOOLD, Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB590", Offset = "0x7CBA390", VA = "0x187CBB590")]
	private void HNDIBPDJIDP(JBBGAMGOICI OBOFPKCKJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC390", Offset = "0x7CBB190", VA = "0x187CBC390")]
	[IteratorStateMachine(typeof(IPNODOCJAKH))]
	public IEnumerable<LOFJHEPBONG> LHIADNGLCFB(JBBGAMGOICI CBBNAACPEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDAC0", Offset = "0x7CBC8C0", VA = "0x187CBDAC0")]
	internal LOFJHEPBONG PMNJHNGMPPI(JBBGAMGOICI CBBNAACPEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBBA0", Offset = "0x7CBA9A0", VA = "0x187CBBBA0")]
	internal JBBGAMGOICI JDHHGCJGKCD(LOFJHEPBONG FOGLBBODFNF)
	{
		return default(JBBGAMGOICI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9530", Offset = "0x7CB8330", VA = "0x187CB9530")]
	private bool CIKMFBIMDLG(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA100", Offset = "0x7CB8F00", VA = "0x187CBA100")]
	private bool EIMPONFOPJI(OPHHACDDLLH DCBFDJKHMOJ, [Out] LOFJHEPBONG BOGJJGPKPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD710", Offset = "0x7CBC510", VA = "0x187CBD710")]
	private LOFJHEPBONG PMNJHNGMPPI(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD0C0", Offset = "0x7CBBEC0", VA = "0x187CBD0C0")]
	private LOFJHEPBONG OGDEHIOJMBG(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9E70", Offset = "0x7CB8C70", VA = "0x187CB9E70")]
	private LOFJHEPBONG ECDDHOKLAHD(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9AD0", Offset = "0x7CB88D0", VA = "0x187CB9AD0")]
	private static Guid CLHDNFBCOBM(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCFD0", Offset = "0x7CBBDD0", VA = "0x187CBCFD0")]
	private string OBEDBKKAAAJ(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA160", Offset = "0x7CB8F60", VA = "0x187CBA160")]
	private void ELCBDEJFAMN(LOFJHEPBONG OBOFPKCKJOC, LOFJHEPBONG JDMAEDJOOLD, RigidTransform JGDALGAMEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB400", Offset = "0x7CBA200", VA = "0x187CBB400")]
	private void HLNIIOCHAEB(LOFJHEPBONG JDMAEDJOOLD, LOFJHEPBONG OBOFPKCKJOC, RigidTransform JGDALGAMEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA3A0", Offset = "0x7CB91A0", VA = "0x187CBA3A0")]
	private void FHAAKJLJKKE(LOFJHEPBONG MKDELEMEDEO, LOFJHEPBONG OBOFPKCKJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA510", Offset = "0x7CB9310", VA = "0x187CBA510")]
	private void GIJEGMHHBAO(LOFJHEPBONG OBOFPKCKJOC, LOFJHEPBONG BOGJJGPKPIJ, RigidTransform JGDALGAMEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA400", Offset = "0x7CB9200", VA = "0x187CBA400")]
	private void FJIOLAAGCJF(JBBGAMGOICI CBBNAACPEGP, LOFJHEPBONG FOGLBBODFNF, JBBGAMGOICI HJODCFIKOEA, JBBGAMGOICI CIPKHFNKANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCC50", Offset = "0x7CBBA50", VA = "0x187CBCC50")]
	private void NLMOGCFHIIO(JBBGAMGOICI CBBNAACPEGP, LOFJHEPBONG FOGLBBODFNF, LOFJHEPBONG EJLAPGBADPB, LOFJHEPBONG CGLAMIGJBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HMAPGMKNKNB
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CJOHOLCDILM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NAELDDAANND container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CJOHOLCDILM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8E10", Offset = "0x7CB7C10", VA = "0x187CB8E10")]
		internal EMPOMMDILON HONCAKEMONI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CC0220", Offset = "0x7CBF020", VA = "0x187CC0220")]
	public static void LNFAFCIIOHN(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CC01D0", Offset = "0x7CBEFD0", VA = "0x187CC01D0")]
	public static void IANHFMILLDF(NAELDDAANND AHGNCOFKLHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KPLOGIKCMGP : BJIIDJEIDEG, CDBCCOFDEEH
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly EMPOMMDILON KLPGCBNKFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly MJPMNOBADJE LENBJPKKBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly KDFOIJAGIKG LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly JFLFHPLFCFG[] CGKBNGLEBNM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LOFJHEPBONG IEBEOODPEAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6EC0", Offset = "0x7CC5CC0", VA = "0x187CC6EC0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LOFJHEPBONG KICFIPGOBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5FD0", Offset = "0x7CC4DD0", VA = "0x187CC5FD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 JINAIPGLIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5410", Offset = "0x7CC4210", VA = "0x187CC5410", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion JHCODDHAIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6930", Offset = "0x7CC5730", VA = "0x187CC6930", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OIMDLCLKDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5B50", Offset = "0x7CC4950", VA = "0x187CC5B50", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<LOFJHEPBONG> DGMELPBFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6350", Offset = "0x7CC5150", VA = "0x187CC6350", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool LOBHPBOOHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC3A4C0", Offset = "0xC392C0", VA = "0x180C3A4C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC6F4E0", Offset = "0xC6E2E0", VA = "0x180C6F4E0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7CC70D0", Offset = "0x7CC5ED0", VA = "0x187CC70D0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject DIBJMNKHENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6DD0", Offset = "0x7CC5BD0", VA = "0x187CC6DD0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6DF0", Offset = "0x7CC5BF0", VA = "0x187CC6DF0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid EDIDJKNBEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6F20", Offset = "0x7CC5D20", VA = "0x187CC6F20", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HFBAMIKFMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7000", Offset = "0x7CC5E00", VA = "0x187CC7000", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FDLLKCEFGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool NDCGCAPKDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7CC53C0", Offset = "0x7CC41C0", VA = "0x187CC53C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event NNEDLMKMCMA BEONNCMDPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7CC68D0", Offset = "0x7CC56D0", VA = "0x187CC68D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6090", Offset = "0x7CC4E90", VA = "0x187CC6090", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NNEDLMKMCMA ACAMAEGCFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7CC52C0", Offset = "0x7CC40C0", VA = "0x187CC52C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7CC60F0", Offset = "0x7CC4EF0", VA = "0x187CC60F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NNEDLMKMCMA LPONBEIAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6750", Offset = "0x7CC5550", VA = "0x187CC6750", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7CC66A0", Offset = "0x7CC54A0", VA = "0x187CC66A0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event NDKPBBPPJHP KAGPIHBPKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5320", Offset = "0x7CC4120", VA = "0x187CC5320", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6400", Offset = "0x7CC5200", VA = "0x187CC6400", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6CD0", Offset = "0x7CC5AD0", VA = "0x187CC6CD0")]
	public KPLOGIKCMGP(JBBGAMGOICI NIFNCNHCJID, RigidbodyEx OEGPMEHPDFC, MJPMNOBADJE LENBJPKKBNG, JFLFHPLFCFG[] CGKBNGLEBNM, KDFOIJAGIKG LKIBPKBGCOO, CGGFBEGKHOF KLPGCBNKFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7CC63D0", Offset = "0x7CC51D0", VA = "0x187CC63D0", Slot = "19")]
	public void IKNOEPKPIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "21")]
	public void JHKCCHPGPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B1F0", Offset = "0x7A29FF0", VA = "0x187A2B1F0", Slot = "22")]
	public void DFBDDDOOJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5470", Offset = "0x7CC4270", VA = "0x187CC5470", Slot = "20")]
	public void CBHIJBFDGNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6990", Offset = "0x7CC5790", VA = "0x187CC6990", Slot = "25")]
	public void PFLJJOCOLFH(int FNKJBHGFEHM, LOFJHEPBONG LNIMMCMHBBL, int HLIIKIECDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CC67B0", Offset = "0x7CC55B0", VA = "0x187CC67B0", Slot = "26")]
	public void MBACACFJMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC57D0", Offset = "0x7CC45D0", VA = "0x187CC57D0", Slot = "27")]
	public void CLFNKNBAOOD(int FNKJBHGFEHM, LOFJHEPBONG HHLJJEKFBCG, int AJIFIGCHMJK, [Optional] Vector3? PFHHEPHFLHF, [Optional] Quaternion? ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6BA0", Offset = "0x7CC59A0", VA = "0x187CC6BA0", Slot = "28")]
	public void PLGMBJDEPPG(LOFJHEPBONG HHLJJEKFBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5BC0", Offset = "0x7CC49C0", VA = "0x187CC5BC0", Slot = "31")]
	public void FAKPHLFNJHD(Vector3 CNNDAKBKGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7CC54C0", Offset = "0x7CC42C0", VA = "0x187CC54C0", Slot = "29")]
	public void CDKFOENAEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CC64A0", Offset = "0x7CC52A0", VA = "0x187CC64A0", Slot = "30")]
	public void ILKJJDDLMIB(int GLAOLHCPLLG, Vector3 HAMOKFILEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6280", Offset = "0x7CC5080", VA = "0x187CC6280", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int FNKJBHGFEHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6150", Offset = "0x7CC4F50", VA = "0x187CC6150", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int FNKJBHGFEHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xC17CF0", Offset = "0xC16AF0", VA = "0x180C17CF0", Slot = "42")]
	public Color GetConnectionSlotColor(int FNKJBHGFEHM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5AB0", Offset = "0x7CC48B0", VA = "0x187CC5AB0", Slot = "43")]
	public bool CanConnectTo(int FNKJBHGFEHM, LOFJHEPBONG FDKFAPHEHHJ, int LOONPLDDFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "44")]
	public void ParentChanged(int FNKJBHGFEHM, LOFJHEPBONG LOGJFOCAPGD, int CJCAGIKEHNE, Vector3 LDEANICNFAN, Quaternion FIHJNFJNAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "45")]
	public void ChildAdded(int FNKJBHGFEHM, LOFJHEPBONG FCPCMGGJMBM, int BOMAOHNDIDC, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "46")]
	public void ChildRemoved(int FNKJBHGFEHM, LOFJHEPBONG OAKJOHLCKLD, int MLNOABICEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "47")]
	public void ConnectionModified(int FNKJBHGFEHM, LOFJHEPBONG LNIMMCMHBBL, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6C20", Offset = "0x7CC5A20", VA = "0x187CC6C20", Slot = "48")]
	public void RootChanged(LOFJHEPBONG FMAOJDFNCML, LOFJHEPBONG HKNEGMNIJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6880", Offset = "0x7CC5680", VA = "0x187CC6880", Slot = "23")]
	public void MCLCMPAHCLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6380", Offset = "0x7CC5180", VA = "0x187CC6380", Slot = "24")]
	public void HNGCHEDAMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6700", Offset = "0x7CC5500", VA = "0x187CC6700")]
	private void JOBFEKIICJM(bool JDIOGJIOBMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(PMINGLOBABF), new string[] { })]
public class CMNPGNDFCAC : PMINGLOBABF, AHDIFPEGPEL, FAGFKOAOOFH
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PELBNOANNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PELBNOANNMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private AIKNHHAADNB NMFFKEACGFO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object DFJOFDLIJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8F10", Offset = "0x7CB7D10", VA = "0x187CB8F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8EC0", Offset = "0x7CB7CC0", VA = "0x187CB8EC0", Slot = "5")]
	private void KHEDDOBEPFG(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x118AF40", Offset = "0x1189D40", VA = "0x18118AF40", Slot = "6")]
	private void JLHNKKDCLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CMNPGNDFCAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(CGGFBEGKHOF), new string[] { "Ignore", "Mock" })]
public class JLNEMLCKKBN : CGGFBEGKHOF, IMNKKHLGPLB
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PIFBNBODPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EJPLFDCHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<LOFJHEPBONG, LOFJHEPBONG> KNEDFCIMPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4420", Offset = "0x7CC3220", VA = "0x187CC4420", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CC46E0", Offset = "0x7CC34E0", VA = "0x187CC46E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<LOFJHEPBONG, LOFJHEPBONG> EBMGPFKFGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7CC44D0", Offset = "0x7CC32D0", VA = "0x187CC44D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4580", Offset = "0x7CC3380", VA = "0x187CC4580", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<LOFJHEPBONG, LOFJHEPBONG, LOFJHEPBONG> IEOEDHHJIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4630", Offset = "0x7CC3430", VA = "0x187CC4630", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4790", Offset = "0x7CC3590", VA = "0x187CC4790", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "26")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "12")]
	public void IANLJFINMMK(GameObject MMMAEDGEACA, JPFEEFLJGMJ GMDBEFLFKFA, BOPCNFFABJA EDMNNKNAJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "13")]
	public void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "14")]
	public void KEMEJJLNDFN(LOFJHEPBONG FOGLBBODFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "15")]
	public void NGPIMBAFGHP(LOFJHEPBONG FOGLBBODFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "16")]
	public void NDALADOMKOK(LOFJHEPBONG FOGLBBODFNF, HashSet<LOFJHEPBONG> AOHKIMMCLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "17")]
	public void IGCCOBKMBNL(LOFJHEPBONG FOGLBBODFNF, LOFJHEPBONG EGLAKHLHFPB, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "18")]
	public void JKOHCGCBCOA(LOFJHEPBONG FOGLBBODFNF, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "19")]
	public void CMACCBNFAOL(LOFJHEPBONG FOGLBBODFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "20")]
	public HFFEILKEBJG HOALJHDOPPF(bool AFDFMLMIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "21")]
	public HFFEILKEBJG NBOOCFNJPOM(HashSet<Guid> ABGEMAMNMBF, bool AFDFMLMIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "22")]
	public bool OAEHMMFCBAP(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "23")]
	public void IGBJEJNNPJL(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "24")]
	public void HIAOHGLBKIJ(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "25")]
	public void BJLICLKHJNA(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public JLNEMLCKKBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LOFJHEPBONG : CDBCCOFDEEH, IEquatable<LOFJHEPBONG>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CDBCCOFDEEH
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	LOFJHEPBONG IEBEOODPEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject DIBJMNKHENG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid EDIDJKNBEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int HFBAMIKFMKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FDLLKCEFGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int FNKJBHGFEHM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int FNKJBHGFEHM);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int FNKJBHGFEHM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int FNKJBHGFEHM, LOFJHEPBONG FDKFAPHEHHJ, int EHKFDENJHMP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int FNKJBHGFEHM, LOFJHEPBONG LOGJFOCAPGD, int CJCAGIKEHNE, Vector3 LDEANICNFAN, Quaternion FIHJNFJNAMA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int FNKJBHGFEHM, LOFJHEPBONG FCPCMGGJMBM, int BOMAOHNDIDC, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int FNKJBHGFEHM, LOFJHEPBONG OAKJOHLCKLD, int MLNOABICEFL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int FNKJBHGFEHM, LOFJHEPBONG LNIMMCMHBBL, int MBHPNHGHCGN, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(LOFJHEPBONG FMAOJDFNCML, LOFJHEPBONG HKNEGMNIJJK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CGGFBEGKHOF : IMNKKHLGPLB
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PIFBNBODPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool EJPLFDCHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LOFJHEPBONG, LOFJHEPBONG> KNEDFCIMPMH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<LOFJHEPBONG, LOFJHEPBONG> EBMGPFKFGOG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<LOFJHEPBONG, LOFJHEPBONG, LOFJHEPBONG> IEOEDHHJIMF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IANLJFINMMK(GameObject MMMAEDGEACA, JPFEEFLJGMJ GMDBEFLFKFA, BOPCNFFABJA FODALMGOBKH);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JPEBABACHJL();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KEMEJJLNDFN(LOFJHEPBONG FOGLBBODFNF);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NGPIMBAFGHP(LOFJHEPBONG FOGLBBODFNF);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NDALADOMKOK(LOFJHEPBONG FOGLBBODFNF, HashSet<LOFJHEPBONG> AOHKIMMCLLA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IGCCOBKMBNL(LOFJHEPBONG FOGLBBODFNF, LOFJHEPBONG EGLAKHLHFPB, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JKOHCGCBCOA(LOFJHEPBONG FOGLBBODFNF, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CMACCBNFAOL(LOFJHEPBONG FOGLBBODFNF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HFFEILKEBJG HOALJHDOPPF(bool AFDFMLMIBHH);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	HFFEILKEBJG NBOOCFNJPOM(HashSet<Guid> ABGEMAMNMBF, bool AFDFMLMIBHH);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OAEHMMFCBAP(OPHHACDDLLH DCBFDJKHMOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IGBJEJNNPJL(HFFEILKEBJG DJNJGENDJMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HIAOHGLBKIJ(HFFEILKEBJG DJNJGENDJMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BJLICLKHJNA(HFFEILKEBJG DJNJGENDJMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PBDAMGFEFEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MPFMOGHFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LOFJHEPBONG ECDDHOKLAHD(int KFIAMAJIHGM);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LOFJHEPBONG OGDEHIOJMBG(Guid IGBHEKJBGIH);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JNKOEJBCAKE(LOFJHEPBONG FOGLBBODFNF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GPJKPJOKJOO();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JMFPKGDIAIO(LOFJHEPBONG LENBJPKKBNG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface KDFOIJAGIKG
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDCGCAPKDMI(MJPMNOBADJE LENBJPKKBNG);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GNCJDCFOBPP(MJPMNOBADJE LENBJPKKBNG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string MIHMCHOHHGJ(MJPMNOBADJE LENBJPKKBNG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid MCFCGJPDDGP(MJPMNOBADJE LENBJPKKBNG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LLKGBAIKCIH(MJPMNOBADJE LENBJPKKBNG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPGNDPGPNIM(MJPMNOBADJE LENBJPKKBNG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void NNEDLMKMCMA(LOFJHEPBONG HHLJJEKFBCG, int KDBGAPPPJOP, LOFJHEPBONG LNIMMCMHBBL, int ACBHPLGIIFN, [Optional] Vector3? PFHHEPHFLHF, [Optional] Quaternion? ODLAIJALNGJ);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void NDKPBBPPJHP(LOFJHEPBONG FMAOJDFNCML, LOFJHEPBONG HKNEGMNIJJK);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MJPMNOBADJE : LOFJHEPBONG, CDBCCOFDEEH, IEquatable<LOFJHEPBONG>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BJIIDJEIDEG : CDBCCOFDEEH
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LOFJHEPBONG KICFIPGOBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<LOFJHEPBONG> DGMELPBFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 JINAIPGLIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion JHCODDHAIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool OIMDLCLKDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LOBHPBOOHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event NNEDLMKMCMA BEONNCMDPKL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event NNEDLMKMCMA ACAMAEGCFIH;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NNEDLMKMCMA LPONBEIAHGL;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event NDKPBBPPJHP KAGPIHBPKMN;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IKNOEPKPIAO();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CBHIJBFDGNG();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JHKCCHPGPAK();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DFBDDDOOJGH();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MCLCMPAHCLM();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HNGCHEDAMDE();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PFLJJOCOLFH(int FNKJBHGFEHM, LOFJHEPBONG LNIMMCMHBBL, int HLIIKIECDOL);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MBACACFJMFN();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void CLFNKNBAOOD(int FNKJBHGFEHM, LOFJHEPBONG HHLJJEKFBCG, int AJIFIGCHMJK, [Optional] Vector3? PFHHEPHFLHF, [Optional] Quaternion? ODLAIJALNGJ);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PLGMBJDEPPG(LOFJHEPBONG HHLJJEKFBCG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CDKFOENAEJE();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ILKJJDDLMIB(int GLAOLHCPLLG, Vector3 HAMOKFILEGG);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FAKPHLFNJHD(Vector3 CNNDAKBKGNF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JFLFHPLFCFG
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 JMAIPLNIPLO
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
public interface JPFEEFLJGMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool AJJJNLIOKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	BBOMNMNOGML NFDIAJADECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, JPFEEFLJGMJ
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
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0C50", VA = "0x180AC1E50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public BBOMNMNOGML LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7CB9010", Offset = "0x7CB7E10", VA = "0x187CB9010")]
		public static ConnectableConfigData EOKAFBBBOJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7CB90D0", Offset = "0x7CB7ED0", VA = "0x187CB90D0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual BNEIJGIEMPB, bool CIBLIBNCNNC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PLIPLIAFJDH : IEquatable<PLIPLIAFJDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LOFJHEPBONG FOGLBBODFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int DNPDDCMEHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int MBHPNHGHCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 PFHHEPHFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion ODLAIJALNGJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD690", Offset = "0x7CCC490", VA = "0x187CCD690")]
	public PLIPLIAFJDH(LOFJHEPBONG FOGLBBODFNF, int DNPDDCMEHGG, int MBHPNHGHCGN, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD6F0", Offset = "0x7CCC4F0", VA = "0x187CCD6F0")]
	public PLIPLIAFJDH(LOFJHEPBONG FOGLBBODFNF, int DNPDDCMEHGG, int MBHPNHGHCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD790", Offset = "0x7CCC590", VA = "0x187CCD790")]
	public PLIPLIAFJDH(LOFJHEPBONG FOGLBBODFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD220", Offset = "0x7CCC020", VA = "0x187CCD220", Slot = "4")]
	public bool Equals(PLIPLIAFJDH HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD2D0", Offset = "0x7CCC0D0", VA = "0x187CCD2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class EJOHHIOLOAP : JDFEBGLMCCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform MAAFBDAKBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private BBOMNMNOGML MHCOIILGPND;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x76A0BE0", Offset = "0x769F9E0", VA = "0x1876A0BE0", Slot = "4")]
	public void IANLJFINMMK(Transform MAAFBDAKBJA, BBOMNMNOGML MHCOIILGPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9120", Offset = "0x7CB7F20", VA = "0x187CB9120", Slot = "5")]
	public BBOMNMNOGML JLOPOCDHIMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7CB91F0", Offset = "0x7CB7FF0", VA = "0x187CB91F0", Slot = "6")]
	public void PGAAOHPFIAI(BBOMNMNOGML MGLNJMBNOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public EJOHHIOLOAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class NNOJANMHAEL : IDisposable, LIEAKPOBFOP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FIMHFOIDNLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LOFJHEPBONG oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public LOFJHEPBONG newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FIMHFOIDNLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE020", Offset = "0x7CBCE20", VA = "0x187CBE020")]
		internal bool GGHPJDJDJOP(PIOLFGCIACO node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly ODEPLJOKKDG DOCAMEPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private FNOAMCEBHMA JLGKAEKBCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private IIPILADFFML ELMBDFGIJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool CIBLIBNCNNC;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly IEBEPMGFCGH ELHHCDDBLDH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public PIOLFGCIACO NLFMPGFBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB530", Offset = "0x7CCA330", VA = "0x187CCB530")]
	public bool OHKAGNBNFCD([In] JOJOAAOHMJD FFEMKICJPKP, bool GAPEOPFPJLP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7CCAE80", Offset = "0x7CC9C80", VA = "0x187CCAE80")]
	private bool IJLDODBLFCM([In] JOJOAAOHMJD FFEMKICJPKP, bool GAPEOPFPJLP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC2A0", Offset = "0x7CCB0A0", VA = "0x187CCC2A0")]
	public NNOJANMHAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7CCAB80", Offset = "0x7CC9980", VA = "0x187CCAB80", Slot = "5")]
	public void IANLJFINMMK(CGGFBEGKHOF HBNPNMJNNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9590", Offset = "0x7CC8390", VA = "0x187CC9590", Slot = "17")]
	public void BGBHHLODFGE(CBDCMIFELDG LDLIMOGOGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA930", Offset = "0x7CC9730", VA = "0x187CCA930", Slot = "12")]
	public void HMCOMDJDFNJ(Func<LOFJHEPBONG, bool> MNFIHMBIAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA800", Offset = "0x7CC9600", VA = "0x187CCA800")]
	private void HMCOMDJDFNJ(ODEPLJOKKDG BINEDJHADMC, Func<LOFJHEPBONG, bool> MNFIHMBIAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9720", Offset = "0x7CC8520", VA = "0x187CC9720", Slot = "11")]
	public void DCBOPHLNCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC1C0", Offset = "0x7CCAFC0", VA = "0x187CCC1C0", Slot = "8")]
	public bool PCCCPFOGFOM(LOFJHEPBONG BBENGALGIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9BE0", Offset = "0x7CC89E0", VA = "0x187CC9BE0")]
	private bool GDADJCDIBJB(LOFJHEPBONG CEBICEILDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC110", Offset = "0x7CCAF10", VA = "0x187CCC110")]
	private static bool OCDFMBJGNOM(LOFJHEPBONG CEBICEILDIJ, ODEPLJOKKDG KCHCPILIBBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7CCBB70", Offset = "0x7CCA970", VA = "0x187CCBB70")]
	private void NHMNGPFMFMC(Transform HFLFCIJCAGN, ODEPLJOKKDG PPGDHGPHEDG, ODEPLJOKKDG[] LMJEMAGPMAC, LOFJHEPBONG EILBHBEMEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB670", Offset = "0x7CCA470", VA = "0x187CCB670")]
	private PLIPLIAFJDH MGGJHMOAMGK(Transform PAGNOHDCAEC, PLIPLIAFJDH GODJOMCOENJ)
	{
		return default(PLIPLIAFJDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA3B0", Offset = "0x7CC91B0", VA = "0x187CCA3B0")]
	private static bool HCJBBKPMGCM(ODEPLJOKKDG KCHCPILIBBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB610", Offset = "0x7CCA410", VA = "0x187CCB610", Slot = "9")]
	public bool MCHEOBHAFLN(LOFJHEPBONG GMGGPCLLJDC, int AJIFIGCHMJK, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7CCAC30", Offset = "0x7CC9A30", VA = "0x187CCAC30")]
	private bool IAPCIOBMEGE(LOFJHEPBONG GMGGPCLLJDC, int AJIFIGCHMJK, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9860", Offset = "0x7CC8660", VA = "0x187CC9860")]
	private static void FCIEOKDOHHL(LOFJHEPBONG GMGGPCLLJDC, int AJIFIGCHMJK, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ, ODEPLJOKKDG LHIBLKACHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9740", Offset = "0x7CC8540", VA = "0x187CC9740")]
	private void ELCBDEJFAMN(LOFJHEPBONG PEKHPPEPDHE, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB4C0", Offset = "0x7CCA2C0", VA = "0x187CCB4C0")]
	private void KAEOFBIDAPC(ODEPLJOKKDG BINEDJHADMC, LOFJHEPBONG EJLAPGBADPB, LOFJHEPBONG CGLAMIGJBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB450", Offset = "0x7CCA250", VA = "0x187CCB450")]
	private void KAEOFBIDAPC(LOFJHEPBONG FOGLBBODFNF, LOFJHEPBONG EJLAPGBADPB, LOFJHEPBONG CGLAMIGJBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC0A0", Offset = "0x7CCAEA0", VA = "0x187CCC0A0")]
	private void NLMOGCFHIIO(LOFJHEPBONG FOGLBBODFNF, LOFJHEPBONG EJLAPGBADPB, LOFJHEPBONG CGLAMIGJBHH, bool NJJAGMMDHEC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7CCBFA0", Offset = "0x7CCADA0", VA = "0x187CCBFA0")]
	private void NLMOGCFHIIO(ODEPLJOKKDG IPCOMOHMNHK, LOFJHEPBONG EILBHBEMEEO, LOFJHEPBONG HKNEGMNIJJK, bool NJJAGMMDHEC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA6E0", Offset = "0x7CC94E0", VA = "0x187CCA6E0")]
	private void HLNIIOCHAEB(LOFJHEPBONG OBOFPKCKJOC, int AJIFIGCHMJK, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7CC99E0", Offset = "0x7CC87E0", VA = "0x187CC99E0")]
	private void FHAAKJLJKKE(PIOLFGCIACO BOGJJGPKPIJ, PIOLFGCIACO NIIJBJHMBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7CC95C0", Offset = "0x7CC83C0", VA = "0x187CC95C0", Slot = "18")]
	public LOFJHEPBONG CNFMEFNFEAK(LOFJHEPBONG FOGLBBODFNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB7C0", Offset = "0x7CCA5C0", VA = "0x187CCB7C0", Slot = "13")]
	public void NDALADOMKOK(LOFJHEPBONG FOGLBBODFNF, HashSet<LOFJHEPBONG> OMLPBKNNHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA940", Offset = "0x7CC9740", VA = "0x187CCA940", Slot = "14")]
	public List<LOFJHEPBONG> IAKMLIBNALD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB540", Offset = "0x7CCA340", VA = "0x187CCB540")]
	protected PIOLFGCIACO KOGAHLLAGDG(PIOLFGCIACO BINEDJHADMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9B40", Offset = "0x7CC8940", VA = "0x187CC9B40")]
	protected ODEPLJOKKDG[] FNNHJLGNPMO(ODEPLJOKKDG KCHCPILIBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA5D0", Offset = "0x7CC93D0", VA = "0x187CCA5D0")]
	protected bool HIHMOGKJJAC(LOFJHEPBONG FOGLBBODFNF, [Out] ODEPLJOKKDG BINEDJHADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8EB0", Offset = "0x7CC7CB0", VA = "0x187CC8EB0", Slot = "15")]
	public bool BEHKBNOEBMP(LOFJHEPBONG FOGLBBODFNF, [Out] PLIPLIAFJDH PKFOKDIPHAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7CCBF60", Offset = "0x7CCAD60", VA = "0x187CCBF60")]
	protected ODEPLJOKKDG NILKBMJPFNA(PLIPLIAFJDH IPGADBHABIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA570", Offset = "0x7CC9370", VA = "0x187CCA570", Slot = "10")]
	public bool HCKFOEJAIMJ(LOFJHEPBONG PEKHPPEPDHE, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8FE0", Offset = "0x7CC7DE0", VA = "0x187CC8FE0")]
	private bool BFCNCCHBKDK(LOFJHEPBONG PEKHPPEPDHE, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA2E0", Offset = "0x7CC90E0", VA = "0x187CCA2E0")]
	private static bool GICJIEPGPJF(ODEPLJOKKDG MKHEGJJPLCD, PLIPLIAFJDH LBBOFFKCNAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB530", Offset = "0x7CCA330", VA = "0x187CCB530", Slot = "7")]
	private bool KMLOFBJJMBI([In] JOJOAAOHMJD FFEMKICJPKP, bool GAPEOPFPJLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class GDOCGONAGGG : CGGFBEGKHOF, IMNKKHLGPLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly NAELDDAANND AHGNCOFKLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly IIPILADFFML ELMBDFGIJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly JBFBOMJHEKD HNLIDDLFHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly IEBNKMFMBOD FOFAOBNEIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly LIEAKPOBFOP DJNJGENDJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal GJHCLODOABG LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal IJHLOKMOBHE KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal FNOAMCEBHMA NKBGJABFJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool CIBLIBNCNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool ENJMMPMBCIO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool JJMFINKCGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xC1FAC0", Offset = "0xC1E8C0", VA = "0x180C1FAC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x12BFF20", Offset = "0x12BED20", VA = "0x1812BFF20")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PIFBNBODPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1172520", Offset = "0x1171320", VA = "0x181172520", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2631A30", Offset = "0x2630830", VA = "0x182631A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool EJPLFDCHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LOFJHEPBONG, LOFJHEPBONG> KNEDFCIMPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE530", Offset = "0x7CBD330", VA = "0x187CBE530", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFD20", Offset = "0x7CBEB20", VA = "0x187CBFD20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LOFJHEPBONG, LOFJHEPBONG> EBMGPFKFGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE590", Offset = "0x7CBD390", VA = "0x187CBE590", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE7E0", Offset = "0x7CBD5E0", VA = "0x187CBE7E0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LOFJHEPBONG, LOFJHEPBONG, LOFJHEPBONG> IEOEDHHJIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF630", Offset = "0x7CBE430", VA = "0x187CBF630", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFD80", Offset = "0x7CBEB80", VA = "0x187CBFD80", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBFDE0", Offset = "0x7CBEBE0", VA = "0x187CBFDE0")]
	public GDOCGONAGGG(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEBA0", Offset = "0x7CBD9A0", VA = "0x187CBEBA0", Slot = "12")]
	public void IANLJFINMMK(GameObject MMMAEDGEACA, JPFEEFLJGMJ GMDBEFLFKFA, BOPCNFFABJA FODALMGOBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE460", Offset = "0x7CBD260", VA = "0x187CBE460", Slot = "26")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF590", Offset = "0x7CBE390", VA = "0x187CBF590", Slot = "13")]
	public void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF610", Offset = "0x7CBE410", VA = "0x187CBF610", Slot = "14")]
	public void KEMEJJLNDFN(LOFJHEPBONG FOGLBBODFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE0E0", Offset = "0x7CBCEE0", VA = "0x187CBE0E0", Slot = "15")]
	public void NGPIMBAFGHP(LOFJHEPBONG FOGLBBODFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7CBFCD0", Offset = "0x7CBEAD0", VA = "0x187CBFCD0", Slot = "22")]
	public bool OAEHMMFCBAP(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE140", Offset = "0x7CBCF40", VA = "0x187CBE140")]
	internal bool BFCNCCHBKDK([In] JOJOAAOHMJD FFEMKICJPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF690", Offset = "0x7CBE490", VA = "0x187CBF690")]
	internal bool LILCKLMKEOE([In] JOJOAAOHMJD FFEMKICJPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE840", Offset = "0x7CBD640", VA = "0x187CBE840")]
	internal void HNCCPOCFLEN(LOFJHEPBONG FOGLBBODFNF, int ECHHDCLBCBP, bool GAPEOPFPJLP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE0E0", Offset = "0x7CBCEE0", VA = "0x187CBE0E0")]
	internal bool BEEBGHLNIIL(LOFJHEPBONG GKADPNILOBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE6A0", Offset = "0x7CBD4A0", VA = "0x187CBE6A0")]
	internal bool HJJHLMADNPE(LOFJHEPBONG GMGGPCLLJDC, int AJIFIGCHMJK, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF980", Offset = "0x7CBE780", VA = "0x187CBF980", Slot = "16")]
	public void NDALADOMKOK(LOFJHEPBONG FOGLBBODFNF, HashSet<LOFJHEPBONG> AOHKIMMCLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF240", Offset = "0x7CBE040", VA = "0x187CBF240", Slot = "17")]
	public void IGCCOBKMBNL(LOFJHEPBONG GMGGPCLLJDC, LOFJHEPBONG EGLAKHLHFPB, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF450", Offset = "0x7CBE250", VA = "0x187CBF450", Slot = "18")]
	public void JKOHCGCBCOA(LOFJHEPBONG PEKHPPEPDHE, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE290", Offset = "0x7CBD090", VA = "0x187CBE290", Slot = "19")]
	public void CMACCBNFAOL(LOFJHEPBONG PEKHPPEPDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBFA80", Offset = "0x7CBE880", VA = "0x187CBFA80")]
	public void NELBIAGEBJL([Optional] AHNIMKBJLEJ NJJLCNCCCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF1B0", Offset = "0x7CBDFB0", VA = "0x187CBF1B0", Slot = "23")]
	public void IGBJEJNNPJL(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEA20", Offset = "0x7CBD820", VA = "0x187CBEA20", Slot = "20")]
	public HFFEILKEBJG HOALJHDOPPF(bool AFDFMLMIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF7E0", Offset = "0x7CBE5E0", VA = "0x187CBF7E0", Slot = "21")]
	public HFFEILKEBJG NBOOCFNJPOM(HashSet<Guid> ABGEMAMNMBF, bool AFDFMLMIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE250", Offset = "0x7CBD050", VA = "0x187CBE250", Slot = "25")]
	public void BJLICLKHJNA(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE5F0", Offset = "0x7CBD3F0", VA = "0x187CBE5F0", Slot = "24")]
	public void HIAOHGLBKIJ(HFFEILKEBJG DJNJGENDJMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class IIPILADFFML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly DPJKFCBILHL<LOFJHEPBONG, LOFJHEPBONG> KNEDFCIMPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly DPJKFCBILHL<LOFJHEPBONG, LOFJHEPBONG> EBMGPFKFGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly NAHDPOOOHFB<LOFJHEPBONG, LOFJHEPBONG, LOFJHEPBONG> IEOEDHHJIMF;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3960", Offset = "0x7CC2760", VA = "0x187CC3960")]
	public IIPILADFFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	public void IANLJFINMMK(GDOCGONAGGG HBNPNMJNNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3820", Offset = "0x7CC2620", VA = "0x187CC3820")]
	public void HJOKEBJGNJJ(LOFJHEPBONG BOGJJGPKPIJ, LOFJHEPBONG OBOFPKCKJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3900", Offset = "0x7CC2700", VA = "0x187CC3900")]
	public void NIDKLLNPPEO(LOFJHEPBONG BOGJJGPKPIJ, LOFJHEPBONG OBOFPKCKJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3880", Offset = "0x7CC2680", VA = "0x187CC3880")]
	public void JEDMCAPAALD(LOFJHEPBONG MKDELEMEDEO, LOFJHEPBONG JDMAEDJOOLD, LOFJHEPBONG OBOFPKCKJOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class JBFBOMJHEKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private GDOCGONAGGG HBNPNMJNNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private IJHLOKMOBHE KLBDPNGJELI;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public JBFBOMJHEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4080", Offset = "0x7CC2E80", VA = "0x187CC4080")]
	public void IANLJFINMMK(GDOCGONAGGG HBNPNMJNNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4000", Offset = "0x7CC2E00", VA = "0x187CC4000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7CC42D0", Offset = "0x7CC30D0", VA = "0x187CC42D0")]
	private void KGIAJGMDPBK(HMJDCIMFIOA LCALHIDHIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4010", Offset = "0x7CC2E10", VA = "0x187CC4010")]
	private void FDJAPPFCHOE(AHNIMKBJLEJ OCMOPICGOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4310", Offset = "0x7CC3110", VA = "0x187CC4310")]
	public void OAHBCBLNPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7CC41C0", Offset = "0x7CC2FC0", VA = "0x187CC41C0")]
	public void JFIKDDJIOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PGCIDGNBIJI
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ADNOPLIJOOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NAELDDAANND container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ADNOPLIJOOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8DA0", Offset = "0x7CB7BA0", VA = "0x187CB8DA0")]
		internal GDOCGONAGGG HONCAKEMONI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD020", Offset = "0x7CCBE20", VA = "0x187CCD020")]
	public static void LNFAFCIIOHN(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCFA0", Offset = "0x7CCBDA0", VA = "0x187CCCFA0")]
	public static void IANHFMILLDF(NAELDDAANND AHGNCOFKLHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class HPBEFAHFKGL : IDisposable, FNOAMCEBHMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, BBOMNMNOGML> LKEBBEHKIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly CBDCMIFELDG GBNNBINGBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private JDFEBGLMCCE NIEDOFANOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private LIEAKPOBFOP DJNJGENDJMJ;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker IOOKIOLFAEO;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1030", Offset = "0x7CBFE30", VA = "0x187CC1030")]
	public HPBEFAHFKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7CC0AA0", Offset = "0x7CBF8A0", VA = "0x187CC0AA0", Slot = "7")]
	public void IANLJFINMMK(LIEAKPOBFOP DJNJGENDJMJ, JDFEBGLMCCE NIEDOFANOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7CC03A0", Offset = "0x7CBF1A0", VA = "0x187CC03A0", Slot = "5")]
	public void BFOILENDCEF(PIOLFGCIACO KAFOLKONDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7CC0930", Offset = "0x7CBF730", VA = "0x187CC0930", Slot = "9")]
	public void FFIMOKMEHIH(PIOLFGCIACO NOKEEMOPODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7CC0C90", Offset = "0x7CBFA90", VA = "0x187CC0C90", Slot = "8")]
	public void KKBDMJEHNIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7CC05E0", Offset = "0x7CBF3E0", VA = "0x187CC05E0", Slot = "10")]
	public void EBIFICCOOMF(PIOLFGCIACO BBOBPIEGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC0E50", Offset = "0x7CBFC50", VA = "0x187CC0E50", Slot = "11")]
	public void OIIBJLDHKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7CC0AE0", Offset = "0x7CBF8E0", VA = "0x187CC0AE0")]
	private bool KCCKIBFBLPM(PIOLFGCIACO KACKFEMGFCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class IEBNKMFMBOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct KLEEIIMDMIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly ODEPLJOKKDG BOOBLDEHHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> ABGEMAMNMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly OPHHACDDLLH LPHCLANPAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly OPHHACDDLLH OFAPPIJBIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool AFDFMLMIBHH;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool CEENKHKKHHI
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7CC5070", Offset = "0x7CC3E70", VA = "0x187CC5070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5250", Offset = "0x7CC4050", VA = "0x187CC5250")]
		public KLEEIIMDMIM(ODEPLJOKKDG BOOBLDEHHFA, HashSet<Guid> ABGEMAMNMBF, bool AFDFMLMIBHH, [Optional] OPHHACDDLLH LPHCLANPAMC, [Optional] OPHHACDDLLH OFAPPIJBIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4ED0", Offset = "0x7CC3CD0", VA = "0x187CC4ED0")]
		public OPHHACDDLLH KIDMEGDOMCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5190", Offset = "0x7CC3F90", VA = "0x187CC5190")]
		private OPHHACDDLLH OCABKBPMNOK([Out] OPHHACDDLLH CKHGPFIACKF, [Out] OPHHACDDLLH GIBOODJDMMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4AF0", Offset = "0x7CC38F0", VA = "0x187CC4AF0")]
		private OPHHACDDLLH BMFOCAKNFCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4980", Offset = "0x7CC3780", VA = "0x187CC4980")]
		private void AMPFMIJOOPF(OPHHACDDLLH DDKPOJPPODI, OPHHACDDLLH MLKFGCGKEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4D10", Offset = "0x7CC3B10", VA = "0x187CC4D10")]
		private void CBKIHBPKEGE(OPHHACDDLLH CKHGPFIACKF, OPHHACDDLLH GIBOODJDMMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private GDOCGONAGGG HBNPNMJNNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private LIEAKPOBFOP DJNJGENDJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private FNOAMCEBHMA JLGKAEKBCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private IJHLOKMOBHE KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool OACOHIPHLPE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool GMHAPAEFPIO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1D40", Offset = "0x7CC0B40", VA = "0x187CC1D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool JJMFINKCGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7CC26A0", Offset = "0x7CC14A0", VA = "0x187CC26A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1D20", Offset = "0x7CC0B20", VA = "0x187CC1D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1FA0", Offset = "0x7CC0DA0", VA = "0x187CC1FA0")]
	public void IANLJFINMMK(GDOCGONAGGG HBNPNMJNNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1E30", Offset = "0x7CC0C30", VA = "0x187CC1E30")]
	public HFFEILKEBJG HOALJHDOPPF(bool AFDFMLMIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2AC0", Offset = "0x7CC18C0", VA = "0x187CC2AC0")]
	public HFFEILKEBJG NBOOCFNJPOM(HashSet<Guid> ABGEMAMNMBF, bool AFDFMLMIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2290", Offset = "0x7CC1090", VA = "0x187CC2290")]
	public void IGBJEJNNPJL(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1D90", Offset = "0x7CC0B90", VA = "0x187CC1D90")]
	public void HIAOHGLBKIJ(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2320", Offset = "0x7CC1120", VA = "0x187CC2320")]
	public void JCABKPHMDMA(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2010", Offset = "0x7CC0E10", VA = "0x187CC2010")]
	private void IBHMJGJCDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2350", Offset = "0x7CC1150", VA = "0x187CC2350")]
	private OPHHACDDLLH JPPGPKLHDIJ(ODEPLJOKKDG BINEDJHADMC, bool AFDFMLMIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2870", Offset = "0x7CC1670", VA = "0x187CC2870")]
	private static void MLDEGLAJGPH(ODEPLJOKKDG BINEDJHADMC, bool AFDFMLMIBHH, OPHHACDDLLH DCBFDJKHMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2C60", Offset = "0x7CC1A60", VA = "0x187CC2C60")]
	private void NLFHHAHDKJH(ODEPLJOKKDG BINEDJHADMC, bool AFDFMLMIBHH, OPHHACDDLLH DCBFDJKHMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2200", Offset = "0x7CC1000", VA = "0x187CC2200")]
	private OPHHACDDLLH ICFNHOPHLMP(ODEPLJOKKDG BOOBLDEHHFA, HashSet<Guid> ABGEMAMNMBF, bool AFDFMLMIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1910", Offset = "0x7CC0710", VA = "0x187CC1910")]
	private bool DCOJIAOPEJF(HFFEILKEBJG KMDHPPCOEFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7CC12A0", Offset = "0x7CC00A0", VA = "0x187CC12A0")]
	private bool CIKMFBIMDLG(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7CC26C0", Offset = "0x7CC14C0", VA = "0x187CC26C0")]
	private bool LHIHJCGHLJC(HFFEILKEBJG DJNJGENDJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2580", Offset = "0x7CC1380", VA = "0x187CC2580")]
	private static bool KLAPNHLFOAN(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2E80", Offset = "0x7CC1C80", VA = "0x187CC2E80")]
	public static bool OAEHMMFCBAP(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3200", Offset = "0x7CC2000", VA = "0x187CC3200")]
	private LOFJHEPBONG PMNJHNGMPPI(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1BA0", Offset = "0x7CC09A0", VA = "0x187CC1BA0")]
	private LOFJHEPBONG ECDDHOKLAHD(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1110", Offset = "0x7CBFF10", VA = "0x187CC1110")]
	private LOFJHEPBONG BAPKBGIPABN(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9AD0", Offset = "0x7CB88D0", VA = "0x187CB9AD0")]
	private static Guid CLHDNFBCOBM(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3110", Offset = "0x7CC1F10", VA = "0x187CC3110")]
	private string OBEDBKKAAAJ(OPHHACDDLLH DCBFDJKHMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7CC26E0", Offset = "0x7CC14E0", VA = "0x187CC26E0")]
	private bool LJOKPHGKEKM(ODEPLJOKKDG BINEDJHADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3550", Offset = "0x7CC2350", VA = "0x187CC3550")]
	private static void PPDJOCBOKIJ(ODEPLJOKKDG BOOBLDEHHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IEBNKMFMBOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct JOJOAAOHMJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public LOFJHEPBONG OBOFPKCKJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public LOFJHEPBONG BOGJJGPKPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int AJIFIGCHMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int HLIIKIECDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 PFHHEPHFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion ODLAIJALNGJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public PLIPLIAFJDH OMFCHLCEFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4840", Offset = "0x7CC3640", VA = "0x187CC4840")]
		get
		{
			return default(PLIPLIAFJDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PLIPLIAFJDH BEKBBOKKCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7CC48E0", Offset = "0x7CC36E0", VA = "0x187CC48E0")]
		get
		{
			return default(PLIPLIAFJDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4910", Offset = "0x7CC3710", VA = "0x187CC4910")]
	public JOJOAAOHMJD(LOFJHEPBONG OBOFPKCKJOC, LOFJHEPBONG BOGJJGPKPIJ, int AJIFIGCHMJK, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface LIEAKPOBFOP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PIOLFGCIACO NLFMPGFBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IANLJFINMMK(CGGFBEGKHOF HBNPNMJNNHB);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OHKAGNBNFCD([In] JOJOAAOHMJD FFEMKICJPKP, bool GAPEOPFPJLP = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PCCCPFOGFOM(LOFJHEPBONG BBENGALGIPD);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MCHEOBHAFLN(LOFJHEPBONG GMGGPCLLJDC, int AJIFIGCHMJK, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HCKFOEJAIMJ(LOFJHEPBONG PEKHPPEPDHE, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCBOPHLNCOD();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HMCOMDJDFNJ(Func<LOFJHEPBONG, bool> MNFIHMBIAKH);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NDALADOMKOK(LOFJHEPBONG FOGLBBODFNF, HashSet<LOFJHEPBONG> OMLPBKNNHAL);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<LOFJHEPBONG> IAKMLIBNALD();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BEHKBNOEBMP(LOFJHEPBONG FOGLBBODFNF, [Out] PLIPLIAFJDH PKFOKDIPHAB);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BGBHHLODFGE(CBDCMIFELDG LDLIMOGOGBF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool CBDCMIFELDG(PIOLFGCIACO BINEDJHADMC);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface PIOLFGCIACO
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LOFJHEPBONG BDKJAMBKLCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PIOLFGCIACO DPEBHIBHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PLIPLIAFJDH AJEMOFMKHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HIKPFNOEKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BBOMNMNOGML
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLJFBNEKAGO(LOFJHEPBONG LNIMMCMHBBL, PLIPLIAFJDH OBOFPKCKJOC);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANFKPELALPG(LOFJHEPBONG LNIMMCMHBBL, PLIPLIAFJDH OBOFPKCKJOC);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLDCJOFGCOI(LOFJHEPBONG LNIMMCMHBBL, PLIPLIAFJDH OBOFPKCKJOC);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGNDLABCCND(LOFJHEPBONG LNIMMCMHBBL, PLIPLIAFJDH OBOFPKCKJOC);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BBOMNMNOGML Instantiate(Transform MAAFBDAKBJA);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCGBACPBOON();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JDFEBGLMCCE
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IANLJFINMMK(Transform MAAFBDAKBJA, BBOMNMNOGML MHCOIILGPND);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BBOMNMNOGML JLOPOCDHIMI();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGAAOHPFIAI(BBOMNMNOGML MGLNJMBNOPD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface GJHCLODOABG : PBDAMGFEFEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNJICCMOCCF();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PNBOJHIPHGC(Guid MLMMNGNEKMO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface FNOAMCEBHMA
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFOILENDCEF(PIOLFGCIACO KAFOLKONDJJ);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IANLJFINMMK(LIEAKPOBFOP DJNJGENDJMJ, JDFEBGLMCCE PGBGOIJILFA);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKBDMJEHNIJ();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFIMOKMEHIH(PIOLFGCIACO NOKEEMOPODJ);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EBIFICCOOMF(PIOLFGCIACO BBOBPIEGFPC);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OIIBJLDHKKE();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class ODEPLJOKKDG : PIOLFGCIACO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FGHHDOLLNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public PLIPLIAFJDH nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public ODEPLJOKKDG foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FGHHDOLLNLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDEE0", Offset = "0x7CBCCE0", VA = "0x187CBDEE0")]
		internal bool LLCPHAMNNBN(PIOLFGCIACO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private PLIPLIAFJDH PKFOKDIPHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<ODEPLJOKKDG> HDOMAGFGOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ODEPLJOKKDG INEPCAHCLLF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public PLIPLIAFJDH AJEMOFMKHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x12BF900", Offset = "0x12BE700", VA = "0x1812BF900", Slot = "6")]
		get
		{
			return default(PLIPLIAFJDH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x12C01F0", Offset = "0x12BEFF0", VA = "0x1812C01F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private ODEPLJOKKDG BOGJJGPKPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7CCCBC0", Offset = "0x7CCB9C0", VA = "0x187CCCBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PIOLFGCIACO DPEBHIBHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LOFJHEPBONG BDKJAMBKLCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HIKPFNOEKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CCC980", Offset = "0x7CCB780", VA = "0x187CCC980", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool HENDMEDLHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7CCC470", Offset = "0x7CCB270", VA = "0x187CCC470", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected ODEPLJOKKDG IPCOMOHMNHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CCC960", Offset = "0x7CCB760", VA = "0x187CCC960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCEF0", Offset = "0x7CCBCF0", VA = "0x187CCCEF0")]
	public ODEPLJOKKDG(PLIPLIAFJDH KCDANJENMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCDA0", Offset = "0x7CCBBA0", VA = "0x187CCCDA0")]
	public ODEPLJOKKDG OFKKBLFBGKA(PLIPLIAFJDH IDFDNKOPLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC990", Offset = "0x7CCB790", VA = "0x187CCC990")]
	public ODEPLJOKKDG JADHLKAAPNH(PLIPLIAFJDH IJPBMAEDNAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC780", Offset = "0x7CCB580", VA = "0x187CCC780")]
	public ODEPLJOKKDG FKCGDELNEED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC630", Offset = "0x7CCB430", VA = "0x187CCC630")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCB10", Offset = "0x7CCB910", VA = "0x187CCCB10")]
	public ODEPLJOKKDG LMDBPBKBEOE(PLIPLIAFJDH JDMAEDJOOLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC4C0", Offset = "0x7CCB2C0", VA = "0x187CCC4C0")]
	private static void BGBHHLODFGE(ODEPLJOKKDG OENHABKMMKI, CBDCMIFELDG GGHOJGJBMPF, bool EIJJOFFMMNK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC620", Offset = "0x7CCB420", VA = "0x187CCC620", Slot = "9")]
	public void BGBHHLODFGE(CBDCMIFELDG LDLIMOGOGBF, bool NJJAGMMDHEC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCCA0", Offset = "0x7CCBAA0", VA = "0x187CCCCA0")]
	public static ODEPLJOKKDG NILKBMJPFNA(ODEPLJOKKDG OENHABKMMKI, PLIPLIAFJDH OBKKHJJGJGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface IJHLOKMOBHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool GMHAPAEFPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool MPFMOGHFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<HMJDCIMFIOA> KGIAJGMDPBK;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<AHNIMKBJLEJ> FDJAPPFCHOE;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HLJFBNEKAGO(GDOCGONAGGG HBNPNMJNNHB, BOPCNFFABJA EDMNNKNAJJB);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IGCCOBKMBNL(LOFJHEPBONG GMGGPCLLJDC, LOFJHEPBONG EGLAKHLHFPB, int AJIFIGCHMJK, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JKOHCGCBCOA(LOFJHEPBONG PEKHPPEPDHE, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OPNGCPIGEKD(HFFEILKEBJG ALMEPAKFDIE, [Optional] AHNIMKBJLEJ NJJLCNCCCKF);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FEJGNIAEHIL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDE20", Offset = "0x7CBCC20", VA = "0x187CBDE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object ICOFMPPJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDDE0", Offset = "0x7CBCBE0", VA = "0x187CBDDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDE80", Offset = "0x7CBCC80", VA = "0x187CBDE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class LALNAFBACDE : IJHLOKMOBHE, IDisposable, MCNHCPEHJEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private GDOCGONAGGG HBNPNMJNNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private BOPCNFFABJA FODALMGOBKH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool GMHAPAEFPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7280", Offset = "0x7CC6080", VA = "0x187CC7280", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool MPFMOGHFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7660", Offset = "0x7CC6460", VA = "0x187CC7660", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView KJBAOMDIAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7CC75D0", Offset = "0x7CC63D0", VA = "0x187CC75D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<HMJDCIMFIOA> KGIAJGMDPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CC70F0", Offset = "0x7CC5EF0", VA = "0x187CC70F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7190", Offset = "0x7CC5F90", VA = "0x187CC7190", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<AHNIMKBJLEJ> FDJAPPFCHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CC76A0", Offset = "0x7CC64A0", VA = "0x187CC76A0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7740", Offset = "0x7CC6540", VA = "0x187CC7740", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7CC72E0", Offset = "0x7CC60E0", VA = "0x187CC72E0", Slot = "10")]
	public void HLJFBNEKAGO(GDOCGONAGGG HBNPNMJNNHB, BOPCNFFABJA FODALMGOBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7230", Offset = "0x7CC6030", VA = "0x187CC7230", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7370", Offset = "0x7CC6170", VA = "0x187CC7370", Slot = "11")]
	public void IGCCOBKMBNL(LOFJHEPBONG GMGGPCLLJDC, LOFJHEPBONG EGLAKHLHFPB, int AJIFIGCHMJK, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CC74A0", Offset = "0x7CC62A0", VA = "0x187CC74A0", Slot = "12")]
	public void JKOHCGCBCOA(LOFJHEPBONG PEKHPPEPDHE, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7CC77E0", Offset = "0x7CC65E0", VA = "0x187CC77E0", Slot = "13")]
	public void OPNGCPIGEKD(HFFEILKEBJG ALMEPAKFDIE, [Optional] AHNIMKBJLEJ NJJLCNCCCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7B50", Offset = "0x7CC6950", VA = "0x187CC7B50")]
	[AONLGKBOHJA]
	private void RpcMasterReparentNodes(LOFJHEPBONG PEKHPPEPDHE, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7950", Offset = "0x7CC6750", VA = "0x187CC7950")]
	[AONLGKBOHJA]
	private void RpcMasterModifyNode(LOFJHEPBONG GMGGPCLLJDC, LOFJHEPBONG EGLAKHLHFPB, int AJIFIGCHMJK, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7F50", Offset = "0x7CC6D50", VA = "0x187CC7F50")]
	[AONLGKBOHJA]
	private void RpcReparentNodes(LOFJHEPBONG PEKHPPEPDHE, int KIBAIGLOBEH, LOFJHEPBONG JDMAEDJOOLD, int CJCAGIKEHNE, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ, LFJEHFKMNHM OGEIFHBCCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7E60", Offset = "0x7CC6C60", VA = "0x187CC7E60")]
	[AONLGKBOHJA]
	private void RpcModifyNode(LOFJHEPBONG GMGGPCLLJDC, int AJIFIGCHMJK, int HLIIKIECDOL, Vector3 PFHHEPHFLHF, Quaternion ODLAIJALNGJ, LFJEHFKMNHM OGEIFHBCCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7910", Offset = "0x7CC6710", VA = "0x187CC7910")]
	[AONLGKBOHJA]
	private void RpcDeserializeConnectableGraph(HFFEILKEBJG DJNJGENDJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public LALNAFBACDE()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, BBOMNMNOGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8710", Offset = "0x7CC7510", VA = "0x187CC8710", Slot = "4")]
		private void PCAGHIAKOPN(LOFJHEPBONG LNIMMCMHBBL, PLIPLIAFJDH OBOFPKCKJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7CC81E0", Offset = "0x7CC6FE0", VA = "0x187CC81E0", Slot = "5")]
		private void BAHBHHHLBOJ(LOFJHEPBONG LNIMMCMHBBL, PLIPLIAFJDH OBOFPKCKJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8080", Offset = "0x7CC6E80", VA = "0x187CC8080", Slot = "6")]
		private void AFOKOJAPELG(LOFJHEPBONG LNIMMCMHBBL, PLIPLIAFJDH OBOFPKCKJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8520", Offset = "0x7CC7320", VA = "0x187CC8520", Slot = "7")]
		private void KEABBBIKIBJ(LOFJHEPBONG LNIMMCMHBBL, PLIPLIAFJDH OBOFPKCKJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8450", Offset = "0x7CC7250", VA = "0x187CC8450", Slot = "8")]
		private BBOMNMNOGML ENHMDMHPPBK(Transform MAAFBDAKBJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7CC84C0", Offset = "0x7CC72C0", VA = "0x187CC84C0", Slot = "9")]
		private void JFJNOCAMIEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DLFOHFEFIOM
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x375DA90", Offset = "0x375C890", VA = "0x18375DA90")]
	public static BLEHBLLPMLP<T> BEABFAKGKIC<T>(this NAELDDAANND AHGNCOFKLHK)
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
