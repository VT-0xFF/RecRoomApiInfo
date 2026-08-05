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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B595F0", Offset = "0x7B57BF0", VA = "0x187B595F0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B64240", Offset = "0x7B62840", VA = "0x187B64240", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B63DA0", Offset = "0x7B623A0", VA = "0x187B63DA0")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B63C30", Offset = "0x7B62230", VA = "0x187B63C30")]
		private void KMFPJCIAGGA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B63F10", Offset = "0x7B62510", VA = "0x187B63F10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B64280", Offset = "0x7B62880", VA = "0x187B64280")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class PBBABANPFCD : HAEKELLPJAC, MMMIGLKPHHG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class BGEODJEJKLG : IEnumerable<KGJNPMKJIIA>, IEnumerable, IEnumerator<KGJNPMKJIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private KGJNPMKJIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private PKENAFNLEAO localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PKENAFNLEAO <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public PBBABANPFCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private JFDGJOPOGFB <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private EPFJFEANHAG <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private EPFJFEANHAG.MJEICEPECDM <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private KGJNPMKJIIA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public BGEODJEJKLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F4E0", Offset = "0x7B4DAE0", VA = "0x187B4F4E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F060", Offset = "0x7B4D660", VA = "0x187B4F060", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F040", Offset = "0x7B4D640", VA = "0x187B4F040")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F3C0", Offset = "0x7B4D9C0", VA = "0x187B4F3C0")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F490", Offset = "0x7B4DA90", VA = "0x187B4F490", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F3E0", Offset = "0x7B4D9E0", VA = "0x187B4F3E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KGJNPMKJIIA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F3E0", Offset = "0x7B4D9E0", VA = "0x187B4F3E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ODFHNMNNIKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PBBABANPFCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public FHKJOHOMFCJ nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ODFHNMNNIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D3A0", Offset = "0x7B5B9A0", VA = "0x187B5D3A0")]
		internal object LKBIBKEPLCM(FHKJOHOMFCJ x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MLBJINNFDAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FHKJOHOMFCJ child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ODFHNMNNIKE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MLBJINNFDAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B59840", Offset = "0x7B57E40", VA = "0x187B59840")]
		internal object LGNIJGGBMBM((FHKJOHOMFCJ child, FHKJOHOMFCJ nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly JBBHIJHGEPM GGJADJBPBEE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly JBBHIJHGEPM DNCEFGKMPLO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly JBBHIJHGEPM BJAJIFOAHGO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly JBBHIJHGEPM NEAMJIMPKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private KLJACPCBIBJ GLLCNGPPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MIJCBDFLLCM EBBCJEKFBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private JHOFBNJCHGN GJDOLECHAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private HMHGMBFLDMI DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private OIAIGLOONMN HLKPCNLNBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PLCKOGMOKKF BHBOGOEHMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ALAAAJBIMIM IDEMOBALCHO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CA0", Offset = "0x9F32A0", VA = "0x1809F4CA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F4C90", Offset = "0x9F3290", VA = "0x1809F4C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LEKOKFJOJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> KGOCIDFOONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EAE0", Offset = "0x7B5D0E0", VA = "0x187B5EAE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B60410", Offset = "0x7B5EA10", VA = "0x187B60410", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> GMKPBCMEFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F970", Offset = "0x7B5DF70", VA = "0x187B5F970", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B61860", Offset = "0x7B5FE60", VA = "0x187B61860", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA, KGJNPMKJIIA> NFAKGCBAMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FBA0", Offset = "0x7B5E1A0", VA = "0x187B5FBA0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B61910", Offset = "0x7B5FF10", VA = "0x187B61910", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7B634C0", Offset = "0x7B61AC0", VA = "0x187B634C0")]
	public PBBABANPFCD(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F140", Offset = "0x7B5D740", VA = "0x187B5F140", Slot = "12")]
	public void ANJKPBDKBKO(GameObject CEKGANCAJPA, GMDBFGIIFFC GHDIGEKIHBA, EGONKLCENLD OHEIAKHGGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B61A50", Offset = "0x7B60050", VA = "0x187B61A50", Slot = "26")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B627F0", Offset = "0x7B60DF0", VA = "0x187B627F0", Slot = "22")]
	public bool OFABFJJKDFG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B608D0", Offset = "0x7B5EED0", VA = "0x187B608D0")]
	private void JCOEKOAFMEA(PKENAFNLEAO ILCDACLHNOJ, PKENAFNLEAO ONKEPDCFAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B615D0", Offset = "0x7B5FBD0", VA = "0x187B615D0")]
	private void MDJDLJABCJB(PKENAFNLEAO ILCDACLHNOJ, PKENAFNLEAO NAFICNAJMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B62D00", Offset = "0x7B61300", VA = "0x187B62D00")]
	private void PHMNFBNNEAF(PKENAFNLEAO ILCDACLHNOJ, PKENAFNLEAO NAFICNAJMHL, PKENAFNLEAO ONKEPDCFAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B62F60", Offset = "0x7B61560", VA = "0x187B62F60")]
	private void PIFLPHIAEMB(PKENAFNLEAO ILCDACLHNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "13")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5EE30", Offset = "0x7B5D430", VA = "0x187B5EE30", Slot = "14")]
	public void AMBIAOGNIIF(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "15")]
	public void OMFPKPKPLOB(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F810", Offset = "0x7B5DE10", VA = "0x187B5F810", Slot = "17")]
	public void CHFGABCDLEC(KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA NJNFNFBFADF, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F6D0", Offset = "0x7B5DCD0", VA = "0x187B5F6D0")]
	public void CHFGABCDLEC(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO NJNFNFBFADF, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FDE0", Offset = "0x7B5E3E0", VA = "0x187B5FDE0")]
	public void EOOOLAKNNAP(KGJNPMKJIIA OAECINPEBBO, float MJAHKCHDPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B5ECD0", Offset = "0x7B5D2D0", VA = "0x187B5ECD0", Slot = "18")]
	public void AKAEAHNKFMK(KGJNPMKJIIA HEKGNKKHMND, int GOPHADGGKNM, KGJNPMKJIIA HKFAMNCINCG, int NBNILDCJONJ, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B60360", Offset = "0x7B5E960", VA = "0x187B60360")]
	private float HPCJBOBOGAN(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO JHDAOHEONAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B5EB90", Offset = "0x7B5D190", VA = "0x187B5EB90")]
	public void AKAEAHNKFMK(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO JHDAOHEONAC, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, bool HDBFKADDDEF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B60AD0", Offset = "0x7B5F0D0", VA = "0x187B60AD0", Slot = "19")]
	public void JJEPLKJECKD(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B61C40", Offset = "0x7B60240", VA = "0x187B61C40", Slot = "16")]
	public void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> FMCCIABOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "20")]
	public JLPHBPPDHAI JHIANAELKAO(bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "21")]
	public JLPHBPPDHAI IFAKLKFBAIA(HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B61560", Offset = "0x7B5FB60", VA = "0x187B61560", Slot = "23")]
	public void LFKJPHLIEMM(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B617F0", Offset = "0x7B5FDF0", VA = "0x187B617F0", Slot = "24")]
	public void MHGECJEGKNL(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F3D0", Offset = "0x7B5D9D0", VA = "0x187B5F3D0", Slot = "25")]
	public void BDHOBHEBPMH(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B61E50", Offset = "0x7B60450", VA = "0x187B61E50")]
	private void NJNHIAMMBKP(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO JHDAOHEONAC, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, float MJAHKCHDPBO, bool HDBFKADDDEF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B60C40", Offset = "0x7B5F240", VA = "0x187B60C40")]
	private void JNICNGKBIJI(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO FAMAONKAFDI, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FA20", Offset = "0x7B5E020", VA = "0x187B5FA20")]
	private void DGIFILGEKAD(PKENAFNLEAO HMCFPGIFOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B619C0", Offset = "0x7B5FFC0", VA = "0x187B619C0")]
	[IteratorStateMachine(typeof(BGEODJEJKLG))]
	public IEnumerable<KGJNPMKJIIA> NBEPPKKEEPI(PKENAFNLEAO GOGGPBKDKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B62840", Offset = "0x7B60E40", VA = "0x187B62840")]
	internal KGJNPMKJIIA OPMKLMMJJEG(PKENAFNLEAO GOGGPBKDKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FC50", Offset = "0x7B5E250", VA = "0x187B5FC50")]
	internal PKENAFNLEAO EIOCNHFCNCF(KGJNPMKJIIA OAECINPEBBO)
	{
		return default(PKENAFNLEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B62260", Offset = "0x7B60860", VA = "0x187B62260")]
	private bool ODGHMKJPKDN(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B5EA80", Offset = "0x7B5D080", VA = "0x187B5EA80")]
	private bool AAMNJLNJDPA(FHKJOHOMFCJ MECICAJOHBD, [Out] KGJNPMKJIIA JHDAOHEONAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B62970", Offset = "0x7B60F70", VA = "0x187B62970")]
	private KGJNPMKJIIA OPMKLMMJJEG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B601D0", Offset = "0x7B5E7D0", VA = "0x187B601D0")]
	private KGJNPMKJIIA FPBMJJIAKCI(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B60000", Offset = "0x7B5E600", VA = "0x187B60000")]
	private KGJNPMKJIIA FNAMBHGNBPO(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B562A0", Offset = "0x7B548A0", VA = "0x187B562A0")]
	private static Guid LOELKJPBEAO(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F5E0", Offset = "0x7B5DBE0", VA = "0x187B5F5E0")]
	private string CCODCGDKILB(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B60740", Offset = "0x7B5ED40", VA = "0x187B60740")]
	private void JAAGLKJFNJO(KGJNPMKJIIA HMCFPGIFOED, KGJNPMKJIIA FAMAONKAFDI, RigidTransform LGKMMMDABOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F450", Offset = "0x7B5DA50", VA = "0x187B5F450")]
	private void CBABJCPBPHD(KGJNPMKJIIA FAMAONKAFDI, KGJNPMKJIIA HMCFPGIFOED, RigidTransform LGKMMMDABOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F3F0", Offset = "0x7B5D9F0", VA = "0x187B5F3F0")]
	private void BDPJJDCEPMM(KGJNPMKJIIA FKDPBFFLHKA, KGJNPMKJIIA HMCFPGIFOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FE70", Offset = "0x7B5E470", VA = "0x187B5FE70")]
	private void FBJHHBCMKAH(KGJNPMKJIIA HMCFPGIFOED, KGJNPMKJIIA JHDAOHEONAC, RigidTransform LGKMMMDABOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FA90", Offset = "0x7B5E090", VA = "0x187B5FA90")]
	private void DLBEDLCFLHC(PKENAFNLEAO GOGGPBKDKBC, KGJNPMKJIIA OAECINPEBBO, PKENAFNLEAO NAFICNAJMHL, PKENAFNLEAO ONKEPDCFAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B604C0", Offset = "0x7B5EAC0", VA = "0x187B604C0")]
	private void INELCBADLIG(PKENAFNLEAO GOGGPBKDKBC, KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA ANIIDMDIGEL, KGJNPMKJIIA CKMMPPDMABF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NPKPPLHNIDB
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MAJBDMLKIJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AINJBKKEAIL container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MAJBDMLKIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B59790", Offset = "0x7B57D90", VA = "0x187B59790")]
		internal PBBABANPFCD GALEJCAFIPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B5D1D0", Offset = "0x7B5B7D0", VA = "0x187B5D1D0")]
	public static void KCIDEFBNJAG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B5D350", Offset = "0x7B5B950", VA = "0x187B5D350")]
	public static void KFBNFICJJPH(AINJBKKEAIL NELIKBMJKPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FOBPKODMDJG : KLOADKCPJHM, NALCGEOCDAO
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly PBBABANPFCD AGINJBNDJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HJHBCOKCHDP BLHGDGOHGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly AHEJCECPAPD DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly OLOLIIEIDMJ[] BEDIEIBMOAJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KGJNPMKJIIA DIKCMBOKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B53DF0", Offset = "0x7B523F0", VA = "0x187B53DF0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KGJNPMKJIIA IKAHKCFCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B538C0", Offset = "0x7B51EC0", VA = "0x187B538C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 DLCDCKGOJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7B52990", Offset = "0x7B50F90", VA = "0x187B52990", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion HELDODPPOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B53980", Offset = "0x7B51F80", VA = "0x187B53980", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool ILPDIFJOOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7B52BA0", Offset = "0x7B511A0", VA = "0x187B52BA0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<KGJNPMKJIIA> AOODDHOINDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B533E0", Offset = "0x7B519E0", VA = "0x187B533E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool MJJEAGMAOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC177F0", Offset = "0xC15DF0", VA = "0x180C177F0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC4C130", Offset = "0xC4A730", VA = "0x180C4C130", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B54000", Offset = "0x7B52600", VA = "0x187B54000", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject ACLMMAOCLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7B53D00", Offset = "0x7B52300", VA = "0x187B53D00", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7B53D20", Offset = "0x7B52320", VA = "0x187B53D20", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid DAKAIKDKNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7B53E50", Offset = "0x7B52450", VA = "0x187B53E50", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HLCFDICAKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7B53F30", Offset = "0x7B52530", VA = "0x187B53F30", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DOAKLKNBOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool KMMJMFIFKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7B528E0", Offset = "0x7B50EE0", VA = "0x187B528E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event NIGKAAIBONN GDBKOPGIMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7B53860", Offset = "0x7B51E60", VA = "0x187B53860", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B52930", Offset = "0x7B50F30", VA = "0x187B52930", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NIGKAAIBONN COPNMFMFJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7B52B40", Offset = "0x7B51140", VA = "0x187B52B40", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7B53170", Offset = "0x7B51770", VA = "0x187B53170", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NIGKAAIBONN CLBOCEOOAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7B53A60", Offset = "0x7B52060", VA = "0x187B53A60", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7B52AE0", Offset = "0x7B510E0", VA = "0x187B52AE0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event FBEGKNIFEEB LBKLFLHJGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B536F0", Offset = "0x7B51CF0", VA = "0x187B536F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B53AC0", Offset = "0x7B520C0", VA = "0x187B53AC0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B53C00", Offset = "0x7B52200", VA = "0x187B53C00")]
	public FOBPKODMDJG(PKENAFNLEAO DCOBGODCAEM, RigidbodyEx DPBHNMFBAMI, HJHBCOKCHDP BLHGDGOHGFH, OLOLIIEIDMJ[] BEDIEIBMOAJ, AHEJCECPAPD DHJEDIPMPLO, HAEKELLPJAC AGINJBNDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B539E0", Offset = "0x7B51FE0", VA = "0x187B539E0", Slot = "19")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "21")]
	public void HHHNHJPFGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x78ABEB0", Offset = "0x78AA4B0", VA = "0x1878ABEB0", Slot = "22")]
	public void CNLGGHFAMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B53790", Offset = "0x7B51D90", VA = "0x187B53790", Slot = "20")]
	public void JDIKNMDACEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7B531D0", Offset = "0x7B517D0", VA = "0x187B531D0", Slot = "25")]
	public void IGIHFOHFFKB(int DCKHPKBNAHB, KGJNPMKJIIA HKFAMNCINCG, int JFAHNBMPGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7B52200", Offset = "0x7B50800", VA = "0x187B52200", Slot = "26")]
	public void ACMIJCNLBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7B53410", Offset = "0x7B51A10", VA = "0x187B53410", Slot = "27")]
	public void INIADDEOGCK(int DCKHPKBNAHB, KGJNPMKJIIA HEKGNKKHMND, int GHHMMIAAMBI, [Optional] Vector3? FDLKFNIKBIK, [Optional] Quaternion? EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B537E0", Offset = "0x7B51DE0", VA = "0x187B537E0", Slot = "28")]
	public void JEFNMAOFAPJ(KGJNPMKJIIA HEKGNKKHMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B522D0", Offset = "0x7B508D0", VA = "0x187B522D0", Slot = "31")]
	public void BBLMKFMBJEC(Vector3 JGAGMHABFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B52E60", Offset = "0x7B51460", VA = "0x187B52E60", Slot = "29")]
	public void HEPFHHFIKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B526E0", Offset = "0x7B50CE0", VA = "0x187B526E0", Slot = "30")]
	public void BEJJGDDMNPL(int OHHMJGCBCKD, Vector3 HNHGJPFCFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B52D90", Offset = "0x7B51390", VA = "0x187B52D90", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int DCKHPKBNAHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B52C60", Offset = "0x7B51260", VA = "0x187B52C60", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int DCKHPKBNAHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xBF5270", Offset = "0xBF3870", VA = "0x180BF5270", Slot = "42")]
	public Color GetConnectionSlotColor(int DCKHPKBNAHB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B529F0", Offset = "0x7B50FF0", VA = "0x187B529F0", Slot = "43")]
	public bool CanConnectTo(int DCKHPKBNAHB, KGJNPMKJIIA PKOBDBDFJDH, int MFGPLFMGPAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "44")]
	public void ParentChanged(int DCKHPKBNAHB, KGJNPMKJIIA HLHOBMFDMEH, int OHFINMJADPB, Vector3 MKLDCPIGJAH, Quaternion CKPBCMANCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "45")]
	public void ChildAdded(int DCKHPKBNAHB, KGJNPMKJIIA EFPDNAFKIKI, int KOKLNGICLKB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "46")]
	public void ChildRemoved(int DCKHPKBNAHB, KGJNPMKJIIA GGGJPOKBGDE, int JGFEALFMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "47")]
	public void ConnectionModified(int DCKHPKBNAHB, KGJNPMKJIIA HKFAMNCINCG, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B53B60", Offset = "0x7B52160", VA = "0x187B53B60", Slot = "48")]
	public void RootChanged(KGJNPMKJIIA IOMLMEIBDMC, KGJNPMKJIIA GMAPFDOKMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B52A90", Offset = "0x7B51090", VA = "0x187B52A90", Slot = "23")]
	public void DFFIMHGDEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B53A10", Offset = "0x7B52010", VA = "0x187B53A10", Slot = "24")]
	public void OEHLEAOCAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7B52C10", Offset = "0x7B51210", VA = "0x187B52C10")]
	private void GJDAKHHOFGC(bool MDLOOCDELDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(CCJNJBAAKAD), new string[] { })]
public class PICAOOPPNAI : CCJNJBAAKAD, KBDPBLKCNPK, FGICIDPFKIB
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BKLGIGJEFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BKLGIGJEFFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private MBIJHFNKOKE JDPKJPILGNF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object COLECDGBHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7B638D0", Offset = "0x7B61ED0", VA = "0x187B638D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7B63960", Offset = "0x7B61F60", VA = "0x187B63960", Slot = "5")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1142790", Offset = "0x1140D90", VA = "0x181142790", Slot = "6")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PICAOOPPNAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(HAEKELLPJAC), new string[] { "Ignore", "Mock" })]
public class COPFPLINDCF : HAEKELLPJAC, MMMIGLKPHHG
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LEKOKFJOJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> KGOCIDFOONL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F700", Offset = "0x7B4DD00", VA = "0x187B4F700", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F910", Offset = "0x7B4DF10", VA = "0x187B4F910", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> GMKPBCMEFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F7B0", Offset = "0x7B4DDB0", VA = "0x187B4F7B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F9C0", Offset = "0x7B4DFC0", VA = "0x187B4F9C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA, KGJNPMKJIIA> NFAKGCBAMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F860", Offset = "0x7B4DE60", VA = "0x187B4F860", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B4FA70", Offset = "0x7B4E070", VA = "0x187B4FA70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "26")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "12")]
	public void ANJKPBDKBKO(GameObject CEKGANCAJPA, GMDBFGIIFFC GHDIGEKIHBA, EGONKLCENLD FJLMGGKGAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "13")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "14")]
	public void AMBIAOGNIIF(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "15")]
	public void OMFPKPKPLOB(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "16")]
	public void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> FMCCIABOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "17")]
	public void CHFGABCDLEC(KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA NJNFNFBFADF, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "18")]
	public void AKAEAHNKFMK(KGJNPMKJIIA OAECINPEBBO, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "19")]
	public void JJEPLKJECKD(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "20")]
	public JLPHBPPDHAI JHIANAELKAO(bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "21")]
	public JLPHBPPDHAI IFAKLKFBAIA(HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "22")]
	public bool OFABFJJKDFG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "23")]
	public void LFKJPHLIEMM(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "24")]
	public void MHGECJEGKNL(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "25")]
	public void BDHOBHEBPMH(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public COPFPLINDCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KGJNPMKJIIA : NALCGEOCDAO, IEquatable<KGJNPMKJIIA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NALCGEOCDAO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KGJNPMKJIIA DIKCMBOKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject ACLMMAOCLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid DAKAIKDKNDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int HLCFDICAKJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DOAKLKNBOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int DCKHPKBNAHB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int DCKHPKBNAHB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int DCKHPKBNAHB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int DCKHPKBNAHB, KGJNPMKJIIA PKOBDBDFJDH, int JLBDCAHEGFC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int DCKHPKBNAHB, KGJNPMKJIIA HLHOBMFDMEH, int OHFINMJADPB, Vector3 MKLDCPIGJAH, Quaternion CKPBCMANCNO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int DCKHPKBNAHB, KGJNPMKJIIA EFPDNAFKIKI, int KOKLNGICLKB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int DCKHPKBNAHB, KGJNPMKJIIA GGGJPOKBGDE, int JGFEALFMLMD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int DCKHPKBNAHB, KGJNPMKJIIA HKFAMNCINCG, int DOLFIDPOHID, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(KGJNPMKJIIA IOMLMEIBDMC, KGJNPMKJIIA GMAPFDOKMHL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HAEKELLPJAC : MMMIGLKPHHG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool LEKOKFJOJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KGJNPMKJIIA, KGJNPMKJIIA> KGOCIDFOONL;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<KGJNPMKJIIA, KGJNPMKJIIA> GMKPBCMEFDE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<KGJNPMKJIIA, KGJNPMKJIIA, KGJNPMKJIIA> NFAKGCBAMFP;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ANJKPBDKBKO(GameObject CEKGANCAJPA, GMDBFGIIFFC GHDIGEKIHBA, EGONKLCENLD FEDKNCIDEOI);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IEKHBJGOAKB();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMBIAOGNIIF(KGJNPMKJIIA OAECINPEBBO);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OMFPKPKPLOB(KGJNPMKJIIA OAECINPEBBO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> FMCCIABOIAA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CHFGABCDLEC(KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA NJNFNFBFADF, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AKAEAHNKFMK(KGJNPMKJIIA OAECINPEBBO, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JJEPLKJECKD(KGJNPMKJIIA OAECINPEBBO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JLPHBPPDHAI JHIANAELKAO(bool BPJLOCGBNMG);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JLPHBPPDHAI IFAKLKFBAIA(HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OFABFJJKDFG(FHKJOHOMFCJ MECICAJOHBD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LFKJPHLIEMM(JLPHBPPDHAI NOKCJFMDPME);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MHGECJEGKNL(JLPHBPPDHAI NOKCJFMDPME);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BDHOBHEBPMH(JLPHBPPDHAI NOKCJFMDPME);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HMHGMBFLDMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CHECBKFCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KGJNPMKJIIA FNAMBHGNBPO(int EBNHDKCINFK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KGJNPMKJIIA FPBMJJIAKCI(Guid JOEDKMGHBFA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BEFNIFKHOPH(KGJNPMKJIIA OAECINPEBBO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OFLFNGHAMAD();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDDKMLAHBPE(KGJNPMKJIIA BLHGDGOHGFH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface AHEJCECPAPD
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMMJMFIFKBB(HJHBCOKCHDP BLHGDGOHGFH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNOBEGAKHDK(HJHBCOKCHDP BLHGDGOHGFH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string EBMOMOKCHOK(HJHBCOKCHDP BLHGDGOHGFH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid FIFDPJDKCDJ(HJHBCOKCHDP BLHGDGOHGFH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CFKCDEBMJNN(HJHBCOKCHDP BLHGDGOHGFH);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHKCOPLKLEJ(HJHBCOKCHDP BLHGDGOHGFH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void NIGKAAIBONN(KGJNPMKJIIA HEKGNKKHMND, int BNCAJCFDLHD, KGJNPMKJIIA HKFAMNCINCG, int FCGFLIFKIFK, [Optional] Vector3? FDLKFNIKBIK, [Optional] Quaternion? EABCELBPDPO);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void FBEGKNIFEEB(KGJNPMKJIIA IOMLMEIBDMC, KGJNPMKJIIA GMAPFDOKMHL);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HJHBCOKCHDP : KGJNPMKJIIA, NALCGEOCDAO, IEquatable<KGJNPMKJIIA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KLOADKCPJHM : NALCGEOCDAO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KGJNPMKJIIA IKAHKCFCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<KGJNPMKJIIA> AOODDHOINDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 DLCDCKGOJJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion HELDODPPOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool ILPDIFJOOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool MJJEAGMAOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event NIGKAAIBONN GDBKOPGIMFE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event NIGKAAIBONN COPNMFMFJEN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NIGKAAIBONN CLBOCEOOAJB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event FBEGKNIFEEB LBKLFLHJGBE;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LLGFJHIIOAB();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JDIKNMDACEI();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HHHNHJPFGBH();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CNLGGHFAMOH();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DFFIMHGDEGN();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OEHLEAOCAGI();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IGIHFOHFFKB(int DCKHPKBNAHB, KGJNPMKJIIA HKFAMNCINCG, int JFAHNBMPGPB);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ACMIJCNLBEF();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void INIADDEOGCK(int DCKHPKBNAHB, KGJNPMKJIIA HEKGNKKHMND, int GHHMMIAAMBI, [Optional] Vector3? FDLKFNIKBIK, [Optional] Quaternion? EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JEFNMAOFAPJ(KGJNPMKJIIA HEKGNKKHMND);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HEPFHHFIKGG();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BEJJGDDMNPL(int OHHMJGCBCKD, Vector3 HNHGJPFCFDL);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BBLMKFMBJEC(Vector3 JGAGMHABFEO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OLOLIIEIDMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 GNFKNNGOKOP
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
public interface GMDBFGIIFFC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool KILMCEKGICN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	GCHDFMGBKEJ HJEFIMHLGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, GMDBFGIIFFC
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
			[Cpp2IlInjected.Address(RVA = "0xAB6E90", Offset = "0xAB5490", VA = "0x180AB6E90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public GCHDFMGBKEJ LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B4FB20", Offset = "0x7B4E120", VA = "0x187B4FB20")]
		public static ConnectableConfigData KIGBJCOFDAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B4FBE0", Offset = "0x7B4E1E0", VA = "0x187B4FBE0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual FFHDEDFHGKP, bool BLHDDBKEJJJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OMPJHADMDBG : IEquatable<OMPJHADMDBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public KGJNPMKJIIA OAECINPEBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int LKOLHBGNLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int DOLFIDPOHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 FDLKFNIKBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion EABCELBPDPO;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B5DB00", Offset = "0x7B5C100", VA = "0x187B5DB00")]
	public OMPJHADMDBG(KGJNPMKJIIA OAECINPEBBO, int LKOLHBGNLLI, int DOLFIDPOHID, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7B5DBE0", Offset = "0x7B5C1E0", VA = "0x187B5DBE0")]
	public OMPJHADMDBG(KGJNPMKJIIA OAECINPEBBO, int LKOLHBGNLLI, int DOLFIDPOHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7B5DB60", Offset = "0x7B5C160", VA = "0x187B5DB60")]
	public OMPJHADMDBG(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7B5D690", Offset = "0x7B5BC90", VA = "0x187B5D690", Slot = "4")]
	public bool Equals(OMPJHADMDBG MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7B5D740", Offset = "0x7B5BD40", VA = "0x187B5D740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class PEHEEPPKBOM : BKFFNCAMMEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform KOOMPFGMBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private GCHDFMGBKEJ ONIONKMJCDK;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x753CDF0", Offset = "0x753B3F0", VA = "0x18753CDF0", Slot = "4")]
	public void ANJKPBDKBKO(Transform KOOMPFGMBLG, GCHDFMGBKEJ ONIONKMJCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7B63790", Offset = "0x7B61D90", VA = "0x187B63790", Slot = "5")]
	public GCHDFMGBKEJ KFOLADHCLIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7B63860", Offset = "0x7B61E60", VA = "0x187B63860", Slot = "6")]
	public void LCHNIHMIAOB(GCHDFMGBKEJ BEOKGAIKNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PEHEEPPKBOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class NLOLJJFHFJL : IDisposable, MPDKCOBOEOI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FJDMMPFOFGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public KGJNPMKJIIA oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KGJNPMKJIIA newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FJDMMPFOFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7B51D20", Offset = "0x7B50320", VA = "0x187B51D20")]
		internal bool DKNCELDKKPC(AFJPILNFMFC node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly ILMFMOKLFED CNPEJDKPHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NAGMEOCGGAJ GHEONPKHJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private PBKCFNFNJEG EIHAJEPOKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool BLHDDBKEJJJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly JBBHIJHGEPM DANCFBEKJGM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public AFJPILNFMFC FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BB80", Offset = "0x7B5A180", VA = "0x187B5BB80")]
	public bool JDECLKBDLHO([In] KMMPPAOLNAM APDBNIMCPID, bool DCGDGGMDIEE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B5C0", Offset = "0x7B59BC0", VA = "0x187B5B5C0")]
	private bool FFDCNBEOANF([In] KMMPPAOLNAM APDBNIMCPID, bool DCGDGGMDIEE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7B5D000", Offset = "0x7B5B600", VA = "0x187B5D000")]
	public NLOLJJFHFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A060", Offset = "0x7B58660", VA = "0x187B5A060", Slot = "5")]
	public void ANJKPBDKBKO(HAEKELLPJAC PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A030", Offset = "0x7B58630", VA = "0x187B5A030", Slot = "17")]
	public void AMBFCMFFILO(FFFPIELDNIL COLEJLDPDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A460", Offset = "0x7B58A60", VA = "0x187B5A460", Slot = "12")]
	public void CCOFEINHDEF(Func<KGJNPMKJIIA, bool> BJPKHNCADHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A470", Offset = "0x7B58A70", VA = "0x187B5A470")]
	private void CCOFEINHDEF(ILMFMOKLFED GOJJJBGJPAM, Func<KGJNPMKJIIA, bool> BJPKHNCADHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C000", Offset = "0x7B5A600", VA = "0x187B5C000", Slot = "11")]
	public void KFPOLEFIECO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A5A0", Offset = "0x7B58BA0", VA = "0x187B5A5A0", Slot = "8")]
	public bool CGPDDOBFGIB(KGJNPMKJIIA CLKOCOADKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7B5ACB0", Offset = "0x7B592B0", VA = "0x187B5ACB0")]
	private bool FDDKIMBNFJO(KGJNPMKJIIA CNCJAONEFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BB90", Offset = "0x7B5A190", VA = "0x187B5BB90")]
	private static bool GLPBBHNOHBH(KGJNPMKJIIA CNCJAONEFKE, ILMFMOKLFED DDMEELKFLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7B59C50", Offset = "0x7B58250", VA = "0x187B59C50")]
	private void ABFFKGFOIIA(Transform PJDGPDKLLOB, ILMFMOKLFED KCBLKELIMAJ, ILMFMOKLFED[] CCADDEKEMHH, KGJNPMKJIIA ALKFDFPDPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A7B0", Offset = "0x7B58DB0", VA = "0x187B5A7B0")]
	private OMPJHADMDBG DPHAGLMLPIP(Transform IKHNBIGOHCA, OMPJHADMDBG FPOOFGMJFHI)
	{
		return default(OMPJHADMDBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B3C0", Offset = "0x7B599C0", VA = "0x187B5B3C0")]
	private static bool FEIKGOIMOJL(ILMFMOKLFED DDMEELKFLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7B5AC50", Offset = "0x7B59250", VA = "0x187B5AC50", Slot = "9")]
	public bool EOOIBLGMGDK(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C1A0", Offset = "0x7B5A7A0", VA = "0x187B5C1A0")]
	private bool LHAHFAICMLC(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C020", Offset = "0x7B5A620", VA = "0x187B5C020")]
	private static void KMGGKMNFHEN(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO, ILMFMOKLFED GBCPONEKIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BDB0", Offset = "0x7B5A3B0", VA = "0x187B5BDB0")]
	private void JAAGLKJFNJO(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C3F0", Offset = "0x7B5A9F0", VA = "0x187B5C3F0")]
	private void LJOKFDGFFPD(ILMFMOKLFED GOJJJBGJPAM, KGJNPMKJIIA ANIIDMDIGEL, KGJNPMKJIIA CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C460", Offset = "0x7B5AA60", VA = "0x187B5C460")]
	private void LJOKFDGFFPD(KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA ANIIDMDIGEL, KGJNPMKJIIA CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BC40", Offset = "0x7B5A240", VA = "0x187B5BC40")]
	private void INELCBADLIG(KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA ANIIDMDIGEL, KGJNPMKJIIA CKMMPPDMABF, bool GOJAHFBBIEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BCB0", Offset = "0x7B5A2B0", VA = "0x187B5BCB0")]
	private void INELCBADLIG(ILMFMOKLFED KNNDNAPJIDP, KGJNPMKJIIA ALKFDFPDPEO, KGJNPMKJIIA GMAPFDOKMHL, bool GOJAHFBBIEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A340", Offset = "0x7B58940", VA = "0x187B5A340")]
	private void CBABJCPBPHD(KGJNPMKJIIA HMCFPGIFOED, int GHHMMIAAMBI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A1E0", Offset = "0x7B587E0", VA = "0x187B5A1E0")]
	private void BDPJJDCEPMM(AFJPILNFMFC JHDAOHEONAC, AFJPILNFMFC MIFGAFJFBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A650", Offset = "0x7B58C50", VA = "0x187B5A650", Slot = "18")]
	public KGJNPMKJIIA DCFAPKBHAIJ(KGJNPMKJIIA OAECINPEBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7B5CA70", Offset = "0x7B5B070", VA = "0x187B5CA70", Slot = "13")]
	public void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> BAFCOLIJPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A900", Offset = "0x7B58F00", VA = "0x187B5A900", Slot = "14")]
	public List<KGJNPMKJIIA> EKDDKIAJEPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A110", Offset = "0x7B58710", VA = "0x187B5A110")]
	protected AFJPILNFMFC ANOGKMJNPPE(AFJPILNFMFC GOJJJBGJPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A5B0", Offset = "0x7B58BB0", VA = "0x187B5A5B0")]
	protected ILMFMOKLFED[] DACNDBPGPLB(ILMFMOKLFED DDMEELKFLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7B5AB40", Offset = "0x7B59140", VA = "0x187B5AB40")]
	protected bool EOBBOBJPPBG(KGJNPMKJIIA OAECINPEBBO, [Out] ILMFMOKLFED GOJJJBGJPAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7B5CE10", Offset = "0x7B5B410", VA = "0x187B5CE10", Slot = "15")]
	public bool OHAGBJIFMMN(KGJNPMKJIIA OAECINPEBBO, [Out] OMPJHADMDBG AOIEEPOJLPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B580", Offset = "0x7B59B80", VA = "0x187B5B580")]
	protected ILMFMOKLFED FEKLJJLNDBG(OMPJHADMDBG MPAFKFEGGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BED0", Offset = "0x7B5A4D0", VA = "0x187B5BED0", Slot = "10")]
	public bool JODLAOJBBKP(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C4D0", Offset = "0x7B5AAD0", VA = "0x187B5C4D0")]
	private bool MNNECBGLJMG(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BF30", Offset = "0x7B5A530", VA = "0x187B5BF30")]
	private static bool KDIGJDKFPMK(ILMFMOKLFED ANLDIJJMHIN, OMPJHADMDBG DOGAEAFCEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BB80", Offset = "0x7B5A180", VA = "0x187B5BB80", Slot = "7")]
	private bool FNHIDHABKEH([In] KMMPPAOLNAM APDBNIMCPID, bool DCGDGGMDIEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class DOPHNNLKEHE : HAEKELLPJAC, MMMIGLKPHHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly AINJBKKEAIL NELIKBMJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly PBKCFNFNJEG EIHAJEPOKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly FKIDMBFCFFO JDDEPBEICGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly HGOJGPOGIKJ NLEKOAFJAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly MPDKCOBOEOI NOKCJFMDPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal NJBGDIJBDMG DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal DGLLIBDCCMB NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal NAGMEOCGGAJ NFONPELDILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool BLHDDBKEJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool NKFIACAHNOL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool OJIKKLEMGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xBFD110", Offset = "0xBFB710", VA = "0x180BFD110")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1266F20", Offset = "0x1265520", VA = "0x181266F20")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1132380", Offset = "0x1130980", VA = "0x181132380", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x25A98C0", Offset = "0x25A7EC0", VA = "0x1825A98C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool LEKOKFJOJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> KGOCIDFOONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7B4FC30", Offset = "0x7B4E230", VA = "0x187B4FC30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7B508F0", Offset = "0x7B4EEF0", VA = "0x187B508F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> GMKPBCMEFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B50830", Offset = "0x7B4EE30", VA = "0x187B50830", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B511A0", Offset = "0x7B4F7A0", VA = "0x187B511A0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA, KGJNPMKJIIA> NFAKGCBAMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7B50890", Offset = "0x7B4EE90", VA = "0x187B50890", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7B51310", Offset = "0x7B4F910", VA = "0x187B51310", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7B51930", Offset = "0x7B4FF30", VA = "0x187B51930")]
	public DOPHNNLKEHE(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7B4FDF0", Offset = "0x7B4E3F0", VA = "0x187B4FDF0", Slot = "12")]
	public void ANJKPBDKBKO(GameObject CEKGANCAJPA, GMDBFGIIFFC GHDIGEKIHBA, EGONKLCENLD FEDKNCIDEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7B51370", Offset = "0x7B4F970", VA = "0x187B51370", Slot = "26")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7B50950", Offset = "0x7B4EF50", VA = "0x187B50950", Slot = "13")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7B4FDD0", Offset = "0x7B4E3D0", VA = "0x187B4FDD0", Slot = "14")]
	public void AMBIAOGNIIF(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7B50ED0", Offset = "0x7B4F4D0", VA = "0x187B50ED0", Slot = "15")]
	public void OMFPKPKPLOB(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7B51540", Offset = "0x7B4FB40", VA = "0x187B51540", Slot = "22")]
	public bool OFABFJJKDFG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7B51200", Offset = "0x7B4F800", VA = "0x187B51200")]
	internal bool MNNECBGLJMG([In] KMMPPAOLNAM APDBNIMCPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7B517E0", Offset = "0x7B4FDE0", VA = "0x187B517E0")]
	internal bool PPAJOOFBJLK([In] KMMPPAOLNAM APDBNIMCPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7B50440", Offset = "0x7B4EA40", VA = "0x187B50440")]
	internal void BHJAKOHDNEM(KGJNPMKJIIA OAECINPEBBO, int IJELAKPHHGP, bool DCGDGGMDIEE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7B50ED0", Offset = "0x7B4F4D0", VA = "0x187B50ED0")]
	internal bool LFABHOHGNOK(KGJNPMKJIIA PIPANKJNIHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7B50FC0", Offset = "0x7B4F5C0", VA = "0x187B50FC0")]
	internal bool MBBAHLLMNKE(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7B51440", Offset = "0x7B4FA40", VA = "0x187B51440", Slot = "16")]
	public void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> FMCCIABOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7B50620", Offset = "0x7B4EC20", VA = "0x187B50620", Slot = "17")]
	public void CHFGABCDLEC(KGJNPMKJIIA APNDBHICMDC, KGJNPMKJIIA NJNFNFBFADF, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7B4FC90", Offset = "0x7B4E290", VA = "0x187B4FC90", Slot = "18")]
	public void AKAEAHNKFMK(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7B50D00", Offset = "0x7B4F300", VA = "0x187B50D00", Slot = "19")]
	public void JJEPLKJECKD(KGJNPMKJIIA JDEBBMOCGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7B51590", Offset = "0x7B4FB90", VA = "0x187B51590")]
	public void PMFPDNNHHIP([Optional] AIPAHMNCJKP IFPPKLHLPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7B50F30", Offset = "0x7B4F530", VA = "0x187B50F30", Slot = "23")]
	public void LFKJPHLIEMM(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7B50B80", Offset = "0x7B4F180", VA = "0x187B50B80", Slot = "20")]
	public JLPHBPPDHAI JHIANAELKAO(bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7B509D0", Offset = "0x7B4EFD0", VA = "0x187B509D0", Slot = "21")]
	public JLPHBPPDHAI IFAKLKFBAIA(HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7B50400", Offset = "0x7B4EA00", VA = "0x187B50400", Slot = "25")]
	public void BDHOBHEBPMH(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B510F0", Offset = "0x7B4F6F0", VA = "0x187B510F0", Slot = "24")]
	public void MHGECJEGKNL(JLPHBPPDHAI NOKCJFMDPME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class PBKCFNFNJEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly KICNHCAEGMA<KGJNPMKJIIA, KGJNPMKJIIA> KGOCIDFOONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly KICNHCAEGMA<KGJNPMKJIIA, KGJNPMKJIIA> GMKPBCMEFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly MOHJIJKGENJ<KGJNPMKJIIA, KGJNPMKJIIA, KGJNPMKJIIA> NFAKGCBAMFP;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7B63670", Offset = "0x7B61C70", VA = "0x187B63670")]
	public PBKCFNFNJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	public void ANJKPBDKBKO(DOPHNNLKEHE PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7B63610", Offset = "0x7B61C10", VA = "0x187B63610")]
	public void JDDDAEADMOB(KGJNPMKJIIA JHDAOHEONAC, KGJNPMKJIIA HMCFPGIFOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7B63530", Offset = "0x7B61B30", VA = "0x187B63530")]
	public void BDMBLLKALMA(KGJNPMKJIIA JHDAOHEONAC, KGJNPMKJIIA HMCFPGIFOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7B63590", Offset = "0x7B61B90", VA = "0x187B63590")]
	public void GPDIFMPKHGD(KGJNPMKJIIA FKDPBFFLHKA, KGJNPMKJIIA FAMAONKAFDI, KGJNPMKJIIA HMCFPGIFOED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FKIDMBFCFFO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private DOPHNNLKEHE PAKPDHLKNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private DGLLIBDCCMB NODDAHEDIAD;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FKIDMBFCFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B51DE0", Offset = "0x7B503E0", VA = "0x187B51DE0")]
	public void ANJKPBDKBKO(DOPHNNLKEHE PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7B51F90", Offset = "0x7B50590", VA = "0x187B51F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7B521C0", Offset = "0x7B507C0", VA = "0x187B521C0")]
	private void KPGHIHLMLLF(AEMMHEJJEHA LFJPHGCMAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7B51F20", Offset = "0x7B50520", VA = "0x187B51F20")]
	private void BOFMJJJDNII(AIPAHMNCJKP FCIPMBBCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7B51FA0", Offset = "0x7B505A0", VA = "0x187B51FA0")]
	public void HJAMBHFKBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7B520B0", Offset = "0x7B506B0", VA = "0x187B520B0")]
	public void KNHCFHPBDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class OMJGJLBJLNK
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IPHPPMEBJID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AINJBKKEAIL container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IPHPPMEBJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7B582F0", Offset = "0x7B568F0", VA = "0x187B582F0")]
		internal DOPHNNLKEHE GALEJCAFIPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7B5D410", Offset = "0x7B5BA10", VA = "0x187B5D410")]
	public static void KCIDEFBNJAG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7B5D610", Offset = "0x7B5BC10", VA = "0x187B5D610")]
	public static void KFBNFICJJPH(AINJBKKEAIL NELIKBMJKPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class PBAFKNEDMKB : IDisposable, NAGMEOCGGAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, GCHDFMGBKEJ> OGGAHOEKPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FFFPIELDNIL GGJNEIPHJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private BKFFNCAMMEA MCPGCAOOHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private MPDKCOBOEOI NOKCJFMDPME;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker LPFECODGPCB;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7B5E9A0", Offset = "0x7B5CFA0", VA = "0x187B5E9A0")]
	public PBAFKNEDMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7B5DDF0", Offset = "0x7B5C3F0", VA = "0x187B5DDF0", Slot = "7")]
	public void ANJKPBDKBKO(MPDKCOBOEOI NOKCJFMDPME, BKFFNCAMMEA MCPGCAOOHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7B5E4F0", Offset = "0x7B5CAF0", VA = "0x187B5E4F0", Slot = "5")]
	public void IHCDDKGPLHB(AFJPILNFMFC JHFCBFNEHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7B5DC80", Offset = "0x7B5C280", VA = "0x187B5DC80", Slot = "9")]
	public void ACPJNFDKFHA(AFJPILNFMFC FGAOOFFBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5E330", Offset = "0x7B5C930", VA = "0x187B5E330", Slot = "8")]
	public void HHAGBNGFILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5DE30", Offset = "0x7B5C430", VA = "0x187B5DE30", Slot = "10")]
	public void FPAIGNFPNJH(AFJPILNFMFC JIIOPCFMGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5E790", Offset = "0x7B5CD90", VA = "0x187B5E790", Slot = "11")]
	public void KFGFAPMCHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5E180", Offset = "0x7B5C780", VA = "0x187B5E180")]
	private bool GLMNGAKOIDG(AFJPILNFMFC KLJKHLHNLGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class HGOJGPOGIKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct JIKFFNIDFBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly ILMFMOKLFED FCNLLBJPCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> CCFFMIEIJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly FHKJOHOMFCJ NOGAGCIANOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly FHKJOHOMFCJ ELIBIGDCALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool BPJLOCGBNMG;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool DHIAICGDGID
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7B587E0", Offset = "0x7B56DE0", VA = "0x187B587E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7B58C30", Offset = "0x7B57230", VA = "0x187B58C30")]
		public JIKFFNIDFBE(ILMFMOKLFED FCNLLBJPCOC, HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG, [Optional] FHKJOHOMFCJ NOGAGCIANOC, [Optional] FHKJOHOMFCJ ELIBIGDCALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7B58580", Offset = "0x7B56B80", VA = "0x187B58580")]
		public FHKJOHOMFCJ DFNAEDFOBIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B58720", Offset = "0x7B56D20", VA = "0x187B58720")]
		private FHKJOHOMFCJ EOMNMNJENOC([Out] FHKJOHOMFCJ LEDBPNNMKIG, [Out] FHKJOHOMFCJ MMMDIAFLLEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7B58360", Offset = "0x7B56960", VA = "0x187B58360")]
		private FHKJOHOMFCJ CDFGICCPBBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7B58AC0", Offset = "0x7B570C0", VA = "0x187B58AC0")]
		private void LFHDAANJDAN(FHKJOHOMFCJ HKPGFEDCDFH, FHKJOHOMFCJ FDPNKIOKBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7B58900", Offset = "0x7B56F00", VA = "0x187B58900")]
		private void JKDJGJDFDEP(FHKJOHOMFCJ LEDBPNNMKIG, FHKJOHOMFCJ MMMDIAFLLEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private DOPHNNLKEHE PAKPDHLKNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private MPDKCOBOEOI NOKCJFMDPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NAGMEOCGGAJ GHEONPKHJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private DGLLIBDCCMB NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool AKLCKNMCPIN;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool IEBIOFEFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7B559F0", Offset = "0x7B53FF0", VA = "0x187B559F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool OJIKKLEMGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7B561F0", Offset = "0x7B547F0", VA = "0x187B561F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7B561D0", Offset = "0x7B547D0", VA = "0x187B561D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7B54FA0", Offset = "0x7B535A0", VA = "0x187B54FA0")]
	public void ANJKPBDKBKO(DOPHNNLKEHE PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7B56060", Offset = "0x7B54660", VA = "0x187B56060")]
	public JLPHBPPDHAI JHIANAELKAO(bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7B55CD0", Offset = "0x7B542D0", VA = "0x187B55CD0")]
	public JLPHBPPDHAI IFAKLKFBAIA(HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7B56210", Offset = "0x7B54810", VA = "0x187B56210")]
	public void LFKJPHLIEMM(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7B562E0", Offset = "0x7B548E0", VA = "0x187B562E0")]
	public void MHGECJEGKNL(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7B55840", Offset = "0x7B53E40", VA = "0x187B55840")]
	public void FELJNIFNLCK(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7B55E70", Offset = "0x7B54470", VA = "0x187B55E70")]
	private void JBJIMPAFJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7B55610", Offset = "0x7B53C10", VA = "0x187B55610")]
	private FHKJOHOMFCJ EBMOBKFKFED(ILMFMOKLFED GOJJJBGJPAM, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7B56C90", Offset = "0x7B55290", VA = "0x187B56C90")]
	private static void OFJBMJOLFLF(ILMFMOKLFED GOJJJBGJPAM, bool BPJLOCGBNMG, FHKJOHOMFCJ MECICAJOHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7B55010", Offset = "0x7B53610", VA = "0x187B55010")]
	private void BGGDOGIBKMN(ILMFMOKLFED GOJJJBGJPAM, bool BPJLOCGBNMG, FHKJOHOMFCJ MECICAJOHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7B55580", Offset = "0x7B53B80", VA = "0x187B55580")]
	private FHKJOHOMFCJ COAGHNEPHCP(ILMFMOKLFED FCNLLBJPCOC, HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7B55A40", Offset = "0x7B54040", VA = "0x187B55A40")]
	private bool HCMGHFIFLDC(JLPHBPPDHAI AJBLPHIOOHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7B563A0", Offset = "0x7B549A0", VA = "0x187B563A0")]
	private bool ODGHMKJPKDN(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7B56380", Offset = "0x7B54980", VA = "0x187B56380")]
	private bool NIHBELLIFJH(JLPHBPPDHAI NOKCJFMDPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7B57550", Offset = "0x7B55B50", VA = "0x187B57550")]
	private static bool POAFOGAGKFG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7B56A00", Offset = "0x7B55000", VA = "0x187B56A00")]
	public static bool OFABFJJKDFG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7B57070", Offset = "0x7B55670", VA = "0x187B57070")]
	private KGJNPMKJIIA OPMKLMMJJEG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7B55870", Offset = "0x7B53E70", VA = "0x187B55870")]
	private KGJNPMKJIIA FNAMBHGNBPO(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7B573C0", Offset = "0x7B559C0", VA = "0x187B573C0")]
	private KGJNPMKJIIA PDNHMHEJGEB(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7B562A0", Offset = "0x7B548A0", VA = "0x187B562A0")]
	private static Guid LOELKJPBEAO(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7B55230", Offset = "0x7B53830", VA = "0x187B55230")]
	private string CCODCGDKILB(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7B56EE0", Offset = "0x7B554E0", VA = "0x187B56EE0")]
	private bool OKMKPEIAPEB(ILMFMOKLFED GOJJJBGJPAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7B55320", Offset = "0x7B53920", VA = "0x187B55320")]
	private static void CLDPMBOGJOJ(ILMFMOKLFED FCNLLBJPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public HGOJGPOGIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct KMMPPAOLNAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public KGJNPMKJIIA HMCFPGIFOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public KGJNPMKJIIA JHDAOHEONAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int GHHMMIAAMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int JFAHNBMPGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 FDLKFNIKBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion EABCELBPDPO;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public OMPJHADMDBG PCAJPDECIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7B58CD0", Offset = "0x7B572D0", VA = "0x187B58CD0")]
		get
		{
			return default(OMPJHADMDBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OMPJHADMDBG GIJALGGGOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7B58CA0", Offset = "0x7B572A0", VA = "0x187B58CA0")]
		get
		{
			return default(OMPJHADMDBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7B58D70", Offset = "0x7B57370", VA = "0x187B58D70")]
	public KMMPPAOLNAM(KGJNPMKJIIA HMCFPGIFOED, KGJNPMKJIIA JHDAOHEONAC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface MPDKCOBOEOI
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	AFJPILNFMFC FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANJKPBDKBKO(HAEKELLPJAC PAKPDHLKNJE);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDECLKBDLHO([In] KMMPPAOLNAM APDBNIMCPID, bool DCGDGGMDIEE = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CGPDDOBFGIB(KGJNPMKJIIA CLKOCOADKDB);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EOOIBLGMGDK(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JODLAOJBBKP(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFPOLEFIECO();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CCOFEINHDEF(Func<KGJNPMKJIIA, bool> BJPKHNCADHP);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> BAFCOLIJPBE);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<KGJNPMKJIIA> EKDDKIAJEPO();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OHAGBJIFMMN(KGJNPMKJIIA OAECINPEBBO, [Out] OMPJHADMDBG AOIEEPOJLPG);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AMBFCMFFILO(FFFPIELDNIL COLEJLDPDCO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool FFFPIELDNIL(AFJPILNFMFC GOJJJBGJPAM);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface AFJPILNFMFC
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KGJNPMKJIIA FNJBEKNFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AFJPILNFMFC LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OMPJHADMDBG OOLJAJNEDND
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EKINFJGDGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GCHDFMGBKEJ
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEBICEODLFH(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECGMLFHIDFD(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIBADKJIJLK(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHEOKAAEIGJ(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GCHDFMGBKEJ Instantiate(Transform KOOMPFGMBLG);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HMHHJKJOIHP();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface BKFFNCAMMEA
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANJKPBDKBKO(Transform KOOMPFGMBLG, GCHDFMGBKEJ ONIONKMJCDK);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GCHDFMGBKEJ KFOLADHCLIF();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCHNIHMIAOB(GCHDFMGBKEJ BEOKGAIKNCN);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NJBGDIJBDMG : HMHGMBFLDMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEDIGCEENCF();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLIPENJKIEG(Guid CJHMIILEEBE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface NAGMEOCGGAJ
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHCDDKGPLHB(AFJPILNFMFC JHFCBFNEHKP);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANJKPBDKBKO(MPDKCOBOEOI NOKCJFMDPME, BKFFNCAMMEA DGDMEHGDCHD);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHAGBNGFILH();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACPJNFDKFHA(AFJPILNFMFC FGAOOFFBEDC);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPAIGNFPNJH(AFJPILNFMFC JIIOPCFMGCK);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFGFAPMCHKC();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class ILMFMOKLFED : AFJPILNFMFC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CJJPLPFLCJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public OMPJHADMDBG nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public ILMFMOKLFED foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CJJPLPFLCJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F5C0", Offset = "0x7B4DBC0", VA = "0x187B4F5C0")]
		internal bool IMMAEKIPFBF(AFJPILNFMFC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private OMPJHADMDBG AOIEEPOJLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<ILMFMOKLFED> CKOCFIAIKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ILMFMOKLFED FOEJNPDDMEA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public OMPJHADMDBG OOLJAJNEDND
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1267840", Offset = "0x1265E40", VA = "0x181267840", Slot = "6")]
		get
		{
			return default(OMPJHADMDBG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1267210", Offset = "0x1265810", VA = "0x181267210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private ILMFMOKLFED JHDAOHEONAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B57DD0", Offset = "0x7B563D0", VA = "0x187B57DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public AFJPILNFMFC LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KGJNPMKJIIA FNJBEKNFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EKINFJGDGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B58230", Offset = "0x7B56830", VA = "0x187B58230", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LMGKHBPOFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B57A50", Offset = "0x7B56050", VA = "0x187B57A50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected ILMFMOKLFED KNNDNAPJIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B57930", Offset = "0x7B55F30", VA = "0x187B57930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7B58240", Offset = "0x7B56840", VA = "0x187B58240")]
	public ILMFMOKLFED(OMPJHADMDBG GKCMEHIPMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B57EB0", Offset = "0x7B564B0", VA = "0x187B57EB0")]
	public ILMFMOKLFED JHHBOOEOKAN(OMPJHADMDBG OHBKJPBDAFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B580B0", Offset = "0x7B566B0", VA = "0x187B580B0")]
	public ILMFMOKLFED OGACJCJBLKD(OMPJHADMDBG LGJDPFBOMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B57AA0", Offset = "0x7B560A0", VA = "0x187B57AA0")]
	public ILMFMOKLFED GNAALOCCJEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B57C80", Offset = "0x7B56280", VA = "0x187B57C80")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B58000", Offset = "0x7B56600", VA = "0x187B58000")]
	public ILMFMOKLFED KEDOMLCMECI(OMPJHADMDBG FAMAONKAFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7B577D0", Offset = "0x7B55DD0", VA = "0x187B577D0")]
	private static void AMBFCMFFILO(ILMFMOKLFED KJMKLBFBJEK, FFFPIELDNIL AOHGJNGCBBI, bool ECMEOAHDOMI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B577C0", Offset = "0x7B55DC0", VA = "0x187B577C0", Slot = "9")]
	public void AMBFCMFFILO(FFFPIELDNIL COLEJLDPDCO, bool GOJAHFBBIEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7B57950", Offset = "0x7B55F50", VA = "0x187B57950")]
	public static ILMFMOKLFED FEKLJJLNDBG(ILMFMOKLFED KJMKLBFBJEK, OMPJHADMDBG EAEGAHLKDDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface DGLLIBDCCMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IEBIOFEFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool CHECBKFCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<AEMMHEJJEHA> KPGHIHLMLLF;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<AIPAHMNCJKP> BOFMJJJDNII;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EEBICEODLFH(DOPHNNLKEHE PAKPDHLKNJE, EGONKLCENLD FJLMGGKGAOO);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHFGABCDLEC(KGJNPMKJIIA APNDBHICMDC, KGJNPMKJIIA NJNFNFBFADF, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AKAEAHNKFMK(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GCDCMBINAOF(JLPHBPPDHAI FNLMKKLNMCA, [Optional] AIPAHMNCJKP IFPPKLHLPGC);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IBKFCLIIFOL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B57760", Offset = "0x7B55D60", VA = "0x187B57760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B57720", Offset = "0x7B55D20", VA = "0x187B57720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B576D0", Offset = "0x7B55CD0", VA = "0x187B576D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class HCKCCIBMGNG : DGLLIBDCCMB, IDisposable, CFOOLLLNECM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private DOPHNNLKEHE PAKPDHLKNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private EGONKLCENLD FEDKNCIDEOI;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool IEBIOFEFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B545D0", Offset = "0x7B52BD0", VA = "0x187B545D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool CHECBKFCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B54760", Offset = "0x7B52D60", VA = "0x187B54760", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView EAKOCIPMAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B54280", Offset = "0x7B52880", VA = "0x187B54280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<AEMMHEJJEHA> KPGHIHLMLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B54630", Offset = "0x7B52C30", VA = "0x187B54630", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B547A0", Offset = "0x7B52DA0", VA = "0x187B547A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<AIPAHMNCJKP> BOFMJJJDNII
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B54320", Offset = "0x7B52920", VA = "0x187B54320", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B546C0", Offset = "0x7B52CC0", VA = "0x187B546C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7B54410", Offset = "0x7B52A10", VA = "0x187B54410", Slot = "10")]
	public void EEBICEODLFH(DOPHNNLKEHE PAKPDHLKNJE, EGONKLCENLD FEDKNCIDEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B543C0", Offset = "0x7B529C0", VA = "0x187B543C0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B54150", Offset = "0x7B52750", VA = "0x187B54150", Slot = "11")]
	public void CHFGABCDLEC(KGJNPMKJIIA APNDBHICMDC, KGJNPMKJIIA NJNFNFBFADF, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7B54020", Offset = "0x7B52620", VA = "0x187B54020", Slot = "12")]
	public void AKAEAHNKFMK(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7B544A0", Offset = "0x7B52AA0", VA = "0x187B544A0", Slot = "13")]
	public void GCDCMBINAOF(JLPHBPPDHAI FNLMKKLNMCA, [Optional] AIPAHMNCJKP IFPPKLHLPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7B54A70", Offset = "0x7B53070", VA = "0x187B54A70")]
	[NNJDEPHNONO]
	private void RpcMasterReparentNodes(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7B54870", Offset = "0x7B52E70", VA = "0x187B54870")]
	[NNJDEPHNONO]
	private void RpcMasterModifyNode(KGJNPMKJIIA APNDBHICMDC, KGJNPMKJIIA NJNFNFBFADF, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7B54E70", Offset = "0x7B53470", VA = "0x187B54E70")]
	[NNJDEPHNONO]
	private void RpcReparentNodes(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO, ADKOONPNFKJ MAJHNAOMFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7B54D80", Offset = "0x7B53380", VA = "0x187B54D80")]
	[NNJDEPHNONO]
	private void RpcModifyNode(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO, ADKOONPNFKJ MAJHNAOMFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7B54830", Offset = "0x7B52E30", VA = "0x187B54830")]
	[NNJDEPHNONO]
	private void RpcDeserializeConnectableGraph(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public HCKCCIBMGNG()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, GCHDFMGBKEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B58FD0", Offset = "0x7B575D0", VA = "0x187B58FD0", Slot = "4")]
		private void EJNKFEJFIDK(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B59150", Offset = "0x7B57750", VA = "0x187B59150", Slot = "5")]
		private void IOMADFNHCFK(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B593C0", Offset = "0x7B579C0", VA = "0x187B593C0", Slot = "6")]
		private void MLBLBGOANDA(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B58DE0", Offset = "0x7B573E0", VA = "0x187B58DE0", Slot = "7")]
		private void EBCBLJCBGGG(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B59580", Offset = "0x7B57B80", VA = "0x187B59580", Slot = "8")]
		private GCHDFMGBKEJ PLOIOGDCOHN(Transform KOOMPFGMBLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B59520", Offset = "0x7B57B20", VA = "0x187B59520", Slot = "9")]
		private void ONKCDGJLFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class IEKCPIAHFFN
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x389ADB0", Offset = "0x38993B0", VA = "0x18389ADB0")]
	public static NIBLMNJEPNB<T> NOGKGBMDBDP<T>(this AINJBKKEAIL NELIKBMJKPH)
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
